<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddUserDialog
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNDELETE = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNADDUSER = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TXTBOXPASSWORD = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TXTBOXUSERNAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel12 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Guna2Panel8.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel8, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel4, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel1, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 49)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(396, 159)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.Controls.Add(Me.BTNDELETE)
        Me.Guna2Panel8.Controls.Add(Me.BTNADDUSER)
        Me.Guna2Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel8.Location = New System.Drawing.Point(112, 100)
        Me.Guna2Panel8.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.Size = New System.Drawing.Size(284, 59)
        Me.Guna2Panel8.TabIndex = 7
        '
        'BTNDELETE
        '
        Me.BTNDELETE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNDELETE.BorderThickness = 1
        Me.BTNDELETE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNDELETE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNDELETE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNDELETE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNDELETE.FillColor = System.Drawing.Color.Goldenrod
        Me.BTNDELETE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNDELETE.ForeColor = System.Drawing.Color.White
        Me.BTNDELETE.Location = New System.Drawing.Point(43, 10)
        Me.BTNDELETE.Name = "BTNDELETE"
        Me.BTNDELETE.Size = New System.Drawing.Size(110, 34)
        Me.BTNDELETE.TabIndex = 3
        Me.BTNDELETE.Text = "DELETE"
        Me.BTNDELETE.Visible = False
        '
        'BTNADDUSER
        '
        Me.BTNADDUSER.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNADDUSER.BorderThickness = 1
        Me.BTNADDUSER.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNADDUSER.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNADDUSER.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNADDUSER.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNADDUSER.FillColor = System.Drawing.Color.Goldenrod
        Me.BTNADDUSER.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNADDUSER.ForeColor = System.Drawing.Color.White
        Me.BTNADDUSER.Location = New System.Drawing.Point(159, 10)
        Me.BTNADDUSER.Name = "BTNADDUSER"
        Me.BTNADDUSER.Size = New System.Drawing.Size(110, 34)
        Me.BTNADDUSER.TabIndex = 2
        Me.BTNADDUSER.Text = "SAVE"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Controls.Add(Me.TXTBOXPASSWORD)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel4.Location = New System.Drawing.Point(112, 50)
        Me.Guna2Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(284, 50)
        Me.Guna2Panel4.TabIndex = 3
        '
        'TXTBOXPASSWORD
        '
        Me.TXTBOXPASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTBOXPASSWORD.DefaultText = ""
        Me.TXTBOXPASSWORD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTBOXPASSWORD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTBOXPASSWORD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTBOXPASSWORD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTBOXPASSWORD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTBOXPASSWORD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTBOXPASSWORD.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTBOXPASSWORD.Location = New System.Drawing.Point(13, 9)
        Me.TXTBOXPASSWORD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTBOXPASSWORD.Name = "TXTBOXPASSWORD"
        Me.TXTBOXPASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTBOXPASSWORD.PlaceholderText = ""
        Me.TXTBOXPASSWORD.SelectedText = ""
        Me.TXTBOXPASSWORD.Size = New System.Drawing.Size(252, 32)
        Me.TXTBOXPASSWORD.TabIndex = 1
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.Label2)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 50)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(112, 50)
        Me.Guna2Panel3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(112, 50)
        Me.Guna2Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username:"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.TXTBOXUSERNAME)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(112, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(284, 50)
        Me.Guna2Panel1.TabIndex = 0
        '
        'TXTBOXUSERNAME
        '
        Me.TXTBOXUSERNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTBOXUSERNAME.DefaultText = ""
        Me.TXTBOXUSERNAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTBOXUSERNAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTBOXUSERNAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTBOXUSERNAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTBOXUSERNAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTBOXUSERNAME.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTBOXUSERNAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTBOXUSERNAME.Location = New System.Drawing.Point(13, 9)
        Me.TXTBOXUSERNAME.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTBOXUSERNAME.Name = "TXTBOXUSERNAME"
        Me.TXTBOXUSERNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTBOXUSERNAME.PlaceholderText = ""
        Me.TXTBOXUSERNAME.SelectedText = ""
        Me.TXTBOXUSERNAME.Size = New System.Drawing.Size(252, 32)
        Me.TXTBOXUSERNAME.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel12, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(396, 208)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Guna2Panel12
        '
        Me.Guna2Panel12.BackColor = System.Drawing.Color.Goldenrod
        Me.Guna2Panel12.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel12.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel12.Name = "Guna2Panel12"
        Me.Guna2Panel12.Size = New System.Drawing.Size(396, 49)
        Me.Guna2Panel12.TabIndex = 9
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
        'AddUserDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 208)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddUserDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ADD USER"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Guna2Panel8.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel12.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TXTBOXPASSWORD As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTBOXUSERNAME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNADDUSER As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNDELETE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2Panel12 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
