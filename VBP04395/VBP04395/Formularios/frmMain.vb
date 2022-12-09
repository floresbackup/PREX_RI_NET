Imports System.Data.SqlClient
Imports System.IO
Imports System.Linq
Imports System.Net
Imports Prex.Utils.ExtensionMehods

Public Class frmMain
	Public ErrorPermiso As Boolean = False
	Private oAdmlocal As New AdmTablas
	Private oProcesando As frmProcesando
	Private bCancelProcAsinc As Boolean

	Public Sub AnalizarCommand()

		Try

			Dim sParametros() As String
			Dim sItemParam() As String
			Dim nCodigoUsuario As Long
			Dim nCodigoTransaccion As Long
			Dim nCodigoEntidad As Long
			Dim nC As Integer

			'''''' USUARIO ''''''

			sParametros = Command.Split("/")

			For nC = 0 To sParametros.Length - 1

				sItemParam = sParametros(nC).Trim.Split(":")

				If sItemParam.Length = 2 Then

					Select Case sItemParam(0).Trim.ToUpper
						Case "U"
							nCodigoUsuario = Val(sItemParam(1))
						Case "T"
							nCodigoTransaccion = Val(sItemParam(1))
						Case "E"
							nCodigoEntidad = Val(sItemParam(1))
					End Select

				End If
			Next

			If nCodigoUsuario = 0 Then
				MensajeError("El par�metro c�digo usuario es inv�lido.")
				Application.Exit()
			End If

			If nCodigoTransaccion = 0 Then
				MensajeError("El par�metro c�digo de transacci�n es inv�lido.")
				Application.Exit()
			End If

			If nCodigoEntidad = 0 Then
				MensajeError("El par�metro c�digo de entidad es inv�lido.")
				Application.Exit()
			End If

			CODIGO_TRANSACCION = nCodigoTransaccion
			CODIGO_ENTIDAD = nCodigoEntidad

			PresentarDatos(nCodigoTransaccion, nCodigoUsuario, nCodigoEntidad)

		Catch ex As Exception
			TratarError(ex, "AnalizarCommand")
			Application.Exit()
		End Try

	End Sub

	Private Sub PresentarDatos(ByVal nCodigoTransaccion As Long, ByVal nCodigoUsuario As Long, ByVal nCodigoEntidad As Long)
		Try
			Try
				Dim sSQL As String
				Dim ds As DataSet

				''''' USUARIO '''''

				sSQL = "SELECT    US_CODUSU, US_NOMBRE, US_DESCRI, US_ADMIN " &
				"FROM      USUARI " &
				"WHERE     US_CODUSU = " & nCodigoUsuario
				ds = oAdmlocal.AbrirDataset(sSQL)

				With ds.Tables(0)

					If .Rows.Count = 0 Then
						Throw New System.Security.SecurityException("Falla de seguridad - US_CODUSU: " & nCodigoUsuario)
					Else
						UsuarioActual.Codigo = nCodigoUsuario
						UsuarioActual.Nombre = .Rows(0).Item("US_NOMBRE")
						UsuarioActual.Descripcion = .Rows(0).Item("US_DESCRI")
						UsuarioActual.Admin = .Rows(0).Item("US_ADMIN")
						UsuarioActual.SoloLectura = False
						lblUsuario.Text = UsuarioActual.Descripcion
					End If

				End With

				ds = Nothing

				''''' ENTIDAD '''''

				sSQL = "SELECT    TG_CODCON, TG_DESCRI " &
				"FROM      TABGEN " &
				"WHERE     TG_CODTAB = 1 " &
				"AND       TG_CODCON = " & nCodigoEntidad
				ds = oAdmlocal.AbrirDataset(sSQL)

				With ds.Tables(0)

					If .Rows.Count = 0 Then
						Throw New System.Security.SecurityException("Par�metro de entidad no v�lido - TG_CODCON: " & nCodigoEntidad)
					Else
						NOMBRE_ENTIDAD = .Rows(0).Item("TG_DESCRI")
						lblEntidad.Text = NOMBRE_ENTIDAD
					End If

				End With

				ds = Nothing

				''''' TRANSACCION '''''

				sSQL = "SELECT    MU_TRANSA, MU_DESCRI " &
				"FROM      MENUES " &
				"WHERE     MU_CODTRA = " & nCodigoTransaccion
				ds = oAdmlocal.AbrirDataset(sSQL)

				With ds.Tables(0)


					If .Rows.Count = 0 Then
						Throw New System.Security.SecurityException("Error en la l�nea de comandos. Par�metro de transacci�n incorrecto - MU_CODTRA: " & nCodigoTransaccion)
					Else
						lblTransaccion.Text = .Rows(0).Item("MU_DESCRI")
						Me.Text = "Transacci�n:" & CODIGO_TRANSACCION.ToString & " - " & .Rows(0).Item("MU_TRANSA")
					End If

				End With

				ds = Nothing

				lblVersion.Text = "Versi�n: " & Application.ProductVersion

			Catch ex As System.Security.SecurityException
				MensajeError(ex.Message)
				ErrorPermiso = True
			End Try
		Catch ex As Exception
			TratarError(ex, "PresentarDatos")
			ErrorPermiso = True
		End Try
	End Sub

	Public Sub New()

		' Llamada necesaria para el Dise�ador de Windows Forms.
		InitializeComponent()

		' Agregue cualquier inicializaci�n despu�s de la llamada a InitializeComponent().
		oAdmlocal.ConnectionString = CONN_LOCAL
		AnalizarCommand()

	End Sub

	Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
		Me.Close()
	End Sub

	Private Sub CargarProceso(ByVal nCodPro As Long)

		Dim sSQL As String
		Dim ad As OleDb.OleDbDataAdapter
		Dim dt As DataTable
		Dim nC As Integer = 0




		'ENCABEZADO
		''''''''''''''''''''''''''''''''''''
		sSQL = "SELECT    * " &
			 "FROM      PROCAB " &
			 "WHERE     PC_CODTRA = " & nCodPro
		ad = New OleDb.OleDbDataAdapter(sSQL, CONN_LOCAL)
		dt = New DataTable
		ad.Fill(dt)
		If dt.Rows.Count > 0 Then
			nCodPro = dt.Rows(0).Item("PC_CODPRO")
			AbrirProceso(nCodPro)
		End If

		Dim ss = "POST;https://fcbd5352-c20c-48cb-b8e4-21b75897cad0.mock.pstmn.io/CitiDocs;LALA|LALA|LALA|;CitiDocsTest;TABLA;FIN DE ARCHIVO;23"

		Dim base = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(ss))

		dt = Nothing
		ad = Nothing

		''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
		'VARIABLES
		''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
		For Each oVar As clsVariables In oVariablesProc

			nC = nC + 1

			Dim lblInput As New Label

			'Labels
			''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
			If oVar.Help <> 2 And oVar.Help <> 3 Then
				lblInput.Name = "_lbl" & oVar.Nombre
				lblInput.Text = oVar.Titulo & ":"
				lblInput.Location = New System.Drawing.Point(5, panTop.Height + 23 * oVar.Orden - 17)
				lblInput.Size() = New System.Drawing.Size(200, 18)
				panControles.Controls.Add(lblInput)
			End If

			Select Case oVar.Help
				Case 0
					If oVar.Tipo = 2 Then

						Dim oFecha As New DateTimePicker

						With oFecha
							.Name = "_" & oVar.Nombre
							.CustomFormat = "dd/MM/yyyy"
							.Format = DateTimePickerFormat.Custom
							.Visible = True
							.Value = DateAdd(DateInterval.Day, -DateTime.Today.Day, DateTime.Today)
							.Location = New System.Drawing.Point(210, panTop.Height + 23 * oVar.Orden - 21)
							.Size() = New System.Drawing.Size(130, 18)

						End With

						panControles.Controls.Add(oFecha)

					Else

						Dim oTextBox As New TextBox
						oTextBox.Tag = oVar
						oTextBox.Name = "_" & oVar.Nombre
						oTextBox.Text = ""
						oTextBox.Location = New System.Drawing.Point(210, panTop.Height + 23 * oVar.Orden - 21)
						oTextBox.Size() = New System.Drawing.Size(130, 18)
						panControles.Controls.Add(oTextBox)
						AddHandler oTextBox.KeyPress, AddressOf oTextBox_KeyPress
					End If

				Case 1 'SQL
					Dim oCombo As New Windows.Forms.ComboBox

					oCombo.Name = "_" & oVar.Nombre
					oCombo.Location = New System.Drawing.Point(210, panTop.Height + 23 * oVar.Orden - 21)
					oCombo.Size() = New System.Drawing.Size(400, 18)
					oCombo.DropDownStyle = ComboBoxStyle.DropDownList
					panControles.Controls.Add(oCombo)
					CargarCombo(oCombo, oVar.HelpQuery)
					oCombo.Text = "<Seleccione...>"


				Case 2 'ENTIDAD
					Dim oTextBox As New TextBox
					oTextBox.Tag = oVar

					oTextBox.Name = "_" & oVar.Nombre
					oTextBox.Text = CODIGO_ENTIDAD
					oTextBox.Visible = False
					nC = nC - 1
					panControles.Controls.Add(oTextBox)

				Case 3 'CUADRO
					Dim oTextBox As New TextBox
					oTextBox.Tag = oVar

					oTextBox.Name = "_" & oVar.Nombre
					oTextBox.Text = oAdmlocal.DevolverValor("TABGEN", "TG_CODCON", "TG_CODTAB = 2 AND TG_NUME01 = " & CODIGO_TRANSACCION, "0").ToString
					oTextBox.Visible = False
					nC = nC - 1
					panControles.Controls.Add(oTextBox)

				Case 4 'CONDICIONAL
					Dim oCheckBox As New CheckBox

					oCheckBox.Name = "_" & oVar.Nombre
					oCheckBox.Location = New System.Drawing.Point(210, panTop.Height + 23 * oVar.Orden - 19)
					oCheckBox.Size() = New System.Drawing.Size(120, 18)
					oCheckBox.Text = ""
					oCheckBox.Tag = oVar.HelpQuery
					panControles.Controls.Add(oCheckBox)

			End Select

		Next

		panControles.Height = panTop.Height + 23 * nC + 3

		Dim oItem As ListViewItem

		For Each oSub As clsSubProcesosSistema In oSubProcesos

			If oSub.Estado = 0 Then

				oItem = New ListViewItem

				oItem.Text = oSub.Nombre
				oItem.Tag = oSub.Key

				oItem.SubItems.Add(New ListViewItem.ListViewSubItem(oItem, ""))

				lvSel.Items.Add(oItem)

				oItem = Nothing

			End If

		Next

	End Sub

	Private Sub oTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
		If e.KeyChar = "." AndAlso System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator <> "." Then
			e.KeyChar = ","
		End If
	End Sub

	Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		CargarProceso(CODIGO_TRANSACCION)
	End Sub

	Private Function DatosOK() As Boolean

		For Each oVar As clsVariables In oVariablesProc

			If oVar.Help = 1 Then

				If CType(Controles("_" & oVar.Nombre), ComboBox).SelectedItem Is Nothing Then
					MensajeError("Debe especificar " & oVar.Titulo)
					Controles("_" & oVar.Nombre).Focus()
					Exit Function
				End If

			ElseIf oVar.Help = 0 Then

				If oVar.Tipo = 0 Then

					If Not IsNumeric(Controles("_" & oVar.Nombre).Text) Then
						MensajeError("Debe especificar " & oVar.Titulo)
						Controles("_" & oVar.Nombre).Focus()
						Exit Function
					End If

				Else

					If Controles("_" & oVar.Nombre).Text.Trim = "" Then
						MensajeError("Debe especificar " & oVar.Titulo)
						Controles("_" & oVar.Nombre).Focus()
						Exit Function
					End If

				End If

			End If

		Next

		Return True

	End Function

	Private Function Controles(ByVal sNombre As String) As Windows.Forms.Control

		For Each oCtl As Windows.Forms.Control In panControles.Controls

			If oCtl.Name = sNombre Then
				Return oCtl
				Exit Function
			End If

		Next

		Return Nothing

	End Function

	Private Function ProcesosPrevios() As Boolean
		If oProcesosInt Is Nothing OrElse oProcesosInt.Count() = 0 Then Return True
		Dim sParam(1) As String

		For Each oPro As clsProcesosPrevios In oProcesosInt
			sParam(0) = oPro.Nombre
			sParam(1) = oPro.Parametros
			For Each oVar As clsVariables In oVariablesProc
				sParam(1) = Replace(sParam(1), oVar.Nombre, ValorVariable(oVar))
			Next
			ProcesosPrevios = CallByName(Me, sParam(0), vbMethod, sParam(1))
			If Not ProcesosPrevios Then
				Exit For
			End If
		Next

		If oProcesosInt.Count = 0 Then
			Return True
		Else
			Return ProcesosPrevios
		End If

	End Function

	Private Function ValorVariable(ByVal oVar As clsVariables) As Object

		Dim vReemplazo As Object = Nothing
		Dim oItem As Prex.Utils.Entities.clsItem

		Select Case oVar.Tipo
			Case 0
				If oVar.Help = 1 Then
					oItem = CType(Controles("_" & oVar.Nombre), ComboBox).SelectedItem
					vReemplazo = oItem.Valor
				ElseIf oVar.Help = 2 Then
					vReemplazo = Val(Controles("_" & oVar.Nombre).Text)
				ElseIf oVar.Help = 3 Then
					vReemplazo = Val(Controles("_" & oVar.Nombre).Text)
				ElseIf oVar.Help = 4 Then
					vReemplazo = Controles("_" & oVar.Nombre).Tag
				Else
					vReemplazo = Val(Controles("_" & oVar.Nombre).Text)
				End If

			Case 1
				If oVar.Help Then
					oItem = CType(Controles("_" & oVar.Nombre), ComboBox).SelectedItem
					vReemplazo = oItem.Valor
				Else
					vReemplazo = Controles("_" & oVar.Nombre).Text
				End If

			Case 2
				vReemplazo = CType(Controles("_" & oVar.Nombre), DateTimePicker).Value

		End Select

		Return vReemplazo

	End Function

	'Parametros= sParam(0)=Periodo
	Public Function ConsFechaFinMes(ByVal sParametros As String) As Boolean
		Dim sParam() As String
		sParam = Split(sParametros, "|")

		Dim fechaFinDeMes As DateTime
		If Month(sParam(0)) = 12 Then
			fechaFinDeMes = DateTime.Parse((Year(sParam(0)) + 1).ToString() & "-" & Format(1, "00") & "-01").AddDays(-1)
		Else
			fechaFinDeMes = DateTime.Parse(Year(sParam(0)).ToString() & "-" & Format(IIf(Month(sParam(0)) = 12, 1, Month(sParam(0)) + 1), "00") & "-01").AddDays(-1)
		End If

		Dim fecha As DateTime
		If DateTime.TryParse(sParametros, fecha) Then
			If fecha.Equals(fechaFinDeMes) Then
				Return True
			Else
				MensajeError("La fecha establecida no es fin de mes")
			End If
		Else
			MensajeError("La fecha establecida no es fin de mes")
		End If

		'Dim i As Integer
		'Dim sTemp As String
		'Dim sParam() As String

		'sParam = Split(sParametros, "|")

		'For i = 31 To 28 Step -1

		'   sTemp = Format(i, "00") & "-" & Format(Month(sParam(0)), "00") & "-" & Year(sParam(0))

		'   If IsDate(sTemp) Then

		'      If CDate(sParam(0)) <> CDate(sTemp) Then
		'         MensajeError("La fecha establecida no es fin de mes")
		'      Else
		'         ConsFechaFinMes = True
		'      End If

		'      Exit For

		'   End If

		'Next

	End Function

	Private Sub cmdProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProcesar.Click

		If cmdProcesar.Text = "&Procesar" Then
			If DatosOK() Then
				cmdProcesar.Text = "&Cancelar"
				bCancelProcAsinc = False
				Ejecutar()
				cmdProcesar.Text = "&Procesar"
			End If
		Else
			bCancelProcAsinc = True
		End If

	End Sub

	Private Function ObtenerFechaVigencia() As Date
		Dim d = Date.MinValue
		Dim paso = False
		For Each control As Control In panControles.Controls
			Select Case control.GetType.ToString.Substring(control.GetType.ToString.LastIndexOf(".") + 1)
				Case "DateTimePicker"
					d = IIf(paso, DateTime.MinValue, DateTime.Parse(FechaSQL(DirectCast(control, DateTimePicker).Value).Replace("'", String.Empty)))
					paso = True
				Case "DateEdit"
					d = IIf(paso, Date.MinValue, Date.Parse(FechaSQL(DirectCast(control, DevExpress.XtraEditors.DateEdit).DateTime).Replace("'", String.Empty)))
					paso = True
				Case Else
					Continue For
			End Select
		Next
		Return d
	End Function

	Private Sub GuardarControlSubProceso(ByVal subProceso As clsSubProcesosSistema, ByVal estado As Integer, ByVal observacion As String)
		If oAdmlocal.ExisteTabla("CTLPRO") Then

			Dim sSQL1 = "INSERT INTO CTLPRO " &
					   "SELECT " & CODIGO_ENTIDAD & " AS CP_CODENT, " &
					   FechaSQL(ObtenerFechaVigencia()) & " AS CP_FECVIG, " &
					   subProceso.CodPro.ToString & " AS CP_PROCES, " &
					   "'" & subProceso.Nombre.ToUpper & "' AS CP_SUBPRO, " &
					   FechaSQL(Date.Now) & " AS CP_DIAPRO, " &
					   FechaYHoraSQL(DateTime.Now) & " AS CP_HORAPRO, " &
					   estado.ToString & " AS CP_ESTADO, " &
					   "'" & observacion.ToUpper & "' AS CP_OBSERV "

			oAdmlocal.EjecutarComandoSQL(sSQL1)

		End If

	End Sub

	Private Sub Ejecutar()

		Dim oItem As ListViewItem
		Dim oSubItem As ListViewItem.ListViewSubItem
		Dim ejecutoProceso As EstadoProceso

		For Each oItem In lvSel.Items
			oSubItem = oItem.SubItems(1)
			oSubItem.Text = ""
		Next

		oSubItem = Nothing
		oItem = Nothing

		If ProcesoEnEjecucion() Then
			Exit Sub
		End If

		If Not ProcesosPrevios() Then
			Exit Sub
		End If

		Dim uncheckAll = True

		For Each oItem In lvSel.Items
			oSubItem = oItem.SubItems(1)
			If oItem.Checked Then
				uncheckAll = False
				oSubItem.Text = "Procesando..."
				Application.DoEvents()
				Dim proceso As clsSubProcesosSistema = CType(oSubProcesos(oItem.Tag), clsSubProcesosSistema)
				GuardarLOG(AccionesLOG.EjecucionSubProceso, "Sub Proceso: " + proceso.CodPro.ToString + " - " + proceso.Nombre, CODIGO_TRANSACCION, UsuarioActual.Codigo)
				GuardarControlSubProceso(proceso, 1, "INICIADO")


				Dim sSQL = ReemplazarVariables(proceso.Query.ToString.Replace(Chr(0), ""), panControles.Controls, oProcesos.CodPro)
				sSQL = ProcesosEmbebidos(ReemplazarVariables(oProcesos.Query.Replace(Chr(0), ""), panControles.Controls, oProcesos.CodPro) & sSQL)

				If TypeOf (sSQL) Is ClsSubProcesosSistemaWebService Then
					Dim procesoWeb = CType(sSQL, ClsSubProcesosSistemaWebService)
					ejecutoProceso = EjecutarProcesoWeService(procesoWeb, Sub(estado As String) oSubItem.Text = estado)
				Else
					'AGREGADO PARA QUE GENERE UN DETALLE DE LOS PROCESOS EJECUTADOS
					ejecutoProceso = EjecutarProcesoSQL(sSQL, proceso, Sub(estado As String) oSubItem.Text = estado)
				End If

				If ejecutoProceso = EstadoProceso.Cancelado Then
					Exit For
				End If

			Else
				oSubItem.Text = "Omitido"
			End If

			Application.DoEvents()
		Next

		ProcesoEnEjecucion(True)
		If uncheckAll Then
			MensajeInformacion("ATENCION! Proceso Finalizado sin tareas selecciondas.")
		Else
			If ejecutoProceso = EstadoProceso.FinalizadoOK Then
				MensajeInformacion("Proceso Finalizado")
			ElseIf ejecutoProceso = EstadoProceso.EnError Then
				MensajeError("Se produjo un error durante el proceso y el mismo fu� abortado.")
			End If
		End If

	End Sub

	Private Function EjecutarProcesoWeService(proceso As ClsSubProcesosSistemaWebService, actualizarDetalle As Action(Of String)) As EstadoProceso
		Try
			If proceso.NombreSalida.IsNullOrEmpty Then
				Throw New Exception("Proceso sin datos de salida [NombreSalida]")
			End If

			If CancelarProceso() Then
				actualizarDetalle("Cancelado")
				Return EstadoProceso.Cancelado
			End If

			Dim response As Prex.Utils.Misc.Http.ResponseResult
			If Not Prex.Utils.Configuration.PrexConfig.CertificateCitiDocsPath.IsNullOrEmpty Then
				response = Prex.Utils.Misc.Http.PeticionesHttp.GestionarPeticion(proceso.FullUri.ToString(),
																			proceso.BodyRequest,
																			proceso.HttpMethod,
																			proceso.ContentType,
																			Nothing,
																			Prex.Utils.Configuration.PrexConfig.CertificateCitiDocsPath,
																			Prex.Utils.Configuration.PrexConfig.CertificateCitiDocsPass,
																			Nothing,
																			proceso.ServiceProtocol)
			Else
				response = Prex.Utils.Misc.Http.PeticionesHttp.GestionarPeticion(proceso.FullUri.ToString(),
																			proceso.BodyRequest,
																			proceso.HttpMethod,
																			proceso.ContentType,
																			Nothing,
																			Nothing,
																			proceso.ServiceProtocol)
			End If

			actualizarDetalle("Guardando detalle")

			Select Case response.StatusCode
				Case HttpStatusCode.OK
					If Not response.Content.IsNullOrEmpty() Then
						'Si la respuesta es vacia, no genera nada y devuelve OK
						Dim respuestaVacia As String = response.Content.ToLower().Replace("|", String.Empty).Replace(proceso.LiteralFinArchivo.ToLower(), String.Empty).Replace(" ", String.Empty)

						If respuestaVacia.Count() = 0 Then

							actualizarDetalle("Finalizado")
							Return EstadoProceso.FinalizadoOK
						End If

						'GrabarEnSalida
						'La tabla va existir
						'Deberia leer los campos de la tabla y excluirlos del contenido del response, solo grabamos datos
						Dim registros As String() = response.Content.Trim.Split("|")

						If registros Is Nothing Then
							Throw New Exception($"Respuesta con registros vac�os")
						End If

						Dim listResults As IEnumerable(Of String) = response.Content.Trim.ToLower() _
							.Split("|") _
							.Where(Function(s) s.Trim <> proceso.LiteralFinArchivo.ToLower()) _
							.Select(Function(s) s.Replace(" ", String.Empty))

						If listResults.IsNullOrEmpty() OrElse
							listResults.All(Function(s) s.IsNullOrEmpty()) Then

							actualizarDetalle("Finalizado")
							Return EstadoProceso.FinalizadoOK
						End If

						If registros.Count <= (proceso.CantidadCampos * 2) Then
							Throw New Exception($"Respuesta sin cantidad m�nima de campos (Config CntCampos: {proceso.CantidadCampos})")
						End If

						If Not registros.Any(Function(r) r.EsIgual(proceso.LiteralFinArchivo)) Then
							Throw New Exception($"Respuesta sin cadena de fin de archivo (Config LineaFina: {proceso.LiteralFinArchivo})")
						End If

						Select Case proceso.TipoSalida
							Case TipoSalidaProcesoWeb.TABLA
								GrabarRespuestaServiceSQL(proceso, registros)
							Case TipoSalidaProcesoWeb.TXT
								File.WriteAllLines(proceso.NombreSalida, registros.Skip(proceso.CantidadCampos))
						End Select
					Else
						Throw New Exception($"Respuesta webservice vac�a")
					End If

				Case Else
					Throw New Exception($"Respuesta en error - HTTPSTATUSCODE: {response.StatusCode}")
			End Select



			actualizarDetalle("Finalizado")
			Return EstadoProceso.FinalizadoOK
		Catch ex As Exception
			actualizarDetalle($"Error - Detalle: {ex.Message}")
			GuardarLOG(AccionesLOG.ErrorSubProceso, "Sub Proceso: " + proceso.CodPro.ToString + " - " + proceso.Nombre, CODIGO_TRANSACCION, UsuarioActual.Codigo)
			Return EstadoProceso.EnError
		End Try
	End Function


	Private Sub GrabarRespuestaServiceSQL(proceso As ClsSubProcesosSistemaWebService, registros As String())
		If proceso.NombreSalida.IsNullOrEmpty Then Throw New ArgumentNullException("Nombre tabla")

		'oAdmlocal.EjecutarComandoAsincrono($"truncate table {proceso.NombreSalida}")

		Dim cmdInsert As New SqlCommand($"Insert into {proceso.NombreSalida} values (")
		Dim campos = 1
		Dim separador As String = String.Empty
		For campos = 1 To proceso.CantidadCampos
			Dim parametroNombre = $"Param_{campos}"
			cmdInsert.Parameters.Add(parametroNombre, SqlDbType.VarChar)
			If cmdInsert.Parameters.Count > 1 Then
				separador = ", "
			End If
			cmdInsert.CommandText = $"{cmdInsert.CommandText}{separador}@{parametroNombre}"
		Next
		cmdInsert.CommandText = $"{cmdInsert.CommandText})"
		If cmdInsert.Parameters.Count = 0 Then Throw New Exception("Comando DB sin par�metros")


		Dim i = 0
		Dim registroActual = 1

		For i = 0 To registros.Length - 1
			'contar cantidad de items, segun campos de la tabla, los primeros son la cebecera, luego datos.
			If i <= proceso.CantidadCampos - 1 Then Continue For

			Dim valorCampo As String = registros(i).Trim

			'el final del archivo tiene un literal que dice "fin de archivo"
			If proceso.LiteralFinArchivo.EsIgual(valorCampo) Then Exit For

			cmdInsert.Parameters($"Param_{registroActual}").Value = valorCampo

			'controlo si estoy en el mismo registro
			If registroActual = proceso.CantidadCampos Then
				registroActual = 1
				If Not oAdmlocal.EjecutarComandoSQL(cmdInsert) Then
					Throw New Exception("Ocurrio un error al grabar detalle webservice")
				End If
			Else
				registroActual += 1
			End If

		Next

	End Sub

	Private Function EjecutarProcesoSQL(ByVal sSql As String, proceso As clsSubProcesosSistema, actualizarDetalle As Action(Of String)) As EstadoProceso
		If ProcesoAsincrono(sSql) Then
			If CancelarProceso() Then
				actualizarDetalle("Cancelado")
				Return EstadoProceso.Cancelado
			End If

			actualizarDetalle("Finalizado")
			GuardarLOG(AccionesLOG.FinSubProceso, "Sub Proceso: " + proceso.CodPro.ToString + " - " + proceso.Nombre, CODIGO_TRANSACCION, UsuarioActual.Codigo)

			'AGREGADO PARA QUE GENERE UN DETALLE DE LOS PROCESOS EJECUTADOS
			GuardarControlSubProceso(proceso, 2, "FINALIZADO")
			Return EstadoProceso.FinalizadoOK
		Else
			actualizarDetalle("Error")

			GuardarLOG(AccionesLOG.ErrorSubProceso, "Sub Proceso: " + proceso.CodPro.ToString + " - " + proceso.Nombre, CODIGO_TRANSACCION, UsuarioActual.Codigo)

			'AGREGADO PARA QUE GENERE UN DETALLE DE LOS PROCESOS EJECUTADOS
			GuardarControlSubProceso(proceso, 3, "ERROR")

			Return EstadoProceso.EnError
		End If
	End Function

	Private Function CancelarProceso() As Boolean
		If bCancelProcAsinc Then
			If Pregunta("�Desea continuar con el resto de los procesos?") = Windows.Forms.DialogResult.No Then
				Return True
			End If
		End If
		Return False
	End Function

	Private Function ProcesoEnEjecucion(Optional ByVal bFinProceso As Boolean = False) As Boolean

		Dim ds As DataSet
		Dim row As DataRow
		Dim cb As OleDb.OleDbCommandBuilder
		Dim da As OleDb.OleDbDataAdapter
		Dim sSQL As String
		Dim bTemp As Boolean

		Try

			sSQL = "SELECT       * " &
				"FROM         PROEXE " &
				"WHERE        PE_CODPRO=" & oProcesos.CodPro
			ds = oAdmlocal.AbrirDataset(sSQL, da)
			cb = New OleDb.OleDbCommandBuilder(da)

			With ds.Tables(0)

				If .Rows.Count = 0 Then
					oAdmlocal.EjecutarComandoSQL("Insert Into PROEXE (PE_ESTADO, PE_DESCRI, PE_FECPRO, PE_CODUSU, PE_CODPRO) " &
												 $"Values (0, ' ', GetDate(), {UsuarioActual.Codigo}, {oProcesos.CodPro})")
				Else

					bTemp = (.Rows(0).Item("PE_ESTADO") <> 0)
					If bFinProceso Then
						oAdmlocal.EjecutarComandoSQL("Update PROEXE set " &
														 " PE_ESTADO = 0, PE_DESCRI = ' ',  " &
														 " PE_FECPRO = GetDate(), " &
														 $" PE_CODUSU = {UsuarioActual.Codigo}" &
														 $"WHERE        PE_CODPRO={ oProcesos.CodPro}")
						bTemp = False
					End If


					If bTemp Then
						If Pregunta("El proceso se encuentra en ejecuci�n por " & oAdmlocal.DevolverValor("USUARI", "US_DESCRI", "US_CODUSU=" & .Rows(0).Item("PE_CODUSU")) & " desde " & .Rows(0).Item("PE_FECPRO") & "." & vbCrLf & "Forzar el inicio puede generar inconsistencia en los datos." & vbCrLf & "�Desea Forzar el inicio de proceso?") = vbYes Then
							bTemp = False

							oAdmlocal.EjecutarComandoSQL("Update PROEXE set " &
														 " PE_ESTADO = 0, PE_DESCRI = ' ',  " &
														 " PE_FECPRO = GetDate(), " &
														 $" PE_CODUSU = {UsuarioActual.Codigo}" &
														 $"WHERE        PE_CODPRO={ oProcesos.CodPro}")

							.Rows(0).Item("PE_ESTADO") = 0
							.Rows(0).Item("PE_DESCRI") = " "
							.Rows(0).Item("PE_FECPRO") = DateTime.Now
							.Rows(0).Item("PE_CODUSU") = UsuarioActual.Codigo
							da.Update(ds)
							ds.AcceptChanges()



						End If
					End If

				End If
			End With

			Return bTemp

		Catch ex As Exception
			ex = Nothing
		End Try

	End Function

	'Public Function ReemplazarVariables(ByVal sSQL As String) As String

	'     Dim oCtl As Windows.Forms.Control
	'   Dim sValor As String
	'   Dim oItem As Prex.Utils.Entities.clsItem

	'   For Each oCtl In panControles.Controls

	'      Select Case oCtl.GetType.ToString.Substring(oCtl.GetType.ToString.LastIndexOf(".") + 1)
	'         Case "ComboBox"
	'                 oItem = CType(oCtl, ComboBox).SelectedItem
	'                 sValor = "'" + oItem.Valor.ToString + "'"
	'             Case "ComboBoxEdit"
	'                 oItem = CType(oCtl, DevExpress.XtraEditors.ComboBoxEdit).SelectedItem
	'                 sValor = "'" + oItem.Valor.ToString + "'"
	'             Case "CheckBox"
	'                 sValor = IIf(CType(oCtl, CheckBox).Checked, oCtl.Tag, "")
	'             Case "CheckEdit"
	'                 sValor = IIf(CType(oCtl, DevExpress.XtraEditors.CheckEdit).Checked, oCtl.Tag, "")
	'             Case "DateTimePicker"
	'                 sValor = FechaSQL(DirectCast(oCtl, DateTimePicker).Value)
	'             Case "DateEdit"
	'                 sValor = FechaSQL(DirectCast(oCtl, DevExpress.XtraEditors.DateEdit).DateTime)
	'             Case Else
	'            sValor = oCtl.Text
	'      End Select

	'      If oCtl.Name.Substring(0, 1) = "_" Then
	'         sSQL = sSQL.Replace(oCtl.Name.Substring(1), sValor)
	'      End If

	'   Next

	'   sSQL = Replace(sSQL, "@CODPRO", oProcesos.CodPro.ToString, , , vbTextCompare)
	'   sSQL = Replace(sSQL, "@CODUSU", UsuarioActual.Codigo, , , vbTextCompare)
	'   sSQL = Replace(sSQL, "@CODIGO_ENTIDAD", CODIGO_ENTIDAD.ToString, , , vbTextCompare)
	'   sSQL = Replace(sSQL, "@CODIGO_TRANSACCION", CODIGO_TRANSACCION.ToString, , , vbTextCompare)

	'   Return sSQL

	'End Function

	Private Function ProcesoAsincrono(ByVal sSQL As String) As Boolean

		Dim oConnection As ADODB.Connection
		Dim oCommand As ADODB.Command
		Dim oError As ADODB.Error
		Dim nErrCount As Integer = 0
		Dim sError As String = ""
		Dim sLog As String = "2"

		bCancelProcAsinc = False

		oConnection = New ADODB.Connection
		oConnection.ConnectionString = CONN_LOCAL
		oConnection.Open()

		oCommand = New ADODB.Command
		oCommand.CommandType = ADODB.CommandTypeEnum.adCmdText
		oCommand.CommandText = sSQL
		oCommand.ActiveConnection = oConnection
		oCommand.CommandTimeout = 0

		On Error Resume Next

		Dim inicio = DateTime.UtcNow

		oCommand.Execute(, , ADODB.ExecuteOptionEnum.adAsyncExecute Or ADODB.ExecuteOptionEnum.adExecuteNoRecords)

		Do While oCommand.State = ADODB.ObjectStateEnum.adStateExecuting
			If bCancelProcAsinc Then
				oCommand.Cancel()
			End If
			Application.DoEvents()
		Loop

		VerStatus(DateDiff(DateInterval.Second, inicio, DateTime.UtcNow))

		If oConnection.Errors.Count > 0 Then
			For Each oError In oConnection.Errors
				If oError.Number Then
					sError = sError & oError.Number & " - " & oError.Description & vbCrLf & vbCrLf
					nErrCount = nErrCount + 1
				End If
			Next
			oConnection.Errors.Clear()
		End If

		If nErrCount > 0 Then
			If Pregunta("Se produjeron " & nErrCount & " errores.�Desea visualizarlos?") = vbYes Then
				File.WriteAllText("Y:\PREX_RI\LOG_SQL.TXT", sSQL)
				frmErrores.PasarDatos(sError)
				frmErrores.ShowDialog()
			End If
		Else
			If Not bCancelProcAsinc Then
				'oConnection.CommitTrans
			End If
			Return True
		End If

		oCommand = Nothing
		oConnection.Close()
		oConnection = Nothing

	End Function

	Private Sub VerStatus(ByVal tiempoProceso As Integer)

		Dim ds As DataSet
		Dim sSQL As String
		Dim sDescri As String = ""
		Dim bFlag As Boolean

		Try

			sSQL = "SELECT    * " &
				"FROM      PROEXE (NOLOCK)" &
				"WHERE     PE_CODPRO=" & oProcesos.CodPro.ToString
			ds = oAdmlocal.AbrirDataset(sSQL)

			With ds.Tables(0)
				For Each row As DataRow In .Rows
					If row("PE_ESTADO") >= 0 And row("PE_ESTADO") <= 100 Then
						PB.Value = row("PE_ESTADO")
					End If

					sDescri = row("PE_DESCRI")

					If row("PE_ESTADO") = -1 Then
						MensajeInformacion(sDescri)
						bFlag = True
					End If

					If Not bFlag Then
						'lvPro.SelectedItem.SubItems(1) = sDescri
						'lvSel.SelectedItems(0).SubItems(1).Text = sDescri
						'sbMain.SimpleText = sDescri
					End If

					lblUsuario.Text = "Tiempo transcurrido: " & Format(TimeSerial(0, 0, tiempoProceso), "HH:mm:ss") & " - " & sDescri

					Application.DoEvents()
				Next
			End With

		Catch ex As Exception
			ex = Nothing
		End Try

		ds = Nothing

	End Sub

	Private Function ProcesosEmbebidos(ByVal sSQLPro As String) As Object
		Try

			Dim sSQL = "SELECT    * " &
				"FROM      PROEMB (NOLOCK) "
			Dim ds = oAdmlocal.AbrirDataset(sSQL)

			With ds.Tables(0)
				For Each row As DataRow In .Rows

					If (Not row("PE_QUERY") Is DBNull.Value) And (Not row("PE_NOMBRE") Is DBNull.Value) Then
						If row("PE_NOMBRE").ToString().ToLower() = "webservice" Then
							Dim procesoWeb = ReemplazarWebService(sSQLPro, row("PE_NOMBRE"), row("PE_VARIAB"), row("PE_QUERY"))
							If Not procesoWeb Is Nothing Then Return procesoWeb
						Else
							sSQLPro = ReemplazarProc(sSQLPro, row("PE_NOMBRE"), row("PE_VARIAB"), row("PE_QUERY"))
						End If
					End If

				Next
			End With
			Return sSQLPro
		Catch ex As Exception
			TratarError(ex, "ProcesosEmbebidos")
		End Try
	End Function

	Private Function ReemplazarProc(ByVal sSQL As String, ByVal sNombre As String,
								   ByVal sVariab As String, ByVal sQuery As String)

		Dim sTemp As String
		Dim sVariables As String
		Dim nPos As Integer
		Dim nPos2 As Integer
		Dim sVars() As String
		Dim sVarsOrig() As String
		Dim nC As Integer
		Dim sGuardo As String

		sQuery = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(sQuery))
		sQuery = Replace(sQuery, Chr(0), "")
		sQuery = Replace(sQuery, "@CODPRO", oProcesos.CodPro, , , vbTextCompare)
		sQuery = Replace(sQuery, "@CODUSU", UsuarioActual.Codigo, , , vbTextCompare)
		sQuery = Replace(sQuery, "@CODIGO_ENTIDAD", CODIGO_ENTIDAD, , , vbTextCompare)
		sQuery = Replace(sQuery, "@CODIGO_TRANSACCION", CODIGO_TRANSACCION, , , vbTextCompare)

		sGuardo = sQuery

InicioBucle:

		sQuery = sGuardo

		nPos = InStr(1, sSQL, "SYS." & UCase(sNombre), vbTextCompare)
		If nPos Then

			nPos2 = InStr(nPos, sSQL, ")")
			sTemp = Mid(sSQL, nPos, nPos2 - nPos + 1)
			sVariables = Replace(sTemp, "SYS." & UCase(sNombre), "", , , vbTextCompare)
			sVariables = Replace(sVariables, "(", "")
			sVariables = Replace(sVariables, ")", "")

			sVars = Split(Trim(sVariables), ",")
			'TODO:Aca levantar las variables nuevas para el webservice.

			If UBound(sVars) < 1 Then
				sQuery = Replace(sQuery, sVariab, Trim(sVariables))
			Else
				sVarsOrig = Split(sVariab, ",")

				For nC = LBound(sVarsOrig) To UBound(sVarsOrig)
					sQuery = Replace(sQuery, Trim(sVarsOrig(nC)), sVars(nC), , , vbTextCompare)
				Next nC
			End If

			sSQL = Replace(sSQL, sTemp, sQuery, , , vbTextCompare)
			GoTo InicioBucle
		End If

		Return sSQL

	End Function


	Private Function ReemplazarWebService(ByVal sSQL As String, ByVal sNombre As String,
								   ByVal sVariab As String, ByVal sQuery As String) As ClsSubProcesosSistemaWebService

		sQuery = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(sQuery))
		sQuery = Replace(sQuery, Chr(0), "")

		dim nPos = InStr(1, sSQL, "SYS." & UCase(sNombre), vbTextCompare)
		If nPos Then

			Dim nPos2 = InStr(nPos, sSQL, ")")
			Dim sTemp = Mid(sSQL, nPos, nPos2 - nPos + 1)
			Dim sVariables = Replace(sTemp, "SYS." & UCase(sNombre), "", , , vbTextCompare)
			sVariables = Replace(sVariables, "(", "")
			sVariables = Replace(sVariables, ")", "")

			Dim sVars As String() = Split(Trim(sVariables), ",")
			Return New ClsSubProcesosSistemaWebService(sVars)
		End If

		Return Nothing

	End Function

	Private Sub cmdTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTodo.Click

		For Each item As ListViewItem In lvSel.Items
			item.Checked = True
		Next

	End Sub

	Private Sub cmdInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInv.Click

		For Each item As ListViewItem In lvSel.Items
			item.Checked = Not item.Checked
		Next

	End Sub

End Class
