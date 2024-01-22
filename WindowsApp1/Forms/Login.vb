Imports System.Data
Imports System.Data.SqlClient
Public Class LoginForm
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If Not String.IsNullOrEmpty(txtadminID.Text) AndAlso Not String.IsNullOrEmpty(txtadminPass.Text) Then
            Dim con As SqlConnection = SqlConnectionSingleton.GetInstance
            Dim command As New SqlCommand("SELECT password FROM tblusers WHERE username = @username", con)
            command.Parameters.AddWithValue("@username", txtadminID.Text)
            Dim data As New DataTable
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(data)
            If data.Rows.Count > 0 Then
                If data.Rows.Item(0).Item("password") = txtadminPass.Text Then
                    DashboardForm.Show()
                    Close()
                Else
                    MessageBox.Show(Me, "Incorrect username or password.", "Failed!")
                End If
            Else
                MessageBox.Show(Me, "Username does not exists.", "Failed!")
            End If
        Else
            MessageBox.Show(Me, "Please fill out the empty fields.", "Empty fields.")
        End If
    End Sub

    Private Sub LblSuperAdmin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtadminPass.PasswordChar = Nothing
        Else
            txtadminPass.PasswordChar = "•"
        End If
    End Sub
End Class