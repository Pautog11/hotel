Imports System.Data.SqlClient

Public Class Staff
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ipakitastaff()
    End Sub
    Private Sub ipakitastaff()
        con = New SqlConnection(My.Settings.hmsConnectionString)
        Dim sql = "select * from tblstaff"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim stafflaman As DataSet
        stafflaman = New DataSet
        adapter.Fill(stafflaman)
        StaffDGV.DataSource = stafflaman.Tables(0)
        con.Close()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs)
        LoginForm.Show()
        Me.Hide()
    End Sub


    Private Sub BtnRoomS_Click(sender As Object, e As EventArgs) Handles BtnRoomS.Click
        Rooms.Show()
        Me.Hide()
    End Sub

    Private Sub BtnReservationS_Click(sender As Object, e As EventArgs) Handles BtnReservationS.Click
        Reservation.Show()
        Me.Hide()
    End Sub
    Private Sub BtnAdminS_Click(sender As Object, e As EventArgs) Handles BtnAdminS.Click
        Dashboard.Show()
        Me.Hide()
    End Sub


End Class