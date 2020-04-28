Imports System.Windows.Forms

Public Class frmAbmRelTec

   Dim oAdmLocal As New AdmTablas

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

   Private Sub cmdCodPar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCodPar.Click

      Dim sSQL As String
      Dim oTG As New frmTablaGeneral

      sSQL = "SELECT    TK_CODPAR, TK_DESCRI " & _
             "FROM      TABPAR " & _
             "WHERE     TK_CODENT = " & LlaveCombo(cboCodEnt) & " " & _
             "AND       TK_FECVIG = " & FechaSQL(LlaveCombo(cboFecVig)) & " " & _
             "ORDER BY  TK_CODPAR"
      oTG.PasarInfo(sSQL, CONN_LOCAL, 1, False, "Partidas")

      If oTG.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
         txtCodPar.Text = INPUT_GENERAL
      End If

      oTG = Nothing

   End Sub

   Private Function guardar() As Boolean

      Dim ds As DataSet
      Dim cb As OleDb.OleDbCommandBuilder
      Dim da As OleDb.OleDbDataAdapter = Nothing
      Dim sSQL As String
      Dim row As DataRow

      Try

         sSQL = "SELECT    * " & _
                "FROM      RELTEC " & _
                "WHERE     RT_CODENT = " & LlaveCombo(cboCodEnt) & " " & _
                "AND       RT_CUADRO = " & LlaveCombo(cboCuadro) & " " & _
                "AND       RT_CODPAR = " & txtCodPar.Text & " " & _
                "AND       RT_CODRTC = " & txtCODRTC.Text
         ds = oAdmLocal.AbrirDataset(sSQL, da)
         cb = New OleDb.OleDbCommandBuilder(da)

         If ds.Tables(0).Rows.Count = 0 Then
            row = ds.Tables(0).NewRow
         Else
            row = ds.Tables(0).Rows(0)
         End If

         If OK_Button.Text = "&Eliminar" Then

            ds.Tables(0).Rows(0).Delete()

         Else

            row("RT_FECVIG") = LlaveCombo(cboFecVig)
            row("RT_CODENT") = LlaveCombo(cboCodEnt)
            row("RT_CUADRO") = LlaveCombo(cboCuadro)
            row("RT_CODPAR") = Val(txtCodPar.Text)
            row("RT_CODRTC") = Val(txtCODRTC.Text)
            row("RT_EOAFNG") = IIf(txtEOAFNG.Text.Trim = "", DBNull.Value, Val(txtEOAFNG.Text))

            If ds.Tables(0).Rows.Count = 0 Then
               ds.Tables(0).Rows.Add(row)
            End If

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

      If cboCuadro.SelectedItem Is Nothing Then
         MensajeError("Debe especificar la entidad")
         cboCuadro.Focus()
         Exit Function
      End If

      If Not IsNumeric(txtCodPar.Text) Then
         MensajeError("Especifique un valor numérico para la partida")
         txtCodPar.Focus()
         Exit Function
      End If

      If Not IsNumeric(txtCODRTC.Text) Then
         MensajeError("Especifique un valor numérico para la relación 1")
         txtCODRTC.Focus()
         Exit Function
      End If

      If txtEOAFNG.Text.Trim <> "" Then
         If Not IsNumeric(txtEOAFNG.Text) Then
            MensajeError("Especifique un valor numérico para la relación 2")
            txtEOAFNG.Focus()
            Exit Function
         End If
      End If

      Return True

   End Function

   Private Sub cargar()

      Dim sSQL As String
      Dim ds As DataSet

      'Fecha vigencia
      cboFecVig.Items.Clear()

      sSQL = "SELECT    DISTINCT TK_FECVIG " & _
             "FROM      TABPAR " & _
             "WHERE     TK_CODENT = " & CODIGO_ENTIDAD & " " & _
             "AND       TK_ACTIVA = 1 " & _
             "ORDER BY  TK_FECVIG DESC"
      ds = oAdmLocal.AbrirDataset(sSQL)

      With ds.Tables(0)
         For Each row As DataRow In .Rows
            cboFecVig.Items.Add(New Prex.Utils.Entities.clsItem(row("TK_FECVIG"), row("TK_FECVIG")))
         Next
      End With

      ds = Nothing

      If cboFecVig.Items.Count > 0 Then
         cboFecVig.SelectedIndex = 0
      End If

      'Entidad
      cboCodEnt.Items.Clear()

      sSQL = "SELECT    TG_CODCON, TG_DESCRI " & _
             "FROM      TABGEN " & _
             "WHERE     TG_CODTAB = 1 " & _
             "AND       TG_CODCON <> 999999 " & _
             "ORDER BY  TG_DESCRI "
      ds = oAdmLocal.AbrirDataset(sSQL)

      With ds.Tables(0)
         For Each row As DataRow In .Rows
            cboCodEnt.Items.Add(New Prex.Utils.Entities.clsItem(row("TG_CODCON"), row("TG_DESCRI")))
         Next
      End With

      ds = Nothing

      SelItemCombo(cboCodEnt, CODIGO_ENTIDAD)

      'Cuadro
      cboCuadro.Items.Clear()

      sSQL = "SELECT    TG_CODCON, TG_DESCRI " & _
             "FROM      TABGEN " & _
             "WHERE     TG_CODTAB = 2 " & _
             "AND       TG_CODCON <> 999999 " & _
             "ORDER BY  TG_CODCON "
      ds = oAdmLocal.AbrirDataset(sSQL)

      With ds.Tables(0)
         For Each row As DataRow In .Rows
            cboCuadro.Items.Add(New Prex.Utils.Entities.clsItem(row("TG_CODCON"), row("TG_DESCRI")))
         Next
      End With

      ds = Nothing

      If cboCuadro.Items.Count > 0 Then
         cboCuadro.SelectedIndex = 0
      End If

   End Sub

   Public Sub New()

      ' Llamada necesaria para el Diseñador de Windows Forms.
      InitializeComponent()

      ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
      oAdmLocal.ConnectionString = CONN_LOCAL
      cargar()

   End Sub

   Private Sub cmdCODRTC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCODRTC.Click

      Dim sSQL As String
      Dim oTG As New frmTablaGeneral

      sSQL = "SELECT    TK_CODPAR, TK_DESCRI " & _
             "FROM      TABPAR " & _
             "WHERE     TK_CODENT = " & LlaveCombo(cboCodEnt) & " " & _
             "AND       TK_CUADRO = " & LlaveCombo(cboCuadro) & " " & _
             "AND       TK_FECVIG = " & FechaSQL(LlaveCombo(cboFecVig)) & " " & _
             "ORDER BY  TK_CODPAR"
      oTG.PasarInfo(sSQL, CONN_LOCAL, 1, False, "Relación 1")

      If oTG.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
         txtCODRTC.Text = INPUT_GENERAL
      End If

      oTG = Nothing

   End Sub

   Private Sub cmdEOAFNG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEOAFNG.Click

      Dim sSQL As String
      Dim oTG As New frmTablaGeneral

      sSQL = "SELECT    TK_CODPAR, TK_DESCRI " & _
             "FROM      TABPAR " & _
             "WHERE     TK_CODENT = " & LlaveCombo(cboCodEnt) & " " & _
             "AND       TK_CUADRO = " & LlaveCombo(cboCuadro) & " " & _
             "AND       TK_FECVIG = " & FechaSQL(LlaveCombo(cboFecVig)) & " " & _
             "ORDER BY  TK_CODPAR"
      oTG.PasarInfo(sSQL, CONN_LOCAL, 1, False, "Relación 2")

      If oTG.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
         txtEOAFNG.Text = INPUT_GENERAL
      End If

      oTG = Nothing

   End Sub

   Public Sub PasarDatos(ByVal dFecVig As Date, _
                          ByVal nCodEnt As Long, _
                          ByVal nCuadro As Long, _
                          ByVal nPartida As Double, _
                          ByVal nCodRTC As Double, _
                          ByVal nEOAFNG As Object, _
                          Optional ByVal bBaja As Boolean = False)

      SelComboBox(cboFecVig, dFecVig.ToString)
      SelItemCombo(cboCodEnt, nCodEnt)
      SelItemCombo(cboCuadro, nCuadro)
      txtCodPar.Text = nPartida.ToString
      txtCODRTC.Text = nCodRTC.ToString

      If Not (nEOAFNG Is DBNull.Value) Then
         txtEOAFNG.Text = nEOAFNG.ToString
      End If

      cboFecVig.Enabled = False
      cboCodEnt.Enabled = False
      cboCuadro.Enabled = False
      txtCodPar.Enabled = False
      txtCODRTC.Enabled = False

      If bBaja Then
         txtEOAFNG.Enabled = False
         OK_Button.Text = "&Eliminar"
      End If

   End Sub

End Class
