Imports Guna.UI2.WinForms

Public Class AddRoomTypeDialog
    Public Property Data As DataRowView
    Private _model As ICommands
    Private _invoker As ICommandInvoker
    Private Sub BTNADDDISCOUNT_Click(sender As Object, e As EventArgs) Handles BTNADDROOMTYPE.Click
        Dim res As Object() = ValidationString.ValidateInputString(TXTBOXROOMTYPE, DataInput.STRING_STRING)
        If res(0) Then
            Dim dict As New Dictionary(Of String, String)
            dict.Add("id", Data?.Item("ID"))
            dict.Add("room_type", res(1))

            _model = New RoomTypeModel(dict)
            If Not RoomTypeModel.Exists(res(1)) AndAlso Data Is Nothing Then
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

    Private Sub BTNDELETEDISCOUNT_Click(sender As Object, e As EventArgs) Handles BTNDELETEROOMTYPE.Click
        _model = New RoomTypeModel(New Dictionary(Of String, String) From {{"id", Data.Item("ID")}})
        _invoker = New DeleteCommand(_model)
        _invoker.Invoke()
        DashboardForm.LoadData()
        Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Close()
    End Sub

    Private Sub AddRoomTypeDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Data IsNot Nothing Then
            BTNDELETEROOMTYPE.Visible = True
            BTNADDROOMTYPE.Text = "UPDATE"
            TXTBOXROOMTYPE.Text = Data.Item("ROOM TYPE")
        End If
    End Sub
End Class
