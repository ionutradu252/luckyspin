Imports System.IO
Imports System.Web.UI.Design.WebControls

Module Modules
    Dim folders() = {"C:/snaipdefix",
            "C:/snaipdefix/LuckySpin",
            "C:/snaipdefix/LuckySpin/settings",
            "C:/snaipdefix/LuckySpin/profiles"}
    Public Sub check_folders()
        If Not Directory.Exists("C:/snaipdefix/LuckySpin") Then
            create_folders()
        End If
    End Sub

    Private startx As Integer
    Private starty As Integer
    Private endx As Integer
    Private endy As Integer
    Private indexx As Integer
    Private picbox As New Guna.UI2.WinForms.Guna2PictureBox
    Private timer1 As New Timer
    Private incr As Integer

    Public Sub animate_to(parentform As Form, startpos As Point, endpos As Point, picture As Image, size As Size, tick As Integer, increment As Integer)
        picbox.Visible = True
        picbox.Image = Nothing
        picbox.Image = picture
        picbox.SizeMode = PictureBoxSizeMode.Zoom
        picbox.Parent = parentform
        picbox.Location = startpos
        picbox.UseTransparentBackground = True
        picbox.BringToFront()
        picbox.Size = size

        incr = increment
        startx = startpos.X
        starty = startpos.Y
        endx = endpos.X
        endy = endpos.Y
        indexx = 0

        AddHandler timer1.Tick, AddressOf t1tick
        timer1.Interval = tick
        timer1.Start()
    End Sub

    Private Function approximate10(value As Integer)
        Return Math.Ceiling(value / 10) * 10
    End Function

    Private Sub t1tick()
        If picbox.Location.X > endx Then
            picbox.Location = New Point(picbox.Location.X - incr, picbox.Location.Y)
        ElseIf picbox.Location.x < endx Then
            picbox.Location = New Point(picbox.Location.X + incr, picbox.Location.Y)
        End If

        If picbox.Location.Y > endy Then
            picbox.Location = New Point(picbox.Location.X, picbox.Location.Y - incr)
        ElseIf picbox.Location.Y < endy Then
            picbox.Location = New Point(picbox.Location.X, picbox.Location.Y + incr)
        End If

        If approximate10(picbox.Location.Y) = approximate10(endy) And approximate10(picbox.Location.X) = approximate10(endx) Then
            timer1.Stop()
            picbox.Image = Nothing
            picbox.Visible = False
        End If
    End Sub

    Private Sub create_folders()
        For Each folder In folders
            If Not Directory.Exists(folder) Then
                My.Computer.FileSystem.CreateDirectory(folder)
            End If
        Next
    End Sub

    Public Sub load_user_items(username As String)
        Dim pth = "C:/snaipdefix/LuckySpin/profiles/" + username + "/saves/"
        My.Settings.coins = My.Computer.FileSystem.ReadAllText(pth + "coins.snp")
        My.Settings.diamonds = My.Computer.FileSystem.ReadAllText(pth + "diamonds.snp")
        My.Settings.piggies = My.Computer.FileSystem.ReadAllText(pth + "piggies.snp")
        My.Settings.spins = My.Computer.FileSystem.ReadAllText(pth + "spins.snp")
        My.Settings.citylevel = My.Computer.FileSystem.ReadAllText(pth + "citylevel.snp")
    End Sub

    Public Sub save_user_items(username As String)
        Dim pth = "C:/snaipdefix/LuckySpin/profiles/" + username + "/saves/"
        My.Computer.FileSystem.WriteAllText(pth + "coins.snp", My.Settings.coins.ToString, False)
        My.Computer.FileSystem.WriteAllText(pth + "diamonds.snp", My.Settings.diamonds.ToString, False)
        My.Computer.FileSystem.WriteAllText(pth + "piggies.snp", My.Settings.piggies.ToString, False)
        My.Computer.FileSystem.WriteAllText(pth + "spins.snp", My.Settings.spins.ToString, False)
        My.Computer.FileSystem.WriteAllText(pth + "citylevel.snp", My.Settings.citylevel.ToString, False)
    End Sub

    Public Sub generate_new_user(username As String)
        My.Computer.FileSystem.CreateDirectory("C:/snaipdefix/LuckySpin/profiles/" + username)
        My.Computer.FileSystem.CreateDirectory("C:/snaipdefix/LuckySpin/profiles/" + username + "/saves")

        Dim pth = "C:/snaipdefix/LuckySpin/profiles/" + username + "/saves/"
        My.Computer.FileSystem.WriteAllText(pth + "coins.snp", "1000", False)
        My.Computer.FileSystem.WriteAllText(pth + "diamonds.snp", "10", False)
        My.Computer.FileSystem.WriteAllText(pth + "piggies.snp", "5", False)
        My.Computer.FileSystem.WriteAllText(pth + "spins.snp", "50", False)
        My.Computer.FileSystem.WriteAllText(pth + "citylevel.snp", "0", False)

        My.Settings.coins = 1000
        My.Settings.diamonds = 10
        My.Settings.piggies = 5
        My.Settings.spins = 50
        My.Settings.citylevel = 0

    End Sub

    Public Sub newmessage(text As String)
        MessageUtility.messagevalue = text
        MessageUtility.ShowDialog()
    End Sub

    Public Sub prepare_form(form As Form, panel As Control)
        form.TopLevel = False
        form.Location = panel.Location
        form.WindowState = FormWindowState.Normal
        form.Visible = True
        panel.Controls.Add(form)
    End Sub

End Module
