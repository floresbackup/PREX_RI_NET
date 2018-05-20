
Module modLocalMain

    Public CONSULTA_SELECCIONADA As Long
    Public FORMATEAR_NUMEROS As Boolean

    Sub Main()
        PrevInstance()
        'Configuración
        LeerXML()
        LeerXMLLocal()

        CulturaActual = System.Threading.Thread.CurrentThread.CurrentCulture
        CulturaCargarTextos(CulturaActual.ToString)


        Dim frmMain As New frmMain
        frmMain.ShowDialog()
    End Sub

    Private Sub PrevInstance()

        Dim MisProcesos() As Process

        MisProcesos = Process.GetProcessesByName(Application.ProductName.ToString)

        If MisProcesos.Length > 1 Then
            MessageBox.Show("Esta aplicación ya se encuentra activa")
            End
        End If

    End Sub

    Public Sub LeerXMLLocal()
        Try

            Dim sRuta As String
            Dim oConfigLocal As New dsConfig

            sRuta = CARPETA_LOCAL & NOMBRE_INI_LOCAL

            'If Not IO.File.Exists(sRuta) Then
            '    GuardarXMLLocal()
            'End If

            If IO.File.Exists(sRuta) Then
                oConfigLocal.ReadXml(sRuta)

                For Each row As DataRow In oConfigLocal.Tables("CONFIG").Rows

                    Select Case row("NOMBRE").ToString

                        Case "FORMATEAR_NUMEROS"
                            FORMATEAR_NUMEROS = Boolean.Parse(row("FORMATEAR_NUMEROS").ToString)

                    End Select

                Next

            End If

        Catch ex As Exception
            TratarError(ex, "LeerXMLLocal")
        End Try

    End Sub




End Module
