Imports DevExpress.XtraGrid

Public Class frmDrillDown

    Private Sub frmDrillDown_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        frmDrillDown_Resize(sender, e)
    End Sub

    Private Sub frmDrillDown_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        On Error Resume Next
        With GridResultados
            .Height = Me.Height - rbcMain.Height - 30
        End With
    End Sub

    Private Sub btnSalir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalir.ItemClick
        Me.Close()
    End Sub

    Private Sub frmDrillDown_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        IniciarOpciones()
        LocalizarFormulario()
        CrearSuperTips(rbcMain)

    End Sub

    Private Sub IniciarOpciones()

        rbcMain.Minimized = (COLLAPSE_RIBBON = 1)

        If COLLAPSE_RIBBON Then
            rbcMain.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above
        Else
            rbcMain.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        End If

    End Sub

    Private Sub CrearSuperTips(ByRef oRibbon As DevExpress.XtraBars.Ribbon.RibbonControl)

        'On Error Resume Next

        Dim rPage As DevExpress.XtraBars.Ribbon.RibbonPage
        Dim rPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Dim oButton As DevExpress.XtraBars.BarItemLink
        Dim oTip As DevExpress.Utils.SuperToolTip
        Dim oTipTitle As DevExpress.Utils.ToolTipTitleItem

        For Each rPage In oRibbon.Pages
            For Each rPageGroup In rPage.Groups
                For Each oButton In rPageGroup.ItemLinks

                    oTip = New DevExpress.Utils.SuperToolTip
                    oTipTitle = New DevExpress.Utils.ToolTipTitleItem

                    oTipTitle.Image = oButton.Glyph
                    oTipTitle.Text = oButton.Caption
                    oTip.Items.Add(oTipTitle)


                    oButton.Item.SuperTip = oTip
                Next
            Next
        Next

    End Sub


    Public Sub AjustarColumnas(ByVal oGvwOriginal As Views.Grid.GridView)

        Dim oCol As Columns.GridColumn
        Dim sField As String

        For Each oCol In oGvwOriginal.Columns
            sField = oCol.FieldName
            gvwResultados.Columns(sField).Caption = oCol.Caption
            gvwResultados.Columns(sField).DisplayFormat.FormatType = oCol.DisplayFormat.FormatType
            gvwResultados.Columns(sField).DisplayFormat.FormatString = oCol.DisplayFormat.FormatString
            gvwResultados.Columns(sField).GroupFormat.FormatType = oCol.GroupFormat.FormatType
            gvwResultados.Columns(sField).GroupFormat.FormatString = oCol.GroupFormat.FormatString
        Next

    End Sub

    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionDrillDown)

        rpOpciones.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_RibbonPageOpciones)
        rpgImpresion.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_GrupoImpresion)
        rpgExportacion.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_GrupoExportar)
        rpgOtros.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_GrupoOtrasOpciones)
        btnVistaPrevia.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_BotonPreview)
        btnImprimir.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_BotonImprimir)
        btnHTML.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_BotonExportarHTML)
        btnSalir.Caption = DescripcionCadena(Cadenas.CDN_GeneralCerrar)

    End Sub

    Private Sub btnVistaPrevia_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVistaPrevia.ItemClick
        If GridResultados.IsPrintingAvailable Then
            GridResultados.ShowPrintPreview()
        End If
    End Sub

    Private Sub btnExcel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcel.ItemClick
        Dim fExcel As New frmExportarXLS

        fExcel.PasarViewResultados(Me.Text, gvwResultados)
        fExcel.ShowDialog()
        fExcel.Dispose()
    End Sub

    Private Sub btnHTML_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHTML.ItemClick
        frmExportarHTML.PasarViewResultados(Me.Text, Me.Text, gvwResultados)
        frmExportarHTML.ShowDialog()
        frmExportarHTML.Dispose()
    End Sub

    Private Sub btnPDF_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPDF.ItemClick
        ExportarGrillaPDF(gvwResultados, Me)
    End Sub

    Private Sub rbcMain_ClientSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbcMain.ClientSizeChanged
        frmDrillDown_Resize(sender, e)
    End Sub

End Class