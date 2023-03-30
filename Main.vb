Imports System.IO

'made by snaipdefix#1288 on discord

Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GunaTabControl.SelectedIndex = -1
        load_user_data()
    End Sub

    Private Sub load_user_data()
        username_label.Text = Login.username
        If check_and_generate_folder(Login.username) = True Then
            load_user_items(Login.username)
        Else
            generate_new_user(Login.username)
        End If
        update_labels()
    End Sub

    Public Sub update_labels()
        coin_label.Text = My.Settings.coins
        diamond_label.Text = My.Settings.diamonds
        piggies_label.Text = My.Settings.piggies
        spins_label.Text = My.Settings.spins
        city_label.Text = My.Settings.citylevel
        save_user_items(Login.username)
    End Sub



    Private Function check_and_generate_folder(username As String)
        Dim dirpath = "C:/snaipdefix/LuckySpin/profiles/" + username
        If Not Directory.Exists(dirpath) Then
            My.Computer.FileSystem.CreateDirectory(dirpath)
            Return False
        Else Return True
        End If
    End Function

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub

    Private Sub GunaTabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GunaTabControl.SelectedIndexChanged
        If GunaTabControl.SelectedIndex = 0 Then
            prepare_form(SpinForm, SpinPage)
        ElseIf GunaTabControl.SelectedIndex = 1 Then
            prepare_form(ShopForm, ShopPage)
        ElseIf GunaTabControl.SelectedIndex = 2 Then
            prepare_form(TradingMarketForm, TradingPage)
        End If
    End Sub

    Private Sub Main_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
            If GunaTabControl.SelectedIndex = 0 Then
                SpinForm.spinbtn.PerformClick()
            End If
        End If
    End Sub
End Class