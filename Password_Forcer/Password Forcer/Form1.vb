Public Class Form1
    Dim timStartValue As Integer
    Dim Started As Integer

    Dim Char1 As Integer
    Dim Char2 As Integer
    Dim Char3 As Integer
    Dim Char4 As Integer
    Dim Char5 As Integer
    Dim Char6 As Integer
    Dim Char7 As Integer
    Dim Char8 As Integer
    Dim Char9 As Integer
    Dim Char10 As Integer
    Dim Char11 As Integer
    Dim Char12 As Integer
    Dim Char13 As Integer
    Dim Char14 As Integer
    Dim Char15 As Integer

    Private Sub btnStartStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartStop.Click
        If Started = 0 Then
            timStart.Start()
            Started = 1
            btnStartStop.Text = "Stop Hacking"
        Else
            timStart.Stop()
            timStartValue = 5
            lblStarttimer.Text = timStartValue
            Started = 0
            btnStartStop.Text = "Start Hacking"
            timRunning.Stop()
        End If
    End Sub

    Private Sub timStart_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timStart.Tick
        timStartValue = timStartValue - 1
        lblStarttimer.Text = timStartValue

        If timStartValue = 0 Then
            timRunning.Start()
            timStart.Stop()
        End If
    End Sub

    Function Character(ByVal CharInput As Integer)
        Dim CharOutput As String

        If CharInput = 0 Then
            CharOutput = 0
        End If
        If CharInput = 1 Then
            CharOutput = 1
        End If
        If CharInput = 2 Then
            CharOutput = 2
        End If
        If CharInput = 3 Then
            CharOutput = 3
        End If
        If CharInput = 4 Then
            CharOutput = 4
        End If
        If CharInput = 4 Then
            CharOutput = 4
        End If
        If CharInput = 5 Then
            CharOutput = 5
        End If
        If CharInput = 6 Then
            CharOutput = 6
        End If
        If CharInput = 7 Then
            CharOutput = 7
        End If
        If CharInput = 8 Then
            CharOutput = 8
        End If
        If CharInput = 9 Then
            CharOutput = 9
        End If
        If CharInput = 10 Then
            CharOutput = "a"
        End If
        If CharInput = 11 Then
            CharOutput = "A"
        End If
        If CharInput = 12 Then
            CharOutput = "b"
        End If
        If CharInput = 13 Then
            CharOutput = "B"
        End If
        If CharInput = 14 Then
            CharOutput = "c"
        End If
        If CharInput = 15 Then
            CharOutput = "C"
        End If
        If CharInput = 16 Then
            CharOutput = "d"
        End If
        If CharInput = 17 Then
            CharOutput = "D"
        End If
        If CharInput = 18 Then
            CharOutput = "e"
        End If
        If CharInput = 19 Then
            CharOutput = "E"
        End If
        If CharInput = 20 Then
            CharOutput = "f"
        End If
        If CharInput = 21 Then
            CharOutput = "F"
        End If
        If CharInput = 22 Then
            CharOutput = "g"
        End If
        If CharInput = 23 Then
            CharOutput = "G"
        End If
        If CharInput = 24 Then
            CharOutput = "h"
        End If
        If CharInput = 25 Then
            CharOutput = "H"
        End If
        If CharInput = 26 Then
            CharOutput = "i"
        End If
        If CharInput = 27 Then
            CharOutput = "I"
        End If
        If CharInput = 28 Then
            CharOutput = "j"
        End If
        If CharInput = 29 Then
            CharOutput = "J"
        End If
        If CharInput = 30 Then
            CharOutput = "k"
        End If
        If CharInput = 31 Then
            CharOutput = "K"
        End If
        If CharInput = 32 Then
            CharOutput = "l"
        End If
        If CharInput = 33 Then
            CharOutput = "L"
        End If
        If CharInput = 34 Then
            CharOutput = "m"
        End If
        If CharInput = 35 Then
            CharOutput = "M"
        End If
        If CharInput = 36 Then
            CharOutput = "n"
        End If
        If CharInput = 37 Then
            CharOutput = "N"
        End If
        If CharInput = 38 Then
            CharOutput = "o"
        End If
        If CharInput = 39 Then
            CharOutput = "O"
        End If
        If CharInput = 40 Then
            CharOutput = "p"
        End If
        If CharInput = 41 Then
            CharOutput = "P"
        End If
        If CharInput = 42 Then
            CharOutput = "q"
        End If
        If CharInput = 43 Then
            CharOutput = "Q"
        End If
        If CharInput = 44 Then
            CharOutput = "r"
        End If
        If CharInput = 45 Then
            CharOutput = "R"
        End If
        If CharInput = 46 Then
            CharOutput = "s"
        End If
        If CharInput = 47 Then
            CharOutput = "S"
        End If
        If CharInput = 48 Then
            CharOutput = "t"
        End If
        If CharInput = 49 Then
            CharOutput = "T"
        End If
        If CharInput = 50 Then
            CharOutput = "u"
        End If
        If CharInput = 51 Then
            CharOutput = "U"
        End If
        If CharInput = 52 Then
            CharOutput = "v"
        End If
        If CharInput = 53 Then
            CharOutput = "V"
        End If
        If CharInput = 54 Then
            CharOutput = "w"
        End If
        If CharInput = 55 Then
            CharOutput = "W"
        End If
        If CharInput = 56 Then
            CharOutput = "x"
        End If
        If CharInput = 57 Then
            CharOutput = "X"
        End If
        If CharInput = 58 Then
            CharOutput = "y"
        End If
        If CharInput = 59 Then
            CharOutput = "Y"
        End If
        If CharInput = 60 Then
            CharOutput = "z"
        End If
        If CharInput = 61 Then
            CharOutput = "Z"
        End If
        If CharInput = 62 Then
            CharOutput = "!"
        End If
        If CharInput = 63 Then
            CharOutput = "@"
        End If
        If CharInput = 64 Then
            CharOutput = "#"
        End If
        If CharInput = 65 Then
            CharOutput = "$"
        End If
        If CharInput = 66 Then
            CharOutput = "%"
        End If
        If CharInput = 67 Then
            CharOutput = "^"
        End If
        If CharInput = 68 Then
            CharOutput = "&"
        End If
        If CharInput = 69 Then
            CharOutput = "*"
        End If
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timStartValue = 5
    End Sub

    Private Sub timRunning_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timRunning.Tick
        Char1 = Char1 + 1
        If Char1 > 69 Then
            Char2 = Char2 + 1
        End If
        If Char2 > 69 Then
            Char3 = Char3 + 1
        End If
        If Char3 > 69 Then
            Char4 = Char4 + 1
        End If
        If Char4 > 69 Then
            Char5 = Char5 + 1
        End If
        If Char5 > 69 Then
            Char6 = Char6 + 1
        End If
        If Char6 > 69 Then
            Char7 = Char7 + 1
        End If
        If Char7 > 69 Then
            Char8 = Char8 + 1
        End If
        If Char8 > 69 Then
            Char9 = Char9 + 1
        End If
        If Char9 > 69 Then
            Char10 = Char10 + 1
        End If
        If Char10 > 69 Then
            Char11 = Char11 + 1
        End If
        If Char11 > 69 Then
            Char12 = Char12 + 1
        End If
        If Char12 > 69 Then
            Char13 = Char13 + 1
        End If
        If Char13 > 69 Then
            Char14 = Char14 + 1
        End If
        If Char14 > 69 Then
            Char15 = Char15 + 1
        End If

        SendKeys.Send(Character(Char1))
        SendKeys.Send(Character(Char2))
        SendKeys.Send(Character(Char3))
        SendKeys.Send(Character(Char4))
        SendKeys.Send(Character(Char5))
        SendKeys.Send(Character(Char6))
        SendKeys.Send(Character(Char7))
        SendKeys.Send(Character(Char8))
        SendKeys.Send(Character(Char9))
        SendKeys.Send(Character(Char10))
        SendKeys.Send(Character(Char11))
        SendKeys.Send(Character(Char12))
        SendKeys.Send(Character(Char13))
        SendKeys.Send(Character(Char14))
        SendKeys.Send(Character(Char15))
    End Sub
End Class
