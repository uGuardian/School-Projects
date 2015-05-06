Public Class Form1
    Dim Tries As Single

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic1.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pic1.InitialImage = My.Resources.depositphotos_1696563_Closed_safe
        Tries = 3
        lblTries.Text = Tries
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        If nud1.Value = 3 And nud2.Value = 9 And nud3.Value = 7 And nud4.Value = 1 Then
            pic1.Image = My.Resources.open_safe
        Else : pic1.Image = My.Resources.depositphotos_1696563_Closed_safeAHAHAHA
            tim1.Start()
            Tries = Tries - 1
            lblTries.Text = Tries
        End If

        If Tries = 0 Then
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tim1.Tick
        If tim1.Interval = 2 Then
            pic1.Image = My.Resources.depositphotos_1696563_Closed_safe
            tim1.Stop()
        End If
    End Sub
End Class
