Public Class frmSQLError 

    Public Sub New(ByVal sErrorDescription As String, ByVal sSQLText As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        LocalizarFormulario()

        txtError.Text = sErrorDescription
        txtSQL.Text = sSQLText

    End Sub

    Public Sub LocalizarFormulario()
        cmdCerrar.Text = DescripcionCadena(Cadenas.CDN_GeneralCerrar)
    End Sub

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub Tabs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tabs.Click

    End Sub

    Private Sub Tabs_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles Tabs.SelectedPageChanged
        cmdCopy.Visible = (e.Page.Name = "tpSQL")
    End Sub

    Private Sub cmdCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCopy.Click
        On Error Resume Next
        Clipboard.SetText(txtSQL.Text)
    End Sub
End Class