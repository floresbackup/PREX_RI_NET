Imports DevExpress.XtraGrid.Views.Base
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
    Public ErrorPermiso As Boolean = False
    Private bGuardar As Boolean

   Private oAdmLocal As New AdmTablas
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
                        Throw New Security.SecurityException("Falla de seguridad - US_CODUSU: " & nCodigoUsuario)
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
                ds = oAdmLocal.AbrirDataset(sSQL)

                With ds.Tables(0)


                    If .Rows.Count = 0 Then
                        Throw New Security.SecurityException("Error en la línea de comandos. Parámetro de transacción incorrecto - MU_CODTRA: " & nCodigoTransaccion)
                    Else
                        lblTransaccion.Text = .Rows(0).Item("MU_DESCRI")
                        Me.Text = "Transacción:" & CODIGO_TRANSACCION.ToString & " - " & .Rows(0).Item("MU_TRANSA")
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
      oAdmlocal.ConnectionString = CONN_LOCAL
      AnalizarCommand()

   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
      Me.Close()
   End Sub

   Private Sub Cargar()

      cargarTabPartidas()
      cargarTabFuentes()
      cargarTabRel()
      cargarTabEstructura()
      cargarTabRdo()
      cargarTabRelTec()

   End Sub

   Private Sub cargarTabPartidas()

      Dim sSQL As String
      Dim ds As DataSet

      sSQL = "SELECT       0 AS Valor, 'No' AS Descripcion " & _
             "UNION " & _
             "SELECT       1 AS Valor, 'Si' AS Descripcion "
      reemplazarValoresColumnas(GridPartidas, "TK_MONFIJ", sSQL)

      sSQL = "SELECT       0 AS Valor, 'Crecimiento' AS Descripcion " & _
             "UNION " & _
             "SELECT       1 AS Valor, 'Rendimiento' AS Descripcion "
      reemplazarValoresColumnas(GridPartidas, "TK_CREOREND", sSQL)

      cboCuadrosPartidas.Items.Clear()
      cboFecVigPartida.Items.Clear()

      sSQL = "SELECT    TG_CODCON, TG_DESCRI " & _
             "FROM      TABGEN " & _
             "WHERE     TG_CODCON <> 999999 " & _
             "AND       TG_CODTAB = 2 " & _
             "ORDER BY  TG_CODCON "
      CargarCombo(cboCuadrosPartidas, sSQL)

      If cboCuadrosPartidas.Items.Count > 0 Then
         cboCuadrosPartidas.SelectedIndex = 0
      End If

      sSQL = "SELECT    DISTINCT TK_FECVIG " & _
             "FROM      TABPAR " & _
             "WHERE     TK_CODENT = " & CODIGO_ENTIDAD & " " & _
             "AND       TK_ACTIVA = 1 " & _
             "ORDER BY  TK_FECVIG DESC"
      ds = oAdmLocal.AbrirDataset(sSQL)

      With ds.Tables(0)
         For Each row As DataRow In .Rows
            cboFecVigPartida.Items.Add(New Prex.Utils.Entities.clsItem(row("TK_FECVIG"), row("TK_FECVIG")))
         Next
      End With

      ds = Nothing

      If cboFecVigPartida.Items.Count > 0 Then
         cboFecVigPartida.SelectedIndex = 0
      End If

   End Sub

   Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

      If bGuardar Then

         Dim oSinc As New frmSincronizar

         If frmSincronizar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            SincPartidas(CDate(INPUT_GENERAL), CODIGO_ENTIDAD, UsuarioActual.Nombre)
         End If

      End If

   End Sub

   Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      Cargar()
   End Sub

   Private Sub btnPresentarPartidas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPresentarPartidas.Click
      presentarPartidas()
   End Sub

   Private Sub presentarPartidas()

      Dim sSQL As String
      Dim ds As DataSet

      Try

         sSQL = "SELECT       * " & _
                "FROM         TABPAR " & _
                "WHERE        TK_CODENT = " & CODIGO_ENTIDAD & " " & _
                "AND          TK_FECVIG = " & FechaSQL(LlaveCombo(cboFecVigPartida)) & " " & _
                "AND          TK_CUADRO = " & LlaveCombo(cboCuadrosPartidas) & " " & _
                "ORDER BY     TK_CUADRO, TK_ORDEN, TK_CODPAR, TK_CAMPO8 "
         ds = oAdmlocal.AbrirDataset(sSQL)

         GridPartidas.DataSource = ds.Tables(0)
         GridPartidas.Refresh()
         GridPartidas.RefreshDataSource()

         btnNuevaPartida.Enabled = True

         activarBotonesPartidas()

         cboFecVigPartida.Enabled = False
         cboCuadrosPartidas.Enabled = False
         btnPresentarPartidas.Enabled = False
         btnLimpiarPartidas.Enabled = True

      Catch ex As Exception
         TratarError(ex, "presentarPartidas")
      End Try

   End Sub

   Private Sub reemplazarValoresColumnas(ByVal oGrid As DevExpress.XtraGrid.GridControl, ByVal sColumna As String, ByVal sSQL As String)

      Dim ds As New DataSet
      Dim oItem As DropDownGrid
      Dim xpCollectionTipo As New XPCollection(GetType(DropDownGrid))

      xpCollectionTipo.DisplayableProperties = "This;Oid;Descripcion"

      ds = oAdmLocal.AbrirDataset(sSQL)

      With ds.Tables(0)

         For Each row As DataRow In .Rows

            oItem = New DropDownGrid

            oItem.Oid = row(0)
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
      oLookUp.ValueMember = "Oid"
      oLookUp.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Oid"))
      oLookUp.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion"))
      oLookUp.Columns("Oid").Visible = False
      oLookUp.ShowFooter = False
      oLookUp.ShowHeader = False
      oGrid.RepositoryItems.Add(oLookUp)

      CType(oGrid.MainView, ColumnView).Columns(sColumna).ColumnEdit = oLookUp

      oLookUp = Nothing

   End Sub

   Private Sub btnNuevaPartida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaPartida.Click

      Dim oForm As New frmABMPartida

      oForm.PasarNuevo(CODIGO_ENTIDAD, LlaveCombo(cboCuadrosPartidas), LlaveCombo(cboFecVigPartida))

      If oForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
         bGuardar = True
         presentarPartidas()
      End If

      oForm = Nothing

   End Sub

   Private Sub btnDesactivarPartida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesactivarPartida.Click

      Dim oForm As New frmABMPartida

      If ValGrilla(gPartidas, "TK_ACTIVA") = 0 Then
         MensajeError("La partida ya se encuentra desactivada")
      Else
         oForm.PasarDatos(CODIGO_ENTIDAD, LlaveCombo(cboCuadrosPartidas), LlaveCombo(cboFecVigPartida), ValGrilla(gPartidas, "TK_CODPAR"), ValGrilla(gPartidas, "TK_CAMPO8"), True)

         If oForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            bGuardar = True
            presentarPartidas()
         End If
      End If

      oForm = Nothing

   End Sub

   Private Sub btnLimpiarPartidas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarPartidas.Click
      limpiarPartidas()
   End Sub

   Private Sub limpiarPartidas()

      GridPartidas.DataSource = Nothing
      GridPartidas.Refresh()
      GridPartidas.RefreshDataSource()

      cboFecVigPartida.Enabled = True
      cboCuadrosPartidas.Enabled = True
      btnPresentarPartidas.Enabled = True
      btnLimpiarPartidas.Enabled = False
      btnNuevaPartida.Enabled = False

      activarBotonesPartidas()

   End Sub

   Private Sub limpiarFuentes()

      GridFuentes.DataSource = Nothing
      GridFuentes.Refresh()
      GridFuentes.RefreshDataSource()

      cboFecVigFuentes.Enabled = True
      cboTablaFuentes.Enabled = True
      btnPresentarFuentes.Enabled = True
      btnLimpiarFuentes.Enabled = False
      btnNuevaFuente.Enabled = False

      activarBotonesFuentes()

   End Sub

   Private Sub activarBotonesPartidas()

      btnModifPartida.Enabled = gPartidas.RowCount > 0
      btnDesactivarPartida.Enabled = gPartidas.RowCount > 0
      btnImprimirPartidas.Enabled = gPartidas.RowCount > 0
      btnExportarPartidas.Enabled = gPartidas.RowCount > 0

   End Sub

   Private Sub activarBotonesFuentes()

      btnModifFuente.Enabled = gFuentes.RowCount > 0
      btnDesactivarFuente.Enabled = gFuentes.RowCount > 0
      btnImprimirFuentes.Enabled = gFuentes.RowCount > 0
      btnExportarFuentes.Enabled = gFuentes.RowCount > 0

   End Sub

   Private Sub btnModifPartida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifPartida.Click

      Dim oForm As New frmABMPartida

      oForm.PasarDatos(CODIGO_ENTIDAD, LlaveCombo(cboCuadrosPartidas), LlaveCombo(cboFecVigPartida), ValGrilla(gPartidas, "TK_CODPAR"), ValGrilla(gPartidas, "TK_CAMPO8"))

      If oForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
         bGuardar = True
         presentarPartidas()
      End If

      oForm = Nothing

   End Sub

   Private Sub btnExportarPartidas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarPartidas.Click
      Dim oForm As New frmExportar
      oForm.PasarViewResultados("Partidas.xls", "Partidas", gPartidas)
      oForm.ShowDialog()
   End Sub

   Private Sub btnImprimirPartidas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirPartidas.Click
      GridPartidas.ShowPrintPreview()
   End Sub

   Private Sub GridPartidas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridPartidas.DoubleClick

      If gPartidas.SelectedRowsCount = 1 Then
         btnModifPartida_Click(sender, e)
      End If

   End Sub

   Private Sub btnImprimirFuentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirFuentes.Click
      GridFuentes.ShowPrintPreview()
   End Sub

   Private Sub btnExportarFuentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarFuentes.Click
      Dim oForm As New frmExportar
      oForm.PasarViewResultados("Fuente de datos.xls", "Fuente de datos", gPartidas)
      oForm.ShowDialog()
   End Sub

   Private Sub cargarTabFuentes()

      Dim sSQL As String
      Dim ds As DataSet

      cboTablaFuentes.Items.Clear()
      cboFecVigFuentes.Items.Clear()

      sSQL = "SELECT    DN_TABLA, DN_NOMBRE " & _
             "FROM      DISNOM " & _
             "WHERE     DN_INACTIVO = 0 "
      ds = oAdmLocal.AbrirDataset(sSQL)

      With ds.Tables(0)
         For Each row As DataRow In .Rows
            cboTablaFuentes.Items.Add(New Prex.Utils.Entities.clsItem(row("DN_TABLA"), row("DN_NOMBRE")))
         Next
      End With

      ds = Nothing

      If cboTablaFuentes.Items.Count > 0 Then
         cboTablaFuentes.SelectedIndex = 0
      End If

      sSQL = "SELECT    DISTINCT TK_FECVIG " & _
             "FROM      TABPAR " & _
             "WHERE     TK_CODENT = " & CODIGO_ENTIDAD & " " & _
             "AND       TK_ACTIVA = 1 " & _
             "ORDER BY  TK_FECVIG DESC"
      ds = oAdmLocal.AbrirDataset(sSQL)

      With ds.Tables(0)
         For Each row As DataRow In .Rows
            cboFecVigFuentes.Items.Add(New Prex.Utils.Entities.clsItem(row("TK_FECVIG"), row("TK_FECVIG")))
         Next
      End With

      ds = Nothing

      If cboFecVigFuentes.Items.Count > 0 Then
         cboFecVigFuentes.SelectedIndex = 0
      End If

   End Sub

   Private Sub presentarFuentes()

      Dim sSQL As String
      Dim ds As DataSet

      Try

         sSQL = "SELECT      * " & _
                "FROM        TABCUE " & _
                "WHERE       TU_CODENT=" & CODIGO_ENTIDAD & " " & _
                "AND         TU_FECVIG=" & FechaSQL(LlaveCombo(cboFecVigFuentes)) & " " & _
                "AND         TU_TABLA ='" & LlaveCombo(cboTablaFuentes) & "' " & _
                "ORDER BY    CAST(TU_CODCUE AS VARCHAR(20)) ASC"
         ds = oAdmLocal.AbrirDataset(sSQL)

         GridFuentes.DataSource = ds.Tables(0)
         GridFuentes.Refresh()
         GridFuentes.RefreshDataSource()

         btnNuevaFuente.Enabled = True

         activarBotonesFuentes()

         cboFecVigFuentes.Enabled = False
         cboTablaFuentes.Enabled = False
         btnPresentarFuentes.Enabled = False
         btnLimpiarFuentes.Enabled = True

      Catch ex As Exception
         TratarError(ex, "presentarFuentes")
      End Try

   End Sub

   Private Sub btnPresentarFuentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPresentarFuentes.Click
      presentarFuentes()
   End Sub

   Private Sub btnLimpiarFuentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarFuentes.Click
      limpiarFuentes()
   End Sub

   Private Sub btnNuevaFuente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaFuente.Click

      Dim oForm As New frmABMFuentes

      oForm.PasarNuevo(LlaveCombo(cboFecVigFuentes), LlaveCombo(cboTablaFuentes))

      If oForm.ShowDialog = Windows.Forms.DialogResult.OK Then
         bGuardar = True
         presentarFuentes()
      End If

      oForm = Nothing

   End Sub

   Private Sub btnModifFuente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifFuente.Click

      Dim oForm As New frmABMFuentes

      oForm.PasarDatos(LlaveCombo(cboFecVigFuentes), LlaveCombo(cboTablaFuentes), ValGrilla(gFuentes, "TU_CODENT"), ValGrilla(gFuentes, "TU_CODCUE"), ValGrilla(gFuentes, "TU_DESCRI"), ValGrilla(gFuentes, "TU_ACTIVA"))

      If oForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
         bGuardar = True
         presentarFuentes()
      End If

      oForm = Nothing

   End Sub

   Private Sub btnDesactivarFuente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesactivarFuente.Click

      Dim oForm As New frmABMFuentes

      oForm.PasarDatos(LlaveCombo(cboFecVigFuentes), LlaveCombo(cboTablaFuentes), ValGrilla(gFuentes, "TU_CODENT"), ValGrilla(gFuentes, "TU_CODCUE"), ValGrilla(gFuentes, "TU_DESCRI"), ValGrilla(gFuentes, "TU_ACTIVA"), True)

      If oForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
         bGuardar = True
         presentarFuentes()
      End If

      oForm = Nothing

   End Sub

   Private Sub GridFuentes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridFuentes.DoubleClick

      If gFuentes.SelectedRowsCount = 1 Then
         btnModifFuente_Click(sender, e)
      End If

   End Sub

   Private Sub cargarTabRel()

      Dim sSQL As String
      Dim ds As DataSet

      cboFecVigRel.Items.Clear()
      cboCuadroRel.Items.Clear()
      cboCuadroRel.Text = ""
      cboCodParRel.Items.Clear()
      cboCodParRel.Text = ""
      cboCampo8Rel.Items.Clear()
      cboCampo8Rel.Text = ""
      cboTablaRel.Items.Clear()
      cboTablaRel.Text = ""
      lvNoRel.Items.Clear()
      lvSiRel.Items.Clear()

      cmdNoUnoRel.Enabled = False
      cmdSiUnoRel.Enabled = False
      cmdNoTodosRel.Enabled = False
      cmdSiTodosRel.Enabled = False

      cboFecVigRel.Enabled = True
      cboCuadroRel.Enabled = False
      cboCodParRel.Enabled = False
      cboCampo8Rel.Enabled = False
      cboTablaRel.Enabled = False
      cmdPresentarRel.Enabled = False
      cmdGuardarRel.Enabled = False

      'PERIODO
      sSQL = "SELECT    DISTINCT TK_FECVIG " & _
             "FROM      TABPAR " & _
             "WHERE     TK_CODENT = " & CODIGO_ENTIDAD & " " & _
             "AND       TK_ACTIVA = 1 " & _
             "ORDER BY  TK_FECVIG DESC"
      ds = oAdmLocal.AbrirDataset(sSQL)

      With ds.Tables(0)
         For Each row As DataRow In .Rows
            cboFecVigRel.Items.Add(New Prex.Utils.Entities.clsItem(row("TK_FECVIG"), row("TK_FECVIG")))
         Next
      End With

      ds = Nothing

      cboFecVigRel.Text = "<Seleccione un período...>"

   End Sub

   Private Sub cboFecVigRel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFecVigRel.SelectedIndexChanged

      Dim ds As DataSet
      Dim sSQL As String = ""

      Try

         cboCuadroRel.Items.Clear()
         cboCodParRel.Items.Clear()
         cboCampo8Rel.Items.Clear()
         cboTablaRel.Items.Clear()

         'CUADRO
         sSQL = "SELECT    DISTINCT TG_CODCON, TG_DESCRI " & _
                "FROM      TABGEN " & _
                "WHERE     TG_CODTAB = 2 " & _
                "AND       TG_CODCON IN   ( " & _
                "                            SELECT      DISTINCT TK_CUADRO " & _
                "                            FROM        TABPAR " & _
                "                            WHERE       TK_FECVIG = " & FechaSQL(LlaveCombo(cboFecVigRel)) & " " & _
                "                            AND         TK_CODENT = " & CODIGO_ENTIDAD & " " & _
                "                         ) " & _
                "ORDER BY  TG_CODCON "
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)
            For Each row As DataRow In .Rows
               cboCuadroRel.Items.Add(New Prex.Utils.Entities.clsItem(row("TG_CODCON"), row("TG_DESCRI")))
            Next
         End With

         ds = Nothing

         cboCuadroRel.Text = "<Seleccione un cuadro...>"

         cboFecVigRel.Enabled = False
         cboCuadroRel.Enabled = True
         cboCodParRel.Enabled = False
         cboCampo8Rel.Enabled = False
         cboTablaRel.Enabled = False

      Catch ex As Exception
         TratarError(ex, "cboFecVigRel_SelectedIndexChanged")
      End Try

   End Sub

   Private Sub cboCuadroRel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuadroRel.SelectedIndexChanged

      Dim ds As DataSet
      Dim sSQL As String = ""

      Try

         cboCodParRel.Items.Clear()
         cboCampo8Rel.Items.Clear()
         cboTablaRel.Items.Clear()

         'PARTIDAS
         sSQL = "SELECT    TK_CODPAR, MAX(TK_DCORTA) AS DCORTA " & _
                "FROM      TABPAR " & _
                "WHERE     TK_FECVIG = " & FechaSQL(LlaveCombo(cboFecVigRel)) & " " & _
                "AND       TK_CODENT = " & CODIGO_ENTIDAD & " " & _
                "AND       TK_CUADRO = " & LlaveCombo(cboCuadroRel) & " " & _
                "AND       TK_ACTIVA = 1 " & _
                "AND       TK_NIVELTAB = 0 " & _
                "GROUP BY  TK_CUADRO, TK_CODPAR "
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)
            For Each row As DataRow In .Rows
               cboCodParRel.Items.Add(New Prex.Utils.Entities.clsItem(row("TK_CODPAR"), row("DCORTA")))
            Next
         End With

         ds = Nothing

         cboCodParRel.Text = "<Seleccione una partida...>"

         cboFecVigRel.Enabled = False
         cboCuadroRel.Enabled = False
         cboCodParRel.Enabled = True
         cboCampo8Rel.Enabled = False
         cboTablaRel.Enabled = False

      Catch ex As Exception
         TratarError(ex, "cboCuadroRel_SelectedIndexChanged")
      End Try

   End Sub

   Private Sub cmdLimpiarRel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiarRel.Click
      cargarTabRel()
   End Sub

   Private Sub cboCodParRel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodParRel.SelectedIndexChanged

      Dim ds As DataSet
      Dim sSQL As String = ""

      Try

         cboCampo8Rel.Items.Clear()
         cboTablaRel.Items.Clear()

         'CAMPO 8
         sSQL = "SELECT    TG_CODCON, TG_DESCRI, TG_NUME02 " & _
                "FROM      TABGEN " & _
                "WHERE     TG_CODTAB = 5 " & _
                "AND       TG_NUME01 = " & LlaveCombo(cboCuadroRel) & " " & _
                "ORDER BY  TG_CODCON ASC"
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)
            For Each row As DataRow In .Rows
               cboCampo8Rel.Items.Add(New Prex.Utils.Entities.clsItem(row("TG_NUME02"), row("TG_DESCRI")))
            Next
         End With

         ds = Nothing

         cboCampo8Rel.Text = "<Seleccione una referencia...>"

         cboFecVigRel.Enabled = False
         cboCuadroRel.Enabled = False
         cboCodParRel.Enabled = False
         cboCampo8Rel.Enabled = True
         cboTablaRel.Enabled = False

         If cboCampo8Rel.Items.Count = 0 Then
            cboCampo8Rel.Items.Add(New Prex.Utils.Entities.clsItem("0", "No Aplica"))
            cboCampo8Rel.SelectedIndex = 0
            cboCampo8Rel_SelectedIndexChanged(sender, e)
         End If

      Catch ex As Exception
         TratarError(ex, "cboCodParRel_SelectedIndexChanged")
      End Try

   End Sub

   Private Sub cboCampo8Rel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCampo8Rel.SelectedIndexChanged

      Dim ds As DataSet
      Dim sSQL As String = ""

      Try

         cboTablaRel.Items.Clear()

         'TABLAS
         sSQL = "SELECT       DISTINCT DN_TABLA, DN_NOMBRE " & _
                "FROM         DISNOM " & _
                "INNER JOIN   RELCUE " & _
                "ON           RU_TABLA = DN_TABLA " & _
                "WHERE        DN_INACTIVO = 0 " & _
                "AND          RU_CUADRO = " & LlaveCombo(cboCuadroRel) & " "
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)
            For Each row As DataRow In .Rows
               cboTablaRel.Items.Add(New Prex.Utils.Entities.clsItem(row("DN_TABLA"), row("DN_NOMBRE")))
            Next
         End With

         ds = Nothing

         cboTablaRel.Text = "<Seleccione una tabla...>"

         cboFecVigRel.Enabled = False
         cboCuadroRel.Enabled = False
         cboCodParRel.Enabled = False
         cboCampo8Rel.Enabled = False
         cboTablaRel.Enabled = True

      Catch ex As Exception
         TratarError(ex, "cboCampo8Rel_SelectedIndexChanged")
      End Try

   End Sub

   Private Sub cboTablaRel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTablaRel.SelectedIndexChanged
      cboTablaRel.Enabled = False
      cmdPresentarRel.Enabled = True
   End Sub

   Private Sub cmdPresentarRel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPresentarRel.Click
      presentarRel()
   End Sub

   Private Sub presentarRel()

      Dim sSQL As String
      Dim ds As DataSet
      Dim item As ListViewItem

      Try

         oProcesando = New frmProcesando
         oProcesando.MensajeProceso("Cargando partidas...")
         oProcesando.Show(Me)
         Application.DoEvents()

         Me.Enabled = False

         'NO
         sSQL = "SELECT    DISTINCT CAST(TU_CODCUE AS VARCHAR(20)) AS TU_CODCUE, TU_DESCRI, TU_ACTIVA " & _
                "FROM      TABCUE " & _
                "LEFT JOIN RELCUE " & _
                "ON        TU_CODCUE = RU_CODCUE " & _
                "AND       TU_FECVIG = RU_FECVIG " & _
                "AND       TU_CODENT = RU_CODENT " & _
                "AND       TU_TABLA  = RU_TABLA " & _
                "AND       RU_TABLA  ='" & LlaveCombo(cboTablaRel) & "' " & _
                "AND       RU_CODPAR = " & LlaveCombo(cboFecVigRel) & " " & _
                "AND       RU_CAMPO8 = " & LlaveCombo(cboCampo8Rel) & " " & _
                "AND       RU_CUADRO = " & LlaveCombo(cboCuadroRel) & " " & _
                "WHERE     TU_CODENT = " & CODIGO_ENTIDAD & " " & _
                "AND       TU_FECVIG = " & FechaSQL(LlaveCombo(cboFecVigRel)) & " " & _
                "AND       TU_TABLA ='" & LlaveCombo(cboTablaRel) & "' " & _
                "AND       RU_CODCUE IS NULL " & _
                "ORDER BY  CAST(TU_CODCUE AS VARCHAR(20)) ASC"
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)
            For Each row As DataRow In .Rows
               item = lvNoRel.Items.Add(row("TU_CODCUE") & " - " & row("TU_DESCRI").ToString.Trim)
               item.Name = row("TU_CODCUE").ToString

               If row("TU_ACTIVA") = 1 Then
                  item.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
               Else
                  item.ForeColor = Color.DarkRed
               End If

            Next
         End With

         ds = Nothing

         ValidarColoresRel(lvSiRel)

         'SI
         sSQL = "SELECT     TU_CODCUE, TU_DESCRI, TU_ACTIVA " & _
                "FROM       RELCUE " & _
                "INNER JOIN TABCUE " & _
                "ON         RELCUE.RU_CODCUE = TABCUE.TU_CODCUE " & _
                "AND        RELCUE.RU_FECVIG = TABCUE.TU_FECVIG " & _
                "AND        RELCUE.RU_CODENT = TABCUE.TU_CODENT " & _
                "AND        RELCUE.RU_TABLA  = TABCUE.TU_TABLA " & _
                "WHERE      TU_CODENT = " & CODIGO_ENTIDAD & " " & _
                "AND        TU_FECVIG = " & FechaSQL(LlaveCombo(cboFecVigRel)) & " " & _
                "AND        TU_TABLA  ='" & LlaveCombo(cboTablaRel) & "' " & _
                "AND        RU_CUADRO = " & LlaveCombo(cboCuadroRel) & " " & _
                "AND        RU_CODPAR = " & LlaveCombo(cboCodParRel) & " " & _
                "AND        RU_CAMPO8 = " & LlaveCombo(cboCampo8Rel) & " " & _
                "ORDER BY   CAST(TU_CODCUE AS VARCHAR(20)) ASC"
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)
            For Each row As DataRow In .Rows
               item = lvSiRel.Items.Add(row("TU_CODCUE") & " - " & row("TU_DESCRI").ToString.Trim)
               item.Name = row("TU_CODCUE").ToString

               If row("TU_ACTIVA") <> 1 Then
                  item.ForeColor = Color.DarkRed
               End If

            Next
         End With

         ds = Nothing

         cmdPresentarRel.Enabled = False

         If lvNoRel.Items.Count + lvSiRel.Items.Count > 0 Then
            cmdSiUnoRel.Enabled = True
            cmdNoUnoRel.Enabled = True
            cmdSiTodosRel.Enabled = True
            cmdNoTodosRel.Enabled = True
         End If

         ValidarColoresRel(lvNoRel)

         oProcesando.Close()

         cmdGuardarRel.Enabled = True

      Catch ex As Exception
         oProcesando.Close()
         TratarError(ex, "presentarFuentes")
      End Try

      Me.Enabled = True
      oProcesando = Nothing
      Me.Focus()

   End Sub

   Private Sub ValidarColoresRel(ByVal oLV As ListView)

      Dim ds As DataSet
      Dim sSQL As String
      Dim oItem As ListViewItem

      Try

         sSQL = "SELECT    * " & _
                "FROM      RELCUE " & _
                "WHERE     RU_CODENT = " & CODIGO_ENTIDAD & " " & _
                "AND       RU_FECVIG = " & FechaSQL(LlaveCombo(cboFecVigRel)) & " " & _
                "AND       RU_CUADRO = " & LlaveCombo(cboCuadroRel) & " " & _
                "AND       RU_TABLA  = '" & LlaveCombo(cboTablaRel) & "'"
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)
            For Each row As DataRow In .Rows

               For Each oItem In oLV.Items
                  If (Mid(oItem.Name, 1, 6) = row("RU_CODCUE").ToString) Or _
                     (Val(oItem.Name) = row("RU_CODCUE")) Or _
                     (oItem.Name = Mid(row("RU_CODCUE").ToString, 1, 6)) Then
                     oItem.ForeColor = Color.DarkRed
                     Exit For
                  End If
               Next

            Next
         End With

         ds = Nothing

      Catch ex As Exception
         TratarError(ex, "ValidarColoresRel")
      End Try

   End Sub

   Private Sub cmdSiUnoRel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSiUnoRel.Click

      Dim itmX As ListViewItem
      Dim sKeys As String = ""
      Dim sKey() As String
      Dim nC As Long

      Try

         oProcesando = New frmProcesando
         oProcesando.MensajeProceso("Moviendo partida...")
         oProcesando.Show(Me)
         Application.DoEvents()

         Me.Enabled = False

         'PRIMERO VERIFICO SI ESTOY PASANDO UN RUBRO, SI ES ASI
         'BLOQUEO LAS PARTIDAS QUE PERTENECEN AL MISMO.
         For Each itmX In lvNoRel.Items

            If itmX.Selected And _
               itmX.ForeColor <> Color.DarkRed And _
               itmX.Name.Trim.Length = 6 Then
               sKeys = sKeys & itmX.Name & ","
            End If

         Next

         If sKeys <> "" Then
            sKey = sKeys.Split(",")

            For Each itmX In lvNoRel.Items
               For nC = LBound(sKey) To UBound(sKey) - 1
                  If Mid(itmX.Name, 1, 6) = sKey(nC) And _
                     itmX.Name.Trim <> sKey(nC) Then
                     itmX.ForeColor = Color.DarkRed
                  End If
               Next nC
            Next
         End If

         sKeys = ""
         ReDim sKey(0)

         'SEGUNDO VERIFICO SI ESTOY PASANDO UNA CUENTA QUE NO ES RUBRO, SI ES ASI
         'BLOQUEO LA CUENTA MADRE DEL GRUPO QUE PERTENECEN.
         For Each itmX In lvNoRel.Items

            If itmX.Selected And _
               itmX.ForeColor <> Color.DarkRed And _
               itmX.Name.Trim.Length > 6 Then
               sKeys = sKeys & itmX.Name.Trim & ","
            End If

         Next

         If sKeys <> "" Then
            sKey = sKeys.Split(",")

            For Each itmX In lvNoRel.Items
               For nC = LBound(sKey) To UBound(sKey) - 1
                  If Mid(itmX.Name, 1, 6) = Mid(sKey(nC), 1, 6) And _
                     itmX.Name.Trim.Length = 6 Then
                     itmX.ForeColor = Color.DarkRed
                  End If
               Next nC
            Next
         End If

         sKeys = ""
         ReDim sKey(0)

         For Each item As ListViewItem In lvNoRel.Items

            If item.Selected And _
               item.ForeColor <> Color.DarkRed Then
               itmX = lvSiRel.Items.Add(item.Text)
               itmX.Name = item.Name
               sKeys = sKeys & item.Name & ","
            End If

         Next

         If sKeys <> "" Then
            lvNoRel.Focus()
            bGuardar = True

            sKey = sKeys.Split(",")

            For nC = LBound(sKey) To UBound(sKey) - 1
               lvNoRel.Items(sKey(nC)).Remove()
            Next nC

         End If

         oProcesando.Close()

      Catch ex As Exception
         oProcesando.Close()
         TratarError(ex, "cmdSiUnoRel_Click")
      End Try

      Me.Enabled = True
      oProcesando = Nothing
      Me.Focus()

   End Sub

   Private Sub cmdSiTodosRel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSiTodosRel.Click

      Dim item As ListViewItem

      Try

         oProcesando = New frmProcesando
         oProcesando.MensajeProceso("Moviendo partidas...")
         oProcesando.Show(Me)
         Application.DoEvents()

         Me.Enabled = False

         For Each itmX As ListViewItem In lvNoRel.Items
            item = lvSiRel.Items.Add(itmX.Text)
            item.Name = itmX.Name
         Next

         If lvNoRel.Items.Count > 0 Then
            lvNoRel.Items.Clear()
            bGuardar = True
         End If

         ValidarColoresRel(lvSiRel)

         oProcesando.Close()

      Catch ex As Exception
         oProcesando.Close()
         TratarError(ex, "cmdSiTodosRel_Click")
      End Try

      Me.Enabled = True
      oProcesando = Nothing
      Me.Focus()

   End Sub

   Private Sub cmdNoUnoRel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNoUnoRel.Click

      Dim itmX As ListViewItem
      Dim sKeys As String = ""
      Dim sKey() As String
      Dim nC As Long
      Dim nCant As Integer

      Try

         oProcesando = New frmProcesando
         oProcesando.MensajeProceso("Moviendo partida...")
         oProcesando.Show(Me)
         Application.DoEvents()

         Me.Enabled = False

         'PRIMERO VERIFICO SI ESTOY PASANDO UN RUBRO, SI ES ASI
         'BLOQUEO LAS PARTIDAS QUE PERTENECEN AL MISMO.
         For Each itmX In lvSiRel.Items
            If itmX.Selected And _
               itmX.Name.Trim.Length = 6 Then
               sKeys = sKeys & itmX.Name & ","
            End If
         Next

         If sKeys <> "" Then
            sKey = sKeys.Split(",")

            For Each itmX In lvNoRel.Items
               For nC = LBound(sKey) To UBound(sKey) - 1
                  'SI ES DEL RUBRO Y NO ES LA CUENTA MADRE ENTONCES LO GRISO.
                  If Mid(itmX.Name, 1, 6) = sKey(nC) And _
                     itmX.Name.Trim <> sKey(nC) Then
                     itmX.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
                  End If
               Next nC
            Next
         End If

         sKeys = ""
         ReDim sKey(0)

         'SEGUNDO VERIFICO SI ESTOY PASANDO UNA CUENTA QUE NO ES RUBRO, SI ES ASI
         'BLOQUEO LA CUENTA MADRE DEL GRUPO QUE PERTENECEN.
         For Each itmX In lvSiRel.Items
            If itmX.Selected And _
               itmX.Name.Trim.Length > 6 Then
               sKeys = sKeys & itmX.Name.Trim & ","
            End If
         Next

         If sKeys <> "" Then
            sKey = sKeys.Split(",")
            sKeys = ""

            For nC = LBound(sKey) To UBound(sKey) - 1
               nCant = 0
               For Each itmX In lvSiRel.Items
                  If Mid(itmX.Name, 1, 6) = Mid(sKey(nC), 1, 6) Then
                     nCant = nCant + 1
                  End If
               Next

               If nCant = 1 Then
                  lvNoRel.Items(Mid(sKey(nC), 1, 6)).ForeColor = Color.FromKnownColor(KnownColor.ControlText)
               End If
            Next nC

         End If

         sKeys = ""
         ReDim sKey(0)

         'PASAJE DE CUENTAS Y RUBROS ENTRE LOS LV.
         For Each item As ListViewItem In lvSiRel.Items

            If item.Selected Then
               itmX = lvNoRel.Items.Add(item.Text)
               itmX.Name = item.Name
               itmX.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
               sKeys = sKeys & item.Name & ","
            End If

         Next

         If sKeys <> "" Then
            lvSiRel.Focus()
            bGuardar = True

            sKey = sKeys.Split(",")

            For nC = LBound(sKey) To UBound(sKey) - 1
               lvSiRel.Items(sKey(nC)).Remove()
            Next nC
         End If

         oProcesando.Close()

      Catch ex As Exception
         oProcesando.Close()
         TratarError(ex, "cmdNoUnoRel_Click")
      End Try

      Me.Enabled = True
      oProcesando = Nothing
      Me.Focus()

   End Sub

   Private Sub cmdNoTodosRel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNoTodosRel.Click

      Dim item As ListViewItem

      Try

         oProcesando = New frmProcesando
         oProcesando.MensajeProceso("Moviendo partidas...")
         oProcesando.Show(Me)
         Application.DoEvents()

         Me.Enabled = False

         For Each itmX As ListViewItem In lvSiRel.Items
            item = lvNoRel.Items.Add(itmX.Text)
            item.Name = itmX.Name
         Next

         If lvSiRel.Items.Count > 0 Then
            bGuardar = True
            lvSiRel.Items.Clear()
         End If

         ValidarColoresRel(lvNoRel)

         oProcesando.Close()

      Catch ex As Exception
         oProcesando.Close()
         TratarError(ex, "cmdNoTodosRel_Click")
      End Try

      Me.Enabled = True
      oProcesando = Nothing
      Me.Focus()

   End Sub

   Private Sub cmdCancelarRel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelarRel.Click
      cargarTabRel()
   End Sub

   Private Sub cmdGuardarRel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardarRel.Click
      guardarRel()
   End Sub

   Private Sub guardarRel()

      Dim ds As DataSet
      Dim cb As OleDb.OleDbCommandBuilder
      Dim da As OleDb.OleDbDataAdapter = Nothing
      Dim sSQL As String
      Dim row As DataRow

      Try

         oProcesando = New frmProcesando
         oProcesando.MensajeProceso("Guardando relaciones Cuentas-Partidas...")
         oProcesando.Show(Me)
         Application.DoEvents()

         Me.Enabled = False

         sSQL = "DELETE " & _
                "FROM   RELCUE " & _
                "WHERE  RU_FECVIG = " & FechaSQL(LlaveCombo(cboFecVigRel)) & " " & _
                "AND    RU_CODENT = " & CODIGO_ENTIDAD & " " & _
                "AND    RU_CODPAR = " & LlaveCombo(cboCodParRel) & " " & _
                "AND    RU_CAMPO8 = " & LlaveCombo(cboCampo8Rel) & " " & _
                "AND    RU_TABLA  = '" & LlaveCombo(cboTablaRel) & "' " & _
                "AND    RU_CUADRO = " & LlaveCombo(cboCuadroRel) & " "
         oAdmLocal.EjecutarComandoSQL(sSQL)

         For Each item As ListViewItem In lvSiRel.Items

            sSQL = "SELECT       * " & _
                   "FROM         RELCUE " & _
                   "WHERE        RU_FECVIG = " & FechaSQL(LlaveCombo(cboFecVigRel)) & " " & _
                   "AND          RU_CODENT = " & CODIGO_ENTIDAD & " " & _
                   "AND          RU_CODCUE=" & item.Name.Trim & " " & _
                   "AND          RU_CODPAR = " & LlaveCombo(cboCodParRel) & " " & _
                   "AND          RU_CAMPO8 = " & LlaveCombo(cboCampo8Rel) & " " & _
                   "AND          RU_TABLA  = '" & LlaveCombo(cboTablaRel) & "' " & _
                   "AND          RU_CUADRO = " & LlaveCombo(cboCuadroRel) & " "
            ds = oAdmLocal.AbrirDataset(sSQL, da)
            cb = New OleDb.OleDbCommandBuilder(da)

            With ds.Tables(0)

               row = .NewRow

               row("RU_FECVIG") = LlaveCombo(cboFecVigRel)
               row("RU_CODENT") = CODIGO_ENTIDAD
               row("RU_CODCUE") = item.Name
               row("RU_CODPAR") = LlaveCombo(cboCodParRel)
               row("RU_CAMPO8") = LlaveCombo(cboCampo8Rel)
               row("RU_TABLA") = LlaveCombo(cboTablaRel)
               row("RU_CUADRO") = LlaveCombo(cboCuadroRel)

               .Rows.Add(row)

            End With

            da.Update(ds)
            ds.AcceptChanges()

            ds = Nothing
            da = Nothing

         Next

         bGuardar = True
         MensajeInformacion("Relación de fuentes de datos guardada exitosamente")
         oProcesando.Close()

      Catch ex As Exception
         oProcesando.Close()
         TratarError(ex, "guardarRel")
      End Try

      Me.Enabled = True
      oProcesando = Nothing
      Me.Focus()

   End Sub

   Private Sub cargarTabEstructura()

      Dim sSQL As String
      Dim ds As DataSet

      cboCuadroEstructura.Items.Clear()
      cboFecVigEstructura.Items.Clear()

      sSQL = "SELECT    TG_CODCON, TG_DESCRI " & _
             "FROM      TABGEN " & _
             "WHERE     TG_CODCON <> 999999 " & _
             "AND       TG_CODTAB = 2 " & _
             "ORDER BY  TG_CODCON "
      CargarCombo(cboCuadroEstructura, sSQL)

      If cboCuadroEstructura.Items.Count > 0 Then
         cboCuadroEstructura.SelectedIndex = 0
      End If

      sSQL = "SELECT    DISTINCT TK_FECVIG " & _
             "FROM      TABPAR " & _
             "WHERE     TK_CODENT = " & CODIGO_ENTIDAD & " " & _
             "AND       TK_ACTIVA = 1 " & _
             "ORDER BY  TK_FECVIG DESC"
      ds = oAdmLocal.AbrirDataset(sSQL)

      With ds.Tables(0)
         For Each row As DataRow In .Rows
            cboFecVigEstructura.Items.Add(New Prex.Utils.Entities.clsItem(row("TK_FECVIG"), row("TK_FECVIG")))
         Next
      End With

      ds = Nothing

      If cboFecVigEstructura.Items.Count > 0 Then
         cboFecVigEstructura.SelectedIndex = 0
      End If

   End Sub

   Private Sub presentarEstructura()

      Dim sSQL As String
      Dim ds As DataSet
      Dim nodoPadre As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
      Dim nuevoNodo As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
      Dim sRelativo As String

      Try

         oProcesando = New frmProcesando
         oProcesando.MensajeProceso("Cargando estructura...")
         oProcesando.Show(Me)
         Application.DoEvents()

         tlEstructura.Nodes.Clear()

         nuevoNodo = tlEstructura.AppendNode(DBNull.Value, nodoPadre)

         nuevoNodo.SetValue("TK_CODPAR", 0)
         nuevoNodo.SetValue("TK_DESCRI", "Partidas")
         nuevoNodo.SetValue("TK_CAMPO8", 0)
         nuevoNodo.SetValue("TK_GENERATXT", False)
         nuevoNodo.SetValue("Clave", "SEBA")

         sSQL = "SELECT       *, 'K' + CAST(TK_CODPAR AS VARCHAR) + 'K' + CAST(TK_CAMPO8 AS VARCHAR) AS Clave " & _
                "FROM         TABPAR " & _
                "WHERE        TK_CODENT = " & CODIGO_ENTIDAD & " " & _
                "AND          TK_FECVIG = " & FechaSQL(LlaveCombo(cboFecVigEstructura)) & " " & _
                "AND          TK_CUADRO = " & LlaveCombo(cboCuadroEstructura) & " " & _
                "ORDER BY     TK_NIVEL, TK_CODPAR, TK_CAMPO8, TK_INDEX "
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)

            For Each row As DataRow In .Rows

               If row("TK_RELATIVO") Is DBNull.Value Then
                  sRelativo = "SEBA"
               Else
                  sRelativo = IIf(row("TK_RELATIVO") = "", "SEBA", row("TK_RELATIVO"))
               End If

               nodoPadre = tlEstructura.FindNodeByFieldValue("Clave", sRelativo)

               nuevoNodo = tlEstructura.AppendNode(DBNull.Value, nodoPadre)

               nuevoNodo.SetValue("TK_CODPAR", row("TK_CODPAR"))
               nuevoNodo.SetValue("TK_DESCRI", row("TK_DESCRI"))
               nuevoNodo.SetValue("TK_CAMPO8", row("TK_CAMPO8"))
               nuevoNodo.SetValue("Clave", row("Clave"))

               If row("TK_GENERATXT") Is DBNull.Value Then
                  nuevoNodo.SetValue("TK_GENERATXT", False)
               Else
                  nuevoNodo.SetValue("TK_GENERATXT", IIf(row("TK_GENERATXT") <> 0, True, False))
               End If

               nuevoNodo = Nothing
               nodoPadre = Nothing

            Next

         End With

         ds = Nothing

         btnGuardarEstructura.Enabled = True
         btnLimpiarEstructura.Enabled = True
         btnPresentarEstructura.Enabled = False
         cboFecVigEstructura.Enabled = False
         cboCuadroEstructura.Enabled = False
         oProcesando.Close()

      Catch ex As Exception
         oProcesando.Close()
         TratarError(ex, "presentarPartidas")
      End Try

      oProcesando = Nothing

   End Sub

   Private Sub btnPresentarEstructura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPresentarEstructura.Click
      presentarEstructura()
   End Sub

   Private Sub limpiarEstructura()

      tlEstructura.Nodes.Clear()

      cboFecVigEstructura.Enabled = True
      cboCuadroEstructura.Enabled = True
      btnPresentarEstructura.Enabled = True
      btnLimpiarEstructura.Enabled = False
      btnGuardarEstructura.Enabled = False

   End Sub

   Private Sub btnGuardarEstructura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarEstructura.Click
      guardarEstructura()
   End Sub

   Private Sub btnLimpiarEstructura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarEstructura.Click
      limpiarEstructura()
   End Sub

   Private Sub guardarEstructura()

      Dim ds As DataSet
      Dim cb As OleDb.OleDbCommandBuilder
      Dim da As OleDb.OleDbDataAdapter = Nothing
      Dim sSQL As String
      Dim nodo As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing

      'Try

      oProcesando = New frmProcesando
      oProcesando.MensajeProceso("Guardando estructura de Partidas...")
      oProcesando.Show(Me)
      Application.DoEvents()

      Me.Enabled = False

      sSQL = "SELECT       * " & _
             "FROM         TABPAR " & _
             "WHERE        TK_CODENT = " & CODIGO_ENTIDAD & " " & _
             "AND          TK_FECVIG = " & FechaSQL(LlaveCombo(cboFecVigEstructura)) & " " & _
             "AND          TK_CUADRO = " & LlaveCombo(cboCuadroEstructura) & " " & _
             "ORDER BY     TK_NIVEL, TK_CODPAR, TK_CAMPO8, TK_INDEX "
      ds = oAdmLocal.AbrirDataset(sSQL, da)
      cb = New OleDb.OleDbCommandBuilder(da)

      With ds.Tables(0)

         For Each row As DataRow In .Rows

            nodo = tlEstructura.FindNodeByFieldValue("Clave", "K" & row("TK_CODPAR").ToString & "K" & row("TK_CAMPO8").ToString)

            If Not (nodo Is Nothing) Then

               row("TK_INDEX") = nodo.Id
               row("TK_NIVEL") = nodo.Level

               If nodo.ParentNode Is Nothing Then
                  row("TK_RELATIVO") = "SEBA"
                  row("TK_ESQUEMA") = 0
               Else
                  row("TK_RELATIVO") = nodo.ParentNode.GetValue("Clave")
                  row("TK_ESQUEMA") = nodo.ParentNode.Id
               End If

               row("TK_GENERATXT") = IIf(nodo.GetValue("TK_GENERATXT"), 1, 0)
               row("TK_NIVELTAB") = IIf(nodo.HasChildren, 1, 0)

               da.Update(ds)
               ds.AcceptChanges()

            End If

         Next

      End With

      ds = Nothing
      da = Nothing

      Me.Enabled = True

      bGuardar = True
      MensajeInformacion("Estructura de partidas guardada exitosamente")
      oProcesando.Close()

      limpiarEstructura()

      'Catch ex As Exception
      'oProcesando.Close()
      'Me.Enabled = True
      'TratarError(ex, "guardarEstructura")
      'End Try

      oProcesando = Nothing

   End Sub

   Private Sub cargarTabRdo()

      Dim sSQL As String
      Dim ds As DataSet
      Dim nMin As Double = 0
      Dim nMax As Double = 0

      cboFecVigRdo.Items.Clear()
      cboCodParRdo.Items.Clear()
      cboCodParRdo.Text = ""
      lvNoRdo.Items.Clear()
      lvSiRdo.Items.Clear()

      cmdNoUnoRdo.Enabled = False
      cmdSiUnoRdo.Enabled = False
      cmdNoTodosRdo.Enabled = False
      cmdSiTodosRdo.Enabled = False
      cmdCancelarRdo.Enabled = False
      cmdGuardarRdo.Enabled = False

      cboFecVigRdo.Enabled = True
      cboCodParRdo.Enabled = True
      btnPresentarRdo.Enabled = True
      btnLimpiarRdo.Enabled = False

      'Rangos
      sSQL = "SELECT    TG_NUME01, TG_NUME02 " & _
             "FROM      TABGEN " & _
             "WHERE     TG_CODTAB = 8 " & _
             "AND       TG_CODCON = 3 "
      ds = oAdmLocal.AbrirDataset(sSQL)

      With ds.Tables(0)
         If .Rows.Count > 0 Then
            nMin = .Rows(0).Item("TG_NUME01")
            nMax = .Rows(0).Item("TG_NUME02")
         End If
      End With

      ds = Nothing

      'PERIODO
      sSQL = "SELECT    DISTINCT TK_FECVIG " & _
             "FROM      TABPAR " & _
             "WHERE     TK_CODPAR >= " & nMin & " " & _
             "AND       TK_CODPAR <= " & nMax & " " & _
             "AND       TK_CODENT = " & CODIGO_ENTIDAD & " " & _
             "AND       TK_ACTIVA = 1 " & _
             "ORDER BY  TK_FECVIG DESC"
      ds = oAdmLocal.AbrirDataset(sSQL)

      With ds.Tables(0)
         For Each row As DataRow In .Rows
            cboFecVigRdo.Items.Add(New Prex.Utils.Entities.clsItem(row("TK_FECVIG"), row("TK_FECVIG")))
         Next
      End With

      ds = Nothing

      cboFecVigRdo.Text = "<Seleccione un período...>"

      'Partidas
      sSQL = "SELECT    DISTINCT TK_CODPAR, TK_DESCRI " & _
             "FROM      TABPAR " & _
             "WHERE     TK_CODPAR >= " & nMin & " " & _
             "AND       TK_CODPAR <= " & nMax & " " & _
             "AND       TK_CODENT = " & CODIGO_ENTIDAD & " " & _
             "AND       TK_ACTIVA = 1 " & _
             "ORDER BY  TK_CODPAR DESC"
      ds = oAdmLocal.AbrirDataset(sSQL)

      With ds.Tables(0)
         For Each row As DataRow In .Rows
            cboCodParRdo.Items.Add(New Prex.Utils.Entities.clsItem(row("TK_CODPAR"), row("TK_CODPAR") & " - " & row("TK_DESCRI")))
         Next
      End With

      ds = Nothing

      cboCodParRdo.Text = "<Seleccione una partida...>"

   End Sub

   Private Sub presentarRdo()

      Dim sSQL As String
      Dim ds As DataSet
      Dim item As ListViewItem
      Dim nMin As Double = 0
      Dim nMax As Double = 0

      Try

         oProcesando = New frmProcesando
         oProcesando.MensajeProceso("Cargando partidas...")
         oProcesando.Show(Me)
         Application.DoEvents()

         Me.Enabled = False

         'Rangos
         sSQL = "SELECT    TG_NUME01, TG_NUME02 " & _
                "FROM      TABGEN " & _
                "WHERE     TG_CODTAB = 8 " & _
                "AND       TG_CODCON = 3 "
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)
            If .Rows.Count > 0 Then
               nMin = .Rows(0).Item("TG_NUME01")
               nMax = .Rows(0).Item("TG_NUME02")
            End If
         End With

         ds = Nothing

         'NO
         sSQL = "SELECT    DISTINCT TK_CODPAR, TK_DESCRI, TK_CAMPO8 " & _
                "FROM      TABPAR " & _
                "LEFT JOIN RELRDO " & _
                "ON        TABPAR.TK_CODPAR = RELRDO.RO_CODPAR " & _
                "AND       TABPAR.TK_CAMPO8 = RELRDO.RO_CAMPO8 " & _
                "AND       TABPAR.TK_CODENT = RELRDO.RO_CODENT " & _
                "AND       TABPAR.TK_FECVIG = RELRDO.RO_FECVIG " & _
                "WHERE     TK_CODENT = " & CODIGO_ENTIDAD & " " & _
                "AND       TK_FECVIG = " & FechaSQL(LlaveCombo(cboFecVigRdo)) & " " & _
                "AND       TK_ACTIVA= 1 " & _
                "AND       TK_NIVELTAB=0 " & _
                "AND       TK_CUADRO < 3 " & _
                "AND       TK_CODPAR < " & nMin & " " & _
                "AND       RO_CODRDO Is Null " & _
                "ORDER BY  TK_CODPAR ASC"
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)
            For Each row As DataRow In .Rows
               item = lvNoRdo.Items.Add(row("TK_CODPAR") & " - " & row("TK_CAMPO8") & " - " & row("TK_DESCRI").ToString.Trim)
               item.Name = row("TK_CODPAR") & "K" & row("TK_CAMPO8")
            Next
         End With

         ds = Nothing

         'SI
         sSQL = "SELECT    DISTINCT TK_CODPAR, TK_DESCRI, TK_CAMPO8 " & _
                "FROM      TABPAR " & _
                "LEFT JOIN RELRDO " & _
                "ON        TABPAR.TK_CODPAR = RELRDO.RO_CODPAR " & _
                "AND       TABPAR.TK_CAMPO8 = RELRDO.RO_CAMPO8 " & _
                "AND       TABPAR.TK_CODENT = RELRDO.RO_CODENT " & _
                "AND       TABPAR.TK_FECVIG = RELRDO.RO_FECVIG " & _
                "WHERE     TK_CODENT = " & CODIGO_ENTIDAD & " " & _
                "AND       TK_FECVIG = " & FechaSQL(LlaveCombo(cboFecVigRdo)) & " " & _
                "AND       TK_CODPAR < " & nMin & " " & _
                "AND       TK_NIVELTAB = 0 " & _
                "AND       TK_CUADRO < 3 " & _
                "AND       RO_CODRDO = " & LlaveCombo(cboCodParRdo) & " " & _
                "AND       RO_CODRDO Is Not Null " & _
                "ORDER BY  TK_CODPAR ASC"
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)
            For Each row As DataRow In .Rows
               item = lvSiRdo.Items.Add(row("TK_CODPAR") & " - " & row("TK_CAMPO8") & " - " & row("TK_DESCRI").ToString.Trim)
               item.Name = row("TK_CODPAR") & "K" & row("TK_CAMPO8")
            Next
         End With

         ds = Nothing

         cboFecVigRdo.Enabled = False
         cboCodParRdo.Enabled = False
         btnPresentarRdo.Enabled = False
         btnLimpiarRdo.Enabled = True

         cmdSiUnoRdo.Enabled = lvNoRdo.Items.Count + lvSiRdo.Items.Count > 0
         cmdNoUnoRdo.Enabled = lvNoRdo.Items.Count + lvSiRdo.Items.Count > 0
         cmdSiTodosRdo.Enabled = lvNoRdo.Items.Count + lvSiRdo.Items.Count > 0
         cmdNoTodosRdo.Enabled = lvNoRdo.Items.Count + lvSiRdo.Items.Count > 0
         cmdGuardarRdo.Enabled = True
         cmdCancelarRdo.Enabled = True

         oProcesando.Close()

      Catch ex As Exception
         oProcesando.Close()
         TratarError(ex, "presentarFuentes")
      End Try

      Me.Enabled = True
      oProcesando = Nothing
      Me.Focus()

   End Sub

   Private Sub btnPresentarRdo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPresentarRdo.Click

      If (cboFecVigRdo.SelectedItem Is Nothing) Or (cboCodParRdo.SelectedItem Is Nothing) Then
         MensajeError("Debe seleccionar un período y una partida")
      Else
         presentarRdo()
      End If

   End Sub

   Private Sub btnLimpiarRdo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarRdo.Click
      cargarTabRdo()
   End Sub

   Private Sub cmdCancelarRdo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelarRdo.Click
      cargarTabRdo()
   End Sub

   Private Sub cmdGuardarRdo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardarRdo.Click
      guardarRdo()
   End Sub

   Private Sub guardarRdo()

      Dim ds As DataSet
      Dim cb As OleDb.OleDbCommandBuilder
      Dim da As OleDb.OleDbDataAdapter = Nothing
      Dim sSQL As String
      Dim row As DataRow
      Dim sDato() As String

      Try

         oProcesando = New frmProcesando
         oProcesando.MensajeProceso("Guardando relaciones Cuentas-Partidas...")
         oProcesando.Show(Me)
         Application.DoEvents()

         Me.Enabled = False

         sSQL = "DELETE " & _
                "FROM      RELRDO " & _
                "WHERE     RO_FECVIG = " & FechaSQL(LlaveCombo(cboFecVigRdo)) & " " & _
                "AND       RO_CODENT = " & CODIGO_ENTIDAD & " " & _
                "AND       RO_CODRDO = " & LlaveCombo(cboCodParRdo)
         oAdmLocal.EjecutarComandoSQL(sSQL)

         For Each item As ListViewItem In lvSiRdo.Items

            sDato = item.Name.Split("K")

            sSQL = "SELECT    * " & _
                   "FROM      RELRDO " & _
                   "WHERE     RO_FECVIG=" & FechaSQL(LlaveCombo(cboFecVigRdo)) & " " & _
                   "AND       RO_CODENT=" & CODIGO_ENTIDAD & " " & _
                   "AND       RO_CODPAR=" & item.Name.Substring(0, item.Name.IndexOf("K")) & " " & _
                   "AND       RO_CODRDO=" & LlaveCombo(cboCodParRdo) & " " & _
                   "AND       RO_CAMPO8=" & item.Name.Substring(item.Name.IndexOf("K") + 1)
            ds = oAdmLocal.AbrirDataset(sSQL, da)
            cb = New OleDb.OleDbCommandBuilder(da)

            With ds.Tables(0)

               row = .NewRow

               row("RO_FECVIG") = LlaveCombo(cboFecVigRdo)
               row("RO_CODENT") = CODIGO_ENTIDAD
               row("RO_CODPAR") = item.Name.Substring(0, item.Name.IndexOf("K"))
               row("RO_CODRDO") = LlaveCombo(cboCodParRdo)
               row("RO_CAMPO8") = item.Name.Substring(item.Name.IndexOf("K") + 1)

               .Rows.Add(row)

            End With

            da.Update(ds)
            ds.AcceptChanges()

            ds = Nothing
            da = Nothing

         Next

         bGuardar = True
         MensajeInformacion("Relación de fuentes de datos guardada exitosamente")
         oProcesando.Close()

      Catch ex As Exception
         oProcesando.Close()
         TratarError(ex, "guardarRel")
      End Try

      Me.Enabled = True
      oProcesando = Nothing
      Me.Focus()

   End Sub

   Private Sub cmdSiUnoRdo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSiUnoRdo.Click

      Dim item As ListViewItem = Nothing

      item = lvNoRdo.FocusedItem

      If Not (item Is Nothing) Then
         lvNoRdo.Items.Remove(item)
         lvSiRdo.Items.Add(item)
      End If

   End Sub

   Private Sub cmdNoUnoRdo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNoUnoRdo.Click

      Dim item As ListViewItem = Nothing

      item = lvSiRdo.FocusedItem

      If Not (item Is Nothing) Then
         lvSiRdo.Items.Remove(item)
         lvNoRdo.Items.Add(item)
      End If

   End Sub

   Private Sub cmdSiTodosRdo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSiTodosRdo.Click

      For Each item As ListViewItem In lvNoRdo.Items
         lvNoRdo.Items.Remove(item)
         lvSiRdo.Items.Add(item)
      Next

   End Sub

   Private Sub cmdNoTodosRdo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNoTodosRdo.Click

      For Each item As ListViewItem In lvSiRdo.Items
         lvSiRdo.Items.Remove(item)
         lvNoRdo.Items.Add(item)
      Next

   End Sub

   Private Sub cargarTabRelTec()

      Dim sSQL As String
      Dim ds As DataSet

      cboFecVigRelTec.Items.Clear()

      sSQL = "SELECT    DISTINCT TK_FECVIG " & _
             "FROM      TABPAR " & _
             "WHERE     TK_CODENT = " & CODIGO_ENTIDAD & " " & _
             "AND       TK_ACTIVA = 1 " & _
             "ORDER BY  TK_FECVIG DESC"
      ds = oAdmLocal.AbrirDataset(sSQL)

      With ds.Tables(0)
         For Each row As DataRow In .Rows
            cboFecVigRelTec.Items.Add(New Prex.Utils.Entities.clsItem(row("TK_FECVIG"), row("TK_FECVIG")))
         Next
      End With

      ds = Nothing

      If cboFecVigRelTec.Items.Count > 0 Then
         cboFecVigRelTec.SelectedIndex = 0
      End If

      GridRelTec.DataSource = Nothing
      GridRelTec.Refresh()
      GridRelTec.RefreshDataSource()

      cboFecVigRelTec.Enabled = True
      btnPresentarRelTec.Enabled = True
      btnLimpiarRelTec.Enabled = False
      btnNuevaRelTec.Enabled = False
      btnModifRelTec.Enabled = False
      btnEliminarRelTec.Enabled = False
      btnImprimirRelTec.Enabled = False
      btnExportarRelTec.Enabled = False

   End Sub

   Public Sub PresentarRelTec()

      Dim sSQL As String
      Dim ds As DataSet

      Try

         sSQL = "SELECT       RELTEC.*, ENTIDA.TG_DESCRI AS XX_ENTIDA, CUADRO.TG_DESCRI AS XX_CUADRO " & _
                "FROM         RELTEC " & _
                "INNER JOIN   TABGEN ENTIDA " & _
                "ON           RT_CODENT = ENTIDA.TG_CODCON " & _
                "AND          ENTIDA.TG_CODTAB = 1 " & _
                "LEFT JOIN    TABGEN CUADRO " & _
                "ON           RT_CUADRO = CUADRO.TG_CODCON " & _
                "AND          CUADRO.TG_CODTAB = 2 " & _
                "WHERE        RT_CODENT = " & CODIGO_ENTIDAD & " " & _
                "AND          RT_FECVIG = " & FechaSQL(LlaveCombo(cboFecVigRelTec)) & " " & _
                "ORDER BY     RT_FECVIG, ENTIDA.TG_DESCRI, CUADRO.TG_DESCRI"
         ds = oAdmLocal.AbrirDataset(sSQL)

         GridRelTec.DataSource = ds.Tables(0)
         GridRelTec.Refresh()
         GridRelTec.RefreshDataSource()

         cboFecVigRelTec.Enabled = False
         btnPresentarRelTec.Enabled = False
         btnLimpiarRelTec.Enabled = True

         btnNuevaRelTec.Enabled = True
         btnModifRelTec.Enabled = gRelTec.RowCount > 0
         btnEliminarRelTec.Enabled = gRelTec.RowCount > 0
         btnImprimirRelTec.Enabled = gRelTec.RowCount > 0
         btnExportarRelTec.Enabled = gRelTec.RowCount > 0

      Catch ex As Exception
         TratarError(ex, "PresentarRelTec")
      End Try

   End Sub

   Private Sub btnPresentarRelTec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPresentarRelTec.Click

      If cboFecVigRelTec.SelectedItem Is Nothing Then
         MensajeError("Debe especificar una fecha de vigencia")
         cboFecVigRelTec.Focus()
      Else
         PresentarRelTec()
      End If

   End Sub

   Private Sub btnLimpiarRelTec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarRelTec.Click

      cargarTabRelTec()

   End Sub

   Private Sub btnNuevaRelTec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaRelTec.Click

      Dim oForm As New frmAbmRelTec

      If oForm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
         PresentarRelTec()
      End If

      oForm = Nothing

   End Sub

   Private Sub btnModifRelTec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifRelTec.Click

      Dim oForm As New frmAbmRelTec

      oForm.PasarDatos(ValGrilla(gRelTec, "RT_FECVIG"), _
                       ValGrilla(gRelTec, "RT_CODENT"), _
                       ValGrilla(gRelTec, "RT_CUADRO"), _
                       ValGrilla(gRelTec, "RT_CODPAR"), _
                       ValGrilla(gRelTec, "RT_CODRTC"), _
                       ValGrilla(gRelTec, "RT_EOAFNG"))

      If oForm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
         PresentarRelTec()
      End If

      oForm = Nothing

   End Sub

   Private Sub btnEliminarRelTec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarRelTec.Click

      Dim oForm As New frmAbmRelTec

      oForm.PasarDatos(ValGrilla(gRelTec, "RT_FECVIG"), _
                       ValGrilla(gRelTec, "RT_CODENT"), _
                       ValGrilla(gRelTec, "RT_CUADRO"), _
                       ValGrilla(gRelTec, "RT_CODPAR"), _
                       ValGrilla(gRelTec, "RT_CODRTC"), _
                       ValGrilla(gRelTec, "RT_EOAFNG"), _
                       True)

      If oForm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
         PresentarRelTec()
      End If

      oForm = Nothing

   End Sub

   Private Sub GridRelTec_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridRelTec.DoubleClick

      If gRelTec.SelectedRowsCount = 1 Then
         btnModifRelTec_Click(sender, e)
      End If

   End Sub

   Private Sub btnImprimirRelTec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirRelTec.Click

      GridRelTec.ShowPrintPreview()

   End Sub

   Private Sub btnExportarRelTec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarRelTec.Click

      Dim oExp As New frmExportar

      oExp.PasarViewResultados("Relaciones Técnicas", "Relaciones Técnicas", gRelTec)
      oExp.ShowDialog(Me)
      oExp = Nothing

   End Sub

   Private Sub SincPartidas(ByVal dFecPro As Date, ByVal nCodEnt As Long, ByVal sUsuario As String)

      Dim sSQL As String
      Dim sError As String = ""

      oProcesando = New frmProcesando
      oProcesando.MensajeProceso("Sincronizando...")
      oProcesando.Show(Me)
      Application.DoEvents()

      Me.Enabled = False

      sSQL = "P_SincPartidas " & FechaSQL(dFecPro) & ", " & _
                                 nCodEnt.ToString & ", " & _
                                 "'" & sUsuario & "'"

      If Not oAdmLocal.EjecutarComandoAsincrono(sSQL, sError) Then
         MensajeError(sError)
      End If

      oProcesando.Close()
      oProcesando = Nothing

   End Sub

End Class
