Imports System.ComponentModel
Imports System.Windows
Imports Guna.UI2.WinForms
Imports HotelReservationSystem.hmsdbDataSet
Imports HotelReservationSystem.hmsdbDataSetTableAdapters

Public Class DashboardForm
    Protected _discountAdapter As New viewtbldiscountsTableAdapter
    Protected _usersAdapter As New viewtblusersTableAdapter
    Protected _roomsAdapter As New viewtblroomsTableAdapter
    Protected _roomstatusAdapter As New viewtblroomsstatusTableAdapter
    Protected _roomratesAdapter As New viewtblroomratesTableAdapter
    Protected _reservationsAdapter As New viewtbltransactionsTableAdapter
    Protected _guestsAdapter As New viewtblguestsTableAdapter
    Protected _staffsAdapter As New viewtblstaffsTableAdapter
    Protected _logsAdapter As New viewtbllogsTableAdapter
    Protected _roomtypeAdapter As New viewtblroomtypeTableAdapter
    Protected _roomstatus As New tblstatusTableAdapter
    Protected _auditAdapter As New viewtblauditTableAdapter
    Private ReadOnly _customCalendar As New CustomCalendar With {
        .TopLevel = False,
        .Dock = DockStyle.Fill
    }

    Public listOfDates As New List(Of DateTime)
    ''' <summary>
    '''  Use for switching the tabs
    ''' </summary>
    Private Sub SwitchPanels(sender As Object, e As EventArgs) Handles BTNROOMS.Click, BTNMAINTAINANCE.Click,
            BTNRESERVATION.Click, BTNDASHBOARD.Click, BTNCALENDAR.Click, BTNAUDITTRAIL.Click
        Select Case True
            Case sender.Equals(BTNDASHBOARD)
                FORMTABCONTROL.SelectTab(0)
            Case sender.Equals(BTNMAINTAINANCE)
                FORMTABCONTROL.SelectTab(1)
            Case sender.Equals(BTNROOMS)
                FORMTABCONTROL.SelectTab(2)
            Case sender.Equals(BTNRESERVATION)
                FORMTABCONTROL.SelectTab(3)
            Case sender.Equals(BTNCALENDAR)
                FORMTABCONTROL.SelectTab(4)
            Case sender.Equals(BTNAUDITTRAIL)
                FORMTABCONTROL.SelectTab(5)
        End Select

    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()

        ' Make the window take full screen
        Location = New Drawing.Point(0, 0)
        Size = Screen.PrimaryScreen.WorkingArea.Size

        TransactionModel.FetchCheckOuts()
        TimeStart.Start()

        CMBSTATUSRESERVATION.DataSource = TransactionModel.FetchStatus()

        CALENDARPANEL.Controls.Add(_customCalendar)
        _customCalendar.Show()
    End Sub

    Public Sub LoadData()
        ' UPDATE ALL THE DATAGRID VIEWS
        USERDATAGRIDVIEW.DataSource = _usersAdapter.GetData()
        ROOMDATAGRIDVIEW.DataSource = _roomsAdapter.GetData()
        ROOMTYPEDATAGRIDVIEW.DataSource = _roomtypeAdapter.GetData()
        STAFFDATAGRIDVIEW.DataSource = _staffsAdapter.GetData()
        DISCOUNTDATAGRIDVIEW.DataSource = _discountAdapter.GetData()
        ROOMRATEDATAGRIDVIEW.DataSource = _roomratesAdapter.GetData()
        ROOMSTATUSDATAGRIDVIEW.DataSource = _roomstatusAdapter.GetData()
        RESERVATIONSDATAGRIDVIEW.DataSource = _reservationsAdapter.GetData()
        DGAUDIT.DataSource = _auditAdapter.GetData()

        Dim room_type_filter As viewtblroomtypeDataTable = _roomtypeAdapter.GetData
        room_type_filter.Rows.Add({-1, "ALL"})
        CMBROOMTYPEFILTER.DataSource = room_type_filter
        COMBOBOXROOMTYPE.DataSource = room_type_filter

        Dim room_status As tblstatusDataTable = _roomstatus.GetData
        room_status.Rows.Add(-1, "ALL")
        COMBOBOXSTATUS.DataSource = room_status
        COMBOBOXROOMTYPE.SelectedValue = -1
        COMBOBOXSTATUS.SelectedValue = -1

        _customCalendar.ChangeDates()
        BackgroundChecker.RunWorkerAsync(1000)
    End Sub

    Private Sub Add_ClickEvents(sender As Object, e As EventArgs) Handles BTNADDDISCOUNTS.Click,
        BTNADDUSER.Click, BTNADDROOMS.Click, BTNADDROOMTYPE.Click, BTNADDSTAFF.Click, BTNADDRESERVATION.Click,
        BTNADDRATES.Click, BTNEXIT.Click

        If sender.Equals(BTNEXIT) Then
            Dim msg As New Guna2MessageDialog With {
                .Text = "Do you want to exit?",
                .Buttons = MessageDialogButtons.YesNo,
                .Caption = "Exit",
                .Icon = MessageDialogIcon.Information,
                .Parent = Me
            }
            Dim res As MessageBoxResult = msg.Show
            If res = MessageBoxResult.Yes Then
                LoginForm.Show()
                Close()
            End If
            Return
        End If

        Dim dialog As Object = Nothing
        Select Case True
            Case sender.Equals(BTNADDDISCOUNTS)
                dialog = New AddDiscountDialog()
            Case sender.Equals(BTNADDUSER)
                dialog = New AddUserDialog
            Case sender.Equals(BTNADDROOMS)
                dialog = New AddRoomDialog
            Case sender.Equals(BTNADDRATES)
                dialog = New AddRateDialog
            Case sender.Equals(BTNADDROOMTYPE)
                dialog = New AddRoomTypeDialog
            Case sender.Equals(BTNADDSTAFF)
                dialog = New AddStaffDialog
            Case sender.Equals(BTNADDRESERVATION)
                dialog = New ReservationDialog()
        End Select
        dialog?.ShowDialog()
    End Sub

    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DISCOUNTDATAGRIDVIEW.CellClick,
            USERDATAGRIDVIEW.CellClick, RESERVATIONSDATAGRIDVIEW.CellClick, ROOMRATEDATAGRIDVIEW.CellClick,
            ROOMSTATUSDATAGRIDVIEW.CellClick, ROOMDATAGRIDVIEW.CellClick, STAFFDATAGRIDVIEW.CellClick, ROOMTYPEDATAGRIDVIEW.CellClick
        Dim dialog As Object = Nothing
        If TryCast(sender, Guna2DataGridView).SelectedRows.Count > 0 Then
            Select Case True
                Case sender.Equals(DISCOUNTDATAGRIDVIEW)
                    dialog = New AddDiscountDialog
                Case sender.Equals(USERDATAGRIDVIEW)
                    dialog = New AddUserDialog
                Case sender.Equals(ROOMRATEDATAGRIDVIEW)
                    dialog = New AddRateDialog
                Case sender.Equals(RESERVATIONSDATAGRIDVIEW)
                    dialog = New ReservationInfoDialog
                Case sender.Equals(ROOMSTATUSDATAGRIDVIEW)
                    dialog = New RoomInfo
                Case sender.Equals(ROOMDATAGRIDVIEW)
                    dialog = New AddRoomDialog
                Case sender.Equals(STAFFDATAGRIDVIEW)
                    dialog = New AddStaffDialog
                Case sender.Equals(ROOMTYPEDATAGRIDVIEW)
                    dialog = New AddRoomTypeDialog
            End Select
            dialog.Data = sender.SelectedRows.Item(0).DataBoundItem()
            dialog?.ShowDialog()
        End If

    End Sub

    Private Sub Search_ClickEvents(sender As Object, e As EventArgs) Handles BTNUSERSEARCH.Click,
            BTNROOMSEARCH.Click, BTNDISCOUNTSEARCH.Click, BTNROOMTYPESEARCH.Click, BTNRATESEARCH.Click,
            BTNSTAFFSEARCH.Click, BTNSEARCHRESERVATION.Click
        Select Case True
            Case sender.Equals(BTNUSERSEARCH)
                USERDATAGRIDVIEW.DataSource = AccountsModel.Search(TXTBOXSEARCHUSER.Text)
            Case sender.Equals(BTNDISCOUNTSEARCH)
                DISCOUNTDATAGRIDVIEW.DataSource = DiscountModel.Search(TXTBOXSEARCHDISCOUNTS.Text)
            Case sender.Equals(BTNROOMSEARCH)
                ROOMDATAGRIDVIEW.DataSource = RoomModel.Search(TXTBOXSEARCHROOM.Text)
            Case sender.Equals(BTNROOMTYPESEARCH)
                ROOMTYPEDATAGRIDVIEW.DataSource = RoomTypeModel.Search(TXTBOXSEARCHROOMTYPE.Text)
            Case sender.Equals(BTNSTAFFSEARCH)
                STAFFDATAGRIDVIEW.DataSource = StaffModel.Search(TXTBOXSEARCHSTAFF.Text)
            Case sender.Equals(BTNRATESEARCH)
                ROOMRATEDATAGRIDVIEW.DataSource = RateModel.Search(TXTBOXSEARCHRATE.Text)
            Case sender.Equals(BTNSEARCHRESERVATION)
                RESERVATIONSDATAGRIDVIEW.DataSource = TransactionModel.Search(TXTBOXTRANSACTIONSEARCH.Text)
        End Select
    End Sub

    Private Sub COMBOBOXSTATUS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMBOBOXSTATUS.SelectedIndexChanged, COMBOBOXROOMTYPE.SelectedIndexChanged
        If COMBOBOXROOMTYPE.SelectedValue = -1 AndAlso COMBOBOXSTATUS.SelectedValue = -1 Then
            ROOMSTATUSDATAGRIDVIEW.DataSource = _roomstatusAdapter.GetData
        Else
            If COMBOBOXSTATUS.SelectedValue <> -1 AndAlso COMBOBOXROOMTYPE.SelectedValue = -1 Then
                ROOMSTATUSDATAGRIDVIEW.DataSource = RoomModel.FetchRoomsByStatus(COMBOBOXSTATUS.SelectedValue)
            ElseIf COMBOBOXSTATUS.SelectedValue = -1 AndAlso COMBOBOXROOMTYPE.SelectedValue <> -1 Then
                ROOMSTATUSDATAGRIDVIEW.DataSource = RoomModel.FetchRoomsByType(COMBOBOXROOMTYPE.SelectedValue)
            Else
                If COMBOBOXSTATUS.SelectedIndex <> -1 AndAlso COMBOBOXROOMTYPE.SelectedIndex <> -1 Then
                    ROOMSTATUSDATAGRIDVIEW.DataSource = RoomModel.FetchRoomsByStatusAndType(COMBOBOXROOMTYPE.SelectedValue, COMBOBOXSTATUS.SelectedValue)
                Else

                End If
            End If
        End If
    End Sub

    Private Sub CMBROOMTYPEFILTER_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBROOMTYPEFILTER.SelectedIndexChanged
        If CMBROOMTYPEFILTER.SelectedValue = -1 Then
            ROOMDATAGRIDVIEW.DataSource = _roomsAdapter.GetData
        Else
            ROOMDATAGRIDVIEW.DataSource = RoomModel.FetchRoomsByType(CMBROOMTYPEFILTER.SelectedValue)
        End If
    End Sub

    Private Sub BackgroundChecker_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundChecker.DoWork
        Dim arg As Integer = e.Argument
        e.Result = BackgroundCheckLogic(sender, arg)
        If (TryCast(sender, BackgroundWorker).CancellationPending) Then
            e.Cancel = True
        End If
    End Sub

    Private Function BackgroundCheckLogic(sender As Object, e As Integer) As Integer
        Dim item_to_remove As DateTime = Nothing
        For Each itemDate As DateTime In listOfDates
            If itemDate.ToString("hh:mm tt") = DateTime.Now.ToString("hh:mm tt") Then
                Dim extended As New ExtendedDialog
                extended.Parent = Me
                extended.ShowDialog()
                item_to_remove = itemDate
                Exit For
            End If
        Next

        If listOfDates.Contains(item_to_remove) Then
            listOfDates.Remove(item_to_remove)
        End If
        Return 0
    End Function

    Private Sub BackgroundComplete(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundChecker.RunWorkerCompleted
        If e.Error IsNot Nothing Then
            MessageDialog.Show(e.Error.Message)
        End If
    End Sub

    Private Sub TimeStart_Tick(sender As Object, e As EventArgs) Handles TimeStart.Tick
        If Not BackgroundChecker.IsBusy Then
            BackgroundChecker.RunWorkerAsync()
        End If
    End Sub
End Class