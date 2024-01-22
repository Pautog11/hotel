Imports Guna.UI2.WinForms
Imports System.Data.SqlClient

Public Class RateModel
    Inherits SqlBase
    Implements ICommands

    Public Sub New(data As Dictionary(Of String, String))
        _data = data
        messagebox = New Guna2MessageDialog
    End Sub

    Public Sub Delete() Implements ICommands.Delete
        _command = New SqlCommand("EXEC DeleteRateProcedure @id, @user_id;", _conn)
        _command.Parameters.AddWithValue("@id", _data.Item("id"))
        _command.Parameters.AddWithValue("@user_id", My.Settings.userID)
        If _command.ExecuteNonQuery() > 0 Then
            messagebox.Caption = "Success."
            messagebox.Text = "Room rate has been deleted successfully."
            messagebox.Icon = MessageDialogIcon.Information
        Else
            messagebox.Caption = "Failed."
            messagebox.Text = "Failed deleting the room rate."
            messagebox.Icon = MessageDialogIcon.Information
        End If
        messagebox.Parent = DashboardForm
        messagebox.Show()
    End Sub

    Public Sub Add() Implements ICommands.Add
        _command = New SqlCommand("EXEC InsertRateProcedure @duration, @per_rate_id, @price, @room_type_id, @user_id", _conn)
        _command.Parameters.AddWithValue("@duration", _data.Item("duration"))
        _command.Parameters.AddWithValue("@per_rate_id", _data.Item("per_rate_id"))
        _command.Parameters.AddWithValue("@price", _data.Item("price"))
        _command.Parameters.AddWithValue("@room_type_id", _data.Item("room_type_id"))
        _command.Parameters.AddWithValue("@user_id", My.Settings.userID)
        If _command.ExecuteNonQuery() > 0 Then
            messagebox.Caption = "Success."
            messagebox.Text = "Room rate has been added successfully."
            messagebox.Icon = MessageDialogIcon.Information
        Else
            messagebox.Caption = "Failed."
            messagebox.Text = "Failed adding the room rate."
            messagebox.Icon = MessageDialogIcon.Information
        End If
        messagebox.Parent = DashboardForm
        messagebox.Show()
    End Sub

    Public Sub Update() Implements ICommands.Update
        _command = New SqlCommand("EXEC UpdateRateProcedure @id, @duration, @per_rate_id, @price, @room_type_id, @user_id", _conn)
        _command.Parameters.AddWithValue("@id", _data.Item("id"))
        _command.Parameters.AddWithValue("@duration", _data.Item("duration"))
        _command.Parameters.AddWithValue("@per_rate_id", _data.Item("per_rate_id"))
        _command.Parameters.AddWithValue("@price", _data.Item("price"))
        _command.Parameters.AddWithValue("@room_type_id", _data.Item("room_type_id"))
        _command.Parameters.AddWithValue("@user_id", My.Settings.userID)
        If _command.ExecuteNonQuery() > 0 Then
            messagebox.Caption = "Success."
            messagebox.Text = "Room rate has been updated successfully."
            messagebox.Icon = MessageDialogIcon.Information
        Else
            messagebox.Caption = "Failed."
            messagebox.Text = "Failed updating the room rate."
            messagebox.Icon = MessageDialogIcon.Information
        End If
        messagebox.Parent = DashboardForm
        messagebox.Show()
    End Sub

    Public Shared Function Search(query As String) As DataTable
        Dim command = New SqlCommand("EXEC SearchRateProcedure @query", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@query", query)
        Dim adapter = New SqlDataAdapter(command)
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Shared Function FetchRateType() As DataTable
        Dim command = New SqlCommand("SELECT * FROM tblroomratetype", SqlConnectionSingleton.GetInstance)
        Dim adapter = New SqlDataAdapter(command)
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Shared Function FetchRoomType(type As String) As DataTable
        Dim command = New SqlCommand("SELECT * FROM viewtblroomrates WHERE [ROOM TYPE] = @room_type", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@room_type", type)
        Dim adapter = New SqlDataAdapter(command)
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Shared Function FetchRateTypeID(query As String) As Integer
        Dim command = New SqlCommand("SELECT id FROM tblroomratetype WHERE per_rate = @query", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@query", query)
        Return command.ExecuteScalar()
    End Function

    Public Shared Function Exists(duration As String, per_rate_id As String, room_type_id As String) As Boolean
        Dim command = New SqlCommand("SELECT CASE WHEN COUNT(*) IS NULL THEN 0 ELSE COUNT(*) END AS C FROM tblroomrate
                    WHERE duration = @duration AND
                    per_rate_id = @per_rate_id AND
                    room_type_id = @room_type_id", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@duration", duration)
        command.Parameters.AddWithValue("@per_rate_id", per_rate_id)
        command.Parameters.AddWithValue("@room_type_id", room_type_id)
        Return command.ExecuteScalar > 0
    End Function
End Class
