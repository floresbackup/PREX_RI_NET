Imports VBP04296.Dominio

Public Class ucFrmColumnas
    Private cmSqlHelp As ScintillaNET.Scintilla
    Private cmSqlFormula As ScintillaNET.Scintilla
    Private detSys As List(Of DetSys)

    Public Enum HelpTipo
        TipoDato = 0  '"Utilizar el tipo de dato",
        SQL = 1 '"Utilizar Help SQL"
    End Enum

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

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        FontDialog1.Font = edFuente.Font
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            edFuente.Font = FontDialog1.Font
            edFuente.Size = New Size(edFuente.Size.Width, 20)
        End If

    End Sub

    Private Sub gridViewColumnas_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles gridViewColumnas.SelectionChanged
        Dim llave = gridViewColumnas.FocusedValue()

        MostrarColumna(detSys.FirstOrDefault(Function(t) t.Campo = llave))
    End Sub

    Private Sub cboHelp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHelp.SelectedIndexChanged
        cmSqlHelp.Enabled = GetTipoHelpTexto(cboHelp.Text) = HelpTipo.SQL
    End Sub
End Class
