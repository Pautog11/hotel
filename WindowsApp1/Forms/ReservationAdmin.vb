Imports System.Data.SqlClient
Public Class ReservationAdmin
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Private Sub BtnStaffAdmin_Click(sender As Object, e As EventArgs) Handles BtnStaffAdmin.Click
        StaffAdmin.Show()
        Me.Hide()
    End Sub
    Private Sub BtnRoomAdmin_Click(sender As Object, e As EventArgs) Handles BtnRoomAdmin.Click
        RoomAdmin.Show()
        Me.Hide()
    End Sub
    Private Sub BtnAddrsrvAdmin_Click(sender As Object, e As EventArgs) Handles BtnAddrsrvAdmin.Click
        'If txtguestcode.Text = "" Or txtguestname.Text = "" Or txtphoneno.Text = "" Or cmbidprovided.SelectedIndex - 1 = "" Or cmbguestcountry.SelectedIndex - 1 = "" Or cmbpax.SelectedIndex - 1 = "" Then
        '    MsgBox("Missing Information! Please fill out the form!")
        ''Else
        Try
            con = SqlConnectionSingleton.GetInstance
            Dim query As String
                query = "insert into tblreservationguests values('" + txtguestcode.Text + "', '" + txtguestname.Text + "','" + txtphoneno.Text + "', '" + cmbidprovided.SelectedItem.ToString() + "', '" + cmbguestcountry.SelectedItem.ToString() + "', '" + cmbpax.SelectedItem.ToString() + "')"
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Guest has been reserve successfully!")
                con.Close()
                ipakitareserve()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        'End If
    End Sub
    Private Sub ipakitareserve()
        con = SqlConnectionSingleton.GetInstance
        Dim sql = "select * from tblreservationguests"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim reservelaman As DataSet
        reservelaman = New DataSet
        adapter.Fill(reservelaman)
        'ReservationDGV.DataSource = ipakitareserve.Tables(0)
        Rooms.ReservationDGV.DataSource = reservelaman.Tables(0)
        con.Close()
    End Sub
    Dim key = 0
    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub ReservationAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load
        ipakitareserve()
    End Sub
End Class