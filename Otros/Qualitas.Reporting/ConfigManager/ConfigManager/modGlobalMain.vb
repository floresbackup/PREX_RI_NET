Module modGlobalMain

    Public CONN_LOCAL As String
    ' Variables para generar algoritmos
    Public SERVER_NAME As String
    Public SERVER_EDITION As String
    Public SERVER_VERSION As String

    ' Keys
    Public AUTHENTICATION_KEY As String
    Public LICENSE_KEY_OK As String
    Public LICENSE_KEY As String
    Public MODO_DEMO As Boolean

    ' Otras
    Public CONSULTA_CANCELADA As Boolean

    Public Sub TratarError(ByRef oEx As Exception)

        MsgBox(oEx.Message, MsgBoxStyle.Exclamation, Application.ProductName)

    End Sub

    Public Sub MensajeInformacion(ByVal sMensaje As String)

        MessageBox.Show(sMensaje, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Public Sub MensajeError(ByVal sMensaje As String)

        MessageBox.Show(sMensaje, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    Public Function Pregunta(ByVal sMensaje As String) As DialogResult

        Return MessageBox.Show(sMensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    End Function

End Module
