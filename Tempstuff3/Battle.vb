Public Class Battle
    Private Result As Integer
    Public Sub Player1Attack()
        Result = (Form1.Plr1.Str + DieRoll.DieRoll) - (Form1.Plr2.Arm + DieRoll.DieRoll)
        MessageBox.Show(Result)
        If Not Result < 0 Then
            Form1.Plr2.Vit = Form1.Plr2.Vit - Result
        End If

        If Not Form1.Plr2.Vit > 0 Then
            Form1.Plr2.Terminate()
        End If
    End Sub
    Public Sub Player2Attack()
        Result = Form1.Plr2.Str + DieRoll.DieRoll - Form1.Plr1.Arm + DieRoll.DieRoll
        MessageBox.Show(Result)
        If Not Result < 0 Then
            Form1.Plr1.Vit = Form1.Plr1.Vit - Result
        End If
    End Sub
    Public Sub Player1RunAway()

    End Sub
    Public Sub Player2RunAway()

    End Sub
End Class
