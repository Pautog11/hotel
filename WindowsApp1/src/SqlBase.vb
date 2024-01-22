Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class SqlBase
    Protected _conn As SqlConnection = SqlConnectionSingleton.GetInstance
    Protected _dataTable As DataTable
    Protected _command As SqlCommand
    Protected _adapter As SqlDataAdapter
    Protected _data As Dictionary(Of String, String)
    Protected messagebox As Guna2MessageDialog

End Class
