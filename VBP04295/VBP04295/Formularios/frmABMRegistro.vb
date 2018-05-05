Imports Microsoft.Data.ConnectionUI

Public Class frmABMRegistro

   Private Const TOP_CONTROLES As Long = 10
   Private MODO_APE As String
   Private sSQL_Update As String
   Private oAdmTablas As New AdmTablas

   Public Sub PasarDatos(ByVal nCodCon As Long, _
                         ByVal sQuery As String, _
                         ByVal sCaption As String, _
                         Optional ByVal sModo As String = "M")

      Dim oCol As clsColumnas
      Dim oField As DataColumn
      Dim nTabOrden As Integer
      Dim ds As DataSet
      Dim nCont As Long
      Dim bExiste As Boolean
      Dim bPrimero As Boolean

      INPUT_GENERAL = ""

      Me.Text = sCaption

      sSQL_Update = sQuery

      MODO_APE = sModo

      If MODO_APE = "B" Then
         cmdGuardar.Text = "Baja"
      End If

      'PONGO LOS VALORES EN LA GRILLA

      If MODO_APE = "A" Then
         ds = oAdmTablas.AbrirDataset(sSQL_Update.Substring(0, sSQL_Update.LastIndexOf("FROM") - 1))
      Else
         ds = oAdmTablas.AbrirDataset(sSQL_Update)
      End If

      If MODO_APE = "B" And (ds.Tables(0).Rows.Count = 0) Then
         MensajeError("El registro actual no se puede eliminar")
         cmdGuardar.Enabled = False
         INPUT_GENERAL = "CERRAR_FORMULARIO_YAA"
         GoTo Salir
      End If

      For Each oCol In oColumnas

         Dim lblInput As New Label()

         bExiste = False

         For Each oField In ds.Tables(0).Columns

            If oCol.Campo.ToUpper = oField.ColumnName.ToUpper Then
               bExiste = True
               Exit For
            End If

         Next

         'VERIFICO EL TIPO DE DATOS Y COMPLETO
         If bExiste Then

            'Obtengo el valor del campo
            oCol.Valor = ds.Tables(0).Rows(0)(oCol.Campo)

            If oCol.VisibleABM Or oCol.Clave Then

               If oCol.VisibleABM Then
                  nCont = nCont + 1
               End If

               'LABEL DE CAMPO
               With lblInput
                  .Name = "_lblInput" & oCol.Orden
                  .AutoSize = True
                  .Visible = oCol.VisibleABM
                  .Top = TOP_CONTROLES + 5 + (25 * (nCont - 1))
                  .Left = 5
                  .Text = IIf(oCol.Titulo.Substring(oCol.Titulo.Length - 1, 1) <> ":", oCol.Titulo & ":", oCol.Titulo)
                  If MODO_APE = "B" Then
                     .Enabled = False
                  Else
                     .Enabled = oCol.Habilitada
                  End If
                  Cont.Controls.Add(lblInput)
               End With

               'SI NO LLEVA UN COMBO DE HELP PONGO UN TEXBOX O DATEPICKER
               If oCol.Help = 0 Then
                  If TipoDatosADO(oCol.Tipo) <> "Fecha/Hora" Then

                     Dim txtInput As New DevExpress.XtraEditors.TextEdit

                     With txtInput
                        .Name = "_txtInput" & oCol.Orden
                        .Visible = oCol.VisibleABM
                        .Properties.MaxLength = oCol.Largo
                        .TabIndex = nTabOrden
                        .TabStop = oCol.Habilitada
                        .Top = TOP_CONTROLES + (25 * (nCont - 1))
                        .Left = 150
                        .Width = Cont.Width - .Left - 10 - Cont.Left
                        .Tag = oCol.Key

                        If MODO_APE = "B" Then
                           .Enabled = False
                        Else
                           .Enabled = oCol.Habilitada
                           If .Enabled And (Not bPrimero) Then
                              .TabIndex = 0
                              bPrimero = True
                           End If
                        End If
                     End With

                     AddHandler txtInput.EditValueChanged, AddressOf txtInput_EditValueChanged
                     Cont.Controls.Add(txtInput)

                  Else

                     Dim fecInput As New DevExpress.XtraEditors.DateEdit

                     With fecInput
                        .Name = "_fecInput" & oCol.Orden
                        .Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
                        .Visible = oCol.VisibleABM
                        .TabIndex = nTabOrden
                        .TabStop = oCol.Habilitada
                        .Top = TOP_CONTROLES + (25 * (nCont - 1))
                        .Left = 150
                        .Width = Cont.Width - .Left - 10 - Cont.Left
                        .DateTime = Date.Today
                        .Tag = oCol.Key

                        If MODO_APE = "B" Then
                           .Enabled = False
                        Else
                           .Enabled = oCol.Habilitada
                           If .Enabled And (Not bPrimero) Then
                              .TabIndex = 0
                              bPrimero = True
                           End If
                        End If
                     End With

                     AddHandler fecInput.EditValueChanged, AddressOf fecInput_EditValueChanged
                     Cont.Controls.Add(fecInput)

                  End If
               Else

                  Dim cboInput As New DevExpress.XtraEditors.ComboBoxEdit

                  With cboInput
                     .Name = "_cboInput" & oCol.Orden
                     .Visible = oCol.VisibleABM
                     .TabIndex = nTabOrden
                     .TabStop = oCol.Habilitada
                     .Top = TOP_CONTROLES + (25 * (nCont - 1))
                     .Left = 150
                     .Width = Cont.Width - .Left - 10 - Cont.Left
                     .Text = "<Seleccione...>"
                     .Tag = oCol.Key

                     If MODO_APE = "B" Then
                        .Enabled = False
                     Else
                        .Enabled = oCol.Habilitada
                        If .Enabled And (Not bPrimero) Then
                           .TabIndex = 0
                           bPrimero = True
                        End If
                     End If
                  End With

                  AddHandler cboInput.SelectedIndexChanged, AddressOf cboInput_SelectedIndexChanged
                  Cont.Controls.Add(cboInput)

                        CargarComboDevExpress(cboInput, frmMain.ReemplazarVariablesExt(oCol.HelpQuery))

                    End If

               If oCol.Valor.ToString.Trim <> "" Then
                  If oCol.Help = 0 Then
                     If TipoDatosADO(oCol.Tipo) = "Fecha/Hora" Then
                        CType(Cont.Controls("_fecInput" & oCol.Orden.ToString), DevExpress.XtraEditors.DateEdit).DateTime = oCol.Valor
                     Else
                        CType(Cont.Controls("_txtInput" & oCol.Orden), DevExpress.XtraEditors.TextEdit).Text = oCol.Valor.ToString
                     End If
                  Else
                     SelComboDevExpress(CType(Cont.Controls("_cboInput" & oCol.Orden.ToString), DevExpress.XtraEditors.ComboBoxEdit), "K" & oCol.Valor.ToString)
                  End If
               End If

            End If

            If oCol.VisibleABM Then
               nTabOrden = nTabOrden + 1
               Cont.Height = Cont.Height + 25
               Me.Height = Me.Height + 25
               cmdGuardar.Top = cmdGuardar.Top + 25
               cmdCancelar.Top = cmdGuardar.Top
            End If

         End If

      Next

Salir:

   End Sub

   Public Sub New()

      ' Llamada necesaria para el Dise�ador de Windows Forms.
      InitializeComponent()

      ' Agregue cualquier inicializaci�n despu�s de la llamada a InitializeComponent().
      oAdmTablas.ConnectionString = CONN_LOCAL

   End Sub

   Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
      Me.Close()
   End Sub

   Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click

      If DatosOK() Then
         Guardar()
      End If

   End Sub

   Private Function DatosOK() As Boolean

      Return True

   End Function

   Private Sub Guardar()

      Dim sSQL As String
      Dim ds As DataSet
      Dim oCol As clsColumnas
      Dim oRow As DataRow
      Dim da As OleDb.OleDbDataAdapter
      Dim cb As OleDb.OleDbCommandBuilder
      Dim bProcesa As Boolean
      Dim sTabla As String
      Dim sUpdate As String = ""
      Dim sValor As String

      Cursor = Cursors.WaitCursor

      sSQL = sSQL_Update
      sSQL = "SELECT * " & sSQL.Substring(sSQL.LastIndexOf("FROM", System.StringComparison.OrdinalIgnoreCase))

      If MODO_APE <> "A" Then
         sTabla = sSQL.Substring(sSQL.LastIndexOf("FROM", System.StringComparison.OrdinalIgnoreCase))
         sTabla = sTabla.Replace("FROM", "").Trim
         sTabla = sTabla.Replace(vbCrLf, " ")
         sTabla = sTabla.Substring(0, sTabla.IndexOf(" ", System.StringComparison.OrdinalIgnoreCase))
         sTabla = sTabla.Trim
      End If

      If sSQL.IndexOf("END") <> -1 Then
         sSQL = sSQL.Substring(0, sSQL.IndexOf("END", System.StringComparison.OrdinalIgnoreCase) - 1)
      End If

      Try

         ds = oAdmTablas.AbrirDataset(sSQL, da)
         cb = New OleDb.OleDbCommandBuilder(da)

         sSQL = sSQL.Substring(sSQL.LastIndexOf("FROM", System.StringComparison.OrdinalIgnoreCase))

         If MODO_APE = "B" Then
            sUpdate = "DELETE " & sSQL
            GoTo GuardaDataRow
         ElseIf MODO_APE = "A" Or MODO_APE = "N" Then
            oRow = ds.Tables(0).NewRow()
         Else
            sUpdate = "UPDATE " & sTabla & " SET "
         End If

         For Each oCol In oColumnas

            bProcesa = False

            For Each oField As DataColumn In ds.Tables(0).Columns
               If oCol.Campo.ToUpper = oField.ColumnName.ToUpper Then
                  bProcesa = True
                  Exit For
               End If
            Next

            If bProcesa Then
               If MODO_APE = "A" Or MODO_APE = "N" Then
                  oRow.Item(oCol.Campo) = oCol.Valor
               Else
                  Select Case TipoDatosADO(oCol.Tipo)
                     Case "Num�rico"
                        sValor = FlotanteSQL(oCol.Valor)
                     Case "Fecha/Hora"
                        sValor = FechaSQL(oCol.Valor)
                     Case Else
                        sValor = "'" & oCol.Valor & "'"
                  End Select

                  If oCol.VisibleABM And oCol.Habilitada Then
                     sUpdate = sUpdate & " [" & oCol.Campo & "] = " & sValor & ","
                  End If
               End If
            End If
         Next

GuardaDataRow:

         If MODO_APE = "A" Or MODO_APE = "N" Then
            ds.Tables(0).Rows.Add(oRow)
            da.Update(ds)
            ds.AcceptChanges()
         Else
            If MODO_APE <> "B" Then
               sUpdate = sUpdate.Substring(0, sUpdate.Length - 1) & " " & sSQL
            End If

            Dim nFilas As Integer
            oAdmTablas.EjecutarComandoAsincrono(sUpdate, nFilas)
            'MessageBox.Show("Filas Afectadas: " & nFilas.ToString)
         End If

         Cursor = Cursors.Default

         frmMain.Ejecutar()

         Me.Close()

      Catch ex As Exception
         Cursor = Cursors.Default
         TratarError(ex, "Guardar")
      End Try

   End Sub

   Private Sub txtInput_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

      Dim oCol As clsColumnas

      oCol = oColumnas(sender.tag)
      oCol.Valor = sender.Text

   End Sub

   Private Sub cboInput_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

      Dim oItem As clsItem.Item
      Dim oCol As clsColumnas

      oCol = oColumnas(sender.tag)
      oItem = sender.SelectedItem

      Select Case TipoDatosADO(oCol.Tipo)
         Case "Num�rico"
            oCol.Valor = oItem.Valor
         Case "Fecha/Hora"
            oCol.Valor = oItem.Valor
         Case Else
            oCol.Valor = oItem.Valor
      End Select

   End Sub

   Private Sub fecInput_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

      Dim oCol As clsColumnas

      oCol = oColumnas(sender.tag)
      oCol.Valor = sender.DateTime

   End Sub

End Class