Imports DevExpress.XtraEditors.Controls
Imports VBP04296.Dominio

Public Class frmABMPro


    Public Proceso As ProSys
    Private _lstProcesos As List(Of ProSys)

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        cboProcesos.Properties.Items.Add(New ComboBoxItem(eProcesos.ConsActualizar))
        cboProcesos.Properties.Items.Add(New ComboBoxItem(eProcesos.ConsActualizarEx))
        cboProcesos.Properties.Items.Add(New ComboBoxItem(eProcesos.ConsFechaFinMes))
        cboProcesos.Properties.Items.Add(New ComboBoxItem(eProcesos.ConsFormatoCondicional))
        cboProcesos.Properties.Items.Add(New ComboBoxItem(eProcesos.ConsValidarPeriodo))

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub PasarDatos(ByRef proceso As ProSys, procesos As List(Of ProSys))
        Me.Proceso = proceso
        If Me.Proceso Is Nothing Then Me.Proceso = New ProSys("K" & (procesos.Count() + 1).ToString)
        _lstProcesos = procesos
        CargarProcesoSeleccionado(proceso)
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If txtDescripcion.Text.Any() AndAlso txtTitulo.Text.Any _
            AndAlso txtParametros.Text.Any AndAlso cboProcesos.SelectedIndex > -1 Then
            Proceso.Descripcion = txtDescripcion.Text
            Proceso.Titulo = txtTitulo.Text
            Proceso.Parametros = txtParametros.Text
            Proceso.Nombre = cboProcesos.SelectedText
            If Proceso.Orden = 0 Then
                Proceso.Orden = _lstProcesos.Count() + 1
            End If
        Else
            Prex.Utils.MensajesForms.MostrarError("Debe completar todos los datos")
            Me.DialogResult = DialogResult.Abort
        End If
    End Sub

    Private Sub FormAbmPro(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.DialogResult = DialogResult.Abort Then
            e.Cancel = True
        End If
    End Sub

    Private Sub cboProcesos_Properties_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProcesos.Properties.SelectedIndexChanged
        If cboProcesos.SelectedIndex = -1 Then
            Exit Sub
        End If
        Dim proc As eProcesos = cboProcesos.SelectedItem

        Select Case proc
            Case eProcesos.ConsActualizar, eProcesos.ConsActualizarEx
                lblInfoParametro.Text = "Puede establecer las variables de entrada para procesar." & vbCrLf & "(Ej. @CUADRO|@FECVIG|@CODCON|@CODENT|54|1|0|DATCUA|DC)"
            Case eProcesos.ConsActualizar_PNP
                lblInfoParametro.Text = String.Empty
            Case eProcesos.ConsFechaFinMes
                lblInfoParametro.Text = "Puede establecer una variable de entrada para indicar el período para evaluar." & vbCrLf & "(Ej. @FECVIG)"
            Case eProcesos.ConsFormatoCondicional
                lblInfoParametro.Text = "Ej. 17"
            Case eProcesos.ConsValidarPeriodo
                lblInfoParametro.Text = "Puede establecer las variables de entrada para validar." & vbCrLf & "(Ej. @FECVIG|@CODCON|@CODENT|@CUADRO|DATCUA|DC)"
            Case Else
                lblInfoParametro.Text = String.Empty
        End Select
    End Sub

    Private Sub CargarProcesoSeleccionado(proc As ProSys)
        If proc Is Nothing Then
            txtDescripcion.Text = String.Empty
            txtTitulo.Text = String.Empty
            txtParametros.Text = String.Empty
            cboProcesos.SelectedItem = Nothing
        Else
            txtDescripcion.Text = proc.Descripcion
            txtTitulo.Text = proc.Titulo
            txtParametros.Text = proc.Parametros
            cboProcesos.SelectedItem = proc.Proceso
        End If
    End Sub
End Class