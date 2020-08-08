Imports System.Reflection

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
		Dim a As New System.Runtime.Versioning.TargetFrameworkAttribute("")
		Dim targetFrameworkAttribute = Assembly.GetExecutingAssembly().GetCustomAttributes(a.GetType(), False)

		lblFrameworkNet.Text = DirectCast(targetFrameworkAttribute(0), System.Runtime.Versioning.TargetFrameworkAttribute).FrameworkDisplayName
		If MODO_ABOUT Then
			lblEquipo.Text = DatosEquipo()
			Label2.Visible = False
			pnlDatos.Height = 191 + 40
			lblFrameworkNet.Visible = True
			pnlDatos.Visible = True

			If ID_SISTEMA > 0 Then
				lblEquipo.Height = pnlDatos.Height + 15
				pblCitiCiberrark.Location = New Point(lblEquipo.Location.X, lblEquipo.Location.Y + lblEquipo.Size.Height)
				pblCitiCiberrark.Visible = True
				picErrorCiberrark.Visible = CYBERRARKPASS.Trim = String.Empty
				picOkCiberrark.Visible = Not picErrorCiberrark.Visible
				If picErrorCiberrark.Visible Then
					lblciti.Text = "Error conexión con Cyberark"
					lblciti.ForeColor = Color.DarkRed
				Else
					lblciti.Text = "Conexión con Cyberark"
					lblciti.ForeColor = Color.DarkGreen
				End If
				pblCitiCiberrark.Location = New Point(pblCitiCiberrark.Location.X, lblEquipo.Location.Y + lblEquipo.Height)
				pnlDatos.AutoScroll = pblCitiCiberrark.Location.Y + pblCitiCiberrark.Height > lblEquipo.Location.Y + lblEquipo.Height

			Else
				pblCitiCiberrark.Visible = False
				pnlDatos.AutoScroll = False

				lblEquipo.Height = pnlDatos.Height

			End If

		Else
			lblFrameworkNet.Visible = False
			Label2.Visible = True
			pnlDatos.Visible = False
			pblCitiCiberrark.Visible = False
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

			DatosEquipo = "Ruta aplicación: " & IO.Path.GetDirectoryName(Application.ExecutablePath) & vbCrLf & vbCrLf

			sSQL = "SELECT DB_NAME() AS BASEDATOS "
			ds = oAdmTablas.AbrirDataset(sSQL)

			If ID_SISTEMA > 0 Then
				DatosEquipo = DatosEquipo & "Perfil CITI: " & CITI_PERFIL & vbCrLf & vbCrLf
			End If
			DatosEquipo += $"WorkStation: {Environment.MachineName} {vbCrLf & vbCrLf}"
			DatosEquipo += "Base de datos: " & ds.Tables(0).Rows(0).Item("BASEDATOS") & vbCrLf & vbCrLf

			sSQL = "SELECT   CONVERT(char(20), SERVERPROPERTY('servername')) AS SERVIDOR "
			ds = oAdmTablas.AbrirDataset(sSQL)

			DatosEquipo += "Servidor SQL: " & ds.Tables(0).Rows(0).Item("SERVIDOR") & vbCrLf & vbCrLf

			ds = Nothing

			sSQL = "SELECT   CONVERT(char(20), SERVERPROPERTY('collation')) as COLL"
			ds = oAdmTablas.AbrirDataset(sSQL)

			DatosEquipo += "Intercalación SQL: " & ds.Tables(0).Rows(0).Item("COLL") & vbCrLf & vbCrLf

			sSQL = "SELECT @@VERSION AS VERSIONSQL "
			ds = oAdmTablas.AbrirDataset(sSQL)

			DatosEquipo += "Versión SQL: " & Replace(Replace(ds.Tables(0).Rows(0).Item("VERSIONSQL"), vbLf, vbCrLf), vbTab, "") & vbCrLf & vbCrLf

			If DatosEquipo.Contains("Microsoft Corporation") Then
				DatosEquipo = DatosEquipo.Substring(0, DatosEquipo.IndexOf("Microsoft Corporation") + 21)
			End If

			ds = Nothing

		Catch ex As Exception
			TratarError(ex, "DatosEquipo")
		End Try

	End Function

	Private Sub SplashScreen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
		If MODO_ABOUT AndAlso e.KeyChar = ChrW(Keys.Escape) Then
			Me.Close()
		End If
	End Sub
End Class
