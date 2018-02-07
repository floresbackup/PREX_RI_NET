Imports System.DirectoryServices

Public Class frmMain

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarArbol()
        CargarMenues(0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmInicioSesion.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CargarArbol()

        Dim sSQL As String = "SELECT * FROM MENUES WHERE MU_NIVEL<>0 ORDER BY MU_NIVEL, MU_TRANSA"
        Dim ad As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(sSQL, My.Settings.CONN_LOCAL.ToString)
        Dim dt As DataTable = New DataTable
        Dim dr As DataRow
        Dim nodo As TreeNode
        Dim nuevoNodo() As TreeNode

        ad.Fill(dt)

        tvMenu.Nodes.Clear()

        nodo = tvMenu.Nodes.Add("K0", "Menú", "Menu")

        For Each dr In dt.Rows

            tvMenu.BeginUpdate()
            nuevoNodo = tvMenu.Nodes.Find("K" & dr("MU_RELMEN").ToString, True)
            nuevoNodo(0).Nodes.Add("K" & dr("MU_NROMEN").ToString, dr("MU_TRANSA").ToString, "Cerrada")
            tvMenu.EndUpdate()

        Next

        nodo.Expand()

    End Sub

    Private Sub CargarMenues(ByVal nMenu As Long)

        Dim sSQL As String = ""

        'Cargo las carpetas
        sSQL = "SELECT    * " & _
               "FROM      MENUES " & _
               "WHERE     MU_RELMEN=" & nMenu & " " & _
               "ORDER BY  MU_TRANSA"

        lvTrans.Items.Clear()

        Dim ad As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(sSQL, My.Settings.CONN_LOCAL.ToString)
        Dim dt As DataTable = New DataTable
        Dim dr As DataRow
        Dim nodo As ListViewItem

        ad.Fill(dt)

        For Each dr In dt.Rows
            If Val(dr("MU_CODTRA").ToString) = 0 Then
                nodo = lvTrans.Items.Add("C" & dr("MU_NROMEN").ToString, dr("MU_TRANSA").ToString, "Carpeta")
            Else
                nodo = lvTrans.Items.Add("T" & dr("MU_CODTRA").ToString, dr("MU_TRANSA").ToString, "Transaccion")
                'nodo.SubItems(0).Text = dr("MU_CODTRA").ToString
            End If
        Next

        Exit Sub

        'Cargo las carpetas
        sSQL = "SELECT    * " & _
               "FROM      MENUES " & _
               "WHERE     MU_RELMEN=" & nMenu & " " & _
               "AND       MU_NIVEL=0 " & _
               "ORDER BY  MU_TRANSA"

        dt.Dispose()
        ad.Dispose()
        ad = New SqlClient.SqlDataAdapter(sSQL, My.Settings.CONN_LOCAL.ToString)

        ad.Fill(dt)

        'lvTrans.Items.Clear()

        For Each dr In dt.Rows
            nodo = lvTrans.Items.Add("T" & dr("MU_NROMEN").ToString, dr("MU_TRANSA").ToString, "Transaccion")
        Next

    End Sub

    Private Sub lvTrans_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvTrans.MouseDoubleClick
        Dim item As ListViewItem

        item = lvTrans.HitTest(e.Location).Item
        If item.Name.Substring(0, 1) = "T" Then
            EjecutarTransaccion(Val(item.Name.Substring(1)))
        Else
            CargarMenues(Val(item.Name.Substring(1)))
        End If
    End Sub

    Private Sub tvMenu_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvMenu.NodeMouseClick
        CargarMenues(Val(e.Node.Name.Substring(1)))
    End Sub

    Private Sub EjecutarTransaccion(ByVal nCodTra As Long)

      Dim oTrx As New System.Diagnostics.Process

      oTrx.StartInfo.FileName = "Y:\PrEx_RI\BIN\VBP" & Format(nCodTra, "00000") & ".EXE"
      'oTrx.StartInfo.RedirectStandardError = True
      oTrx.StartInfo.Arguments = "/u:1/t:" & nCodTra & "/e:20"
      oTrx.StartInfo.UseShellExecute = True
      oTrx.StartInfo.WorkingDirectory = "Y:\PrEx_RI\BIN"
      oTrx.Start()
      oTrx.WaitForExit()


    End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
      Me.Close()
   End Sub

   Private Sub btnIr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIr.Click
      If Val(txtCodTra.Text) <> 0 Then
         EjecutarTransaccion(Val(txtCodTra.Text))
      End If
   End Sub

   Private Sub txtCodTra_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodTra.KeyUp
      If e.KeyCode = Keys.Return Then
         If Val(txtCodTra.Text) <> 0 Then
            EjecutarTransaccion(Val(txtCodTra.Text))
         End If
      End If
   End Sub
End Class
