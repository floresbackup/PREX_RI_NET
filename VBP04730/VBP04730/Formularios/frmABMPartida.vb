Imports System.Windows.Forms

Public Class frmABMPartida

   Private oAdmLocal As New AdmTablas

   Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

      If datosOK() Then
         guardar()
         Me.DialogResult = System.Windows.Forms.DialogResult.OK
         Me.Close()
      End If

   End Sub

   Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
      Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub

   Public Sub PasarNuevo(ByVal nCodEnt As Long, _
                         ByVal nCuadro As Long, _
                         ByVal dFecVig As Date)

      SelItemCombo(cboEntidad, nCodEnt)
      SelItemCombo(cboCuadro, nCuadro)
      fecFecVig.Value = dFecVig

      cargarCampo8()
      proximoOrden()

      cboCampo8.SelectedIndex = 0
      cboActiva.SelectedIndex = 1
      cboCreoRend.SelectedIndex = 0
      cboMonFij.SelectedIndex = 0
      txtOperacion.Text = "1"
      txtNivel.Text = "1"
      txtRelativo.Text = "SEBA"
      txtIndex.Text = oAdmLocal.ProximoID("TABPAR", "TK_INDEX")

   End Sub

   Public Sub PasarDatos(ByVal nCodEnt As Long, _
                         ByVal nCuadro As Long, _
                         ByVal dFecVig As Date, _
                         ByVal nCodPar As Double, _
                         ByVal nCampo8 As Long, _
                         Optional ByVal bDesactiva As Boolean = False)

      Dim ds As DataSet
      Dim sSQL As String

      Try

         sSQL = "SELECT       * " & _
                "FROM         TABPAR " & _
                "WHERE        TK_FECVIG = " & FechaSQL(dFecVig) & " " & _
                "AND          TK_CODENT = " & nCodEnt & " " & _
                "AND          TK_CODPAR = " & nCodPar & " " & _
                "AND          TK_CAMPO8 = " & nCampo8 & " " & _
                "AND          TK_CUADRO = " & nCuadro & " "
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)
            If .Rows.Count > 0 Then

               Dim row As DataRow = .Rows(0)

               fecFecVig.Value = row("TK_FECVIG")
               SelItemCombo(cboEntidad, row("TK_CODENT"))
               SelItemCombo(cboCuadro, row("TK_CUADRO"))
               txtCodPar.Text = row("TK_CODPAR")
               cargarCampo8()
               SelItemCombo(cboCampo8, row("TK_CAMPO8"))
               txtDescri.Text = row("TK_DESCRI")
               txtDCorta.Text = row("TK_DCORTA")
               SelItemCombo(cboActiva, row("TK_ACTIVA"))
               SelItemCombo(cboCreoRend, row("TK_CREOREND"))
               SelItemCombo(cboMonFij, row("TK_MONFIJ"))
               txtOrden.Text = row("TK_ORDEN")
               txtOperacion.Text = row("TK_OPERACION")
               txtNivel.Text = row("TK_NIVEL")
               txtRelativo.Text = row("TK_RELATIVO")
               txtIndex.Text = row("TK_INDEX")

            End If
         End With

         ds = Nothing

         fecFecVig.Enabled = False
         cboEntidad.Enabled = False
         cboCuadro.Enabled = False
         txtCodPar.Enabled = False
         cboCampo8.Enabled = False

         If bDesactiva Then
            cboActiva.SelectedIndex = 0
            txtDescri.Enabled = False
            txtDCorta.Enabled = False
            cboActiva.Enabled = False
            cboCreoRend.Enabled = False
            cboMonFij.Enabled = False
            txtOrden.Enabled = False
            txtOperacion.Enabled = False
            OK_Button.Text = "&Desactivar"
         End If

      Catch ex As Exception
         TratarError(ex, "PasarDatos")
      End Try

   End Sub

   Public Sub New()

      ' Llamada necesaria para el Diseñador de Windows Forms.
      InitializeComponent()

      ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
      oAdmLocal.ConnectionString = CONN_LOCAL
      cargar()

   End Sub

   Private Sub cargar()

      Dim sSQL As String

      Try

         sSQL = "SELECT    TG_CODCON, TG_DESCRI " & _
                "FROM      TABGEN " & _
                "WHERE     TG_CODTAB = 1 " & _
                "AND       TG_CODCON <> 999999 " & _
                "ORDER BY  TG_DESCRI "
         CargarCombo(cboEntidad, sSQL)

         sSQL = "SELECT    TG_CODCON, TG_DESCRI " & _
                "FROM      TABGEN " & _
                "WHERE     TG_CODTAB = 2 " & _
                "AND       TG_CODCON <> 999999 " & _
                "ORDER BY  TG_CODCON "
         CargarCombo(cboCuadro, sSQL)

         sSQL = "SELECT    0 AS TG_CODCON, 'No' AS TG_DESCRI " & _
                "UNION " & _
                "SELECT    1, 'Si' "
         CargarCombo(cboActiva, sSQL)

         sSQL = "SELECT    0 AS TG_CODCON, 'No' AS TG_DESCRI " & _
                "UNION " & _
                "SELECT    1, 'Si' " & _
                "UNION " & _
                "SELECT    2, 'Agrega fila' "
         CargarCombo(cboMonFij, sSQL)

         sSQL = "SELECT    0 AS TG_CODCON, 'Crecimiento' AS TG_DESCRI " & _
                "UNION " & _
                "SELECT    1, 'Rendimiento' "
         CargarCombo(cboCreoRend, sSQL)

      Catch ex As Exception
         TratarError(ex, "cargar")
      End Try

   End Sub

   Private Sub cboCuadro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuadro.SelectedIndexChanged
      cargarCampo8()
      proximoOrden()
   End Sub

   Private Sub cargarCampo8()

      Dim sSQL As String

      Try

         cboCampo8.Items.Clear()

         If Not (LlaveCombo(cboCuadro) Is Nothing) Then
            sSQL = "SELECT    TG_NUME02, TG_DESCRI " & _
                   "FROM      TABGEN " & _
                   "WHERE     TG_CODTAB = 5 " & _
                   "AND       TG_CODCON <> 999999 " & _
                   "AND       TG_NUME01 = " & LlaveCombo(cboCuadro) & " " & _
                   "ORDER BY  TG_CODCON "
            CargarCombo(cboCampo8, sSQL)
         End If

         If cboCampo8.Items.Count = 0 Then
            AgregarItemCombo(cboCampo8, 0, "No Aplica")
            cboCampo8.SelectedIndex = 0
         End If

      Catch ex As Exception
         TratarError(ex, "cargarCampo8")
      End Try

   End Sub

   Private Sub proximoOrden()

      Dim nProx As Long

      nProx = oAdmLocal.DevolverValor("TABPAR", "IsNull(MAX(CAST(TK_ORDEN AS INT)) + 10, 0)", _
                                       "    TK_CODENT = " & LlaveCombo(cboEntidad) & " " & _
                                       "AND TK_FECVIG = " & FechaSQL(fecFecVig.Value) & " " & _
                                       "AND TK_CUADRO = " & LlaveCombo(cboCuadro), "0")


      txtOrden.Text = Format(nProx, "0000")

   End Sub

   Private Sub cboEntidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEntidad.SelectedIndexChanged
      cargarCampo8()
      proximoOrden()
   End Sub

   Private Function datosOK() As Boolean

      If FechaCorrecta(Month(fecFecVig.Value), Year(fecFecVig.Value)) <> fecFecVig.Value Then
         MensajeError("La fecha de vigencia no es fin de mes")
         fecFecVig.Focus()
         Exit Function
      End If

      If cboEntidad.SelectedItem Is Nothing Then
         MensajeError("Debe especificar una entidad")
         cboEntidad.Focus()
         Exit Function
      End If

      If cboCuadro.SelectedItem Is Nothing Then
         MensajeError("Debe especificar un cuadro")
         cboCuadro.Focus()
         Exit Function
      End If

      If Not IsNumeric(txtCodPar.Text) Then
         MensajeError("Debe especificar un código de partida")
         txtCodPar.Focus()
         Exit Function
      End If

      If cboCampo8.SelectedItem Is Nothing Then
         MensajeError("Debe especificar una referencia")
         cboCampo8.Focus()
         Exit Function
      End If

      If txtDescri.Text.Trim = "" Then
         MensajeError("Debe especificar una descripción")
         txtDescri.Focus()
         Exit Function
      End If

      If txtDCorta.Text.Trim = "" Then
         MensajeError("Debe especificar una descripción corta")
         txtDCorta.Focus()
         Exit Function
      End If

      If Not IsNumeric(txtOrden.Text) Then
         MensajeError("Debe especificar un orden")
         txtOrden.Focus()
         Exit Function
      End If

      If Not IsNumeric(txtOperacion.Text) Then
         MensajeError("Debe especificar una operación")
         txtOperacion.Focus()
         Exit Function
      End If

      Return True

   End Function

   Private Sub guardar()

      Dim ds As DataSet
      Dim cb As OleDb.OleDbCommandBuilder
      Dim da As OleDb.OleDbDataAdapter
      Dim sSQL As String
      Dim row As DataRow

      sSQL = "SELECT       * " & _
             "FROM         TABPAR " & _
             "WHERE        TK_FECVIG = " & FechaSQL(fecFecVig.Value) & " " & _
             "AND          TK_CODENT = " & LlaveCombo(cboEntidad) & " " & _
             "AND          TK_CUADRO = " & LlaveCombo(cboCuadro) & " " & _
             "AND          TK_CODPAR = " & txtCodPar.Text & " " & _
             "AND          TK_CAMPO8 = " & LlaveCombo(cboCampo8)

      ds = oAdmLocal.AbrirDataset(sSQL, da)
      cb = New OleDb.OleDbCommandBuilder(da)

      If ds.Tables(0).Rows.Count = 0 Then
         row = ds.Tables(0).NewRow
      Else
         row = ds.Tables(0).Rows(0)
      End If

      row("TK_FECVIG") = fecFecVig.Value
      row("TK_CODENT") = LlaveCombo(cboEntidad)
      row("TK_CUADRO") = LlaveCombo(cboCuadro)
      row("TK_CODPAR") = Val(txtCodPar.Text)
      row("TK_CAMPO8") = LlaveCombo(cboCampo8)
      row("TK_DESCRI") = txtDescri.Text
      row("TK_DCORTA") = txtDCorta.Text
      row("TK_ACTIVA") = LlaveCombo(cboActiva)
      row("TK_CREOREND") = LlaveCombo(cboCreoRend)
      row("TK_MONFIJ") = LlaveCombo(cboMonFij)
      row("TK_ORDEN") = txtOrden.Text
      row("TK_OPERACION") = txtOperacion.Text
      row("TK_NIVEL") = Val(txtNivel.Text)
      row("TK_RELATIVO") = txtRelativo.Text
      row("TK_INDEX") = Val(txtIndex.Text)

      If ds.Tables(0).Rows.Count = 0 Then
         ds.Tables(0).Rows.Add(row)
      End If

      da.Update(ds)
      ds.AcceptChanges()

   End Sub

End Class
