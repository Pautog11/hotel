Imports Guna.UI2.WinForms

Public Class AddStaffDialog
    Public Property Data As DataRowView
    Private _model As ICommands
    Private _invoker As ICommandInvoker
    Private Sub AddStaffDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        COMBOBOXROOM.DataSource = RoomModel.FetchRooms()
        If Data IsNot Nothing Then
            BTNDELETESTAFF.Visible = True
            BTNADDSTAFF.Text = "UPDATE"
            Dim name As String() = Data.Item("FULL NAME").ToString.Split(" ")
            TXTBOXFIRSTNAME.Text = String.Join(" ", name.Take(name.Count - 1))
            TXTBOXLASTNAME.Text = name.Last()
            TXTBOXPHONE.Text = Data.Item("PHONE")
            TXTBOXSTAFFCODE.Text = Data.Item("STAFF CODE")
            COMBOBOXROOM.SelectedValue = RoomModel.FetchRooms(Data.Item("ROOM NUMBER"))
        End If
    End Sub

    Private Sub BTNADDUSER_Click(sender As Object, e As EventArgs) Handles BTNADDSTAFF.Click
        Dim controls As Object() = {TXTBOXFIRSTNAME, TXTBOXLASTNAME, TXTBOXPHONE, TXTBOXSTAFFCODE, COMBOBOXROOM}
        Dim types As DataInput() = {DataInput.STRING_NAME, DataInput.STRING_NAME, DataInput.STRING_PHONE, DataInput.STRING_INTEGER, DataInput.STRING_STRING}

        Dim res As New List(Of Object())
        For i = 0 To controls.Count - 1
            res.Add(ValidationString.ValidateInputString(controls(i), types(i)))
        Next

        If Not res.Any(Function(item As Object()) Not item(0)) Then
            Dim dict As New Dictionary(Of String, String) From {
                {"id", Data?.Item("ID")},
                {"room_id", COMBOBOXROOM.SelectedValue},
                {"staff_code", res(4)(1)},
                {"first_name", res(0)(1)},
                {"last_name", res(1)(1)},
                {"phone", res(2)(1)}
            }
            _model = New StaffModel(dict)
            If Not StaffModel.Exists(res(0)(1), res(1)(1), res(2)(1)) AndAlso Data Is Nothing Then
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

    Private Sub BTNDELETE_Click(sender As Object, e As EventArgs) Handles BTNDELETESTAFF.Click
        _model = New StaffModel(New Dictionary(Of String, String) From {{"id", Data.Item("ID")}})
        _invoker = New DeleteCommand(_model)
        _invoker.Invoke()
        DashboardForm.LoadData()
        Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Close()
    End Sub
End Class
