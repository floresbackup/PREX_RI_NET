Imports System.Data.SqlClient
Imports System.Text
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports Prex.Utils
Imports VBP04296.Dominio

Public Class frmMain
    Public ErrorPermiso As Boolean = False
    Private dataConsulta As DataTable
    Private tCabSys As CabSys
    Private tVarSys As List(Of VarSys)
    Private tProcesosPrevios As List(Of ProSys)
    Private tGraficos As List(Of SysGra)

    Private oDetSys As List(Of DetSys)
    Private cmSql As ScintillaNET.Scintilla

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

	End Sub

	'#Region "Metodos"
	Public Function AnalizarCommand() As Boolean

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
				Return False
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
				Return False
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
				Return False
			End If

			nPosAux = InStr(1, Mid(sTemp, nPos + 3), "/")

			If nPosAux > 0 Then
				nCodigoEntidad = Val(Mid(sTemp, nPos + 3, nPosAux - 1))
			Else
				nCodigoEntidad = Val(Mid(sTemp, nPos + 3))
			End If

			Configuration.PrexConfig.CODIGO_TRANSACCION = nCodigoTransaccion
			Configuration.PrexConfig.CODIGO_ENTIDAD = nCodigoEntidad

			Return PresentarDatos(nCodigoTransaccion, nCodigoUsuario, nCodigoEntidad)
		Catch ex As Exception
			ManejarErrores.TratarError(ex, "AnalizarCommand")
		End Try
	End Function

	Private Function PresentarDatos(ByVal nCodigoTransaccion As Long, ByVal nCodigoUsuario As Long, ByVal nCodigoEntidad As Long) As Boolean
		Try
			Dim sError = String.Empty
			''''' USUARIO '''''
			Dim sSQL = "SELECT    US_CODUSU, US_NOMBRE, US_DESCRI " &
						"FROM      USUARI " &
						"WHERE     US_CODUSU = " & nCodigoUsuario
			Dim rstAux As SqlDataReader = DataAccess.GetReader(sSQL)

			If Not rstAux.HasRows OrElse rstAux.RecordsAffected > 1 Then
				sError += vbCrLf + "Falla de seguridad"
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

			If Not rstAux.HasRows OrElse rstAux.RecordsAffected > 1 Then
				sError += vbCrLf + "Parámetro de entidad no válido"
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

			If Not rstAux.HasRows OrElse rstAux.RecordsAffected > 1 Then
				sError += vbCrLf + "Error en la línea de comandos. Parámetro de transacción incorrecto"
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
				Return False
			End If

			Return True
		Catch ex As Exception
			ManejarErrores.TratarError(ex, "PresentarDatos")
		End Try

	End Function

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
			Dim sSql = "insert into VARSYS (VS_CODCON, VS_HELP, VS_HELQUE, VS_NOMBRE, "
			sSql += " VS_ORDEN, VS_TIPO, VS_TITULO) values (@VS_CODCON, @VS_HELP, @VS_HELQUE, @VS_NOMBRE, "
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
				cmdClone.ExecuteNonQuery()
			Next

        Catch ex As Exception
            Throw New Exception("Guardando variables de entrada", ex)
        End Try
    End Sub

    Private Sub DeteleTablaRelacionada(con As SqlConnection, tran As SqlTransaction, tabla As String, campoClave As String)
        Dim cmdDelete As New SqlCommand($"delete {tabla} where {campoClave} = @VCODCON", con, tran)
		cmdDelete.Parameters.AddWithValue("VCODCON", tCabSys.CS_CODCON)
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
			sSQL += " DS_LLAVE, DS_REEMPL, DS_AYUDA, DS_MAXLAR, DS_VISABM) values "
			sSQL += " (@DS_CODCON, @DS_CAMPO, @DS_FORMAT, @DS_FORMUL, @DS_HABILI, "
			sSQL += " @DS_HELP, @DS_HELQUE, @DS_LARGO, @DS_ORDEN, @DS_TIPO, "
            sSQL += " @DS_TITULO, @DS_VISIBL, @DS_DRILLD, @DS_DRIQUE, @DS_DRIPRE, "
            sSQL += " @DS_LLAVE, @DS_REEMPL, @DS_AYUDA, @DS_MAXLAR, @DS_VISABM)"
            Dim cmd As New SqlCommand(sSQL, con, tran)

            DeteleTablaRelacionada(con, tran, "DETSYS", "DS_CODCON")

            For Each oCol As DetSys In UcFrmColumnas1.tDetSys
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
                    .AddWithValue("DS_AYUDA", oCol.RutaAyuda.ValueOrDbNull())
                    .AddWithValue("DS_MAXLAR", oCol.MaxLargo)
                    .AddWithValue("DS_VISABM", IIf(oCol.VisABM, 1, 0))
                    '.AddWithValue("DS_VISABM", IIf(chkVisABM.Checked, IIf(oCol.VisABM, 1, 0), DBNull.Value))
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

    Private Function GetCellBase64Value(row As DataRow, campo As String) As String
        If row IsNot Nothing Then
            Return Misc.Encoding.Base64DeCode(row(campo))
        Else
            Return String.Empty
        End If
    End Function

    Private Sub CargarConsultaSeleccionada()

        NuevaConsulta()
        Dim hdle = GridViewCons.FocusedRowHandle

        Dim row As DataRow = Nothing
        With GridViewCons
            Dim condicion = $"CS_CODCON = { .GetRowCellValue(hdle, .Columns("CS_CODCON"))} AND CS_CODTRA = { .GetRowCellValue(hdle, .Columns("CS_CODTRA"))} AND CS_NOMBRE = '{ .GetRowCellValue(hdle, .Columns("CS_NOMBRE"))}'"
            row = dataConsulta.Select(condicion).FirstOrDefault()
        End With
        If row IsNot Nothing Then

            tCabSys.CS_CODCON = row("CS_CODCON")
            tCabSys.CS_CODENT = row("CS_CODENT")
            tCabSys.CS_CODTRA = row("CS_CODTRA")
            tCabSys.CS_DESCRI = row("CS_DESCRI")
            tCabSys.CS_FECPRO = Date.Now
            tCabSys.CS_LAYOUT = row("CS_LAYOUT")
            tCabSys.CS_NOMBRE = row("CS_NOMBRE")
            tCabSys.CS_QUERY = GetCellBase64Value(row, "CS_QUERY")
            tCabSys.CS_REPORT = row("CS_REPORT")
            tCabSys.CS_UPDATE = row("CS_UPDATE")
            tCabSys.CS_DRILLD = row("CS_DRILLD")
            tCabSys.CS_GROUPB = row("CS_GROUPB")
            tCabSys.CS_DRIQUE = GetCellBase64Value(row, "CS_DRIQUE")
            tCabSys.CS_DRIPRE = GetCellBase64Value(row, "CS_DRIPRE")
            tCabSys.CS_TABLA = GetCellBase64Value(row, "CS_TABLA")
            tCabSys.CS_UPDQUE = GetCellBase64Value(row, "CS_UPDQUE")
            tCabSys.CS_NDESDE = GetCellBase64Value(row, "CS_NDESDE")
            tCabSys.CS_NDEVAL = GetCellBase64Value(row, "CS_NDEVAL")
            tCabSys.CS_HABNDE = row("CS_HABNDE")
            tCabSys.CS_ALTQUE = GetCellBase64Value(row, "CS_ALTQUE")
            tCabSys.CS_BAJQUE = GetCellBase64Value(row, "CS_BAJQUE")
            tCabSys.CS_ALTA = row("CS_ALTA")
            tCabSys.CS_BAJA = row("CS_BAJA")
            tCabSys.CS_HABNDE = row("CS_HABNDE")
            tCabSys.CS_ALTVAL = GetCellBase64Value(row, "CS_ALTVAL")
            tCabSys.CS_MODVAL = GetCellBase64Value(row, "CS_MODVAL")
        End If

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
        CargarProcesos()
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
            oDetSys.Add(New DetSys(Long.Parse(rd("DS_CODCON").ToString), Integer.Parse(rd("DS_ORDEN").ToString), rd("DS_CAMPO").ToString,
                                   Integer.Parse(rd("DS_TIPO").ToString), Integer.Parse(rd("DS_LARGO").ToString), rd("DS_FORMAT").ToString, rd("DS_TITULO").ToString,
                                   rd("DS_HELP").ToString, Misc.Encoding.Base64DeCode(rd("DS_HELQUE").ToString), Misc.Encoding.Base64DeCode(rd("DS_FORMUL").ToString),
                                   Boolean.Parse(rd("DS_HABILI")), Boolean.Parse(rd("DS_VISIBL")), Boolean.Parse(rd("DS_VISABM")), Boolean.Parse(rd("DS_LLAVE")),
                                   Boolean.Parse(rd("DS_DRILLD")), Misc.Encoding.Base64DeCode(rd("DS_DRIQUE").ToString), Misc.Encoding.Base64DeCode(rd("DS_DRIPRE")),
                                   Boolean.Parse(rd("DS_REEMPL")), rd("DS_AYUDA").ToString, Integer.Parse(rd("DS_MAXLAR")), "K" & rd("DS_ORDEN").ToString))
        End While
        rd.Close()
        UcFrmColumnas1.CargarGrillaColumnas(oDetSys)

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

                If tProcesosPrevios.Any() Then
                    BeginInvoke(New Action(Function() FocusRow(gridViewProc)))
                    MostrarProceso(tProcesosPrevios.FirstOrDefault().Llave)
                End If


                lblSubtitulo.Text = $"Explorador de consultas - {tCabSys.CS_NOMBRE} ({tCabSys.CS_CODCON})"
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

    Private Function FocusRow(ByVal view As GridView) As Boolean
        view.FocusedRowHandle = 0
        Return True
    End Function

#End Region

#Region "Eventos Form"
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If AnalizarCommand() Then

			cmSql = New ScintillaNET.Scintilla()
			tabPageQuery.Controls.Add(cmSql)
			cmSql.Dock = DockStyle.Fill
			Prex.Utils.Misc.Forms.ScintillaSQL.InitialiseScintilla(cmSql)


			GridViewCons.OptionsSelection.EnableAppearanceFocusedCell = True
			GridViewCons.OptionsSelection.EnableAppearanceFocusedRow = True
			GridViewCons.Appearance.FocusedRow.BackColor = Color.FromArgb(255, 255, 192)
			GridViewCons.Appearance.SelectedRow.BackColor = Color.FromArgb(255, 255, 192)
			GridViewCons.Appearance.SelectedRow.Options.UseBackColor = True

			gridViewProc.OptionsBehavior.AutoPopulateColumns = True
			AddHandler cmSql.TextChanged, AddressOf cmSQL_Change



			dataConsulta = DataAccess.GetDataTable("Select *, CAST(CS_CODTRA As VARCHAR) +  ' - ' + CS_NOMBRE AS XX_DESCRI FROM CABSYS ORDER BY CS_CODTRA ")
			GridCons.DataSource = dataConsulta
			NuevaConsulta()

			'''PARAMETROS CUADRO SQL
			'    AjusteCodemax cmHelp
			'    AjusteCodemax txtFormul

		Else
			Me.Close()
		End If
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
        Dim frmDrill As New frmDrillDown()
        frmDrill.PasarQuery(tCabSys.CS_ALTQUE)
        If frmDrill.ShowDialog() = DialogResult.OK Then
            If frmDrillDown.INPUT_GENERAL <> String.Empty Then
                tCabSys.CS_ALTQUE = frmDrillDown.INPUT_GENERAL
            End If
        End If
    End Sub

    Private Sub cmdAltaValida_Click(sender As Object, e As EventArgs) Handles cmdAltaValida.Click
        Dim frmDrill As New frmDrillDown()
        frmDrill.PasarQuery(tCabSys.CS_ALTVAL)
        If frmDrill.ShowDialog() = DialogResult.OK Then
            If frmDrillDown.INPUT_GENERAL <> String.Empty Then
                tCabSys.CS_ALTVAL = frmDrillDown.INPUT_GENERAL
            End If
        End If
    End Sub

    Private Sub cmdBaja_Click(sender As Object, e As EventArgs) Handles cmdBaja.Click
        Dim frmDrill As New frmDrillDown()
        If frmDrill.ShowDialog() = DialogResult.OK Then
            If frmDrillDown.INPUT_GENERAL <> String.Empty Then
                tCabSys.CS_BAJQUE = frmDrillDown.INPUT_GENERAL
            End If
        End If
    End Sub

    Private Sub chkBaja_CheckedChanged(sender As Object, e As EventArgs) Handles chkBaja.CheckedChanged
        tCabSys.CS_BAJA = chkBaja.Checked
        cmdBaja.Enabled = tCabSys.CS_BAJA
    End Sub

    ' Private Sub cmdDrill_Click(sender As Object, e As EventArgs) handles cmdDrill.Click

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
        Dim frmDrill As New frmDrillDown()
        frmDrill.PasarConsulta(tCabSys.CS_CODTRA, "", tCabSys.CS_DRIQUE, tCabSys.CS_DRIPRE)

        If frmDrill.ShowDialog() = DialogResult.OK Then

            If frmDrillDown.INPUT_GENERAL <> String.Empty Then
                tCabSys.CS_DRIQUE = frmDrillDown.INPUT_GENERAL
            End If
            If frmDrillDown.INPUT_GENERAL_AUX <> String.Empty Then
                tCabSys.CS_DRIPRE = frmDrillDown.INPUT_GENERAL_AUX
            End If
        End If
    End Sub

	Private Sub cmdCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCancelar.ItemClick
		Dim res As MsgBoxResult = MsgBox("¿Esta seguro que desea canceclar los cambios realizados?", vbQuestion + vbYesNo, "Pregunta del sistema")
		If res = MsgBoxResult.Yes Then
			NuevaConsulta()
		End If
	End Sub

	Private Sub cmdSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdSave.ItemClick

		Dim res As MsgBoxResult = MsgBox("¿Desea guardar los cambios?", vbQuestion + vbYesNoCancel, "Pregunta del sistema")

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


    Private Sub cmdModValida_Click() Handles cmdModValida.Click
        Dim frmDrillDown As New frmDrillDown()
        frmDrillDown.PasarQuery(tCabSys.CS_MODVAL)
        If frmDrillDown.ShowDialog = DialogResult.OK Then
            tCabSys.CS_MODVAL = Trim(frmDrillDown.INPUT_GENERAL)
        End If
    End Sub

    Private Sub cmdQueryNDesde_Click() Handles cmdQueryNDesde.Click
        Dim frmDrillDown As New frmDrillDown()
        frmDrillDown.PasarQuery(tCabSys.CS_NDESDE)

        If frmDrillDown.ShowDialog = DialogResult.OK Then
            tCabSys.CS_NDESDE = Trim(frmDrillDown.INPUT_GENERAL)
        End If
    End Sub

    Private Sub cmdQueryUpdate_Click() Handles cmdQueryUpdate.Click
        Dim frmDrillDown As New frmDrillDown()
        frmDrillDown.PasarQuery(tCabSys.CS_TABLA)
        If frmDrillDown.ShowDialog() = DialogResult.OK Then
            If frmDrillDown.INPUT_GENERAL <> String.Empty Then
                tCabSys.CS_TABLA = frmDrillDown.INPUT_GENERAL
            End If
        End If
    End Sub

    Private Sub cmdValidaNuevoDesde_Click() Handles cmdValidaNuevoDesde.Click
        Dim frmDrillDown As New frmDrillDown()
        frmDrillDown.PasarQuery(tCabSys.CS_NDEVAL)
        If frmDrillDown.ShowDialog() = DialogResult.OK Then
            If frmDrillDown.INPUT_GENERAL <> String.Empty Then
                tCabSys.CS_NDEVAL = frmDrillDown.INPUT_GENERAL
            End If
        End If
    End Sub

    Private Sub cmdValidarUpdate_Click() Handles cmdValidarUpdate.Click
        Dim frmDrillDown As New frmDrillDown()
        frmDrillDown.PasarQuery(tCabSys.CS_UPDQUE)

        If frmDrillDown.ShowDialog() = DialogResult.OK Then
            If frmDrillDown.INPUT_GENERAL <> String.Empty Then
                tCabSys.CS_UPDQUE = frmDrillDown.INPUT_GENERAL
            End If
        End If
    End Sub

    '    Private Sub cmHelp_Change(ByVal Control As CodeMaxCtl.ICodeMax)
    '        oDetSys(GridCols.Value(GridCols.Columns("Key").Index)).HelQue = cmHelp.Text
    '    End Sub

    '    Private Function cmHelp_RClick(ByVal Control As CodeMaxCtl.ICodeMax) As Boolean
    '        cmHelp_RClick = True
    '    End Function

    Private Sub cmSQL_Change(ByVal Control As Object, ByVal e As EventArgs)
        tCabSys.CS_QUERY = cmSql.Text
    End Sub
    'Private Sub GridCons_RowStyle(sender As Object, e As RowStyleEventArgs) Handles `RowStyle
    '    If e.RowHandle = rowHandle Then

    '        e.Appearance.BackColor = BackColor
    '        e.HighPriority = True
    '    End If
    'End Sub
    Private rowHandle As Integer
    Private Sub GridCons_DoubleClick(sender As Object, e As EventArgs) Handles GridViewCons.DoubleClick

        Dim ea As DXMouseEventArgs = CType(e, DXMouseEventArgs)
        Dim hitInfo As GridHitInfo = GridViewCons.CalcHitInfo(ea.Location)
        If hitInfo.InRowCell Then
            If EditarConsulta() Then
                rowHandle = hitInfo.RowHandle
                GridViewCons.LayoutChanged()
            End If
        End If
    End Sub


    Private Sub GridViewCons_RowStyle(sender As Object, e As RowStyleEventArgs) Handles GridViewCons.RowStyle
		If Not GridViewCons.IsDataRow(e.RowHandle) Then
			Return
		End If
		If e.RowHandle = rowHandle Then
			e.Appearance.BackColor = Color.LightBlue
			e.Appearance.Options.UseBackColor = True
		Else
			e.Appearance.BackColor = Color.White
		End If

	End Sub

	Private Sub gridViewProc_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles gridViewProc.SelectionChanged
        MostrarProceso(gridViewProc.GetFocusedRowCellValue("Llave"))
    End Sub

    Private Sub gridViewProc_DoubleClick(sender As Object, e As EventArgs) Handles gridViewProc.DoubleClick


        Dim ea As DXMouseEventArgs = CType(e, DXMouseEventArgs)
        Dim hitInfo As GridHitInfo = gridViewProc.CalcHitInfo(ea.Location)
        If hitInfo.InRowCell Then
            ModificarProceso(False)
            gridViewProc.LayoutChanged()
        End If

    End Sub


    Private Sub cmdNuevoProceso_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdNuevoProceso.ItemClick
        ModificarProceso(True)
    End Sub

    Private Sub cmdEditarProceso_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdEditarProceso.ItemClick
        ModificarProceso(False)
    End Sub

    Private Sub cmdEliminarProceso_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdEliminarProceso.ItemClick
        EliminarProceso()
    End Sub

    Private Sub cmdSubirOrdenProceso_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdSubirOrdenProceso.ItemClick
        SubirOrdenPro()
    End Sub

    Private Sub cmdBajarOrdenProceso_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdBajarOrdenProceso.ItemClick
        BajarOrdenPro()
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

#Region "Procesos"
    Private Sub ModificarProceso(esNuevo As Boolean)
        Dim sLlave = gridViewProc.GetFocusedRowCellValue("Llave")
        Dim frmABMPro As New frmABMPro()
        frmABMPro.PasarDatos(IIf(esNuevo, Nothing, tProcesosPrevios.FirstOrDefault(Function(t) t.Llave = sLlave)), tProcesosPrevios)
        If frmABMPro.ShowDialog() = DialogResult.OK Then
            If esNuevo Then
                tProcesosPrevios.Add(frmABMPro.Proceso)
                sLlave = frmABMPro.Proceso.Llave
            End If
            RefrescarGrillaProcesos()
            MostrarProceso(sLlave)
        End If
    End Sub

    Private Sub RefrescarGrillaProcesos()
        Try
            RemoveHandler gridViewProc.SelectionChanged, AddressOf gridViewProc_SelectionChanged

            gridProc.DataSource = tProcesosPrevios.OrderBy(Function(c) c.Orden).Select(Function(c) New With {c.Nombre, c.Llave}).ToList()
            For Each item As DevExpress.XtraGrid.Columns.GridColumn In gridViewProc.Columns
                item.Visible = item.FieldName.Contains("Nombre")
            Next
        Finally
            AddHandler gridViewProc.SelectionChanged, AddressOf gridViewProc_SelectionChanged
        End Try
    End Sub

    Private Sub CargarProcesos()
        RefrescarGrillaProcesos()
		MostrarProceso(tProcesosPrevios.FirstOrDefault()?.Llave)
	End Sub


    Private Sub EliminarProceso()
        Try

            Dim sLlave = gridViewProc.GetFocusedRowCellValue("Llave")
            Dim oPro = tProcesosPrevios.FirstOrDefault(Function(t) t.Llave = sLlave)

            For Each item As ProSys In tProcesosPrevios
                If item.Orden > oPro.Orden Then
                    item.Orden = item.Orden - 1
                End If
            Next

            tProcesosPrevios.Remove(oPro)
            CargarProcesos()
        Catch ex As Exception
            ManejarErrores.TratarError(ex, "EliminarProceso")
        End Try

    End Sub

    Private Sub SubirOrdenPro()
        Dim sLlave = gridViewProc.GetFocusedRowCellValue("Llave")
        Dim oPro As ProSys = tProcesosPrevios.FirstOrDefault(Function(t) t.Llave = sLlave)
        oPro.Orden -= 1

        Dim l As New List(Of ProSys)
        For Each item As ProSys In tProcesosPrevios.Where(Function(t) t.Llave <> oPro.Llave)
            If oPro.Orden = item.Orden Then
                item.Orden += 1
            End If
            l.Add(item)
        Next
        l.Add(oPro)

        tProcesosPrevios = l.OrderBy(Function(t) t.Orden).ToList()
        CargarProcesos()
    End Sub

    Private Sub BajarOrdenPro()
        Dim sLlave = gridViewProc.GetFocusedRowCellValue("Llave")
        Dim oPro As ProSys = tProcesosPrevios.FirstOrDefault(Function(t) t.Llave = sLlave)
        oPro.Orden += 1

        Dim l As New List(Of ProSys)
        For Each item As ProSys In tProcesosPrevios.Where(Function(t) t.Llave <> oPro.Llave)
            If oPro.Orden = item.Orden Then
                item.Orden -= 1
            End If
            l.Add(item)
        Next
        l.Add(oPro)

        tProcesosPrevios = l.OrderBy(Function(t) t.Orden).ToList()
        CargarProcesos()
    End Sub


	Private Sub MostrarProceso(ByVal sLlave As String)
		If Not tProcesosPrevios.Any() Then Exit Sub
		Dim proc = tProcesosPrevios.FirstOrDefault(Function(p) p.Llave = sLlave)
		If proc IsNot Nothing Then
			txtOrdenPro.Text = proc.Orden
			txtNombrePro.Text = proc.Nombre
			txtTituloPro.Text = proc.Titulo
			txtDescriPro.Text = proc.Descripcion
			txtParamPro.Text = proc.Parametros
			Dim rh = gridViewProc.GetRowHandle(proc.Orden - 1)
			gridViewProc.SelectRow(rh)
		Else
			txtOrdenPro.Text = String.Empty
			txtNombrePro.Text = String.Empty
			txtTituloPro.Text = String.Empty
			txtDescriPro.Text = String.Empty
			txtParamPro.Text = String.Empty
		End If

		cmdEditarProceso.Enabled = tProcesosPrevios.Any
		cmdEliminarProceso.Enabled = tProcesosPrevios.Any
		cmdSubirOrdenProceso.Enabled = tProcesosPrevios.Count() > 1
		cmdBajarOrdenProceso.Enabled = tProcesosPrevios.Count() > 1
	End Sub


    Private Sub cmdGenerarScipt_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdGenerarScipt.ItemClick
        Try
            Dim dialog As New SaveFileDialog With {
                .Filter = "Script SQL(*.sql)|*.sql",
                .Title = "Guardar Script"
            }

            If dialog.ShowDialog(Me) = DialogResult.OK Then
                Dim fileName = dialog.FileName

                Dim frmInputGral As New Prex.Utils.Misc.Forms.FrmInputGeneral()
                frmInputGral.PasarInfoVentana("Entidad Destino", "Ingrese el código de entidad destino:")
                If frmInputGral.ShowDialog(Me) = DialogResult.OK Then
                    Dim entDestino = frmInputGral.ResultadoInput

                    Dim sScript = GetStringScript(frmInputGral.ResultadoInput)

                    'guardar archivo
                    If System.IO.File.Exists(fileName) Then System.IO.File.Delete(fileName)

                    System.IO.File.WriteAllText(fileName, sScript, Encoding.UTF8)

                    Prex.Utils.MensajesForms.MostrarInformacion("Script generado exitosamente!")
                End If
            End If




        Catch ex As Exception
            Prex.Utils.ManejarErrores.TratarError(ex, "GenerarScript", String.Empty, True)
        End Try
    End Sub

    Private Function GetStringScript(codEntidad As String) As String
        Dim script = "SET DATEFORMAT YMD" & Environment.NewLine
        script &= "BEGIN TRANSACTION" & Environment.NewLine
        script &= "DECLARE @CODCON INT" & Environment.NewLine
        script &= "SELECT @CODCON = ISNULL(MAX(CS_CODCON), 0) + 1 FROM CABSYS " & Environment.NewLine

        script &= Environment.NewLine & "--ENCABEZADO" & Environment.NewLine

        Dim sSql = "SELECT * FROM CABSYS WHERE CS_CODCON = " & tCabSys.CS_CODCON
        Dim dr As SqlDataReader = Prex.Utils.DataAccess.GetReader(sSql)

        If Not dr.HasRows OrElse dr.RecordsAffected > 1 Then
            Throw New Exception("CABSYS vacio en CS_CODCON = " & tCabSys.CS_CODCON)
        End If

        While dr.Read()
            script &= QueryInsert("CABSYS", dr, codEntidad) & Environment.NewLine
        End While
        dr.Close()

        script &= Environment.NewLine & "--VARIABLES" & Environment.NewLine
        sSql = "SELECT       * " &
             "FROM         VARSYS " &
             "WHERE        VS_CODCON = " & tCabSys.CS_CODCON & " " &
             "ORDER BY     VS_ORDEN "

        dr = Prex.Utils.DataAccess.GetReader(sSql)

        If Not dr.HasRows OrElse dr.RecordsAffected > 1 Then
            Throw New Exception("VARSYS vacio en VS_CODCON = " & tCabSys.CS_CODCON)
        End If

        While dr.Read()
            script &= QueryInsert("VARSYS", dr, codEntidad) & Environment.NewLine
        End While
        dr.Close()

        script &= Environment.NewLine & "--DETALLE" & Environment.NewLine
        sSql = "SELECT       * " &
             "FROM         DETSYS " &
             "WHERE        DS_CODCON = " & tCabSys.CS_CODCON & " " &
             "ORDER BY     DS_ORDEN "
        dr = Prex.Utils.DataAccess.GetReader(sSql)

        If Not dr.HasRows OrElse dr.RecordsAffected > 1 Then
            Throw New Exception("DETSYS vacio en DS_CODCON = " & tCabSys.CS_CODCON)
        End If

        While dr.Read()
            script &= QueryInsert("DETSYS", dr, codEntidad) & Environment.NewLine
        End While
        dr.Close()


        script &= Environment.NewLine & "--PROCESOS" & Environment.NewLine

        sSql = "SELECT       * " &
             "FROM         PROSYS " &
             "WHERE        PS_CODCON = " & tCabSys.CS_CODCON & " " &
             "ORDER BY     PS_ORDEN "
        dr = Prex.Utils.DataAccess.GetReader(sSql)

        If Not dr.HasRows OrElse dr.RecordsAffected > 1 Then
            Throw New Exception("PROSYS vacio en PS_CODCON = " & tCabSys.CS_CODCON)
        End If

        While dr.Read()
            script &= QueryInsert("PROSYS", dr, codEntidad) & Environment.NewLine
        End While
        dr.Close()

        script &= Environment.NewLine & "COMMIT" & Environment.NewLine

        Return script
    End Function

    Private Function QueryInsert(ByVal sTabla As String, ByVal reader As SqlDataReader, entidadDestino As String,
                             Optional ByVal sAdicional As String = "",
                             Optional ByVal sValorAdic As String = "") As String

        Dim sSQL As String
        Dim campos As List(Of String) = Enumerable.Range(0, reader.FieldCount).Select(Function(d) reader.GetName(d)).ToList()
        Dim camposTipo = Enumerable.Range(0, reader.FieldCount).Select(Function(d) New With {.id = d, .tipo = reader.GetFieldType(d)}).ToList()

        sSQL = "INSERT INTO " & sTabla & " (" & Join(campos.ToArray(), ",")
        sSQL = IIf(sAdicional.IsNullOrEmpty, sSQL.Trim, sSQL & sAdicional) & ") VALUES ("

        For Each campoTipo As Object In camposTipo
            Select Case campoTipo.tipo
                Case True AndAlso campoTipo.tipo Is GetType(String)
                    sSQL = sSQL & "'" & Replace("" & reader(campoTipo.id), "'", "") & "',"
                Case True AndAlso (campoTipo.tipo Is GetType(Date) OrElse campoTipo.tipo Is GetType(DateTime))
                    sSQL = sSQL & Prex.Utils.DataAccess.FechaSQL(IIf(reader(campoTipo.id).IsNullOrEmpty(), "01/01/1900", reader(campoTipo.id))) & ","
                Case True AndAlso campoTipo.tipo Is GetType(Boolean)
                    sSQL = sSQL & IIf(reader(campoTipo.id), "1,", "0,")
                Case True AndAlso (campoTipo.tipo Is GetType(Integer) OrElse campoTipo.tipo Is GetType(Long))

                    If reader.GetName(campoTipo.id).Trim().ToUpper() = "CODCON" Then
                        sSQL = sSQL & "@CODCON,"
                    ElseIf reader.GetName(campoTipo.id).Trim().ToUpper() = "CODENT" Then
                        sSQL = sSQL & entidadDestino & ","
                    Else
                        If IsNumeric(reader(campoTipo.id)) Then
                            sSQL = sSQL & Prex.Utils.DataAccess.FlotanteSQL(reader(campoTipo.id)) & ","
                        Else
                            sSQL = sSQL & "0,"
                        End If
                    End If
                Case Else
                    sSQL = sSQL & "'" & Replace("" & reader(campoTipo.id), "'", "") & "',"
            End Select

        Next

        sSQL = IIf(sValorAdic.IsNullOrEmpty(), sSQL.Trim, sSQL & sValorAdic) & ") "

        Return sSQL

    End Function

#End Region

End Class
