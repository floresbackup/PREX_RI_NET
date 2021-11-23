Imports System.Data.SqlClient
Imports System.Linq
Imports Prex.Utils

Public Class frmMain

	Private oAdmLocal As New AdmTablas
	Private oIconos As New ExtraerIconos
	Private TransaccionesHabilitadas As List(Of Long)
	Private TransaccionesInhaabilitadas As List(Of Long)
	Private ListadoNodosHabilitados As List(Of Integer)
	Private ListadoMenu As List(Of MenuSistema)
	Private _mostrarSoloMenuesHabilitados As Boolean? = Nothing

	Private ReadOnly Property MostrarSoloMenuesHabilitados As Boolean
		Get
			If Not _mostrarSoloMenuesHabilitados.HasValue Then
				_mostrarSoloMenuesHabilitados = IIf(UsuarioActual.Nombre.ToLower = "admin", False, CBool(Val(oAdmLocal.DevolverValor("TABGEN", "TG_NUME01", "", "TG_CODCON = 50 AND TG_CODTAB = " & CType(EnumTablasGenerales.TGL_PARAMETROS_GENERALES, Integer).ToString))))
			End If

			Return _mostrarSoloMenuesHabilitados.Value
		End Get
	End Property

	Public Sub New()

		' Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		oAdmLocal.ConnectionString = CONN_LOCAL

		lblUsuario.Text = UsuarioActual.Descripcion
		lblEntidad.Text = NOMBRE_ENTIDAD ' UsuarioActual.Entidad
		CargarILMenu()
		CargarMenu()
		CargarTransacciones(UsuarioActual.Codigo)

	End Sub

	Private Sub CargarILMenu()

		If Prex.Utils.Configuration.PrexConfigLocal.SiempreIG = 1 Then
			lvTrans.SmallImageList = il32x32
		Else
			lvTrans.SmallImageList = il16x16
		End If
		lvTrans.Refresh()
	End Sub

	Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click, btnSalir.Click
		Me.Close()
	End Sub

	Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		Try
			Cursor = Cursors.WaitCursor
			CargarArbol()
			CargarMenues(0)
			SetFooterFechaHora()
		Finally
			Cursor = Cursors.Default
		End Try
	End Sub

	Private Sub CargarArbol()
		Try

			Dim sqlWhere = String.Empty

			If MostrarSoloMenuesHabilitados Then


				Dim codUsuario = UsuarioActual.Codigo

				Dim sqlMaxNivel = "SELECT  MAX(MU_NIVEL) AS MU_NIVEL 
                                        FROM    MENUES 
                                        WHERE   MU_NIVEL <> 0 
                                        AND MU_NROMEN IN ( SELECT   DISTINCT MU_RELMEN 
	                                        FROM     MENUES 
	                                        WHERE    MU_CODTRA IN (SELECT   DISTINCT DP_CODTRA 
		                                        FROM     DETPER 
		                                        WHERE    DP_CODPER IN (SELECT   DISTINCT HA_CODPER 
								                                        FROM     HABILI 
								                                        WHERE    (HA_TIPOBJ = 'G' 
								                                        AND HA_CODOBJ = (SELECT  UG_CODGRU FROM    USUGRU 
													                                        WHERE   UG_CODUSU = " & codUsuario & ")) 
								                                        OR (HA_TIPOBJ = 'U' AND       HA_CODOBJ = " & codUsuario & " )) )) "

				Dim nivelMaximo = CType(Prex.Utils.DataAccess.GetScalar(sqlMaxNivel), Integer)

				Dim sqlMenuHabilitados = "SELECT  MU_NROMEN
										 From MENUES 
										 WHERE   MU_NIVEL <> 0 
										 And     MU_NROMEN IN (SELECT   DISTINCT MU_RELMEN 
															  From MENUES 
															  WHERE    MU_CODTRA IN ( 
																	   Select DISTINCT DP_CODTRA
																	   FROM     DETPER 
																	   WHERE    DP_CODPER IN (
																				SELECT DISTINCT HA_CODPER
																				From HABILI 
																				WHERE  (HA_TIPOBJ = 'G' 
																				And     HA_CODOBJ = (SELECT UG_CODGRU
																									 FROM   USUGRU 
																									 WHERE  UG_CODUSU = " & codUsuario & " )) 
																				OR       (HA_TIPOBJ = 'U' 
																				AND       HA_CODOBJ = " & codUsuario & " )))) 
										 OR            MU_RELMEN = 0"

				ListadoNodosHabilitados = New List(Of Integer)

				Dim r As SqlDataReader = DataAccess.GetReader(sqlMenuHabilitados)
				While r.Read()
					ListadoNodosHabilitados.Add(r("MU_NROMEN"))
				End While
				r.Close()

				Do While nivelMaximo >= 2

					sqlMenuHabilitados = "SELECT    DISTINCT MU_RELMEN
										FROM      MENUES
										WHERE     MU_NIVEL <> 0
										AND       MU_NIVEL = " & nivelMaximo & " 
										AND       MU_RELMEN NOT IN " & ListadoNodosHabilitados.Distinct.ToCompleteInStr() & "
										AND       MU_NROMEN IN (SELECT  DISTINCT MU_RELMEN 
																FROM    MENUES 
																WHERE   MU_CODTRA IN (
																		SELECT   DISTINCT DP_CODTRA 
																		FROM     DETPER 
																		WHERE    DP_CODPER IN (SELECT  DISTINCT HA_CODPER
																				FROM    HABILI
																				WHERE   (HA_TIPOBJ = 'G'
																				AND      HA_CODOBJ = (SELECT  UG_CODGRU
																										FROM    USUGRU 
																										WHERE   UG_CODUSU = " & codUsuario & " )) 
																				OR      (HA_TIPOBJ = 'U'
																				AND      HA_CODOBJ = " & codUsuario & " )) ))"

					r = DataAccess.GetReader(sqlMenuHabilitados)
					While r.Read()


						ListadoNodosHabilitados.Add(r("MU_RELMEN"))
					End While
					r.Close()

					nivelMaximo -= 1
				Loop

				sqlWhere = String.Empty ' " AND  MU_NROMEN IN " & ListadoNodosHabilitados.Distinct.ToCompleteInStr()
			End If

			'antes
			'Dim sSQL = "SELECT * FROM MENUES 
			'		   WHERE MU_NIVEL <> 0 " & sqlWhere & "
			'		   ORDER BY MU_NIVEL, MU_TRANSA"

			'Dim ds As DataSet = oAdmLocal.AbrirDataset(sSQL)

			'tvMenu.Nodes.Clear()

			'With ds.Tables(0)

			'	nodo = tvMenu.Nodes.Add("K0", "Menú", "Menu")

			'	For Each dr As DataRow In .Rows
			'		If TieneTransaccionesRecursivasMenu(Long.Parse(dr("MU_NROMEN"))) Then

			'			tvMenu.BeginUpdate()
			'			Dim nuevoNodo() = tvMenu.Nodes.Find("K" & dr("MU_RELMEN").ToString, True)
			'			If nuevoNodo.Length > 0 Then
			'				nuevoNodo(0).Nodes.Add("K" & dr("MU_NROMEN").ToString, dr("MU_TRANSA").ToString, "Cerrada")
			'			End If
			'			tvMenu.EndUpdate()
			'		End If
			'	Next
			'End With
			tvMenu.Nodes.Clear()
			Dim nodo = tvMenu.Nodes.Add("K0", "Menú", "Menu", "Menu")

			For Each mnu As MenuSistema In ListadoMenu.OrderBy(Function(l) l.MU_NIVEL).ThenBy(Function(l) l.MU_TRANSA).Where(Function(m) m.MU_NIVEL <> 0)
				If TieneTransaccionesRecursivasMenu(mnu.MU_NROMEN) Then

					tvMenu.BeginUpdate()
					Dim nuevoNodo() = tvMenu.Nodes.Find("K" & mnu.MU_RELMEN.ToString, True)
					If nuevoNodo.Length > 0 Then
						nuevoNodo(0).Nodes.Add("K" & mnu.MU_NROMEN.ToString, mnu.MU_TRANSA, "Cerrada")
					End If
					tvMenu.EndUpdate()
				End If
			Next
			nodo.Expand()

		Catch ex As Exception
			TratarError(ex, "CargarArbol")
		End Try

	End Sub

	Private Sub CargarMenues(ByVal nMenu As Long)
		Try

			Dim ds As DataSet
			Dim nodo As ListViewItem
			Dim sqlWhere = String.Empty

			Me.Cursor = Cursors.WaitCursor

			Try

				LimpiarIL()
				'Dim lst As List(Of Integer) = ListadoNodosHabilitados.Distinct.Where(Function(l) TieneTransaccionesRecursivasMenu(l)).ToList
				'Cargo las carpetas
				'Dim sSQL = "SELECT    * " &
				'	   "FROM      MENUES " &
				'	   "WHERE     MU_RELMEN = " & nMenu.ToString & " " & sqlWhere &
				'	   "ORDER BY  MU_NIVEL DESC, MU_TRANSA ASC"
				'ds = oAdmLocal.AbrirDataset(sSQL)

				lvTrans.Items.Clear()

				'For Each dr As DataRow In ds.Tables(0).Rows
				For Each itemMenu As MenuSistema In ListadoMenu.OrderByDescending(Function(l) l.MU_NIVEL).ThenBy(Function(l) l.MU_TRANSA).Where(Function(l) l.MU_RELMEN = nMenu)
					If itemMenu.MU_CODTRA = 0 Then
						If Not TieneTransaccionesRecursivasMenu(itemMenu.MU_NROMEN) Then Continue For

						' Adding the text value of a folder in the list view
						nodo = lvTrans.Items.Add("C" & itemMenu.MU_NROMEN.ToString, itemMenu.MU_TRANSA, "Carpeta")

						' We add the description value to the list view ,
						' if the column is empty in db, the value of the list view will be empty
						nodo.SubItems.Add(itemMenu.MU_DESCRI)

					ElseIf Not MostrarSoloMenuesHabilitados OrElse TransaccionHabilitadaEnUsuario(itemMenu.MU_CODTRA, UsuarioActual.Codigo) Then
						nodo = lvTrans.Items.Add(itemMenu.MU_TRANSA.ToString)

						' We add the description value to the list view ,
						' if the column is empty in db, the value of the list view will be empty
						nodo.SubItems.Add(itemMenu.MU_DESCRI)
						nodo.Name = "T" & itemMenu.MU_CODTRA.ToString
						nodo.Tag = itemMenu.MU_COMAND

						' We add an icon to the list view row deppending the value of the .exe that
						' we find in the column MU_COMAND in db
						' Important: Find any one of this values in the collection of icons of the list view

						Select Case itemMenu.MU_COMAND
							Case "VBP04295.EXE"
								If InStr("4102, 4104, 4103, 4105, 4106, 4107, 4194, 4101, 4195, 4196, 6191", itemMenu.MU_CODTRA.ToString, CompareMethod.Text) > 0 Then
									nodo.ImageKey = "Controles"
								Else
									nodo.ImageKey = "Formularios"
								End If
							Case "VBP04395.EXE"
								nodo.ImageKey = "Procesos"
							Case "VBP04865.EXE"
								nodo.ImageKey = "Actualizador"
							Case "VBP04721.EXE"
								nodo.ImageKey = "Administracion"
							Case "VBP08800.EXE"
								nodo.ImageKey = "Calculadora"
							Case "VBP04098.EXE"
								nodo.ImageKey = "Consolida"
							Case "VBP04000.EXE"
								nodo.ImageKey = "Consultas"
							Case "VBP04725.EXE"
								nodo.ImageKey = "Equivalencias"
							Case "VBP04893.EXE"
								nodo.ImageKey = "Feriados"
							Case "VBP09001.EXE"
								nodo.ImageKey = "GeneraTXT"
							Case "VBP04711.EXE"
								nodo.ImageKey = "Logs"
							Case "VBP70199.EXE"
								nodo.ImageKey = "Notas"
							Case "VBP04730.EXE"
								nodo.ImageKey = "Relaciones"
							Case "VBP04720.EXE"
								nodo.ImageKey = "Seguridad"
							Case "VBP04999.EXE"
								nodo.ImageKey = "Spool"
							Case "VBP04723.EXE"
								nodo.ImageKey = "Tabgen"

								'We needs an exe to asign the ExportExcel icon
								'  Case ""
								'     nodo.ImageKey = "ExportExcel"
							Case Else
								nodo.ImageKey = "Transaccion"


						End Select

						' Here we add the transaction code to the list view
						nodo.SubItems.Add(itemMenu.MU_CODTRA)

					End If
				Next

				ds = Nothing

				Dim oNodo() As TreeNode = tvMenu.Nodes.Find("K" & nMenu.ToString, True)
				If oNodo.Length > 0 Then
					tvMenu.SelectedNode = oNodo(0)
				End If
				ResizeColumns()

			Catch ex As Exception
				TratarError(ex, "CargarMenues(" & nMenu.ToString & ")")
			End Try

		Finally
			Me.Cursor = Cursors.Default
		End Try
	End Sub

	Private Sub ResizeColumns()
		Dim colCodTran = 80
		Dim colMenu = ((lvTrans.Width - colCodTran) / 3) - 10
		Dim colDescripcion = lvTrans.Width - colCodTran - colMenu

		lvTrans.Columns.Item(0).Width = If(colMenu > 200, colMenu, 200)
		lvTrans.Columns.Item(1).Width = If(colDescripcion > 200, colDescripcion, 200)
		lvTrans.Columns.Item(2).Width = colCodTran
		Dim widthTotal = lvTrans.Columns.Item(0).Width + lvTrans.Columns.Item(1).Width + lvTrans.Columns.Item(2).Width
		If lvTrans.ClientSize.Width < widthTotal And lvTrans.Columns.Item(0).Width > 200 Then
			Dim offset = (widthTotal - lvTrans.ClientSize.Width) / 2
			lvTrans.Columns.Item(0).Width -= offset
			lvTrans.Columns.Item(1).Width -= offset
		End If
	End Sub


	Private DiccionarioMenuTransacciones As New Dictionary(Of Integer, List(Of Long))

	Private Function TieneTransaccionesRecursivasMenu(ByVal codMenuRel As Integer) As Boolean
		If UsuarioActual.Nombre.ToLower = "admin" OrElse Not MostrarSoloMenuesHabilitados Then Return True
		If DiccionarioMenuTransacciones.ContainsKey(codMenuRel) Then Return DiccionarioMenuTransacciones(codMenuRel).Any


		Dim encontre As Boolean = False

		Dim sql = "with cte as
					(
						SELECT * FROM MENUES WHERE MU_NROMEN = " & codMenuRel.ToString() & "
						union all
						SELECT M.* FROM MENUES M
						inner join cte on M.MU_RELMEN = CTE.MU_NROMEN
					)
					select distinct MU_CODTRA from cte "


		Dim reader As SqlDataReader = Prex.Utils.DataAccess.GetReader(sql)
		While reader.Read
			If Not DiccionarioMenuTransacciones.ContainsKey(codMenuRel) Then
				DiccionarioMenuTransacciones.Add(codMenuRel, New List(Of Long))
			End If
			Dim codTran = Long.Parse(reader("MU_CODTRA"))
			If TransaccionHabilitadaEnUsuario(codTran, UsuarioActual.Codigo) Then
				encontre = True
				DiccionarioMenuTransacciones(codMenuRel).Add(codTran)
			End If
		End While
		reader.Close()

		Return encontre
	End Function

	Private Sub txtCodTra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodTra.KeyDown

		'Dim sSQL As String
		'Dim ds As DataSet

		If e.KeyCode = Keys.Return Then

			'sSQL = "SELECT    TOP 1 * " &
			'	   "FROM      MENUES " &
			'	   "WHERE     MU_CODTRA = " & Val(txtCodTra.Text) & " "

			'ds = oAdmLocal.AbrirDataset(sSQL)

			'If ds.Tables(0).Rows.Count = 0 Then
			Dim itemMenu As MenuSistema = ListadoMenu.FirstOrDefault(Function(m) m.MU_CODTRA = Val(txtCodTra.Text))
			If itemMenu Is Nothing Then
				MensajeError("Transacción inexistente")
			ElseIf UsuarioActual.Nombre.ToLower() = "admin" Then
				EjecutarTransaccion(Val(txtCodTra.Text), itemMenu.MU_COMAND)
			Else
				EjecutarTransaccion(Val(txtCodTra.Text), itemMenu.MU_COMAND, UsuarioActual.Codigo)
			End If

		End If

	End Sub

	Private Sub EjecutarTransaccion(ByVal nTransaccion As Long, ByVal sPrograma As String, Optional ByVal nCodigoUsuario As Integer = -1)

		Try
			Me.Cursor = Cursors.WaitCursor
			Try

				Dim oTrx As New System.Diagnostics.Process

				If nCodigoUsuario = -1 Then

					nCodigoUsuario = UsuarioActual.Codigo

					If Not TransaccionHabilitada(nTransaccion) Then
						GuardarLOG(AccionesLOG.AL_VIOLACION_SEGURIDAD, "", nTransaccion)
						MensajeError("Violación de seguridad. No dispone de privilegios para ingresar a esta transacción")
						Exit Try
					End If

				Else

					If Not TransaccionHabilitadaEnUsuario(nTransaccion, nCodigoUsuario) Then
						GuardarLOG(AccionesLOG.AL_VIOLACION_SEGURIDAD, "", nTransaccion, nCodigoUsuario)
						MensajeError("Violación de seguridad. No dispone de privilegios para ingresar a esta transacción")
						Exit Try
					End If

				End If

				If IO.Path.GetExtension(sPrograma).ToLower().Contains("exe") Then
					Dim sRuta = RUTA_BIN & sPrograma
					Dim sParametros = "/u:" & nCodigoUsuario.ToString & "/t:" & nTransaccion.ToString & "/e:" & CODIGO_ENTIDAD.ToString
					If IO.File.Exists(sRuta) Then

						GuardarLOG(AccionesLOG.AL_INGRESO_TRANSACCION, "Ingreso a transacción", CODIGO_TRANSACCION, UsuarioActual.Codigo)
						'If MULTIEXEC = 1 Then
						If sPrograma.Contains("VBP09001") AndAlso RUTAENCR_RA.Length > 2 Then
							If Not System.IO.File.Exists(RUTAENCR_RA & "\PrExEncr_RA.txt") Then
								Throw New Exception("No se encontró archivo de encriptación de usuario: [" & RUTAENCR_RA & "\PrExEncr_RA.txt]")
							End If

							Dim sUsuEncr_RA As String
							Dim sPwdEncr_RA As String

							LeerArchivoEncriptado(RUTAENCR_RA & "\PrExEncr_RA.txt", sUsuEncr_RA, sPwdEncr_RA)
							sPwdEncr_RA = ObternerPasswordRunAsCyberark(sPwdEncr_RA)



							RunProgram(sUsuEncr_RA, sPwdEncr_RA, DOMINIO_DEFAULT, sRuta, sParametros)
						Else
							Process.Start(sRuta, sParametros)
						End If
					Else
						MensajeError("No se encuentra el programa " & sPrograma)
					End If
				ElseIf IO.File.Exists(NormalizarRuta(RUTA_BIN) & "Informes\" & sPrograma) Then

					GuardarExcelEncryptParaCiti()

					Process.Start(NormalizarRuta(RUTA_BIN) & "Informes/" & sPrograma)
				Else
					MensajeError("No se encuentra el archivo " & sPrograma)
				End If
			Catch ex As Exception
				TratarError(ex, "EjecutarTransaccion(" & nTransaccion.ToString & "," & sPrograma & "," & nCodigoUsuario & ")")
				'Throw ex
			End Try

		Finally
			Me.Cursor = Cursors.Default
		End Try
	End Sub


	Private Function ObternerPasswordRunAsCyberark(ByVal pass As String) As String
		If ID_SISTEMA <= 0 Then
			Return pass
		End If
		Try
			Dim passCyberArk As String = Prex.Utils.Security.CitiSecurity.GetPassWordCyberRark(WSDL, CertificatePath, CertificatePass, APPID, SAFE, STR_FOLDER, STR_OBJECT_AD, STR_REASON)
			If passCyberArk Is Nothing OrElse String.IsNullOrEmpty(passCyberArk.Trim()) Then
				Return pass
			End If

			Return passCyberArk
		Catch ex As Exception
			Return pass
		End Try

	End Function

	Private Sub GuardarExcelEncryptParaCiti()
		If ID_SISTEMA <= 0 Then Exit Sub

		Dim sUsuEncr = String.Empty
		Try
			Dim builder As New OleDb.OleDbConnectionStringBuilder(Configuration.PrexConfig.CONN_LOCAL)
			sUsuEncr = builder("User ID").ToString()
		Catch ex As Exception
			Throw New Exception("Ocurrió un error al obtener usuario desde la cadena de conexión", ex)
		End Try

		Dim sPwdEncr = String.Empty
		Try
			sPwdEncr = ObternerPasswordRunAsCyberark(sPwdEncr)
		Catch ex As Exception
			Throw New Exception("Ocurrió un error al obtener password desde Cyberark", ex)
		End Try

		If String.IsNullOrEmpty(sPwdEncr) Then
			Throw New Exception("Cyberark devolvió password vacio")
		End If

		Try
			GuardarArchivoEncriptadoNew(IO.Path.Combine(CARPETA_LOCAL, "ExcelEncrypt.txt"), sUsuEncr, sPwdEncr)
		Catch ex As Exception
			Throw New Exception("Ocurrió un error al guardar archivo ExcelEncrypt.txt", ex)
		End Try
	End Sub

	Private Sub btnIr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIr.Click

		Dim evArgs As New System.Windows.Forms.KeyEventArgs(Keys.Return)

		txtCodTra_KeyDown(sender, evArgs)

	End Sub

	Private Sub lvTrans_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvTrans.MouseDoubleClick

		Dim oItem As ListViewItem

		oItem = lvTrans.HitTest(e.Location).Item

		If oItem.Name.Substring(0, 1) = "T" Then
			If UsuarioActual.Nombre.ToLower = "admin" Then
				EjecutarTransaccion(Val(oItem.Name.Substring(1)), oItem.Tag)
			Else
				EjecutarTransaccion(Val(oItem.Name.Substring(1)), oItem.Tag, UsuarioActual.Codigo)
			End If
		Else
			CargarMenues(Val(oItem.Name.Substring(1)))
		End If

	End Sub

	Private Sub tvMenu_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvMenu.NodeMouseClick
		CargarMenues(Val(e.Node.Name.Substring(1)))
	End Sub

	Private Sub mnuPreferencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPreferencias.Click
		Try
			Me.Cursor = Cursors.WaitCursor
			Dim oOpciones As New frmOpciones

			oOpciones.ShowDialog(Me)

			oOpciones = Nothing
			CargarILMenu()
		Finally
			Me.Cursor = Cursors.Default
		End Try
	End Sub

	Private Sub LimpiarIL()

		'Dim nC As Integer

		' For nC = (il16x16.Images.Count - 1) * -1 To -2
		' il16x16.Images.RemoveAt(nC * -1)
		' Next

		'For nC = (il32x32.Images.Count - 1) * -1 To -2
		' il32x32.Images.RemoveAt(nC * -1)
		' Next

	End Sub

	Private Sub mnuIconos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIconos.Click

		lvTrans.View = View.Tile

	End Sub

	Private Sub mnuLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLista.Click

		lvTrans.View = View.List

	End Sub

	Private Sub mnuDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDetalle.Click

		lvTrans.View = View.Details

	End Sub

	Public Function ActualizarSeguridad(Optional ByVal sPerfil As String = "") As Boolean

		Dim oAdmUsuarios As New AdmUsuarios

		If SEGURIDAD_INTEGRADA Then

			HABILITACIONES_ESPECIALES = MenuesSeguridadIntegrada(UsuarioActual.Nombre)
			INHABILITACIONES_ESPECIALES = ""

			mnuActualizar.Enabled = False

		ElseIf ID_SISTEMA <> 0 Then '2009/10/27 CITIBANK

			HABILITACIONES_ESPECIALES = TrxCitiBank(sPerfil)

		Else

			HABILITACIONES_ESPECIALES = oAdmUsuarios.DevolverHabilitacionesUsuario(UsuarioActual.Codigo)
			INHABILITACIONES_ESPECIALES = oAdmUsuarios.DevolverInhabilitacionesUsuario(UsuarioActual.Codigo)

		End If

		oAdmUsuarios = Nothing
		If HABILITACIONES_ESPECIALES.Trim().Replace(" ", String.Empty) = String.Empty Then
			Return False
		Else
			Return True
		End If
	End Function

	Private Function TransaccionHabilitada(ByVal nCodTransaccion As Long) As Boolean

		If UCase(UsuarioActual.Nombre) = "ADMIN" Then
			TransaccionHabilitada = True
			Exit Function
		End If
		If HABILITACIONES_ESPECIALES.Split(",").Where(Function(s) s.Trim().Length > 0).Contains(nCodTransaccion) Then Return True
		If INHABILITACIONES_ESPECIALES.Split(",").Where(Function(s) s.Trim().Length > 0).Contains(nCodTransaccion) Then Return False
		Return False

		'If Len(HABILITACIONES_ESPECIALES) > 0 Then
		'    If InStr(1, HABILITACIONES_ESPECIALES, CStr(nCodTransaccion)) > 0 Then
		'        If Len(INHABILITACIONES_ESPECIALES) > 0 Then
		'            If InStr(1, INHABILITACIONES_ESPECIALES, CStr(nCodTransaccion)) = 0 Then
		'                TransaccionHabilitada = True
		'            End If
		'        Else
		'            TransaccionHabilitada = True
		'        End If
		'    End If
		'End If

	End Function

	Private Function TransaccionHabilitadaEnUsuario(ByVal nCodTransaccion As Long, ByVal nCodUsuario As Long) As Boolean
		If UsuarioActual.Nombre.ToLower = "admin" Then Return True

		If TransaccionesHabilitadas Is Nothing OrElse TransaccionesInhaabilitadas Is Nothing Then

			CargarTransacciones(nCodUsuario)
		End If

		If TransaccionesHabilitadas.Contains(nCodTransaccion) Then Return True
		If TransaccionesInhaabilitadas.Contains(nCodTransaccion) Then Return False

		Return False
	End Function

	Private Sub CargarMenu()
		Dim sSQL = "SELECT * FROM MENUES ORDER BY  MU_NIVEL DESC, MU_TRANSA ASC"
		Dim reader As SqlDataReader = Prex.Utils.DataAccess.GetReader(sSQL)
		ListadoMenu = New List(Of MenuSistema)

		While reader.Read
			ListadoMenu.Add(New MenuSistema(reader))
		End While
		reader.Close()
	End Sub

	Private Sub CargarTransacciones(ByVal nCodUsuario As Long)
		Dim sHabs As String = ""
		Dim sInHabs As String = ""
		Dim oAdmUsuarios As New AdmUsuarios

		If SEGURIDAD_INTEGRADA Then

			sHabs = MenuesSeguridadIntegrada(oAdmLocal.DevolverValor("USUARI", "US_NOMBRE", "US_CODUSU=" & nCodUsuario, ""))
			sInHabs = ""

		Else

			sHabs = oAdmUsuarios.DevolverHabilitacionesUsuario(nCodUsuario)
			sInHabs = oAdmUsuarios.DevolverInhabilitacionesUsuario(nCodUsuario)

		End If

		TransaccionesHabilitadas = sHabs.Split(",").Where(Function(s) s.Trim().Length > 0).Select(Function(s) Long.Parse(s)).ToList()
		TransaccionesInhaabilitadas = sInHabs.Split(",").Where(Function(s) s.Trim().Length > 0).Select(Function(s) Long.Parse(s)).ToList()
	End Sub


	Public Function MenuesSeguridadIntegrada(ByVal sNombreUsuario As String) As String

		On Error GoTo Err_Trap

		Dim sTemp As String = ""
		Dim sMatriz() As String
		Dim i As Integer

		Dim oConn As SqlConnection
		Dim oComm As SqlCommand
		Dim oRst As IDataReader

		' CONEXION
		oConn = New SqlConnection

		oConn.ConnectionString = "DRIVER=SQL Server;" &
								 "SERVER=" & NOMBRE_SQLSERVER & ";" &
								 "APP=PREXRI;" &
								 "WSID=" & sNombreUsuario & ";" &
								 "DATABASE=" & NOMBRE_BD & ";" &
								 "NETWORK=DBMSLPCN;" &
								 "TRUSTED_CONNECTION=YES"
		oConn.Open()

		' PERMISOS

		oComm = New SqlCommand

		oComm.Connection = oConn
		oComm.CommandText = "EXEC sp_setapprole 'AppSeguridad' , {Encrypt N 'SegIntWin'} , 'odbc'"
		oComm.ExecuteNonQuery()

		oComm = Nothing

		' RECORDSET CON MENUES

		oComm = New SqlCommand
		oComm.Connection = oConn
		oComm.CommandText = "EXEC crearCursorTree '" & NUMERO_SISTEMA & "','" & UsuarioActual.Nombre & "', '" & LOG_AUDITORIA & "'"
		oRst = oComm.ExecuteReader

		With oRst.Read()
			sTemp = sTemp & oRst("NodoCall").ToString & ","
		End With
		oRst.Close()

		MenuesSeguridadIntegrada = sTemp

		'   Open "C:\MenuesSegInt.txt" For Output As #1
		'      Print #1, CONN_LOCAL
		'      Print #1, "--------------------------------------------"
		'      Print #1, sTemp
		'   Close #1

Err_Trap:

		oConn = Nothing
		oComm = Nothing
		oRst = Nothing

		If Err.Number <> 0 Then
			TratarErrorErr(Err, "MenuesSeguridadIntegrada")
		End If

	End Function

	Private Function DatosEquipo() As String

		On Error Resume Next

		Dim ds As DataSet
		Dim sSQL As String
		Dim sTemp As String = ""

		sTemp = "Ruta aplicación: " & vbCrLf & Application.ExecutablePath & vbCrLf & vbCrLf

		sSQL = "SELECT DB_NAME() AS BASEDATOS "
		ds = oAdmLocal.AbrirDataset(sSQL)

		sTemp = sTemp & "Base de datos: " & vbCrLf & ds.Tables(0).Rows(0).Item("BASEDATOS") & vbCrLf & vbCrLf

		ds = Nothing

		sSQL = "SELECT   CONVERT(char(20), SERVERPROPERTY('servername')) AS SERVIDOR "
		ds = oAdmLocal.AbrirDataset(sSQL)

		sTemp = sTemp & "Servidor SQL: " & vbCrLf & ds.Tables(0).Rows(0).Item("SERVIDOR") & vbCrLf & vbCrLf

		ds = Nothing

		sSQL = "SELECT   CONVERT(char(20), SERVERPROPERTY('collation')) as COLL"
		ds = oAdmLocal.AbrirDataset(sSQL)

		sTemp = sTemp & "Intercalación SQL: " & vbCrLf & ds.Tables(0).Rows(0).Item("COLL") & vbCrLf & vbCrLf

		ds = Nothing

		sSQL = "SELECT @@VERSION AS VERSIONSQL "
		ds = oAdmLocal.AbrirDataset(sSQL)

		sTemp = sTemp & "Versión SQL: " & vbCrLf & Replace(Replace(ds.Tables(0).Rows(0).Item("VERSIONSQL"), vbLf, vbCrLf), vbTab, "") & vbCrLf

		ds = Nothing

		Return sTemp

	End Function

	Private Function TrxCitiBank(ByVal sPerfil As String) As String

		Dim sSQL As String
		Dim ds As DataSet
		Dim sTemp As String = ""

		Try

			sSQL = "       SELECT      DISTINCT DP_CODTRA " & vbCrLf
			sSQL = sSQL & "FROM        DETPER " & vbCrLf
			sSQL = sSQL & "INNER JOIN  CABPER " & vbCrLf
			sSQL = sSQL & "ON          CP_CODPER = DP_CODPER " & vbCrLf
			sSQL = sSQL & "WHERE       CP_DESCRI LIKE '" & Replace(sPerfil, "*", "%") & "' "

			ds = oAdmLocal.AbrirDataset(sSQL)

			For Each row As DataRow In ds.Tables(0).Rows
				sTemp = sTemp & row("DP_CODTRA") & ","
			Next

			ds = Nothing

		Catch ex As Exception
			TratarError(ex, "trxCitibank")
		End Try

		Return sTemp

	End Function

	Private Sub btnSubir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubir.Click

		subirCarpeta()

	End Sub

	Private Sub subirCarpeta()



		If Not (tvMenu.SelectedNode Is Nothing) Then
			If tvMenu.SelectedNode.Name <> "K0" Then
				Dim nMenu As Long = Convert.ToInt32(tvMenu.SelectedNode.Parent.Name.Substring(1))
				tvMenu.SelectedNode = tvMenu.Nodes(tvMenu.SelectedNode.Parent.Name)
				CargarMenues(nMenu)
			End If
		End If

	End Sub

	Private Sub mnuAcerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAcerca.Click

		Dim oSplash As New SplashScreen

		oSplash.AcercaDe = True
		oSplash.ShowDialog()

		oSplash = Nothing

	End Sub

	Protected Overrides Sub Finalize()
		MyBase.Finalize()
	End Sub

	Private Sub lvTrans_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvTrans.SelectedIndexChanged

	End Sub

	Private Sub txtCodTra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodTra.Click

	End Sub

	Private Sub tvMenu_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMenu.AfterSelect

	End Sub

	Private Sub frmMain_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
		ResizeColumns()
	End Sub

	Private Sub TimerFooter_Tick(sender As Object, e As EventArgs) Handles TimerFooter.Tick
		SetFooterFechaHora()
	End Sub

	Private Sub SetFooterFechaHora()

		lblFecha.Text = DateTime.Now.ToShortDateString()
		lblHora.Text = DateTime.Now.ToShortTimeString()
	End Sub
	Private Sub frmMain_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
		If e.KeyCode = Keys.CapsLock Then
			lblCaps.Enabled = Control.IsKeyLocked(Keys.CapsLock)
		ElseIf e.KeyCode = Keys.NumLock Then
			lblNum.Enabled = Control.IsKeyLocked(Keys.NumLock)
		End If
	End Sub

	Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
		lblCaps.Enabled = Control.IsKeyLocked(Keys.CapsLock)

		lblNum.Enabled = Control.IsKeyLocked(Keys.NumLock)
	End Sub

	Private Sub mnuActualizar_Click(sender As Object, e As EventArgs) Handles mnuActualizar.Click
		Try
			Me.Cursor = Cursors.WaitCursor
			DiccionarioMenuTransacciones.Clear()
			TransaccionesHabilitadas = Nothing
			TransaccionesInhaabilitadas = Nothing
			ListadoNodosHabilitados = Nothing
			_mostrarSoloMenuesHabilitados = Nothing
			CargarMenu()
			CargarTransacciones(UsuarioActual.Codigo)
			CargarArbol()
			CargarMenues(0)
		Finally
			Me.Cursor = Cursors.Default
		End Try
	End Sub

	Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		GuardarLOG(AccionesLOG.AL_SALIDA_SISTEMA, "Salida del sistema", CODIGO_TRANSACCION)
	End Sub

	Private Sub mnuMain_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuMain.ItemClicked

	End Sub


	'resize de menu
	'Private Function GetMaxNodeWidth(ByVal nodes As TreeNodeCollection, ByVal width As Integer) As Integer
	'    For Each node As TreeNode In nodes
	'        If node.IsExpanded Then
	'            width = Math.Max(width, node.Bounds.Right)
	'            width = GetMaxNodeWidth(node.Nodes, width)
	'        End If
	'    Next
	'    Return width
	'End Function

	'Private Function ResizeTreeView(ByVal tree As TreeView) As Integer
	'    Dim width = GetMaxNodeWidth(tree.Nodes, 0)
	'    tree.ClientSize = New Size(width, tree.ClientSize.Height)
	'    Return tree.Width
	'End Function

	'Private Sub tvMenu_AfterExpand(sender As Object, e As TreeViewEventArgs) Handles tvMenu.AfterExpand
	'    Dim max = GetMaxNodeWidth(tvMenu.Nodes, 20)
	'    If max > 600 Then
	'        SplitContainer1.SplitterDistance = max
	'    End If
	'End Sub
End Class

