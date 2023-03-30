Public Class Login

    Public username = "undefined"

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If String.IsNullOrEmpty(usernamebox.Text) = False Then
            username = usernamebox.Text
            Main.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Guna2TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles usernamebox.KeyDown
        If e.KeyValue = Keys.Enter Then
            loginbtn.PerformClick()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        check_folders()
    End Sub

    Private Sub Guna2RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles remember_radio.CheckedChanged
        If remember_radio.Checked = True Then
            My.Settings.remember = True
            My.Settings.remembername = usernamebox.Text
        Else
            My.Settings.remember = False
        End If
    End Sub

    Private Sub Login_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If My.Settings.remember = True Then
            usernamebox.Text = My.Settings.remembername
            loginbtn.PerformClick()
        End If
    End Sub
End Class
