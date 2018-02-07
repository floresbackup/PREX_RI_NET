Imports DevExpress.XtraCharts

Public Class frmGrafico

   Public Sub Exportar(Optional ByVal sRuta As String = "")

      If sRuta = "" Then
         Dim oDlg As SaveFileDialog

         oDlg = New SaveFileDialog
         oDlg.FileName = "TRX" & CODIGO_TRANSACCION & ".jpg"
         oDlg.ValidateNames = True
         oDlg.OverwritePrompt = True
         oDlg.Filter = "Texto enriquecido (*.jpg)|*.jpg"
         oDlg.ShowDialog(Me)

         If oDlg.FileName.Trim <> vbNullString Then
            sRuta = oDlg.FileName.Trim
         Else
            Exit Sub
         End If
      End If

      TChart.ExportToImage(sRuta, System.Drawing.Imaging.ImageFormat.Jpeg)

   End Sub

   Public Sub PasarDatos(ByVal oGrid As DevExpress.XtraGrid.GridControl, _
                            Optional ByVal bGuardarImagen As Boolean = False)

      Dim sSQL As String
      Dim ds As DataSet
      Dim dt As DataTable
      Dim oAdmLocal As New AdmTablas
      Dim nC As Long

      oAdmLocal.ConnectionString = CONN_LOCAL

      dt = oGrid.DataSource

      sSQL = "SELECT    * " & _
             "FROM      SYSGRA " & _
             "WHERE     SG_CODCON = " & oConsulta.CodCon.ToString & " " & _
             "ORDER BY  SG_ORDEN "
      ds = oAdmLocal.AbrirDataset(sSQL)

      With ds.Tables(0)
         For Each oRow As DataRow In .Rows

            If nC = 0 Then
               sSQL = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(oRow("SG_QUERY").ToString))
               Clipboard.SetText(sSQL)

               If sSQL.Trim <> "" Then
                  sSQL = frmMain.ReemplazarVariables(sSQL)
                  dt = Nothing
                  dt = New DataTable
                  Dim ad As OleDb.OleDbDataAdapter
                  ad = New OleDb.OleDbDataAdapter(sSQL, CONN_LOCAL)
                  ad.Fill(dt)
               End If

               Select Case oRow("SG_POSLEY")
                  Case 0
                     TChart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Left
                     TChart.Legend.AlignmentVertical = LegendAlignmentVertical.Center
                  Case 1
                     TChart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Right
                     TChart.Legend.AlignmentVertical = LegendAlignmentVertical.Center
                  Case 2
                     TChart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center
                     TChart.Legend.AlignmentVertical = LegendAlignmentVertical.Top
                  Case Else
                     TChart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center
                     TChart.Legend.AlignmentVertical = LegendAlignmentVertical.Bottom
               End Select

               If oRow("SG_TITVIS") <> 0 Then
                  Dim oLabel As ChartTitle = New ChartTitle()
                  oLabel.Text = oConsulta.Nombre
                  TChart.Titles.Add(oLabel)
               End If

            End If

            Dim serie As Series = New Series()

            serie.Name = "Serie " & nC.ToString

            Dim optPuntos As PointOptions = New PointOptions()
            optPuntos.ValueNumericOptions.Format = NumericFormat.FixedPoint
            optPuntos.ArgumentNumericOptions.Format = NumericFormat.FixedPoint
            optPuntos.HiddenSerializableString = "Serializar"

            'serie.PointOptions = optPuntos
            'serie.PointOptionsTypeName = "PointOptions"

            For Each oRow2 As DataRow In dt.Rows
               serie.Points.Add(New SeriesPoint(oRow2(oRow("SG_CAMTIT")), New Object() {oRow2(oRow("SG_CAMVAL"))}))
            Next

            nC = nC + 1

            serie.LegendText = oRow("SG_TITULO")

            'serie.View = new DevExpress.XtraCharts.BarSeriesView()
            serie.Name = oRow("SG_TITULO")
            TChart.Series.Add(serie)

         Next

      End With

   End Sub

   Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
      Me.Close()
   End Sub

   Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
      Exportar()
   End Sub

   Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
      TChart.ShowPrintPreview(Printing.PrintSizeMode.Zoom)
   End Sub

End Class