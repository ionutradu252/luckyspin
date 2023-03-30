<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SpinForm
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
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Guna2VSeparator2 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.spinbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.payout_label = New System.Windows.Forms.Label()
        Me.SpinTimer = New System.Windows.Forms.Timer(Me.components)
        Me.slot1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.slot3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.slot2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.spinx10btn = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.slot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slot3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slot2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.FillColor = System.Drawing.Color.PaleVioletRed
        Me.Guna2VSeparator1.FillThickness = 2
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(250, 12)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(10, 135)
        Me.Guna2VSeparator1.TabIndex = 0
        '
        'Guna2VSeparator2
        '
        Me.Guna2VSeparator2.FillColor = System.Drawing.Color.PaleVioletRed
        Me.Guna2VSeparator2.FillThickness = 2
        Me.Guna2VSeparator2.Location = New System.Drawing.Point(506, 12)
        Me.Guna2VSeparator2.Name = "Guna2VSeparator2"
        Me.Guna2VSeparator2.Size = New System.Drawing.Size(10, 135)
        Me.Guna2VSeparator2.TabIndex = 0
        '
        'spinbtn
        '
        Me.spinbtn.Animated = True
        Me.spinbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.spinbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.spinbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.spinbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.spinbtn.FillColor = System.Drawing.Color.PaleVioletRed
        Me.spinbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.spinbtn.ForeColor = System.Drawing.Color.White
        Me.spinbtn.Location = New System.Drawing.Point(178, 254)
        Me.spinbtn.Name = "spinbtn"
        Me.spinbtn.Size = New System.Drawing.Size(195, 37)
        Me.spinbtn.TabIndex = 2
        Me.spinbtn.Text = "roll"
        '
        'payout_label
        '
        Me.payout_label.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.payout_label.Location = New System.Drawing.Point(250, 162)
        Me.payout_label.Name = "payout_label"
        Me.payout_label.Size = New System.Drawing.Size(266, 76)
        Me.payout_label.TabIndex = 10
        Me.payout_label.Text = "roll to win"
        Me.payout_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SpinTimer
        '
        Me.SpinTimer.Interval = 125
        '
        'slot1
        '
        Me.slot1.BackColor = System.Drawing.Color.Transparent
        Me.slot1.ErrorImage = Nothing
        Me.slot1.FillColor = System.Drawing.Color.Transparent
        Me.slot1.ImageRotate = 0!
        Me.slot1.Location = New System.Drawing.Point(27, 12)
        Me.slot1.Name = "slot1"
        Me.slot1.Size = New System.Drawing.Size(195, 135)
        Me.slot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.slot1.TabIndex = 1
        Me.slot1.TabStop = False
        Me.slot1.UseTransparentBackground = True
        '
        'slot3
        '
        Me.slot3.BackColor = System.Drawing.Color.Transparent
        Me.slot3.FillColor = System.Drawing.Color.Transparent
        Me.slot3.ImageRotate = 0!
        Me.slot3.Location = New System.Drawing.Point(544, 12)
        Me.slot3.Name = "slot3"
        Me.slot3.Size = New System.Drawing.Size(195, 135)
        Me.slot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.slot3.TabIndex = 1
        Me.slot3.TabStop = False
        Me.slot3.UseTransparentBackground = True
        '
        'slot2
        '
        Me.slot2.BackColor = System.Drawing.Color.Transparent
        Me.slot2.FillColor = System.Drawing.Color.Transparent
        Me.slot2.ImageRotate = 0!
        Me.slot2.Location = New System.Drawing.Point(288, 12)
        Me.slot2.Name = "slot2"
        Me.slot2.Size = New System.Drawing.Size(195, 135)
        Me.slot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.slot2.TabIndex = 1
        Me.slot2.TabStop = False
        Me.slot2.UseTransparentBackground = True
        '
        'spinx10btn
        '
        Me.spinx10btn.Animated = True
        Me.spinx10btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.spinx10btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.spinx10btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.spinx10btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.spinx10btn.FillColor = System.Drawing.Color.PaleVioletRed
        Me.spinx10btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.spinx10btn.ForeColor = System.Drawing.Color.White
        Me.spinx10btn.Location = New System.Drawing.Point(396, 254)
        Me.spinx10btn.Name = "spinx10btn"
        Me.spinx10btn.Size = New System.Drawing.Size(195, 37)
        Me.spinx10btn.TabIndex = 11
        Me.spinx10btn.Text = "roll x10"
        '
        'SpinForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 303)
        Me.Controls.Add(Me.spinx10btn)
        Me.Controls.Add(Me.payout_label)
        Me.Controls.Add(Me.spinbtn)
        Me.Controls.Add(Me.slot1)
        Me.Controls.Add(Me.slot3)
        Me.Controls.Add(Me.slot2)
        Me.Controls.Add(Me.Guna2VSeparator2)
        Me.Controls.Add(Me.Guna2VSeparator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "SpinForm"
        Me.Text = "SpinForm"
        CType(Me.slot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slot3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slot2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents Guna2VSeparator2 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents slot2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents slot1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents slot3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents spinbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents payout_label As Label
    Friend WithEvents SpinTimer As Timer
    Friend WithEvents spinx10btn As Guna.UI2.WinForms.Guna2Button
End Class
