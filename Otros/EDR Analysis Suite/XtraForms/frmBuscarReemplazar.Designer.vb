<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarReemplazar
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblBuscar = New DevExpress.XtraEditors.LabelControl
        Me.txtBuscar = New DevExpress.XtraEditors.TextEdit
        Me.txtReemplazar = New DevExpress.XtraEditors.TextEdit
        Me.lblReemplazar = New DevExpress.XtraEditors.LabelControl
        Me.chkMayusculas = New DevExpress.XtraEditors.CheckEdit
        Me.chkPalabraCompleta = New DevExpress.XtraEditors.CheckEdit
        Me.chkSoloSeleccion = New DevExpress.XtraEditors.CheckEdit
        Me.cmdBuscarSiguiente = New DevExpress.XtraEditors.SimpleButton
        Me.cmdReemplazar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdReemplazarTodo = New DevExpress.XtraEditors.SimpleButton
        Me.cmdMarcarTodo = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCerrar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReemplazar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMayusculas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPalabraCompleta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSoloSeleccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBuscar
        '
        Me.lblBuscar.Location = New System.Drawing.Point(12, 12)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(36, 13)
        Me.lblBuscar.TabIndex = 0
        Me.lblBuscar.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(105, 9)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(277, 20)
        Me.txtBuscar.TabIndex = 1
        '
        'txtReemplazar
        '
        Me.txtReemplazar.Location = New System.Drawing.Point(105, 35)
        Me.txtReemplazar.Name = "txtReemplazar"
        Me.txtReemplazar.Size = New System.Drawing.Size(277, 20)
        Me.txtReemplazar.TabIndex = 3
        '
        'lblReemplazar
        '
        Me.lblReemplazar.Location = New System.Drawing.Point(12, 38)
        Me.lblReemplazar.Name = "lblReemplazar"
        Me.lblReemplazar.Size = New System.Drawing.Size(80, 13)
        Me.lblReemplazar.TabIndex = 2
        Me.lblReemplazar.Text = "Reemplazar con:"
        '
        'chkMayusculas
        '
        Me.chkMayusculas.Location = New System.Drawing.Point(10, 77)
        Me.chkMayusculas.Name = "chkMayusculas"
        Me.chkMayusculas.Properties.Caption = "Coincidir mayúsculas"
        Me.chkMayusculas.Size = New System.Drawing.Size(155, 19)
        Me.chkMayusculas.TabIndex = 4
        '
        'chkPalabraCompleta
        '
        Me.chkPalabraCompleta.Location = New System.Drawing.Point(10, 102)
        Me.chkPalabraCompleta.Name = "chkPalabraCompleta"
        Me.chkPalabraCompleta.Properties.Caption = "Palabra completa"
        Me.chkPalabraCompleta.Size = New System.Drawing.Size(155, 19)
        Me.chkPalabraCompleta.TabIndex = 5
        '
        'chkSoloSeleccion
        '
        Me.chkSoloSeleccion.Location = New System.Drawing.Point(10, 127)
        Me.chkSoloSeleccion.Name = "chkSoloSeleccion"
        Me.chkSoloSeleccion.Properties.Caption = "Buscar en el texto seleccionado"
        Me.chkSoloSeleccion.Size = New System.Drawing.Size(197, 19)
        Me.chkSoloSeleccion.TabIndex = 6
        '
        'cmdBuscarSiguiente
        '
        Me.cmdBuscarSiguiente.Location = New System.Drawing.Point(396, 4)
        Me.cmdBuscarSiguiente.Name = "cmdBuscarSiguiente"
        Me.cmdBuscarSiguiente.Size = New System.Drawing.Size(112, 27)
        Me.cmdBuscarSiguiente.TabIndex = 7
        Me.cmdBuscarSiguiente.Text = "Buscar siguiente"
        '
        'cmdReemplazar
        '
        Me.cmdReemplazar.Location = New System.Drawing.Point(396, 37)
        Me.cmdReemplazar.Name = "cmdReemplazar"
        Me.cmdReemplazar.Size = New System.Drawing.Size(112, 27)
        Me.cmdReemplazar.TabIndex = 8
        Me.cmdReemplazar.Text = "Reemplazar"
        '
        'cmdReemplazarTodo
        '
        Me.cmdReemplazarTodo.Location = New System.Drawing.Point(396, 70)
        Me.cmdReemplazarTodo.Name = "cmdReemplazarTodo"
        Me.cmdReemplazarTodo.Size = New System.Drawing.Size(112, 27)
        Me.cmdReemplazarTodo.TabIndex = 9
        Me.cmdReemplazarTodo.Text = "Reemplazar todo"
        '
        'cmdMarcarTodo
        '
        Me.cmdMarcarTodo.Location = New System.Drawing.Point(396, 103)
        Me.cmdMarcarTodo.Name = "cmdMarcarTodo"
        Me.cmdMarcarTodo.Size = New System.Drawing.Size(112, 27)
        Me.cmdMarcarTodo.TabIndex = 10
        Me.cmdMarcarTodo.Text = "Marcar todo"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.Location = New System.Drawing.Point(396, 136)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(112, 27)
        Me.cmdCerrar.TabIndex = 11
        Me.cmdCerrar.Text = "Cerrar"
        '
        'frmBuscarReemplazar
        '
        Me.AcceptButton = Me.cmdBuscarSiguiente
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCerrar
        Me.ClientSize = New System.Drawing.Size(521, 174)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdMarcarTodo)
        Me.Controls.Add(Me.cmdReemplazarTodo)
        Me.Controls.Add(Me.cmdReemplazar)
        Me.Controls.Add(Me.cmdBuscarSiguiente)
        Me.Controls.Add(Me.chkSoloSeleccion)
        Me.Controls.Add(Me.chkPalabraCompleta)
        Me.Controls.Add(Me.chkMayusculas)
        Me.Controls.Add(Me.txtReemplazar)
        Me.Controls.Add(Me.lblReemplazar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarReemplazar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar y reemplazar"
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReemplazar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMayusculas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPalabraCompleta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSoloSeleccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBuscar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtReemplazar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblReemplazar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkMayusculas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPalabraCompleta As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSoloSeleccion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdBuscarSiguiente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdReemplazar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdReemplazarTodo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdMarcarTodo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCerrar As DevExpress.XtraEditors.SimpleButton
End Class
