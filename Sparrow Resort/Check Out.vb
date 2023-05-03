Public Class CheckOut
    Dim RoomPrice As Single
    Private Sub CheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        lblTime.Text = Now.ToShortTimeString
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home.Show()
        Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmreceipt.Show()
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Borrow As DateTime = Convert.ToDateTime(DateTimePicker1.Text)
        Dim Back As DateTime = Convert.ToDateTime(DateTimePicker2.Text)
        Dim CountDays As TimeSpan = Back.Subtract(Borrow)
        Dim TotalDays = Convert.ToInt32(CountDays.Days)
        If Convert.ToInt32(CountDays.Days) >= 0 Then
            Label17.Text = TotalDays
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Days As Integer
        Dim TotalCharges As Single
        Days = Integer.Parse(Label17.Text)
        TotalCharges = RoomPrice * Days - RoomPrice * Days * 0.15
        Label19.Text = TotalCharges.ToString("c")
    End Sub
    Private Sub radSuperior_CheckedChanged(sender As Object, e As EventArgs) Handles radSupreme.CheckedChanged
        RoomPrice = 250.0
        Label10.Text = RoomPrice
    End Sub
    Private Sub radStandard_CheckedChanged(sender As Object, e As EventArgs) Handles radStandard.CheckedChanged
        RoomPrice = 150.0
        Label10.Text = RoomPrice
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim AmountPaid As Single
        Dim Days As Integer
        Dim Balance As Single
        Dim TotalCharges As Single
        Days = Integer.Parse(Label17.Text)
        TotalCharges = RoomPrice * Days - RoomPrice * Days * 0.15
        AmountPaid = TextBox6.Text
        Balance = AmountPaid - TotalCharges
        TextBox7.Text = Balance.ToString("c")
    End Sub
End Class