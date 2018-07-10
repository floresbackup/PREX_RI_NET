Public Class frmMain

    Public ps1 = New DevExpress.XtraPrinting.PrintingSystem
    Public ErrorPermiso As Boolean = False
    Private oAdmTablas As New AdmTablas

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oAdmTablas.ConnectionString = CONN_LOCAL

        AnalizarCommand()


        txtDesde.DateTime = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        txtHasta.DateTime = DateTime.Today

        Habilitar(False)

    End Sub

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
                ds = oAdmTablas.AbrirDataset(sSQL)

                With ds.Tables(0)

                    If .Rows.Count = 0 Then
                        Throw New Security.SecurityException("Falla de seguridad")
                    Else
                        UsuarioActual.Codigo = nCodigoUsuario
                        UsuarioActual.Nombre = .Rows(0).Item("US_NOMBRE")
                        UsuarioActual.Descripcion = .Rows(0).Item("US_DESCRI")
                        UsuarioActual.Admin = .Rows(0).Item("US_ADMIN")
                        UsuarioActual.SoloLectura = False
                        'lblUsuario.Text = UsuarioActual.Descripcion
                    End If

                End With

                ds = Nothing

                ''''' ENTIDAD '''''

                sSQL = "SELECT    TG_CODCON, TG_DESCRI " &
                "FROM      TABGEN " &
                "WHERE     TG_CODTAB = 1 " &
                "AND       TG_CODCON = " & nCodigoEntidad
                ds = oAdmTablas.AbrirDataset(sSQL)

                With ds.Tables(0)

                    If .Rows.Count = 0 Then
                        Throw New Security.SecurityException("Parámetro de entidad no válido")
                    Else
                        NOMBRE_ENTIDAD = .Rows(0).Item("TG_DESCRI")
                        'lblEntidad.Text = NOMBRE_ENTIDAD
                    End If

                End With

                ds = Nothing

                ''''' TRANSACCION '''''

                sSQL = "SELECT    MU_TRANSA, MU_DESCRI " &
                "FROM      MENUES " &
                "WHERE     MU_CODTRA = " & nCodigoTransaccion
                ds = oAdmTablas.AbrirDataset(sSQL)

                With ds.Tables(0)


                    If .Rows.Count = 0 Then
                        Throw New Security.SecurityException("Error en la línea de comandos. Parámetro de transacción incorrecto")
                    Else
                        'lblTransaccion.Text = nCodigoTransaccion.ToString & " - " & .Rows(0).Item("MU_TRANSA")
                        Me.Text = nCodigoTransaccion.ToString & " - " & .Rows(0).Item("MU_TRANSA")
                    End If

                End With

                ds = Nothing

                'lblVersion.Text = "Versión: " & Application.ProductVersion
                'Me.Text = lblTransaccion.Text

            Catch ex As Security.SecurityException
                MensajeError(ex.Message)
                ErrorPermiso = True
            End Try
        Catch ex As Exception
            TratarError(ex, "PresentarDatos")
            ErrorPermiso = True
        End Try

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblTitulo.Text = Me.Text
        lblSubtitulo.Text = "Realice consultas sobre el log del sistema"
        txtDesde.Focus()
    End Sub

    Private Sub frmMain_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        GridDiseno.Height = Me.Height - 100
    End Sub

    Private Sub btnNuevaConsulta_Click(sender As Object, e As EventArgs) Handles btnNuevaConsulta.Click
        GridDiseno.DataSource = Nothing
        GridDiseno.RefreshDataSource()
        GridDiseno.Refresh()

        Habilitar(False)
        txtDesde.Focus()

    End Sub


    Private Sub Habilitar(ByVal bHab As Boolean)


        txtDesde.Enabled = Not bHab
        txtHasta.Enabled = Not bHab
        txtDescripcion.Enabled = Not bHab
        txtUsuario.Enabled = Not bHab
        txtAcciones.Enabled = Not bHab
        txtCodigosTransaccion.Enabled = Not bHab
        cmdConsultar.Enabled = Not bHab
        cmdBuscarAcciones.Enabled = Not bHab

        ToolBarra.Enabled = bHab

        If oAdmTablas.ExisteTabla("TXTADJ") AndAlso False Then
            btnVerAdjunto.Visible = bHab
            btnVerAdjunto.Enabled = bHab
        Else
            btnVerAdjunto.Visible = False
            btnVerAdjunto.Enabled = False
        End If

    End Sub


    Private Function Validar() As Boolean

        If Not IsDate(txtDesde.Text) Then
            MensajeError("Fecha no válida")
            txtDesde.Focus()
            Exit Function
        End If

        If Not IsDate(txtHasta.Text) Then
            MensajeError("Fecha no válida")
            txtHasta.Focus()
            Exit Function
        End If

        Return True

    End Function


    Private Function ConformarSQL() As String



        'MODIFICADO EL 11/05/2011 POR COMPTIBILIDAD CON SQL 2005
        'sSQL = "SELECT    US_DESCRI, LS_FECLOG, LS_HORLOG, LS_CODTRA, MU_TRANSA, TG_DESCRI, LS_EXTRA " & _
        '       "FROM      LOGSIS, USUARI, MENUES, TABGEN " & _
        '       "WHERE     LS_CODUSU = US_CODUSU " & _
        '       "AND       LS_CODTRA = MU_CODTRA " & _
        '       "AND       LS_ACCION = TG_CODCON " & _
        '       "AND       TG_CODTAB = 301 " & _
        '       "AND       LS_FECLOG BETWEEN " & FechaSQL(CDate(txtDesde)) & " AND " & FechaSQL(CDate(txtHasta)) & " "

        Dim sSQL = "SELECT     LS_SECUEN, US_DESCRI, LS_WKSTAT, LS_FECLOG, LS_HORLOG, CASE WHEN LS_CODTRA < 0 THEN 0 ELSE LS_CODTRA END AS LS_CODTRA, MU_TRANSA, TG_DESCRI, LS_EXTRA " &
          "FROM       LOGSIS " &
          "INNER JOIN USUARI " &
          "ON         LS_CODUSU = US_CODUSU " &
          "LEFT JOIN  MENUES  " &
          "ON         LS_CODTRA = MU_CODTRA " &
          "AND        0 <> MU_CODTRA " &
          "LEFT JOIN TABGEN " &
          "ON         LS_ACCION = TG_CODCON " &
          "AND        TG_CODTAB = 301 " &
          "WHERE      LS_FECLOG BETWEEN " & FechaSQL(txtDesde.DateTime) & " AND " & FechaSQL(txtHasta.DateTime) & " "


        If Trim(txtAcciones.Text) <> "" Then

            If InStr(1, Trim(txtAcciones.Text), ",") > 0 Then
                sSQL = sSQL &
                "AND    LS_ACCION IN (" & Trim(txtAcciones.Text) & ") "
            Else
                sSQL = sSQL &
                "AND    LS_ACCION = " & Trim(txtAcciones.Text) & " "
            End If

        End If

        If Trim(txtCodigosTransaccion.Text) <> "" Then

            If InStr(1, Trim(txtCodigosTransaccion.Text), ",") > 0 Then
                sSQL = sSQL &
                "AND    LS_CODTRA IN (" & Trim(txtCodigosTransaccion.Text) & ") "
            Else
                sSQL = sSQL &
                "AND    LS_CODTRA = " & Trim(txtCodigosTransaccion.Text) & " "
            End If

        End If

        If Trim(txtDescripcion.Text) <> "" Then

            sSQL = sSQL &
             "AND    MU_TRANSA LIKE '%" & Trim(txtDescripcion.Text) & "%' "

        End If

        If Trim(txtUsuario.Text) <> "" Then

            sSQL = sSQL &
             "AND    US_DESCRI LIKE '%" & Trim(txtUsuario.Text) & "%' "

        End If

        sSQL = sSQL &
          "ORDER BY  LS_FECLOG, LS_HORLOG, US_DESCRI"

        Return sSQL

    End Function


    Private Sub Actualizar()
        Try
            Me.Cursor = Cursors.WaitCursor
            Try

                Dim sSQL = ConformarSQL()


                Dim ds = oAdmTablas.AbrirDataset(sSQL)

                If ds.Tables(0).Rows.Count > 0 Then
                    GridDiseno.DataSource = ds.Tables(0)
                Else
                    GridDiseno.DataSource = Nothing
                End If

                GridDiseno.RefreshDataSource()
                GridDiseno.Refresh()

                If gDiseno.RowCount > 0 Then
                    Habilitar(True)
                Else
                    MensajeError("No se han encontrado resultados según el criterio de búsqueda utilizado")
                End If

            Catch ex As Exception
                TratarError(ex, "Actualizar")
            End Try

        Finally
            GuardarLOG(AccionesLOG.Consulta_LOG, GetTextoLog(), CODIGO_TRANSACCION, UsuarioActual.Codigo)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function GetTextoLog() As String
        Dim filtros = "Fecha desde: " & txtDesde.Text & "; Fecha Hasta: " & txtHasta.Text

        If Trim(txtAcciones.Text) <> "" Then
            filtros = filtros & "; Acciones: " & txtAcciones.Text
        End If

        If Trim(txtCodigosTransaccion.Text) <> "" Then
            filtros = filtros & "; Códigos de Trans.: " & txtCodigosTransaccion.Text
        End If

        If Trim(txtDescripcion.Text) <> "" Then
            filtros = filtros & "; Descripción de trans. contiene: " & txtDescripcion.Text
        End If

        If Trim(txtUsuario.Text) <> "" Then
            filtros = filtros & "; Nombre Usuario Contiene: " & txtUsuario.Text
        End If

        Return filtros
    End Function

    Private Sub cmdBuscarAcciones_Click(sender As Object, e As EventArgs) Handles cmdBuscarAcciones.Click

        Dim sSQL As String
        Dim oTG As New frmTablaGeneral

        sSQL = "SELECT    TG_CODCON, TG_DESCRI " &
               "FROM      TABGEN " &
               "WHERE     TG_CODTAB = 301 " &
               "AND       TG_CODCON <> 999999"

        'BuscadorTablaGeneral(CONN_LOCAL,
        '                          sSQL,
        '                          txtAcciones,
        '                          True,
        '                          TGL_ACCIONES_LOG,
        '                          "Acciones del LOG")

        oTG.PasarInfo(sSQL, CONN_LOCAL, 1, True, "Acciones del LOG")

        If oTG.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            txtAcciones.Text = INPUT_GENERAL
        End If

        oTG = Nothing

    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        If Validar() Then
            Actualizar()
        End If
    End Sub

    Private Sub btnVerAdjunto_Click(sender As Object, e As EventArgs) Handles btnVerAdjunto.Click
        Dim frmAdjuntar As New frmAdjuntos
        frmAdjuntar.PasarDatos(txtDesde.DateTime.Year * 10000 + txtDesde.DateTime.Month * 100 + txtDesde.DateTime.Day, txtHasta.DateTime.Year * 10000 + txtHasta.DateTime.Month * 100 + txtHasta.DateTime.Day)
        frmAdjuntar.ShowDialog(Me)
        frmAdjuntar = Nothing
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        VistaPrevia(Me.lblTitulo.Text)

    End Sub

    Private Sub VistaPrevia(ByVal sTitulo As String)
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim pl As New DevExpress.XtraPrinting.PrintableComponentLink
            Dim phf As DevExpress.XtraPrinting.PageHeaderFooter
            Dim Period As String

            Period = Format(DateTime.Today, "dd-MM-yyyy")

            pl.Component = GridDiseno
            ps1.Links.Add(pl)
            phf = pl.PageHeaderFooter

            phf.Header.Font = New Font("Tahoma", 10, FontStyle.Bold)
            phf.Header.LineAlignment = DevExpress.XtraPrinting.BrickAlignment.Center

            phf.Header.Content.Clear()
            phf.Header.Content.Add(sTitulo)

            phf.Footer.Font = New Font("Tahoma", 8, FontStyle.Bold)
            phf.Footer.LineAlignment = DevExpress.XtraPrinting.BrickAlignment.Center

            phf.Footer.Content.Clear()
            phf.Footer.Content.Add("Fecha: " & Period)

            pl.CreateDocument()
            pl.ShowPreview()

        Finally
            Me.Cursor = Cursors.Default
            GuardarLOG(AccionesLOG.Impresión_LOG, "Fecha desde: " & txtDesde.Text & "; Fecha Hasta: " & txtHasta.Text & "; Nombre Usuario Contiene: " & Trim(txtUsuario.Text), CODIGO_TRANSACCION, UsuarioActual.Codigo)
        End Try
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        frmExportar.PasarViewResultados(Me.Text, Me.lblTitulo.Text, gDiseno)
        frmExportar.ShowDialog()
        GuardarLOG(AccionesLOG.Exportación_LOG, "Fecha desde: " & txtDesde.Text & "; Fecha Hasta: " & txtHasta.Text & "; Nombre Usuario Contiene: " & Trim(txtUsuario.Text), CODIGO_TRANSACCION, UsuarioActual.Codigo)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        gDiseno.CopyToClipboard()
        GuardarLOG(AccionesLOG.Copia_LOG, "Fecha desde: " & txtDesde.Text & "; Fecha Hasta: " & txtHasta.Text & "; Nombre Usuario Contiene: " & Trim(txtUsuario.Text), CODIGO_TRANSACCION, UsuarioActual.Codigo)
        MessageBox.Show(Me, "Se han copiado los resultados al portapapeles", "Copiar", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub txtAcciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAcciones.KeyPress
        If IsNumeric(e.KeyChar) OrElse e.KeyChar = "," OrElse e.KeyChar = vbBack Then
            Exit Sub
        Else
            e.KeyChar = ""
        End If
    End Sub
End Class

