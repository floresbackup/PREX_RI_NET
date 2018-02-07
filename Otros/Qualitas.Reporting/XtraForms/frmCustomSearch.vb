Public Class frmCustomSearch 

    Public Sub New(ByVal sMensaje As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        LocalizarFormulario()
        lblMensaje.Text = sMensaje

    End Sub

    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionDisenoCustomSearch)
        lblTitulo.Text = Me.Text

        
        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If txtBusqueda.Text.Trim = "" Then
            MensajeError(DescripcionCadena(Cadenas.CDN_frmDisenoCustomSearch_ErrorVacio))
            txtBusqueda.Focus()
        Else
            RETORNO_CUSTOM_SEARCH = txtBusqueda.Text.Trim
            Me.Close()
        End If

    End Sub
End Class