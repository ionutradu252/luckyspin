Public Class ShopForm
    Private Sub offer1_Click(sender As Object, e As EventArgs) Handles offer1.Click
        If My.Settings.diamonds >= 10 Then
            My.Settings.diamonds -= 10
            My.Settings.coins += 1000
            Main.update_labels()
        Else
            newmessage("Not enough diamonds!")
        End If
    End Sub

    Private Sub offer2_Click(sender As Object, e As EventArgs) Handles offer2.Click
        If My.Settings.coins >= 500 Then
            My.Settings.coins -= 500
            My.Settings.spins += 10
            Main.update_labels()
        Else
            newmessage("Not enough coins!")
        End If
    End Sub
End Class