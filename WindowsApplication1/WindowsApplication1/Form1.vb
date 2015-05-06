Public Class Form1
    Function RandGen(ByVal Question As Single)
        Try
            Dim Answer As Double
            Answer = Rnd() * Question
            Return Answer
        Catch Exception As OverflowException
            lblAnswer.Text = "Number is too large!"
            Exit Function
        End Try
    End Function

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        If txtQuestion.Text = Nothing Then
            lblAnswer.Text = "Enter a Number!"
        Else
            lblAnswer.Text = RandGen(txtQuestion.Text)
        End If
    End Sub
End Class
