Public Class Rooms
    Dim dateFrom As DateTime
    Dim dateTo As DateTime
    Dim roomCost As Double = 0
    Dim totalCharges As Double
    Dim once = 0
    Private Sub Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnStaff_Click(sender As Object, e As EventArgs) Handles BtnStaffR.Click
        Staff.Show()
        Me.Hide()
    End Sub
    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdminR.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub BtnReservation_Click(sender As Object, e As EventArgs) Handles BtnReservationR.Click
        Reservation.Show()
        Me.Hide()
    End Sub
    '    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)
    '        dateFrom = dtpcheckin.Value
    '        dateTo = dateFrom.AddDays(NumericUpDown1.Value)
    '        dtpcheckout.Value = dateTo
    '    End Sub

    '    Private Sub dtpcheckin_ValueChanged(sender As Object, e As EventArgs)
    '        dtpcheckin.MinDate = Now
    '    End Sub

    '    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)


    '    End Sub
    '    'Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs)
    '    '    getRoomcost()
    '    'End Sub
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

    '    Private Sub btncompute_Click(sender As Object, e As EventArgs)
    '        getRoomcost()
    '        txtroomrate.Text = roomCost * CInt(NumericUpDown1.Value)
    '        txtdp.Text = Format(Val(txtroomrate.Text) * 0.25, ".00")
    '        txtbalance.Text = Format(Val(txtroomrate.Text) - Val(txtdp.Text), ".00")
    '    End Sub

    '    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    '    End Sub

    '    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    '    End Sub

    '    'Private Sub rb1_MouseClick(sender As Object, e As MouseEventArgs) Handles rb1.MouseClick, rb2.MouseClick, rb3.MouseClick, rb4.MouseClick, rb5.MouseClick, rb6.MouseClick, rb7.MouseClick, rb8.MouseClick, rb9.MouseClick, rb10.MouseClick, rb11.MouseClick, rb12.MouseClick, rb13.MouseClick, rb14.MouseClick, rb15.MouseClick
    '    '    Dim rb() = {rb1, rb2, rb3, rb4, rb5}
    '    '    For Each i in rb
    '    '       if i.Checked Then
    '    '           i.Checked = False
    '    '       End If
    '    '    Next
    '    'End Sub
End Class