Imports System.DirectoryServices

Public Class frmMain

   Private oAdmLocal As New AdmTablas
   Private oIconos As New ExtraerIconos

   Public Sub New()

      ' Llamada necesaria para el Diseñador de Windows Forms.
      InitializeComponent()

      ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
      oAdmlocal.ConnectionString = CONN_LOCAL

      lblUsuario.Text = UsuarioActual.Descripcion
      lblEntidad.Text = NOMBRE_ENTIDAD ' UsuarioActual.Entidad

      If SIEMPRE_ICONOS_GRANDES Then
         lvTrans.SmallImageList = il32x32
      Else
         lvTrans.SmallImageList = il16x16
      End If

   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click, btnSalir.Click
      Me.Close()
   End Sub

   Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      CargarArbol()
      CargarMenues(0)
   End Sub

   Private Sub CargarArbol()

      Dim sSQL As String
      Dim ds As DataSet
      Dim nodo As TreeNode
      Dim nuevoNodo() As TreeNode

      Try

         sSQL = "SELECT       * " & _
                "FROM         MENUES " & _
                "WHERE        MU_NIVEL <> 0 " & _
                "ORDER BY     MU_NIVEL, MU_TRANSA"
         ds = oAdmlocal.AbrirDataset(sSQL)

         tvMenu.Nodes.Clear()

         With ds.Tables(0)

            nodo = tvMenu.Nodes.Add("K0", "Menú", "Menu")

            For Each dr As DataRow In .Rows

               tvMenu.BeginUpdate()
               nuevoNodo = tvMenu.Nodes.Find("K" & dr("MU_RELMEN").ToString, True)
               nuevoNodo(0).Nodes.Add("K" & dr("MU_NROMEN").ToString, dr("MU_TRANSA").ToString, "Cerrada")
               tvMenu.EndUpdate()

            Next

         End With

         nodo.Expand()

      Catch ex As Exception
         TratarError(ex, "CargarArbol")
      End Try

   End Sub

   Private Sub CargarMenues(ByVal nMenu As Long)

        Dim sSQL As String = ""
      Dim ds As DataSet
      Dim nodo As ListViewItem

      Try

         LimpiarIL()

         'Cargo las carpetas
         sSQL = "SELECT    * " & _
                "FROM      MENUES " & _
                "WHERE     MU_RELMEN = " & nMenu.ToString & " " & _
                "ORDER BY  MU_NIVEL DESC, MU_TRANSA ASC"
         ds = oAdmLocal.AbrirDataset(sSQL)

         lvTrans.Items.Clear()

         For Each dr As DataRow In ds.Tables(0).Rows
                If dr("MU_CODTRA") = 0 Then
                    ' Adding the text value of a folder in the list view
                    nodo = lvTrans.Items.Add("C" & dr("MU_NROMEN").ToString, dr("MU_TRANSA").ToString, "Carpeta")

                    ' We add the description value to the list view ,
                    ' if the column is empty in db, the value of the list view will be empty
                    nodo.SubItems.Add(dr("MU_DESCRI".ToString))

                Else
                    nodo = lvTrans.Items.Add(dr("MU_TRANSA").ToString)

                    ' We add the description value to the list view ,
                    ' if the column is empty in db, the value of the list view will be empty
                    nodo.SubItems.Add(dr("MU_DESCRI".ToString))
                    nodo.Name = "T" & dr("MU_CODTRA").ToString
                    nodo.Tag = dr("MU_COMAND").ToString

                    ' We add an icon to the list view row deppending the value of the .exe that
                    ' we find in the column MU_COMAND in db
                    ' Important: Find any one of this values in the collection of icons of the list view

                    Select Case dr("MU_COMAND").ToString().Trim()
                        Case "VBP04295.EXE"
                            If InStr("4102, 4104, 4103, 4105, 4106, 4107, 4194, 4101, 4195, 4196, 6191", dr("MU_CODTRA").ToString, CompareMethod.Text) > 0 Then
                                nodo.ImageKey = "Controles"
                            Else
                                nodo.ImageKey = "Formularios"
                            End If
                        Case "VBP04395.EXE"
                            nodo.ImageKey = "Procesos"
                        Case "VBP04865.EXE"
                            nodo.ImageKey = "Actualizador"
                        Case "VBP04721.EXE"
                            nodo.ImageKey = "Administracion"
                        Case "VBP08800.EXE"
                            nodo.ImageKey = "Calculadora"
                        Case "VBP04098.EXE"
                            nodo.ImageKey = "Consolida"
                        Case "VBP04000.EXE"
                            nodo.ImageKey = "Consultas"
                        Case "VBP04725.EXE"
                            nodo.ImageKey = "Equivalencias"
                        Case "VBP04893.EXE"
                            nodo.ImageKey = "Feriados"
                        Case "VBP09001.EXE"
                            nodo.ImageKey = "GeneraTXT"
                        Case "VBP04711.EXE"
                            nodo.ImageKey = "Logs"
                        Case "VBP70199.EXE"
                            nodo.ImageKey = "Notas"
                        Case "VBP04730.EXE"
                            nodo.ImageKey = "Relaciones"
                        Case "VBP04720.EXE"
                            nodo.ImageKey = "Seguridad"
                        Case "VBP04999.EXE"
                            nodo.ImageKey = "Spool"
                        Case "VBP04723.EXE"
                            nodo.ImageKey = "Tabgen"

                            'We needs an exe to asign the ExportExcel icon
                            '  Case ""
                            '     nodo.ImageKey = "ExportExcel"
                        Case Else
                            nodo.ImageKey = "Transaccion"


                    End Select

                    ' Here we add the transaction code to the list view
                    nodo.SubItems.Add(dr("MU_CODTRA"))

                End If
            Next

            ds = Nothing

            Dim oNodo() As TreeNode = tvMenu.Nodes.Find("K" & nMenu.ToString, True)

            tvMenu.SelectedNode = oNodo(0)
         'tvMenu.SelectedNode.Expand()

        Catch ex As Exception
            TratarError(ex, "CargarMenues(" & nMenu.ToString & ")")
        End Try

   End Sub

   Private Sub txtCodTra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodTra.KeyDown

      On Error Resume Next

      Dim sSQL As String
      Dim ds As DataSet

      If e.KeyCode = Keys.Return Then

         sSQL = "SELECT    TOP 1 * " & _
                "FROM      MENUES " & _
                "WHERE     MU_CODTRA = " & Val(txtCodTra.Text) & " "

         ds = oAdmLocal.AbrirDataset(sSQL)

         If ds.Tables(0).Rows.Count = 0 Then
            MensajeError("Transacción inexistente")
         Else
            EjecutarTransaccion(Val(txtCodTra.Text), ds.Tables(0).Rows(0)("MU_COMAND").ToString)
         End If

      End If

   End Sub

   Private Sub EjecutarTransaccion(ByVal nTransaccion As Long, ByVal sPrograma As String, Optional ByVal nCodigoUsuario As Integer = -1)

      Try

         Dim oTrx As New System.Diagnostics.Process

         If nCodigoUsuario = -1 Then

            nCodigoUsuario = UsuarioActual.Codigo

            If Not TransaccionHabilitada(nTransaccion) Then
               GuardarLOG(AccionesLOG.AL_VIOLACION_SEGURIDAD, "", nTransaccion)
               MensajeError("Violación de seguridad. No dispone de privilegios para ingresar a esta transacción")
               Exit Try
            End If

         Else

            If Not TransaccionHabilitadaEnUsuario(nTransaccion, nCodigoUsuario) Then
               GuardarLOG(AccionesLOG.AL_VIOLACION_SEGURIDAD, "", nTransaccion, nCodigoUsuario)
               MensajeError("Violación de seguridad. No dispone de privilegios para ingresar a esta transacción")
               Exit Try
            End If

         End If

         If IO.File.Exists(RUTA_BIN & sPrograma) Then

            oTrx.StartInfo.FileName = RUTA_BIN & sPrograma
            oTrx.StartInfo.Arguments = "/u:" & nCodigoUsuario.ToString & "/t:" & nTransaccion.ToString & "/e:" & CODIGO_ENTIDAD.ToString
            oTrx.StartInfo.UseShellExecute = True
            oTrx.StartInfo.WorkingDirectory = RUTA_BIN
            oTrx.Start()

            If MULTIEXEC = 0 Then
               oTrx.WaitForExit()
            End If

         Else
            MensajeError("No se encuentra el programa " & sPrograma)
         End If

      Catch ex As Exception
         TratarError(ex, "EjecutarTransaccion(" & nTransaccion.ToString & "," & sPrograma & "," & nCodigoUsuario & ")")
      End Try

   End Sub

   Private Sub btnIr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIr.Click

      Dim evArgs As New System.Windows.Forms.KeyEventArgs(Keys.Return)

      txtCodTra_KeyDown(sender, evArgs)

   End Sub

   Private Sub lvTrans_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvTrans.MouseDoubleClick

      Dim oItem As ListViewItem

      oItem = lvTrans.HitTest(e.Location).Item

      If oItem.Name.Substring(0, 1) = "T" Then
         EjecutarTransaccion(Val(oItem.Name.Substring(1)), oItem.Tag)
      Else
         CargarMenues(Val(oItem.Name.Substring(1)))
      End If

   End Sub

   Private Sub tvMenu_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvMenu.NodeMouseClick
      CargarMenues(Val(e.Node.Name.Substring(1)))
   End Sub

   Private Sub mnuPreferencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPreferencias.Click

      Dim oOpciones As New frmOpciones

      oOpciones.ShowDialog(Me)

      oOpciones = Nothing

   End Sub

   Private Sub LimpiarIL()

      'Dim nC As Integer

      ' For nC = (il16x16.Images.Count - 1) * -1 To -2
      ' il16x16.Images.RemoveAt(nC * -1)
      ' Next

      'For nC = (il32x32.Images.Count - 1) * -1 To -2
      ' il32x32.Images.RemoveAt(nC * -1)
      ' Next

   End Sub

   Private Sub mnuIconos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIconos.Click

      lvTrans.View = View.Tile

   End Sub

   Private Sub mnuLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLista.Click

      lvTrans.View = View.List

   End Sub

   Private Sub mnuDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDetalle.Click

      lvTrans.View = View.Details

   End Sub

    Public Sub ActualizarSeguridad(Optional ByVal sPerfil As String = "")

        Dim oAdmUsuarios As New AdmUsuarios

        If SEGURIDAD_INTEGRADA Then

            HABILITACIONES_ESPECIALES = MenuesSeguridadIntegrada(UsuarioActual.Nombre)
            INHABILITACIONES_ESPECIALES = ""

            mnuActualizar.Enabled = False

        ElseIf ID_SISTEMA <> 0 Then '2009/10/27 CITIBANK

            HABILITACIONES_ESPECIALES = TrxCitiBank(sPerfil)

        Else

            HABILITACIONES_ESPECIALES = oAdmUsuarios.DevolverHabilitacionesUsuario(UsuarioActual.Codigo)
            INHABILITACIONES_ESPECIALES = oAdmUsuarios.DevolverInhabilitacionesUsuario(UsuarioActual.Codigo)

        End If

        oAdmUsuarios = Nothing

    End Sub

    Private Function TransaccionHabilitada(ByVal nCodTransaccion As Long) As Boolean

        If UCase(UsuarioActual.Nombre) = "ADMIN" Then
            TransaccionHabilitada = True
            Exit Function
        End If

        If Len(HABILITACIONES_ESPECIALES) > 0 Then
            If InStr(1, HABILITACIONES_ESPECIALES, CStr(nCodTransaccion)) > 0 Then
                If Len(INHABILITACIONES_ESPECIALES) > 0 Then
                    If InStr(1, INHABILITACIONES_ESPECIALES, CStr(nCodTransaccion)) = 0 Then
                        TransaccionHabilitada = True
                    End If
                Else
                    TransaccionHabilitada = True
                End If
            End If
        End If

    End Function

    Private Function TransaccionHabilitadaEnUsuario(ByVal nCodTransaccion As Long, ByVal nCodUsuario As Long) As Boolean

        Dim sHabs As String = ""
        Dim sInHabs As String = ""
        Dim oAdmUsuarios As New AdmUsuarios

        If SEGURIDAD_INTEGRADA Then

            sHabs = MenuesSeguridadIntegrada(oAdmLocal.DevolverValor("USUARI", "US_NOMBRE", "US_CODUSU=" & nCodUsuario, ""))
            sInHabs = ""

        Else

            sHabs = oAdmUsuarios.DevolverHabilitacionesUsuario(nCodUsuario)
            sInHabs = oAdmUsuarios.DevolverInhabilitacionesUsuario(nCodUsuario)

        End If

        If Len(sHabs) > 0 Then
            If InStr(1, sHabs, CStr(nCodTransaccion)) > 0 Then
                If Len(sInHabs) > 0 Then
                    If InStr(1, sInHabs, CStr(nCodTransaccion)) = 0 Then
                        TransaccionHabilitadaEnUsuario = True
                    End If
                Else
                    TransaccionHabilitadaEnUsuario = True
                End If
            End If
        End If

    End Function

    Public Function MenuesSeguridadIntegrada(ByVal sNombreUsuario As String) As String

        On Error GoTo Err_Trap

        Dim sTemp As String = ""
        Dim sMatriz() As String
        Dim i As Integer

        Dim oConn As ADODB.Connection
        Dim oComm As ADODB.Command
        Dim oRst As ADODB.Recordset

        ' CONEXION
        oConn = New ADODB.Connection

        oConn.ConnectionString = "DRIVER=SQL Server;" & _
                                 "SERVER=" & NOMBRE_SQLSERVER & ";" & _
                                 "APP=PREXRI;" & _
                                 "WSID=" & sNombreUsuario & ";" & _
                                 "DATABASE=" & NOMBRE_BD & ";" & _
                                 "NETWORK=DBMSLPCN;" & _
                                 "TRUSTED_CONNECTION=YES"
        oConn.Open()

        ' PERMISOS

        oComm = New ADODB.Command

        oComm.ActiveConnection = oConn
        oComm.CommandText = "EXEC sp_setapprole 'AppSeguridad' , {Encrypt N 'SegIntWin'} , 'odbc'"
        oComm.Execute()

        oComm = Nothing

        ' RECORDSET CON MENUES

        oComm = New ADODB.Command
        oComm.ActiveConnection = oConn
        oComm.CommandText = "EXEC crearCursorTree '" & NUMERO_SISTEMA & "','" & UsuarioActual.Nombre & "', '" & LOG_AUDITORIA & "'"
        oRst = oComm.Execute

        With oRst

            If Not (.BOF And .EOF) Then

                Do Until .EOF

                    sTemp = sTemp & .Fields("NodoCall").Value & ","

                    .MoveNext()

                Loop

            End If

        End With

        MenuesSeguridadIntegrada = sTemp

        '   Open "C:\MenuesSegInt.txt" For Output As #1
        '      Print #1, CONN_LOCAL
        '      Print #1, "--------------------------------------------"
        '      Print #1, sTemp
        '   Close #1

Err_Trap:

        oConn = Nothing
        oComm = Nothing
        oRst = Nothing

        If Err.Number <> 0 Then
            TratarErrorErr(Err, "MenuesSeguridadIntegrada")
        End If

    End Function

    Private Function DatosEquipo() As String

        On Error Resume Next

        Dim ds As DataSet
        Dim sSQL As String
        Dim sTemp As String = ""

        sTemp = "Ruta aplicación: " & vbCrLf & Application.ExecutablePath & vbCrLf & vbCrLf

        sSQL = "SELECT DB_NAME() AS BASEDATOS "
        ds = oAdmLocal.AbrirDataset(sSQL)

        sTemp = sTemp & "Base de datos: " & vbCrLf & ds.Tables(0).Rows(0).Item("BASEDATOS") & vbCrLf & vbCrLf

        ds = Nothing

        sSQL = "SELECT   CONVERT(char(20), SERVERPROPERTY('servername')) AS SERVIDOR "
        ds = oAdmLocal.AbrirDataset(sSQL)

        sTemp = sTemp & "Servidor SQL: " & vbCrLf & ds.Tables(0).Rows(0).Item("SERVIDOR") & vbCrLf & vbCrLf

        ds = Nothing

        sSQL = "SELECT   CONVERT(char(20), SERVERPROPERTY('collation')) as COLL"
        ds = oAdmLocal.AbrirDataset(sSQL)

        sTemp = sTemp & "Intercalación SQL: " & vbCrLf & ds.Tables(0).Rows(0).Item("COLL") & vbCrLf & vbCrLf

        ds = Nothing

        sSQL = "SELECT @@VERSION AS VERSIONSQL "
        ds = oAdmLocal.AbrirDataset(sSQL)

        sTemp = sTemp & "Versión SQL: " & vbCrLf & Replace(Replace(ds.Tables(0).Rows(0).Item("VERSIONSQL"), vbLf, vbCrLf), vbTab, "") & vbCrLf

        ds = Nothing

        Return sTemp

    End Function

    Private Function TrxCitiBank(ByVal sPerfil As String) As String

        Dim sSQL As String
        Dim ds As DataSet
        Dim sTemp As String = ""

        Try

            sSQL = "       SELECT      DISTINCT DP_CODTRA " & vbCrLf
            sSQL = sSQL & "FROM        DETPER " & vbCrLf
            sSQL = sSQL & "INNER JOIN  CABPER " & vbCrLf
            sSQL = sSQL & "ON          CP_CODPER = DP_CODPER " & vbCrLf
            sSQL = sSQL & "WHERE       CP_DESCRI LIKE '" & Replace(sPerfil, "*", "%") & "' "

            ds = oAdmLocal.AbrirDataset(sSQL)

            For Each row As DataRow In ds.Tables(0).Rows
                sTemp = sTemp & row("DP_CODTRA") & ","
            Next

            ds = Nothing

        Catch ex As Exception
            TratarError(ex, "trxCitibank")
        End Try

        Return sTemp

    End Function

    Private Sub btnSubir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubir.Click

        subirCarpeta()

    End Sub

    Private Sub subirCarpeta()



        If Not (tvMenu.SelectedNode Is Nothing) Then
            If tvMenu.SelectedNode.Name <> "K0" Then
                Dim nMenu As Long = Convert.ToInt32(tvMenu.SelectedNode.Parent.Name.Substring(1))
                tvMenu.SelectedNode = tvMenu.Nodes(tvMenu.SelectedNode.Parent.Name)
                CargarMenues(nMenu)
            End If
        End If

    End Sub

    Private Sub mnuAcerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAcerca.Click

        Dim oSplash As New SplashScreen

        oSplash.AcercaDe = True
        oSplash.ShowDialog()

        oSplash = Nothing

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

   Private Sub lvTrans_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvTrans.SelectedIndexChanged

   End Sub

   Private Sub txtCodTra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodTra.Click

   End Sub

   Private Sub tvMenu_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMenu.AfterSelect

   End Sub
End Class
