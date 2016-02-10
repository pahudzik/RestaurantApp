Public Class frmAfternoonMenu

    Private Sub frmAfternoonMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = My.Computer.Screen.WorkingArea.Location
        Me.Size = My.Computer.Screen.WorkingArea.Size
        'the above code in form 2 makes the application run into full screen.
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbxItem1.Click
        frmAddModifiers.Show()
        frmAddModifiers.pbxItem.Image = pbxItem1.Image

    End Sub
End Class