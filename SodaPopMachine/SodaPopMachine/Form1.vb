Public Class Form1
    Dim SodaPrice As Double

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurchase.Click
        If radCoke.Checked = True Then
            SodaPrice = 3.0
        End If

        If radPepper.Checked = True Then
            SodaPrice = 3.5
        End If

        If radSprite.Checked = True Then
            SodaPrice = 2.0
        End If

        If radMountaindew.Checked = True Then
            SodaPrice = 5.0
        End If

        If SodaPrice = Nothing Then
            MessageBox.Show("Choose a soda")
            Exit Sub
        End If

        If SodaPrice = 3.5 Then
            txtSodaprice.Text = "$" & SodaPrice & "0"
        Else : txtSodaprice.Text = "$" & SodaPrice & ".00"
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtSodaprice.Text = Nothing
    End Sub
End Class
