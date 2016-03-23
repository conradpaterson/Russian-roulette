<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopPlayers
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnReturnMainMenu = New System.Windows.Forms.Button()
        Me.Score = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlayerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Score, Me.PlayerName, Me.Remark})
        Me.DataGridView1.Location = New System.Drawing.Point(35, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(717, 273)
        Me.DataGridView1.TabIndex = 0
        '
        'btnReturnMainMenu
        '
        Me.btnReturnMainMenu.Location = New System.Drawing.Point(527, 354)
        Me.btnReturnMainMenu.Name = "btnReturnMainMenu"
        Me.btnReturnMainMenu.Size = New System.Drawing.Size(198, 56)
        Me.btnReturnMainMenu.TabIndex = 1
        Me.btnReturnMainMenu.Text = "Return to the MainMenu"
        Me.btnReturnMainMenu.UseVisualStyleBackColor = True
        '
        'Score
        '
        Me.Score.HeaderText = "Score"
        Me.Score.Name = "Score"
        Me.Score.ReadOnly = True
        Me.Score.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'PlayerName
        '
        Me.PlayerName.HeaderText = "Player Name"
        Me.PlayerName.Name = "PlayerName"
        Me.PlayerName.ReadOnly = True
        '
        'Remark
        '
        Me.Remark.HeaderText = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.ReadOnly = True
        Me.Remark.Width = 400
        '
        'TopPlayers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 433)
        Me.Controls.Add(Me.btnReturnMainMenu)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "TopPlayers"
        Me.Text = "TopPlayers"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnReturnMainMenu As Button
    Friend WithEvents Score As DataGridViewTextBoxColumn
    Friend WithEvents PlayerName As DataGridViewTextBoxColumn
    Friend WithEvents Remark As DataGridViewTextBoxColumn
End Class
