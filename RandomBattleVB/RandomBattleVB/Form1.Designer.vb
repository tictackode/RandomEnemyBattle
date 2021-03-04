<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.e1name = New System.Windows.Forms.Label()
        Me.e1hp = New System.Windows.Forms.Label()
        Me.e1atk = New System.Windows.Forms.Label()
        Me.e2atk = New System.Windows.Forms.Label()
        Me.e2hp = New System.Windows.Forms.Label()
        Me.e2name = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.pbe1 = New System.Windows.Forms.ProgressBar()
        Me.pbe2 = New System.Windows.Forms.ProgressBar()
        Me.e1Lvl = New System.Windows.Forms.Label()
        Me.e2Lvl = New System.Windows.Forms.Label()
        Me.e2wins = New System.Windows.Forms.Label()
        Me.e1wins = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'e1name
        '
        Me.e1name.AutoSize = True
        Me.e1name.Font = New System.Drawing.Font("Pericles", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e1name.Location = New System.Drawing.Point(34, 41)
        Me.e1name.Name = "e1name"
        Me.e1name.Size = New System.Drawing.Size(0, 23)
        Me.e1name.TabIndex = 0
        '
        'e1hp
        '
        Me.e1hp.AutoSize = True
        Me.e1hp.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e1hp.Location = New System.Drawing.Point(211, 65)
        Me.e1hp.Name = "e1hp"
        Me.e1hp.Size = New System.Drawing.Size(0, 21)
        Me.e1hp.TabIndex = 1
        '
        'e1atk
        '
        Me.e1atk.AutoSize = True
        Me.e1atk.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e1atk.Location = New System.Drawing.Point(211, 102)
        Me.e1atk.Name = "e1atk"
        Me.e1atk.Size = New System.Drawing.Size(0, 21)
        Me.e1atk.TabIndex = 2
        '
        'e2atk
        '
        Me.e2atk.AutoSize = True
        Me.e2atk.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e2atk.Location = New System.Drawing.Point(489, 102)
        Me.e2atk.Name = "e2atk"
        Me.e2atk.Size = New System.Drawing.Size(0, 21)
        Me.e2atk.TabIndex = 5
        '
        'e2hp
        '
        Me.e2hp.AutoSize = True
        Me.e2hp.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e2hp.Location = New System.Drawing.Point(489, 65)
        Me.e2hp.Name = "e2hp"
        Me.e2hp.Size = New System.Drawing.Size(0, 21)
        Me.e2hp.TabIndex = 4
        '
        'e2name
        '
        Me.e2name.AutoSize = True
        Me.e2name.Font = New System.Drawing.Font("Pericles", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e2name.Location = New System.Drawing.Point(301, 41)
        Me.e2name.Name = "e2name"
        Me.e2name.Size = New System.Drawing.Size(0, 23)
        Me.e2name.TabIndex = 3
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.LightGray
        Me.btnStart.Font = New System.Drawing.Font("Pericles", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(191, 222)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(85, 33)
        Me.btnStart.TabIndex = 6
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.Color.LightGray
        Me.txtOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.ForeColor = System.Drawing.Color.Black
        Me.txtOutput.Location = New System.Drawing.Point(77, 272)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(417, 24)
        Me.txtOutput.TabIndex = 7
        '
        'pbe1
        '
        Me.pbe1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbe1.Location = New System.Drawing.Point(38, 110)
        Me.pbe1.Name = "pbe1"
        Me.pbe1.Size = New System.Drawing.Size(150, 15)
        Me.pbe1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbe1.TabIndex = 8
        '
        'pbe2
        '
        Me.pbe2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbe2.Location = New System.Drawing.Point(305, 113)
        Me.pbe2.Name = "pbe2"
        Me.pbe2.Size = New System.Drawing.Size(150, 15)
        Me.pbe2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbe2.TabIndex = 9
        '
        'e1Lvl
        '
        Me.e1Lvl.AutoSize = True
        Me.e1Lvl.Font = New System.Drawing.Font("Quartz MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e1Lvl.ForeColor = System.Drawing.Color.Blue
        Me.e1Lvl.Location = New System.Drawing.Point(34, 94)
        Me.e1Lvl.Name = "e1Lvl"
        Me.e1Lvl.Size = New System.Drawing.Size(0, 16)
        Me.e1Lvl.TabIndex = 10
        '
        'e2Lvl
        '
        Me.e2Lvl.AutoSize = True
        Me.e2Lvl.Font = New System.Drawing.Font("Quartz MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e2Lvl.ForeColor = System.Drawing.Color.Blue
        Me.e2Lvl.Location = New System.Drawing.Point(308, 94)
        Me.e2Lvl.Name = "e2Lvl"
        Me.e2Lvl.Size = New System.Drawing.Size(0, 16)
        Me.e2Lvl.TabIndex = 11
        '
        'e2wins
        '
        Me.e2wins.AutoSize = True
        Me.e2wins.Font = New System.Drawing.Font("Pericles", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e2wins.Location = New System.Drawing.Point(410, 91)
        Me.e2wins.Name = "e2wins"
        Me.e2wins.Size = New System.Drawing.Size(0, 16)
        Me.e2wins.TabIndex = 12
        '
        'e1wins
        '
        Me.e1wins.AutoSize = True
        Me.e1wins.Font = New System.Drawing.Font("Pericles", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e1wins.Location = New System.Drawing.Point(139, 91)
        Me.e1wins.Name = "e1wins"
        Me.e1wins.Size = New System.Drawing.Size(0, 16)
        Me.e1wins.TabIndex = 13
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Red
        Me.btnStop.Font = New System.Drawing.Font("Pericles", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(292, 222)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(85, 34)
        Me.btnStop.TabIndex = 14
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 322)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.e1wins)
        Me.Controls.Add(Me.e2wins)
        Me.Controls.Add(Me.e2Lvl)
        Me.Controls.Add(Me.e1Lvl)
        Me.Controls.Add(Me.pbe2)
        Me.Controls.Add(Me.pbe1)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.e2atk)
        Me.Controls.Add(Me.e2hp)
        Me.Controls.Add(Me.e2name)
        Me.Controls.Add(Me.e1atk)
        Me.Controls.Add(Me.e1hp)
        Me.Controls.Add(Me.e1name)
        Me.Name = "Form1"
        Me.Text = "Random Battle >> TictacKode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents e1name As System.Windows.Forms.Label
    Friend WithEvents e1hp As System.Windows.Forms.Label
    Friend WithEvents e1atk As System.Windows.Forms.Label
    Friend WithEvents e2atk As System.Windows.Forms.Label
    Friend WithEvents e2hp As System.Windows.Forms.Label
    Friend WithEvents e2name As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents pbe1 As System.Windows.Forms.ProgressBar
    Friend WithEvents pbe2 As System.Windows.Forms.ProgressBar
    Friend WithEvents e1Lvl As System.Windows.Forms.Label
    Friend WithEvents e2Lvl As System.Windows.Forms.Label
    Friend WithEvents e2wins As System.Windows.Forms.Label
    Friend WithEvents e1wins As System.Windows.Forms.Label
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
