Public Class frmProcesando

    Public Sub DeshabilitarCancelacion()
        lblTip.Text = DescripcionCadena(Cadenas.CDN_lblProcesandoTipNoCancelar)
        cmdCancelar.Visible = False
    End Sub

    Private Sub frmProcesando_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LocalizarFormulario()
        CONSULTA_CANCELADA = False
    End Sub

    Private Sub LocalizarFormulario()
        lblProcesando.Text = DescripcionCadena(Cadenas.CDN_lblProcesando)
        lblTip.Text = DescripcionCadena(Cadenas.CDN_lblProcesandoTip)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        CONSULTA_CANCELADA = True
    End Sub

End Class