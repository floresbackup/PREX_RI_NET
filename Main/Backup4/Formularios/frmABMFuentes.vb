Imports System.Windows.Forms

Public Class frmABMFuentes

   Private oadmLocal As New AdmTablas

   Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

      If datosOK() Then
         If guardar() Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
         End If
      End If

   End Sub

   Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
      Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub

   Public Sub PasarNuevo()

   End Sub

   Private Sub cargar()

      Dim sSQL As String

      Try

         fecFecVig.Value = DateTime.Today

         sSQL = "SELECT    TG_CODCON, TG_DESCRI " & _
                "FROM      TABGEN " & _
                "WHERE     TG_CODTAB = 1 " & _
                "AND       TG_CODCON <> 999999 " & _
                "ORDER BY  TG_DESCRI "
         CargarCombo(cboCodEnt, sSQL)

         If cboCodEnt.Items.Count > 0 Then
            SelItemCombo(cboCodEnt, CODIGO_ENTIDAD)
         End If

         txtCodCue.Text = "0"
         txtDescri.Text = ""
         chkActiva.Checked = True

      Catch ex As Exception
         TratarError(ex, "cargar")
      End Try

   End Sub

   Public Sub New()

      ' Llamada necesaria para el Diseñador de Windows Forms.
      InitializeComponent()

      ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
      oadmLocal.ConnectionString = CONN_LOCAL
      cargar()

   End Sub

   Public Sub PasarNuevo(ByVal dFecVig As Date, _
                         ByVal sTabla As String)

      fecFecVig.Value = dFecVig
      txtTabla.Text = sTabla

   End Sub

   Public Sub PasarDatos(ByVal dFecVig As Date, _
                         ByVal sTabla As String, _
                         ByVal nCodEnt As Long, _
                         ByVal nCodCue As Double, _
                         ByVal sDescri As String, _
                         ByVal bActiva As Boolean, _
                         Optional ByVal bDesactivar As Boolean = False)

      fecFecVig.Value = dFecVig
      txtTabla.Text = sTabla
      SelItemCombo(cboCodEnt, nCodEnt)
      txtCodCue.Text = nCodCue.ToString
      txtDescri.Text = sDescri
      chkActiva.Checked = bActiva

      If bDesactivar Then
         chkActiva.Checked = False
         fecFecVig.Enabled = False
         cboCodEnt.Enabled = False
         txtCodCue.Enabled = False
         txtDescri.Enabled = False
         chkActiva.Enabled = False
         OK_Button.Text = "&Desactivar"
      End If

   End Sub

   Private Function guardar() As Boolean

      Dim ds As DataSet
      Dim cb As OleDb.OleDbCommandBuilder
      Dim da As OleDb.OleDbDataAdapter
      Dim sSQL As String
      Dim row As DataRow

      Try

         sSQL = "SELECT       * " & _
                "FROM         TABCUE " & _
                "WHERE        TU_FECVIG = " & FechaSQL(fecFecVig.Value) & " " & _
                "AND          TU_CODENT = " & LlaveCombo(cboCodEnt) & " " & _
                "AND          TU_CODCUE = " & txtCodCue.Text & " " & _
                "AND          TU_TABLA  = '" & txtTabla.Text & "' "
         ds = oadmLocal.AbrirDataset(sSQL, da)
         cb = New OleDb.OleDbCommandBuilder(da)

         If ds.Tables(0).Rows.Count = 0 Then
            row = ds.Tables(0).NewRow
         Else
            row = ds.Tables(0).Rows(0)
         End If

         row("TU_FECVIG") = fecFecVig.Value
         row("TU_CODENT") = LlaveCombo(cboCodEnt)
         row("TU_CODCUE") = Val(txtCodCue.Text)
         row("TU_DESCRI") = txtDescri.Text
         row("TU_ACTIVA") = chkActiva.Checked
         row("TU_TABLA") = txtTabla.Text

         If ds.Tables(0).Rows.Count = 0 Then
            ds.Tables(0).Rows.Add(row)
         End If

         da.Update(ds)
         ds.AcceptChanges()

         Return True

      Catch ex As Exception
         TratarError(ex, "guardar")
      End Try

   End Function

   Private Function datosOK() As Boolean

      If cboCodEnt.SelectedItem Is Nothing Then
         MensajeError("Debe especificar la entidad")
         cboCodEnt.Focus()
         Exit Function
      End If

      If Not IsNumeric(txtCodCue.Text) Then
         MensajeError("Especifique un valor numérico para el código")
         txtCodCue.Focus()
         Exit Function
      End If

      Return True

   End Function

End Class
