Public Class Enemy
    Public EnemyName As String
    Public hp, maxHP, atk, exp As Integer
    Public wins As Byte
    Public Enum Level
        'tentar user este enum nos calculos de mudança de level
        Level1
        Level2
        Level3
        Level4
        Level5
        Level6
        Level7
    End Enum
    Public Lvl As Level
    Sub New()
        Me.EnemyName = "desconhecido"
        Me.hp = 0
        Me.atk = 0
        Me.exp = 5
        Me.Lvl = Level.level1
        Me.wins = 0
    End Sub
    Public Enum EnemyFirst
        The_Evil = 0
        The_Mad = 1
        The_Big = 2
        The_Dangerous = 3
        Captain = 4
        The_Ghostly = 5
        Professor = 6
        Doctor = 7
        Phantom = 8
        The_Brutal = 9
        The_Unstoppable = 10
        The_Vile = 11
        The_Dark = 12
        The_Crazy = 13
        The_Iron = 14
        The_Poison = 15
        The_Berserker = 16
        The_Bloody = 17
        The_King = 18
        The_Violent = 19
        The_Rancid = 20
        The_Invisible = 21
        The_Black = 22
        The_Atomic = 23
        The_Mega = 24
        The_Grand = 25
    End Enum
    Public Enum EnemyLast
        Shadow = 0
        Knight = 1
        Tarantula = 2
        Skull = 3
        Mastermind = 4
        Wizard = 5
        Ninja = 6
        Devil = 7
        Freak = 8
        Beast = 9
        Criminal = 10
        Master = 11
        Lord = 12
        Child = 13
        Corpse = 14
        Slayer = 15
        Spider = 16
        Creature = 17
        Werewolf = 18
        Monster = 19
        Vampire = 20
        Mutant = 21
        Robot = 22
        Claw = 23
        Machine = 24
        Clown = 25
    End Enum
    Public Enum golpe
        slashed = 0
        striked = 1
        punched = 2
        kicked = 3
        shooted = 4
        uppercuted = 5
        throwed = 6
    End Enum
    Public Function randGolpe() As golpe
        Return CInt(Int((6 * Rnd()) + 0))
    End Function
    Public Sub randEnemy()
        Randomize()
        Dim firstName As EnemyFirst = New EnemyFirst
        Dim secondName As EnemyLast = New EnemyFirst
        firstName = CInt(Int((25 * Rnd()) + 0))
        secondName = CInt(Int((25 * Rnd()) + 0))
        Me.EnemyName = firstName.ToString() & " " & secondName.ToString()
        Me.Lvl = Level.level1
        Me.maxHP = CInt(Int(60 * Rnd()) + 30)
        Me.hp = maxHP
        Me.atk = CInt((Int(15 * Rnd())) + 5)
        Me.wins = 0
    End Sub
    Public Function attack() As Integer
        Return CInt(Int((Me.atk * Rnd()) + 1))
    End Function
    Public Function getName()
        Return Me.EnemyName
    End Function
    Public Sub wonBattle()
        'coisas que acontecem quando uma batalha e ganha
        Me.hp = maxHP
        Me.exp += 5
        Me.wins += 1
    End Sub
    Public Function isLevelUP() As Boolean
        Dim aux, atual As Level
        atual = Me.Lvl
        Dim upou As Boolean = False
        Select Case Me.exp
            Case 1 To 15
                aux = Level.level1


            Case 15 To 40
                aux = Level.level2


            Case 40 To 60
                aux = Level.level3

            Case 60 To 80
                aux = Level.level4
            Case 80 To 100
                aux = Level.level5
            Case 100 To 120
                aux = Level.level6
            Case 120 To 150
                aux = Level.level7
            Case Else
                aux = atual
        End Select

        If aux <> atual Then
            upou = True
            Me.Lvl = aux
        End If

        Return upou
    End Function
    Public Function statsUP() As String
        Dim hpInc As Byte = CInt(Int((5 * Rnd()) + 1))
        Dim atkInc As Byte = CInt(Int((3 * Rnd()) + 1))

        Me.maxHP += hpInc
        Me.hp = Me.maxHP
        Me.atk += atkInc
        Return "Hp + " & hpInc & " Attack + " & atkInc
    End Function
    'Public Sub isLevelUP2()
    '   If Me.Lvl > (Me.Lvl + 1) Then
    '       Me.Lvl += 1
    '   End If
    ' End Sub
End Class

