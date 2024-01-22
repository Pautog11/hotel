Imports System.Windows.Forms
Imports HotelReservationSystem.hmsdbDataSetTableAdapters

Public Class RoomInfo

    Public Property Data As DataRowView
    Private _model As ICommands
    Private _invoker As ICommandInvoker
    Private _adapterRoomType As New viewtblroomtypeTableAdapter

    Private Sub AddRoomDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        COMBOBOXROOMTYPE.DataSource = _adapterRoomType.GetData()
        COMBOBOXROOMTYPE.DisplayMember = "ROOM TYPE"
        COMBOBOXROOMTYPE.ValueMember = "ID"
        If Data IsNot Nothing Then
            TXTBOXROOMNO.Text = Data.Item("ROOM NUMBER")
            COMBOBOXROOMTYPE.SelectedValue = RoomTypeModel.FetchRoomTypeID(Data.Item("ROOM TYPE"))
            TXTSTATUS.Text = Data.Item("STATUS")

            Dim _data As DataTable = TransactionModel.FetchTransactionByRoomID(Data.Item("ID"))
            If _data.Rows.Count > 0 Then
                TXTGUESTNAME.Text = _data.Rows(0).Item("GUEST NAME")
                DATECHECKIN.Value = Date.Parse(_data.Rows(0).Item("CHECK IN"))
                DATECHECKOUT.Value = Date.Parse(_data.Rows(0).Item("CHECK OUT"))
            End If
        End If
    End Sub

    Private Sub BTNADDROOM_Click(sender As Object, e As EventArgs) Handles BTNADDROOM.Click
        Close()
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Close()
    End Sub

End Class
