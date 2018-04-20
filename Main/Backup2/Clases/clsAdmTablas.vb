Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
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

   Public Function AbrirDatasetNativo(ByVal sSQL As String, _
                                      Optional ByVal bAsincrono As Boolean = True, _
                                      Optional ByRef sErrorText As String = "") As System.Data.DataSet

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

         If CONSULTA_CANCELADA Then
            ds = Nothing
         Else
            ds = New DataSet
            oAdapter.Fill(ds)
         End If

         Return ds

      Catch ex As Exception
         TratarError(ex)
         sErrorText = ex.Message
         Return Nothing

      End Try

   End Function

   Public Function AbrirDatasetOracleNativo(ByVal sSQL As String, _
                                            Optional ByRef sErrorText As String = "") As System.Data.DataSet

      Dim oConn As OracleConnection
      Dim oAdapter As OracleDataAdapter
      Dim ds As DataSet

      Try

         oConn = New OracleConnection
         oAdapter = New OracleDataAdapter(sSQL, oConn)

         oConn.ConnectionString = ConnectionString
         oConn.Open()

         oAdapter.SelectCommand.ExecuteReader()

         ds = New DataSet
         oAdapter.Fill(ds)

         Return ds

      Catch ex As Exception
         TratarError(ex)
         sErrorText = ex.Message
         Return Nothing

      End Try

   End Function

   Public Function AbrirDatasetODBCNativo(ByVal sSQL As String, _
                                          Optional ByRef sErrorText As String = "") As System.Data.DataSet

      Dim oConn As Odbc.OdbcConnection
      Dim oAdapter As Odbc.OdbcDataAdapter
      Dim ds As DataSet

      Try

         oConn = New Odbc.OdbcConnection
         oAdapter = New Odbc.OdbcDataAdapter(sSQL, oConn)

         oConn.ConnectionString = ConnectionString
         oConn.Open()

         oAdapter.SelectCommand.ExecuteReader()

         ds = New DataSet
         oAdapter.Fill(ds)

         Return ds

      Catch ex As Exception
         TratarError(ex)
         sErrorText = ex.Message
         Return Nothing

      End Try

   End Function

   Public Function AbrirDataset(ByVal sSQL As String, _
                                Optional ByRef oDa As OleDb.OleDbDataAdapter = Nothing, _
                                Optional ByRef sErrorText As String = "") As System.Data.DataSet

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
         oDa = da
         Return ds

      Catch ex As Exception
         sErrorText = ex.Message
         Return Nothing
      End Try

   End Function

   Public Function EjecutarComandoSQLNativo(ByVal sSQL As String) As Boolean

      Dim oConn As SqlConnection
      Dim oCommand As SqlCommand
      'Dim oResult As IAsyncResult
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

   Public Function EjecutarComandoOracleNativo(ByVal sSQL As String) As Boolean

      Dim oConn As OracleConnection
      Dim oCommand As OracleCommand
      Dim iRows As Integer

      Try

         oConn = New OracleConnection
         oCommand = New OracleCommand(sSQL, oConn)

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

   Public Function EjecutarComandoODBCNativo(ByVal sSQL As String) As Boolean

      Dim oConn As Odbc.OdbcConnection
      Dim oCommand As Odbc.OdbcCommand
      Dim iRows As Integer

      Try

         oConn = New Odbc.OdbcConnection
         oCommand = New Odbc.OdbcCommand(sSQL, oConn)

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

   Public Function EjecutarComandoSQL(ByVal sSQL As String) As Boolean

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
         Return False
      End Try

   End Function

   Public Function EjecutarComandoAsincrono(ByVal sSQL As String, _
                                            Optional ByRef sError As String = "", _
                                            Optional ByRef nFilas As Integer = 0, _
                                            Optional ByRef ds As DataSet = Nothing) As Boolean

      Dim oConn As OleDb.OleDbConnection
      Dim cmd As New OleDb.OleDbCommand


      Try

         oConn = New OleDb.OleDbConnection
         oConn.ConnectionString = ConnectionString
         oConn.Open()

         cmd.CommandText = sSQL
         cmd.Connection = oConn
         cmd.CommandTimeout = 0

         If Not (ds Is Nothing) Then
            Dim oRead As OleDb.OleDbDataReader = cmd.ExecuteReader()
            ds = DataReaderToDataSet(oRead)
            nFilas = ds.Tables(0).Rows.Count
         Else
            nFilas = cmd.ExecuteNonQuery()
         End If

         Return True

      Catch ex As Exception
         sError = ex.Message
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
               If .Rows(0).Item(0) Is DBNull.Value Then
                  Return 1
               Else
                  Return .Rows(0).Item(0) + 1
               End If
            Else
               Return 1
            End If
         End With

      Catch ex As Exception
         Return 0
      End Try

   End Function

   Public Function DevolverValor(ByVal sTabla As String, ByVal sCampo As String, ByVal sCondicion As String, Optional ByVal sDescripcionInexistente As Object = "") As Object

      Dim sSQL As String
      Dim ds As DataSet

      sSQL = "SELECT  " & sCampo & " " & _
             "FROM    " & sTabla & " "

      If sCondicion <> vbNullString Then
         sSQL = sSQL & "WHERE " & sCondicion
      End If

      Try

         ds = AbrirDataset(sSQL)

         With ds.Tables(0)
            If .Rows.Count > 0 Then
               Return .Rows(0).Item(0)
            Else
               Return sDescripcionInexistente
            End If
         End With

      Catch ex As Exception
         Return 0
      End Try

   End Function

   Private Function DataReaderToDataSet(ByVal reader As OleDb.OleDbDataReader) As DataSet

      Dim dataSet As DataSet = New DataSet()
      Dim schemaTable As DataTable = reader.GetSchemaTable()
      Dim dataTable As DataTable = New DataTable()
      Dim intCounter As Integer

      For intCounter = 0 To schemaTable.Rows.Count - 1

         Dim dataRow As DataRow = schemaTable.Rows(intCounter)
         Dim columnName As String = CType(dataRow("ColumnName"), String)
         Dim column As DataColumn = New DataColumn(columnName, CType(dataRow("DataType"), Type))

         dataTable.Columns.Add(column)

      Next

      dataSet.Tables.Add(dataTable)

      While reader.Read()

         Dim dataRow As DataRow = dataTable.NewRow()

         For intCounter = 0 To reader.FieldCount - 1
            dataRow(intCounter) = reader.GetValue(intCounter)
         Next

         dataTable.Rows.Add(dataRow)

      End While

      Return dataSet

   End Function

   Public Function ExisteCampo(ByVal sTabla As String, ByVal sCampo As String)

      Try

         Dim ds As DataSet

         ds = AbrirDataset("SELECT TOP 1 " & sCampo & " FROM " & sTabla)
         ds = Nothing

         Return True

      Catch ex As Exception
         Return False
      End Try

   End Function

   Public Function ExisteTabla(ByVal sTabla As String)

      Try

         Dim ds As DataSet

         ds = AbrirDataset("SELECT TOP 1 * FROM " & sTabla)
         ds = Nothing

         Return True

      Catch ex As Exception
         Return False
      End Try

   End Function

End Class
