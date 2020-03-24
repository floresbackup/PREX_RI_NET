Imports VBP04296.Dominio
Imports Prex.Utils.ExtensionMehods

Public Class ucFrmColumnas
    Private cmSqlHelp As ScintillaNET.Scintilla
    Private cmSqlFormula As ScintillaNET.Scintilla
    Private detSys As List(Of DetSys)

    Public Enum HelpTipo
        TipoDato = 0  '"Utilizar el tipo de dato",
        SQL = 1 '"Utilizar Help SQL"
    End Enum

    Private ReadOnly Property ColSeleccionada As DetSys
        Get
            If detSys Is Nothing OrElse Not detSys.Any() Then Return Nothing

            Dim llave = gridViewColumnas.FocusedValue()
            If llave.IsNullOrEmpty() Then detSys.FirstOrDefault()

            Return detSys.FirstOrDefault(Function(t) t.Campo = llave)
        End Get
    End Property

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        cmSqlHelp = New ScintillaNET.Scintilla()
        pnlHelpSQL.Controls.Add(cmSqlHelp)
        cmSqlHelp.Dock = DockStyle.Fill
        Prex.Utils.Misc.Forms.ScintillaSQL.InitialiseScintilla(cmSqlHelp)

        cmSqlFormula = New ScintillaNET.Scintilla()
        pnlSQLFormula.Controls.Add(cmSqlFormula)
        cmSqlFormula.Dock = DockStyle.Fill
        Prex.Utils.Misc.Forms.ScintillaSQL.InitialiseScintilla(cmSqlFormula)

        Dim item As New DevExpress.XtraEditors.Controls.ComboBoxItem()
        item.Value = HelpTipo.TipoDato
        cboHelp.Properties.Items.Add(item)

        Dim item2 As New DevExpress.XtraEditors.Controls.ComboBoxItem()
        item2.Value = HelpTipo.SQL
        cboHelp.Properties.Items.Add(item2)
    End Sub


    Private Sub ucFrmColumnas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#Region "Metodos"
    Public Sub CargarGrillaColumnas(tDetSys As List(Of DetSys))
        Try
            RemoveHandler gridViewColumnas.SelectionChanged, AddressOf gridViewColumnas_SelectionChanged
            detSys = tDetSys
            gridColumnas.DataSource = tDetSys.OrderBy(Function(c) c.Orden).Select(Function(c) New With {c.Campo, c.Llave}).ToList()
            For Each item As DevExpress.XtraGrid.Columns.GridColumn In gridViewColumnas.Columns
                item.Visible = item.FieldName.Contains("Campo")
            Next
            gridViewColumnas.FocusedRowHandle = 0
            gridViewColumnas.SelectRow(0)

            MostrarColumna(tDetSys.OrderBy(Function(c) c.Orden).FirstOrDefault())
        Finally
            AddHandler gridViewColumnas.SelectionChanged, AddressOf gridViewColumnas_SelectionChanged
        End Try
    End Sub


    Private Sub MostrarColumna(columna As DetSys)
        If columna Is Nothing Then
            txtTituloVar.Text = String.Empty
            txtTipo.Text = String.Empty
            cboHelp.Text = String.Empty
            chkClaveTabla.Checked = False
            chkDrillDown.Checked = False
            chkHabilita.Checked = False
            chkReemplazoValores.Checked = False
            chkVisABM.Checked = False
            chkVisGrilla.Checked = False

            txtFormato.Text = String.Empty

        Else
            txtTituloVar.Text = columna.Titulo
            txtTipo.Text = columna.Tipo
            cboHelp.Text = GetTextoTipoHelp(columna.Help)
            txtAnchoMax.Text = columna.MaxLargo
            txtAncho.Text = columna.Largo

            chkClaveTabla.Checked = columna.Llave
            chkDrillDown.Checked = columna.DrillD
            chkHabilita.Checked = columna.Habili
            chkReemplazoValores.Checked = columna.Reemplazo
            chkVisABM.Checked = columna.VisABM
            chkVisGrilla.Checked = columna.Visible

            cmSqlFormula.Text = columna.Formul
            cmSqlHelp.Text = columna.HelQue

            If columna.Format.Length >= 8 Then
                Dim sFormat = columna.Format.Split(";")
                txtFormato.Text = sFormat(0)
                pickFondo.Color = ColorTranslator.FromOle(Val(sFormat(1)))
                pickFrente.Color = ColorTranslator.FromOle(Val(sFormat(2)))
                Dim f As Font
                Dim ff As FontStyle
                If Val(sFormat(4)) Then ff = FontStyle.Bold
                If Val(sFormat(5)) Then ff = ff And FontStyle.Underline
                If Val(sFormat(6)) Then ff = ff And FontStyle.Strikeout

                edFuente.Font = New Font(sFormat(3).ToString, Single.Parse(sFormat(7)), ff)
                txtAncho.Text = Val(sFormat(8))
                If UBound(sFormat) = 9 Then
                    txtCond.Text = sFormat(9)
                End If
            End If
            cmSqlHelp.Enabled = columna.Help = HelpTipo.SQL
        End If
        btnQueryDrillDown.Enabled = chkDrillDown.Checked
    End Sub


    Private Function GetTextoTipoHelp(tipo As HelpTipo) As String
        Select Case tipo
            Case HelpTipo.SQL
                Return "Utilizar Help SQL"
            Case HelpTipo.TipoDato
                Return "Utilizar el tipo de dato"
        End Select
        Return "Utilizar el tipo de dato"
    End Function

    Private Function GetTipoHelpTexto(tipo As String) As HelpTipo
        If tipo = "Utilizar Help SQL" Then Return HelpTipo.SQL
        If tipo = "Utilizar el tipo de dato" Then Return HelpTipo.TipoDato
        Return HelpTipo.TipoDato
    End Function

#End Region

#Region "Eventos"

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        FontDialog1.Font = edFuente.Font
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            edFuente.Font = FontDialog1.Font
            edFuente.Size = New Size(edFuente.Size.Width, 20)
        End If

    End Sub

    Private Sub gridViewColumnas_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles gridViewColumnas.SelectionChanged
        Dim llave = ColSeleccionada?.Campo

        MostrarColumna(detSys.FirstOrDefault(Function(t) t.Campo = llave))
    End Sub

    Private Sub cboHelp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHelp.SelectedIndexChanged
        cmSqlHelp.Enabled = GetTipoHelpTexto(cboHelp.Text) = HelpTipo.SQL
    End Sub

    Private Sub btnBajarColumna_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBajarColumna.ItemClick
        CambiarOrdenColumna(-1)
    End Sub

    Private Sub btnEliminarColumna_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEliminarColumna.ItemClick

        If ColSeleccionada Is Nothing Then Exit Sub
        detSys.Remove(ColSeleccionada)
        gridViewColumnas.FocusedRowHandle = 0
        gridViewColumnas.SelectRow(0)
        MostrarColumna(detSys.FirstOrDefault())

    End Sub

    Private Sub btnSubirColumna_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSubirColumna.ItemClick
        CambiarOrdenColumna(1)
    End Sub

    Private Sub CambiarOrdenColumna(pos As Integer)
        ColSeleccionada.Orden = ColSeleccionada.Orden + pos

        Dim l As New List(Of DetSys)
        For Each item As DetSys In detSys.Where(Function(t) t.Campo <> ColSeleccionada.Orden)
            If ColSeleccionada.Orden = item.Orden Then
                item.Orden = item.Orden + pos
            End If
            l.Add(item)
        Next
        l.Add(ColSeleccionada)

        detSys = l.OrderBy(Function(t) t.Orden).ToList()
    End Sub

    Private Sub chkHabilita_CheckedChanged(sender As Object, e As EventArgs) Handles chkHabilita.CheckedChanged
        If ColSeleccionada Is Nothing Then Exit Sub
        ColSeleccionada.Habili = chkHabilita.Checked
    End Sub

    Private Sub chkVisGrilla_CheckedChanged(sender As Object, e As EventArgs) Handles chkVisGrilla.CheckedChanged
        If ColSeleccionada Is Nothing Then Exit Sub
        ColSeleccionada.Visible = chkVisGrilla.Checked
    End Sub

    Private Sub chkVisABM_CheckedChanged(sender As Object, e As EventArgs) Handles chkVisABM.CheckedChanged
        If ColSeleccionada Is Nothing Then Exit Sub
        ColSeleccionada.VisABM = chkVisABM.Checked
    End Sub

    Private Sub chkClaveTabla_CheckedChanged(sender As Object, e As EventArgs) Handles chkClaveTabla.CheckedChanged
        If ColSeleccionada Is Nothing Then Exit Sub
        ColSeleccionada.Llave = chkClaveTabla.Checked
    End Sub

    Private Sub chkDrillDown_CheckedChanged(sender As Object, e As EventArgs) Handles chkDrillDown.CheckedChanged
        If ColSeleccionada Is Nothing Then Exit Sub
        ColSeleccionada.DrillD = chkDrillDown.Checked
        btnQueryDrillDown.Enabled = chkDrillDown.Checked
    End Sub

    Private Sub btnQueryDrillDown_Click(sender As Object, e As EventArgs) Handles btnQueryDrillDown.Click
        If ColSeleccionada Is Nothing Then Exit Sub

        Dim frmDrill As New frmDrillDown()
        frmDrill.PasarQuery(ColSeleccionada.DriQue, $"DrillDown {ColSeleccionada.Campo}", sProcesoPrevio:=ColSeleccionada.DriPre)
        If frmDrill.ShowDialog() = DialogResult.OK Then
            If frmDrillDown.INPUT_GENERAL <> String.Empty Then
                ColSeleccionada.DriQue = frmDrillDown.INPUT_GENERAL
            End If
            If frmDrillDown.INPUT_GENERAL_AUX <> String.Empty Then
                ColSeleccionada.DriPre = frmDrillDown.INPUT_GENERAL_AUX
            End If
        End If
    End Sub
#End Region

End Class
