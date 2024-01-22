Public Class AddCommand
    Implements ICommandInvoker
    Private _model As ICommands
    Public Sub New(model As ICommands)
        _model = model
    End Sub

    Public Sub Invoke() Implements ICommandInvoker.Invoke
        _model.Add()
    End Sub
End Class
