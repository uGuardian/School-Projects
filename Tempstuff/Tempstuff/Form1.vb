Public Class Form1

    Private Sub btnCall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCall.Click
        Dim CallChar As New Char2Mem
        lblMonster.Text = CallChar.SendForChar(txtCall.Text)
    End Sub
End Class