Public Class Form1
    Dim Slot1_1 As Integer
    Dim Slot1_2 As Integer
    Dim Slot1_3 As Integer
    Dim Slot2_1 As Integer
    Dim Slot2_2 As Integer
    Dim Slot2_3 As Integer
    Dim Slot3_1 As Integer
    Dim Slot3_2 As Integer
    Dim Slot3_3 As Integer
    Dim Slot1Stop As Integer
    Dim Slot2Stop As Integer
    Dim Slot3Stop As Integer
    Dim Started As Integer

    Private Sub picLever_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picLever.Click
        picLever.Image = My.Resources.lever_pulled
        If Started = 0 Then
            timStart.Start()
            Started = 1
            Audio()
        Else : timSpin.Interval = Int(Rnd() * 2000)
            timSpin.Start()
        End If
        timLever.Start()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        picLever.Image = My.Resources.lever
        Slot1_1 = 0
        Slot1_2 = 1
        Slot1_3 = 2

        Slot2_1 = 0
        Slot2_2 = 1
        Slot2_3 = 2

        Slot3_1 = 0
        Slot3_2 = 1
        Slot3_3 = 2

        Slot1Stop = 0
        Slot2Stop = 0
        Slot3Stop = 0

        pic1_1.Image = imlSlots.Images.Item(Slot1_1)
        pic1_2.Image = imlSlots.Images.Item(Slot1_2)
        pic1_3.Image = imlSlots.Images.Item(Slot1_3)

        pic2_1.Image = imlSlots.Images.Item(Slot2_1)
        pic2_2.Image = imlSlots.Images.Item(Slot2_2)
        pic2_3.Image = imlSlots.Images.Item(Slot2_3)

        pic3_1.Image = imlSlots.Images.Item(Slot3_1)
        pic3_2.Image = imlSlots.Images.Item(Slot3_2)
        pic3_3.Image = imlSlots.Images.Item(Slot3_3)

        My.Computer.Audio.Play("U:\Lottery Wheel\Lottery Wheel\Resources\Halloween_MainTheme_converted.wav")
        My.Computer.Audio.Stop()
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub timlever_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timLever.Tick
        picLever.Image = My.Resources.lever
        timLever.Stop()
    End Sub

    Private Sub timSpin_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timSpin.Tick
        If Slot1Stop = 0 Then
            Slot1Stop = 1
        ElseIf Slot2Stop = 0 Then
            Slot2Stop = 1
        ElseIf Slot3Stop = 0 Then
            Slot3Stop = 1
            Started = 0
            Audio()
            Winner()
        End If

        timSpin.Stop()
    End Sub

    Private Sub timSpinning_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timSpinning.Tick
        If Slot1Stop = 0 Then
            Slot1_1 = Slot1_1 + 1
            Slot1_2 = Slot1_2 + 1
            Slot1_3 = Slot1_3 + 1
        End If
        If Slot2Stop = 0 Then
            Slot2_1 = Slot2_1 + 1
            Slot2_2 = Slot2_2 + 1
            Slot2_3 = Slot2_3 + 1
        End If
        If Slot3Stop = 0 Then
            Slot3_1 = Slot3_1 + 1
            Slot3_2 = Slot3_2 + 1
            Slot3_3 = Slot3_3 + 1
        End If

        If Slot1_1 > 15 Then
            Slot1_1 = 0
        End If
        If Slot1_2 > 15 Then
            Slot1_2 = 0
        End If
        If Slot1_3 > 15 Then
            Slot1_3 = 0
        End If

        If Slot2_1 > 15 Then
            Slot2_1 = 0
        End If
        If Slot2_2 > 15 Then
            Slot2_2 = 0
        End If
        If Slot2_3 > 15 Then
            Slot2_3 = 0
        End If

        If Slot3_1 > 15 Then
            Slot3_1 = 0
        End If
        If Slot3_2 > 15 Then
            Slot3_2 = 0
        End If
        If Slot3_3 > 15 Then
            Slot3_3 = 0
        End If

        pic1_1.Image = imlSlots.Images.Item(Slot1_1)
        pic1_2.Image = imlSlots.Images.Item(Slot1_2)
        pic1_3.Image = imlSlots.Images.Item(Slot1_3)

        pic2_1.Image = imlSlots.Images.Item(Slot2_1)
        pic2_2.Image = imlSlots.Images.Item(Slot2_2)
        pic2_3.Image = imlSlots.Images.Item(Slot2_3)

        pic3_1.Image = imlSlots.Images.Item(Slot3_1)
        pic3_2.Image = imlSlots.Images.Item(Slot3_2)
        pic3_3.Image = imlSlots.Images.Item(Slot3_3)
    End Sub

    Private Sub timStart_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timStart.Tick
        timSpinning.Start()
        If Slot1Stop = 1 Then
            Slot1Stop = 0
        ElseIf Slot2Stop = 1 Then
            Slot2Stop = 0
        ElseIf Slot3Stop = 1 Then
            Slot3Stop = 0
        Else : timStart.Stop()
        End If
    End Sub

    Private Sub Audio()
        If Started = 1 Then
            My.Computer.Audio.Play("U:\Lottery Wheel\Lottery Wheel\Resources\Halloween_MainTheme.wav")
        Else : My.Computer.Audio.Stop()
        End If
    End Sub

    Private Sub Winner()
        pic1_1.Image = imlSlots.Images.Item(Slot1_1)
        pic1_2.Image = imlSlots.Images.Item(Slot1_2)
        pic1_3.Image = imlSlots.Images.Item(Slot1_3)

        pic2_1.Image = imlSlots.Images.Item(Slot2_1)
        pic2_2.Image = imlSlots.Images.Item(Slot2_2)
        pic2_3.Image = imlSlots.Images.Item(Slot2_3)

        pic3_1.Image = imlSlots.Images.Item(Slot3_1)
        pic3_2.Image = imlSlots.Images.Item(Slot3_2)
        pic3_3.Image = imlSlots.Images.Item(Slot3_3)

        If Slot1_2 = 15 And Slot2_2 = 15 And Slot3_2 = 15 Then
            My.Computer.Audio.Play("U:\Lottery Wheel\Lottery Wheel\Resources\explosion-01.wav")
            MessageBox.Show("BOOM! HEADSHOT!")
            My.Computer.Audio.Stop()
        ElseIf Slot1_2 = Slot2_2 And Slot2_2 = Slot3_2 And Slot1_2 = Slot3_2 Then
            My.Computer.Audio.Play("U:\Lottery Wheel\Lottery Wheel\Resources\JackPotWinMusic.wav")
            MessageBox.Show("You win!")
            My.Computer.Audio.Stop()
        End If
    End Sub
End Class
