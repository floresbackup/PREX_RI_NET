Public NotInheritable Class SplashScreen

   Public Property AcercaDe() As Boolean
      Get
         Return MODO_ABOUT
      End Get

      Set(ByVal bModo As Boolean)
         MODO_ABOUT = bModo
      End Set
   End Property

   Private MODO_ABOUT As Boolean = False

   'TODO: Este formulario se puede establecer fácilmente como pantalla de bienvenida para la aplicación desde la ficha "Aplicación"
   '  del Diseñador de proyectos ("Propiedades" bajo el menú "Proyecto").
   Private Sub SplashScreen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click

      If MODO_ABOUT Then
         Me.Close()
      End If

   End Sub

   Private Sub SplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      If MODO_ABOUT Then
         lblEquipo.Text = DatosEquipo()
      End If

   End Sub

   Public Sub New()

      ' Llamada necesaria para el Diseñador de Windows Forms.
      InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lblEmpresa.Text = NOMBRE_EMPRESA
        lblVersion.Text = "Versión " & Application.ProductVersion.Trim

   End Sub

   Private Function DatosEquipo() As String

      Dim ds As DataSet
      Dim oAdmTablas As New AdmTablas
      Dim sSQL As String

      DatosEquipo = ""

      Try

         oAdmTablas.ConnectionString = CONN_LOCAL

         DatosEquipo = "Ruta aplicación: " & vbCrLf & IO.Path.GetDirectoryName(Application.ExecutablePath) & vbCrLf & vbCrLf

         sSQL = "SELECT DB_NAME() AS BASEDATOS "
         ds = oAdmTablas.AbrirDataset(sSQL)

         DatosEquipo = DatosEquipo & "Base de datos: " & vbCrLf & ds.Tables(0).Rows(0).Item("BASEDATOS") & vbCrLf & vbCrLf

         sSQL = "SELECT   CONVERT(char(20), SERVERPROPERTY('servername')) AS SERVIDOR "
         ds = oAdmTablas.AbrirDataset(sSQL)

         DatosEquipo = DatosEquipo & "Servidor SQL: " & vbCrLf & ds.Tables(0).Rows(0).Item("SERVIDOR") & vbCrLf & vbCrLf

         ds = Nothing

         sSQL = "SELECT   CONVERT(char(20), SERVERPROPERTY('collation')) as COLL"
         ds = oAdmTablas.AbrirDataset(sSQL)

         DatosEquipo = DatosEquipo & "Intercalación SQL: " & vbCrLf & ds.Tables(0).Rows(0).Item("COLL") & vbCrLf & vbCrLf

         sSQL = "SELECT @@VERSION AS VERSIONSQL "
         ds = oAdmTablas.AbrirDataset(sSQL)

         DatosEquipo = DatosEquipo & "Versión SQL: " & vbCrLf & Replace(Replace(ds.Tables(0).Rows(0).Item("VERSIONSQL"), vbLf, vbCrLf), vbTab, "") & vbCrLf

         ds = Nothing

      Catch ex As Exception
         TratarError(ex, "DatosEquipo")
      End Try

   End Function

End Class
