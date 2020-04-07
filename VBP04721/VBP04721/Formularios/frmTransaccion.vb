Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmTransaccion

	Private oAdmLocal As New AdmTablas
	Private bAlta As Boolean = True

	Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
		Try
			Me.Cursor = Cursors.WaitCursor
			If DatosOK() Then
				If actualizar() Then
					Me.DialogResult = System.Windows.Forms.DialogResult.OK
					Me.Close()
				End If
			End If
		Finally
			Me.Cursor = Cursors.Default
		End Try
	End Sub

	Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
		Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub CargarPerfiles()

		Dim sSQL As String
		Dim ds As DataSet
		Dim item As ListViewItem

		Try

			sSQL = "SELECT * " &
				   "FROM   CABPER " &
				   "ORDER  BY CP_DESCRI ASC"

			ds = oAdmLocal.AbrirDataset(sSQL)

			With ds.Tables(0)

				For Each row As DataRow In .Rows

					item = lvPerfiles.Items.Add(row("CP_DESCRI"))
					item.Name = row("CP_CODPER")
				Next

			End With

			ds = Nothing

		Catch ex As Exception
			TratarError(ex, "CargarPerfiles")
		End Try

	End Sub

	Public Sub New()

		' Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		oAdmLocal.ConnectionString = CONN_LOCAL
		CargarPerfiles()

	End Sub

	Private Sub cmdCarpeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCarpeta.Click

		Dim oCarpeta As New frmArbolMenu

		If oCarpeta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
			txtCarpeta.Text = oCarpeta.NombreMenu
			txtCarpeta.Tag = oCarpeta.NumeroMenu
		End If

	End Sub

	Private Function DatosOK() As Boolean

		If Val(txtCodigo.Text) <= 0 Then
			MensajeError("Código de transacción inválido")
			Exit Function
		End If

		If txtNombre.Text.Trim = "" Then
			MensajeError("Proporcione el nombre de la transacción")
			txtNombre.Focus()
			Exit Function
		End If

		If txtPrograma.Text.Trim = "" Then
			MensajeError("Proporcione el programa de la transacción")
			txtPrograma.Focus()
			Exit Function
		End If

		If txtCarpeta.Text.Trim = "" Then
			MensajeError("Seleccione la carpeta donde debe ser ubicada esta transacción")
			cmdCarpeta.Focus()
			Exit Function
		End If

		If bAlta Then
			If TransaccionExiste(Val(txtCodigo.Text)) Then
				MensajeError("El código que intenta asignar ya pertenece a otra transacción")
				txtCodigo.Focus()
				Exit Function
			End If
		End If

		Return True

	End Function

	Private Function TransaccionExiste(ByVal nCodTra As Long) As Boolean

		Dim nTransa As Long

		nTransa = oAdmLocal.DevolverValor("MENUES", "MU_CODTRA", "MU_CODTRA = " & nCodTra, 0)

		If nTransa <> 0 Then
			Return True
		End If

	End Function

	Private Function actualizar() As Boolean
		Try
			Dim nProxID As Long

			Dim sqlUpd As String
			If bAlta Then
				nProxID = oAdmLocal.ProximoID("MENUES", "MU_NROMEN")
				sqlUpd = "INSERT INTO MENUES (MU_NROMEN,[MU_CODTRA],[MU_TRANSA],[MU_RELMEN],[MU_COMAND],[MU_DESCRI],[MU_NIVEL]) " &
							"VALUES (@MU_NROMEN, @MU_CODTRA, @MU_TRANSA, @MU_RELMEN, @MU_COMAND, @MU_DESCRI, @MU_NIVEL)"
			Else
				nProxID = oAdmLocal.DevolverValor("MENUES", "MU_NROMEN", "MU_CODTRA = " & Val(txtCodigo.Text), 0)
				sqlUpd = "UPDATE MENUES SET  " &
						"	MU_CODTRA = @MU_CODTRA, " &
						"    MU_TRANSA = @MU_TRANSA, " &
						"    MU_RELMEN = @MU_RELMEN, " &
						"	MU_COMAND = @MU_COMAND, " &
						"    MU_DESCRI = @MU_DESCRI, " &
						"	MU_NIVEL = @MU_NIVEL " &
						" WHERE MU_NROMEN = @MU_NROMEN"
			End If

			Dim cmd = New SqlCommand(sqlUpd)

			cmd.Parameters.Add("MU_NROMEN", SqlDbType.Int).Value = nProxID
			cmd.Parameters.Add("MU_CODTRA", SqlDbType.Int).Value = Integer.Parse(txtCodigo.Text)
			cmd.Parameters.Add("MU_TRANSA", SqlDbType.VarChar).Value = txtNombre.Text.Trim
			cmd.Parameters.Add("MU_DESCRI", SqlDbType.VarChar).Value = txtDescripcion.Text.Trim
			cmd.Parameters.Add("MU_COMAND", SqlDbType.VarChar).Value = txtPrograma.Text.Trim
			cmd.Parameters.Add("MU_NIVEL", SqlDbType.Int).Value = 0
			cmd.Parameters.Add("MU_RELMEN", SqlDbType.Int).Value = Integer.Parse(txtCarpeta.Tag)

			oAdmLocal.EjecutarComandoSQL(cmd)

			'Perfiles
			Dim sSQL = "DELETE FROM DETPER WHERE DP_CODTRA = " & Integer.Parse(txtCodigo.Text)

			If oAdmLocal.EjecutarComandoSQL(sSQL) Then

				For Each itmX As ListViewItem In lvPerfiles.Items
					If itmX.Checked Then
						Dim cmdIns As New SqlCommand("INSERT INTO DETPER (DP_CODPER, DP_CODTRA) VALUES (@DP_CODPER, @DP_CODTRA)")
						cmdIns.Parameters.Add("DP_CODPER", SqlDbType.Int).Value = Integer.Parse(itmX.Name)
						cmdIns.Parameters.Add("DP_CODTRA", SqlDbType.Int).Value = Integer.Parse(txtCodigo.Text)

						oAdmLocal.EjecutarComandoSQL(cmdIns)
					End If
				Next

			End If

			Return True

		Catch ex As Exception
			TratarError(ex, "actualizar")
		End Try

	End Function

	Public Sub PasarDatos(ByVal nNroMen As Long)

		Dim sSQL As String
		Dim ds As DataSet
		Dim item As ListViewItem
		Dim row As DataRow

		Try

			sSQL = "SELECT * " &
				   "FROM   MENUES " &
				   "WHERE  MU_NROMEN = " & nNroMen.ToString & " "
			ds = oAdmLocal.AbrirDataset(sSQL)

			If ds.Tables(0).Rows.Count > 0 Then

				row = ds.Tables(0).Rows(0)

				txtCodigo.Text = row("MU_CODTRA")
				txtNombre.Text = row("MU_TRANSA")
				txtPrograma.Text = row("MU_COMAND")
				txtDescripcion.Text = row("MU_DESCRI")

				If row("MU_RELMEN") = 0 Then
					txtCarpeta.Text = "Menú"
				Else
					txtCarpeta.Text = oAdmLocal.DevolverValor("MENUES", "MU_TRANSA", "MU_NROMEN=" & row("MU_RELMEN"))
				End If
				txtCarpeta.Tag = row("MU_RELMEN")

			End If

			ds = Nothing

			txtCodigo.Enabled = False

			bAlta = False

			sSQL = "SELECT    * " &
				   "FROM      DETPER " &
				   "WHERE     DP_CODTRA = " & txtCodigo.Text & " " &
				   "ORDER BY  DP_CODPER "
			ds = oAdmLocal.AbrirDataset(sSQL)

			With ds.Tables(0)

				For Each row In .Rows

					item = lvPerfiles.Items(row("DP_CODPER").ToString)
					item.Checked = True

				Next

			End With

			ds = Nothing

		Catch ex As Exception
			TratarError(ex, "PasarDatos")
		End Try

	End Sub

End Class
