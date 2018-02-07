Public Class frmUsuario 

    Private oAdmTablas As New AdmTablas
    Private MODO As String
    Private nCodUsuario As Long

    Public Sub New()

        InitializeComponent()

        LocalizarFormulario()
        oAdmTablas.ConnectionString = CONN_LOCAL
        CargarTodo()
        MODO = "A"

    End Sub

    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionUsuario)

        tpGeneral.Text = DescripcionCadena(Cadenas.CDN_frmUsuario_TabGeneral)
        tpPermisos.Text = DescripcionCadena(Cadenas.CDN_frmUsuario_TabPermisosConsultas)
        lblLoginName.Text = DescripcionCadena(Cadenas.CDN_frmUsuario_NombreLogin)
        lblNombreCompleto.Text = DescripcionCadena(Cadenas.CDN_frmUsuario_NombreCompleto)
        lblPassword.Text = DescripcionCadena(Cadenas.CDN_frmUsuario_Password)
        grpPermisos.Text = DescripcionCadena(Cadenas.CDN_frmUsuario_GrupoPermisos)
        grpEstado.Text = DescripcionCadena(Cadenas.CDN_frmUsuario_GrupoEstado)
        chkBloqueado.Text = DescripcionCadena(Cadenas.CDN_frmUsuario_EstadoBloqueado)
        chkEstado.Text = DescripcionCadena(Cadenas.CDN_frmUsuario_EstadoSuspendido)
        chkPermisoCategorias.Text = DescripcionCadena(Cadenas.CDN_frmUsuario_PermisoCategorias)
        chkPermisoConexiones.Text = DescripcionCadena(Cadenas.CDN_frmUsuario_PermisoConexiones)
        chkPermisoDisenar.Text = DescripcionCadena(Cadenas.CDN_frmUsuario_PermisoDisenar)
        chkPermisoEjecutar.Text = DescripcionCadena(Cadenas.CDN_frmUsuario_PermisoEjecutar)
        chkPermisoExportar.Text = DescripcionCadena(Cadenas.CDN_frmUsuario_PermisoExportar)
        chkPermisoImportar.Text = DescripcionCadena(Cadenas.CDN_frmUsuario_PermisoImportar)
        chkPermisoEliminar.Text = DescripcionCadena(Cadenas.CDN_frmUsuario_PermisoEliminar)
        chkPermisoSeguridad.Text = DescripcionCadena(Cadenas.CDN_frmUsuario_PermisoSeguridad)
        chkOpcionesGenerales.Text = DescripcionCadena(Cadenas.CDN_frmUsuario_PermisoOpcionesGrales)
        lblNoHabilitadas.Text = DescripcionCadena(Cadenas.CDN_frmUsuario_ConsultasNoHabilitadas)
        lblHabilitadas.Text = DescripcionCadena(Cadenas.CDN_frmUsuario_ConsultasHabilitadas)
        lblContadorFallidos.Text = DescripcionCadena(Cadenas.CDN_frmUsuario_ContadorLoginsFallidos)

        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

    End Sub

    Public Sub PasarUsuario(ByVal nCodUsu As Long)

        nCodUsuario = nCodUsu
        MODO = "M"
        txtNombreLogin.Enabled = False
        chkEstado.Enabled = nCodUsu <> 1    ' Admin
        DatosUsuario()

    End Sub

    Private Sub CargarTodo()

        lvHabilitadas.Items.Clear()
        lvHabilitadas.Groups.Clear()
        lvNoHabilitadas.Items.Clear()
        lvNoHabilitadas.Groups.Clear()
        CargarGrupos()
        CargarConsultas()

    End Sub

    Private Sub CargarGrupos()

        Dim sSQL As String
        Dim ds As DataSet
        Dim grpX As ListViewGroup
        Dim nI As Integer

        sSQL = "SELECT DISTINCT TG_CODCON, TG_DESCRI " & _
               "FROM            TABGEN " & _
               "INNER JOIN      CONVAR " & _
               "ON              TG_CODCON = CV_CODCON " & _
               "AND             TG_CODTAB = 3 " & _
               "ORDER BY        TG_DESCRI"

        Try

            ds = oAdmTablas.AbrirDataset(sSQL)

            With ds.Tables(0)
                For nI = 0 To .Rows.Count - 1

                    grpX = New ListViewGroup

                    grpX.Name = "G" & .Rows(nI)("TG_CODCON").ToString
                    grpX.Header = .Rows(nI)("TG_DESCRI").ToString.Trim

                    lvHabilitadas.Groups.Add(grpX)
                    lvNoHabilitadas.Groups.Add(grpX)

                Next
            End With

        Catch ex As Exception

            TratarError(ex)

        End Try

    End Sub

    Private Sub CargarConsultas()

        Dim sSQL As String
        Dim ds As DataSet
        Dim itmX As ListViewItem
        Dim nI As Integer

        sSQL = "SELECT          CV_CODCON, CV_NOMBRE, CV_DESCRI, CV_CATEGO " & _
               "FROM            CONVAR " & _
               "ORDER BY        CV_NOMBRE"

        Try

            ds = oAdmTablas.AbrirDataset(sSQL)

            With ds.Tables(0)

                For nI = 0 To .Rows.Count - 1

                    itmX = New ListViewItem

                    itmX.Name = "K" & .Rows(nI)("CV_CODCON").ToString
                    itmX.Tag = itmX.Name
                    itmX.Text = .Rows(nI)("CV_NOMBRE").ToString.Trim
                    itmX.SubItems.Add(.Rows(nI)("CV_DESCRI")).ToString()
                    itmX.ImageIndex = 0

                    If GrupoExiste("G" & .Rows(nI)("CV_CATEGO").ToString, lvHabilitadas) Then
                        itmX.Group = lvHabilitadas.Groups("G" & .Rows(nI)("CV_CATEGO").ToString)
                    End If

                    lvHabilitadas.Items.Add(itmX)

                Next

            End With

        Catch ex As Exception

            TratarError(ex)

        End Try

    End Sub

    Private Function GrupoExiste(ByVal sName As String, ByRef oLV As ListView) As Boolean

        Dim grpX As ListViewGroup

        For Each grpX In oLV.Groups
            If grpX.Name = sName Then
                GrupoExiste = True
                Exit Function
            End If
        Next
    End Function

    Private Function ItemExiste(ByVal sName As String, ByRef oLV As ListView) As Boolean

        Dim grpX As ListViewItem

        For Each grpX In oLV.Items
            If grpX.Name = sName Then
                ItemExiste = True
                Exit Function
            End If
        Next
    End Function

    Private Sub HabilitarConsulta(ByVal bHab As Boolean, ByRef itmX As ListViewItem)

        Dim itmNew As ListViewItem

        itmNew = itmX.Clone

        If bHab Then
            lvNoHabilitadas.Items.Remove(itmX)
            lvHabilitadas.Items.Add(itmNew)
        Else
            lvHabilitadas.Items.Remove(itmX)
            lvNoHabilitadas.Items.Add(itmNew)
        End If

    End Sub


    Private Sub btnInhablitarSeleccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInhablitarSeleccion.Click

        If lvHabilitadas.SelectedItems.Count = 1 Then
            If Not lvHabilitadas.FocusedItem Is Nothing Then
                HabilitarConsulta(False, lvHabilitadas.FocusedItem)
            End If
        End If

    End Sub

    Private Sub btnHabilitarSeleccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHabilitarSeleccion.Click

        If lvNoHabilitadas.SelectedItems.Count = 1 Then
            If Not lvNoHabilitadas.FocusedItem Is Nothing Then
                HabilitarConsulta(True, lvNoHabilitadas.FocusedItem)
            End If
        End If

    End Sub

    Private Sub btnInhabilitarTodas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInhabilitarTodas.Click

        Dim itmX As ListViewItem

        For Each itmX In lvHabilitadas.Items
            HabilitarConsulta(False, itmX)
        Next

    End Sub

    Private Sub btnHabilitarTodas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHabilitarTodas.Click

        Dim itmX As ListViewItem

        For Each itmX In lvNoHabilitadas.Items
            HabilitarConsulta(True, itmX)
        Next

    End Sub

    Private Sub lvHabilitadas_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvHabilitadas.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Not lvHabilitadas.FocusedItem Is Nothing Then
                HabilitarConsulta(False, lvHabilitadas.FocusedItem)
            End If
        End If
    End Sub

    Private Sub lvNoHabilitadas_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvNoHabilitadas.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Not lvNoHabilitadas.FocusedItem Is Nothing Then
                HabilitarConsulta(True, lvNoHabilitadas.FocusedItem)
            End If
        End If
    End Sub

    Private Sub DatosUsuario()

        Dim sSQL As String
        Dim ds As DataSet

        sSQL = "SELECT      * " & _
               "FROM        USUARI " & _
               "WHERE       US_CODUSU = " & nCodUsuario

        Try

            ds = oAdmTablas.AbrirDataset(sSQL)

            With ds.Tables(0)

                If .Rows.Count >= 1 Then
                    txtNombreLogin.Text = .Rows(0)("US_NOMBRE")
                    txtNombreCompleto.Text = .Rows(0)("US_DESCRI")
                    txtPassword.Text = cEncrypt.DecryptString128Bit(.Rows(0)("US_PASSWD"))
                    chkBloqueado.Checked = (.Rows(0)("US_LOCKED") <> 0)
                    chkEstado.Checked = (.Rows(0)("US_ESTADO") <> 0)
                    chkPermisoCategorias.Checked = (.Rows(0)("US_CATQRY") <> 0)
                    chkPermisoConexiones.Checked = (.Rows(0)("US_CNNQRY") <> 0)
                    chkPermisoDisenar.Checked = (.Rows(0)("US_DSNQRY") <> 0)
                    chkPermisoEjecutar.Checked = (.Rows(0)("US_EXEQRY") <> 0)
                    chkPermisoExportar.Checked = (.Rows(0)("US_EXPQRY") <> 0)
                    chkPermisoImportar.Checked = (.Rows(0)("US_IMPQRY") <> 0)
                    chkPermisoSeguridad.Checked = (.Rows(0)("US_ADMSEG") <> 0)
                    chkOpcionesGenerales.Checked = (.Rows(0)("US_OPCGRL") <> 0)
                    txtIntentos.Text = .Rows(0)("US_INTENT")
                    chkPermisoEliminar.Checked = (.Rows(0)("US_ELIQRY") <> 0)

                End If

            End With

            ' Cargar las consultas no habilitadas ...
            CargarPermisosConsultas()

        Catch ex As Exception
            TratarError(ex)
        End Try


    End Sub

    Private Function UsuarioExiste(ByVal sNombreLogin As String) As Boolean

        Dim sSQL As String
        Dim ds As DataSet

        sSQL = "SELECT  COUNT(1) AS XX_CUENTA " & _
               "FROM    USUARI " & _
               "WHERE   US_NOMBRE = '" & sNombreLogin & "' "

        ds = oAdmTablas.AbrirDataset(sSQL)

        With ds.Tables(0)
            Return .Rows(0)("XX_CUENTA") > 0
        End With

    End Function

    Private Function DatosOK() As Boolean

        If txtNombreLogin.Text.Trim = "" Then
            Tabs.SelectedTabPage = tpGeneral
            MensajeError(DescripcionCadena(Cadenas.CDN_frmUsuario_ValidarNombreLoginVacio))
            txtNombreLogin.Focus()
            Exit Function
        End If

        If MODO = "A" Then
            If UsuarioExiste(txtNombreLogin.Text.Trim) Then
                Tabs.SelectedTabPage = tpGeneral
                MensajeError(DescripcionCadena(Cadenas.CDN_frmUsuario_ValidarNombreLoginExiste))
                txtNombreLogin.Focus()
                Exit Function
            End If
        End If

        If txtNombreCompleto.Text.Trim = "" Then
            Tabs.SelectedTabPage = tpGeneral
            MensajeError(DescripcionCadena(Cadenas.CDN_frmUsuario_ValidarNombreCompletoVacio))
            txtNombreCompleto.Focus()
            Exit Function
        End If

        If txtPassword.Text = "" Then
            Tabs.SelectedTabPage = tpGeneral
            MensajeError(DescripcionCadena(Cadenas.CDN_frmUsuario_ValidarPasswordVacia))
            txtPassword.Focus()
            Exit Function
        End If

        DatosOK = True

    End Function

    Private Sub Actualizar()

        Dim sSQL As String
        Dim ds As DataSet
        Dim nId As Long
        Dim oRow As DataRow
        Dim da As OleDb.OleDbDataAdapter
        Dim cb As OleDb.OleDbCommandBuilder

        Cursor = Cursors.WaitCursor

        If MODO = "A" Then
            nId = oAdmTablas.ProximoID("USUARI", "US_CODUSU")
        Else
            nId = nCodUsuario
        End If

        sSQL = "SELECT  * " & _
               "FROM    USUARI " & _
               "WHERE   US_CODUSU = " & nId

        Try

            ds = oAdmTablas.AbrirDataset(sSQL, da)
            cb = New OleDb.OleDbCommandBuilder(da)

            With ds.Tables(0)

                If MODO = "A" Then

                    oRow = .NewRow()
                    oRow.Item("US_CODUSU") = nId
                    oRow.Item("US_NOMBRE") = txtNombreLogin.Text.Trim
                    oRow.Item("US_DESCRI") = txtNombreCompleto.Text.Trim
                    oRow.Item("US_PASSWD") = cEncrypt.EncryptString128Bit(txtPassword.Text)
                    oRow.Item("US_EXEQRY") = IIf(chkPermisoEjecutar.Checked, 1, 0)
                    oRow.Item("US_DSNQRY") = IIf(chkPermisoDisenar.Checked, 1, 0)
                    oRow.Item("US_CATQRY") = IIf(chkPermisoCategorias.Checked, 1, 0)
                    oRow.Item("US_IMPQRY") = IIf(chkPermisoImportar.Checked, 1, 0)
                    oRow.Item("US_EXPQRY") = IIf(chkPermisoExportar.Checked, 1, 0)
                    oRow.Item("US_ADMSEG") = IIf(chkPermisoSeguridad.Checked, 1, 0)
                    oRow.Item("US_CNNQRY") = IIf(chkPermisoConexiones.Checked, 1, 0)
                    oRow.Item("US_ESTADO") = IIf(chkEstado.Checked, 1, 0)
                    oRow.Item("US_LOCKED") = IIf(chkBloqueado.Checked, 1, 0)
                    oRow.Item("US_OPCGRL") = IIf(chkOpcionesGenerales.Checked, 1, 0)
                    oRow.Item("US_INTENT") = 0
                    oRow.Item("US_ELIQRY") = IIf(chkPermisoEliminar.Checked, 1, 0)

                    .Rows.Add(oRow)

                Else

                    oRow = .Rows(0)

                    oRow.BeginEdit()
                    oRow.Item("US_DESCRI") = txtNombreCompleto.Text.Trim
                    oRow.Item("US_PASSWD") = cEncrypt.EncryptString128Bit(txtPassword.Text)
                    oRow.Item("US_EXEQRY") = IIf(chkPermisoEjecutar.Checked, 1, 0)
                    oRow.Item("US_DSNQRY") = IIf(chkPermisoDisenar.Checked, 1, 0)
                    oRow.Item("US_CATQRY") = IIf(chkPermisoCategorias.Checked, 1, 0)
                    oRow.Item("US_IMPQRY") = IIf(chkPermisoImportar.Checked, 1, 0)
                    oRow.Item("US_EXPQRY") = IIf(chkPermisoExportar.Checked, 1, 0)
                    oRow.Item("US_ADMSEG") = IIf(chkPermisoSeguridad.Checked, 1, 0)
                    oRow.Item("US_CNNQRY") = IIf(chkPermisoConexiones.Checked, 1, 0)
                    oRow.Item("US_ESTADO") = IIf(chkEstado.Checked, 1, 0)
                    oRow.Item("US_LOCKED") = IIf(chkBloqueado.Checked, 1, 0)
                    oRow.Item("US_OPCGRL") = IIf(chkOpcionesGenerales.Checked, 1, 0)
                    oRow.Item("US_ELIQRY") = IIf(chkPermisoEliminar.Checked, 1, 0)
                    oRow.EndEdit()

                End If

                da.Update(ds)
                ds.AcceptChanges()

            End With

            ActualizarPermisosConsultas(nId)
            frmMainX.EstablecerPermisos()
            Cursor = Cursors.Default
            Me.Close()

        Catch ex As Exception
            Cursor = Cursors.Default
            TratarError(ex)
        End Try

    End Sub

    Private Sub CargarPermisosConsultas()

        Dim sSQL As String
        Dim ds As DataSet
        Dim itmX As ListViewItem
        Dim nI As Integer

        sSQL = "SELECT  IH_CODCON " & _
               "FROM    INHABI " & _
               "WHERE   IH_CODUSU = " & nCodUsuario

        Try

        ds = oAdmTablas.AbrirDataset(sSQL)

            With ds.Tables(0)
                For nI = 0 To .Rows.Count - 1
                    If ItemExiste("K" & .Rows(nI)("IH_CODCON").ToString, lvHabilitadas) Then
                        HabilitarConsulta(False, lvHabilitadas.Items("K" & .Rows(nI)("IH_CODCON").ToString))
                    End If
                Next
            End With

            ds = Nothing

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub ActualizarPermisosConsultas(ByVal nCodUser As Long)

        Dim sSQL As String
        Dim itmX As ListViewItem
        Dim nCodConsulta As Long

        sSQL = "DELETE FROM INHABI WHERE IH_CODUSU = " & nCodUser
        Call oAdmTablas.EjecutarComandoSQL(sSQL)

        For Each itmX In lvNoHabilitadas.Items

            nCodConsulta = Val(itmX.Tag.Substring(1))

            sSQL = "INSERT INTO INHABI (IH_CODUSU, IH_CODCON) VALUES (" & nCodUser & ", " & nCodConsulta & ")"
            Call oAdmTablas.EjecutarComandoSQL(sSQL)

        Next

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If DatosOK() Then
            Actualizar()
        End If
    End Sub
End Class