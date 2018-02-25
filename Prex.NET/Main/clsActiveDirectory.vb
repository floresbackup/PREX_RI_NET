Option Strict Off
Option Explicit On

Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.InteropServices
Imports System
Imports System.Windows.Forms
Imports System.DirectoryServices

#Region " Server Information Class "
'*******************************************************************************
'*  ServerInfo Class
'*******************************************************************************
'Class used to return server info
Public NotInheritable Class ServerInfo

    Public Enum PLATFORM_ID As Long
        PLATFORM_ID_DOS = 300
        PLATFORM_ID_OS2 = 400
        PLATFORM_ID_NT = 500
        PLATFORM_ID_OSF = 600
        PLATFORM_ID_VMS = 700
    End Enum

    Protected Structure InfoStruct
        Public is_platformid As Long
        Public is_name As String
        Public is_version_major As Long
        Public is_version_minor As Long
        Public is_type As Long
        Public is_comment As String
    End Structure

    Protected myData As InfoStruct

    Friend Sub New(ByVal p_PlatformID As UInt32, _
                   ByVal p_Name As String, _
                   ByVal p_Version_major As UInt32, _
                   ByVal p_Version_minor As UInt32, _
                   ByVal p_Type As UInt32, _
                   ByVal p_Comment As String)

        With myData
            .is_platformid = Long.Parse(p_PlatformID.ToString)
            .is_name = p_Name
            .is_version_major = Long.Parse(p_Version_major.ToString)
            .is_version_minor = Long.Parse(p_Version_minor.ToString)
            .is_type = Long.Parse(p_Type.ToString)
            .is_comment = p_Comment
        End With
    End Sub

    Public ReadOnly Property Platform() As PLATFORM_ID
        Get
            Platform = myData.is_platformid
        End Get
    End Property

    Public ReadOnly Property Name() As String
        Get
            Name = myData.is_name
        End Get
    End Property

    Public ReadOnly Property VersionMajor() As Long
        Get
            VersionMajor = myData.is_version_major
        End Get
    End Property

    Public ReadOnly Property VersionMinor() As Long
        Get
            VersionMinor = myData.is_version_minor
        End Get
    End Property

    Public ReadOnly Property Type() As Long
        Get
            Type = myData.is_type
        End Get
    End Property

    Public ReadOnly Property Comment() As String
        Get
            Comment = myData.is_comment
        End Get
    End Property
End Class

#End Region

#Region " SQL Connector Class "
Public Class SQLConnector
    Inherits Object
    Implements IDisposable

#Region " API Declarations - GetSQLServers   "
    'Enumerators
    Public Enum EServerTypes
        SV_TYPE_WORKSTATION = &H1
        SV_TYPE_SERVER = &H2
        SV_TYPE_SQLSERVER = &H4
        SV_TYPE_DOMAIN_CTRL = &H8
        SV_TYPE_DOMAIN_BAKCTRL = &H10
        SV_TYPE_TIME_SOURCE = &H20
        SV_TYPE_AFP = &H40
        SV_TYPE_NOVELL = &H80
        SV_TYPE_DOMAIN_MEMBER = &H100
        SV_TYPE_PRINTQ_SERVER = &H200
        SV_TYPE_DIALIN_SERVER = &H400
        SV_TYPE_XENIX_SERVER = &H800
        SV_TYPE_SERVER_UNIX = SV_TYPE_XENIX_SERVER
        SV_TYPE_NT = &H1000
        SV_TYPE_WFW = &H2000
        SV_TYPE_SERVER_MFPN = &H4000
        SV_TYPE_SERVER_NT = &H8000
        SV_TYPE_POTENTIAL_BROWSER = &H10000
        SV_TYPE_BACKUP_BROWSER = &H20000
        SV_TYPE_MASTER_BROWSER = &H40000
        SV_TYPE_DOMAIN_MASTER = &H80000
        SV_TYPE_SERVER_OSF = &H100000
        SV_TYPE_SERVER_VMS = &H200000
        SV_TYPE_WINDOWS = &H400000
        SV_TYPE_DFS = &H800000
        SV_TYPE_CLUSTER_NT = &H1000000
        SV_TYPE_TERMINALSERVER = &H2000000
        SV_TYPE_CLUSTER_VS_NT = &H4000000
        SV_TYPE_DCE = &H10000000
        SV_TYPE_ALTERNATE_XPORT = &H20000000
        SV_TYPE_LOCAL_LIST_ONLY = &H40000000
        SV_TYPE_DOMAIN_ENUM = &H80000000
        SV_TYPE_ALL = &HFFFFFFFF
    End Enum

    <StructLayout(LayoutKind.Sequential)> Protected Structure SERVER_INFO_101
        <MarshalAs(System.Runtime.InteropServices.UnmanagedType.U4)> _
        Public sv101_platform_id As UInt32
        <MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)> _
        Public sv101_name As String
        <MarshalAs(System.Runtime.InteropServices.UnmanagedType.U4)> _
        Public sv101_version_major As UInt32
        <MarshalAs(System.Runtime.InteropServices.UnmanagedType.U4)> _
        Public sv101_version_minor As UInt32
        <MarshalAs(System.Runtime.InteropServices.UnmanagedType.U4)> _
        Public sv101_type As UInt32
        <MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)> _
        Public sv101_comment As String
    End Structure

    Protected Enum NERR
        NERR_Success = 0 ' Success 
        ERROR_MORE_DATA = 234 ' dderror
        ERROR_NO_BROWSER_SERVERS_FOUND = 6118
        'The system call level is not correct.
        ERROR_INVALID_LEVEL = 124
        'Access is denied.
        ERROR_ACCESS_DENIED = 5
        'The parameter is incorrect.
        ERROR_INVALID_PARAMETER = 87
        'Not enough storage to process this command.
        ERROR_NOT_ENOUGH_MEMORY = 8
        'The network is busy.
        ERROR_NETWORK_BUSY = 54
        'The network path was not found.
        ERROR_BAD_NETPATH = 53
        'The network is not present or not started.
        ERROR_NO_NETWORK = 1222
        'Handle is in an invalid state.
        ERROR_INVALID_HANDLE_STATE = 1609
        'An extended error has occurred.
        ERROR_EXTENDED_ERROR = 1208
    End Enum

    'API Declarations
    Protected Declare Function NetServerEnum _
       Lib "netapi32.dll" Alias "NetServerEnum" ( _
          <MarshalAs(UnmanagedType.LPWStr)> ByVal servername As String, _
          ByVal level As Integer, _
          ByRef bufptr As IntPtr, _
          ByVal prefmaxlen As Integer, _
          ByRef entriesread As Integer, _
          ByRef totalentries As Integer, _
          ByVal servertype As EServerTypes, _
          <MarshalAs(UnmanagedType.LPWStr)> ByVal domain As String, _
          ByVal resume_handle As Integer _
          ) As Integer
    Protected Declare Function NetApiBufferFree _
       Lib "netapi32.dll" Alias "NetApiBufferFree" ( _
          ByVal buffer As IntPtr _
          ) As Integer
#End Region

#Region " PROTECTED - Variable declarations  "
    Private m_TimeOut As Long = 30
    Private m_ServerName As String
    Private m_UserID As String
    Private m_Password As String
    Private m_DatabaseName As String
    Private m_VersionString As String

    Private m_DatabaseStarted As Boolean

    Private WithEvents m_ConSQL As SqlClient.SqlConnection
#End Region

#Region " Event declarations                 "
    Public Event ConnectionStateChange(ByVal sender As Object, ByVal e As System.Data.StateChangeEventArgs)
    Public Event ConnectionInfoMessage(ByVal sender As Object, ByVal e As System.Data.SqlClient.SqlInfoMessageEventArgs)
    Public Event DatabaseStarting(ByVal sender As Object, ByRef interrupt As Boolean)
    Public Event DatabaseStopping(ByVal sender As Object, ByRef interrupt As Boolean)
    Public Event DatabaseStarted(ByVal sender As Object)
    Public Event DatabaseStopped(ByVal sender As Object)
#End Region


    Public Sub New()
        m_ServerName = ""
        m_DatabaseName = ""
        m_UserID = ""
        m_Password = ""

        m_DatabaseStarted = False
    End Sub

    Public Sub New(ByVal SQLServerName As String, _
                   ByVal SQLDatabaseName As String, _
                   ByVal SQLUserID As String, _
                   ByVal SQLPassword As String, _
                   Optional ByVal StartDB As Boolean = False)

        m_ServerName = SQLServerName
        m_DatabaseName = SQLDatabaseName
        m_UserID = SQLUserID
        m_Password = SQLPassword

        m_DatabaseStarted = False

        If StartDB Then
            m_DatabaseStarted = StartDatabase(m_ServerName, m_DatabaseName, m_UserID, m_Password)
        End If
    End Sub

    Protected Overrides Sub Finalize()
        'Do the finalising here
        Dispose()
        MyBase.Finalize()
    End Sub

    Public Sub Dispose() Implements System.IDisposable.Dispose
        'Do the disposing here
        'Dispose of the connection object
        If Not m_ConSQL Is Nothing Then
            If Not (m_ConSQL.State = ConnectionState.Closed) Then
                m_ConSQL.Close()
            End If
            m_ConSQL.Dispose()
        End If
    End Sub

    Public ReadOnly Property IsDatabaseStarted() As Boolean
        Get
            IsDatabaseStarted = m_DatabaseStarted
        End Get
    End Property

    Public ReadOnly Property ServerName() As String
        Get
            ServerName = m_ServerName
        End Get
    End Property

    Public ReadOnly Property UserName() As String
        Get
            UserName = m_UserID
        End Get
    End Property

    Public ReadOnly Property Password() As String
        Get
            Password = m_Password
        End Get
    End Property

    Public ReadOnly Property DatabaseName() As String
        Get
            DatabaseName = m_DatabaseName
        End Get
    End Property

    Public Property ConnectionTimeout() As Long
        Get
            ConnectionTimeout = m_TimeOut
        End Get
        Set(ByVal Value As Long)
            m_TimeOut = Value
        End Set
    End Property

    Public ReadOnly Property ServerVersion() As String
        Get
            ServerVersion = m_VersionString
        End Get
    End Property


    Public Function StartSaving(ByVal strSQl As String, Optional ByVal SQLServerName As String = "", _
                                    Optional ByVal SQLDatabaseName As String = "", _
                                    Optional ByVal SQLUserID As String = "", _
                                    Optional ByVal SQLPassword As String = "" _
                                    ) As Boolean
        Dim sConnectionString As String
        Dim bInterrupt As Boolean = False

        'Raise an event to inform the caller that the DB
        'is about to start
        RaiseEvent DatabaseStarting(Me, bInterrupt)
        If bInterrupt Then
            StartSaving = False
            Exit Function
        End If

        If ((Len(SQLServerName) = 0) Or _
           (Len(SQLDatabaseName) = 0) Or _
           (Len(SQLUserID) = 0)) Then

            'All the parameters were empty

            If ((Len(m_ServerName) = 0) Or _
               (Len(m_DatabaseName) = 0) Or _
               (Len(m_UserID) = 0)) Then

                'All the class properties re empty too
                StartSaving = False
                m_DatabaseStarted = False
                Exit Function
            End If
        Else
            'Save the parameters passed to the class properties
            m_ServerName = SQLServerName
            m_DatabaseName = SQLDatabaseName
            m_UserID = SQLUserID
            m_Password = SQLPassword
        End If

        sConnectionString = "Data Source=" & m_ServerName & _
                            ";Initial Catalog=" & m_DatabaseName & _
                            ";User Id=" & m_UserID & _
                            ";Password=" & m_Password & _
                            ";Connect Timeout=" & m_TimeOut.ToString
        m_ConSQL = New SqlClient.SqlConnection(sConnectionString)

        Try
            m_ConSQL.Open()
            m_VersionString = m_ConSQL.ServerVersion()
            StartSaving = True
            m_DatabaseStarted = True

            'Raise an event to inform the caller that the DB
            'has started
            RaiseEvent DatabaseStarted(Me)

        Catch ex As Exception
            If Not (m_ConSQL.State = ConnectionState.Closed) Then
                m_ConSQL.Close()
            End If
            m_ConSQL.Dispose()

            StartSaving = False
            m_DatabaseStarted = False

            Throw
        End Try

    End Function

    '*******************************************
    '  StartDatabase
    '*******************************************
    Public Function StartDatabase(Optional ByVal SQLServerName As String = "", _
                                  Optional ByVal SQLDatabaseName As String = "", _
                                  Optional ByVal SQLUserID As String = "", _
                                  Optional ByVal SQLPassword As String = "" _
                                  ) As Boolean
        Dim sConnectionString As String
        Dim bInterrupt As Boolean = False

        'Raise an event to inform the caller that the DB
        'is about to start
        RaiseEvent DatabaseStarting(Me, bInterrupt)
        If bInterrupt Then
            StartDatabase = False
            Exit Function
        End If

        If ((Len(SQLServerName) = 0) Or _
           (Len(SQLDatabaseName) = 0) Or _
           (Len(SQLUserID) = 0)) Then

            'All the parameters were empty

            If ((Len(m_ServerName) = 0) Or _
               (Len(m_DatabaseName) = 0) Or _
               (Len(m_UserID) = 0)) Then

                'All the class properties re empty too
                StartDatabase = False
                m_DatabaseStarted = False
                Exit Function
            End If
        Else
            'Save the parameters passed to the class properties
            m_ServerName = SQLServerName
            m_DatabaseName = SQLDatabaseName
            m_UserID = SQLUserID
            m_Password = SQLPassword
        End If

        sConnectionString = "Data Source=" & m_ServerName & _
                            ";Initial Catalog=" & m_DatabaseName & _
                            ";User Id=" & m_UserID & _
                            ";Password=" & m_Password & _
                            ";Connect Timeout=" & m_TimeOut.ToString
        m_ConSQL = New SqlClient.SqlConnection(sConnectionString)
        m_ConSQL.CreateCommand()
        Try
            m_ConSQL.Open()
            m_VersionString = m_ConSQL.ServerVersion()
            StartDatabase = True
            m_DatabaseStarted = True

            'Raise an event to inform the caller that the DB
            'has started
            RaiseEvent DatabaseStarted(Me)

        Catch ex As Exception
            If Not (m_ConSQL.State = ConnectionState.Closed) Then
                m_ConSQL.Close()
            End If
            m_ConSQL.Dispose()

            StartDatabase = False
            m_DatabaseStarted = False

            Throw
        End Try

    End Function

    '*******************************************
    '  StopDatabase
    '*******************************************
    Public Function StopDatabase() As Boolean
        Dim bInterrupt As Boolean = False

        'Raise an event to inform the caller that the DB
        'is about to stop
        RaiseEvent DatabaseStopping(Me, bInterrupt)
        If bInterrupt Then
            StopDatabase = False
            Exit Function
        End If

        Dispose()
        StopDatabase = True
        m_DatabaseStarted = False

        'Raise an event to inform the caller that the DB
        'has stopped
        RaiseEvent DatabaseStopped(Me)
    End Function


    Public Overloads Shared Function GetSQLServers(ByVal ServerType As EServerTypes, ByVal Domain As String) As ServerInfo()
        Dim si As SERVER_INFO_101
        Dim ppSVINFO As New IntPtr
        Dim etriesread As Integer = 0
        Dim totalentries As Integer = 0
        Dim oEntries() As ServerInfo

        Try
            If NetServerEnum(Nothing, 101, ppSVINFO, -1, etriesread, totalentries, ServerType, Domain, 0) = 0 Then
                Dim ptr As Int32 = ppSVINFO.ToInt32()

                ReDim oEntries(etriesread - 1)
                Dim i As Integer
                For i = 0 To etriesread - 1
                    si = CType(Marshal.PtrToStructure(New IntPtr(ptr), GetType(SERVER_INFO_101)), SERVER_INFO_101)
                    oEntries(i) = New ServerInfo(si.sv101_platform_id, _
                                                 si.sv101_name, _
                                                 si.sv101_version_major, _
                                                 si.sv101_version_minor, _
                                                 si.sv101_type, _
                                                 si.sv101_comment)
                    ptr += Marshal.SizeOf(si)
                Next i
            End If
            NetApiBufferFree(ppSVINFO)

            Return oEntries
        Catch ex As Exception
            Throw New SQLDLGeneralException("Error returning server names!", ex)
        End Try
    End Function

    Public Overloads Shared Function GetSQLServers(ByVal ServerType As EServerTypes) As ServerInfo()
        Return GetSQLServers(ServerType, Nothing)
    End Function

    Private Sub m_ConSQL_StateChange(ByVal sender As Object, ByVal e As System.Data.StateChangeEventArgs) Handles m_ConSQL.StateChange
        RaiseEvent ConnectionStateChange(Me, e)
    End Sub

    Private Sub m_ConSQL_InfoMessage(ByVal sender As Object, ByVal e As System.Data.SqlClient.SqlInfoMessageEventArgs) Handles m_ConSQL.InfoMessage
        RaiseEvent ConnectionInfoMessage(Me, e)
    End Sub

    '*******************************************
    '  DatabaseExist
    '*******************************************
    'Checks if a database exists on the current server
    Public Function DatabaseExist(ByVal DatabaseName As String) As Boolean
        If DatabaseName.Length = 0 Then
            DatabaseExist = False
            Throw New SQLDLGeneralException("No Database name specified!")
            Exit Function
        End If

        If m_ServerName.Length > 0 Then
            Dim oSQLConnection As New SqlClient.SqlConnection
            Dim oSQLCommand As New SqlClient.SqlCommand
            Dim oSQLDataReader As SqlClient.SqlDataReader
            Dim sConnectionString As String

            Try
                DatabaseExist = False
                sConnectionString = "Data Source=" & m_ServerName & _
                                  ";Initial Catalog=master" & _
                                  ";User Id=" & m_UserID & _
                                  ";Password=" & m_Password & _
                                  ";Connect Timeout=" & m_TimeOut.ToString

                oSQLConnection.ConnectionString = sConnectionString
                oSQLConnection.Open()

                oSQLCommand.CommandText = "sp_databases"
                oSQLCommand.CommandType = CommandType.StoredProcedure
                oSQLCommand.Connection = oSQLConnection
                'Get the Data reader
                oSQLDataReader = oSQLCommand.ExecuteReader()
                While oSQLDataReader.Read()
                    If DatabaseName = oSQLDataReader.GetString(0) Then
                        DatabaseExist = True
                    End If
                End While
            Catch ex As Exception
                DatabaseExist = False
                Throw New SQLDLGeneralException("General Error.", ex)
            Finally
                'Close and dispose of the connection
                If Not (oSQLConnection.State = ConnectionState.Closed) Then
                    oSQLConnection.Close()
                End If
                oSQLConnection.Dispose()
                'Dispose of the command
                oSQLCommand.Dispose()
                'Close the reader if it is open
                If Not (oSQLDataReader Is Nothing) Then
                    oSQLDataReader.Close()
                End If
            End Try
        Else
            DatabaseExist = False
            Throw New SQLDLNoServerSpecifiedException("No Server specified!", _
                  Me.GetType.ToString & ".DatabaseExist()")
        End If
    End Function

    '*******************************************
    '  GetDatabaseLocation
    '*******************************************
    'Gets the physical disc location of a SQL database
    Public Function GetDatabaseLocation(ByVal DatabaseName As String) As String
        If DatabaseName.Length = 0 Then
            GetDatabaseLocation = ""
            Throw New SQLDLGeneralException("No Database name specified!")
            Exit Function
        End If

        If m_ServerName.Length > 0 Then
            Dim oSQLConnection As New SqlClient.SqlConnection
            Dim oSQLCommand As New SqlClient.SqlCommand
            Dim oSQLDataReader As SqlClient.SqlDataReader
            Dim sConnectionString As String

            Try
                GetDatabaseLocation = ""
                sConnectionString = "Data Source=" & m_ServerName & _
                                  ";Initial Catalog=master" & _
                                  ";User Id=" & m_UserID & _
                                  ";Password=" & m_Password & _
                                  ";Connect Timeout=" & m_TimeOut.ToString

                oSQLConnection.ConnectionString = sConnectionString
                oSQLConnection.Open()

                oSQLCommand.CommandText = "SELECT filename FROM sysdatabases WHERE name = '" & DatabaseName & "'"
                oSQLCommand.CommandType = CommandType.Text
                oSQLCommand.Connection = oSQLConnection
                'Get the Data reader
                oSQLDataReader = oSQLCommand.ExecuteReader()
                oSQLDataReader.Read()
                GetDatabaseLocation = New IO.FileInfo(oSQLDataReader.GetString(oSQLDataReader.GetOrdinal("filename"))).DirectoryName
            Catch ex As Exception
                GetDatabaseLocation = ""
                Throw New SQLDLGeneralException("General Error.", ex)
            Finally
                'Close and dispose of the connection
                If Not (oSQLConnection.State = ConnectionState.Closed) Then
                    oSQLConnection.Close()
                End If
                oSQLConnection.Dispose()
                'Dispose of the command
                oSQLCommand.Dispose()
                'Close the reader if it is open
                If Not (oSQLDataReader Is Nothing) Then
                    oSQLDataReader.Close()
                End If
            End Try
        Else
            GetDatabaseLocation = ""
            Throw New SQLDLNoServerSpecifiedException("No Server specified!", _
                  Me.GetType.ToString & ".GetDatabaseLocation()")
        End If

    End Function

    '*******************************************
    '  GetDataAdapter
    '*******************************************
    'Returns a DataAdapter created using a SELECT T-SQL script
    Public Function GetDataAdapter(ByVal SelectSQL As String, ByVal CommandType As System.Data.CommandType) As System.Data.SqlClient.SqlDataAdapter
        If SelectSQL.Length = 0 Then
            GetDataAdapter = Nothing
            Throw New SQLDLGeneralException("No T-SQL script specified!")
            Exit Function
        End If

        If m_DatabaseStarted Then
            Dim oDC As New SqlClient.SqlCommand(SelectSQL)
            oDC.CommandType = CommandType
            oDC.Connection = m_ConSQL
            Dim oDA As New SqlClient.SqlDataAdapter(oDC)
            oDC.Dispose()

            Return oDA
        Else
            Throw New SQLDLDatabaseNotStartedException("Database not yet started!", _
                  Me.GetType.ToString & ".GetDataAdapter()")
        End If

    End Function

    '*******************************************
    '  StartTransaction
    '*******************************************
    'Returns a SqlTransaction object
    Public Overloads Function StartTransaction() As System.Data.SqlClient.SqlTransaction
        StartTransaction = m_ConSQL.BeginTransaction()
    End Function
    Public Overloads Function StartTransaction(ByVal Name As String) As System.Data.SqlClient.SqlTransaction
        StartTransaction = m_ConSQL.BeginTransaction(Name)
    End Function

    '*******************************************
    '  StartAndAttachTransaction
    '*******************************************
    'Attaches a SqlTransaction object to a supplied command object
    Public Overloads Sub StartAndAttachTransaction(ByRef Command As SqlClient.SqlCommand)
        StartAndAttachTransaction(Command, "")
    End Sub
    Public Overloads Sub StartAndAttachTransaction(ByRef Command As SqlClient.SqlCommand, ByVal Name As String)
        If Command Is Nothing Then
            Command = New SqlClient.SqlCommand
        End If
        If Name = "" Then
            Command.Transaction = m_ConSQL.BeginTransaction()
        Else
            Command.Transaction = m_ConSQL.BeginTransaction(Name)
        End If
    End Sub

    '*******************************************
    '  GetDatabases
    '*******************************************
    'Gets the database names listed on the server
    Public Overloads Shared Function GetDatabases(ByVal ServerName As String, ByVal Username As String, ByVal Password As String) As String()
        Dim sNames(0) As String

        If ServerName.Length > 0 Then
            Dim oSQLConnection As New SqlClient.SqlConnection
            Dim oSQLCommand As New SqlClient.SqlCommand
            Dim oSQLDataReader As SqlClient.SqlDataReader
            Dim sConnectionString As String

            Try
                sConnectionString = "Data Source=" & ServerName & _
                                  ";Initial Catalog=master" & _
                                  ";User Id=" & Username & _
                                  ";Password=" & Password & _
                                  ";Connect Timeout=15"

                oSQLConnection.ConnectionString = sConnectionString
                oSQLConnection.Open()

                oSQLCommand.CommandText = "sp_databases"
                oSQLCommand.CommandType = CommandType.StoredProcedure
                oSQLCommand.Connection = oSQLConnection
                'Get the Data reader
                oSQLDataReader = oSQLCommand.ExecuteReader()

                Dim i As Long = 0
                While oSQLDataReader.Read()
                    ReDim Preserve sNames(i)
                    sNames(i) = oSQLDataReader.GetString(oSQLDataReader.GetOrdinal("DATABASE_NAME"))
                    i += 1
                End While
            Catch ex As SqlClient.SqlException
                ReDim sNames(0)
                sNames(0) = ""
                GetDatabases = sNames
                'Just pass the current exception on
                Throw
            Finally
                'Close and dispose of the connection
                If Not (oSQLConnection.State = ConnectionState.Closed) Then
                    oSQLConnection.Close()
                End If
                oSQLConnection.Dispose()
                'Dispose of the command
                oSQLCommand.Dispose()
                'Close the reader if it is open
                If Not (oSQLDataReader Is Nothing) Then
                    oSQLDataReader.Close()
                End If
                GetDatabases = sNames
            End Try
        Else
            ReDim sNames(0)
            sNames(0) = ""
            GetDatabases = sNames
            Throw New SQLDLNoServerSpecifiedException("No Server specified!", _
                  "DatabaseExist()")
        End If

    End Function

    Public Overloads Shared Function GetDatabases(ByVal ServerName As String) As String()
        Return GetDatabases(ServerName, "sa", String.Empty)
    End Function

    '*******************************************
    '  GetTables
    '*******************************************
    'Gets the database names listed on the server
    Public Function GetTableNames() As String()
        Dim sNames(0) As String

        If Not m_DatabaseStarted Then
            sNames(0) = ""
            GetTableNames = sNames

            Throw New SQLDLDatabaseNotStartedException("Database not started.", _
                  Me.GetType.ToString & ".GetTableNames()")
            Exit Function
        End If

        Dim oSQLCommand As New SqlClient.SqlCommand
        Dim oSQLDataReader As SqlClient.SqlDataReader

        Try
            oSQLCommand.CommandText = "sp_tables"
            oSQLCommand.CommandType = CommandType.StoredProcedure
            oSQLCommand.Connection = m_ConSQL
            'Get the Data reader
            oSQLDataReader = oSQLCommand.ExecuteReader()

            Dim i As Long = 0
            While oSQLDataReader.Read()
                If oSQLDataReader.GetString(oSQLDataReader.GetOrdinal("TABLE_TYPE")) = "TABLE" Then
                    ReDim Preserve sNames(i)
                    sNames(i) = oSQLDataReader.GetString(oSQLDataReader.GetOrdinal("TABLE_NAME"))
                    i += 1
                End If
            End While
        Catch ex As Exception
            ReDim sNames(0)
            sNames(0) = ""
            GetTableNames = sNames
            Throw New SQLDLGeneralException("General Error.", ex)
        Finally
            'Dispose of the command
            oSQLCommand.Dispose()
            'Close the reader if it is open
            If Not (oSQLDataReader Is Nothing) Then
                oSQLDataReader.Close()
            End If
            GetTableNames = sNames
        End Try

    End Function



End Class
#End Region

#Region " Exception Classes "
'*******************************************************************************
'*  SQLDLGeneralException Class
'*******************************************************************************
Public Class SQLDLGeneralException
    Inherits Exception

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal message As String)
        MyBase.New(message)
    End Sub

    Public Sub New(ByVal message As String, ByVal ex As Exception)
        MyBase.New(message, ex)
    End Sub
End Class

'*******************************************************************************
'*  SQLDLDatabaseNotStartedException Class
'*******************************************************************************
Public Class SQLDLDatabaseNotStartedException
    Inherits Exception

    Public Sub New()
        MyBase.New("Database not started.")
    End Sub

    Public Sub New(ByVal Message As String, _
                   ByVal Source As String)
        MyBase.New(Message)
        MyBase.Source = Source
    End Sub

    Public Sub New(ByVal Message As String, _
                   ByVal Source As String, _
                   ByRef innerException As Exception)
        MyBase.New(Message, innerException)
        MyBase.Source = Source
    End Sub

    Public Overrides Property HelpLink() As String
        Get
            HelpLink = MyBase.HelpLink
        End Get
        Set(ByVal Value As String)
            MyBase.HelpLink = Value
        End Set
    End Property

End Class

'*******************************************************************************
'*  SQLDLNoServerSpecifiedException Class
'*******************************************************************************
Public Class SQLDLNoServerSpecifiedException
    Inherits Exception

    Public Sub New()
        MyBase.New("No Server specified.")
    End Sub

    Public Sub New(ByVal Message As String, _
                   ByVal Source As String)
        MyBase.New(Message)
        MyBase.Source = Source
    End Sub

    Public Sub New(ByVal Message As String, _
                   ByVal Source As String, _
                   ByRef innerException As Exception)
        MyBase.New(Message, innerException)
        MyBase.Source = Source
    End Sub

    Public Overrides Property HelpLink() As String
        Get
            HelpLink = MyBase.HelpLink
        End Get
        Set(ByVal Value As String)
            MyBase.HelpLink = Value
        End Set
    End Property

End Class
#End Region

#Region " AutenticacionActiveDirectory "
''' <summary>
''' DESCRIPCION:  CLASE DE AUTENTICACION CONTRA ACTIVE DIRECTORY
''' AUTOR:        SEBASTIAN BUCETA
''' EMPRESA:      PROYECTO EXCELENCIA
''' FECHA:        08/09/2008
''' </summary>
''' <remarks></remarks>

Public Class AutenticacionActiveDirectory

    Private Enum ADSIMode
        <Description("LDAP://")>
        ldap
        <Description("WinNT://")>
        winnt
    End Enum

    Private sUsuario As String = ""
    Private sPassword As String = ""
    Private sDominio As String = ""
    Private eTipoAutenticacion As AuthenticationTypes = AuthenticationTypes.SecureSocketsLayer
    Private bAutenticado As Boolean = False
    Private _activeADSIMode = ADSIMode.ldap

    Private ReadOnly Property PrefixADSI(modo As ADSIMode) As String
        Get
            Dim ten As Reflection.FieldInfo = modo.GetType.GetField(modo.ToString)
            Dim attr As DescriptionAttribute = DirectCast(ten.GetCustomAttributes(GetType(DescriptionAttribute), False)(0), DescriptionAttribute)
            Return attr.Description
        End Get
    End Property

    Friend Sub New()
        sUsuario = ""
        sPassword = ""
        sDominio = ""
        eTipoAutenticacion = AuthenticationTypes.SecureSocketsLayer
        bAutenticado = False
    End Sub

    Public Property Dominio() As String
        Get
            Dominio = sDominio.Replace(PrefixADSI(ADSIMode.ldap), "").Replace(PrefixADSI(ADSIMode.winnt), "") '.Replace("LDAP://", "")
        End Get

        Set(ByVal valor As String)
            ' sDominio = "LDAP://" & valor.Replace("LDAP://", "")
            sDominio = PrefixADSI(_activeADSIMode) & valor.Replace(PrefixADSI(ADSIMode.ldap), "").Replace(PrefixADSI(ADSIMode.winnt), "")
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Usuario = sUsuario
        End Get

        Set(ByVal valor As String)
            sUsuario = valor
        End Set
    End Property

    Public Property Password() As String
        Get
            Password = sPassword
        End Get

        Set(ByVal valor As String)
            sPassword = valor
        End Set
    End Property

    Public Property TipoAutenticacion() As AuthenticationTypes
        Get
            TipoAutenticacion = eTipoAutenticacion
        End Get

        Set(ByVal valor As AuthenticationTypes)
            eTipoAutenticacion = valor
        End Set
    End Property

    Public ReadOnly Property Autenticado() As Boolean
        Get
            Autenticado = bAutenticado
        End Get
    End Property

    Public Function Autenticar() As Boolean
        Return Autenticar(String.Empty)
    End Function
    Public Function Autenticar(ByRef sError As String) As Boolean
        Return Autenticar(True, sError)
    End Function
    Public Function Autenticar(ByVal reintenta As Boolean, ByRef sError As String) As Boolean

        Dim oDirEntry As DirectoryEntry = New DirectoryEntry(sDominio, sUsuario, sPassword)

        Try

            sError = oDirEntry.Name

            bAutenticado = True
            Return True

        Catch ex As Exception
            If (reintenta) Then
                _activeADSIMode = ADSIMode.winnt
                Dominio = Dominio
                Return Autenticar(False, sError)

            End If
            sError = ex.Message
            bAutenticado = False
            Return False
        End Try

    End Function

End Class

#End Region