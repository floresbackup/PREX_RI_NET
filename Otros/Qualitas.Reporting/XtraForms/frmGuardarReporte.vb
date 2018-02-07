Public Class frmGuardarReporte 

    Private oAdmTablas As New AdmTablas
    Private nConsultaActual As Long

    Public Sub New(ByVal nCodConsulta As Long, ByVal sFile As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        LocalizarFormulario()
        oAdmTablas.ConnectionString = CONN_LOCAL
        REPORTE_NOMBRE = ""
        nConsultaActual = nCodConsulta
        txtPath.Text = sFile

    End Sub

    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionGuardarInforme)

        lblNombreReporte.Text = DescripcionCadena(Cadenas.CDN_frmGuardarInforme_NombreInforme)
        lblRuta.Text = DescripcionCadena(Cadenas.CDN_frmGuardarInforme_NombreArchivo)
        chkPublico.Text = DescripcionCadena(Cadenas.CDN_frmGuardarInforme_Publico)

        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

    End Sub

    Private Function DatosOK() As Boolean

        If txtNombreReporte.Text.Trim = "" Then
            MensajeError(DescripcionCadena(Cadenas.CDN_frmGuardarInforme_WarningNombreVacio))
            txtNombreReporte.Focus()
            Exit Function
        End If

        If NombreReporteExiste() Then
            MensajeError(DescripcionCadena(Cadenas.CDN_frmGuardarInforme_WarningNombreExiste))
            txtNombreReporte.Focus()
            Exit Function
        End If

        DatosOK = True

    End Function

    Private Function NombreReporteExiste() As Boolean

        Dim sSQL As String
        Dim ds As DataSet

        sSQL = "SELECT  COUNT(1) AS XX_CUENTA " & _
               "FROM    REPORT " & _
               "WHERE   RP_CODUSU = " & USUARIO_ACTUAL & " " & _
               "AND     RP_CODCON = " & nConsultaActual & " " & _
               "AND     RP_NOMBRE = '" & txtNombreReporte.Text.Trim & "'"

        Try

        
            ds = oAdmTablas.AbrirDataset(sSQL)

            With ds.Tables(0)

                If .Rows.Count > 0 Then
                    Return .Rows(0)("XX_CUENTA") > 0
                End If

            End With

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Function

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If DatosOK() Then
            REPORTE_NOMBRE = txtNombreReporte.Text.Trim
            REPORTE_PUBLICO = chkPublico.Checked
            Me.Close()
        End If
    End Sub
End Class