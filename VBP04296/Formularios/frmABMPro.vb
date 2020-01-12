Public Class frmABMPro
    Private _proceso As ProSys

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub PasarDatos(proceso As ProSys)
        _proceso = proceso
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click

    End Sub
End Class