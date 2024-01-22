Imports Guna.UI2.WinForms
Imports System.Data.SqlClient

Public Class StaffModel
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
        _command = New SqlCommand("EXEC InsertStaffProcedure @room_id, @staff_code, @first_name, @last_name, @phone, @user_id", _conn)
        _command.Parameters.AddWithValue("@room_id", _data.Item("room_id"))
        _command.Parameters.AddWithValue("@staff_code", _data.Item("staff_code"))
        _command.Parameters.AddWithValue("@first_name", _data.Item("first_name"))
        _command.Parameters.AddWithValue("@last_name", _data.Item("last_name"))
        _command.Parameters.AddWithValue("@phone", _data.Item("phone"))
        _command.Parameters.AddWithValue("@user_id", My.Settings.userID)
        If _command.ExecuteNonQuery() > 0 Then
            messagebox.Caption = "Success."
            messagebox.Text = "Staff has been added successfully."
            messagebox.Icon = MessageDialogIcon.Information
        Else
            messagebox.Caption = "Failed."
            messagebox.Text = "Failed adding the staff."
            messagebox.Icon = MessageDialogIcon.Error
        End If
        messagebox.Parent = DashboardForm
        messagebox.Show()
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
        Dim command = New SqlCommand("EXEC SearchStaffProcedure @query", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@query", query)
        Dim adapter = New SqlDataAdapter(command)
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Shared Function Exists(fn As String, ln As String, p As String) As Boolean
        Dim command = New SqlCommand("SELECT CASE WHEN COUNT(*) IS NULL THEN 0 ELSE COUNT(*) END AS C FROM tblstaffs WHERE first_name = @fn AND last_name = @ln AND phone = @p", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@fn", fn)
        command.Parameters.AddWithValue("@ln", ln)
        command.Parameters.AddWithValue("@p", p)
        Return command.ExecuteScalar > 0
    End Function
End Class
