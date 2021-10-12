Imports System
Imports System.Linq
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Data.SqlClient

Public Class frmMain

	Private oAdmLocal As New AdmTablas
	Private dFechaProx As Date
	Private Formato As New Collection
	Private nGenerado As Integer
	Public ErrorPermiso As Boolean = False

	Private ReadOnly Property IsArchivoPorDia As Boolean
		Get
			Return CType(cboArchivos.SelectedItem, Prex.Utils.Entities.clsItem).Periodo = "D"
		End Get
	End Property

	Private ReadOnly Property MesSeleccionado As Integer
		Get
			Return CType(cboMes.SelectedItem, Prex.Utils.Entities.clsItem).Valor
		End Get
	End Property

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
		oAdmLocal.ConnectionString = CONN_LOCAL
		AnalizarCommand()



	End Sub

	Public Sub Cargar()

		CargarArchivos()
		IniciarControles()
		txtCarpeta.Text = NormalizarRuta(Application.StartupPath)

		Dim sRutaDefault As String
		Dim nOpcionRuta As Integer

		'nOpcionRuta = Val(NoNulo(oAdmLocal.DevolverValor("TABGEN", "TG_NUME01", "TG_CODTAB=10 AND TG_CODCON=1000", ""), False))
		'sRutaDefault = NoNulo(oAdmLocal.DevolverValor("TXTNOM", "TN_RUTA", "TG_CODTAB=10 AND TG_CODCON=1000", "Ruta"))



		txtCarpeta.Text = CARPETA_LOCAL
		txtCarpeta.Enabled = True


	End Sub

	Private Function PreparaTXT_5603(ByVal sTabla As String, ByVal dFecha As Date) As Boolean

		Dim sSQL As String

		Try

			If oAdmLocal.ExisteTabla(sTabla) Then
				oAdmLocal.EjecutarComandoSQL("DROP TABLE " & sTabla)
			End If

			sSQL = "SELECT        DF_FECVIG AS PERIODO, " &
				   "              DF_FECVIG AS FECHAVIG," &
				   "              0         AS CUADRO,  " &
				   "              DF_CODPAR AS CODIGO,  " &
				   "              DF_CAMPO8 AS CAMPO8,  " &
				   "              DF_CODCON AS CODCON,  " &
				   "              DF_RESNOT,            " &
				   "              DF_FECRES,            " &
				   "              DF_PTORES,            " &
				   "              DF_SECUEN,            " &
				   "              DF_DESCRI,            " &
				   "              DF_IMPORT AS IMPORTE, " &
				   "              1         AS GENERATXT " &
				   "INTO          TXTSAL2               " &
				   "FROM          DATFRA                " &
				   "WHERE         DF_FECVIG = " & FechaSQL(dFecha) & " " &
				   "AND           DF_CODENT = " & CODIGO_ENTIDAD & " "
			oAdmLocal.EjecutarComandoSQL(sSQL)

			Return True

		Catch ex As Exception
			TratarError(ex, "PreparaTXT_5603")
		End Try

	End Function

	Private Function PreparaTXT_5610(ByVal sTabla As String, ByVal dFecha As Date) As Boolean

		Dim sSQL As String

		Try

			If oAdmLocal.ExisteTabla(sTabla) Then
				oAdmLocal.EjecutarComandoSQL("DROP TABLE " & sTabla)
			End If

			sSQL = "SELECT        DI_FECVIG AS PERIODO,  " &
				   "              DI_FECVIG AS FECHAVIG, " &
				   "              0         AS CUADRO,   " &
				   "              DI_CODPAR AS CODIGO,   " &
				   "              DI_CAMPO8 AS CAMPO8,   " &
				   "              DI_CODCON AS CODCON,   " &
				   "              DI_TIPIDE,             " &
				   "              DI_NROIDE,             " &
				   "              DI_DENOMI,             " &
				   "              DI_PTONOR,             " &
				   "              DI_IMPORTE AS IMPORTE, " &
				   "              1         AS GENERATXT " &
				   "INTO          TXTSAL3                " &
				   "FROM          DATINC                 " &
				   "WHERE         DI_FECVIG = " & FechaSQL(dFecha) & " " &
				   "AND           DI_CODENT = " & CODIGO_ENTIDAD & " "
			oAdmLocal.EjecutarComandoSQL(sSQL)

			Return True

		Catch ex As Exception
			TratarError(ex, "PreparaTXT_5610")
		End Try

	End Function

	Private Function PreparaTXT_5611(ByVal sTabla As String, ByVal dFecha As Date) As Boolean

		Dim sSQL As String

		Try

			If oAdmLocal.ExisteTabla(sTabla) Then
				oAdmLocal.EjecutarComandoSQL("DROP TABLE " & sTabla)
			End If

			sSQL = "SELECT        DP_FECVIG AS PERIODO,  " &
				   "              DP_FECVIG AS FECHAVIG, " &
				   "              0         AS CUADRO,   " &
				   "              DP_CODPAR AS CODIGO,   " &
				   "              DP_CAMPO8 AS CAMPO8,   " &
				   "              DP_CODCON AS CODCON,   " &
				   "              DP_1ERMES,             " &
				   "              DP_2DOMES,             " &
				   "              1         AS GENERATXT " &
				   "INTO          TXTSAL4                " &
				   "FROM          DATPER                 " &
				   "WHERE         DP_FECVIG = " & FechaSQL(dFecha) & " " &
				   "AND           DP_CODENT = " & CODIGO_ENTIDAD & " "
			oAdmLocal.EjecutarComandoSQL(sSQL)

			Return True

		Catch ex As Exception
			TratarError(ex, "PreparaTXT_5611")
		End Try

	End Function

	Private Function PreparaTXT_5601(ByVal sTabla As String, ByVal dFecha As Date) As Boolean

		Dim sSQL As String

		Try

			If oAdmLocal.ExisteTabla(sTabla) Then
				oAdmLocal.EjecutarComandoSQL("DROP TABLE " & sTabla)
			End If

			sSQL = "SELECT        DC_FECVIG     AS PERIODO,  " &
				   "              DC_FECVIG     AS FECHAVIG, " &
				   "              DC_CUADRO     AS CUADRO,   " &
				   "              DC_CODPAR     AS CODIGO,   " &
				   "              DC_CAMPO8     AS CAMPO8,   " &
				   "              DC_CODCON     AS CODCON,   " &
				   "              DC_MES1 * DC_OPERACION  AS IMPORTE,  " &
				   "              DC_GENERATXT  AS GENERATXT " &
				   "INTO          TXTSAL                     " &
				   "FROM          DATCUA                     " &
				   "WHERE         DC_FECVIG = " & FechaSQL(dFecha) & " " &
				   "AND           DC_CUADRO IN (331, 351, 352, 353, 361, 371, 381, 391, 392) " &
				   "AND           DC_CODENT = " & CODIGO_ENTIDAD & " "
			oAdmLocal.EjecutarComandoSQL(sSQL)

			'-----------------------------------------------------------------------------------------
			' AGREGADO PARA ELIMINAR LAS PARTIDAS DIARIOS EN R.MERCADO QUE NO CORRESPONDEN AL MES
			'-----------------------------------------------------------------------------------------

			sSQL = "DELETE " &
				   "FROM         TXTSAL " &
				   "WHERE        PERIODO = " & FechaSQL(dFecha) & " " &
				   "AND          CUADRO IN (351, 352, 353) " &
				   "AND          RIGHT(CODIGO,2) > DAY(PERIODO) "
			oAdmLocal.EjecutarComandoSQL(sSQL)

			sSQL = "DELETE " &
				   "FROM         TXTSAL " &
				   "WHERE        PERIODO = " & FechaSQL(dFecha) & " " &
				   "AND          CUADRO NOT IN (351, 352) " &
				   "AND          IMPORTE = 0 "
			oAdmLocal.EjecutarComandoSQL(sSQL)

			sSQL = "DELETE " &
				   "FROM         TXTSAL " &
				   "WHERE        PERIODO = " & FechaSQL(dFecha) & " " &
				   "AND          CUADRO IN (351, 352) " &
				   "AND          LEFT(CODIGO, 6) IN ( " &
				   "                                  SELECT   CODPAR " &
				   "                                  FROM     ( " &
				   "                                              SELECT      LEFT(CODIGO, 6) AS CODPAR, SUM(IMPORTE) AS IMPORT " &
				   "                                              FROM        TXTSAL " &
				   "                                              WHERE       CUADRO IN (351, 352) " &
				   "                                              GROUP BY    LEFT(CODIGO, 6) " &
				   "                                           )  XXTEMP " &
				   "                                  WHERE    IMPORT = 0 " &
				   "                                ) "

			oAdmLocal.EjecutarComandoSQL(sSQL)

			Return True

		Catch ex As Exception
			TratarError(ex, "PreparaTXT_5601")
		End Try

	End Function


	Private Function PreparaTXT_5605(ByVal sTabla As String, ByVal dFecha As Date) As Boolean

		Dim sSQL As String

		Try

			If oAdmLocal.ExisteTabla(sTabla) Then
				oAdmLocal.EjecutarComandoSQL("DROP TABLE " & sTabla)
			End If

			sSQL = "SELECT        DB_FECVIG AS PERIODO, " &
				   "              DB_FECVIG AS FECHAVIG," &
				   "              DB_CODCON AS CODCON,  " &
				   "              DB_CUADRO AS CUADRO,  " &
				   "              DB_CODPAR AS CODIGO,  " &
				   "              DB_CAMPO8 AS CAMPO8, "

			sSQL = sSQL & "  DB_MES0  * DB_OPERACION AS DB_MES0 , "
			sSQL = sSQL & "  DB_MES1  * DB_OPERACION AS DB_MES1 , "
			sSQL = sSQL & "  DB_MES2  * DB_OPERACION AS DB_MES2 , "
			sSQL = sSQL & "  DB_MES3  * DB_OPERACION AS DB_MES3 , "
			sSQL = sSQL & "  DB_MES4  * DB_OPERACION AS DB_MES4 , "
			sSQL = sSQL & "  DB_MES5  * DB_OPERACION AS DB_MES5 , "
			sSQL = sSQL & "  DB_MES6  * DB_OPERACION AS DB_MES6 , "
			sSQL = sSQL & "  DB_MES7  * DB_OPERACION AS DB_MES7 , "
			sSQL = sSQL & "  DB_MES8  * DB_OPERACION AS DB_MES8 , "
			sSQL = sSQL & "  DB_MES9  * DB_OPERACION AS DB_MES9 , "
			sSQL = sSQL & "  DB_MES10 * DB_OPERACION AS DB_MES10, "
			sSQL = sSQL & "  DB_MES11 * DB_OPERACION AS DB_MES11, "
			sSQL = sSQL & "  DB_MES12 * DB_OPERACION AS DB_MES12, "
			sSQL = sSQL & "  DB_MES13 * DB_OPERACION AS DB_MES13, "
			sSQL = sSQL & "  DB_MES14 * DB_OPERACION AS DB_MES14, "
			sSQL = sSQL & "  DB_MES15 * DB_OPERACION AS DB_MES15, "
			sSQL = sSQL & "  DB_MES16 * DB_OPERACION AS DB_MES16, "
			sSQL = sSQL & "  DB_MES17 * DB_OPERACION AS DB_MES17, "
			sSQL = sSQL & "  DB_MES18 * DB_OPERACION AS DB_MES18, "
			sSQL = sSQL & "  DB_MES19 * DB_OPERACION AS DB_MES19, "
			sSQL = sSQL & "  DB_MES20 * DB_OPERACION AS DB_MES20, "
			sSQL = sSQL & "  DB_MES21 * DB_OPERACION AS DB_MES21, "
			sSQL = sSQL & "  DB_MES22 * DB_OPERACION AS DB_MES22, "
			sSQL = sSQL & "  DB_MES23 * DB_OPERACION AS DB_MES23, "
			sSQL = sSQL & "  DB_MES24 * DB_OPERACION AS DB_MES24, "
			sSQL = sSQL & "  DB_MES25 * DB_OPERACION AS DB_MES25, "
			sSQL = sSQL & "  DB_MES26 * DB_OPERACION AS DB_MES26, "
			sSQL = sSQL & "  DB_MES27 * DB_OPERACION AS DB_MES27, "
			sSQL = sSQL & "  DB_MES28 * DB_OPERACION AS DB_MES28, "
			sSQL = sSQL & "  DB_MES29 * DB_OPERACION AS DB_MES29, "
			sSQL = sSQL & "  DB_MES30 * DB_OPERACION AS DB_MES30, "
			sSQL = sSQL & "  DB_MES31 * DB_OPERACION AS DB_MES31, "
			sSQL = sSQL & "  DB_MES32 * DB_OPERACION AS DB_MES32, "
			sSQL = sSQL & "  DB_MES33 * DB_OPERACION AS DB_MES33, "
			sSQL = sSQL & "  DB_MES34 * DB_OPERACION AS DB_MES34, "
			sSQL = sSQL & "  DB_MES35 * DB_OPERACION AS DB_MES35, "
			sSQL = sSQL & "  DB_MES36 * DB_OPERACION AS DB_MES36, "
			sSQL = sSQL & "  DB_MES37 * DB_OPERACION AS DB_MES37, "
			sSQL = sSQL & "  DB_MES38 * DB_OPERACION AS DB_MES38, "
			sSQL = sSQL & "  DB_MES39 * DB_OPERACION AS DB_MES39, "
			sSQL = sSQL & "  DB_MES40 * DB_OPERACION AS DB_MES40, "
			sSQL = sSQL & "  DB_MES41 * DB_OPERACION AS DB_MES41, "
			sSQL = sSQL & "  DB_MES42 * DB_OPERACION AS DB_MES42, "
			sSQL = sSQL & "  DB_MES43 * DB_OPERACION AS DB_MES43, "
			sSQL = sSQL & "  DB_MES44 * DB_OPERACION AS DB_MES44, "
			sSQL = sSQL & "  DB_MES45 * DB_OPERACION AS DB_MES45, "
			sSQL = sSQL & "  DB_MES46 * DB_OPERACION AS DB_MES46, "
			sSQL = sSQL & "  DB_MES47 * DB_OPERACION AS DB_MES47, "
			sSQL = sSQL & "  DB_MES48 * DB_OPERACION AS DB_MES48, "
			sSQL = sSQL & "  DB_MES49 * DB_OPERACION AS DB_MES49, "
			sSQL = sSQL & "  DB_MES50 * DB_OPERACION AS DB_MES50, "
			sSQL = sSQL & "  DB_MES51 * DB_OPERACION AS DB_MES51, "
			sSQL = sSQL & "  DB_MES52 * DB_OPERACION AS DB_MES52, "
			sSQL = sSQL & "  DB_MES53 * DB_OPERACION AS DB_MES53, "

			sSQL = sSQL &
				   "              DB_GENERATXT AS GENERATXT " &
				   "INTO          " & sTabla & "                " &
				   "FROM          DATBAN                " &
				   "WHERE         DB_FECVIG = " & FechaSQL(dFecha) & " " &
				   "AND           DB_CODENT = " & CODIGO_ENTIDAD & " " &
				   "AND           DB_CUADRO IN (341,342,343) " &
				   "ORDER BY      DB_CUADRO, DB_CODPAR"
			oAdmLocal.EjecutarComandoSQL(sSQL)

			Return True

		Catch ex As Exception
			TratarError(ex, "PreparaTXT_5605")
		End Try
	End Function

	Private Function PreparaTXT_5607(ByVal sTabla As String, ByVal dFecha As Date) As Boolean

		Dim sSQL As String

		Try

			If oAdmLocal.ExisteTabla(sTabla) Then
				oAdmLocal.EjecutarComandoSQL("DROP TABLE " & sTabla)
			End If

			sSQL = "SELECT        DB_FECVIG AS PERIODO, " &
				   "              DB_FECVIG AS FECHAVIG," &
				   "              DB_CODCON AS CODCON,  " &
				   "              DB_CUADRO AS CUADRO,  " &
				   "              DB_CODPAR AS CODIGO,  " &
				   "              DB_CAMPO8 AS CAMPO8, "

			sSQL = sSQL & "  DB_MES0  * DB_OPERACION AS DB_MES0 , "
			sSQL = sSQL & "  DB_MES1  * DB_OPERACION AS DB_MES1 , "
			sSQL = sSQL & "  DB_MES2  * DB_OPERACION AS DB_MES2 , "
			sSQL = sSQL & "  DB_MES3  * DB_OPERACION AS DB_MES3 , "
			sSQL = sSQL & "  DB_MES4  * DB_OPERACION AS DB_MES4 , "
			sSQL = sSQL & "  DB_MES5  * DB_OPERACION AS DB_MES5 , "
			sSQL = sSQL & "  DB_MES6  * DB_OPERACION AS DB_MES6 , "
			sSQL = sSQL & "  DB_MES7  * DB_OPERACION AS DB_MES7 , "
			sSQL = sSQL & "  DB_MES8  * DB_OPERACION AS DB_MES8 , "
			sSQL = sSQL & "  DB_MES9  * DB_OPERACION AS DB_MES9 , "
			sSQL = sSQL & "  DB_MES10 * DB_OPERACION AS DB_MES10, "
			sSQL = sSQL & "  DB_MES11 * DB_OPERACION AS DB_MES11, "
			sSQL = sSQL & "  DB_MES12 * DB_OPERACION AS DB_MES12, "
			sSQL = sSQL & "  DB_MES13 * DB_OPERACION AS DB_MES13, "
			sSQL = sSQL & "  DB_MES14 * DB_OPERACION AS DB_MES14, "
			sSQL = sSQL & "  DB_MES15 * DB_OPERACION AS DB_MES15, "
			sSQL = sSQL & "  DB_MES16 * DB_OPERACION AS DB_MES16, "
			sSQL = sSQL & "  DB_MES17 * DB_OPERACION AS DB_MES17, "
			sSQL = sSQL & "  DB_MES18 * DB_OPERACION AS DB_MES18, "
			sSQL = sSQL & "  DB_MES19 * DB_OPERACION AS DB_MES19, "
			sSQL = sSQL & "  DB_MES20 * DB_OPERACION AS DB_MES20, "
			sSQL = sSQL & "  DB_MES21 * DB_OPERACION AS DB_MES21, "
			sSQL = sSQL & "  DB_MES22 * DB_OPERACION AS DB_MES22, "
			sSQL = sSQL & "  DB_MES23 * DB_OPERACION AS DB_MES23, "
			sSQL = sSQL & "  DB_MES24 * DB_OPERACION AS DB_MES24, "
			sSQL = sSQL & "  DB_MES25 * DB_OPERACION AS DB_MES25, "
			sSQL = sSQL & "  DB_MES26 * DB_OPERACION AS DB_MES26, "
			sSQL = sSQL & "  DB_MES27 * DB_OPERACION AS DB_MES27, "
			sSQL = sSQL & "  DB_MES28 * DB_OPERACION AS DB_MES28, "
			sSQL = sSQL & "  DB_MES29 * DB_OPERACION AS DB_MES29, "
			sSQL = sSQL & "  DB_MES30 * DB_OPERACION AS DB_MES30, "
			sSQL = sSQL & "  DB_MES31 * DB_OPERACION AS DB_MES31, "
			sSQL = sSQL & "  DB_MES32 * DB_OPERACION AS DB_MES32, "
			sSQL = sSQL & "  DB_MES33 * DB_OPERACION AS DB_MES33, "
			sSQL = sSQL & "  DB_MES34 * DB_OPERACION AS DB_MES34, "
			sSQL = sSQL & "  DB_MES35 * DB_OPERACION AS DB_MES35, "
			sSQL = sSQL & "  DB_MES36 * DB_OPERACION AS DB_MES36, "
			sSQL = sSQL & "  DB_MES37 * DB_OPERACION AS DB_MES37, "
			sSQL = sSQL & "  DB_MES38 * DB_OPERACION AS DB_MES38, "
			sSQL = sSQL & "  DB_MES39 * DB_OPERACION AS DB_MES39, "
			sSQL = sSQL & "  DB_MES40 * DB_OPERACION AS DB_MES40, "
			sSQL = sSQL & "  DB_MES41 * DB_OPERACION AS DB_MES41, "
			sSQL = sSQL & "  DB_MES42 * DB_OPERACION AS DB_MES42, "
			sSQL = sSQL & "  DB_MES43 * DB_OPERACION AS DB_MES43, "
			sSQL = sSQL & "  DB_MES44 * DB_OPERACION AS DB_MES44, "
			sSQL = sSQL & "  DB_MES45 * DB_OPERACION AS DB_MES45, "
			sSQL = sSQL & "  DB_MES46 * DB_OPERACION AS DB_MES46, "
			sSQL = sSQL & "  DB_MES47 * DB_OPERACION AS DB_MES47, "
			sSQL = sSQL & "  DB_MES48 * DB_OPERACION AS DB_MES48, "
			sSQL = sSQL & "  DB_MES49 * DB_OPERACION AS DB_MES49, "
			sSQL = sSQL & "  DB_MES50 * DB_OPERACION AS DB_MES50, "
			sSQL = sSQL & "  DB_MES51 * DB_OPERACION AS DB_MES51, "
			sSQL = sSQL & "  DB_MES52 * DB_OPERACION AS DB_MES52, "
			sSQL = sSQL & "  DB_MES53 * DB_OPERACION AS DB_MES53, "
			sSQL = sSQL & "  DB_MES54 * DB_OPERACION AS DB_MES54, "

			sSQL = sSQL &
				   "              DB_GENERATXT AS GENERATXT " &
				   "INTO          " & sTabla & "                " &
				   "FROM          DATBAN                 " &
				   "WHERE         DB_FECVIG = " & FechaSQL(dFecha) & " " &
				   "AND           DB_CODENT = " & CODIGO_ENTIDAD & " " &
				   "AND           DB_CUADRO IN (344,345) " &
				   "ORDER BY      DB_CUADRO, DB_CODPAR"
			oAdmLocal.EjecutarComandoSQL(sSQL)

			Return True

		Catch ex As Exception
			TratarError(ex, "PreparaTXT_5607")
		End Try

	End Function

	Private Sub GenerarPDF(ByVal nCod As Long, ByVal dFecha As Date)

		Dim sSQL As String
		Dim ds As DataSet
		Dim sRuta As String = ""
		Dim sRetorno As String = ""

		Try

			sSQL = "SELECT    DISTINCT CAST(0 AS BIT) AS [Sel.], " &
				   "          NO_SUBCOD AS [Sub. Cód.], " &
				   "          NO_TITULO AS [Título] " &
				   "FROM      NOTAS " &
				   "WHERE     NO_FECVIG = " & FechaSQL(dFecha) & " " &
				   "AND       NO_CUADRO = " & IIf(nCod = 2813, "'NOTASCYA'", "'NOTASSUP'")
			frmTablaGeneral.PasarInfo(sSQL, CONN_LOCAL, 2, True, "Notas")

			If frmTablaGeneral.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
				sRetorno = INPUT_GENERAL & ","
			Else
				Exit Try
			End If

			sSQL = "SELECT    * " &
				   "FROM      NOTAS " &
				   "WHERE     NO_FECVIG = " & FechaSQL(dFecha) & " " &
				   "AND       NO_CUADRO = " & IIf(nCod = 2813, "'NOTASCYA'", "'NOTASSUP'")
			ds = oAdmLocal.AbrirDataset(sSQL)

			With ds.Tables(0)

				For Each row As DataRow In .Rows

					If sRetorno.IndexOf(row("NO_SUBCOD").ToString & ",") <> -1 Then
						sRuta = NormalizarRuta(txtCarpeta.Text) & IIf(nCod = 2813, "P", "S") & Format(row("NO_CODIGO"), "000") & "_" & Format(row("NO_SUBCOD"), "000") & ".PDF"
						ConvertirRTFenPDFLocal(row("NO_DESCRI"), sRuta)
					End If

				Next

			End With

			MensajeInformacion("Notas generadas")

			If chkOpen.Checked Then
				Process.Start(sRuta)
			End If

			ds = Nothing

		Catch ex As Exception
			TratarError(ex, "GenerarPDF")
		End Try

	End Sub

	Private Function PreparaTXT_RESTO(ByVal sTabla As String, ByVal dFecha As Date) As Boolean

		Dim sSQL As String
		Dim nCuadro As Long

		Try

			If oAdmLocal.ExisteTabla(sTabla) Then
				oAdmLocal.EjecutarComandoSQL("DROP TABLE " & sTabla)
			End If

			nCuadro = oAdmLocal.DevolverValor("TXTREL", "TR_CUADRO", "TR_TABLATRABAJO = '" & sTabla & "' AND TR_ORDENTXT = 1", "")


			sSQL = "SELECT        DC_FECVIG     AS PERIODO,  " &
				   "              DC_FECVIG     AS FECHAVIG, " &
				   "              DC_CUADRO     AS CUADRO,   " &
				   "              DC_CODPAR     AS CODIGO,   " &
				   "              DC_CAMPO8     AS CAMPO8,   " &
				   "              DC_CODCON     AS CODCON,   " &
				   "              DC_MES1  * DC_OPERACION  AS IMPORTE,  " &
				   "              DC_GENERATXT  AS GENERATXT " &
				   "INTO          " & sTabla & " " &
				   "FROM          DATCUA                     " &
				   "WHERE         DC_FECVIG = " & FechaSQL(dFecha) & " " &
				   "AND           DC_CUADRO = " & nCuadro & " " &
				   "AND           DC_CODENT = " & CODIGO_ENTIDAD & " "
			oAdmLocal.EjecutarComandoSQL(sSQL)

			Return True

		Catch ex As Exception
			TratarError(ex, "PreparaTXT_RESTO")
		End Try

	End Function

	Private Function PreparaTXT_4401(ByVal sTabla As String, ByVal dFecha As Date) As Boolean

		Dim sSQL As String = ""

		Try

			If oAdmLocal.ExisteTabla(sTabla) Then
				oAdmLocal.EjecutarComandoSQL("DROP TABLE " & sTabla)
			End If

			sSQL = ""
			sSQL = sSQL & "SELECT      DC_FECVIG                  AS FECHAVIG,  " & vbCrLf
			sSQL = sSQL & "            DC_FECVIG                  AS PERIODO, " & vbCrLf
			sSQL = sSQL & "            DATEADD(year, -1, DC_FECVIG) AS PERIODO2, " & vbCrLf
			sSQL = sSQL & "            DC_CODPAR                  AS CODIGO,  " & vbCrLf
			sSQL = sSQL & "            DC_CODPAR                  AS PARTIDA,  " & vbCrLf
			sSQL = sSQL & "            DC_CAMPO8                  AS CAMPO8,   " & vbCrLf
			sSQL = sSQL & "            DC_CUADRO                  AS CUADRO,   " & vbCrLf
			sSQL = sSQL & "            DC_CODCON                  AS CODCON,   " & vbCrLf
			sSQL = sSQL & "            DC_MES0 * DC_OPERACION     AS DC_MES0,  " & vbCrLf
			sSQL = sSQL & "            DC_MES1 * DC_OPERACION     AS DC_MES1, " & vbCrLf
			sSQL = sSQL & "            DC_MES2 * DC_OPERACION     AS DC_MES2, " & vbCrLf
			sSQL = sSQL & "            DC_MES3 * DC_OPERACION     AS DC_MES3, " & vbCrLf
			sSQL = sSQL & "            DC_MES4 * DC_OPERACION     AS DC_MES4, " & vbCrLf
			sSQL = sSQL & "            DC_MES5 * DC_OPERACION     AS DC_MES5, " & vbCrLf
			sSQL = sSQL & "            DC_MES6 * DC_OPERACION     AS DC_MES6, " & vbCrLf
			sSQL = sSQL & "            DC_MES7 * DC_OPERACION     AS DC_MES7, " & vbCrLf
			sSQL = sSQL & "            DC_MES8 * DC_OPERACION     AS DC_MES8, " & vbCrLf
			sSQL = sSQL & "            DC_MES9 * DC_OPERACION     AS DC_MES9, " & vbCrLf
			sSQL = sSQL & "            DC_MES10 * DC_OPERACION    AS DC_MES10, " & vbCrLf
			sSQL = sSQL & "            DC_MES11 * DC_OPERACION    AS DC_MES11, " & vbCrLf
			sSQL = sSQL & "            DC_ALFA01                  AS DC_ALFA01, " & vbCrLf
			sSQL = sSQL & "            DC_ALFA02                  AS DC_ALFA02, " & vbCrLf
			sSQL = sSQL & "            DC_ALFA03                  AS DC_ALFA03, " & vbCrLf
			sSQL = sSQL & "            DC_ALFA04                  AS DC_ALFA04, " & vbCrLf
			sSQL = sSQL & "            DC_FECH01                  AS DC_FECH01, " & vbCrLf
			sSQL = sSQL & "            DC_GENERATXT               AS GENERATXT " & vbCrLf
			sSQL = sSQL & "INTO        TXT4401                 " & vbCrLf
			sSQL = sSQL & "FROM        DATCUA                  " & vbCrLf
			sSQL = sSQL & "WHERE       DC_FECVIG = @FECVIG     " & vbCrLf
			sSQL = sSQL & "AND         DC_CODENT = @CODENT     " & vbCrLf
			sSQL = sSQL & "AND         (DC_CUADRO BETWEEN 7101 AND 7115 " & vbCrLf
			sSQL = sSQL & "OR           DC_CUADRO BETWEEN 7001 AND 7004) " & vbCrLf
			sSQL = Replace(sSQL, "@FECVIG", FechaSQL(dFecha))
			sSQL = Replace(sSQL, "@CODENT", CODIGO_ENTIDAD)

			oAdmLocal.EjecutarComandoSQL(sSQL)

			Return True

		Catch ex As Exception
			TratarError(ex, "PreparaTXT_4401")
		End Try

	End Function


	Private Function PreparaTXT_Dinamico(ByVal nCodigo As Long,
										 ByVal dFecha As Date) As Boolean

		Dim sSQL As String
		Dim ds As DataSet
		Dim sError As String

		Try

			sSQL = "SELECT * FROM TXTNOM WHERE TN_CODIGO = " & nCodigo
			ds = oAdmLocal.AbrirDataset(sSQL)

			sSQL = ""

			If ds.Tables(0).Rows.Count > 0 Then
				sSQL = Encoding.UTF8.GetString(Convert.FromBase64String(ds.Tables(0).Rows(0).Item("TN_PROCES"))) 'sBase64Decode(ds.Tables(0).Rows(0).Item("TN_PROCES"))
			End If

			sSQL = Replace(sSQL, "@FECDES", FechaSQL(dFecha.AddDays((dFecha.Day) * -1 + 1)))
			sSQL = Replace(sSQL, "@FECHAS", FechaSQL(dFecha))
			sSQL = Replace(sSQL, "@FECVIG", FechaSQL(dFecha))
			sSQL = Replace(sSQL, "@CODENT", CODIGO_ENTIDAD)

			If Not oAdmLocal.EjecutarComandoAsincrono(sSQL, sError) Then
				MensajeError(sError)
			End If

			ds = Nothing

			Return True

		Catch ex As Exception
			TratarError(ex, "PreparaTXT_Dinamico")
		End Try

	End Function

	Private Sub ConvertirHTMLenPDFLocal(ByVal sRutaHTML As String, ByVal sRutaPDF As String, Optional ByVal bVertical As Boolean = True)

		Dim oDoc As WebSupergoo.ABCpdf7.Doc
		Dim oId As Long
		Dim w, h, l, b, i As Long

		Try

			oDoc = New WebSupergoo.ABCpdf7.Doc

			oDoc.Rect.Inset(50, 15)

			If Not bVertical Then

				w = oDoc.MediaBox.Width
				h = oDoc.MediaBox.Height
				l = oDoc.MediaBox.Left
				b = oDoc.MediaBox.Bottom
				oDoc.Transform.Rotate(90, l, b)
				oDoc.Transform.Translate(w, 0)

				' rotate our rectangle
				oDoc.Rect.Width = h
				oDoc.Rect.Height = w

			End If

			oId = oDoc.AddImageUrl("file:///" & Replace(sRutaHTML, "\", "/"), True, 0, True)

			Do
				'oDoc.FrameRect

				If oDoc.GetInfo(oId, "Truncated") <> "1" Then
					Exit Do
				End If

				oDoc.Page = oDoc.AddPage()
				oId = oDoc.AddImageToChain(oId)
				Application.DoEvents()

			Loop

			For i = 1 To oDoc.PageCount
				oDoc.PageNumber = i
				oDoc.Flatten()
			Next

			oDoc.Save(sRutaPDF)

			oDoc = Nothing

			Exit Sub

		Catch ex As Exception
			TratarError(ex, "ConvertirHTMLenPDFLocal")
		End Try

	End Sub

	Private Sub ConvertirRTFenPDFLocal(ByVal sRTF As String, ByVal sRutaPDF As String, Optional ByVal bVertical As Boolean = True)

		Dim oDoc As Object = Nothing
		Dim oApp As Object = Nothing
		Dim sArchivoRTF As String = ""
		Dim bAbierto As Boolean

		Try

			oApp = CreateObject("Word.Application")
			oDoc = CreateObject("Word.Document")

			sArchivoRTF = NormalizarRuta(CARPETA_LOCAL) & "TEMP\" & NombreArchivo(Application.ExecutablePath) & ".RTF"

			If ArchivoExiste(sArchivoRTF) Then
				Kill(sArchivoRTF)
			End If

			File.WriteAllText(sArchivoRTF, sRTF)

			oDoc = oApp.Documents.Open(sArchivoRTF)

			bAbierto = True

			With oApp.ActiveDocument.PageSetup
				.TopMargin = 50
				.LeftMargin = 50
				.RightMargin = 50
				.BottomMargin = 50
			End With

			oDoc.SaveAs(sArchivoRTF & ".HTML", 10)

			oDoc.Close(False)
			bAbierto = False

			Application.DoEvents()
			ConvertirHTMLenPDFLocal(sArchivoRTF & ".html", sRutaPDF, bVertical)

		Catch ex As Exception
			TratarError(ex, "RTF_HTML")
		End Try

		If bAbierto Then
			oDoc.Close(False)
		End If

		oDoc = Nothing
		oApp = Nothing

	End Sub

	Private Sub CargarArchivos()

		Dim sSQL As String
		Dim ds As DataSet
		Try
			RemoveHandler cboArchivos.SelectedIndexChanged, AddressOf cboArchivos_SelectedIndexChanged
			Try

				sSQL = "SELECT * " &
				"FROM TXTNOM " &
				"ORDER BY TN_NOMBRETXT"

				ds = oAdmLocal.AbrirDataset(sSQL)
				cboArchivos.Items.Clear()
				cboArchivos.Items.Add(New Prex.Utils.Entities.clsItem("", "<Seleccionar ...>"))
				Dim listNombres As New List(Of String)
				With ds.Tables(0)

					For Each row As DataRow In .Rows
						If listNombres.Contains(row("TN_NOMBRETXT").ToString) Then
							Continue For
						End If
						Dim item As New Prex.Utils.Entities.clsItem(row("TN_CODIGO"), row("TN_NOMBRETXT"))
						If Not row("TN_PERIOD") Is DBNull.Value Then item.Periodo = row("TN_PERIOD").ToString

						cboArchivos.Items.Add(item)
						listNombres.Add(item.Nombre)
					Next

				End With

				ds = Nothing

				If cboArchivos.Items.Count > 0 Then
					cboArchivos.SelectedIndex = 0
				End If

			Catch ex As Exception
				TratarError(ex, "CargarArchivos")
			End Try

		Finally
			AddHandler cboArchivos.SelectedIndexChanged, AddressOf cboArchivos_SelectedIndexChanged
		End Try
	End Sub

	Private Sub IniciarControles()

		Dim i As Integer
		Dim oFecha As Date = Date.Today

		For i = 1 To 31
			cboDia.Items.Add(New Prex.Utils.Entities.clsItem(i, i))
		Next
		cboDia.SelectedIndex = 0

		For i = 1 To 12
			cboMes.Items.Add(New Prex.Utils.Entities.clsItem(i, MonthName(i).ToUpper))
		Next

		For i = oFecha.Year - 10 To oFecha.Year + 10
			cboAno.Items.Add(New Prex.Utils.Entities.clsItem(i, i.ToString))
		Next

		ResetFecha(oFecha)
	End Sub

	Private Sub ResetFecha(ByVal oFecha As Date)
		If oFecha.Month <= 3 Then
			cboAno.Text = oFecha.Year - 1
			cboMes.SelectedIndex = 11
		Else
			cboAno.Text = oFecha.Year
			cboMes.SelectedIndex = oFecha.Month - 2
		End If

	End Sub

	Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
		Me.Close()
	End Sub

	Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click

		Dim oDlg As New FolderBrowserDialog

		If oDlg.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
			txtCarpeta.Text = oDlg.SelectedPath
		End If

	End Sub

	Private Sub cmdGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerar.Click

		Dim oItem As Prex.Utils.Entities.clsItem
		Dim sSQL As String
		Dim nCont As Integer
		Try
			Me.Cursor = Cursors.WaitCursor
			'Agregado para usar un SP que grabe en otro lado - 2013/10/03

			Dim nRutPre = oAdmLocal.DevolverValor("TABGEN", "ISNULL(TG_NUME01, 0)", " TG_CODTAB = 10 AND TG_CODCON = 10", "")

			Dim sRutaPrevia = oAdmLocal.DevolverValor("TABGEN", "ISNULL(TG_ALFA01, '')", " TG_CODTAB = 10 AND TG_CODCON = 10")

			' FIN AGREGADO SP

			If DatosOK() Then

				Dim dFecPro As Date

				If IsArchivoPorDia Then
					dFecPro = New Date(cboAno.Text, MesSeleccionado, cboDia.Text)
				Else
					dFecPro = FechaCorrecta(MesSeleccionado, Val(cboAno.Text))
				End If

				If (Val(LlaveCombo(cboArchivos)) >= 4300 And
					Val(LlaveCombo(cboArchivos)) <= 4399) Or
						 (Val(LlaveCombo(cboArchivos)) >= 3901 And
					Val(LlaveCombo(cboArchivos)) <= 3903) Or
						 (Val(LlaveCombo(cboArchivos)) >= 2900 And
					Val(LlaveCombo(cboArchivos)) <= 2910) Then

					nCont = 1

					'Programado para soportar TXTs de más de un diseño
					sSQL = "SELECT    DISTINCT TN_CODIGO " &
							"FROM      TXTNOM " &
							"WHERE     UPPER(TN_NOMBRETXT) = '" & UCase(LTrim(RTrim(cboArchivos.Text))) & "' " &
							"ORDER BY  TN_CODIGO"

					Dim rstAux As DataSet = oAdmLocal.AbrirDataset(sSQL)
					With rstAux.Tables(0)

						For Each row As DataRow In .Rows
							GenerarTXTMultiple(Long.Parse(row("TN_CODIGO").ToString()), dFecPro, Val(.Rows.Count), nCont)
							nCont = nCont + 1
						Next

					End With

					rstAux = Nothing
				Else
					oItem = cboArchivos.SelectedItem
					GenerarTXT(Long.Parse(oItem.Valor.ToString()), dFecPro)
				End If

			End If
		Finally
			Me.Cursor = Cursors.Default
		End Try
	End Sub

	Private Sub GenerarTXTMultiple(ByVal nCod As Long, ByVal dFecha As Date, nReg As Integer, nPosic As Integer)

		Dim sCampo As String
		Try
			Me.Cursor = Cursors.WaitCursor
			Try

				cmdGenerar.Enabled = False

				Dim dFechaReal = dFecha
				Dim oText As StreamWriter
				Dim sFile = txtCarpeta.Text & cboArchivos.Text
				If nPosic = 1 Then
					If File.Exists(sFile) Then
						File.Delete(sFile)
					End If
					oText = File.CreateText(sFile)
				Else
					oText = File.AppendText(sFile)
				End If


				Dim sSQL = "SELECT MAX(TR_FECHAVIG) AS MAX_FECHA " &
					   "FROM TXTREL " &
					   "WHERE TR_FECHAVIG <= " & FechaSQL(dFecha) & " " &
					   "AND TR_CODIGO = " & nCod

				Dim rstTemp As DataSet = oAdmLocal.AbrirDataset(sSQL)
				With rstTemp.Tables(0)
					If .Rows.Count = 0 Then
Salir:
						MensajeError("No existe el diseño para la fecha ingresada")
						Exit Sub
					Else
						If .Rows(0).Item("MAX_FECHA") Is DBNull.Value Then
							GoTo Salir
						Else
							dFechaProx = .Rows(0).Item("MAX_FECHA")
						End If
					End If
				End With

				rstTemp = Nothing

				sSQL = "SELECT DISTINCT TR_CUADRO, TR_TABLATRABAJO FROM TXTREL " &
					  "WHERE TR_CODIGO = " & nCod & " " &
					  "AND TR_FECHAVIG = " & FechaSQL(dFechaProx) & " " &
					  "ORDER BY TR_CUADRO ASC"

				Dim rstCuadros = oAdmLocal.AbrirDataset(sSQL)

				' Ver formato ----------

				sSQL = "SELECT   * " &
					 "FROM     TXTDIS " &
					 "WHERE    TD_CODIGO = " & nCod & " " &
					 "AND      TD_FECHAVIG = " & FechaSQL(dFechaProx) & " " &
					 "ORDER BY TD_ORDEN"

				Dim rstFormato As DataSet = oAdmLocal.AbrirDataset(sSQL)

				Formato.Clear()
				Dim oForm As clsFormato
				With rstFormato.Tables(0)

					For Each row As DataRow In .Rows

						oForm = New clsFormato

						oForm.Codigo = row("TD_CODIGO")
						oForm.Decimales = row("TD_CANTDECIMALES")
						oForm.Descripcion = row("TD_DESCRIPCION")
						oForm.Fecha = row("TD_FECHAVIG")
						oForm.FormatoCampo = "" & row("TD_FORMATO")
						oForm.Inicio = row("TD_INICIO")
						oForm.Longitud = row("TD_LONGITUD")
						oForm.Tipo = row("TD_TIPO")
						oForm.Key = "K" & row("TD_ORDEN")

						If oForm.FormatoCampo = "yyyymmdd" Then oForm.FormatoCampo = "yyyyMMdd"
						If oForm.FormatoCampo = "yyyymm" Then oForm.FormatoCampo = "yyyyMM"

						Formato.Add(oForm, oForm.Key)

						oForm = Nothing

					Next

				End With

				rstFormato = Nothing

				'-- Generar TXT
				Dim sTabla = rstCuadros.Tables(0).Rows(0).Item("TR_TABLATRABAJO")

				'-- Generar Tabla de Trabajo
				If Not (PreparaTxt(dFechaReal, sTabla, nCod)) Then
					cmdGenerar.Enabled = True
					lblStatus.Text = ""
					Me.Cursor = Cursors.Default
					Exit Sub
				End If
				lblStatus.Text = "Procesando..."
				lblStatus.Visible = True

				Dim sCuadro As String
				Dim sLine As String = ""
				Dim rstTrabajo As DataSet
				Dim rstAux As DataSet
				Dim nOrden As Integer
				Dim vDato As Object
				Dim dNewValue As Date
				Dim j As Long

				For Each row As DataRow In rstCuadros.Tables(0).Rows

					sCuadro = row("TR_CUADRO")

					sSQL = "SELECT       * " &
							"FROM         " & sTabla & " " &
							"WHERE        FECHAVIG = " & FechaSQL(dFecha) & " " &
							"AND          CUADRO = '" & sCuadro & "' " &
							"AND          GENERATXT = 1 " &
										  FiltroTablaTrabajo(sTabla) & " " &
							"ORDER BY     CODIGO, CAMPO8, PERIODO"
					rstTrabajo = oAdmLocal.AbrirDataset(sSQL)

					sSQL = "SELECT       * " &
							"FROM         TXTREL " &
							"WHERE        TR_CODIGO = " & nCod & " " &
							"AND          TR_CUADRO = '" & sCuadro & "' " &
							"AND          TR_FECHAVIG = " & FechaSQL(dFechaProx) & " " &
							"ORDER BY     TR_ORDENTXT ASC"
					rstAux = oAdmLocal.AbrirDataset(sSQL)
					If rstTrabajo IsNot Nothing Then
						For Each rowTrabajo As DataRow In rstTrabajo.Tables(0).Rows
							For Each rowAux As DataRow In rstAux.Tables(0).Rows
								nOrden = rowAux("TR_ORDENTXT")
								If "" & rowAux("TR_CAMPOTRABAJO") = "" Then ' Dato fijo !!
									If InStr(1, "" & rowAux("TR_DATOFIJO"), "[") > 0 Then
										Select Case "" & rowAux("TR_DATOFIJO")
											Case "[RECTIFICATIVA]"
												sLine = sLine & IIf(chkRectivicativa.Checked, "R", "N")
											Case "[ENTIDAD]"
												sLine = sLine & Format(CODIGO_ENTIDAD, Strings.Left(CType(Formato(nOrden), clsFormato).FormatoCampo, CType(Formato(nOrden), clsFormato).Longitud))
										End Select
									Else
										Select Case CType(Formato(nOrden), clsFormato).Tipo
											Case "N"
												If IsNumeric(rowAux("TR_DATOFIJO")) Then
													sLine = sLine & Format(Val(rowAux("TR_DATOFIJO")), Strings.Left(CType(Formato(nOrden), clsFormato).FormatoCampo, CType(Formato(nOrden), clsFormato).Longitud))
												ElseIf IsDate(rowAux("TR_DATOFIJO")) Then
													sLine = sLine & Format(CDate(rowAux("TR_DATOFIJO")), Strings.Left(CType(Formato(nOrden), clsFormato).FormatoCampo, CType(Formato(nOrden), clsFormato).Longitud))
												Else
													sLine = sLine & Format(NoNulo(rowAux("TR_DATOFIJO")), Strings.Left(CType(Formato(nOrden), clsFormato).FormatoCampo, CType(Formato(nOrden), clsFormato).Longitud))
												End If
											Case "F"
												If NoNulo(rowAux("TR_DATOFIJO"), False) = 0 Then
													sLine = sLine & New String("0", CType(Formato(nOrden), clsFormato).Longitud)
												Else
													sLine = sLine & Format(CDate(rowAux("TR_DATOFIJO")), Strings.Left(CType(Formato(nOrden), clsFormato).FormatoCampo, CType(Formato(nOrden), clsFormato).Longitud))
												End If
											Case Else
												sLine = sLine & RellenarCadena(Trim("" & rowAux("TR_DATOFIJO")), CType(Formato(nOrden), clsFormato).Longitud)
										End Select
									End If
									' Ver rutina --------
								Else
									sCampo = rowAux("TR_CAMPOTRABAJO")

									Select Case CType(Formato(nOrden), clsFormato).Tipo
										Case "N"
											vDato = Val(rowTrabajo(sCampo))
											If CType(Formato(nOrden), clsFormato).Decimales > 0 Then
												sLine = sLine & Format(vDato * Val("1" & "".PadLeft(CType(Formato(nOrden), clsFormato).Decimales, "0")), CType(Formato(nOrden), clsFormato).FormatoCampo)
											Else
												If vDato >= 0 Then
													sLine = sLine & (IIf(vDato = 0 AndAlso CType(Formato(nOrden), clsFormato).FormatoCampo = String.Empty, String.Empty, Format(vDato, CType(Formato(nOrden), clsFormato).FormatoCampo)))
												Else
													sLine = sLine & Format(vDato, Strings.Right(CType(Formato(nOrden), clsFormato).FormatoCampo, CType(Formato(nOrden), clsFormato).Longitud - 1))
												End If
											End If

											If Strings.Right(rowAux("TR_DATOFIJO").ToString, 1) = ";" Then
												sLine = sLine & ";"
											End If
										Case "T"

											If Strings.Right(rowAux("TR_DATOFIJO").ToString, 1) = ";" Then ' Right("" & rowAux("TR_DATOFIJO", 1) = ";" Then
												vDato = rowTrabajo(sCampo).ToString.Trim
												sLine = sLine & vDato.ToString & ";"
											ElseIf Strings.Right(rowAux("TR_DATOFIJO").ToString, 2) = "||" Then 'Right("" & rstAux!TR_DATOFIJO, 2) = "||" Then
												vDato = rowTrabajo(sCampo).ToString.Trim
												sLine = sLine & vDato.ToString & ""
											Else
												vDato = Trim(rowTrabajo(sCampo).ToString)
												sLine = sLine & RellenarCadena(vDato, CType(Formato(nOrden), clsFormato).Longitud)
											End If
										Case "F"
											vDato = NoNulo(rowTrabajo(sCampo))
											Select Case rowAux("TR_DATOFIJO").ToString
												Case "[PERIODOANT]"
													dNewValue = UnAnioMenos(DateTime.Parse(vDato.ToString))
													sLine = sLine & Format(dNewValue, Formato(nOrden).FORMATOCAMPO)
												Case Else ' VACIO !!
													If vDato.ToString = "0" Then
														If Strings.Right(rowAux("TR_DATOFIJO").ToString, 1) = ";" Then
															sLine = sLine
														Else
															sLine = sLine & Format(vDato, "".PadLeft(Len(Formato(nOrden).FORMATOCAMPO), "0"))
														End If
													Else
														sLine = sLine & Format(vDato, Formato(nOrden).FORMATOCAMPO)
													End If
											End Select

											If Strings.Right(rowAux("TR_DATOFIJO").ToString, 1) = ";" Then
												sLine = sLine & ";"
											End If
									End Select
								End If
							Next

							j = j + 1
							oText.WriteLine(sLine)
							sLine = ""
							lblStatus.Text = "Procesados: " & j.ToString & " ..."

							Application.DoEvents()
							Threading.Thread.Sleep(10)

						Next
						rstTrabajo = Nothing
					End If
					rstAux = Nothing
				Next

				oText.Close()
				oText = Nothing

				rstCuadros = Nothing

				Dim sArchFTP As String

				If nPosic = nReg Then
					cmdGenerar.Enabled = True

					'Agregado para que grabe en un servidor FTP - 2014/08/26
					'SOLO METROPOLIS
					If CODIGO_ENTIDAD = 44068 Or CODIGO_ENTIDAD = 432 Then
						Try

							sArchFTP = cboArchivos.Text

							Dim request As FtpWebRequest = WebRequest.Create("192.9.200.249/proyex/" + CStr(Year(dFechaReal) * 100 + Month(dFechaReal)) + "/")
							request.Method = WebRequestMethods.Ftp.UploadFile
							request.Credentials = New NetworkCredential("reginf", "metropolis")
							Dim sourceStream As New StreamReader(sArchFTP)
							Dim fileContents = Encoding.UTF8.GetBytes(sFile)
							sourceStream.Close()
							request.ContentLength = fileContents.Length

							Dim requestStream As Stream = request.GetRequestStream()
							requestStream.Write(fileContents, 0, fileContents.Length)
							requestStream.Close()

							Dim response As FtpWebResponse = request.GetResponse()

							response.Close()

							'SubirFTP "192.9.200.249", "/proyex/" + CStr(Year(dFechaReal) * 100 + Month(dFechaReal)) + "/", "reginf", "metropolis", sFile, sArchFTP
						Catch ex As Exception
							GuardarLOG(AccionesLOG.AL_ERROR_SISTEMA, "Error al enviar arvhico a ftp " & vbCrLf & ex.Message, CODIGO_TRANSACCION, UsuarioActual.Codigo)
						End Try

					End If

					GrabarLog(sFile, dFechaReal, j)

					MensajeInformacion("Proceso finalizado")
					'Me.lblStatus.Visible = True

					If chkOpen.Checked Then
						Process.Start(sFile)
					End If

				End If

			Catch ex As Exception
				TratarError(ex, "GenerarTXTMultiple", "Campo: " & sCampo & vbCrLf & Err.Description)
				lblStatus.Text = ""
			End Try
		Finally
			Me.Cursor = Cursors.Default
		End Try
	End Sub

	Private Sub GrabarLog(sFile As String, ByVal dFechaReal As Date, ByVal j As Integer)

		Dim nGrabaSegTXT = IIf(oAdmLocal.DevolverValor("TABGEN", "ISNULL(TG_NUME02, 0)", " TG_CODTAB = 3 AND TG_CODCON = 60", -9999) = -9999, 0,
								   oAdmLocal.DevolverValor("TABGEN", "ISNULL(TG_NUME02, 0)", " TG_CODTAB = 3 AND TG_CODCON = 60", ""))

		If nGrabaSegTXT = 1 Then
			AdjuntarArchivo(sFile,
										 Strings.Left(cboArchivos.Text, InStr(1, cboArchivos.Text, ".", vbTextCompare) - 1) & "_" & DateTime.Now.Year * 10000 + DateTime.Now.Month * 100 + DateTime.Now.Day & "_" & Strings.Right("00" & DateTime.Now.Hour, 2) & ":" & Strings.Right("00" & DateTime.Now.Minute, 2),
										 Strings.Left(cboArchivos.Text, InStr(1, cboArchivos.Text, ".", vbTextCompare) - 1) & "_" & CStr(Year(dFechaReal) * 100 + Month(dFechaReal)) & "_" & IIf(chkRectivicativa.Checked = True, "R", "N"))

		End If

		' FIN AGREGADO TXTADJ

		'Agregado para que genere LOG

		If chkRectivicativa.Checked = False And nGenerado = 0 Then
			GuardarLOG(61, "Archivo: " + cboArchivos.Text + ", Ruta: " + txtCarpeta.Text + ", Período: " + CStr(dFechaReal) + ", Filas: " + Str(j), CODIGO_TRANSACCION, UsuarioActual.Codigo)
		ElseIf chkRectivicativa.Checked = False And nGenerado >= 1 Then
			GuardarLOG(63, "Archivo Nro.(" + Str(nGenerado) + "): " + cboArchivos.Text + ", Ruta: " + txtCarpeta.Text + ", Período: " + CStr(dFechaReal) + ", Filas: " + Str(j), CODIGO_TRANSACCION, UsuarioActual.Codigo)
		ElseIf chkRectivicativa.Checked = True And nGenerado = 0 Then
			GuardarLOG(62, "Archivo: " + cboArchivos.Text + ", Ruta: " + txtCarpeta.Text + ", Período: " + CStr(dFechaReal) + ", Filas: " + Str(j), CODIGO_TRANSACCION, UsuarioActual.Codigo)
		ElseIf chkRectivicativa.Checked = True And nGenerado >= 1 Then
			GuardarLOG(64, "Archivo Nro.(" + Str(nGenerado) + "): " + cboArchivos.Text + ", Ruta: " + txtCarpeta.Text + ", Período: " + CStr(dFechaReal) + ", Filas: " + Str(j), CODIGO_TRANSACCION, UsuarioActual.Codigo)
		End If
		' FIN AGREGADO para que genere LOG

	End Sub

	'    Private Sub SubirFTP(ByVal sFTPSrvr As String, sDirName As String,
	'                           sLogin As String, sPassword As String,
	'                           sFn As String, sTarget As String)
	'        On Error GoTo Err_Trap

	'        Dim hConnection As Long, hOpen As Long, sOrgPath As String

	'        'open an internet connection
	'        hOpen = InternetOpen("vb wininet", INTERNET_OPEN_TYPE_PRECONFIG, vbNullString, vbNullString, 0)

	'        'connect to the FTP server
	'        hConnection = InternetConnect(hOpen, sFTPSrvr, INTERNET_DEFAULT_FTP_PORT, sLogin,
	'sPassword, INTERNET_SERVICE_FTP, IIf(PassiveConnection, INTERNET_FLAG_PASSIVE, 0), 0)

	'        'create a buffer to store the original directory
	'        sOrgPath = String(MAX_PATH, 0)

	'        'get the directory
	'        FtpGetCurrentDirectory hConnection, sOrgPath, Len(sOrgPath)

	''Create the directory
	'        FtpCreateDirectory hConnection, sDirName

	''set the current directory
	'        FtpSetCurrentDirectory hConnection, sDirName

	''delete the file from the FTP server
	'        FtpDeleteFile hConnection, sTarget

	''upload the file
	'        FtpPutFile hConnection, sFn, sTarget, FTP_TRANSFER_TYPE_UNKNOWN, 0

	''set the current directory back to the root
	'        FtpSetCurrentDirectory hConnection, sOrgPath

	''close the FTP connection
	'        InternetCloseHandle hConnection

	''close the internet connection
	'        InternetCloseHandle hOpen

	'Err_Trap:

	'        Exit Sub

	'    End Sub


	Private Function AdjuntarArchivo(ByVal sArchivo As String, sClave As String, sDescri As String) As Boolean

		Dim sSQL As String
		Dim nProx As Long
		Try
			Me.Cursor = Cursors.WaitCursor
			Try

				AdjuntarArchivo = False

				nProx = oAdmLocal.ProximoID("TXTADJ", "AD_CODADJ")

				Dim cmd As New SqlCommand("INSERT INTO TXTADJ (AD_CODADJ, AD_TIPREG, AD_NROREG, AD_DESCRI, AD_CLAVE , AD_NOMBRE, AD_ARCHIV) " &
									  "values (@AD_CODADJ, 1, 0, @AD_DESCRI, @AD_CLAVE, @AD_NOMBRE, @AD_ARCHIV)")
				cmd.Parameters.Add("AD_CODADJ", SqlDbType.Int).Value = nProx
				cmd.Parameters.Add("AD_DESCRI", SqlDbType.VarChar, 255).Value = sDescri
				cmd.Parameters.Add("AD_CLAVE", SqlDbType.VarChar, 1000).Value = sClave
				cmd.Parameters.Add("AD_ARCHIV", SqlDbType.Image).Value = System.IO.File.ReadAllBytes(sArchivo)
				cmd.Parameters.Add("AD_NOMBRE", SqlDbType.VarChar, 255).Value = modArchivos.NombreArchivo(sArchivo)


				oAdmLocal.EjecutarComandoSQL(cmd)

				Return True
			Catch ex As Exception
				TratarError(ex, "AdjuntarArchivo")
			End Try

		Finally
			Me.Cursor = Cursors.Default
		End Try

	End Function


	Private Function DatosOK() As Boolean

		Dim bTemp As Boolean

		If cboArchivos.SelectedItem Is Nothing Then
			MensajeError("Seleccione el archivo TXT a generar")
			cboArchivos.Focus()
			Exit Function
		End If

		If txtCarpeta.Text.Trim = "" Or Not Directory.Exists(txtCarpeta.Text) Then
			MensajeError("La carpeta seleccionada no es válida o no ha sido creada")
			txtCarpeta.Focus()
			Exit Function
		End If


		If IsArchivoPorDia Then
			Dim d As Date
			Try
				d = New Date(cboAno.Text, MesSeleccionado, cboDia.Text)
			Catch ex As System.ArgumentOutOfRangeException
				MensajeError("La fecha es invalida")
				cboDia.SelectAll()
				Exit Function
			End Try
		End If

		txtCarpeta.Text = NormalizarRuta(txtCarpeta.Text)

		bTemp = File.Exists(txtCarpeta.Text & cboArchivos.Text)

		If bTemp Then
			If MsgBox("El archivo ya existe. ¿Desea sobreescribirlo?", vbQuestion + vbYesNo + vbDefaultButton2, "Pregunta") = vbNo Then
				Exit Function
			End If
		End If

		'Verifica si ya fue generado el archivo como normal!!!
		If oAdmLocal.ExisteTabla("TXTADJ") Then

			Dim dFecPro As Date

			If IsArchivoPorDia Then
				dFecPro = New Date(cboAno.Text, MesSeleccionado, cboDia.Text)
			Else
				dFecPro = FechaCorrecta(MesSeleccionado, Val(cboAno.Text)) 'FechaCorrecta(DatoItemCombo(cboMes), Val(cboAnio.Text))
			End If

			nGenerado = Val(oAdmLocal.DevolverValor("TXTADJ (NOLOCK)", "ISNULL(COUNT(*), 0)",
					  " AD_DESCRI = '" & Strings.Left(cboArchivos.Text, InStr(1, cboArchivos.Text, ".", vbTextCompare) - 1) & "_" & CStr(Year(dFecPro) * 100 + Month(dFecPro)) & "_N'", ""))

			If nGenerado = 0 And chkRectivicativa.Checked = True Then
				MensajeInformacion("El archivo NO fue generado como NORMAL. Quite la marca de Rectificativa!")
				Exit Function
			End If

			If nGenerado > 0 And chkRectivicativa.Checked = False Then
				If MsgBox("El archivo ya fue generado como NORMAL. Volverá a generarlo?", vbQuestion + vbYesNo + vbDefaultButton2, "Pregunta") = vbNo Then
					Exit Function
				End If
			End If

		End If

		Return True

	End Function

	Private Sub GenerarTXT(ByVal nCod As Long, ByVal dFecha As Date)

		Dim oText As StreamWriter
		Dim sFile As String
		Dim sSQL As String
		Dim rstTemp As DataSet
		Dim rstCuadros As DataSet
		Dim rstAux As DataSet
		Dim rstTrabajo As DataSet
		Dim rstFormato As DataSet
		Dim sTabla As String
		Dim sCampo As String
		Dim sCuadro As String
		Dim sLine As String = ""
		Dim dNewValue As Date
		Dim vDato As Object
		Dim j As Long
		Dim nOrden As Integer
		Dim dFechaReal As Date
		Dim oForm As clsFormato
		Dim procesoFin = False
		'      Try

		Me.Cursor = Cursors.WaitCursor
		cmdGenerar.Enabled = False

		dFechaReal = dFecha

		sFile = txtCarpeta.Text & cboArchivos.Text
		If File.Exists(sFile) Then
			File.Delete(sFile)
		End If
		oText = File.CreateText(sFile)
		Try

			sSQL = "SELECT    MAX(TR_FECHAVIG) AS MAX_FECHA " &
			   "FROM      TXTREL " &
			   "WHERE     TR_FECHAVIG <= " & FechaSQL(dFecha) & " " &
			   "AND       TR_CODIGO = " & nCod

			rstTemp = oAdmLocal.AbrirDataset(sSQL)
			If rstTemp IsNot Nothing Then

				With rstTemp.Tables(0)
					If .Rows.Count = 0 Then
Salir:
						MensajeError("No existe el diseño para la fecha ingresada")
						Exit Sub
					Else
						If .Rows(0).Item("MAX_FECHA") Is DBNull.Value Then
							GoTo Salir
						Else
							dFechaProx = .Rows(0).Item("MAX_FECHA")
						End If
					End If
				End With
			Else

				MensajeError("No existe el diseño para la fecha ingresada")
				Exit Sub
			End If

			rstTemp = Nothing

			sSQL = "SELECT    DISTINCT TR_CUADRO, TR_TABLATRABAJO " &
			   "FROM      TXTREL " &
			   "WHERE     TR_CODIGO = " & nCod & " " &
			   "AND       TR_FECHAVIG = " & FechaSQL(dFechaProx) & " " &
			   "ORDER BY  TR_CUADRO ASC"

			rstCuadros = oAdmLocal.AbrirDataset(sSQL)

			' Ver formato ----------

			sSQL = "SELECT   * " &
			   "FROM     TXTDIS " &
			   "WHERE    TD_CODIGO = " & nCod & " " &
			   "AND      TD_FECHAVIG = " & FechaSQL(dFechaProx) & " " &
			   "ORDER BY TD_ORDEN"

			rstFormato = oAdmLocal.AbrirDataset(sSQL)

			Formato.Clear()

			With rstFormato.Tables(0)

				For Each row As DataRow In .Rows

					oForm = New clsFormato

					oForm.Codigo = row("TD_CODIGO")
					oForm.Decimales = row("TD_CANTDECIMALES")
					oForm.Descripcion = row("TD_DESCRIPCION")
					oForm.Fecha = row("TD_FECHAVIG")
					oForm.FormatoCampo = "" & row("TD_FORMATO")
					oForm.Inicio = row("TD_INICIO")
					oForm.Longitud = row("TD_LONGITUD")
					oForm.Tipo = row("TD_TIPO")
					oForm.Key = "K" & row("TD_ORDEN")

					If oForm.FormatoCampo = "yyyymmdd" Then oForm.FormatoCampo = "yyyyMMdd"
					If oForm.FormatoCampo = "yyyymm" Then oForm.FormatoCampo = "yyyyMM"

					If Not Formato.Contains(oForm.Key) Then

						Formato.Add(oForm, oForm.Key)
					End If

					oForm = Nothing

				Next

			End With

			rstFormato = Nothing

			If rstCuadros IsNot Nothing AndAlso rstCuadros.Tables(0) IsNot Nothing AndAlso
				rstCuadros.Tables(0).Rows.Count > 0 Then

				'-- Generar TXT
				sTabla = rstCuadros.Tables(0).Rows(0).Item("TR_TABLATRABAJO")

				'-- Generar Tabla de Trabajo
				If Not (PreparaTxt(dFechaReal, sTabla)) Then
					cmdGenerar.Enabled = True
					lblStatus.Text = ""
					Me.Cursor = Cursors.Default
					Exit Sub
				End If
			End If

			If rstCuadros.Tables(0).Rows.Count() > 0 Then

				lblStatus.Text = "Procesando..."
				lblStatus.Visible = True
				Application.DoEvents()
				Threading.Thread.Sleep(10)

				For Each row As DataRow In rstCuadros.Tables(0).Rows

					sCuadro = row("TR_CUADRO")

					sSQL = "SELECT       * " &
					   "FROM         " & sTabla & " " &
					   "WHERE        FECHAVIG = " & FechaSQL(dFecha) & " " &
					   "AND          CUADRO = '" & sCuadro & "' " &
					   "AND          GENERATXT = 1 " &
						FiltroTablaTrabajo(sTabla) & " " &
					   "ORDER BY     CODIGO, CAMPO8, PERIODO"
					rstTrabajo = oAdmLocal.AbrirDataset(sSQL)

					sSQL = "SELECT       * " &
					   "FROM         TXTREL " &
					   "WHERE        TR_CODIGO = " & nCod & " " &
					   "AND          TR_CUADRO = '" & sCuadro & "' " &
					   "AND          TR_FECHAVIG = " & FechaSQL(dFechaProx) & " " &
					   "ORDER BY     TR_ORDENTXT ASC"
					rstAux = oAdmLocal.AbrirDataset(sSQL)

					If rstTrabajo.Tables(0).Rows.Count() > 0 Then

						For Each rowTrabajo As DataRow In rstTrabajo.Tables(0).Rows

							'If j = 102 Then Stop

							For Each rowAux As DataRow In rstAux.Tables(0).Rows

								nOrden = rowAux("TR_ORDENTXT")

								If "" & rowAux("TR_CAMPOTRABAJO") = "" Then ' Dato fijo !!

									If InStr(1, "" & rowAux("TR_DATOFIJO"), "[") > 0 Then

										Select Case "" & rowAux("TR_DATOFIJO")

											Case "[RECTIFICATIVA]"
												sLine &= IIf(chkRectivicativa.Checked, "R", "N")

											Case "[ENTIDAD]"
												sLine &= Format(CODIGO_ENTIDAD, Microsoft.VisualBasic.Strings.Left(CType(Formato(nOrden), clsFormato).FormatoCampo, CType(Formato(nOrden), clsFormato).Longitud))

										End Select

									Else

										Select Case CType(Formato(nOrden), clsFormato).Tipo

											Case "N"
												Dim num = NoNulo(rowAux("TR_DATOFIJO"), False)
												If String.IsNullOrEmpty(num) OrElse num.ToString() = "0" Then
													Dim valorFormato = CType(Formato(nOrden), clsFormato).FormatoCampo
													If Not String.IsNullOrEmpty(valorFormato) Then
														sLine &= Format(0, Strings.Left(valorFormato, CType(Formato(nOrden), clsFormato).Longitud))
													End If
												Else
													If IsNumeric(rowAux("TR_DATOFIJO")) Then
														sLine &= Format(Val(rowAux("TR_DATOFIJO")), Strings.Left(CType(Formato(nOrden), clsFormato).FormatoCampo, CType(Formato(nOrden), clsFormato).Longitud))
													ElseIf IsDate(rowAux("TR_DATOFIJO")) Then
														sLine &= Format(CDate(rowAux("TR_DATOFIJO")), Strings.Left(CType(Formato(nOrden), clsFormato).FormatoCampo, CType(Formato(nOrden), clsFormato).Longitud))
													Else
														sLine &= Format(NoNulo(rowAux("TR_DATOFIJO")), Strings.Left(CType(Formato(nOrden), clsFormato).FormatoCampo, CType(Formato(nOrden), clsFormato).Longitud))
													End If
												End If

											Case "F"
												If NoNulo(rowAux("TR_DATOFIJO"), False) = 0 Then
													'sLine = sLine & "".PadLeft(CType(Formato(nOrden), clsFormato).Longitud, "0")
													sLine &= New String("0", CType(Formato(nOrden), clsFormato).Longitud)
												Else
													sLine &= Format(CDate(rowAux("TR_DATOFIJO")), Strings.Left(CType(Formato(nOrden), clsFormato).FormatoCampo, CType(Formato(nOrden), clsFormato).Longitud))
												End If

											Case Else
												sLine &= RellenarCadena(Trim("" & rowAux("TR_DATOFIJO")), CType(Formato(nOrden), clsFormato).Longitud)

										End Select
									End If

									' Ver rutina --------

								Else

									sCampo = rowAux("TR_CAMPOTRABAJO")

									Select Case CType(Formato(nOrden), clsFormato).Tipo

										Case "N"
											Dim num = NoNulo(rowTrabajo(sCampo), False)

											If String.IsNullOrEmpty(num) OrElse num.ToString() = "0" Then
												Dim valorFormato = CType(Formato(nOrden), clsFormato).FormatoCampo
												If Not String.IsNullOrEmpty(valorFormato) Then
													sLine &= Format(0 * Val("1" & "".PadLeft(CType(Formato(nOrden), clsFormato).Decimales, "0")), valorFormato)
												End If
											Else

												vDato = Val(rowTrabajo(sCampo))
												If CType(Formato(nOrden), clsFormato).Decimales > 0 Then
													sLine &= Format(vDato * Val("1" & "".PadLeft(CType(Formato(nOrden), clsFormato).Decimales, "0")), CType(Formato(nOrden), clsFormato).FormatoCampo)
												Else
													If vDato >= 0 Then
														sLine &= (IIf(vDato = 0 AndAlso CType(Formato(nOrden), clsFormato).FormatoCampo = String.Empty, String.Empty, Format(vDato, CType(Formato(nOrden), clsFormato).FormatoCampo)))
													Else
														sLine &= Format(vDato, Microsoft.VisualBasic.Strings.Right(CType(Formato(nOrden), clsFormato).FormatoCampo, CType(Formato(nOrden), clsFormato).Longitud - 1))
													End If
												End If
											End If

											If Strings.Right(rowAux("TR_DATOFIJO").ToString, 1) = ";" Then
												sLine &= ";"
											End If

										Case "T"
											vDato = NoNulo(rowTrabajo(sCampo), False)

											If Strings.Right(rowAux("TR_DATOFIJO").ToString, 1) = ";" Then ' Right("" & rowAux("TR_DATOFIJO", 1) = ";" Then

												'vDato = rowTrabajo(sCampo).ToString.Trim
												sLine = sLine & vDato.ToString & ";"

											ElseIf Strings.Right(rowAux("TR_DATOFIJO").ToString, 2) = "||" Then 'Right("" & rstAux!TR_DATOFIJO, 2) = "||" Then

												'vDato = rowTrabajo(sCampo).ToString.Trim
												sLine = sLine & vDato.ToString & ""

											Else

												'vDato = Trim(rowTrabajo(sCampo).ToString)
												sLine &= RellenarCadena(vDato, CType(Formato(nOrden), clsFormato).Longitud)

											End If

								'Codigo anterior
								'vDato = Trim(rowTrabajo(sCampo).ToString)
								'sLine = sLine & RellenarCadena(vDato, CType(Formato(nOrden), clsFormato).Longitud)

										Case "F"
											vDato = NoNulo(rowTrabajo(sCampo), False)

											Select Case rowAux("TR_DATOFIJO").ToString

												Case "[PERIODOANT]"

													dNewValue = UnAnioMenos(DateTime.Parse(vDato.ToString))
													sLine &= Format(dNewValue, Formato(nOrden).FORMATOCAMPO)

												Case Else ' VACIO !!

													If vDato.ToString = "0" Then

														If Strings.Right(rowAux("TR_DATOFIJO").ToString, 1) = ";" Then
															sLine = sLine
														Else
															sLine &= Format(vDato, "".PadLeft(Len(Formato(nOrden).FORMATOCAMPO), "0"))
														End If

													Else

														sLine &= Format(vDato, Formato(nOrden).FORMATOCAMPO)

													End If

											End Select

											If Strings.Right(rowAux("TR_DATOFIJO").ToString, 1) = ";" Then
												sLine &= ";"
											End If


									End Select

								End If

							Next

							j += 1
							oText.WriteLine(sLine)
							sLine = ""
							procesoFin = True
							lblStatus.Text = "Procesados: " & j.ToString & " ..."
							Application.DoEvents()
							Threading.Thread.Sleep(10)
						Next
					Else
						procesoFin = True
						lblStatus.Text = "Procesados: 0 (sin datos)"
						Application.DoEvents()
						Threading.Thread.Sleep(10)
					End If

					rstTrabajo = Nothing
					rstAux = Nothing

				Next

			End If
			'Exit Sub

			'   Catch ex As Exception
			' Me.Cursor = Cursors.Default
			' TratarError(ex, "GenerarTXT", "Campo: " & sCampo & vbCrLf & Err.Description)
			' End Try

			oText.Close()
			oText = Nothing

			GrabarLog(sFile, dFechaReal, j)
		Finally
			If oText IsNot Nothing Then
				oText.Close()
				oText = Nothing
			End If
			rstCuadros = Nothing

			cmdGenerar.Enabled = True

			Me.Cursor = Cursors.Default

			If (procesoFin) Then
				MensajeInformacion("Proceso finalizado")
				Me.lblStatus.Visible = True
			End If


			If chkOpen.Checked Then
				Process.Start(sFile)
			End If
		End Try

	End Sub

	Private Function PreparaTxt(ByVal dFecha As Date,
							 Optional ByVal sTabla As String = "",
							 Optional ByVal nCod As Long = 0) As Boolean

		Dim oItem As Prex.Utils.Entities.clsItem

		oItem = cboArchivos.SelectedItem

		Select Case oItem.Valor
			Case 6301 To 6303
				Return PreparaTXT_Anticipos(sTabla, dFecha)
			Case 5601
				Return PreparaTXT_5601(sTabla, dFecha)
			Case 5603
				Return PreparaTXT_5603(sTabla, dFecha)
			Case 5605
				Return PreparaTXT_5605(sTabla, dFecha)
			Case 5607
				Return PreparaTXT_5607(sTabla, dFecha)
			Case 5610
				Return PreparaTXT_5610(sTabla, dFecha)
			Case 5611
				Return PreparaTXT_5611(sTabla, dFecha)
			'Case 4401
			'   Return PreparaTXT_4401(sTabla, dFecha)
			Case 4300 To 4399
				Return PreparaTXT_Dinamico(nCod, dFecha)
			Case Else
				Return PreparaTXT_Dinamico(oItem.Valor, dFecha)
		End Select

		Return False
	End Function

	Private Function PreparaTXT_Anticipos(ByVal sTabla As String,
										  ByVal dFecha As Date) As Boolean

		Dim sSQL As String
		Dim RS As DataSet
		Dim sError As String

		Try

			sSQL = "SELECT    * " &
				   "FROM      TXTNOM " &
				   "WHERE     TN_CODIGO = 6303 "
			RS = oAdmLocal.AbrirDataset(sSQL)

			sSQL = ""

			If RS.Tables(0).Rows.Count > 0 Then
				sSQL = sBase64Decode("" & RS.Tables(0).Rows(0).Item("TN_PROCES"))
			End If

			sSQL = Replace(sSQL, "@FECDES", FechaSQL(dFecha.AddDays((dFecha.Day) * -1 + 1)))
			sSQL = Replace(sSQL, "@FECHAS", FechaSQL(dFecha))
			sSQL = Replace(sSQL, "@CODENT", CODIGO_ENTIDAD)

			If Not oAdmLocal.EjecutarComandoAsincrono(sSQL, sError) Then
				MensajeError(sError)
				Return False
			End If
			Return True
		Catch ex As Exception
			TratarError(ex, "PreparaTXT_Anticipos")
			Return False
		End Try

		RS = Nothing

	End Function

	Private Function FiltroTablaTrabajo(ByVal sTabla As String) As String

		Dim sSQL As String
		Dim ds As DataSet
		Dim sTemp As String = ""

		sSQL = "SELECT * " &
			   "FROM TXTFIL " &
			   "WHERE TF_TABLA = '" & sTabla & "'"

		ds = oAdmLocal.AbrirDataset(sSQL)

		With ds.Tables(0)

			For Each row As DataRow In .Rows

				sTemp = sTemp & "AND " & row("TF_CONDICION") & " "

			Next

		End With

		ds = Nothing

		FiltroTablaTrabajo = sTemp

	End Function

	Private Sub frmMain_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

		If e.KeyCode = 116 Then

			Dim oGral As New frmInputGeneral

			oGral.PasarInfoVentana("Modo diseño", "Ingrese la contraseña")
			oGral.txtResultado.UseSystemPasswordChar = True

			If oGral.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

				If INPUT_GENERAL = "Prex123" Then
					Dim _frmProceso As New frmProceso()

					_frmProceso.ShowDialog(Me)
					_frmProceso = Nothing
				Else
					MensajeError("Login Incorrecto")
				End If

			End If

		End If

	End Sub

	Private Sub cboArchivos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboArchivos.SelectedIndexChanged

		If IsArchivoPorDia Then
			cboDia.Visible = True
			cboMes.Size = New Size(184, cboMes.Size.Height)
			cboMes.Location = New Point(223, cboMes.Location.Y)
		Else
			cboDia.Visible = False
			cboMes.Size = New Size(265, cboMes.Size.Height)
			cboMes.Location = New Point(142, cboMes.Location.Y)
		End If


		Dim sRutaDefault As String = CType(NoNulo(oAdmLocal.DevolverValor("TXTNOM", "TN_RUTA", $"TN_NOMBRETXT='{CType(cboArchivos.SelectedItem, Prex.Utils.Entities.clsItem).Nombre}'", String.Empty), True), String)

		If (sRutaDefault.Length() > 0) Then
			txtCarpeta.Text = NormalizarRuta(sRutaDefault)
			txtCarpeta.Enabled = False
		Else
			txtCarpeta.Enabled = True
			txtCarpeta.Text = CARPETA_LOCAL
		End If

		cmdBrowse.Visible = txtCarpeta.Enabled
		chkOpen.Visible = txtCarpeta.Enabled
		lblStatus.Text = ""
		Me.lblStatus.Visible = False
		ResetFecha(Date.Today)
	End Sub
End Class