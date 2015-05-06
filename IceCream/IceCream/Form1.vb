Public Class Form1
    Dim Flavor As String
    Dim Topping As String

    Private Sub lblTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnFlavor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlavor.Click
        If cmbFlavor.SelectedItem = Nothing Then
            MessageBox.Show("Pick a flavor!")
        Else
            Flavor = cmbFlavor.SelectedItem
        End If

    End Sub

    Private Sub btnToppings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToppings.Click
        If radCaramel.Checked = True Then
            Topping = "Caramel"
        ElseIf radIchigo.Checked = True Then
            Topping = "Strawberry"
        ElseIf radChocolate.Checked = True Then
            Topping = "Chocolate"
        Else : MessageBox.Show("You need a topping to click this button")
        End If
    End Sub

    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click
        If Flavor = Nothing Then

            If Topping = Nothing Then
                Topping = "no topping"
            End If

            lstOrders.Items.Add(Flavor & " with " & Topping)
    End Sub
End Class
