Imports Guna.UI2.WinForms
Imports HotelReservationSystem.hmsdbDataSetTableAdapters

Public Class ReservationInfoDialog
    Private _discountAdapter As New viewtbldiscountsTableAdapter
    Private _roomsadapter As New viewtblroomsTableAdapter
    Public Property Data As DataRowView
    Private Sub BTNEXTEND_Click(sender As Object, e As EventArgs) Handles BTNEXTEND.Click

    End Sub

    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        If TransactionModel.CancelReservation(Data.Item("ID"), 2) Then
            Dim dialog As New Guna2MessageDialog With {
                    .Caption = "Success!",
                    .Text = "Reservation has been cancelled.",
                    .Icon = MessageDialogIcon.Information,
                    .Parent = DashboardForm
                }
            dialog.Show()
            DashboardForm.LoadData()
            Close()
        End If
    End Sub

    Private Sub BTNCHECKOUT_Click(sender As Object, e As EventArgs) Handles BTNCHECKOUT.Click
        If TransactionModel.CancelReservation(Data.Item("ID"), 3) Then
            Dim dialog As New Guna2MessageDialog With {
                    .Caption = "Success!",
                    .Text = "Reservation has been checked out.",
                    .Icon = MessageDialogIcon.Information,
                    .Parent = DashboardForm
                }
            dialog.Show()
            DashboardForm.LoadData()
            Close()
        End If
    End Sub

    Private Sub ReservationInfoDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        CMDROOMNO.DataSource = _roomsadapter.GetData
        CMDDISCOUNTVALUE.DataSource = _discountAdapter.GetData()
        CMDDISCOUNTVALUE.SelectedIndex = -1

        Dim rawdata As DataTable = TransactionModel.FetchTransactionByID(Data.Item("ID"))
        TXTINVOICENO.Text = Data.Item("INVOICE NO")
        TXTGUESTNAME.Text = Data.Item("GUEST NAME")
        TXTBOXTOTALDUE.Text = Data.Item("TOTAL DUE")
        If rawdata.Rows.Count > 0 Then
            TXTBOXROOMTYPE.Text = rawdata.Rows(0).Item("ROOM TYPE")
            CMDROOMNO.SelectedValue = rawdata.Rows(0).Item("ROOM ID")
        End If
    End Sub

    Private Sub CMDROOMNO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMDROOMNO.SelectedIndexChanged
        If CMDROOMNO.SelectedIndex <> -1 Then
            CMBRATE.DataSource = RateModel.FetchRoomType(TXTBOXROOMTYPE.Text)
        End If
    End Sub

    Private Sub BTNBACK_Click(sender As Object, e As EventArgs) Handles BTNBACK.Click
        Close()
    End Sub
End Class
