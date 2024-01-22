Public Class DeleteCommand
    Implements ICommandInvoker
    Private _model As ICommands
    Public Sub New(model As ICommands)
        _model = model
    End Sub

    Public Sub Invoke() Implements ICommandInvoker.Invoke
        _model.Delete()
    End Sub
End Class
