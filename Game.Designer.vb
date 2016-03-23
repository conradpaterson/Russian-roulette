<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.rb1ChamberPlay = New System.Windows.Forms.RadioButton()
        Me.rb3ChamberPlay = New System.Windows.Forms.RadioButton()
        Me.rb6ChamberPlay = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.btnFire = New System.Windows.Forms.Button()
        Me.tbPlayer2LastRoundPoints = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPlayer2TotalPoints = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPlayerTurn = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl1Bullet = New System.Windows.Forms.Label()
        Me.lbl2Bullet = New System.Windows.Forms.Label()
        Me.lbl3Bullet = New System.Windows.Forms.Label()
        Me.lbl4Bullet = New System.Windows.Forms.Label()
        Me.lbl5Bullet = New System.Windows.Forms.Label()
        Me.lbl6Bullet = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkPointAtOpponent = New System.Windows.Forms.CheckBox()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.tbPlayer1LastRoundPoints = New System.Windows.Forms.TextBox()
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.lblPlayer2Other = New System.Windows.Forms.Label()
        Me.tbPlayer1TotalPoints = New System.Windows.Forms.TextBox()
        Me.lblPlayer1Other = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TimerLoad = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSpin = New System.Windows.Forms.Timer(Me.components)
        Me.TimerFireBullet = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rb1ChamberPlay
        '
        Me.rb1ChamberPlay.AutoSize = True
        Me.rb1ChamberPlay.Location = New System.Drawing.Point(7, 4)
        Me.rb1ChamberPlay.Name = "rb1ChamberPlay"
        Me.rb1ChamberPlay.Size = New System.Drawing.Size(99, 17)
        Me.rb1ChamberPlay.TabIndex = 1
        Me.rb1ChamberPlay.TabStop = True
        Me.rb1ChamberPlay.Text = "1 Chamber Play"
        Me.rb1ChamberPlay.UseVisualStyleBackColor = True
        '
        'rb3ChamberPlay
        '
        Me.rb3ChamberPlay.AutoSize = True
        Me.rb3ChamberPlay.Location = New System.Drawing.Point(7, 40)
        Me.rb3ChamberPlay.Name = "rb3ChamberPlay"
        Me.rb3ChamberPlay.Size = New System.Drawing.Size(99, 17)
        Me.rb3ChamberPlay.TabIndex = 2
        Me.rb3ChamberPlay.TabStop = True
        Me.rb3ChamberPlay.Text = "3 Chamber Play"
        Me.rb3ChamberPlay.UseVisualStyleBackColor = True
        '
        'rb6ChamberPlay
        '
        Me.rb6ChamberPlay.AutoSize = True
        Me.rb6ChamberPlay.Location = New System.Drawing.Point(7, 79)
        Me.rb6ChamberPlay.Name = "rb6ChamberPlay"
        Me.rb6ChamberPlay.Size = New System.Drawing.Size(99, 17)
        Me.rb6ChamberPlay.TabIndex = 3
        Me.rb6ChamberPlay.TabStop = True
        Me.rb6ChamberPlay.Text = "6 Chamber Play"
        Me.rb6ChamberPlay.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb6ChamberPlay)
        Me.GroupBox1.Controls.Add(Me.rb3ChamberPlay)
        Me.GroupBox1.Controls.Add(Me.rb1ChamberPlay)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 410)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(125, 108)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "                           "
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(159, 413)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(125, 30)
        Me.btnLoad.TabIndex = 5
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(159, 449)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(125, 30)
        Me.btnSpin.TabIndex = 6
        Me.btnSpin.Text = "Spin"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'btnFire
        '
        Me.btnFire.Location = New System.Drawing.Point(159, 488)
        Me.btnFire.Name = "btnFire"
        Me.btnFire.Size = New System.Drawing.Size(125, 30)
        Me.btnFire.TabIndex = 7
        Me.btnFire.Text = "Fire !"
        Me.btnFire.UseVisualStyleBackColor = True
        '
        'tbPlayer2LastRoundPoints
        '
        Me.tbPlayer2LastRoundPoints.Location = New System.Drawing.Point(614, 436)
        Me.tbPlayer2LastRoundPoints.Name = "tbPlayer2LastRoundPoints"
        Me.tbPlayer2LastRoundPoints.ReadOnly = True
        Me.tbPlayer2LastRoundPoints.Size = New System.Drawing.Size(42, 20)
        Me.tbPlayer2LastRoundPoints.TabIndex = 9
        Me.tbPlayer2LastRoundPoints.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(548, 403)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Last Round Points"
        '
        'tbPlayer2TotalPoints
        '
        Me.tbPlayer2TotalPoints.Location = New System.Drawing.Point(614, 520)
        Me.tbPlayer2TotalPoints.Name = "tbPlayer2TotalPoints"
        Me.tbPlayer2TotalPoints.ReadOnly = True
        Me.tbPlayer2TotalPoints.Size = New System.Drawing.Size(42, 20)
        Me.tbPlayer2TotalPoints.TabIndex = 11
        Me.tbPlayer2TotalPoints.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(548, 475)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Total Points"
        '
        'lblPlayerTurn
        '
        Me.lblPlayerTurn.AutoSize = True
        Me.lblPlayerTurn.Location = New System.Drawing.Point(343, 497)
        Me.lblPlayerTurn.Name = "lblPlayerTurn"
        Me.lblPlayerTurn.Size = New System.Drawing.Size(70, 13)
        Me.lblPlayerTurn.TabIndex = 13
        Me.lblPlayerTurn.Text = "                     "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 539)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Bullets Fired"
        '
        'lbl1Bullet
        '
        Me.lbl1Bullet.AutoSize = True
        Me.lbl1Bullet.Location = New System.Drawing.Point(91, 539)
        Me.lbl1Bullet.Name = "lbl1Bullet"
        Me.lbl1Bullet.Size = New System.Drawing.Size(13, 13)
        Me.lbl1Bullet.TabIndex = 15
        Me.lbl1Bullet.Text = "1"
        '
        'lbl2Bullet
        '
        Me.lbl2Bullet.AutoSize = True
        Me.lbl2Bullet.BackColor = System.Drawing.SystemColors.Control
        Me.lbl2Bullet.Location = New System.Drawing.Point(136, 539)
        Me.lbl2Bullet.Name = "lbl2Bullet"
        Me.lbl2Bullet.Size = New System.Drawing.Size(13, 13)
        Me.lbl2Bullet.TabIndex = 16
        Me.lbl2Bullet.Text = "2"
        '
        'lbl3Bullet
        '
        Me.lbl3Bullet.AutoSize = True
        Me.lbl3Bullet.Location = New System.Drawing.Point(181, 539)
        Me.lbl3Bullet.Name = "lbl3Bullet"
        Me.lbl3Bullet.Size = New System.Drawing.Size(13, 13)
        Me.lbl3Bullet.TabIndex = 17
        Me.lbl3Bullet.Text = "3"
        '
        'lbl4Bullet
        '
        Me.lbl4Bullet.AutoSize = True
        Me.lbl4Bullet.Location = New System.Drawing.Point(226, 539)
        Me.lbl4Bullet.Name = "lbl4Bullet"
        Me.lbl4Bullet.Size = New System.Drawing.Size(13, 13)
        Me.lbl4Bullet.TabIndex = 18
        Me.lbl4Bullet.Text = "4"
        '
        'lbl5Bullet
        '
        Me.lbl5Bullet.AutoSize = True
        Me.lbl5Bullet.Location = New System.Drawing.Point(271, 539)
        Me.lbl5Bullet.Name = "lbl5Bullet"
        Me.lbl5Bullet.Size = New System.Drawing.Size(13, 13)
        Me.lbl5Bullet.TabIndex = 19
        Me.lbl5Bullet.Text = "5"
        '
        'lbl6Bullet
        '
        Me.lbl6Bullet.AutoSize = True
        Me.lbl6Bullet.Location = New System.Drawing.Point(316, 539)
        Me.lbl6Bullet.Name = "lbl6Bullet"
        Me.lbl6Bullet.Size = New System.Drawing.Size(13, 13)
        Me.lbl6Bullet.TabIndex = 20
        Me.lbl6Bullet.Text = "6"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(343, 475)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Player Turn"
        '
        'chkPointAtOpponent
        '
        Me.chkPointAtOpponent.AutoSize = True
        Me.chkPointAtOpponent.Location = New System.Drawing.Point(346, 426)
        Me.chkPointAtOpponent.Name = "chkPointAtOpponent"
        Me.chkPointAtOpponent.Size = New System.Drawing.Size(113, 17)
        Me.chkPointAtOpponent.TabIndex = 22
        Me.chkPointAtOpponent.Text = "Point At Opponent"
        Me.chkPointAtOpponent.UseVisualStyleBackColor = True
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.Location = New System.Drawing.Point(611, 416)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(49, 13)
        Me.lblPlayer2.TabIndex = 23
        Me.lblPlayer2.Text = "              "
        '
        'tbPlayer1LastRoundPoints
        '
        Me.tbPlayer1LastRoundPoints.Location = New System.Drawing.Point(516, 436)
        Me.tbPlayer1LastRoundPoints.Name = "tbPlayer1LastRoundPoints"
        Me.tbPlayer1LastRoundPoints.ReadOnly = True
        Me.tbPlayer1LastRoundPoints.Size = New System.Drawing.Size(39, 20)
        Me.tbPlayer1LastRoundPoints.TabIndex = 24
        Me.tbPlayer1LastRoundPoints.TabStop = False
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.Location = New System.Drawing.Point(516, 416)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(58, 13)
        Me.lblPlayer1.TabIndex = 25
        Me.lblPlayer1.Text = "                 "
        '
        'lblPlayer2Other
        '
        Me.lblPlayer2Other.AutoSize = True
        Me.lblPlayer2Other.Location = New System.Drawing.Point(611, 497)
        Me.lblPlayer2Other.Name = "lblPlayer2Other"
        Me.lblPlayer2Other.Size = New System.Drawing.Size(52, 13)
        Me.lblPlayer2Other.TabIndex = 26
        Me.lblPlayer2Other.Text = "               "
        '
        'tbPlayer1TotalPoints
        '
        Me.tbPlayer1TotalPoints.Location = New System.Drawing.Point(516, 520)
        Me.tbPlayer1TotalPoints.Name = "tbPlayer1TotalPoints"
        Me.tbPlayer1TotalPoints.ReadOnly = True
        Me.tbPlayer1TotalPoints.Size = New System.Drawing.Size(42, 20)
        Me.tbPlayer1TotalPoints.TabIndex = 27
        Me.tbPlayer1TotalPoints.TabStop = False
        '
        'lblPlayer1Other
        '
        Me.lblPlayer1Other.AutoSize = True
        Me.lblPlayer1Other.Location = New System.Drawing.Point(516, 497)
        Me.lblPlayer1Other.Name = "lblPlayer1Other"
        Me.lblPlayer1Other.Size = New System.Drawing.Size(55, 13)
        Me.lblPlayer1Other.TabIndex = 28
        Me.lblPlayer1Other.Text = "                "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'RToolStripMenuItem
        '
        Me.RToolStripMenuItem.Name = "RToolStripMenuItem"
        Me.RToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RToolStripMenuItem.Text = "Rules of the Game"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(19, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(637, 353)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TimerLoad
        '
        Me.TimerLoad.Interval = 1000
        '
        'TimerSpin
        '
        Me.TimerSpin.Interval = 1000
        '
        'TimerFireBullet
        '
        Me.TimerFireBullet.Interval = 1000
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.lblPlayer1Other)
        Me.Controls.Add(Me.tbPlayer1TotalPoints)
        Me.Controls.Add(Me.lblPlayer2Other)
        Me.Controls.Add(Me.lblPlayer1)
        Me.Controls.Add(Me.tbPlayer1LastRoundPoints)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.chkPointAtOpponent)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl6Bullet)
        Me.Controls.Add(Me.lbl5Bullet)
        Me.Controls.Add(Me.lbl4Bullet)
        Me.Controls.Add(Me.lbl3Bullet)
        Me.Controls.Add(Me.lbl2Bullet)
        Me.Controls.Add(Me.lbl1Bullet)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPlayerTurn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbPlayer2TotalPoints)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbPlayer2LastRoundPoints)
        Me.Controls.Add(Me.btnFire)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Game"
        Me.Text = "Game"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents rb1ChamberPlay As RadioButton
    Friend WithEvents rb3ChamberPlay As RadioButton
    Friend WithEvents rb6ChamberPlay As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnSpin As Button
    Friend WithEvents btnFire As Button
    Friend WithEvents tbPlayer2LastRoundPoints As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbPlayer2TotalPoints As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPlayerTurn As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl1Bullet As Label
    Friend WithEvents lbl2Bullet As Label
    Friend WithEvents lbl3Bullet As Label
    Friend WithEvents lbl4Bullet As Label
    Friend WithEvents lbl5Bullet As Label
    Friend WithEvents lbl6Bullet As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents chkPointAtOpponent As CheckBox
    Friend WithEvents lblPlayer2 As Label
    Friend WithEvents tbPlayer1LastRoundPoints As TextBox
    Friend WithEvents lblPlayer1 As Label
    Friend WithEvents lblPlayer2Other As Label
    Friend WithEvents tbPlayer1TotalPoints As TextBox
    Friend WithEvents lblPlayer1Other As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimerLoad As Timer
    Friend WithEvents TimerSpin As Timer
    Friend WithEvents TimerFireBullet As Timer
End Class
