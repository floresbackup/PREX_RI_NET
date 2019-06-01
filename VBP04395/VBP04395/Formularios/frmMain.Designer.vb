<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
   Inherits System.Windows.Forms.Form

   'Form reemplaza a Dispose para limpiar la lista de componentes.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing AndAlso components IsNot Nothing Then
         components.Dispose()
      End If
      MyBase.Dispose(disposing)
   End Sub

   'Requerido por el Diseñador de Windows Forms
   Private components As System.ComponentModel.IContainer

   'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
   'Se puede modificar usando el Diseñador de Windows Forms.  
   'No lo modifique con el editor de código.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.sbMain = New System.Windows.Forms.StatusStrip()
        Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblEntidad = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolMain = New System.Windows.Forms.ToolStrip()
        Me.lblTransaccion = New System.Windows.Forms.ToolStripLabel()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.tsSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAyuda = New System.Windows.Forms.ToolStripButton()
        Me.tsSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblVersion = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.panControles = New System.Windows.Forms.Panel()
        Me.panTop = New System.Windows.Forms.Panel()
        Me.panProceso = New System.Windows.Forms.Panel()
        Me.cmdInv = New System.Windows.Forms.Button()
        Me.cmdTodo = New System.Windows.Forms.Button()
        Me.PB = New System.Windows.Forms.ProgressBar()
        Me.cmdProcesar = New System.Windows.Forms.Button()
        Me.panLV = New System.Windows.Forms.Panel()
        Me.lvSel = New System.Windows.Forms.ListView()
        Me.Tarea = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Estado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tmrProceso = New System.Windows.Forms.Timer(Me.components)
        Me.sbMain.SuspendLayout()
        Me.toolMain.SuspendLayout()
        Me.panControles.SuspendLayout()
        Me.panProceso.SuspendLayout()
        Me.panLV.SuspendLayout()
        Me.SuspendLayout()
        '
        'sbMain
        '
        Me.sbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUsuario, Me.lblEntidad})
        Me.sbMain.Location = New System.Drawing.Point(0, 390)
        Me.sbMain.Name = "sbMain"
        Me.sbMain.Size = New System.Drawing.Size(626, 25)
        Me.sbMain.SizingGrip = False
        Me.sbMain.TabIndex = 8
        '
        'lblUsuario
        '
        Me.lblUsuario.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblUsuario.Image = Global.VBP04395.My.Resources.Resources.Messenger_Information
        Me.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(472, 20)
        Me.lblUsuario.Spring = True
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEntidad
        '
        Me.lblEntidad.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblEntidad.Image = Global.VBP04395.My.Resources.Resources.Home
        Me.lblEntidad.Name = "lblEntidad"
        Me.lblEntidad.Size = New System.Drawing.Size(139, 20)
        Me.lblEntidad.Text = "Banco de Prueba S.A."
        '
        'toolMain
        '
        Me.toolMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTransaccion, Me.btnSalir, Me.tsSep1, Me.btnAyuda, Me.tsSep2, Me.lblVersion, Me.ToolStripSeparator6})
        Me.toolMain.Location = New System.Drawing.Point(0, 0)
        Me.toolMain.Name = "toolMain"
        Me.toolMain.Size = New System.Drawing.Size(626, 25)
        Me.toolMain.TabIndex = 9
        Me.toolMain.Text = "ToolStrip1"
        '
        'lblTransaccion
        '
        Me.lblTransaccion.AutoSize = False
        Me.lblTransaccion.Image = Global.VBP04395.My.Resources.Resources.About
        Me.lblTransaccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTransaccion.Name = "lblTransaccion"
        Me.lblTransaccion.Size = New System.Drawing.Size(390, 22)
        Me.lblTransaccion.Text = "Transacción"
        Me.lblTransaccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.VBP04395.My.Resources.Resources.Cross
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(52, 22)
        Me.btnSalir.Text = " Salir"
        '
        'tsSep1
        '
        Me.tsSep1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsSep1.Name = "tsSep1"
        Me.tsSep1.Size = New System.Drawing.Size(6, 25)
        '
        'btnAyuda
        '
        Me.btnAyuda.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAyuda.Image = Global.VBP04395.My.Resources.Resources.Help_2
        Me.btnAyuda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(64, 22)
        Me.btnAyuda.Text = " Ayuda"
        '
        'tsSep2
        '
        Me.tsSep2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsSep2.Name = "tsSep2"
        Me.tsSep2.Size = New System.Drawing.Size(6, 25)
        '
        'lblVersion
        '
        Me.lblVersion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(76, 22)
        Me.lblVersion.Text = "Versión: 1.0.0"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'panControles
        '
        Me.panControles.Controls.Add(Me.panTop)
        Me.panControles.Dock = System.Windows.Forms.DockStyle.Top
        Me.panControles.Location = New System.Drawing.Point(0, 25)
        Me.panControles.Name = "panControles"
        Me.panControles.Size = New System.Drawing.Size(626, 55)
        Me.panControles.TabIndex = 11
        '
        'panTop
        '
        Me.panTop.BackColor = System.Drawing.SystemColors.Control
        Me.panTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panTop.Location = New System.Drawing.Point(0, 0)
        Me.panTop.Name = "panTop"
        Me.panTop.Size = New System.Drawing.Size(626, 1)
        Me.panTop.TabIndex = 2
        '
        'panProceso
        '
        Me.panProceso.Controls.Add(Me.cmdInv)
        Me.panProceso.Controls.Add(Me.cmdTodo)
        Me.panProceso.Controls.Add(Me.PB)
        Me.panProceso.Controls.Add(Me.cmdProcesar)
        Me.panProceso.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panProceso.Location = New System.Drawing.Point(0, 358)
        Me.panProceso.Name = "panProceso"
        Me.panProceso.Size = New System.Drawing.Size(626, 32)
        Me.panProceso.TabIndex = 13
        '
        'cmdInv
        '
        Me.cmdInv.Image = Global.VBP04395.My.Resources.Resources.db_refresh
        Me.cmdInv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdInv.Location = New System.Drawing.Point(35, 5)
        Me.cmdInv.Name = "cmdInv"
        Me.cmdInv.Size = New System.Drawing.Size(29, 23)
        Me.cmdInv.TabIndex = 3
        Me.cmdInv.UseVisualStyleBackColor = True
        '
        'cmdTodo
        '
        Me.cmdTodo.Image = Global.VBP04395.My.Resources.Resources.db_post
        Me.cmdTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTodo.Location = New System.Drawing.Point(4, 5)
        Me.cmdTodo.Name = "cmdTodo"
        Me.cmdTodo.Size = New System.Drawing.Size(29, 23)
        Me.cmdTodo.TabIndex = 2
        Me.cmdTodo.UseVisualStyleBackColor = True
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(70, 10)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(445, 13)
        Me.PB.TabIndex = 1
        '
        'cmdProcesar
        '
        Me.cmdProcesar.Location = New System.Drawing.Point(523, 6)
        Me.cmdProcesar.Name = "cmdProcesar"
        Me.cmdProcesar.Size = New System.Drawing.Size(98, 22)
        Me.cmdProcesar.TabIndex = 0
        Me.cmdProcesar.Text = "&Procesar"
        Me.cmdProcesar.UseVisualStyleBackColor = True
        '
        'panLV
        '
        Me.panLV.Controls.Add(Me.lvSel)
        Me.panLV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panLV.Location = New System.Drawing.Point(0, 80)
        Me.panLV.Name = "panLV"
        Me.panLV.Size = New System.Drawing.Size(626, 278)
        Me.panLV.TabIndex = 14
        '
        'lvSel
        '
        Me.lvSel.CheckBoxes = True
        Me.lvSel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Tarea, Me.Estado})
        Me.lvSel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvSel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lvSel.LabelWrap = False
        Me.lvSel.Location = New System.Drawing.Point(0, 0)
        Me.lvSel.Name = "lvSel"
        Me.lvSel.Size = New System.Drawing.Size(626, 278)
        Me.lvSel.TabIndex = 11
        Me.lvSel.UseCompatibleStateImageBehavior = False
        Me.lvSel.View = System.Windows.Forms.View.Details
        '
        'Tarea
        '
        Me.Tarea.Text = "Tarea"
        Me.Tarea.Width = 450
        '
        'Estado
        '
        Me.Estado.Text = "Estado"
        Me.Estado.Width = 150
        '
        'tmrProceso
        '
        Me.tmrProceso.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 415)
        Me.Controls.Add(Me.panLV)
        Me.Controls.Add(Me.panProceso)
        Me.Controls.Add(Me.panControles)
        Me.Controls.Add(Me.toolMain)
        Me.Controls.Add(Me.sbMain)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procesos del sistema"
        Me.sbMain.ResumeLayout(False)
        Me.sbMain.PerformLayout()
        Me.toolMain.ResumeLayout(False)
        Me.toolMain.PerformLayout()
        Me.panControles.ResumeLayout(False)
        Me.panProceso.ResumeLayout(False)
        Me.panLV.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sbMain As System.Windows.Forms.StatusStrip
   Friend WithEvents lblUsuario As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents lblEntidad As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents toolMain As System.Windows.Forms.ToolStrip
   Friend WithEvents lblTransaccion As System.Windows.Forms.ToolStripLabel
   Friend WithEvents tsSep1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnAyuda As System.Windows.Forms.ToolStripButton
   Friend WithEvents tsSep2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
   Friend WithEvents lblVersion As System.Windows.Forms.ToolStripLabel
   Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents panControles As System.Windows.Forms.Panel
   Friend WithEvents panTop As System.Windows.Forms.Panel
   Friend WithEvents panProceso As System.Windows.Forms.Panel
   Friend WithEvents cmdProcesar As System.Windows.Forms.Button
   Friend WithEvents panLV As System.Windows.Forms.Panel
   Friend WithEvents lvSel As System.Windows.Forms.ListView
   Friend WithEvents Tarea As System.Windows.Forms.ColumnHeader
   Friend WithEvents Estado As System.Windows.Forms.ColumnHeader
   Friend WithEvents tmrProceso As System.Windows.Forms.Timer
   Friend WithEvents PB As System.Windows.Forms.ProgressBar
   Friend WithEvents cmdTodo As System.Windows.Forms.Button
   Friend WithEvents cmdInv As System.Windows.Forms.Button
End Class
