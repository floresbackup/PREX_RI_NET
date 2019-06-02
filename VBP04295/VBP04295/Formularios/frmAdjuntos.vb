Imports System.Data.SqlClient
Imports System.IO

Public Class frmAdjuntos
    Private oAdmTablas As New AdmTablas
    Private CLAVE_ADJUNT As String

    Private Declare Function GetWindowsDirectory Lib "kernel32" Alias "GetWindowsDirectoryA" (ByVal lpBuffer As String, ByVal nSize As Long) As Long
    Private Declare Function GetSystemDirectory Lib "kernel32" Alias "GetSystemDirectoryA" (ByVal lpBuffer As String, ByVal nSize As Long) As Long
    Private Declare Function GetTempPath Lib "kernel32" Alias "GetTempPathA" (ByVal nBufferLength As Long, ByVal lpBuffer As String) As Long

    Private ReadOnly Property RowHandleArchivoSeleccionado As Integer
        Get
            If GridView1.SelectedRowsCount = 0 Then Return Integer.MinValue

            Return GridView1.GetRowHandle(GridView1.GetSelectedRows(0))
        End Get
    End Property

    Private ReadOnly Property NombreArchivoSeleccionado As String
        Get
            If GridView1.SelectedRowsCount = 0 Then Return String.Empty

            Return GridView1.GetRowCellValue(RowHandleArchivoSeleccionado, GridView1.Columns.Item("AD_NOMBRE")).ToString()
        End Get
    End Property

    Private ReadOnly Property CodigoArchivoSeleccionado As String
        Get
            If GridView1.SelectedRowsCount = 0 Then Return String.Empty
            Return GridView1.GetRowCellValue(RowHandleArchivoSeleccionado, GridView1.Columns.Item("AD_CODADJ")).ToString()
        End Get
    End Property

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub



    Public Sub PasarDatos(ByVal sClave As String)
        Try
            Me.Cursor = Cursors.WaitCursor
            Try
                oAdmTablas = New AdmTablas
                oAdmTablas.ConnectionString = CONN_LOCAL

                Dim sSQL As String


                CLAVE_ADJUNT = sClave

                sSQL = "SELECT   * " &
                       "FROM     ADJUNT " &
                       "WHERE    AD_CLAVE = '" & CLAVE_ADJUNT & "'"

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

    Private Sub frmAdjuntos_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        oAdmTablas = Nothing
    End Sub

    Private Sub frmAdjuntos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTitulo.Text = "Adjuntar archivos"
        lblSubtitulo.Text = "Agregar, ver o eliminar archivos adjuntos"
    End Sub


    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        VerArchivoAdjunto()
    End Sub

    Private Sub cmdVer_Click(sender As Object, e As EventArgs) Handles cmdVer.Click
        VerArchivoAdjunto()
    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
    Private Sub cmd_Eliminar_Click(sender As Object, e As EventArgs) Handles cmd_Eliminar.Click

        If GridView1.SelectedRowsCount > 0 Then
            If Pregunta("¿ Desea eliminar el documento adjunto ?") = vbYes Then
                EliminarAdjunto()
            End If
        Else
            MensajeInformacion("Noy hay documentos para eliminar.")
        End If

    End Sub


    Private Sub cmdAdjuntar_Click(sender As Object, e As EventArgs) Handles cmdAdjuntar.Click
        Try
            OpenFileDialog1.Filter = "Todos los archivos|*.*"
            OpenFileDialog1.DefaultExt = "*"
            OpenFileDialog1.FileName = ""

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                AdjuntarArchivo(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            TratarError(ex, "cmdAdjuntar_Click")
        End Try
    End Sub
#Region "Metodos"

    Private Function AdjuntarArchivo(ByVal sArchivo As String) As Boolean
        Try
            Dim sSQL As String
            Dim nProx As Long

            INPUT_GENERAL = ""
            Dim frmInp As New frmInputGeneral()
            frmInp.Owner = Me

            frmInp.PasarInfoVentana("Descripción de archivo", "Ingrese la descripción del archivo adjunto")
            frmInp.ShowDialog(Me)

            If Trim(INPUT_GENERAL) = "" Then Exit Function

            Me.Cursor = Cursors.WaitCursor

            nProx = oAdmTablas.ProximoID("ADJUNT", "AD_CODADJ")

            '      sSQL = "INSERT INTO ADJUNT (AD_CODADJ,AD_TIPREG,AD_NROREG,AD_DESCRI,AD_CLAVE ,AD_ARCHIV,AD_NOMBRE)" &
            '          " VALUES (" & nProx & ", 1, 0, '" & INPUT_GENERAL & "', '" & CLAVE_ADJUNT &
            '          "', '" & PutFileInField(sArchivo) & "', '" & Path.GetFileName(sArchivo) & "')"
            '
            Dim cmd As New SqlCommand("INSERT INTO ADJUNT (AD_CODADJ,AD_TIPREG,AD_NROREG,AD_DESCRI,AD_CLAVE ,AD_ARCHIV,AD_NOMBRE) " &
                                      "values (@AD_CODADJ,1,0,@AD_DESCRI,@AD_CLAVE ,@AD_ARCHIV,@AD_NOMBRE)")
            cmd.Parameters.Add("AD_CODADJ", SqlDbType.Int).Value = nProx
            cmd.Parameters.Add("AD_DESCRI", SqlDbType.VarChar, 255).Value = INPUT_GENERAL
            cmd.Parameters.Add("AD_CLAVE", SqlDbType.VarChar, 1000).Value = CLAVE_ADJUNT
            cmd.Parameters.Add("AD_ARCHIV", SqlDbType.Image).Value = System.IO.File.ReadAllBytes(sArchivo)
            cmd.Parameters.Add("AD_NOMBRE", SqlDbType.VarChar, 255).Value = Path.GetFileName(sArchivo)


            oAdmTablas.EjecutarComandoSQL(cmd)
            PasarDatos(CLAVE_ADJUNT)
            Me.Cursor = Cursors.Default

            Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub VerArchivoAdjunto()
        If GridView1.SelectedRowsCount = 0 Then
            MensajeInformacion("Noy hay documentos para visualizar")
            Exit Sub
        End If
        Try
            Dim pathArchivo = IO.Path.GetTempPath() & NombreArchivoSeleccionado

            If ArchivoExiste(pathArchivo) Then Kill(pathArchivo)
            Dim f As Byte() = GridView1.GetRowCellValue(RowHandleArchivoSeleccionado, GridView1.Columns.Item("AD_ARCHIV"))
            GetFileFromField(f, pathArchivo)

            Process.Start(pathArchivo)
        Catch ex As Exception
            TratarError(ex, sCustomError:="Ocurrió un error al intentar mostrar archivo Adjunto")
        End Try
    End Sub

    Private Sub EliminarAdjunto()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim sSQL = "DELETE     " &
               "FROM       ADJUNT " &
               "WHERE      AD_CODADJ = " & CodigoArchivoSeleccionado & " "

            If Not oAdmTablas.EjecutarComandoSQL(sSQL) Then
                MensajeError("Se produjo un error al intentar eliminar el adjunto.")
            End If

            PasarDatos(CLAVE_ADJUNT)

            Me.Cursor = Cursors.Default


        Catch ex As Exception
            TratarError(ex, "EliminarAdjunto")
        End Try

    End Sub

#End Region
End Class