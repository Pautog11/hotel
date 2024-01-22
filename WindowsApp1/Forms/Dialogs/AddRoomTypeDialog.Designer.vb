<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRoomTypeDialog
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TXTBOXROOMTYPE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel11 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNDELETEROOMTYPE = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNADDROOMTYPE = New Guna.UI2.WinForms.Guna2Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel12 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel11.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel11, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 49)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(416, 106)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(100, 50)
        Me.Guna2Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ROOM TYPE:"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.TXTBOXROOMTYPE)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(100, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(316, 50)
        Me.Guna2Panel1.TabIndex = 0
        '
        'TXTBOXROOMTYPE
        '
        Me.TXTBOXROOMTYPE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTBOXROOMTYPE.DefaultText = ""
        Me.TXTBOXROOMTYPE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTBOXROOMTYPE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTBOXROOMTYPE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTBOXROOMTYPE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTBOXROOMTYPE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTBOXROOMTYPE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTBOXROOMTYPE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTBOXROOMTYPE.Location = New System.Drawing.Point(13, 8)
        Me.TXTBOXROOMTYPE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTBOXROOMTYPE.Name = "TXTBOXROOMTYPE"
        Me.TXTBOXROOMTYPE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTBOXROOMTYPE.PlaceholderText = ""
        Me.TXTBOXROOMTYPE.SelectedText = ""
        Me.TXTBOXROOMTYPE.Size = New System.Drawing.Size(284, 35)
        Me.TXTBOXROOMTYPE.TabIndex = 0
        '
        'Guna2Panel11
        '
        Me.Guna2Panel11.Controls.Add(Me.BTNDELETEROOMTYPE)
        Me.Guna2Panel11.Controls.Add(Me.BTNADDROOMTYPE)
        Me.Guna2Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel11.Location = New System.Drawing.Point(100, 50)
        Me.Guna2Panel11.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel11.Name = "Guna2Panel11"
        Me.Guna2Panel11.Size = New System.Drawing.Size(316, 56)
        Me.Guna2Panel11.TabIndex = 9
        '
        'BTNDELETEROOMTYPE
        '
        Me.BTNDELETEROOMTYPE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNDELETEROOMTYPE.BorderThickness = 1
        Me.BTNDELETEROOMTYPE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNDELETEROOMTYPE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNDELETEROOMTYPE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNDELETEROOMTYPE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNDELETEROOMTYPE.FillColor = System.Drawing.Color.Goldenrod
        Me.BTNDELETEROOMTYPE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNDELETEROOMTYPE.ForeColor = System.Drawing.Color.White
        Me.BTNDELETEROOMTYPE.Location = New System.Drawing.Point(63, 11)
        Me.BTNDELETEROOMTYPE.Name = "BTNDELETEROOMTYPE"
        Me.BTNDELETEROOMTYPE.Size = New System.Drawing.Size(110, 34)
        Me.BTNDELETEROOMTYPE.TabIndex = 3
        Me.BTNDELETEROOMTYPE.Text = "DELETE"
        Me.BTNDELETEROOMTYPE.Visible = False
        '
        'BTNADDROOMTYPE
        '
        Me.BTNADDROOMTYPE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNADDROOMTYPE.BorderThickness = 1
        Me.BTNADDROOMTYPE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNADDROOMTYPE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNADDROOMTYPE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNADDROOMTYPE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNADDROOMTYPE.FillColor = System.Drawing.Color.Goldenrod
        Me.BTNADDROOMTYPE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNADDROOMTYPE.ForeColor = System.Drawing.Color.White
        Me.BTNADDROOMTYPE.Location = New System.Drawing.Point(186, 11)
        Me.BTNADDROOMTYPE.Name = "BTNADDROOMTYPE"
        Me.BTNADDROOMTYPE.Size = New System.Drawing.Size(110, 34)
        Me.BTNADDROOMTYPE.TabIndex = 2
        Me.BTNADDROOMTYPE.Text = "SAVE"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel12, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(416, 155)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'Guna2Panel12
        '
        Me.Guna2Panel12.BackColor = System.Drawing.Color.Goldenrod
        Me.Guna2Panel12.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel12.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel12.Name = "Guna2Panel12"
        Me.Guna2Panel12.Size = New System.Drawing.Size(416, 49)
        Me.Guna2Panel12.TabIndex = 10
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
        Me.Guna2Button1.Size = New System.Drawing.Size(91, 49)
        Me.Guna2Button1.TabIndex = 0
        Me.Guna2Button1.Text = "Back"
        Me.Guna2Button1.UseTransparentBackground = True
        '
        'AddRoomTypeDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 155)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddRoomTypeDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AddRoomTypeDialog"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel11.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel12.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TXTBOXROOMTYPE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel11 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNDELETEROOMTYPE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNADDROOMTYPE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2Panel12 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
End Class
