Public Class Form1
    Dim CurrentImage1 As Integer
    Dim CurrentImage2 As Integer
    Dim CurrentImage3 As Integer

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CurrentImage1 = 0
        CurrentImage2 = 1
        CurrentImage3 = 2

        pic1.Image = iml.Images.Item(CurrentImage1)
        pic2.Image = iml.Images.Item(CurrentImage2)
        pic3.Image = iml.Images.Item(CurrentImage3)
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        CurrentImage1 = CurrentImage1 - 1
        CurrentImage2 = CurrentImage2 - 1
        CurrentImage3 = CurrentImage3 - 1

        If CurrentImage1 < 0 Then
            CurrentImage1 = 7
        End If
        If CurrentImage2 < 0 Then
            CurrentImage2 = 7
        End If
        If CurrentImage3 < 0 Then
            CurrentImage3 = 7
        End If

        pic1.Image = iml.Images.Item(CurrentImage1)
        pic2.Image = iml.Images.Item(CurrentImage2)
        pic3.Image = iml.Images.Item(CurrentImage3)
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        CurrentImage1 = CurrentImage1 + 1
        CurrentImage2 = CurrentImage2 + 1
        CurrentImage3 = CurrentImage3 + 1

        If CurrentImage1 > 7 Then
            CurrentImage1 = 0
        End If
        If CurrentImage2 > 7 Then
            CurrentImage2 = 0
        End If
        If CurrentImage3 > 7 Then
            CurrentImage3 = 0
        End If

        pic1.Image = iml.Images.Item(CurrentImage1)
        pic2.Image = iml.Images.Item(CurrentImage2)
        pic3.Image = iml.Images.Item(CurrentImage3)
    End Sub

    Private Sub chkSlideshow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSlideshow.CheckedChanged
        If chkSlideshow.Checked = True Then
            timSlideshow.Start()
        Else : timSlideshow.Stop()
        End If
    End Sub

    Private Sub timSlideshow_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timSlideshow.Tick
        CurrentImage1 = CurrentImage1 + 1
        CurrentImage2 = CurrentImage2 + 1
        CurrentImage3 = CurrentImage3 + 1

        If CurrentImage1 > 7 Then
            CurrentImage1 = 0
        End If
        If CurrentImage2 > 7 Then
            CurrentImage2 = 0
        End If
        If CurrentImage3 > 7 Then
            CurrentImage3 = 0
        End If

        pic1.Image = iml.Images.Item(CurrentImage1)
        pic2.Image = iml.Images.Item(CurrentImage2)
        pic3.Image = iml.Images.Item(CurrentImage3)
    End Sub
End Class
