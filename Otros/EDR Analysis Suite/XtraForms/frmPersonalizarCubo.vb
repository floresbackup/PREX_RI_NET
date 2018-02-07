Imports DevExpress.XtraPivotGrid

Public Class frmPersonalizarCubo

    Private oCubo As PivotGridControl

    Private Sub frmPersonalizarCubo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LocalizarFormulario()

    End Sub

    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionPersonalizarCubo)
        lvCampos.Groups(0).Header = DescripcionCadena(Cadenas.CDN_frmPersonalizarCubo_HeaderListView)
        cmdAgregar.Text = DescripcionCadena(Cadenas.CDN_frmPersonalizarCubo_Agregar)
        cmdPropiedades.Text = DescripcionCadena(Cadenas.CDN_frmPersonalizarCubo_Propiedades)
        cmdEliminar.Text = DescripcionCadena(Cadenas.CDN_frmPersonalizarCubo_Eliminar)

        chkTotalesFilas.Text = DescripcionCadena(Cadenas.CDN_frmPersonalizarCubo_TotalesFilas)
        chkGrandesTotalesFilas.Text = DescripcionCadena(Cadenas.CDN_frmPersonalizarCubo_GrandesTotalesFilas)
        chkTotalesColumnas.Text = DescripcionCadena(Cadenas.CDN_frmPersonalizarCubo_TotalesColumnas)
        chkGrandesTotalesColumnas.Text = DescripcionCadena(Cadenas.CDN_frmPersonalizarCubo_GrandesTotalesColumnas)
        grpTotales.Text = DescripcionCadena(Cadenas.CDN_frmPersonalizarCubo_GrupoTotales)

        cmdCerrar.Text = DescripcionCadena(Cadenas.CDN_GeneralCerrar)

    End Sub

    Public Sub PasarCubo(ByRef oPivotGrid As PivotGridControl)

        oCubo = oPivotGrid
        CargarColumnas()
        IniciarPropiedades()

    End Sub

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub CargarColumnas()

        Dim itmX As ListViewItem
        Dim subX As ListViewItem.ListViewSubItem
        Dim colX As PivotGridField
        Dim sArea As String

        lvCampos.Items.Clear()

        For Each colX In oCubo.Fields

            itmX = New ListViewItem

            Select Case colX.Area
                Case PivotArea.ColumnArea
                    sArea = DescripcionCadena(Cadenas.CDN_frmPersonalizarCubo_AreaColumnas)
                    itmX.ImageIndex = 2
                Case PivotArea.DataArea
                    sArea = DescripcionCadena(Cadenas.CDN_frmPersonalizarCubo_AreaTotales)
                    itmX.ImageIndex = 3
                Case PivotArea.FilterArea
                    sArea = DescripcionCadena(Cadenas.CDN_frmPersonalizarCubo_AreaFiltros)
                    itmX.ImageIndex = 0
                Case PivotArea.RowArea
                    sArea = DescripcionCadena(Cadenas.CDN_frmPersonalizarCubo_AreaFilas)
                    itmX.ImageIndex = 1
            End Select


            itmX.UseItemStyleForSubItems = False
            subX = itmX.SubItems.Add(sArea)
            subX.ForeColor = Color.DarkGray

            If colX.Caption <> vbNullString Then
                itmX.Text = colX.Caption
            Else
                itmX.Text = colX.FieldName
            End If

            itmX.Tag = colX.ColumnHandle
            itmX.Group = lvCampos.Groups(0)

            lvCampos.Items.Add(itmX)

        Next

    End Sub

    Private Sub lvCampos_DrawSubItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawListViewSubItemEventArgs) Handles lvCampos.DrawSubItem
        e.DrawText()
    End Sub

    Private Sub lvCampos_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvCampos.ItemSelectionChanged
        cmdPropiedades.Enabled = e.IsSelected
        cmdEliminar.Enabled = e.IsSelected
    End Sub

    Private Sub lvCampos_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvCampos.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Not lvCampos.FocusedItem Is Nothing Then
                PropiedadesItem(lvCampos.FocusedItem)
            End If
        End If
    End Sub

    Private Sub PropiedadesItem(ByVal oItem As ListViewItem)

        Dim fCampo As frmColumnaCubo
        Dim nItemName As Integer

        nItemName = oItem.Index

        fCampo = New frmColumnaCubo
        fCampo.Iniciar()
        fCampo.PasarField(oCubo.Fields(nItemName))
        fCampo.ShowDialog()

        CargarColumnas()
        lvCampos.Items(nItemName).Selected = True
        lvCampos.Items(nItemName).EnsureVisible()

    End Sub

    Private Sub NuevoItem()

        Dim fCampo As frmColumnaCubo

        fCampo = New frmColumnaCubo
        fCampo.Iniciar()
        fCampo.PasarCubo(oCubo)
        fCampo.ShowDialog()

        CargarColumnas()

    End Sub

    Private Sub cmdPropiedades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPropiedades.Click
        If Not lvCampos.FocusedItem Is Nothing Then
            PropiedadesItem(lvCampos.FocusedItem)
        End If
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        NuevoItem()
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If Not lvCampos.FocusedItem Is Nothing Then
            If Pregunta(DescripcionCadena(Cadenas.CDN_frmPersonalizarCubo_WarningEliminar)) = Windows.Forms.DialogResult.Yes Then
                oCubo.Fields.Remove(oCubo.Fields(lvCampos.FocusedItem.Index))
                CargarColumnas()
            End If
        End If
    End Sub

    Private Sub chkTotalesFilas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTotalesFilas.CheckedChanged
        oCubo.OptionsView.ShowRowTotals = chkTotalesFilas.Checked
    End Sub

    Private Sub chkTotalesColumnas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTotalesColumnas.CheckedChanged
        oCubo.OptionsView.ShowColumnTotals = chkTotalesColumnas.Checked
    End Sub

    Private Sub chkGrandesTotalesFilas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGrandesTotalesFilas.CheckedChanged
        oCubo.OptionsView.ShowRowGrandTotals = chkGrandesTotalesFilas.Checked
    End Sub

    Private Sub chkGrandesTotalesColumnas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGrandesTotalesColumnas.CheckedChanged
        oCubo.OptionsView.ShowColumnGrandTotals = chkGrandesTotalesColumnas.Checked
    End Sub

    Private Sub IniciarPropiedades()

        chkTotalesFilas.Checked = oCubo.OptionsView.ShowRowTotals
        chkTotalesColumnas.Checked = oCubo.OptionsView.ShowColumnTotals
        chkGrandesTotalesFilas.Checked = oCubo.OptionsView.ShowRowGrandTotals
        chkGrandesTotalesColumnas.Checked = oCubo.OptionsView.ShowColumnGrandTotals

    End Sub

End Class