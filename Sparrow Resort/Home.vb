Public Class Home
    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        Dim dlgR As DialogResult
        dlgR = MessageBox.Show("Are you sure you want to log out?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If dlgR = DialogResult.Yes Then
            Login.Show()
            Hide()
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        RegisterGuest.Show()
        Hide()

    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RegisterGuestForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub


    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        SearchGuest.Show()
        Hide()
    End Sub

    Private Sub Panel8_Click(sender As Object, e As EventArgs) Handles Panel8.Click
        ReservationInformation.Show()
        Hide()
    End Sub
    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        ExtendBookingDetail.Show()
        Hide()
    End Sub
    Private Sub Panel7_Click(sender As Object, e As EventArgs) Handles Panel7.Click
        OccupancyReport2.Show()
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Refresh()
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        CheckIn.Show()
        Hide()
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        CheckOut.Show()
        Hide()
    End Sub
End Class