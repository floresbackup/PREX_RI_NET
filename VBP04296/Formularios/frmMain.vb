Imports System.Data.SqlClient
Imports Prex.Utils

Public Class frmMain
    Public ErrorPermiso As Boolean = False
    Private tCabSys As CabSys

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        AnalizarCommand()
    End Sub

    '#Region "Metodos"
    Public Sub AnalizarCommand()

        Try

            Dim sTemp As String
            Dim nPos As Integer
            Dim nPosAux As Integer
            Dim nCodigoUsuario As Long
            Dim nCodigoTransaccion As Long
            Dim nCodigoEntidad As Long

            sTemp = Command()

            '''''' USUARIO ''''''

            nPos = InStr(1, UCase(sTemp), "/U:")

            If nPos = 0 Then
                MensajesForms.MostrarError("Los argumentos de la línea de comandos no son válidos")
                Exit Sub
            End If

            nPosAux = InStr(1, Mid(sTemp, nPos + 3), "/")

            If nPosAux > 0 Then
                nCodigoUsuario = Val(Mid(sTemp, nPos + 3, nPosAux - 1))
            Else
                nCodigoUsuario = Val(Mid(sTemp, nPos + 3))
            End If

            '''''' TRANSACCION ''''''

            nPos = InStr(1, UCase(sTemp), "/T:")

            If nPos = 0 Then
                MensajesForms.MostrarError("Los argumentos de la línea de comandos no son válidos")
                Exit Sub
            End If

            nPosAux = InStr(1, Mid(sTemp, nPos + 3), "/")

            If nPosAux > 0 Then
                nCodigoTransaccion = Val(Mid(sTemp, nPos + 3, nPosAux - 1))
            Else
                nCodigoTransaccion = Val(Mid(sTemp, nPos + 3))
            End If

            '''''' ENTIDAD ''''''

            nPos = InStr(1, UCase(sTemp), "/E:")

            If nPos = 0 Then
                MensajesForms.MostrarError("Los argumentos de la línea de comandos no son válidos")
                Exit Sub
            End If

            nPosAux = InStr(1, Mid(sTemp, nPos + 3), "/")

            If nPosAux > 0 Then
                nCodigoEntidad = Val(Mid(sTemp, nPos + 3, nPosAux - 1))
            Else
                nCodigoEntidad = Val(Mid(sTemp, nPos + 3))
            End If

            Configuration.PrexConfig.CODIGO_TRANSACCION = nCodigoTransaccion
            Configuration.PrexConfig.CODIGO_ENTIDAD = nCodigoEntidad

            PresentarDatos(nCodigoTransaccion, nCodigoUsuario, nCodigoEntidad)

        Catch ex As Exception
            ManejarErrores.TratarError(ex, "AnalizarCommand")
        End Try
    End Sub

    Private Sub PresentarDatos(ByVal nCodigoTransaccion As Long, ByVal nCodigoUsuario As Long, ByVal nCodigoEntidad As Long)
        Try
            Dim sError = String.Empty
            ''''' USUARIO '''''
            Dim sSQL = "SELECT    US_CODUSU, US_NOMBRE, US_DESCRI " &
                        "FROM      USUARI " &
                        "WHERE     US_CODUSU = " & nCodigoUsuario
            Dim rstAux As SqlDataReader = DataAccess.GetReader(sSQL)

            If rstAux.RecordsAffected = 0 OrElse rstAux.RecordsAffected > 1 Then
                sError = "Falla de seguridad"
            End If

            While rstAux.Read()
                Configuration.PrexConfig.UsuarioActual.Codigo = nCodigoUsuario
                Configuration.PrexConfig.UsuarioActual.Nombre = rstAux("US_NOMBRE").ToString()
                Configuration.PrexConfig.UsuarioActual.Descripcion = rstAux("US_DESCRI").ToString()
                Configuration.PrexConfig.UsuarioActual.SoloLectura = False
                lblUsuario.Text = Configuration.PrexConfig.UsuarioActual.Descripcion
            End While
            rstAux.Close()


            ''''' ENTIDAD '''''
            sSQL = "SELECT    TG_CODCON, TG_DESCRI " &
          "FROM      TABGEN " &
          "WHERE     TG_CODTAB = " & EnumTablasGenerales.TGL_Entidades & " " &
          "AND       TG_CODCON = " & nCodigoEntidad

            rstAux = DataAccess.GetReader(sSQL)

            If rstAux.RecordsAffected = 0 OrElse rstAux.RecordsAffected > 1 Then
                sError = "Parámetro de entidad no válido"
            End If

            While rstAux.Read()
                Configuration.PrexConfig.NOMBRE_ENTIDAD = rstAux("TG_DESCRI").ToString()
                lblEntidad.Text = rstAux("TG_DESCRI").ToString()
            End While
            rstAux = Nothing

            ''''' TRANSACCION '''''
            sSQL = "SELECT    MU_TRANSA, MU_DESCRI " &
          "FROM      MENUES " &
          "WHERE     MU_CODTRA = " & nCodigoTransaccion

            rstAux = DataAccess.GetReader(sSQL)

            If rstAux.RecordsAffected = 0 OrElse rstAux.RecordsAffected > 1 Then
                sError = "Error en la línea de comandos. Parámetro de transacción incorrecto"
            End If

            While rstAux.Read()
                Configuration.PrexConfig.CODIGO_TRANSACCION = nCodigoTransaccion
                lblTransaccion.Text = rstAux("MU_DESCRI").ToString()
                Me.Text = "Gestión RI | " & nCodigoTransaccion.ToString & " - " & rstAux("MU_TRANSA").ToString
                lblTitulo.Text = rstAux("MU_TRANSA").ToString
                lblSubtitulo.Text = rstAux.Item("MU_DESCRI").ToString
            End While
            rstAux = Nothing

            If sError <> "" Then
                Prex.Utils.MensajesForms.MostrarError(sError)
            End If


        Catch ex As Exception
            ManejarErrores.TratarError(ex, "PresentarDatos")
        End Try

    End Sub

    Private Sub NuevaConsulta()

        tCabSys = New CabSys(Configuration.PrexConfig.CODIGO_ENTIDAD)

        txtNombreCab.Text = tCabSys.CS_NOMBRE
        txtDescriCab.Text = ""
        txtCodTraCab.text = ""
        chkAlta.Checked = False
        chkBaja.Checked = False
        chkABM.Checked = False
        chkNDesde.Checked = False
        chkDrillDown.Checked = False
        chkGroup.Checked = False

        'cmSQL.Text = tCabSys.CS_QUERY
        '
        'txtOrdenVar = ""
        'txtNombreVar = ""
        'txtTituloVar = ""
        'txtTipoVar = ""
        'txtHelpVar = ""
        'txtRutaHelp.Text = ""
        '
        'txtTitulo = ""
        'txtFormat = ""
        'TxtMaxAncho = ""
        '
        'cmHelp.Text = ""
        'txtFormul.Text = ""
        'chkHabili.Value = 1
        'chkVisible.Value = 1
        'lstIntelliSense.Clear
        '
        'cmHelp.Enabled = False
        'lbl(10).Enabled = False
        '
        'CargarCombos

        tabPageFormulario.Select()

    End Sub

    '    Public Sub CargarVariable(ByVal nOrden As Integer,
    '                          ByVal sNombre As String,
    '                          ByVal nTipo As Integer,
    '                          ByVal sTitulo As String,
    '                          ByVal nHelp As Integer,
    '                          ByVal sHelSQL As String)


    '        Dim oVar As ItemsVarSys

    '        If nOrden = 0 Then
    '            nLlave = nLlave + 1
    '            oVarSys.Add tCabSys.CS_CODCON, oVarSys.Count + 1, sNombre, nTipo, sTitulo, nHelp, sHelSQL, "K" & nLlave
    '   End If

    '        If nOrden <> 0 Then
    '            For Each oVar In oVarSys
    '                If oVar.Orden = nOrden Then
    '                    oVar.Nombre = sNombre
    '                    oVar.Tipo = nTipo
    '                    oVar.Titulo = sTitulo
    '                    oVar.Help = nHelp
    '                    oVar.HelQue = sHelSQL
    '                    Exit For
    '                End If
    '            Next
    '        End If

    '        CargarVariables()

    '    End Sub

    '    Private Sub CargarVariables()

    '        GridVar.ItemCount = oVarSys.Count
    '        GridVar.Refresh
    '        GridVar.RefreshSort
    '        DoEvents

    '        If GridVar.ItemCount > 0 Then
    '            MostrarVariable "K" & GridVar.Value(GridVar.Columns("Key").Index)
    '   End If

    '    End Sub

    '#End Region

#Region "Eventos Form"
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim dt As SqlDataReader = DataAccess.GetReader("SELECT *, CAST(CS_CODTRA AS VARCHAR) +  ' - ' + CS_NOMBRE AS XX_DESCRI FROM CABSYS ORDER BY CS_CODTRA ")
        GridCons.DataSource = dt
        dt.Close()
        NuevaConsulta()

        '''PARAMETROS CUADRO SQL
        'AjusteCodemax cmSQL
        '    AjusteCodemax cmHelp
        '    AjusteCodemax txtFormul

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub
#End Region

#Region "Eventos Controles"

    Private Sub chkABM_CheckedChanged(sender As Object, e As EventArgs) Handles chkABM.CheckedChanged
        tCabSys.CS_UPDATE = chkABM.Checked
        cmdQueryUpdate.Enabled = tCabSys.CS_UPDATE
        cmdModValida.Enabled = tCabSys.CS_UPDATE
        cmdValidarUpdate.Enabled = (chkABM.Value = 1)
    End Sub

    '    Private Sub chkClave_Click()

    '        oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).Llave = CBool(chkClave.Value)

    '    End Sub

    '    Private Sub chkDrill_Click()

    '        oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).DrillD = CBool(chkDrill.Value)

    '        cmdDrill.Enabled = (chkDrill.Value = 1)

    '    End Sub

    '    Private Sub chkDrillDown_Click()
    '        cmdDrillDown.Enabled = CBool(chkDrillDown.Value)
    '        tCabSys.CS_DRILLD = cmdDrillDown.Enabled
    '    End Sub

    '    Private Sub chkGroup_Click()
    '        tCabSys.CS_GROUPB = CBool(chkGroup.Value)
    '    End Sub

    '    Private Sub chkHabili_Click()
    '        On Error Resume Next
    '        oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).Habili = CBool(chkHabili.Value)
    '    End Sub


    Private Sub chkNDesde_CheckedChanged(sender As Object, e As EventArgs) Handles chkNDesde.CheckedChanged
        tCabSys.CS_HABNDE = chkNDesde.Checked
        cmdQueryNDesde.Enabled = tCabSys.CS_HABNDE

        cmdValidaNuevoDesde.Enabled = chkNDesde.Value
    End Sub

    '    Private Sub chkReempl_Click()
    '        On Error Resume Next
    '        oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).Reemplazo = CBool(chkReempl.Value)
    '    End Sub

    '    Private Sub chkVisible_Click()
    '        On Error Resume Next
    '        oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).Visible = CBool(chkVisible.Value)
    '    End Sub

    '    Private Sub chkVisABM_Click()
    '        On Error Resume Next
    '        oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).VisABM = CBool(chkVisABM.Value)
    '    End Sub

    Private Sub chkAlta_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlta.CheckedChanged

        'Load frmDrillDown
        'frmDrillDown.PasarQuery tCabSys.CS_ALTQUE
        'frmDrillDown.Show vbModal, Me

        If Trim(INPUT_GENERAL) <> "" Then
            tCabSys.CS_ALTQUE = INPUT_GENERAL
        End If

    End Sub

    '    Private Sub cmdAltaValida_Click()

    '        Load frmDrillDown
    '   frmDrillDown.PasarQuery tCabSys.CS_ALTVAL
    '   frmDrillDown.Show vbModal, Me

    '    If FORM_MODAL_RESP Then
    '            tCabSys.CS_ALTVAL = Trim(INPUT_GENERAL)
    '        End If

    '    End Sub

    '    Private Sub cmdBaja_Click()

    '        Load frmDrillDown
    '   frmDrillDown.PasarQuery tCabSys.CS_BAJQUE
    '   frmDrillDown.Show vbModal, Me

    '    If Trim(INPUT_GENERAL) <> "" Then
    '            tCabSys.CS_BAJQUE = INPUT_GENERAL
    '        End If

    '    End Sub

    '    Private Sub cmdDrill_Click()

    '        Load frmDrillDown
    '   frmDrillDown.PasarConsulta tCabSys.CS_CODTRA, oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).Campo, oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).DriQue, oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).DriPre
    '   frmDrillDown.Show vbModal, Me

    '    If Trim(INPUT_GENERAL) <> "" Then
    '            oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).DriQue = INPUT_GENERAL

    '            If Trim(INPUT_GENERAL_AUX) <> "" Then
    '                oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).DriPre = INPUT_GENERAL_AUX
    '            End If

    '        Else
    '            chkDrill.Value = 0
    '        End If

    '    End Sub

    '    Private Sub cmdDrillDown_Click()

    '        Load frmDrillDown
    '   frmDrillDown.PasarConsulta tCabSys.CS_CODTRA, "", tCabSys.CS_DRIQUE, tCabSys.CS_DRIPRE
    '   frmDrillDown.Show vbModal, Me

    '    If Trim(INPUT_GENERAL) <> "" Then
    '            tCabSys.CS_DRIQUE = INPUT_GENERAL
    '        End If

    '        If Trim(INPUT_GENERAL_AUX) <> "" Then
    '            tCabSys.CS_DRIPRE = INPUT_GENERAL_AUX
    '        End If

    '    End Sub

    '    Private Sub cmdFondo_Click()

    '        On Error Resume Next

    '        Dim nColor As Long

    '        nColor = picFondo.BackColor

    '        If VBChooseColor(nColor, True, True) Then
    '            picFondo.BackColor = nColor

    '            Dim sFormat As String

    '            sFormat = txtFormat.Text & ";" &
    '             picFondo.BackColor & ";" &
    '             picFrente.BackColor & ";" &
    '             txtFuente.Font.name & ";" &
    '             IIf(txtFuente.Font.Bold, 1, 0) & ";" &
    '             IIf(txtFuente.Font.Underline, 1, 0) & ";" &
    '             IIf(txtFuente.Font.Strikethrough, 1, 0) & ";" &
    '             Int(Val(txtFuente.Font.Size)) & ";" &
    '             Int(Val(txtAncho.Text)) & ";" &
    '             txtCond

    '            oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).Format = sFormat

    '        End If

    '    End Sub

    '    Private Sub cmdFrente_Click()


    '        Dim nColor As Long

    '        nColor = picFrente.BackColor

    '        If VBChooseColor(nColor, True, True) Then
    '            picFrente.BackColor = nColor

    '            Dim sFormat As String

    '            sFormat = txtFormat.Text & ";" &
    '             picFondo.BackColor & ";" &
    '             picFrente.BackColor & ";" &
    '             txtFuente.Font.name & ";" &
    '             IIf(txtFuente.Font.Bold, 1, 0) & ";" &
    '             IIf(txtFuente.Font.Underline, 1, 0) & ";" &
    '             IIf(txtFuente.Font.Strikethrough, 1, 0) & ";" &
    '             Int(Val(txtFuente.Font.Size)) & ";" &
    '             Int(Val(txtAncho.Text)) & ";" &
    '             txtCond

    '            oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).Format = sFormat

    '        End If

    '    End Sub

    '    Private Sub cmdFuente_Click()

    '        Dim oFont As StdFont

    '    Set oFont = New StdFont
    '    Set oFont = txtFuente.Font

    '    If VBChooseFont(oFont) Then
    '    Set txtFuente.Font = oFont

    '    Dim sFormat As String

    '            sFormat = txtFormat.Text & ";" &
    '             picFondo.BackColor & ";" &
    '             picFrente.BackColor & ";" &
    '             txtFuente.Font.name & ";" &
    '             IIf(txtFuente.Font.Bold, 1, 0) & ";" &
    '             IIf(txtFuente.Font.Underline, 1, 0) & ";" &
    '             IIf(txtFuente.Font.Strikethrough, 1, 0) & ";" &
    '             Int(Val(txtFuente.Font.Size)) & ";" &
    '             Int(Val(txtAncho.Text)) & ";" &
    '             txtCond

    '            oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).Format = sFormat

    '        End If

    '    Set oFont = Nothing


    '    Private Sub cmdModValida_Click()

    '        Load frmDrillDown
    '   frmDrillDown.PasarQuery tCabSys.CS_MODVAL
    '   frmDrillDown.Show vbModal, Me

    '    If FORM_MODAL_RESP Then
    '            tCabSys.CS_MODVAL = Trim(INPUT_GENERAL)
    '        End If

    '    End Sub

    '    Private Sub cmdQueryNDesde_Click()

    '        Load frmDrillDown
    '   frmDrillDown.PasarQuery tCabSys.CS_NDESDE
    '   frmDrillDown.Show vbModal, Me

    '    If Trim(INPUT_GENERAL) <> "" Then
    '            tCabSys.CS_NDESDE = INPUT_GENERAL
    '        End If

    '    End Sub

    '    Private Sub cmdQueryUpdate_Click()

    '        Load frmDrillDown
    '   frmDrillDown.PasarQuery tCabSys.CS_TABLA
    '   frmDrillDown.Show vbModal, Me

    '    If Trim(INPUT_GENERAL) <> "" Then
    '            tCabSys.CS_TABLA = INPUT_GENERAL
    '        End If

    '    End Sub

    '    Private Sub cmdValidaNuevoDesde_Click()

    '        Load frmDrillDown
    '   frmDrillDown.PasarQuery tCabSys.CS_NDEVAL
    '   frmDrillDown.Show vbModal, Me

    '    If Trim(INPUT_GENERAL) <> "" Then
    '            tCabSys.CS_NDEVAL = INPUT_GENERAL
    '        End If

    '    End Sub

    '    Private Sub cmdValidarUpdate_Click()

    '        Load frmDrillDown
    '   frmDrillDown.PasarQuery tCabSys.CS_UPDQUE
    '   frmDrillDown.Show vbModal, Me

    '    If Trim(INPUT_GENERAL) <> "" Then
    '            tCabSys.CS_UPDQUE = INPUT_GENERAL
    '        End If

    '    End Sub

    '    Private Sub cmHelp_Change(ByVal Control As CodeMaxCtl.ICodeMax)
    '        oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).HelQue = cmHelp.Text
    '    End Sub

    '    Private Function cmHelp_RClick(ByVal Control As CodeMaxCtl.ICodeMax) As Boolean
    '        cmHelp_RClick = True
    '    End Function

    '    Private Sub cmSQL_Change(ByVal Control As CodeMaxCtl.ICodeMax)
    '        tCabSys.CS_QUERY = cmSQL.Text
    '    End Sub

    '    Private Function cmSQL_RClick(ByVal Control As CodeMaxCtl.ICodeMax) As Boolean
    '        cmSQL_RClick = True
    '    End Function

    '    Private Sub dckCampos_CommandClick(ByVal Command As InnovaDSXP.Command)

    '        Select Case Command.name

    '            Case "btnBaja"
    '                If Pregunta("¿Eliminar columna?") = vbYes Then
    '                    EliminarCampo GridCols.Value(GridCols.Columns("Key").Index)
    '    End If

    '            Case "btnArriba"
    '                SubirOrdenCol GridCols.Value(GridCols.Columns("Orden").Index)

    '    Case "btnAbajo"
    '                BajarOrdenCol GridCols.Value(GridCols.Columns("Orden").Index)

    '    End Select

    '    End Sub

    '    Private Sub dckCons_CommandClick(ByVal Command As InnovaDSXP.Command)

    '        Dim oRespuesta As VbMsgBoxResult

    '        Select Case Command.name

    '            Case "btnNuevo"

    '                oRespuesta = MsgBox("Se perderan los cambios de la consulta actual. ¿Desea guardar los cambios?", vbQuestion + vbYesNoCancel, "Preguta del sistema")

    '                If oRespuesta = vbYes Then
    '                    GuardarConsulta
    '                ElseIf oRespuesta = vbCancel Then
    '                    Exit Sub
    '                Else
    '                    NuevaConsulta
    '                End If

    '            Case "btnBaja"

    '                If Pregunta("¿Eliminar la consulta de la base de datos?") = vbYes Then
    '                    EliminarConsulta
    '                End If

    '            Case "btnEditar"
    '                EditarConsulta

    '        End Select

    '    End Sub

    '    Private Sub dckStudio_CommandClick(ByVal Command As InnovaDSXP.Command)

    '        Select Case Command.name

    '            Case "btnAyuda"

    '                Ayuda

    '            Case "btnSalir"

    '                Unload Me

    '    End Select

    '    End Sub


#End Region

End Class
