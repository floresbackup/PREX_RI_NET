Public Class frmAgregarTabla

    Public ReadOnly Property CodigoTabla As String
        Get
            Return txtCodigo.Text
        End Get
    End Property

    Public ReadOnly Property NombreTabla As String
        Get
            Return txtNombre.Text
        End Get
    End Property
    Public ReadOnly Property DatosOK As Boolean
        Get
            Return NombreTabla.Trim <> String.Empty AndAlso CodigoTabla.Trim <> String.Empty
        End Get
    End Property
    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class