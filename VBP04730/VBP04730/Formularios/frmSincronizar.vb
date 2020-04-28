Imports System.Windows.Forms

Public Class frmSincronizar

   Private oAdmLocal As New AdmTablas

   Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

      INPUT_GENERAL = LlaveCombo(cboFecPro)

      Me.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.Close()

   End Sub

   Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

      Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Close()

   End Sub

   Private Sub cargar()

      Dim ds As DataSet
      Dim sSQL As String

      sSQL = "SELECT    DISTINCT DC_FECVIG " & _
             "FROM      (SELECT DISTINCT DC_FECVIG, DC_CODENT FROM DATCUA WHERE DC_ACTIVA=1 UNION SELECT DISTINCT DB_FECVIG, DB_CODENT FROM DATBAN WHERE DB_ACTIVA=1) XXTABLA " & _
             "WHERE     DC_CODENT = " & CODIGO_ENTIDAD & " " & _
             "ORDER BY  DC_FECVIG DESC"
      ds = oAdmLocal.AbrirDataset(sSQL)

      With ds.Tables(0)

         For Each row As DataRow In .Rows
            cboFecPro.Items.Add(New Prex.Utils.Entities.clsItem(row("DC_FECVIG"), row("DC_FECVIG")))
         Next
      End With

      ds = Nothing

      If cboFecPro.Items.Count > 0 Then
         cboFecPro.SelectedIndex = 0
      End If

   End Sub

   Public Sub New()

      ' Llamada necesaria para el Diseñador de Windows Forms.
      InitializeComponent()

      ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
      oAdmLocal.ConnectionString = CONN_LOCAL
      cargar()

   End Sub
End Class
