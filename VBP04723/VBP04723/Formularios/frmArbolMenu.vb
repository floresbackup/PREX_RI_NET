Imports System.Windows.Forms

Public Class frmArbolMenu

   Private nNumeroMenu As Long
   Private sNombreMenu As String

   Public ReadOnly Property NombreMenu() As String
      Get
         Return sNombreMenu
      End Get
   End Property

   Public ReadOnly Property NumeroMenu() As Long
      Get
         Return nNumeroMenu
      End Get
   End Property

   Private oAdmLocal As New AdmTablas

   Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

      If tvMenu.SelectedNode Is Nothing Then
         MensajeError("Debe seleccionar una carpeta")
      Else
         nNumeroMenu = Val(tvMenu.SelectedNode.Name)
         sNombreMenu = tvMenu.SelectedNode.Text
         Me.DialogResult = System.Windows.Forms.DialogResult.OK
         Me.Close()
      End If

   End Sub

   Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
      Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub

   Private Sub CargarArbol()

      Dim sSQL As String
      Dim ds As DataSet
      Dim nodo As TreeNode
      Dim nuevoNodo() As TreeNode

      Try

         sSQL = "SELECT       * " & _
                "FROM         MENUES " & _
                "WHERE        MU_NIVEL <> 0 " & _
                "ORDER BY     MU_NIVEL, MU_TRANSA"
         ds = oAdmLocal.AbrirDataset(sSQL)

         tvMenu.Nodes.Clear()

         With ds.Tables(0)

            nodo = tvMenu.Nodes.Add("0", "Menú", "Abierta")

            For Each dr As DataRow In .Rows

               tvMenu.BeginUpdate()
               nuevoNodo = tvMenu.Nodes.Find(dr("MU_RELMEN").ToString, True)
               nuevoNodo(0).Nodes.Add(dr("MU_NROMEN").ToString, dr("MU_TRANSA").ToString, "Cerrada", "Abierta")
               tvMenu.EndUpdate()

            Next

         End With

         ds = Nothing

         nodo.Expand()

      Catch ex As Exception
         TratarError(ex, "CargarArbol")
      End Try

   End Sub

   Public Sub New()

      ' Llamada necesaria para el Diseñador de Windows Forms.
      InitializeComponent()

      ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
      oAdmLocal.ConnectionString = CONN_LOCAL
      CargarArbol()

   End Sub

End Class
