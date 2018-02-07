Imports DevExpress.XtraGrid.Views
Imports DevExpress.XtraPrinting
Public Class frmExportarHTML

    Private oGvwResults As Grid.GridView

    Public Sub PasarViewResultados(ByVal sDefaultFileName As String, ByVal sNombreConsulta As String, ByRef oGvw As Grid.GridView)
        oGvwResults = oGvw
        txtPageTitle.Text = sNombreConsulta
        txtFileName.Text = SPOOL_PATH & sDefaultFileName & ".html"

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim oOptions As New HtmlExportOptions

        oOptions.PageBorderColor = cboColor.Color
        oOptions.Title = txtPageTitle.Text.Trim
        oOptions.PageBorderWidth = txtBorderWidth.Value
        oOptions.ExportMode = cboPaginado.SelectedIndex
        oOptions.RemoveSecondarySymbols = chkRemoveSymbols.Checked

        Try

            If txtFileName.Text.Trim <> vbNullString Then

                If Dir(txtFileName.Text.Trim) <> vbNullString Then
                    If Pregunta(DescripcionCadena(Cadenas.CDN_frmExportarXLS_FileAlreadyExists)) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If

                oGvwResults.ExportToHtml(txtFileName.Text.Trim, oOptions)

                If oOptions.ExportMode <> HtmlExportMode.DifferentFiles Then
                    Process.Start(txtFileName.Text.Trim)
                End If

                Me.Close()

            End If

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub frmExportarHTML_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cboPaginado.Properties.Items.Clear()
        LocalizarFormulario()
        cboPaginado.SelectedIndex = 1
    End Sub

    Private Sub LocalizarFormulario()
        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionExportarHTML)

        lblFileName.Text = DescripcionCadena(Cadenas.CDN_frmExportarHTML_lblFileName)
        lblPageTitle.Text = DescripcionCadena(Cadenas.CDN_frmExportarHTML_lblPageTitle)
        lblBorderWidth.Text = DescripcionCadena(Cadenas.CDN_frmExportarHTML_lblBorderWidth)
        lblBorderColor.Text = DescripcionCadena(Cadenas.CDN_frmExportarHTML_lblBorderColor)
        lblPageModo.Text = DescripcionCadena(Cadenas.CDN_frmExportarHTML_lblPaginado)

        cboPaginado.Properties.Items.Add(DescripcionCadena(Cadenas.CDN_frmExportarHTML_PaginadoOpcion00))
        cboPaginado.Properties.Items.Add(DescripcionCadena(Cadenas.CDN_frmExportarHTML_PaginadoOpcion01))
        cboPaginado.Properties.Items.Add(DescripcionCadena(Cadenas.CDN_frmExportarHTML_PaginadoOpcion02))

        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click

        Dim oDlg As SaveFileDialog

        oDlg = New SaveFileDialog
        oDlg.ValidateNames = True
        oDlg.OverwritePrompt = False
        oDlg.Filter = DescripcionCadena(Cadenas.CDN_frmExportarHTML_SaveDialogFilter) & "|*.html"
        oDlg.ShowDialog(Me)

        If oDlg.FileName.Trim <> vbNullString Then
            txtFileName.Text = oDlg.FileName.Trim
        End If

    End Sub
End Class