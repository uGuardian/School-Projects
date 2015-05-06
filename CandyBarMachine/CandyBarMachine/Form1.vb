Public Class Form1

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurchase.Click
        If radSpacebar.Checked = True Then
            txtFullprice.Text = TaxAddition(20)
        End If
        If radKitkat.Checked = True Then
            txtFullprice.Text = TaxAddition(1.5)
        End If
        If rad3musketeer.Checked = True Then
            txtFullprice.Text = TaxAddition(3)
        End If
        If radExplodium.Checked = True Then
            txtFullprice.Text = TaxAddition(1337)
        End If
    End Sub
    Function TaxAddition(ByVal Input)
        Dim Output As Double
        Dim partialoutput As Integer
        partialoutput = Input * 100 * 0.06
        Output = partialoutput / 100 + Input
        Return Output
    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtFullprice.Text = Nothing
    End Sub
End Class
