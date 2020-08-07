<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGuide
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.PanControl = New System.Windows.Forms.Panel()
		Me.SuspendLayout()
		'
		'PanControl
		'
		Me.PanControl.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.PanControl.Dock = System.Windows.Forms.DockStyle.Top
		Me.PanControl.Location = New System.Drawing.Point(0, 0)
		Me.PanControl.Name = "PanControl"
		Me.PanControl.Size = New System.Drawing.Size(800, 30)
		Me.PanControl.TabIndex = 0
		'
		'FrmGuide
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.BackgroundImage = Global.Screen_Guide.My.Resources.Resources.grey
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(800, 137)
		Me.ControlBox = False
		Me.Controls.Add(Me.PanControl)
		Me.DoubleBuffered = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FrmGuide"
		Me.Opacity = 0.5R
		Me.ShowIcon = False
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
		Me.TopMost = True
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents PanControl As Panel
End Class
