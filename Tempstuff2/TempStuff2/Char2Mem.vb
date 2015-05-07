Public Class Char2Mem
    Public Char2 As String
    Private Char2Num As Integer
    Private RandType As Integer

    Private Sub RandomChar()
        Dim Char2Rnd As Integer
        If RandType = 0 Then
            Char2Rnd = Rnd() * 1999
        End If
        If RandType = 1 Then
            Char2Rnd = Rnd() * 999
        End If
        If RandType = 2 Then
            Char2Rnd = Rnd() * 999 + 1000
        End If

        'Normal Monster Declaration
        If Char2Num = 0 Then
            Char2Num = 0
        End If
        If Not Char2Rnd < 1 And Not Char2Rnd > 20 Then
            Char2Num = 1
        End If
        If Not Char2Rnd < 21 And Not Char2Rnd > 21 Then
            Char2Num = 2
        End If

        'Boss Monster Declaration
        If Not Char2Rnd < 1000 And Not Char2Rnd > 1000 Then
            Char2Num = 101
        End If
    End Sub

    Public Sub SendForChar(ByVal Input As String)
        'Random Monster
        If Input = "random" Then
            RandType = 0
            RandomChar()
        End If
        If Input = "random mob" Then
            RandType = 1
            RandomChar()
        End If
        If Input = "random boss" Then
            RandType = 2
            RandomChar()
        End If

        'Monster Declaration
        If Char2Num = 0 Then
            MissingNo()
        End If
        If Char2Num = 1 Or Input = "slime" Then
            Slime()
        End If
        If Char2Num = 2 Or Input = "bunny" Then
            Bunny()
        End If
        If Char2Num = 101 Or Input = "Draven" Then
            Draven()
        End If
    End Sub

    'Stats
    'Char2 As String
    'Char2Num As Integer
    Public Lvl As Integer
    Public Str As Integer
    Public Agl As Integer
    Public Arm As Integer
    Public Spd As Integer
    Public Vit As Integer


    'NOTE: Matthew, you may edit ANYTHING below this line


    'Monsters
    Sub MissingNo()
        Char2 = "MissingNo"
        'Char2Num = 0
        Lvl = 0
        Str = 999
        Agl = 999
        Arm = 999
        Spd = 999
        Vit = 99999
    End Sub
    Sub Slime()
        Lvl = 1
        Char2 = "Slime"
        'Char2Num = 1
        Str = 1
        Agl = 1
        Arm = 1
        Spd = 1
        Vit = 10
    End Sub
    Sub Bunny()
        Char2 = "Bunny"
        'Char2Num = 2
        Lvl = 3
        Str = 10
        Agl = 10
        Arm = 10
        Spd = 10
        Vit = 30
    End Sub

    'Bosses
    Sub Draven()
        Char2 = "Draven"
        'Char2Num = 101
        Lvl = 30
        Str = 100
        Agl = 100
        Arm = 100
        Spd = 100
        Vit = 300
    End Sub
End Class
