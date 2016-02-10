Public Class frmAddModifiers


    Private Sub frmAddModifiers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = My.Computer.Screen.WorkingArea.Location
        Me.Size = My.Computer.Screen.WorkingArea.Size
        'the above code in form 2 makes the application run into full screen.
    End Sub
End Class