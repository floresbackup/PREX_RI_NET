Imports ActiveDatabaseSoftware.ActiveQueryBuilder

Public Class frmSQLWizard

    Private oAdmTablas As New AdmTablas
    Private WARNING_REPLACE As Boolean

    Private Sub frmSQLWizard_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        SQL_ASISTENTE = ""
        oAdmTablas.ConnectionString = CONN_LOCAL
        LocalizarFormulario()

    End Sub

    Private Sub LocalizarFormulario()

        Dim sSQL As String
        Dim ds As DataSet
        Dim sXMLLocalePath As String

        sSQL = "SELECT      TG_ALFA01 " & _
               "FROM        TABGEN " & _
               "WHERE       TG_CODTAB = 1 " & _
               "AND         TG_CODCON = " & IDIOMA_ACTUAL

        ds = oAdmTablas.AbrirDataset(sSQL)
        With ds.Tables(0)

            If .Rows.Count > 0 Then
                sXMLLocalePath = LOCALE_PATH & .Rows(0)("TG_ALFA01").ToString.Trim
            Else
                sXMLLocalePath = LOCALE_PATH
            End If

        End With
        ds.Dispose()

        ActiveDatabaseSoftware.ActiveQueryBuilder.Helpers.Localizer.LoadLanguageFromFile(sXMLLocalePath)
        qbMain.Language = IDIOMA_ACTUAL.ToString

        ' Agregar otras localizaciones de ser necesarias....

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionQueryBuilder)
        cmdAgregarObjeto.Text = DescripcionCadena(Cadenas.CDN_frmSQLWizard_BotonAgregarObjeto)
        cmdPropiedades.Text = DescripcionCadena(Cadenas.CDN_frmSQLWizard_BotonPropiedades)
        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

        qbMain.QueryStructureTreeOptions.UnionsNodeText = DescripcionCadena(Cadenas.CDN_frmSQLWizard_Uniones)
        qbMain.QueryStructureTreeOptions.FromNodeText = DescripcionCadena(Cadenas.CDN_frmSQLWizard_Objetos)
        qbMain.QueryStructureTreeOptions.FieldsNodeText = DescripcionCadena(Cadenas.CDN_frmSQLWizard_Expresiones)


    End Sub

    Public Sub New(ByVal sCadenaConexion As String, ByVal nTipoConexion As Integer, Optional ByVal bWarningReplace As Boolean = True)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        WARNING_REPLACE = bWarningReplace
        txtSQL.Enabled = EDICION_SQL_HABILITADA

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Try

            With qbMain

                Select Case nTipoConexion
                    Case 0
                        OLEDBMDP.Connection = New OleDb.OleDbConnection(sCadenaConexion)
                        OLEDBMDP.Connection.Open()
                        .MetadataProvider = OLEDBMDP
                    Case 1
                        MSSQLMDP.Connection = New SqlClient.SqlConnection(sCadenaConexion)
                        MSSQLMDP.Connection.Open()
                        .MetadataProvider = MSSQLMDP
                    Case 2
                        ORAMDP.Connection = New OracleClient.OracleConnection(sCadenaConexion)
                        ORAMDP.Connection.Open()
                        .MetadataProvider = ORAMDP
                    Case 3
                        ODBCMDP.Connection = New Odbc.OdbcConnection(sCadenaConexion)
                        ODBCMDP.Connection.Open()
                        .MetadataProvider = ODBCMDP

                End Select


                Dim oFilterTables As New ActiveDatabaseSoftware.ActiveQueryBuilder.MetadataFilterItem
                Dim oFilterViews As New ActiveDatabaseSoftware.ActiveQueryBuilder.MetadataFilterItem
                Dim oFilterSPs As New ActiveDatabaseSoftware.ActiveQueryBuilder.MetadataFilterItem

                oFilterTables.ApplyFor = MetadataFilterApplyFor.Tables
                oFilterTables.Exclude = AQB_MOSTRAR_TABLAS = 0

                oFilterViews.ApplyFor = MetadataFilterApplyFor.Views
                oFilterViews.Exclude = AQB_MOSTRAR_VISTAS = 0

                oFilterSPs.ApplyFor = MetadataFilterApplyFor.Procedures
                oFilterSPs.Exclude = AQB_MOSTRAR_SPS = 0


                qbMain.MetadataFilter.Add(oFilterTables)
                qbMain.MetadataFilter.Add(oFilterViews)
                qbMain.MetadataFilter.Add(oFilterSPs)

                .RefreshMetadata()

            End With

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub qbMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ptbSQL_SQLUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ptbSQL.SQLUpdated
        txtSQL.Text = ptbSQL.SQL
    End Sub

    Private Sub frmSQLWizard_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        On Error Resume Next
        oSplitter.Height = Me.Height - pcMain.Height - 25
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAgregarObjeto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarObjeto.Click

        qbMain.ShowAddObjectForm()
    End Sub

    Private Sub cmdPropiedades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPropiedades.Click

        qbMain.ShowQueryBuilderPropertiesForm("Active Query Builder Properties", _
         QueryBuilderProperties.NonVisual Or QueryBuilderProperties.Visual Or _
         QueryBuilderProperties.SqlBuilder, ptbSQL)

    End Sub

    'Private Sub ShowCustomProperties(ByVal Title As String, ByVal flags As QueryBuilderProperties, ByVal builder As BaseSQLBuilder)

    'Dim f As New ActiveDatabaseSoftware.ActiveQueryBuilder.QueryBuilder QueryBuilderPropertiesForm(queryBuilder1, Title, flags, builder)
    'f.ShowDialog()

    'End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If txtSQL.Text <> "" Then

            If WARNING_REPLACE Then
                If Pregunta(DescripcionCadena(Cadenas.CDN_frmSQLWizard_WarningReplace)) = Windows.Forms.DialogResult.Yes Then
                    SQL_ASISTENTE = txtSQL.Text
                    Me.Close()
                End If
            Else
                SQL_ASISTENTE = txtSQL.Text
                Me.Close()
            End If
        End If


    End Sub


    Private Sub txtSQL_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSQL.EditValueChanged

    End Sub

    Private Sub txtSQL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSQL.Leave

        ' Update the query builder with new manually edited SQL query text


        Try
            qbMain.SQL = txtSQL.Text

            ' !!!
            ' QueryBuilder.SQL property is asynchronous.
            ' If you need to wait until the QueryBuilder is updated, use QueryBuilder.SyncSQL property instead.
            ' !!!

        Catch ex As Exception


        End Try

    End Sub
End Class