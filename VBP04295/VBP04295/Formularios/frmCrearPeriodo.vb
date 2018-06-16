Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmCrearPeriodo

   Private PREFIJO As String
   Private TABLA As String
   Private CodCon As String
   Private CUADRO As Long
   Private FECVIG As Date

   Private oAdmLocal As New AdmTablas

   Private Sub CargarPeriodos()

      Dim sSQL As String

      sSQL = "SELECT    DISTINCT " & PREFIJO & "_FECVIG, " & PREFIJO & "_FECVIG AS XX_DESCRI " & _
             "FROM      " & TABLA & " " & _
             "WHERE     " & PREFIJO & "_CODENT = " & CODIGO_ENTIDAD & " " & _
             "AND       CAST(" & PREFIJO & "_CODCON AS INT) = " & CodCon & " "

      If CUADRO <> 0 Then
         sSQL = sSQL & "AND " & PREFIJO & "_CUADRO = " & CUADRO & " "
      End If

      sSQL = sSQL & "ORDER BY  " & PREFIJO & "_FECVIG DESC"

      CargarComboDevExpress(cboFecVig, sSQL)

      chkDatos.Enabled = cboFecVig.Properties.Items.Count

   End Sub

   Public Sub PasarDatos(ByVal sPrefijo As String, ByVal sTabla As String, _
                       ByVal sCodCon As String, ByVal nCuadro As Long, _
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
            ConsCrearPeriodo(FECVIG & "|" & CodCon & "|" & CODIGO_ENTIDAD & "|" & _
                             CUADRO & "|" & TABLA & "|" & PREFIJO)
         End If

         If chkDatos.Checked Then
            sSQL = "SELECT  * " & _
                   "INTO    VBP04295 " & _
                   "FROM    " & TABLA & " " & _
                   "WHERE   " & PREFIJO & "_FECVIG = " & FechaSQL(cboFecVig.Text) & " " & _
                   "AND     " & PREFIJO & "_CODENT = " & CODIGO_ENTIDAD & " " & _
                   "AND     CAST(" & PREFIJO & "_CODCON AS INT) = " & CodCon & " "

            If CUADRO <> 0 Then
               sSQL = sSQL & "AND " & PREFIJO & "_CUADRO = " & CUADRO & " "
            End If

            oAdmLocal.EjecutarComandoAsincrono(sSQL)

            sSQL = "UPDATE  VBP04295 " & _
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

                  sSQL = Mid(sSQL, 1, Len(sSQL) - 4) & vbCrLf & "FROM " & TABLA & " A " & _
                                "INNER JOIN VBP04295 B " & _
                                "ON    A." & PREFIJO & "_FECVIG = B." & PREFIJO & "_FECVIG " & _
                                "AND   A." & PREFIJO & "_CODENT = B." & PREFIJO & "_CODENT " & _
                                "AND   A." & PREFIJO & "_CODPAR = B." & PREFIJO & "_CODPAR " & _
                                "AND   A." & PREFIJO & "_CAMPO8 = B." & PREFIJO & "_CAMPO8 " & _
                                "AND   A." & PREFIJO & "_CODCON = B." & PREFIJO & "_CODCON " & _
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

         sSQL = "SELECT    MAX(TK_FECVIG) AS MAX_FECHA " & _
                "FROM      TABPAR " & _
                "WHERE     TK_FECVIG <= " & FechaSQL(dFechaSel) & " " & _
                "AND       TK_CODENT = " & nCodEnt & " " & _
                "AND       TK_CUADRO = " & nCuadro
         ds = oAdmLocal.AbrirDataset(sSQL)

         If ds.Tables(0).Rows(0).Item("MAX_FECHA") Is DBNull.Value Then
            bSinFechas = True
            GoTo Maneja_Error
         Else
            dFecha = ds.Tables(0).Rows(0).Item("MAX_FECHA")
         End If

         ds = Nothing

         sSQL = "INSERT INTO " & sTabla & " " & _
                "             ( " & sPrefijo & "_FECVIG, " & sPrefijo & "_CODENT, " & sPrefijo & "_CODPAR, " & sPrefijo & "_CODCON, " & sPrefijo & "_DESCRI, " & _
                "             " & sPrefijo & "_DCORTA, " & sPrefijo & "_ACTIVA, " & sPrefijo & "_CREOREND, " & sPrefijo & "_CUADRO, " & sPrefijo & "_MONFIJ, " & _
                "             " & sPrefijo & "_ORDEN, " & sPrefijo & "_OPERACION, " & sPrefijo & "_ESQUEMA, " & sPrefijo & "_NIVEL, " & sPrefijo & "_GENERATXT, " & _
                "             " & sPrefijo & "_NIVELTAB, " & sPrefijo & "_RELATIVO, " & sPrefijo & "_INDEX, " & sPrefijo & "_FECHACAR, " & sPrefijo & "_USUARIO, " & sPrefijo & "_CAMPO8 ) " & _
                "SELECT " & FechaSQL(dFechaSel) & ", TK_CODENT, TK_CODPAR, " & _
                "             '" & sCodCon & "', TK_DESCRI, TK_DCORTA, TK_ACTIVA, " & _
                "             TK_CREOREND, TK_CUADRO, TK_MONFIJ, TK_ORDEN, " & _
                "             TK_OPERACION, TK_ESQUEMA, TK_NIVEL, TK_GENERATXT, " & _
                "             TK_NIVELTAB, TK_RELATIVO, TK_INDEX, " & FechaSQL(Date.Today) & ", '" & UsuarioActual.Nombre & "', "

         If nCuadro = 400 Or _
            nCuadro = 401 Or _
            nCuadro = 402 Or _
            nCuadro = 403 Or _
            nCuadro = 404 Or _
            nCuadro = 410 Or _
            nCuadro = 411 Then


                frmTablaGeneral.PasarInfo("SELECT  TG_CODCON AS [Cód.], TG_DESCRI AS [Moneda] " &
                                          "FROM TABGEN WHERE TG_CODTAB = 100 AND TG_CODCON <> 999999 " &
                                          "ORDER BY TG_CODCON", CONN_LOCAL, 1, True, "Indique las Monedas/Especies", )

                If frmTablaGeneral.ShowDialog = Windows.Forms.DialogResult.Cancel Then
               Exit Function
            End If

            sSQL = sSQL & "" & _
                   "TG_CODCON " & _
                   "FROM            TABPAR " & _
                   "INNER  JOIN     TABGEN " & _
                   "ON              TG_CODTAB = 100 " & _
                   "AND             TG_CODCON IN (" & INPUT_GENERAL & ") "

         Else

            sSQL = sSQL & "" & _
                   "TK_CAMPO8 " & _
                   "FROM            TABPAR "

         End If

         sSQL = sSQL & _
                "WHERE        TK_FECVIG = " & FechaSQL(dFecha) & " " & _
                "AND          TK_CODENT= " & CODIGO_ENTIDAD & " " & _
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
End Class