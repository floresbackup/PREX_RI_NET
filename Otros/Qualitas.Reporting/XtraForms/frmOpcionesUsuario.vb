Imports DevExpress.XtraEditors.Controls

Public Class frmOpcionesUsuario

    Private oAdmTablas As New AdmTablas

    Private Sub frmOpcionesUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        oAdmTablas.ConnectionString = CONN_LOCAL
        LocalizarFormulario()
        CargarIdimas()
        LeerOpciones()

    End Sub

    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionOpcionesUsuario)

        lblIdioma.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesUsuario_Idioma)
        lblTema.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesUsuario_Tema)
        chkGuardarLayouts.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesUsuario_GuardarLayoutsAuto)
        cmdRestablecerLayouts.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesUsuario_RestablecerLayouts)
        chkColapsarRibbons.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesUsuario_RibbonsColapsadas)
        chkIntelliprompt.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesUsuario_Intelliprompt)
        chkWelcome.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesUsuario_Welcome)
        chkMultifiltro.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesUsuario_Multifiltro)
        chkShowPB.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesUsuario_ShowPB)

        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

    End Sub

    Private Sub CargarIdimas()

        Dim sSQL As String
        Dim ds As DataSet
        Dim oItem As ImageComboBoxItem
        Dim oItemAux As ImageComboBoxItem
        Dim i As Integer

        sSQL = "SELECT  TG_CODCON, TG_DESCRI " & _
               "FROM    TABGEN " & _
               "WHERE   TG_CODTAB = 1 " & _
               "AND     TG_CODCON <> 999999 " & _
               "ORDER BY TG_CODCON"

        ds = oAdmTablas.AbrirDataset(sSQL)
        cboIdioma.Properties.Items.Clear()

        With ds.Tables(0)
            For i = 0 To .Rows.Count - 1
                oItem = New ImageComboBoxItem
                oItem.Description = .Rows(i).Item("TG_DESCRI")
                oItem.Value = .Rows(i).Item("TG_CODCON")
                cboIdioma.Properties.Items.Add(oItem)

                If .Rows(i).Item("TG_CODCON") = IDIOMA_ACTUAL Then
                    oItemAux = oItem
                End If
            Next
        End With

        If Not oItemAux Is Nothing Then
            cboIdioma.SelectedItem = oItemAux
        End If

    End Sub

    Private Sub cmdRestablecerLayouts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRestablecerLayouts.Click
        If Pregunta(DescripcionCadena(Cadenas.CDN_frmOpcionesUsuario_WarningRestablecer)) = Windows.Forms.DialogResult.Yes Then
            BorrarLayouts()
            cmdRestablecerLayouts.Enabled = False
        End If
    End Sub

    Private Sub BorrarLayouts()

        Dim oFile As IO.FileInfo
        Dim oFolder As IO.DirectoryInfo

        Cursor = Cursors.WaitCursor

        Try

            oFolder = New IO.DirectoryInfo(GRID_LAYOUTS_PATH)

            For Each oFile In oFolder.GetFiles("*.xml")
                oFile.Delete()
            Next

            oFolder = New IO.DirectoryInfo(CUBE_LAYOUTS_PATH)

            For Each oFile In oFolder.GetFiles("*.xml")
                oFile.Delete()
            Next

            Cursor = Cursors.Default

        Catch ex As Exception
            TratarError(ex)
        End Try


    End Sub

    Private Sub LeerOpciones()
        chkColapsarRibbons.Checked = COLLAPSE_RIBBON
        chkGuardarLayouts.Checked = AUTOSAVE_LAYOUTS
        cboTema.EditValue = THEME_ACTUAL
        chkIntelliprompt.Checked = USE_INTELLIPROMPT
        chkWelcome.Checked = SHOW_WELCOME
        chkMultifiltro.Checked = MULTIFILTER_COLUMNS
        chkShowPB.Checked = SHOW_PERCENT_PB
    End Sub

    Private Sub GuardarOpciones()

        Dim sIniPath As String = USER_FOLDER & "User.ini"
        Dim bThemeChanged As Boolean

        If chkColapsarRibbons.Checked Then COLLAPSE_RIBBON = 1 Else COLLAPSE_RIBBON = 0
        If chkGuardarLayouts.Checked Then AUTOSAVE_LAYOUTS = 1 Else AUTOSAVE_LAYOUTS = 0
        If chkIntelliprompt.Checked Then USE_INTELLIPROMPT = 1 Else USE_INTELLIPROMPT = 0
        If chkWelcome.Checked Then SHOW_WELCOME = 1 Else SHOW_WELCOME = 0
        If chkMultifiltro.Checked Then MULTIFILTER_COLUMNS = 1 Else MULTIFILTER_COLUMNS = 0
        If chkShowPB.Checked Then SHOW_PERCENT_PB = 1 Else SHOW_PERCENT_PB = 0

        If cboTema.EditValue <> THEME_ACTUAL Then
            THEME_ACTUAL = cboTema.EditValue
            bThemeChanged = True
        End If

        INIWrite(sIniPath, "OPCIONES", "COLLAPSE_RIBBON", COLLAPSE_RIBBON)
        INIWrite(sIniPath, "OPCIONES", "AUTOSAVE_LAYOUTS", AUTOSAVE_LAYOUTS)
        INIWrite(sIniPath, "OPCIONES", "USE_INTELLIPROMPT", USE_INTELLIPROMPT)
        INIWrite(sIniPath, "OPCIONES", "SHOW_WELCOME", SHOW_WELCOME)
        INIWrite(sIniPath, "OPCIONES", "MULTIFILTER_COLUMNS", MULTIFILTER_COLUMNS)
        INIWrite(sIniPath, "OPCIONES", "SHOW_PERCENT_PB", SHOW_PERCENT_PB)
        INIWrite(sIniPath, "OPCIONES", "IDIOMA", cboIdioma.EditValue)
        INIWrite(sIniPath, "OPCIONES", "THEME_ACTUAL", THEME_ACTUAL)


        If cboIdioma.EditValue <> IDIOMA_ACTUAL Then
            If Pregunta(DescripcionCadena(Cadenas.CDN_frmOpcionesUsuario_PreguntaReiniciarApp)) = Windows.Forms.DialogResult.Yes Then
                Application.Restart()
            End If
        End If

        If bThemeChanged Then
            frmMainX.SetSkin()
        End If

        Me.Close()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        GuardarOpciones()
    End Sub
End Class