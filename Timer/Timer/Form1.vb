Public Class Form1
    Dim Seconds As Integer
    Dim Minutes As Integer
    Dim Hours As Integer

    Dim Started As Integer

    Private Sub timStopwatch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timStopwatch.Tick
        Seconds = Seconds + 1

        If Seconds > 59 Then
            Seconds = 0
            Minutes = Minutes + 1
        End If

        If Seconds < 10 Then
            lblSecond.Text = "0" & Seconds
        Else : lblSecond.Text = Seconds
        End If

        If Minutes > 59 Then
            Minutes = 0
            Hours = Hours + 1
        End If

        If Minutes < 10 Then
            lblMinute.Text = "0" & Minutes
        Else : lblMinute.Text = Minutes
        End If

        If Hours > 11 Then
            timStopwatch.Stop()
            MessageBox.Show("You ran it for that long?")
            Seconds = 0
            Minutes = 0
            Hours = 0
            Exit Sub
        End If

        If Hours < 10 Then
            lblHour.Text = "0" & Hours
        Else : lblHour.Text = Hours
        End If
    End Sub

    Private Sub btnStopwatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopwatch.Click
        If Started = 0 Then
            timStopwatch.Start()
            Started = 2
            btnStopwatch.Text = "Stop"
            Seconds = 0
            Minutes = 0
            Hours = 0
            btnCountdown.Enabled = False
            btnResetQuit.Text = "Reset"
            nudSecond.Enabled = False
            nudMinute.Enabled = False
            nudHour.Enabled = False
        ElseIf Started = 1 Then
            timStopwatch.Start()
            Started = 2
            btnStopwatch.Text = "Stop"
        ElseIf Started = 2 Then
            timStopwatch.Stop()
            Started = 1
            btnStopwatch.Text = "Start"
        End If
    End Sub

    Private Sub btnResetQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetQuit.Click
        ResetQuit()
    End Sub

    Private Sub btnCountdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCountdown.Click
        If Started = 0 Then
            timCountdown.Start()
            Started = 2
            btnCountdown.Text = "Stop"
            Seconds = nudSecond.Value
            Minutes = nudMinute.Value
            Hours = nudHour.Value
            btnStopwatch.Enabled = False
            btnResetQuit.Text = "Reset"
            nudSecond.Enabled = False
            nudMinute.Enabled = False
            nudHour.Enabled = False
            Seconds = Seconds + 1


        ElseIf Started = 1 Then
            timCountdown.Start()
            Started = 2
            btnCountdown.Text = "Stop"
        ElseIf Started = 2 Then
            timCountdown.Stop()
            Started = 1
            btnCountdown.Text = "Start"
        End If
    End Sub

    Private Sub timCountdown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timCountdown.Tick
        Seconds = Seconds - 1

        If Seconds < 0 Then
            Seconds = 59
            Minutes = Minutes - 1
        End If

        If Seconds < 10 Then
            lblSecond.Text = "0" & Seconds
        Else : lblSecond.Text = Seconds
        End If

        If Minutes < 0 Then
            Minutes = 59
            Hours = Hours - 1
        End If

        If Minutes < 10 Then
            lblMinute.Text = "0" & Minutes
        Else : lblMinute.Text = Minutes
        End If

        If Hours = 0 And Minutes = 0 And Seconds = 0 Then
            timCountdown.Stop()
            MessageBox.Show("Time's up!")
            ResetQuit()
            Exit Sub
        End If

        If Hours < 10 Then
            lblHour.Text = "0" & Hours
        Else : lblHour.Text = Hours
        End If
    End Sub

    Private Sub ResetQuit()
        If Started = 0 Then
            Me.Close()
        End If

        timStopwatch.Stop()
        timCountdown.Stop()

        Seconds = 0
        Minutes = 0
        Hours = 0

        lblSecond.Text = "0" & Seconds
        lblMinute.Text = "0" & Minutes
        lblHour.Text = "0" & Hours

        btnCountdown.Enabled = True
        btnStopwatch.Enabled = True
        nudSecond.Enabled = True
        nudMinute.Enabled = True
        nudHour.Enabled = True

        Started = 0

        btnCountdown.Text = "Countdown"
        btnStopwatch.Text = "Stopwatch"
        btnResetQuit.Text = "Quit"
    End Sub
End Class
