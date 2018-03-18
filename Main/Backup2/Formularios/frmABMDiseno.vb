Imports System.Windows.Forms

Public Class frmABMDiseno

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

   Private Sub frmABMDiseno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      'Tipo de dato
      AgregarItemCombo(cboTipo, 70, "Fecha")
      AgregarItemCombo(cboTipo, 84, "Texto")
      AgregarItemCombo(cboTipo, 0, "N�mero")
      AgregarItemCombo(cboTipo, 2, "N�mero 2 decimales")
      AgregarItemCombo(cboTipo, 4, "N�mero 4 decimales")
      AgregarItemCombo(cboTipo, 6, "N�mero 6 decimales")

      SelItemCombo(cboTipo, 0)

      'Validaci�n
      AgregarItemCombo(cboValida, 0, "Sin validaci�n")
      AgregarItemCombo(cboValida, 1, "Validar Fecha")
      AgregarItemCombo(cboValida, 2, "Validar Entidad")
      AgregarItemCombo(cboValida, 99, "Incorporar Fecha")
      AgregarItemCombo(cboValida, 98, "Incorporar Entidad")
      AgregarItemCombo(cboValida, 50, "Convierte en decimal")
      AgregarItemCombo(cboValida, 3, "Validar cuenta")

      SelItemCombo(cboValida, 0)

   End Sub

   Public Sub PasarDatos(ByVal sCampo As String, _
                         ByVal sDescri As String, _
                         ByVal nInicio As Long, _
                         ByVal nLongitud As Long, _
                         ByVal nTipo As Integer, _
                         ByVal sFormato As String, _
                         ByVal sRelacion As String, _
                         ByVal nValida As Integer, _
                         ByVal nClave As Integer)


      txtCampo.Text = sCampo
      txtDescri.Text = sDescri
      txtInicio.Text = nInicio.ToString
      txtLongitud.Text = nLongitud.ToString
      lblFin.Text = (nInicio + nLongitud).ToString
      SelItemCombo(cboTipo, nTipo)
      cboFormato.Text = sFormato
      txtRelacion.Text = sRelacion
      SelItemCombo(cboValida, nValida)
      txtNroClave.Text = nClave.ToString

   End Sub
End Class
