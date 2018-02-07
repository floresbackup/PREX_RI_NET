Imports DevExpress.XtraGrid.Views
Imports DevExpress.XtraPrinting

Public Class frmExportar

   Private oGvwResults As Grid.GridView
   Private sFiltro As String

   Public Sub PasarViewResultados(ByVal sDefaultFileName As String, ByVal sNombreConsulta As String, ByRef oGvw As Grid.GridView)

      oGvwResults = oGvw
      txtPageTitle.Text = sNombreConsulta
      txtFileName.Text = sDefaultFileName

   End Sub

   Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

      If DatosOK() Then
         Exportar()
      End If

   End Sub

   Private Sub Exportar()

      Try

         Select Case Me.cboExportarA.SelectedIndex

            Case 0 'Planilla Excel
               Dim oOptions As New XlsExportOptions

               oOptions.ShowGridLines = True
               oOptions.UseNativeFormat = True

               oGvwResults.ExportToXls(txtFileName.Text.Trim, oOptions)

            Case 1 'Archivo PDF

               Dim oOptions As New PdfExportOptions

               oOptions.Compressed = True
               oOptions.ImageQuality = PdfJpegImageQuality.Highest
               oOptions.DocumentOptions.Title = "Titulo"
               oOptions.DocumentOptions.Subject = "Subtitulo"
               oOptions.DocumentOptions.Author = Application.CompanyName & " - " & Application.ProductName & " " & Application.ProductVersion

               oGvwResults.ExportToPdf(txtFileName.Text.Trim)

            Case 2 'Archivo HTML
               Dim oOptions As New HtmlExportOptions

               oOptions.PageBorderColor = txtColor.BackColor
               oOptions.Title = txtPageTitle.Text.Trim
               oOptions.PageBorderWidth = txtBorderWidth.Value
               oOptions.ExportMode = HtmlExportMode.SingleFile
               oOptions.RemoveSecondarySymbols = True

               oGvwResults.ExportToHtml(txtFileName.Text.Trim, oOptions)

            Case 3 'Archivo de Texto
               oGvwResults.ExportToText(txtFileName.Text.Trim)

            Case 4 'Archivo delimitado
               Dim oOptions As New TextExportOptions

               oOptions.Separator = txtSep.Text.Trim
               oOptions.QuoteStringsWithSeparators = chkTexto.Checked

               oGvwResults.ExportToText(txtFileName.Text.Trim, oOptions)

            Case 5 'Texto enriquecido
               Dim oOptions As New RtfExportOptions

               oGvwResults.ExportToRtf(txtFileName.Text.Trim)

         End Select

         If chkAbrir.Checked Then
            Process.Start(txtFileName.Text.Trim)
         End If

         Me.Close()

      Catch ex As Exception
         TratarError(ex)
      End Try

   End Sub

   Private Function DatosOK() As Boolean

      If txtFileName.Text.Trim = vbNullString Then
         MensajeInformacion("Debe especificar un archivo")
         txtFileName.Focus()
         Exit Function
      End If

      If System.IO.File.Exists(txtFileName.Text.Trim) Then
         If Pregunta("El archivo existe ¿Desea sobreescribir?") = Windows.Forms.DialogResult.No Then
            Exit Function
         End If
      End If

      Return True

   End Function

   Private Sub frmExportar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      cboExportarA.SelectedIndex = 0

      OpcionVisible()

   End Sub

   Private Sub OpcionVisible()

      panHTML.Visible = False
      PanCSV.Visible = False

      Select Case cboExportarA.SelectedIndex
         Case 0 'Planilla Excel
            sFiltro = "Archivos Excel (*.xls)|*.xls"
         Case 1 'Archivo PDF
            sFiltro = "Archivos PDF (*.pdf)|*.pdf"
         Case 2 'Archivo HTML
            panHTML.Visible = True
            sFiltro = "Archivos HTML (*.html)|*.html"
         Case 3 'Archivo de Texto
            sFiltro = "Archivos de Texto (*.txt)|*.txt"
         Case 4 'Archivo delimitado
            PanCSV.Visible = True
            sFiltro = "Archivo delimitado (*.csv)|*.csv"
         Case 5 'Texto enriquecido
            sFiltro = "Texto enriquecido (*.rtf)|*.rtf"

      End Select

      Dim sExt As String = sFiltro.Substring(sFiltro.LastIndexOf("."))

      If txtFileName.Text.LastIndexOf(".") > 0 Then
         txtFileName.Text = txtFileName.Text.Substring(0, txtFileName.Text.LastIndexOf("."))
      End If

      txtFileName.Text = txtFileName.Text & sExt

   End Sub

   Private Sub cmdColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdColor.Click
      Dim oColor As New ColorDialog

      oColor.Color = txtColor.BackColor

      If oColor.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
         txtColor.BackColor = oColor.Color
      End If

   End Sub

   Private Sub cboExportarA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboExportarA.SelectedIndexChanged
      OpcionVisible()
   End Sub

   Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click

      Dim oDlg As SaveFileDialog

      oDlg = New SaveFileDialog
      oDlg.FileName = txtFileName.Text.Trim
      oDlg.ValidateNames = True
      oDlg.OverwritePrompt = False
      oDlg.Filter = sFiltro
      oDlg.ShowDialog(Me)

      If oDlg.FileName.Trim <> vbNullString Then
         txtFileName.Text = oDlg.FileName.Trim
      End If

   End Sub
End Class