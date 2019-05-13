Imports System.Globalization
Imports System.IO
Imports DevExpress.Utils
Imports DevExpress.Xpo
Imports DevExpress.XtraBars.Localization
Imports DevExpress.XtraCharts.Localization
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Localization
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraPivotGrid.Localization
Imports DevExpress.XtraPrinting.Localization
Imports DevExpress.XtraReports.Localization
Imports WebSupergoo

Public Class frmMain
    Private sExtra_log As String
    Public ps1 = New DevExpress.XtraPrinting.PrintingSystem

    Public Class DropDownGrid
        Inherits XPObject
        Public Sub New()
            Codigo = Nothing
            Descripcion = ""
        End Sub
        Public Codigo As Object
        Public Descripcion As String
    End Class

    Private Structure tDetalle
        Friend SI As Boolean
        Friend Variable As String
        Friend Condicion As Object
        Friend CodigoHTML As String
        Friend PosIni As Long
        Friend PosFin As Long
        Friend Longitud As Long
        Friend Encabezado As String
        Friend Pie As String
    End Structure

    Private oAdmTablas As New AdmTablas
    Private nLastCol As Long
    Private nLastRow As Long
    Private nPagInicial As Long
    Private bFlagCargado As Boolean
    Private bHabilitado As Boolean
    Private Detalle() As tDetalle

    Private Declare Function OleTranslateColor Lib "OLEPRO32.DLL" (ByVal OLE_COLOR As Long, ByVal HPALETTE As Long, ByVal pccolorref As Long) As Long
    Public ErrorPermiso As Boolean = False

    Private ReadOnly Property ClaveFormulario(separador As String) As String
        Get
            Dim sClave = String.Empty
            If GridView1.RowCount > 0 AndAlso GridView1.SelectedRowsCount > 0 Then

                For Each oCol As clsColumnas In oColumnas
                    If oCol.Clave Then
                        sClave = sClave & GridView1.GetRowCellDisplayText(GridView1.GetRowHandle(GridView1.GetSelectedRows(0)), oCol.Campo).ToString & separador
                    End If
                Next
            End If
            Return sClave
        End Get
    End Property

    Public Sub AnalizarCommand()

        Try

            Dim sParametros() As String
            Dim sItemParam() As String
            Dim nCodigoUsuario As Long
            Dim nCodigoTransaccion As Long
            Dim nCodigoEntidad As Long
            Dim nC As Integer

            '''''' USUARIO ''''''

            sParametros = Command.Split("/")

            For nC = 0 To sParametros.Length - 1

                sItemParam = sParametros(nC).Trim.Split(":")

                If sItemParam.Length = 2 Then

                    Select Case sItemParam(0).Trim.ToUpper
                        Case "U"
                            nCodigoUsuario = Val(sItemParam(1))
                        Case "T"
                            nCodigoTransaccion = Val(sItemParam(1))
                        Case "E"
                            nCodigoEntidad = Val(sItemParam(1))
                    End Select

                End If
            Next

            If nCodigoUsuario = 0 Then
                MensajeError("El parámetro código usuario es inválido.")
                Application.Exit()
            End If

            If nCodigoTransaccion = 0 Then
                MensajeError("El parámetro código de transacción es inválido.")
                Application.Exit()
            End If

            If nCodigoEntidad = 0 Then
                MensajeError("El parámetro código de entidad es inválido.")
                Application.Exit()
            End If

            CODIGO_TRANSACCION = nCodigoTransaccion
            CODIGO_ENTIDAD = nCodigoEntidad

            PresentarDatos(nCodigoTransaccion, nCodigoUsuario, nCodigoEntidad)

        Catch ex As Exception
            TratarError(ex, "AnalizarCommand")
            Application.Exit()
        End Try

    End Sub

    Private Sub PresentarDatos(ByVal nCodigoTransaccion As Long, ByVal nCodigoUsuario As Long, ByVal nCodigoEntidad As Long)

        Try
            Try
                Dim sSQL As String
                Dim ds As DataSet

                ''''' USUARIO '''''

                sSQL = "SELECT    US_CODUSU, US_NOMBRE, US_DESCRI, US_ADMIN " &
                   "FROM      USUARI " &
                   "WHERE     US_CODUSU = " & nCodigoUsuario
                ds = oAdmTablas.AbrirDataset(sSQL)

                With ds.Tables(0)

                    If .Rows.Count = 0 Then
                        Throw New Security.SecurityException("Falla de seguridad - US_CODUSU: " & nCodigoUsuario)
                    Else
                        UsuarioActual.Codigo = nCodigoUsuario
                        UsuarioActual.Nombre = .Rows(0).Item("US_NOMBRE")
                        UsuarioActual.Descripcion = .Rows(0).Item("US_DESCRI")
                        UsuarioActual.Admin = .Rows(0).Item("US_ADMIN")
                        UsuarioActual.SoloLectura = False
                        'lblUsuario.Text = UsuarioActual.Descripcion
                    End If

                End With

                ds = Nothing

                ''''' ENTIDAD '''''

                sSQL = "SELECT    TG_CODCON, TG_DESCRI " &
                   "FROM      TABGEN " &
                   "WHERE     TG_CODTAB = 1 " &
                   "AND       TG_CODCON = " & nCodigoEntidad
                ds = oAdmTablas.AbrirDataset(sSQL)

                With ds.Tables(0)

                    If .Rows.Count = 0 Then
                        Throw New Security.SecurityException("Parámetro de entidad no válido - TG_CODCON: " & nCodigoEntidad)
                    Else
                        NOMBRE_ENTIDAD = .Rows(0).Item("TG_DESCRI")
                        'lblEntidad.Text = NOMBRE_ENTIDAD
                    End If

                End With

                ds = Nothing

                ''''' TRANSACCION '''''

                sSQL = "SELECT    MU_TRANSA, MU_DESCRI " &
                   "FROM      MENUES " &
                   "WHERE     MU_CODTRA = " & nCodigoTransaccion
                ds = oAdmTablas.AbrirDataset(sSQL)

                With ds.Tables(0)


                    If .Rows.Count = 0 Then
                        Throw New Security.SecurityException("Error en la línea de comandos. Parámetro de transacción incorrecto - MU_CODTRA: " & nCodigoTransaccion)
                    Else
                        'lblTransaccion.Text = nCodigoTransaccion.ToString & " - " & .Rows(0).Item("MU_TRANSA")
                        Me.Text = "Transacción:" & nCodigoTransaccion.ToString & " - " & .Rows(0).Item("MU_TRANSA")
                    End If

                End With

                ds = Nothing

                'lblVersion.Text = "Versión: " & Application.ProductVersion
                'Me.Text = lblTransaccion.Text

            Catch ex As Security.SecurityException
                MensajeError(ex.Message)
                ErrorPermiso = True
            End Try
        Catch ex As Exception
            TratarError(ex, "PresentarDatos")
            ErrorPermiso = True
        End Try

    End Sub

    Public Sub Ejecutar()
        If ProcesosPrevios() Then

            Dim sSQL As String = ReemplazarVariables(oConsulta.Query, PanControles.Controls)

            Dim ad As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sSQL, CONN_LOCAL)
            Dim dt As New DataTable
            ad.Fill(dt)


            If Not bFlagCargado Then
                For Each oCol As clsColumnas In oColumnas

                    If oCol.Help = 1 And oCol.Reemplazar Then
                        CargarValoresColumna(oCol.Campo, oCol.HelpQuery)
                    End If

                Next
                bFlagCargado = True
            End If

            Grid.DataSource = dt
            Grid.RefreshDataSource()
            Grid.Refresh()

            If GridView1.RowCount > 0 Then
                btnMostrarBuscador.Enabled = True
                btnImprimir.Enabled = True
                btnExportar.Enabled = True
                btnCopiar.Enabled = True
            End If

            btnAdjuntarArchivo.Enabled = oAdmTablas.ExisteTabla("ADJUNT")
        End If
    End Sub

    Private Sub Columnas()

        Dim View As ColumnView = Grid.MainView
        Dim Column As DevExpress.XtraGrid.Columns.GridColumn
        Dim oCol As clsColumnas

        View.Columns.Clear()

        For Each oCol In oColumnas

            Column = View.Columns.AddField(oCol.Campo)

            Column.Width = 100
            Column.VisibleIndex = oCol.Orden
            Column.Visible = oCol.Visible
            Column.Caption = oCol.Titulo

            If oCol.Formato.IndexOf(";") <> -1 Then
                If Not FormatearColumna(Column) Then
                    FormatoCondicional(oCol.Campo)
                End If
            End If

        Next

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarConsulta(CODIGO_TRANSACCION)
    End Sub

    Private Sub frmMain_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        Grid.Height = Me.Height - 100
    End Sub

    Private Sub HabilitarBotones()

        btnAlta.Enabled = oConsulta.Alta
        btnBaja.Enabled = oConsulta.Baja
        btnModif.Enabled = ValidaUpdate()
        btnNDesde.Enabled = oConsulta.NuevoDesde
        btnDrillDown.Enabled = ValidarDrillDown()
        btnComent.Enabled = GridView1.RowCount > 0

    End Sub

    Private Sub CargarConsulta(ByVal nCodCon As Long)

        Dim sSQL As String
        Dim ad As OleDb.OleDbDataAdapter
        Dim dt As DataTable
        Dim dr As DataRow
        Dim nC As Integer = 0
        Dim oVar As clsVariables

        'ENCABEZADO
        ''''''''''''''''''''''''''''''''''''
        sSQL = "SELECT    * " &
               "FROM      CABSYS " &
               "WHERE     CS_CODTRA = " & nCodCon

        ad = New OleDb.OleDbDataAdapter(sSQL, CONN_LOCAL)
        dt = New DataTable

        ad.Fill(dt)

        For Each dr In dt.Rows
            nCodCon = Convert.ToInt32(dr("CS_CODCON").ToString)
        Next

        AbrirConsulta(nCodCon)

        dt = Nothing
        ad = Nothing

        sSQL = "SELECT    * " &
               "FROM      SYSGRA " &
               "WHERE     SG_CODCON = " & oConsulta.CodCon

        ad = New OleDb.OleDbDataAdapter(sSQL, CONN_LOCAL)
        dt = New DataTable

        ad.Fill(dt)
        'btnGrafico.Enabled = dt.Rows.Count > 0

        dt = Nothing
        ad = Nothing

        sSQL = "SELECT    * " &
               "FROM      REPORT " &
               "WHERE     RO_CODTRA = " & oConsulta.Transaccion

        ad = New OleDb.OleDbDataAdapter(sSQL, CONN_LOCAL)
        dt = New DataTable

        ad.Fill(dt)
        ' btnReporte.Enabled = dt.Rows.Count > 0

        lblTitulo.Text = oConsulta.Nombre
        lblSubtitulo.Text = oConsulta.Descripcion
        Me.Text = oConsulta.Transaccion & " - " & oConsulta.Nombre

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'VARIABLES
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        For Each oVar In oVariables

            nC = nC + 1

            Dim lblInput As New Label

            'Labels
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If oVar.Help <> 2 And oVar.Help <> 3 Then
                lblInput.Name = "_lbl" & oVar.Nombre
                If oVar.Titulo.Contains(":") Then
                    lblInput.Text = oVar.Titulo
                Else
                    lblInput.Text = oVar.Titulo & ":"
                End If

                lblInput.Location = New System.Drawing.Point(5, PanTop.Height + 23 * oVar.Orden - 17)
                lblInput.Size() = New System.Drawing.Size(200, 18)
                PanControles.Controls.Add(lblInput)
            End If

            Select Case oVar.Help
                Case 0
                    If oVar.Tipo = 2 Then

                        Dim oFecha As New DateTimePicker

                        With oFecha
                            .Name = "_" & oVar.Nombre
                            .CustomFormat = "dd/MM/yyyy"
                            .Format = DateTimePickerFormat.Custom
                            .Visible = True
                            .Value = Date.Today ' DateAdd(DateInterval.Day, -DateTime.Today.Day, DateTime.Today)
                            .Location = New System.Drawing.Point(210, PanTop.Height + 23 * oVar.Orden - 21)
                            .Size() = New System.Drawing.Size(130, 18)

                        End With

                        PanControles.Controls.Add(oFecha)

                    Else

                        Dim oTextBox As New TextBox

                        oTextBox.Name = "_" & oVar.Nombre
                        oTextBox.Text = ""
                        oTextBox.Location = New System.Drawing.Point(210, PanTop.Height + 23 * oVar.Orden - 21)
                        oTextBox.Size() = New System.Drawing.Size(130, 18)
                        PanControles.Controls.Add(oTextBox)

                    End If

                Case 1 'SQL
                    Dim oCombo As New Windows.Forms.ComboBox

                    oCombo.Name = "_" & oVar.Nombre
                    oCombo.Location = New System.Drawing.Point(210, PanTop.Height + 23 * oVar.Orden - 21)
                    oCombo.Size() = New System.Drawing.Size(400, 18)
                    oCombo.DropDownStyle = ComboBoxStyle.DropDownList
                    PanControles.Controls.Add(oCombo)
                    CargarCombo(oCombo, oVar.HelpQuery)
                    oCombo.Text = "<Seleccione...>"


                Case 2 'ENTIDAD
                    Dim oTextBox As New TextBox

                    oTextBox.Name = "_" & oVar.Nombre
                    oTextBox.Text = CODIGO_ENTIDAD
                    oTextBox.Visible = False
                    nC = nC - 1
                    PanControles.Controls.Add(oTextBox)

                Case 3 'CUADRO
                    Dim oTextBox As New TextBox

                    oTextBox.Name = "_" & oVar.Nombre
                    oTextBox.Text = oAdmTablas.DevolverValor("TABGEN", "TG_CODCON", "TG_CODTAB = 2 AND TG_NUME01 = " & CODIGO_TRANSACCION, "0").ToString
                    oTextBox.Visible = False
                    nC = nC - 1
                    PanControles.Controls.Add(oTextBox)

                Case 4 'CONDICIONAL
                    Dim oCheckBox As New CheckBox

                    oCheckBox.Name = "_" & oVar.Nombre
                    oCheckBox.Location = New System.Drawing.Point(210, PanTop.Height + 23 * oVar.Orden - 19)
                    oCheckBox.Size() = New System.Drawing.Size(120, 18)
                    oCheckBox.Text = ""
                    oCheckBox.Tag = oVar.HelpQuery
                    PanControles.Controls.Add(oCheckBox)

            End Select

        Next

        ad.Dispose()
        dt.Dispose()

        PanControles.Height = PanTop.Height + 23 * nC + 3

        ad.Dispose()
        dt.Dispose()

        Columnas()

        HabilitarBotones()

    End Sub

    Function TranslateColor(ByVal clr As Long) As Long
        If OleTranslateColor(clr, 0, TranslateColor) Then
            TranslateColor = -1
        End If
    End Function

    Private Sub RefreshCombosVariables()
        Try
            Dim i As Integer
            For i = 0 To PanControles.Controls.Count - 1
                If TypeOf (PanControles.Controls.Item(i)) Is ComboBox Then
                    Dim combo As ComboBox = CType(PanControles.Controls.Item(i), ComboBox)
                    Dim txtSelected = combo.SelectedItem
                    Dim oVar As clsVariables
                    For Each oVar In oVariables
                        If combo.Name = "_" & oVar.Nombre Then
                            combo.Items.Clear()
                            CargarCombo(combo, oVar.HelpQuery)
                            combo.SelectedItem = txtSelected
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            TratarError(ex, "RefreshCombosVariables")
        End Try
    End Sub

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        If DatosOK() Then
            Try
                bHabilitado = False
                Me.Cursor = Cursors.WaitCursor
                Ejecutar()
                RefreshCombosVariables()
            Finally
                Me.Cursor = Cursors.Default
                bHabilitado = True
            End Try
        End If
    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oAdmTablas.ConnectionString = CONN_LOCAL
        AnalizarCommand()

    End Sub

    Private Function FormatearColumna(ByVal oColumna As DevExpress.XtraGrid.Columns.GridColumn) As Boolean

        Dim fmt As StyleFormatCondition = New StyleFormatCondition()
        Dim oFont As Font
        Dim oEstiloFuente As FontStyle
        Dim oFmt As clsFormatosColumnas = New clsFormatosColumnas()

        oFmt = oFormato(oColumna.FieldName)

        If oFmt.Ancho = 0 Then
            oColumna.OptionsColumn.FixedWidth = True
        Else
            oColumna.Width = IIf(oFmt.Ancho = 0, 1000, oFmt.Ancho)
        End If

        If Not (oFmt.Formato Is Nothing) AndAlso (oFmt.Formato.ToLower() <> "standard") Then
            oColumna.DisplayFormat.FormatType = FormatType.Custom
            oColumna.DisplayFormat.FormatString = oFmt.Formato
        End If

        If Not bFmtEmb Then
            If oFmt.Condicion = "" Then
                If oFmt.Negrita Then oEstiloFuente = FontStyle.Bold
                If oFmt.Subrayado Then oEstiloFuente = oEstiloFuente + FontStyle.Underline
                If oFmt.Tachado Then oEstiloFuente = oEstiloFuente + FontStyle.Strikeout

                If oFmt.Fuente <> "" Then
                    oFont = New Font(oFmt.Fuente, oFmt.Tamano, oEstiloFuente)
                    oColumna.AppearanceCell.Font = oFont
                End If

                If oFmt.Frente <> 0 Then oColumna.AppearanceCell.ForeColor = System.Drawing.ColorTranslator.FromWin32(oFmt.Frente)
                If oFmt.Fondo <> 0 Then oColumna.AppearanceCell.BackColor = System.Drawing.ColorTranslator.FromWin32(oFmt.Fondo)

                Return True
            End If
        Else
            Return True
        End If

    End Function

    Private Function FormatoCondicional(ByVal sCampo As String) As Boolean

        Dim fmt As StyleFormatCondition = New StyleFormatCondition()
        Dim sValor() As String
        Dim oFmt As clsFormatosColumnas
        Dim nC As Long

        oFmt = oFormato(sCampo)

        If oFmt.Condicion <> "" Then

            GridView1.FormatConditions.Add(fmt)
            fmt.Column = GridView1.Columns(sCampo)

            If oFmt.Condicion.IndexOf("|") > 0 Then
                sValor = oFmt.Condicion.Split("|")

                If sValor.Length > 2 Then
                    For nC = LBound(sValor) To UBound(sValor)
                        fmt.Condition = FormatConditionEnum.Equal
                        fmt.Value1 = sValor(nC)

                        EstablecerFmt(fmt, oFmt)

                        If nC < UBound(sValor) Then
                            fmt = New StyleFormatCondition()
                            GridView1.FormatConditions.Add(fmt)
                            fmt.Column = GridView1.Columns(sCampo)
                        End If

                    Next
                Else
                    fmt.Condition = FormatConditionEnum.Between
                    fmt.Value1 = sValor(0)
                    fmt.Value2 = sValor(1)
                    EstablecerFmt(fmt, oFmt)
                End If
            Else
                fmt.Condition = FormatConditionEnum.Equal
                Dim result As Integer
                'Todo: revisar formato condicional xej: BALANA
                If Integer.TryParse(oFmt.Condicion, result) Then
                    fmt.Value1 = result
                Else
                    fmt.Value1 = oFmt.Condicion
                End If
                EstablecerFmt(fmt, oFmt)
            End If

            Return True

        End If

    End Function

    Private Sub EstablecerFmt(ByVal fmt As StyleFormatCondition, ByVal oFmt As clsFormatosColumnas)

        Dim oFont As Font
        Dim oEstiloFuente As System.Drawing.FontStyle

        If oFmt.Negrita Then oEstiloFuente = oEstiloFuente + FontStyle.Bold
        If oFmt.Subrayado Then oEstiloFuente = oEstiloFuente + FontStyle.Underline
        If oFmt.Tachado Then oEstiloFuente = oEstiloFuente + FontStyle.Strikeout

        If oFmt.Fuente <> "" Then
            oFont = New Font(oFmt.Fuente, oFmt.Tamano, oEstiloFuente)
        Else
            oFont = New Font("Tahoma", 8, oEstiloFuente)
        End If

        If oFmt.Fondo <> 0 Then fmt.Appearance.BackColor = System.Drawing.ColorTranslator.FromWin32(oFmt.Fondo)
        If oFmt.Frente <> 0 Then fmt.Appearance.ForeColor = System.Drawing.ColorTranslator.FromWin32(oFmt.Frente)

        fmt.Appearance.Font = oFont
        fmt.ApplyToRow = True

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        GuardarLOG(AccionesLOG.ExportacionDeDatos, "Parámetros utilizados: " + sExtra_log, CODIGO_TRANSACCION, UsuarioActual.Codigo)

        frmExportar.PasarViewResultados(Me.Text, Me.lblTitulo.Text, GridView1)
        frmExportar.ShowDialog()

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click


        VistaPrevia(Me.lblTitulo.Text)
        'Grid.ShowPrintPreview()

    End Sub

    Private Sub EstablecerLenguaje()

        BarLocalizer.Active = New cBarsLocalizer()
        GridLocalizer.Active = New cGridLocalizer()
        PivotGridLocalizer.Active = New cPivotGridLocalizer()
        ChartLocalizer.Active = New cChartLocalizer()
        PreviewLocalizer.Active = New cPrintingLocalizer()
        BarLocalizer.Active = New cBarsLocalizer()
        Localizer.Active = New cEditorsLocalizer()
        ReportLocalizer.Active = New cReportsLocalizer()

    End Sub

    Private Sub Grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.DoubleClick

        If ValidaUpdate() Then
            If Not UsuarioActual.SoloLectura Then
                Modificar()
            End If
        ElseIf ValidarDrillDown() Then
            DrillDown()
        End If

    End Sub

    'Public Function ReemplazarVariables(ByVal sSQL As String) As String

    '    Dim oCtl As Windows.Forms.Control
    '    Dim sValor As String
    '    Dim oItem As clsItem.Item

    '    For Each oCtl In PanControles.Controls

    '        Select Case oCtl.GetType.ToString.Substring(oCtl.GetType.ToString.LastIndexOf(".") + 1)
    '            Case "ComboBox"
    '                oItem = CType(oCtl, ComboBox).SelectedItem
    '                sValor = oItem.Valor
    '            Case "ComboBoxEdit"
    '                oItem = CType(oCtl, DevExpress.XtraEditors.ComboBoxEdit).SelectedItem
    '                sValor = oItem.Valor
    '            Case "CheckBox"
    '                sValor = IIf(CType(oCtl, CheckBox).Checked, oCtl.Tag, "")
    '            Case "CheckEdit"
    '                sValor = IIf(CType(oCtl, DevExpress.XtraEditors.CheckEdit).Checked, oCtl.Tag, "")
    '            Case "DateTimePicker"
    '                sValor = FechaSQL(DirectCast(oCtl, DateTimePicker).Value)
    '            Case "DateEdit"
    '                sValor = FechaSQL(DirectCast(oCtl, DevExpress.XtraEditors.DateEdit).DateTime)
    '            Case Else
    '                sValor = oCtl.Text
    '        End Select

    '        If oCtl.Name.Substring(0, 1) = "_" Then
    '            sSQL = sSQL.Replace(oCtl.Name.Substring(1), sValor)
    '        End If

    '    Next

    '    Return sSQL

    'End Function


    Private Sub Adjuntar()

        Try
            'Dim sClave As String = String.Empty

            'Dim sSQL = "SELECT DS_ORDEN " &
            '  "FROM   DETSYS " &
            '  "WHERE  DS_CODCON = " & oConsulta.CodCon.ToString & " " &
            '  "AND    DS_LLAVE  = 1 " &
            '  "ORDER  BY DS_ORDEN "
            'Dim RS As DataSet = oAdmTablas.AbrirDataset(sSQL)

            'sSQL = "SELECT "

            'With RS
            '    If (.Tables.Count > 0) Then
            '        For Each oRow As DataRow In RS.Tables(0).Rows
            '            Dim vValor = GridView1.GetRowCellValue(GridView1.GetRowHandle(GridView1.GetSelectedRows(0)), GridView1.Columns.Item("K" & oRow("DS_ORDEN").ToString())).ToString
            '            sClave = sClave & vValor & ";"

            '        Next
            '    End If

            'End With
            If GridView1.SelectedRowsCount > 0 Then

                Dim frmAdjuntar As New frmAdjuntos()
                frmAdjuntar.PasarDatos(ClaveFormulario(";"))
                frmAdjuntar.ShowDialog(Me)

                frmAdjuntar.Dispose()
            Else
                MensajeInformacion("No hay registros seleccionados")
            End If
        Catch ex As Exception
            TratarError(ex, "Adjuntar")
        End Try
    End Sub


    Private Sub Modificar(Optional ByVal MODO_APE As String = "M")

        Dim sSQL As String
        Dim oCol As clsColumnas
        Dim vValor As Object

        Me.Enabled = False

        If MODO_APE = "N" Then
            sSQL = oConsulta.NuevoDesdeQuery
        ElseIf MODO_APE = "B" Then
            sSQL = oConsulta.BajaQuery
        ElseIf MODO_APE = "A" Then
            sSQL = oConsulta.AltaQuery
        Else
            sSQL = oConsulta.ActualizaQuery
        End If

        If Grid.MainView.RowCount > 0 And MODO_APE <> "A" Then

            For Each oCol In oColumnas

                vValor = GridView1.GetRowCellDisplayText(GridView1.GetRowHandle(GridView1.GetSelectedRows(0)), oCol.Campo).ToString

                If Not String.IsNullOrEmpty(vValor.ToString) Then
                    If TipoDatosADO(oCol.Tipo) = "Fecha/Hora" Then
                        vValor = FechaSQL(vValor)
                    ElseIf TipoDatosADO(oCol.Tipo) = "Numérico" Then
                        vValor = FlotanteSQL(vValor)
                    Else
                        vValor = "'" & vValor & "'"
                    End If
                Else
                    vValor = "NULL"
                End If

                sSQL = sSQL.Replace("@" & oCol.Campo, vValor)

            Next
        End If

        sSQL = ReemplazarVariables(sSQL, PanControles.Controls)

        Me.Enabled = True

        Dim oForm As New frmABMRegistro()
        oForm.PasarDatos(oConsulta.CodCon, sSQL, "Modificar registro", MODO_APE)

        If INPUT_GENERAL = "CERRAR_FORMULARIO_YAA" Then
            oForm.Close()
        Else
            oForm.ShowDialog()
        End If

        oForm = Nothing

Maneja_Error:
        'Err.Clear()

        Me.Enabled = True

        '      If bActualizado Then
        ' Ejecutar()
        ' Grid.Row = nLastRow
        ' Grid.Col = nLastCol
        ' bActualizado = False
        ' End If

    End Sub

    Private Sub btnModif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModif.Click
        Modificar()
    End Sub

    Private Sub btnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        Modificar("A")
    End Sub

    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        Modificar("B")
    End Sub

    Private Sub Comentarios()

        ' Dim oCol As clsColumnas
        ' Dim sClave As String = ""

        If GridView1.SelectedRowsCount > 0 Then
            'For Each oCol In oColumnas
            '    If oCol.Clave Then
            '        sClave = sClave & GridView1.GetRowCellDisplayText(GridView1.GetRowHandle(GridView1.GetSelectedRows(0)), oCol.Campo).ToString
            '    End If
            'Next

            frmNotas.PasarDatos(ClaveFormulario("|"))
            frmNotas.ShowDialog()
        Else
            MensajeInformacion("No hay registros seleccionados")
        End If

    End Sub

    Private Sub btnComent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComent.Click
        GuardarLOG(AccionesLOG.ActualizacionDeComentarios, "Parámetros utilizados: " + sExtra_log, CODIGO_TRANSACCION, UsuarioActual.Codigo)
        Comentarios()
    End Sub

    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GenerarReporte()
    End Sub

    Private Sub GenerarReporte()

        Dim ds As DataSet
        Dim sSQL As String
        Dim oReporte As New Collection
        Dim oVar As clsReportes
        Dim sHTML As String
        Dim sArchivo As String = ""
        Dim oField As DataColumn
        Dim nCont As Long
        Dim sVar As String
        Dim bHoriz As Boolean
        Dim encoding As System.Text.Encoding = System.Text.Encoding.GetEncoding("ISO-8859-1")

        sSQL = "SELECT    * " &
               "FROM      REPORT " &
               "WHERE     RO_CODENT IN (@CODENT, 0) " &
               "AND       RO_CODTRA = " & CODIGO_TRANSACCION & " " &
               "AND       RO_FECVIG = ( " &
               "                       SELECT   MAX(RO_FECVIG) " &
               "                       FROM     REPORT " &
               "                       WHERE    RO_CODENT IN (@CODENT, 0) " &
               "                       AND      RO_CODTRA = " & CODIGO_TRANSACCION & " " &
               "                       AND      RO_FECVIG <= @FECVIG) " &
               "AND       RO_REPITE IN (0, 1) "

        sSQL = ReemplazarVariables(sSQL, PanControles.Controls)
        sSQL = Replace(sSQL, "@CODENT", CODIGO_ENTIDAD)
        sSQL = Replace(sSQL, "@FECVIG", FechaSQL(Date.Today))
        ds = oAdmTablas.AbrirDataset(sSQL)

        If ds.Tables(0).Rows.Count = 0 Then
            MensajeError("No hay reporte disponible para el período indicado.")
            Exit Sub
        End If

        For Each oRow As DataRow In ds.Tables(0).Rows

            For Each oField In ds.Tables(0).Columns
                If UCase(oField.ColumnName) = "RO_QUERY" Then
                    sSQL = "" & oRow("RO_QUERY").ToString
                End If

                If UCase(oField.ColumnName) = "RO_ORIENT" Then
                    bHoriz = Convert.ToBoolean(Convert.ToInt32(oRow("RO_ORIENT")))
                End If
            Next

            sArchivo = Application.StartupPath & "\Informes\" & oRow("RO_HTML").ToString

            oVar = New clsReportes

            oVar.CodTransaccion = oRow("RO_CODTRA")
            oVar.Campo = oRow("RO_VARIAB").ToString.Replace("@", "")
            oVar.Formato = oRow("RO_FORMAT").ToString
            oVar.Repite = oRow("RO_REPITE")
            oVar.HTML = oRow("RO_HTML").ToString
            oVar.FechaVig = oRow("RO_FECVIG")
            oVar.CodEntidad = oRow("RO_CODENT")
            oVar.Key = oRow("RO_VARIAB").ToString.Replace("@", "")

            oReporte.Add(oVar, oVar.Key)

            oVar = Nothing

        Next

        'CAPTURO EL HTML
        If Not File.Exists(sArchivo) Then
            MensajeError("Falta el reporte " & sArchivo)
            Exit Sub
        End If

        sHTML = File.ReadAllText(sArchivo, encoding)

        If sHTML.IndexOf("{NumPag}", StringComparison.OrdinalIgnoreCase) > 0 Then

            frmInputGeneral.PasarInfoVentana("Página inicial", "Ingrese el número de página inicial")
            frmInputGeneral.txtResultado.Text = "1"

            If frmInputGeneral.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

            nPagInicial = Val(INPUT_GENERAL)

            If nPagInicial = 0 Then nPagInicial = 1

        End If

        If CODIGO_TRANSACCION = 14001 Then
            sSQL = "SELECT       DATCUA.*, TG_DESCRI " &
                   "FROM         DATCUA " &
                   "LEFT JOIN    TABGEN " &
                   "ON           DC_CODENT = TG_CODCON " &
                   "AND          TG_CODTAB = 1 " &
                   "WHERE        DC_CUADRO = @CUADRO " &
                   "AND          DC_FECVIG = @FECVIG " &
                   "AND          DC_CODENT = @CODENT " &
                   "AND          CAST(DC_CODCON AS INT) = @CODCON " &
                   "AND          DC_ACTIVA = 1 " &
                   "AND          DC_NIVELTAB = 1 " &
                   "ORDER BY     DC_ORDEN, DC_CODPAR, DC_CAMPO8 ASC"
        End If

        sSQL = Replace(sSQL, "@CODENT", CODIGO_ENTIDAD)
        ds = oAdmTablas.AbrirDataset(ReemplazarVariables(sSQL, PanControles.Controls))

        For Each oRow As DataRow In ds.Tables(0).Rows
            nCont = nCont + 1

            For Each oField In ds.Tables(0).Columns
                For Each oVar In oReporte
                    If oField.ColumnName = oVar.Key Then

                        If oVar.Formato.IndexOf("MMMM") > 0 Then
                            sVar = UCase(Format(oRow(oField.ColumnName), oVar.Formato))
                        ElseIf (oVar.Formato.IndexOf("#") > 0) And (oVar.Formato.Substring(oVar.Formato.Length) = "-") Then
                            If oRow(oField.ColumnName).ToString.Trim <> "" Then
                                sVar = Format(oRow(oField.ColumnName), oVar.Formato.Replace("-", ""))
                            Else
                                sVar = "-"
                            End If
                        Else
                            If oRow(oField.ColumnName) Is DBNull.Value Then
                                sVar = ""
                            Else
                                sVar = IIf(oVar.Formato.Trim <> "", Format(oRow(oField.ColumnName), oVar.Formato), oRow(oField.ColumnName).ToString)
                            End If
                        End If
                        If oVar.Repite Then
                            sHTML = sHTML.Replace("@" & oVar.Campo & "_" & nCont.ToString & "@", sVar)
                        Else
                            sHTML = sHTML.Replace("@" & oVar.Campo & "@", sVar)
                        End If
                    End If
                Next
            Next

        Next

        'Creacion del PDF

        'If btnGrafico.Visible Then
        '    frmGrafico.PasarDatos(Grid)
        '    frmGrafico.Exportar(Application.StartupPath & "\Informes\" & CODIGO_TRANSACCION & ".jpg")
        '    frmGrafico.Close()
        'End If

        If sHTML.IndexOf("<detalle>", System.StringComparison.OrdinalIgnoreCase) > 0 Then
            GenerarDetalle(sHTML)
        Else

            sHTML = Replace(sHTML, "SRC=" & Chr(34), "SRC=" & Chr(34) & Application.StartupPath & "\Informes\", , , vbTextCompare)
            sHTML = Replace(sHTML, "SRC='", "SRC='" & Application.StartupPath & "\Informes\", , , vbTextCompare)
            sHTML = Replace(sHTML, "{NumPag}", nPagInicial, 1, -1, vbTextCompare)

            File.WriteAllText(CARPETA_LOCAL & "TEMP\temp.html", sHTML, encoding)

            ConvertirHTMLenPDF(CARPETA_LOCAL & "TEMP\Temp.HTML", CARPETA_LOCAL & "SPOOL\TRX" & CODIGO_TRANSACCION & ".PDF", Not bHoriz)
        End If

        Process.Start(CARPETA_LOCAL & "SPOOL\TRX" & CODIGO_TRANSACCION & ".PDF")

        File.Delete(CARPETA_LOCAL & "TEMP\temp.html")


    End Sub

    Private Sub GenerarDetalle(ByVal sHTML As String)

        Dim ds As DataSet
        Dim sSQL As String
        Dim oReporte As New Collection
        Dim oVar As clsReportes
        Dim sArchivo As String = ""
        Dim oField As DataColumn
        Dim nCont As Long
        Dim sVar As String
        Dim sFuente As String
        Dim sDetalle As String
        Dim sSalida As String
        Dim nMax As Integer
        Dim nPos1 As Long
        Dim bFlag As Boolean
        Dim bFlagSale As Boolean
        Dim nPag As Long
        Dim nPagina As Integer
        Dim oDoc As New ABCpdf7.Doc()
        Dim sPag As String
        Dim w, h, l, b As Long
        Dim bHorizontal As Boolean
        Dim bAdicionar As Boolean
        Dim sEncPag As String
        Dim sPiePag As String
        Dim sTemp As String
        Dim bSaltoPag As Boolean
        Dim encoding As System.Text.Encoding = System.Text.Encoding.GetEncoding("ISO-8859-1")

        sSQL = "SELECT    * " &
               "FROM      REPORT " &
               "WHERE     RO_CODENT IN (@CODENT, 0) " &
               "AND       RO_CODTRA = " & CODIGO_TRANSACCION & " " &
               "AND       RO_FECVIG = ( " &
               "                       SELECT   MAX(RO_FECVIG) " &
               "                       FROM     REPORT " &
               "                       WHERE    RO_CODENT IN (@CODENT, 0) " &
               "                       AND      RO_CODTRA = " & CODIGO_TRANSACCION & " " &
               "                       AND      RO_FECVIG <= @FECVIG) " &
               "AND       RO_REPITE IN (2) "

        sSQL = ReemplazarVariables(sSQL, PanControles.Controls)
        sSQL = Replace(sSQL, "@CODENT", CODIGO_ENTIDAD)
        sSQL = Replace(sSQL, "@FECVIG", FechaSQL(Date.Today))
        ds = oAdmTablas.AbrirDataset(sSQL)

        With ds.Tables(0)
            If .Rows.Count = 0 Then
                Exit Sub
            Else
                For Each oRow As DataRow In .Rows
                    For Each oField In .Columns
                        If oField.ColumnName.ToUpper = "RO_QUERY" Then
                            sSQL = oRow(oField.ColumnName)
                        End If

                        If oField.ColumnName.ToUpper = "RO_MAXDET" Then
                            If Not (oRow(oField.ColumnName) Is DBNull.Value) Then
                                nMax = oRow(oField.ColumnName)
                            End If
                        End If

                        If oField.ColumnName.ToUpper = "RO_ORIENT" Then
                            If Not (oRow(oField.ColumnName) Is DBNull.Value) Then
                                bHorizontal = Convert.ToBoolean(Convert.ToInt32(oRow(oField.ColumnName)))
                            End If
                        End If

                    Next

                    sArchivo = Application.StartupPath & "\Informes\" & oRow("RO_HTML")

                    oVar = New clsReportes

                    oVar.CodTransaccion = oRow("RO_CODTRA")
                    oVar.Campo = oRow("RO_VARIAB").ToString.Replace("@", "")
                    oVar.Formato = oRow("RO_FORMAT")
                    oVar.Repite = Convert.ToBoolean(Convert.ToInt32(oRow("RO_REPITE")))
                    oVar.HTML = oRow("RO_HTML")
                    oVar.FechaVig = oRow("RO_FECVIG")
                    oVar.CodEntidad = oRow("RO_CODENT")
                    oVar.Key = oRow("RO_VARIAB").ToString.Replace("@", "")

                    oReporte.Add(oVar)

                    oVar = Nothing

                Next
            End If
        End With

        ds = Nothing

        If nMax = 0 Then
            nMax = 20
        End If

        'CAPTURO EL HTML
        sArchivo = Replace(sArchivo, ".html", "_det.html", 1, -1, CompareMethod.Text)
        If Not File.Exists(sArchivo) Then
            Exit Sub
        End If

        sSalida = sHTML
        sHTML = ""

        sFuente = File.ReadAllText(sArchivo, encoding)

        sFuente = Replace(Replace(sFuente, "</BODY>", "", 1, -1, vbTextCompare), "</HTML>", "", 1, -1, vbTextCompare)
        sFuente = Replace(Replace(sFuente, "<BODY>", "", 1, -1, vbTextCompare), "<HTML>", "", 1, -1, vbTextCompare)

        ProcesarDetalle(sFuente)

        sSQL = sSQL.Replace("@CODENT", CODIGO_ENTIDAD)
        ds = oAdmTablas.AbrirDataset(ReemplazarVariables(sSQL, PanControles.Controls))

        sDetalle = ""

        With ds.Tables(0)
            sEncPag = Detalle(0).Encabezado
            sPiePag = Detalle(0).Pie

            For Each oRow As DataRow In .Rows
                nCont = nCont + 1
                nPag = nPag + 1

                sFuente = Detalle(0).CodigoHTML

                'EVALUO SI DEBO ADICIONAR AL CAMPO RENGLONES
                For Each oField In .Columns
                    If oField.ColumnName.ToUpper = "RENGLON" Then
                        nPag = nPag + oRow(oField.ColumnName)
                        Exit For
                    End If
                Next

                'EVALUO SI SE PROCESA UN SI O EL DETALLE NORMAL
                If UBound(Detalle) > 0 Then
                    For Each oField In .Columns

                        bFlagSale = False

                        For nPos1 = 1 To UBound(Detalle)

                            If "@" & oField.ColumnName.ToUpper & "@" = Detalle(nPos1).Variable.ToUpper Then
                                If oRow(oField.ColumnName).ToString = Detalle(nPos1).Condicion.ToString Then
                                    sFuente = Detalle(nPos1).CodigoHTML

                                    If nPag = 1 And sFuente.IndexOf("<NO_PRIMERO/>", 0, StringComparison.OrdinalIgnoreCase) > 0 Then
                                        sFuente = sFuente.Substring(sFuente.IndexOf("<NO_PRIMERO/>", 0, StringComparison.OrdinalIgnoreCase))
                                    End If

                                    sFuente = Replace(sFuente, "<NO_PRIMERO/>", "", 1, -1, vbTextCompare)

                                    bFlagSale = True
                                    Exit For
                                End If
                            ElseIf Detalle(nPos1).Variable.ToUpper = "PAG" Then
                                If (nPagina + 1).ToString = Detalle(nPos1).Condicion.ToString Then
                                    sPag = Detalle(nPos1).CodigoHTML
                                    If Not bAdicionar Then
                                        nPag = nPag + 3
                                        bAdicionar = True
                                    End If
                                End If
                            End If

                        Next nPos1

                        If bFlagSale Then
                            Exit For
                        End If

                    Next
                End If

                sTemp = sDetalle
                sDetalle = sDetalle & sFuente

                bFlag = True

                '2009/09/16 AGREGUE LA OPCION DE EJECUTA UN CODIGO SI
                'SE PRODUCE UN SALTO DE PAGINA
                If (nPag >= nMax) Or (InStr(1, sFuente, "<SALTO_PAGINA/>", vbTextCompare)) Then

                    For nPos1 = 1 To UBound(Detalle)
                        If UCase(Detalle(nPos1).Variable) = "SALTO_PAGINA" Then
                            If (CStr(nPagina + 1) = CStr(Detalle(nPos1).Condicion) And
                                Val(Detalle(nPos1).Condicion) <> 0) Or
                                Val(Detalle(nPos1).Condicion) = 0 Then
                                sDetalle = sDetalle & Detalle(nPos1).CodigoHTML
                                Exit For
                            End If
                        End If
                    Next nPos1

                End If

Reinicio:

                For Each oField In .Columns

                    For Each oVar In oReporte
                        If oField.ColumnName.ToUpper = oVar.Key.ToUpper Then

                            If oVar.Formato.IndexOf("MMMM") > 0 Then
                                If (oRow(oField.ColumnName) Is DBNull.Value) Then
                                    sVar = ""
                                Else
                                    If IsDate(oRow(oField.ColumnName)) Then
                                        sVar = UCase(Format(Convert.ToDateTime(oRow(oField.ColumnName)), oVar.Formato.Replace("DD", "dd").Replace("YYYY", "yyyy")))
                                    Else
                                        If oRow(oField.ColumnName).ToString.Trim <> "" Then
                                            sVar = UCase(Format(Convert.ToDateTime(oRow(oField.ColumnName)), oVar.Formato.Replace("DD", "dd").Replace("YYYY", "yyyy")))
                                        Else
                                            sVar = ""
                                        End If
                                    End If
                                End If
                            ElseIf (oVar.Formato.IndexOf("#") > 0) And (oVar.Formato.Substring(oVar.Formato.Length) = "-") Then
                                If IsNumeric(oRow(oField.ColumnName)) Then
                                    If oRow(oField.ColumnName).ToString.Trim <> "" Then
                                        sVar = Format(oRow(oField.ColumnName), oVar.Formato.Replace("-", ""))
                                    Else
                                        sVar = "-"
                                    End If
                                Else
                                    sVar = oRow(oField.ColumnName).ToString
                                End If
                            Else
                                If oRow(oField.ColumnName) Is DBNull.Value Then
                                    sVar = ""
                                Else
                                    sVar = IIf(oVar.Formato.Trim <> "", Format(oRow(oField.ColumnName), oVar.Formato), oRow(oField.ColumnName).ToString)
                                End If
                            End If

                            If InStr(1, sVar, "<SALTO_PAGINA/>", vbTextCompare) Then
                                sVar = Replace(sVar, "<SALTO_PAGINA/>", "", 1, -1, vbTextCompare)
                                If Not bSaltoPag Then
                                    SaltoPagina(sTemp, oDoc, nPag, nMax, bHorizontal, sHTML, sEncPag, sPiePag, sSalida, sPag, bFlag, bAdicionar, nPagina)
                                    sDetalle = sFuente
                                    bSaltoPag = True
                                    GoTo Reinicio
                                End If
                            End If

                            sDetalle = Replace(sDetalle, "@" & oVar.Campo & "@", sVar)
                            sEncPag = Replace(sEncPag, "@" & oVar.Campo & "@", sVar)
                            sPiePag = Replace(sPiePag, "@" & oVar.Campo & "@", sVar)

                            If sPag <> "" Then
                                sPag = Replace(sPag, "@" & oVar.Campo & "@", sVar)
                            End If

                            Exit For

                        End If
                    Next
                Next

                bSaltoPag = False

                If (nPag >= nMax) Or (InStr(1, sFuente, "<SALTO_PAGINA/>", vbTextCompare)) Then

                    nPagina = nPagina + 1
                    oDoc.Page = oDoc.AddPage
                    bAdicionar = False

                    If Not bHorizontal Then
                        If nPagina = 1 Then
                            oDoc.Rect.Inset(0, -5)
                        End If
                    Else

                        If nPagina = 1 Then
                            oDoc.Rect.Inset(-5, 10)
                            w = oDoc.MediaBox.Width
                            h = oDoc.MediaBox.Height
                            l = oDoc.MediaBox.Left
                            b = oDoc.MediaBox.Bottom
                            oDoc.Transform.Rotate(90, l, b)
                            oDoc.Transform.Translate(w, 0)

                            oDoc.Rect.Width = h
                            oDoc.Rect.Height = w
                        End If

                    End If


                    sHTML = Replace(sSalida, "<DETALLE>", sEncPag & sDetalle & sPiePag, 1, -1, vbTextCompare)
                    sHTML = Replace(sHTML, "{NumPag}", nPagina + nPagInicial - 1, 1, -1, vbTextCompare)

                    sEncPag = Detalle(0).Encabezado
                    sPiePag = Detalle(0).Pie

                    If sPag <> "" Then
                        sHTML = Replace(sHTML, "<PAG" & nPagina & ">", sPag, 1, -1, vbTextCompare)
                        sPag = ""
                    End If

                    If nPagina > 1 Then
                        sHTML = Replace(sHTML, "<CONT/>", "(Cont.)", 1, -1, vbTextCompare)
                    End If
                    sDetalle = ""
                    nPag = 0
                    bFlag = False

                    sHTML = Replace(sHTML, "SRC=" & Chr(34), "SRC=" & Chr(34) & Application.StartupPath & "\Informes\", , , vbTextCompare)
                    sHTML = Replace(sHTML, "SRC='", "SRC='" & Application.StartupPath & "\Informes\", , , vbTextCompare)

                    File.WriteAllText(CARPETA_LOCAL & "TEMP\temp.html", sHTML, encoding)

                    oDoc.AddImageUrl("file:///" & Replace(CARPETA_LOCAL & "TEMP\temp.html", "\", "/"), False, 0, True)

                    sHTML = sSalida
                End If

            Next
        End With

        ds = Nothing

        If bFlag Then
            nPagina = nPagina + 1
            oDoc.Page = oDoc.AddPage

            If Not bHorizontal Then
                If nPagina = 1 Then
                    oDoc.Rect.Inset(0, -5)
                End If
            Else

                If nPagina = 1 Then
                    oDoc.Rect.Inset(-5, 10)
                    w = oDoc.MediaBox.Width
                    h = oDoc.MediaBox.Height
                    l = oDoc.MediaBox.Left
                    b = oDoc.MediaBox.Bottom
                    oDoc.Transform.Rotate(90, l, b)
                    oDoc.Transform.Translate(w, 0)

                    oDoc.Rect.Width = h
                    oDoc.Rect.Height = w
                End If

            End If

            For nPos1 = 1 To UBound(Detalle)
                If UCase(Detalle(nPos1).Variable) = "SALTO_PAGINA" Then
                    If (CStr(nPagina + 1) = CStr(Detalle(nPos1).Condicion) And
                        Val(Detalle(nPos1).Condicion) <> 0) Or
                       Val(Detalle(nPos1).Condicion) = 0 Then
                        sDetalle = sDetalle & Detalle(nPos1).CodigoHTML
                        Exit For
                    End If
                End If
            Next nPos1

            sHTML = Replace(sSalida, "<DETALLE>", sEncPag & sDetalle & sPiePag, 1, -1, vbTextCompare)
            sHTML = Replace(sHTML, "{NumPag}", nPagina + nPagInicial - 1, 1, -1, vbTextCompare)

            If nPagina > 1 Then
                sHTML = Replace(sHTML, "<CONT/>", "(Cont.)", 1, -1, vbTextCompare)
            End If

            If sPag <> "" Then
                sHTML = Replace(sHTML, "<PAG" & nPagina & ">", sPag, 1, -1, vbTextCompare)
                sPag = ""
            End If

            sHTML = Replace(sHTML, "SRC=" & Chr(34), "SRC=" & Chr(34) & Application.StartupPath & "\Informes\", , , vbTextCompare)
            sHTML = Replace(sHTML, "SRC='", "SRC='" & Application.StartupPath & "\Informes\", , , vbTextCompare)

            File.WriteAllText(CARPETA_LOCAL & "TEMP\temp.html", sHTML, encoding)

            oDoc.AddImageUrl("file:///" & Replace(CARPETA_LOCAL & "TEMP\temp.html", "\", "/"), False, 0, True)
        End If

        oDoc.Save(CARPETA_LOCAL & "SPOOL\TRX" & CODIGO_TRANSACCION & ".PDF")

        oDoc = Nothing

    End Sub

    Private Sub ProcesarDetalle(ByVal sFuente As String)

        Dim sTemp As String
        Dim nPos As Long

        ReDim Detalle(0)

        With Detalle(0)
            .SI = False
            .PosIni = InStr(1, sFuente, "<detalle>", vbTextCompare) + 9
            .PosFin = InStrRev(sFuente, "</detalle>", -1, vbTextCompare)
            .Longitud = Len(sFuente) - .PosIni - (Len(sFuente) - .PosFin)
            .CodigoHTML = Mid(sFuente, .PosIni, .Longitud)
            .Encabezado = sFuente.Substring(0, .PosIni - 10)
        End With

        nPos = 1

        If InStr(nPos, sFuente, "</SI>", vbTextCompare) = 0 Then
            Detalle(0).Pie = Mid(sFuente, Detalle(0).PosFin + 10)
            Exit Sub
        End If

        Do While nPos

            ReDim Preserve Detalle(UBound(Detalle) + 1)

            With Detalle(UBound(Detalle))
                .SI = True
                .PosIni = InStr(nPos, sFuente, "<SI ", vbTextCompare) + 4
                .PosFin = InStr(.PosIni, sFuente, ">", vbTextCompare)
                .Longitud = Len(sFuente) - .PosIni - (Len(sFuente) - .PosFin)

                sTemp = Mid(sFuente, .PosIni, .Longitud)

                .Variable = sTemp.Substring(0, InStr(1, sTemp, "=") - 1)
                .Condicion = Mid(sTemp, InStr(1, sTemp, "=") + 1)
                .PosIni = .PosFin + 1
                .PosFin = InStr(.PosIni, sFuente, "</SI>", vbTextCompare)
                .Longitud = Len(sFuente) - .PosIni - (Len(sFuente) - .PosFin)
                .CodigoHTML = Mid(sFuente, .PosIni, .Longitud)

                nPos = InStr(.PosFin + 5, sFuente, "<SI ", vbTextCompare)
            End With

        Loop

        Detalle(0).Pie = Mid(sFuente, Detalle(UBound(Detalle)).PosFin + 5)

    End Sub

    Private Function SaltoPagina(ByRef sDetalle As String,
                                 ByRef oDoc As ABCpdf7.Doc,
                                 ByRef nPag As Long,
                                 ByRef nMax As Integer,
                                 ByRef bHorizontal As Boolean,
                                 ByRef sHTML As String,
                                 ByRef sEncPag As String,
                                 ByRef sPiePag As String,
                                 ByRef sSalida As String,
                                 ByRef sPag As String,
                                 ByRef bFlag As Boolean,
                                 ByRef bAdicionar As Boolean,
                                 ByRef nPagina As Integer) As String

        Dim w, h, l, b As Long
        Dim encoding As System.Text.Encoding = System.Text.Encoding.GetEncoding("ISO-8859-1")

        nPagina = nPagina + 1
        oDoc.Page = oDoc.AddPage
        bAdicionar = False

        If Not bHorizontal Then
            If nPagina = 1 Then
                oDoc.Rect.Inset(0, -5)
            End If
        Else

            If nPagina = 1 Then
                oDoc.Rect.Inset(-5, 10)
                w = oDoc.MediaBox.Width
                h = oDoc.MediaBox.Height
                l = oDoc.MediaBox.Left
                b = oDoc.MediaBox.Bottom
                oDoc.Transform.Rotate(90, l, b)
                oDoc.Transform.Translate(w, 0)

                oDoc.Rect.Width = h
                oDoc.Rect.Height = w
            End If

        End If


        sHTML = Replace(sSalida, "<DETALLE>", sEncPag & sDetalle & sPiePag, 1, -1, vbTextCompare)
        sHTML = Replace(sHTML, "{NumPag}", nPagina + nPagInicial - 1, 1, -1, vbTextCompare)

        sEncPag = Detalle(0).Encabezado
        sPiePag = Detalle(0).Pie

        If sPag <> "" Then
            sHTML = Replace(sHTML, "<PAG" & nPagina & ">", sPag, 1, -1, vbTextCompare)
            sPag = ""
        End If

        If nPagina > 1 Then
            sHTML = Replace(sHTML, "<CONT/>", "(Cont.)", 1, -1, vbTextCompare)
        End If
        sDetalle = ""
        nPag = 0
        bFlag = False

        sHTML = Replace(sHTML, "SRC=" & Chr(34), "SRC=" & Chr(34) & Application.StartupPath & "\Informes\", , , vbTextCompare)
        sHTML = Replace(sHTML, "SRC='", "SRC='" & Application.StartupPath & "\Informes\", , , vbTextCompare)

        File.WriteAllText(CARPETA_LOCAL & "TEMP\temp.html", sHTML, encoding)

        oDoc.AddImageUrl("file:///" & Replace(CARPETA_LOCAL & "TEMP\temp.html", "\", "/"), False, 0, True)

        Return sSalida

    End Function


    Private Sub btnGrafico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmGrafico.PasarDatos(Grid, False)
        frmGrafico.ShowDialog()
        frmGrafico.Close()
    End Sub

    Private Sub btnDrillDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrillDown.Click
        DrillDown()
    End Sub
    Private Function ValidaNDesde() As Boolean
        Try
            If Not oConsulta.NuevoDesde Then
                Return False
            End If

            Dim sSQL = oConsulta.NuevoDesdeQuery.Trim

            If Trim(sSQL) = "" Then
                Return True
            End If

            For Each oCol As clsColumnas In oColumnas
                Dim vValor = GridView1.GetRowCellValue(GridView1.GetRowHandle(GridView1.GetSelectedRows(0)), oCol.Campo).ToString

                If vValor IsNot Nothing Then
                    If TipoDatosADO(oCol.Tipo) = "Fecha/Hora" Then
                        vValor = FechaSQL(vValor)
                    ElseIf TipoDatosADO(oCol.Tipo) = "Numérico" Then
                        vValor = FlotanteSQL(Format(vValor, "Fixed"))
                    Else
                        vValor = "'" & vValor & "'"
                    End If
                Else
                    vValor = "NULL"
                End If

                sSQL = Replace(sSQL, "@" & oCol.Campo, vValor)

            Next

            Dim dt As DataSet = oAdmTablas.AbrirDataset(sSQL)

            If dt.Tables(0) IsNot Nothing Then
                If dt.Tables(0).Rows.Count > 0 Then
                    Return dt.Tables(0).Rows(0).Item(0)
                End If
            End If
            Return False
        Catch ex As Exception
            GuardarLOG(AccionesLOG.AL_ERROR_SISTEMA, "ValidarNDesde", CODIGO_TRANSACCION)
            Return False
        End Try
    End Function

    Private Function ValidaUpdate() As Boolean

        If Grid.MainView.RowCount = 0 Then
            Return False
            Exit Function
        End If

        Try

            Dim ds As DataSet
            Dim oCol As clsColumnas
            Dim vValor As Object
            Dim sSQL As String

            sSQL = oConsulta.ActualizaValida.Trim

            If (Not oConsulta.Actualiza) Or (sSQL = "") Then
                Return False
                Exit Function
            End If

            For Each oCol In oColumnas

                'vValor = GridView1.GetRowCellDisplayText(GridView1.GetRowHandle(GridView1.GetSelectedRows(0)), oCol.Campo).ToString
                vValor = GridView1.GetRowCellValue(GridView1.GetRowHandle(GridView1.GetSelectedRows(0)), oCol.Campo).ToString

                If Not String.IsNullOrEmpty(vValor.ToString) Then
                    If TipoDatosADO(oCol.Tipo) = "Fecha/Hora" Then
                        vValor = FechaSQL(vValor)
                    ElseIf TipoDatosADO(oCol.Tipo) = "Numérico" Then
                        vValor = FlotanteSQL(vValor)
                    Else
                        vValor = "'" & vValor & "'"
                    End If
                Else
                    vValor = "NULL"
                End If

                sSQL = sSQL.Replace("@" & oCol.Campo, vValor)

            Next

            ds = oAdmTablas.AbrirDataset(sSQL)

            Dim bRespuesta As Boolean = False

            If ds.Tables(0).Rows.Count > 0 Then
                Dim oRow As DataRow = ds.Tables(0).Rows(0)

                If oRow(0).Equals(True) Or oRow(0).Equals(False) Then
                    bRespuesta = oRow(0)
                Else
                    bRespuesta = False
                End If

                ds = Nothing
            End If

            Return bRespuesta

        Catch ex As Exception
            TratarError(ex, "ValidaUpdate")
            Return False
        End Try

    End Function

    Private Function ValidarDrillDown() As Boolean

        Dim oCol As clsColumnas
        If Grid.MainView.RowCount = 0 Then
            Return False
            Exit Function
        End If

        If oConsulta.DrillDown And oConsulta.DrillDownQuery.Trim <> "" Then
            Return True
        Else
            For Each oCol In oColumnas
                If oCol.Campo = GridView1.FocusedColumn.FieldName Then
                    If oCol.DrillDown And oCol.DrillDownQuery.Trim <> "" Then
                        Return True
                        Exit For
                    End If
                End If
            Next
        End If

    End Function

    Private Sub GridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GridView1.FocusedColumnChanged
        HabilitarBotones()

    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged



        If bHabilitado Then
            If Not UsuarioActual.SoloLectura Then
                If GridView1.RowCount > 0 Then
                    btnBaja.Enabled = oConsulta.Baja
                    If btnModif.Visible Then
                        btnModif.Enabled = ValidaUpdate()
                    End If

                    If btnNDesde.Visible Then
                        btnNDesde.Enabled = ValidaNDesde
                    End If

                Else
                    btnBaja.Enabled = False
                    btnModif.Enabled = False
                End If
            Else
                btnModif.Enabled = False
            End If

            If btnModif.Enabled Then
                btnDrillDown.Enabled = False
            Else
                btnDrillDown.Enabled = ValidarDrillDown()
            End If

            If btnComent.Enabled Then
                Dim sTemp As String = TieneComentarios()

                If sTemp = "" Then
                    ToolTipText.SetToolTip(Me.Grid, "")
                    ToolTipText.Hide(Me.Grid)
                Else
                    ToolTipText.Show(sTemp, Me.Grid)
                End If

            End If
        End If
    End Sub

    Private Sub DrillDown()

        Dim sSQL As String = ""
        Dim oCol As clsColumnas
        Dim vValor As Object
        Dim bCol As Boolean

        oCol = oColumnas(GridView1.FocusedColumn.FieldName)

        'SI NO SE ESPECIFICO NADA VERIFICA SI HAY DRILL DOWN POR CELDA
        If oCol.Campo = GridView1.FocusedColumn.FieldName Then
            If oCol.DrillDown And oCol.DrillDownQuery.Trim <> "" Then
                bCol = True
                If oCol.DrillDownProceso.Trim <> "" Then
                    CorrerProcesoSQL(oCol.DrillDownProceso, oCol.Campo, oCol.Titulo)
                End If

                sSQL = oCol.DrillDownQuery.Trim

                For Each oGridCol As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

                    Debug.Print("RowHandle: " & GridView1.GetSelectedRows(0))

                    vValor = GridView1.GetRowCellDisplayText(GridView1.GetSelectedRows(0), oGridCol.FieldName).ToString

                    If IsDate(vValor) Then
                        vValor = FechaSQL(vValor)
                    ElseIf IsNumeric(vValor) Then
                        vValor = FlotanteSQL(Format(vValor, "Fixed"))
                    Else
                        vValor = "'" & vValor & "'"
                    End If

                    sSQL = Replace(sSQL, "@" & oGridCol.FieldName, vValor)
                Next

                sSQL = Replace(sSQL, "@NOMBRE_COLUMNA", GridView1.FocusedColumn.FieldName)
                sSQL = Replace(sSQL, "@TITULO_COLUMNA", GridView1.FocusedColumn.Caption)

                sSQL = ReemplazarVariables(sSQL, PanControles.Controls)
            End If
        End If

        'SI SE PARAMETRIZA QUE UTILICE DRILL DOWN POR RENGLON
        If Not bCol Then
            If oConsulta.DrillDown And oConsulta.DrillDownQuery.Trim <> "" Then

                sSQL = oConsulta.DrillDownQuery.Trim

                For Each oGridCol As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
                    vValor = GridView1.GetRowCellDisplayText(GridView1.GetSelectedRows(0), oGridCol.FieldName).ToString

                    If IsDate(vValor) Then
                        vValor = FechaSQL(vValor)
                    ElseIf IsNumeric(vValor) Then
                        vValor = FlotanteSQL(Format(vValor, "Fixed"))
                    Else
                        vValor = "'" & vValor & "'"
                    End If

                    sSQL = Replace(sSQL, "@" & oGridCol.FieldName, vValor)
                Next

                sSQL = Replace(sSQL, "@NOMBRE_COLUMNA", GridView1.FocusedColumn.FieldName)
                sSQL = Replace(sSQL, "@TITULO_COLUMNA", GridView1.FocusedColumn.Caption)

                sSQL = ReemplazarVariables(sSQL, PanControles.Controls)
            End If
        End If

        If sSQL <> "" Then
            Dim seleccion As String = GridView1.FocusedColumn.GetTextCaption()
            Dim valor As String = GridView1.GetRowCellDisplayText(GridView1.GetSelectedRows(0), GridView1.FocusedColumn).ToString

            frmDrillDown.lblSubtitulo.Text = seleccion & ": " & valor
            frmDrillDown.PasarDatos(sSQL)
            frmDrillDown.ShowDialog()
            frmDrillDown.Close()
        End If

    End Sub

    Private Sub CorrerProcesoSQL(ByVal sSQL As String,
                                 Optional ByVal sCampo As String = "",
                                 Optional ByVal sTitulo As String = "")

        On Error Resume Next

        Dim vValor As Object
        Dim sError As String

        For Each oGridCol As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            vValor = GridView1.GetRowCellDisplayText(GridView1.GetRowHandle(GridView1.GetSelectedRows(0)), oGridCol.FieldName).ToString

            If IsDate(vValor) Then
                vValor = FechaSQL(vValor)
            ElseIf IsNumeric(vValor) Then
                vValor = FlotanteSQL(Format(vValor, "Fixed"))
            Else
                vValor = "'" & vValor & "'"
            End If

            sSQL = Replace(sSQL, "@" & oGridCol.FieldName, vValor)
        Next

        sSQL = Replace(sSQL, "@NOMBRE_COLUMNA", sCampo)
        sSQL = Replace(sSQL, "@TITULO_COLUMNA", sTitulo)

        sSQL = Replace(sSQL, "@CODIGO_CONSULTA", oConsulta.CodCon, , , vbTextCompare)
        sSQL = Replace(sSQL, "@CODUSU", UsuarioActual.Codigo, , , vbTextCompare)
        sSQL = Replace(sSQL, "@CODIGO_ENTIDAD", CODIGO_ENTIDAD, , , vbTextCompare)
        sSQL = Replace(sSQL, "@CODIGO_TRANSACCION", CODIGO_TRANSACCION, , , vbTextCompare)

        sSQL = ReemplazarVariables(sSQL, PanControles.Controls)

        oAdmTablas.EjecutarComandoAsincrono(sSQL)

    End Sub

    'Parametros sParam(0)=Cuadro|sParam(1)=Periodo|sParam(2)=CodCons|sParam(3)=Entidad|
    '           sParam(4)=Columnas|sParam(5)=MesDesde|sParam(6)=MostrarSoloConSaldo|
    '           sParam(7)=TablaDatos|sParam(8)=PrefijoTablaDatos
    Public Function ConsActualizar(ByVal sParametros As String) As Boolean

        Try

            Dim sSQL As String
            Dim dFechaVig As Date
            Dim ds As DataSet
            Dim nCont As Long
            Dim sParam() As String
            Dim sIndice As String
            Dim sTabla As String
            Dim nMaxNivel As Long

            sParam = Split(sParametros, "|")
            sTabla = sParam(7)
            sIndice = sParam(8)

            sSQL = "SELECT  MAX(RU_FECVIG) AS MAX_FECHA " &
                   "FROM    RELCUE " &
                   "WHERE   RU_FECVIG <= " & FechaSQL(sParam(1))
            ds = oAdmTablas.AbrirDataset(sSQL)

            If ds.Tables(0).Rows.Count = 0 Then
                MensajeInformacion("No existen relaciones con vigencia igual o anterior al período seleccionado. Por favor verifique el Mapa de Relaciones!")
                Exit Function
            End If

            dFechaVig = ds.Tables(0).Rows(0).Item("MAX_FECHA")

            ds = Nothing

            nMaxNivel = ConsTotalizar(sParam(0), CDate(sParam(1)), dFechaVig, sParam(2), sParam(3), sParam(4), sParam(5), sTabla, sIndice)

            sSQL = ""

            If CBool(Val(sParam(6))) Then

                For nCont = 0 To Val(sParam(4))
                    sSQL = sSQL & sIndice & "_MES" & nCont & " + "
                Next

                sSQL = Mid(sSQL, 1, Len(sSQL) - 2)
                sSQL = "AND (" & sSQL & ") <> 0 "
            End If

            sSQL = "SELECT    * " &
                   "FROM      " & sTabla & " " &
                   "WHERE     " & sIndice & "_CUADRO = " & sParam(0) & " " &
                   "AND       " & sIndice & "_FECVIG = " & FechaSQL(sParam(1)) & " " &
                   "AND       " & sIndice & "_CODENT = " & sParam(3) & " " &
                   "AND       " & sIndice & "_CODCON = '" & sParam(2) & "' " &
                   "AND       " & sIndice & "_ACTIVA = 1 " &
                   IIf(CBool(Val(sParam(6))), "AND (" & sIndice & "_MES" & Val(sParam(4)) & " <> 0 OR " & sIndice & "_MES" & Val(sParam(4)) - 1 & " <> 0) ", " ") &
                   "ORDER BY  " & sIndice & "_ORDEN, " & sIndice & "_CODPAR, " & sIndice & "_CAMPO8 ASC"

            nMaxNivel = 16

            For Each oCol As clsColumnas In oColumnas
                If oCol.Campo.ToUpper.Contains("NIVELTAB") Then
                    ConsFormatoCondicional(oCol.Orden - 1)
                Else
                    ' Otra cosa...
                    ConsFormatoCondicional_Especiales(oCol.Campo)
                End If
            Next

            Return True

        Catch ex As Exception
            TratarError(ex, "Actualizar")
        End Try

    End Function

    'Parametros sParam(0)=Cuadro|sParam(1)=Periodo|sParam(2)=CodCons|sParam(3)=Entidad|
    '           sParam(4)=Columnas|sParam(5)=MesDesde|sParam(6)=MostrarSoloConSaldo|
    '           sParam(7)=TablaDatos|sParam(8)=PrefijoTablaDatos
    Public Function ConsActualizarEx(ByVal sParametros As String) As Boolean

        Try

            Dim sSQL As String
            Dim dFechaVig As Date
            Dim ds As DataSet
            Dim nCont As Long
            Dim sParam() As String
            Dim sIndice As String
            Dim sTabla As String
            Dim nMaxNivel As Long

            sParam = Split(sParametros, "|")
            sTabla = sParam(7)
            sIndice = sParam(8)

            sSQL = "SELECT  MAX(RU_FECVIG) AS MAX_FECHA " &
                   "FROM    RELCUE " &
                   "WHERE   RU_FECVIG <= " & FechaSQL(sParam(1))
            ds = oAdmTablas.AbrirDataset(sSQL)

            If ds.Tables(0).Rows.Count = 0 Then
                MensajeInformacion("No existen relaciones con vigencia igual o anterior al período seleccionado. Por favor verifique el Mapa de Relaciones!")
                Exit Function
            End If

            dFechaVig = ds.Tables(0).Rows(0).Item("MAX_FECHA")

            ds = Nothing

            nMaxNivel = ConsTotalizarEx(sParam(0), CDate(sParam(1)), dFechaVig, sParam(2), sParam(3), sParam(4), sParam(5), sTabla, sIndice)

            sSQL = ""

            If CBool(Val(sParam(6))) Then

                For nCont = 0 To Val(sParam(4))
                    sSQL = sSQL & sIndice & "_MES" & nCont & " + "
                Next

                sSQL = Mid(sSQL, 1, Len(sSQL) - 2)
                sSQL = "AND (" & sSQL & ") <> 0 "
            End If

            sSQL = "SELECT    * " &
                   "FROM      " & sTabla & " " &
                   "WHERE     " & sIndice & "_CUADRO = " & sParam(0) & " " &
                   "AND       " & sIndice & "_FECVIG = " & FechaSQL(sParam(1)) & " " &
                   "AND       " & sIndice & "_CODENT = " & sParam(3) & " " &
                   "AND       " & sIndice & "_CODCON = '" & sParam(2) & "' " &
                   "AND       " & sIndice & "_ACTIVA = 1 " &
                   IIf(CBool(Val(sParam(6))), "AND (" & sIndice & "_MES" & Val(sParam(4)) & " <> 0 OR " & sIndice & "_MES" & Val(sParam(4)) - 1 & " <> 0) ", " ") &
                   "ORDER BY  " & sIndice & "_ORDEN, " & sIndice & "_CODPAR, " & sIndice & "_CAMPO8 ASC"

            nMaxNivel = 16



            'ConsFormatoCondicionalEx(nMaxNivel)

            For Each oCol As clsColumnas In oColumnas
                If oCol.Campo.ToUpper.Contains("NIVELTAB") Then
                    ConsFormatoCondicional(oCol.Orden - 1)
                Else
                    ' Otra cosa...
                    ConsFormatoCondicional_Especiales(oCol.Campo)
                End If
            Next

            Return True

        Catch ex As Exception
            TratarError(ex, "Actualizar")
        End Try

    End Function


    Public Function ConsTotalizar(ByVal sCuadro As String, ByVal dFecha As Date,
                                  ByVal dFechaVig As Date, ByVal sConsolidacion As String,
                                  ByVal nEmpresa As Long, ByVal nCol As Long,
                                  ByVal nDesdeMes As Integer, ByVal sTabla As String,
                                  ByVal sIndice As String) As Long

        Dim sSQL As String
        Dim ds As DataSet
        Dim nMax As Long
        Dim nCont As Long
        Dim nCont1 As Long

        sConsolidacion = Format(Val(sConsolidacion), "000")

        sSQL = "SELECT      MAX(" & sIndice & "_NIVEL) AS MAXNIVEL " &
               "FROM        " & sTabla & " " &
               "WHERE       " & sIndice & "_FECVIG=" & FechaSQL(dFecha) & " " &
               "AND         " & sIndice & "_CODENT = " & nEmpresa & " " &
               "AND         " & sIndice & "_CUADRO = " & sCuadro

        ds = oAdmTablas.AbrirDataset(sSQL)
        If ds.Tables(0).Rows(0).Item("MAXNIVEL") Is DBNull.Value Then
            nMax = 0
        Else
            nMax = ds.Tables(0).Rows(0).Item("MAXNIVEL")
        End If

        ds = Nothing

        For nCont = 1 To nMax

            oAdmTablas.EjecutarComandoAsincrono("DROP TABLE SUMTEMP")

            sSQL = "SELECT " & sTabla & "." & sIndice & "_NIVEL, " & sTabla & "." & sIndice & "_ESQUEMA, " &
                   "       " & sTabla & "." & sIndice & "_CODENT, " & sTabla & "." & sIndice & "_FECVIG, "

            For nCont1 = 0 To nCol - 1

                sSQL = sSQL & "Sum(" & sTabla & "." & sIndice & "_MES" & nDesdeMes + nCont1 & ") AS Tot_MES" & nDesdeMes + nCont1 & ", "

            Next nCont1

            sSQL = Mid(sSQL, 1, Len(sSQL) - 2)

            sSQL = sSQL & " " &
                   "INTO   SUMTEMP " &
                   "FROM   " & sTabla & " " &
                   "WHERE  " & sTabla & "." & sIndice & "_CODENT = " & nEmpresa & " " &
                   "AND    " & sTabla & "." & sIndice & "_ACTIVA = 1 " &
                   "AND    " & sTabla & "." & sIndice & "_FECVIG = " & FechaSQL(dFecha) & " " &
                   "AND    " & sTabla & "." & sIndice & "_CUADRO = " & sCuadro & " " &
                   "AND    " & sTabla & "." & sIndice & "_CODCON = '" & sConsolidacion & "' " &
                   "GROUP BY " & sTabla & "." & sIndice & "_NIVEL, " & sTabla & "." & sIndice & "_ESQUEMA, " &
                   "         " & sTabla & "." & sIndice & "_CODENT, " & sTabla & "." & sIndice & "_FECVIG " &
                   "HAVING (((" & sTabla & "." & sIndice & "_NIVEL)=" & (nMax - (nCont - 1)) & "));"

            oAdmTablas.EjecutarComandoAsincrono(sSQL)

            sSQL = "UPDATE        " & sTabla & " " &
                   "SET "

            For nCont1 = 0 To nCol - 1

                sSQL = sSQL & "" & sTabla & "." & sIndice & "_MES" & nDesdeMes + nCont1 & " = SUMTEMP.TOT_MES" & nDesdeMes + nCont1 & ", "

            Next nCont1

            sSQL = Mid(sSQL, 1, Len(sSQL) - 2)

            sSQL = sSQL & " " &
                   "FROM " & sTabla & " " &
                   "INNER JOIN    SUMTEMP " &
                   "ON            (" & sTabla & "." & sIndice & "_INDEX = SUMTEMP." & sIndice & "_ESQUEMA) " &
                   "AND           (" & sTabla & "." & sIndice & "_CODENT = SUMTEMP." & sIndice & "_CODENT) " &
                   "AND           (" & sTabla & "." & sIndice & "_FECVIG = SUMTEMP." & sIndice & "_FECVIG) " &
                   "WHERE         " & sTabla & "." & sIndice & "_CODENT = " & nEmpresa & " " &
                   "AND           " & sTabla & "." & sIndice & "_FECVIG = " & FechaSQL(dFecha) & " " &
                   "AND           " & sTabla & "." & sIndice & "_CUADRO = " & sCuadro & " " &
                   "AND           " & sTabla & "." & sIndice & "_INDEX > 1 " &
                   "AND           " & sTabla & "." & sIndice & "_CODCON = '" & sConsolidacion & "' "

            ' Filtro por DC_index agregado para que no cometa el error de actualizar partidas de mas

            oAdmTablas.EjecutarComandoAsincrono(sSQL)

        Next nCont

        ConsTotalizar = nMax

    End Function


    Public Function ConsTotalizarEx(ByVal sCuadro As String, ByVal dFecha As Date,
                                  ByVal dFechaVig As Date, ByVal sConsolidacion As String,
                                  ByVal nEmpresa As Long, ByVal nCol As Long,
                                  ByVal nDesdeMes As Integer, ByVal sTabla As String,
                                  ByVal sIndice As String) As Long

        Dim sSQL As String
        Dim ds As DataSet
        Dim ds2 As DataSet
        Dim i As Long
        Dim nMax As Long
        Dim nCont As Long
        Dim nCont1 As Long

        sConsolidacion = Format(Val(sConsolidacion), "000")

        sSQL = "SELECT      DISTINCT " & sIndice & "_CAMPO8 " &
               "FROM        " & sTabla & " " &
               "WHERE       " & sIndice & "_FECVIG=" & FechaSQL(dFecha) & " " &
               "AND         " & sIndice & "_CODENT = " & nEmpresa & " " &
               "AND         " & sIndice & "_CUADRO = " & sCuadro & " " &
               "ORDER BY    " & sIndice & "_CAMPO8 "
        ds2 = oAdmTablas.AbrirDataset(sSQL)

        For i = 0 To ds2.Tables(0).Rows.Count - 1



            sSQL = "SELECT      MAX(" & sIndice & "_NIVEL) AS MAXNIVEL " &
                   "FROM        " & sTabla & " " &
                   "WHERE       " & sIndice & "_FECVIG=" & FechaSQL(dFecha) & " " &
                   "AND         " & sIndice & "_CODENT = " & nEmpresa & " " &
                   "AND         " & sIndice & "_CUADRO = " & sCuadro & " " &
                   "AND         " & sIndice & "_CAMPO8 = " & ds2.Tables(0).Rows(i).Item(0).ToString

            ds = oAdmTablas.AbrirDataset(sSQL)

            If ds.Tables(0).Rows(0).Item("MAXNIVEL") Is DBNull.Value Then
                nMax = 0
            Else
                nMax = ds.Tables(0).Rows(0).Item("MAXNIVEL")
            End If

            ds = Nothing

            For nCont = 1 To nMax

                oAdmTablas.EjecutarComandoAsincrono("DROP TABLE SUMTEMP")

                sSQL = "SELECT " & sTabla & "." & sIndice & "_NIVEL, " & sTabla & "." & sIndice & "_ESQUEMA, " &
                       "       " & sTabla & "." & sIndice & "_CODENT, " & sTabla & "." & sIndice & "_FECVIG, "

                For nCont1 = 0 To nCol - 1

                    sSQL = sSQL & "Sum(" & sTabla & "." & sIndice & "_MES" & nDesdeMes + nCont1 & ") AS Tot_MES" & nDesdeMes + nCont1 & ", "

                Next nCont1

                sSQL = Mid(sSQL, 1, Len(sSQL) - 2)

                sSQL = sSQL & " " &
                       "INTO   SUMTEMP " &
                       "FROM   " & sTabla & " " &
                       "WHERE  " & sTabla & "." & sIndice & "_CODENT = " & nEmpresa & " " &
                       "AND    " & sTabla & "." & sIndice & "_ACTIVA = 1 " &
                       "AND    " & sTabla & "." & sIndice & "_FECVIG = " & FechaSQL(dFecha) & " " &
                       "AND    " & sTabla & "." & sIndice & "_CUADRO = " & sCuadro & " " &
                       "AND    " & sTabla & "." & sIndice & "_CODCON = '" & sConsolidacion & "' " &
                       "AND    " & sTabla & "." & sIndice & "_CAMPO8 = " & ds2.Tables(0).Rows(i).Item(0).ToString & " " &
                       "GROUP BY " & sTabla & "." & sIndice & "_NIVEL, " & sTabla & "." & sIndice & "_ESQUEMA, " &
                       "         " & sTabla & "." & sIndice & "_CODENT, " & sTabla & "." & sIndice & "_FECVIG " &
                       "HAVING (((" & sTabla & "." & sIndice & "_NIVEL)=" & (nMax - (nCont - 1)) & "));"

                oAdmTablas.EjecutarComandoAsincrono(sSQL)

                sSQL = "UPDATE        " & sTabla & " " &
                       "SET "

                For nCont1 = 0 To nCol - 1

                    sSQL = sSQL & "" & sTabla & "." & sIndice & "_MES" & nDesdeMes + nCont1 & " = SUMTEMP.TOT_MES" & nDesdeMes + nCont1 & ", "

                Next nCont1

                sSQL = Mid(sSQL, 1, Len(sSQL) - 2)

                sSQL = sSQL & " " &
                       "FROM " & sTabla & " " &
                       "INNER JOIN    SUMTEMP " &
                       "ON            (" & sTabla & "." & sIndice & "_INDEX = SUMTEMP." & sIndice & "_ESQUEMA) " &
                       "AND           (" & sTabla & "." & sIndice & "_CODENT = SUMTEMP." & sIndice & "_CODENT) " &
                       "AND           (" & sTabla & "." & sIndice & "_FECVIG = SUMTEMP." & sIndice & "_FECVIG) " &
                       "WHERE         " & sTabla & "." & sIndice & "_CODENT = " & nEmpresa & " " &
                       "AND           " & sTabla & "." & sIndice & "_FECVIG = " & FechaSQL(dFecha) & " " &
                       "AND           " & sTabla & "." & sIndice & "_CUADRO = " & sCuadro & " " &
                       "AND           " & sTabla & "." & sIndice & "_INDEX > 1 " &
                       "AND           " & sTabla & "." & sIndice & "_CODCON = '" & sConsolidacion & "' " &
                       "AND           " & sTabla & "." & sIndice & "_CAMPO8 = " & ds2.Tables(0).Rows(i).Item(0).ToString & " "

                ' Filtro por DC_index agregado para que no cometa el error de actualizar partidas de mas

                oAdmTablas.EjecutarComandoAsincrono(sSQL)

            Next nCont

        Next i

        ds2 = Nothing

        ConsTotalizarEx = nMax

    End Function


    Public Function ConsFormatoCondicional(ByVal sParametros As String) As Boolean


        If bFmtEmb Then

            Dim nMaxNivel As Integer = 0
            Dim fmt As StyleFormatCondition = New StyleFormatCondition()

            nMaxNivel = Val(sParametros)

            GridView1.FormatConditions.Add(fmt)
            fmt.Column = GridView1.Columns(nMaxNivel)
            fmt.Condition = FormatConditionEnum.Equal
            fmt.Value1 = 1
            fmt.Appearance.BackColor = System.Drawing.ColorTranslator.FromWin32(&HE6E6E6)
            fmt.Appearance.Font = New Font(Grid.Font.Name, Grid.Font.Size, FontStyle.Bold)
            fmt.ApplyToRow = True

        End If

        Return True

    End Function

    Public Function ConsFormatoCondicional_Especiales(ByVal sCampo As String) As Boolean


        If bFmtEmb Then

            For Each oFmt As clsFormatosColumnas In oFormato

                If oFmt.Columna = sCampo Then

                    Dim nMaxNivel As Integer = 0
                    Dim fmt As StyleFormatCondition = New StyleFormatCondition()
                    Dim oFont As Font
                    Dim efStyle As FontStyle
                    Dim sFontName As String
                    Dim nFontSize As Long

                    If oFmt.Condicion <> "" Then
                        If oFmt.Condicion.Contains("|") Then

                            Dim sValores() As String

                            sValores = Split(oFmt.Condicion, "|")

                            For nI As Integer = 0 To 0 'sValores.Length - 1    ''' esto es xq la grilla no se banca mas de un valor para la condicion de la columna

                                GridView1.FormatConditions.Add(fmt)
                                fmt.Column = GridView1.Columns(oFmt.Columna)
                                fmt.Condition = FormatConditionEnum.Equal
                                fmt.Value1 = sValores(nI)
                                fmt.Appearance.BackColor = System.Drawing.ColorTranslator.FromWin32(oFmt.Fondo)
                                fmt.Appearance.ForeColor = System.Drawing.ColorTranslator.FromWin32(oFmt.Frente)

                                efStyle = FontStyle.Regular

                                If oFmt.Negrita Then
                                    efStyle = FontStyle.Bold
                                End If

                                If oFmt.Fuente <> "" Then
                                    sFontName = oFmt.Fuente
                                Else
                                    sFontName = Grid.Font.Name
                                End If

                                If oFmt.Tamano > 0 Then
                                    nFontSize = oFmt.Tamano
                                Else
                                    nFontSize = Grid.Font.Size
                                End If

                                oFont = New Font(sFontName, nFontSize, efStyle)
                                fmt.Appearance.Font = oFont

                                fmt.ApplyToRow = True


                            Next

                        Else

                            GridView1.FormatConditions.Add(fmt)
                            fmt.Column = GridView1.Columns(oFmt.Columna)
                            fmt.Condition = FormatConditionEnum.Equal
                            fmt.Value1 = oFmt.Condicion
                            fmt.Appearance.BackColor = System.Drawing.ColorTranslator.FromWin32(oFmt.Fondo)
                            fmt.Appearance.ForeColor = System.Drawing.ColorTranslator.FromWin32(oFmt.Frente)

                            efStyle = FontStyle.Regular

                            If oFmt.Negrita Then
                                efStyle = FontStyle.Bold
                            End If

                            If oFmt.Fuente <> "" Then
                                sFontName = oFmt.Fuente
                            Else
                                sFontName = Grid.Font.Name
                            End If

                            If oFmt.Tamano > 0 Then
                                nFontSize = oFmt.Tamano
                            Else
                                nFontSize = Grid.Font.Size
                            End If

                            oFont = New Font(sFontName, nFontSize, efStyle)
                            fmt.Appearance.Font = oFont

                            fmt.ApplyToRow = True

                        End If
                    End If
                End If

            Next

        End If

        Return True

    End Function


    'Parametros= sParam(0)=Periodo
    Public Function ConsFechaFinMes(ByVal sParametros As String) As Boolean
        Dim sParam() As String
        sParam = Split(sParametros, "|")
        Dim fechaFinDeMes As DateTime

        If Month(sParam(0)) = 12 Then
            fechaFinDeMes = DateTime.Parse((Year(sParam(0)) + 1).ToString() & "-" & Format(1, "00") & "-01").AddDays(-1)
        Else
            fechaFinDeMes = DateTime.Parse(Year(sParam(0)).ToString() & "-" & Format(IIf(Month(sParam(0)) = 12, 1, Month(sParam(0)) + 1), "00") & "-01").AddDays(-1)
        End If


        Dim fecha As DateTime
        If DateTime.TryParse(sParametros, fecha) Then
            If fecha.Equals(fechaFinDeMes) Then
                Return True
            Else
                MensajeError("La fecha establecida no es fin de mes")
            End If
        Else
            MensajeError("La fecha establecida no es fin de mes")
        End If

        'Dim i As Integer
        'Dim sTemp As String

        'For i = 31 To 28 Step -1

        '    sTemp = Format(i, "00") & "-" & Format(Month(sParam(0)), "00") & "-" & Year(sParam(0))

        '    If IsDate(sTemp) Then

        '        If CDate(sParam(0)) <> CDate(sTemp) Then
        '            MensajeError("La fecha establecida no es fin de mes")
        '        Else
        '            ConsFechaFinMes = True
        '        End If

        '        Exit For

        '    End If

        'Next

    End Function

    'Parametros = sParam(0)=Fecha|sParam(1)=CodCons|sParam(2)=Entidad|sParam(3)=Cuadro|
    '             sParam(4)=TablaDatos|sParam(5)=PrefijoTablaDatos
    Public Function ConsValidarPeriodo(ByVal sParametros As String) As Boolean

        Try

            Dim sSQL As String
            Dim ds As DataSet
            Dim dFecha As Date
            Dim sParam() As String
            Dim bResp As Boolean

            sParam = Split(sParametros, "|")

            dFecha = sParam(0)

            sSQL = "SELECT   COUNT(*) " &
                   "FROM     " & sParam(4) & " " &
                   "WHERE    " & sParam(5) & "_FECVIG = " & FechaSQL(dFecha) & " " &
                   "AND      " & sParam(5) & "_CODENT =" & sParam(2) & " " &
                   "AND      CAST(" & sParam(5) & "_CODCON AS INT) = " & sParam(1) & " "

            If Val(sParam(3)) <> 0 Then
                sSQL = sSQL & "AND      " & sParam(5) & "_CUADRO = " & sParam(3)
            End If

            ds = oAdmTablas.AbrirDataset(sSQL)

            bResp = (ds.Tables(0).Rows(0).Item(0) > 0)

            ds = Nothing

            If Not bResp Then
                frmCrearPeriodo.PasarDatos(sParam(5), sParam(4), sParam(1), Val(sParam(3)), dFecha)
                frmCrearPeriodo.ShowDialog()
                bResp = (frmCrearPeriodo.DialogResult = Windows.Forms.DialogResult.OK)
            End If

            Return bResp

        Catch ex As Exception
            TratarError(ex, "Validar Periodo")
        End Try

    End Function

    Private Function DatosOK() As Boolean

        Dim oVar As clsVariables
        sExtra_log = String.Empty

        For Each oVar In oVariables

            If oVar.Help = 1 Then
                sExtra_log = IIf(Len(sExtra_log) < 11,
                   "Selección: " + oVar.Titulo + ": " + CType(Controles("_" & oVar.Nombre), ComboBox).Text,
                   sExtra_log + ", " + oVar.Titulo + ": " + CType(Controles("_" & oVar.Nombre), ComboBox).Text)

                If CType(Controles("_" & oVar.Nombre), ComboBox).SelectedItem Is Nothing Then
                    MensajeError("Debe especificar " & oVar.Titulo)
                    Controles("_" & oVar.Nombre).Focus()
                    Exit Function
                End If

            ElseIf oVar.Help = 0 Then

                If oVar.Tipo = 2 Then

                    sExtra_log = IIf(Len(sExtra_log) < 11,
                           "Selección: " + oVar.Titulo + ": " + CType(Controles("_" & oVar.Nombre), DateTimePicker).Value.ToString(),
                           sExtra_log + ", " + oVar.Titulo + ": " + CType(Controles("_" & oVar.Nombre), DateTimePicker).Value.ToString())

                    If CType(Controles("_" & oVar.Nombre), DateTimePicker).Value = CType(Controles("_" & oVar.Nombre), DateTimePicker).MinDate Then
                        MensajeError("Debe especificar " & oVar.Titulo)
                        Controles("_" & oVar.Nombre).Focus()
                        Exit Function
                    End If

                ElseIf oVar.Tipo = 0 Then

                    sExtra_log = IIf(Len(sExtra_log) < 11,
                                "Selección: " + oVar.Titulo + ": " + Controles("_" & oVar.Nombre).Text,
                                sExtra_log + ", " + oVar.Titulo + ": " + Controles("_" & oVar.Nombre).Text)

                    If Not IsNumeric(Controles("_" & oVar.Nombre).Text) Then
                        MensajeError("Debe especificar " & oVar.Titulo)
                        Controles("_" & oVar.Nombre).Focus()
                        Exit Function
                    End If

                Else
                    sExtra_log = IIf(Len(sExtra_log) < 11,
                               "Selección: " + oVar.Titulo + ": " + Controles("_" & oVar.Nombre).Text.Trim,
                               sExtra_log + ", " + oVar.Titulo + ": " + Controles("_" & oVar.Nombre).Text.Trim)

                    If Controles("_" & oVar.Nombre).Text.Trim = "" Then
                        MensajeError("Debe especificar " & oVar.Titulo)
                        Controles("_" & oVar.Nombre).Focus()
                        Exit Function
                    End If

                End If

            End If

        Next

        sExtra_log = IIf(Len(sExtra_log) < 11, "Formulario sin parámetros de selección. ", sExtra_log)
        GuardarLOG(AccionesLOG.ParametrosSeleccionFormularios, sExtra_log, CODIGO_TRANSACCION, UsuarioActual.Codigo)

        Return True

    End Function

    Private Function Controles(ByVal sNombre As String) As Windows.Forms.Control

        For Each oCtl As Windows.Forms.Control In PanControles.Controls

            If oCtl.Name = sNombre Then
                Return oCtl
                Exit Function
            End If

        Next

        Return Nothing

    End Function

    Private Function ProcesosPrevios() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            If oProcesosPrevios Is Nothing OrElse oProcesosPrevios.Count() = 0 Then Return True
            Dim oPro As clsProcesosPrevios
            Dim oVar As clsVariables
            Dim sParam(1) As String

            For Each oPro In oProcesosPrevios
                sParam(0) = oPro.Nombre
                sParam(1) = oPro.Parametros
                For Each oVar In oVariables
                    sParam(1) = Replace(sParam(1), oVar.Nombre, ValorVariable(oVar))
                Next
                ProcesosPrevios = CallByName(Me, sParam(0), vbMethod, sParam(1))
                If Not ProcesosPrevios Then
                    Exit For
                End If
            Next

        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function

    Private Function ValorVariable(ByVal oVar As clsVariables) As Object
        Dim vReemplazo As Object = Nothing
        Dim oItem As clsItem.Item

        Select Case oVar.Tipo
            Case 0
                If oVar.Help = 1 Then
                    oItem = CType(Controles("_" & oVar.Nombre), ComboBox).SelectedItem
                    vReemplazo = oItem.Valor
                ElseIf oVar.Help = 2 Then
                    vReemplazo = Val(Controles("_" & oVar.Nombre).Text)
                ElseIf oVar.Help = 3 Then
                    vReemplazo = Val(Controles("_" & oVar.Nombre).Text)
                ElseIf oVar.Help = 4 Then
                    vReemplazo = Controles("_" & oVar.Nombre).Tag
                Else
                    vReemplazo = Val(Controles("_" & oVar.Nombre).Text)
                End If

            Case 1
                If oVar.Help Then
                    oItem = CType(Controles("_" & oVar.Nombre), ComboBox).SelectedItem
                    vReemplazo = oItem.Valor
                Else
                    vReemplazo = Controles("_" & oVar.Nombre)
                End If

            Case 2
                vReemplazo = CType(Controles("_" & oVar.Nombre), DateTimePicker).Value

        End Select
        Return vReemplazo

    End Function

    Private Sub CargarValoresColumna(ByVal sColumna As String, ByVal sSQL As String)

        Dim ds As New DataSet
        Dim oItem As DropDownGrid
        Dim xpCollectionTipo As New XPCollection(GetType(DropDownGrid))

        xpCollectionTipo.DisplayableProperties = "This;Oid;Descripcion"

        sSQL = ReemplazarVariables(sSQL, PanControles.Controls)
        ds = oAdmTablas.AbrirDataset(sSQL)

        With ds.Tables(0)

            For Each row As DataRow In .Rows

                oItem = New DropDownGrid

                If IsNumeric(row(0).ToString) Then oItem.Oid = row(0)
                oItem.Codigo = row(0)
                oItem.Descripcion = row(1)

                xpCollectionTipo.Add(oItem)

                oItem = Nothing

            Next

        End With

        Dim oLookUp As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        oLookUp.Name = "lu" & sColumna
        oLookUp.DataSource = xpCollectionTipo
        oLookUp.DisplayMember = "Descripcion"
        oLookUp.ValueMember = "Oid"
        oLookUp.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Oid"))
        oLookUp.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion"))
        oLookUp.Columns("Oid").Visible = False
        oLookUp.ShowFooter = False
        oLookUp.ShowHeader = False
        Grid.RepositoryItems.Add(oLookUp)

        CType(Grid.MainView, ColumnView).Columns(sColumna).ColumnEdit = oLookUp

        oLookUp = Nothing

    End Sub

    Private Function TieneComentarios() As String

        Dim ds As DataSet
        Dim sTemp As String = ""
        Dim sSQL As String

        If Grid.MainView.RowCount > 0 Then

            Dim oNotas As New frmNotas



            sSQL = "SELECT    * " &
                   "FROM      COMENT " &
                   "WHERE     CM_CLAVE = '" & ClaveFormulario("|") & "'"
            ds = oAdmTablas.AbrirDataset(sSQL)

            With ds.Tables(0)
                For Each row As DataRow In .Rows
                    oNotas.rtfNota.Rtf = row("CM_COMENT")
                Next
            End With

            sTemp = oNotas.rtfNota.Text

            oNotas = Nothing
            ds = Nothing
        End If

        Return sTemp

    End Function


    Private Sub GridView1_GridMenuItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventArgs) Handles GridView1.GridMenuItemClick

        ' In some cases the SummaryType is not null, but the SummaryItems is null
        ' For that reason we are validating that to prevent the crash
        If e.SummaryItem IsNot Nothing Then
            ' We need to set the handle as true. This should be the default value, Stupid Grid!
            e.Handled = True

            Select Case e.SummaryType
                Case DevExpress.Data.SummaryItemType.Sum
                    e.SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "SUM={0}")
                Case DevExpress.Data.SummaryItemType.Average
                    e.SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Average, "AVE={0}")
                Case DevExpress.Data.SummaryItemType.Count
                    e.SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Count, "COUNT={0}")
                Case DevExpress.Data.SummaryItemType.Max
                    e.SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Max, "MAX={0}")
                Case DevExpress.Data.SummaryItemType.Min
                    e.SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Min, "MIN={0}")
                Case DevExpress.Data.SummaryItemType.None
                    e.SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.None, "")
            End Select
        Else
            e.Handled = False
        End If

        e.DXMenuItem.Collection.BeginUpdate()

    End Sub

    Private Sub VistaPrevia(ByVal sTitulo As String)
        GuardarLOG(AccionesLOG.ImprimeDatosDeCuadro, "Parámetros utilizados: " + sExtra_log, CODIGO_TRANSACCION, UsuarioActual.Codigo)
        Dim pl As New DevExpress.XtraPrinting.PrintableComponentLink
        Dim phf As DevExpress.XtraPrinting.PageHeaderFooter
        Dim Period As String

        Period = Format(DateTime.Today, "dd-MM-yyyy")

        pl.Component = Grid
        ps1.Links.Add(pl)
        phf = pl.PageHeaderFooter

        phf.Header.Font = New Font("Tahoma", 10, FontStyle.Bold)
        phf.Header.LineAlignment = DevExpress.XtraPrinting.BrickAlignment.Center

        phf.Header.Content.Clear()
        phf.Header.Content.Add(sTitulo)

        phf.Footer.Font = New Font("Tahoma", 8, FontStyle.Bold)
        phf.Footer.LineAlignment = DevExpress.XtraPrinting.BrickAlignment.Center

        phf.Footer.Content.Clear()
        phf.Footer.Content.Add("Fecha: " & Period)

        pl.CreateDocument()
        pl.ShowPreview()


    End Sub

    Public Function ReemplazarVariablesExt(ByVal sConsulta As String) As String
        Return ReemplazarVariables(sConsulta, PanControles.Controls)
    End Function

    Private Sub btnCopiar_Click(sender As Object, e As EventArgs) Handles btnCopiar.Click
        GuardarLOG(AccionesLOG.CopiaDeDatos, "Parámetros utilizados: " + sExtra_log, CODIGO_TRANSACCION, UsuarioActual.Codigo)

        GridView1.CopyToClipboard()
    End Sub

    Private Sub btnAdjuntarArchivo_Click(sender As Object, e As EventArgs) Handles btnAdjuntarArchivo.Click
        GuardarLOG(AccionesLOG.ActualizacionDeArchivosAdjuntos, "Parámetros utilizados: " + sExtra_log, CODIGO_TRANSACCION, UsuarioActual.Codigo)
        Adjuntar()

    End Sub

    Private Sub btnNDesde_Click(sender As Object, e As EventArgs) Handles btnNDesde.Click
        Modificar("N")
    End Sub

    Private Sub btnMostrarBuscador_Click(sender As Object, e As EventArgs) Handles btnMostrarBuscador.Click
        If Not GridView1.IsFindPanelVisible Then
            btnMostrarBuscador.BackColor = SystemColors.ActiveCaption
            GridView1.ShowFindPanel()
        Else
            btnMostrarBuscador.BackColor = SystemColors.Control
            GridView1.HideFindPanel()
        End If
    End Sub

    'Parametros sParam(0)=Cuadro|sParam(1)=Periodo|sParam(2)=CodCons|sParam(3)=Entidad|
    '           sParam(4)=Columnas|sParam(5)=MesDesde|sParam(6)=MostrarSoloConSaldo|
    '           sParam(7)=TablaDatos|sParam(8)=PrefijoTablaDatos|sParam(9)=Escenario
    Public Function ConsActualizar_PNP(ByVal sParametros As String) As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim sSQL As String
            Dim dFechaVig As Date
            Dim nCont As Long
            Dim sParam() As String
            Dim sIndice As String
            Dim nEscena As Integer
            Dim sTabla As String
            Dim nMaxNivel As Long
            Try

                sParam = Split(sParametros, "|")
                sTabla = sParam(7)
                sIndice = sParam(8)
                nEscena = sParam(9)

                sSQL = "SELECT  MAX(TK_FECVIG) AS MAX_FECHA " &
                   "FROM    PNP_TABPAR " &
                   "WHERE   TK_FECVIG <= " & FechaSQL(sParam(1))

                Dim rs As DataSet = oAdmTablas.AbrirDataset(sSQL)
                If rs.Tables(0) Is Nothing OrElse rs.Tables(0).Rows.Count() = 0 Then
                    MensajeInformacion("No existen relaciones con vigencia igual o anterior al período seleccionado. Por favor verifique el Mapa de Relaciones!")
                    Return False
                End If


                dFechaVig = rs.Tables(0).Rows(0).Item("MAX_FECHA")


                nMaxNivel = ConsTotalizar_PNP(sParam(0), CDate(sParam(1)), dFechaVig, sParam(2), sParam(3), sParam(4), sParam(5), sTabla, sIndice, nEscena)

                sSQL = ""

                If CBool(Val(sParam(6))) Then

                    For nCont = 0 To Val(sParam(4))
                        sSQL = sSQL & sIndice & "_MES" & nCont & " + "
                    Next

                    sSQL = Strings.Left(sSQL, Len(sSQL) - 2)
                    sSQL = "AND (" & sSQL & ") <> 0 "
                End If

                sSQL = "SELECT    * " &
                   "FROM      " & sTabla & " " &
                   "WHERE     " & sIndice & "_CUADRO = " & sParam(0) & " " &
                   "AND       " & sIndice & "_FECVIG = " & FechaSQL(sParam(1)) & " " &
                   "AND       " & sIndice & "_CODENT = " & sParam(3) & " " &
                   "AND       " & sIndice & "_CODCON = '" & sParam(2) & "' " &
                   "AND       " & sIndice & "_ESCENA = " & nEscena & " " &
                   "AND       " & sIndice & "_ACTIVA = 1 " &
                    IIf(CBool(Val(sParam(6))), "AND (" & sIndice & "_MES" & Val(sParam(4)) & " <> 0 OR " & sIndice & "_MES" & Val(sParam(4)) - 1 & " <> 0) ", " ") &
                   "ORDER BY  " & sIndice & "_ORDEN, " & sIndice & "_CODPAR, " & sIndice & "_CAMPO8 ASC"

                nMaxNivel = 17
                ConsFormatoCondicional(nMaxNivel)

                Return True

            Catch ex As Exception
                If Err.Number <> 0 Then
                    TratarError(ex, "ConsActualizar_PNP")
                End If
            End Try
        Finally
            Cursor = Cursors.Default
        End Try

    End Function


    Public Function ConsTotalizar_PNP(ByVal sCuadro As String, ByVal dFecha As Date,
                              ByVal dFechaVig As Date, ByVal sConsolidacion As String,
                              ByVal nEmpresa As Long, ByVal nCol As Long,
                              ByVal nDesdeMes As Integer, ByVal sTabla As String,
                              ByVal sIndice As String, ByVal nEscena As Integer) As Long

        Dim sSQL As String
        Dim nMax As Long
        Dim nCont As Long
        Dim nCont1 As Long

        sConsolidacion = Format(Val(sConsolidacion), "000")

        sSQL = "SELECT      MAX(" & sIndice & "_NIVEL) AS MAXNIVEL " &
          "FROM        " & sTabla & " " &
          "WHERE       " & sIndice & "_FECVIG=" & FechaSQL(dFecha) & " " &
          "AND         " & sIndice & "_CODENT = " & nEmpresa & " " &
          "AND         " & sIndice & "_CUADRO = " & sCuadro & " " &
          "AND         " & sIndice & "_ESCENA = " & nEscena

        Dim RS As DataSet = oAdmTablas.AbrirDataset(sSQL)
        If RS.Tables(0) Is Nothing OrElse RS.Tables(0).Rows.Count() = 0 Then
            Throw New Exception("No hay registros en MAX de tabla " & sTabla)
        End If

        If RS.Tables(0).Rows.Item(0)("MAXNIVEL") Is Nothing OrElse IsDBNull(RS.Tables(0).Rows.Item(0)("MAXNIVEL")) Then
            nMax = 0
        Else
            nMax = RS.Tables(0).Rows.Item(0)("MAXNIVEL")
        End If
        RS = Nothing

        For nCont = 1 To nMax

            If oAdmTablas.ExisteTabla("SUMTEMP") Then
                Call oAdmTablas.EjecutarComandoSQL("DROP TABLE SUMTEMP")
            End If

            sSQL = "SELECT " & sTabla & "." & sIndice & "_NIVEL, " & sTabla & "." & sIndice & "_ESQUEMA, " &
              "       " & sTabla & "." & sIndice & "_CODENT, " & sTabla & "." & sIndice & "_FECVIG, "

            For nCont1 = 0 To nCol - 1

                sSQL = sSQL & "Sum(" & sTabla & "." & sIndice & "_MES" & nDesdeMes + nCont1 & ") AS Tot_MES" & nDesdeMes + nCont1 & ", "

            Next nCont1

            sSQL = Strings.Left(sSQL, Len(sSQL) - 2)

            sSQL = sSQL & " " &
              "INTO   SUMTEMP " &
              "FROM   " & sTabla & " " &
              "WHERE  " & sTabla & "." & sIndice & "_CODENT = " & nEmpresa & " " &
              "AND    " & sTabla & "." & sIndice & "_ACTIVA = 1 " &
              "AND    " & sTabla & "." & sIndice & "_FECVIG = " & FechaSQL(dFecha) & " " &
              "AND    " & sTabla & "." & sIndice & "_CUADRO = " & sCuadro & " " &
              "AND    " & sTabla & "." & sIndice & "_ESCENA = " & nEscena & " " &
              "AND    " & sTabla & "." & sIndice & "_CODCON = '" & sConsolidacion & "' " &
              "GROUP BY " & sTabla & "." & sIndice & "_NIVEL, " & sTabla & "." & sIndice & "_ESQUEMA, " &
              "         " & sTabla & "." & sIndice & "_CODENT, " & sTabla & "." & sIndice & "_FECVIG " &
              "HAVING (((" & sTabla & "." & sIndice & "_NIVEL)=" & (nMax - (nCont - 1)) & "));"

            Call oAdmTablas.EjecutarComandoSQL(sSQL)

            sSQL = "UPDATE        " & sTabla & " " &
              "INNER JOIN    SUMTEMP " &
              "ON            (" & sTabla & "." & sIndice & "_INDEX = SUMTEMP." & sIndice & "_ESQUEMA) " &
              "AND           (" & sTabla & "." & sIndice & "_CODENT = SUMTEMP." & sIndice & "_CODENT) " &
              "AND           (" & sTabla & "." & sIndice & "_FECVIG = SUMTEMP." & sIndice & "_FECVIG) SET "

            For nCont1 = 0 To nCol - 1
                sSQL = sSQL & "" & sTabla & "." & sIndice & "_MES" & nDesdeMes + nCont1 & " = SUMTEMP.TOT_MES" & nDesdeMes + nCont1 & ", "
            Next nCont1

            sSQL = Strings.Left(sSQL, Len(sSQL) - 2)

            sSQL = sSQL & " " &
              "WHERE         " & sTabla & "." & sIndice & "_CODENT = " & nEmpresa & " " &
              "AND           " & sTabla & "." & sIndice & "_FECVIG = " & FechaSQL(dFecha) & " " &
              "AND           " & sTabla & "." & sIndice & "_CUADRO = " & sCuadro & " " &
              "AND           " & sTabla & "." & sIndice & "_ESCENA = " & nEscena & " " &
              "AND           " & sTabla & "." & sIndice & "_INDEX > 1 " &
              "AND           " & sTabla & "." & sIndice & "_CODCON = '" & sConsolidacion & "' "

            ' Filtro por DC_index agregado para que no cometa el error de actualizar partidas de mas

            Call oAdmTablas.EjecutarComandoSQL(sSQL)

        Next nCont

        Return nMax

    End Function



End Class

