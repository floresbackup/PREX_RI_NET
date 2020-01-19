Public Class frmABMPro
    Public Enum Procesos
        ConsFechaFinMes = 0
        ConsValidarPeriodo = 1
        ConsActualizar = 2
        ConsFormatoCondicional = 3
        ConsActualizarEx = 4
        ConsActualizar_PNP = 5
    End Enum


    Private _proceso As ProSys
    Private _lstProcesos As List(Of ProSys)

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub PasarDatos(ByRef proceso As ProSys, procesos As List(Of ProSys))
        _proceso = proceso
        _lstProcesos = procesos
        CargarProcesoSeleccionado(proceso)
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        _proceso.Descripcion = txtDescripcion.Text
        _proceso.Titulo = txtTitulo.Text
        _proceso.Parametros = txtParametros.Text
    End Sub

    Private Sub cboProcesos_Properties_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProcesos.Properties.SelectedIndexChanged
        Dim proc As Procesos = [Enum].Parse(GetType(Procesos), cboProcesos.SelectedText)

        Select Case proc
            Case Procesos.ConsActualizar
            Case Procesos.ConsActualizarEx
                lblInfoParametro.Text = "Puede establecer las variables de entrada para procesar." & vbCrLf & "(Ej. @CUADRO|@FECVIG|@CODCON|@CODENT|54|1|0|DATCUA|DC)"
            Case Procesos.ConsActualizar_PNP
                lblInfoParametro.Text = String.Empty
            Case Procesos.ConsFechaFinMes
                lblInfoParametro.Text = "Puede establecer una variable de entrada para indicar el período para evaluar." & vbCrLf & "(Ej. @FECVIG)"
            Case Procesos.ConsFormatoCondicional
                lblInfoParametro.Text = "Ej. 17"
            Case Procesos.ConsValidarPeriodo
                lblInfoParametro.Text = "Puede establecer las variables de entrada para validar." & vbCrLf & "(Ej. @FECVIG|@CODCON|@CODENT|@CUADRO|DATCUA|DC)"
            Case Else
                lblInfoParametro.Text = String.Empty
        End Select
    End Sub

    Private Sub CargarProcesoSeleccionado(proc As ProSys)
        txtDescripcion.Text = proc.Descripcion
        txtTitulo.Text = proc.Titulo
        txtParametros.Text = proc.Parametros
    End Sub
End Class