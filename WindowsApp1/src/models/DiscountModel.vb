Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class DiscountModel
    Inherits SqlBase
    Implements ICommands

    Public Sub New(data As Dictionary(Of String, String))
        _data = data
        messagebox = New Guna2MessageDialog
    End Sub

    Public Sub Delete() Implements ICommands.Delete
        _command = New SqlCommand("EXEC DeleteDiscountProcedure @id, @user_id;", _conn)
        _command.Parameters.AddWithValue("@id", _data.Item("id"))
        _command.Parameters.AddWithValue("@user_id", My.Settings.userID)
        If _command.ExecuteNonQuery() > 0 Then
            messagebox.Caption = "Success."
            messagebox.Text = "Discount has been deleted successfully."
            messagebox.Icon = MessageDialogIcon.Information
        Else
            messagebox.Caption = "Failed."
            messagebox.Text = "Failed deleting the discount."
            messagebox.Icon = MessageDialogIcon.Information
        End If
        messagebox.Parent = DashboardForm
        messagebox.Show()
    End Sub

    Public Sub Add() Implements ICommands.Add
        _command = New SqlCommand("EXEC InsertDiscountProcedure @discount_name, @discount_value, @discount_comment, @user_id", _conn)
        _command.Parameters.AddWithValue("@discount_name", _data.Item("discount_name"))
        _command.Parameters.AddWithValue("@discount_value", _data.Item("discount_value"))
        _command.Parameters.AddWithValue("@discount_comment", If(String.IsNullOrEmpty(_data.Item("discount_comment")), DBNull.Value, _data.Item("discount_comment")))
        _command.Parameters.AddWithValue("@user_id", My.Settings.userID)
        If _command.ExecuteNonQuery() > 0 Then
            messagebox.Caption = "Success."
            messagebox.Text = "Discount has been added successfully."
            messagebox.Icon = MessageDialogIcon.Information
        Else
            messagebox.Caption = "Failed."
            messagebox.Text = "Failed adding the discount."
            messagebox.Icon = MessageDialogIcon.Information
        End If
        messagebox.Parent = DashboardForm
        messagebox.Show()
    End Sub

    Public Sub Update() Implements ICommands.Update
        _command = New SqlCommand("EXEC UpdateDiscountProcedure @id, @discount_name, @discount_value, @discount_comment, @user_id", _conn)
        _command.Parameters.AddWithValue("@id", _data.Item("id"))
        _command.Parameters.AddWithValue("@discount_name", _data.Item("discount_name"))
        _command.Parameters.AddWithValue("@discount_value", _data.Item("discount_value"))
        _command.Parameters.AddWithValue("@discount_comment", If(String.IsNullOrEmpty(_data.Item("discount_comment")), DBNull.Value, _data.Item("discount_comment")))
        _command.Parameters.AddWithValue("@user_id", My.Settings.userID)
        If _command.ExecuteNonQuery() > 0 Then
            messagebox.Caption = "Success."
            messagebox.Text = "Discount has been updated successfully."
            messagebox.Icon = MessageDialogIcon.Information
        Else
            messagebox.Caption = "Failed."
            messagebox.Text = "Failed updating the discount."
            messagebox.Icon = MessageDialogIcon.Information
        End If
        messagebox.Parent = DashboardForm
        messagebox.Show()
    End Sub

    Public Shared Function Exists(query As String) As Boolean
        Dim command = New SqlCommand("SELECT CASE WHEN COUNT(*) IS NULL THEN 0 ELSE COUNT(*) END AS C FROM viewtbldiscounts WHERE LOWER([DISCOUNT TYPE]) = LOWER(@query)", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@query", query.Trim())
        Return command.ExecuteScalar > 0
    End Function

    Public Shared Function Search(query As String) As DataTable
        Dim command = New SqlCommand("EXEC SearchDiscountProcedure @query", SqlConnectionSingleton.GetInstance)
        command.Parameters.AddWithValue("@query", query)
        Dim adapter = New SqlDataAdapter(command)
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        Return dataTable
    End Function
End Class
