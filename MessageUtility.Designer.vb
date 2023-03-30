<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageUtility
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MessageUtility))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.loginbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.afkwheel = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.messagebox = New System.Windows.Forms.Label()
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
        Me.loginbtn.Location = New System.Drawing.Point(100, 151)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(200, 30)
        Me.loginbtn.TabIndex = 2
        Me.loginbtn.Text = "okay"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.Color.PaleVioletRed
        Me.Guna2Separator1.FillThickness = 2
        Me.Guna2Separator1.Location = New System.Drawing.Point(12, 43)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(376, 12)
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
        Me.afkwheel.Size = New System.Drawing.Size(25, 25)
        Me.afkwheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.afkwheel.TabIndex = 10
        Me.afkwheel.TabStop = False
        Me.afkwheel.UseTransparentBackground = True
        '
        'messagebox
        '
        Me.messagebox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.messagebox.Location = New System.Drawing.Point(12, 58)
        Me.messagebox.Name = "messagebox"
        Me.messagebox.Size = New System.Drawing.Size(376, 90)
        Me.messagebox.TabIndex = 11
        Me.messagebox.Text = "message"
        Me.messagebox.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MessageUtility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.messagebox)
        Me.Controls.Add(Me.afkwheel)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.loginbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MessageUtility"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MessageUtility"
        CType(Me.afkwheel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents loginbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents afkwheel As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents messagebox As Label
End Class
