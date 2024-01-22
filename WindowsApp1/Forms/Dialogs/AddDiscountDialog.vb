Imports Guna.UI2.WinForms

Public Class AddDiscountDialog
    Public Property Data As DataRowView
    Private _model As ICommands
    Private _invoker As ICommandInvoker
    Private Sub AddDiscount_Click(sender As Object, e As EventArgs) Handles BTNADDDISCOUNT.Click

        Dim controls As Object() = {TXTBOXDISCOUNTNAME, TXTBOXDISCOUNTPERCENT}
        Dim types As DataInput() = {DataInput.STRING_NAME, DataInput.STRING_INTEGER}

        Dim res As New List(Of Object())
        For i = 0 To controls.Count - 1
            res.Add(ValidationString.ValidateInputString(controls(i), types(i)))
        Next

        If Not res.Any(Function(item As Object()) Not item(0)) Then
            Dim dict As New Dictionary(Of String, String) From {
                {"id", Data?.Item("ID")},
                {"discount_name", res(0)(1)},
                {"discount_value", res(1)(1)},
                {"discount_comment", TXTBOXDESCRIPTION.Text}
            }
            _model = New DiscountModel(dict)
            If Not DiscountModel.Exists(res(0)(1)) AndAlso Data Is Nothing Then
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
            _invoker?.Invoke()
            DashboardForm.LoadData()
            Close()
        End If
    End Sub

    Private Sub BTNDELETESTAFF_Click(sender As Object, e As EventArgs) Handles BTNDELETEDISCOUNT.Click
        _model = New DiscountModel(New Dictionary(Of String, String) From {{"id", Data.Item("ID")}})
        _invoker = New DeleteCommand(_model)
        _invoker.Invoke()
        DashboardForm.LoadData()
        Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Close()
    End Sub

    Private Sub AddDiscountDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _Data IsNot Nothing Then
            BTNDELETEDISCOUNT.Visible = True
            BTNADDDISCOUNT.Text = "UPDATE"
            TXTBOXDISCOUNTNAME.Text = _Data.Item("DISCOUNT TYPE")
            TXTBOXDISCOUNTPERCENT.Text = _Data.Item("VALUE")
            If String.IsNullOrEmpty(_Data.Item("DESCRIPTION")) Then
                TXTBOXDESCRIPTION.PlaceholderText = "None"
            Else
                TXTBOXDESCRIPTION.Text = _Data.Item("DESCRIPTION")
            End If
        End If
    End Sub
End Class
