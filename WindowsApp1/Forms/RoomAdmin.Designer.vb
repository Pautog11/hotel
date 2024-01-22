<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoomAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RoomAdmin))
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpcheckin = New System.Windows.Forms.DateTimePicker()
        Me.dtpcheckout = New System.Windows.Forms.DateTimePicker()
        Me.txtbalance = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btncompute = New Guna.UI2.WinForms.Guna2Button()
        Me.txtdp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtroomrate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2TextBox7 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbtype = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Guna2TextBox6 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Guna2TextBox5 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnReserveAdmin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2PictureBox15 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BtnStaffAdmin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.Guna2PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator2.FillColor = System.Drawing.Color.Gray
        Me.Guna2Separator2.FillThickness = 2
        Me.Guna2Separator2.Location = New System.Drawing.Point(13, 94)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(150, 10)
        Me.Guna2Separator2.TabIndex = 75
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 19)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "ADMIN ROOM"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Gray
        Me.Guna2ShadowPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Guna2ShadowPanel1.Controls.Add(Me.GroupBox3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtbalance)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label11)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btncompute)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtdp)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label4)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtroomrate)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label8)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label6)
        Me.Guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(178, 0)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(767, 526)
        Me.Guna2ShadowPanel1.TabIndex = 85
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.dtpcheckin)
        Me.GroupBox3.Controls.Add(Me.dtpcheckout)
        Me.GroupBox3.Location = New System.Drawing.Point(401, 34)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(342, 87)
        Me.GroupBox3.TabIndex = 136
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Check In/Check Out:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "To:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-3, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "From:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(266, 41)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(57, 20)
        Me.NumericUpDown1.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(250, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Day(s) to Stay:"
        '
        'dtpcheckin
        '
        Me.dtpcheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpcheckin.Location = New System.Drawing.Point(41, 22)
        Me.dtpcheckin.Name = "dtpcheckin"
        Me.dtpcheckin.Size = New System.Drawing.Size(187, 20)
        Me.dtpcheckin.TabIndex = 65
        '
        'dtpcheckout
        '
        Me.dtpcheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpcheckout.Location = New System.Drawing.Point(41, 52)
        Me.dtpcheckout.Name = "dtpcheckout"
        Me.dtpcheckout.Size = New System.Drawing.Size(187, 20)
        Me.dtpcheckout.TabIndex = 64
        '
        'txtbalance
        '
        Me.txtbalance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbalance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbalance.DefaultText = ""
        Me.txtbalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbalance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbalance.ForeColor = System.Drawing.Color.Black
        Me.txtbalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbalance.Location = New System.Drawing.Point(580, 233)
        Me.txtbalance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbalance.PlaceholderText = ""
        Me.txtbalance.SelectedText = ""
        Me.txtbalance.Size = New System.Drawing.Size(148, 21)
        Me.txtbalance.TabIndex = 142
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(456, 234)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 17)
        Me.Label11.TabIndex = 141
        Me.Label11.Text = "Balance Payment:"
        '
        'btncompute
        '
        Me.btncompute.BackColor = System.Drawing.Color.Transparent
        Me.btncompute.BorderThickness = 2
        Me.btncompute.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btncompute.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btncompute.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btncompute.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btncompute.FillColor = System.Drawing.Color.Goldenrod
        Me.btncompute.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncompute.ForeColor = System.Drawing.Color.White
        Me.btncompute.Location = New System.Drawing.Point(503, 139)
        Me.btncompute.Name = "btncompute"
        Me.btncompute.Size = New System.Drawing.Size(182, 23)
        Me.btncompute.TabIndex = 135
        Me.btncompute.Text = "COMPUTE CHARGES"
        '
        'txtdp
        '
        Me.txtdp.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtdp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdp.DefaultText = ""
        Me.txtdp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtdp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtdp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdp.ForeColor = System.Drawing.Color.Black
        Me.txtdp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdp.Location = New System.Drawing.Point(580, 208)
        Me.txtdp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdp.Name = "txtdp"
        Me.txtdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdp.PlaceholderText = ""
        Me.txtdp.SelectedText = ""
        Me.txtdp.Size = New System.Drawing.Size(148, 21)
        Me.txtdp.TabIndex = 140
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(394, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 17)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "[Less] Downpayment (15%):"
        '
        'txtroomrate
        '
        Me.txtroomrate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtroomrate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtroomrate.DefaultText = ""
        Me.txtroomrate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtroomrate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtroomrate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtroomrate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtroomrate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtroomrate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtroomrate.ForeColor = System.Drawing.Color.Black
        Me.txtroomrate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtroomrate.Location = New System.Drawing.Point(580, 178)
        Me.txtroomrate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtroomrate.Name = "txtroomrate"
        Me.txtroomrate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtroomrate.PlaceholderText = ""
        Me.txtroomrate.SelectedText = ""
        Me.txtroomrate.Size = New System.Drawing.Size(148, 21)
        Me.txtroomrate.TabIndex = 138
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(454, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 17)
        Me.Label8.TabIndex = 137
        Me.Label8.Text = "Total Room Rate:"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2TextBox7)
        Me.Guna2GroupBox1.Controls.Add(Me.cmbtype)
        Me.Guna2GroupBox1.Controls.Add(Me.Label14)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2TextBox6)
        Me.Guna2GroupBox1.Controls.Add(Me.Label13)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2TextBox5)
        Me.Guna2GroupBox1.Controls.Add(Me.Label12)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button1)
        Me.Guna2GroupBox1.Controls.Add(Me.Label10)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2TextBox3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2TextBox2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Goldenrod
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(26, 27)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(360, 471)
        Me.Guna2GroupBox1.TabIndex = 129
        Me.Guna2GroupBox1.Text = "GUEST'S INVOICE:"
        '
        'Guna2TextBox7
        '
        Me.Guna2TextBox7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox7.DefaultText = ""
        Me.Guna2TextBox7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox7.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox7.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox7.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox7.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox7.Location = New System.Drawing.Point(34, 329)
        Me.Guna2TextBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox7.Name = "Guna2TextBox7"
        Me.Guna2TextBox7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox7.PlaceholderText = ""
        Me.Guna2TextBox7.SelectedText = ""
        Me.Guna2TextBox7.Size = New System.Drawing.Size(292, 31)
        Me.Guna2TextBox7.TabIndex = 150
        '
        'cmbtype
        '
        Me.cmbtype.BackColor = System.Drawing.Color.Transparent
        Me.cmbtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtype.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbtype.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbtype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbtype.ItemHeight = 30
        Me.cmbtype.Location = New System.Drawing.Point(34, 132)
        Me.cmbtype.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.Size = New System.Drawing.Size(293, 36)
        Me.cmbtype.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(20, 309)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 17)
        Me.Label14.TabIndex = 149
        Me.Label14.Text = "NO. OF PAX:"
        '
        'Guna2TextBox6
        '
        Me.Guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox6.DefaultText = ""
        Me.Guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox6.Location = New System.Drawing.Point(34, 259)
        Me.Guna2TextBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox6.Name = "Guna2TextBox6"
        Me.Guna2TextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox6.PlaceholderText = ""
        Me.Guna2TextBox6.SelectedText = ""
        Me.Guna2TextBox6.Size = New System.Drawing.Size(292, 31)
        Me.Guna2TextBox6.TabIndex = 148
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 239)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 17)
        Me.Label13.TabIndex = 147
        Me.Label13.Text = "RATE PER DAY:"
        '
        'Guna2TextBox5
        '
        Me.Guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox5.DefaultText = ""
        Me.Guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox5.Location = New System.Drawing.Point(35, 204)
        Me.Guna2TextBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox5.Name = "Guna2TextBox5"
        Me.Guna2TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox5.PlaceholderText = ""
        Me.Guna2TextBox5.SelectedText = ""
        Me.Guna2TextBox5.Size = New System.Drawing.Size(292, 31)
        Me.Guna2TextBox5.TabIndex = 146
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 178)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 17)
        Me.Label12.TabIndex = 145
        Me.Label12.Text = "ROOM NUMBER:"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderThickness = 2
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Goldenrod
        Me.Guna2Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(92, 415)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(182, 37)
        Me.Guna2Button1.TabIndex = 143
        Me.Guna2Button1.Text = "SAVE ROOM RESERVATION"
        '
        'Guna2TextBox3
        '
        Me.Guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox3.DefaultText = ""
        Me.Guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.Location = New System.Drawing.Point(11, 102)
        Me.Guna2TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox3.Name = "Guna2TextBox3"
        Me.Guna2TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox3.PlaceholderText = ""
        Me.Guna2TextBox3.SelectedText = ""
        Me.Guna2TextBox3.Size = New System.Drawing.Size(333, 301)
        Me.Guna2TextBox3.TabIndex = 131
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "GUEST'S CODE:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox2.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Location = New System.Drawing.Point(115, 45)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderText = ""
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(96, 21)
        Me.Guna2TextBox2.TabIndex = 130
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "GUEST'S NAME:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(115, 73)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(211, 21)
        Me.Guna2TextBox1.TabIndex = 117
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(527, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 17)
        Me.Label6.TabIndex = 39
        '
        'BtnReserveAdmin
        '
        Me.BtnReserveAdmin.ActiveBorderThickness = 1
        Me.BtnReserveAdmin.ActiveCornerRadius = 20
        Me.BtnReserveAdmin.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BtnReserveAdmin.ActiveForecolor = System.Drawing.Color.White
        Me.BtnReserveAdmin.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BtnReserveAdmin.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnReserveAdmin.BackgroundImage = CType(resources.GetObject("BtnReserveAdmin.BackgroundImage"), System.Drawing.Image)
        Me.BtnReserveAdmin.ButtonText = "RESERVATIONS"
        Me.BtnReserveAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReserveAdmin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReserveAdmin.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnReserveAdmin.IdleBorderThickness = 2
        Me.BtnReserveAdmin.IdleCornerRadius = 20
        Me.BtnReserveAdmin.IdleFillColor = System.Drawing.Color.Transparent
        Me.BtnReserveAdmin.IdleForecolor = System.Drawing.Color.White
        Me.BtnReserveAdmin.IdleLineColor = System.Drawing.Color.Black
        Me.BtnReserveAdmin.Location = New System.Drawing.Point(17, 225)
        Me.BtnReserveAdmin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnReserveAdmin.Name = "BtnReserveAdmin"
        Me.BtnReserveAdmin.Size = New System.Drawing.Size(135, 44)
        Me.BtnReserveAdmin.TabIndex = 84
        Me.BtnReserveAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.HotelReservationSystem.My.Resources.Resources.background6
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 526)
        Me.Panel1.TabIndex = 76
        '
        'Guna2PictureBox15
        '
        Me.Guna2PictureBox15.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox15.Image = Global.HotelReservationSystem.My.Resources.Resources.background4
        Me.Guna2PictureBox15.ImageRotate = 0!
        Me.Guna2PictureBox15.Location = New System.Drawing.Point(-17, -11)
        Me.Guna2PictureBox15.Name = "Guna2PictureBox15"
        Me.Guna2PictureBox15.Size = New System.Drawing.Size(216, 121)
        Me.Guna2PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox15.TabIndex = 70
        Me.Guna2PictureBox15.TabStop = False
        Me.Guna2PictureBox15.UseTransparentBackground = True
        '
        'BtnStaffAdmin
        '
        Me.BtnStaffAdmin.ActiveBorderThickness = 1
        Me.BtnStaffAdmin.ActiveCornerRadius = 20
        Me.BtnStaffAdmin.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BtnStaffAdmin.ActiveForecolor = System.Drawing.Color.White
        Me.BtnStaffAdmin.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BtnStaffAdmin.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnStaffAdmin.BackgroundImage = CType(resources.GetObject("BtnStaffAdmin.BackgroundImage"), System.Drawing.Image)
        Me.BtnStaffAdmin.ButtonText = "STAFFS"
        Me.BtnStaffAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStaffAdmin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStaffAdmin.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnStaffAdmin.IdleBorderThickness = 2
        Me.BtnStaffAdmin.IdleCornerRadius = 20
        Me.BtnStaffAdmin.IdleFillColor = System.Drawing.Color.Transparent
        Me.BtnStaffAdmin.IdleForecolor = System.Drawing.Color.White
        Me.BtnStaffAdmin.IdleLineColor = System.Drawing.Color.Black
        Me.BtnStaffAdmin.Location = New System.Drawing.Point(17, 170)
        Me.BtnStaffAdmin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnStaffAdmin.Name = "BtnStaffAdmin"
        Me.BtnStaffAdmin.Size = New System.Drawing.Size(135, 44)
        Me.BtnStaffAdmin.TabIndex = 71
        Me.BtnStaffAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 17)
        Me.Label10.TabIndex = 132
        Me.Label10.Text = "ROOM TYPE:"
        '
        'RoomAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(945, 526)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.BtnReserveAdmin)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Separator2)
        Me.Controls.Add(Me.Guna2PictureBox15)
        Me.Controls.Add(Me.BtnStaffAdmin)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RoomAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RoomAdmin"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.Guna2PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2PictureBox15 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnStaffAdmin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnReserveAdmin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox

    Private Sub btncompute_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2ShadowPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2ShadowPanel1.Paint

    End Sub

    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbalance As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btncompute As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtdp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtroomrate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpcheckin As DateTimePicker
    Friend WithEvents dtpcheckout As DateTimePicker

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub txtbalance_TextChanged(sender As Object, e As EventArgs) Handles txtbalance.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtdp_TextChanged(sender As Object, e As EventArgs) Handles txtdp.TextChanged

    End Sub

    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button

    Private Sub btncompute_Click_1(sender As Object, e As EventArgs) Handles btncompute.Click

    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub


    Friend WithEvents Guna2TextBox7 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Guna2TextBox6 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Guna2TextBox5 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)

    End Sub


    Friend WithEvents cmbtype As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label10 As Label
End Class
