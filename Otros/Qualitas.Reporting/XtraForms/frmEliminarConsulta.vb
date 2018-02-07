Public Class frmEliminarConsulta 

    Private CODIGO_CONSULTA As Long
    Private NOMBRE_CONSULTA As String

    Public Sub New(ByVal nCodigo As Long, ByVal sNombre As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        CODIGO_CONSULTA = nCodigo
        NOMBRE_CONSULTA = sNombre
        lblNombreConsulta.Text = sNombre

        LocalizarFormulario()

    End Sub

    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionEliminarConsulta)

        lblWarning01.Text = DescripcionCadena(Cadenas.CDN_frmEliminarConsulta_Warning01)
        lblWarning02.Text = DescripcionCadena(Cadenas.CDN_frmEliminarConsulta_Warning02)

        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub Eliminar()

        Dim sSQL As String
        Dim oAdmTablas As New AdmTablas

        oAdmTablas.ConnectionString = CONN_LOCAL

        sSQL = ""
        sSQL = sSQL & "DELETE FROM CONRES WHERE CR_CODCON = " & CODIGO_CONSULTA & " " & vbCrLf
        sSQL = sSQL & "DELETE FROM CONFOR WHERE CF_CODCON = " & CODIGO_CONSULTA & " " & vbCrLf
        sSQL = sSQL & "DELETE FROM CONSEG WHERE CS_CODCON = " & CODIGO_CONSULTA & " " & vbCrLf
        sSQL = sSQL & "DELETE FROM CONDET WHERE CD_CODCON = " & CODIGO_CONSULTA & " " & vbCrLf
        sSQL = sSQL & "DELETE FROM CONVAR WHERE CV_CODCON = " & CODIGO_CONSULTA & " " & vbCrLf
        sSQL = sSQL & "DELETE FROM FAVORI WHERE FV_CODCON = " & CODIGO_CONSULTA & " " & vbCrLf
        sSQL = sSQL & "DELETE FROM DICDAT WHERE DD_CODCON = " & CODIGO_CONSULTA & " " & vbCrLf
        sSQL = sSQL & "DELETE FROM INHABI WHERE IH_CODCON = " & CODIGO_CONSULTA & " " & vbCrLf
        sSQL = sSQL & "DELETE FROM REPORT WHERE RP_CODCON = " & CODIGO_CONSULTA & " " & vbCrLf
        sSQL = sSQL & "DELETE FROM CONLAY WHERE CL_CODCON = " & CODIGO_CONSULTA & " " & vbCrLf

        Try

            Cursor = Cursors.WaitCursor
            oAdmTablas.EjecutarComandoSQL(sSQL)
            frmMainX.CargarTree()
            Cursor = Cursors.Default
            Me.Close()

        Catch ex As Exception
            Cursor = Cursors.Default
            TratarError(ex)
        End Try


    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Eliminar()
    End Sub
End Class