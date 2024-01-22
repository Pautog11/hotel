Imports System.Data.SqlClient
Public Class RoomAdmin
    Private Sub RoomAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim con As SqlConnection = SqlConnectionSingleton.GetInstance
        Dim sqlcmd As New SqlCommand("SELECT * from tblroomtype", con)
        Dim adapter As New SqlDataAdapter(sqlcmd)
        Dim data As New DataSet
        adapter.Fill(data)
        cmbtype.DataSource = data.Tables(0)
        cmbtype.DisplayMember = "room_type"
        cmbtype.ValueMember = "id"
    End Sub

    Private Sub BtnStaffAdmin_Click(sender As Object, e As EventArgs) Handles BtnStaffAdmin.Click
        StaffAdmin.Show()
        Me.Close()
    End Sub
    '    Dim dateFrom As DateTime
    '    Dim dateTo As DateTime
    '    Dim roomCost As Double = 0
    '    Dim totalCharges As Double
    '    Dim once = 0
    '    Private Sub RoomAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    End Sub

    '    Private Sub BtnRoom_Click(sender As Object, e As EventArgs)

    '    End Sub

    '    Private Sub BtnStaff_Click(sender As Object, e As EventArgs) Handles BtnStaffAdmin.Click
    '        StaffAdmin.Show()
    '        Me.Hide()
    '    End Sub

    '    Private Sub BtnReserveAdmin_Click(sender As Object, e As EventArgs) Handles BtnReserveAdmin.Click
    '        ReservationAdmin.Show()
    '        Me.Hide()
    '    End Sub
    '    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
    '        dateFrom = dtpcheckin.Value
    '        dateTo = dateFrom.AddDays(NumericUpDown1.Value)
    '        dtpcheckout.Value = dateTo
    '    End Sub
    '    Private Sub dtpcheckin_ValueChanged(sender As Object, e As EventArgs) Handles dtpcheckin.ValueChanged
    '        dtpcheckin.MinDate = Now
    '    End Sub
    '    Sub getRoomcost()
    '        roomCost = 0
    '        If rb1.Checked OrElse rb2.Checked OrElse rb3.Checked Then
    '            roomCost += 3500

    '        ElseIf rb4.Checked OrElse rb5.Checked Then
    '            roomCost += 4500
    '        End If

    '        If rb6.Checked OrElse rb7.Checked Then
    '            roomCost += 2000
    '        ElseIf rb8.Checked OrElse rb9.Checked Then
    '            roomCost += 2500

    '        ElseIf rb10.Checked Then
    '            roomCost += 3000
    '        End If

    '        If rb11.Checked Or rb12.Checked Then
    '            roomCost += 1500
    '        ElseIf rb13.Checked Then
    '            roomCost += 3500
    '        ElseIf rb14.Checked Then
    '            roomCost += 3000
    '        ElseIf rb15.Checked Then
    '            roomCost += 4500
    '        End If
    '    End Sub

    '    Private Sub btncompute_Click(sender As Object, e As EventArgs) Handles btncompute.Click
    '        getRoomcost()
    '        txtroomrate.Text = roomCost * CInt(NumericUpDown1.Value)
    '        txtdp.Text = Format(Val(txtroomrate.Text) * 0.25, ".00")
    '        txtbalance.Text = Format(Val(txtroomrate.Text) - Val(txtdp.Text), ".00")
    '    End Sub


End Class