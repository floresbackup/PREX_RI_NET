Public Class frmTablaGeneral 

   Private sSQLEjecutar As String
   Private sConnStringEjecutar As String
   Private nColumnaRetornar As Integer
   Private bMultiSeleccion As Boolean
   Private bCheck As Boolean

   Private oAdmTablas As New AdmTablas
   Private ds As DataSet
   Private vRetorno As String
   Private nTipoCon As Integer

   Public Sub PasarInfo(ByVal sSQL As String, _
                        ByVal sConnString As String, _
                        Optional ByVal nColumnaRetorno As Integer = 1, _
                        Optional ByVal bMultiSelect As Boolean = False, _
                        Optional ByVal sTitulo As String = "Tabla general")


      sSQLEjecutar = sSQL
      sConnStringEjecutar = sConnString
      nColumnaRetornar = nColumnaRetorno
      bMultiSeleccion = bMultiSelect
      lblTitulo.Text = sTitulo

      gvwResultados.OptionsSelection.MultiSelect = bMultiSeleccion

      Ejecutar()

   End Sub

   Private Sub Ejecutar()

      Try
         Dim ad As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sSQLEjecutar, sConnStringEjecutar)
         Dim dt As New DataTable

         ad.Fill(dt)

         GridResultados.DataSource = dt
         GridResultados.RefreshDataSource()
         GridResultados.Refresh()
         gvwResultados.BestFitColumns()

         If bMultiSeleccion Then
            For Each oCol As DevExpress.XtraGrid.Columns.GridColumn In gvwResultados.Columns
               If oCol.VisibleIndex > 0 Then
                  oCol.OptionsColumn.AllowEdit = False
               Else
                  If oCol.ColumnType.FullName.ToUpper = "SYSTEM.BOOLEAN" Then
                     bCheck = True
                  End If
               End If
            Next
         End If

         cmdAceptar.Enabled = gvwResultados.RowCount > 0

      Catch ex As Exception
         TratarError(ex, "Ejecutar")
      End Try

   End Sub

   Private Sub GridResultados_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
      If cmdAceptar.Enabled Then
         cmdAceptar_Click(sender, e)
      End If
   End Sub

   Private Sub frmTablaGeneral_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      INPUT_GENERAL = ""
   End Sub

   Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

      Dim vValores() As VariantType
      Dim vValor As VariantType

      vRetorno = ""

      If bMultiSeleccion Then
         If bCheck Then
            Dim dt As New DataTable
            dt = GridResultados.DataSource

            For Each oRow As DataRow In dt.Rows
               If oRow(0) Then
                  vRetorno = vRetorno.ToString & oRow(nColumnaRetornar - 1).ToString & ","
               End If
            Next

         Else
            vValores = gvwResultados.GetSelectedRows

            For Each vValor In vValores
               vRetorno = vRetorno.ToString & gvwResultados.GetDataRow(vValor).Item(nColumnaRetornar - 1).ToString & ","
            Next
         End If

         If vRetorno.Length > 0 Then
            vRetorno = vRetorno.Substring(0, vRetorno.Length - 1)
         Else
            Exit Sub
         End If

      Else
         vRetorno = gvwResultados.GetDataRow(gvwResultados.FocusedRowHandle).Item(nColumnaRetornar - 1)
      End If

      INPUT_GENERAL = vRetorno
      Me.DialogResult = Windows.Forms.DialogResult.OK
      Me.Close()

   End Sub

   Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
   End Sub

End Class