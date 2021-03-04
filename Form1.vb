Public Class Form1
    Shared cont As Byte = 0
    Dim b As Battle = New Battle
    Public nextGame As Boolean = False
    Public victory As Image = Image.FromFile("victory.jpg")
    Public levelup As Image = Image.FromFile("levelup.jpg")
    Public abertura As Image = Image.FromFile("abertura.jpg")
    Public primeiraTela As Boolean = False

    'para deslocar o botão start
    Dim restaura As Point = New Point(175, 226)
    Dim newPos As Point = New Point(240, 226)

    'pontos que guardarão o local padrao dos labels opara serem restaurados apos a animação
    Public e11, e12, e13, e14, e15, e16 As Point
    Public e21, e22, e23, e24, e25, e26 As Point
    Public Sub getLabelsInitialPositions()

        e11 = e1hp.Location
        e12 = e1atk.Location
        e13 = e1name.Location
        e14 = e1wins.Location
        e15 = e1Lvl.Location
        e16 = pbe1.Location

        e21 = e2hp.Location
        e22 = e2atk.Location
        e23 = e2name.Location
        e24 = e2wins.Location
        e25 = e2Lvl.Location
        e26 = pbe2.Location
    End Sub
    Public Sub setLabelsInitialPositions()

        e1hp.Location = e11
        e1atk.Location = e12
        e1name.Location = e13
        e1wins.Location = e14
        e1Lvl.Location = e15
        pbe1.Location = e16

        e2hp.Location = e21
        e2atk.Location = e22
        e2name.Location = e23
        e2wins.Location = e24
        e2Lvl.Location = e25
        pbe2.Location = e26
    End Sub

    Public Enum Enemy
        e1
        e2
    End Enum
    Public Sub New()
        InitializeComponent()
        getLabelsInitialPositions()  ' grava as posicoes iniciais dos labels
        Me.BackgroundImage = abertura
        pbe1.Hide()
        pbe2.Hide()
        txtOutput.Hide()
        btnStop.Hide()
        btnStart.Location = newPos
        btnStart.Update()
    End Sub

    '  Structure enemy
    'Public nome As Label
    '  Public hp As Label
    '  Public atk As Label
    '  Public wins As Label
    '  Public level As Label
    '  End Structure
    '  Dim enemy1 As enemy = New enemy
    '  enemy1.hp.Text=e1hp.Text


    Public Sub atualizaLabels()

        e1name.Text = b.e1.EnemyName
        e1hp.Text = "HP " & b.e1.hp
        e1atk.Text = "Atk " & b.e1.atk

        pbe1.Maximum = b.e1.maxHP
        pbe1.Value = b.e1.hp

        pbe2.Maximum = b.e2.maxHP
        pbe2.Value = b.e2.hp

        e1Lvl.Text = b.e1.Lvl.ToString()
        e2Lvl.Text = b.e2.Lvl.ToString()
        e1wins.Text = "Wins " & b.e1.wins
        e2wins.Text = "Wins " & b.e2.wins

        e2name.Text = b.e2.EnemyName
        e2hp.Text = "HP " & b.e2.hp
        e2atk.Text = "Atk " & b.e2.atk

        btnStart.Text = "Turn " & cont
    End Sub
    Public Sub apagaLabels()

        e1name.Text = ""
        e1hp.Text = ""
        e1atk.Text = ""

        pbe1.Hide()
        pbe2.Hide()

        e1Lvl.Text = ""
        e2Lvl.Text = ""
        e1wins.Text = ""
        e2wins.Text = ""

        e2name.Text = ""
        e2hp.Text = ""
        e2atk.Text = ""

        btnStart.Text = "Start"
        btnStop.Hide()
    End Sub
    Public Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        pbe1.Show()  'mostra barras de vida
        pbe2.Show()
        btnStop.Show()
        txtOutput.Show()
        txtOutput.Text = ""

        btnStart.Location = restaura
        btnStart.Update()

        ' muda por 100ms a cor do botao
        If cont > 0 Then
            Dim i As Integer
            Dim p, restoreSize, location, restoreLocation As Point
            btnStart.BackColor = Color.Red
            btnStart.ForeColor = Color.Yellow
            btnStart.Text = "HIT!"
            restoreSize = btnStart.Size()
            restoreLocation = btnStart.Location
            location = btnStart.Location
            For i = 0 To 50
                location.X += 1
                location.Y -= 1
                p.Y += 1
                p.X += 1
                btnStart.Size = p
                btnStart.Location = location
                btnStart.Update()
                System.Threading.Thread.Sleep(4)
            Next i
            btnStart.BackColor = Color.LightGray
            btnStart.ForeColor = Color.Black
            btnStart.Size = restoreSize
            btnStart.Location = restoreLocation
            btnStart.Text = "Turno " & cont
            ' btnStart.Update()
        End If


        cont += 1
        If cont = 1 Then
            Me.BackgroundImage = Nothing
        End If
        atualizaLabels()
        btnStart.Update()
        If cont > 1 Then

            randomAttack()
            checkWinner()
            If nextGame = True Then
                setLabelsInitialPositions()
                b.NextEnemy()
                nextGame = False
            End If
        End If

    End Sub

    Public Sub attackE1()
        Dim a As Integer = b.e1.attack()
        txtOutput.Text = b.e1.EnemyName & "  " & b.e1.randGolpe().ToString() & "!      " & a & " damage"
        b.e2.hp -= a
        txtOutput.BackColor = Color.Red
        txtOutput.Update()
        Dim c As Color = Me.e2name.ForeColor
        Me.e2name.ForeColor = Color.Red
        Me.e2name.Update()
        System.Threading.Thread.Sleep(50)
        txtOutput.BackColor = Color.LightGray
        Me.e2name.ForeColor = c
        Me.e2name.Update()
        txtOutput.Update()
    End Sub
    Public Sub attackE2()
        Dim a As Integer = b.e2.attack()
        txtOutput.Text = b.e2.EnemyName & "  " & b.e2.randGolpe().ToString() & "!      " & a & " damage"
        txtOutput.BackColor = Color.Red
        txtOutput.Update()
        Dim c As Color = Me.e1name.ForeColor
        Me.e1name.ForeColor = Color.Red
        Me.e1name.Update()
        System.Threading.Thread.Sleep(50)
        txtOutput.BackColor = Color.LightGray
        txtOutput.Update()
        Me.e1name.ForeColor = c
        Me.e1name.Update()
        b.e1.hp -= a
    End Sub

    Public Sub randomAttack()
        Dim aux As Byte = CInt(Int((2 * Rnd()) + 1))
        If aux = 1 Then
            attackE1()
        ElseIf aux = 2 Then
            attackE2()
        End If
    End Sub
    Public Sub checkWinner()
       
        If b.isDead() = 1 Or b.isDead() = 2 Then
            ' se inimigo 1 morreu  confere se inimigo 2 fez level para chamar a funcao que incrementa o status
            If b.isDead() = 1 Then
                b.e1.exp = 0
                animacaoDerrota(True)
                apagaLabels()
                btnStart.Show()
                btnStop.Show()
                txtOutput.Show()
                Me.BackgroundImage = victory
                ' codigo para colocar o botao start no meio da tela

                btnStart.Location = newPos
                btnStart.Update()
                ''''''''''''''''''''''''''''''''''''''''''''''''''
                apagaLabels()
                txtOutput.Text = b.e2.EnemyName & " Wins "
                b.e2.wonBattle()

                cont = 0
                If b.e2.isLevelUP() = True Then
                    txtOutput.Text = b.e2.EnemyName & "  " & b.e2.statsUP()
                    Me.BackgroundImage = levelup
                    ' codigo para colocar o botao start no meio da tela

                    btnStart.Location = newPos
                    btnStart.Update()
                    ''''''''''''''''''''''''''''''''''''''''''''''''''
                    apagaLabels()
                End If
                Me.nextGame = True
            End If
            If b.isDead() = 2 Then
                b.e2.exp = 0
                animacaoDerrota(False)
                apagaLabels()
                btnStart.Show()
                btnStop.Show()
                txtOutput.Show()
                Me.BackgroundImage = victory
               
                txtOutput.Text = b.e1.EnemyName & " Wins "
                b.e1.hp = b.e1.maxHP
                b.e1.wonBattle()
                ' codigo para colocar o botao start no meio da tela
                btnStop.Hide()
                btnStart.Location = newPos
                btnStart.Update()
                ''''''''''''''''''''''''''''''''''''''''''''''''''
                cont = 0
                If b.e1.isLevelUP() = True Then
                    txtOutput.Text = b.e1.EnemyName & "  " & b.e1.statsUP()
                    Me.BackgroundImage = levelup
                    ' codigo para colocar o botao start no meio da tela

                    btnStart.Location = newPos
                    btnStart.Update()
                    ''''''''''''''''''''''''''''''''''''''''''''''''''
                    apagaLabels()

                End If
                Me.nextGame = True

            End If
        End If
       
    End Sub



    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click

        pbe1.Hide()
        pbe2.Hide()
        ' zera a ezperiencia dos inimigos para nao dar efeito colateral em um reinicio
        b.e1.exp = 0
        b.e2.exp = 0

        apagaLabels()
        cont = 0
        b.e1.randEnemy()
        b.e2.randEnemy()
        txtOutput.Text = " "
        txtOutput.Hide()

        btnStart.Location = newPos
        btnStart.Update()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        pbe1.Value = 0
        pbe2.Value = 0
        Me.BackgroundImage = abertura
    End Sub

    Public Sub animacaoDerrota(ByVal c As Boolean)
        Dim i As Integer

        btnStart.Hide()
        btnStop.Hide()
        txtOutput.Hide()

        Dim p1, p2, p3, p4, p5, p6 As Point
        '    If qual = Enemy.e1 Then
        If c = True Then
            pbe1.Value = 0

            While i < 200
                System.Threading.Thread.Sleep(2)
                p1 = e1hp.Location
                p2 = e1atk.Location
                p3 = e1name.Location
                p4 = e1wins.Location
                p5 = e1Lvl.Location
                p6 = pbe1.Location

                p1.Y += 1
                p2.Y += 1
                p3.Y += 1
                p4.Y += 1
                p5.Y += 1
                p6.Y += 1

                e1hp.Location = p1
                e1atk.Location = p2
                e1name.Location = p3
                e1name.Update()
                e1wins.Location = p4
                e1Lvl.Location = p5
                pbe1.Location = p6
                '   Me.Refresh()

                i += 1
            End While

        ElseIf c = False Then
            i = 0
            pbe2.Value = 0 ' so pra conferir que a barra esta vazia
            While i < 200
                System.Threading.Thread.Sleep(2)
                p1 = e2hp.Location
                p2 = e2atk.Location
                p3 = e2name.Location
                p4 = e2wins.Location
                p5 = e2Lvl.Location
                p6 = pbe2.Location

                p1.Y += 1
                p2.Y += 1
                p3.Y += 1
                p4.Y += 1
                p5.Y += 1
                p6.Y += 1

                e2hp.Location = p1
                e2hp.Refresh()

                e2atk.Location = p2
                e2name.Location = p3
                e2wins.Location = p4
                e2Lvl.Location = p5
                pbe2.Location = p6
                ' Me.Refresh()

                i += 1
            End While

        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Interval = 200
        Timer1.Start()
        btnStart.BackColor = Color.LightGreen
    End Sub


End Class
