Imports System.Windows.Forms

Public Class frmCarpeta

   Private oAdmLocal As New AdmTablas

   Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

      If DatosOK() Then
         If guardar() Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
         End If
      End If

   End Sub

   Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
      Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub

   Private Sub cmdCarpeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCarpeta.Click

      Dim oCarpeta As New frmArbolMenu

      If oCarpeta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
         txtCarpeta.Text = oCarpeta.NombreMenu
         txtCarpeta.Tag = oCarpeta.NumeroMenu
      End If

   End Sub

   Private Function datosOK() As Boolean

      If txtNombre.Text.Trim = "" Then
         MensajeError("Proporcione el nombre de la carpeta")
         txtNombre.Focus()
         Exit Function
      End If

      If txtCarpeta.Text.Trim = "" Then
         MensajeError("Seleccione la carpeta donde debe ser ubicada esta carpeta")
         cmdCarpeta.Focus()
         Exit Function
      End If

      Return True

   End Function

   Private Function guardar() As Boolean

      Dim sSQL As String
      Dim ds As DataSet
      Dim cb As OleDb.OleDbCommandBuilder
      Dim da As OleDb.OleDbDataAdapter
      Dim row As DataRow
      Dim nProxID As Long

      Try

         nProxID = oAdmLocal.ProximoID("MENUES", "MU_NROMEN")

         sSQL = "SELECT    * " & _
                "FROM      MENUES " & _
                "WHERE     MU_NROMEN = " & nProxID
         ds = oAdmLocal.AbrirDataset(sSQL, da)
         cb = New OleDb.OleDbCommandBuilder(da)

         With ds.Tables(0)

            row = .NewRow()

            row("MU_NROMEN") = nProxID
            row("MU_CODTRA") = 0
            row("MU_TRANSA") = txtNombre.Text.Trim
            row("MU_DESCRI") = ""
            row("MU_COMAND") = ""

            If txtCarpeta.Tag = 0 Then
               row("MU_NIVEL") = 2
            Else
               row("MU_NIVEL") = oAdmLocal.DevolverValor("MENUES", "MU_NIVEL", "MU_NROMEN=" & txtCarpeta.Tag, 0) + 1
            End If

            row("MU_RELMEN") = txtCarpeta.Tag

            .Rows.Add(row)

         End With

         da.Update(ds)
         ds.AcceptChanges()

         ds = Nothing
         cb = Nothing
         da = Nothing

         Return True

      Catch ex As Exception
         TratarError(ex, "guardar")
      End Try

   End Function

   Public Sub New()

      ' Llamada necesaria para el Diseñador de Windows Forms.
      InitializeComponent()

      ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
      oAdmLocal.ConnectionString = CONN_LOCAL

   End Sub

   Private Sub txtCarpeta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCarpeta.TextChanged

   End Sub
End Class
