﻿Imports System.Data.SqlClient
Imports System.Text
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports Prex.Utils

Public Class frmMain
    Public ErrorPermiso As Boolean = False
    Private tCabSys As CabSys
    Private tVarSys As List(Of VarSys)
    Private tProcesosPrevios As List(Of ProSys)
    Private tGraficos As List(Of SysGra)

    Private oDetSys As List(Of DetSys)
    Private cmSql As ScintillaNET.Scintilla

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        AnalizarCommand()

        cmSql = New ScintillaNET.Scintilla()
        tabPageQuery.Controls.Add(cmSql)
        cmSql.Dock = DockStyle.Fill
        Prex.Utils.Misc.Forms.ScintillaSQL.InitialiseScintilla(cmSql)
        AddHandler cmSql.TextChanged, AddressOf cmSQL_Change
    End Sub

    '#Region "Metodos"
    Public Sub AnalizarCommand()

        Try

            Dim sTemp As String
            Dim nPos As Integer
            Dim nPosAux As Integer
            Dim nCodigoUsuario As Long
            Dim nCodigoTransaccion As Long
            Dim nCodigoEntidad As Long

            sTemp = Command()

            '''''' USUARIO ''''''

            nPos = InStr(1, UCase(sTemp), "/U:")

            If nPos = 0 Then
                MensajesForms.MostrarError("Los argumentos de la línea de comandos no son válidos")
                Exit Sub
            End If

            nPosAux = InStr(1, Mid(sTemp, nPos + 3), "/")

            If nPosAux > 0 Then
                nCodigoUsuario = Val(Mid(sTemp, nPos + 3, nPosAux - 1))
            Else
                nCodigoUsuario = Val(Mid(sTemp, nPos + 3))
            End If

            '''''' TRANSACCION ''''''

            nPos = InStr(1, UCase(sTemp), "/T:")

            If nPos = 0 Then
                MensajesForms.MostrarError("Los argumentos de la línea de comandos no son válidos")
                Exit Sub
            End If

            nPosAux = InStr(1, Mid(sTemp, nPos + 3), "/")

            If nPosAux > 0 Then
                nCodigoTransaccion = Val(Mid(sTemp, nPos + 3, nPosAux - 1))
            Else
                nCodigoTransaccion = Val(Mid(sTemp, nPos + 3))
            End If

            '''''' ENTIDAD ''''''

            nPos = InStr(1, UCase(sTemp), "/E:")

            If nPos = 0 Then
                MensajesForms.MostrarError("Los argumentos de la línea de comandos no son válidos")
                Exit Sub
            End If

            nPosAux = InStr(1, Mid(sTemp, nPos + 3), "/")

            If nPosAux > 0 Then
                nCodigoEntidad = Val(Mid(sTemp, nPos + 3, nPosAux - 1))
            Else
                nCodigoEntidad = Val(Mid(sTemp, nPos + 3))
            End If

            Configuration.PrexConfig.CODIGO_TRANSACCION = nCodigoTransaccion
            Configuration.PrexConfig.CODIGO_ENTIDAD = nCodigoEntidad

            PresentarDatos(nCodigoTransaccion, nCodigoUsuario, nCodigoEntidad)

        Catch ex As Exception
            ManejarErrores.TratarError(ex, "AnalizarCommand")
        End Try
    End Sub

    Private Sub PresentarDatos(ByVal nCodigoTransaccion As Long, ByVal nCodigoUsuario As Long, ByVal nCodigoEntidad As Long)
        Try
            Dim sError = String.Empty
            ''''' USUARIO '''''
            Dim sSQL = "SELECT    US_CODUSU, US_NOMBRE, US_DESCRI " &
                        "FROM      USUARI " &
                        "WHERE     US_CODUSU = " & nCodigoUsuario
            Dim rstAux As SqlDataReader = DataAccess.GetReader(sSQL)

            If rstAux.RecordsAffected = 0 OrElse rstAux.RecordsAffected > 1 Then
                sError = "Falla de seguridad"
            End If

            While rstAux.Read()
                Configuration.PrexConfig.UsuarioActual.Codigo = nCodigoUsuario
                Configuration.PrexConfig.UsuarioActual.Nombre = rstAux("US_NOMBRE").ToString()
                Configuration.PrexConfig.UsuarioActual.Descripcion = rstAux("US_DESCRI").ToString()
                Configuration.PrexConfig.UsuarioActual.SoloLectura = False
                lblUsuario.Text = Configuration.PrexConfig.UsuarioActual.Descripcion
            End While
            rstAux.Close()


            ''''' ENTIDAD '''''
            sSQL = "SELECT    TG_CODCON, TG_DESCRI " &
          "FROM      TABGEN " &
          "WHERE     TG_CODTAB = " & EnumTablasGenerales.TGL_Entidades & " " &
          "AND       TG_CODCON = " & nCodigoEntidad

            rstAux = DataAccess.GetReader(sSQL)

            If rstAux.RecordsAffected = 0 OrElse rstAux.RecordsAffected > 1 Then
                sError = "Parámetro de entidad no válido"
            End If

            While rstAux.Read()
                Configuration.PrexConfig.NOMBRE_ENTIDAD = rstAux("TG_DESCRI").ToString()
                lblEntidad.Text = rstAux("TG_DESCRI").ToString()
            End While
            rstAux = Nothing

            ''''' TRANSACCION '''''
            sSQL = "SELECT    MU_TRANSA, MU_DESCRI " &
          "FROM      MENUES " &
          "WHERE     MU_CODTRA = " & nCodigoTransaccion

            rstAux = DataAccess.GetReader(sSQL)

            If rstAux.RecordsAffected = 0 OrElse rstAux.RecordsAffected > 1 Then
                sError = "Error en la línea de comandos. Parámetro de transacción incorrecto"
            End If

            While rstAux.Read()
                Configuration.PrexConfig.CODIGO_TRANSACCION = nCodigoTransaccion
                lblTransaccion.Text = rstAux("MU_DESCRI").ToString()
                Me.Text = "Gestión RI | " & nCodigoTransaccion.ToString & " - " & rstAux("MU_TRANSA").ToString
                lblTitulo.Text = rstAux("MU_TRANSA").ToString
                lblSubtitulo.Text = rstAux.Item("MU_DESCRI").ToString
            End While
            rstAux = Nothing

            If sError <> "" Then
                Prex.Utils.MensajesForms.MostrarError(sError)
            End If


        Catch ex As Exception
            ManejarErrores.TratarError(ex, "PresentarDatos")
        End Try

    End Sub

    Private Sub NuevaConsulta()
        rowHandle = -99

        tCabSys = New CabSys(Configuration.PrexConfig.CODIGO_ENTIDAD)

        tProcesosPrevios = New List(Of ProSys)
        tGraficos = New List(Of SysGra)
        tVarSys = New List(Of VarSys)
        oDetSys = New List(Of DetSys)

        txtNombreCab.Text = tCabSys.CS_NOMBRE
        txtDescriCab.Text = ""
        txtCodTraCab.Text = ""
        chkAlta.Checked = False
        chkBaja.Checked = False
        chkABM.Checked = False
        chkNDesde.Checked = False
        chkDrillDown.Checked = False
        chkGroup.Checked = False

        cmSql.Text = tCabSys.CS_QUERY
        '
        'txtOrdenVar = ""
        'txtNombreVar = ""
        'txtTituloVar = ""
        'txtTipoVar = ""
        'txtHelpVar = ""
        'txtRutaHelp.Text = ""
        '
        'txtTitulo = ""
        'txtFormat = ""
        'TxtMaxAncho = ""
        '
        'cmHelp.Text = ""
        'txtFormul.Text = ""
        'chkHabili.Value = 1
        'chkVisible.Value = 1
        'lstIntelliSense.Clear
        '
        'cmHelp.Enabled = False
        'lbl(10).Enabled = False
        '
        'CargarCombos

        tabPageFormulario.Select()

    End Sub

#Region "Guardar"

    Private Function VerificacionExistenciaConsulta() As Boolean
        Dim existe = False
        Try
            Dim co = Long.Parse(Prex.Utils.DataAccess.GetScalar("SELECT count(1) FROM CABSYS WHERE CS_CODTRA=" & tCabSys.CS_CODTRA))
            existe = co > 0
        Catch ex As Exception
            Throw New Exception("Verificando si existe consulta", ex)
        End Try
        Try
            If tCabSys.CS_CODCON = 0 Then
                If existe Then
                    Prex.Utils.MensajesForms.MostrarError("El código de transacción ya se encuentra asignado. Especifique otro.")
                    Return False
                End If
                tCabSys.CS_CODCON = Prex.Utils.DataAccess.ProximoID("CABSYS", "CS_CODCON")
                tCabSys.isNew = True
                Return True
            Else
                tCabSys.isNew = False
            End If

        Catch ex As Exception
            Throw New Exception("Obteniendo nuevo código de consulta", ex)
        End Try
        Return True
    End Function

    Private Sub GuardarEncabezado(con As SqlConnection, tran As SqlTransaction)

        Try
            Dim cmd As New SqlCommand("", con, tran)
            If tCabSys.isNew Then

                Dim sSql = "insert into CABSYS (CS_CODCON, CS_CODENT, CS_CODTRA, CS_DESCRI, CS_FECPRO, CS_LAYOUT, "
                sSql += " CS_NOMBRE, CS_QUERY, CS_REPORT, CS_UPDATE, CS_DRILLD, CS_GROUPB, CS_DRIQUE, "
                sSql += " CS_DRIPRE, CS_TABLA, CS_UPDQUE, CS_NDESDE, CS_NDEVAL, CS_HABNDE, CS_BAJA, "
                sSql += " CS_ALTA, CS_ALTQUE, CS_BAJQUE, CS_ALTVAL, CS_MODVAL) "
                sSql += " values (@CS_CODCON, @CS_CODENT, @CS_CODTRA, @CS_DESCRI, @CS_FECPRO, @CS_LAYOUT, "
                sSql += " @CS_NOMBRE, @CS_QUERY, @CS_REPORT, @CS_UPDATE, @CS_DRILLD, @CS_GROUPB, @CS_DRIQUE, "
                sSql += " @CS_DRIPRE, @CS_TABLA, @CS_UPDQUE, @CS_NDESDE, @CS_NDEVAL, @CS_HABNDE, @CS_BAJA, "
                sSql += " @CS_ALTA, @CS_ALTQUE, @CS_BAJQUE, @CS_ALTVAL, @CS_MODVAL) "
                cmd.CommandText = sSql

            Else

                Dim sSql = "update CABSYS set "
                sSql += " CS_CODCON = @CS_CODCON, "
                sSql += " CS_CODENT = @CS_CODENT, "
                sSql += " CS_CODTRA = @CS_CODTRA, "
                sSql += " CS_DESCRI = @CS_DESCRI, "
                sSql += " CS_FECPRO = @CS_FECPRO, "
                sSql += " CS_LAYOUT = @CS_LAYOUT, "
                sSql += " CS_NOMBRE = @CS_NOMBRE, "
                sSql += " CS_QUERY = @CS_QUERY, "
                sSql += " CS_REPORT = @CS_REPORT, "
                sSql += " CS_UPDATE = @CS_UPDATE, "
                sSql += " CS_DRILLD = @CS_DRILLD, "
                sSql += " CS_GROUPB = @CS_GROUPB, "
                sSql += " CS_DRIQUE = @CS_DRIQUE, "
                sSql += " CS_DRIPRE = @CS_DRIPRE, "
                sSql += " CS_TABLA = @CS_TABLA, "
                sSql += " CS_UPDQUE = @CS_UPDQUE, "
                sSql += " CS_NDESDE = @CS_NDESDE, "
                sSql += " CS_NDEVAL = @CS_NDEVAL, "
                sSql += " CS_HABNDE = @CS_HABNDE, "
                sSql += " CS_BAJA = @CS_BAJA, "
                sSql += " CS_ALTA = @CS_ALTA, "
                sSql += " CS_ALTQUE = @CS_ALTQUE, "
                sSql += " CS_BAJQUE = @CS_BAJQUE, "
                sSql += " CS_ALTVAL = @CS_ALTVAL, "
                sSql += " CS_MODVAL = @CS_MODVAL "
                sSql += " WHERE CS_CODCON = @CS_CODCON2"

                cmd.CommandText = sSql
                cmd.Parameters.AddWithValue("CS_CODCON2", tCabSys.CS_CODCON)
            End If

            With cmd.Parameters
                .AddWithValue("CS_CODCON", tCabSys.CS_CODCON)
                .AddWithValue("CS_CODENT", tCabSys.CS_CODENT)
                .AddWithValue("CS_CODTRA", tCabSys.CS_CODTRA)
                .AddWithValue("CS_DESCRI", tCabSys.CS_DESCRI)
                .AddWithValue("CS_FECPRO", tCabSys.CS_FECPRO)
                .AddWithValue("CS_LAYOUT", tCabSys.CS_LAYOUT)
                .AddWithValue("CS_NOMBRE", tCabSys.CS_NOMBRE)
                .AddWithValue("CS_QUERY", Misc.Encoding.Base64Encode(tCabSys.CS_QUERY))
                .AddWithValue("CS_REPORT", tCabSys.CS_REPORT)
                .AddWithValue("CS_UPDATE", IIf(tCabSys.CS_UPDATE, 1, 0))
                .AddWithValue("CS_DRILLD", IIf(tCabSys.CS_DRILLD, 1, 0))
                .AddWithValue("CS_GROUPB", IIf(tCabSys.CS_GROUPB, 1, 0))
                .AddWithValue("CS_DRIQUE", Misc.Encoding.Base64Encode(tCabSys.CS_DRIQUE))
                .AddWithValue("CS_DRIPRE", Misc.Encoding.Base64Encode(tCabSys.CS_DRIPRE))
                .AddWithValue("CS_TABLA", Misc.Encoding.Base64Encode(tCabSys.CS_TABLA))
                .AddWithValue("CS_UPDQUE", Misc.Encoding.Base64Encode(tCabSys.CS_UPDQUE))
                .AddWithValue("CS_NDESDE", Misc.Encoding.Base64Encode(tCabSys.CS_NDESDE))
                .AddWithValue("CS_NDEVAL", Misc.Encoding.Base64Encode(tCabSys.CS_NDEVAL))
                .AddWithValue("CS_HABNDE", IIf(tCabSys.CS_HABNDE, 1, 0))
                .AddWithValue("CS_BAJA", IIf(tCabSys.CS_BAJA, 1, 0))
                .AddWithValue("CS_ALTA", IIf(tCabSys.CS_ALTA, 1, 0))
                .AddWithValue("CS_ALTQUE", Misc.Encoding.Base64Encode(tCabSys.CS_ALTQUE))
                .AddWithValue("CS_BAJQUE", Misc.Encoding.Base64Encode(tCabSys.CS_BAJQUE))
                .AddWithValue("CS_ALTVAL", Misc.Encoding.Base64Encode(tCabSys.CS_ALTVAL))
                .AddWithValue("CS_MODVAL", Misc.Encoding.Base64Encode(tCabSys.CS_MODVAL))
            End With

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Guardando encabezado de consulta", ex)
        End Try

    End Sub

    Private Sub GuardarVariablesEntrada(con As SqlConnection, tran As SqlTransaction)
        Try
            Dim sSql = "insert into VARSYS (VS_CODCON, VS_HELP, VS_HELQUE, VS_NOMBRE "
            sSql += " VS_ORDEN, VS_TIPO, VS_TITULO) values (@VS_CODCON, @VS_HELP, @VS_HELQUE, @VS_NOMBRE "
            sSql += " @VS_ORDEN, @VS_TIPO, @VS_TITULO)"
            Dim cmd As New SqlCommand(sSql, con, tran)

            DeteleTablaRelacionada(con, tran, "VARSYS", "VS_CODCON")

            For Each oVar As VarSys In tVarSys
                Dim cmdClone As SqlCommand = cmd.Clone
                With cmdClone.Parameters
                    .AddWithValue("VS_CODCON", tCabSys.CS_CODCON)
                    .AddWithValue("VS_HELP", oVar.Help)
                    .AddWithValue("VS_HELQUE", Misc.Encoding.Base64Encode(oVar.HelQue))
                    .AddWithValue("VS_NOMBRE", oVar.Nombre)
                    .AddWithValue("VS_ORDEN", oVar.Orden)
                    .AddWithValue("VS_TIPO", oVar.Tipo)
                    .AddWithValue("VS_TITULO", oVar.Titulo)
                End With
                cmd.ExecuteNonQuery()
            Next

        Catch ex As Exception
            Throw New Exception("Guardando variables de entrada", ex)
        End Try
    End Sub

    Private Sub DeteleTablaRelacionada(con As SqlConnection, tran As SqlTransaction, tabla As String, campoClave As String)
        Dim cmdDelete As New SqlCommand($"delete {tabla} where {campoClave} = @VCODCON", con, tran)
        cmdDelete.Parameters.AddWithValue("CODCON", tCabSys.CS_CODCON)
        cmdDelete.ExecuteNonQuery()
    End Sub

    Private Sub GuardarProcesosPrevios(con As SqlConnection, tran As SqlTransaction)
        Try

            Dim sSQL = "insert into PROSYS (PS_CODCON, PS_DESCRI, PS_NOMBRE, PS_ORDEN "
            sSQL += " PS_PARAME, PS_TITULO) VALUES (@PS_CODCON, @PS_DESCRI, @PS_NOMBRE, @PS_ORDEN "
            sSQL += " @PS_PARAME, @PS_TITULO)"
            Dim cmd As New SqlCommand(sSQL, con, tran)


            DeteleTablaRelacionada(con, tran, "PROSYS", "PS_CODCON")

            For Each oPro As ProSys In tProcesosPrevios
                Dim cmdClone As SqlCommand = cmd.Clone
                With cmdClone.Parameters
                    .AddWithValue("PS_CODCON", tCabSys.CS_CODCON)
                    .AddWithValue("PS_DESCRI", oPro.Descripcion)
                    .AddWithValue("PS_NOMBRE", oPro.Nombre)
                    .AddWithValue("PS_ORDEN", oPro.Orden)
                    .AddWithValue("PS_PARAME", oPro.Parametros)
                    .AddWithValue("PS_TITULO", oPro.Titulo)
                End With
                cmdClone.ExecuteNonQuery()
            Next

        Catch ex As Exception
            Throw New Exception("Guardando procesos previos", ex)
        End Try
    End Sub

    Private Sub GuardarColumnas(con As SqlConnection, tran As SqlTransaction)
        Try
            Dim sSQL = "Insert into DETSYS (DS_CODCON, DS_CAMPO, DS_FORMAT, DS_FORMUL, DS_HABILI, "
            sSQL += " DS_HELP, DS_HELQUE, DS_LARGO, DS_ORDEN, DS_TIPO, "
            sSQL += " DS_TITULO, DS_VISIBL, DS_DRILLD, DS_DRIQUE, DS_DRIPRE, "
            sSQL += " DS_LLAVE, DS_REEMPL, DS_AYUDA, DS_MAXLAR, DS_VISABM) values (@DS_CODCON, @DS_CAMPO, @DS_FORMAT, @DS_FORMUL, @DS_HABILI, "
            sSQL += " @DS_HELP, @DS_HELQUE, @DS_LARGO, @DS_ORDEN, @DS_TIPO, "
            sSQL += " @DS_TITULO, @DS_VISIBL, @DS_DRILLD, @DS_DRIQUE, @DS_DRIPRE, "
            sSQL += " @DS_LLAVE, @DS_REEMPL, @DS_AYUDA, @DS_MAXLAR, @DS_VISABM)"
            Dim cmd As New SqlCommand(sSQL, con, tran)

            DeteleTablaRelacionada(con, tran, "DETSYS", "DS_CODCON")

            For Each oCol As DetSys In oDetSys
                Dim cmdClone As SqlCommand = cmd.Clone
                With cmdClone.Parameters
                    .AddWithValue("DS_CODCON", tCabSys.CS_CODCON)
                    .AddWithValue("DS_CAMPO", oCol.Campo)
                    .AddWithValue("DS_FORMAT", oCol.Format)
                    .AddWithValue("DS_FORMUL", Misc.Encoding.Base64Encode(oCol.Formul))
                    .AddWithValue("DS_HABILI", IIf(oCol.Habili, 1, 0))
                    .AddWithValue("DS_HELP", oCol.Help)
                    .AddWithValue("DS_HELQUE", Misc.Encoding.Base64Encode(oCol.HelQue))
                    .AddWithValue("DS_LARGO", oCol.Largo)
                    .AddWithValue("DS_ORDEN", oCol.Orden)
                    .AddWithValue("DS_TIPO", oCol.Tipo)
                    .AddWithValue("DS_TITULO", oCol.Titulo)
                    .AddWithValue("DS_VISIBL", IIf(oCol.Visible, 1, 0))
                    .AddWithValue("DS_DRILLD", IIf(oCol.DrillD, 1, 0))
                    .AddWithValue("DS_DRIQUE", Misc.Encoding.Base64Encode(oCol.DriQue))
                    .AddWithValue("DS_DRIPRE", Misc.Encoding.Base64Encode(oCol.DriPre))
                    .AddWithValue("DS_LLAVE", IIf(oCol.Llave, 1, 0))
                    .AddWithValue("DS_REEMPL", IIf(oCol.Reemplazo, 1, 0))
                    .AddWithValue("DS_AYUDA", oCol.RutaAyuda)
                    .AddWithValue("DS_MAXLAR", oCol.MaxLargo)
                    ' .AddWithValue("DS_VISABM", IIf(chkVisABM.Checked, IIf(oCol.VisABM, 1, 0), DBNull.Value))
                End With
                cmdClone.ExecuteNonQuery()
            Next
        Catch ex As Exception
            Throw New Exception("Guardando Columnas", ex)
        End Try
    End Sub

    Private Sub GuardarGraficos(con As SqlConnection, tran As SqlTransaction)
        '     Try
        '         Dim sSQL = "Select    * " &
        '       "FROM      SYSGRA " &
        '       "WHERE     SG_CODCON = " & tCabSys.CS_CODCON
        'Set RS = oAdmLocal.AbrirRecordset(sSQL, True)
        'DeteleTablaRelacionada(con, tran, "SYSGRA", "SG_CODCON")

        '         With RS
        '         Do Until .EOF
        '             .Delete
        '             .MoveNext
        '             DoEvents
        '         Loop

        '         For Each oBan In oSysGra
        '             .AddNew

        '             !SG_CODCON = tCabSys.CS_CODCON
        '             !SG_ORDEN = oBan.Orden
        '             !SG_TIPO = oBan.Tipo
        '             !SG_CAMVAL = oBan.CamVal
        '             !SG_CAMTIT = oBan.CamTit
        '             !SG_TITULO = oBan.Titulo
        '             !SG_QUERY = oBan.Query
        '             !SG_POSLEY = oBan.PosLeyenda
        '             !SG_TITVIS = oBan.TitVisible

        '             .Update

        '             DoEvents
        '         Next
        '     End With

        '     Catch ex As Exception
        '         Throw New Exception("Guardando graficos", ex)
        '     End Try

    End Sub

    Private Sub GuardarConsulta()
        Dim tr As SqlTransaction = Nothing
        Dim con As SqlConnection = Nothing
        Try
            Me.Cursor = Cursors.WaitCursor
            Try
                If Not VerificacionExistenciaConsulta() Then Exit Sub
                con = DataAccess.GetConnection()

                tr = con.BeginTransaction()
                GuardarEncabezado(con, tr)
                GuardarVariablesEntrada(con, tr)
                GuardarProcesosPrevios(con, tr)
                GuardarColumnas(con, tr)
                GuardarGraficos(con, tr)

                tr.Commit()
            Catch ex As Exception
                If tr IsNot Nothing Then tr.Rollback()
                ManejarErrores.TratarError(ex, "GuardarConsulta")
            End Try

        Finally
            Me.Cursor = Cursors.Default
            If con IsNot Nothing Then
                If con.State = ConnectionState.Open Then con.Close()
                con = Nothing
            End If
        End Try
    End Sub

    Private Sub EliminarConsulta()
        EliminarConsulta(False)
    End Sub

    Private Sub EliminarConsulta(ByVal bModoSilencioso As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim tr As SqlTransaction = Nothing

            Try
                Dim con As SqlConnection = Prex.Utils.DataAccess.GetConnection()
                tr = con.BeginTransaction
                DeteleTablaRelacionada(con, tr, "CABSYS", "CS_CODCON")
                DeteleTablaRelacionada(con, tr, "DETSYS", "DS_CODCON")
                DeteleTablaRelacionada(con, tr, "VARSYS", "VS_CODCON")

                tr.Commit()
                If Not bModoSilencioso Then
                    Prex.Utils.MensajesForms.MostrarInformacion("Consulta Eliminada")
                End If

            Catch ex As Exception
                Prex.Utils.ManejarErrores.TratarError(ex, "EliminarConsulta")
                If tr IsNot Nothing Then tr.Rollback()
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub CargarConsultaSeleccionada()

        NuevaConsulta()
        Dim hdle = GridViewCons.GetSelectedRows().FirstOrDefault()
        With GridViewCons
            tCabSys.CS_CODCON = .GetRowCellValue(hdle, .Columns("CS_CODCON"))
            tCabSys.CS_CODENT = .GetRowCellValue(hdle, .Columns("CS_CODENT"))
            tCabSys.CS_CODTRA = .GetRowCellValue(hdle, .Columns("CS_CODTRA"))
            tCabSys.CS_DESCRI = .GetRowCellValue(hdle, .Columns("CS_DESCRI"))
            tCabSys.CS_FECPRO = Date.Now
            tCabSys.CS_LAYOUT = .GetRowCellValue(hdle, .Columns("CS_LAYOUT"))
            tCabSys.CS_NOMBRE = .GetRowCellValue(hdle, .Columns("CS_NOMBRE"))
            tCabSys.CS_QUERY = Misc.Encoding.Base64DeCode(.GetRowCellValue(hdle, .Columns("CS_QUERY")))
            tCabSys.CS_REPORT = .GetRowCellValue(hdle, .Columns("CS_REPORT"))
            tCabSys.CS_UPDATE = .GetRowCellValue(hdle, .Columns("CS_UPDATE"))
            tCabSys.CS_DRILLD = .GetRowCellValue(hdle, .Columns("CS_DRILLD"))
            tCabSys.CS_GROUPB = .GetRowCellValue(hdle, .Columns("CS_GROUPB"))
            tCabSys.CS_DRIQUE = Misc.Encoding.Base64DeCode(.GetRowCellValue(hdle, .Columns("CS_DRIQUE")))
            tCabSys.CS_DRIPRE = Misc.Encoding.Base64DeCode("" & .GetRowCellValue(hdle, .Columns("CS_DRIPRE")))
            tCabSys.CS_TABLA = Misc.Encoding.Base64DeCode(.GetRowCellValue(hdle, .Columns("CS_TABLA")))
            tCabSys.CS_UPDQUE = Misc.Encoding.Base64DeCode("" & .GetRowCellValue(hdle, .Columns("CS_UPDQUE")))
            tCabSys.CS_NDESDE = Misc.Encoding.Base64DeCode("" & .GetRowCellValue(hdle, .Columns("CS_NDESDE")))
            tCabSys.CS_NDEVAL = Misc.Encoding.Base64DeCode("" & .GetRowCellValue(hdle, .Columns("CS_NDEVAL")))
            tCabSys.CS_HABNDE = .GetRowCellValue(hdle, .Columns("CS_HABNDE"))
            tCabSys.CS_ALTQUE = Misc.Encoding.Base64DeCode("" & .GetRowCellValue(hdle, .Columns("CS_ALTQUE")))
            tCabSys.CS_BAJQUE = Misc.Encoding.Base64DeCode("" & .GetRowCellValue(hdle, .Columns("CS_BAJQUE")))
            tCabSys.CS_ALTA = .GetRowCellValue(hdle, .Columns("CS_ALTA"))
            tCabSys.CS_BAJA = .GetRowCellValue(hdle, .Columns("CS_BAJA"))
            tCabSys.CS_HABNDE = .GetRowCellValue(hdle, .Columns("CS_HABNDE"))
            tCabSys.CS_ALTVAL = Misc.Encoding.Base64DeCode("" & .GetRowCellValue(hdle, .Columns("CS_ALTVAL")))
            tCabSys.CS_MODVAL = Misc.Encoding.Base64DeCode("" & .GetRowCellValue(hdle, .Columns("CS_MODVAL")))
        End With

        txtNombreCab.Text = tCabSys.CS_NOMBRE
        txtCodTraCab.Text = tCabSys.CS_CODTRA
        txtDescriCab.Text = tCabSys.CS_DESCRI
        chkABM.Checked = IIf(tCabSys.CS_UPDATE, 1, 0)
        chkBaja.Checked = IIf(tCabSys.CS_BAJA, 1, 0)
        chkAlta.Checked = IIf(tCabSys.CS_ALTA, 1, 0)
        chkDrillDown.Checked = IIf(tCabSys.CS_DRILLD, 1, 0)
        chkGroup.Checked = IIf(tCabSys.CS_GROUPB, 1, 0)
        chkNDesde.Checked = IIf(tCabSys.CS_HABNDE, 1, 0)
        cmSql.Text = tCabSys.CS_QUERY
    End Sub

    Private Sub CargarVariables()
        Dim sSQL = "SELECT    * " &
              "FROM      VARSYS " &
              "WHERE     VS_CODCON = " & tCabSys.CS_CODCON & " " &
              "ORDER BY  VS_ORDEN "
        tVarSys.Clear()
        Dim rd As SqlDataReader = DataAccess.GetReader(sSQL)
        While rd.Read
            tVarSys.Add(New VarSys(rd("VS_CODCON").ToString, Integer.Parse(rd("VS_ORDEN").ToString), rd("VS_NOMBRE").ToString,
                                   rd("VS_TIPO").ToString, rd("VS_TITULO").ToString, rd("VS_HELP").ToString,
                                   Misc.Encoding.Base64DeCode(rd("VS_HELQUE").ToString), "K" & rd("VS_ORDEN").ToString))
        End While
        rd.Close()

        'nLlave = oVarSys.Count

    End Sub

    Private Sub CargarProcesosPrevios()
        Dim sSQL = "SELECT    * " &
          "FROM      PROSYS " &
          "WHERE     PS_CODCON = " & tCabSys.CS_CODCON & " " &
          "ORDER BY  PS_ORDEN "

        tProcesosPrevios.Clear()
        Dim rd As SqlDataReader = DataAccess.GetReader(sSQL)
        While rd.Read
            tProcesosPrevios.Add(New ProSys(Long.Parse(rd("PS_CODCON").ToString), Integer.Parse(rd("PS_ORDEN").ToString),
                                            rd("PS_NOMBRE").ToString, rd("PS_TITULO").ToString, rd("PS_DESCRI").ToString, rd("PS_PARAME").ToString, "K" & rd("PS_ORDEN").ToString))
        End While
        rd.Close()

        'nLlavePro = oProSys.Count
    End Sub

    Private Sub CargarGraficos()
        Dim sSQL = "SELECT    * " &
          "FROM      SYSGRA " &
          "WHERE     SG_CODCON = " & tCabSys.CS_CODCON & " " &
          "ORDER BY  SG_ORDEN "


        tGraficos.Clear()
        Dim rd As SqlDataReader = DataAccess.GetReader(sSQL)
        While rd.Read
            tGraficos.Add(New SysGra(Long.Parse(rd("SG_CODCON").ToString), Integer.Parse(rd("SG_ORDEN").ToString), Long.Parse(rd("SG_TIPO").ToString), 0, rd("SG_CAMVAL").ToString, rd("SG_CAMTIT").ToString,
                                    rd("SG_TITULO").ToString, rd("SG_QUERY").ToString, Integer.Parse(rd("SG_POSLEY").ToString), Integer.Parse(rd("SG_TITVIS").ToString), "K" & rd("SG_ORDEN").ToString))
        End While
        rd.Close()

    End Sub

    Private Sub CargarColumnas()
        'COLUMNAS
        Dim sSQL = "SELECT       * " &
          "FROM         DETSYS " &
          "WHERE        DS_CODCON = " & tCabSys.CS_CODCON & " " &
          "ORDER BY     DS_ORDEN "

        oDetSys.Clear()
        Dim rd As SqlDataReader = DataAccess.GetReader(sSQL)
        While rd.Read
            oDetSys.Add(New DetSys(Long.Parse(rd("DS_CODCON").ToString), Integer.Parse(rd("DS_ORDEN").ToString), Integer.Parse(rd("DS_CAMPO").ToString),
                                   Integer.Parse(rd("DS_TIPO").ToString), Integer.Parse(rd("DS_LARGO").ToString), rd("DS_FORMAT").ToString, rd("DS_TITULO").ToString,
                                   rd("DS_HELP").ToString, Misc.Encoding.Base64DeCode(rd("DS_HELQUE").ToString), Misc.Encoding.Base64DeCode(rd("DS_FORMUL").ToString),
                                   Boolean.Parse(rd("DS_HABILI")), Boolean.Parse(rd("DS_VISIBL")), Boolean.Parse(rd("DS_VISABM")), Boolean.Parse(rd("DS_LLAVE")),
                                   Boolean.Parse(rd("DS_DRILLD")), Misc.Encoding.Base64DeCode(rd("DS_DRIQUE").ToString), Misc.Encoding.Base64DeCode(rd("DS_DRIPRE")),
                                   Boolean.Parse(rd("DS_REEMPL")), rd("DS_AYUDA").ToString, Integer.Parse(rd("DS_MAXLAR")), "K" & rd("DS_ORDEN").ToString))
        End While
        rd.Close()

        'nLlaveDet = oDetSys.Count
    End Sub

    Private Function EditarConsulta() As Boolean
        Try
            Dim oRespuesta = MensajesForms.MostrarPreguntaCancelar("Se perderan los cambios de la consulta actual. ¿Desea guardar los cambios?")

            If oRespuesta = vbYes Then
                GuardarConsulta()
            ElseIf oRespuesta = DialogResult.Cancel Then
                Return False
            End If

            Me.Cursor = Cursors.WaitCursor
            Try
                CargarConsultaSeleccionada()
                CargarVariables()
                CargarProcesosPrevios()
                CargarGraficos()
                CargarColumnas()

                'GridVar.ItemCount = oVarSys.Count
                'GridVar.Refresh
                'GridVar.RefreshSort
                '
                'If GridVar.ItemCount > 0 Then
                '    GridVar.Row = 1
                '    MostrarVariable "K" & GridVar.Value(GridVar.Columns("Key").Index)
                'End If
                '
                'GridPro.ItemCount = oProSys.Count
                'GridPro.Refresh
                'GridPro.RefreshSort
                '
                'If GridPro.ItemCount > 0 Then
                '    GridPro.Row = 1
                '    MostrarProceso "K" & GridPro.Value(GridPro.Columns("Key").Index)
                'End If
                '
                'GridCols.ItemCount = oDetSys.Count
                'GridCols.Refresh

                'If GridCols.ItemCount > 0 Then
                '    GridCols.Row = 1
                'End If
                '
                'Label1.Caption = "Explorador de consultas - (" & tCabSys.CS_CODCON & ")"
                Return True
            Finally
                Me.Cursor = Cursors.Default

            End Try
        Catch ex As Exception
            If Err.Number Then
                ManejarErrores.TratarError(ex, "EditarConsulta")
            End If
            Return False
        End Try


    End Function


#End Region
    '    Public Sub CargarVariable(ByVal nOrden As Integer,
    '                          ByVal sNombre As String,
    '                          ByVal nTipo As Integer,
    '                          ByVal sTitulo As String,
    '                          ByVal nHelp As Integer,
    '                          ByVal sHelSQL As String)


    '        Dim oVar As ItemsVarSys

    '        If nOrden = 0 Then
    '            nLlave = nLlave + 1
    '            oVarSys.Add tCabSys.CS_CODCON, oVarSys.Count + 1, sNombre, nTipo, sTitulo, nHelp, sHelSQL, "K" & nLlave
    '   End If

    '        If nOrden <> 0 Then
    '            For Each oVar In oVarSys
    '                If oVar.Orden = nOrden Then
    '                    oVar.Nombre = sNombre
    '                    oVar.Tipo = nTipo
    '                    oVar.Titulo = sTitulo
    '                    oVar.Help = nHelp
    '                    oVar.HelQue = sHelSQL
    '                    Exit For
    '                End If
    '            Next
    '        End If

    '        CargarVariables()

    '    End Sub

    '    Private Sub CargarVariables()

    '        GridVar.ItemCount = oVarSys.Count
    '        GridVar.Refresh
    '        GridVar.RefreshSort
    '        DoEvents

    '        If GridVar.ItemCount > 0 Then
    '            MostrarVariable "K" & GridVar.Value(GridVar.Columns("Key").Index)
    '   End If

    '    End Sub

    '#End Region

#Region "Eventos Form"
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim dt As SqlDataReader = DataAccess.GetReader("Select *, CAST(CS_CODTRA As VARCHAR) +  ' - ' + CS_NOMBRE AS XX_DESCRI FROM CABSYS ORDER BY CS_CODTRA ")
        GridCons.DataSource = dt
        dt.Close()
        NuevaConsulta()

        '''PARAMETROS CUADRO SQL
        '    AjusteCodemax cmHelp
        '    AjusteCodemax txtFormul

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub
#End Region

#Region "Eventos Controles"

    Private Sub chkABM_CheckedChanged(sender As Object, e As EventArgs) Handles chkABM.CheckedChanged
        tCabSys.CS_UPDATE = chkABM.Checked
        cmdQueryUpdate.Enabled = chkABM.Checked
        cmdModValida.Enabled = chkABM.Checked
        cmdValidarUpdate.Enabled = chkABM.Checked
    End Sub

    '    Private Sub chkClave_Click()

    '        oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).Llave = CBool(chkClave.Value)

    '    End Sub

    'Private Sub chkDrill_Click()
    '
    '    oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).DrillD = CBool(chkDrill.Value)
    '
    '    cmdDrill.Enabled = (chkDrill.Value = 1)
    '
    'End Sub

    Private Sub chkDrillDown_CheckedChanged(sender As Object, e As EventArgs) Handles chkDrillDown.CheckedChanged
        cmdDrillDown.Enabled = chkDrillDown.Checked
        tCabSys.CS_DRILLD = cmdDrillDown.Enabled
    End Sub

    '    Private Sub chkGroup_Click()
    '        tCabSys.CS_GROUPB = CBool(chkGroup.Value)
    '    End Sub

    '    Private Sub chkHabili_Click()
    '        On Error Resume Next
    '        oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).Habili = CBool(chkHabili.Value)
    '    End Sub


    Private Sub chkNDesde_CheckedChanged(sender As Object, e As EventArgs) Handles chkNDesde.CheckedChanged
        tCabSys.CS_HABNDE = chkNDesde.Checked
        cmdQueryNDesde.Enabled = chkNDesde.Checked
        cmdValidaNuevoDesde.Enabled = chkNDesde.Checked
    End Sub

    '    Private Sub chkReempl_Click()
    '        On Error Resume Next
    '        oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).Reemplazo = CBool(chkReempl.Value)
    '    End Sub

    '    Private Sub chkVisible_Click()
    '        On Error Resume Next
    '        oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).Visible = CBool(chkVisible.Value)
    '    End Sub

    '    Private Sub chkVisABM_Click()
    '        On Error Resume Next
    '        oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).VisABM = CBool(chkVisABM.Value)
    '    End Sub

    Private Sub chkAlta_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlta.CheckedChanged
        tCabSys.CS_ALTA = chkAlta.Checked
        cmdAlta.Enabled = chkAlta.Checked
        cmdAltaValida.Enabled = chkAlta.Checked
        cmdAlta.Enabled = chkAlta.Checked
    End Sub

    Private Sub cmdAlta_Click(sender As Object, e As EventArgs) Handles cmdAlta.Click

        'Load frmDrillDown
        'frmDrillDown.PasarQuery tCabSys.CS_ALTQUE
        'frmDrillDown.Show vbModal, Me

        'If Trim(INPUT_GENERAL) <> "" Then
        '    tCabSys.CS_ALTQUE = INPUT_GENERAL
        'End If

    End Sub

    Private Sub cmdAltaValida_Click(sender As Object, e As EventArgs) Handles cmdAltaValida.Click

        'Load frmDrillDown
        'rmDrillDown.PasarQuery tCabSys.CS_ALTVAL
        'rmDrillDown.Show vbModal, Me
        '
        'If FORM_MODAL_RESP Then
        '    tCabSys.CS_ALTVAL = Trim(INPUT_GENERAL)
        'End If

    End Sub

    Private Sub cmdBaja_Click(sender As Object, e As EventArgs) Handles cmdBaja.Click

        '        Load frmDrillDown
        '   frmDrillDown.PasarQuery tCabSys.CS_BAJQUE
        '   frmDrillDown.Show vbModal, Me

        '    If Trim(INPUT_GENERAL) <> "" Then
        '            tCabSys.CS_BAJQUE = INPUT_GENERAL
        '        End If

    End Sub

    Private Sub chkBaja_CheckedChanged(sender As Object, e As EventArgs) Handles chkBaja.CheckedChanged
        tCabSys.CS_BAJA = chkBaja.Checked
        cmdBaja.Enabled = tCabSys.CS_BAJA
    End Sub

    ' Private Sub cmdDrill_Click(sender As Object, e As EventArgs)

    '        Load frmDrillDown
    '   frmDrillDown.PasarConsulta tCabSys.CS_CODTRA, oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).Campo, oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).DriQue, oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).DriPre
    '   frmDrillDown.Show vbModal, Me

    '    If Trim(INPUT_GENERAL) <> "" Then
    '            oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).DriQue = INPUT_GENERAL

    '            If Trim(INPUT_GENERAL_AUX) <> "" Then
    '                oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).DriPre = INPUT_GENERAL_AUX
    '            End If

    '        Else
    '            chkDrill.Value = 0
    '        End If

    ' End Sub

    Private Sub cmdDrillDown_Click(sender As Object, e As EventArgs) Handles cmdDrillDown.Click

        '        Load frmDrillDown
        '   frmDrillDown.PasarConsulta tCabSys.CS_CODTRA, "", tCabSys.CS_DRIQUE, tCabSys.CS_DRIPRE
        '   frmDrillDown.Show vbModal, Me

        '    If Trim(INPUT_GENERAL) <> "" Then
        '            tCabSys.CS_DRIQUE = INPUT_GENERAL
        '        End If

        '        If Trim(INPUT_GENERAL_AUX) <> "" Then
        '            tCabSys.CS_DRIPRE = INPUT_GENERAL_AUX
        '        End If

    End Sub

    Private Sub cmdSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdSave.ItemClick

        Dim res As MsgBoxResult = MsgBox("Se perderan los cambios de la consulta actual. ¿Desea guardar los cambios?", vbQuestion + vbYesNoCancel, "Preguta del sistema")

        If res = MsgBoxResult.Yes Then
            GuardarConsulta()
        ElseIf res = MsgBoxResult.Cancel Then
            Exit Sub
        Else
            NuevaConsulta()
        End If
    End Sub

    Private Sub btnEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEliminar.ItemClick

        If Prex.Utils.MensajesForms.MostrarPregunta("¿Eliminar la consulta de la base de datos?") = DialogResult.Yes Then
            EliminarConsulta()
        End If

    End Sub


    '    Private Sub cmdFondo_Click()

    '        On Error Resume Next

    '        Dim nColor As Long

    '        nColor = picFondo.BackColor

    '        If VBChooseColor(nColor, True, True) Then
    '            picFondo.BackColor = nColor

    '            Dim sFormat As String

    '            sFormat = txtFormat.Text & ";" &
    '             picFondo.BackColor & ";" &
    '             picFrente.BackColor & ";" &
    '             txtFuente.Font.name & ";" &
    '             IIf(txtFuente.Font.Bold, 1, 0) & ";" &
    '             IIf(txtFuente.Font.Underline, 1, 0) & ";" &
    '             IIf(txtFuente.Font.Strikethrough, 1, 0) & ";" &
    '             Int(Val(txtFuente.Font.Size)) & ";" &
    '             Int(Val(txtAncho.Text)) & ";" &
    '             txtCond

    '            oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).Format = sFormat

    '        End If

    '    End Sub

    '    Private Sub cmdFrente_Click()


    '        Dim nColor As Long

    '        nColor = picFrente.BackColor

    '        If VBChooseColor(nColor, True, True) Then
    '            picFrente.BackColor = nColor

    '            Dim sFormat As String

    '            sFormat = txtFormat.Text & ";" &
    '             picFondo.BackColor & ";" &
    '             picFrente.BackColor & ";" &
    '             txtFuente.Font.name & ";" &
    '             IIf(txtFuente.Font.Bold, 1, 0) & ";" &
    '             IIf(txtFuente.Font.Underline, 1, 0) & ";" &
    '             IIf(txtFuente.Font.Strikethrough, 1, 0) & ";" &
    '             Int(Val(txtFuente.Font.Size)) & ";" &
    '             Int(Val(txtAncho.Text)) & ";" &
    '             txtCond

    '            oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).Format = sFormat

    '        End If

    '    End Sub

    '    Private Sub cmdFuente_Click()

    '        Dim oFont As StdFont

    '    Set oFont = New StdFont
    '    Set oFont = txtFuente.Font

    '    If VBChooseFont(oFont) Then
    '    Set txtFuente.Font = oFont

    '    Dim sFormat As String

    '            sFormat = txtFormat.Text & ";" &
    '             picFondo.BackColor & ";" &
    '             picFrente.BackColor & ";" &
    '             txtFuente.Font.name & ";" &
    '             IIf(txtFuente.Font.Bold, 1, 0) & ";" &
    '             IIf(txtFuente.Font.Underline, 1, 0) & ";" &
    '             IIf(txtFuente.Font.Strikethrough, 1, 0) & ";" &
    '             Int(Val(txtFuente.Font.Size)) & ";" &
    '             Int(Val(txtAncho.Text)) & ";" &
    '             txtCond

    '            oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).Format = sFormat

    '        End If

    '    Set oFont = Nothing


    '    Private Sub cmdModValida_Click()

    '        Load frmDrillDown
    '   frmDrillDown.PasarQuery tCabSys.CS_MODVAL
    '   frmDrillDown.Show vbModal, Me

    '    If FORM_MODAL_RESP Then
    '            tCabSys.CS_MODVAL = Trim(INPUT_GENERAL)
    '        End If

    '    End Sub

    '    Private Sub cmdQueryNDesde_Click()

    '        Load frmDrillDown
    '   frmDrillDown.PasarQuery tCabSys.CS_NDESDE
    '   frmDrillDown.Show vbModal, Me

    '    If Trim(INPUT_GENERAL) <> "" Then
    '            tCabSys.CS_NDESDE = INPUT_GENERAL
    '        End If

    '    End Sub

    '    Private Sub cmdQueryUpdate_Click()

    '        Load frmDrillDown
    '   frmDrillDown.PasarQuery tCabSys.CS_TABLA
    '   frmDrillDown.Show vbModal, Me

    '    If Trim(INPUT_GENERAL) <> "" Then
    '            tCabSys.CS_TABLA = INPUT_GENERAL
    '        End If

    '    End Sub

    '    Private Sub cmdValidaNuevoDesde_Click()

    '        Load frmDrillDown
    '   frmDrillDown.PasarQuery tCabSys.CS_NDEVAL
    '   frmDrillDown.Show vbModal, Me

    '    If Trim(INPUT_GENERAL) <> "" Then
    '            tCabSys.CS_NDEVAL = INPUT_GENERAL
    '        End If

    '    End Sub

    '    Private Sub cmdValidarUpdate_Click()

    '        Load frmDrillDown
    '   frmDrillDown.PasarQuery tCabSys.CS_UPDQUE
    '   frmDrillDown.Show vbModal, Me

    '    If Trim(INPUT_GENERAL) <> "" Then
    '            tCabSys.CS_UPDQUE = INPUT_GENERAL
    '        End If

    '    End Sub

    '    Private Sub cmHelp_Change(ByVal Control As CodeMaxCtl.ICodeMax)
    '        oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).HelQue = cmHelp.Text
    '    End Sub

    '    Private Function cmHelp_RClick(ByVal Control As CodeMaxCtl.ICodeMax) As Boolean
    '        cmHelp_RClick = True
    '    End Function

    Private Sub cmSQL_Change(ByVal Control As Object, ByVal e As EventArgs)
        tCabSys.CS_QUERY = cmSql.Text
    End Sub
    Private Sub GridCons_RowStyle(sender As Object, e As RowStyleEventArgs) Handles GridViewCons.RowStyle
        If e.RowHandle = rowHandle Then

            e.Appearance.BackColor = BackColor
            e.HighPriority = True
        End If
    End Sub
    Private rowHandle As Integer
    Private Sub GridCons_DoubleClick(sender As Object, e As EventArgs) Handles GridViewCons.DoubleClick
        If EditarConsulta() Then
            Dim ea As DXMouseEventArgs = CType(e, DXMouseEventArgs)
            Dim hitInfo As GridHitInfo = GridViewCons.CalcHitInfo(ea.Location)
            If hitInfo.InRowCell Then

                rowHandle = hitInfo.RowHandle
                GridViewCons.LayoutChanged()
            End If
        End If
    End Sub

    '    Private Function cmSQL_RClick(ByVal Control As CodeMaxCtl.ICodeMax) As Boolean
    '        cmSQL_RClick = True
    '    End Function

    '    Private Sub dckCampos_CommandClick(ByVal Command As InnovaDSXP.Command)

    '        Select Case Command.name

    '            Case "btnBaja"
    '                If Pregunta("¿Eliminar columna?") = vbYes Then
    '                    EliminarCampo GridCols.Value(GridCols.Columns("Key").Index)
    '    End If

    '            Case "btnArriba"
    '                SubirOrdenCol GridCols.Value(GridCols.Columns("Orden").Index)

    '    Case "btnAbajo"
    '                BajarOrdenCol GridCols.Value(GridCols.Columns("Orden").Index)

    '    End Select

    '    End Sub

    '    Private Sub dckCons_CommandClick(ByVal Command As InnovaDSXP.Command)

    '        Dim oRespuesta As VbMsgBoxResult

    '        Select Case Command.name

    '            Case "btnNuevo"

    '                oRespuesta = MsgBox("Se perderan los cambios de la consulta actual. ¿Desea guardar los cambios?", vbQuestion + vbYesNoCancel, "Preguta del sistema")

    '                If oRespuesta = vbYes Then
    '                    GuardarConsulta
    '                ElseIf oRespuesta = vbCancel Then
    '                    Exit Sub
    '                Else
    '                    NuevaConsulta
    '                End If

    '            Case "btnBaja"

    '                If Pregunta("¿Eliminar la consulta de la base de datos?") = vbYes Then
    '                    EliminarConsulta
    '                End If

    '            Case "btnEditar"
    '                EditarConsulta

    '        End Select

    '    End Sub

    '    Private Sub dckStudio_CommandClick(ByVal Command As InnovaDSXP.Command)

    '        Select Case Command.name

    '            Case "btnAyuda"

    '                Ayuda

    '            Case "btnSalir"

    '                Unload Me

    '    End Select

    '    End Sub


#End Region

End Class
