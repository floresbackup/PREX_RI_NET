Public NotInheritable Class frmSplash

    Private Sub frmSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Info()

        On Error Resume Next
        LOGO_SPLASH_PATH = Application.StartupPath & "\RES\001.DAT"
        Me.BackgroundImage = Image.FromFile(LOGO_SPLASH_PATH)

    End Sub

    Private Sub Info()

        On Error Resume Next

        Dim sVersion As String
        Dim sCopyright As String
        Dim sCPInfoPath As String

        sVersion = "Version " & Application.ProductVersion
        sCPInfoPath = Application.StartupPath & "\CPNAME.DAT"

        If IO.File.Exists(sCPInfoPath) Then
            sCopyright = IO.File.ReadAllText(sCPInfoPath)
        Else
            sCopyright = "Todos los derechos reservados. EDR Software 2008®"
        End If

        lblVersion.Text = sVersion
        lblCopyright.Text = sCopyright

    End Sub

    Private Sub tmrLoad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        On Error Resume Next
        Static nI As Integer

        nI = nI + 1

        If nI >= 4 Then
            Me.Close()
        End If

    End Sub

End Class
