Imports System.Runtime.InteropServices.ComTypes
Imports System.Windows.Forms
Imports Guna.UI2.WinForms

Public Class AddUserDialog
    Public Property Data As DataRowView
    Private _model As ICommands
    Private _invoker As ICommandInvoker

    Private Sub BTNADDUSER_Click(sender As Object, e As EventArgs) Handles BTNADDUSER.Click

        Dim controls As Object() = {TXTBOXUSERNAME, TXTBOXPASSWORD}
        Dim types As DataInput() = {DataInput.STRING_USERNAME, DataInput.STRING_PASSWORD}

        Dim res As New List(Of Object())
        For i = 0 To controls.Count - 1
            res.Add(ValidationString.ValidateInputString(controls(i), types(i)))
        Next

        If Not res.Any(Function(item As Object()) Not item(0)) Then
            Dim dict As New Dictionary(Of String, String)
            dict.Add("id", Data?.Item("ID"))
            dict.Add("username", res(0)(1))
            dict.Add("password", res(1)(1))

            _model = New AccountsModel(dict)
            If Not AccountsModel.Exists(res(0)(1)) AndAlso Data Is Nothing Then
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

    Private Sub BTNDELETE_Click(sender As Object, e As EventArgs) Handles BTNDELETE.Click
        _model = New AccountsModel(New Dictionary(Of String, String) From {{"id", Data.Item("ID")}})
        _invoker = New DeleteCommand(_model)
        _invoker.Invoke()
        DashboardForm.LoadData()
        Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Close()
    End Sub

    Private Sub AddUserDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Data IsNot Nothing Then
            BTNDELETE.Visible = True
            BTNADDUSER.Text = "UPDATE"
            TXTBOXUSERNAME.Text = Data.Item("USERNAME")
        End If
    End Sub
End Class
