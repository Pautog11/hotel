<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservationDialog
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RESERVATIONSTYLE = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.BTNRESERVATION = New Guna.UI2.WinForms.Guna2Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNBACK = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TXTBOXTOTAL = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTBOXINVOICENUMBER = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ROOMSDATAGRIDVIEW = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ADDRESERVATION = New Guna.UI2.WinForms.Guna2Button()
        Me.CMBGUESTS = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TXTBOXPHONE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel7.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.ROOMSDATAGRIDVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'RESERVATIONSTYLE
        '
        Me.RESERVATIONSTYLE.ContainerControl = Me
        Me.RESERVATIONSTYLE.DockIndicatorTransparencyValue = 0.6R
        Me.RESERVATIONSTYLE.TransparentWhileDrag = True
        '
        'BTNRESERVATION
        '
        Me.BTNRESERVATION.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNRESERVATION.BackColor = System.Drawing.Color.Transparent
        Me.BTNRESERVATION.BorderThickness = 2
        Me.BTNRESERVATION.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNRESERVATION.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNRESERVATION.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNRESERVATION.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNRESERVATION.FillColor = System.Drawing.Color.Goldenrod
        Me.BTNRESERVATION.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRESERVATION.ForeColor = System.Drawing.Color.White
        Me.BTNRESERVATION.Location = New System.Drawing.Point(667, 57)
        Me.BTNRESERVATION.Name = "BTNRESERVATION"
        Me.BTNRESERVATION.Size = New System.Drawing.Size(222, 36)
        Me.BTNRESERVATION.TabIndex = 161
        Me.BTNRESERVATION.Text = "ADD ROOM"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel7, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel3, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(911, 531)
        Me.TableLayoutPanel1.TabIndex = 162
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.BackColor = System.Drawing.Color.Goldenrod
        Me.Guna2Panel7.Controls.Add(Me.BTNBACK)
        Me.Guna2Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel7.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.Size = New System.Drawing.Size(911, 40)
        Me.Guna2Panel7.TabIndex = 9
        '
        'BTNBACK
        '
        Me.BTNBACK.BackColor = System.Drawing.Color.Transparent
        Me.BTNBACK.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNBACK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNBACK.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNBACK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNBACK.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNBACK.FillColor = System.Drawing.Color.Transparent
        Me.BTNBACK.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBACK.ForeColor = System.Drawing.Color.White
        Me.BTNBACK.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.BTNBACK.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.BTNBACK.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.BTNBACK.Image = Global.HotelReservationSystem.My.Resources.Resources.back_ic
        Me.BTNBACK.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNBACK.Location = New System.Drawing.Point(0, 0)
        Me.BTNBACK.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNBACK.Name = "BTNBACK"
        Me.BTNBACK.PressedColor = System.Drawing.Color.Transparent
        Me.BTNBACK.Size = New System.Drawing.Size(91, 40)
        Me.BTNBACK.TabIndex = 0
        Me.BTNBACK.Text = "Back"
        Me.BTNBACK.UseTransparentBackground = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.TXTBOXPHONE)
        Me.Guna2Panel1.Controls.Add(Me.CMBGUESTS)
        Me.Guna2Panel1.Controls.Add(Me.TXTBOXTOTAL)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.TXTBOXINVOICENUMBER)
        Me.Guna2Panel1.Controls.Add(Me.BTNRESERVATION)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(911, 100)
        Me.Guna2Panel1.TabIndex = 0
        '
        'TXTBOXTOTAL
        '
        Me.TXTBOXTOTAL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTBOXTOTAL.AutoSize = True
        Me.TXTBOXTOTAL.BackColor = System.Drawing.Color.Transparent
        Me.TXTBOXTOTAL.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBOXTOTAL.Location = New System.Drawing.Point(86, 66)
        Me.TXTBOXTOTAL.Name = "TXTBOXTOTAL"
        Me.TXTBOXTOTAL.Size = New System.Drawing.Size(15, 21)
        Me.TXTBOXTOTAL.TabIndex = 164
        Me.TXTBOXTOTAL.Text = "-"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.TabIndex = 163
        Me.Label1.Text = "TOTAL:"
        '
        'TXTBOXINVOICENUMBER
        '
        Me.TXTBOXINVOICENUMBER.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTBOXINVOICENUMBER.AutoSize = True
        Me.TXTBOXINVOICENUMBER.BackColor = System.Drawing.Color.Transparent
        Me.TXTBOXINVOICENUMBER.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBOXINVOICENUMBER.Location = New System.Drawing.Point(16, 34)
        Me.TXTBOXINVOICENUMBER.Name = "TXTBOXINVOICENUMBER"
        Me.TXTBOXINVOICENUMBER.Size = New System.Drawing.Size(15, 21)
        Me.TXTBOXINVOICENUMBER.TabIndex = 162
        Me.TXTBOXINVOICENUMBER.Text = "-"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 21)
        Me.Label6.TabIndex = 157
        Me.Label6.Text = "INVOICE NUMBER:"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.ROOMSDATAGRIDVIEW)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 140)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Padding = New System.Windows.Forms.Padding(20)
        Me.Guna2Panel2.Size = New System.Drawing.Size(911, 331)
        Me.Guna2Panel2.TabIndex = 1
        '
        'ROOMSDATAGRIDVIEW
        '
        Me.ROOMSDATAGRIDVIEW.AllowUserToAddRows = False
        Me.ROOMSDATAGRIDVIEW.AllowUserToDeleteRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        Me.ROOMSDATAGRIDVIEW.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ROOMSDATAGRIDVIEW.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.ROOMSDATAGRIDVIEW.ColumnHeadersHeight = 40
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ROOMSDATAGRIDVIEW.DefaultCellStyle = DataGridViewCellStyle18
        Me.ROOMSDATAGRIDVIEW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ROOMSDATAGRIDVIEW.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ROOMSDATAGRIDVIEW.Location = New System.Drawing.Point(20, 20)
        Me.ROOMSDATAGRIDVIEW.Margin = New System.Windows.Forms.Padding(0)
        Me.ROOMSDATAGRIDVIEW.Name = "ROOMSDATAGRIDVIEW"
        Me.ROOMSDATAGRIDVIEW.ReadOnly = True
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ROOMSDATAGRIDVIEW.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.ROOMSDATAGRIDVIEW.RowHeadersVisible = False
        Me.ROOMSDATAGRIDVIEW.RowHeadersWidth = 51
        Me.ROOMSDATAGRIDVIEW.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle20.Padding = New System.Windows.Forms.Padding(5)
        Me.ROOMSDATAGRIDVIEW.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.ROOMSDATAGRIDVIEW.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(5)
        Me.ROOMSDATAGRIDVIEW.RowTemplate.Height = 30
        Me.ROOMSDATAGRIDVIEW.Size = New System.Drawing.Size(871, 291)
        Me.ROOMSDATAGRIDVIEW.TabIndex = 163
        Me.ROOMSDATAGRIDVIEW.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.ROOMSDATAGRIDVIEW.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.ROOMSDATAGRIDVIEW.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.ROOMSDATAGRIDVIEW.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.ROOMSDATAGRIDVIEW.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.ROOMSDATAGRIDVIEW.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.ROOMSDATAGRIDVIEW.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ROOMSDATAGRIDVIEW.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ROOMSDATAGRIDVIEW.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ROOMSDATAGRIDVIEW.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ROOMSDATAGRIDVIEW.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.ROOMSDATAGRIDVIEW.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ROOMSDATAGRIDVIEW.ThemeStyle.HeaderStyle.Height = 40
        Me.ROOMSDATAGRIDVIEW.ThemeStyle.ReadOnly = True
        Me.ROOMSDATAGRIDVIEW.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.ROOMSDATAGRIDVIEW.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ROOMSDATAGRIDVIEW.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ROOMSDATAGRIDVIEW.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ROOMSDATAGRIDVIEW.ThemeStyle.RowsStyle.Height = 30
        Me.ROOMSDATAGRIDVIEW.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ROOMSDATAGRIDVIEW.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.ADDRESERVATION)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 471)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(911, 60)
        Me.Guna2Panel3.TabIndex = 10
        '
        'ADDRESERVATION
        '
        Me.ADDRESERVATION.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ADDRESERVATION.BackColor = System.Drawing.Color.Transparent
        Me.ADDRESERVATION.BorderThickness = 2
        Me.ADDRESERVATION.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ADDRESERVATION.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ADDRESERVATION.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ADDRESERVATION.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ADDRESERVATION.FillColor = System.Drawing.Color.Goldenrod
        Me.ADDRESERVATION.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADDRESERVATION.ForeColor = System.Drawing.Color.White
        Me.ADDRESERVATION.Location = New System.Drawing.Point(667, 12)
        Me.ADDRESERVATION.Name = "ADDRESERVATION"
        Me.ADDRESERVATION.Size = New System.Drawing.Size(222, 36)
        Me.ADDRESERVATION.TabIndex = 162
        Me.ADDRESERVATION.Text = "ADD RESERVATION"
        '
        'CMBGUESTS
        '
        Me.CMBGUESTS.BackColor = System.Drawing.Color.Transparent
        Me.CMBGUESTS.DisplayMember = "name"
        Me.CMBGUESTS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBGUESTS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBGUESTS.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBGUESTS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBGUESTS.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CMBGUESTS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CMBGUESTS.ItemHeight = 30
        Me.CMBGUESTS.Location = New System.Drawing.Point(330, 13)
        Me.CMBGUESTS.Margin = New System.Windows.Forms.Padding(2)
        Me.CMBGUESTS.Name = "CMBGUESTS"
        Me.CMBGUESTS.Size = New System.Drawing.Size(250, 36)
        Me.CMBGUESTS.TabIndex = 167
        Me.CMBGUESTS.ValueMember = "id"
        '
        'TXTBOXPHONE
        '
        Me.TXTBOXPHONE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTBOXPHONE.DefaultText = ""
        Me.TXTBOXPHONE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTBOXPHONE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTBOXPHONE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTBOXPHONE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTBOXPHONE.Enabled = False
        Me.TXTBOXPHONE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTBOXPHONE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTBOXPHONE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTBOXPHONE.Location = New System.Drawing.Point(639, 13)
        Me.TXTBOXPHONE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTBOXPHONE.Name = "TXTBOXPHONE"
        Me.TXTBOXPHONE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTBOXPHONE.PlaceholderText = "Phone"
        Me.TXTBOXPHONE.SelectedText = ""
        Me.TXTBOXPHONE.Size = New System.Drawing.Size(250, 36)
        Me.TXTBOXPHONE.TabIndex = 168
        '
        'ReservationDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 531)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReservationDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReservationDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel7.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.ROOMSDATAGRIDVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RESERVATIONSTYLE As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents BTNRESERVATION As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ROOMSDATAGRIDVIEW As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNBACK As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ADDRESERVATION As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXTBOXINVOICENUMBER As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTBOXTOTAL As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CMBGUESTS As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TXTBOXPHONE As Guna.UI2.WinForms.Guna2TextBox
End Class
