Public Class frmMain

    Private oAdmLocal As New AdmTablas
    Public ErrorPermiso As Boolean = False

    Public Sub AnalizarCommand()

        Try

            Dim sParametros() As String
            Dim sItemParam() As String
            Dim nCodigoUsuario As Long
            Dim nCodigoTransaccion As Long
            Dim nCodigoEntidad As Long
            Dim nC As Integer

            '''''' USUARIO ''''''

            sParametros = Command.Split("/")

            For nC = 0 To sParametros.Length - 1

                sItemParam = sParametros(nC).Trim.Split(":")

                If sItemParam.Length = 2 Then

                    Select Case sItemParam(0).Trim.ToUpper
                        Case "U"
                            nCodigoUsuario = Val(sItemParam(1))
                        Case "T"
                            nCodigoTransaccion = Val(sItemParam(1))
                        Case "E"
                            nCodigoEntidad = Val(sItemParam(1))
                    End Select

                End If
            Next

            If nCodigoUsuario = 0 Then
                MensajeError("El parámetro código usuario es inválido.")
                Application.Exit()
            End If

            If nCodigoTransaccion = 0 Then
                MensajeError("El parámetro código de transacción es inválido.")
                Application.Exit()
            End If

            If nCodigoEntidad = 0 Then
                MensajeError("El parámetro código de entidad es inválido.")
                Application.Exit()
            End If

            CODIGO_TRANSACCION = nCodigoTransaccion
            CODIGO_ENTIDAD = nCodigoEntidad

            PresentarDatos(nCodigoTransaccion, nCodigoUsuario, nCodigoEntidad)

        Catch ex As Exception
            TratarError(ex, "AnalizarCommand")
            Application.Exit()
        End Try

    End Sub

    Private Sub PresentarDatos(ByVal nCodigoTransaccion As Long, ByVal nCodigoUsuario As Long, ByVal nCodigoEntidad As Long)
        Try
            Try
                Dim sSQL As String
                Dim ds As DataSet

                ''''' USUARIO '''''

                sSQL = "SELECT    US_CODUSU, US_NOMBRE, US_DESCRI, US_ADMIN " &
                "FROM      USUARI " &
                "WHERE     US_CODUSU = " & nCodigoUsuario
                ds = oAdmLocal.AbrirDataset(sSQL)

                With ds.Tables(0)

                    If .Rows.Count = 0 Then
                        Throw New Security.SecurityException("Falla de seguridad")
                    Else
                        UsuarioActual.Codigo = nCodigoUsuario
                        UsuarioActual.Nombre = .Rows(0).Item("US_NOMBRE")
                        UsuarioActual.Descripcion = .Rows(0).Item("US_DESCRI")
                        UsuarioActual.Admin = .Rows(0).Item("US_ADMIN")
                        UsuarioActual.SoloLectura = False
                        lblUsuario.Text = UsuarioActual.Descripcion
                    End If

                End With

                ds = Nothing

                ''''' ENTIDAD '''''

                sSQL = "SELECT    TG_CODCON, TG_DESCRI " &
                "FROM      TABGEN " &
                "WHERE     TG_CODTAB = 1 " &
                "AND       TG_CODCON = " & nCodigoEntidad
                ds = oAdmLocal.AbrirDataset(sSQL)

                With ds.Tables(0)

                    If .Rows.Count = 0 Then
                        Throw New Security.SecurityException("Parámetro de entidad no válido")
                    Else
                        NOMBRE_ENTIDAD = .Rows(0).Item("TG_DESCRI")
                        lblEntidad.Text = NOMBRE_ENTIDAD
                    End If

                End With

                ds = Nothing

                ''''' TRANSACCION '''''

                sSQL = "SELECT    MU_TRANSA, MU_DESCRI " &
                "FROM      MENUES " &
                "WHERE     MU_CODTRA = " & nCodigoTransaccion
                ds = oAdmLocal.AbrirDataset(sSQL)

                With ds.Tables(0)


                    If .Rows.Count = 0 Then
                        Throw New Security.SecurityException("Error en la línea de comandos. Parámetro de transacción incorrecto")
                    Else
                        lblTransaccion.Text = .Rows(0).Item("MU_DESCRI")
                        Me.Text = CODIGO_TRANSACCION.ToString & " - " & .Rows(0).Item("MU_TRANSA")
                    End If

                End With

                ds = Nothing

                lblVersion.Text = "Versión: " & Application.ProductVersion

            Catch ex As Security.SecurityException
                MensajeError(ex.Message)
                ErrorPermiso = True
            End Try
        Catch ex As Exception
            TratarError(ex, "PresentarDatos")
            ErrorPermiso = True
        End Try
    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oAdmLocal.ConnectionString = CONN_LOCAL
        AnalizarCommand()
        CargarArbol()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub CargarArbol()

        Dim sSQL As String
        Dim ds As DataSet
        Dim nodo As TreeNode
        Dim nuevoNodo() As TreeNode

        Try

            sSQL = "SELECT       * " &
                "FROM         MENUES " &
                "WHERE        MU_NIVEL <> 0 " &
                "ORDER BY     MU_NIVEL, MU_TRANSA"
            ds = oAdmLocal.AbrirDataset(sSQL)

            tvMenu.Nodes.Clear()

            With ds.Tables(0)

                nodo = tvMenu.Nodes.Add("0", "Menú", "Menu")

                For Each dr As DataRow In .Rows

                    tvMenu.BeginUpdate()
                    nuevoNodo = tvMenu.Nodes.Find(dr("MU_RELMEN").ToString, True)
                    nuevoNodo(0).Nodes.Add(dr("MU_NROMEN").ToString, dr("MU_TRANSA").ToString, "Cerrada", "Abierta")
                    tvMenu.EndUpdate()

                Next

            End With

            ds = Nothing

            nodo.Expand()

            sSQL = "SELECT       * " &
                "FROM         MENUES " &
                "WHERE        MU_NIVEL = 0 " &
                "ORDER BY     MU_TRANSA "
            ds = oAdmLocal.AbrirDataset(sSQL)

            With ds.Tables(0)

                For Each dr As DataRow In .Rows

                    tvMenu.BeginUpdate()
                    nuevoNodo = tvMenu.Nodes.Find(dr("MU_RELMEN").ToString, True)
                    nuevoNodo(0).Nodes.Add(dr("MU_NROMEN").ToString, dr("MU_TRANSA").ToString, "Trx", "Trx")
                    tvMenu.EndUpdate()

                Next

            End With

            ds = Nothing

        Catch ex As Exception
            TratarError(ex, "CargarArbol")
        End Try

    End Sub

    Private Sub btnNuevaCarp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaCarp.Click

        Dim oCarp As New frmCarpeta

        oCarp.txtCarpeta.Text = tvMenu.SelectedNode.Text
        oCarp.txtCarpeta.Tag = Val(tvMenu.SelectedNode.Name)

        If oCarp.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            CargarArbol()
        End If

    End Sub

    Private Sub btnQuitarCarp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarCarp.Click

        Dim oNode As TreeNode

        oNode = tvMenu.SelectedNode

        If Not oNode Is Nothing Then

            If oNode.ImageKey <> "Trx" Then
                oNode.Expand()

                If Not oNode.IsExpanded Then
                    If Pregunta("¿Desea quitar la carpeta " & oNode.Text & "?") = vbYes Then
                        If oAdmLocal.EjecutarComandoSQL("DELETE FROM MENUES WHERE MU_NROMEN = " & oNode.Name) Then
                            MensajeInformacion("Carpeta eliminada exitosamente")
                            CargarArbol()
                        Else
                            MensajeError("No se pudo eliminar la carpeta")
                        End If
                    End If
                Else
                    MensajeError("La carpeta seleccionada no está vacía")
                End If

            End If

        End If

    End Sub

    Private Sub tvMenu_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMenu.AfterSelect

        btnQuitarCarp.Enabled = tvMenu.SelectedNode.ImageKey <> "Trx"
        btnPropTrx.Enabled = tvMenu.SelectedNode.ImageKey = "Trx"
        btnElimTrx.Enabled = tvMenu.SelectedNode.ImageKey = "Trx"

    End Sub

    Private Sub btnNuevaTrx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaTrx.Click

        Dim oTrx As New frmTransaccion

        If oTrx.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            CargarArbol()
        End If

    End Sub

    Private Sub btnPropTrx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPropTrx.Click

        Dim oTrx As New frmTransaccion
        Dim nodo As TreeNode

        nodo = tvMenu.SelectedNode

        If Not (nodo Is Nothing) Then

            oTrx.PasarDatos(Val(nodo.Name))

            If oTrx.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarArbol()
            End If

        End If

    End Sub

    Private Sub tvMenu_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvMenu.NodeMouseDoubleClick

        If btnPropTrx.Enabled Then
            btnPropTrx_Click(sender, e)
        End If

    End Sub

    Private Sub btnElimTrx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElimTrx.Click

        Dim oNode As TreeNode

        oNode = tvMenu.SelectedNode

        If Not oNode Is Nothing Then

            If oNode.ImageKey = "Trx" Then

                If Pregunta("¿Desea quitar la transacción " & oNode.Text & "?") = vbYes Then
                    If oAdmLocal.EjecutarComandoSQL("DELETE FROM MENUES WHERE MU_NROMEN = " & oNode.Name) Then
                        MensajeInformacion("Transacción eliminada exitosamente")
                        CargarArbol()
                    Else
                        MensajeError("No se pudo eliminar la transacción")
                    End If
                End If

            End If

        End If

    End Sub

End Class
