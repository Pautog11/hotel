Imports HotelReservationSystem.hmsdbDataSetTableAdapters


Public Class AddReservationDialog
    Public Property Data As DataRowView = Nothing
    Private _discountAdapter As New viewtbldiscountsTableAdapter
    Private total As Decimal = 0
    Private _parent As ReservationDialog

    Public Sub New(Optional parent As ReservationDialog = Nothing)
        InitializeComponent()
        _parent = parent
        DATECHECKIN.Value = Date.Now
        CHECKINTIME.Value = DateTime.Now
    End Sub

    Private Sub BTNRESERVATION_Click(sender As Object, e As EventArgs) Handles BTNRESERVATION.Click
        Dim controls As Object() = {TXTBOXROOMTYPE}
        Dim types As DataInput() = {DataInput.STRING_NAME, DataInput.STRING_INTEGER}

        Dim res As New List(Of Object())
        For i = 0 To controls.Count - 1
            res.Add(ValidationString.ValidateInputString(controls(i), types(i)))
        Next

        If DATECHECKIN.Value.Date < Date.Now.Date.AddDays(-1) Then
            MsgBox("Invalid date selected.")
            Return
        End If

        If Not res.Any(Function(item As Object()) Not item(0)) Then
            Dim check_in_date As Date = DATECHECKIN.Value.Date
            Dim check_in_time As String = CHECKINTIME.Value.ToString("HH:mm:ss")
            Dim timesplit As String() = check_in_time.Split(":")

            Dim ntimespan As TimeSpan = New TimeSpan(CInt(timesplit(0)), CInt(timesplit(1)), 0)
            Dim check_in As DateTime = check_in_date + ntimespan
            Dim antimespan As TimeSpan = ntimespan.Add(New TimeSpan(CInt(CMBRATE.Text.Split(" ")(0)), 0, 0))
            Dim check_out As DateTime = check_in.Date + antimespan
            Dim row As DataRow = Nothing
            Dim is_existing As Boolean = False
            For Each i As DataRow In _parent._dataSource.Rows
                If i.Item("ROOM_ID") = CMDROOMNO.SelectedValue Then
                    row = i
                    is_existing = True
                End If
            Next

            If Not is_existing Then
                _parent._dataSource.Rows.Add(
                {CMDROOMNO.SelectedValue, If(CMDDISCOUNTVALUE.SelectedIndex = -1, "", CMDDISCOUNTVALUE.SelectedValue),
                -1, CMBRATE.SelectedValue, CMDROOMNO.Text, check_in, check_out,
                If(CMDDISCOUNTVALUE.SelectedIndex = -1, "None", CMDDISCOUNTVALUE.Text),
                TXTBOXTOTALDUE.Text}
            )
            Else
                row.Item("ROOM_ID") = CMDROOMNO.SelectedValue
                row.Item("DISCOUNT_ID") = CMDDISCOUNTVALUE.SelectedValue
                row.Item("ROOM_RATE_ID") = CMBRATE.SelectedValue
                row.Item("ROOM NO") = CMDROOMNO.Text
                row.Item("CHECK IN") = check_in
                row.Item("CHECK OUT") = check_out
                row.Item("TOTAL RATE") = TXTBOXTOTALDUE.Text
                row.Item("DISCOUNT") = If(CMDDISCOUNTVALUE.SelectedIndex = -1, "None", CMDDISCOUNTVALUE.Text)
            End If
            _parent.LoadData()
            Close()
        End If
    End Sub

    Private Sub AddReservationDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMDROOMNO.DataSource = RoomModel.FetchRoomsByAvailable()
        CMDDISCOUNTVALUE.DataSource = _discountAdapter.GetData()
        CMDDISCOUNTVALUE.SelectedIndex = -1

        If Data IsNot Nothing Then
            BTNREMOVEROOM.Visible = Visible
            BTNRESERVATION.Text = "UPDATE ROOM"
            DATECHECKIN.Value = Data.Item("CHECK IN")
            CHECKINTIME.Value = Data.Item("CHECK IN")
        End If
    End Sub

    Private Sub CMDROOMNO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMDROOMNO.SelectedIndexChanged
        If CMDROOMNO.SelectedIndex <> -1 Then
            Dim dr As DataRowView = CMDROOMNO.SelectedItem
            CMDDISCOUNTVALUE.SelectedIndex = -1
            TXTBOXROOMTYPE.Text = dr.Item("ROOM TYPE")
            CMBRATE.DataSource = RateModel.FetchRoomType(TXTBOXROOMTYPE.Text)
        End If
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles BTNREMOVEROOM.Click
        Dim idx As Integer = _parent._dataSource.Rows.IndexOf(Data.Row)
        _parent._dataSource.Rows.RemoveAt(idx)
        _parent.LoadData()
        Close()
    End Sub

    Private Sub CMBRATE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBRATE.SelectedIndexChanged
        If CMBRATE.SelectedIndex <> -1 Then
            Dim dr As DataRowView = CMBRATE.SelectedItem
            total = dr.Item("PRICE")
            TXTBOXTOTALDUE.Text = total
            CMDDISCOUNTVALUE.SelectedIndex = -1
        End If
    End Sub

    Private Sub BTNBACK_Click(sender As Object, e As EventArgs) Handles BTNBACK.Click
        Close()
    End Sub

    Private Sub CMDDISCOUNTVALUE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMDDISCOUNTVALUE.SelectedIndexChanged
        If CMDDISCOUNTVALUE.SelectedIndex <> -1 Then
            Dim dr As DataRowView = CMDDISCOUNTVALUE.SelectedItem
            Dim value As Integer = dr.Item("VALUE")
            Dim discount_amount = total * (value / 100)
            TXTBOXTOTALDUE.Text = total - discount_amount
        Else
            If CMBRATE.SelectedIndex <> -1 Then
                Dim dr As DataRowView = CMBRATE.SelectedItem
                total = dr.Item("PRICE")
                TXTBOXTOTALDUE.Text = total
            End If
        End If
    End Sub
End Class
