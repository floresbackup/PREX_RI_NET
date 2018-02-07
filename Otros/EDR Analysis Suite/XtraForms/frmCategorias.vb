Public Class frmCategorias 

    Private oAdmTablas As New AdmTablas

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmCategorias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        oAdmTablas.ConnectionString = CONN_LOCAL
        LocalizarFormulario()
        CargarTree()

    End Sub

    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionCategorias)
        cmdCerrar.Text = DescripcionCadena(Cadenas.CDN_GeneralCerrar)

        lblTip.Text = DescripcionCadena(Cadenas.CDN_frmCategorias_Tip)
        btnNueva.Caption = DescripcionCadena(Cadenas.CDN_frmCategorias_MenuAgregar)
        btnCambiarNombre.Caption = DescripcionCadena(Cadenas.CDN_frmCategorias_MenuRenombrar)
        btnEliminar.Caption = DescripcionCadena(Cadenas.CDN_frmCategorias_MenuEliminar)

    End Sub

    Private Sub CargarTree()

        On Error Resume Next

        Dim ds As System.Data.DataSet
        Dim sSQL As String
        Dim nodX As TreeNode
        Dim nodPadre As TreeNode
        Dim i As Int32

        ' CATEGORIAS
        sSQL = "SELECT      TG_CODCON, TG_DESCRI, TG_NUME01 " & _
               "FROM        TABGEN " & _
               "WHERE       TG_CODTAB = 3 " & _
               "AND         TG_CODCON <> 999999 " & _
               "ORDER BY    TG_NUME01, TG_DESCRI ASC "

        sSQL = sSQL & _
               "SELECT      CV_CODCON, CV_NOMBRE, CV_CATEGO " & _
               "FROM        CONVAR"

        ds = oAdmTablas.AbrirDataset(sSQL)
        tvMain.Nodes.Clear()

        nodX = New TreeNode
        nodX.Name = "nodRaiz"
        nodX.Text = DescripcionCadena(Cadenas.CDN_nodRaizConsultas)
        nodX.ImageIndex = 0
        tvMain.Nodes.Add(nodX)

        With ds.Tables(0)
            For i = 0 To .Rows.Count - 1
                nodX = New TreeNode
                nodX.Name = "C" & .Rows(i).Item("TG_CODCON").ToString
                nodX.Text = .Rows(i).Item("TG_DESCRI").ToString
                nodX.ImageIndex = 1
                nodX.SelectedImageIndex = 1

                If .Rows(i).Item("TG_NUME01") = 0 Then
                    nodPadre = tvMain.Nodes("nodRaiz")
                Else
                    nodPadre = tvMain.Nodes.Find("C" & .Rows(i).Item("TG_NUME01").ToString, True)(0)
                End If

                nodPadre.Nodes.Add(nodX)

            Next
        End With

        With ds.Tables(1)
            For i = 0 To .Rows.Count - 1
                nodX = New TreeNode
                nodX.Name = "K" & .Rows(i).Item("CV_CODCON").ToString
                nodX.Text = .Rows(i).Item("CV_NOMBRE").ToString
                nodX.ImageIndex = 3
                nodX.SelectedImageIndex = 3

                nodPadre = tvMain.Nodes.Find("C" & .Rows(i).Item("CV_CATEGO").ToString, True)(0)
                nodPadre.Nodes.Add(nodX)

            Next
        End With

        tvMain.ExpandAll()

    End Sub

    Private Sub tvMain_AfterCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMain.AfterCollapse
        If e.Node.Name.Substring(0, 1) = "C" Then
            e.Node.ImageIndex = 2
            e.Node.SelectedImageIndex = 2
        End If
    End Sub

    Private Sub tvMain_AfterExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMain.AfterExpand
        If e.Node.Name.Substring(0, 1) = "C" Then
            e.Node.ImageIndex = 1
            e.Node.SelectedImageIndex = 1
        End If
    End Sub

    Private Sub tvMain_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvMain.NodeMouseClick

        tvMain.SelectedNode = e.Node

        If e.Button = Windows.Forms.MouseButtons.Right Then
            If e.Node.Name.Substring(0, 1) <> "K" Then
                btnCambiarNombre.Enabled = e.Node.Name <> "nodRaiz"
                btnEliminar.Enabled = (e.Node.Name <> "nodRaiz") And (e.Node.Nodes.Count = 0)
                popContext.ShowPopup(Control.MousePosition)
            End If
        End If

    End Sub

    Private Sub tvMain_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles tvMain.DragEnter
        'See if there is a TreeNode being dragged
        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", _
            True) Then
            'TreeNode found allow move effect
            e.Effect = DragDropEffects.Move
        Else
            'No TreeNode found, prevent move
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub tvMain_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles tvMain.DragOver
        'Check that there is a TreeNode being dragged 
        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", _
               True) = False Then Exit Sub

        'Get the TreeView raising the event (incase multiple on form)
        Dim selectedTreeview As TreeView = CType(sender, TreeView)

        'As the mouse moves over nodes, provide feedback to 
        'the user by highlighting the node that is the 
        'current drop target
        Dim pt As Point = _
            CType(sender, TreeView).PointToClient(New Point(e.X, e.Y))
        Dim targetNode As TreeNode = selectedTreeview.GetNodeAt(pt)

        'See if the targetNode is currently selected, 
        'if so no need to validate again
        If Not (selectedTreeview.SelectedNode Is targetNode) Then
            'Select the    node currently under the cursor
            selectedTreeview.SelectedNode = targetNode

            'Check that the selected node is not the dropNode and
            'also that it is not a child of the dropNode and 
            'therefore an invalid target
            Dim dropNode As TreeNode = _
                CType(e.Data.GetData("System.Windows.Forms.TreeNode"), _
                TreeNode)

            Do Until targetNode Is Nothing
                If targetNode Is dropNode Then
                    e.Effect = DragDropEffects.None
                    Exit Sub
                End If
                ''''''''''''
                If dropNode.Name.Substring(0, 1) = "C" Then
                    e.Effect = DragDropEffects.None
                    Exit Sub
                End If

                If targetNode.Name.Substring(0, 1) = "K" Then
                    e.Effect = DragDropEffects.None
                    Exit Sub
                End If

                targetNode = targetNode.Parent
            Loop

            If selectedTreeview.SelectedNode Is Nothing Then
                e.Effect = DragDropEffects.None
                Exit Sub
            Else
                If dropNode.Name.Substring(0, 1) = "K" Then
                    If selectedTreeview.SelectedNode.Parent Is Nothing Then
                        e.Effect = DragDropEffects.None
                        Exit Sub
                    End If
                End If
            End If

            'Currently selected node is a suitable target
            e.Effect = DragDropEffects.Move

        End If

    End Sub

    Private Sub tvMain_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles tvMain.DragDrop
        'Check that there is a TreeNode being dragged
        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", _
              True) = False Then Exit Sub

        'Get the TreeView raising the event (incase multiple on form)
        Dim selectedTreeview As TreeView = CType(sender, TreeView)


        Dim sOrigen As String
        Dim sDestino As String
        Dim nCodOrigen As Long
        Dim nCodDestino As Long

        'Get the TreeNode being dragged
        Dim dropNode As TreeNode = _
              CType(e.Data.GetData("System.Windows.Forms.TreeNode"), _
              TreeNode)

        'The target node should be selected from the DragOver event
        Dim targetNode As TreeNode = selectedTreeview.SelectedNode

        'Remove the drop node from its current location
        dropNode.Remove()

        Debug.Print("Mover " & dropNode.Name & " a " & targetNode.Name)

        nCodOrigen = Val(dropNode.Name.Substring(1))
        sOrigen = dropNode.Name.Substring(0, 1)

        If targetNode.Name = "nodRaiz" Then
            nCodDestino = 0
        Else
            nCodDestino = Val(targetNode.Name.Substring(1))
        End If
        sDestino = targetNode.Name.Substring(0, 1)

        If sOrigen = "K" Then
            ModificarConsulta(nCodOrigen, nCodDestino)
        Else
            ModificarCategoria(nCodOrigen, nCodDestino)
        End If

        'If there is no targetNode add dropNode to the bottom of
        'the TreeView root nodes, otherwise add it to the end of
        'the dropNode child nodes
        If targetNode Is Nothing Then
            selectedTreeview.Nodes.Add(dropNode)
        Else
            targetNode.Nodes.Add(dropNode)
        End If

        'Ensure the newley created node is visible to
        'the user and select it
        dropNode.EnsureVisible()
        selectedTreeview.SelectedNode = dropNode


    End Sub

    Private Sub tvMain_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles tvMain.ItemDrag
        'Set the drag node and initiate the DragDrop 
        DoDragDrop(e.Item, DragDropEffects.Move)

    End Sub

    Private Sub ModificarConsulta(ByVal nCodigoConsulta As Long, ByVal nNuevaCategoria As Long)

        Dim sSQL As String

        sSQL = "UPDATE CONVAR " & _
               "SET CV_CATEGO = " & nNuevaCategoria & " " & _
               "WHERE CV_CODCON = " & nCodigoConsulta

        Try
            oAdmTablas.EjecutarComandoSQL(sSQL)
        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub ModificarCategoria(ByVal nCodigoCategoria As Long, ByVal nNuevaCategoria As Long)

        Dim sSQL As String

        sSQL = "UPDATE TABGEN " & _
               "SET TG_NUME01 = " & nNuevaCategoria & " " & _
               "WHERE TG_CODTAB = 3 AND TG_CODCON = " & nCodigoCategoria

        Try
            oAdmTablas.EjecutarComandoSQL(sSQL)
        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub EliminarCategoria(ByVal nCodigoCategoria As Long)

        Dim sSQL As String

        sSQL = "DELETE FROM TABGEN " & _
               "WHERE TG_CODTAB = 3 AND TG_CODCON = " & nCodigoCategoria

        Try
            oAdmTablas.EjecutarComandoSQL(sSQL)
        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub ModificarNombreCategoria(ByVal nCodigoCategoria As Long, ByVal sNuevoNombre As String)

        Dim sSQL As String

        sSQL = "UPDATE TABGEN " & _
               "SET TG_DESCRI = '" & sNuevoNombre & "' " & _
               "WHERE TG_CODTAB = 3 AND TG_CODCON = " & nCodigoCategoria

        Try
            oAdmTablas.EjecutarComandoSQL(sSQL)
        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub AgregarCategoria(ByVal nCodigoCategoria As Long, ByVal sNuevoNombre As String, ByVal nCategoriaPadre As Long)

        Dim sSQL As String

        sSQL = "INSERT INTO TABGEN " & _
               "VALUES (3," & nCodigoCategoria & ",'" & sNuevoNombre & "'," & nCategoriaPadre & ",0,'','','1900-01-01','1900-01-01')"

        Try
            oAdmTablas.EjecutarComandoSQL(sSQL)
        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub btnCambiarNombre_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCambiarNombre.ItemClick
        tvMain.LabelEdit = True
        tvMain.SelectedNode.BeginEdit()
    End Sub

    Private Sub tvMain_AfterLabelEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs) Handles tvMain.AfterLabelEdit
        If e.Label Is Nothing Then
            e.CancelEdit = True
        Else
            If e.Label.Trim = vbNullString Or e.Node.Text.Trim = e.Label.Trim Then
                e.CancelEdit = True
            Else
                ModificarNombreCategoria(Val(e.Node.Name.Substring(1)), e.Label.Trim)
            End If
        End If
    End Sub

    Private Sub btnNueva_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNueva.ItemClick

        Dim oNode As TreeNode
        Dim oNewNode As TreeNode
        Dim nID As Long
        Dim nCatPadre As Long
        Dim sText As String

        oNode = tvMain.SelectedNode

        If Not oNode Is Nothing Then

            nID = oAdmTablas.ProximoID("TABGEN", "TG_CODCON", "TG_CODTAB = 3 AND TG_CODCON <> 999999")
            nCatPadre = Val(oNode.Name.Substring(1))
            sText = DescripcionCadena(Cadenas.CDN_frmCategorias_DefaultNueva)

            oNewNode = New TreeNode
            oNewNode.Name = "C" & nID
            oNewNode.Text = sText
            oNewNode.ImageIndex = 1
            oNewNode.SelectedImageIndex = 1

            AgregarCategoria(nID, sText, nCatPadre)
            oNode.Nodes.Add(oNewNode)
            oNode.Expand()
            oNewNode.EnsureVisible()
            oNewNode.BeginEdit()

        End If

    End Sub

    Private Sub btnEliminar_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEliminar.ItemClick

        Dim oNode As TreeNode

        oNode = tvMain.SelectedNode

        If Not oNode Is Nothing Then
            If Pregunta(DescripcionCadena(Cadenas.CDN_frmCategorias_WarningEliminar)) = Windows.Forms.DialogResult.Yes Then
                EliminarCategoria(Val(oNode.Name.Substring(1)))
                CargarTree()
            End If
        End If

    End Sub

End Class