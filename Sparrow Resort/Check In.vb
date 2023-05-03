Public Class CheckIn
    Dim RoomPrice As Single
    Private Sub CheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        lblTime.Text = Now.ToShortTimeString
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Home.Show()
        Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmdeposit.Show()
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Borrow As DateTime = Convert.ToDateTime(DateTimePicker1.Text)
        Dim Back As DateTime = Convert.ToDateTime(DateTimePicker2.Text)
        Dim CountDays As TimeSpan = Back.Subtract(Borrow)
        Dim TotalDays = Convert.ToInt32(CountDays.Days)
        If Convert.ToInt32(CountDays.Days) >= 0 Then
            Label11.Text = TotalDays
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Days As Integer
        Dim Deposit As Single
        Days = Integer.Parse(Label11.Text)
        Deposit = RoomPrice * Days * 0.15
        Label15.Text = Deposit.ToString("c")
    End Sub
    Private Sub radSuperior_CheckedChanged(sender As Object, e As EventArgs) Handles radSupreme.CheckedChanged
        RoomPrice = 250.0
        Label13.Text = RoomPrice
    End Sub
    Private Sub radStandard_CheckedChanged(sender As Object, e As EventArgs) Handles radStandard.CheckedChanged
        RoomPrice = 150.0
        Label13.Text = RoomPrice
    End Sub
End Class