Public Class frmCambiarPass

   Private nCodUsu As Long = 0
   Private sNombreUsuario As String = ""
   Private oAdmLocal As New AdmTablas
   Private oAdmUsuarios As New AdmUsuarios

   Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

      If datosOK() Then
         If guardar() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
         End If
      End If

   End Sub

   Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click

      Me.DialogResult = Windows.Forms.DialogResult.Cancel
      Me.Close()

   End Sub

   Public Sub New()

      ' Llamada necesaria para el Diseñador de Windows Forms.
      InitializeComponent()

      ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
      oAdmLocal.ConnectionString = CONN_LOCAL

   End Sub

   Public Sub PasarDatos(ByVal nCodUsuario As Long, _
                         ByVal sUsuario As String, _
                         ByVal sDescri As String, _
                         Optional ByVal bRenueva As Boolean = False)

      nCodUsu = nCodUsuario
      sNombreUsuario = sUsuario
      lblUsuario.Text = "Usuario: " & sUsuario
      lblDescripcion.Text = "Nombre: " & sDescri

      txtActual.Enabled = bRenueva
      PasswordLabel.Enabled = bRenueva

   End Sub

   Private Function datosOK() As Boolean

      If txtActual.Enabled Then
         If CalculateMD5(txtActual.Text) <> oAdmLocal.DevolverValor("USUARI", "US_PASSWO", "US_CODUSU=" & nCodUsu, "") Then
            MensajeError("La contraseña actual es incorrecta")
            txtActual.Focus()
            Return False
         End If
      End If

      If txtNueva.Text.Trim = "" Then
         MensajeError("Debe ingresar una nueva contraseña")
         txtNueva.Focus()
         Return False
      End If

      If txtNueva.Text <> txtConfirmacion.Text Then
         MensajeError("La contraseña nueva y la confirmación no coinciden")
         txtNueva.Focus()
         Return False
      End If

      If txtActual.Enabled Then
         If txtActual.Text.Trim.ToUpper = txtNueva.Text.Trim.ToUpper Then
            MensajeError("La nueva contraseña debe diferir de la anterior, sin distinguir mayúsculas de minúsculas")
            txtNueva.Focus()
            Return False
         End If
      End If

      Return True

   End Function

   Private Function guardar() As Boolean

      Dim bResult As Boolean
      Dim sError As String = ""

      If UsuarioActual.Codigo > 1 Then

         bResult = oAdmUsuarios.CambiarPassword(sNombreUsuario, txtNueva.Text, sError)

      Else

         bResult = oAdmUsuarios.CambiarPasswordPorAdmin(sNombreUsuario, txtNueva.Text, sError)

      End If

      If Not bResult Then
         MensajeError(sError)
         Return False
      Else
         Return True
      End If

   End Function

End Class
