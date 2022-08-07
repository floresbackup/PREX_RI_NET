Imports System.Windows.Forms

Public Class frmDialog

	Private isNew As Boolean = True
	Private _callBack As Action(Of String, String, Object)
	Private _tag As Object = Nothing

	Private ReadOnly Property Valor As String
		Get
			If isNew AndAlso chkEncrypt.Checked Then Return Convert.ToBase64String(System.Text.ASCIIEncoding.UTF8.GetBytes(txtValor.Text))
			Return txtValor.Text
		End Get
	End Property




	Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
		Me.DialogResult = System.Windows.Forms.DialogResult.OK
		_callBack.Invoke(txtNombre.Text, Valor, _tag)
		Me.Close()
	End Sub

	Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
		Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Close()
	End Sub

	Friend Sub PasarDatos(ByVal sNombre As String,
						  ByVal sValor As String,
						  ByVal callBack As Action(Of String, String, Object))
		PasarDatos(sNombre, sValor, False, Nothing, callBack)

	End Sub

	Friend Sub PasarDatos(ByVal sNombre As String,
						  ByVal sValor As String,
						  ByVal _isNew As Boolean,
						  ByVal oTag As Object,
						  ByVal callBack As Action(Of String, String, Object))
		isNew = _isNew
		txtNombre.Text = sNombre
		txtValor.Text = sValor
		_tag = oTag
		_callBack = callBack
	End Sub

	Private Sub frmDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		chkEncrypt.Enabled = isNew
	End Sub
End Class
