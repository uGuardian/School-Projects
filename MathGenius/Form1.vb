Public Class Form1
    Dim num1 As Double
    Dim num2 As Double
    Dim answer As Double
    Dim sign As String

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click
        sign = "Add"
        lblOperator.Text = "+"
    End Sub

    Private Sub btnSubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubtract.Click
        sign = "Subtract"
        lblOperator.Text = "-"
    End Sub

    Private Sub btnMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiply.Click
        sign = "Multiply"
        lblOperator.Text = "x"
    End Sub

    Private Sub btnDevide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDevide.Click
        sign = "Devide"
        lblOperator.Text = "/"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        If Not IsNumeric(txt1.Text) Or Not IsNumeric(txt2.Text) Then
            MessageBox.Show("Put in only numbers, no blanks")
            Exit Sub
        End If

        num1 = txt1.Text
        num2 = txt2.Text

        If sign = "Add" Then
            answer = num1 + num2

        ElseIf sign = "Subtract" Then
            answer = num1 - num2

        ElseIf sign = "Multiply" Then
            answer = num1 * num2

        ElseIf sign = "Devide" Then
            answer = num1 / num2

        ElseIf sign = Nothing Then
            MessageBox.Show("Select a operator!")
            Exit Sub
        End If

        txtAnswer.Text = answer

    End Sub
End Class