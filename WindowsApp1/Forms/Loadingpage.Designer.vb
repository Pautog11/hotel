<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loadingpage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLpercent = New System.Windows.Forms.Label()
        Me.PBloading = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(103, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "  GOLDSBERG HOTEL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RESERVATION SYSTEM"
        '
        'LBLpercent
        '
        Me.LBLpercent.AutoSize = True
        Me.LBLpercent.BackColor = System.Drawing.Color.Transparent
        Me.LBLpercent.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLpercent.ForeColor = System.Drawing.Color.White
        Me.LBLpercent.Location = New System.Drawing.Point(213, 91)
        Me.LBLpercent.Name = "LBLpercent"
        Me.LBLpercent.Size = New System.Drawing.Size(28, 27)
        Me.LBLpercent.TabIndex = 1
        Me.LBLpercent.Text = "%"
        '
        'PBloading
        '
        Me.PBloading.FillColor = System.Drawing.Color.Goldenrod
        Me.PBloading.Location = New System.Drawing.Point(-1, 197)
        Me.PBloading.Name = "PBloading"
        Me.PBloading.Size = New System.Drawing.Size(472, 22)
        Me.PBloading.TabIndex = 2
        Me.PBloading.Text = "Guna2ProgressBar1"
        Me.PBloading.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Timer1
        '
        '
        'Loadingpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.HotelReservationSystem.My.Resources.Resources.background1
        Me.ClientSize = New System.Drawing.Size(470, 219)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBloading)
        Me.Controls.Add(Me.LBLpercent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Loadingpage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loadingpage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LBLpercent As Label
    Friend WithEvents PBloading As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Timer1 As Timer
End Class
