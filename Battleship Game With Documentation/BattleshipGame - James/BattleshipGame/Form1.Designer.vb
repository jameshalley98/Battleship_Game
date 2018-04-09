<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBattleship
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBattleship))
        Me.btn2Player = New System.Windows.Forms.Button()
        Me.btnCPUPlayer = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn2Player
        '
        Me.btn2Player.Location = New System.Drawing.Point(60, 12)
        Me.btn2Player.Name = "btn2Player"
        Me.btn2Player.Size = New System.Drawing.Size(121, 23)
        Me.btn2Player.TabIndex = 100
        Me.btn2Player.Text = "&Player vs Player"
        Me.btn2Player.UseVisualStyleBackColor = True
        '
        'btnCPUPlayer
        '
        Me.btnCPUPlayer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCPUPlayer.Location = New System.Drawing.Point(60, 41)
        Me.btnCPUPlayer.Name = "btnCPUPlayer"
        Me.btnCPUPlayer.Size = New System.Drawing.Size(121, 23)
        Me.btnCPUPlayer.TabIndex = 101
        Me.btnCPUPlayer.Text = "Player vs &Computer"
        Me.btnCPUPlayer.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.Location = New System.Drawing.Point(60, 99)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(121, 23)
        Me.btnExit.TabIndex = 102
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHelp.Location = New System.Drawing.Point(60, 70)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(121, 23)
        Me.btnHelp.TabIndex = 103
        Me.btnHelp.Text = "&Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'frmBattleship
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 135)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCPUPlayer)
        Me.Controls.Add(Me.btn2Player)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBattleship"
        Me.Text = "Battleship Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn2Player As System.Windows.Forms.Button
    Friend WithEvents btnCPUPlayer As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button

End Class
