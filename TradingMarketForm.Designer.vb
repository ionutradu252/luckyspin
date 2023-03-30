<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TradingMarketForm
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
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.username_label = New System.Windows.Forms.Label()
        Me.offer1 = New Guna.UI2.WinForms.Guna2Button()
        Me.offer2 = New Guna.UI2.WinForms.Guna2Button()
        Me.item1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.item2 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.item1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 5
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragForm = False
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'username_label
        '
        Me.username_label.AutoSize = True
        Me.username_label.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_label.Location = New System.Drawing.Point(12, 9)
        Me.username_label.Name = "username_label"
        Me.username_label.Size = New System.Drawing.Size(175, 32)
        Me.username_label.TabIndex = 8
        Me.username_label.Text = "Trading Market"
        '
        'offer1
        '
        Me.offer1.Animated = True
        Me.offer1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.offer1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.offer1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.offer1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.offer1.FillColor = System.Drawing.Color.PaleVioletRed
        Me.offer1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.offer1.ForeColor = System.Drawing.Color.White
        Me.offer1.Location = New System.Drawing.Point(284, 84)
        Me.offer1.Name = "offer1"
        Me.offer1.Size = New System.Drawing.Size(200, 37)
        Me.offer1.TabIndex = 9
        Me.offer1.Text = "10 pigs - 5 spins"
        '
        'offer2
        '
        Me.offer2.Animated = True
        Me.offer2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.offer2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.offer2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.offer2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.offer2.FillColor = System.Drawing.Color.PaleVioletRed
        Me.offer2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.offer2.ForeColor = System.Drawing.Color.White
        Me.offer2.Location = New System.Drawing.Point(284, 203)
        Me.offer2.Name = "offer2"
        Me.offer2.Size = New System.Drawing.Size(200, 37)
        Me.offer2.TabIndex = 9
        Me.offer2.Text = "10 pigs - 250 coins"
        '
        'item1
        '
        Me.item1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.item1.Image = Global.LuckySpin.My.Resources.Resources.pigs
        Me.item1.ImageRotate = 0!
        Me.item1.Location = New System.Drawing.Point(18, 44)
        Me.item1.Name = "item1"
        Me.item1.Size = New System.Drawing.Size(169, 247)
        Me.item1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.item1.TabIndex = 10
        Me.item1.TabStop = False
        '
        'item2
        '
        Me.item2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.item2.Image = Global.LuckySpin.My.Resources.Resources.coins
        Me.item2.ImageRotate = 0!
        Me.item2.Location = New System.Drawing.Point(587, 44)
        Me.item2.Name = "item2"
        Me.item2.Size = New System.Drawing.Size(169, 247)
        Me.item2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.item2.TabIndex = 10
        Me.item2.TabStop = False
        '
        'TradingMarketForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 303)
        Me.Controls.Add(Me.item2)
        Me.Controls.Add(Me.item1)
        Me.Controls.Add(Me.offer2)
        Me.Controls.Add(Me.offer1)
        Me.Controls.Add(Me.username_label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TradingMarketForm"
        Me.Text = "TradingMarketForm"
        CType(Me.item1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents username_label As Label
    Friend WithEvents offer1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents offer2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents item2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents item1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
