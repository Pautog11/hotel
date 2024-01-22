Imports System.Data.SqlClient
Public Class Reservation
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ipakitareserve()
    End Sub

    Private Sub BtnRoom_Click(sender As Object, e As EventArgs) Handles BtnRoomRV.Click
        Rooms.Show()
        Me.Hide()
    End Sub
    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdminRV.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub ipakitareserve()
        con = New SqlConnection(My.Settings.hmsConnectionString)
        con.Open()
        Dim sql = "select * from tblreservationguests"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim reservelaman As DataSet
        reservelaman = New DataSet
        adapter.Fill(reservelaman)
        ReservationDGV.DataSource = reservelaman.Tables(0)
        con.Close()
    End Sub
    Private Sub BtnStaff_Click(sender As Object, e As EventArgs) Handles BtnStaffRV.Click
        Staff.Show()
        Me.Hide()
    End Sub

    Private Sub BtnDeletersrvAdmin_Click(sender As Object, e As EventArgs) Handles BtnDeletersrvAdmin.Click

        Try
            con = SqlConnectionSingleton.GetInstance
            Dim query As String
            query = "Delete from tblresrvationguests where Guest Code = " & txtguestcode.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Guest Deleted Successfully")
            con.Close()
            ipakitareserve()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub BtnUpdatersrvAdmin_Click(sender As Object, e As EventArgs) Handles BtnUpdatersrvAdmin.Click
        ipakitareserve()
    End Sub
End Class