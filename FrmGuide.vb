Public Class FrmGuide
	Private Property MoveForm As Boolean
	Private Property MoveForm_MousePosition As Point

	Private Sub FrmGuide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Set TransparencyKey to backcolour to make the guide transparent
		' The colour comes form the background image
		Me.TransparencyKey = Me.BackColor
	End Sub


	' To move Guide START
	'*****************************************************************************************************************
	Private Sub PanControl_MouseUp(sender As Object, e As MouseEventArgs) Handles PanControl.MouseUp
		If e.Button = MouseButtons.Left Then
			MoveForm = False
			Me.Cursor = Cursors.Default
		End If
	End Sub

	Private Sub PanControl_MouseDown(sender As Object, e As MouseEventArgs) Handles PanControl.MouseDown
		If e.Button = MouseButtons.Left Then
			MoveForm = True
			Me.Cursor = Cursors.Default
			MoveForm_MousePosition = e.Location
		End If
	End Sub

	Private Sub PanControl_MouseMove(sender As Object, e As MouseEventArgs) Handles PanControl.MouseMove
		If MoveForm Then
			Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
		End If
	End Sub
	' To move Guide END
	'*****************************************************************************************************************

	Private Sub PanControl_DoubleClick(sender As Object, e As EventArgs) Handles PanControl.DoubleClick
		' Double click the panel to minimise the guide
		Me.WindowState = FormWindowState.Minimized
	End Sub


End Class