Public Class frmRestoreDB 

    Private oAdmTablas As New AdmTablas

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        HabilitarInfoRestore(False)
        txtBackupFile.Text = Application.StartupPath & "\SQLDB\QUALITAS.BAK"
        txtDBName.Text = "QUALITAS"
        txtDataFile.Text = "C:\Program Files\Microsoft SQL Server\MSSQL\Data\QUALITAS_DATA.MDF"
        txtLogFile.Text = "C:\Program Files\Microsoft SQL Server\MSSQL\Data\QUALITAS_LOG.LDF"

    End Sub

    Private Sub HabilitarAuthSQL(ByVal bHab As Boolean)

        lblUserName.Enabled = bHab
        lblPassword.Enabled = bHab
        txtUserName.Enabled = bHab
        txtPassword.Enabled = bHab

    End Sub

    Private Sub HabilitarInfoRestore(ByVal bHab As Boolean)

        lblBackupFile.Enabled = bHab
        lblDBName.Enabled = bHab
        lblDataFile.Enabled = bHab
        lblLogFile.Enabled = bHab

        txtBackupFile.Enabled = bHab
        txtDBName.Enabled = bHab
        txtDataFile.Enabled = bHab
        txtLogFile.Enabled = bHab

        chkForceRestore.Enabled = bHab
        cmdOK.Enabled = bHab

        lblServerName.Enabled = Not bHab
        txtServerName.Enabled = Not bHab

        optWindows.Enabled = Not bHab
        optSQL.Enabled = Not bHab
        cmdConnect.Enabled = Not bHab

        If Not bHab Then
            HabilitarAuthSQL(optSQL.Checked)
        Else
            HabilitarAuthSQL(False)
        End If

    End Sub

    Private Sub cmdConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConnect.Click
        Conectar()
    End Sub

    Private Sub optWindows_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optWindows.CheckedChanged
        HabilitarAuthSQL(False)
    End Sub

    Private Sub optSQL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSQL.CheckedChanged
        HabilitarAuthSQL(True)
    End Sub

    Private Sub Conectar()

        Dim sConnString As String
        Dim sSQL As String
        Dim ds As DataSet

        If txtServerName.Text.Trim = "" Then
            MensajeError("You must enter the SQL Server name or IP address")
            txtServerName.Focus()
            Exit Sub
        End If

        If optSQL.Checked Then
            If txtUserName.Text.Trim = "" Then
                MensajeError("You must enter the user name to connect to the server")
                txtUserName.Focus()
                Exit Sub
            End If
        End If


        sConnString = ArmarCadena()
        oAdmTablas.ConnectionString = sConnString

        sSQL = "SELECT GETDATE()"

        Try
            Cursor = Cursors.WaitCursor
            ds = oAdmTablas.AbrirDataset(sSQL)
            HabilitarInfoRestore(True)
            Cursor = Cursors.Default

        Catch ex As Exception
            Cursor = Cursors.Default
            TratarError(ex)
        End Try



    End Sub


    Private Function ArmarCadena() As String

        Dim sTemp As String

        If optWindows.Checked Then
            sTemp = "Provider=SQLOLEDB.1;" & _
                    "Integrated Security=SSPI;" & _
                    "Persist Security Info=False;" & _
                    "Initial Catalog=master;" & _
                    "Data Source=" & txtServerName.Text.Trim
        Else
            sTemp = "Provider=SQLOLEDB.1;" & _
                    "User ID=" & txtUserName.Text.Trim & ";" & _
                    "Password=" & txtPassword.Text & ";" & _
                    "Persist Security Info=True;" & _
                    "Initial Catalog=master;" & _
                    "Data Source=" & txtServerName.Text.Trim
        End If

        ArmarCadena = sTemp

    End Function

    Private Function CadenaSQL() As String

        Dim sSQL As String

        sSQL = "RESTORE DATABASE " & txtDBName.Text.Trim & " " & _
               "FROM DISK = '" & txtBackupFile.Text.Trim & "' "

        If txtDataFile.Text.Trim <> "" And _
           txtLogFile.Text.Trim <> "" Then

            sSQL = sSQL & _
                   "WITH MOVE 'IRM' TO '" & txtDataFile.Text.Trim & "'," & _
                   "     MOVE 'IRM_log'  TO '" & txtLogFile.Text.Trim & "' "
        End If

        If chkForceRestore.Checked Then
            sSQL = sSQL & ", REPLACE"
        End If

        CadenaSQL = sSQL

    End Function

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click

        Dim sSQL As String
        Dim sErrores As String = ""
        Dim bResult As Boolean

        If Not IO.File.Exists(txtBackupFile.Text.Trim) Then
            MensajeError("The specified backup file name does not exists")
            txtBackupFile.Focus()
            Exit Sub
        End If

        If txtDBName.Text.Trim = "" Then
            MensajeError("You must enter a valid database name")
            txtDBName.Focus()
            Exit Sub
        End If

        If chkForceRestore.Checked Then
            If Pregunta("If a database with the specified name already exists, it will be replaced. Do you want to continue ?") = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If

        sSQL = CadenaSQL()

        Try
            Cursor = Cursors.WaitCursor
            bResult = oAdmTablas.EjecutarComandoSQL(sSQL, sErrores)
            Cursor = Cursors.Default

            If Not bResult Then
                MensajeError(sErrores)
            Else
                MensajeInformacion("Restore successful. Please reconfigure the connection string and license information")
                Me.Close()
            End If
        Catch ex As Exception
            Cursor = Cursors.Default
            TratarError(ex)
        End Try

    End Sub
End Class