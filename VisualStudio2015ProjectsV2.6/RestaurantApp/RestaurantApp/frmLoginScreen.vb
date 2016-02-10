Public Class frmLoginScreen


    'Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Me.StartPosition = FormStartPosition.Manual
    '    Me.Location = My.Computer.Screen.WorkingArea.Location
    '    Me.Size = My.Computer.Screen.WorkingArea.Size

    'End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "Admin" And txtPassword.Text = "Admin" Then
            frmMainMenu.Show()
            frmMainMenu.btnAdjustPrice.Visible = True
            frmMainMenu.btnRemoveItems.Visible = True
        ElseIf txtUsername.Text = "Burgers" And txtPassword.Text = "Burgers" Then
            frmMainMenu.Show()
        Else
            MessageBox.Show("You've entered icorrect credentials")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Clear()
        txtPassword.Clear()

    End Sub
End Class