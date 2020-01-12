Public Class frmDrillDown
    Private cmSql As ScintillaNET.Scintilla
    Private cmProcesoPrevio As ScintillaNET.Scintilla

    Private COD_CONSULTA As Long
    Private CAMPO_TABLA As String
    Private nLastCol As Integer
    Private bRefresh As Boolean

    Public INPUT_GENERAL As String
    Public INPUT_GENERAL_AUX As String

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        cmSql = New ScintillaNET.Scintilla()
        pnlQuery.Controls.Add(cmSql)
        cmSql.Dock = DockStyle.Fill
        Prex.Utils.Misc.Forms.ScintillaSQL.InitialiseScintilla(cmSql)

        cmProcesoPrevio = New ScintillaNET.Scintilla()
        pnlProceso.Controls.Add(cmProcesoPrevio)
        cmProcesoPrevio.Dock = DockStyle.Fill
        Prex.Utils.Misc.Forms.ScintillaSQL.InitialiseScintilla(cmProcesoPrevio)
    End Sub

    Public Sub PasarQuery(sql As String)
        PasarQuery(sql, String.Empty, String.Empty, String.Empty)
    End Sub



    Public Sub PasarQuery(ByVal sSQL As String,
                          Optional ByVal sTitulo As String = "",
                          Optional ByVal sSubTitulo As String = "",
                          Optional ByVal sProcesoPrevio As String = "")

        If sTitulo <> "" Then
            lblTitulo.Text = sTitulo
            Text = sTitulo
        End If
        If sSubTitulo <> "" Then lblSubtitulo.Text = sSubTitulo

        cmSql.Text = sSQL
        cmProcesoPrevio.Text = sProcesoPrevio

        'Tabs.Tabs(2).Enabled = False
        'Tabs.Tabs(3).Enabled = False

    End Sub

    Public Sub PasarConsulta(ByVal nCodCon As Long, ByVal sCampo As String,
                             ByVal sQuery As String, Optional ByVal sProcesoPrevio As String = "")


        COD_CONSULTA = nCodCon
        CAMPO_TABLA = sCampo
        cmSql.Text = sQuery
        cmProcesoPrevio.Text = sProcesoPrevio

        'Dim sFile As String
        'sFile = App.Path & "\LAYOUTS\DrillD_" & Prex.Utils.Configuration.PrexConfig.CODIGO_ENTIDAD & "_" & COD_CONSULTA & CAMPO_TABLA & ".lyt"

        'If ArchivoExiste(sFile) Then
        '    Grid.LoadLayout sFile, False, CONN_LOCAL
        'End If

    End Sub



    Private Sub cmdGuardar_Click() Handles cmdGuardar.Click

        INPUT_GENERAL = Trim(cmSql.Text)
        INPUT_GENERAL_AUX = Trim(cmProcesoPrevio.Text)
        Me.Close()

    End Sub

    Private Sub btnEjecutar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEjecutar.ItemClick
        Try


            '      Dim RS As Recordset
            '  Dim sSQL As String
            '  Dim oCol As Field
            '  Dim bExiste As Boolean
            '  Dim oFmt As JSFormatStyle
            '  Dim oGridCol As JSColumn
            '  Dim bActual As Boolean

            '  If Grid.Columns.Count > 0 Then
            '      If Pregunta("¿Actualizar la información de columnas?") = vbYes Then
            '          bActual = True
            '      End If
            '  End If

            '  sSQL = frmMain.ReemplazarVariables(cmSql.Text)

            '  If bActual Then
            '      Grid.Columns.Clear
            '      Grid.FormatStyles.Clear

            'Set RS = oAdmLocal.AbrirRecordset(sSQL)

            'With RS
            '          For Each oCol In RS.Fields

            '      Set oFmt = Grid.FormatStyles.Add(oCol.Name)
            '      oFmt.ForeColor = Grid.ForeColor
            '              oFmt.BackColor = Grid.BackColor

            '      Set oGridCol = Grid.Columns.Add(oCol.Name, jgexText, jgexEditTextBox, oCol.Name)
            '      oGridCol.DataField = oCol.Name
            '              oGridCol.Visible = True

            '              If TipoDatosADO(oCol.Type) = "Texto" Then
            '                  oGridCol.TextAlignment = jgexAlignLeft
            '                  oGridCol.HeaderAlignment = jgexAlignLeft
            '                  oGridCol.SortType = jgexSortTypeString
            '              ElseIf TipoDatosADO(oCol.Type) = "Numérico" Then
            '                  oGridCol.TextAlignment = jgexAlignRight
            '                  oGridCol.HeaderAlignment = jgexAlignCenter
            '                  oGridCol.SortType = jgexSortTypeNumeric
            '              Else
            '                  oGridCol.TextAlignment = jgexAlignRight
            '                  oGridCol.HeaderAlignment = jgexAlignCenter
            '                  oGridCol.SortType = jgexSortTypeDateTime
            '              End If

            '              oGridCol.CellStyle = oCol.Name

            '              DoEvents
            '          Next
            '      End With
            '  End If

        Catch ex As Exception
            Prex.Utils.ManejarErrores.TratarError(ex, "EjecutarConsulta")
        End Try

    End Sub
End Class