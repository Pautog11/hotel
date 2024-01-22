<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rooms
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rooms))
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.txtclientID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ReservationDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnGuestR = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnAdminR = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnReservationR = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnStaffR = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Guna2PictureBox15 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnUpdatersrvAdmin = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDeletersrvAdmin = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.ReservationDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator2.FillColor = System.Drawing.Color.Gray
        Me.Guna2Separator2.FillThickness = 2
        Me.Guna2Separator2.Location = New System.Drawing.Point(14, 97)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(144, 10)
        Me.Guna2Separator2.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(22, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 38)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "       ROOM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RESERVATION"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Gray
        Me.Guna2ShadowPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.BtnUpdatersrvAdmin)
        Me.Guna2ShadowPanel1.Controls.Add(Me.BtnDeletersrvAdmin)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtclientID)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label10)
        Me.Guna2ShadowPanel1.Controls.Add(Me.ReservationDGV)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label6)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2Separator1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.PictureBox2)
        Me.Guna2ShadowPanel1.Controls.Add(Me.PictureBox1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label2)
        Me.Guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(165, 0)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(642, 450)
        Me.Guna2ShadowPanel1.TabIndex = 64
        '
        'txtclientID
        '
        Me.txtclientID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtclientID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtclientID.DefaultText = ""
        Me.txtclientID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtclientID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtclientID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtclientID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtclientID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtclientID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtclientID.ForeColor = System.Drawing.Color.Black
        Me.txtclientID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtclientID.Location = New System.Drawing.Point(266, 112)
        Me.txtclientID.Name = "txtclientID"
        Me.txtclientID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtclientID.PlaceholderText = ""
        Me.txtclientID.SelectedText = ""
        Me.txtclientID.Size = New System.Drawing.Size(105, 21)
        Me.txtclientID.TabIndex = 101
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(176, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 17)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "GUEST CODE:"
        '
        'ReservationDGV
        '
        Me.ReservationDGV.AllowUserToDeleteRows = False
        Me.ReservationDGV.AllowUserToResizeColumns = False
        Me.ReservationDGV.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.ReservationDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.ReservationDGV.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReservationDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.ReservationDGV.ColumnHeadersHeight = 27
        Me.ReservationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ReservationDGV.DefaultCellStyle = DataGridViewCellStyle7
        Me.ReservationDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReservationDGV.Location = New System.Drawing.Point(21, 165)
        Me.ReservationDGV.Name = "ReservationDGV"
        Me.ReservationDGV.ReadOnly = True
        Me.ReservationDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReservationDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.ReservationDGV.RowHeadersVisible = False
        Me.ReservationDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ReservationDGV.Size = New System.Drawing.Size(598, 263)
        Me.ReservationDGV.TabIndex = 96
        Me.ReservationDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver
        Me.ReservationDGV.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservationDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ReservationDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ReservationDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.ReservationDGV.ThemeStyle.BackColor = System.Drawing.Color.DimGray
        Me.ReservationDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReservationDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ReservationDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ReservationDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservationDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.ReservationDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.ReservationDGV.ThemeStyle.HeaderStyle.Height = 27
        Me.ReservationDGV.ThemeStyle.ReadOnly = True
        Me.ReservationDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Silver
        Me.ReservationDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ReservationDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservationDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.ReservationDGV.ThemeStyle.RowsStyle.Height = 22
        Me.ReservationDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ReservationDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(83, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(477, 30)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "GOLDSBERG HOTEL DAY AND NIGHT"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.HotelReservationSystem.My.Resources.Resources.background6
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 450)
        Me.Panel2.TabIndex = 63
        '
        'BtnGuestR
        '
        Me.BtnGuestR.ActiveBorderThickness = 1
        Me.BtnGuestR.ActiveCornerRadius = 20
        Me.BtnGuestR.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BtnGuestR.ActiveForecolor = System.Drawing.Color.White
        Me.BtnGuestR.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BtnGuestR.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnGuestR.BackgroundImage = CType(resources.GetObject("BtnGuestR.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuestR.ButtonText = "GUESTS"
        Me.BtnGuestR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuestR.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuestR.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnGuestR.IdleBorderThickness = 2
        Me.BtnGuestR.IdleCornerRadius = 20
        Me.BtnGuestR.IdleFillColor = System.Drawing.Color.Transparent
        Me.BtnGuestR.IdleForecolor = System.Drawing.Color.White
        Me.BtnGuestR.IdleLineColor = System.Drawing.Color.Black
        Me.BtnGuestR.Location = New System.Drawing.Point(17, 274)
        Me.BtnGuestR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnGuestR.Name = "BtnGuestR"
        Me.BtnGuestR.Size = New System.Drawing.Size(135, 44)
        Me.BtnGuestR.TabIndex = 60
        Me.BtnGuestR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnAdminR
        '
        Me.BtnAdminR.ActiveBorderThickness = 1
        Me.BtnAdminR.ActiveCornerRadius = 20
        Me.BtnAdminR.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BtnAdminR.ActiveForecolor = System.Drawing.Color.White
        Me.BtnAdminR.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BtnAdminR.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnAdminR.BackgroundImage = CType(resources.GetObject("BtnAdminR.BackgroundImage"), System.Drawing.Image)
        Me.BtnAdminR.ButtonText = "ADMINS"
        Me.BtnAdminR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdminR.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdminR.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnAdminR.IdleBorderThickness = 2
        Me.BtnAdminR.IdleCornerRadius = 20
        Me.BtnAdminR.IdleFillColor = System.Drawing.Color.Transparent
        Me.BtnAdminR.IdleForecolor = System.Drawing.Color.White
        Me.BtnAdminR.IdleLineColor = System.Drawing.Color.Black
        Me.BtnAdminR.Location = New System.Drawing.Point(17, 328)
        Me.BtnAdminR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAdminR.Name = "BtnAdminR"
        Me.BtnAdminR.Size = New System.Drawing.Size(135, 44)
        Me.BtnAdminR.TabIndex = 59
        Me.BtnAdminR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnReservationR
        '
        Me.BtnReservationR.ActiveBorderThickness = 1
        Me.BtnReservationR.ActiveCornerRadius = 20
        Me.BtnReservationR.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BtnReservationR.ActiveForecolor = System.Drawing.Color.White
        Me.BtnReservationR.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BtnReservationR.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnReservationR.BackgroundImage = CType(resources.GetObject("BtnReservationR.BackgroundImage"), System.Drawing.Image)
        Me.BtnReservationR.ButtonText = "RESERVATIONS"
        Me.BtnReservationR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReservationR.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReservationR.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnReservationR.IdleBorderThickness = 2
        Me.BtnReservationR.IdleCornerRadius = 20
        Me.BtnReservationR.IdleFillColor = System.Drawing.Color.Transparent
        Me.BtnReservationR.IdleForecolor = System.Drawing.Color.White
        Me.BtnReservationR.IdleLineColor = System.Drawing.Color.Black
        Me.BtnReservationR.Location = New System.Drawing.Point(17, 166)
        Me.BtnReservationR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnReservationR.Name = "BtnReservationR"
        Me.BtnReservationR.Size = New System.Drawing.Size(135, 44)
        Me.BtnReservationR.TabIndex = 58
        Me.BtnReservationR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnStaffR
        '
        Me.BtnStaffR.ActiveBorderThickness = 1
        Me.BtnStaffR.ActiveCornerRadius = 20
        Me.BtnStaffR.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BtnStaffR.ActiveForecolor = System.Drawing.Color.White
        Me.BtnStaffR.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BtnStaffR.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnStaffR.BackgroundImage = CType(resources.GetObject("BtnStaffR.BackgroundImage"), System.Drawing.Image)
        Me.BtnStaffR.ButtonText = "STAFFS"
        Me.BtnStaffR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStaffR.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStaffR.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnStaffR.IdleBorderThickness = 2
        Me.BtnStaffR.IdleCornerRadius = 20
        Me.BtnStaffR.IdleFillColor = System.Drawing.Color.Transparent
        Me.BtnStaffR.IdleForecolor = System.Drawing.Color.White
        Me.BtnStaffR.IdleLineColor = System.Drawing.Color.Black
        Me.BtnStaffR.Location = New System.Drawing.Point(17, 220)
        Me.BtnStaffR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnStaffR.Name = "BtnStaffR"
        Me.BtnStaffR.Size = New System.Drawing.Size(135, 44)
        Me.BtnStaffR.TabIndex = 57
        Me.BtnStaffR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Guna2PictureBox15.TabIndex = 56
        Me.Guna2PictureBox15.TabStop = False
        Me.Guna2PictureBox15.UseTransparentBackground = True
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
        Me.Guna2Button1.Location = New System.Drawing.Point(21, 110)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(97, 23)
        Me.Guna2Button1.TabIndex = 105
        Me.Guna2Button1.Text = "UPDATE"
        '
        'BtnUpdatersrvAdmin
        '
        Me.BtnUpdatersrvAdmin.BackColor = System.Drawing.Color.Transparent
        Me.BtnUpdatersrvAdmin.BorderThickness = 2
        Me.BtnUpdatersrvAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnUpdatersrvAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnUpdatersrvAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUpdatersrvAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnUpdatersrvAdmin.FillColor = System.Drawing.Color.Goldenrod
        Me.BtnUpdatersrvAdmin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdatersrvAdmin.ForeColor = System.Drawing.Color.White
        Me.BtnUpdatersrvAdmin.Location = New System.Drawing.Point(512, 90)
        Me.BtnUpdatersrvAdmin.Name = "BtnUpdatersrvAdmin"
        Me.BtnUpdatersrvAdmin.Size = New System.Drawing.Size(97, 23)
        Me.BtnUpdatersrvAdmin.TabIndex = 104
        Me.BtnUpdatersrvAdmin.Text = "REFRESH"
        '
        'BtnDeletersrvAdmin
        '
        Me.BtnDeletersrvAdmin.BackColor = System.Drawing.Color.Transparent
        Me.BtnDeletersrvAdmin.BorderThickness = 2
        Me.BtnDeletersrvAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDeletersrvAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDeletersrvAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDeletersrvAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDeletersrvAdmin.FillColor = System.Drawing.Color.Goldenrod
        Me.BtnDeletersrvAdmin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeletersrvAdmin.ForeColor = System.Drawing.Color.White
        Me.BtnDeletersrvAdmin.Location = New System.Drawing.Point(512, 123)
        Me.BtnDeletersrvAdmin.Name = "BtnDeletersrvAdmin"
        Me.BtnDeletersrvAdmin.Size = New System.Drawing.Size(97, 23)
        Me.BtnDeletersrvAdmin.TabIndex = 103
        Me.BtnDeletersrvAdmin.Text = "DELETE"
        '
        'Rooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(807, 450)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Guna2Separator2)
        Me.Controls.Add(Me.BtnGuestR)
        Me.Controls.Add(Me.BtnAdminR)
        Me.Controls.Add(Me.BtnReservationR)
        Me.Controls.Add(Me.BtnStaffR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Guna2PictureBox15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Rooms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rooms"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.ReservationDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents BtnGuestR As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnAdminR As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnReservationR As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnStaffR As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2PictureBox15 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents txtclientID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ReservationDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnUpdatersrvAdmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDeletersrvAdmin As Guna.UI2.WinForms.Guna2Button
End Class
