Imports System.Data.SqlClient
Public Class StaffAdmin
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Private Sub BtnRoom_Click(sender As Object, e As EventArgs) Handles BtnRoomAdmin.Click
        RoomAdmin.Show()
        Me.Hide()
    End Sub
    Private Sub BtnReserveAdmin_Click(sender As Object, e As EventArgs) Handles BtnReserveAdmin.Click
        ReservationAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub BtnAddstaffAdmin_Click(sender As Object, e As EventArgs) Handles BtnAddstaffAdmin.Click
        Try
            con = New SqlConnection(My.Settings.hmsConnectionString)
            con.Open()
            Dim query As String
            query = "insert into tblstaff values('" + txtstaffcode.Text + "', '" + txtstaffname.Text + "','" + txtstaffphone.Text + "', '" + cmbroomass.SelectedItem.ToString() + "')"
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Staff has been added successfully!")
            con.Close()
            ipakitastaff()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ipakitastaff()
        con = SqlConnectionSingleton.GetInstance
        Dim sql = "select * from tblstafflist"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim stafflaman As DataSet
        stafflaman = New DataSet
        adapter.Fill(stafflaman)
        'StaffDGV.DataSource = ipakitareserve.Tables(0)
        Staff.StaffDGV.DataSource = stafflaman.Tables(0)
        con.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ipakitastaff()
    End Sub
End Class