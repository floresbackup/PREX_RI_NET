Imports DevExpress.XtraCharts
Imports System.Drawing.Imaging

Public Class frmExportarImagen

    Private oChart As ChartControl

    Private Sub frmExportarImagen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LocalizarFormulario()
    End Sub

    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionExportarImagen)
        lblFileName.Text = DescripcionCadena(Cadenas.CDN_frmExportarImagen_lblFileName)
        lblFormato.Text = DescripcionCadena(Cadenas.CDN_frmExportarImagen_lblFormato)
        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

    End Sub

    Public Sub PasarChart(ByRef oChrt As ChartControl, ByVal sDefaultFileName As String)
        oChart = oChrt
        txtFileName.Text = SPOOL_PATH & sDefaultFileName & ".JPG"

    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click

        Dim oDlg As SaveFileDialog

        oDlg = New SaveFileDialog
        oDlg.ValidateNames = True
        oDlg.OverwritePrompt = False
        oDlg.Filter = cboFormato.Text & "|*." & cboFormato.Text
        oDlg.ShowDialog(Me)

        If oDlg.FileName.Trim <> vbNullString Then
            txtFileName.Text = oDlg.FileName.Trim
        End If

    End Sub


    Private Sub cboFormato_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFormato.SelectedIndexChanged

        Dim nPos As Integer
        Dim sTemp As String
        Dim sNewPath As String

        sTemp = txtFileName.Text.Trim

        If sTemp.Length > 0 Then

            nPos = sTemp.IndexOf(".")

            If nPos >= 0 Then
                sNewPath = sTemp.Substring(0, nPos) & "." & cboFormato.SelectedItem
                txtFileName.Text = sNewPath
            End If

        End If

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Try

            If txtFileName.Text.Trim <> vbNullString Then

                If Dir(txtFileName.Text.Trim) <> vbNullString Then
                    If Pregunta(DescripcionCadena(Cadenas.CDN_frmExportarXLS_FileAlreadyExists)) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If

                Cursor = Cursors.WaitCursor

                Select Case cboFormato.SelectedItem
                    Case "JPG"
                        oChart.ExportToImage(txtFileName.Text.Trim, ImageFormat.Jpeg)
                    Case "BMP"
                        oChart.ExportToImage(txtFileName.Text.Trim, ImageFormat.Bmp)
                    Case "GIF"
                        oChart.ExportToImage(txtFileName.Text.Trim, ImageFormat.Gif)
                    Case "PNG"
                        oChart.ExportToImage(txtFileName.Text.Trim, ImageFormat.Png)
                    Case "TIFF"
                        oChart.ExportToImage(txtFileName.Text.Trim, ImageFormat.Tiff)
                    Case Else
                        oChart.ExportToImage(txtFileName.Text.Trim, ImageFormat.Jpeg)
                End Select

                Cursor = Cursors.Default

                Process.Start(txtFileName.Text.Trim)
                Me.Close()

            End If

        Catch ex As Exception
            Cursor = Cursors.Default
            TratarError(ex)
        End Try

    End Sub


End Class