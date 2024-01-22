<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResInfo
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
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.DATECHECKIN = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTBOXROOMTYPE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CMDROOMNO = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel7.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel7, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(536, 308)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.BackColor = System.Drawing.Color.Goldenrod
        Me.Guna2Panel7.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel7.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.Size = New System.Drawing.Size(536, 49)
        Me.Guna2Panel7.TabIndex = 7
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.DATECHECKIN)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.TXTBOXROOMTYPE)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.CMDROOMNO)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(536, 259)
        Me.Guna2Panel1.TabIndex = 8
        '
        'DATECHECKIN
        '
        Me.DATECHECKIN.BackColor = System.Drawing.Color.Transparent
        Me.DATECHECKIN.Checked = True
        Me.DATECHECKIN.Enabled = False
        Me.DATECHECKIN.FillColor = System.Drawing.SystemColors.Control
        Me.DATECHECKIN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DATECHECKIN.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DATECHECKIN.Location = New System.Drawing.Point(146, 65)
        Me.DATECHECKIN.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DATECHECKIN.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DATECHECKIN.Name = "DATECHECKIN"
        Me.DATECHECKIN.Size = New System.Drawing.Size(205, 36)
        Me.DATECHECKIN.TabIndex = 170
        Me.DATECHECKIN.UseTransparentBackground = True
        Me.DATECHECKIN.Value = New Date(2023, 10, 22, 18, 38, 3, 255)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 21)
        Me.Label3.TabIndex = 169
        Me.Label3.Text = "CHECK IN DATE:"
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
        Me.TXTBOXROOMTYPE.Location = New System.Drawing.Point(146, 13)
        Me.TXTBOXROOMTYPE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTBOXROOMTYPE.Name = "TXTBOXROOMTYPE"
        Me.TXTBOXROOMTYPE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTBOXROOMTYPE.PlaceholderText = ""
        Me.TXTBOXROOMTYPE.SelectedText = ""
        Me.TXTBOXROOMTYPE.Size = New System.Drawing.Size(205, 36)
        Me.TXTBOXROOMTYPE.TabIndex = 160
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 21)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "GUEST NAME:"
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
        Me.CMDROOMNO.Location = New System.Drawing.Point(146, 123)
        Me.CMDROOMNO.Margin = New System.Windows.Forms.Padding(2)
        Me.CMDROOMNO.Name = "CMDROOMNO"
        Me.CMDROOMNO.Size = New System.Drawing.Size(205, 36)
        Me.CMDROOMNO.TabIndex = 149
        Me.CMDROOMNO.ValueMember = "id"
        '
        'ResInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 308)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ResInfo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ResInfo"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel7.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents CMDROOMNO As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TXTBOXROOMTYPE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DATECHECKIN As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
