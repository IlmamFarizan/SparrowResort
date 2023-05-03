Imports System.Data.OleDb
Public Class frmreceipt
    Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SparrowResort.accdb;Persist Security Info=False")
    Dim cmd As OleDbCommand
    Dim sql As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckOut.Show()
        Close()
    End Sub

    Private Sub frmreceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Label15.Text = CheckOut.TextBox1.Text
        Label16.Text = CheckOut.txtIc.Text
        Label17.Text = CheckOut.ComboBox1.Text
        Label18.Text = CheckIn.radSupreme.Text
        Label18.Text = CheckIn.radStandard.Text
        Label19.Text = CheckOut.ComboBox2.Text
        Label20.Text = CheckOut.ComboBox3.Text
        Label21.Text = CheckOut.DateTimePicker1.Text
        Label22.Text = CheckOut.DateTimePicker2.Text
        Label23.Text = CheckOut.lblTime.Text
        Label24.Text = CheckOut.Label19.Text
        Label27.Text = CheckOut.TextBox6.Text
        Label28.Text = CheckOut.TextBox7.Text
        Label25.Text = CheckOut.TextBox2.Text
        Label26.Text = CheckOut.TextBox3.Text
        Label29.Text = CheckOut.Label17.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Home.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conn.Open()
        sql = "INSERT INTO CheckOut(GuestName,PassportIC,ContactNumber,EmailAddress,ChaletNumber,ChaletType, NumberofAdult, NumberofChildren, CheckInDate, CheckOutDate, Numberofdays, CheckOutTime, TotalCharges, AmountPaid, Balance) 
VALUES (@GuestName, @PassportIC, @ContactNumber, @EmailAddress, @ChaletNumber, @ChaletType, @NumberofAdult, @NumberofChildren, @CheckInDate, @CheckOutDate, @Numberofdays, @CheckOutTime, @TotalCharges, @AmountPaid, @Balance )"

        cmd = New OleDbCommand(sql, conn)

        cmd.Parameters.AddWithValue("@GuestName", Label15.Text)
        cmd.Parameters.AddWithValue("@PassportIC", Label16.Text)
        cmd.Parameters.AddWithValue("@ContactNumber", Label25.Text)
        cmd.Parameters.AddWithValue("@EmailAddress", Label26.Text)
        cmd.Parameters.AddWithValue("@ChaletNumber", Label17.Text)
        cmd.Parameters.AddWithValue("@ChaletType", Label18.Text)
        cmd.Parameters.AddWithValue("@NumberofAdult", Label19.Text)
        cmd.Parameters.AddWithValue("@NumberofChildren", Label20.Text)
        cmd.Parameters.AddWithValue("@CheckInDate", Label21.Text)
        cmd.Parameters.AddWithValue("@CheckOutDate", Label22.Text)
        cmd.Parameters.AddWithValue("@Numberofdays", Label29.Text)
        cmd.Parameters.AddWithValue("@CheckOutTime", Label23.Text)
        cmd.Parameters.AddWithValue("@TotalCharges", Label24.Text)
        cmd.Parameters.AddWithValue("@AmountPaid", Label27.Text)
        cmd.Parameters.AddWithValue("@Balance", Label28.Text)
        Dim i As Integer = 0
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("Register Successfull!", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Register Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        conn.Close()
    End Sub
End Class