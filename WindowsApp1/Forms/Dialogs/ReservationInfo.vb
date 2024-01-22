Imports System.Windows.Forms

Public Class ReservationInfo
    Public RESERVATION_DATE As Date
    Private Sub BTNBACK_Click(sender As Object, e As EventArgs) Handles BTNBACK.Click
        Close()
    End Sub

    Private Sub ReservationInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGRESERVATION.DataSource = TransactionModel.FetchTransactionByDate(RESERVATION_DATE)
    End Sub
End Class
