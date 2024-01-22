<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddReservationDialog
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
        Me.BTNREMOVEROOM = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNRESERVATION = New Guna.UI2.WinForms.Guna2Button()
        Me.PANWFA = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.TXTBOXTOTALDUE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTNBACK = New Guna.UI2.WinForms.Guna2Button()
        Me.CHECKINTIME = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CMBRATE = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.DATECHECKIN = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.CMDDISCOUNTVALUE = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTBOXROOMTYPE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CMDROOMNO = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.PANWFA.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNREMOVEROOM
        '
        Me.BTNREMOVEROOM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNREMOVEROOM.BackColor = System.Drawing.Color.Transparent
        Me.BTNREMOVEROOM.BorderThickness = 2
        Me.BTNREMOVEROOM.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNREMOVEROOM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNREMOVEROOM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNREMOVEROOM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNREMOVEROOM.FillColor = System.Drawing.Color.Goldenrod
        Me.BTNREMOVEROOM.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNREMOVEROOM.ForeColor = System.Drawing.Color.White
        Me.BTNREMOVEROOM.Location = New System.Drawing.Point(465, 294)
        Me.BTNREMOVEROOM.Name = "BTNREMOVEROOM"
        Me.BTNREMOVEROOM.Size = New System.Drawing.Size(180, 37)
        Me.BTNREMOVEROOM.TabIndex = 165
        Me.BTNREMOVEROOM.Text = "REMOVE ROOM"
        Me.BTNREMOVEROOM.Visible = False
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
        Me.BTNRESERVATION.Location = New System.Drawing.Point(674, 294)
        Me.BTNRESERVATION.Name = "BTNRESERVATION"
        Me.BTNRESERVATION.Size = New System.Drawing.Size(176, 37)
        Me.BTNRESERVATION.TabIndex = 143
        Me.BTNRESERVATION.Text = "ADD ROOM"
        '
        'PANWFA
        '
        Me.PANWFA.BorderColor = System.Drawing.Color.Black
        Me.PANWFA.BorderThickness = 0
        Me.PANWFA.Controls.Add(Me.TXTBOXTOTALDUE)
        Me.PANWFA.Controls.Add(Me.Label4)
        Me.PANWFA.Controls.Add(Me.BTNBACK)
        Me.PANWFA.Controls.Add(Me.BTNREMOVEROOM)
        Me.PANWFA.Controls.Add(Me.CHECKINTIME)
        Me.PANWFA.Controls.Add(Me.Label3)
        Me.PANWFA.Controls.Add(Me.CMBRATE)
        Me.PANWFA.Controls.Add(Me.DATECHECKIN)
        Me.PANWFA.Controls.Add(Me.CMDDISCOUNTVALUE)
        Me.PANWFA.Controls.Add(Me.Label1)
        Me.PANWFA.Controls.Add(Me.TXTBOXROOMTYPE)
        Me.PANWFA.Controls.Add(Me.Label7)
        Me.PANWFA.Controls.Add(Me.BTNRESERVATION)
        Me.PANWFA.Controls.Add(Me.Label2)
        Me.PANWFA.Controls.Add(Me.Label11)
        Me.PANWFA.Controls.Add(Me.Label10)
        Me.PANWFA.Controls.Add(Me.CMDROOMNO)
        Me.PANWFA.CustomBorderColor = System.Drawing.Color.Goldenrod
        Me.PANWFA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PANWFA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PANWFA.ForeColor = System.Drawing.Color.Black
        Me.PANWFA.Location = New System.Drawing.Point(0, 0)
        Me.PANWFA.Name = "PANWFA"
        Me.PANWFA.Size = New System.Drawing.Size(870, 346)
        Me.PANWFA.TabIndex = 133
        Me.PANWFA.Text = "ROOM INFORMATION"
        Me.PANWFA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTBOXTOTALDUE
        '
        Me.TXTBOXTOTALDUE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTBOXTOTALDUE.DefaultText = ""
        Me.TXTBOXTOTALDUE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTBOXTOTALDUE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTBOXTOTALDUE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTBOXTOTALDUE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTBOXTOTALDUE.Enabled = False
        Me.TXTBOXTOTALDUE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTBOXTOTALDUE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTBOXTOTALDUE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTBOXTOTALDUE.Location = New System.Drawing.Point(600, 219)
        Me.TXTBOXTOTALDUE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTBOXTOTALDUE.Name = "TXTBOXTOTALDUE"
        Me.TXTBOXTOTALDUE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTBOXTOTALDUE.PlaceholderText = ""
        Me.TXTBOXTOTALDUE.SelectedText = ""
        Me.TXTBOXTOTALDUE.Size = New System.Drawing.Size(250, 36)
        Me.TXTBOXTOTALDUE.TabIndex = 171
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(497, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 21)
        Me.Label4.TabIndex = 170
        Me.Label4.Text = "TOTAL DUE:"
        '
        'BTNBACK
        '
        Me.BTNBACK.BackColor = System.Drawing.Color.Transparent
        Me.BTNBACK.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNBACK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNBACK.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNBACK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNBACK.FillColor = System.Drawing.Color.Transparent
        Me.BTNBACK.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.BTNBACK.TabIndex = 169
        Me.BTNBACK.Text = "Back"
        Me.BTNBACK.UseTransparentBackground = True
        '
        'CHECKINTIME
        '
        Me.CHECKINTIME.BackColor = System.Drawing.Color.Transparent
        Me.CHECKINTIME.Checked = True
        Me.CHECKINTIME.CustomFormat = "hh:mm tt"
        Me.CHECKINTIME.FillColor = System.Drawing.SystemColors.Control
        Me.CHECKINTIME.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CHECKINTIME.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CHECKINTIME.Location = New System.Drawing.Point(600, 143)
        Me.CHECKINTIME.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.CHECKINTIME.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.CHECKINTIME.Name = "CHECKINTIME"
        Me.CHECKINTIME.ShowUpDown = True
        Me.CHECKINTIME.Size = New System.Drawing.Size(250, 36)
        Me.CHECKINTIME.TabIndex = 168
        Me.CHECKINTIME.UseTransparentBackground = True
        Me.CHECKINTIME.Value = New Date(2023, 10, 22, 18, 38, 3, 255)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(466, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 21)
        Me.Label3.TabIndex = 167
        Me.Label3.Text = "CHECK IN TIME:"
        '
        'CMBRATE
        '
        Me.CMBRATE.BackColor = System.Drawing.Color.Transparent
        Me.CMBRATE.DisplayMember = "rate"
        Me.CMBRATE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBRATE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBRATE.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBRATE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBRATE.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CMBRATE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CMBRATE.ItemHeight = 30
        Me.CMBRATE.Location = New System.Drawing.Point(157, 219)
        Me.CMBRATE.Margin = New System.Windows.Forms.Padding(2)
        Me.CMBRATE.Name = "CMBRATE"
        Me.CMBRATE.Size = New System.Drawing.Size(250, 36)
        Me.CMBRATE.TabIndex = 166
        Me.CMBRATE.ValueMember = "id"
        '
        'DATECHECKIN
        '
        Me.DATECHECKIN.BackColor = System.Drawing.Color.Transparent
        Me.DATECHECKIN.Checked = True
        Me.DATECHECKIN.FillColor = System.Drawing.SystemColors.Control
        Me.DATECHECKIN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DATECHECKIN.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DATECHECKIN.Location = New System.Drawing.Point(600, 67)
        Me.DATECHECKIN.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DATECHECKIN.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DATECHECKIN.Name = "DATECHECKIN"
        Me.DATECHECKIN.Size = New System.Drawing.Size(250, 36)
        Me.DATECHECKIN.TabIndex = 163
        Me.DATECHECKIN.UseTransparentBackground = True
        Me.DATECHECKIN.Value = New Date(2023, 10, 22, 18, 38, 3, 255)
        '
        'CMDDISCOUNTVALUE
        '
        Me.CMDDISCOUNTVALUE.BackColor = System.Drawing.Color.Transparent
        Me.CMDDISCOUNTVALUE.DisplayMember = "DISCOUNT TYPE"
        Me.CMDDISCOUNTVALUE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMDDISCOUNTVALUE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMDDISCOUNTVALUE.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMDDISCOUNTVALUE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMDDISCOUNTVALUE.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CMDDISCOUNTVALUE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CMDDISCOUNTVALUE.ItemHeight = 30
        Me.CMDDISCOUNTVALUE.Location = New System.Drawing.Point(157, 295)
        Me.CMDDISCOUNTVALUE.Margin = New System.Windows.Forms.Padding(2)
        Me.CMDDISCOUNTVALUE.Name = "CMDDISCOUNTVALUE"
        Me.CMDDISCOUNTVALUE.Size = New System.Drawing.Size(250, 36)
        Me.CMDDISCOUNTVALUE.TabIndex = 162
        Me.CMDDISCOUNTVALUE.ValueMember = "id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 21)
        Me.Label1.TabIndex = 161
        Me.Label1.Text = "DISCOUNT:"
        '
        'TXTBOXROOMTYPE
        '
        Me.TXTBOXROOMTYPE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTBOXROOMTYPE.DefaultText = ""
        Me.TXTBOXROOMTYPE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTBOXROOMTYPE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTBOXROOMTYPE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTBOXROOMTYPE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTBOXROOMTYPE.Enabled = False
        Me.TXTBOXROOMTYPE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTBOXROOMTYPE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTBOXROOMTYPE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTBOXROOMTYPE.Location = New System.Drawing.Point(157, 143)
        Me.TXTBOXROOMTYPE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTBOXROOMTYPE.Name = "TXTBOXROOMTYPE"
        Me.TXTBOXROOMTYPE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTBOXROOMTYPE.PlaceholderText = ""
        Me.TXTBOXROOMTYPE.SelectedText = ""
        Me.TXTBOXROOMTYPE.Size = New System.Drawing.Size(250, 36)
        Me.TXTBOXROOMTYPE.TabIndex = 159
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(100, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 21)
        Me.Label7.TabIndex = 152
        Me.Label7.Text = "RATE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 21)
        Me.Label2.TabIndex = 148
        Me.Label2.Text = "ROOM NO:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(461, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 21)
        Me.Label11.TabIndex = 154
        Me.Label11.Text = "CHECK IN DATE:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(46, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 21)
        Me.Label10.TabIndex = 145
        Me.Label10.Text = "ROOM TYPE:"
        '
        'CMDROOMNO
        '
        Me.CMDROOMNO.BackColor = System.Drawing.Color.Transparent
        Me.CMDROOMNO.DisplayMember = "ROOM NUMBER"
        Me.CMDROOMNO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMDROOMNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMDROOMNO.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMDROOMNO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMDROOMNO.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CMDROOMNO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CMDROOMNO.ItemHeight = 30
        Me.CMDROOMNO.Location = New System.Drawing.Point(157, 67)
        Me.CMDROOMNO.Margin = New System.Windows.Forms.Padding(2)
        Me.CMDROOMNO.Name = "CMDROOMNO"
        Me.CMDROOMNO.Size = New System.Drawing.Size(250, 36)
        Me.CMDROOMNO.TabIndex = 144
        Me.CMDROOMNO.ValueMember = "id"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'AddReservationDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 346)
        Me.Controls.Add(Me.PANWFA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddReservationDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ADD RESERVATION"
        Me.PANWFA.ResumeLayout(False)
        Me.PANWFA.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTNRESERVATION As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PANWFA As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CMDROOMNO As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TXTBOXROOMTYPE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CMDDISCOUNTVALUE As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents DATECHECKIN As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents BTNREMOVEROOM As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CMBRATE As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CHECKINTIME As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents BTNBACK As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXTBOXTOTALDUE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
End Class
