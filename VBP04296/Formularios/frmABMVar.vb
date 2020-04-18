Imports DevExpress.XtraEditors.Controls
Imports VBP04296.Dominio

Public Class frmABMVar

	Public Class VarHelpItems
		Public _tipo As eVarHelp

		Sub New(tipo As eVarHelp)
			_tipo = tipo
		End Sub

		Public Overrides Function ToString() As String
			Return _tipo.ToString().Replace("_", " ")
		End Function
	End Class

	Public Variable As VarSys
	Private _lstVariables As List(Of VarSys)
	Private cmSql As ScintillaNET.Scintilla

	Sub New()

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		cboTipoDato.Properties.Items.Add(New ComboBoxItem(eTipoVariable.Numero))
		cboTipoDato.Properties.Items.Add(New ComboBoxItem(eTipoVariable.Texto))
		cboTipoDato.Properties.Items.Add(New ComboBoxItem(eTipoVariable.Fecha))

		RemoveHandler cboHelp.CustomDisplayText, AddressOf cboHelp_CustomDisplayText
		RemoveHandler cboHelp.Properties.SelectedIndexChanged, AddressOf cboHelp_Properties_SelectedIndexChanged

		cboHelp.Properties.Items.Add(New VarHelpItems(eVarHelp.Utilizar_el_tipo_de_dato))
		cboHelp.Properties.Items.Add(New VarHelpItems(eVarHelp.Utilizar_Help_SQL))
		cboHelp.Properties.Items.Add(New VarHelpItems(eVarHelp.Utilizar_código_de_entidad))
		cboHelp.Properties.Items.Add(New VarHelpItems(eVarHelp.Utilizar_código_de_cuadro))
		cboHelp.Properties.Items.Add(New VarHelpItems(eVarHelp.Utilizar_Condicional))
		cboHelp.Properties.Items.Add(New VarHelpItems(eVarHelp.Utilizar_codigo_de_usuario))

		AddHandler cboHelp.Properties.SelectedIndexChanged, AddressOf cboHelp_Properties_SelectedIndexChanged
		AddHandler cboHelp.CustomDisplayText, AddressOf cboHelp_CustomDisplayText

		cmSql = New ScintillaNET.Scintilla()
		cmSql.TabIndex = 5
		pnlQuery.Controls.Add(cmSql)
		cmSql.Dock = DockStyle.Fill
		Prex.Utils.Misc.Forms.ScintillaSQL.InitialiseScintilla(cmSql)

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().

	End Sub

	Public Sub PasarDatos(ByRef variable As VarSys, variables As List(Of VarSys))
		Try
			RemoveHandler cboHelp.Properties.SelectedIndexChanged, AddressOf cboHelp_Properties_SelectedIndexChanged
			RemoveHandler cboHelp.CustomDisplayText, AddressOf cboHelp_CustomDisplayText

			Me.Variable = variable
			If Me.Variable Is Nothing Then Me.Variable = New VarSys("K" & (variables.Count() + 1).ToString)
			_lstVariables = variables
			CargarVariableSeleccionado(variable)
		Finally
			AddHandler cboHelp.Properties.SelectedIndexChanged, AddressOf cboHelp_Properties_SelectedIndexChanged
			AddHandler cboHelp.CustomDisplayText, AddressOf cboHelp_CustomDisplayText

		End Try
	End Sub

	Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
		If txtTitulo.Text.Any AndAlso txtVariable.Text.Any AndAlso (Not cmSql.Enabled OrElse cmSql.Text.Any) _
			AndAlso cboHelp.SelectedIndex > -1 AndAlso cboTipoDato.SelectedIndex > -1 Then
			Variable.Titulo = txtTitulo.Text
			Variable.Nombre = txtVariable.Text
			Variable.Tipo = cboTipoDato.SelectedItem
			Variable.Help = cboHelp.SelectedItem._tipo
			Variable.HelQue = cmSql.Text
			If Variable.Orden = 0 Then
				Variable.Orden = _lstVariables.Count() + 1
			End If
		Else
			Prex.Utils.MensajesForms.MostrarError("Debe completar todos los datos")
			Me.DialogResult = DialogResult.Abort
		End If
	End Sub

	Private Sub FormAbmPro(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		If Me.DialogResult = DialogResult.Abort Then
			e.Cancel = True
		End If
	End Sub

	Private Sub cboHelp_Properties_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHelp.Properties.SelectedIndexChanged
		If cboHelp.SelectedIndex = -1 Then
			Exit Sub
		End If

		cmSql.Enabled = cboHelp.SelectedItem._tipo = eVarHelp.Utilizar_Help_SQL OrElse cboHelp.SelectedItem._tipo = eVarHelp.Utilizar_Condicional
		cmSql.ReadOnly = Not cmSql.Enabled
		lblHelpSQL.Enabled = cboHelp.SelectedItem._tipo = eVarHelp.Utilizar_Help_SQL OrElse cboHelp.SelectedItem._tipo = eVarHelp.Utilizar_Condicional
	End Sub

	Private Sub CargarVariableSeleccionado(vari As VarSys)
		If vari Is Nothing Then
			txtVariable.Text = String.Empty
			txtTitulo.Text = String.Empty
			cmSql.Text = String.Empty
			cboHelp.SelectedItem = Nothing
			cboTipoDato.SelectedItem = Nothing
		Else
			txtVariable.Text = vari.Nombre
			txtTitulo.Text = vari.Titulo
			cboHelp.SelectedItem = cboHelp.Properties.Items.Item(vari.Help)
			cboTipoDato.SelectedItem = cboTipoDato.Properties.Items.Item(vari.Tipo)
			cmSql.Text = vari.HelQue
		End If
	End Sub

	Private Sub cboHelp_CustomDisplayText(sender As Object, e As CustomDisplayTextEventArgs) Handles cboHelp.CustomDisplayText
		If e.Value Is Nothing Then Exit Sub
		e.DisplayText = e.Value.ToString
	End Sub
End Class