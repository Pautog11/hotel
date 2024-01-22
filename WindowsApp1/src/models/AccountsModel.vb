Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class AccountsModel
    Inherits SqlBase
    Implements ICommands

    Public Sub New(data As Dictionary(Of String, String))
        _data = data
        messagebox = New Guna2MessageDialog
    End Sub

    Public Sub Delete() Implements ICommands.Delete
        Try
            _command = New SqlCommand("EXEC DeleteUserProcedure @id, @user_id;", _conn)
            _command.Parameters.AddWithValue("@id", _data.Item("id"))
            _command.Parameters.AddWithValue("@user_id", My.Settings.userID)
            If _command.ExecuteNonQuery() > 0 Then
                messagebox.Caption = "Success."
                messagebox.Text = "User has been deleted successfully."
                messagebox.Icon = MessageDialogIcon.Information
            Else
                messagebox.Caption = "Failed."
                messagebox.Text = "Failed deleting the user."
                messagebox.Icon = MessageDialogIcon.Error
            End If
        Catch ex As Exception
            messagebox.Caption = "Failed."
            messagebox.Text = ex.Message
            messagebox.Icon = MessageDialogIcon.Error
        End Try
        messagebox.Parent = DashboardForm
        messagebox.Show()
    End Sub

    Public Sub Add() Implements ICommands.Add
        Try
            _command = New SqlCommand("EXEC InsertUserProcedure @username, @password, @user_id", _conn)
            _command.Parameters.AddWithValue("@username", _data.Item("username"))
            _command.Parameters.AddWithValue("@password", _data.Item("password"))
            _command.Parameters.AddWithValue("@user_id", My.Settings.userID)
            If _command.ExecuteNonQuery() > 0 Then
                messagebox.Caption = "Success."
                messagebox.Text = "User has been added successfully."
                messagebox.Icon = MessageDialogIcon.Information
            Else
                messagebox.Caption = "Failed."
                messagebox.Text = "Failed adding the user."
                messagebox.Icon = MessageDialogIcon.Error
            End If
        Catch ex As Exception
            messagebox.Caption = "Failed."
            messagebox.Text = ex.Message
            messagebox.Icon = MessageDialogIcon.Error
        End Try
        messagebox.Parent = DashboardForm
        messagebox.Show()
    End Sub

    Public Sub Update() Implements ICommands.Update
        Try
            _command = New SqlCommand("EXEC UpdateUserProcedure @id, @username, @password, @user_id", _conn)
            _command.Parameters.AddWithValue("@id", _data.Item("id"))
            _command.Parameters.AddWithValue("@username", _data.Item("username"))
            _command.Parameters.AddWithValue("@password", _data.Item("password"))
            If _command.ExecuteNonQuery() > 0 Then
                messagebox.Caption = "Success."
                messagebox.Text = "User has been updated successfully."
                messagebox.Icon = MessageDialogIcon.Information
            Else
                messagebox.Caption = "Success."
                messagebox.Text = "Failed updating the user."
                messagebox.Icon = MessageDialogIcon.Error
            End If
        Catch ex As Exception
            messagebox.Caption = "Failed."
            messagebox.Text = ex.Message
            messagebox.Icon = MessageDialogIcon.Error
        End Try
        messagebox.Parent = DashboardForm
        messagebox.Show()
    End Sub

    Public Shared Function Search(query As String) As DataTable
        Try
            Dim command = New SqlCommand("EXEC SearchUserProcedure @username", SqlConnectionSingleton.GetInstance)
            command.Parameters.AddWithValue("@username", query)
            Dim adapter = New SqlDataAdapter(command)
            Dim dataTable = New DataTable
            adapter.Fill(dataTable)
            Return dataTable
        Catch e As Exception
            MsgBox(e.Message)
        End Try
        Return Nothing
    End Function

    Public Shared Function Exists(query As String) As Boolean
        Dim command = New SqlCommand("SELECT CASE WHEN COUNT(*) IS NULL THEN 0 ELSE COUNT(*) FROM tblusers WHERE username = @query", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@query", query)
        Return command.ExecuteScalar
    End Function
End Class
