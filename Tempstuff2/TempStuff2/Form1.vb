Public Class Form1

    Private Sub btnCall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCall.Click
        Dim CallChar As New Char2Mem
        CallChar.SendForChar(txtCall.Text)
        lblMonster.Text = CallChar.Char2
        txtStr.Text = CallChar.Str
        txtAgl.Text = CallChar.Agl
        txtArm.Text = CallChar.Arm
        txtSpd.Text = CallChar.Spd
        txtVit.Text = CallChar.Vit
    End Sub
End Class
