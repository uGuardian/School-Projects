Public Class Plr1Mem
    Public Name As Integer
    'Stats
    Public Str As Integer
    Public Arm As Integer
    Public Agl As Integer
    Public Spd As Integer
    Public Vit As Integer
    'Status Effects
    Public Poison As Integer
    Public Sleep As Integer

    Public Sub Terminate()
        Name = Nothing
        Str = Nothing
        Arm = Nothing
        Agl = Nothing
        Spd = Nothing
        Vit = Nothing
        Poison = Nothing
        Sleep = Nothing
    End Sub
End Class
