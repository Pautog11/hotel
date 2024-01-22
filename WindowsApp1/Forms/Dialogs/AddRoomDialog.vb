Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports HotelReservationSystem.hmsdbDataSetTableAdapters

Public Class AddRoomDialog
    Public Property Data As DataRowView
    Private _model As ICommands
    Private _invoker As ICommandInvoker
    Private _adapterRoomType As New viewtblroomtypeTableAdapter

    Private Sub AddRoomDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        COMBOBOXROOMTYPE.DataSource = _adapterRoomType.GetData()
        COMBOBOXROOMTYPE.DisplayMember = "ROOM TYPE"
        COMBOBOXROOMTYPE.ValueMember = "ID"
        If Data IsNot Nothing Then
            BTNDELETEROOM.Visible = True
            BTNADDROOM.Text = "UPDATE"
            TXTBOXROOMNO.Text = Data.Item("ROOM NUMBER")
            COMBOBOXROOMTYPE.SelectedValue = RoomTypeModel.FetchRoomTypeID(Data.Item("ROOM TYPE"))
        End If
    End Sub

    Private Sub BTNADDROOM_Click(sender As Object, e As EventArgs) Handles BTNADDROOM.Click
        Dim controls As Object() = {COMBOBOXROOMTYPE, TXTBOXROOMNO}
        Dim types As DataInput() = {DataInput.STRING_NAME, DataInput.STRING_INTEGER}

        Dim res As New List(Of Object())
        For i = 0 To controls.Count - 1
            res.Add(ValidationString.ValidateInputString(controls(i), types(i)))
        Next

        If Not res.Any(Function(item As Object()) Not item(0)) Then
            Dim dict As New Dictionary(Of String, String) From {
                {"id", Data?.Item("ID")},
                {"room_no", res(1)(1)},
                {"room_type_id", COMBOBOXROOMTYPE.SelectedValue}
            }

            _model = New RoomModel(dict)
            If Not RoomModel.Exists(res(1)(1)) AndAlso Data Is Nothing Then
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
        _model = New RoomModel(New Dictionary(Of String, String) From {{"id", Data.Item("ID")}})
        _invoker = New DeleteCommand(_model)
        _invoker.Invoke()
        DashboardForm.LoadData()
        Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Close()
    End Sub
End Class
