Imports System.Data.OleDb
Public Class frmdeposit
    Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SparrowResort.accdb;Persist Security Info=False")
    Dim cmd As OleDbCommand
    Dim sql As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckIn.Show()
        Close()
    End Sub

    Private Sub frmpayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Label10.Text = CheckIn.txtName.Text
        Label11.Text = CheckIn.txtIc.Text
        Label12.Text = CheckIn.ComboBox4.Text
        Label13.Text = CheckIn.radSupreme.Text
        Label13.Text = CheckIn.radStandard.Text
        Label14.Text = CheckIn.ComboBox2.Text
        Label15.Text = CheckIn.ComboBox3.Text
        Label16.Text = CheckIn.DateTimePicker2.Text
        Label17.Text = CheckIn.DateTimePicker1.Text
        Label18.Text = CheckIn.lblTime.Text
        Label20.Text = CheckIn.Label11.Text
        Label25.Text = CheckIn.TextBox2.Text
        Label26.Text = CheckIn.TextBox3.Text
        Label22.Text = CheckIn.Label15.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conn.Open()
        sql = "INSERT INTO CheckIn(GuestName,PassportIC,ContactNumber,EmailAddress,ChaletNumber,ChaletType, NumberofAdult, NumberofChildren, CheckInDate, CheckOutDate, Numberofdays, CheckOutTime, Deposit) VALUES (@GuestName, @PassportIC, @ContactNumber, @EmailAddress, @ChaletNumber, @ChaletType, @NumberofAdult, @NumberofChildren, @CheckInDate, @CheckOutDate, @Numberofdays, @CheckOutTime, @Deposit)"

        cmd = New OleDbCommand(sql, conn)

        cmd.Parameters.AddWithValue("@GuestName", Label10.Text)
        cmd.Parameters.AddWithValue("@PassportIC", Label11.Text)
        cmd.Parameters.AddWithValue("@ContactNumber", Label25.Text)
        cmd.Parameters.AddWithValue("@EmailAddress", Label26.Text)
        cmd.Parameters.AddWithValue("@ChaletNumber", Label12.Text)
        cmd.Parameters.AddWithValue("@ChaletType", Label13.Text)
        cmd.Parameters.AddWithValue("@NumberofAdult", Label14.Text)
        cmd.Parameters.AddWithValue("@NumberofChildren", Label15.Text)
        cmd.Parameters.AddWithValue("@CheckInDate", Label16.Text)
        cmd.Parameters.AddWithValue("@CheckOutDate", Label17.Text)
        cmd.Parameters.AddWithValue("@Numberofdays", Label20.Text)
        cmd.Parameters.AddWithValue("@CheckOutTime", Label18.Text)
        cmd.Parameters.AddWithValue("@Deposit", Label22.Text)
        Dim i As Integer = 0
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("Register Successfull!", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Register Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Home.Show()
        Close()
    End Sub
End Class