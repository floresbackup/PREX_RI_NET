Imports Microsoft.Data.ConnectionUI

Public Class frmConnString

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        txtCadena.Text = CONN_LOCAL


    End Sub

    Private Sub cmdGenerarCadena_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerarCadena.Click

        Dim dcd As New DataConnectionDialog
        Dim buf As String

        DataSource.AddStandardDataSources(dcd)

        If DataConnectionDialog.Show(dcd) = Windows.Forms.DialogResult.OK Then
            txtCadena.Text = dcd.ConnectionString
        End If

    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click

        If txtCadena.Text <> "" Then
            CONN_LOCAL = txtCadena.Text.Trim
            GuardarCerrar()
        Else
            MensajeError("Please specify the connection string")
            txtCadena.Focus()
        End If

    End Sub

    Private Sub GuardarCerrar()

        Dim sFileName As String

        sFileName = Application.StartupPath & "\CONNECT.DAT"

        If IO.File.Exists(sFileName) Then
            IO.File.Delete(sFileName)
        End If

        IO.File.WriteAllText(sFileName, cEncrypt.EncryptString128Bit(CONN_LOCAL))
        Me.Hide()
        frmMain.LeerConnLocal()

        MensajeInformacion("You must restart configuration and licensing manager to validate changes to this connection string")
        Me.Close()

    End Sub

    Private Sub cmdRestoreDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRestoreDB.Click

        Dim fRestore As New frmRestoreDB

        fRestore.ShowDialog()
        fRestore.Dispose()

    End Sub
End Class