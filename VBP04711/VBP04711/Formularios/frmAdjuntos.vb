Public Class frmAdjuntos
    Private oAdmTablas As New AdmTablas
    Private CLAVE_ADJUNT1 As String
    Private CLAVE_ADJUNT2 As String


    Private Declare Function GetWindowsDirectory Lib "kernel32" Alias "GetWindowsDirectoryA" (ByVal lpBuffer As String, ByVal nSize As Long) As Long
    Private Declare Function GetSystemDirectory Lib "kernel32" Alias "GetSystemDirectoryA" (ByVal lpBuffer As String, ByVal nSize As Long) As Long
    Private Declare Function GetTempPath Lib "kernel32" Alias "GetTempPathA" (ByVal nBufferLength As Long, ByVal lpBuffer As String) As Long

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


    End Sub



    Public Sub PasarDatos(ByVal sClave1 As String, ByVal sClave2 As String)
        Try
            Me.Cursor = Cursors.WaitCursor
            Try
                oAdmTablas = New AdmTablas
                oAdmTablas.ConnectionString = CONN_LOCAL
                CLAVE_ADJUNT1 = sClave1
                CLAVE_ADJUNT2 = sClave2

                Dim sSQL = "SELECT   * " &
               "FROM     TXTADJ " &
               "WHERE    CAST(SUBSTRING(AD_CLAVE, CHARINDEX('_', AD_CLAVE) + 1, 8) AS DATETIME) >= '" & CLAVE_ADJUNT1 & "' " &
               "AND      CAST(SUBSTRING(AD_CLAVE, CHARINDEX('_', AD_CLAVE) + 1, 8) AS DATETIME) <= '" & CLAVE_ADJUNT2 & "' "
                Dim ds = oAdmTablas.AbrirDataset(sSQL)
                GridControl1.DataSource = ds.Tables(0)
                GridControl1.RefreshDataSource()
                GridControl1.Refresh()

            Catch ex As Exception
                TratarError(ex, "PasarDatos")
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    'Dim c As Integer = ds.Tables("BLOBTest").Rows.Count
    'If c > 0 Then
    'Dim bytBLOBData() As Byte =
    '            ds.Tables("BLOBTest").Rows(c - 1)("BLOBData")
    'Dim stmBLOBData As New MemoryStream(bytBLOBData)
    '        picBLOB.Image = Image.FromStream(stmBLOBData)
    '    End If
    Private Sub frmAdjuntos_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        oAdmTablas = Nothing
    End Sub
    Private Sub frmAdjuntos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTitulo.Text = "Adjuntar archivos"
        lblSubtitulo.Text = "Agregar, ver o eliminar archivos adjuntos"
    End Sub


    'Public Function RutaTemp() As String

    '    Dim sDirWin As String '* 255
    '    Dim nTemp As Long

    '    nTemp = GetTempPath(255, sDirWin)
    '    RutaTemp = Strings.Left(sDirWin, nTemp)
    '    RutaTemp = NormalizarRuta(Trim(RutaTemp))

    'End Function

    Private Sub cmdVer_Click()
        If GridView1.SelectedRowsCount = 0 Then
            MensajeInformacion("Noy hay documentos para visualizar")
            Exit Sub
        End If
        Try

            Dim nRenglon As Long
            Dim r = GridView1.GetRowHandle(GridView1.GetSelectedRows(0))
            Dim nombreArchivo = GridView1.GetRowCellValue(r, GridView1.Columns.Item("AD_NOMBRE")).ToString()
            Dim pathArchivo = IO.Path.GetTempPath() & nombreArchivo

            If ArchivoExiste(pathArchivo) Then Kill(pathArchivo)

            GetFileFromField(GridView1.GetRowCellValue(r, GridView1.Columns.Item("AD_ARCHIV")), pathArchivo)

            Process.Start(pathArchivo)
        Catch ex As Exception
            TratarError(ex, sCustomError:="Ocurrió un error al intentar mostrar archivo TXT")
        End Try


    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        cmdVer_Click()
    End Sub

    Private Sub cmdVer_Click(sender As Object, e As EventArgs) Handles cmdVer.Click
        cmdVer_Click()
    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub


    '    Public Function RutaTemp() As String

    '        Dim sDirWin As String * 255
    'Dim nTemp As Long

    '        nTemp = GetTempPath(255, sDirWin)
    '        RutaTemp = Left(sDirWin, nTemp)
    '        RutaTemp = NormalizarRuta(Trim(RutaTemp))

    '    End Function

End Class