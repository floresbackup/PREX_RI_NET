Imports System.Windows.Forms

Public Class frmUsuario

   Private oAdmLocal As New AdmTablas
   Private bAlta As Boolean = True
   Private nCodUsu As Long = 0

   Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

      If DatosOK() Then
         If actualizar() Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
         End If
      End If

   End Sub

   Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
      Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub

   Public Sub New()

      ' Llamada necesaria para el Diseñador de Windows Forms.
      InitializeComponent()

      ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
      oAdmLocal.ConnectionString = CONN_LOCAL
      Cargar()

   End Sub

   Private Sub Cargar()

      Dim sSQL As String

      sSQL = "SELECT    0, '(Todas)' " & _
             "UNION " & _
             "SELECT    TG_CODCON, TG_DESCRI " & _
             "FROM      TABGEN " & _
             "WHERE     TG_CODTAB = 1 " & _
             "AND       TG_CODCON <> 999999 " & _
             "ORDER BY  2"
      CargarCombo(cboEntidad, sSQL)

      SelItemCombo(cboEntidad, CODIGO_ENTIDAD)

      sSQL = "SELECT    GR_CODGRU, GR_DESCRI " & _
             "FROM      GRUPOS " & _
             "ORDER BY  GR_DESCRI"
      CargarCombo(cboGrupos, sSQL)

      sSQL = "SELECT    MU_CODTRA, CAST(MU_CODTRA AS VARCHAR) + ' - ' + MU_TRANSA " & _
             "FROM      MENUES " & _
             "WHERE     MU_CODTRA <> 0 " & _
             "ORDER BY  MU_CODTRA "
      CargarCombo(cboHab, sSQL)

      sSQL = "SELECT    MU_CODTRA, CAST(MU_CODTRA AS VARCHAR) + ' - ' + MU_TRANSA " & _
             "FROM      MENUES " & _
             "WHERE     MU_CODTRA <> 0 " & _
             "ORDER BY  MU_CODTRA "
      CargarCombo(cboDesHab, sSQL)

   End Sub

   Private Sub cargarGrupos()

      Dim sSQL As String
      Dim ds As DataSet
      Dim item As ListViewItem

      Try

         sSQL = "SELECT       * " & _
                "FROM         GRUPOS " & _
                "INNER JOIN   USUGRU " & _
                "ON           UG_CODGRU = GR_CODGRU " & _
                "WHERE        UG_CODUSU = " & nCodUsu.ToString & " " & _
                "ORDER BY     GR_DESCRI ASC"
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)

            For Each row As DataRow In .Rows

               item = lvGrupos.Items.Add(row("GR_DESCRI"))
               item.Name = row("GR_CODGRU")

               QuitarItemCombo(cboGrupos, row("GR_CODGRU"))

            Next

         End With

         ds = Nothing

      Catch ex As Exception
         TratarError(ex, "cargarGrupos")
      End Try

   End Sub

   Private Sub cargarHabilitaciones()

      Dim sSQL As String
      Dim ds As DataSet
      Dim item As ListViewItem

      Try

         sSQL = "SELECT       * " & _
                "FROM         HABEXT " & _
                "INNER JOIN   MENUES " & _
                "ON           MU_CODTRA = HE_CODTRA " & _
                "WHERE        HE_CODUSU = " & nCodUsu.ToString & " " & _
                "ORDER BY     HE_CODTRA ASC"
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)

            For Each row As DataRow In .Rows

               If row("HE_HABILI") = 1 Then
                  item = lvHab.Items.Add(row("MU_CODTRA") & " - " & row("MU_TRANSA"))
               Else
                  item = lvDeshab.Items.Add(row("MU_CODTRA") & " - " & row("MU_TRANSA"))
               End If

               item.Name = row("HE_CODTRA")

            Next

         End With

         ds = Nothing

      Catch ex As Exception
         TratarError(ex, "cargarGrupos")
      End Try

   End Sub

   Private Function DatosOK() As Boolean

      If txtNombreInicioSesion.Text.Trim = "" Then
         MensajeError("Proporcione el nombre para el inicio de sesión")
         tabProp.Focus()
         txtNombreInicioSesion.Focus()
         Return False
      End If

      If nCodUsu <> 0 Then
         If oAdmLocal.DevolverValor("USUARI", "COUNT(*)", "WHERE US_NOMBRE='" & txtNombreInicioSesion.Text.Trim & "'", 0) <> 0 Then
            MensajeError("El nombre de inicio de sesión que intenta registrar ya fue asignado a otro usuario")
            tabProp.Focus()
            txtNombreInicioSesion.Focus()
            Return False
         End If
      End If

      If txtNombreCompleto.Text.Trim = "" Then
         MensajeError("Proporcione el nombre del usuario")
         tabProp.Focus()
         txtNombreCompleto.Focus()
         Return False
      End If

      If Not IsDate(txtFechaVtoPassword.Text.Trim) Then
         MensajeError("Fecha inválida")
         tabProp.Focus()
         txtFechaVtoPassword.Focus()
         Return False
      End If

      If cboEntidad.SelectedItem Is Nothing Then
         MensajeError("Seleccione la entidad a la que pertenece, o bien indique la opción '(Todas)'")
         tabProp.Focus()
         cboEntidad.Focus()
         Return False
      End If

      If Not txtPassword.Enabled Then
         If txtPassword.Text.Trim = "" Then
            MensajeError("Proporcione la contraseña inicial del usuario")
            tabProp.Focus()
            txtPassword.Focus()
            Return False
         End If
         If txtConfirmacion.Text <> txtPassword.Text Then
            MensajeError("La contraseña no coincide con la confirmación")
            tabProp.Focus()
            txtConfirmacion.Focus()
            Return False
         End If
      End If

      Return True

   End Function

   Private Function actualizar() As Boolean

      Dim sSQL As String
      Dim ds As DataSet
      Dim cb As OleDb.OleDbCommandBuilder
      Dim da As OleDb.OleDbDataAdapter
      Dim row As DataRow
      Dim itmX As ListViewItem

      Try

         ' DATOS DEL USUARIO *****************

         If nCodUsu = 0 Then
            nCodUsu = oAdmLocal.ProximoID("USUARI", "US_CODUSU")
         End If

         sSQL = "SELECT       * " & _
                "FROM         USUARI " & _
                "WHERE        US_CODUSU = " & nCodUsu
         ds = oAdmLocal.AbrirDataset(sSQL, da)
         cb = New OleDb.OleDbCommandBuilder(da)

         With ds.Tables(0)

            If .Rows.Count = 0 Then

               row = .NewRow()

               row("US_CODUSU") = nCodUsu
               row("US_NOMBRE") = txtNombreInicioSesion.Text.Trim
               row("US_PASSWO") = CalculateMD5(txtPassword.Text)
               row("US_PASS01") = ""
               row("US_PASS02") = ""
               row("US_PASS03") = ""
               row("US_PASS04") = ""
               row("US_PASS05") = ""
               row("US_FECALT") = Date.Today
               row("US_FECBAJ") = "01-01-1900"
               row("US_GRACIA") = DirectivaVigente.IntentosBloqueo
               row("US_ENCRYP") = CalculateMD5(txtPassword.Text)

            Else

               row = .Rows(0)

            End If

            row("US_DESCRI") = txtNombreCompleto.Text.Trim
            row("US_FECVTO") = CDate(txtFechaVtoPassword.Text)
            row("US_BLOQUE") = IIf(chkBloqueado.Checked, 1, 0)
            row("US_ADMIN") = IIf(chkAdmin.Checked, 1, 0)
            row("US_CODENT") = LlaveCombo(cboEntidad)
            row("US_CORREO") = txtCorreo.Text.Trim
            row("US_INTERN") = txtInterno.Text.Trim

            For Each col As DataColumn In .Columns
               If col.ColumnName.ToUpper = "US_READER" Then
                  row("US_READER") = IIf(chkSoloLectura.Checked, 1, 0)
                  Exit For
               End If
            Next

            If .Rows.Count = 0 Then
               .Rows.Add(row)
            End If

            da.Update(ds)
            ds.AcceptChanges()

         End With

         ds = Nothing
         cb = Nothing
         da = Nothing

         ' PERTENENCIA A GRUPOS *****************

         sSQL = "DELETE       " & _
                "FROM         USUGRU " & _
                "WHERE        UG_CODUSU = " & nCodUsu
         oAdmLocal.EjecutarComandoSQL(sSQL)

         For Each itmX In lvGrupos.Items

            sSQL = "INSERT    " & _
                   "INTO      USUGRU " & _
                   "          (UG_CODUSU, UG_CODGRU) " & _
                   "VALUES    (" & nCodUsu & ", " & itmX.Name & ")"
            oAdmLocal.EjecutarComandoSQL(sSQL)

         Next

         ' HAB.ESPECIALES *****************
         sSQL = "DELETE       " & _
                "FROM         HABEXT " & _
                "WHERE        HE_HABILI = 1 " & _
                "AND          HE_CODUSU = " & nCodUsu
         oAdmLocal.EjecutarComandoSQL(sSQL)

         For Each itmX In lvHab.Items

            sSQL = "INSERT    " & _
                   "INTO      HABEXT " & _
                   "          (HE_CODUSU, HE_HABILI, HE_CODTRA) " & _
                   "VALUES    (" & nCodUsu & ", 1, " & itmX.Name & ")"
            oAdmLocal.EjecutarComandoSQL(sSQL)

         Next

         ' INHAB.ESPECIALES *****************
         sSQL = "DELETE       " & _
                "FROM         HABEXT " & _
                "WHERE        HE_HABILI = 0 " & _
                "AND          HE_CODUSU = " & nCodUsu
         oAdmLocal.EjecutarComandoSQL(sSQL)

         For Each itmX In lvDeshab.Items

            sSQL = "INSERT    " & _
                   "INTO      HABEXT " & _
                   "          (HE_CODUSU, HE_HABILI, HE_CODTRA) " & _
                   "VALUES    (" & nCodUsu & ", 0, " & itmX.Name & ")"
            oAdmLocal.EjecutarComandoSQL(sSQL)

         Next

         Return True

      Catch ex As Exception
         TratarError(ex, "actualizar")
      End Try

   End Function

   Public Sub PasarDatos(ByVal nUsuario As Long)

      Dim sSQL As String
      Dim ds As DataSet
      Dim row As DataRow

      Try

         nCodUsu = nUsuario

         cargarGrupos()
         cargarHabilitaciones()

         sSQL = "SELECT * " & _
                "FROM   USUARI " & _
                "WHERE  US_CODUSU = " & nCodUsu.ToString & " "
         ds = oAdmLocal.AbrirDataset(sSQL)

         If ds.Tables(0).Rows.Count > 0 Then

            row = ds.Tables(0).Rows(0)

            txtNombreInicioSesion.Text = row("US_NOMBRE")
            txtNombreCompleto.Text = "" & row("US_DESCRI")
            SelItemCombo(cboEntidad, row("US_CODENT"))
            txtFechaVtoPassword.Text = "" & row("US_FECVTO")
            txtFechaAlta.Text = "" & row("US_FECALT")

            If row("US_FECBAJ") > CDate("01-01-1900") Then
               txtFechaBaja.Text = "" & row("US_FECBAJ")
            End If

            txtIntentosRestantes.Text = row("US_GRACIA")
            chkBloqueado.Checked = IIf(row("US_BLOQUE") <> 0, True, False)
            chkAdmin.Checked = IIf(row("US_ADMIN") <> 0, True, False)
            txtCorreo.Text = "" & row("US_CORREO")
            txtInterno.Text = "" & row("US_INTERN")
            Me.txtIntentosRestantes.Text = "" & row("US_GRACIA")

            For Each col As DataColumn In ds.Tables(0).Columns
               If col.ColumnName.ToUpper = "US_READER" Then
                  chkSoloLectura.Checked = IIf(row("US_READER") <> 0, True, False)
               End If
            Next

         End If

         ds = Nothing

         txtNombreInicioSesion.Enabled = False

         bAlta = False

         ds = Nothing

      Catch ex As Exception
         TratarError(ex, "PasarDatos")
      End Try

   End Sub

   Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

      Dim item As ListViewItem
      Dim itemCombo As Prex.Utils.Entities.clsItem

      If Not (cboGrupos.SelectedItem Is Nothing) Then

         itemCombo = cboGrupos.SelectedItem
         item = lvGrupos.Items.Add(itemCombo.Nombre)
         item.Name = itemCombo.Valor.ToString
         item.ImageKey = "Grupo"
         cboGrupos.Items.Remove(itemCombo)

      End If

   End Sub

   Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click

      On Error Resume Next

      Dim item As ListViewItem

      If Not (lvGrupos.SelectedItems(0) Is Nothing) Then

         item = lvGrupos.SelectedItems(0)
         cboGrupos.Items.Add(New Prex.Utils.Entities.clsItem(item.Name, item.Text))
         lvGrupos.SelectedItems(0).Remove()

      End If

   End Sub

   Private Sub cmdAgregarHab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarHab.Click

      Dim item As ListViewItem
      Dim itemCombo As Prex.Utils.Entities.clsItem
      Dim items() As ListViewItem

      If Not (cboHab.SelectedItem Is Nothing) Then

         itemCombo = cboHab.SelectedItem

         items = lvHab.Items.Find(itemCombo.Valor.ToString, True)

         If items.Length = 0 Then
            item = lvHab.Items.Add(itemCombo.Nombre)
            item.Name = itemCombo.Valor.ToString
            item.ImageKey = "Hab"

            items = lvDeshab.Items.Find(item.Name, True)
            If items.Length > 0 Then
               lvDeshab.Items.Remove(items(0))
            End If
         End If

      End If

   End Sub

   Private Sub cmdAgregarDeshab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarDeshab.Click

      Dim item As ListViewItem
      Dim itemCombo As Prex.Utils.Entities.clsItem
      Dim items() As ListViewItem

      If Not (cboDesHab.SelectedItem Is Nothing) Then

         itemCombo = cboDesHab.SelectedItem

         items = lvDeshab.Items.Find(itemCombo.Valor.ToString, True)

         If items.Length = 0 Then
            item = lvDeshab.Items.Add(itemCombo.Nombre)
            item.Name = itemCombo.Valor.ToString
            item.ImageKey = "Deshab"

            items = lvHab.Items.Find(item.Name, True)
            If items.Length > 0 Then
               lvHab.Items.Remove(items(0))
            End If
         End If

      End If


   End Sub

   Private Sub cmdQuitarDeshab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitarDeshab.Click

      Dim item As ListViewItem

      If lvDeshab.SelectedItems.Count <> 0 Then

         item = lvDeshab.SelectedItems(0)

         If Pregunta("¿Quitar " & item.Text & "?") = Windows.Forms.DialogResult.Yes Then
            lvDeshab.SelectedItems(0).Remove()
         End If

      End If

   End Sub

   Private Sub cmdQuitarHab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitarHab.Click

      Dim item As ListViewItem

      If lvHab.SelectedItems.Count <> 0 Then

         item = lvHab.SelectedItems(0)

         If Pregunta("¿Quitar " & item.Text & "?") = Windows.Forms.DialogResult.Yes Then
            lvHab.SelectedItems(0).Remove()
         End If

      End If

   End Sub

End Class
