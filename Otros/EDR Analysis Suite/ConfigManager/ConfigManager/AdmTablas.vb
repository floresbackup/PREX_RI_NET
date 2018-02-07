Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading

Public Class AdmTablas

    Private sConnectionString As String

    Public Property ConnectionString() As String
        Get
            Return sConnectionString
        End Get

        Set(ByVal sConnString As String)
            sConnectionString = sConnString
        End Set
    End Property

    Public Function AbrirDatasetNativo(ByVal sSQL As String, Optional ByVal bAsincrono As Boolean = True) As System.Data.DataSet

        Dim oConn As SqlConnection
        Dim oResult As IAsyncResult
        Dim oAdapter As SqlDataAdapter

        CONSULTA_CANCELADA = False

        Dim ds As DataSet

        Try

            oConn = New SqlConnection
            oAdapter = New SqlDataAdapter(sSQL, oConn)

            oConn.ConnectionString = ConnectionString
            oConn.Open()

            oResult = oAdapter.SelectCommand.BeginExecuteReader

            While Not oResult.IsCompleted
                Application.DoEvents()

                If CONSULTA_CANCELADA Then
                    oAdapter.SelectCommand.Cancel()
                End If
            End While

            oAdapter.SelectCommand.EndExecuteReader(oResult).Close()

            'frmProcesando.DeshabilitarCancelacion()
            'frmProcesando.Refresh()

            If CONSULTA_CANCELADA Then
                ds = Nothing
            Else
                ds = New DataSet
                oAdapter.Fill(ds)
            End If
            
            Return ds

        Catch ex As Exception
            TratarError(ex)
            Return Nothing

        End Try

    End Function

    Public Function AbrirDataset(ByVal sSQL As String, Optional ByRef oDa As OleDb.OleDbDataAdapter = Nothing) As System.Data.DataSet

        Dim oConn As OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim ds As System.Data.DataSet

        oConn = New OleDb.OleDbConnection
        oConn.ConnectionString = ConnectionString
        oConn.Open()

        da = New OleDb.OleDbDataAdapter(sSQL, oConn)

        ds = New DataSet

        da.Fill(ds)
        oDa = da
        Return ds

    End Function

    Public Function EjecutarComandoSQLNativo(ByVal sSQL As String) As Boolean

        Dim oConn As SqlConnection
        Dim oCommand As SqlCommand
        Dim oResult As IAsyncResult
        Dim iRows As Integer

        Try

            oConn = New SqlConnection
            oCommand = New SqlCommand(sSQL, oConn)

            oConn.ConnectionString = ConnectionString
            oConn.Open()

            'oResult = oCommand.BeginExecuteNonQuery

            'While Not oResult.IsCompleted
            'Application.DoEvents()
            'End While

            'oCommand.EndExecuteNonQuery(oResult)

            iRows = oCommand.ExecuteNonQuery

            Return iRows

        Catch ex As Exception

            TratarError(ex)

        End Try

    End Function

    Public Function EjecutarComandoSQL(ByVal sSQL As String, Optional ByRef sErrores As String = "") As Boolean

        Dim oConn As OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim ds As System.Data.DataSet

        Try

            oConn = New OleDb.OleDbConnection
            oConn.ConnectionString = ConnectionString
            oConn.Open()

            da = New OleDb.OleDbDataAdapter(sSQL, oConn)
            ds = New DataSet

            da.Fill(ds)
            Return True

        Catch ex As Exception
            sErrores = ex.Message
            Return False
        End Try

    End Function

    Public Function ProximoID(ByVal sTabla As String, ByVal sCampoClave As String, Optional ByVal sFiltroWhere As String = vbNullString) As Long

        Dim sSQL As String
        Dim ds As DataSet

        sSQL = "SELECT  MAX(" & sCampoClave & ") " & _
               "FROM    " & sTabla & " "

        If sFiltroWhere <> vbNullString Then
            sSQL = sSQL & "WHERE " & sFiltroWhere
        End If

        Try

            ds = AbrirDataset(sSQL)

            With ds.Tables(0)
                If .Rows.Count > 0 Then
                    Return .Rows(0).Item(0) + 1
                Else
                    Return 1
                End If
            End With

        Catch ex As Exception
            Return 0
        End Try

    End Function
    
End Class
