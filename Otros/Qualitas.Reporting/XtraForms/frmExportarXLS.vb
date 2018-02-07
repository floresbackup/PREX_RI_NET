Imports DevExpress.XtraGrid.Views
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPrinting

Public Class frmExportarXLS

    Private oGvwResults As Grid.GridView
    Private oTablaDin As PivotGridControl
    Private bEsGrid As Boolean

    Public Sub PasarViewResultados(ByVal sDefaultFileName As String, ByRef oGvw As Grid.GridView)
        oGvwResults = oGvw
        txtFileName.Text = SPOOL_PATH & sDefaultFileName & ".xls"
        bEsGrid = True
    End Sub

    Public Sub PasarTablaDinamica(ByVal sDefaultFileName As String, ByRef oCube As PivotGridControl)
        oTablaDin = oCube
        txtFileName.Text = SPOOL_PATH & sDefaultFileName & ".xls"
        chkLines.Visible = False
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim oOptions As New XlsExportOptions

        oOptions.ShowGridLines = chkLines.Checked
        oOptions.UseNativeFormat = chkNative.Checked
        Try

            If txtFileName.Text.Trim <> vbNullString Then

                If Dir(txtFileName.Text.Trim) <> vbNullString Then
                    If Pregunta(DescripcionCadena(Cadenas.CDN_frmExportarXLS_FileAlreadyExists)) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If

                Cursor = Cursors.WaitCursor

                If bEsGrid Then
                    oGvwResults.ExportToXls(txtFileName.Text.Trim, oOptions)
                Else
                    oTablaDin.ExportToXls(txtFileName.Text, chkNative.Checked)
                End If

                Cursor = Cursors.Default

                Process.Start(txtFileName.Text.Trim)
                Me.Close()

            End If

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub frmExportarXLS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LocalizarFormulario()
    End Sub

    Private Sub LocalizarFormulario()
        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionExportarXLS)
        lblFileName.Text = DescripcionCadena(Cadenas.CDN_frmExportarXLS_lblFileName)
        chkLines.Text = DescripcionCadena(Cadenas.CDN_frmExportarXLS_chkCellBorders)
        chkNative.Text = DescripcionCadena(Cadenas.CDN_frmExportarXLS_chkNativeFormat)
        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click

        Dim oDlg As SaveFileDialog

        oDlg = New SaveFileDialog
        oDlg.ValidateNames = True
        oDlg.OverwritePrompt = False
        oDlg.Filter = DescripcionCadena(Cadenas.CDN_frmExportarXLS_SaveDialogFilter) & "|*.xls"
        oDlg.ShowDialog(Me)

        If oDlg.FileName.Trim <> vbNullString Then
            txtFileName.Text = oDlg.FileName.Trim
        End If

    End Sub
End Class