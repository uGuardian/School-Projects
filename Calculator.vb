Public Class Form1

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub chkPower_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPower.CheckedChanged
        If chkPower.Checked - False Then
            txtNum1.Enabled = True
            txtNum2.Enabled = True
            btnCalculate.Enabled = True
        Else
            txtNum1.Enabled = False
            txtNum2.Enabled = False
            btnCalculate.Enabled = False
        End If
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim Num1 As Integer
        Dim Num2 As Integer
        Dim Num_Answer As Integer

        If Not IsNumeric(txtNum1.Text) Or Not IsNumeric(txtNum2.Text) Then
            MessageBox.Show("OY! Enter only numbers")
        Else
            Num1 = txtNum1.Text
            Num2 = txtNum2.Text
            Num_Answer = Num1 + Num2

            txtNum_answer.Text = Num_Answer
        End If
    End Sub
End Class
