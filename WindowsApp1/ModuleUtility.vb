Imports System.Data.SqlClient

Module ModuleUtility
    Private _sqlConnection As SqlConnection = SqlConnectionSingleton.GetInstance

    Public Function HasReservation(reservationDate As Date) As Boolean
        Dim command As New SqlCommand("SELECT check_in FROM tbltransactions WHERE CONVERT(VARCHAR, check_in, 3) = CONVERT(VARCHAR, @reservation_date, 3) AND reservation_status_id = 1", _sqlConnection)
        command.Parameters.AddWithValue("@reservation_date", reservationDate)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        Return table.Rows.Count > 0
    End Function

    Public Function GenInvoiceNumber() As String
        Randomize()
        Dim unixTimeString As String = CStr(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds)
        Dim timeString As String = unixTimeString.Substring(7, unixTimeString.Count - 8)
        Dim dateString As String = String.Join("", DateTime.Now.ToShortDateString.Split("/"))
        Return String.Format("HMSI-{0}-{1}", dateString, timeString)
    End Function

    'Public Sub FillByTransacID(id As Integer)
    '    Dim command As New SqlCommand("SELECT t.id, 
    '                                           room_id,
    '                                        CASE WHEN user_id IS NULL THEN -1 ELSE user_id END AS user_id,
    '                                        CASE WHEN room_id IS NULL THEN -1 ELSE room_id END AS room_id,
    '                                        CASE WHEN discount_id IS NULL THEN -1 ELSE discount_id END AS discount_id,
    '                                        CASE WHEN guest_id IS NULL THEN -1 ELSE guest_id END AS guest_id,
    '                                        transaction_no,
    '                                        check_in,
    '                                        check_out,
    '                                        total_rate,
    '                                        date_added,
    '                                        CONVERT(date, date_added, 149)
    '                                        AS [date_inserted],
    '                                        time_added,
    '                                        CASE WHEN guest_id IS NULL THEN 'DELETED' ELSE CONCAT(g.first_name, ' ', g.last_name) END AS guest_name,
    '                                        CONVERT(VARCHAR, time_added, 8) time_inserted,
    '                                           g.phone, g.country, g.type_id
    '                                FROM dbo.tbltransactions t 
    '                                LEFT JOIN tblguests g ON t.guest_id = g.id
    '                                WHERE t.id = @id;")
    '    command.Parameters.AddWithValue("@id", id)
    '    command.Connection = _sqlConnection
    '    Dim adapter As New SqlDataAdapter(command)
    '    'adapter.Fill(AddReservationDialog.HmsDataSet.tbltransactions)
    'End Sub

    'Public Sub CancelReservation(id As String)
    '    Dim command As New SqlCommand("UPDATE tbltransactions SET reservation_status_id = 2 WHERE id = @id", _sqlConnection)
    '    command.Parameters.AddWithValue("@id", id)
    '    command.ExecuteNonQuery()
    'End Sub
End Module
