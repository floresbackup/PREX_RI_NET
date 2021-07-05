Imports Microsoft.Data.ConnectionUI
Imports ExtensionsAdm
Imports Prex.Utils
Imports System.Data.SqlClient

Public Class frmABMRegistro

	Private Const TOP_CONTROLES As Long = 10
	Private MODO_APE As String
	Private sSQL_Update As String
	Private sSQL_Actualizar As String
	Private oAdmTablas As New AdmTablas
	Private listColumnasExistentes As List(Of clsColumnas)
	Private dicControlesValorAnterior As Dictionary(Of String, Control)
	Private QueryConsulta As String

	Public Sub PasarDatos(ByVal nCodCon As Long,
						 ByVal sQuery As String,
						 ByVal sCaption As String,
						 ByVal sModo As String,
						 ByVal sQueryConsulta As String,
						 ByVal sQueryActualizar As String)

		Dim oCol As clsColumnas
		Dim oField As DataColumn
		Dim nTabOrden As Integer
		Dim ds As DataSet
		Dim nCont As Long
		Dim bExiste As Boolean
		Dim bPrimero As Boolean

		QueryConsulta = sQueryConsulta
		INPUT_GENERAL = ""
		dicControlesValorAnterior = New Dictionary(Of String, Control)()
		Me.Text = sCaption

		sSQL_Update = sQuery
		sSQL_Actualizar = sQueryActualizar

		MODO_APE = sModo

		If MODO_APE = "B" Then
			cmdGuardar.Text = "Baja"
		End If

		'PONGO LOS VALORES EN LA GRILLA

		If MODO_APE = "A" Then
			ds = oAdmTablas.AbrirDataset(sSQL_Update.Substring(0, sSQL_Update.LastIndexOf("FROM") - 1))
		Else
			ds = oAdmTablas.AbrirDataset(sSQL_Update)
		End If
		If (ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0) AndAlso MODO_APE = "M" Then
			INPUT_GENERAL = "CERRAR_FORMULARIO_YAA"
			cmdGuardar.Enabled = False
			Return
		End If
		If MODO_APE = "B" AndAlso (ds.Tables(0).Rows.Count = 0) Then
			MensajeError("El registro actual no se puede eliminar")
			cmdGuardar.Enabled = False
			INPUT_GENERAL = "CERRAR_FORMULARIO_YAA"
			Return
		End If

		bExiste = False
		Dim withLabel = 165
		listColumnasExistentes = New List(Of clsColumnas)
		For Each oCol In oColumnas
			For Each oField In ds.Tables(0).Columns

				If oCol.Campo.ToUpper = oField.ColumnName.ToUpper Then
					listColumnasExistentes.Add(oCol)
					If oCol.Titulo IsNot Nothing AndAlso oCol.Titulo.Trim.Length > 0 Then

						Dim t As String = IIf(oCol.Titulo.Substring(oCol.Titulo.Length - 1, 1) <> ":", oCol.Titulo & ":", oCol.Titulo)
						If t.Length > 30 Then
							withLabel = 165 + ((t.Length - 30) * 5)
						End If
					End If

					Exit For
				End If
			Next
		Next

		For Each oCol In listColumnasExistentes

			Dim lblInput As New Label()

			'Obtengo el valor del campo
			oCol.Valor = ds.Tables(0).Rows(0)(oCol.Campo)
			oCol.ValorAnterior = oCol.Valor

			If oCol.VisibleABM Or oCol.Clave Then

				If oCol.VisibleABM Then
					nCont = nCont + 1
				End If

				'LABEL DE CAMPO
				With lblInput
					.Name = "_lblInput" & oCol.Orden
					.AutoSize = True
					.Visible = oCol.VisibleABM
					.Top = TOP_CONTROLES + 5 + (25 * (nCont - 1))
					.Left = 5
					.Text = IIf(oCol.Titulo.Substring(oCol.Titulo.Length - 1, 1) <> ":", oCol.Titulo & ":", oCol.Titulo)
					If MODO_APE = "B" Then
						.Enabled = False
					Else
						.Enabled = oCol.Habilitada
					End If
					Cont.Controls.Add(lblInput)
				End With

				'SI NO LLEVA UN COMBO DE HELP PONGO UN TEXBOX O DATEPICKER
				'TODO: Usar MaxLargo y probar que funcione el Largo como limitador de carga de datos. Revisar si funciona el multilinea
				If oCol.Help = 0 Then
					If TipoDatosADO(oCol.Tipo) <> "Fecha/Hora" Then
						Dim cntLineas = 1
						Dim txtInput As DevExpress.XtraEditors.BaseEdit

						If oCol.MaxLargo > 50 AndAlso oCol.Formula = "" Then
							cntLineas = Math.Min(Math.Ceiling((oCol.MaxLargo / 50)), 5)
							txtInput = New DevExpress.XtraEditors.MemoEdit
							CType(txtInput, DevExpress.XtraEditors.MemoEdit).Properties.MaxLength = oCol.Largo
							CType(txtInput, DevExpress.XtraEditors.MemoEdit).Properties.LinesCount = cntLineas
						Else
							txtInput = New DevExpress.XtraEditors.TextEdit
							CType(txtInput, DevExpress.XtraEditors.TextEdit).Properties.MaxLength = oCol.Largo
						End If

						With txtInput
							.Name = "_txtInput" & oCol.Orden
							.Visible = oCol.VisibleABM
							.Height = .Height * cntLineas
							.TabIndex = nTabOrden
							.TabStop = oCol.Habilitada
							.Top = TOP_CONTROLES + (25 * (nCont - 1))
							.Left = withLabel
							.Width = Cont.Width - .Left - 10 - Cont.Left
							.Tag = oCol.Key

							If MODO_APE = "B" Then
								.ReadOnly = True
							Else
								.ReadOnly = Not oCol.Habilitada
								If Not .ReadOnly And (Not bPrimero) Then
									.TabIndex = 0
									bPrimero = True
								End If
							End If
							If .ReadOnly Then
								.ForeColor = Color.Gray
							End If
						End With

						AddHandler txtInput.EditValueChanged, AddressOf txtInput_EditValueChanged
						If Not txtInput.ReadOnly Then
							AddHandler txtInput.TextChanged, AddressOf fecInput_Leave
						End If


						dicControlesValorAnterior.Add(oCol.Key, txtInput)
						Cont.Controls.Add(txtInput)

					Else

						Dim fecInput As New DevExpress.XtraEditors.DateEdit

						With fecInput
							.Name = "_fecInput" & oCol.Orden
							.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
							.Visible = oCol.VisibleABM
							.TabIndex = nTabOrden
							.TabStop = oCol.Habilitada
							.Top = TOP_CONTROLES + (25 * (nCont - 1))
							.Left = withLabel
							.Width = Cont.Width - .Left - 10 - Cont.Left
							.DateTime = Date.Today
							.Tag = oCol.Key

							If MODO_APE = "B" Then
								.ReadOnly = True
							Else
								.ReadOnly = Not oCol.Habilitada
								If Not .ReadOnly And (Not bPrimero) Then
									.TabIndex = 0
									bPrimero = True
								End If
							End If
							If .ReadOnly Then
								.ForeColor = Color.Gray
							End If
						End With

						AddHandler fecInput.EditValueChanged, AddressOf fecInput_EditValueChanged
						If Not fecInput.ReadOnly Then
							AddHandler fecInput.DateTimeChanged, AddressOf fecInput_Leave
						End If
						dicControlesValorAnterior.Add(oCol.Key, fecInput)

						Cont.Controls.Add(fecInput)

					End If
				Else

					Dim cboInput As New DevExpress.XtraEditors.ComboBoxEdit

					With cboInput
						.Name = "_cboInput" & oCol.Orden
						.Visible = oCol.VisibleABM
						.TabIndex = nTabOrden
						.TabStop = oCol.Habilitada
						.Top = TOP_CONTROLES + (25 * (nCont - 1))
						.Left = withLabel
						.Width = Cont.Width - .Left - 10 - Cont.Left
						.Text = "<Seleccione...>"
						.Tag = oCol.Key

						If MODO_APE = "B" Then
							.ReadOnly = True
						Else
							.ReadOnly = Not oCol.Habilitada
							If Not .ReadOnly And (Not bPrimero) Then
								.TabIndex = 0
								bPrimero = True
							End If
						End If
						If .ReadOnly Then
							.ForeColor = Color.Gray
						End If
					End With

					AddHandler cboInput.SelectedIndexChanged, AddressOf cboInput_SelectedIndexChanged
					If Not cboInput.ReadOnly Then
						AddHandler cboInput.SelectedIndexChanged, AddressOf fecInput_Leave
					End If

					dicControlesValorAnterior.Add(oCol.Key, cboInput)

					Cont.Controls.Add(cboInput)

					CargarComboDevExpress(cboInput, frmMain.ReemplazarVariablesExt(oCol.HelpQuery))

				End If

				If oCol.Valor.ToString.Trim <> "" Then
					If oCol.Help = 0 Then
						If TipoDatosADO(oCol.Tipo) = "Fecha/Hora" Then
							CType(Cont.Controls("_fecInput" & oCol.Orden.ToString), DevExpress.XtraEditors.DateEdit).DateTime = oCol.Valor
						Else
							CType(Cont.Controls("_txtInput" & oCol.Orden), DevExpress.XtraEditors.BaseEdit).Text = oCol.Valor.ToString
						End If
					Else
						SelComboDevExpress(CType(Cont.Controls("_cboInput" & oCol.Orden.ToString), DevExpress.XtraEditors.ComboBoxEdit), "K" & oCol.Valor.ToString)
					End If
				End If
				If MODO_APE = "A" AndAlso oCol.Formula <> "" Then
					Formula(oCol.Formula, oCol.Key)
				End If
			End If

			If oCol.VisibleABM Then
				nTabOrden = nTabOrden + 1
				If nCont < 12 Then

					Cont.Height = Cont.Height + 25
					Me.Height = Me.Height + 25
					cmdGuardar.Top = cmdGuardar.Top + 25
					cmdCancelar.Top = cmdGuardar.Top
				End If
			End If
		Next
	End Sub

	Public Sub New()

		' Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		oAdmTablas.ConnectionString = CONN_LOCAL

	End Sub

	Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
		Me.Close()
	End Sub

	Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click

		If DatosOK() Then
			Guardar()
		End If

	End Sub

	Private Function DatosOK() As Boolean

		Return True

	End Function

	Private Sub Guardar()

		Dim sSQL As String
		Dim oCol As clsColumnas
		'Dim oRow As DataRow
		Dim da As OleDb.OleDbDataAdapter
		'Dim cb As OleDb.OleDbCommandBuilder
		Dim bProcesa As Boolean
		Dim sTabla As String
		Dim sUpdate As String = ""
		Dim sValor As String
		Dim sVarLogAnt As String = ""
		Dim sVarLogAct As String = ""

		Cursor = Cursors.WaitCursor

		sSQL = sSQL_Update
		sSQL = "SELECT * " & sSQL.Substring(sSQL.LastIndexOf("FROM", System.StringComparison.OrdinalIgnoreCase))

		sTabla = sSQL.Substring(sSQL.LastIndexOf("FROM", System.StringComparison.OrdinalIgnoreCase))
		sTabla = sTabla.Replace("FROM", "").Trim
		sTabla = sTabla.Replace(vbCrLf, " ")
		If sTabla.IndexOf(" ", System.StringComparison.OrdinalIgnoreCase) > 0 Then
			sTabla = sTabla.Substring(0, sTabla.IndexOf(" ", System.StringComparison.OrdinalIgnoreCase))
		End If
		sTabla = sTabla.Replace(vbCrLf, String.Empty).Replace(vbNullChar, String.Empty).Trim


		If sSQL.IndexOf("END") <> -1 Then
			sSQL = sSQL.Substring(0, sSQL.IndexOf("END", System.StringComparison.OrdinalIgnoreCase) - 1)
		End If

		Try
			Dim ds As DataSet = oAdmTablas.AbrirDataset(QueryConsulta, da)
			'Dim ds As DataSet = Prex.Utils.DataAccess.GetDataSet(sSQL, sTabla)

			Dim parametrosInsert As New Dictionary(Of String, Object)

			sSQL = sSQL.Substring(sSQL.LastIndexOf("FROM", System.StringComparison.OrdinalIgnoreCase))

			If MODO_APE = "B" Then
				sUpdate = "DELETE " & sSQL

				If GENERAR_LOG_SQL And (TIPO_LOG_SQL = 1 Or TIPO_LOG_SQL = 2 Or TIPO_LOG_SQL = 3) Then
					sVarLogAnt = "Registro a Eliminar: " + sSQL_Update
					sVarLogAct = "Registro a Eliminado: " + sSQL_Update
				End If

				GoTo GuardaDataRow
			ElseIf MODO_APE = "A" OrElse MODO_APE = "N" Then

				'oRow = ds.Tables(0).NewRow()
			Else
				sUpdate = "UPDATE " & sTabla & " SET "
			End If

			For Each oCol In oColumnas
				If Not oCol.VisibleABM Then Continue For
				bProcesa = False

				For Each oField As DataColumn In ds.Tables(0).Columns
					If oCol.Campo.ToUpper = oField.ColumnName.ToUpper Then
						bProcesa = True
						Exit For
					End If
				Next

				If bProcesa Then
					If MODO_APE = "A" Or MODO_APE = "N" Then
						parametrosInsert.Add(oCol.Campo, oAdmTablas.ValueOrDbNull(oCol.Valor))
						'oRow.Item(oCol.Campo) = oAdmTablas.ValueOrDbNull(oCol.Valor)
					Else
						If oCol.Valor Is Nothing AndAlso TipoDatosADO(oCol.Tipo) <> "Numérico" Then
							sValor = "NULL"
						Else
							Select Case TipoDatosADO(oCol.Tipo)
								Case "Numérico"
									If oCol.Valor Is Nothing OrElse oCol.Valor.ToString().Trim() = String.Empty Then
										sValor = FlotanteSQL(0)
									Else
										sValor = FlotanteSQL(oCol.Valor)
									End If
								Case "Fecha/Hora"
									If oCol.Valor.ToString().Trim() = String.Empty Then
										sValor = FechaSQL(Date.MinValue)
									Else
										sValor = FechaSQL(oCol.Valor)
									End If

								Case Else
									sValor = "'" & oCol.Valor & "'"
							End Select
						End If
					End If

					If oCol.VisibleABM Then
						sUpdate = sUpdate & " [" & oCol.Campo & "] = " & sValor & ","

						'AGREGADO PARA QUE ESCRIBA LOG DE LAS MODIFICACIONES MANUALES
						'SI EXISTE LA VARIABLE "DEBUG" EN EL INI - 0 = NO / 1 = SI
						'SI EXISTE LA VARIABLE "TIPOLOG" EN EL INI - 1= Completo 2= Solo modificaciones no SELECT 3= No graba nada


						If GENERAR_LOG_SQL And (TIPO_LOG_SQL = 1 Or TIPO_LOG_SQL = 2 Or TIPO_LOG_SQL = 3) Then
							Dim valor = sValor
							If MODO_APE = "A" Then
								valor = $"@{oCol.Campo}"
							End If
							sVarLogAct = sVarLogAct +
										oCol.Titulo + ": " +
										valor + ", "
							If oCol.ValorAnterior Is Nothing Then
								sVarLogAnt = sVarLogAnt + oCol.Titulo + ": , "

							Else
								sVarLogAnt = sVarLogAnt + oCol.Titulo + ": " + oCol.ValorAnterior.ToString + ", "
							End If

						End If
					End If
				End If
			Next

			'Agregar valores default
			Dim cmdDefault As SqlCommand
			Dim updateDefault As String = String.Empty
			If MODO_APE = "A" AndAlso Not sSQL_Actualizar.IsNullOrEmpty Then
				Dim dataDefault As SqlClient.SqlDataReader = DataAccess.GetSingleReader(sSQL_Update)
				Dim parametros As New Dictionary(Of String, Object)
				If dataDefault.Read() Then
					For i As Integer = 0 To dataDefault.FieldCount() - 1
						Dim nombreColumna As String = dataDefault.GetName(i)
						If Not parametros.ContainsKey(nombreColumna) Then
							If oColumnas.Contains(nombreColumna) Then

								Dim columna As clsColumnas = oColumnas(nombreColumna)
								Dim valor As Object = dataDefault(i)
								If TipoDatosADO(columna.Tipo) = "Fecha/Hora" Then
									If dataDefault(i) Is Nothing OrElse IsDBNull(dataDefault(i)) Then
										valor = DateTime.Parse("1900-01-01 00:00:00.000")
									End If
								End If

								If Not columna.VisibleABM Then
									If updateDefault.IsNullOrEmpty Then
										updateDefault = $"UPDATE {sTabla} SET {nombreColumna} = @{nombreColumna}"
									Else
										updateDefault += $", {nombreColumna} = @{nombreColumna}"
									End If
									parametros.Add(nombreColumna, valor)

								End If
							Else
								If updateDefault.IsNullOrEmpty Then
									updateDefault = $"UPDATE {sTabla} SET {nombreColumna} = @{nombreColumna}"
								Else
									updateDefault += $", {nombreColumna} = @{nombreColumna}"
								End If

								parametros.Add(nombreColumna, dataDefault(i))
							End If



						End If
					Next

					'If Not updateDefault.IsNullOrEmpty Then
					'	updateDefault += $" WHERE DC_FECVIG = @DC_FECVIG AND DC_CODENT = @DC_CODENT AND DC_CODPAR = @DC_CODPAR AND DC_CAMPO8 = @DC_CAMPO8 AND DC_CODCON = @DC_CODCON AND DC_CUADRO = @DC_CUADRO"
					'	cmdDefault = New SqlCommand(updateDefault)
					'	For Each parametro As KeyValuePair(Of String, Object) In parametros
					'		cmdDefault.Parameters.AddWithValue(parametro.Key, parametro.Value)
					'	Next
					'	cmdDefault.Parameters.AddWithValue("DC_FECVIG", parametrosInsert("DC_FECVIG"))
					'	cmdDefault.Parameters.AddWithValue("DC_CODENT", parametrosInsert("DC_CODENT"))
					'	cmdDefault.Parameters.AddWithValue("DC_CODPAR", parametrosInsert("DC_CODPAR"))
					'	cmdDefault.Parameters.AddWithValue("DC_CAMPO8", parametrosInsert("DC_CAMPO8"))
					'	cmdDefault.Parameters.AddWithValue("DC_CODCON", parametrosInsert("DC_CODCON"))
					'	cmdDefault.Parameters.AddWithValue("DC_CUADRO", parametrosInsert("DC_CUADRO"))
					'End If

					updateDefault += " " + sSQL_Actualizar.Substring(sSQL_Actualizar.LastIndexOf("WHERE "))
					cmdDefault = New SqlCommand(updateDefault)

					For Each parametro As KeyValuePair(Of String, Object) In parametros
						If updateDefault.Contains($"@{parametro.Key}") AndAlso Not cmdDefault.Parameters.Contains(parametro.Key) Then
							cmdDefault.Parameters.AddWithValue(parametro.Key, parametro.Value)
						End If
					Next

					For Each item As KeyValuePair(Of String, Object) In parametrosInsert
						If sSQL_Actualizar.Contains($"@{item.Key}") AndAlso Not cmdDefault.Parameters.Contains(item.Key) Then
							cmdDefault.Parameters.AddWithValue(item.Key, item.Value)
						End If
					Next

				End If
			End If
GuardaDataRow:

			If MODO_APE = "A" OrElse MODO_APE = "N" Then

				Dim cmdInsert As New SqlCommand()
				cmdInsert.CommandText = $"INSERT INTO {sTabla} ({String.Join(",", parametrosInsert.Keys)}) VALUES ("
				Dim i = 0
				For Each paramInsert As KeyValuePair(Of String, Object) In parametrosInsert
					sVarLogAct = sVarLogAct.Replace($"@{paramInsert.Key}", paramInsert.Value)
					If i = 0 Then
						cmdInsert.CommandText += $"@{paramInsert.Key}"
					Else
						cmdInsert.CommandText += $", @{paramInsert.Key}"

					End If
					i += 1
					cmdInsert.Parameters.AddWithValue(paramInsert.Key, paramInsert.Value)
				Next
				cmdInsert.CommandText += ")"
				Prex.Utils.DataAccess.Execute(cmdInsert)

				If cmdDefault IsNot Nothing AndAlso Not cmdDefault.CommandText.IsNullOrEmpty() Then
					Try
						DataAccess.Execute(cmdDefault)
					Catch ex As Exception
						'GuardarLOG(AccionesLOG.ModificacionDeDatos, $"Error grabando datos default: {cmdDefault.CommandText}", CODIGO_TRANSACCION, UsuarioActual.Codigo)
					End Try
				End If

			Else
				If MODO_APE <> "B" Then
					sUpdate = sUpdate.Substring(0, sUpdate.Length - 1) & " " & sSQL
				End If

				Dim nFilas As Integer
				oAdmTablas.EjecutarComandoAsincrono(sUpdate, nFilas)
				'MessageBox.Show("Filas Afectadas: " & nFilas.ToString)
			End If


			'AGREGADO PARA QUE ESCRIBA LOG DE LAS MODIFICACIONES MANUALES
			If GENERAR_LOG_SQL AndAlso (TIPO_LOG_SQL = 1 Or TIPO_LOG_SQL = 2 Or TIPO_LOG_SQL = 3) Then

				If MODO_APE = "B" AndAlso cmdGuardar.Text = "Baja" Then
					GuardarLOG(AccionesLOG.EliminarDatosEnCuadros, "Ant.: " & sVarLogAnt, CODIGO_TRANSACCION, UsuarioActual.Codigo)
					GuardarLOG(AccionesLOG.EliminarDatosEnCuadros, "Act.: " & sVarLogAct, CODIGO_TRANSACCION, UsuarioActual.Codigo)
				Else
					GuardarLOG(AccionesLOG.ModificacionDeDatos, "Ant.: " & sVarLogAnt, CODIGO_TRANSACCION, UsuarioActual.Codigo)
					GuardarLOG(AccionesLOG.ModificacionDeDatos, "Act.: " & sVarLogAct, CODIGO_TRANSACCION, UsuarioActual.Codigo)
				End If
			End If

			Cursor = Cursors.Default

			frmMain.Ejecutar()

			Me.Close()

		Catch ex As Exception
			Cursor = Cursors.Default
			TratarError(ex, "Guardar")
		End Try

	End Sub

	Private Sub Formula(ByVal sSQL As String, ByVal sKey As String)

		Try
			Dim oCol As clsColumnas
			For Each oCol In oColumnas
				Dim vValor = String.Empty
				If oCol.Valor IsNot Nothing AndAlso Not IsDBNull(oCol.Valor) Then
					If oCol.Help = 0 Then
						If TipoDatosADO(oCol.Tipo) = "Fecha/Hora" Then
							vValor = FechaSQL(oCol.Valor)
						ElseIf TipoDatosADO(oCol.Tipo) = "Numérico" Then
							If IsNumeric(oCol.Valor) Then
								vValor = FlotanteSQL(Format(oCol.Valor, "Fixed"))
							Else
								vValor = 0
							End If
						Else
							vValor = "'" & oCol.Valor & "'"
						End If
					Else
						If TipoDatosADO(oCol.Tipo) = "Fecha/Hora" Then
							vValor = FechaSQL(Llave(oCol.Valor))
						ElseIf TipoDatosADO(oCol.Tipo) = "Numérico" Then
							If IsNumeric(oCol.Valor) Then
								vValor = FlotanteSQL(Format(oCol.Valor, "Fixed"))
							Else
								vValor = 0
							End If
						Else
							vValor = "'" & oCol.Valor & "'"
						End If
					End If
				End If




				sSQL = Replace(sSQL, "[" & oCol.Campo & "]", vValor)

				'Application.DoEvents()
			Next

			sSQL = frmMain.ReemplazarVariablesExt(sSQL)

			Dim ds As New DataSet
			oAdmTablas.EjecutarComandoAsincrono(sSQL, "", 0, ds)
			If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then

				If oColumnas(sKey).Help = 0 AndAlso dicControlesValorAnterior.ContainsKey(sKey) Then
					If TipoDatosADO(oColumnas(sKey).Tipo) = "Fecha/Hora" Then
						CType(dicControlesValorAnterior(sKey), DevExpress.XtraEditors.DateEdit).DateTime = Date.Parse(ds.Tables(0).Rows(0).Item(0).ToString())
					Else
						If (TypeOf (dicControlesValorAnterior(sKey)) Is DevExpress.XtraEditors.ComboBoxEdit) Then
							CType(dicControlesValorAnterior(sKey), DevExpress.XtraEditors.ComboBoxEdit).SelectedText = ds.Tables(0).Rows(0).Item(0).ToString()
						End If
						If (TypeOf (dicControlesValorAnterior(sKey)) Is DevExpress.XtraEditors.MemoEdit) Then
							CType(dicControlesValorAnterior(sKey), DevExpress.XtraEditors.MemoEdit).Text = ds.Tables(0).Rows(0).Item(0).ToString()
						End If
					End If
				ElseIf dicControlesValorAnterior.ContainsKey(sKey) Then
					Dim items = CType(dicControlesValorAnterior(sKey), DevExpress.XtraEditors.ComboBoxEdit).Properties.Items
					Dim cItem As Prex.Utils.Entities.clsItem = Nothing

					For Each i As Object In items
						If TypeOf i Is Prex.Utils.Entities.clsItem AndAlso CType(i, Prex.Utils.Entities.clsItem).Valor = ds.Tables(0).Rows(0).Item(0).ToString() Then
							cItem = i
							Exit For
						End If
					Next

					If cItem IsNot Nothing Then
						CType(dicControlesValorAnterior(sKey), DevExpress.XtraEditors.ComboBoxEdit).SelectedItem = cItem
					Else
						CType(dicControlesValorAnterior(sKey), DevExpress.XtraEditors.ComboBoxEdit).SelectedText = ds.Tables(0).Rows(0).Item(0).ToString()
					End If

					'SelCombo(cboInput(oColumnas(sKey).Orden), "K" & RS.Fields(0)
				End If
			End If


		Catch ex As Exception
			Prex.Utils.ManejarErrores.TratarError(ex, "Formula")
		End Try
	End Sub

	Private Sub txtInput_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

		Dim oCol As clsColumnas

		oCol = oColumnas(sender.tag)

		oCol.Valor = sender.Text

	End Sub

	Private Sub cboInput_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

		Dim oCol As clsColumnas
		oCol = oColumnas(sender.tag)

		If TypeOf sender.SelectedItem Is Prex.Utils.Entities.clsItem Then

			Dim oItem As Prex.Utils.Entities.clsItem = sender.SelectedItem
			Select Case TipoDatosADO(oCol.Tipo)
				Case "Numérico"
					oCol.Valor = oItem.Valor
				Case "Fecha/Hora"
					oCol.Valor = oItem.Valor
				Case Else
					oCol.Valor = oItem.Valor
			End Select

		End If



	End Sub


	'Private Sub cboInput_Click(Index As Integer)
	'	Dim oCol As ItemsDetSys
	'	Dim sSQL As String
	'	For Each oCol In oDetSys
	'		If Trim(oCol.Formul) <> "" Then
	'			Formula oCol.Formul, oCol.Key
	'  End If
	'		DoEvents
	'	Next

	'	If CODIGO_TRANSACCION = 86101 And Index = 4 Then

	'		sSQL = "SELECT TG_NUME02, '(' + CAST(TG_NUME02 AS VARCHAR) + ') - ' + TG_DESCRI " &
	'		 "FROM TABGEN WHERE TG_CODTAB = 86004 " &
	'		 "AND TG_NUME01 = " & Llave(cboInput(4)) & " ORDER BY TG_CODCON"
	'		CargarCombo cboInput(5), sSQL
	'  DoEvents
	'	End If
	'	DoEvents
	'	cboInput(Index).ToolTipText = cboInput(Index).Text
	'	'AGREGADO PARA UNIDADES DE SERVICIO (OCtubre 2014)
	'	If CODIGO_TRANSACCION = 86101 And (Index = 3 Or Index = 4 Or Index = 5) Then

	'		Inhabilita_ABM CODIGO_TRANSACCION, Llave(cboInput(4)), Llave(cboInput(3)), Llave(cboInput(5))

	'  End If

	'	DoEvents
	'End Sub

	Private Sub fecInput_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)

		listColumnasExistentes _
		.ForEach(Sub(col)
					 If col.Formula <> "" Then
						 Formula(col.Formula, col.Key)
					 End If
				 End Sub)


		'If Not CType(sender, Control).Enabled OrElse (TypeOf sender Is DevExpress.XtraEditors.BaseEdit AndAlso CType(sender, DevExpress.XtraEditors.BaseEdit).ReadOnly) Then
		'	Exit Sub
		'End If
		'Dim oCol As clsColumnas
		'oCol = oColumnas(sender.tag)
		'If oCol.Formula <> "" Then

		'	Formula(oCol.Formula, oCol.Key)
		'End If

	End Sub

	Private Sub fecInput_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

		Dim oCol As clsColumnas

		oCol = oColumnas(sender.tag)
		oCol.Valor = sender.DateTime

	End Sub

End Class