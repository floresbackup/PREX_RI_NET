Imports System.Data.SqlClient
Imports Prex.Utils

Public Class FrmAltaUsuarioNaranja

	Public Sub New(usuario As String)

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		txtUsusario.Text = usuario
	End Sub
	Public Sub New(usuario As String, nombre As String, apellido As String)

		Me.New(usuario)
		txtApellido.Text = apellido
		txtNombre.Text = nombre
	End Sub

	Private ReadOnly Property DatosValidos
		Get

			Return Not txtUsusario.Text.IsNullOrEmpty AndAlso Not txtApellido.Text.IsNullOrEmpty _
				AndAlso Not txtNombre.Text.IsNullOrEmpty AndAlso cboGrupos.SelectedText IsNot Nothing
		End Get
	End Property

	Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
		If Not DatosValidos Then
			MensajesForms.MostrarError("Deben completarse todos los datos")
			Exit Sub
		End If
		Try

			Me.Cursor = Cursors.WaitCursor

			Try

				'Grabar Usuario
				Dim codUsuario = CType(DataAccess.GetScalar("select MAX(US_CODUSU)+1 from USUARI"), Integer)

				Dim cmd As New SqlCommand("INSERT INTO [USUARI] ([US_CODUSU],[US_NOMBRE],[US_DESCRI],[US_PASSWO],[US_PASS01]
															,[US_PASS02],[US_PASS03],[US_PASS04],[US_PASS05],[US_FECVTO]
														   ,[US_FECALT],[US_FECBAJ],[US_ENCRYP],[US_BLOQUE],[US_GRACIA]
														  ,[US_ADMIN],[US_CODENT],[US_CORREO],[US_INTERN],[US_READER])
									 VALUES
										   (@CodUsuario,@Usuario,@Descripcion,NULL,NULL,NULL,NULL,NULL,NULL,
											'2100-12-31 00:00:00.000',GetDate(),'1900-01-01 00:00:00.000'
										   ,'',0,99,0,@CodEntidad,@Correo,'',0)")

				cmd.Parameters.Add("CodUsuario", SqlDbType.Int).Value = codUsuario
				cmd.Parameters.Add("Usuario", SqlDbType.VarChar).Value = txtUsusario.Text.Trim
				cmd.Parameters.Add("Descripcion", SqlDbType.VarChar).Value = $"{txtApellido.Text.Trim}, {txtNombre.Text.Trim}"
				cmd.Parameters.Add("CodEntidad", SqlDbType.Int).Value = CODIGO_ENTIDAD
				cmd.Parameters.Add("Correo", SqlDbType.VarChar).Value = $"{txtUsusario.Text.Trim.ToLower()}@naranjax.com"

				DataAccess.Execute(cmd)

				'Grabar Grupo
				Dim cmdUsuGru As New SqlCommand("INSERT INTO USUGRU (UG_CODUSU, UG_CODGRU) VALUES (@CodUsuario, @CodGrupo)")
				cmdUsuGru.Parameters.Add("CodUsuario", SqlDbType.Int).Value = codUsuario
				cmdUsuGru.Parameters.Add("CodGrupo", SqlDbType.Int).Value = CType(cboGrupos.SelectedItem, Entities.clsItem).Valor
				DataAccess.Execute(cmdUsuGru)

				'Update de USUTOK 
				Dim cmdUsuTok As New SqlCommand("UPDATE USUTOK SET UT_CODUSU=@CodUsuario WHERE UT_NOMBRE=@NombreUsuario")
				cmdUsuTok.Parameters.Add("CodUsuario", SqlDbType.Int).Value = codUsuario
				cmdUsuTok.Parameters.Add("NombreUsuario", SqlDbType.VarChar).Value = txtUsusario.Text.Trim()
				DataAccess.Execute(cmdUsuTok)

				Me.Close()
			Catch ex As Exception
				TratarError(ex, "GuardarNuevoUsuario")
			End Try
		Finally
			Me.Cursor = Cursors.Default
		End Try
	End Sub

	Private Sub FrmAltaUsuarioNaranja_Load(sender As Object, e As EventArgs) Handles MyBase.Load


		Dim dt = DataAccess.GetDataTable("select * from GRUPOS")

		cboGrupos.Items.Clear()

		For Each dr In dt.Rows
			cboGrupos.Items.Add(New Entities.clsItem(Convert.ToInt64(dr(0).ToString), dr(1).ToString))
		Next
	End Sub
End Class