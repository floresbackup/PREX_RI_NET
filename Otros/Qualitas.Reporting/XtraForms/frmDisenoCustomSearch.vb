Public Class frmDisenoCustomSearch 

    Public Sub New(ByVal bHabilitado As Boolean, ByVal sMensaje As String, ByVal sVariable As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        DISENO_CUSTOM_SEARCH_ACEPTADO = False
        chkHabilitar.Checked = bHabilitado
        txtMensaje.Text = sMensaje
        txtVariable.Text = sVariable

    End Sub

    Private Sub frmDisenoCustomSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LocalizarFormulario()

    End Sub

    Private Sub LocalizarFormulario()

        On Error Resume Next
        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionDisenoCustomSearch)

        chkHabilitar.Text = DescripcionCadena(Cadenas.CDN_frmDisenoCustomSearch_Habilitada)
        grpParametros.Text = DescripcionCadena(Cadenas.CDN_frmDisenoCustomSearch_TituloFrame)
        lblMensaje.Text = DescripcionCadena(Cadenas.CDN_frmDisenoCustomSearch_Mensaje)
        lblVariable.Text = DescripcionCadena(Cadenas.CDN_frmDisenoCustomSearch_Variable)

        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

    End Sub

    Private Function DatosOK() As Boolean

        If chkHabilitar.Checked Then


            If txtMensaje.Text.Trim = vbNullString Then
                MensajeError(DescripcionCadena(Cadenas.CDN_frmDisenoCustomSearch_ErrorVacio))
                txtMensaje.Focus()
                Exit Function
            End If

            If txtVariable.Text.Trim = vbNullString Then
                MensajeError(DescripcionCadena(Cadenas.CDN_frmDisenoCustomSearch_ErrorVacio))
                txtVariable.Focus()
                Exit Function
            End If

        End If

        DatosOK = True

    End Function

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If DatosOK() Then
            DISENO_CUSTOM_SEARCH_HABILITADA = chkHabilitar.Checked
            DISENO_CUSTOM_SEARCH_MENSAJE = txtMensaje.Text.Trim
            DISENO_CUSTOM_SEARCH_VARIABLE = txtVariable.Text.Trim
            DISENO_CUSTOM_SEARCH_ACEPTADO = True
            Me.Close()
        End If
    End Sub

    Private Sub chkHabilitar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHabilitar.CheckedChanged
        grpParametros.Enabled = chkHabilitar.Checked

        If chkHabilitar.Checked Then txtMensaje.Focus()
    End Sub
End Class