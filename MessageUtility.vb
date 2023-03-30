Public Class MessageUtility

    Public messagevalue
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Me.Close()
    End Sub

    Private Sub MessageUtility_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        messagebox.Text = messagevalue
    End Sub
End Class