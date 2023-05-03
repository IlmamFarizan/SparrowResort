Imports System.Data.OleDb
Public Class SummaryReservation
    Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SparrowResort.accdb;Persist Security Info=False")
    Dim cmd As OleDbCommand
    Dim sql, sql2 As String

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Home.Show()
        Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ReservationRoom.Show()
        Close()
    End Sub

    Private Sub SummaryReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNights.Text = ReservationRoom.lblNights.Text
        lblBookedBy.Text = ReservationInformation.txtFullName.Text
        lblCheckinDate.Text = ReservationRoom.DateTimePicker1.Text
        lblCheckOutDate.Text = ReservationRoom.DateTimePicker2.Text
        If ReservationRoom.radStandard.Checked Then
            lblChaletType.Text = "Standard"
        Else
            lblChaletType.Text = "Supreme"
        End If
        lblNumGuest.Text = ReservationRoom.txtNumGuest.Text
        lblDeposit.Text = ReservationRoom.lblDeposit.Text
        lblTotalAmount.Text = ReservationRoom.lblTotalAmount.Text
        lblCusResq.Text = ReservationRoom.txtRequestBox.Text
        lblPassportIC.Text = ReservationInformation.txtPassportIC.Text

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        'Dim x As Integer = cmd.ExecuteNonQuery()
        'conn.Close()
        sql = "INSERT INTO ReservationDetails(GuestID,BookedBy,CheckIndate,CheckOutdate,GuestNumber,Nights,ChaletType,ChaletID,CustomerRequest,Deposit,TotalAmount) VALUES (@GuestID,@BookedBy,@CheckIndate,@CheckOutdate,@GuestNumber,@Nights,@ChaletType,@ChaletID,@CustomerRequest,@Deposit,@TotalAmount)"
        sql2 = "UPDATE Chalet SET [ChaletStatus]='Booked' WHERE ChaletID='" & lblChaletID.Text & "'"
        conn.Open()
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@GuestID", lblPassportIC.Text)
        cmd.Parameters.AddWithValue("@BookedBy", lblBookedBy.Text)
        cmd.Parameters.AddWithValue("@CheckIndate", lblCheckinDate.Text)
        cmd.Parameters.AddWithValue("@CheckOutdate", lblCheckOutDate.Text)
        cmd.Parameters.AddWithValue("@GuestNumber", lblNumGuest.Text)
        cmd.Parameters.AddWithValue("@Nights", lblNights.Text)
        cmd.Parameters.AddWithValue("@ChaletType", lblChaletType.Text)
        cmd.Parameters.AddWithValue("@ChaletID", lblChaletID.Text)
        cmd.Parameters.AddWithValue("@CustomerRequest", lblCusResq.Text)
        cmd.Parameters.AddWithValue("@Deposit", lblDeposit.Text)
        cmd.Parameters.AddWithValue("@TotalAmount", lblTotalAmount.Text)
        cmd.Parameters.AddWithValue("@GuestID", lblPassportIC.Text)
        cmd.Parameters.AddWithValue("@BChaletID", lblChaletID.Text)
        Dim cmd2 As OleDbCommand = New OleDbCommand(sql2, conn)
        cmd2.ExecuteNonQuery()
        Dim i As Integer = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("Record Details Saved sucessfully", "Saved Successs", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Unable to Save record. Please check your information", "Saved Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        conn.Close()
        Home.Show()
        Close()
    End Sub

    Private Sub lblChaletID_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblChaletID_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class