Imports System.Windows.Forms
Imports DevExpress.XtraBars.Localization
Imports DevExpress.XtraGrid.Localization
Imports DevExpress.XtraPivotGrid.Localization
Imports DevExpress.XtraCharts.Localization
Imports DevExpress.XtraPrinting.Localization
Imports DevExpress.XtraReports.Localization
Imports DevExpress.XtraEditors.Controls


Public Class frmMainX

    Private oAdmTablas As New AdmTablas
    Private REGISTRY_BASE_PATH As String = "EDR\conXion\"
    Private REGISTRY_PATH As String
    Private IDIOMA_ANTERIOR As Integer

    Private Sub Welcome()
        Dim fWelcome As New frmWelcome

        fWelcome.MdiParent = Me
        fWelcome.Show()

    End Sub

    Public Sub New()

        DevExpress.UserSkins.OfficeSkins.Register()
        DevExpress.UserSkins.BonusSkins.Register()


        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Try
            MODO_DEMO = True
            
            LeerINI()
            ObtenerNombreApp()
            ComprobarModoDemo()


            USUARIO_ACTUAL = LAST_USER
            LeerINIUsuario()

            REGISTRY_PATH = REGISTRY_BASE_PATH & Format(USUARIO_ACTUAL, "00000")
            IDIOMA_ANTERIOR = 0
            InicioGeneral()
            IDIOMA_ANTERIOR = IDIOMA_ACTUAL

            If SHOW_WELCOME Then
                Welcome()
            End If

        Catch ex As Exception
            TratarError(ex)
        End Try


    End Sub

    Private Sub ObtenerNombreApp()

        On Error Resume Next

        Dim sNombre As String
        Dim ds As DataSet
        Dim sSQL As String

        sNombre = "EDR conXion"

        sSQL = "SELECT TOP 1 FG_XTRNFO FROM CONFIG"
        oAdmTablas.ConnectionString = CONN_LOCAL
        ds = oAdmTablas.AbrirDataset(sSQL)

        With ds.Tables(0)
            If .Rows.Count > 0 Then
                sNombre = .Rows(0)(0)
            End If
        End With

        ds = Nothing

        If sNombre <> "" Then
            APP_NAME = sNombre
        End If

        Me.Text = sNombre

    End Sub

    Private Sub CrearSuperTips(ByRef oRibbon As DevExpress.XtraBars.Ribbon.RibbonControl)

        'On Error Resume Next

        Dim rPage As DevExpress.XtraBars.Ribbon.RibbonPage
        Dim rPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Dim oButton As DevExpress.XtraBars.BarItemLink
        Dim oTip As DevExpress.Utils.SuperToolTip
        Dim oTipTitle As DevExpress.Utils.ToolTipTitleItem
        Dim oTipDesc As DevExpress.Utils.ToolTipItem

        For Each rPage In oRibbon.Pages
            For Each rPageGroup In rPage.Groups
                For Each oButton In rPageGroup.ItemLinks

                    oTip = New DevExpress.Utils.SuperToolTip
                    oTipTitle = New DevExpress.Utils.ToolTipTitleItem
                    oTipDesc = New DevExpress.Utils.ToolTipItem

                    oTipTitle.Image = oButton.Glyph
                    oTipTitle.Text = oButton.Caption

                    oTipDesc.Text = oButton.Item.Description

                    oTip.Items.Add(oTipTitle)
                    oTip.Items.Add(oTipDesc)


                    oButton.Item.SuperTip = oTip
                Next
            Next
        Next

    End Sub

    Private Sub frmMainX_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'dxBars.SaveLayoutToRegistry()
        RibbonControl.Toolbar.SaveLayoutToRegistry(REGISTRY_PATH)
        dckManager.SaveLayoutToRegistry(REGISTRY_PATH)
    End Sub

    Private Sub frmMainX_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim fLogin As New frmLogin
        fLogin.ShowDialog()

        If USUARIO_ACTUAL >= 0 Then
            LeerINIUsuario()
            REGISTRY_PATH = REGISTRY_BASE_PATH & Format(USUARIO_ACTUAL, "00000")
            InicioGeneral()
            LocalizarDevExpress()
            stcUsuario.Caption = USUARIO_ACTUAL_NOMBRE
        Else
            Me.Close()
        End If

    End Sub

    Private Sub InicioGeneral()

        stcHora.Caption = System.DateTime.Now

        IniciarBarraHerramientas()

        If IDIOMA_ANTERIOR <> IDIOMA_ACTUAL Then
            LeerCadenas(IDIOMA_ACTUAL)
        End If

        LocalizarFormulario()
        SetSkin()

        oAdmTablas.ConnectionString = CONN_LOCAL
        CargarTree()
        CargarFavoritas()

        RibbonControl.Minimized = COLLAPSE_RIBBON
        CrearSuperTips(RibbonControl)
        EstablecerPermisos()

    End Sub

    Public Sub SetSkin()

        oLAF.LookAndFeel.SkinName = THEME_ACTUAL

    End Sub

    Private Sub IniciarBarraHerramientas()
        On Error Resume Next
        'dxBars.RestoreLayoutFromRegistry()
        RibbonControl.Toolbar.RestoreLayoutFromRegistry(REGISTRY_PATH)
        dckManager.RestoreLayoutFromRegistry(REGISTRY_PATH)

        btnVerPC.Down = pnlConsultas.Visibility <> DevExpress.XtraBars.Docking.DockVisibility.Hidden
        btnVerPF.Down = pnlFavoritas.Visibility <> DevExpress.XtraBars.Docking.DockVisibility.Hidden
    End Sub

    Private Sub AbrirEjecucionConsulta(ByVal nCodigoConsulta As Integer)

        If Not USUARIO_ACTUAL_PMS_EJECUTAR Then
            MensajeError(DescripcionCadena(Cadenas.CDN_GeneralSinPermisos))
            Exit Sub
        End If

        If ConsultaNoHabilitada(nCodigoConsulta) Then
            MensajeError(DescripcionCadena(Cadenas.CDN_GeneralSinPermisosConsulta))
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor

        Procesando(False, DescripcionCadena(Cadenas.CDN_GeneralAbriendoConsulta), DescripcionCadena(Cadenas.CDN_GeneralAbriendoConsultaTip))

        Dim fCons As New frmConsulta

        fCons.MdiParent = Me
        fCons.AbrirConsulta(nCodigoConsulta)

        If fCons.Tag = "InvalidPassword" Then
            fCons.Dispose()
        Else
            fCons.Show()
            mdiTabs.SelectedPage.Image = il16x16.Images(3)
        End If

        FinProcesando()

        Cursor = Cursors.Default

    End Sub

    Private Sub AbrirDisenoConsulta(ByVal nCodigoConsulta As Integer)

        If Not USUARIO_ACTUAL_PMS_DISENAR Then
            MensajeError(DescripcionCadena(Cadenas.CDN_GeneralSinPermisos))
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor

        Procesando(False, DescripcionCadena(Cadenas.CDN_GeneralAbriendoConsulta), DescripcionCadena(Cadenas.CDN_GeneralAbriendoConsultaTip))

        Dim fCons As New frmDisenoConsulta

        fCons.MdiParent = Me
        fCons.InicioGeneral()
        fCons.AbrirConsulta(nCodigoConsulta)

        fCons.Show()
        mdiTabs.SelectedPage.Image = il16x16.Images(3)

        FinProcesando()

        Cursor = Cursors.Default

    End Sub

    Private Sub AbrirExportacionConsulta(ByVal nCodigoConsulta As Integer)

        If Not USUARIO_ACTUAL_PMS_EXPORTAR Then
            MensajeError(DescripcionCadena(Cadenas.CDN_GeneralSinPermisos))
            Exit Sub
        End If

        Dim sDescripcion As String
        Dim ds As DataSet
        Dim sSQL As String

        sSQL = "SELECT      CV_NOMBRE " & _
               "FROM        CONVAR " & _
               "WHERE       CV_CODCON = " & nCodigoConsulta

        Try

            ds = oAdmTablas.AbrirDataset(sSQL)
            sDescripcion = ds.Tables(0).Rows(0)("CV_NOMBRE")
            ds.Dispose()

            Dim fExportar As New frmExportar(nCodigoConsulta, sDescripcion)
            fExportar.ShowDialog()

            fExportar.Dispose()

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub AbrirImportacionConsulta()

        If Not USUARIO_ACTUAL_PMS_IMPORTAR Then
            MensajeError(DescripcionCadena(Cadenas.CDN_GeneralSinPermisos))
            Exit Sub
        End If

        Dim fImportar As New frmImportar
        fImportar.ShowDialog()

        fImportar.Dispose()


    End Sub

    Private Sub AbrirEliminacionConsulta(ByVal nCodigoConsulta As Integer)

        If Not USUARIO_ACTUAL_PMS_ELIMINAR Then
            MensajeError(DescripcionCadena(Cadenas.CDN_GeneralSinPermisos))
            Exit Sub
        End If

        Dim sDescripcion As String
        Dim ds As DataSet
        Dim sSQL As String

        sSQL = "SELECT      CV_NOMBRE " & _
               "FROM        CONVAR " & _
               "WHERE       CV_CODCON = " & nCodigoConsulta

        Try

            ds = oAdmTablas.AbrirDataset(sSQL)
            sDescripcion = ds.Tables(0).Rows(0)("CV_NOMBRE")
            ds.Dispose()

            Dim fEliminar As New frmEliminarConsulta(nCodigoConsulta, sDescripcion)
            fEliminar.ShowDialog()
            fEliminar.Dispose()

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub NuevoDisenoConsulta()

        If Not USUARIO_ACTUAL_PMS_DISENAR Then
            MensajeError(DescripcionCadena(Cadenas.CDN_GeneralSinPermisos))
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor

        Dim fCons As New frmDisenoConsulta

        fCons.MdiParent = Me
        fCons.InicioGeneral()

        fCons.Show()
        mdiTabs.SelectedPage.Image = il16x16.Images(3)

        Cursor = Cursors.Default

    End Sub

    Public Sub CargarTree()

        On Error Resume Next

        Dim ds As System.Data.DataSet
        Dim sSQL As String
        Dim nodX As TreeNode
        Dim nodY As TreeNode
        Dim nodPadre As TreeNode
        Dim i As Int32

        Cursor = Cursors.WaitCursor

        ' CATEGORIAS
        sSQL = "SELECT      TG_CODCON, TG_DESCRI, TG_NUME01, TG_NUME02 " & _
               "FROM        TABGEN " & _
               "WHERE       TG_CODTAB = 3 " & _
               "AND         TG_CODCON <> 999999 " & _
               "ORDER BY    TG_NUME01, TG_DESCRI ASC "

        sSQL = sSQL & _
               "SELECT      CV_CODCON, CV_NOMBRE, CV_CATEGO " & _
               "FROM        CONVAR"

        ds = oAdmTablas.AbrirDataset(sSQL)
        tvMain.Nodes.Clear()

        nodX = New TreeNode
        nodX.Name = "nodRaiz"
        nodX.Text = DescripcionCadena(Cadenas.CDN_nodRaizConsultas)
        nodX.ImageIndex = 0
        tvMain.Nodes.Add(nodX)

        With ds.Tables(0)
            For i = 0 To .Rows.Count - 1
                nodX = New TreeNode

                nodX.Name = "C" & .Rows(i).Item("TG_CODCON").ToString
                nodX.Tag = "C" & .Rows(i).Item("TG_CODCON").ToString
                nodX.Text = .Rows(i).Item("TG_DESCRI").ToString
                nodX.ImageIndex = 1
                nodX.SelectedImageIndex = 1

                If .Rows(i).Item("TG_NUME01") = 0 Then
                    nodPadre = tvMain.Nodes("nodRaiz")
                Else
                    nodPadre = tvMain.Nodes.Find("C" & .Rows(i).Item("TG_NUME01").ToString, True)(0)
                End If

                nodPadre.Nodes.Add(nodX)
                'nodX.Name = nodX.Tag

                'tvMain.Nodes("nodRaiz").Nodes.Add(nodX)

            Next
        End With


        With ds.Tables(1)
            For i = 0 To .Rows.Count - 1
                nodX = New TreeNode
                nodX.Name = "K" & .Rows(i).Item("CV_CODCON").ToString
                nodX.Text = .Rows(i).Item("CV_NOMBRE").ToString
                nodX.ImageIndex = 3
                nodX.SelectedImageIndex = 3

                nodPadre = tvMain.Nodes.Find("C" & .Rows(i).Item("CV_CATEGO").ToString, True)(0)
                nodPadre.Nodes.Add(nodX)

            Next
        End With

        tvMain.ExpandAll()

        Cursor = Cursors.Default

    End Sub


    Private Sub tmrFechaHora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFechaHora.Tick
        stcHora.Caption = System.DateTime.Now
    End Sub

    Private Sub LocalizarDevExpress()

        If IDIOMA_ACTUAL <> IDIOMA_INGLES Then
            BarLocalizer.Active = New cBarsLocalizer()
            GridLocalizer.Active = New cGridLocalizer()
            PivotGridLocalizer.Active = New cPivotGridLocalizer()
            ChartLocalizer.Active = New cChartLocalizer()
            PreviewLocalizer.Active = New cPrintingLocalizer()
            BarLocalizer.Active = New cBarsLocalizer()
            Localizer.Active = New cEditorsLocalizer()
            ReportLocalizer.Active = New cReportsLocalizer()
        End If

    End Sub

    Private Sub LocalizarFormulario()

        btnPreferencias.Caption = DescripcionCadena(Cadenas.CDN_mnuArchivoPreferencias)
        btnOpcionesGenerales.Caption = DescripcionCadena(Cadenas.CDN_mnuArchivoOpcionesGlobales)
        btnAdministracionSeguridad.Caption = DescripcionCadena(Cadenas.CDN_mnuArchivoSeguridadUsuarios)
        btnConexiones.Caption = DescripcionCadena(Cadenas.CDN_mnuArchivoConexiones)
        btnSalir.Caption = DescripcionCadena(Cadenas.CDN_mnuArchivoSalir)

        mnuConsulta.Caption = DescripcionCadena(Cadenas.CDN_mnuConsulta)
        btnCrearConsulta.Caption = DescripcionCadena(Cadenas.CDN_mnuConsultaCrear)
        btnAbrirConsulta.Caption = DescripcionCadena(Cadenas.CDN_mnuConsultaAbrir)
        btnDisenarConsulta.Caption = DescripcionCadena(Cadenas.CDN_mnuConsultaDisenar)
        btnEliminarConsulta.Caption = DescripcionCadena(Cadenas.CDN_mnuEliminarConsulta)
        btnImportarConsulta.Caption = DescripcionCadena(Cadenas.CDN_mnuConsultaImportar)
        btnExportarConsulta.Caption = DescripcionCadena(Cadenas.CDN_mnuConsultaExportar)
        btnCategorias.Caption = DescripcionCadena(Cadenas.CDN_mnuConsultaCategorias)

        mnuVer.Caption = DescripcionCadena(Cadenas.CDN_mnuVer)
        btnVerPF.Caption = DescripcionCadena(Cadenas.CDN_mnuVerPanelFavoritas)
        btnVerPC.Caption = DescripcionCadena(Cadenas.CDN_mnuVerPanelConsultas)

        mnuVentanas.Caption = DescripcionCadena(Cadenas.CDN_mnuVentana)

        btnContenido.Caption = DescripcionCadena(Cadenas.CDN_mnuAyudaContenido)
        btnAbout.Caption = DescripcionCadena(Cadenas.CDN_mnuAyudaAcercaDe)

        stcStatus.Caption = DescripcionCadena(Cadenas.CDN_stcStatus)
        pnlFavoritas.Text = DescripcionCadena(Cadenas.CDN_pnlFavoritas)
        pnlConsultas.Text = DescripcionCadena(Cadenas.CDN_pnlConsultas)

        rpConsultas.Text = DescripcionCadena(Cadenas.CDN_rpConsultas)
        rpOtros.Text = DescripcionCadena(Cadenas.CDN_rpOtros)
        rpgAyuda.Text = DescripcionCadena(Cadenas.CDN_rpgAyuda)
        rpgConsultas.Text = DescripcionCadena(Cadenas.CDN_rpgComun)
        rpgOtros.Text = DescripcionCadena(Cadenas.CDN_rpOtros)
        rpgImportacion.Text = DescripcionCadena(Cadenas.CDN_rpgImportacion)
        rpgConfiguracion.Text = DescripcionCadena(Cadenas.CDN_mnuConfiguracion)
        mnuConfiguracion.Caption = DescripcionCadena(Cadenas.CDN_mnuConfiguracion)


        ' Descripciones

        btnCrearConsulta.Description = DescripcionCadena(Cadenas.CDN_Descripciones_NuevaConsulta)
        btnAbrirConsulta.Description = DescripcionCadena(Cadenas.CDN_Descripciones_AbrirConsulta)
        btnImportarConsulta.Description = DescripcionCadena(Cadenas.CDN_Descripciones_ImportarConsulta)
        btnExportarConsulta.Description = DescripcionCadena(Cadenas.CDN_Descripciones_ExportarConsulta)
        btnDisenarConsulta.Description = DescripcionCadena(Cadenas.CDN_Descripciones_DisenarConsulta)
        btnOpcionesGenerales.Description = DescripcionCadena(Cadenas.CDN_Descripciones_OpcionesGlobales)
        btnPreferencias.Description = DescripcionCadena(Cadenas.CDN_Descripciones_OpcionesUsuario)
        btnVerPC.Description = DescripcionCadena(Cadenas.CDN_Descripciones_VerPanelConsultas)
        btnVerPF.Description = DescripcionCadena(Cadenas.CDN_Descripciones_VerPanelFavoritas)
        mnuVentanas.Description = DescripcionCadena(Cadenas.CDN_Descripciones_Ventanas)
        btnAdministracionSeguridad.Description = DescripcionCadena(Cadenas.CDN_Descripciones_Seguridad)
        btnConexiones.Description = DescripcionCadena(Cadenas.CDN_Descripciones_Conexiones)
        btnCategorias.Description = DescripcionCadena(Cadenas.CDN_Descripciones_Categorias)
        mnuVer.Description = DescripcionCadena(Cadenas.CDN_Descripciones_Ver)
        btnContenido.Description = DescripcionCadena(Cadenas.CDN_Descripciones_Contenido)
        btnAbout.Description = DescripcionCadena(Cadenas.CDN_Descripciones_About)
        btnEliminarConsulta.Description = DescripcionCadena(Cadenas.CDN_Descripciones_Eliminar)


        ' Menu contextual
        btnAbrirContext.Caption = DescripcionCadena(Cadenas.CDN_mnuConsultaAbrir)
        btnDisenarContext.Caption = DescripcionCadena(Cadenas.CDN_mnuConsultaDisenar)
        btnExportarContext.Caption = DescripcionCadena(Cadenas.CDN_mnuConsultaExportar)
        btnAgregarFavoritasContext.Caption = DescripcionCadena(Cadenas.CDN_mnuAgregarFavoritas)
        btnEliminarContext.Caption = DescripcionCadena(Cadenas.CDN_mnuEliminarConsulta)

        ' Otros
        tvMain.Nodes("nodRaiz").Text = DescripcionCadena(Cadenas.CDN_nodRaizConsultas)
        lvFavoritas.Groups(0).Header = DescripcionCadena(Cadenas.CDN_GrupoListViewFavoritas)

    End Sub

    Private Sub tvMain_AfterCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMain.AfterCollapse
        If e.Node.Name.Substring(0, 1) = "C" Then
            e.Node.ImageIndex = 2
            e.Node.SelectedImageIndex = 2
        End If
    End Sub

    Private Sub tvMain_AfterExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMain.AfterExpand
        If e.Node.Name.Substring(0, 1) = "C" Then
            e.Node.ImageIndex = 1
            e.Node.SelectedImageIndex = 1
        End If
    End Sub

    Private Sub tvMain_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvMain.NodeMouseDoubleClick

        Dim sKey As String
        Dim nCodigoConsulta As Integer

        If e.Button = Windows.Forms.MouseButtons.Left Then
            sKey = e.Node.Name

            If sKey.Substring(0, 1) = "K" Then
                nCodigoConsulta = Val(sKey.Substring(1))
                AbrirEjecucionConsulta(nCodigoConsulta)
            End If

        End If
    End Sub

    Private Sub btnSalir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalir.ItemClick
        Application.Exit()
    End Sub

    Private Sub pnlConsultas_ClosedPanel(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking.DockPanelEventArgs) Handles pnlConsultas.ClosedPanel
        btnVerPC.Toggle()
    End Sub

    Private Sub btnVerPC_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVerPC.ItemClick
        If btnVerPC.Down Then
            pnlConsultas.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
        Else
            pnlConsultas.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        End If
    End Sub

    Private Sub pnlFavoritas_ClosedPanel(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking.DockPanelEventArgs) Handles pnlFavoritas.ClosedPanel
        btnVerPF.Toggle()
    End Sub

    Private Sub btnVerPF_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVerPF.ItemClick
        If btnVerPF.Down Then
            pnlFavoritas.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
        Else
            pnlFavoritas.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        End If
    End Sub

    Private Sub tvMain_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvMain.NodeMouseClick

        tvMain.SelectedNode = e.Node

        If e.Button = Windows.Forms.MouseButtons.Right Then
            If e.Node.Name.Substring(0, 1) = "K" Then
                popContext.ShowPopup(Control.MousePosition)
            End If
        End If

    End Sub

    Private Sub btnAbrirContext_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAbrirContext.ItemClick

        Dim nCodigoConsulta As Integer
        Dim nodX As TreeNode

        nodX = tvMain.SelectedNode

        If Not nodX Is Nothing Then
            nCodigoConsulta = Val(nodX.Name.Substring(1))

            If nCodigoConsulta > 0 Then
                AbrirEjecucionConsulta(nCodigoConsulta)
            End If
        End If

    End Sub

    Private Sub btnAbrirConsulta_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAbrirConsulta.ItemClick

        Dim nCodConsulta As Integer

        If Not USUARIO_ACTUAL_PMS_EJECUTAR Then
            MensajeError(DescripcionCadena(Cadenas.CDN_GeneralSinPermisos))
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        nCodConsulta = SeleccionarConsulta()
        Cursor = Cursors.Default

        If nCodConsulta > 0 Then
            AbrirEjecucionConsulta(nCodConsulta)
        End If

    End Sub

    Private Sub btnDisenarConsulta_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDisenarConsulta.ItemClick

        Dim nCodConsulta As Integer

        If Not USUARIO_ACTUAL_PMS_DISENAR Then
            MensajeError(DescripcionCadena(Cadenas.CDN_GeneralSinPermisos))
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        nCodConsulta = SeleccionarConsulta()
        Cursor = Cursors.Default

        If nCodConsulta > 0 Then
            AbrirDisenoConsulta(nCodConsulta)
        End If

    End Sub

    Private Sub btnAbout_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAbout.ItemClick
        frmAbout.ShowDialog()
    End Sub

    Private Sub btnConexiones_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConexiones.ItemClick

        If Not USUARIO_ACTUAL_PMS_CONEXIONES Then
            MensajeError(DescripcionCadena(Cadenas.CDN_GeneralSinPermisos))
            Exit Sub
        End If

        Dim fConns As New frmConexiones
        fConns.ShowDialog(Me)
        fConns.Dispose()

    End Sub

    Private Sub btnCategorias_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCategorias.ItemClick

        If Not USUARIO_ACTUAL_PMS_CATEGORIAS Then
            MensajeError(DescripcionCadena(Cadenas.CDN_GeneralSinPermisos))
            Exit Sub
        End If

        Dim fCategorias As New frmCategorias
        fCategorias.ShowDialog()
        fCategorias.Dispose()
        CargarTree()

    End Sub

    Private Sub btnPreferencias_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreferencias.ItemClick
        Dim fOpUsuario As New frmOpcionesUsuario

        fOpUsuario.ShowDialog()
        fOpUsuario.Dispose()

    End Sub

    Private Sub btnCrearConsulta_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCrearConsulta.ItemClick

        Dim nCantidad As Integer

        If MODO_DEMO Then
            nCantidad = CantidadConsultas()
            If nCantidad >= 3 Then
                MensajeError(DescripcionCadena(Cadenas.CDN_GeneralHasta3ConsultasModoDemo))
                Exit Sub
            End If
        End If

        NuevoDisenoConsulta()
    End Sub

    Private Sub btnDisenarContext_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDisenarContext.ItemClick

        Dim nCodigoConsulta As Integer
        Dim nodX As TreeNode

        nodX = tvMain.SelectedNode

        If Not nodX Is Nothing Then
            nCodigoConsulta = Val(nodX.Name.Substring(1))

            If nCodigoConsulta > 0 Then
                AbrirDisenoConsulta(nCodigoConsulta)
            End If
        End If

    End Sub


    Private Sub mnuConsulta_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuConsulta.ItemClick

        Dim nCodConsulta As Integer

        Cursor = Cursors.WaitCursor
        nCodConsulta = SeleccionarConsulta()
        Cursor = Cursors.Default

        If nCodConsulta > 0 Then
            AbrirEjecucionConsulta(nCodConsulta)
        End If

    End Sub

    Private Sub mnuConfiguracion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuConfiguracion.ItemClick
        Dim fOpUsuario As New frmOpcionesUsuario

        fOpUsuario.ShowDialog()
        fOpUsuario.Dispose()

    End Sub

    Private Sub CargarFavoritas()

        Dim sSQL As String
        Dim itmX As ListViewItem
        Dim ds As DataSet
        Dim i As Integer

        Try

            sSQL = "SELECT      FV_CODCON, CV_NOMBRE, CV_DESCRI " & _
                   "FROM        FAVORI " & _
                   "INNER JOIN  CONVAR " & _
                   "ON          FV_CODCON = CV_CODCON " & _
                   "WHERE       FV_CODUSU = " & USUARIO_ACTUAL & " " & _
                   "ORDER BY    CV_NOMBRE ASC"

            ds = oAdmTablas.AbrirDataset(sSQL)
            lvFavoritas.Items.Clear()

            With ds.Tables(0)

                For i = 0 To .Rows.Count - 1

                    itmX = New ListViewItem

                    itmX.Name = "K" & .Rows(i).Item("FV_CODCON").ToString
                    itmX.Text = .Rows(i).Item("CV_NOMBRE").ToString
                    itmX.ImageIndex = 0
                    itmX.Group = lvFavoritas.Groups(0)
                    itmX.SubItems.Add(.Rows(i).Item("CV_DESCRI"))

                    lvFavoritas.Items.Add(itmX)

                Next

            End With

        Catch ex As Exception

            TratarError(ex)

        End Try

    End Sub

    Private Sub AgregarFavorita(ByVal nCodConsulta As Long)

        Dim sSQL As String
        Dim itmX As ListViewItem

        Try

            sSQL = "INSERT INTO FAVORI (FV_CODUSU,FV_CODCON) " & _
                   "VALUES (" & USUARIO_ACTUAL & "," & nCodConsulta & ")"

            oAdmTablas.EjecutarComandoSQL(sSQL)
            CargarFavoritas()

            dckManager.ActivePanel = pnlFavoritas

            itmX = lvFavoritas.Items("K" & nCodConsulta)
            itmX.Selected = True
            itmX.EnsureVisible()


        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub btnAgregarFavoritasContext_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAgregarFavoritasContext.ItemClick

        Dim nCodigoConsulta As Integer
        Dim nodX As TreeNode

        nodX = tvMain.SelectedNode

        If Not nodX Is Nothing Then
            nCodigoConsulta = Val(nodX.Name.Substring(1))

            If nCodigoConsulta > 0 Then
                AgregarFavorita(nCodigoConsulta)
            End If
        End If

    End Sub

    Private Sub lvFavoritas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvFavoritas.KeyDown

        Dim itmX As ListViewItem

        If e.KeyCode = Keys.Delete Then

            If lvFavoritas.SelectedItems.Count = 1 Then

                itmX = lvFavoritas.FocusedItem

                If Not itmX Is Nothing Then

                    If Pregunta(DescripcionCadena(Cadenas.CDN_WarningEliminarFavorita)) = Windows.Forms.DialogResult.Yes Then

                        EliminarFavorita(Val(itmX.Name.Substring(1)))

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub EliminarFavorita(ByVal nCodigoConsulta As Long)

        Dim sSQL As String

        Try
            sSQL = "DELETE          " & _
                   "FROM        FAVORI " & _
                   "WHERE       FV_CODUSU = " & USUARIO_ACTUAL & " " & _
                   "AND         FV_CODCON = " & nCodigoConsulta

            oAdmTablas.EjecutarComandoSQL(sSQL)
            CargarFavoritas()

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub lvFavoritas_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvFavoritas.MouseDoubleClick

        Dim itmX As ListViewItem

        If e.Button = Windows.Forms.MouseButtons.Left Then

            If lvFavoritas.SelectedItems.Count = 1 Then

                itmX = lvFavoritas.FocusedItem

                If Not itmX Is Nothing Then

                    AbrirEjecucionConsulta(Val(itmX.Name.Substring(1)))


                End If

            End If

        End If

    End Sub

    Private Sub btnAdministracionSeguridad_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdministracionSeguridad.ItemClick

        VentanaUsuarios()

    End Sub

    Private Sub VentanaUsuarios()

        If USUARIO_ACTUAL_PMS_SEGURIDAD Then

            Dim fUsuarios As frmSeguridad

            fUsuarios = New frmSeguridad
            fUsuarios.ShowDialog()
            fUsuarios.Dispose()

        Else

            MensajeError(DescripcionCadena(Cadenas.CDN_GeneralSinPermisos))

        End If

    End Sub

    Public Sub EstablecerPermisos()

        Dim sSQL As String
        Dim ds As DataSet

        sSQL = "SELECT      * " & _
               "FROM        USUARI " & _
               "WHERE       US_CODUSU = " & USUARIO_ACTUAL

        Try

            ds = oAdmTablas.AbrirDataset(sSQL)

            With ds.Tables(0)

                If .Rows.Count >= 1 Then
                    USUARIO_ACTUAL_PMS_CATEGORIAS = (.Rows(0)("US_CATQRY") <> 0)
                    USUARIO_ACTUAL_PMS_CONEXIONES = (.Rows(0)("US_CNNQRY") <> 0)
                    USUARIO_ACTUAL_PMS_DISENAR = (.Rows(0)("US_DSNQRY") <> 0)
                    USUARIO_ACTUAL_PMS_EJECUTAR = (.Rows(0)("US_EXEQRY") <> 0)
                    USUARIO_ACTUAL_PMS_EXPORTAR = (.Rows(0)("US_EXPQRY") <> 0)
                    USUARIO_ACTUAL_PMS_IMPORTAR = (.Rows(0)("US_IMPQRY") <> 0)
                    USUARIO_ACTUAL_PMS_SEGURIDAD = (.Rows(0)("US_ADMSEG") <> 0)
                    USUARIO_ACTUAL_PMS_OPCIONES_GRALES = (.Rows(0)("US_OPCGRL") <> 0)
                    USUARIO_ACTUAL_PMS_ELIMINAR = (.Rows(0)("US_ELIQRY") <> 0)
                End If

            End With

            ' Cargar las consultas no habilitadas ...
            ' CargarPermisosConsultas()

        Catch ex As Exception
            TratarError(ex)
        End Try



    End Sub

    Private Sub btnExportarContext_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportarContext.ItemClick
        Dim nCodigoConsulta As Integer
        Dim nodX As TreeNode

        nodX = tvMain.SelectedNode

        If Not nodX Is Nothing Then
            nCodigoConsulta = Val(nodX.Name.Substring(1))

            If nCodigoConsulta > 0 Then
                AbrirExportacionConsulta(nCodigoConsulta)
            End If
        End If
    End Sub

    Private Sub btnExportarConsulta_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportarConsulta.ItemClick
        Dim nCodConsulta As Integer

        If Not USUARIO_ACTUAL_PMS_EXPORTAR Then
            MensajeError(DescripcionCadena(Cadenas.CDN_GeneralSinPermisos))
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        nCodConsulta = SeleccionarConsulta()
        Cursor = Cursors.Default

        If nCodConsulta > 0 Then
            AbrirExportacionConsulta(nCodConsulta)
        End If

    End Sub

    Private Sub btnOpcionesGenerales_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOpcionesGenerales.ItemClick

        If Not USUARIO_ACTUAL_PMS_OPCIONES_GRALES Then
            MensajeError(DescripcionCadena(Cadenas.CDN_GeneralSinPermisos))
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        '' ABRIR FORM '''
        Dim fOpciones As New frmOpcionesGlobales
        fOpciones.ShowDialog()
        fOpciones.Dispose()
        '' FIN '''
        Cursor = Cursors.Default

    End Sub

    Private Sub btnImportarConsulta_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImportarConsulta.ItemClick

        If MODO_DEMO Then
            MensajeError(DescripcionCadena(Cadenas.CDN_GeneralImportarNoHabilitadoModoDemo))
        Else
            AbrirImportacionConsulta()
        End If

    End Sub

    Private Sub btnEliminarConsulta_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEliminarConsulta.ItemClick
        Dim nCodConsulta As Integer

        If Not USUARIO_ACTUAL_PMS_ELIMINAR Then
            MensajeError(DescripcionCadena(Cadenas.CDN_GeneralSinPermisos))
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        nCodConsulta = SeleccionarConsulta()
        Cursor = Cursors.Default

        If nCodConsulta > 0 Then
            AbrirEliminacionConsulta(nCodConsulta)
        End If
    End Sub

    Private Sub btnEliminarContext_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEliminarContext.ItemClick

        Dim nCodigoConsulta As Integer
        Dim nodX As TreeNode

        nodX = tvMain.SelectedNode

        If Not nodX Is Nothing Then
            nCodigoConsulta = Val(nodX.Name.Substring(1))

            If nCodigoConsulta > 0 Then
                AbrirEliminacionConsulta(nCodigoConsulta)
            End If
        End If

    End Sub

    Public Function CantidadConsultas() As Integer

        Dim sSQL As String
        Dim ds As DataSet
        Dim nCant As Integer

        sSQL = "SELECT  COUNT(1) AS CANTIDAD " & _
               "FROM    CONVAR "

        Try

            ds = oAdmTablas.AbrirDataset(sSQL)
            With ds.Tables(0)
                nCant = .Rows(0)(0)
            End With
            ds.Dispose()

            Return nCant

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Function

    Public Function ConsultaNoHabilitada(ByVal nCodigo As Long) As Integer

        Dim sSQL As String
        Dim ds As DataSet
        Dim bTemp As Boolean

        sSQL = "SELECT  COUNT(1) AS CANTIDAD " & _
               "FROM    INHABI " & _
               "WHERE   IH_CODCON = " & nCodigo & " " & _
               "AND     IH_CODUSU = " & USUARIO_ACTUAL

        Try

            ds = oAdmTablas.AbrirDataset(sSQL)
            With ds.Tables(0)
                bTemp = .Rows(0)(0) > 0
            End With
            ds.Dispose()

            Return bTemp

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Function

    Private Sub btnContenido_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnContenido.ItemClick

        If HELP_PATH <> "" Then

            Try

                System.Diagnostics.Process.Start(HELP_PATH)

            Catch ex As Exception
                TratarError(ex)
            End Try
        End If
    End Sub
End Class