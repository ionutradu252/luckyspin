Public Class TradingMarketForm
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles offer1.Click
        If My.Settings.piggies >= 10 Then
            My.Settings.piggies -= 10
            My.Settings.spins += 5
            Main.update_labels()
        Else
            newmessage("Not enough piggies!")
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles offer2.Click
        If My.Settings.piggies >= 10 Then
            My.Settings.piggies -= 10
            My.Settings.coins += 250
            Main.update_labels()
        Else
            newmessage("Not enough piggies!")
        End If
    End Sub

    Private Sub TradingMarketForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles item2.Click

    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles item1.Click

    End Sub
End Class