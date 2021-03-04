Public Class Battle
    Public e1 As Enemy = New Enemy
    Public e2 As Enemy = New Enemy


    Sub New()
        e1.randEnemy()
        e2.randEnemy()
    End Sub
    Public Function isDead() As Byte
        'se inimigo 1 morreu retorna 1, se o 2 morreu retorna 2, se estão vivos retorna 0 
        If Me.e1.hp < 1 Then
            Return 1
        ElseIf Me.e2.hp < 1 Then
            Return 2
        Else
            Return 0
        End If
    End Function
    Public Sub NextEnemy()
        'procura qual inimigo morreu e gera outro no lugar
        If Me.isDead() = 1 Then
            e1.randEnemy()
        ElseIf Me.isDead() = 2 Then
            e2.randEnemy()
        End If
    End Sub


End Class
