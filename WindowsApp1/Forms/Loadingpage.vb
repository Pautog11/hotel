Public Class Loadingpage
    Private Sub Loadingpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PBloading.Increment(1)
        LBLpercent.Text = Convert.ToString(PBloading.Value) + "%"
        If PBloading.Value = 100 Then
            Me.Hide()
            Dim LoginForm = New LoginForm
            LoginForm.Show()
            Timer1.Enabled = False
        End If
    End Sub
End Class
