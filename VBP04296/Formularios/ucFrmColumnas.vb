Imports VBP04296.Dominio
Imports Prex.Utils.ExtensionMehods
Imports System.Data.SqlClient

Public Class ucFrmColumnas
	Private cmSqlHelp As ScintillaNET.Scintilla
	Private cmSqlFormula As ScintillaNET.Scintilla
	Private detSys As List(Of DetSys)
	Private isCargando As Boolean

	Public Enum HelpTipo
		TipoDato = 0  '"Utilizar el tipo de dato",
		SQL = 1 '"Utilizar Help SQL"
	End Enum

	Public ReadOnly Property tDetSys As List(Of DetSys)
		Get

			Return detSys
		End Get
	End Property
	Private ReadOnly Property ColSeleccionada As DetSys
		Get
			If isCargando Then Return Nothing
			If detSys Is Nothing OrElse Not detSys.Any() Then Return Nothing

            Dim llave As String = gridViewColumnas.FocusedValue().ToString
            If llave.IsNullOrEmpty() Then detSys.FirstOrDefault()

			Return detSys.FirstOrDefault(Function(t) t.Campo = llave)
		End Get
	End Property

	Public Sub New()

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().

		cmSqlHelp = New ScintillaNET.Scintilla()
		pnlHelpSQL.Controls.Add(cmSqlHelp)
		cmSqlHelp.Dock = DockStyle.Fill
		Prex.Utils.Misc.Forms.ScintillaSQL.InitialiseScintilla(cmSqlHelp)

		cmSqlFormula = New ScintillaNET.Scintilla()
		pnlSQLFormula.Controls.Add(cmSqlFormula)
		cmSqlFormula.Dock = DockStyle.Fill
		Prex.Utils.Misc.Forms.ScintillaSQL.InitialiseScintilla(cmSqlFormula)

		Dim item As New DevExpress.XtraEditors.Controls.ComboBoxItem()
		item.Value = HelpTipo.TipoDato
		cboHelp.Properties.Items.Add(item)

		Dim item2 As New DevExpress.XtraEditors.Controls.ComboBoxItem()
		item2.Value = HelpTipo.SQL
		cboHelp.Properties.Items.Add(item2)

	End Sub


	Private Sub ucFrmColumnas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

#Region "Metodos"

	Public Sub CargarGrillaColumnas(tDetSys As List(Of DetSys))
		Try
			RemoveHandler gridViewColumnas.SelectionChanged, AddressOf gridViewColumnas_SelectionChanged
			detSys = tDetSys
			gridColumnas.DataSource = tDetSys.OrderBy(Function(c) c.Orden).Select(Function(c) New With {c.Campo, c.Llave}).ToList()
			For Each item As DevExpress.XtraGrid.Columns.GridColumn In gridViewColumnas.Columns
				item.Visible = item.FieldName.Contains("Campo")
			Next
			gridViewColumnas.FocusedRowHandle = 0
			gridViewColumnas.SelectRow(0)

			MostrarColumna(tDetSys.OrderBy(Function(c) c.Orden).FirstOrDefault())
		Finally
			AddHandler gridViewColumnas.SelectionChanged, AddressOf gridViewColumnas_SelectionChanged
		End Try
	End Sub


	Private Sub MostrarColumna(columna As DetSys)
		Try
			RemoveHandler cmSqlFormula.TextChanged, AddressOf CambioSQL
			RemoveHandler cmSqlHelp.TextChanged, AddressOf CambioSQL
			isCargando = True

			If columna Is Nothing Then
				txtTituloVar.Text = String.Empty
				txtTipo.Text = String.Empty
				cboHelp.Text = String.Empty
				chkClaveTabla.Checked = False
				chkDrillDown.Checked = False
				chkHabilita.Checked = False
				chkReemplazoValores.Checked = False
				chkVisABM.Checked = False
				chkVisGrilla.Checked = False

				txtFormato.Text = String.Empty
				TextEdit6.Text = String.Empty

			Else
				txtTituloVar.Text = columna.Titulo
				txtTipo.Text = columna.Tipo.ToString
				cboHelp.Text = GetTextoTipoHelp(columna.Help)
				txtAnchoMax.Text = columna.MaxLargo
				txtAncho.Text = columna.Largo
				'No se que campos es
				TextEdit6.Text = columna.RutaAyuda

				chkClaveTabla.Checked = columna.Llave
				chkDrillDown.Checked = columna.DrillD
				chkHabilita.Checked = columna.Habili
				chkReemplazoValores.Checked = columna.Reemplazo
				chkVisABM.Checked = columna.VisABM
				chkVisGrilla.Checked = columna.Visible

				cmSqlFormula.Text = columna.Formul
				cmSqlHelp.Text = columna.HelQue

				If columna.Format.Length >= 8 Then
					Dim sFormat = columna.Format.Split(";")
					txtFormato.Text = sFormat(0)
					pickFondo.Color = ColorTranslator.FromOle(Val(sFormat(1)))
					pickFrente.Color = ColorTranslator.FromOle(Val(sFormat(2)))
					Dim f As Font
					Dim ff As FontStyle
					If Val(sFormat(4)) Then ff = FontStyle.Bold
					If Val(sFormat(5)) Then ff = ff And FontStyle.Underline
					If Val(sFormat(6)) Then ff = ff And FontStyle.Strikeout

					edFuente.Font = New Font(sFormat(3).ToString, Single.Parse(sFormat(7)), ff)
					txtAncho.Text = Val(sFormat(8))
					If UBound(sFormat) = 9 Then
						txtValorCond.Text = sFormat(9)
					End If
				End If
				cmSqlHelp.Enabled = columna.Help = HelpTipo.SQL
			End If
			'Siempre esta en =
			txtCond.Text = "="
			btnQueryDrillDown.Enabled = chkDrillDown.Checked

		Finally
			AddHandler cmSqlFormula.TextChanged, AddressOf CambioSQL
			AddHandler cmSqlHelp.TextChanged, AddressOf CambioSQL
			isCargando = False
		End Try
	End Sub

	Private Function GetTextoTipoHelp(tipo As HelpTipo) As String
		If ColSeleccionada Is Nothing Then Return "Utilizar el tipo de dato"

		Select Case tipo
			Case HelpTipo.SQL
				Return "Utilizar Help SQL"
			Case HelpTipo.TipoDato
				Return "Utilizar el tipo de dato"
		End Select
		Return "Utilizar el tipo de dato"
	End Function

	Private Function GetTipoHelpTexto(tipo As String) As HelpTipo
		If ColSeleccionada Is Nothing Then Return HelpTipo.TipoDato
		If tipo = "Utilizar Help SQL" Then Return HelpTipo.SQL
		If tipo = "Utilizar el tipo de dato" Then Return HelpTipo.TipoDato
		Return HelpTipo.TipoDato
	End Function

	Private Sub CambiarOrdenColumna(pos As Integer)
		ColSeleccionada.Orden = ColSeleccionada.Orden + pos

		Dim l As New List(Of DetSys)
		For Each item As DetSys In detSys.Where(Function(t) t.Campo <> ColSeleccionada.Orden)
			If ColSeleccionada.Orden = item.Orden Then
				item.Orden = item.Orden + pos
			End If
			l.Add(item)
		Next
		l.Add(ColSeleccionada)

		detSys = l.OrderBy(Function(t) t.Orden).ToList()
	End Sub

	Private Sub ActualizarFormato()
		If ColSeleccionada Is Nothing Then Exit Sub


		Dim sFormat As String = txtFormato.Text & ";" &
				  ColorTranslator.ToOle(pickFondo.Color) & ";" &
				  ColorTranslator.ToOle(pickFrente.Color) & ";" &
				  edFuente.Font.Name & ";" &
				  IIf(edFuente.Font.Bold, 1, 0) & ";" &
				  IIf(edFuente.Font.Underline, 1, 0) & ";" &
				  IIf(edFuente.Font.Style = FontStyle.Strikeout, 1, 0) & ";" &
				  Int(Val(edFuente.Font.Size)) & ";" &
				  Int(Val(txtAncho.Text)) & ";" &
				  txtValorCond.Text()

		ColSeleccionada.Format = sFormat
	End Sub

	Public Sub ObtenerCampos(codCon As Long, sSql As String, varSys As List(Of VarSys))
		Try
			Me.Cursor = Cursors.WaitCursor
			isCargando = True
			Try
				txtFormato.Text = String.Empty
				pickFondo.Color = SystemColors.Window
				pickFrente.BackColor = SystemColors.ActiveCaptionText
				edFuente.Font = New Font("Tahoma", 8)
				txtAncho.Text = "0"

				txtCond.Text = "="
				txtCond.Text = String.Empty

				Dim sFormat As String = txtFormato.Text & ";" &
					  ColorTranslator.ToOle(pickFondo.Color) & ";" &
					  ColorTranslator.ToOle(pickFrente.Color) & ";" &
					  edFuente.Font.Name & ";" &
					  IIf(edFuente.Font.Bold, 1, 0) & ";" &
					  IIf(edFuente.Font.Underline, 1, 0) & ";" &
					  IIf(edFuente.Font.Style = FontStyle.Strikeout, 1, 0) & ";" &
					  Int(Val(edFuente.Font.Size)) & ";" &
					  Int(Val(txtAncho.Text)) & ";" &
					  txtValorCond.Text()

				Dim nuevasColumnas = False
				If detSys.Count > 0 Then nuevasColumnas = Prex.Utils.MensajesForms.MostrarPregunta("Existen columnas cargadas. ¿Desea agregar aquellas que no existan y preservar las existentes?") = DialogResult.Yes

				Dim variableReemplazo = String.Empty
				For Each variable As VarSys In varSys

					Select Case variable.Tipo
						Case 0
							variableReemplazo = "0"
						Case 1
							variableReemplazo = "''"
						Case 2
							variableReemplazo = Prex.Utils.DataAccess.FechaSQL("01/01/1900")
					End Select

					'SI ES CONDICIONAL NO LO EVALUO
					If variable.Help > 3 Then variableReemplazo = ""

					sSql = sSql.Replace(variable.Nombre, variableReemplazo)
				Next


				Dim columnas As List(Of DetSys) = detSys
				If Not nuevasColumnas Then
					detSys.Clear()
					columnas.Clear()
				End If

				Dim dt As SqlDataReader = Prex.Utils.DataAccess.GetReader(sSql)
				Dim sch As DataTable = dt.GetSchemaTable()


				For Each item As DataRow In sch.Rows
					Dim nLargo As Integer? = Nothing
					Dim fieldName = item("ColumnName").ToString
					Dim fieldType = item("DataTypeName").ToString
					Dim maxLength = Integer.Parse(item("ColumnSize").ToString)
					Dim precision As Integer = Integer.Parse(item("NumericPrecision"))
					Dim scale As Integer = Integer.Parse(item("NumericScale"))



					If Prex.Utils.DataAccess.TipoDatosDao(fieldType) = Prex.Utils.TipoDatosDAO.Texto Then
						nLargo = IIf(maxLength > 30000, 0, maxLength)
					ElseIf Prex.Utils.DataAccess.TipoDatosDao(fieldType) = Prex.Utils.TipoDatosDAO.Numerico Then
						If Prex.Utils.DataAccess.TipoDatosRS(fieldType) = 5 Then
							nLargo = 32
						Else
							nLargo = precision
						End If
						If scale > 0 And scale < 255 Then
							nLargo = nLargo + scale + 2
						End If
					Else
						nLargo = 10
					End If

					Dim columna As DetSys = detSys.FirstOrDefault(Function(c) c.Campo = fieldName)
					If columna IsNot Nothing Then
						columna.Largo = nLargo
						If columna.Tipo <> Prex.Utils.DataAccess.TipoDatosRS(fieldType) Then
							If 1 = 1 Then

							End If
						End If
						columna.Tipo = Prex.Utils.DataAccess.TipoDatosRS(fieldType)
					Else
						Dim f = encode(fieldName)
						Dim d As New DetSys(codCon, detSys.Count + 1, fieldName, Prex.Utils.DataAccess.TipoDatosRS(fieldType),
											nLargo, sFormat, fieldName, 0, String.Empty, String.Empty, False, False, False, False, False,
											String.Empty, String.Empty, False, String.Empty, 0, "K" & (detSys.Count + 1).ToString())
						detSys.Add(d)
					End If
				Next

				dt.Close()
				CargarGrillaColumnas(columnas)


			Catch ex As Exception
				Prex.Utils.ManejarErrores.TratarError(ex, "ObtenerCampos", String.Empty, True)
			End Try
		Finally
			Me.Cursor = Cursors.Default
			isCargando = False
		End Try
	End Sub

	Public Shared Function encode(ByVal str As String) As String
		'supply True as the construction parameter to indicate
		'that you wanted the class to emit BOM (Byte Order Mark)
		'NOTE: this BOM value is the indicator of a UTF-8 string
		Dim utf8Encoding As New System.Text.UTF8Encoding(True)
		Dim encodedString() As Byte

		encodedString = utf8Encoding.GetBytes(str)

		Return utf8Encoding.GetString(encodedString)
	End Function
#End Region

#Region "Eventos"
	Private Sub CambioSQL(sender As Object, e As EventArgs)
		If ColSeleccionada Is Nothing Then Exit Sub

		ColSeleccionada.Formul = cmSqlFormula.Text
		ColSeleccionada.HelQue = cmSqlHelp.Text
	End Sub

	Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
		FontDialog1.Font = edFuente.Font
		If FontDialog1.ShowDialog() = DialogResult.OK Then
			edFuente.Font = FontDialog1.Font
			edFuente.Size = New Size(edFuente.Size.Width, 20)
		End If
		ActualizarFormato()
	End Sub

	Private Sub gridViewColumnas_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles gridViewColumnas.SelectionChanged
		Dim llave = ColSeleccionada?.Campo

		MostrarColumna(detSys.FirstOrDefault(Function(t) t.Campo = llave))
	End Sub

	Private Sub cboHelp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHelp.SelectedIndexChanged

		cmSqlHelp.Enabled = GetTipoHelpTexto(cboHelp.Text) = HelpTipo.SQL
	End Sub

	Private Sub btnBajarColumna_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBajarColumna.ItemClick
		CambiarOrdenColumna(-1)
	End Sub

	Private Sub btnEliminarColumna_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEliminarColumna.ItemClick

		If ColSeleccionada Is Nothing Then Exit Sub
		detSys.Remove(ColSeleccionada)
		gridViewColumnas.FocusedRowHandle = 0
		gridViewColumnas.SelectRow(0)
		MostrarColumna(detSys.FirstOrDefault())

	End Sub

	Private Sub btnSubirColumna_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSubirColumna.ItemClick
		CambiarOrdenColumna(1)
	End Sub


	Private Sub chkHabilita_CheckedChanged(sender As Object, e As EventArgs) Handles chkHabilita.CheckedChanged
		If ColSeleccionada Is Nothing Then Exit Sub
		ColSeleccionada.Habili = chkHabilita.Checked
	End Sub

	Private Sub chkVisGrilla_CheckedChanged(sender As Object, e As EventArgs) Handles chkVisGrilla.CheckedChanged
		If ColSeleccionada Is Nothing Then Exit Sub
		ColSeleccionada.Visible = chkVisGrilla.Checked
	End Sub

	Private Sub chkVisABM_CheckedChanged(sender As Object, e As EventArgs) Handles chkVisABM.CheckedChanged
		If ColSeleccionada Is Nothing Then Exit Sub
		ColSeleccionada.VisABM = chkVisABM.Checked
	End Sub

	Private Sub chkClaveTabla_CheckedChanged(sender As Object, e As EventArgs) Handles chkClaveTabla.CheckedChanged
		If ColSeleccionada Is Nothing Then Exit Sub
		ColSeleccionada.Llave = chkClaveTabla.Checked
	End Sub

	Private Sub chkDrillDown_CheckedChanged(sender As Object, e As EventArgs) Handles chkDrillDown.CheckedChanged
		If ColSeleccionada Is Nothing Then Exit Sub
		ColSeleccionada.DrillD = chkDrillDown.Checked
		btnQueryDrillDown.Enabled = chkDrillDown.Checked
	End Sub

	Private Sub btnQueryDrillDown_Click(sender As Object, e As EventArgs) Handles btnQueryDrillDown.Click
		If ColSeleccionada Is Nothing Then Exit Sub

		Dim frmDrill As New frmDrillDown()
		frmDrill.PasarQuery(ColSeleccionada.DriQue, $"DrillDown {ColSeleccionada.Campo}", sProcesoPrevio:=ColSeleccionada.DriPre)
		If frmDrill.ShowDialog() = DialogResult.OK Then
			If frmDrillDown.INPUT_GENERAL <> String.Empty Then
				ColSeleccionada.DriQue = frmDrillDown.INPUT_GENERAL
			End If
			If frmDrillDown.INPUT_GENERAL_AUX <> String.Empty Then
				ColSeleccionada.DriPre = frmDrillDown.INPUT_GENERAL_AUX
			End If
		End If
	End Sub

	Private Sub TextEdit6_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit6.EditValueChanged
		If ColSeleccionada Is Nothing Then Exit Sub
		ColSeleccionada.RutaAyuda = TextEdit6.Text
	End Sub

	Private Sub txtTituloVar_TextChanged(sender As Object, e As EventArgs) Handles txtTituloVar.TextChanged
		If ColSeleccionada Is Nothing Then Exit Sub
		ColSeleccionada.Titulo = txtTituloVar.Text
	End Sub


	Private Sub txtAnchoMax_TextChanged(sender As Object, e As EventArgs) Handles txtAnchoMax.TextChanged
		If ColSeleccionada Is Nothing Then Exit Sub
		ColSeleccionada.MaxLargo = txtAnchoMax.Text

	End Sub
	Private Sub txtAncho_TextChanged(sender As Object, e As EventArgs) Handles txtAncho.TextChanged, txtFormato.TextChanged, txtValorCond.TextChanged
		ActualizarFormato()
	End Sub

	Private Sub pickFondo_ColorChanged(sender As Object, e As EventArgs) Handles pickFondo.ColorChanged, pickFrente.ColorChanged
		ActualizarFormato()
	End Sub

	Private Sub chkReemplazoValores_CheckedChanged(sender As Object, e As EventArgs) Handles chkReemplazoValores.CheckedChanged
		If ColSeleccionada Is Nothing Then Exit Sub
		ColSeleccionada.Reemplazo = chkReemplazoValores.Checked
	End Sub

	Private Sub txtTipo_TextChanged(sender As Object, e As EventArgs) Handles txtTipo.TextChanged
		If ColSeleccionada Is Nothing Then Exit Sub
		ColSeleccionada.Tipo = txtTipo.Text
	End Sub
#End Region

End Class
