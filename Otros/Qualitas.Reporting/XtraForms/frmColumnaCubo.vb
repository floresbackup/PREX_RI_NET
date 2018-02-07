Imports DevExpress.XtraPivotGrid



Public Class frmColumnaCubo

    Private MODO As String
    Private oCubo As PivotGridControl
    Private oField As PivotGridField
    Dim oFCons As frmConsulta

    Private Sub frmColumnaCubo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter

    End Sub

    Public Sub Iniciar()
        LocalizarFormulario()
        MODO = "A"
    End Sub

    Public Sub PasarField(ByRef oFld As PivotGridField)

        MODO = "M"
        oField = oFld

        DatosCampo()

    End Sub

    Public Sub PasarCubo(ByRef oPvt As PivotGridControl)

        MODO = "A"
        oCubo = oPvt
        txtNombreColumna.Visible = False
        cboColumnas.Visible = True
        CargarCampos()

    End Sub

    Private Sub CargarCampos()

        Dim oField As PivotGridField

        cboColumnas.Properties.Items.Clear()

        For Each oField In oCubo.Fields
            With cboColumnas.Properties.Items
                .Add(oField.FieldName)
            End With
        Next

        cboColumnas.SelectedIndex = 0

    End Sub

    Private Sub DatosCampo()

        With oField

            txtNombreColumna.Text = .FieldName
            txtTitulo.Text = IIf(.Caption <> vbNullString, .Caption, .FieldName)
            txtFormato.Text = .TotalValueFormat.FormatString
            cboTipoFormato.SelectedIndex = .TotalValueFormat.FormatType
            cboFuncion.SelectedIndex = .SummaryType
            cboTipoResumen.SelectedIndex = .SummaryDisplayType
            cboUbicacion.SelectedIndex = .Area
            cboGrupoIntervalo.SelectedIndex = .GroupInterval
            txtRangoIntervalo.Text = .GroupIntervalNumericRange

            'txtRangoIntervalo.Visible = (.GroupInterval = PivotGroupInterval.Numeric)

        End With

    End Sub

    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionColumnaCubo)

        lblNombreColumna.Text = DescripcionCadena(Cadenas.CDN_frmColumnaCubo_NombreCampo)
        lblTitulo.Text = DescripcionCadena(Cadenas.CDN_frmColumnaCubo_Titulo)
        lblFormato.Text = DescripcionCadena(Cadenas.CDN_frmColumnaCubo_Formato)
        lblUbicacion.Text = DescripcionCadena(Cadenas.CDN_frmColumnaCubo_Ubicacion)
        lblFuncion.Text = DescripcionCadena(Cadenas.CDN_frmColumnaCubo_FuncionAgr)
        lblTipoResumen.Text = DescripcionCadena(Cadenas.CDN_frmColumnaCubo_TipoResumen)
        lblGrupoIntervalo.Text = DescripcionCadena(Cadenas.CDN_frmColumnaCubo_IntervaloGrupo)
        lblRangoIntervalo.Text = DescripcionCadena(Cadenas.CDN_frmColumnaCubo_IntervaloGrupoRangoNumericos)


        With cboUbicacion.Properties

            .Items.Clear()
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmPersonalizarCubo_AreaFilas))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmPersonalizarCubo_AreaColumnas))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmPersonalizarCubo_AreaFiltros))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmPersonalizarCubo_AreaTotales))

            cboUbicacion.SelectedIndex = 2

        End With

        With cboFuncion.Properties

            .Items.Clear()
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_Recuento))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_Suma))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_Minimo))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_Maximo))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_Promedio))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_StdDevEst))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_StdDev))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_VarEst))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_Var))

            cboFuncion.SelectedIndex = 1

        End With

        With cboTipoResumen.Properties

            .Items.Clear()
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_Predeterminado))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_VariacionAbsoluta))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_VariacionPrc))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_PrcSobreColumna))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_PrcSobreFila))

            cboTipoResumen.SelectedIndex = 0

        End With

        With cboTipoFormato.Properties

            .Items.Clear()
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_FormatoNinguno))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_FormatoNumero))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_FormatoFecha))

            cboTipoFormato.SelectedIndex = 1

        End With

        With cboGrupoIntervalo.Properties

            .Items.Clear()
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_IntervaloPredeterminado))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_IntervaloFecha))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_IntervaloDiaMes))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_IntervaloDiaSemana))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_IntervaloDiaAnio))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_IntervaloSemanaMes))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_IntervaloSemanaAnio))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_IntervaloMes))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_IntervaloCuatrimestre))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_IntervaloAnio))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_IntervaloEdadAnios))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_IntervaloEdadMeses))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_IntervaloEdadSemanas))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_IntervaloEdadDias))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_IntervaloAlfabetico))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_IntervaloNumerico))
            .Items.Add(DescripcionCadena(Cadenas.CDN_frmColumnaCubo_IntervaloHora))

            cboGrupoIntervalo.SelectedIndex = 0

        End With

        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub Actualizar()

        With oField

            .Caption = txtTitulo.Text
            .TotalValueFormat.FormatType = cboTipoFormato.SelectedIndex
            .TotalValueFormat.FormatString = txtFormato.Text
            .TotalCellFormat.FormatType = cboTipoFormato.SelectedIndex
            .TotalCellFormat.FormatString = txtFormato.Text
            .GrandTotalCellFormat.FormatType = cboTipoFormato.SelectedIndex
            .GrandTotalCellFormat.FormatString = txtFormato.Text
            .CellFormat.FormatType = cboTipoFormato.SelectedIndex
            .CellFormat.FormatString = txtFormato.Text

            .SummaryType = cboFuncion.SelectedIndex
            .SummaryDisplayType = cboTipoResumen.SelectedIndex
            .Area = cboUbicacion.SelectedIndex
            .GroupInterval = cboGrupoIntervalo.SelectedIndex
            .GroupIntervalNumericRange = Val(txtRangoIntervalo.Text)

            oFCons.CheckFields()

        End With

        Me.Close()

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If MODO = "M" Then
            Actualizar()
        Else
            Agregar()
        End If

    End Sub

    Private Sub Agregar()

        oField = New PivotGridField

        With oField

            .FieldName = cboColumnas.SelectedItem

            If txtTitulo.Text.Trim = vbNullString Then
                .Caption = .FieldName
            Else
                .Caption = txtTitulo.Text
            End If

            .TotalValueFormat.FormatType = cboTipoFormato.SelectedIndex
            .TotalValueFormat.FormatString = txtFormato.Text
            .TotalCellFormat.FormatType = cboTipoFormato.SelectedIndex
            .TotalCellFormat.FormatString = txtFormato.Text
            .GrandTotalCellFormat.FormatType = cboTipoFormato.SelectedIndex
            .GrandTotalCellFormat.FormatString = txtFormato.Text
            .CellFormat.FormatType = cboTipoFormato.SelectedIndex
            .CellFormat.FormatString = txtFormato.Text

            .SummaryType = cboFuncion.SelectedIndex
            .SummaryDisplayType = cboTipoResumen.SelectedIndex
            .Area = cboUbicacion.SelectedIndex
            .GroupInterval = cboGrupoIntervalo.SelectedIndex
            .GroupIntervalNumericRange = Val(txtRangoIntervalo.Text)



            oCubo.Fields.Add(oField)
            oFCons.CheckFields()

        End With

        Me.Close()

    End Sub

    Private Sub frmColumnaCubo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cboGrupoIntervalo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrupoIntervalo.SelectedIndexChanged
        'txtRangoIntervalo.Visible = (cboGrupoIntervalo.SelectedIndex = PivotGroupInterval.Numeric)
    End Sub

    Public Sub New(ByRef oFormConsulta As frmConsulta)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oFCons = oFormConsulta

    End Sub
End Class