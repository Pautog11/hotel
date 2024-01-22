Imports Guna.UI2.WinForms

Public Class ReservationDialog
    Public Property Data As DataRowView
    Private _model As ICommands
    Private _invoker As ICommandInvoker
    Public _dataSource As DataTable
    Private _guest_id As Integer

    Public Sub New()
        InitializeComponent()
        _dataSource = New DataTable
        _dataSource.Columns.Add("ROOM_ID")
        _dataSource.Columns.Add("DISCOUNT_ID")
        _dataSource.Columns.Add("GUEST_ID")
        _dataSource.Columns.Add("ROOM_RATE_ID")
        _dataSource.Columns.Add("ROOM NO")
        _dataSource.Columns.Add("CHECK IN").DataType = GetType(DateTime)
        _dataSource.Columns.Add("CHECK OUT").DataType = GetType(Date)
        _dataSource.Columns.Add("DISCOUNT")
        _dataSource.Columns.Add("TOTAL RATE")
        ROOMSDATAGRIDVIEW.DataSource = _dataSource
    End Sub

    Private Sub ADDRESERVATION_Click(sender As Object, e As EventArgs) Handles ADDRESERVATION.Click
        If CMBGUESTS.SelectedIndex <> -1 Then
            For Each item As DataRow In _dataSource.Rows
                Dim _data As New Dictionary(Of String, String) From {
                    {"room_id", item.Item("ROOM_ID")},
                    {"discount_id", If(item.Item("DISCOUNT_ID") = "", "", item.Item("DISCOUNT_ID"))},
                    {"guest_id", _guest_id},
                    {"room_rate_id", item.Item("room_rate_id")},
                    {"transaction_no", TXTBOXINVOICENUMBER.Text},
                    {"check_in", item.Item("CHECK IN")},
                    {"check_out", item.Item("CHECK OUT")},
                    {"total_rate", item.Item("TOTAL RATE")}
                }
                Dim cmd As ICommands = New TransactionModel(_data)
                Dim invoker As ICommandInvoker = New AddCommand(cmd)
                invoker.Invoke()
            Next

            Dim messagebox As New Guna2MessageDialog With {
                .Caption = "Success.",
                .Text = "Reservation added successfully.",
                .Icon = MessageDialogIcon.Information,
                .Parent = DashboardForm
            }
            messagebox.Show()
            DashboardForm.LoadData()
            Close()
        Else
            Dim messagebox As New Guna2MessageDialog With {
                .Caption = "Empty Guest.",
                .Text = "Please select a guest.",
                .Icon = MessageDialogIcon.Information,
                .Parent = DashboardForm
            }
            messagebox.Show()
        End If
        TransactionModel.FetchCheckOuts()
    End Sub

    Private Sub ReservationDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        ROOMSDATAGRIDVIEW.Columns.Item(0).Visible = False
        ROOMSDATAGRIDVIEW.Columns.Item(1).Visible = False
        ROOMSDATAGRIDVIEW.Columns.Item(2).Visible = False
        ROOMSDATAGRIDVIEW.Columns.Item(3).Visible = False
        TXTBOXINVOICENUMBER.Text = GenInvoiceNumber()
        CMBGUESTS.DataSource = TransactionModel.FetchGuest()
    End Sub

    Public Sub LoadData()
        ROOMSDATAGRIDVIEW.DataSource = _dataSource
        Dim total As Decimal = 0
        For i = 0 To _dataSource.Rows.Count - 1
            total += _dataSource.Rows.Item(0).Item("TOTAL RATE")
        Next
        TXTBOXTOTAL.Text = total
    End Sub

    Private Sub BTNBACK_Click(sender As Object, e As EventArgs) Handles BTNBACK.Click
        Close()
    End Sub

    Private Sub BTNRESERVATION_Click(sender As Object, e As EventArgs) Handles BTNRESERVATION.Click
        Dim roomDialog As New AddReservationDialog(Me)
        roomDialog.ShowDialog()
    End Sub

    Private Sub ROOMSDATAGRIDVIEW_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ROOMSDATAGRIDVIEW.CellClick
        If ROOMSDATAGRIDVIEW.SelectedRows.Count > 0 Then
            Dim roomDialog As New AddReservationDialog(Me)
            roomDialog.Data = ROOMSDATAGRIDVIEW.SelectedRows(0).DataBoundItem
            roomDialog.ShowDialog()
        End If
    End Sub

    Private Sub CMBGUESTS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBGUESTS.SelectedIndexChanged
        If CMBGUESTS.SelectedIndex <> -1 Then

            Dim dr As DataRowView = CMBGUESTS.SelectedItem
            _guest_id = CMBGUESTS.SelectedValue
            TXTBOXPHONE.Text = dr.Item("phone")
        End If
    End Sub
End Class