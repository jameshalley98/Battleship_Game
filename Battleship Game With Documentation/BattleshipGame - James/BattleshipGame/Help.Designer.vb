<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Help))
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRulesLink = New System.Windows.Forms.Button()
        Me.btnMoreHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHelp
        '
        Me.lblHelp.Location = New System.Drawing.Point(12, 9)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(411, 212)
        Me.lblHelp.TabIndex = 0
        Me.lblHelp.Text = resources.GetString("lblHelp.Text")
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(348, 279)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnRulesLink
        '
        Me.btnRulesLink.Location = New System.Drawing.Point(12, 279)
        Me.btnRulesLink.Name = "btnRulesLink"
        Me.btnRulesLink.Size = New System.Drawing.Size(113, 23)
        Me.btnRulesLink.TabIndex = 2
        Me.btnRulesLink.Text = "Rules of Battleship"
        Me.btnRulesLink.UseVisualStyleBackColor = True
        '
        'btnMoreHelp
        '
        Me.btnMoreHelp.Location = New System.Drawing.Point(177, 279)
        Me.btnMoreHelp.Name = "btnMoreHelp"
        Me.btnMoreHelp.Size = New System.Drawing.Size(113, 23)
        Me.btnMoreHelp.TabIndex = 3
        Me.btnMoreHelp.Text = "More Help"
        Me.btnMoreHelp.UseVisualStyleBackColor = True
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 314)
        Me.Controls.Add(Me.btnMoreHelp)
        Me.Controls.Add(Me.btnRulesLink)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblHelp)
        Me.Name = "Help"
        Me.Text = "Help"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHelp As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnRulesLink As System.Windows.Forms.Button
    Friend WithEvents btnMoreHelp As System.Windows.Forms.Button
End Class
