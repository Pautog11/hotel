<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRateDialog
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
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.COMBOBOXRATETYPE = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TXTBOXRATE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNDELETEROOM = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNADDROOM = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PRICE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel9 = New Guna.UI2.WinForms.Guna2Panel()
        Me.CMBROOMTYPE = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel10 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel6.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel7.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel8.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel9.SuspendLayout()
        Me.Guna2Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.Controls.Add(Me.COMBOBOXRATETYPE)
        Me.Guna2Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel6.Location = New System.Drawing.Point(130, 50)
        Me.Guna2Panel6.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(268, 50)
        Me.Guna2Panel6.TabIndex = 5
        '
        'COMBOBOXRATETYPE
        '
        Me.COMBOBOXRATETYPE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.COMBOBOXRATETYPE.BackColor = System.Drawing.Color.Transparent
        Me.COMBOBOXRATETYPE.DisplayMember = "per_rate"
        Me.COMBOBOXRATETYPE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.COMBOBOXRATETYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COMBOBOXRATETYPE.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.COMBOBOXRATETYPE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.COMBOBOXRATETYPE.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.COMBOBOXRATETYPE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.COMBOBOXRATETYPE.ItemHeight = 30
        Me.COMBOBOXRATETYPE.Location = New System.Drawing.Point(13, 7)
        Me.COMBOBOXRATETYPE.Name = "COMBOBOXRATETYPE"
        Me.COMBOBOXRATETYPE.Size = New System.Drawing.Size(240, 36)
        Me.COMBOBOXRATETYPE.TabIndex = 0
        Me.COMBOBOXRATETYPE.ValueMember = "id"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel7, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(398, 303)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.BackColor = System.Drawing.Color.Goldenrod
        Me.Guna2Panel7.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel7.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.Size = New System.Drawing.Size(398, 49)
        Me.Guna2Panel7.TabIndex = 8
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = Global.HotelReservationSystem.My.Resources.Resources.back_ic
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(87, 49)
        Me.Guna2Button1.TabIndex = 0
        Me.Guna2Button1.Text = "Back"
        Me.Guna2Button1.UseTransparentBackground = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel4, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel6, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel5, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel8, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel3, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel9, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel10, 0, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 49)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(398, 254)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Controls.Add(Me.Label2)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 100)
        Me.Guna2Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(130, 50)
        Me.Guna2Panel4.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PRICE:"
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Controls.Add(Me.Label3)
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel5.Location = New System.Drawing.Point(0, 50)
        Me.Guna2Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(130, 50)
        Me.Guna2Panel5.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 14)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DURATION TYPE:"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(130, 50)
        Me.Guna2Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "RATE:"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.TXTBOXRATE)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(130, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(268, 50)
        Me.Guna2Panel1.TabIndex = 0
        '
        'TXTBOXRATE
        '
        Me.TXTBOXRATE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTBOXRATE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTBOXRATE.DefaultText = ""
        Me.TXTBOXRATE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTBOXRATE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTBOXRATE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTBOXRATE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTBOXRATE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTBOXRATE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTBOXRATE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTBOXRATE.Location = New System.Drawing.Point(13, 8)
        Me.TXTBOXRATE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTBOXRATE.Name = "TXTBOXRATE"
        Me.TXTBOXRATE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTBOXRATE.PlaceholderText = ""
        Me.TXTBOXRATE.SelectedText = ""
        Me.TXTBOXRATE.Size = New System.Drawing.Size(240, 35)
        Me.TXTBOXRATE.TabIndex = 0
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.Controls.Add(Me.BTNDELETEROOM)
        Me.Guna2Panel8.Controls.Add(Me.BTNADDROOM)
        Me.Guna2Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel8.Location = New System.Drawing.Point(130, 200)
        Me.Guna2Panel8.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.Size = New System.Drawing.Size(268, 54)
        Me.Guna2Panel8.TabIndex = 8
        '
        'BTNDELETEROOM
        '
        Me.BTNDELETEROOM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNDELETEROOM.BorderThickness = 1
        Me.BTNDELETEROOM.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNDELETEROOM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNDELETEROOM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNDELETEROOM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNDELETEROOM.FillColor = System.Drawing.Color.Goldenrod
        Me.BTNDELETEROOM.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNDELETEROOM.ForeColor = System.Drawing.Color.White
        Me.BTNDELETEROOM.Location = New System.Drawing.Point(28, 10)
        Me.BTNDELETEROOM.Name = "BTNDELETEROOM"
        Me.BTNDELETEROOM.Size = New System.Drawing.Size(110, 34)
        Me.BTNDELETEROOM.TabIndex = 3
        Me.BTNDELETEROOM.Text = "DELETE"
        Me.BTNDELETEROOM.Visible = False
        '
        'BTNADDROOM
        '
        Me.BTNADDROOM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNADDROOM.BorderThickness = 1
        Me.BTNADDROOM.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNADDROOM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNADDROOM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNADDROOM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNADDROOM.FillColor = System.Drawing.Color.Goldenrod
        Me.BTNADDROOM.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNADDROOM.ForeColor = System.Drawing.Color.White
        Me.BTNADDROOM.Location = New System.Drawing.Point(144, 10)
        Me.BTNADDROOM.Name = "BTNADDROOM"
        Me.BTNADDROOM.Size = New System.Drawing.Size(110, 34)
        Me.BTNADDROOM.TabIndex = 2
        Me.BTNADDROOM.Text = "SAVE"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.PRICE)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel3.Location = New System.Drawing.Point(130, 100)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(268, 50)
        Me.Guna2Panel3.TabIndex = 9
        '
        'PRICE
        '
        Me.PRICE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PRICE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PRICE.DefaultText = ""
        Me.PRICE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PRICE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PRICE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PRICE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PRICE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PRICE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PRICE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PRICE.Location = New System.Drawing.Point(13, 8)
        Me.PRICE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PRICE.Name = "PRICE"
        Me.PRICE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PRICE.PlaceholderText = ""
        Me.PRICE.SelectedText = ""
        Me.PRICE.Size = New System.Drawing.Size(240, 35)
        Me.PRICE.TabIndex = 0
        '
        'Guna2Panel9
        '
        Me.Guna2Panel9.Controls.Add(Me.CMBROOMTYPE)
        Me.Guna2Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel9.Location = New System.Drawing.Point(130, 150)
        Me.Guna2Panel9.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel9.Name = "Guna2Panel9"
        Me.Guna2Panel9.Size = New System.Drawing.Size(268, 50)
        Me.Guna2Panel9.TabIndex = 11
        '
        'CMBROOMTYPE
        '
        Me.CMBROOMTYPE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CMBROOMTYPE.BackColor = System.Drawing.Color.Transparent
        Me.CMBROOMTYPE.DisplayMember = "ROOM TYPE"
        Me.CMBROOMTYPE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBROOMTYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBROOMTYPE.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBROOMTYPE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBROOMTYPE.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CMBROOMTYPE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CMBROOMTYPE.ItemHeight = 30
        Me.CMBROOMTYPE.Location = New System.Drawing.Point(14, 7)
        Me.CMBROOMTYPE.Name = "CMBROOMTYPE"
        Me.CMBROOMTYPE.Size = New System.Drawing.Size(240, 36)
        Me.CMBROOMTYPE.TabIndex = 1
        Me.CMBROOMTYPE.ValueMember = "id"
        '
        'Guna2Panel10
        '
        Me.Guna2Panel10.Controls.Add(Me.Label4)
        Me.Guna2Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel10.Location = New System.Drawing.Point(0, 150)
        Me.Guna2Panel10.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel10.Name = "Guna2Panel10"
        Me.Guna2Panel10.Size = New System.Drawing.Size(130, 50)
        Me.Guna2Panel10.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ROOM TYPE:"
        '
        'AddRateDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 303)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddRateDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AddRateDialog"
        Me.Guna2Panel6.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel7.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel8.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel9.ResumeLayout(False)
        Me.Guna2Panel10.ResumeLayout(False)
        Me.Guna2Panel10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents COMBOBOXRATETYPE As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TXTBOXRATE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNDELETEROOM As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNADDROOM As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PRICE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel9 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CMBROOMTYPE As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Panel10 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As Label
End Class
