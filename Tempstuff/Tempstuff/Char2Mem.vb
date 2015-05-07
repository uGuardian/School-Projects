Public Class Char2Mem
    Private Char2 As String
    Private Char2Num As Integer

    Sub RandomChar()
        Dim Char2Rnd As Integer
        Char2Rnd = Rnd() * 21

        If Not Char2Rnd < 1 And Not Char2Rnd > 20 Then
            Char2Num = 1
        End If
    End Sub

    Public Function SendForChar(ByVal Input As String) As String
        'Random Monster
        If Input = "Random" Or 0 Then
            RandomChar()
        End If

        'Monster Declaration
        If Char2Num = 1 Then
            Slime()
        End If

        Return Char2
    End Function

    'Stats
    Public Name As String
    Public Str As Integer
    Public Agl As Integer
    Public Arm As Integer
    Public Spd As Integer
    Public Vit As Integer

    'Monsters
    Sub Slime()
        Char2 = "Slime"
        Str = 1
        Agl = 1
        Arm = 1
        Spd = 1
        Vit = 10
    End Sub
    Sub Bunny()
        Char2 = "Bunny"
        Str = 10
        Agl = 10
        Arm = 10
        Spd = 10
        Vit = 30
    End Sub
    

End Class
