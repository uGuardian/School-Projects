Public Class Form1
    Public Plr1 As New Plr1Mem
    Public Plr2 As New Plr2Mem
    Dim Combat As New Battle
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Plr2.Vit = TextBox1.Text
        UpdateStats()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Plr1.Str = TextBox1.Text
        UpdateStats()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Plr2.Arm = TextBox1.Text
        UpdateStats()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        UpdateStats()
    End Sub

    Private Sub UpdateStats()
        Label1.Text = Plr2.Vit
        Label2.Text = Plr1.Str
        Label3.Text = Plr2.Arm
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Combat.Player1Attack()
        UpdateStats()
    End Sub
End Class
