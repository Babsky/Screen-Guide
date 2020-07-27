<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStart
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStart))
		Me.CboColour = New System.Windows.Forms.ComboBox()
		Me.LblColour = New System.Windows.Forms.Label()
		Me.BtnClose = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'CboColour
		'
		Me.CboColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CboColour.FormattingEnabled = True
		Me.CboColour.Location = New System.Drawing.Point(108, 32)
		Me.CboColour.Name = "CboColour"
		Me.CboColour.Size = New System.Drawing.Size(185, 21)
		Me.CboColour.TabIndex = 0
		'
		'LblColour
		'
		Me.LblColour.AutoSize = True
		Me.LblColour.Location = New System.Drawing.Point(12, 35)
		Me.LblColour.Name = "LblColour"
		Me.LblColour.Size = New System.Drawing.Size(68, 13)
		Me.LblColour.TabIndex = 1
		Me.LblColour.Text = "Guide Colour"
		Me.LblColour.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'BtnClose
		'
		Me.BtnClose.Location = New System.Drawing.Point(218, 84)
		Me.BtnClose.Name = "BtnClose"
		Me.BtnClose.Size = New System.Drawing.Size(75, 23)
		Me.BtnClose.TabIndex = 2
		Me.BtnClose.Text = "Button1"
		Me.BtnClose.UseVisualStyleBackColor = True
		'
		'FrmStart
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(319, 123)
		Me.Controls.Add(Me.BtnClose)
		Me.Controls.Add(Me.LblColour)
		Me.Controls.Add(Me.CboColour)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "FrmStart"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.Text = "Screen Guide"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents CboColour As ComboBox
	Friend WithEvents LblColour As Label
	Friend WithEvents BtnClose As Button
End Class
