Public Class Form1
    Private Sub Time_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim time As Date
        Dim hour As Integer
        Dim minute As Integer

        time = DateTime.Now
        hour = time.Hour
        minute = time.Minute
        If hour < 11 AndAlso minute < 59 Then
            Form2.Show()
        Else
            Form3.Show()
        End If



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = My.Computer.Screen.WorkingArea.Location
        Me.Size = My.Computer.Screen.WorkingArea.Size
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

    End Sub
End Class
