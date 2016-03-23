<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn2Player = New System.Windows.Forms.Button()
        Me.btnComVsPlayer = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tbPlayer1Name = New System.Windows.Forms.TextBox()
        Me.tbPlayer2Name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.tbPlayer1AccumPoints = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbPlayer2AccumPoints = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Russian Roulette"
        '
        'btn2Player
        '
        Me.btn2Player.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2Player.Location = New System.Drawing.Point(51, 168)
        Me.btn2Player.Name = "btn2Player"
        Me.btn2Player.Size = New System.Drawing.Size(167, 70)
        Me.btn2Player.TabIndex = 1
        Me.btn2Player.Text = "2 Player"
        Me.btn2Player.UseVisualStyleBackColor = True
        '
        'btnComVsPlayer
        '
        Me.btnComVsPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComVsPlayer.Location = New System.Drawing.Point(51, 267)
        Me.btnComVsPlayer.Name = "btnComVsPlayer"
        Me.btnComVsPlayer.Size = New System.Drawing.Size(167, 70)
        Me.btnComVsPlayer.TabIndex = 2
        Me.btnComVsPlayer.Text = "Computer Vs Player"
        Me.btnComVsPlayer.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(51, 370)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(167, 70)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tbPlayer1Name
        '
        Me.tbPlayer1Name.Enabled = False
        Me.tbPlayer1Name.Location = New System.Drawing.Point(338, 146)
        Me.tbPlayer1Name.Name = "tbPlayer1Name"
        Me.tbPlayer1Name.Size = New System.Drawing.Size(254, 20)
        Me.tbPlayer1Name.TabIndex = 4
        '
        'tbPlayer2Name
        '
        Me.tbPlayer2Name.Enabled = False
        Me.tbPlayer2Name.Location = New System.Drawing.Point(338, 307)
        Me.tbPlayer2Name.Name = "tbPlayer2Name"
        Me.tbPlayer2Name.Size = New System.Drawing.Size(254, 20)
        Me.tbPlayer2Name.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(428, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Player 1 Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(428, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Player 2 Name"
        '
        'btnPlay
        '
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(383, 463)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(167, 70)
        Me.btnPlay.TabIndex = 8
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'tbPlayer1AccumPoints
        '
        Me.tbPlayer1AccumPoints.Location = New System.Drawing.Point(431, 204)
        Me.tbPlayer1AccumPoints.Name = "tbPlayer1AccumPoints"
        Me.tbPlayer1AccumPoints.Size = New System.Drawing.Size(60, 20)
        Me.tbPlayer1AccumPoints.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(414, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Accumulated Points"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(414, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Accumulated Points"
        '
        'tbPlayer2AccumPoints
        '
        Me.tbPlayer2AccumPoints.Location = New System.Drawing.Point(431, 370)
        Me.tbPlayer2AccumPoints.Name = "tbPlayer2AccumPoints"
        Me.tbPlayer2AccumPoints.Size = New System.Drawing.Size(60, 20)
        Me.tbPlayer2AccumPoints.TabIndex = 12
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.tbPlayer2AccumPoints)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbPlayer1AccumPoints)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbPlayer2Name)
        Me.Controls.Add(Me.tbPlayer1Name)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnComVsPlayer)
        Me.Controls.Add(Me.btn2Player)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn2Player As Button
    Friend WithEvents btnComVsPlayer As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tbPlayer1Name As TextBox
    Friend WithEvents tbPlayer2Name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents tbPlayer1AccumPoints As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbPlayer2AccumPoints As TextBox
End Class
