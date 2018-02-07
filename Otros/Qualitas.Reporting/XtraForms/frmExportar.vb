Public Class frmExportar

    Private CODIGO_CONSULTA As Long
    Private NOMBRE_CONSULTA As String
    Private oAdmTablas As New AdmTablas

    Public Sub New(ByVal nCodCon As Long, ByVal sNombreConsulta As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CODIGO_CONSULTA = nCodCon
        NOMBRE_CONSULTA = sNombreConsulta
        lblNombreConsulta.Text = NOMBRE_CONSULTA
        oAdmTablas.ConnectionString = CONN_LOCAL
        txtFileName.Text = SPOOL_PATH & sNombreConsulta & ".dat"
        LocalizarFormulario()

    End Sub

    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionExportarConsulta)
        grpExportar.Text = Me.Text

        lblConsultaExportar.Text = DescripcionCadena(Cadenas.CDN_frmExportar_NombreConsulta)
        lblNombreArchivo.Text = DescripcionCadena(Cadenas.CDN_frmExportar_NombreArchivo)
        chkExportarLayouts.Text = DescripcionCadena(Cadenas.CDN_frmExportar_ExportarLayouts)
        chkExportarReportes.Text = DescripcionCadena(Cadenas.CDN_frmExportar_ExportarReportes)

        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

    End Sub


    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        Dim oDlg As SaveFileDialog

        oDlg = New SaveFileDialog
        oDlg.ValidateNames = True
        oDlg.OverwritePrompt = False
        oDlg.Filter = DescripcionCadena(Cadenas.CDN_frmExportar_SaveDialogFilter) & "|*.dat"
        oDlg.ShowDialog(Me)

        If oDlg.FileName.Trim <> vbNullString Then
            txtFileName.Text = oDlg.FileName.Trim
        End If

    End Sub

    Private Sub Exportar()

        Dim sSQL As String
        Dim ds As DataSet
        Dim sTempFile As String
        Dim sFile As String

        Dim sEncrypt As String
        Dim stReader As IO.TextReader
        Dim stWriter As IO.TextWriter


        sFile = txtFileName.Text.Trim
        sTempFile = LOCAL_FOLDER & "XMLTEMP.DAT"

        sSQL = "SELECT      * " & _
               "FROM        CONVAR " & _
               "WHERE       CV_CODCON = " & CODIGO_CONSULTA & " "

        sSQL = sSQL & _
               "SELECT      * " & _
               "FROM        CONDET " & _
               "WHERE       CD_CODCON = " & CODIGO_CONSULTA & " "

        sSQL = sSQL & _
               "SELECT      * " & _
               "FROM        CONFOR " & _
               "WHERE       CF_CODCON = " & CODIGO_CONSULTA & " "

        sSQL = sSQL & _
               "SELECT      * " & _
               "FROM        CONRES " & _
               "WHERE       CR_CODCON = " & CODIGO_CONSULTA & " "


        sSQL = sSQL & _
               "SELECT      * " & _
               "FROM        CONLAY " & _
               "WHERE       CL_CODCON = " & CODIGO_CONSULTA & " " & _
               "AND         CL_SHARED = 1 " & _
               "AND         1 = " & IIf(chkExportarLayouts.Checked, "1", "0")

        sSQL = sSQL & _
                   "SELECT      * " & _
                   "FROM        REPORT " & _
                   "WHERE       RP_CODCON = " & CODIGO_CONSULTA & " " & _
                   "AND         RP_PUBLIC = 1 " & _
                   "AND         1 = " & IIf(chkExportarReportes.Checked, "1", "0")
        
        Try

            Cursor = Cursors.WaitCursor
            ds = oAdmTablas.AbrirDataset(sSQL)

            ds.Tables(0).TableName = "CONVAR"
            ds.Tables(1).TableName = "CONDET"
            ds.Tables(2).TableName = "CONFOR"
            ds.Tables(3).TableName = "CONRES"
            ds.Tables(4).TableName = "CONLAY"
            ds.Tables(5).TableName = "REPORT"

            ds.WriteXml(sTempFile)
            ds.Dispose()

            Call EncryptFile(sTempFile, sFile)

            IO.File.Delete(sTempFile)

            Cursor = Cursors.Default
            MensajeInformacion(DescripcionCadena(Cadenas.CDN_frmExportar_InfoExportacionOK))

            Me.Close()

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If txtFileName.Text.Trim <> "" Then

            If Dir(txtFileName.Text.Trim) <> vbNullString Then
                If Pregunta(DescripcionCadena(Cadenas.CDN_frmExportarXLS_FileAlreadyExists)) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If

            Exportar()

        End If

    End Sub


End Class