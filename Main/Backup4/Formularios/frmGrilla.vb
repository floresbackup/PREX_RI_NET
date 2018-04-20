Imports System.Windows.Forms

Public Class frmGrilla

   Private oAdmTablas As New AdmTablas

   Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Me.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.Close()
   End Sub

   Public Sub PasarSQL(ByVal sSQL As String)

      Dim ds As DataSet

      oAdmTablas.ConnectionString = CONN_LOCAL

      ds = oAdmTablas.AbrirDataset(sSQL)

      Grid.DataSource = ds.tables(0)
      Grid.RefreshDataSource()
      Grid.Refresh()

   End Sub

   Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

      Grid.ShowPrintPreview()

   End Sub

   Private Sub cmdExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportar.Click

      frmExportar.PasarViewResultados(Me.Text, Me.Text, gResult)
      frmExportar.ShowDialog()

   End Sub

End Class
