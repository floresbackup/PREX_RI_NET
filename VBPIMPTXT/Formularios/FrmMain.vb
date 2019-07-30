Imports System.Collections.Concurrent
Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading

Public Class FrmMain
#If DEBUG Then
    Public ARCHIVO_CONFIG As String = "C:\Prex\DebugLocal\Prex.config"
#Else
    Public ARCHIVO_CONFIG As String = Application.StartupPath & "\Prex.config"
#End If

    Private Enum DisenioTxt
        D4305 = 4305
        D4306 = 4306
        D4307 = 4307
    End Enum

#Region "Variables y propiedades"
    Public CONN_LOCAL As String = ""
    Private _formatos As Dictionary(Of DisenioTxt, List(Of Columna)) = New Dictionary(Of DisenioTxt, List(Of Columna))()
    Private isProcesando As Boolean

    Private ReadOnly Property TableName As String
        Get
            Return $"PREX_{Path.GetFileNameWithoutExtension(txtPathBCP.Text).Replace(".", "_")}"
        End Get
    End Property

    Private ReadOnly Property GetFullConnectionString As String
        Get
            Dim ss As String = CONN_LOCAL

            Return ss.Replace("Provider=SQLOLEDB;", String.Empty).Replace("Provider=SQLOLEDB.1;", String.Empty)

            ' $"Password={txtUserPass.Text.Trim()};User Id={txtSQLUser.Text.Trim()};Initial Catalog={txtDataBase.Text.Trim()};Data Source={txtSQLServer.Text.Trim()}".Replace(";;", ";");
        End Get
    End Property

#End Region

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not File.Exists(ARCHIVO_CONFIG) Then
            'ARCHIVO_CONFIG = ARCHIVO_CONFIG_DEV
            MessageBox.Show(Me, "No se encuentra el archivo encriptado con la conexion SQL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Dim oConfig As New DataSet()
        If File.Exists(ARCHIVO_CONFIG) Then
            oConfig.ReadXml(ARCHIVO_CONFIG)
        End If

        For Each row As DataRow In oConfig.Tables("CONFIG").Rows

            Dim sTemp = row("VALOR").ToString

            If row("NOMBRE").ToString = "CONN_LOCAL" Then

                CONN_LOCAL = System.Text.ASCIIEncoding.UTF8.GetString(Convert.FromBase64String(sTemp))
            End If

        Next


    End Sub

    Private Sub IncrementarProgressInterno(ctrl As ProgressBar, valor As Integer)
        If ctrl.Value = ctrl.Maximum Then
            ctrl.Value = 0
        End If
        If (ctrl.Value + valor) <= ctrl.Maximum Then
            ctrl.Increment(valor)
        End If
    End Sub

    Private terminoLeerTxt As Boolean = False
    Private Sub ProgressLoadTxt()
        While Not terminoLeerTxt
            IncrementarProgress(progressBar, 1)
            Thread.Sleep(100)
        End While
    End Sub

    Private Async Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim lineas As New ConcurrentBag(Of List(Of String))()
        isProcesando = True
        Try
            Cursor = Cursors.WaitCursor
            lblProgreso.Visible = True
            progressBar.Visible = True
            btnProcesar.Enabled = False

            SetLabelProgreso(lblProgreso, "Guardando configuración...")

            SetLabelProgreso(lblProgreso, "Cargando diseños...")
            CargarFormatos(DisenioTxt.D4305)
            CargarFormatos(DisenioTxt.D4306)
            CargarFormatos(DisenioTxt.D4307)

            Dim conn = New SqlConnection(GetFullConnectionString)
            Dim tran As SqlTransaction = Nothing
            Try
                'tran = conn.BeginTransaction()
                progressBar.Value = 0
                progressBar.Maximum = 200
                Dim thread As New Thread(AddressOf ProgressLoadTxt)
                thread.Start()

                Await Task.Run(Sub()
                                   SetLabelProgreso(lblProgreso, "Leyendo archivo txt, aguarde unos instantes...")
                                   Dim archivo = File.ReadLines(txtPathBCP.Text)
                                   Dim cc = txtDecimalSeparator.Text.Trim().ToCharArray()
                                   'progressBar.Maximum = archivo.Count()
                                   archivo.AsParallel().ForAll(Sub(l)
                                                                   lineas.Add(l.Split(cc).ToList())
                                                                   'IncrementarProgress(progressBar, 1)
                                                               End Sub)
                                   terminoLeerTxt = True
                               End Sub)
                thread.Abort()
                progressBar.Value = 0
                progressBar.Maximum = 100

                conn.Open()
                Await Task.Run(Sub()
                                   SetLabelProgreso(lblProgreso, $"Creando tablas {TableName} ...")
                                   DropYCrearTabla(DisenioTxt.D4305, conn, tran)
                                   DropYCrearTabla(DisenioTxt.D4306, conn, tran)
                                   DropYCrearTabla(DisenioTxt.D4307, conn, tran)
                               End Sub)

                Await ProcesarFormato(DisenioTxt.D4305, lineas.ToList().Where(Function(l) l(0) = Integer.Parse(DisenioTxt.D4305).ToString()).ToList(), conn, tran)
                Await ProcesarFormato(DisenioTxt.D4306, lineas.ToList().Where(Function(l) l(0) = Integer.Parse(DisenioTxt.D4306).ToString()).ToList(), conn, tran)
                Await ProcesarFormato(DisenioTxt.D4307, lineas.ToList().Where(Function(l) l(0) = Integer.Parse(DisenioTxt.D4307).ToString()).ToList(), conn, tran)


                If tran IsNot Nothing Then
                    tran.Commit()
                End If
                conn.Close()
                MessageBox.Show(Me, "Proceso finalizado!", "Importador TXT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                If tran IsNot Nothing Then
                    tran.Rollback()
                End If

                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                MessageBox.Show(Me, "Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Finally
            Cursor = Cursors.Default
            lblProgreso.Visible = False
            progressBar.Visible = False
            progressBar.Value = 0
            btnProcesar.Enabled = True
            Dim someItem As List(Of String) = Nothing
            While Not lineas.IsEmpty
                lineas.TryTake(someItem)
            End While
            someItem = Nothing
            lineas = Nothing
            isProcesando = False
        End Try
    End Sub

    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isProcesando Then
            If MessageBox.Show(Me, "El proceso aún esta en ejecución." & vbCrLf & "¿Está seguro que desea cerrar el sistema?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnDialogBCP_Click(sender As Object, e As EventArgs) Handles btnDialogBCP.Click
        Dim OpenFileDialog1 As New OpenFileDialog()
        OpenFileDialog1.FileName = "*.txt"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtPathBCP.Text = OpenFileDialog1.FileName
        End If
    End Sub


#Region "Proceso"
    Private Async Function ProcesarFormato(formato As DisenioTxt, lineasDisenio As List(Of List(Of String)), conn As SqlConnection, tran As SqlTransaction) As Task
        Dim lineasBulk As IEnumerable(Of IEnumerable(Of List(Of String))) = Nothing

        Try
            Await Task.Run(Sub()
                               SetLabelProgreso(lblProgreso, "Obteniendo registros del diseño " & Integer.Parse(formato).ToString() & "...")
                           End Sub)

            lineasBulk = lineasDisenio.Partir(10000)
            progressBar.Maximum = lineasBulk.Count()
            progressBar.Value = 0
            Await Task.Run(Sub()
                               SetLabelProgreso(lblProgreso, "Procesando diseño " & CType(formato, Integer).ToString & "...")

                               lineasBulk.ToList() _
                               .ForEach(Sub(lin)
                                            Dim bulkCopy As New SqlBulkCopy(conn, SqlBulkCopyOptions.Default, tran)
                                            bulkCopy.DestinationTableName = "dbo." & TableName & "_" & CType(formato, Integer).ToString

                                            Try

                                                bulkCopy.WriteToServer(MakeTable(lin.ToList(), formato))
                                                IncrementarProgress(progressBar, 1)

                                            Catch ex As Exception
                                                Throw New Exception("Ocurrió un error al procesar registros de diseño " & CType(formato, Integer).ToString, ex)
                                            End Try
                                            bulkCopy = Nothing
                                        End Sub)
                           End Sub)
        Finally
            lineasDisenio.RemoveAll(Function(r) r(0) = CType(formato, Integer).ToString)
            lineasBulk = Nothing
        End Try
    End Function

    Private Function MakeTable(lines As List(Of List(Of String)), formato As DisenioTxt) As DataTable

        Dim tablaSQL As New DataTable(TableName & CType(formato, Integer).ToString)
        _formatos(formato).ForEach(Sub(f)
                                       Try
                                           Dim col As New DataColumn()
                                           Select Case f.TipoDato
                                               Case SqlDbType.BigInt
                                                   col.DataType = System.Type.GetType("System.Int64")
                                               Case SqlDbType.Int
                                                   col.DataType = System.Type.GetType("System.Int32")
                                               Case SqlDbType.VarChar
                                                   col.DataType = System.Type.GetType("System.String")
                                               Case SqlDbType.Decimal
                                                   col.DataType = System.Type.GetType("System.Decimal")
                                               Case SqlDbType.DateTime
                                                   col.DataType = System.Type.GetType("System.DateTime")
                                               Case Else
                                                   col.DataType = System.Type.GetType("System.String")
                                           End Select
                                           col.ColumnName = f.Nombre
                                           tablaSQL.Columns.Add(col)
                                       Catch ex As Exception
                                           Throw New Exception("Ocurrió un error armando DataTable formato " & formato.ToString)
                                       End Try
                                   End Sub)

        lines.ForEach(Sub(l)
                          Dim terminos = l
                          If terminos.Count > 0 Then

                              Dim Row = tablaSQL.NewRow()
                              _formatos(formato) _
                              .ForEach(Sub(f)
                                           Try
                                               If terminos(f.Indice).Trim().Count = 0 Then
                                                   Row(f.Nombre) = DBNull.Value
                                               Else
                                                   Select Case f.TipoDato
                                                       Case SqlDbType.VarChar
                                                           Row(f.Nombre) = terminos(f.Indice).Trim()
                                                       Case SqlDbType.Decimal
                                                           Row(f.Nombre) = Decimal.Parse(terminos(f.Indice).Trim())
                                                       Case SqlDbType.Int
                                                           Row(f.Nombre) = Int32.Parse(terminos(f.Indice).Trim())
                                                       Case SqlDbType.BigInt
                                                           Row(f.Nombre) = Int64.Parse(terminos(f.Indice).Trim())
                                                       Case SqlDbType.DateTime
                                                           Dim dd As Date
                                                           Dim d = String.Empty
                                                           If terminos(f.Indice).Trim().Length = 8 Then
                                                               If DateTime.TryParseExact(terminos(f.Indice).Trim(), "yyyyMMdd", System.Globalization.DateTimeFormatInfo.InvariantInfo, Globalization.DateTimeStyles.None, dd) Then
                                                                   d = dd.ToString("yyyy-MM-dd")
                                                               End If
                                                           Else
                                                               Try
                                                                   dd = New DateTime(CType(terminos(f.Indice).Trim().Substring(0, 4), Integer), CType(terminos(f.Indice).Trim().Substring(4, 2), Integer), 1)
                                                               Catch
                                                                   dd = New DateTime(CType(terminos(f.Indice).Trim().Substring(2, 4), Integer), CType(terminos(f.Indice).Trim().Substring(0, 2), Integer), 1)
                                                               End Try
                                                               d = dd.ToString("yyyy-MM-dd")
                                                           End If
                                                           If d.Count = 0 Then
                                                               Row(f.Nombre) = DBNull.Value
                                                           Else
                                                               Row(f.Nombre) = DateTime.Parse(d.Trim())
                                                           End If
                                                       Case Else
                                                           Row(f.Nombre) = terminos(f.Indice).Trim()
                                                   End Select
                                               End If
                                           Catch ex As Exception
                                               Throw ex
                                           End Try
                                       End Sub)
                              tablaSQL.Rows.Add(Row)
                          End If
                      End Sub)
        Return tablaSQL
    End Function

    Private Sub DropYCrearTabla(disenio As DisenioTxt, conn As SqlConnection, tran As SqlTransaction)

        Dim cmdCreateTable As New SqlCommand($"IF OBJECT_ID('dbo.{TableName}_{Integer.Parse(disenio).ToString()}', 'U') IS NOT NULL DROP TABLE {TableName}_{Integer.Parse(disenio).ToString}", conn)
        cmdCreateTable.Transaction = tran

        cmdCreateTable.ExecuteNonQuery()

        cmdCreateTable.CommandText = $"CREATE TABLE {TableName}_{Integer.Parse(disenio).ToString} ("

        _formatos(disenio).OrderBy(Function(d) d.Indice) _
        .ToList().ForEach(Sub(d)
                              Select Case d.TipoDato
                                  Case SqlDbType.BigInt
                                      cmdCreateTable.CommandText = cmdCreateTable.CommandText & $"{d.Nombre} BIGINT NULL "
                                  Case SqlDbType.Int
                                      cmdCreateTable.CommandText = cmdCreateTable.CommandText & $"{d.Nombre} INT NULL "
                                  Case SqlDbType.Decimal
                                      cmdCreateTable.CommandText = cmdCreateTable.CommandText & $"{d.Nombre} Decimal(18,4) NULL "
                                  Case SqlDbType.VarChar
                                      cmdCreateTable.CommandText = cmdCreateTable.CommandText & $"{d.Nombre} VARCHAR({d.LongitudCampo}) NULL "
                                  Case SqlDbType.DateTime
                                      cmdCreateTable.CommandText = cmdCreateTable.CommandText & $"{d.Nombre} DATETIME NULL "
                              End Select
                              If d.Indice < _formatos(disenio).Count() Then
                                  cmdCreateTable.CommandText = cmdCreateTable.CommandText & ", "
                              End If
                          End Sub)

        cmdCreateTable.CommandText = cmdCreateTable.CommandText & ")"


        cmdCreateTable.ExecuteNonQuery()
    End Sub

    Private Sub CargarFormatos(disenio As DisenioTxt)
        If Not _formatos.ContainsKey(disenio) Then
            _formatos.Add(disenio, New List(Of Columna)())
        End If

        _formatos(disenio).Clear()

        Select Case disenio
            Case DisenioTxt.D4305
#Region "diseño 4305"
                _formatos(disenio).Add(New Columna("TipoIdentificacion", 1, 2, SqlDbType.VarChar))
                _formatos(disenio).Add(New Columna("NroIdentificacion", 2, 11, SqlDbType.VarChar))
                _formatos(disenio).Add(New Columna("Denominacion", 3, 55, SqlDbType.VarChar))
                _formatos(disenio).Add(New Columna("Categoria", 4, 1, SqlDbType.Int))
                _formatos(disenio).Add(New Columna("ResidenciaSector", 5, 1, SqlDbType.Int))
                _formatos(disenio).Add(New Columna("Gobierno", 6, 1, SqlDbType.Int))
                _formatos(disenio).Add(New Columna("Provincia", 7, 2, SqlDbType.VarChar))
                _formatos(disenio).Add(New Columna("Situacion", 8, 2, SqlDbType.VarChar))
                _formatos(disenio).Add(New Columna("Vinculacion", 9, 1, SqlDbType.Int))
                _formatos(disenio).Add(New Columna("PrevisionesAsistenciaCrediticia", 10, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("PrevisionesParticipaciones", 11, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("PrevRespEventGtiaOtorgadas", 12, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("IncPrevMinPermCat4o5Gral", 13, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("IncPrevMinPermCat4o5Normas", 14, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("MaxAsistCliVincODeuda05", 15, 14, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("TotalFinancionesDeudor", 16, 14, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("ActividadPrincipal", 17, 3, SqlDbType.VarChar))
                _formatos(disenio).Add(New Columna("InformacionTransitoria", 18, 1, SqlDbType.Int))
                _formatos(disenio).Add(New Columna("DeudorLey25326Art26", 19, 1, SqlDbType.Int))
                _formatos(disenio).Add(New Columna("Refinanciaciones", 20, 1, SqlDbType.Int))
                _formatos(disenio).Add(New Columna("RecatObligatoria", 21, 1, SqlDbType.Int))
                _formatos(disenio).Add(New Columna("SituacionJuridica", 22, 1, SqlDbType.Int))
                _formatos(disenio).Add(New Columna("IrrecuperablesDispTecnica", 23, 1, SqlDbType.Int))
                _formatos(disenio).Add(New Columna("DiasAtrasoEnPago", 24, 4, SqlDbType.Int))
                _formatos(disenio).Add(New Columna("MiPyME", 25, 2, SqlDbType.VarChar))
                _formatos(disenio).Add(New Columna("SituacionSinReclasificar", 26, 2, SqlDbType.VarChar))
#End Region
            Case DisenioTxt.D4306
#Region "Diseño 4306"
                _formatos(disenio).Add(New Columna("TipoIdentificacion", 1, 2, SqlDbType.VarChar))
                _formatos(disenio).Add(New Columna("NroIdentificacion", 2, 11, SqlDbType.VarChar))
                _formatos(disenio).Add(New Columna("TipoAsistenciaCrediticia", 3, 2, SqlDbType.Int))
                _formatos(disenio).Add(New Columna("GtiaPrefACapIntDevengDeudaVenc", 4, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("GtiaPrefACapIntDevengDeudaTotal", 5, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("GtiaPrefACapIntDevengNoPrevDeudaVenc", 6, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("GtiaPrefACapIntDevengNoPrevDeudaTotal", 7, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("GtiaPrefBIntDevengPrevDeudaVenc", 8, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("GtiaPrefBIntDevengPrevDeudaTotal", 9, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("SinGtiaPrefCapIntDevengNoPrevDeudaVenc", 10, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("SinGtiaPrefCapIntDevengNoPrevDeudaTotal", 11, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("SinGtiaPrefIntDevengPrevDeudaVenc", 12, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("SinGtiaPrefIntDevengPrevDeudaTotal", 13, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("PrevMinCreAdicionales", 14, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("FechaUltimaRefinanciacion", 15, 8, SqlDbType.DateTime))
                _formatos(disenio).Add(New Columna("FinanciacionParaMiPyMEs", 16, 12, SqlDbType.Decimal))
#End Region
            Case DisenioTxt.D4307
#Region "Diseño 4307"
                _formatos(disenio).Add(New Columna("TipoIdentificacion", 1, 2, SqlDbType.VarChar))
                _formatos(disenio).Add(New Columna("NroIdentificacion", 2, 11, SqlDbType.VarChar))
                _formatos(disenio).Add(New Columna("ParticiOtrasSociedadesDeducRPC", 3, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("ParticiOtrasSociedadesNoDeducRPC", 4, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("AdelCtaCteAcordadosConContragtiasPrefA", 5, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("AdelCtaCteAcordadosConContragtiasPrefB", 6, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("AdelCtaCteAcordadosSinContragtiasPref", 7, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("ResponsEventualesConContragtiasPrefA", 8, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("ResponsEventualesConContragtiasPrefB", 9, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("ResponsEventualesSinContragtiasPref", 10, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("GtiasOtorgadasConContragtiasPrefA", 11, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("GtiasOtorgadasConContragtiasPrefB", 12, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("GtiasOtorgadasSinContragtiasPref", 13, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("MontoPorIrrecuperablesCtasOrden", 14, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("FinanciacionesFianzasAvalesOtrasRespOtorExt", 15, 12, SqlDbType.Decimal))
                _formatos(disenio).Add(New Columna("DiferenciaPorAdquisicionCartera", 16, 12, SqlDbType.Decimal))

#End Region
        End Select
    End Sub

#End Region

#Region "Delegados"

    Delegate Sub ChangeProgressDelegado(ctrl As ProgressBar, valor As Integer)
    Public Sub IncrementarProgress(ctrl As ProgressBar, valor As Integer)

        If ctrl.InvokeRequired Then
            Dim del As ChangeProgressDelegado = AddressOf IncrementarProgress
            ctrl.Invoke(del, ctrl, valor)
        Else
            IncrementarProgressInterno(ctrl, valor)
        End If
    End Sub

    Delegate Sub ChangeMyTextDelegate(ctrl As Control, text As String)
    Public Sub SetLabelProgreso(ctrl As Control, text As String)

        If ctrl.InvokeRequired Then
            Dim del As ChangeMyTextDelegate = AddressOf SetLabelProgreso
            ctrl.Invoke(del, ctrl, text)
        Else
            ctrl.Text = text
            Thread.Sleep(200)
        End If
    End Sub



#End Region

End Class

Public Module Utilidades
    <Extension()>
    Public Function Clone(Of Tipo)(list As IEnumerable(Of Tipo)) As IList(Of Tipo)
        Return list.ToList().Clone()
    End Function

    <Extension()>
    Public Function Clone(Of Tipo)(list As IList(Of Tipo)) As IList(Of Tipo)

        Dim NewList As New List(Of Tipo)()

        NewList.AddRange(list)
        Return NewList
    End Function

    <Extension()>
    Public Iterator Function Partir(Of TipoObjeto)(Lista As IEnumerable(Of TipoObjeto), Cantidad As Integer) As IEnumerable(Of IEnumerable(Of TipoObjeto))
        Dim newList As New List(Of TipoObjeto)()
        Dim Cnt = 1

        For Each item As TipoObjeto In Lista
            newList.Add(item)
            Cnt = Cnt + 1
            If Cnt > Cantidad Then
                Yield newList.Clone()

                newList.Clear()
                Cnt = 1
            End If

        Next

        If newList.Count() > 0 Then
            Yield newList.Clone()
        End If
    End Function
End Module

Public Class Columna
    Public Nombre As String
    Public TipoDato As SqlDbType
    Public LongitudCampo As Integer
    Public Valor As Object
    Public Indice As Integer

    Public Sub New(nombre As String, indice As Integer, longitud As Integer, tipo As SqlDbType)
        Me.Nombre = nombre
        Me.Indice = indice
        Me.LongitudCampo = longitud
        Me.TipoDato = tipo
    End Sub
End Class

