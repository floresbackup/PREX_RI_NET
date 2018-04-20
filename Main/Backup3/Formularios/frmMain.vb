Imports DevExpress.XtraGrid.Views.Base
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Xpo

Public Class frmMain

   Private oAdmLocal As New AdmTablas

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
         ds = oAdmlocal.AbrirDataset(sSQL)

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
         ds = oAdmlocal.AbrirDataset(sSQL)

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
         ds = oAdmlocal.AbrirDataset(sSQL)

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
      cargarTablas()

      limpiar()

   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
      Me.Close()
   End Sub

   Private Sub cargarTablas()

      Dim sSQL As String
      Dim ds As DataSet

      Try

         sSQL = "SELECT       TG_CODTAB, CAST(TG_CODTAB AS VARCHAR) + ' - ' + TG_DESCRI AS TG_DESCRI, TG_ALFA02 " & _
                "FROM         TABGEN " & _
                "WHERE        TG_CODCON = 999999 " & _
                "ORDER BY     TG_CODTAB "
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)
            For Each row As DataRow In .Rows
               cboTabla.Items.Add(New clsItem.Item(row(0), row(1), "" & row(2)))
            Next
         End With

         ds = Nothing

      Catch ex As Exception
         TratarError(ex, "cargarTablas")
      End Try

   End Sub

   Private Sub cboTabla_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTabla.SelectedIndexChanged
      cboTabla.ToolTipText = cboTabla.Text
   End Sub

   Private Sub btnPresentar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPresentar.Click

      If Not (cboTabla.SelectedItem Is Nothing) Then

         Dim item As clsItem.Item

         item = cboTabla.SelectedItem
         presentarTabla(item.Valor)

      End If

   End Sub

   Private Sub presentarTabla(ByVal nCodigoTabla As Long)

      Dim sSQL As String
      Dim ds As New DataSet

      sSQL = "SELECT       * " & _
             "FROM         TABGEN " & _
             "WHERE        TG_CODTAB = " & nCodigoTabla & " " & _
             "AND          TG_CODCON <> 999999 " & _
             "ORDER BY     TG_CODCON "
      ds = oAdmLocal.AbrirDataset(sSQL)

      GridTG.DataSource = ds.Tables(0)
      GridTG.RefreshDataSource()
      GridTG.Refresh()

      verificarColumnas(nCodigoTabla)

      habilitar(False)

   End Sub

   Private Sub verificarColumnas(ByVal nCodigoTabla As Long)

      Dim View As ColumnView = GridTG.MainView
      Dim Column As DevExpress.XtraGrid.Columns.GridColumn
      Dim sSQL As String
      Dim ds As New DataSet
      Dim sCadena As String = ""
      Dim nC As Integer = 0

      sSQL = "SELECT       * " & _
             "FROM         TABGEN " & _
             "WHERE        TG_CODTAB = " & nCodigoTabla & " " & _
             "AND          TG_CODCON = 999999 " & _
             "ORDER BY     TG_CODCON "
      ds = oAdmLocal.AbrirDataset(sSQL)

      If ds.Tables(0).Rows.Count > 0 Then
         If ds.Tables(0).Rows(0).Item("TG_ALFA02").ToString.Trim <> "" Then
            sCadena = ds.Tables(0).Rows(0).Item("TG_ALFA02").ToString.Trim
            For Each sCol As String In sCadena.Split("|")

               If View.Columns.Count >= nC Then

                  Column = View.Columns(nC)
                  Column.Caption = sCol
                  Column.Visible = sCol.Trim <> ""
                  Column.Width = Column.GetBestWidth

               End If

               nC = nC + 1
            Next
         End If
      End If

   End Sub

   Private Sub habilitar(ByVal bHabilita As Boolean)

      cboTabla.Enabled = bHabilita
      btnPresentar.Enabled = bHabilita
      btnLimpiar.Enabled = Not bHabilita
      btnNuevaTabla.Enabled = bHabilita
      btnParamTabla.Enabled = Not bHabilita
      btnNuevoReg.Enabled = Not bHabilita
      btnEditarReg.Enabled = Not bHabilita
      btnEliminarReg.Enabled = Not bHabilita

   End Sub

   Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
      limpiar()
   End Sub

   Private Sub limpiar()

      Dim View As ColumnView = GridTG.MainView

      GridTG.DataSource = Nothing
      GridTG.RefreshDataSource()
      GridTG.Refresh()

      View.Columns.Clear()

      habilitar(True)

   End Sub

End Class
