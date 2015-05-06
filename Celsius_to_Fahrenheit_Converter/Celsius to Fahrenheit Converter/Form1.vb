Public Class Form1
    Dim Celsius As Integer
    Dim Fahrenheit As Integer

    Private Sub txtCelsius_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCelsius.TextChanged
        If IsNumeric(txtCelsius.Text) = True Then
            Celsius = txtCelsius.Text * 100
        Else : ErrorShow()
            Exit Sub
        End If

        Fahrenheit = Celsius * 9 / 5 + 32
        txtFahrenheit.Text = Fahrenheit / 100
    End Sub

    Private Sub txtFahrenheit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFahrenheit.TextChanged
        If IsNumeric(txtFahrenheit.Text) = True Then
            Fahrenheit = txtFahrenheit.Text * 100
        Else : ErrorShow()
            Exit Sub
        End If

        Celsius = Fahrenheit - 32
        Celsius = Celsius * 5 / 9
        txtCelsius.Text = Celsius / 100
    End Sub

    Private Sub ErrorShow()
            txtCelsius.Text = Nothing
            txtFahrenheit.Text = Nothing
    End Sub
End Class
