Imports System.Windows.Interop
Imports Guna.UI2.WinForms

Public Class CustomCalendar
    Private CURRENT_DATE As Date = Date.Now
    Private panels As New List(Of Guna2Panel)(35)
    Private list_of_dates As New List(Of Date)(35)

    Public Sub New()
        InitializeComponent()
        panels.AddRange({
            P1, P2, P3, P4, P5, P6, P7,
            P8, P9, P10, P11, P12, P13, P14,
            P15, P16, P17, P18, P19, P20, P21,
            P22, P23, P24, P25, P26, P27, P28,
            P29, P30, P31, P32, P33, P34, P35
        })
    End Sub

    Private Sub CustomCalendar_Load(sender As Object, e As EventArgs) Handles Me.Load
        LABELMONTHHEADER.Text = MonthName(CURRENT_DATE.Month) & ", " & CURRENT_DATE.Year
        ChangeDates()
    End Sub

    Public Sub ChangeDates()
        Dim temp_date As Date = CURRENT_DATE
        Dim labels As Label() = {
            L1, L2, L3, L4, L5, L6, L7,
            L8, L9, L10, L11, L12, L13, L14,
            L15, L16, L17, L18, L19, L20, L21,
            L22, L23, L24, L25, L26, L27, L28,
            L29, L30, L31, L32, L33, L34, L35
        }

        For idx As Integer = 0 To 34
            list_of_dates.Add(Date.Now)
        Next

        ' To prevent the click from duplicating
        For Each panel As Guna2Panel In panels
            For Each ctrl In panel.Controls
                If TypeOf ctrl Is Guna2Panel Then
                    panel.Controls.Remove(ctrl)
                End If
            Next
            RemoveHandler panel.Click, AddressOf PanelHandler
        Next

        ' Clear all the texts in the labels
        For Each item In labels
            item.Text = Nothing
        Next

        ' Find the starting date of the day
        While temp_date.Day <> 1
            temp_date = temp_date.AddDays(-1)
        End While

        Dim start_date_idx As Integer = temp_date.DayOfWeek

        ' Fill the left if the first day is not sunday
        Dim fill_date As Date = temp_date
        Dim past_idx As Integer = start_date_idx - 1
        While past_idx <> -1
            fill_date = fill_date.AddDays(-1)
            labels(past_idx).Text = fill_date.Day
            list_of_dates.Item(past_idx) = fill_date
            If HasReservation(fill_date) Then
                Dim circle As New Guna2Panel With {
                    .Width = 10,
                    .Height = 10,
                    .Anchor = AnchorStyles.Top Or AnchorStyles.Right,
                    .FillColor = Color.Blue,
                    .Location = New Point(panels(past_idx).Width - 40, panels(past_idx).Height - 25)
                }
                circle.AutoRoundedCorners = True
                panels(past_idx).Controls.Add(circle)
            End If
            AddHandler panels(past_idx).Click, AddressOf PanelHandler
            past_idx -= 1
        End While

        ' Fill all the days of the calendar
        For idx = start_date_idx To labels.Count - 1
            If temp_date.Month = CURRENT_DATE.Month Then
                list_of_dates.Item(idx) = temp_date
                labels(idx).Text = temp_date.Day
                AddHandler panels(idx).Click, AddressOf PanelHandler
                If HasReservation(temp_date) Then
                    Dim circle As New Guna2Panel With {
                        .Width = 10,
                        .Height = 10,
                        .Anchor = AnchorStyles.Top Or AnchorStyles.Right,
                        .FillColor = Color.Blue,
                        .Location = New Point(panels(idx).Width - 40, panels(idx).Height - 25)
                    }
                    circle.AutoRoundedCorners = True
                    panels(idx).Controls.Add(circle)
                End If
            End If
            temp_date = temp_date.AddDays(1)
        Next
    End Sub

    Private Sub BTNNEXT_Click(sender As Object, e As EventArgs) Handles BTNNEXT.Click
        CURRENT_DATE = CURRENT_DATE.AddMonths(1)
        LABELMONTHHEADER.Text = MonthName(CURRENT_DATE.Month) & ", " & CURRENT_DATE.Year
        ChangeDates()
    End Sub

    Private Sub BTNPREV_Click(sender As Object, e As EventArgs) Handles BTNPREV.Click
        CURRENT_DATE = CURRENT_DATE.AddMonths(-1)
        LABELMONTHHEADER.Text = MonthName(CURRENT_DATE.Month) & ", " & CURRENT_DATE.Year
        ChangeDates()
    End Sub

    Private Sub PanelHandler(sender As Object, e As EventArgs)
        Dim idx As Integer = panels.IndexOf(sender)
        ReservationInfo.RESERVATION_DATE = list_of_dates(idx)
        ReservationInfo.ShowDialog()
    End Sub
End Class