Public Class ReservationForm
    Private Sub ReservationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HmsDataSet.tblrooms' table. You can move, or remove it, as needed.
        Me.TblroomsTableAdapter.Fill(Me.HmsDataSet.tblrooms)

    End Sub
End Class