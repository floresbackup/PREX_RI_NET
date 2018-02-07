<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrafico
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
      Me.PanTop = New DevExpress.XtraEditors.PanelControl
      Me.lblSubtitulo = New DevExpress.XtraEditors.LabelControl
      Me.lblTitulo = New DevExpress.XtraEditors.LabelControl
      Me.panBotones = New DevExpress.XtraEditors.PanelControl
      Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
      Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton
      Me.cmdCerrar = New DevExpress.XtraEditors.SimpleButton
      Me.panGrafico = New DevExpress.XtraEditors.PanelControl
      Me.TChart = New DevExpress.XtraCharts.ChartControl
      Me.picLogo = New DevExpress.XtraEditors.PictureEdit
      CType(Me.PanTop, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.PanTop.SuspendLayout()
      CType(Me.panBotones, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.panBotones.SuspendLayout()
      CType(Me.panGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.panGrafico.SuspendLayout()
      CType(Me.TChart, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'PanTop
      '
      Me.PanTop.Appearance.BackColor = System.Drawing.Color.White
      Me.PanTop.Appearance.Options.UseBackColor = True
      Me.PanTop.Controls.Add(Me.lblSubtitulo)
      Me.PanTop.Controls.Add(Me.lblTitulo)
      Me.PanTop.Controls.Add(Me.picLogo)
      Me.PanTop.Dock = System.Windows.Forms.DockStyle.Top
      Me.PanTop.Location = New System.Drawing.Point(0, 0)
      Me.PanTop.LookAndFeel.UseDefaultLookAndFeel = False
      Me.PanTop.Name = "PanTop"
      Me.PanTop.Size = New System.Drawing.Size(614, 54)
      Me.PanTop.TabIndex = 16
      '
      'lblSubtitulo
      '
      Me.lblSubtitulo.Location = New System.Drawing.Point(24, 29)
      Me.lblSubtitulo.Name = "lblSubtitulo"
      Me.lblSubtitulo.Size = New System.Drawing.Size(289, 13)
      Me.lblSubtitulo.TabIndex = 2
      Me.lblSubtitulo.Text = "Vista previa del gráfico seleccione una opción para continuar"
      '
      'lblTitulo
      '
      Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
      Me.lblTitulo.Appearance.Options.UseFont = True
      Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
      Me.lblTitulo.Name = "lblTitulo"
      Me.lblTitulo.Size = New System.Drawing.Size(40, 13)
      Me.lblTitulo.TabIndex = 1
      Me.lblTitulo.Text = "Gráfico"
      '
      'panBotones
      '
      Me.panBotones.Controls.Add(Me.cmdImprimir)
      Me.panBotones.Controls.Add(Me.cmdGuardar)
      Me.panBotones.Controls.Add(Me.cmdCerrar)
      Me.panBotones.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.panBotones.Location = New System.Drawing.Point(0, 430)
      Me.panBotones.Name = "panBotones"
      Me.panBotones.Size = New System.Drawing.Size(614, 33)
      Me.panBotones.TabIndex = 22
      '
      'cmdImprimir
      '
      Me.cmdImprimir.Location = New System.Drawing.Point(5, 5)
      Me.cmdImprimir.Name = "cmdImprimir"
      Me.cmdImprimir.Size = New System.Drawing.Size(75, 23)
      Me.cmdImprimir.TabIndex = 2
      Me.cmdImprimir.Text = "&Imprimir"
      '
      'cmdGuardar
      '
      Me.cmdGuardar.Location = New System.Drawing.Point(86, 5)
      Me.cmdGuardar.Name = "cmdGuardar"
      Me.cmdGuardar.Size = New System.Drawing.Size(75, 23)
      Me.cmdGuardar.TabIndex = 1
      Me.cmdGuardar.Text = "&Guardar"
      '
      'cmdCerrar
      '
      Me.cmdCerrar.Location = New System.Drawing.Point(167, 5)
      Me.cmdCerrar.Name = "cmdCerrar"
      Me.cmdCerrar.Size = New System.Drawing.Size(75, 23)
      Me.cmdCerrar.TabIndex = 0
      Me.cmdCerrar.Text = "&Cerrar"
      '
      'panGrafico
      '
      Me.panGrafico.Controls.Add(Me.TChart)
      Me.panGrafico.Dock = System.Windows.Forms.DockStyle.Fill
      Me.panGrafico.Location = New System.Drawing.Point(0, 54)
      Me.panGrafico.Name = "panGrafico"
      Me.panGrafico.Size = New System.Drawing.Size(614, 376)
      Me.panGrafico.TabIndex = 23
      '
      'TChart
      '
      Me.TChart.Dock = System.Windows.Forms.DockStyle.Fill
      Me.TChart.Location = New System.Drawing.Point(2, 2)
      Me.TChart.Name = "TChart"
      Me.TChart.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
      Me.TChart.SeriesTemplate.PointOptionsTypeName = "PointOptions"
      Me.TChart.Size = New System.Drawing.Size(610, 372)
      Me.TChart.TabIndex = 1
      '
      'picLogo
      '
      Me.picLogo.Dock = System.Windows.Forms.DockStyle.Right
      Me.picLogo.EditValue = Global.VBP04295.My.Resources.Resources.Chart
      Me.picLogo.Location = New System.Drawing.Point(553, 2)
      Me.picLogo.Name = "picLogo"
      Me.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
      Me.picLogo.Properties.Appearance.Options.UseBackColor = True
      Me.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
      Me.picLogo.Size = New System.Drawing.Size(59, 50)
      Me.picLogo.TabIndex = 0
      '
      'frmGrafico
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(614, 463)
      Me.Controls.Add(Me.panGrafico)
      Me.Controls.Add(Me.panBotones)
      Me.Controls.Add(Me.PanTop)
      Me.Name = "frmGrafico"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = " Gráfico"
      CType(Me.PanTop, System.ComponentModel.ISupportInitialize).EndInit()
      Me.PanTop.ResumeLayout(False)
      Me.PanTop.PerformLayout()
      CType(Me.panBotones, System.ComponentModel.ISupportInitialize).EndInit()
      Me.panBotones.ResumeLayout(False)
      CType(Me.panGrafico, System.ComponentModel.ISupportInitialize).EndInit()
      Me.panGrafico.ResumeLayout(False)
      CType(Me.TChart, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents PanTop As DevExpress.XtraEditors.PanelControl
   Friend WithEvents lblSubtitulo As DevExpress.XtraEditors.LabelControl
   Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
   Friend WithEvents picLogo As DevExpress.XtraEditors.PictureEdit
   Friend WithEvents panBotones As DevExpress.XtraEditors.PanelControl
   Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents cmdCerrar As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents panGrafico As DevExpress.XtraEditors.PanelControl
   Friend WithEvents TChart As DevExpress.XtraCharts.ChartControl
End Class
