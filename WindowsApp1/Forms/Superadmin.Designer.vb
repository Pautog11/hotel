<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Superadmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Superadmin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsuperadminPass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtsuperadminID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BtnLogin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Separator7 = New Guna.UI2.WinForms.Guna2Separator()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Guna2PictureBox15 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbladmin = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.HotelReservationSystem.My.Resources.Resources.background6
        Me.Panel1.Controls.Add(Me.lbladmin)
        Me.Panel1.Controls.Add(Me.Guna2PictureBox15)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(96, 286)
        Me.Panel1.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 14)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "PASSWORD:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 14)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "ADMIN ID:"
        '
        'txtsuperadminPass
        '
        Me.txtsuperadminPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsuperadminPass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtsuperadminPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtsuperadminPass.HintForeColor = System.Drawing.Color.Empty
        Me.txtsuperadminPass.HintText = ""
        Me.txtsuperadminPass.isPassword = True
        Me.txtsuperadminPass.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtsuperadminPass.LineIdleColor = System.Drawing.Color.Black
        Me.txtsuperadminPass.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtsuperadminPass.LineThickness = 3
        Me.txtsuperadminPass.Location = New System.Drawing.Point(113, 145)
        Me.txtsuperadminPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsuperadminPass.Name = "txtsuperadminPass"
        Me.txtsuperadminPass.Size = New System.Drawing.Size(205, 37)
        Me.txtsuperadminPass.TabIndex = 28
        Me.txtsuperadminPass.Text = "Password"
        Me.txtsuperadminPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtsuperadminID
        '
        Me.txtsuperadminID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsuperadminID.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtsuperadminID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtsuperadminID.HintForeColor = System.Drawing.Color.Empty
        Me.txtsuperadminID.HintText = ""
        Me.txtsuperadminID.isPassword = False
        Me.txtsuperadminID.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtsuperadminID.LineIdleColor = System.Drawing.Color.Black
        Me.txtsuperadminID.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtsuperadminID.LineThickness = 3
        Me.txtsuperadminID.Location = New System.Drawing.Point(113, 74)
        Me.txtsuperadminID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsuperadminID.Name = "txtsuperadminID"
        Me.txtsuperadminID.Size = New System.Drawing.Size(205, 37)
        Me.txtsuperadminID.TabIndex = 27
        Me.txtsuperadminID.Text = "Username"
        Me.txtsuperadminID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnLogin
        '
        Me.BtnLogin.ActiveBorderThickness = 1
        Me.BtnLogin.ActiveCornerRadius = 20
        Me.BtnLogin.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BtnLogin.ActiveForecolor = System.Drawing.Color.White
        Me.BtnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BtnLogin.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnLogin.BackgroundImage = CType(resources.GetObject("BtnLogin.BackgroundImage"), System.Drawing.Image)
        Me.BtnLogin.ButtonText = "LOGIN"
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.Black
        Me.BtnLogin.IdleBorderThickness = 2
        Me.BtnLogin.IdleCornerRadius = 20
        Me.BtnLogin.IdleFillColor = System.Drawing.Color.White
        Me.BtnLogin.IdleForecolor = System.Drawing.Color.Black
        Me.BtnLogin.IdleLineColor = System.Drawing.Color.Black
        Me.BtnLogin.Location = New System.Drawing.Point(161, 218)
        Me.BtnLogin.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(110, 43)
        Me.BtnLogin.TabIndex = 31
        Me.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HotelReservationSystem.My.Resources.Resources.room_key
        Me.PictureBox1.Location = New System.Drawing.Point(106, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(145, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 22)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "SUPER ADMIN"
        '
        'Guna2Separator7
        '
        Me.Guna2Separator7.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator7.Location = New System.Drawing.Point(101, 43)
        Me.Guna2Separator7.Name = "Guna2Separator7"
        Me.Guna2Separator7.Size = New System.Drawing.Size(230, 10)
        Me.Guna2Separator7.TabIndex = 34
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(116, 189)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox1.TabIndex = 35
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Guna2PictureBox15
        '
        Me.Guna2PictureBox15.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox15.Image = Global.HotelReservationSystem.My.Resources.Resources.background4
        Me.Guna2PictureBox15.ImageRotate = 0!
        Me.Guna2PictureBox15.Location = New System.Drawing.Point(-18, 3)
        Me.Guna2PictureBox15.Name = "Guna2PictureBox15"
        Me.Guna2PictureBox15.Size = New System.Drawing.Size(127, 94)
        Me.Guna2PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox15.TabIndex = 1
        Me.Guna2PictureBox15.TabStop = False
        Me.Guna2PictureBox15.UseTransparentBackground = True
        '
        'lbladmin
        '
        Me.lbladmin.AutoSize = True
        Me.lbladmin.BackColor = System.Drawing.Color.Transparent
        Me.lbladmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladmin.LinkColor = System.Drawing.Color.Red
        Me.lbladmin.Location = New System.Drawing.Point(19, 262)
        Me.lbladmin.Name = "lbladmin"
        Me.lbladmin.Size = New System.Drawing.Size(51, 15)
        Me.lbladmin.TabIndex = 36
        Me.lbladmin.TabStop = True
        Me.lbladmin.Text = "ADMIN"
        Me.lbladmin.VisitedLinkColor = System.Drawing.Color.Red
        '
        'Superadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(335, 286)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Guna2Separator7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtsuperadminPass)
        Me.Controls.Add(Me.txtsuperadminID)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Superadmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Superadmin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtsuperadminPass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtsuperadminID As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BtnLogin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Separator7 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Guna2PictureBox15 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lbladmin As LinkLabel
End Class
