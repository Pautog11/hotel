Imports Guna.UI2.WinForms
Imports System.Data.SqlClient

Public Class RoomModel
    Inherits SqlBase
    Implements ICommands

    Public Sub New(data As Dictionary(Of String, String))
        _data = data
        messagebox = New Guna2MessageDialog
    End Sub

    Public Sub Delete() Implements ICommands.Delete
        _command = New SqlCommand("EXEC DeleteRoomProcedure @id, @user_id;", _conn)
        _command.Parameters.AddWithValue("@id", _data.Item("id"))
        _command.Parameters.AddWithValue("@user_id", My.Settings.userID)
        If _command.ExecuteNonQuery() > 0 Then
            messagebox.Caption = "Success."
            messagebox.Text = "Room has been deleted successfully."
            messagebox.Icon = MessageDialogIcon.Information
        Else
            messagebox.Caption = "Failed."
            messagebox.Text = "Failed deleting the room."
            messagebox.Icon = MessageDialogIcon.Error
        End If
        messagebox.Parent = DashboardForm
        messagebox.Show()
    End Sub

    Public Sub Add() Implements ICommands.Add
        _command = New SqlCommand("EXEC InsertRoomProcedure @room_type_id, @room_no, @user_id", _conn)
        _command.Parameters.AddWithValue("@room_type_id", _data.Item("room_type_id"))
        _command.Parameters.AddWithValue("@room_no", _data.Item("room_no"))
        _command.Parameters.AddWithValue("@user_id", My.Settings.userID)
        If _command.ExecuteNonQuery() > 0 Then
            messagebox.Caption = "Success."
            messagebox.Text = "Room has been added successfully."
            messagebox.Icon = MessageDialogIcon.Information
        Else
            messagebox.Caption = "Failed."
            messagebox.Text = "Failed adding the room."
            messagebox.Icon = MessageDialogIcon.Error
        End If
        messagebox.Parent = DashboardForm
        messagebox.Show()
    End Sub

    Public Sub Update() Implements ICommands.Update
        _command = New SqlCommand("EXEC UpdateRoomProcedure @id, @room_type_id, @room_no, @user_id", _conn)
        _command.Parameters.AddWithValue("@id", _data.Item("id"))
        _command.Parameters.AddWithValue("@room_type_id", _data.Item("room_type_id"))
        _command.Parameters.AddWithValue("@room_no", _data.Item("room_no"))
        _command.Parameters.AddWithValue("@user_id", My.Settings.userID)
        If _command.ExecuteNonQuery() > 0 Then
            messagebox.Caption = "Success."
            messagebox.Text = "Room has been updated successfully."
            messagebox.Icon = MessageDialogIcon.Information
        Else
            messagebox.Caption = "Success."
            messagebox.Text = "Failed updating the room."
            messagebox.Icon = MessageDialogIcon.Error
        End If
        messagebox.Parent = DashboardForm
        messagebox.Show()
    End Sub

    Public Shared Function Search(query As String) As DataTable
        Dim command = New SqlCommand("EXEC SearchRoomProcedure @query", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@query", query)
        Dim adapter = New SqlDataAdapter(command)
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Shared Function FetchRooms() As DataTable
        Dim command As New SqlCommand("SELECT * FROM viewtblrooms WHERE ID NOT IN (SELECT room_id FROM tblstaffs)", SqlConnectionSingleton.GetInstance)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Shared Function FetchRoomsByStatus(status_id As String) As DataTable
        Dim command As New SqlCommand("SELECT r.id ID,
	                                       room_no [ROOM NUMBER],
	                                       CASE WHEN room_type_id IS NULL THEN 'NONE' ELSE room_type END AS [ROOM TYPE],
	                                       status_name [STATUS]
                                    FROM dbo.tblrooms r
                                    LEFT JOIN tblroomtype t ON r.room_type_id = t.id
                                    LEFT JOIN tblstatus s ON r.status_id = s.id WHERE r.status_id = @status_id", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@status_id", status_id)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Shared Function FetchRoomsByAvailable() As DataTable
        Dim command As New SqlCommand("SELECT r.id ID,
	                                           room_no [ROOM NUMBER],
	                                           CASE WHEN room_type_id IS NULL THEN 'NONE' ELSE room_type END AS [ROOM TYPE],
	                                           status_name [STATUS]
                                        FROM dbo.tblrooms r
                                        LEFT JOIN tblroomtype t ON r.room_type_id = t.id
                                        LEFT JOIN tblstatus s ON r.status_id = s.id WHERE r.status_id = 1", SqlConnectionSingleton.GetInstance)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Shared Function FetchRoomsByType(room_type_id As String) As DataTable
        Dim command As New SqlCommand("SELECT r.id ID,
	           room_no [ROOM NUMBER],
	           CASE WHEN room_type_id IS NULL THEN 'NONE' ELSE room_type END AS [ROOM TYPE],
	           status_name [STATUS]
        FROM dbo.tblrooms r
        LEFT JOIN tblroomtype t ON r.room_type_id = t.id
        LEFT JOIN tblstatus s ON r.status_id = s.id WHERE r.room_type_id = @room_type_id", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@room_type_id", room_type_id)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Shared Function FetchRoomsByStatusAndType(type As String, status As String) As DataTable
        Dim command As New SqlCommand("SELECT r.id ID,
	           room_no [ROOM NUMBER],
	           CASE WHEN room_type_id IS NULL THEN 'NONE' ELSE room_type END AS [ROOM TYPE],
	           status_name [STATUS]
        FROM dbo.tblrooms r
        LEFT JOIN tblroomtype t ON r.room_type_id = t.id
        LEFT JOIN tblstatus s ON r.status_id = s.id WHERE r.room_type_id = @type AND r.status_id = @status", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@type", type)
        command.Parameters.AddWithValue("@status", status)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Shared Function Exists(query As String) As Boolean
        Dim command = New SqlCommand("SELECT CASE WHEN COUNT(*) IS NULL THEN 0 ELSE COUNT(*) END AS C FROM tblrooms WHERE room_no = @query", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@query", query)
        Return command.ExecuteScalar > 0
    End Function

    Public Shared Function FetchRooms(query As String) As Integer
        Dim command As New SqlCommand("SELECT ID FROM viewtblrooms WHERE [ROOM NUMBER] = @room_no", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@room_no", query)
        Return command.ExecuteScalar()
    End Function
End Class
