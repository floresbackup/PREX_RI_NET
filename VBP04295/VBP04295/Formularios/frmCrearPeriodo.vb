Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls

Public Class frmCrearPeriodo

	Private PREFIJO As String
	Private TABLA As String
	Private CodCon As String
	Private CUADRO As Long
	Private FECVIG As Date

	Private oAdmLocal As New AdmTablas

	Private Sub CargarPeriodos()

		Dim sSQL As String

		sSQL = "SELECT    DISTINCT " & PREFIJO & "_FECVIG, " & PREFIJO & "_FECVIG AS XX_DESCRI " &
			   "FROM      " & TABLA & " " &
			   "WHERE     " & PREFIJO & "_CODENT = " & CODIGO_ENTIDAD & " " &
			   "AND       CAST(" & PREFIJO & "_CODCON AS INT) = " & CodCon & " "

		If CUADRO <> 0 Then
			sSQL = sSQL & "AND " & PREFIJO & "_CUADRO = " & CUADRO & " "
		End If

		sSQL = sSQL & "ORDER BY  " & PREFIJO & "_FECVIG DESC"

		CargarComboDevExpress(cboFecVig, sSQL, True)

		chkDatos.Enabled = cboFecVig.Properties.Items.Count

	End Sub

	Public Sub PasarDatos(ByVal sPrefijo As String, ByVal sTabla As String,
						ByVal sCodCon As String, ByVal nCuadro As Long,
						ByVal dFecVig As Date)

		PREFIJO = Trim(sPrefijo)
		TABLA = Trim(sTabla)
		CodCon = Trim(sCodCon)
		CUADRO = nCuadro
		FECVIG = dFecVig

		CargarPeriodos()

	End Sub

	Private Sub Guardar()

		Dim sSQL As String
		Dim ds As DataSet
		Dim oField As DataColumn

		Try

			If TABLA = "DATCUA" Or TABLA = "DATBAN" Then
				ConsCrearPeriodo(FECVIG & "|" & CodCon & "|" & CODIGO_ENTIDAD & "|" &
								 CUADRO & "|" & TABLA & "|" & PREFIJO)
			End If

			If chkDatos.Checked Then
				sSQL = "SELECT  * " &
					   "INTO    VBP04295 " &
					   "FROM    " & TABLA & " " &
					   "WHERE   " & PREFIJO & "_FECVIG = " & FechaSQL(cboFecVig.Text) & " " &
					   "AND     " & PREFIJO & "_CODENT = " & CODIGO_ENTIDAD & " " &
					   "AND     CAST(" & PREFIJO & "_CODCON AS INT) = " & CodCon & " "

				If CUADRO <> 0 Then
					sSQL = sSQL & "AND " & PREFIJO & "_CUADRO = " & CUADRO & " "
				End If

				oAdmLocal.EjecutarComandoAsincrono(sSQL)

				sSQL = "UPDATE  VBP04295 " &
					   "SET     " & PREFIJO & "_FECVIG = " & FechaSQL(FECVIG) & " "
				oAdmLocal.EjecutarComandoAsincrono(sSQL)

				If TABLA = "DATCUA" Or TABLA = "DATBAN" Then
					ds = New DataSet
					oAdmLocal.EjecutarComandoAsincrono("SELECT TOP 1 * FROM VBP04295 ", , , ds)

					With ds.Tables(0)
						sSQL = "UPDATE " & TABLA & " SET "
						For Each oField In .Columns
							If UCase(Mid(oField.Namespace, 1, 6)) = UCase(PREFIJO & "_MES") Then
								sSQL = sSQL & oField.ColumnName & " = B." & oField.ColumnName & ", " & vbCrLf
							End If
						Next

						sSQL = Mid(sSQL, 1, Len(sSQL) - 4) & vbCrLf & "FROM " & TABLA & " A " &
									  "INNER JOIN VBP04295 B " &
									  "ON    A." & PREFIJO & "_FECVIG = B." & PREFIJO & "_FECVIG " &
									  "AND   A." & PREFIJO & "_CODENT = B." & PREFIJO & "_CODENT " &
									  "AND   A." & PREFIJO & "_CODPAR = B." & PREFIJO & "_CODPAR " &
									  "AND   A." & PREFIJO & "_CAMPO8 = B." & PREFIJO & "_CAMPO8 " &
									  "AND   A." & PREFIJO & "_CODCON = B." & PREFIJO & "_CODCON " &
									  "AND   A." & PREFIJO & "_CUADRO = B." & PREFIJO & "_CUADRO "

					End With

					oAdmLocal.EjecutarComandoAsincrono(sSQL)
				Else
					sSQL = "INSERT INTO " & TABLA & " SELECT * FROM VBP04295 "
					oAdmLocal.EjecutarComandoAsincrono(sSQL)
				End If

				sSQL = "DROP TABLE VBP04295 "
				oAdmLocal.EjecutarComandoAsincrono(sSQL)

			End If

			Me.DialogResult = Windows.Forms.DialogResult.OK
			Me.Close()

		Catch ex As Exception
			TratarError(ex, "Guardar")
		End Try

	End Sub

	'Parametros = sParam(0)=Fecha|sParam(1)=CodCons|sParam(2)=Entidad|sParam(3)=Cuadro|
	'             sParam(4)=TablaDatos|sParam(5)=PrefijoTablaDatos
	Public Function ConsCrearPeriodo(ByVal sParametros As String) As Boolean

		Dim sSQL As String
		Dim ds As DataSet
		Dim dFechaSel As Date
		Dim dFecha As Date
		Dim bRes As Boolean
		Dim bSinFechas As Boolean
		Dim sCodCon As String
		Dim nCuadro As Long
		Dim nCodEnt As Long
		Dim sPrefijo As String
		Dim sParam() As String
		Dim sTabla As String

		Try

			sParam = Split(sParametros, "|")

			dFechaSel = CDate(sParam(0))
			sCodCon = Format(Val(sParam(1)), "000")
			nCodEnt = Val(sParam(2))
			nCuadro = Val(sParam(3))
			sTabla = sParam(4)
			sPrefijo = sParam(5)

			sSQL = "SELECT    MAX(TK_FECVIG) AS MAX_FECHA " &
				   "FROM      TABPAR " &
				   "WHERE     TK_FECVIG <= " & FechaSQL(dFechaSel) & " " &
				   "AND       TK_CODENT = " & nCodEnt & " " &
				   "AND       TK_CUADRO = " & nCuadro
			ds = oAdmLocal.AbrirDataset(sSQL)

			If ds.Tables(0).Rows(0).Item("MAX_FECHA") Is DBNull.Value Then
				bSinFechas = True
				GoTo Maneja_Error
			Else
				dFecha = ds.Tables(0).Rows(0).Item("MAX_FECHA")
			End If

			ds = Nothing

			sSQL = "INSERT INTO " & sTabla & " " &
				   "             ( " & sPrefijo & "_FECVIG, " & sPrefijo & "_CODENT, " & sPrefijo & "_CODPAR, " & sPrefijo & "_CODCON, " & sPrefijo & "_DESCRI, " &
				   "             " & sPrefijo & "_DCORTA, " & sPrefijo & "_ACTIVA, " & sPrefijo & "_CREOREND, " & sPrefijo & "_CUADRO, " & sPrefijo & "_MONFIJ, " &
				   "             " & sPrefijo & "_ORDEN, " & sPrefijo & "_OPERACION, " & sPrefijo & "_ESQUEMA, " & sPrefijo & "_NIVEL, " & sPrefijo & "_GENERATXT, " &
				   "             " & sPrefijo & "_NIVELTAB, " & sPrefijo & "_RELATIVO, " & sPrefijo & "_INDEX, " & sPrefijo & "_FECHACAR, " & sPrefijo & "_USUARIO, " & sPrefijo & "_CAMPO8 ) " &
				   "SELECT " & FechaSQL(dFechaSel) & ", TK_CODENT, TK_CODPAR, " &
				   "             '" & sCodCon & "', TK_DESCRI, TK_DCORTA, TK_ACTIVA, " &
				   "             TK_CREOREND, TK_CUADRO, TK_MONFIJ, TK_ORDEN, " &
				   "             TK_OPERACION, TK_ESQUEMA, TK_NIVEL, TK_GENERATXT, " &
				   "             TK_NIVELTAB, TK_RELATIVO, TK_INDEX, " & FechaSQL(Date.Today) & ", '" & UsuarioActual.Nombre & "', "

			If nCuadro = 400 OrElse
			   nCuadro = 401 OrElse
			   nCuadro = 402 OrElse
			   nCuadro = 403 OrElse
			   nCuadro = 404 OrElse
			   nCuadro = 410 OrElse
			   nCuadro = 411 OrElse
			   nCuadro = 420 OrElse
			   nCuadro = 430 Then

				frmTablaGeneral.PasarInfo("SELECT  TG_CODCON AS [Cód.], TG_DESCRI AS [Moneda] " &
									  "FROM TABGEN WHERE TG_CODTAB = 100 AND TG_CODCON <> 999999 " &
									  "ORDER BY TG_CODCON", CONN_LOCAL, 1, True, "Indique las Monedas/Especies", )

				If frmTablaGeneral.ShowDialog = Windows.Forms.DialogResult.Cancel Then
					Exit Function
				End If

				sSQL = sSQL & "" &
				   "TG_CODCON " &
				   "FROM            TABPAR " &
				   "INNER  JOIN     TABGEN " &
				   "ON              TG_CODTAB = 100 " &
				   "AND             TG_CODCON IN (" & INPUT_GENERAL & ") "

			Else

				sSQL = sSQL & "" &
					   "TK_CAMPO8 " &
					   "FROM            TABPAR "

			End If

			sSQL = sSQL &
				   "WHERE        TK_FECVIG = " & FechaSQL(dFecha) & " " &
				   "AND          TK_CODENT= " & CODIGO_ENTIDAD & " " &
				   "AND          TK_CUADRO= " & nCuadro & " "

			If nCuadro = 344 Then
				Select Case Val(sCodCon)
					Case 0
						sSQL = sSQL & "AND TK_CODPAR NOT IN (601300000,601400000,601500000,601600000) "
					Case 1
						sSQL = sSQL & "AND TK_CODPAR NOT IN (601100000,601200000,601500000,601600000) "
					Case 2
						sSQL = sSQL & "AND TK_CODPAR NOT IN (601100000,601200000,601300000,601400000) "
				End Select
			End If

			If nCuadro = 345 Then
				Select Case Val(sCodCon)
					Case 0
						sSQL = sSQL & "AND TK_CODPAR NOT IN (602300000,602400000,602500000,602600000) "
					Case 1
						sSQL = sSQL & "AND TK_CODPAR NOT IN (602100000,602200000,602500000,602600000) "
					Case 2
						sSQL = sSQL & "AND TK_CODPAR NOT IN (602100000,602200000,602300000,602400000) "
				End Select
			End If

			bRes = oAdmLocal.EjecutarComandoAsincrono(sSQL)

			If Not bRes Then
				MensajeError("Error al crear la información del período")
				GoTo Maneja_Error
			End If

			Return True

		Catch ex As Exception
			TratarError(ex, "ConsCrearPeriodo")
		End Try

Maneja_Error:
		ds = Nothing

		If bSinFechas Then
			MensajeError("No hay datos anteriores a la fecha seleccionada. Imposible crear el período")
		End If

	End Function

	Public Sub New()

		' Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		oAdmLocal.ConnectionString = CONN_LOCAL

	End Sub

	Private Sub cmdCrearPeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCrearPeriodo.Click

		If DatosOK() Then
			Guardar()
		End If

	End Sub

	Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
		Me.Close()
	End Sub

	Private Function DatosOK() As Boolean

		If chkDatos.Checked Then
			If cboFecVig.SelectedItem Is Nothing Then
				MensajeError("Debe especificar un período de origen")
				cboFecVig.Focus()
				Exit Function
			End If
		End If

		Return True

	End Function

	Private Sub chkDatos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDatos.CheckedChanged
		cboFecVig.Enabled = chkDatos.Checked
	End Sub

	Private Sub cboFecVig_CustomDisplayText(sender As Object, e As CustomDisplayTextEventArgs) Handles cboFecVig.CustomDisplayText
		If e.Value Is Nothing Then Exit Sub
		e.DisplayText = CType(CType(e.Value, Prex.Utils.Entities.clsItem).Valor, DateTime).ToString("dd/MM/yyyy")
	End Sub
End Class