Imports System.Xml
Imports System.IO

Public Class frmMain

   Public ARCHIVO_CONFIG As String = Application.StartupPath & "\Prex.config"

   Private oConfig As New dsConfig
   Private oItemSel As ListViewItem

   Function CrearConnString(Optional ByVal parentForm As Form = Nothing) As String

      Dim dataLink As Object = Microsoft.VisualBasic.Interaction.CreateObject("DataLinks")

      If Not parentForm Is Nothing Then
         dataLink.hWnd = parentForm.Handle.ToInt32()
      End If

      Dim oForm As Object = dataLink.PromptNew()

      If oForm Is Nothing Then
         Return ""
      Else
         Return oForm.ConnectionString.ToString()
      End If

   End Function

   Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
      Application.Exit()
   End Sub

   Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
      Guardar()
   End Sub

   Private Sub cmdCarpetaLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCarpetaLocal.Click

      CarpetaDialogo.SelectedPath = txtCarpetaLocal.Text
      CarpetaDialogo.ShowDialog()
      txtCarpetaLocal.Text = CarpetaDialogo.SelectedPath

   End Sub

   Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click

      GuardarDialogo.OverwritePrompt = False
      GuardarDialogo.Title = "Especifique el archivo de configuración"
      GuardarDialogo.Filter = "Archivos de configuración (*.config)|*.config"
      GuardarDialogo.InitialDirectory = txtCarpetaLocal.Text
      If GuardarDialogo.ShowDialog() = Windows.Forms.DialogResult.OK Then
         txtArchivoConfig.Text = System.IO.Path.GetFileName(GuardarDialogo.FileName)
      End If

   End Sub

   Private Sub btnConnString_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnString.Click
      txtConnString.Text = CrearConnString(Me)
   End Sub

   Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

      Dim frm As New frmDialog
      Dim oResult As DialogResult = frm.ShowDialog()

      If oResult = Windows.Forms.DialogResult.OK Then
         lvConfig.Refresh()
      End If

      frm = Nothing

   End Sub

   Private Sub lvConfig_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvConfig.ItemSelectionChanged

      If lvConfig.Items.Count Then
         oItemSel = e.Item
      Else
         oItemSel = Nothing
      End If

   End Sub

   Private Sub lvConfig_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvConfig.MouseDoubleClick

      If Not (oItemSel Is Nothing) Then
         Dim frm As New frmDialog
         frm.PasarDatos(oItemSel.Text, oItemSel.SubItems.Item(1).Text)
         frm.ShowDialog()
         frm = Nothing
      End If

   End Sub

   Friend Sub PasarDatos(ByVal sNombre As String, _
                         ByVal sValor As String)

      Dim oItem As ListViewItem
      Dim bAgrega As Boolean = True

      For Each oItem In lvConfig.Items
         If oItem.Text = sNombre Then
            oItem.SubItems.Item(1).Text = sValor
            bAgrega = False
         End If
      Next

      If bAgrega Then
         oItem = lvConfig.Items.Add(sNombre)
         oItem.SubItems.Add(sValor)
      End If

   End Sub

   Private Sub CargarXML()

      Try

         Dim sTemp As String
         Dim oItem As ListViewItem

         If File.Exists(ARCHIVO_CONFIG) Then
            oConfig.ReadXml(ARCHIVO_CONFIG)

            For Each row As DataRow In oConfig.Tables("CONFIG").Rows

               sTemp = row("VALOR").ToString

               Select Case row("NOMBRE").ToString

                  Case "CONN_LOCAL"
                     sTemp = System.Text.ASCIIEncoding.UTF8.GetString(Convert.FromBase64String(sTemp))

                     txtConnString.Text = sTemp.Substring(0, sTemp.LastIndexOf(";"))
                     sTemp = sTemp.Substring(sTemp.LastIndexOf(";"))
                     txtPassword.Text = sTemp.Substring(sTemp.LastIndexOf("=") + 1)

                  Case "FFECHA"
                     txtFFecha.Text = sTemp

                  Case "CARPETA_LOCAL"
                     txtCarpetaLocal.Text = sTemp

                  Case "NOMBRE_INI_LOCAL"
                     txtArchivoConfig.Text = sTemp

                  Case Else
                     oItem = lvConfig.Items.Add(row("NOMBRE").ToString)
                     oItem.SubItems.Add(sTemp)

               End Select
            Next

         End If

      Catch ex As Exception
         MessageBox.Show(ex.Source & " - " & ex.Message, "Error")
      End Try

   End Sub

   Private Sub Guardar()

      Try

         Dim ds As New dsConfig
         Dim dr As DataRow
         Dim dt As DataTable = ds.Tables("CONFIG")

         'Conexión Base de datos
         dr = dt.NewRow()
         dr("NOMBRE") = "CONN_LOCAL"
         dr("VALOR") = Convert.ToBase64String(System.Text.ASCIIEncoding.UTF8.GetBytes(txtConnString.Text & ";Password=" & txtPassword.Text))
         dt.Rows.Add(dr)
         ds.AcceptChanges()

         'Formato de Fecha del Servidor SQL
         dr = dt.NewRow()
         dr("NOMBRE") = "FFECHA"
         dr("VALOR") = txtFFecha.Text
         dt.Rows.Add(dr)
         ds.AcceptChanges()

         'Ruta a la carpeta local
         dr = dt.NewRow()
         dr("NOMBRE") = "CARPETA_LOCAL"
         dr("VALOR") = txtCarpetaLocal.Text
         dt.Rows.Add(dr)
         ds.AcceptChanges()

         'Nombre de archivo de configuración local
         dr = dt.NewRow()
         dr("NOMBRE") = "NOMBRE_INI_LOCAL"
         dr("VALOR") = txtArchivoConfig.Text
         dt.Rows.Add(dr)
         ds.AcceptChanges()

         'Configuraciones Variadas
         For Each oItem As ListViewItem In lvConfig.Items
            dr = dt.NewRow()
            dr("NOMBRE") = oItem.Text
            dr("VALOR") = oItem.SubItems.Item(1).Text
            dt.Rows.Add(dr)
            ds.AcceptChanges()

            Application.DoEvents()
         Next

         ds.WriteXml(ARCHIVO_CONFIG)

         Application.DoEvents()
         Application.Exit()

      Catch ex As Exception
         MessageBox.Show(ex.Source & " - " & ex.Message, "Error")
      End Try

   End Sub

   Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      CargarXML()
   End Sub

   Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click

      If Not (oItemSel Is Nothing) Then
         lvConfig.Items.Remove(oItemSel)
      End If

   End Sub

End Class