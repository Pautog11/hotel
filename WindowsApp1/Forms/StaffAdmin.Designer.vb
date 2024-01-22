<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffAdmin
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffAdmin))
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.txtstaffname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtstaffphone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtstaffcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnAddstaffAdmin = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.StaffDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbroomass = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnReserveAdmin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2PictureBox15 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BtnRoomAdmin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Gray
        Me.Guna2ShadowPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtstaffname)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label8)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtstaffphone)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label9)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtstaffcode)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label10)
        Me.Guna2ShadowPanel1.Controls.Add(Me.BtnAddstaffAdmin)
        Me.Guna2ShadowPanel1.Controls.Add(Me.PictureBox3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2TextBox3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label7)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2Separator3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.StaffDGV)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label6)
        Me.Guna2ShadowPanel1.Controls.Add(Me.cmbroomass)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label5)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2Separator1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.PictureBox2)
        Me.Guna2ShadowPanel1.Controls.Add(Me.PictureBox1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label1)
        Me.Guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(165, 0)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(642, 450)
        Me.Guna2ShadowPanel1.TabIndex = 42
        '
        'txtstaffname
        '
        Me.txtstaffname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtstaffname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtstaffname.DefaultText = ""
        Me.txtstaffname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtstaffname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtstaffname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtstaffname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtstaffname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstaffname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtstaffname.ForeColor = System.Drawing.Color.Black
        Me.txtstaffname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstaffname.Location = New System.Drawing.Point(140, 117)
        Me.txtstaffname.Name = "txtstaffname"
        Me.txtstaffname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtstaffname.PlaceholderText = ""
        Me.txtstaffname.SelectedText = ""
        Me.txtstaffname.Size = New System.Drawing.Size(166, 21)
        Me.txtstaffname.TabIndex = 107
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(39, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 17)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "PHONE NO:"
        '
        'txtstaffphone
        '
        Me.txtstaffphone.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtstaffphone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtstaffphone.DefaultText = ""
        Me.txtstaffphone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtstaffphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtstaffphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtstaffphone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtstaffphone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstaffphone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtstaffphone.ForeColor = System.Drawing.Color.Black
        Me.txtstaffphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstaffphone.Location = New System.Drawing.Point(140, 144)
        Me.txtstaffphone.Name = "txtstaffphone"
        Me.txtstaffphone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtstaffphone.PlaceholderText = ""
        Me.txtstaffphone.SelectedText = ""
        Me.txtstaffphone.Size = New System.Drawing.Size(166, 21)
        Me.txtstaffphone.TabIndex = 105
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(39, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 17)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "STAFF'S CODE:"
        '
        'txtstaffcode
        '
        Me.txtstaffcode.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtstaffcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtstaffcode.DefaultText = ""
        Me.txtstaffcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtstaffcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtstaffcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtstaffcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtstaffcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstaffcode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtstaffcode.ForeColor = System.Drawing.Color.Black
        Me.txtstaffcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstaffcode.Location = New System.Drawing.Point(140, 90)
        Me.txtstaffcode.Name = "txtstaffcode"
        Me.txtstaffcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtstaffcode.PlaceholderText = ""
        Me.txtstaffcode.SelectedText = ""
        Me.txtstaffcode.Size = New System.Drawing.Size(74, 21)
        Me.txtstaffcode.TabIndex = 103
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(38, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 17)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "STAFF'S NAME:"
        '
        'BtnAddstaffAdmin
        '
        Me.BtnAddstaffAdmin.BackColor = System.Drawing.Color.Transparent
        Me.BtnAddstaffAdmin.BorderThickness = 2
        Me.BtnAddstaffAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAddstaffAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAddstaffAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAddstaffAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAddstaffAdmin.FillColor = System.Drawing.Color.Goldenrod
        Me.BtnAddstaffAdmin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddstaffAdmin.ForeColor = System.Drawing.Color.White
        Me.BtnAddstaffAdmin.Location = New System.Drawing.Point(521, 87)
        Me.BtnAddstaffAdmin.Name = "BtnAddstaffAdmin"
        Me.BtnAddstaffAdmin.Size = New System.Drawing.Size(85, 23)
        Me.BtnAddstaffAdmin.TabIndex = 52
        Me.BtnAddstaffAdmin.Text = "ADD"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.HotelReservationSystem.My.Resources.Resources.room_key
        Me.PictureBox3.Location = New System.Drawing.Point(578, 233)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 21)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 44
        Me.PictureBox3.TabStop = False
        '
        'Guna2TextBox3
        '
        Me.Guna2TextBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox3.DefaultText = ""
        Me.Guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox3.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.Location = New System.Drawing.Point(442, 234)
        Me.Guna2TextBox3.Name = "Guna2TextBox3"
        Me.Guna2TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox3.PlaceholderText = ""
        Me.Guna2TextBox3.SelectedText = ""
        Me.Guna2TextBox3.Size = New System.Drawing.Size(135, 21)
        Me.Guna2TextBox3.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(225, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 24)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "STAFF'S LIST"
        '
        'Guna2Separator3
        '
        Me.Guna2Separator3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator3.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Separator3.Location = New System.Drawing.Point(21, 221)
        Me.Guna2Separator3.Name = "Guna2Separator3"
        Me.Guna2Separator3.Size = New System.Drawing.Size(597, 10)
        Me.Guna2Separator3.TabIndex = 41
        '
        'StaffDGV
        '
        Me.StaffDGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.StaffDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.StaffDGV.BackgroundColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StaffDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.StaffDGV.ColumnHeadersHeight = 4
        Me.StaffDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StaffDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.StaffDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StaffDGV.Location = New System.Drawing.Point(21, 271)
        Me.StaffDGV.Name = "StaffDGV"
        Me.StaffDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StaffDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.StaffDGV.RowHeadersVisible = False
        Me.StaffDGV.Size = New System.Drawing.Size(597, 166)
        Me.StaffDGV.TabIndex = 40
        Me.StaffDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.StaffDGV.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.StaffDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Blue
        Me.StaffDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.StaffDGV.ThemeStyle.BackColor = System.Drawing.Color.Gray
        Me.StaffDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StaffDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Silver
        Me.StaffDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.StaffDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.StaffDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.StaffDGV.ThemeStyle.HeaderStyle.Height = 4
        Me.StaffDGV.ThemeStyle.ReadOnly = False
        Me.StaffDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.StaffDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.StaffDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.StaffDGV.ThemeStyle.RowsStyle.Height = 22
        Me.StaffDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Blue
        Me.StaffDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
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
        'cmbroomass
        '
        Me.cmbroomass.FormattingEnabled = True
        Me.cmbroomass.Items.AddRange(New Object() {"101", "102", "103", "104", "201", "202", "203", "204", "301", "302", "303", "304", "401", "402", "403", "404", "501", "502", "503", "504", "601", "602", "603", "604", "701", "702", "703", "704", "801", "802", "803", "804"})
        Me.cmbroomass.Location = New System.Drawing.Point(369, 110)
        Me.cmbroomass.Name = "cmbroomass"
        Me.cmbroomass.Size = New System.Drawing.Size(88, 21)
        Me.cmbroomass.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(339, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 17)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "ROOM ASSIGNED:"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Separator1.Location = New System.Drawing.Point(21, 69)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(597, 10)
        Me.Guna2Separator1.TabIndex = 32
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.HotelReservationSystem.My.Resources.Resources.room_key
        Me.PictureBox2.Location = New System.Drawing.Point(578, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.HotelReservationSystem.My.Resources.Resources.room_key
        Me.PictureBox1.Location = New System.Drawing.Point(21, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(83, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(477, 30)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "GOLDSBERG HOTEL DAY AND NIGHT"
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator2.FillColor = System.Drawing.Color.Gray
        Me.Guna2Separator2.FillThickness = 2
        Me.Guna2Separator2.Location = New System.Drawing.Point(13, 94)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(150, 10)
        Me.Guna2Separator2.TabIndex = 79
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(28, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 19)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "ADMIN STAFF"
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
        Me.BtnReserveAdmin.Location = New System.Drawing.Point(17, 224)
        Me.BtnReserveAdmin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnReserveAdmin.Name = "BtnReserveAdmin"
        Me.BtnReserveAdmin.Size = New System.Drawing.Size(135, 44)
        Me.BtnReserveAdmin.TabIndex = 83
        Me.BtnReserveAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.HotelReservationSystem.My.Resources.Resources.background6
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 450)
        Me.Panel1.TabIndex = 80
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
        Me.Guna2PictureBox15.TabIndex = 77
        Me.Guna2PictureBox15.TabStop = False
        Me.Guna2PictureBox15.UseTransparentBackground = True
        '
        'BtnRoomAdmin
        '
        Me.BtnRoomAdmin.ActiveBorderThickness = 1
        Me.BtnRoomAdmin.ActiveCornerRadius = 20
        Me.BtnRoomAdmin.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BtnRoomAdmin.ActiveForecolor = System.Drawing.Color.White
        Me.BtnRoomAdmin.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BtnRoomAdmin.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnRoomAdmin.BackgroundImage = CType(resources.GetObject("BtnRoomAdmin.BackgroundImage"), System.Drawing.Image)
        Me.BtnRoomAdmin.ButtonText = "ROOMS"
        Me.BtnRoomAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRoomAdmin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRoomAdmin.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnRoomAdmin.IdleBorderThickness = 2
        Me.BtnRoomAdmin.IdleCornerRadius = 20
        Me.BtnRoomAdmin.IdleFillColor = System.Drawing.Color.Transparent
        Me.BtnRoomAdmin.IdleForecolor = System.Drawing.Color.White
        Me.BtnRoomAdmin.IdleLineColor = System.Drawing.Color.Black
        Me.BtnRoomAdmin.Location = New System.Drawing.Point(18, 170)
        Me.BtnRoomAdmin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnRoomAdmin.Name = "BtnRoomAdmin"
        Me.BtnRoomAdmin.Size = New System.Drawing.Size(135, 44)
        Me.BtnRoomAdmin.TabIndex = 78
        Me.BtnRoomAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StaffAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(807, 450)
        Me.Controls.Add(Me.BtnReserveAdmin)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Separator2)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.Guna2PictureBox15)
        Me.Controls.Add(Me.BtnRoomAdmin)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StaffAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StaffAdmin"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents BtnAddstaffAdmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents StaffDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbroomass As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2PictureBox15 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BtnRoomAdmin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnReserveAdmin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtstaffname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtstaffphone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtstaffcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
End Class
