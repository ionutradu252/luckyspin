Imports System.Threading

Public Class SpinForm

    Private arrImages(9) As Image
    Dim spins(2) As Integer

    Private Function GetRandom(min As Integer, max As Integer)
        Static Generator As Random = New Random()
        Return Generator.Next(min, max)
    End Function

    Private Sub SpinForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        arrImages(0) = My.Resources.fruit3
        arrImages(1) = My.Resources.fruit1
        arrImages(2) = My.Resources.fruit4
        arrImages(3) = My.Resources.fruit2
        arrImages(4) = My.Resources.coins
        arrImages(5) = My.Resources.luckyspin
        arrImages(6) = My.Resources.pigs
        arrImages(7) = My.Resources.diamond
        arrImages(8) = My.Resources.city
        arrImages(9) = My.Resources._7slot
    End Sub

    Private Sub spinbtn_Click(sender As Object, e As EventArgs) Handles spinbtn.Click
        If My.Settings.spins = 0 Then
            'no spins
            newmessage("No spins left.")
            Return
        End If
        My.Settings.spins -= 1
        spinbtn.Enabled = False
        spinx10btn.Enabled = False
        payout_label.Visible = False
        Dim pay As Integer = 0
        Dim payed As Boolean = False

        'audio
        My.Computer.Audio.Play(My.Resources.slot_spin, AudioPlayMode.BackgroundLoop)
        timerindex = 0
        SpinTimer.Start()

        For i As Integer = 0 To 2
            Dim rolled = GetRandom(1, 1000)
            If rolled < 10 Then
                spins(i) = 9
            ElseIf rolled < 50 And rolled > 10 Then
                spins(i) = 8
            ElseIf rolled < 100 And rolled > 50 Then
                spins(i) = 7
            ElseIf rolled < 200 And rolled > 100 Then
                spins(i) = 6
            ElseIf rolled < 350 And rolled > 200 Then
                spins(i) = 5
            ElseIf rolled < 500 And rolled > 350 Then
                spins(i) = 4
            ElseIf rolled < 650 And rolled > 500 Then
                spins(i) = 3
            ElseIf rolled < 750 And rolled > 650 Then
                spins(i) = 2
            ElseIf rolled < 850 And rolled > 750 Then
                spins(i) = 1
            ElseIf rolled < 1000 And rolled > 850 Then
                spins(i) = 0
            End If
        Next

        'all same
        If spins(0) = spins(1) And spins(1) = spins(2) Then
            If spins(0) = 0 Then
                pay = 50 * 3
                payout_label.Text = "Three pears : "
            ElseIf spins(0) = 1 Then
                pay = 60 * 3
                payout_label.Text = "Three oranges : "
            ElseIf spins(0) = 2 Then
                pay = 65 * 3
                payout_label.Text = "Nine cherries : "
            ElseIf spins(0) = 3 Then
                pay = 70 * 3
                payout_label.Text = "Three grapes : "
            ElseIf spins(0) = 4 Then
                pay = 100 * 3
                payout_label.Text = "Three coins : "
            ElseIf spins(0) = 5 Then
                'pay spins
                My.Settings.spins += 30
                payout_label.Text = "Three spins : +30"
            ElseIf spins(0) = 6 Then
                'pay piggies
                My.Settings.piggies += 10
                payout_label.Text = "Three piggies : +10"
            ElseIf spins(0) = 7 Then
                'pay diamonds
                My.Settings.diamonds += 6
                payout_label.Text = "Three diamonds : +6"
            ElseIf spins(0) = 8 Then
                'level up city
                My.Settings.citylevel += 1
                payout_label.Text = "Three cities : +1"
            ElseIf spins(0) = 9 Then
                pay = 5000 * 3
                payout_label.Text = "JACKPOT : "
            End If
            payed = True
        End If


        'first two same
        If spins(0) = spins(1) And payed = False Then
            If spins(0) = 0 Then
                pay = 50
                payout_label.Text = "Two pears : "
            ElseIf spins(0) = 1 Then
                pay = 60
                payout_label.Text = "Two oranges : "
            ElseIf spins(0) = 2 Then
                pay = 65
                payout_label.Text = "Six cherries : "
            ElseIf spins(0) = 3 Then
                pay = 70
                payout_label.Text = "Two grapes : "
            ElseIf spins(0) = 4 Then
                pay = 100
                payout_label.Text = "Two coins : "
            ElseIf spins(0) = 5 Then
                'pay spins
                My.Settings.spins += 10
                payout_label.Text = "Two spins : +10"
            ElseIf spins(0) = 6 Then
                'pay piggies
                My.Settings.piggies += 4
                payout_label.Text = "Two piggies : +4"
            ElseIf spins(0) = 7 Then
                'pay diamonds
                My.Settings.diamonds += 1
                payout_label.Text = "Two diamonds : +1"
            ElseIf spins(0) = 8 Then
                'level up city
                payout_label.Text = "Two cities"
            ElseIf spins(0) = 9 Then
                pay = 5000
                payout_label.Text = "Semi JACKPOT : "
            End If
            payed = True
        End If

        'last two same
        If spins(1) = spins(2) And payed = False Then
            If spins(1) = 0 Then
                pay = 50
                payout_label.Text = "Two pears : "
            ElseIf spins(1) = 1 Then
                pay = 60
                payout_label.Text = "Two oranges : "
            ElseIf spins(1) = 2 Then
                pay = 65
                payout_label.Text = "Six cherries : "
            ElseIf spins(1) = 3 Then
                pay = 70
                payout_label.Text = "Two grapes : "
            ElseIf spins(1) = 4 Then
                pay = 100
                payout_label.Text = "Two coins : "
            ElseIf spins(1) = 5 Then
                'pay spins
                My.Settings.spins += 10
                payout_label.Text = "Two spins : +10"
            ElseIf spins(1) = 6 Then
                'pay piggies
                My.Settings.piggies += 4
                payout_label.Text = "Two piggies: +4"
            ElseIf spins(1) = 7 Then
                'pay diamonds
                My.Settings.diamonds += 1
                payout_label.Text = "Two diamonds : +1"
            ElseIf spins(1) = 8 Then
                'level up city
                payout_label.Text = "Two cities"
            ElseIf spins(1) = 9 Then
                pay = 5000
            End If
            payed = True
        End If


        'fruit frenzy
        If spins(0) = 0 And spins(1) = 1 And spins(2) = 2 Then
            pay = 250
            payout_label.Text = "Fruit Frenzy : "
            payed = True
        End If

        If payed = False Then
            payout_label.Text = "0$"
        ElseIf pay <> 0 Then
            payout_label.Text += pay.ToString + "$."
            My.Settings.coins += pay
        Else
            payout_label.Text += "."
        End If
    End Sub



    Private timerindex

    Private Sub SpinTimer_Tick(sender As Object, e As EventArgs) Handles SpinTimer.Tick

        If timerindex < 2 Then
            slot1.Image = arrImages(GetRandom(0, 9))
            slot2.Image = arrImages(GetRandom(0, 9))
            slot3.Image = arrImages(GetRandom(0, 9))
        ElseIf timerindex < 2.5 And timerindex > 2 Then
            slot2.Image = arrImages(GetRandom(0, 9))
            slot3.Image = arrImages(GetRandom(0, 9))
        ElseIf timerindex < 3 And timerindex > 2.5 Then
            slot3.Image = arrImages(GetRandom(0, 9))
        End If


        If timerindex = 2 Then
            'slot1
            My.Computer.Audio.Play(My.Resources.slot_select, AudioPlayMode.Background)
            'slot1.BeginInvoke(Sub() slot1.Image = arrImages(spins(0)))
            slot1.Image = arrImages(spins(0))
        End If

        If timerindex = 2.5 Then
            'slot2
            My.Computer.Audio.Play(My.Resources.slot_select, AudioPlayMode.Background)
            'slot2.BeginInvoke(Sub() slot2.Image = arrImages(spins(1)))
            slot2.Image = arrImages(spins(1))
        End If

        If timerindex = 3 Then
            'slot3
            My.Computer.Audio.Play(My.Resources.slot_select, AudioPlayMode.Background)
            'slot3.BeginInvoke(Sub() slot3.Image = arrImages(spins(2)))
            slot3.Image = arrImages(spins(2))

            spinbtn.Enabled = True
            spinx10btn.Enabled = True
            payout_label.Visible = True
            Main.update_labels()

            SpinTimer.Stop()
        End If

        timerindex += 0.125
    End Sub

    Private Sub spinx10btn_Click(sender As Object, e As EventArgs) Handles spinx10btn.Click
        Dim totalpay As Integer = 0
        If My.Settings.spins < 10 Then
            newmessage("Not enough spins.")
            Return
        End If
        For y = 0 To 9
            My.Settings.spins -= 1
            spinbtn.Enabled = False
            spinx10btn.Enabled = False
            payout_label.Visible = False
            Dim pay As Integer = 0
            Dim payed As Boolean = False

            'audio
            My.Computer.Audio.Play(My.Resources.slot_spin, AudioPlayMode.BackgroundLoop)

            For i As Integer = 0 To 2
                Dim rolled = GetRandom(1, 1000)
                If rolled < 10 Then
                    spins(i) = 9
                ElseIf rolled < 50 And rolled > 10 Then
                    spins(i) = 8
                ElseIf rolled < 100 And rolled > 50 Then
                    spins(i) = 7
                ElseIf rolled < 200 And rolled > 100 Then
                    spins(i) = 6
                ElseIf rolled < 350 And rolled > 200 Then
                    spins(i) = 5
                ElseIf rolled < 500 And rolled > 350 Then
                    spins(i) = 4
                ElseIf rolled < 650 And rolled > 500 Then
                    spins(i) = 3
                ElseIf rolled < 750 And rolled > 650 Then
                    spins(i) = 2
                ElseIf rolled < 850 And rolled > 750 Then
                    spins(i) = 1
                ElseIf rolled < 1000 And rolled > 850 Then
                    spins(i) = 0
                End If
            Next

            'all same
            If spins(0) = spins(1) And spins(1) = spins(2) Then
                If spins(0) = 0 Then
                    pay = 50 * 3
                    payout_label.Text = "Three pears : "
                ElseIf spins(0) = 1 Then
                    pay = 60 * 3
                    payout_label.Text = "Three oranges : "
                ElseIf spins(0) = 2 Then
                    pay = 65 * 3
                    payout_label.Text = "Nine cherries : "
                ElseIf spins(0) = 3 Then
                    pay = 70 * 3
                    payout_label.Text = "Three grapes : "
                ElseIf spins(0) = 4 Then
                    pay = 100 * 3
                    payout_label.Text = "Three coins : "
                ElseIf spins(0) = 5 Then
                    'pay spins
                    My.Settings.spins += 30
                    payout_label.Text = "Three spins : "
                ElseIf spins(0) = 6 Then
                    'pay piggies
                    My.Settings.piggies += 10
                    payout_label.Text = "Three piggies : "
                ElseIf spins(0) = 7 Then
                    'pay diamonds
                    My.Settings.diamonds += 6
                    payout_label.Text = "Three diamonds : "
                ElseIf spins(0) = 8 Then
                    'level up city
                    My.Settings.citylevel += 1
                    payout_label.Text = "Three cities : "
                ElseIf spins(0) = 9 Then
                    pay = 5000 * 3
                    payout_label.Text = "JACKPOT : "
                End If
                payed = True
            End If


            'first two same
            If spins(0) = spins(1) And payed = False Then
                If spins(0) = 0 Then
                    pay = 50
                    payout_label.Text = "Two pears : "
                ElseIf spins(0) = 1 Then
                    pay = 60
                    payout_label.Text = "Two oranges : "
                ElseIf spins(0) = 2 Then
                    pay = 65
                    payout_label.Text = "Six cherries : "
                ElseIf spins(0) = 3 Then
                    pay = 70
                    payout_label.Text = "Two grapes : "
                ElseIf spins(0) = 4 Then
                    pay = 100
                    payout_label.Text = "Two coins : "
                ElseIf spins(0) = 5 Then
                    'pay spins
                    My.Settings.spins += 10
                    payout_label.Text = "Two spins : "
                ElseIf spins(0) = 6 Then
                    'pay piggies
                    My.Settings.piggies += 4
                    payout_label.Text = "Two piggies : "
                ElseIf spins(0) = 7 Then
                    'pay diamonds
                    My.Settings.diamonds += 1
                    payout_label.Text = "Two diamonds : "
                ElseIf spins(0) = 8 Then
                    'level up city
                    payout_label.Text = "Two cities : "
                ElseIf spins(0) = 9 Then
                    pay = 5000
                    payout_label.Text = "Semi JACKPOT : "
                End If
                payed = True
            End If

            'last two same
            If spins(1) = spins(2) And payed = False Then
                If spins(1) = 0 Then
                    pay = 50
                    payout_label.Text = "Two pears : "
                ElseIf spins(1) = 1 Then
                    pay = 60
                    payout_label.Text = "Two oranges : "
                ElseIf spins(1) = 2 Then
                    pay = 65
                    payout_label.Text = "Six cherries : "
                ElseIf spins(1) = 3 Then
                    pay = 70
                    payout_label.Text = "Two grapes : "
                ElseIf spins(1) = 4 Then
                    pay = 100
                    payout_label.Text = "Two coins : "
                ElseIf spins(1) = 5 Then
                    'pay spins
                    My.Settings.spins += 10
                    payout_label.Text = "Two spins"
                ElseIf spins(1) = 6 Then
                    'pay piggies
                    My.Settings.piggies += 4
                    payout_label.Text = "Two piggies"
                ElseIf spins(1) = 7 Then
                    'pay diamonds
                    My.Settings.diamonds += 1
                    payout_label.Text = "Two diamonds"
                ElseIf spins(1) = 8 Then
                    'level up city
                    payout_label.Text = "Two cities"
                ElseIf spins(1) = 9 Then
                    pay = 5000
                End If
                payed = True
            End If


            'fruit frenzy
            If spins(0) = 0 And spins(1) = 1 And spins(2) = 2 Then
                pay = 250
                payout_label.Text = "Fruit Frenzy : "
                payed = True
            End If

            If payed = False Then
                payout_label.Text = "0$"
            ElseIf pay <> 0 Then
                payout_label.Text += pay.ToString + "$."
                My.Settings.coins += pay
                totalpay += pay
            Else
                payout_label.Text += "."
            End If
        Next
        My.Computer.Audio.Play(My.Resources.slot_select, AudioPlayMode.Background)
        payout_label.Text = "Total win : " + totalpay.ToString + "$."
        spinbtn.Enabled = True
        spinx10btn.Enabled = True
        payout_label.Visible = True
        Main.update_labels()

        slot1.Image = arrImages(spins(0))
        slot2.Image = arrImages(spins(1))
        slot3.Image = arrImages(spins(2))
    End Sub

    Private Sub SpinForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
            spinbtn.PerformClick()
        End If
    End Sub
End Class