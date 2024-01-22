Imports Guna.UI2.WinForms
Imports System.Data.SqlClient

Public Class RoomTypeModel
    Inherits SqlBase
    Implements ICommands

    Public Sub New(data As Dictionary(Of String, String))
        _data = data
        messagebox = New Guna2MessageDialog
    End Sub

    Public Sub Delete() Implements ICommands.Delete
        _command = New SqlCommand("EXEC DeleteRoomTypeProcedure @id, @user_id;", _conn)
        _command.Parameters.AddWithValue("@id", _data.Item("id"))
        _command.Parameters.AddWithValue("@user_id", My.Settings.userID)
        If _command.ExecuteNonQuery() > 0 Then
            messagebox.Caption = "Success."
            messagebox.Text = "Room type has been deleted successfully."
            messagebox.Icon = MessageDialogIcon.Information
        Else
            messagebox.Caption = "Failed."
            messagebox.Text = "Failed deleting the room type."
            messagebox.Icon = MessageDialogIcon.Information
        End If
        messagebox.Parent = DashboardForm
        messagebox.Show()
    End Sub

    Public Sub Add() Implements ICommands.Add
        _command = New SqlCommand("EXEC InsertRoomTypeProcedure @room_type, @user_id", _conn)
        _command.Parameters.AddWithValue("@room_type", _data.Item("room_type"))
        _command.Parameters.AddWithValue("@user_id", My.Settings.userID)
        If _command.ExecuteNonQuery() > 0 Then
            messagebox.Caption = "Success."
            messagebox.Text = "Room type has been added successfully."
            messagebox.Icon = MessageDialogIcon.Information
        Else
            messagebox.Caption = "Failed."
            messagebox.Text = "Failed adding the room type."
            messagebox.Icon = MessageDialogIcon.Error
        End If
        messagebox.Parent = DashboardForm
        messagebox.Show()
    End Sub

    Public Sub Update() Implements ICommands.Update
        _command = New SqlCommand("EXEC UpdateRoomTypeProcedure @id, @room_type, @user_id", _conn)
        _command.Parameters.AddWithValue("@id", _data.Item("id"))
        _command.Parameters.AddWithValue("@room_type", _data.Item("room_type"))
        _command.Parameters.AddWithValue("@user_id", My.Settings.userID)
        If _command.ExecuteNonQuery() > 0 Then
            messagebox.Caption = "Success."
            messagebox.Text = "Room type has been updated successfully."
            messagebox.Icon = MessageDialogIcon.Information
        Else
            messagebox.Caption = "Success."
            messagebox.Text = "Failed updating the room type."
            messagebox.Icon = MessageDialogIcon.Error
        End If
        messagebox.Parent = DashboardForm
        messagebox.Show()
    End Sub

    Public Shared Function Search(query As String) As DataTable
        Dim command = New SqlCommand("EXEC SearchRoomTypeProcedure @query", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@query", query)
        Dim adapter = New SqlDataAdapter(command)
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Shared Function Exists(query As String) As Boolean
        Dim command = New SqlCommand("SELECT CASE WHEN COUNT(*) IS NULL THEN 0 ELSE COUNT(*) END AS C FROM tblroomtype WHERE room_type = @query", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@query", query)
        Return command.ExecuteScalar > 0
    End Function

    Public Shared Function FetchRoomTypeID(room_type As String) As Integer
        Dim command = New SqlCommand("SELECT ID FROM viewtblroomtype WHERE [ROOM TYPE] = @room_type", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@room_type", room_type)
        Return command.ExecuteScalar()
    End Function
End Class
