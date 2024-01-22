Imports System.Data.SqlClient

Public Class SqlConnectionSingleton
    Private Shared _sqlConnection As New SqlConnection(My.Settings.hmsConnectionString)

    Private Sub New()

    End Sub

    Public Shared Function GetInstance() As SqlConnection
        If _sqlConnection.State = ConnectionState.Closed Then
            _sqlConnection.Open()
        End If
        Return _sqlConnection
    End Function
End Class
