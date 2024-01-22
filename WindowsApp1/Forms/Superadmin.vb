Imports System.Data
Imports System.Data.SqlClient
Public Class Superadmin
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If (txtsuperadminID.Text = "") Then
            MsgBox("Enter AdminID!")
            txtsuperadminID.Focus()
            Exit Sub
        End If
        If (txtsuperadminPass.Text = "") Then
            MsgBox("Enter Password!")
            txtsuperadminPass.Focus()
            Exit Sub
        End If
        Try
            con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\source\repos\HotelReservationSystem\dtbaseq.mdf;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("select * from tblsuperadmin where Username='" + txtsuperadminID.Text + "' and Password ='" + txtsuperadminPass.Text + "'")
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If (rdr.Read()) Then
                Dashboard.Show()
                Me.Hide()
                txtsuperadminID.Text = ""
                txtsuperadminPass.Text = ""
            Else
                MsgBox("Enter a valid AdminId and Password")
                txtsuperadminID.Text = ""
                txtsuperadminPass.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtsuperadminID_OnValueChanged(sender As Object, e As EventArgs) Handles txtsuperadminID.OnValueChanged

    End Sub

    Private Sub txtsuperadminPass_OnValueChanged(sender As Object, e As EventArgs) Handles txtsuperadminPass.OnValueChanged

    End Sub

    Private Sub Guna2PictureBox15_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox15.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lbladmin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbladmin.LinkClicked
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class