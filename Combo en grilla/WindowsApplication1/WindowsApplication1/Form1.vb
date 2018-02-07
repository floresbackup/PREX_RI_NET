Imports DevExpress.Xpo

Public Class Form1


   Public Class Person
      Inherits XPObject
      Public Sub New()
         Name = ""
         Group = Nothing
      End Sub
      Public Name As String
      Public Group As PersonGroup
   End Class

   Public Class PersonGroup
      Inherits XPObject
      Public Sub New()
         GroupName = ""
      End Sub 'New
      Public GroupName As String
   End Class

   Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      'TODO: esta línea de código carga datos en la tabla 'INST_PREXRIDataSet.USUGRU' Puede moverla o quitarla según sea necesario.
      Me.USUGRUTableAdapter.Fill(Me.INST_PREXRIDataSet.USUGRU)

      Dim otemp As PersonGroup

      otemp = New PersonGroup

      otemp.GroupName = "Grupo1"
      otemp.Oid = 1

      Me.XpCollectionGroup.Add(otemp)

      otemp = Nothing

      otemp = New PersonGroup

      otemp.GroupName = "Grupo2"
      otemp.Oid = 2

      Me.XpCollectionGroup.Add(otemp)

      otemp = Nothing

      'Dim xpCollectionPerson As New XPCollection(GetType(Person))
      'xpCollectionPerson.DisplayableProperties = "Name;Group!Key"
      'GridControl1.DataSource = xpCollectionPerson

   End Sub
End Class
