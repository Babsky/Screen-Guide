Public Class FrmStart

	Private Sub FrmStart_Load(sender As Object, e As EventArgs) Handles Me.Load

		CboColour.Items.Add("None")
		CboColour.Items.Add("Yellow")
		CboColour.Items.Add("Orange")
		CboColour.Items.Add("Red")
		CboColour.Items.Add("Grey")
		CboColour.SelectedIndex = 0

		BtnAbout.Text = "About"
		BtnClose.Text = "Close"
	End Sub


	Private Sub CboColour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboColour.SelectedIndexChanged
		If CboColour.SelectedIndex = 0 Then
			'None
			FrmGuide.Close()
		Else

			If CboColour.SelectedIndex = 1 Then
				'Yellow
				FrmGuide.BackgroundImage = Screen_Guide.My.Resources.Resources.yellow
			ElseIf CboColour.SelectedIndex = 2 Then
				'Orange
				FrmGuide.BackgroundImage = Screen_Guide.My.Resources.Resources.orange
			ElseIf CboColour.SelectedIndex = 3 Then
				'Red
				FrmGuide.BackgroundImage = Screen_Guide.My.Resources.Resources.red
			ElseIf CboColour.SelectedIndex = 4 Then
				'Grey
				FrmGuide.BackgroundImage = Screen_Guide.My.Resources.Resources.grey
			End If

			FrmGuide.Show()
			Me.WindowState = FormWindowState.Minimized

		End If
	End Sub

	Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
		Me.Close()
	End Sub

	Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
		AbtScreenGuide.Show()
	End Sub
End Class
