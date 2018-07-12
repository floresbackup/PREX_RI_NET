Imports DevExpress.XtraGrid.Views.Base
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Xpo

Public Class frmMain
    Public ErrorPermiso As Boolean = False
    Public Class DropDownGrid
        Inherits XPObject
      Public Sub New()
         Codigo = Nothing
         Descripcion = ""
      End Sub
      Public Codigo As Object
      Public Descripcion As String
   End Class

   Private oAdmLocal As New AdmTablas
   Private bProcCheck As Boolean = False

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

                sSQL = "SELECT    * " &
                "FROM      USUARI " &
                "WHERE     US_CODUSU = " & nCodigoUsuario
                ds = oAdmlocal.AbrirDataset(sSQL)

                With ds.Tables(0)

                    If .Rows.Count = 0 Then
                        Throw New Security.SecurityException("Falla de seguridad - US_CODUSU: " & nCodigoUsuario)
                    Else
                        UsuarioActual.Codigo = nCodigoUsuario
                        UsuarioActual.Nombre = .Rows(0).Item("US_NOMBRE")
                        UsuarioActual.Descripcion = .Rows(0).Item("US_DESCRI")
                        UsuarioActual.Admin = .Rows(0).Item("US_ADMIN")
                        UsuarioActual.Password = .Rows(0).Item("US_PASSWO")
                        UsuarioActual.Entidad = .Rows(0).Item("US_CODENT")
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
                ds = oAdmlocal.AbrirDataset(sSQL)

                With ds.Tables(0)

                    If .Rows.Count = 0 Then
                        Throw New Security.SecurityException("Parámetro de entidad no válido - TG_CODCON: " & nCodigoEntidad)
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
                ds = oAdmlocal.AbrirDataset(sSQL)

                With ds.Tables(0)


                    If .Rows.Count = 0 Then
                        Throw New Security.SecurityException("Error en la línea de comandos. Parámetro de transacción incorrecto - MU_CODTRA: " & nCodigoTransaccion)
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
      Cargar()

   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
      Me.Close()
   End Sub

   Private Sub btnAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAyuda.Click
      Ayuda()
   End Sub

   Private Sub cargarArbol()

      Dim sSQL As String
      Dim ds As DataSet
      Dim nodo As TreeNode
      Dim nuevoNodo() As TreeNode

      Try

         sSQL = "SELECT       * " & _
                "FROM         MENUES " & _
                "WHERE        MU_NIVEL <> 0 " & _
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

         sSQL = "SELECT       * " & _
                "FROM         MENUES " & _
                "WHERE        MU_NIVEL = 0 " & _
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

   Private Sub cargar()

      'Tab Directivas de seguridad
      cargarDirSeg()

      'Tab Perfiles
      cargarPerfiles()

      'Tab Usuarios
      cargarUsuarios()

      'Tab Grupos
      cargarGrupos()

      'Tab Asignacio de perfiles
      cargarAsig()
      refrescarAsignaciones()

   End Sub

   Private Sub cargarUsuarios()

      Dim ds As DataSet
      Dim sSQL As String

      Try

            sSQL = "SELECT       0, 'No' " & _
                "UNION " & _
                "SELECT       1, 'Si' "
         CargarValoresColumna(GridUsuarios, "US_ADMIN", sSQL)

         sSQL = "SELECT       0, 'No' " & _
                "UNION " & _
                "SELECT       1, 'Si' "
         CargarValoresColumna(GridUsuarios, "US_BLOQUE", sSQL)

         sSQL = "SELECT       * " & _
                "FROM         USUARI " & _
                "ORDER BY     US_CODUSU "
         ds = oAdmLocal.AbrirDataset(sSQL)

         GridUsuarios.DataSource = ds.Tables(0)
         GridUsuarios.Refresh()
         GridUsuarios.RefreshDataSource()

         ds = Nothing

      Catch ex As Exception

      End Try

   End Sub

   Private Sub cargarGrupos()

      Dim sSQL As String

      Try

         cboGrupos.Items.Clear()

         sSQL = "SELECT       GR_CODGRU, GR_DESCRI " & _
                "FROM         GRUPOS " & _
                "ORDER BY     GR_CODGRU "
         CargarCombo(cboGrupos, sSQL)

         lvNoGrupo.Items.Clear()
         lvSiGrupo.Items.Clear()

      Catch ex As Exception

      End Try

   End Sub

   Private Sub RefrescarGrupos()

      Dim ds As DataSet
      Dim sSQL As String
      Dim item As ListViewItem

      Try

         lvNoGrupo.Items.Clear()
         lvSiGrupo.Items.Clear()

         sSQL = "SELECT       DISTINCT US_CODUSU, US_DESCRI, UG_CODGRU " & _
                "FROM         USUARI " & _
                "LEFT JOIN    USUGRU " & _
                "ON           UG_CODUSU = US_CODUSU " & _
                "AND          UG_CODGRU = " & LlaveCombo(cboGrupos) & " " & _
                "WHERE        US_CODENT IN (" & CODIGO_ENTIDAD & ", 0)"
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)

            For Each row As DataRow In .Rows

               If row("UG_CODGRU") Is DBNull.Value Then
                  item = lvNoGrupo.Items.Add(row("US_DESCRI"))
               Else
                  item = lvSiGrupo.Items.Add(row("US_DESCRI"))
               End If

               item.Name = row("US_CODUSU")
               item.ImageKey = "Usuario"

            Next

         End With

         ds = Nothing

         btnPresentarGrupos.Enabled = False
         btnLimpiarGrupos.Enabled = True
         btnEliminarGrupo.Enabled = True
         cmdGuardarGrupo.Enabled = True
         cmdCancelarGrupo.Enabled = True
         cboGrupos.Enabled = False

      Catch ex As Exception

      End Try

   End Sub

   Private Sub cargarPerfiles()

      Dim sSQL As String

      sSQL = "SELECT    CP_CODPER, CP_DESCRI " & _
             "FROM      CABPER " & _
             "ORDER BY  CP_DESCRI ASC"

      CargarCombo(cboPerfilPerfiles, sSQL)

   End Sub

   Private Sub cargarPerfil(ByVal nCodPer As Long)

      Dim sSQL As String
      Dim ds As DataSet
      Dim nodo() As TreeNode

      Try

         bProcCheck = True

         cargarArbol()

         sSQL = "SELECT       * " & _
                "FROM         DETPER " & _
                "INNER JOIN   MENUES " & _
                "ON           MU_CODTRA = DP_CODTRA " & _
                "WHERE        DP_CODPER = " & nCodPer.ToString
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)
            For Each row As DataRow In .Rows
               nodo = tvMenu.Nodes.Find(row("MU_NROMEN"), True)

               If nodo.Length <> 0 Then
                  nodo(0).Checked = True
               End If

               nodo = Nothing

            Next
         End With

         ds = Nothing

         cboPerfilPerfiles.Enabled = False
         btnPresentarPerfil.Enabled = False
         btnLimpiarPerfil.Enabled = True
         btnEliminarPerfil.Enabled = True
         cmdGuardarPerfil.Enabled = True
         cmdCancelarPerfil.Enabled = True

         bProcCheck = False

      Catch ex As Exception
         TratarError(ex, "cargarPerfil " & nCodPer.ToString)
      End Try

   End Sub

   Private Sub tvMenu_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMenu.AfterCheck

      If Not bProcCheck Then
         If e.Node.Nodes.Count > 0 Then
            SetLower(e.Node, e.Node.Checked)
         End If
      End If

   End Sub

   Private Sub SetLower(ByRef nodX As TreeNode, ByVal bCheck As Boolean)

      Dim i As Integer
      Dim nodo As TreeNode

      If nodX.FirstNode Is Nothing Then
         Exit Sub
      End If

      bProcCheck = True

      For i = nodX.FirstNode.Index To nodX.LastNode.Index

         tvMenu.BeginUpdate()

         nodo = nodX.Nodes(i)
         nodo.Checked = bCheck

         tvMenu.EndUpdate()

         If nodX.Nodes.Count > 0 Then
            SetLower(nodo, bCheck)
         End If

      Next i

      bProcCheck = False

   End Sub

   Private Sub tvMenu_AfterCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMenu.AfterCollapse
      e.Node.ImageKey = "Cerrada"
      e.Node.SelectedImageKey = "Cerrada"
   End Sub

   Private Sub tvMenu_AfterExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMenu.AfterExpand
      e.Node.ImageKey = "Abierta"
      e.Node.SelectedImageKey = "Abierta"
   End Sub

   Private Sub btnPresentarPerfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPresentarPerfil.Click

      Dim item As clsItem.Item

      item = cboPerfilPerfiles.SelectedItem

      cargarPerfil(item.Valor)

      item = Nothing

   End Sub

   Private Sub btnLimpiarPerfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarPerfil.Click

      cboPerfilPerfiles.Enabled = True
      btnPresentarPerfil.Enabled = True
      btnLimpiarPerfil.Enabled = False
      btnEliminarPerfil.Enabled = False
      cmdGuardarPerfil.Enabled = False
      cmdCancelarPerfil.Enabled = False

      tvMenu.Nodes.Clear()

   End Sub

   Private Sub cmdGuardarPerfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardarPerfil.Click

      guardarPerfil()

   End Sub

   Private Sub guardarPerfil()

      Dim sSQL As String
      Dim ds As DataSet
      Dim cb As OleDb.OleDbCommandBuilder = Nothing
      Dim da As OleDb.OleDbDataAdapter = Nothing

      Try

         Me.Enabled = False

         sSQL = "DELETE " & _
                "FROM         DETPER " & _
                "WHERE        DP_CODPER = " & LlaveCombo(cboPerfilPerfiles).ToString
         oAdmLocal.EjecutarComandoAsincrono(sSQL)

         guardarNodos(tvMenu.Nodes("0"))

         Me.Enabled = True

         MensajeInformacion("Perfil guardado exitosamente")

      Catch ex As Exception
         TratarError(ex, "guardarPerfil")
      End Try

   End Sub

   Private Sub btnNuevoPerfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoPerfil.Click

      Dim oInput As New frmInputGeneral

      oInput.PasarInfoVentana("Nuevo Perfil", "Ingrese el nombre del nuevo perfil:")

      If oInput.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
         If guardarNuevoPerfil(oInput.ResultadoInput) Then

            MensajeInformacion("Perfil creado exitosamente")

            btnLimpiarPerfil_Click(sender, e)
            Application.DoEvents()

            cargarPerfiles()
            Application.DoEvents()

            SelCombo(cboPerfilPerfiles, oInput.ResultadoInput)
            Application.DoEvents()

            btnPresentarPerfil_Click(sender, e)

         End If
      End If

      oInput = Nothing

   End Sub

   Private Function guardarNuevoPerfil(ByVal sNombre As String) As Boolean

      Dim sSQL As String
      Dim ds As DataSet
      Dim cb As OleDb.OleDbCommandBuilder = Nothing
      Dim da As OleDb.OleDbDataAdapter = Nothing
      Dim row As DataRow
      Dim bResult As Boolean = False

      Try

         Me.Enabled = False

         sSQL = "SELECT       * " & _
                "FROM         CABPER " & _
                "WHERE        CP_DESCRI = '" & sNombre & "' "
         ds = oAdmLocal.AbrirDataset(sSQL, da)
         cb = New OleDb.OleDbCommandBuilder(da)

         With ds.Tables(0)

            If .Rows.Count = 0 Then
               row = .NewRow

               row("CP_CODPER") = oAdmLocal.ProximoID("CABPER", "CP_CODPER")
               row("CP_DESCRI") = sNombre

               .Rows.Add(row)

               da.Update(ds)
               ds.AcceptChanges()

               da = Nothing
               cb = Nothing

               bResult = True

            Else

               MensajeError("Especifique un nombre de perfil diferente")

            End If

         End With

         ds = Nothing

         Me.Enabled = True

         Return bResult

      Catch ex As Exception
         TratarError(ex, "guardarNuevoPerfil " & sNombre)
      End Try

   End Function

   Private Sub btnEliminarPerfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarPerfil.Click

      Dim bResult As Boolean

      If Pregunta("¿Eliminar Perfil?") = Windows.Forms.DialogResult.Yes Then
         bResult = oAdmLocal.EjecutarComandoSQL("DELETE FROM CABPER WHERE CP_CODPER = " & LlaveCombo(cboPerfilPerfiles))

         If bResult Then

            bResult = oAdmLocal.EjecutarComandoSQL("DELETE FROM DETPER WHERE DP_CODPER = " & LlaveCombo(cboPerfilPerfiles))

         Else

            MensajeError("Se produjo un error al intentar eliminar el encabezado del perfil")
            Exit Sub

         End If

         If bResult Then

            MensajeInformacion("Perfil eliminado exitosamente")

            btnLimpiarPerfil_Click(sender, e)
            Application.DoEvents()

            cargarPerfiles()

         Else

            MensajeError("Se produjo un error al intentar eliminar el detalle del perfil")

         End If
      End If

   End Sub

   Private Sub guardarNodos(ByRef nodX As TreeNode)

      Dim i As Integer
      Dim nodo As TreeNode
      Dim sSQL As String

      If nodX.FirstNode Is Nothing Then
         Exit Sub
      End If

      For i = nodX.FirstNode.Index To nodX.LastNode.Index

         nodo = nodX.Nodes(i)
         If nodo.Checked Then
            If nodo.ImageKey = "Trx" Then
               sSQL = "INSERT INTO DETPER (DP_CODPER, DP_CODTRA) VALUES (@CODPER, @CODTRA) "
               sSQL = sSQL.Replace("@CODPER", LlaveCombo(cboPerfilPerfiles).ToString)
               sSQL = sSQL.Replace("@CODTRA", oAdmLocal.DevolverValor("MENUES", "MU_CODTRA", "MU_NROMEN=" & nodo.Name, 0).ToString)
               oAdmLocal.EjecutarComandoAsincrono(sSQL)
            End If
         End If

         If nodX.Nodes.Count > 0 Then
            guardarNodos(nodo)
         End If

      Next i

   End Sub

   Private Sub cmdCancelarPerfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelarPerfil.Click
      btnLimpiarPerfil_Click(sender, e)
   End Sub

   Private Sub CargarValoresColumna(ByVal oGrid As DevExpress.XtraGrid.GridControl, ByVal sColumna As String, ByVal sSQL As String)

      Dim ds As New DataSet
      Dim oItem As DropDownGrid
      Dim xpCollectionTipo As New XPCollection(GetType(DropDownGrid))
      xpCollectionTipo.DisplayableProperties = "This;Codigo;Descripcion"

      ds = oAdmLocal.AbrirDataset(sSQL)

      With ds.Tables(0)

         For Each row As DataRow In .Rows

            oItem = New DropDownGrid

            If IsNumeric(row(0)) Then
               oItem.Oid = row(0)
            End If

            oItem.Codigo = row(0)
            oItem.Descripcion = row(1)

            xpCollectionTipo.Add(oItem)

            oItem = Nothing

         Next

      End With


      Dim oLookUp As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

      oLookUp.Name = "lu" & sColumna
      oLookUp.DataSource = xpCollectionTipo
      oLookUp.DisplayMember = "Descripcion"
      oLookUp.ValueMember = "Codigo"
      oLookUp.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo"))
      oLookUp.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion"))
      oLookUp.Columns("Codigo").Visible = False
      oLookUp.ShowFooter = False
      oLookUp.ShowHeader = False
      oGrid.RepositoryItems.Add(oLookUp)

      CType(oGrid.MainView, ColumnView).Columns(sColumna).ColumnEdit = oLookUp

      oLookUp = Nothing

   End Sub

   Private Sub btnNuevoUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoUsuario.Click

      Dim oUsuario As New frmUsuario

      If oUsuario.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
         cargarUsuarios()
      End If

      oUsuario = Nothing

   End Sub

   Private Sub btnEditarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarUsuario.Click

      Dim oUsuario As New frmUsuario

      oUsuario.PasarDatos(ValGrilla(gUsuarios, "US_CODUSU"))

      If oUsuario.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
         cargarUsuarios()
      End If

   End Sub

   Private Sub cargarDirectivaVigente()

      Dim sSQL As String
      Dim ds As DataSet
      Dim row As DataRow

      Try

         sSQL = "SELECT       * " & _
                "FROM         DIRSEG " & _
                "WHERE        DS_VIGENT = 1 "
         ds = oAdmLocal.AbrirDataset(sSQL)

         With DirectivaVigente

            row = ds.Tables(0).Rows(0)

            .CodDirectiva = row("DS_CODDIR")
            .Descripcion = row("DS_DESCRI")
            .DiasCambioClave = row("DS_DIASRE")
            .DiasVtoClave = row("DS_DIASVT")
            .ClavesRecordadas = row("DS_CANTPC")
            .IntentosBloqueo = row("DS_INTBLO")
            .IntegrarSeguridadNT = IIf(row("DS_SEGUNT") <> 0, True, False)
            .DirectivaVigente = IIf(row("DS_VIGENT") <> 0, True, False)
            .CantidadLetras = row("DS_PASCAR")
            .CantidadNumeros = row("DS_PASNUM")
            .CantidadCarEsp = row("DS_PASESP")
            .CantidadMinima = row("DS_MININA")

         End With

         row = Nothing
         ds = Nothing

      Catch ex As Exception
         TratarError(ex, "cargarDirectivaVigente")
      End Try

   End Sub

   Private Sub btnUsuarioBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuarioBaja.Click

      Dim nCodUsuario As Long
      Dim dFecBaja As Date
      Dim sMotivoError As String = ""
      Dim sSQL As String

      If gUsuarios.RowCount > 0 Then

         nCodUsuario = ValGrilla(gUsuarios, "US_CODUSU")
         dFecBaja = CDate(ValGrilla(gUsuarios, "US_FECBAJ"))

         If nCodUsuario > 1 Then

            If dFecBaja > CDate("01-01-1900") Then

               MensajeError("El usuario seleccionado ya fue dado de baja")

            Else

               If Pregunta("¿Realmente desea dar de baja al usuario seleccionado?") = Windows.Forms.DialogResult.Yes Then
                  If Pregunta("Atención: esta operación no se puede deshacer. ¿Desea continuar?") = Windows.Forms.DialogResult.Yes Then

                     sSQL = "UPDATE    USUARI " & _
                            "SET       US_FECBAJ = " & FechaSQL(Date.Today) & " " & _
                            "WHERE     US_CODUSU = " & nCodUsuario

                     If oAdmLocal.EjecutarComandoAsincrono(sSQL, sMotivoError) Then
                        cargarUsuarios()
                     Else
                        MensajeError(sMotivoError)
                     End If

                  End If
               End If

            End If

         Else
            MensajeError("No se puede dar de baja el usuario seleccionado")
         End If

      End If

   End Sub

   Private Sub btnCambiarPassUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarPassUsuario.Click

      Dim oPass As New frmCambiarPass

      If gUsuarios.RowCount > 0 Then

         oPass.PasarDatos(ValGrilla(gUsuarios, "US_CODUSU"), ValGrilla(gUsuarios, "US_NOMBRE"), ValGrilla(gUsuarios, "US_DESCRI"))

         If oPass.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            MensajeInformacion("Contraseña cambiada exitosamente")
         End If

      End If

      oPass = Nothing

   End Sub

   Private Sub btnPresentarGrupos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPresentarGrupos.Click

      If Not (cboGrupos.SelectedItem Is Nothing) Then
         RefrescarGrupos()
      End If

   End Sub

   Private Sub btnLimpiarGrupos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarGrupos.Click

      cargarGrupos()
      btnPresentarGrupos.Enabled = True
      btnLimpiarGrupos.Enabled = False
      btnEliminarGrupo.Enabled = False
      cmdGuardarGrupo.Enabled = False
      cmdCancelarGrupo.Enabled = False
      cboGrupos.Enabled = True

   End Sub

   Private Sub btnNuevoGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoGrupo.Click

      Dim oInput As New frmInputGeneral

      oInput.PasarInfoVentana("Nuevo Grupo", "Ingrese el nombre del nuevo grupo:")

      If oInput.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
         If guardarNuevoGrupo(oInput.ResultadoInput) Then

            MensajeInformacion("Grupo creado exitosamente")

            btnLimpiarGrupos_Click(sender, e)
            Application.DoEvents()

            cargarGrupos()
            Application.DoEvents()

            SelCombo(cboGrupos, oInput.ResultadoInput)
            Application.DoEvents()

            btnPresentarGrupos_Click(sender, e)

         End If
      End If

      oInput = Nothing

   End Sub

   Private Function guardarNuevoGrupo(ByVal sNombre As String) As Boolean

      Dim sSQL As String
      Dim ds As DataSet
      Dim cb As OleDb.OleDbCommandBuilder = Nothing
      Dim da As OleDb.OleDbDataAdapter = Nothing
      Dim row As DataRow
      Dim bResult As Boolean = False

      Try

         Me.Enabled = False

         sSQL = "SELECT       * " & _
                "FROM         GRUPOS " & _
                "WHERE        GR_DESCRI = '" & sNombre & "' "
         ds = oAdmLocal.AbrirDataset(sSQL, da)
         cb = New OleDb.OleDbCommandBuilder(da)

         With ds.Tables(0)

            If .Rows.Count = 0 Then

               row = .NewRow

               row("GR_CODGRU") = oAdmLocal.ProximoID("GRUPOS", "GR_CODGRU")
               row("GR_DESCRI") = sNombre

               .Rows.Add(row)

               da.Update(ds)
               ds.AcceptChanges()

               da = Nothing
               cb = Nothing

               bResult = True

            Else

               MensajeError("Especifique un nombre de grupo diferente")

            End If

         End With

         ds = Nothing

         Me.Enabled = True

         Return bResult

      Catch ex As Exception
         TratarError(ex, "guardarNuevoGrupo " & sNombre)
      End Try

   End Function

   Private Sub btnEliminarGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarGrupo.Click

      Dim bResult As Boolean

      If Pregunta("¿Eliminar Grupo?") = Windows.Forms.DialogResult.Yes Then
         bResult = oAdmLocal.EjecutarComandoSQL("DELETE FROM GRUPOS WHERE GR_CODGRU = " & LlaveCombo(cboGrupos))

         If bResult Then

            bResult = oAdmLocal.EjecutarComandoSQL("DELETE FROM USUGRU WHERE UG_CODGRU = " & LlaveCombo(cboGrupos))

         Else

            MensajeError("Se produjo un error al intentar eliminar el Grupo")
            Exit Sub

         End If

         If bResult Then

            MensajeInformacion("Grupo eliminado exitosamente")

            btnLimpiarGrupos_Click(sender, e)
            Application.DoEvents()

            cargarGrupos()

         Else

            MensajeError("Se produjo un error al intentar eliminar la relación grupo-usuarios")

         End If

      End If

   End Sub

   Private Sub cmdSiTodosGrupos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSiTodosGrupos.Click

      Try

         Me.Enabled = False

         For Each item As ListViewItem In lvNoGrupo.Items
            item.Remove()
            lvSiGrupo.Items.Add(item)
         Next

      Catch ex As Exception
         TratarError(ex, "cmdSiTodosRdo_Click")
      End Try

      Me.Enabled = True
      Me.Focus()

   End Sub

   Private Sub cmdSiUnoGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSiUnoGrupo.Click

      Try

         Me.Enabled = False

         For Each item As ListViewItem In lvNoGrupo.Items

            If item.Selected Then
               item.Remove()
               lvSiGrupo.Items.Add(item)
            End If

         Next

      Catch ex As Exception
         TratarError(ex, "cmdSiUnoGrupo_Click")
      End Try

      Me.Enabled = True
      Me.Focus()

   End Sub

   Private Sub cmdNoUnoGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNoUnoGrupo.Click

      Try

         Me.Enabled = False

         For Each item As ListViewItem In lvSiGrupo.Items

            If item.Selected Then
               item.Remove()
               lvNoGrupo.Items.Add(item)
            End If

         Next

      Catch ex As Exception
         TratarError(ex, "cmdNoUnoGrupo_Click")
      End Try

      Me.Enabled = True
      Me.Focus()

   End Sub

   Private Sub cmdNoTodosGrupos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNoTodosGrupos.Click

      Try

         Me.Enabled = False

         For Each item As ListViewItem In lvSiGrupo.Items
            item.Remove()
            lvNoGrupo.Items.Add(item)
         Next

      Catch ex As Exception
         TratarError(ex, "cmdSiTodosRdo_Click")
      End Try

      Me.Enabled = True
      Me.Focus()

   End Sub

   Private Sub cmdGuardarGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardarGrupo.Click

      guardarGrupos()

   End Sub

   Private Sub guardarGrupos()

      Dim ds As DataSet
      Dim cb As OleDb.OleDbCommandBuilder
      Dim da As OleDb.OleDbDataAdapter = Nothing
      Dim sSQL As String
      Dim row As DataRow

      Try

         Me.Enabled = False

         sSQL = "DELETE " & _
                "FROM         USUGRU " & _
                "WHERE        UG_CODGRU = " & LlaveCombo(cboGrupos) & " "
         oAdmLocal.EjecutarComandoAsincrono(sSQL)

         sSQL = "SELECT       * " & _
                "FROM         USUGRU " & _
                "WHERE        UG_CODGRU = " & LlaveCombo(cboGrupos) & " "
         ds = oAdmLocal.AbrirDataset(sSQL, da)
         cb = New OleDb.OleDbCommandBuilder(da)

         With ds.Tables(0)

            For Each item As ListViewItem In lvSiGrupo.Items

               row = .NewRow
               row("UG_CODGRU") = LlaveCombo(cboGrupos)
               row("UG_CODUSU") = item.Name
               .Rows.Add(row)

            Next

         End With

         da.Update(ds)
         ds.AcceptChanges()

         ds = Nothing
         da = Nothing

         MensajeInformacion("Relación de fuentes de datos guardada exitosamente")

      Catch ex As Exception
         TratarError(ex, "guardarGrupos")
      End Try

      Me.Enabled = True
      Me.Focus()

   End Sub

   Private Sub cargarAsig()

      Dim sSQL As String
      Dim ds As DataSet

      Try

         cboGrupoAsig.Items.Clear()

         sSQL = "SELECT    * " & _
                "FROM      GRUPOS " & _
                "ORDER BY  GR_DESCRI ASC"
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)
            For Each row As DataRow In .Rows
               cboGrupoAsig.Items.Add(New clsItem.Item("G" & row("GR_CODGRU"), row("GR_DESCRI")))
            Next
         End With

         ds = Nothing

         sSQL = "SELECT    * " & _
                "FROM      USUARI " & _
                "ORDER BY  US_DESCRI ASC"
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)
            For Each row As DataRow In .Rows
               cboGrupoAsig.Items.Add(New clsItem.Item("U" & row("US_CODUSU"), row("US_DESCRI")))
            Next
         End With

         ds = Nothing

         cboPerfilAsig.Items.Clear()

         sSQL = "SELECT    * " & _
                "FROM      CABPER " & _
                "ORDER BY  CP_DESCRI ASC"
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)
            For Each row As DataRow In .Rows
               cboPerfilAsig.Items.Add(New clsItem.Item(row("CP_CODPER"), row("CP_DESCRI")))
            Next
         End With

         ds = Nothing

      Catch ex As Exception
         TratarError(ex, "cargarAsig")
      End Try

   End Sub

   Private Sub refrescarAsignaciones()

      Dim sSQL As String
      Dim ds As DataSet

      Try

         sSQL = "SELECT       'G', 'Grupo' " & _
                "UNION " & _
                "SELECT       'U', 'Usuario' "
         CargarValoresColumna(gridAsig, "HA_TIPOBJ", sSQL)

         sSQL = "SELECT       GR_DESCRI, CP_DESCRI, HA_TIPOBJ, HA_CODOBJ, HA_CODPER " & _
                "FROM         GRUPOS, CABPER, HABILI " & _
                "WHERE        HA_TIPOBJ = 'G' " & _
                "AND          HA_CODOBJ = GR_CODGRU " & _
                "AND          HA_CODPER = CP_CODPER " & _
                "UNION        " & _
                "SELECT       US_DESCRI, CP_DESCRI, HA_TIPOBJ, HA_CODOBJ, HA_CODPER " & _
                "FROM         USUARI, CABPER, HABILI " & _
                "WHERE        HA_TIPOBJ = 'U' " & _
                "AND          HA_CODOBJ = US_CODUSU " & _
                "AND          HA_CODPER = CP_CODPER"
         ds = oAdmLocal.AbrirDataset(sSQL)

         With gridAsig

            .DataSource = ds.Tables(0)
            .Refresh()
            .RefreshDataSource()

         End With

      Catch ex As Exception
         TratarError(ex, "refrescarAsignaciones")
      End Try

   End Sub

   Private Sub btnAsignarAsig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarAsig.Click

      Dim sTipObj As String
      Dim nCodObj As Long
      Dim nCodPerfil As Long
      Dim sMotivoError As String = ""
      Dim item As clsItem.Item
      Dim oAdmUsuarios As New AdmUsuarios

      Try

         If cboGrupoAsig.SelectedItem Is Nothing Then
            MensajeError("Seleccione el grupo o el usuario al que desea asignar un perfil")
            cboGrupoAsig.Focus()
            Exit Sub
         End If

         If cboPerfilAsig.SelectedItem Is Nothing Then
            MensajeError("Seleccione el perfil que desea asignar")
            cboPerfilAsig.Focus()
            Exit Sub
         End If

         item = cboGrupoAsig.SelectedItem
         sTipObj = item.Valor.ToString.Substring(0, 1)
         nCodObj = Val(item.Valor.ToString.Substring(1))

         item = cboPerfilAsig.SelectedItem
         nCodPerfil = item.Valor

         If oAdmUsuarios.AsignarPerfilObjeto(sTipObj, nCodObj, nCodPerfil, sMotivoError) Then
            refrescarAsignaciones()
         Else
            MensajeError(sMotivoError)
         End If

      Catch ex As Exception
         TratarError(ex, "btnAsignarAsig_Click")
      End Try

   End Sub

   Private Sub btnEliminarAsig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarAsig.Click

      Dim sTipObj As String
      Dim nCodObj As Long
      Dim nCodPerfil As Long
      Dim sSQL As String

      Try

         If gAsig.RowCount > 0 Then


            sTipObj = ValGrilla(gAsig, "HA_TIPOBJ")
            nCodObj = ValGrilla(gAsig, "HA_CODOBJ")
            nCodPerfil = ValGrilla(gAsig, "HA_CODPER")

            If Pregunta("¿Desea quitar la asignación de perfil seleccionada?") = Windows.Forms.DialogResult.Yes Then

               sSQL = "DELETE       " & _
                      "FROM         HABILI " & _
                      "WHERE        HA_TIPOBJ = '" & sTipObj & "' " & _
                      "AND          HA_CODOBJ = " & nCodObj & " " & _
                      "AND          HA_CODPER = " & nCodPerfil

               If oAdmLocal.EjecutarComandoSQL(sSQL) Then
                  refrescarAsignaciones()
               Else
                  MensajeError("Error al quitar la asignación de perfil seleccionada")
               End If

            End If

         End If

      Catch ex As Exception
         TratarError(ex, "btnEliminarAsig_Click")
      End Try

   End Sub

   Private Sub cargarDirSeg()

      Dim sSQL As String
      Dim ds As DataSet

      Try

         sSQL = "SELECT    * " & _
                "FROM      DIRSEG " & _
                "ORDER BY  DS_CODDIR ASC"
         ds = oAdmLocal.AbrirDataset(sSQL)

         GridDirSeg.DataSource = ds.Tables(0)
         GridDirSeg.Refresh()
         GridDirSeg.RefreshDataSource()

         cargarDirectivaVigente()

      Catch ex As Exception
         TratarError(ex, "cargarDirectivas")
      End Try

   End Sub

   Private Sub btnNuevaDirSeg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaDirSeg.Click

      Dim oForm As New frmAbmDirSeg

      If oForm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
         cargarDirSeg()
      End If

      oForm = Nothing

   End Sub

   Private Sub btnPropDirSeg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPropDirSeg.Click

      Dim oForm As New frmAbmDirSeg

      If gDirSeg.SelectedRowsCount > 0 Then

         oForm.PasarDatos(ValGrilla(gDirSeg, "DS_CODDIR"))

         If oForm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            cargarDirSeg()
         End If

      End If

      oForm = Nothing

   End Sub

   Private Sub btnEliminarDirSeg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarDirSeg.Click


      If gDirSeg.SelectedRowsCount > 0 Then
         If Pregunta("¿Eliminar directiva de seguridad?") = Windows.Forms.DialogResult.Yes Then

            Dim sSQL As String

            sSQL = "DELETE " & _
                   "FROM      DIRSEG " & _
                   "WHERE     DS_CODDIR = " & ValGrilla(gDirSeg, "DS_CODDIR")
            If oAdmLocal.EjecutarComandoAsincrono(sSQL) Then
               cargarDirSeg()
            End If

         End If
      End If

   End Sub

   Private Sub btnPredetermDirSeg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPredetermDirSeg.Click

      If gDirSeg.SelectedRowsCount > 0 Then
         If Pregunta("¿Establecer directiva de seguridad como predeterminada?") = Windows.Forms.DialogResult.Yes Then

            Dim sSQL As String

            sSQL = "UPDATE    DIRSEG " & _
                   "SET       DS_VIGENT = 0 "
            If oAdmLocal.EjecutarComandoAsincrono(sSQL) Then

               sSQL = "UPDATE    DIRSEG " & _
                      "SET       DS_VIGENT = 1 " & _
                      "WHERE     DS_CODDIR = " & ValGrilla(gDirSeg, "DS_CODDIR")
               If oAdmLocal.EjecutarComandoAsincrono(sSQL) Then
                  cargarDirSeg()
               End If

            End If

         End If
      End If

   End Sub
End Class
