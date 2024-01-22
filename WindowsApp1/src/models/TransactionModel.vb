Imports Guna.UI2.WinForms
Imports System.Data.SqlClient

Public Class TransactionModel
    Inherits SqlBase
    Implements ICommands

    Public Sub New(data As Dictionary(Of String, String))
        _data = data
        messagebox = New Guna2MessageDialog
    End Sub

    Public Sub Delete() Implements ICommands.Delete
        _command = New SqlCommand("EXEC DeleteStaffProcedure @id, @user_id;", _conn)
        _command.Parameters.AddWithValue("@id", _data.Item("id"))
        _command.Parameters.AddWithValue("@user_id", My.Settings.userID)
        If _command.ExecuteNonQuery() > 0 Then
            messagebox.Caption = "Success."
            messagebox.Text = "Staff has been deleted successfully."
            messagebox.Icon = MessageDialogIcon.Information
        Else
            messagebox.Caption = "Failed."
            messagebox.Text = "Failed deleting the staff."
            messagebox.Icon = MessageDialogIcon.Error
        End If
        messagebox.Parent = DashboardForm
        messagebox.Show()
    End Sub

    Public Sub Add() Implements ICommands.Add
        _command = New SqlCommand("EXEC InsertReservationProcedure @room_id, @discount_id, @guest_id, @room_rate_id, @transaction_no, @check_in, @check_out, @total_rate, @user_id", _conn)
        _command.Parameters.AddWithValue("@room_id", _data.Item("room_id"))
        _command.Parameters.AddWithValue("@discount_id", If(_data.Item("discount_id") = "", DBNull.Value, _data.Item("discount_id")))
        _command.Parameters.AddWithValue("@guest_id", _data.Item("guest_id"))
        _command.Parameters.AddWithValue("@room_rate_id", _data.Item("room_rate_id"))
        _command.Parameters.AddWithValue("@transaction_no", _data.Item("transaction_no"))
        _command.Parameters.AddWithValue("@check_in", CDate(_data.Item("check_in")))
        _command.Parameters.AddWithValue("@check_out", CDate(_data.Item("check_out")))
        _command.Parameters.AddWithValue("@total_rate", _data.Item("total_rate"))
        _command.Parameters.AddWithValue("@user_id", My.Settings.userID)
        If _command.ExecuteNonQuery() = 0 Then
            messagebox.Caption = "Failed."
            messagebox.Text = "Failed adding the staff."
            messagebox.Icon = MessageDialogIcon.Error
            messagebox.Parent = DashboardForm
            messagebox.Show()
        End If

    End Sub

    Public Sub Update() Implements ICommands.Update
        _command = New SqlCommand("EXEC UpdateStaffProcedure @id, @room_id, @staff_code, @first_name, @last_name, @phone, @user_id", _conn)
        _command.Parameters.AddWithValue("@id", _data.Item("id"))
        _command.Parameters.AddWithValue("@room_id", _data.Item("room_id"))
        _command.Parameters.AddWithValue("@staff_code", _data.Item("staff_code"))
        _command.Parameters.AddWithValue("@first_name", _data.Item("first_name"))
        _command.Parameters.AddWithValue("@last_name", _data.Item("last_name"))
        _command.Parameters.AddWithValue("@phone", _data.Item("phone"))
        _command.Parameters.AddWithValue("@user_id", My.Settings.userID)
        If _command.ExecuteNonQuery() > 0 Then
            messagebox.Caption = "Success."
            messagebox.Text = "Staff has been updated successfully."
            messagebox.Icon = MessageDialogIcon.Information
        Else
            messagebox.Caption = "Failed."
            messagebox.Text = "Failed updating the staff."
            messagebox.Icon = MessageDialogIcon.Error
        End If
        messagebox.Parent = DashboardForm
        messagebox.Show()
    End Sub

    Public Shared Function Search(query As String) As DataTable
        Dim command = New SqlCommand("SELECT * FROM viewtbltransactions WHERE [INVOICE NO] LIKE CONCAT('%', @query, '%')", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@query", query)
        Dim adapter = New SqlDataAdapter(command)
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Shared Function FetchStatus() As DataTable
        Dim command = New SqlCommand("SELECT * FROM tblreservationstatus", SqlConnectionSingleton.GetInstance)
        Dim adapter = New SqlDataAdapter(command)
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Shared Function FetchTransactionByDate(query As String) As DataTable
        Dim command = New SqlCommand("SELECT * FROM viewtbltransactions WHERE CONVERT(VARCHAR, [CHECK IN], 3) = CONVERT(VARCHAR,@query,3)", SqlConnectionSingleton.GetInstance)
        command.Parameters.Add("@query", SqlDbType.Date).Value = query
        Dim adapter = New SqlDataAdapter(command)
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Shared Function FetchTransactionByRoomID(query As String) As DataTable
        Dim command = New SqlCommand("EXEC FetchReservationByRoomIDProcedure @query", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@query", query)
        Dim adapter = New SqlDataAdapter(command)
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Shared Function FetchTransactionByID(id As String) As DataTable
        Dim command = New SqlCommand("EXEC FetchReservationByIDProcedure @id", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@id", id)
        Dim adapter = New SqlDataAdapter(command)
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Shared Function FetchGuest() As DataTable
        Dim command = New SqlCommand("SELECT id, CONCAT(first_name, ' ', last_name) name, phone FROM tblguests", SqlConnectionSingleton.GetInstance)
        Dim adapter = New SqlDataAdapter(command)
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Shared Sub FetchCheckOuts()
        Dim command = New SqlCommand("SELECT check_out - CAST('05:59' AS datetime) as c FROM tbltransactions WHERE reservation_status_id = 1 AND CAST(check_out AS DATE) = CAST(GETDATE() AS DATE) ORDER BY check_out DESC", SqlConnectionSingleton.GetInstance)
        Dim adapter = New SqlDataAdapter(command)
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        For Each item As DataRow In dataTable.Rows
            If Not DBNull.Value.Equals(item.Item("c")) Then
                DashboardForm.listOfDates.Add(item.Item("c"))
            End If
        Next
    End Sub



    Public Shared Function CancelReservation(query As String, status As String) As Boolean
        Dim command = New SqlCommand("UPDATE tbltransactions SET reservation_status_id  = @s WHERE id = @id", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@id", query)
        command.Parameters.AddWithValue("@s", status)


        If status = "2" OrElse status = "3" AndAlso command.ExecuteNonQuery() > 0 Then
            command = New SqlCommand("UPDATE tblrooms SET status_id = 1 WHERE id = (SELECT room_id FROM tbltransactions WHERE id = @id)", SqlConnectionSingleton.GetInstance)
            command.Parameters.AddWithValue("@id", query)
        End If
        Return command.ExecuteNonQuery > 0
    End Function
End Class

