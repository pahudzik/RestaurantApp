Public Class frmMainMenu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Dim time As Date
        Dim hour As Integer
        Dim minute As Integer

        time = DateTime.Now
        hour = time.Hour
        minute = time.Minute
        If hour < 11 AndAlso minute < 59 Then
            frmBreakfastMenu.Show()
        Else
            frmAfternoonMenu.Show()
        End If

    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = My.Computer.Screen.WorkingArea.Location
        Me.Size = My.Computer.Screen.WorkingArea.Size

    End Sub
End Class
