Imports WebSupergoo
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Xpo

Public Class frmMain

   Public Class DropDownGrid
      Inherits XPObject
      Public Sub New()
         Codigo = Nothing
         Descripcion = ""
      End Sub
      Public Codigo As Object
      Public Descripcion As String
   End Class

   Private Const TABLA_TEMPORAL As String = "OrigenDatosTemp"

   Private nIndexOr As Integer
   Private oAdmlocal As New AdmTablas
   Private oTabla As New dsTabla
   Private bCambios As Boolean
   Private oProcesando As frmProcesando

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

         Dim sSQL As String
         Dim ds As DataSet
         Dim sError As String = ""

         ''''' USUARIO '''''

         sSQL = "SELECT    US_CODUSU, US_NOMBRE, US_DESCRI, US_ADMIN " & _
                "FROM      USUARI " & _
                "WHERE     US_CODUSU = " & nCodigoUsuario
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)

            If .Rows.Count = 0 Then
               sError = "Falla de seguridad"
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

         sSQL = "SELECT    TG_CODCON, TG_DESCRI " & _
                "FROM      TABGEN " & _
                "WHERE     TG_CODTAB = 1 " & _
                "AND       TG_CODCON = " & nCodigoEntidad
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)

            If .Rows.Count = 0 Then
               sError = "Parámetro de entidad no válido"
            Else
               NOMBRE_ENTIDAD = .Rows(0).Item("TG_DESCRI")
               lblEntidad.Text = NOMBRE_ENTIDAD
            End If

         End With

         ds = Nothing

         ''''' TRANSACCION '''''

         sSQL = "SELECT    MU_TRANSA, MU_DESCRI " & _
                "FROM      MENUES " & _
                "WHERE     MU_CODTRA = " & nCodigoTransaccion
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)


            If .Rows.Count = 0 Then
               sError = "Error en la línea de comandos. Parámetro de transacción incorrecto"
            Else
               lblTransaccion.Text = .Rows(0).Item("MU_DESCRI")
               Me.Text = CODIGO_TRANSACCION.ToString & " - " & .Rows(0).Item("MU_TRANSA")
            End If

         End With

         ds = Nothing

         lblVersion.Text = "Versión: " & Application.ProductVersion

         If sError <> "" Then
            MensajeError(sError)
            Application.Exit()
         End If

      Catch ex As Exception
         TratarError(ex, "AnalizarCommand")
         Application.Exit()
      End Try

   End Sub

   Public Sub New()

      ' Llamada necesaria para el Diseñador de Windows Forms.
      InitializeComponent()

      ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
      oAdmLocal.ConnectionString = CONN_LOCAL
      AnalizarCommand()

   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
      Me.Close()
   End Sub


    Private Sub Cargar()

        cboTabla1.Text = "<Seleccionar...>"
        txtFecha.Format = DateTimePickerFormat.Custom
      txtFecha.CustomFormat = "dd/MM/yyyy"
      txtFecha.Value = Date.Today

      CargarTablas()

        cboTabla1.Enabled = True
        cboTabla1.Focus()

        cboPeriodo1.Text = ""
        cboPeriodo1.Enabled = False

        GridDiseno.DataSource = Nothing
      GridDiseno.RefreshDataSource()
      GridDiseno.Refresh()
      GridDiseno.Enabled = False

      gResult.Columns.Clear()
      Grid.DataSource = Nothing
      Grid.RefreshDataSource()
      Grid.Refresh()

      txtOrigen.Text = ""
      cmdIncorporar.Text = "&Vista previa"

        tabDatos.Enabled = False

        cboTipo.Items.Clear()
        cboTipo.Items.Add(New clsItem.Item("K1", "Ancho fijo"))
        cboTipo.Items.Add(New clsItem.Item("K2", "Delimitado por caracter"))
        cboTipo.SelectedIndex = 0

        'SelComboBox(cboTipo, "K1")

        FiltrarTipo()
        optTexto.Checked = True

        DropDowns()

    End Sub

    Private Sub CargarTablas(Optional ByVal sSeleccion As String = "")

        Try
            Dim sSQL As String
            Dim ds As DataSet

            sSQL = "SELECT    DN_TABLA, MAX(DN_NOMBRE) AS DN_NOMBRE " &
                "FROM      DISNOM " &
                "WHERE     DN_TABLA IS NOT NULL " &
                "AND       DN_TABLA <> '' " &
                "AND       DN_INACTIVO = 0 "

            If chkTodas.Checked Then
                sSQL = sSQL & "AND       DN_CODENT IN (0, " & CODIGO_ENTIDAD & ") "
            Else
                sSQL = sSQL & "AND       DN_CODENT = " & CODIGO_ENTIDAD & " "
            End If

            sSQL = sSQL &
                "GROUP BY  DN_TABLA " &
                "ORDER BY  MAX(DN_NOMBRE) ASC"
            ds = oAdmlocal.AbrirDataset(sSQL)

            cboTabla1.Items.Clear()
            cboTabla1.Items.Add(New clsItem.Item("SELECCIONAR", "<Seleccionar...>"))
            With ds.Tables(0)
                For Each row As DataRow In .Rows
                    cboTabla1.Items.Add(New clsItem.Item("K" & row("DN_TABLA"), row("DN_NOMBRE")))
                Next
            End With

            ds = Nothing

            cboTabla1.Items.Add(New clsItem.Item("NUEVA", "Nueva tabla..."))

            If sSeleccion <> "" Then
                SelComboBox(cboTabla1, sSeleccion)
            Else
                SelComboBox(cboTabla1, "SELECCIONAR")
            End If

            ds = Nothing

        Catch ex As Exception
            TratarError(ex, "CargarTablas")
        End Try
    End Sub

    Private Sub FiltrarTipo()

        If optTexto.Checked Then
            If Val(Llave(cboTipo)) = 2 Then
                lblSep.Visible = True
                txtSep.Visible = True
                txtCualif.Visible = True
            Else
                lblSep.Visible = False
                txtSep.Visible = False
                txtCualif.Visible = False
            End If
        End If

    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Cargar()

    End Sub

    Private Sub chkTodas_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodas.CheckedChanged
        If chkTodas.CheckState = CheckState.Checked Then
            CargarTablas()
        End If
    End Sub


    Private Sub btnOtra1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtra1.Click
        Cargar()
    End Sub

    Private Sub EliminarTabla()

        Try

            Dim sSQL As String = ""

            If cboTabla1.SelectedItem Is Nothing Then
                MensajeError("Debe seleccionar una tabla")
                cboTabla1.Focus()
                Exit Sub
            End If

            If cboPeriodo1.SelectedItem Is Nothing Then
                MensajeError("Debe seleccionar un período")
                cboPeriodo1.Focus()
                Exit Sub
            End If

            If Pregunta("¿Eliminar Tabla?") = vbNo Then
                Exit Sub
            End If

            sSQL = "DELETE " &
                "FROM      DISPOS " &
                "WHERE     DP_NOMBRE = '" & Llave(cboTabla1) & "' " &
                "AND       DP_CODENT IN (0, " & CODIGO_ENTIDAD.ToString & ") " &
                "AND       DP_FECVIG = " & FechaSQL(CDate(cboPeriodo1.Text)) & " "
            oAdmlocal.EjecutarComandoAsincrono(sSQL)

            sSQL = "DELETE " &
                "FROM      DISNOM " &
                "WHERE     DN_TABLA = '" & Llave(cboTabla1) & "' " &
                "AND       DN_CODENT IN (0, " & CODIGO_ENTIDAD.ToString & ") " &
                "AND       DN_FECHAVIG = " & FechaSQL(CDate(cboPeriodo1.Text)) & " "
            oAdmlocal.EjecutarComandoAsincrono(sSQL)

            sSQL = "IF EXISTS(SELECT * FROM SYSOBJECTS WHERE TYPE='U' AND NAME='" & Llave(cboTabla1) & "_" & Llave(cboPeriodo1) & "') BEGIN " &
                "DROP TABLE " & Llave(cboTabla1) & "_" & Llave(cboPeriodo1) & " " &
                "END"
            oAdmlocal.EjecutarComandoAsincrono(sSQL)

            Cargar()

        Catch ex As Exception
            TratarError(ex, "EliminarTabla")
        End Try

    End Sub

    Private Sub btnEliminarTabla1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarTabla1.Click
        EliminarTabla()
    End Sub

    Private Sub CargarTabla()

        Dim oItem As clsItem.Item

        If Not cboTabla1.SelectedItem Is Nothing Then

            oItem = cboTabla1.SelectedItem
            If oItem.Valor.ToString = "NUEVA" Then

                NOMBRE_NUEVA_TABLA = ""
                DESCRIPCION_NUEVA_TABLA = ""
                ' FECHA_VIG_NUEVA_TABLA = ""

                'Load(frmNuevaTabla)
                'frmNuevaTabla.Show(vbModal)

                If NOMBRE_NUEVA_TABLA = "" Then
                    cboTabla1.SelectedItem = Nothing
                    cboTabla1.Text = "<Seleccionar...>"
                Else
                    cboTabla1.Items.Add(New clsItem.Item("K" & NOMBRE_NUEVA_TABLA, DESCRIPCION_NUEVA_TABLA))
                    SelCombo(cboTabla1, "K" & NOMBRE_NUEVA_TABLA)
                    RefrescarEstructura()
                    cboTabla1.Enabled = False
                End If

            Else

                RefrescarEstructura()
                cboTabla1.Enabled = False
                tabDatos.Enabled = True

            End If

        End If

    End Sub

   Private Sub CargarPeriodos()

      Try

         Dim sSQL As String
         Dim ds As DataSet

         Cursor = Cursors.WaitCursor

            cboPeriodo1.Enabled = True
            cboPeriodo1.Items.Clear()

            sSQL = "SELECT    DISTINCT DN_FECHAVIG " &
                "FROM      DISNOM " &
                "WHERE     DN_TABLA = '" & Llave(cboTabla1) & "' " &
                "AND       DN_CODENT IN (0, " & CODIGO_ENTIDAD.ToString & ") " &
                "ORDER BY  DN_FECHAVIG DESC "
            ds = oAdmlocal.AbrirDataset(sSQL)

         With ds.Tables(0)
            For Each row As DataRow In .Rows
                    cboPeriodo1.Items.Add(New clsItem.Item("K" & Format(row("DN_FECHAVIG"), "yyyyMMdd"), row("DN_FECHAVIG")))
                Next
         End With

         ds = Nothing

            If cboPeriodo1.Items.Count = 1 Then
                cboPeriodo1.SelectedIndex = 0
                CargarTabla()
            Else
                cboPeriodo1.Text = "<Seleccione un período...>"
            End If

         Cursor = Cursors.Default

      Catch ex As Exception
         Cursor = Cursors.Default
         TratarError(ex, "RefrescarEstructura")
      End Try

   End Sub

   Private Sub RefrescarEstructura()

      Try

         Dim sSQL As String
         Dim ds As DataSet
         Dim oRow As DataRow

         oTabla = Nothing
         oTabla = New dsTabla

            sSQL = "SELECT    * " &
                "FROM      DISPOS " &
                "WHERE     DP_NOMBRE = '" & Llave(cboTabla1) & "' " &
                "AND       DP_FECVIG = " & FechaSQL(CDate(cboPeriodo1.Text)) & " " &
                "AND       DP_CODENT IN (0, " & CODIGO_ENTIDAD.ToString & ") " &
                "ORDER BY  DP_INICIO "
            ds = oAdmlocal.AbrirDataset(sSQL)

         With ds.Tables(0)
            For Each row As DataRow In .Rows

               oRow = oTabla.Diseno.NewRow

               oRow.Item("Nombre") = row("DP_NOMBRE")
               oRow.Item("Campo") = row("DP_CAMPO")
               oRow.Item("Inicio") = row("DP_INICIO")
               oRow.Item("Longitud") = row("DP_LONGITUD")
               oRow.Item("Fin") = row("DP_FIN")
               oRow.Item("Campo destino") = row("DP_CAMPO_DESTINO")
               oRow.Item("Tipo") = row("DP_TIPO").ToString.Trim
               oRow.Item("Formato") = row("DP_FORMATO")
               oRow.Item("Marca") = row("DP_MARCA")
               oRow.Item("Relacion") = row("DP_RELACION")
               oRow.Item("Valida") = row("DP_VALIDA")
               oRow.Item("CodEnt") = row("DP_CODENT")
               oRow.Item("Fecha") = row("DP_FECVIG")
               oRow.Item("Clave") = row("DP_CLAVE")

               oTabla.Diseno.Rows.Add(oRow)
               oTabla.AcceptChanges()
               oRow = Nothing

               'oCampo = Nothing

            Next
         End With

         GridDiseno.Enabled = True
         GridDiseno.DataSource = oTabla.Diseno
         GridDiseno.RefreshDataSource()
         GridDiseno.Refresh()

      Catch ex As Exception
         TratarError(ex, "RefrescarEstructura")
      End Try

   End Sub

    Private Sub cboTabla1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTabla1.SelectedIndexChanged

        Dim cboX As clsItem.Item
        Dim bExisteCbo As Boolean

        If Not cboTabla1.SelectedItem Is Nothing Then

            cboX = cboTabla1.SelectedItem

            If cboX.Valor.ToString = "NUEVA" Then

                NOMBRE_NUEVA_TABLA = ""
                DESCRIPCION_NUEVA_TABLA = ""
                ' FECHA_VIG_NUEVA_TABLA = ""

                'Load(frmNuevaTabla)
                'frmNuevaTabla.Show(vbModal)

                If NOMBRE_NUEVA_TABLA = "" Then
                    cboTabla1.SelectedItem = Nothing
                    cboTabla1.Text = "<Seleccionar...>"
                Else

                    For Each cboX In cboTabla1.Items
                        If cboX.Valor.ToString = "K" & NOMBRE_NUEVA_TABLA Then
                            bExisteCbo = True
                            Exit For
                        End If
                    Next

                    If Not bExisteCbo Then
                        cboTabla1.Items.Add(New clsItem.Item("K" & NOMBRE_NUEVA_TABLA, DESCRIPCION_NUEVA_TABLA))
                    End If

                    SelCombo(cboTabla1, "K" & NOMBRE_NUEVA_TABLA)
                    CargarPeriodos()
                    cboTabla1.Enabled = False
                End If

            Else

                CargarPeriodos()

            End If

        End If

    End Sub

    Private Sub cboPeriodo1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPeriodo1.SelectedIndexChanged
        CargarTabla()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

      frmExportar.PasarViewResultados(Me.Text, lblTransaccion.Text, gDiseno)
      frmExportar.ShowDialog()

   End Sub

   Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

      GridDiseno.ShowPrintPreview()

   End Sub

   Private Sub DropDowns()
        Exit Sub
        'DropDown Tipo

        Dim oItem As DropDownGrid
      Dim xpCollectionTipo As New XPCollection(GetType(DropDownGrid))
      xpCollectionTipo.DisplayableProperties = "This;Codigo;Descripcion"

      oItem = New DropDownGrid
      oItem.Codigo = "T"
      oItem.Descripcion = "Texto"
      xpCollectionTipo.Add(oItem)

      oItem = New DropDownGrid
      oItem.Codigo = "F"
      oItem.Descripcion = "Fecha"
      xpCollectionTipo.Add(oItem)

      oItem = New DropDownGrid
      oItem.Codigo = "N0"
      oItem.Descripcion = "Número"
      xpCollectionTipo.Add(oItem)

      oItem = New DropDownGrid
      oItem.Codigo = "N2"
      oItem.Descripcion = "Número 2 decimales"
      xpCollectionTipo.Add(oItem)

      oItem = New DropDownGrid
      oItem.Codigo = "N4"
      oItem.Descripcion = "Número 4 decimales"
      xpCollectionTipo.Add(oItem)

      oItem = New DropDownGrid
      oItem.Codigo = "N6"
      oItem.Descripcion = "Número 6 decimales"
      xpCollectionTipo.Add(oItem)

      Dim oLookUp As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
      oLookUp.Name = "luTipo"
      oLookUp.DataSource = xpCollectionTipo
      oLookUp.DisplayMember = "Descripcion"
      oLookUp.ValueMember = "Codigo"
      oLookUp.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo"))
      oLookUp.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion"))
      oLookUp.Columns("Codigo").Visible = False
      oLookUp.ShowFooter = False
      oLookUp.ShowHeader = False
      GridDiseno.RepositoryItems.Add(oLookUp)

      CType(GridDiseno.MainView, ColumnView).Columns("Tipo").ColumnEdit = oLookUp

      oLookUp = Nothing

      'DropDown Valida

      Dim xpCollectionValida As New XPCollection(GetType(DropDownGrid))
      xpCollectionValida.DisplayableProperties = "This;Codigo;Descripcion"

      oItem = New DropDownGrid
      oItem.Codigo = 0
      oItem.Descripcion = "Sin validación"
      xpCollectionValida.Add(oItem)

      oItem = New DropDownGrid
      oItem.Codigo = 1
      oItem.Descripcion = "Validar fecha"
      xpCollectionValida.Add(oItem)

      oItem = New DropDownGrid
      oItem.Codigo = 2
      oItem.Descripcion = "Validar entidad"
      xpCollectionValida.Add(oItem)

      oItem = New DropDownGrid
      oItem.Codigo = 99
      oItem.Descripcion = "Incorpora fecha"
      xpCollectionValida.Add(oItem)

      oItem = New DropDownGrid
      oItem.Codigo = 98
      oItem.Descripcion = "Incorpora entidad"
      xpCollectionValida.Add(oItem)

      oItem = New DropDownGrid
      oItem.Codigo = 50
      oItem.Descripcion = "Convierte en decimal"
      xpCollectionValida.Add(oItem)

      oItem = New DropDownGrid
      oItem.Codigo = 3
      oItem.Descripcion = "Valida Cuenta"
      xpCollectionValida.Add(oItem)

      oLookUp = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
      oLookUp.Name = "luValida"
      oLookUp.DataSource = xpCollectionValida
      oLookUp.DisplayMember = "Descripcion"
      oLookUp.ValueMember = "Codigo"
      oLookUp.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo"))
      oLookUp.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion"))
      oLookUp.Columns("Codigo").Visible = False
      oLookUp.ShowFooter = False
      oLookUp.ShowHeader = False
      GridDiseno.RepositoryItems.Add(oLookUp)

      CType(GridDiseno.MainView, ColumnView).Columns("Valida").ColumnEdit = oLookUp

   End Sub

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
      GuardarDiseno()
   End Sub

   Private Sub GuardarDiseno()

      Try

         Dim ds As DataSet
         Dim sSQL As String
         Dim row As DataRow
         Dim da As OleDb.OleDbDataAdapter
         Dim cb As OleDb.OleDbCommandBuilder

            sSQL = "DELETE " &
                "FROM      DISPOS " &
                "WHERE     DP_NOMBRE = '" & Llave(cboTabla1) & "' " &
                "AND       DP_FECVIG = " & FechaSQL(CDate(cboPeriodo1.Text)) & " " &
                "AND       DP_CODENT IN (0, " & CODIGO_ENTIDAD.ToString & ")"
            oAdmlocal.EjecutarComandoSQL(sSQL)

            sSQL = "SELECT    * " &
                "FROM      DISPOS " &
                "WHERE     DP_NOMBRE = '" & Llave(cboTabla1) & "' " &
                "AND       DP_FECVIG = " & FechaSQL(CDate(cboPeriodo1.Text)) & " " &
                "AND       DP_CODENT IN (0, " & CODIGO_ENTIDAD.ToString & ")"
            ds = oAdmlocal.AbrirDataset(sSQL, da)
         cb = New OleDb.OleDbCommandBuilder(da)

         With ds.Tables(0)

            For Each oCampo As DataRow In oTabla.Diseno.Rows

               row = .NewRow

                    row("DP_NOMBRE") = Llave(cboTabla1)
                    row("DP_CAMPO") = oCampo("Campo")
               row("DP_INICIO") = oCampo("Inicio")
               row("DP_LONGITUD") = oCampo("Longitud")
               row("DP_FIN") = oCampo("Fin")
               row("DP_CAMPO_DESTINO") = oCampo("Campo destino")
               row("DP_TIPO") = oCampo("Tipo")
               row("DP_FORMATO") = oCampo("Formato")
               row("DP_MARCA") = oCampo("Marca")
               row("DP_RELACION") = oCampo("Relacion")
               row("DP_VALIDA") = oCampo("Valida")
               row("DP_CODENT") = oCampo("CodEnt")
               row("DP_FECVIG") = oCampo("Fecha")
               row("DP_CLAVE") = oCampo("Clave")

               ds.Tables(0).Rows.Add(row)
               da.Update(ds)
               ds.AcceptChanges()

            Next

         End With

         ds = Nothing

            sSQL = "SELECT * FROM SYSOBJECTS WHERE NAME='" & Llave(cboTabla1) & "_" & Llave(cboPeriodo1) & "' AND TYPE='U'"
            ds = oAdmlocal.AbrirDataset(sSQL)

         If ds.Tables(0).Rows.Count = 0 Then
            CrearTabla()
         Else
            ModificarTabla()
         End If

         ds = Nothing

         MensajeInformacion("El diseño ha sido guardado")

         bCambios = False

      Catch ex As Exception
         TratarError(ex, "GuardarDiseno")
      End Try

   End Sub

   Private Sub CrearTabla()
      Try

         Dim sSQL As String
         Dim sTipo As String
         Dim nLong As Long
         Dim bClave As Boolean

            sSQL = "CREATE TABLE " & Llave(cboTabla1) & "_" & Llave(cboPeriodo1) & " ("

            For Each oCampo As DataRow In oTabla.Diseno.Rows

            sTipo = oCampo("Tipo")

            If sTipo.Substring(0, 1) = "N" Then
               nLong = sTipo.Substring(1, 1)
            Else
               nLong = oCampo("Longitud")
            End If

            sSQL = sSQL & oCampo("Campo destino") & " " & TipoDatosSQL(sTipo, nLong) & ", " & vbCrLf

            If oCampo("Clave") > 0 Then
               bClave = True
            End If

         Next

         If bClave Then
            sSQL = sSQL & "PrexClave VARCHAR(255) NULL)"
         Else
            sSQL = Mid(sSQL, 1, Len(sSQL) - 2) & ")"
         End If

         oAdmlocal.EjecutarComandoAsincrono(sSQL)

      Catch ex As Exception
         TratarError(ex, "CrearTabla")
      End Try

   End Sub

   Private Sub CrearTablaTemp()

      Try

         Dim sSQL As String
         Dim sTipo As String
         Dim nLong As Long
         Dim bClave As Boolean

         sSQL = "IF EXISTS ( " & _
                "             SELECT      * " & _
                "             FROM        SYSOBJECTS " & _
                "             WHERE       NAME = '" & TABLA_TEMPORAL & "' " & _
                "             AND         TYPE = 'U' " & _
                "          ) BEGIN " & _
                "    DROP TABLE " & TABLA_TEMPORAL & " " & _
                "END "
         oAdmlocal.EjecutarComandoAsincrono(sSQL)

         sSQL = "CREATE TABLE " & TABLA_TEMPORAL & " ("

         For Each oCampo As DataRow In oTabla.Diseno.Rows

            sTipo = oCampo("Tipo")

            If sTipo.Substring(0, 1) = "N" Then
               nLong = sTipo.Substring(1, 1)
            Else
               nLong = oCampo("Longitud")
            End If

            sSQL = sSQL & oCampo("Campo destino") & " " & TipoDatosSQL(sTipo, nLong) & ", " & vbCrLf

            If oCampo("Clave") > 0 Then
               bClave = True
            End If

         Next

         If bClave Then
            sSQL = sSQL & "PrexClave VARCHAR(255) NULL)"
         Else
            sSQL = Mid(sSQL, 1, Len(sSQL) - 2) & ")"
         End If

         oAdmlocal.EjecutarComandoAsincrono(sSQL)

      Catch ex As Exception
         TratarError(ex, "CrearTablaTemp")
      End Try

   End Sub

   Private Sub ModificarTabla()

      Try

         Dim sSQL As String
         Dim ds As DataSet
         Dim oField As DataColumn
         Dim sTipo As String
         Dim bClave As Boolean
         Dim nLong As Long
         Dim bElimina As Boolean

            'Primero verifico si tengo columnas para dropear
            sSQL = "SELECT TOP 1 * FROM " & Llave(cboTabla1) & "_" & Llave(cboPeriodo1) & " "
            ds = oAdmlocal.AbrirDataset(sSQL)

         For Each oField In ds.Tables(0).Columns
            bElimina = True

            For Each oCampo As DataRow In oTabla.Diseno.Rows
               If oCampo("Campo destino").ToString.ToUpper = oField.ColumnName.ToUpper Then
                  bElimina = False
                  Exit For
               End If
            Next

            If bElimina Then
                    sSQL = sSQL & "ALTER TABLE " & Llave(cboTabla1) & "_" & Llave(cboPeriodo1) & " " &
                      "DROP COLUMN " & oField.ColumnName & vbCrLf
                End If
         Next

         ds = Nothing

         oAdmlocal.EjecutarComandoAsincrono(sSQL)

         'Segundo altero los campos que hayan cambiado y agrego los nuevos
         For Each oCampo As DataRow In oTabla.Diseno.Rows

            sTipo = oCampo("Tipo")

            If sTipo.Substring(0, 1) = "N" Then
               nLong = sTipo.Substring(1, 1)
            Else
               nLong = oCampo("Longitud")
            End If

            sSQL = sSQL & oCampo("Campo destino") & " " & TipoDatosSQL(sTipo, nLong) & ", " & vbCrLf

                If oAdmlocal.ExisteCampo(Llave(cboTabla1) & "_" & Llave(cboPeriodo1), oCampo("Campo destino")) Then
                    sSQL = "ALTER TABLE " & Llave(cboTabla1) & "_" & Llave(cboPeriodo1) & " " &
                      "ALTER COLUMN " & oCampo("Campo destino") & " " & TipoDatosSQL(sTipo, nLong) & " "
                Else
                    sSQL = "ALTER TABLE " & Llave(cboTabla1) & "_" & Llave(cboPeriodo1) & " " &
                      "ADD " & oCampo("Campo destino") & " " & TipoDatosSQL(sTipo, nLong) & " "
                End If

            oAdmlocal.EjecutarComandoAsincrono(sSQL)

            If oCampo("Clave") > 0 Then
               bClave = True
            End If

         Next

         If bClave Then
                sSQL = "SELECT TOP 1 * FROM " & Llave(cboTabla1) & "_" & Llave(cboPeriodo1)
                ds = oAdmlocal.AbrirDataset(sSQL)

            bClave = False

            For Each oField In ds.Tables(0).Columns
               If oField.ColumnName = "PrexClave" Then
                  bClave = True
                  Exit For
               End If
            Next

            ds = Nothing

            If Not bClave Then
                    sSQL = "ALTER TABLE " & Llave(cboTabla1) & "_" & Llave(cboPeriodo1) & " " &
                      "ADD PrexClave VARCHAR(255) NULL"
                    oAdmlocal.EjecutarComandoAsincrono(sSQL)
            End If
         End If

      Catch ex As Exception
         TratarError(ex, "ModificarTabla")
      End Try

   End Sub

   Private Sub cmdExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExaminar.Click

      Examinar()

   End Sub

   Private Sub Examinar()

      Dim sFile As String
      Dim sFiltro As String

      If optTexto.Checked Then
         sFiltro = "Documentos de texto|*.txt|Archivo CSV|*.csv"
      ElseIf optExcel.Checked Then
         sFiltro = "Documentos de Excel|*.xls"
      ElseIf optAccess.Checked Then
         sFiltro = "Bases de Datos Access(*.mdb)|*.mdb"
      ElseIf optDBase.Checked Then
         sFiltro = "Carpeta"
      ElseIf OptSQL.Checked Then
         sFiltro = "SQL"
      Else
         Exit Sub
      End If

      If sFiltro = "Carpeta" Then

         Dim oAbrir As New FolderBrowserDialog

         oAbrir.ShowNewFolderButton = False
         oAbrir.ShowDialog()

         sFile = oAbrir.SelectedPath

         If Directory.Exists(sFile) Then
            txtOrigen.Text = sFile
            frmOrigenDB.Modo(3, sFile)
            CargarTablasDB()
         End If

      ElseIf sFiltro = "SQL" Then
         frmOrigenDB.Modo(2)

         If frmOrigenDB.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtOrigen.Text = INPUT_GENERAL
            CargarTablasDB()
         End If

      Else
         Dim oAbrir As New OpenFileDialog

         oAbrir.Filter = sFiltro
         oAbrir.ShowDialog()
         sFile = oAbrir.FileName

         If File.Exists(sFile) Then
            txtOrigen.Text = sFile

            'PARA EXCEL
            If optExcel.Checked Then
               MostrarProceso("Leyendo hojas del cuaderno...")
               CargarHojas(sFile)
               OcultarProceso()
            End If

            'PARA ACCESS
            If optAccess.Checked Then
               frmOrigenDB.Modo(1, sFile)

               If frmOrigenDB.ShowDialog = Windows.Forms.DialogResult.OK Then
                  CargarTablasDB()
               End If

            End If

         End If

         End If

   End Sub

   Private Sub CargarTablasDB()

      Try

         Dim dt As DataTable
         Dim cnnTemp As Data.OleDb.OleDbConnection

         cnnTemp = New Data.OleDb.OleDbConnection

         cnnTemp.ConnectionString = ADOTEMP
         cnnTemp.Open()

         dt = cnnTemp.GetSchema(System.Data.OleDb.OleDbMetaDataCollectionNames.Tables)

         cboTipo.Items.Clear()

         For Each row As DataRow In dt.Rows

            If row("TABLE_TYPE") = "TABLE" Then
               cboTipo.Items.Add(New clsItem.Item(row("TABLE_NAME"), row("TABLE_NAME")))
            End If
         Next

         If cboTipo.Items.Count > 0 Then
            cboTipo.Enabled = True
            cboTipo.SelectedIndex = 0
         End If

         cnnTemp.Close()

      Catch ex As Exception
         TratarError(ex, "CargarTablasDB")
      End Try

   End Sub

   Private Sub CargarHojas(ByVal sRuta As String)

      Dim oApp As Object = Nothing 'Excel.Application
      Dim oBook As Object = Nothing ' Excel.Workbook
      Dim oSht As Object = Nothing 'Excel.Worksheet
      Dim bAbrio As Boolean = False

      Try

         oApp = CreateObject("Excel.Application")
         oBook = oApp.Workbooks.Open(Filename:="" & sRuta)
         oSht = oBook.Sheets(1)

         bAbrio = True

         cboTipo.Items.Clear()

         For Each oSht In oBook.Sheets
            cboTipo.Items.Add(New clsItem.Item("K" & oSht.Name, oSht.Name))
         Next

         If cboTipo.Items.Count > 0 Then
            cboTipo.SelectedIndex = 0
            cboTipo.Enabled = True
         Else
            cboTipo.Text = "<Libro sin hojas..>"
         End If

      Catch ex As Exception
         OcultarProceso()
         TratarError(ex, "CargarHojas")
      End Try

      If bAbrio Then
         oBook.Close(0)
         oApp.Quit()
      End If

      oApp = Nothing
      oBook = Nothing
      oSht = Nothing

   End Sub

   Private Sub optTexto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTexto.CheckedChanged

      EvaluarOptions()

      If optTexto.Checked Then
         Label3.Text = "Tipo de archivo:"
         cboTipo.Enabled = True
         cboTipo.Items.Add(New clsItem.Item("K1", "Ancho fijo"))
         cboTipo.Items.Add(New clsItem.Item("K2", "Delimitado por caracter"))
         cboTipo.SelectedIndex = 0
      End If

   End Sub

   Private Sub optExcel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optExcel.CheckedChanged

      EvaluarOptions()

      If optExcel.Checked Then
         Label3.Text = "Hoja de datos:"
         cboTipo.Enabled = True
         cboTipo.Text = "<Debe cargar la planilla...>"
         cboTipo.Enabled = False
      End If

   End Sub

   Private Sub optAccess_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAccess.CheckedChanged

      EvaluarOptions()

      If optAccess.Checked Then
         Label3.Text = "Tabla orígen:"
         cboTipo.Enabled = True
         cboTipo.Text = "<Debe cargar la base...>"
         cboTipo.Enabled = False
         chkEncabezado.Enabled = False
      End If

   End Sub

   Private Sub OptSQL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptSQL.CheckedChanged

      EvaluarOptions()

      If OptSQL.Checked Then
         Label3.Text = "Tabla orígen:"
         cboTipo.Enabled = True
         cboTipo.Text = "<Debe cargar la base...>"
         cboTipo.Enabled = False
         chkEncabezado.Enabled = False
      End If

   End Sub

   Private Sub optDBase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDBase.CheckedChanged

      EvaluarOptions()

      If optDBase.Checked Then
         Label3.Text = "Tabla orígen:"
         cboTipo.Enabled = True
         cboTipo.Text = "<Debe cargar la base...>"
         cboTipo.Enabled = False
         chkEncabezado.Enabled = False
      End If

   End Sub

   Private Sub EvaluarOptions()

      cboTipo.Items.Clear()

      Label4.Visible = optTexto.Checked
      txtSymbol.Visible = optTexto.Checked

      lblSep.Visible = False
      txtSep.Visible = False
      txtCualif.Visible = False

   End Sub

   Private Sub cboTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedIndexChanged
      FiltrarTipo()
   End Sub

   Private Sub cmdIncorporar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIncorporar.Click

      If cmdIncorporar.Text = "&Vista previa" Then
         If TempOrig() <> "" Then
            CargarOrigenDatos()
         End If
      Else
         Incorporar()
      End If

   End Sub

   Private Sub CargarOrigenDatos()

      Dim ds As DataSet
      Dim sSQL As String = ""
      Dim nCont As Integer = 0
      Dim bResult As Boolean
      Dim sError As String = ""

      Try

         If optTexto.Checked Then
            sSQL = ProcesarArchivoTexto()
         ElseIf optExcel.Checked Then
            sSQL = ProcesarArchivoExcel()
         Else
            sSQL = ProcesarBaseDatos()
         End If

         MostrarProceso("Capturando datos...")

         If sSQL = "" Then
            MensajeError("Se produjo un error en los procesos previos a la incorporación.")
            Exit Try
         End If

         CrearTablaTemp()
            bResult = IncorporarArchivos(txtOrigen.Text, Llave(cboTabla1))
            'Solo se usa importacion de archivos
            'If rbArchivo.Checked Then
            '    bResult = IncorporarArchivos(txtOrigen.Text, Llave(cboTabla1))
            'Else

            '    If optAccess.Checked Then
            '        sSQL = "INSERT " &
            '               "INTO " & TABLA_TEMPORAL & " " & vbCrLf &
            '               sSQL & vbCrLf & " " &
            '               "FROM OPENROWSET('Microsoft.Jet.OLEDB.4.0','Text;Database=" & TempOrig() & ";HDR=" & IIf(chkEncabezado.Checked, "YES", "NO") & "', " &
            '               "'SELECT * FROM " & System.IO.Path.GetFileName(txtOrigen.Text) & "')"
            '    Else
            '        sSQL = Trim(sSQL)
            '        If Len(sSQL) <= 4000 Then
            '            sSQL = Replace(sSQL, "'", Chr(27))
            '            sSQL = "P_IncorporarInterfase '" & sSQL & "'"
            '        End If
            '    End If

            '    'tmrProcesando.Enabled = True
            '    bResult = oAdmlocal.EjecutarComandoAsincrono(sSQL, sError)
            '    'tmrProcesando.Enabled = False

            'End If

            OcultarProceso()

         If Not bResult Then
            If sError <> "" Then
               Dim oErrores As New frmErrores
               oErrores.Owner = Me
               oErrores.PasarDatos(sError & vbCrLf & "------------------------------" & vbCrLf & sSQL)
               oErrores.ShowDialog()
               oErrores = Nothing
            End If
            Exit Try
         End If

         'VERIFICO LA FECHA Y ENTIDAD
         MostrarProceso("Validando datos...")

         If Not VerificarOrigen(sError) Then
            OcultarProceso()
            MensajeError("Error de validación en " & sError)
            Exit Try
         End If

         OcultarProceso()

         'REEMPLAZO EQUIVALENCIAS
         If chkEqui.Checked Then
            MostrarProceso("Reemplazando equivalencias...")

            If Not ReemplazarEquivalencias Then
               OcultarProceso()
               MensajeError("Se produjo un error y no se pudieron procesar equivalencias.")
               Exit Try
            End If

            OcultarProceso()
         End If

         'GENERO LA CLAVE DE TABLA
         MostrarProceso("Verificando claves...")

         If Not GenerarClaveTabla Then
            OcultarProceso()
            MensajeError("Se produjo un error y no se pudo procesar la clave.")
            Exit Try
         End If

         OcultarProceso()

         'PRESENTO LOS DATOS
         sSQL = "SELECT " & IIf(Val(txtCantidad.Text) <> 0, " TOP " & txtCantidad.Text, "") & " * " & _
                "FROM   " & TABLA_TEMPORAL

         ds = New DataSet
         oAdmlocal.EjecutarComandoAsincrono(sSQL, , , ds)

         Grid.DataSource = ds.Tables(0)
         Grid.RefreshDataSource()
         Grid.Refresh()

            'If rbLinked.Checked Or rbRowSet.Checked Then
            '    If optDBase.Checked Then
            '        File.Delete(TempOrig() & cboTipo.Text & ".DBF")
            '    ElseIf optExcel.Checked Then
            '        File.Delete(TempOrig() & "Origen.xls")
            '    ElseIf Not OptSQL.Checked Then
            '        File.Delete(TempOrig() & NombreArchivo(txtOrigen.Text))
            '        If File.Exists(TempOrig() & "schema.ini") Then
            '            File.Delete(TempOrig() & "schema.ini")
            '        End If
            '    End If
            'End If

            cmdIncorporar.Text = "&Incorporar"

      Catch ex As Exception
         OcultarProceso()
         TratarError(ex, "CargarOrigenDatos", ex.Message & vbCrLf & sSQL)
      End Try

   End Sub

   Private Sub cmdCancelarVP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelarVP.Click

      ResetVistaPrevia()

   End Sub


   Private Function ProcesarArchivoTexto() As String

      Dim sSQL As String = ""

        'If rbLinked.Checked Or rbRowSet.Checked Then

        '    MostrarProceso("Generando esquema y copiando archivos...")

        '    GenerarEsquema()

        '    OcultarProceso()

        'End If

        sSQL = GenerarSQLOrigen()

        'If rbLinked.Checked Then
        '    sSQL = "INSERT " &
        '        "INTO " & TABLA_TEMPORAL &
        '        sSQL & " FROM " &
        '        "TXTSVR...[" & Replace(NombreArchivo(txtOrigen.Text), ".", "#") & "]"
        'End If

        Return sSQL

   End Function

   Private Function ProcesarArchivoExcel() As String

      Dim sSQL As String = ""
      Dim sArchivo As String = ""

      MostrarProceso("Copiando archivo origen...")

      Try

         sArchivo = TempOrig() & "Origen.xls"

         If File.Exists(sArchivo) Then
            If Not (File.GetCreationTime(txtOrigen.Text) = File.GetCreationTime(sArchivo) And FileLen(txtOrigen.Text) = FileLen(sArchivo)) Then
               CopiarArchivo(txtOrigen.Text, sArchivo, True)
            End If
         Else
            CopiarArchivo(txtOrigen.Text, sArchivo, True)
         End If

         If Not EncabezadoExcel(sArchivo) Then
            MensajeError("No se puede escribir en el archivo excel. Se cancela proceso.")
            Exit Try
         End If

         sSQL = "INSERT " & _
                "INTO " & TABLA_TEMPORAL & _
                GenerarSQLOrigen() & " " & _
                "FROM EXCELSVR...[" & cboTipo.Text & "$]"

      Catch ex As Exception
         OcultarProceso()
         TratarError(ex, "ProcesarArchivoExcel")
      End Try

      OcultarProceso()

      Return sSQL

   End Function

   Private Function GenerarEsquema() As Boolean


      Dim sArchivo As String = ""
      Dim sResp As String = ""
      Dim sDelimitado As String = ""
      Dim sNombreOrigen As String = ""
      Dim sEsquema As String = ""
      Dim nCont As Integer = 0
      Dim sDatoCol As String = ""

      Try

         sArchivo = TempOrig() & System.IO.Path.GetFileName(txtOrigen.Text)
         sEsquema = TempOrig() & "Schema.ini"

         sNombreOrigen = NombreArchivo(txtOrigen.Text)

         If File.Exists(sArchivo) Then

            If Not (File.GetCreationTime(txtOrigen.Text) = File.GetCreationTime(sArchivo) And FileLen(txtOrigen.Text) = FileLen(sArchivo)) Then
               CopiarArchivo(txtOrigen.Text, sArchivo, True)
            End If

         Else

            CopiarArchivo(txtOrigen.Text, sArchivo, True)

         End If

         If chkEncabezado.Checked Then
            sResp = "True"
         Else
            sResp = "False"
         End If

         If Not File.Exists(sArchivo) Then
            MensajeError("Se produjo un error al intentar copiar el archivo a la carpeta temporal el proceso fue anulado.")
            Return False
            Exit Function
         End If

         If Val(Llave(cboTipo)) = 1 Then
            sDelimitado = "FixedLength"
         Else
            sDelimitado = "Delimited(" & txtSep.Text & ")"
         End If

         If File.Exists(sEsquema) Then
            File.Delete(sEsquema)
         End If

         EscribirINI(sNombreOrigen, "ColNameHeader", sResp, sEsquema)
         EscribirINI(sNombreOrigen, "CharacterSet", "ANSI", sEsquema)
         EscribirINI(sNombreOrigen, "Format", sDelimitado, sEsquema)
         EscribirINI(sNombreOrigen, "DecimalSymbol", Trim(txtSymbol.Text), sEsquema)

         nCont = 0

         For Each oCampo As DataRow In oTabla.Diseno.Rows

            If oCampo("Longitud") > 0 Then

               nCont = nCont + 1
               sDatoCol = oCampo("Campo destino") & " "

               If oCampo("Tipo").ToString.Substring(0, 1) = "N" Then
                  sDatoCol = sDatoCol & IIf(oCampo("Tipo") = "N0", "Decimal ", "Float ") & IIf(oCampo("Longitud"), "Width " & oCampo("Longitud"), "")
               ElseIf oCampo("Tipo").ToString.Substring(0, 1) = "F" Then
                  sDatoCol = sDatoCol & "Text " & IIf(oCampo("Longitud"), "Width " & oCampo("Longitud"), "")
               Else
                  sDatoCol = sDatoCol & "Text " & IIf(oCampo("Longitud"), "Width " & oCampo("Longitud"), "")
               End If

               EscribirINI(sNombreOrigen, "COL" & nCont, sDatoCol, sEsquema)

            End If

         Next

      Catch ex As Exception
         OcultarProceso()
         TratarError(ex, "GenerarEsquema")
      End Try

   End Function

   Private Function GenerarSQLOrigen() As String


      Dim sSQL As String = ""
      Dim sTipo As String
      Dim sFldOrigen As String
      Dim bClave As Boolean
      Dim sCampoClave() As String '2009-09-30 Va armando el campo Clave
      Dim nCont As Integer
      Dim View As ColumnView = Grid.MainView
      Dim Column As DevExpress.XtraGrid.Columns.GridColumn

      Try

         View.Columns.Clear()

         ReDim sCampoClave(0)

         sSQL = " SELECT "

         For Each oCampo As DataRow In oTabla.Diseno.Rows

            If optAccess.Checked Or optDBase.Checked Or OptSQL.Checked Then
               sFldOrigen = "" & oCampo("Relacion")
            Else
               sFldOrigen = oCampo("Campo destino")
            End If

            sTipo = oCampo("Tipo")

            If sTipo.Substring(0, 1) = "N" Then

               '''''''''''NUMERO'''''''''''''
               If oCampo("Valida") = 98 Then
                  sSQL = sSQL & FormatearNumeroSQL(CODIGO_ENTIDAD.ToString, oCampo("Valida"), Val(Mid(sTipo, 2))) & ", " & vbCrLf '& " AS " & .CampoDestino & ", " & vbCrLf
               Else
                  sSQL = sSQL & FormatearNumeroSQL(sFldOrigen, oCampo("Valida"), Val(Mid(sTipo, 2))) & ", " & vbCrLf '& " AS " & .CampoDestino & ", " & vbCrLf
               End If

            ElseIf sTipo.Substring(0, 1) = "F" Then

               '''''''''''FECHA''''''''''''''
               If oCampo("Valida") = 99 Then
                  sSQL = sSQL & "CAST(" & FechaSQL(txtFecha.Value) & " AS DATETIME) " & ", " & vbCrLf ' AS " & .CampoDestino & ", " & vbCrLf
               Else
                  sSQL = sSQL & FormatearFechaSQL(sFldOrigen, oCampo("Formato")) & ", " & vbCrLf '& " AS " & .CampoDestino & ", " & vbCrLf
               End If

            Else
               ''''''''''TEXTO'''''''''''''''
               sSQL = sSQL & FormatearTextoSQL(sFldOrigen, oCampo("Longitud")) & ", " & vbCrLf '& " AS " & .CampoDestino & ", " & vbCrLf

            End If

            Column = View.Columns.AddField(sFldOrigen)
            Column.Width = 100
            Column.Visible = True
            Column.Caption = oCampo("Campo")

            Select Case Trim(sTipo)

               Case "F"
                  Column.DisplayFormat.FormatType = FormatType.Custom
                  Column.DisplayFormat.FormatString = "dd/MM/yyyy"

               Case "N0"
                  Column.DisplayFormat.FormatType = FormatType.Custom
                  Column.DisplayFormat.FormatString = "#,##0"

               Case "N2"
                  Column.DisplayFormat.FormatType = FormatType.Custom
                  Column.DisplayFormat.FormatString = "#,##0.00"

               Case "N4"
                  Column.DisplayFormat.FormatType = FormatType.Custom
                  Column.DisplayFormat.FormatString = "#,##0.0000"

               Case "N6"
                  Column.DisplayFormat.FormatType = FormatType.Custom
                  Column.DisplayFormat.FormatString = "#,##0.000000"

            End Select

            If oCampo("Clave") > 0 Then
               bClave = True
               If oCampo("Clave") > UBound(sCampoClave) Then
                  ReDim Preserve sCampoClave(oCampo("Clave"))
               End If
               sCampoClave(oCampo("Clave")) = sFldOrigen
            End If

         Next

         If bClave Then
            Column = View.Columns.AddField("PrexClave")
            Column.Width = 100
            Column.Visible = True
            Column.Caption = "Clave"

            For nCont = 1 To UBound(sCampoClave)
               sSQL = sSQL & "CAST(" & sCampoClave(nCont) & " AS VARCHAR) + "
            Next nCont

            sSQL = Mid(sSQL, 1, Len(sSQL) - 2) & ", " & vbCrLf
         End If

         sSQL = Mid(sSQL, 1, Len(sSQL) - 4)

      Catch ex As Exception
         TratarError(ex, "GenerarSQLOrigen")
      End Try

      Return sSQL

   End Function

   Private Function FormatearFechaSQL(ByVal sCampo As String, ByVal sFormato As String) As String

      Dim sComando As String = ""
      Dim bPeriodo As Boolean

      If Not optTexto.Checked Then
         Return sCampo
         Exit Function
      End If

      Select Case LCase(Replace(sFormato, "/", "-"))
         '''''''''''''''''''''
         'SIN SEPARADOR
         '''''''''''''''''''''
         Case "aaaammdd"
            sComando = "SUBSTRING(@CAMPO, 1, 4) + '/' + SUBSTRING(@CAMPO, 5, 2) + '/' + SUBSTRING(@CAMPO, 7, 2) "
         Case "ddmmaaaa"
            sComando = "SUBSTRING(@CAMPO, 5, 4) + '/' + SUBSTRING(@CAMPO, 3, 2) + '/' + SUBSTRING(@CAMPO, 1, 2) "
         Case "mmddaaaa"
            sComando = "SUBSTRING(@CAMPO, 5, 4) + '/' + SUBSTRING(@CAMPO, 1, 2) + '/' + SUBSTRING(@CAMPO, 3, 2) "
         Case "aaaaddmm"
            sComando = "SUBSTRING(@CAMPO, 1, 4) + '/' + SUBSTRING(@CAMPO, 7, 2) + '/' + SUBSTRING(@CAMPO, 5, 2) "
         Case "aammdd"
            sComando = "SUBSTRING(@CAMPO, 1, 2) + '/' + SUBSTRING(@CAMPO, 3, 2) + '/' + SUBSTRING(@CAMPO, 5, 2) "
         Case "ddmmaa"
            sComando = "SUBSTRING(@CAMPO, 5, 2) + '/' + SUBSTRING(@CAMPO, 3, 2) + '/' + SUBSTRING(@CAMPO, 1, 2) "
         Case "mmddaa"
            sComando = "SUBSTRING(@CAMPO, 5, 2) + '/' + SUBSTRING(@CAMPO, 1, 2) + '/' + SUBSTRING(@CAMPO, 3, 2) "
         Case "aaddmm"
            sComando = "SUBSTRING(@CAMPO, 1, 2) + '/' + SUBSTRING(@CAMPO, 5, 2) + '/' + SUBSTRING(@CAMPO, 3, 2) "

            '''''''''''''''''''''
            'CON SEPARADOR
            '''''''''''''''''''''
         Case "aaaa-mm-dd"
            sComando = "SUBSTRING(@CAMPO, 1, 4) + '/' + SUBSTRING(@CAMPO, 6, 2) + '/' + SUBSTRING(@CAMPO, 9, 2) "
         Case "dd-mm-aaaa"
            sComando = "SUBSTRING(@CAMPO, 7, 4) + '/' + SUBSTRING(@CAMPO, 4, 2) + '/' + SUBSTRING(@CAMPO, 1, 2) "
         Case "mm-dd-aaaa"
            sComando = "SUBSTRING(@CAMPO, 7, 4) + '/' + SUBSTRING(@CAMPO, 1, 2) + '/' + SUBSTRING(@CAMPO, 4, 2) "
         Case "aaaa-dd-mm"
            sComando = "SUBSTRING(@CAMPO, 1, 4) + '/' + SUBSTRING(@CAMPO, 9, 2) + '/' + SUBSTRING(@CAMPO, 6, 2) "
         Case "aa-mm-dd"
            sComando = "SUBSTRING(@CAMPO, 1, 2) + '/' + SUBSTRING(@CAMPO, 4, 2) + '/' + SUBSTRING(@CAMPO, 7, 2) "
         Case "dd-mm-aa"
            sComando = "SUBSTRING(@CAMPO, 7, 2) + '/' + SUBSTRING(@CAMPO, 4, 2) + '/' + SUBSTRING(@CAMPO, 1, 2) "
         Case "mm-dd-aa"
            sComando = "SUBSTRING(@CAMPO, 7, 2) + '/' + SUBSTRING(@CAMPO, 1, 2) + '/' + SUBSTRING(@CAMPO, 4, 2) "
         Case "aa-dd-mm"
            sComando = "SUBSTRING(@CAMPO, 1, 2) + '/' + SUBSTRING(@CAMPO, 7, 2) + '/' + SUBSTRING(@CAMPO, 4, 2) "

            '''''''''''''''''''''''
            ' SIN DIA
            '''''''''''''''''''''''
         Case "aaaa-mm"
            sComando = "SUBSTRING(@CAMPO, 1, 4) + '/' + SUBSTRING(@CAMPO, 6, 2) + '/01'"
            bPeriodo = True
         Case "mm-aaaa"
            sComando = "SUBSTRING(@CAMPO, 4, 4) + '/' + SUBSTRING(@CAMPO, 1, 2) + '/01'"
            bPeriodo = True
         Case "aaaamm"
            sComando = "SUBSTRING(@CAMPO, 1, 4) + '/' + SUBSTRING(@CAMPO, 5, 2) + '/01'"
            bPeriodo = True
         Case "mmaaaa"
            sComando = "SUBSTRING(@CAMPO, 3, 4) + '/' + SUBSTRING(@CAMPO, 1, 2) + '/01'"
            bPeriodo = True
         Case "aa-mm"
            sComando = "SUBSTRING(@CAMPO, 1, 2) + '/' + SUBSTRING(@CAMPO, 4, 2) + '/01'"
            bPeriodo = True
         Case "mm-aa"
            sComando = "SUBSTRING(@CAMPO, 4, 2) + '/' + SUBSTRING(@CAMPO, 1, 2) + '/01'"
            bPeriodo = True
         Case "aamm"
            sComando = "SUBSTRING(@CAMPO, 1, 2) + '/' + SUBSTRING(@CAMPO, 3, 2) + '/01'"
            bPeriodo = True
         Case "mmaa"
            sComando = "SUBSTRING(@CAMPO, 3, 2) + '/' + SUBSTRING(@CAMPO, 1, 2) + '/01'"
            bPeriodo = True

      End Select


      FormatearFechaSQL = "CONVERT(DATETIME, CASE WHEN ISDATE(" & Replace(sComando, "@CAMPO", sCampo) & ") <> 0 THEN " & Replace(sComando, "@CAMPO", sCampo) & " ELSE '1900-01-01' END, 111)"

      If bPeriodo Then
         Return "dbo.F_FechaCorrecta(" & FormatearFechaSQL & ")  "
         'Return FormatearFechaSQL & " + 31 - DAY(" & FormatearFechaSQL & " + 31)   "
      End If

   End Function

   Private Function FormatearNumeroSQL(ByVal sCampo As String, ByVal nValida As Integer, ByVal nDecimales As Integer) As String

      Dim sCeros As String = ""
      Dim nC As Integer

      sCampo = "CASE WHEN IsNumeric(" & sCampo & ") <> 0 THEN " & sCampo & " ELSE 0 END"

      If nDecimales > 0 Then
         If nValida = 50 Then
            For nC = 1 To nDecimales
               sCeros = sCeros & "0"
            Next nC
            sCampo = sCampo & " / 1" & sCeros
         End If
      End If

      Return sCampo

   End Function

   Private Function FormatearTextoSQL(ByVal sCampo As String, ByVal nLargo As Integer) As String

      If nLargo = 0 Then
         nLargo = 50
      End If

      If nLargo > 255 Then
         Return "SUBSTRING(" & sCampo & ", 0, " & nLargo.ToString & ") "
      Else
         Return "LEFT(" & sCampo & ", " & nLargo.ToString & ") "
      End If

   End Function

   Private Function EncabezadoExcel(ByVal sArchivo As String) As Boolean

      Dim oApp As Object
      Dim oBook As Object
      Dim oSheet As Object

      Try

         Dim nCont As Integer

         If cboTipo.SelectedItem Is Nothing Then
            MensajeError("Debe especificar una hoja del excel")
            Exit Function
         End If

         oApp = CreateObject("Excel.Application")
         oBook = oApp.Workbooks.Open(Filename:="" & sArchivo)
         oSheet = oBook.Sheets(cboTipo.SelectedIndex + 1)

         If Not chkEncabezado.Checked Then
            oSheet.Range("1:1").EntireRow.Insert()
         End If

         For Each oCampo As DataRow In oTabla.Diseno.Rows

            nCont = nCont + 1
            oSheet.Cells(1, nCont) = oCampo("Campo destino")

         Next

         oBook.Close(1)
         oApp.Quit()

         Return True

      Catch ex As Exception
         TratarError(ex, "EncabezadoExcel")
      End Try

      oSheet = Nothing
      oBook = Nothing
      oApp = Nothing

   End Function

   Public Function IncorporarArchivos(ByVal sArchivo As String, ByVal sTabla As String) As Boolean

      Dim oArchivo As System.IO.StreamReader
      Dim ds As DataSet
      Dim sSQL As String
      Dim vTemp As Object
      Dim sFormat As String
      Dim sLinea As String
      Dim sFecha(2) As String
      Dim nLinea As Long = 0
      Dim nLineaActual As Long = 0
      Dim sDato() As String
      Dim nC As Long
      Dim nIndex As Long
      Dim nSep As Integer
      Dim nTex As Integer
      Dim sTemp As String
      Dim sCampo As String = ""
      Dim nLineaAct As Long
      Dim bProcesando As Boolean
      Dim bEncabezado As Boolean
      Dim row As DataRow
      Dim da As OleDb.OleDbDataAdapter
      Dim cb As OleDb.OleDbCommandBuilder

      Try

            sTabla = sTabla & "_" & Llave(cboPeriodo1)

            If Not oAdmlocal.ExisteTabla(sTabla) Then
            CrearTabla()
         End If

         oAdmlocal.EjecutarComandoAsincrono("SELECT TOP 1 * INTO " & TABLA_TEMPORAL & " FROM " & sTabla)
         oAdmlocal.EjecutarComandoAsincrono("DELETE FROM " & TABLA_TEMPORAL)

         'Abro un recordset en modo escritura y agrego los registros.
         sSQL = "SELECT * FROM " & TABLA_TEMPORAL
         ds = oAdmlocal.AbrirDataset(sSQL, da)
         cb = New OleDb.OleDbCommandBuilder(da)

         'Cuento las líneas
         oArchivo = File.OpenText(sArchivo)

         Do Until oArchivo.EndOfStream
            nLinea = nLinea + 1
            oArchivo.ReadLine()
         Loop

         oArchivo.Close()

         'Proceso y meto en la base
         oArchivo = File.OpenText(sArchivo)

         ReDim sDato(oTabla.Diseno.Rows.Count)

         bProcesando = True

         bEncabezado = chkEncabezado.Checked

         Do Until oArchivo.EndOfStream

            nLineaActual = nLineaActual + 1

            If bEncabezado Then
               oArchivo.ReadLine()
               bEncabezado = False
            End If

            sLinea = oArchivo.ReadLine

            oProcesando.MensajeProceso("Procesando línea " & nLineaActual.ToString & " de " & nLinea.ToString & "(" & Int(nLineaActual * 100 / nLinea).ToString & "%)")
            Application.DoEvents()

            row = ds.Tables(0).NewRow()

            If Val(Llave(cboTipo)) = 2 Then
               sTemp = sLinea
               nIndex = 0

               For Each oCampo As DataRow In oTabla.Diseno.Rows

                  If (oCampo("Valida") <> 98 And _
                      oCampo("Valida") <> 99) Or _
                      oCampo("Longitud") > 0 Then

                     nSep = InStr(1, sTemp, txtSep.Text)
                     nTex = InStr(1, sTemp, txtCualif.Text)

                     If nTex < nSep Then
                        nSep = InStr(InStr(nTex + 1, sTemp, txtCualif.Text) + 1, sTemp, txtSep.Text)
                     End If

                     If nSep = 0 Then
                        sDato(nIndex) = Replace(sTemp, txtCualif.Text, "")
                     Else
                        sDato(nIndex) = Replace(Mid(sTemp, 1, nSep - 1), txtCualif.Text, "")
                        sTemp = Mid(sTemp, nSep + 1)
                     End If

                  End If

                  nIndex = nIndex + 1
               Next
            End If

            nC = 0

            For Each oCampo As DataRow In oTabla.Diseno.Rows

               sCampo = oCampo("Campo destino")

               nLineaAct = nLineaActual

               If oCampo("Valida") = 98 Then
                  vTemp = CODIGO_ENTIDAD
                  GoTo GrabarCampo
               End If

               If oCampo("Valida") = 99 Then
                  vTemp = txtFecha.Value
                  GoTo GrabarCampo
               End If

               'Obtengo el dato de acuerdo a si es delimitado o ancho fijo
               If Val(Llave(cboTipo)) = 1 Then
                  vTemp = Mid(sLinea, Int(oCampo("Inicio")), Int(oCampo("Longitud"))).Trim
               Else
                  vTemp = sDato(nC)
               End If

               sFormat = oCampo("Formato")

               Select Case Mid(oCampo("Tipo"), 1, 1)
                  'TEXTO
                  Case "T"
                     vTemp = Mid(CStr(vTemp), 1, oCampo("Longitud"))

                     'FECHA
                  Case "F"
                     If sFormat = "" Then
                        vTemp = Format(vTemp, "dd/MM/yyyy")
                     Else

                        If InStr(1, LCase(sFormat), "dd") Then
                           sFecha(0) = Mid(vTemp, InStr(1, LCase(sFormat), "dd"), 2)
                        Else
                           sFecha(0) = "01"
                        End If

                        If InStr(1, LCase(sFormat), "mm") Then
                           sFecha(1) = Mid(vTemp, InStr(1, LCase(sFormat), "mm"), 2)
                        End If

                        If InStr(1, LCase(sFormat), "aaaa") Then
                           sFecha(2) = Mid(vTemp, InStr(1, LCase(sFormat), "aaaa"), 4)
                        Else
                           sFecha(2) = Mid(vTemp, InStr(1, LCase(sFormat), "aa"), 2)
                        End If

                        'vTemp = sFecha(0) & "/" & sFecha(1) & "/" & sFecha(2)
                        vTemp = FechaCorrecta(sFecha(1), sFecha(2))

                     End If

                     If vTemp.ToString = "00/00/0000" Or _
                        Len(vTemp.ToString) = 0 Then
                        vTemp = "01/01/1900"
                     End If

                     If IsDate(vTemp) Then
                        vTemp = CDate(vTemp)
                     Else
                        MensajeError("Fecha inválida para campo " & oCampo("Campo destino") & " leyendo línea " & nLineaActual.ToString)
                        Exit Try
                     End If

                     'NUMERO
                  Case "N"

                     nIndex = Val(Mid(oCampo("Tipo"), 2))

                     vTemp = Val(Replace(vTemp, ",", "."))
                     vTemp = Format(vTemp, "#0." & Mid("000000", 1, nIndex))

                     If IsNumeric(vTemp) Then
                        vTemp = CDbl(vTemp)
                     Else
                        MensajeError("Número inválido para campo " & oCampo("Campo destino") & " leyendo línea " & nLineaActual.ToString)
                        Exit Try
                     End If

               End Select

GrabarCampo:
               row(oCampo("Campo destino")) = vTemp
               nC = nC + 1
            Next

            ds.Tables(0).Rows.Add(row)
            da.Update(ds)
            ds.AcceptChanges()
         Loop

         oArchivo.Close()

         Return True

      Catch ex As Exception

         If bProcesando Then
            MensajeError("Se produjo un error en la línea " & nLineaActual.ToString & ", campo " & sCampo & ": " & vbCrLf & ex.Message)
         Else
            TratarError(ex, "IncorporarArchivos")
         End If

      End Try

      ds = Nothing
      oArchivo = Nothing

   End Function

   Private Function VerificarOrigen(Optional ByRef sError As String = "") As Boolean

      Dim sSQL As String
      Dim ds As DataSet

      Try

         For Each oCampo As DataRow In oTabla.Diseno.Rows

            If oCampo("Valida") = 1 Then

               ds = New DataSet

               sSQL = "SELECT    DISTINCT " & oCampo("Campo destino") & " " & _
                      "FROM      " & TABLA_TEMPORAL
               oAdmlocal.EjecutarComandoAsincrono(sSQL, , , ds)

               For Each row As DataRow In ds.Tables(0).Rows
                  If row(oCampo("Campo destino")) <> txtFecha.Value Then
                     sError = oCampo("Campo") & " " & row(oCampo("Campo destino"))
                     Exit Try
                  End If

               Next

               ds = Nothing

            End If

            If oCampo("Valida") = 2 Then

               ds = New DataSet

               sSQL = "SELECT    DISTINCT " & oCampo("Campo destino") & " " & _
                      "FROM      " & TABLA_TEMPORAL
               oAdmlocal.EjecutarComandoAsincrono(sSQL, , , ds)

               For Each row As DataRow In ds.Tables(0).Rows

                  If Val(row(oCampo("Campo destino"))) <> CODIGO_ENTIDAD Then
                     sError = oCampo("Campo") & " " & row(oCampo("Campo destino"))
                     Exit Try
                  End If

               Next

               ds = Nothing

            End If

         Next

         Return True

      Catch ex As Exception
         TratarError(ex, "VerificarOrigen")
      End Try

      ds = Nothing

   End Function

   Private Function ReemplazarEquivalencias() As Boolean

      Dim sSQL As String
      Dim sCampo1 As String = ""
      Dim sCampo2 As String = ""
      Dim sTipo As String

      Try

         For Each oCampo As DataRow In oTabla.Diseno.Rows

            sTipo = oCampo("Tipo")

            If Mid(sTipo, 1, 1) = "N" Then
               sCampo1 = "CAST(ED_CODIGO AS Numeric(18," & Val(Mid(sTipo, 2)) & "0))"
               sCampo2 = "CAST(ED_RELEQU AS Numeric(18," & Val(Mid(sTipo, 2)) & "0))"
            ElseIf Mid(sTipo, 1, 1) = "F" Then
               sCampo1 = "CAST(ED_CODIGO AS DATETIME)"
               sCampo1 = "CAST(ED_RELEQU AS DATETIME)"
            Else
               sCampo1 = "ED_CODIGO"
               sCampo2 = "ED_RELEQU"
            End If

                sSQL = "UPDATE     " & TABLA_TEMPORAL & " " &
                   "SET        " & oCampo("Campo destino") & " = " & sCampo1 & " " &
                   "FROM       " & TABLA_TEMPORAL & " " &
                   "INNER JOIN EQUDET " &
                   "ON         " & oCampo("Campo destino") & " = " & sCampo2 & " " &
                   "AND        ED_TABLA = '" & Llave(cboTabla1) & "_" & Llave(cboPeriodo1) & "'"

                oAdmlocal.EjecutarComandoAsincrono(sSQL)

         Next

         Return True

      Catch ex As Exception
         TratarError(ex, "ReemplazarEquivalencias")
      End Try

   End Function

   Private Function GenerarClaveTabla() As Boolean

      Dim sClave As String = ""
      Dim sSQL As String

      Try

         sClave = ClaveTabla()

         'SI HAY CLAVE PROCESO
         If sClave <> "" Then

            sClave = Mid(sClave, 1, Len(sClave) - 2)

            'ACTUALIZO CON LA CLAVE LA TABLA TEMPORAL
            sSQL = "UPDATE     " & TABLA_TEMPORAL & " " & _
                   "SET        PrexClave = " & sClave & " "
            oAdmlocal.EjecutarComandoAsincrono(sSQL)

            If chkEqui.Checked Then

                    'REEMPLAZA EQUIVALENCIAS DE CLAVE
                    sSQL = "UPDATE     " & TABLA_TEMPORAL & " " &
                      "SET        PrexClave = ED_CODIGO " &
                      "FROM       " & TABLA_TEMPORAL & " " &
                      "INNER JOIN EQUDET " &
                      "ON         PrexClave = ED_RELEQU " &
                      "AND        ED_TABLA = '" & Llave(cboTabla1) & "_" & Llave(cboPeriodo1) & "'"
                    oAdmlocal.EjecutarComandoAsincrono(sSQL)

            End If

         End If

         Return True

      Catch ex As Exception
         TratarError(ex, "GenerarClaveTabla")
      End Try

   End Function

   Private Function ClaveTabla() As String

      Dim sSQL As String
      Dim ds As DataSet
      Dim sClave As String = ""

      Try

            'CARGO LOS CAMPOS CLAVE EN EL ORDEN ESTABLECIDO
            sSQL = "SELECT    * " &
                "FROM      DISPOS " &
                "WHERE     DP_NOMBRE = '" & Llave(cboTabla1) & "' " &
                "AND       DP_FECVIG = " & FechaSQL(cboPeriodo1.Text) & " " &
                "AND       DP_CODENT IN (0, " & CODIGO_ENTIDAD.ToString & ") " &
                "AND       DP_CLAVE > 0 " &
                "ORDER BY  DP_CLAVE "
            ds = oAdmlocal.AbrirDataset(sSQL)

         With ds.Tables(0)
            For Each row As DataRow In .Rows
               sClave = sClave & "CAST(" & row("DP_CAMPO_DESTINO") & " AS VARCHAR(255)) + "
            Next
         End With

      Catch ex As Exception
         TratarError(ex, "ClaveTabla")
      End Try

      ds = Nothing

      Return sClave

   End Function

   Private Sub btnExportarResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarResult.Click

      frmExportar.PasarViewResultados(Me.Text, lblTransaccion.Text, gResult)
      frmExportar.ShowDialog()

   End Sub

   Private Sub btnImprimirResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirResult.Click
      Grid.ShowPrintPreview()
   End Sub

   Private Sub OcultarProceso()

      If Not (oProcesando Is Nothing) Then
         oProcesando.Close()
         oProcesando = Nothing
      End If

   End Sub

   Private Sub MostrarProceso(ByVal sMensaje As String)

      If oProcesando Is Nothing Then
         oProcesando = New frmProcesando
         oProcesando.MensajeProceso(sMensaje)
         oProcesando.Show(Me)
      Else
         oProcesando.MensajeProceso(sMensaje)
      End If

      Application.DoEvents()

   End Sub

   Private Function ProcesarBaseDatos() As String

      Dim sSQL As String = ""

      If optAccess.Checked Then
         CopiarArchivo(txtOrigen.Text, TempOrig() & NombreArchivo(txtOrigen.Text), True)
      ElseIf optDBase.Checked Then
         CopiarArchivo(NormalizarRuta(txtOrigen.Text) & cboTipo.Text & ".dbf", TempOrig() & cboTipo.Text & ".dbf", True)
      End If

      sSQL = "INSERT " & _
             "INTO " & TABLA_TEMPORAL & _
             GenerarSQLOrigen & " " & _
             "FROM " & OLEDBDin & "[" & cboTipo.Text & "]')"

      Return sSQL

   End Function

   Private Sub Incorporar()

      Dim sSQL As String = ""
      Dim sError As String = ""
      Dim ds As DataSet

      Try

            If Not oAdmlocal.ExisteTabla(Llave(cboTabla1) & "_" & Llave(cboPeriodo1)) Then
                CrearTabla()
            Else
                If Not ValidarIncorporacion(Llave(cboTabla1) & "_" & Llave(cboPeriodo1)) Then
                    Exit Sub
                End If
            End If

         For Each oCampo As DataRow In oTabla.Diseno.Rows

            If oCampo("Valida") = 3 Then

                    sSQL = "SELECT    TG_ALFA01 " &
                      "FROM      TABGEN " &
                      "WHERE     TG_CODTAB = 1500 " &
                      "AND       TG_DESCRI = '" & Llave(cboTabla1) & "' " &
                      "ORDER BY  TG_CODCON "
                    ds = oAdmlocal.AbrirDataset(sSQL)

               For Each row As DataRow In ds.Tables(0).Rows

                  If oAdmlocal.ExisteTabla("OrigenCuentasTemp") Then
                     oAdmlocal.EjecutarComandoAsincrono("DROP TABLE OrigenCuentasTemp")
                  End If

                  sSQL = "SELECT       A.{CUENTA} AS XX_CUENTA " & _
                         "INTO         OrigenCuentasTemp " & _
                         "FROM         OrigenDatosTemp A " & _
                         "LEFT JOIN    RELCUE B " & _
                         "ON           A.{CUENTA} = B.RU_CODCUE " & _
                         "AND          B.RU_TABLA = '{TABLA}' " & _
                         "AND          B.RU_CODENT = " & CODIGO_ENTIDAD.ToString & " " & _
                         "AND          B.RU_FECVIG IN (SELECT MAX(RU_FECVIG) FROM RELCUE WHERE RU_FECVIG <= " & FechaSQL(txtFecha.Value) & " AND RU_CODENT = " & CODIGO_ENTIDAD & " AND RU_TABLA = '{TABLA}' ) " & _
                         "WHERE        B.RU_CODCUE IS NULL "
                  sSQL = sSQL.Replace("{CUENTA}", oCampo("Campo destino"))
                  sSQL = sSQL.Replace("{TABLA}", "" & row("TG_ALFA01"))

                  oAdmlocal.EjecutarComandoAsincrono(sSQL)

                  If oAdmlocal.ExisteTabla("OrigenCuentasTemp") Then
                     Dim oCuentas As New frmGrilla
                     oCuentas.Owner = Me
                     oCuentas.PasarSQL("SELECT DISTINCT XX_CUENTA AS [Cuenta] FROM OrigenCuentasTemp ORDER BY XX_CUENTA ")
                     oCuentas.ShowDialog()
                     oCuentas = Nothing
                  End If

               Next

               ds = Nothing

            End If

         Next

         MostrarProceso("Incorporando datos...")

         If ClaveTabla() <> "" Then
                If Not oAdmlocal.ExisteCampo(Llave(cboTabla1) & "_" & Llave(cboPeriodo1), "PrexClave") Then
                    oAdmlocal.EjecutarComandoAsincrono("ALTER TABLE " & Llave(cboTabla1) & "_" & Llave(cboPeriodo1) & " ADD PrexClave VARCHAR(255) NULL ")
                End If
            End If

         sSQL = ""

         For Each oCampo As DataRow In oTabla.Diseno.Rows
            sSQL = sSQL & "[" & oCampo("Campo destino") & "], "
         Next

         sSQL = Mid(sSQL, 1, Len(sSQL) - 2)

            sSQL = "INSERT INTO [" & Llave(cboTabla1) & "_" & Llave(cboPeriodo1) & "] (" &
                sSQL & ") " &
                "SELECT " & sSQL & " FROM [" & TABLA_TEMPORAL & "]"
            oAdmlocal.EjecutarComandoAsincrono(sSQL, sError)

      Catch ex As Exception
         TratarError(ex, "Incorporar")
      End Try

      OcultarProceso()

      If Trim(sError) = "" Then
         MensajeInformacion("Captura de datos completada")
         cmdIncorporar.Text = "&Vista previa"
            TabDiseno.SelectedTab = tabTablas

            cmdCancelarVP_Click(Nothing, Nothing)
      Else
         MensajeError(sError)
      End If

   End Sub

   Private Function ValidarIncorporacion(ByVal sTabla As String) As Boolean

      Dim sFecha As String = ""
      Dim sEntidad As String = ""
      Dim ds As DataSet
      Dim sSQL As String = ""
      Dim sError As String = ""

      Try

         sSQL = "SELECT    COUNT(*) AS CANT " & _
                "FROM      " & sTabla & " " & _
                "WHERE     1 = 1 "

         For Each oCampo As DataRow In oTabla.Diseno.Rows

            If sFecha = "" Then
               If oCampo("Valida") = 1 Then
                  sFecha = "AND " & oCampo("Campo destino") & " = " & FechaSQL(txtFecha.Value) & " "
               End If
            End If

            If oCampo("Valida") = 99 Then
               sFecha = "AND " & oCampo("Campo destino") & " = " & FechaSQL(txtFecha.Value) & " "
            End If

            If sEntidad = "" Then
               If oCampo("Valida") = 2 Then
                  sEntidad = "AND " & oCampo("Campo destino") & " = " & CODIGO_ENTIDAD.ToString & " "
               End If
            End If

            If oCampo("Valida") = 98 Then
               sEntidad = "AND " & oCampo("Campo destino") & " = " & CODIGO_ENTIDAD.ToString & " "
            End If

         Next

         If sFecha <> "" Or sEntidad <> "" Then
            sSQL = sSQL & sFecha & sEntidad
            ds = oAdmlocal.AbrirDataset(sSQL)

            If ds.Tables(0).Rows.Count > 0 Then
               If ds.Tables(0).Rows(0).Item("CANT") > 0 Then
                  If Pregunta("¿Desea quitar la información correspondiente al " & Format(txtFecha.Value, "dd/MM/yyyy") & "?") = vbYes Then
                     sSQL = "DELETE FROM " & sTabla & " " & _
                            "WHERE  1 = 1 " & sFecha & sEntidad
                     oAdmlocal.EjecutarComandoAsincrono(sSQL, sError)

                     If sError <> "" Then
                        MensajeError(sError)
                        Exit Try
                     End If
                  End If
               End If
            End If

         End If

         Return True

      Catch ex As Exception
         TratarError(ex, "ValidarIncorporacion")
      End Try

      ds = Nothing

   End Function

   Private Sub ResetVistaPrevia()

      '      gResult.Columns.Clear()
      Grid.DataSource = Nothing
      Grid.RefreshDataSource()
      Grid.Refresh()

      cmdIncorporar.Text = "&Vista previa"

   End Sub

    Private Sub btnSolapaAnt_Click(sender As Object, e As EventArgs) Handles btnSolapaAnt.Click
        If TabDiseno.SelectedIndex <> tabTablas.TabIndex Then
            tabTablas.Select()
            TabDiseno.SelectedIndex = tabTablas.TabIndex
            TabDiseno.SelectedTab = tabTablas
        End If
    End Sub

    Private Sub btnSolapaSig_Click(sender As Object, e As EventArgs) Handles btnSolapaSig.Click
        If TabDiseno.SelectedIndex <> tabDatos.TabIndex Then
            tabDatos.Select()
            TabDiseno.SelectedIndex = tabDatos.TabIndex
            TabDiseno.SelectedTab = tabDatos
        End If
    End Sub

    Private Sub TabDiseno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabDiseno.SelectedIndexChanged
        If TabDiseno.SelectedIndex = tabDatos.TabIndex Then
            btnSolapaAnt.Enabled = True
            btnSolapaSig.Enabled = False
        Else
            btnSolapaAnt.Enabled = False
            btnSolapaSig.Enabled = True

        End If
    End Sub
End Class
