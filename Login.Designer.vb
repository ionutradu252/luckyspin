<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.usernamebox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.loginbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.quitbtn = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.luckyspin_title = New System.Windows.Forms.Label()
        Me.remember_radio = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.afkwheel = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        CType(Me.afkwheel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 5
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'usernamebox
        '
        Me.usernamebox.Animated = True
        Me.usernamebox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernamebox.DefaultText = ""
        Me.usernamebox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.usernamebox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.usernamebox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernamebox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernamebox.FocusedState.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.usernamebox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.usernamebox.HoverState.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.usernamebox.Location = New System.Drawing.Point(300, 183)
        Me.usernamebox.Name = "usernamebox"
        Me.usernamebox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.usernamebox.PlaceholderText = "username"
        Me.usernamebox.SelectedText = ""
        Me.usernamebox.Size = New System.Drawing.Size(200, 36)
        Me.usernamebox.TabIndex = 0
        Me.usernamebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'loginbtn
        '
        Me.loginbtn.Animated = True
        Me.loginbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.loginbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.loginbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.loginbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.loginbtn.FillColor = System.Drawing.Color.PaleVioletRed
        Me.loginbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.loginbtn.ForeColor = System.Drawing.Color.White
        Me.loginbtn.Location = New System.Drawing.Point(300, 225)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(200, 37)
        Me.loginbtn.TabIndex = 1
        Me.loginbtn.Text = "login"
        '
        'quitbtn
        '
        Me.quitbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.quitbtn.Animated = True
        Me.quitbtn.FillColor = System.Drawing.Color.Transparent
        Me.quitbtn.IconColor = System.Drawing.Color.PaleVioletRed
        Me.quitbtn.Location = New System.Drawing.Point(743, 12)
        Me.quitbtn.Name = "quitbtn"
        Me.quitbtn.Size = New System.Drawing.Size(45, 29)
        Me.quitbtn.TabIndex = 2
        '
        'luckyspin_title
        '
        Me.luckyspin_title.AutoSize = True
        Me.luckyspin_title.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luckyspin_title.Location = New System.Drawing.Point(68, 21)
        Me.luckyspin_title.Name = "luckyspin_title"
        Me.luckyspin_title.Size = New System.Drawing.Size(121, 32)
        Me.luckyspin_title.TabIndex = 4
        Me.luckyspin_title.Text = "LuckySpin"
        '
        'remember_radio
        '
        Me.remember_radio.Animated = True
        Me.remember_radio.AutoSize = True
        Me.remember_radio.CheckedState.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.remember_radio.CheckedState.BorderThickness = 0
        Me.remember_radio.CheckedState.FillColor = System.Drawing.Color.PaleVioletRed
        Me.remember_radio.CheckedState.InnerColor = System.Drawing.Color.PaleVioletRed
        Me.remember_radio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.remember_radio.Location = New System.Drawing.Point(350, 268)
        Me.remember_radio.Name = "remember_radio"
        Me.remember_radio.Size = New System.Drawing.Size(101, 17)
        Me.remember_radio.TabIndex = 5
        Me.remember_radio.Text = "Remember login"
        Me.remember_radio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.remember_radio.UncheckedState.BorderThickness = 2
        Me.remember_radio.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.remember_radio.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.Color.PaleVioletRed
        Me.Guna2Separator1.FillThickness = 2
        Me.Guna2Separator1.Location = New System.Drawing.Point(12, 68)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(776, 13)
        Me.Guna2Separator1.TabIndex = 9
        '
        'afkwheel
        '
        Me.afkwheel.BackColor = System.Drawing.Color.Transparent
        Me.afkwheel.Image = Global.LuckySpin.My.Resources.Resources.luckyspin
        Me.afkwheel.ImageRotate = 0!
        Me.afkwheel.Location = New System.Drawing.Point(12, 12)
        Me.afkwheel.Name = "afkwheel"
        Me.afkwheel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.afkwheel.Size = New System.Drawing.Size(50, 50)
        Me.afkwheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.afkwheel.TabIndex = 3
        Me.afkwheel.TabStop = False
        Me.afkwheel.UseTransparentBackground = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.remember_radio)
        Me.Controls.Add(Me.luckyspin_title)
        Me.Controls.Add(Me.afkwheel)
        Me.Controls.Add(Me.quitbtn)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.usernamebox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.afkwheel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents usernamebox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents quitbtn As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents loginbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents afkwheel As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents luckyspin_title As Label
    Friend WithEvents remember_radio As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
End Class
