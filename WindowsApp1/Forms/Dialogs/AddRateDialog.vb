Imports Guna.UI2.WinForms
Imports HotelReservationSystem.hmsdbDataSetTableAdapters

Public Class AddRateDialog
    Public Property Data As DataRowView
    Private _model As ICommands
    Private _invoker As ICommandInvoker
    Private _roomTypeAdapter As New viewtblroomtypeTableAdapter
    Private Sub AddRateDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        COMBOBOXRATETYPE.DataSource = RateModel.FetchRateType()
        CMBROOMTYPE.DataSource = _roomTypeAdapter.GetData()
        If Data IsNot Nothing Then
            BTNDELETEROOM.Visible = True
            BTNADDROOM.Text = "UPDATE"
            TXTBOXRATE.Text = Data.Item("RATE").ToString.Split(" ")(0)
            PRICE.Text = Data.Item("PRICE")
            COMBOBOXRATETYPE.SelectedValue = RateModel.FetchRateTypeID(Data.Item("RATE").ToString.Split(" ")(1))
            CMBROOMTYPE.SelectedValue = RoomTypeModel.FetchRoomTypeID(Data.Item("ROOM TYPE"))
        Else
            COMBOBOXRATETYPE.SelectedIndex = 0
            CMBROOMTYPE.SelectedIndex = 0
        End If
    End Sub

    Private Sub BTNADDROOM_Click(sender As Object, e As EventArgs) Handles BTNADDROOM.Click
        Dim controls As Object() = {TXTBOXRATE, COMBOBOXRATETYPE, PRICE}
        Dim types As DataInput() = {DataInput.STRING_INTEGER, DataInput.STRING_STRING, DataInput.STRING_INTEGER}

        Dim res As New List(Of Object())
        For i = 0 To controls.Count - 1
            res.Add(ValidationString.ValidateInputString(controls(i), types(i)))
        Next

        If Not res.Any(Function(item As Object()) Not item(0)) Then
            Dim dict As New Dictionary(Of String, String) From {
                {"id", Data?.Item("ID")},
                {"duration", res(0)(1)},
                {"per_rate_id", COMBOBOXRATETYPE.SelectedValue},
                {"price", res(2)(1)},
                {"room_type_id", CMBROOMTYPE.SelectedValue}
            }


            _model = New RateModel(dict)
            If Not RateModel.Exists(res(0)(1), COMBOBOXRATETYPE.SelectedValue, CMBROOMTYPE.SelectedValue) AndAlso Data Is Nothing Then
                _invoker = New AddCommand(_model)
            ElseIf Data IsNot Nothing Then
                _invoker = New UpdateCommnad(_model)
            Else
                Dim dialog As New Guna2MessageDialog With {
                    .Caption = "Exists",
                    .Text = "Discount already exists",
                    .Icon = MessageDialogIcon.Information,
                    .Parent = DashboardForm
                }
                dialog.Show()
                Return
            End If
            _invoker.Invoke()
            DashboardForm.LoadData()
            Close()
        End If

    End Sub

    Private Sub BTNDELETEROOM_Click(sender As Object, e As EventArgs) Handles BTNDELETEROOM.Click
        _model = New RateModel(New Dictionary(Of String, String) From {{"id", Data.Item("ID")}})
        _invoker = New DeleteCommand(_model)
        _invoker.Invoke()
        DashboardForm.LoadData()
        Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Close()
    End Sub
End Class