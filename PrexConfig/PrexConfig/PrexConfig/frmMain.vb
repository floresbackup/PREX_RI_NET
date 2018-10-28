Imports System.Xml
Imports System.IO
Imports System.Data.SqlClient
Imports System.Linq

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

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarSgLibrary.Click

        GuardarDialogo.OverwritePrompt = False
        GuardarDialogo.Title = "Especifique el archivo de configuración SG"
        GuardarDialogo.Filter = "Archivos de configuración (*.xml)|*.xml"
        GuardarDialogo.InitialDirectory = txtSGLibrary.Text
        If GuardarDialogo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtSGLibrary.Text = System.IO.Path.GetFileName(GuardarDialogo.FileName)
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

    Friend Sub PasarDatos(ByVal sNombre As String,
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
                            ' sTemp = sTemp.Substring(sTemp.LastIndexOf(";"))
                            txtPassword.Text = GetStringFromConnection(sTemp, "Password=") ' sTemp.Substring(sTemp.LastIndexOf("=") + 1)
                            txtUsuario.Text = GetStringFromConnection(sTemp, "User Id=")
                            txtBaseDeDatos.Text = GetStringFromConnection(sTemp, "Initial Catalog=")
                            txtServidor.Text = GetStringFromConnection(sTemp, "Data Source=")
                            ckSeguridadIntegrada.Checked = sTemp.Contains("Integrated Security=true")
                        Case "FFECHA"
                            txtFFecha.Text = sTemp

                        Case "CARPETA_LOCAL"
                            txtCarpetaLocal.Text = sTemp

                        Case "NOMBRE_INI_LOCAL"
                            txtArchivoConfig.Text = sTemp
                        Case "SG_CONFIG"
                            MostrarRutaSG(True)
                            txtSGLibrary.Text = sTemp
                        Case Else
                            oItem = lvConfig.Items.Add(row("NOMBRE").ToString)
                            oItem.SubItems.Add(sTemp)

                    End Select

                Next

            End If
            lvConfig.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        Catch ex As Exception
            MessageBox.Show(ex.Source & " - " & ex.Message, "Error")
        End Try

    End Sub
    Private Function ReemplazarValorConexion(value As String, conexion As String) As String
        Dim str As New System.Text.StringBuilder()
        For Each item As String In conexion.Split(";")
            If Not item.Contains(value) AndAlso item.Trim().Length > 1 Then
                str.Append(item & ";")
            End If
        Next
        Return str.ToString()

        'If conexion.Contains(value) Then
        '    Dim inicio As Integer = conexion.IndexOf(value, 0) - 1
        '    Dim fin As Integer = conexion.IndexOf(";", inicio + 1)
        '    If fin <= 0 Then
        '        fin = conexion.Length - 1
        '    End If
        '    Dim reemplazar As String = conexion.Substring(inicio, fin - inicio)
        '    conexion = conexion.Replace(reemplazar, String.Empty)
        'End If
        'Return conexion
    End Function

    Private Function GetConnectionStringWithOutLogin() As String
        Dim conexion As String = ReemplazarValorConexion("User Id=", txtConnString.Text)
        conexion = ReemplazarValorConexion("Password=", conexion)
        conexion = ReemplazarValorConexion("Initial Catalog=", conexion)
        conexion = ReemplazarValorConexion("Data Source=", conexion)
        conexion = ReemplazarValorConexion("Integrated Security=", conexion)

        Return conexion.Replace(";;", ";").Replace("  ", " ").Trim()
    End Function

    Private Function GetFullConnectionString() As String
        'Provider=SQLOLEDB.1;Persist Security Info=False;User ID=capmin;Password=capmin;User Id=;Initial Catalog=capitalesminimos;Data Source=LACARGBAAS196,2431
        'Dim con As String = GetConnectionStringWithOutLogin()
        Dim con As String = "Provider=SQLOLEDB.1;Persist Security Info=False;"
        If ckSeguridadIntegrada.Checked Then
            con &= "Integrated Security=true;"
        Else
            con &= "Password=" & txtPassword.Text.Trim() & ";User ID=" & txtUsuario.Text.Trim()
        End If
        con &= ";Initial Catalog=" & txtBaseDeDatos.Text.Trim() & ";DATA SOURCE=" & txtServidor.Text.Trim()
        'Initial Catalog=GESTIONRI_PNP;Data Source=NTB-EMILSE\SQLEXPRESS
        Return con.Replace(";;", ";")
    End Function

    Private Function GetStringFromConnection(conexion As String, clave As String) As String
        For Each item As String In conexion.Split(";")
            If item.ToUpper().Contains(clave.ToUpper) Then
                Dim clavelst As List(Of String) = item.Replace(";", String.Empty).Split("=").ToList()
                Return clavelst.LastOrDefault()
                'Return item.Replace(";", String.Empty).Replace(clave.ToUpper, String.Empty)
            End If
        Next
        Return String.Empty
    End Function

    Private Sub Guardar()

        Try

            Dim ds As New dsConfig
            Dim dr As DataRow
            Dim dt As DataTable = ds.Tables("CONFIG")

            'Conexión Base de datos
            dr = dt.NewRow()
            dr("NOMBRE") = "CONN_LOCAL"
            dr("VALOR") = Convert.ToBase64String(System.Text.ASCIIEncoding.UTF8.GetBytes(GetFullConnectionString()))
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

            'Ruta configuracion SG
            If txtSGLibrary.Visible Then
                dr = dt.NewRow()
                dr("NOMBRE") = "SG_CONFIG"
                dr("VALOR") = txtSGLibrary.Text
                dt.Rows.Add(dr)
                ds.AcceptChanges()
            End If

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

    Private Sub MostrarRutaSG(mostrar As Boolean)
        If mostrar Then
            lvConfig.Location = New Point(39, 285)
            lvConfig.Height = 108
        Else
            lvConfig.Location = New Point(39, 262)
            lvConfig.Height = 130
        End If
        lblSgLibrary.Visible = mostrar
        btnBuscarSgLibrary.Visible = mostrar
        txtSGLibrary.Visible = mostrar
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostrarRutaSG(False)

        CargarXML()
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click

        If Not (oItemSel Is Nothing) Then
            lvConfig.Items.Remove(oItemSel)
        End If

    End Sub

    Private Sub ckSeguridadIntegrada_CheckedChanged(sender As Object, e As EventArgs) Handles ckSeguridadIntegrada.CheckedChanged
        txtUsuario.Enabled = ckSeguridadIntegrada.CheckState = CheckState.Unchecked
        txtPassword.Enabled = ckSeguridadIntegrada.CheckState = CheckState.Unchecked

    End Sub

    Private Sub btnProbarConexion_Click(sender As Object, e As EventArgs) Handles btnProbarConexion.Click
        Try
            Dim conn As New OleDb.OleDbConnection(GetFullConnectionString())
            conn.Open()
            If conn.State = ConnectionState.Open Then
                MessageBox.Show("Conexión establecida exitosamente", "Probando conexión con SQL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()
            Else
                MessageBox.Show("No se pudo establecer conexión, revise los datos ingresados", "Probando conexión con SQL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            conn = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Source & " - " & ex.Message, "Probando conexión con SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class