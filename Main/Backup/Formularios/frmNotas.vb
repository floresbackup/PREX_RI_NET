Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports System.Drawing.Printing
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Localization
Imports DevExpress.XtraGrid.Localization
Imports DevExpress.XtraPivotGrid.Localization
Imports DevExpress.XtraCharts.Localization
Imports DevExpress.XtraPrinting.Localization
Imports DevExpress.XtraReports.Localization
Imports DevExpress.XtraEditors.Controls
Imports System.Runtime.InteropServices

Public Class frmNotas

   Private oAdmTablas As New AdmTablas
   Private CLAVE_COMENT As String
   Private bFlagCargado As Boolean
   Private checkPrint As Integer
   Private Const AnInch As Double = 14.4

   Private Structure RECT
      Public Left As Integer
      Public Top As Integer
      Public Right As Integer
      Public Bottom As Integer
   End Structure

   Private Structure CHARRANGE
      Public cpMin As Integer          ' First character of range (0 for start of doc)
      Public cpMax As Integer          ' Last character of range (-1 for end of doc)
   End Structure

   Private Structure FORMATRANGE
      Public hdc As IntPtr             ' Actual DC to draw on
      Public hdcTarget As IntPtr       ' Target DC for determining text formatting
      Public rc As RECT                ' Region of the DC to draw to (in twips)
      Public rcPage As RECT            ' Region of the whole DC (page size) (in twips)
      Public chrg As CHARRANGE         ' Range of text to draw (see above declaration)
   End Structure

   Private Const WM_USER As Integer = &H400
   Private Const EM_FORMATRANGE As Integer = WM_USER + 57

   Private Declare Function SendMessage Lib "USER32" Alias "SendMessageA" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr) As IntPtr

   Private Sub CambiarEstiloFuente(ByVal oFuente As FontStyle)
      rtfNota.SelectionFont = New Font(rtfNota.SelectionFont.Name, _
                                       rtfNota.SelectionFont.Size, _
                                       oFuente)
   End Sub

   Private Sub frmNotas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      oAdmTablas.ConnectionString = CONN_LOCAL

      cargarFuente()

   End Sub

   Public Sub PasarDatos(ByVal sClave As String)

      Dim sSQL As String
      Dim ad As OleDb.OleDbDataAdapter
      Dim dt As DataTable

      CLAVE_COMENT = sClave

      sSQL = "SELECT    CM_CLAVE, CM_FECPRO, US_DESCRI AS XX_CODUSU, CM_COMENT " & _
             "FROM      COMENT " & _
             "LEFT JOIN USUARI " & _
             "ON        US_CODUSU = CM_CODUSU " & _
             "WHERE     CM_CLAVE = '" & sClave & "'" & _
             "ORDER BY  CM_FECPRO DESC "

      ad = New OleDb.OleDbDataAdapter(sSQL, CONN_LOCAL)
      dt = New DataTable

      ad.Fill(dt)

      Grid.DataSource = dt
      Grid.RefreshDataSource()
      Grid.Refresh()

      bFlagCargado = True

   End Sub

   Private Sub btnNegrita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNegrita.Click

      If rtfNota.SelectionFont.Bold Then
         CambiarEstiloFuente(rtfNota.SelectionFont.Style - FontStyle.Bold)
      Else
         CambiarEstiloFuente(rtfNota.SelectionFont.Style + FontStyle.Bold)
      End If

   End Sub

   Private Sub btnCursiva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCursiva.Click

      If rtfNota.SelectionFont.Italic Then
         CambiarEstiloFuente(rtfNota.SelectionFont.Style - FontStyle.Italic)
      Else
         CambiarEstiloFuente(rtfNota.SelectionFont.Style + FontStyle.Italic)
      End If

   End Sub

   Private Sub Guardar()

      Dim sSQL As String
      Dim ds As DataSet
      Dim oRow As DataRow
      Dim da As OleDb.OleDbDataAdapter
      Dim cb As OleDb.OleDbCommandBuilder

      Cursor = Cursors.WaitCursor

      Try

         sSQL = "SELECT    * " & _
                "FROM      COMENT " & _
                "WHERE     CM_CLAVE = '" & CLAVE_COMENT & "'"

         ds = oAdmTablas.AbrirDataset(sSQL, da)
         cb = New OleDb.OleDbCommandBuilder(da)

         oRow = ds.Tables(0).NewRow()

         oRow("CM_CLAVE") = CLAVE_COMENT
         oRow("CM_FECPRO") = DateTime.Now
         oRow("CM_CODUSU") = UsuarioActual.Codigo
         oRow("CM_COMENT") = rtfNota.Rtf

         ds.Tables(0).Rows.Add(oRow)
         da.Update(ds)
         ds.AcceptChanges()

      Catch ex As Exception
         TratarError(ex, "Guardar")
      End Try

      PasarDatos(CLAVE_COMENT)

      Cursor = Cursors.Default

   End Sub


   Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

      If Grid.MainView.RowCount Then
         rtfNota.Rtf = GridView1.GetRowCellDisplayText(e.FocusedRowHandle, "CM_COMENT").ToString
      End If

   End Sub

   Private Sub btnSubrayado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubrayado.Click

      If rtfNota.SelectionFont.Underline Then
         CambiarEstiloFuente(rtfNota.SelectionFont.Style - FontStyle.Underline)
      Else
         CambiarEstiloFuente(rtfNota.SelectionFont.Style + FontStyle.Underline)
      End If

   End Sub

   Private Sub btnIzquierda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzquierda.Click
      rtfNota.SelectionAlignment = HorizontalAlignment.Left
   End Sub

   Private Sub btnCentro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCentro.Click
      rtfNota.SelectionAlignment = HorizontalAlignment.Center
   End Sub

   Private Sub btnDerecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDerecha.Click
      rtfNota.SelectionAlignment = HorizontalAlignment.Right
   End Sub

   Private Sub cargarFuente()

      Dim installed_fonts As New System.Drawing.Text.InstalledFontCollection
      Dim font_families() As FontFamily = installed_fonts.Families()
      Dim nC As Integer = 0

      For Each oFont As FontFamily In font_families
         AgregarItemCombo(cboFuente, nC, oFont.Name)
      Next

      For nC = 8 To 40 Step 2
         AgregarItemCombo(cboTamano, nC, nC.ToString)
      Next

      cboFuente.Text = "Arial"
      cboTamano.SelectedIndex = 0

      FuenteRTF(cboFuente.Text, 8)

   End Sub

   Private Sub FuenteRTF(ByVal sFuente As String, ByVal nTamano As Single)

      If nTamano Then
         rtfNota.SelectionFont = New Font(sFuente, _
                                          nTamano, _
                                          rtfNota.SelectionFont.Style)
      End If

   End Sub

   Private Sub cboFuente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFuente.SelectedIndexChanged
      If IsNumeric(cboTamano.Text) And bFlagCargado Then
         FuenteRTF(cboFuente.Text, Convert.ToSingle(cboTamano.Text))
      End If
   End Sub

   Private Sub cboTamano_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTamano.TextChanged
      If IsNumeric(cboTamano.Text) And bFlagCargado Then
         FuenteRTF(cboFuente.Text, Convert.ToSingle(cboTamano.Text))
      End If
   End Sub

   Private Sub rtfNota_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
      bFlagCargado = False
      If rtfNota.SelectionLength = 0 Then
         cboTamano.Text = rtfNota.SelectionFont.Size.ToString
         cboFuente.Text = rtfNota.SelectionFont.FontFamily.Name
      End If
      bFlagCargado = True
   End Sub

   Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
      Guardar()
   End Sub

   Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
      Me.Close()
   End Sub

   Private Sub pDocRTF_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles pDocRTF.BeginPrint
      checkPrint = 0
   End Sub

   Private Sub pDocRTF_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pDocRTF.PrintPage

      checkPrint = rtfNota.Print(checkPrint, rtfNota.TextLength, e)

      If checkPrint < rtfNota.TextLength Then
         e.HasMorePages = True
      Else
         e.HasMorePages = False
      End If

   End Sub

   Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

      pDiagRTF.Document = pDocRTF

      If pDiagRTF.ShowDialog = Windows.Forms.DialogResult.OK Then
         pDocRTF.Print()
      End If

   End Sub

   Private Sub btnDeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeshacer.Click
      rtfNota.Undo()
   End Sub

   Private Sub btnRehacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRehacer.Click
      rtfNota.Redo()
   End Sub

   Private Sub btnCortar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCortar.Click
      rtfNota.Cut()
   End Sub

   Private Sub btnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiar.Click
      rtfNota.Copy()
   End Sub

   Private Sub btnPegar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPegar.Click
      rtfNota.Paste()
   End Sub

End Class