Imports System.Data.OleDb
Public Class RegisterGuestConfirm
    Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SparrowResort.accdb;Persist Security Info=False")
    Dim cmd As OleDbCommand
    Dim sql As String
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblGuestName2.Click

    End Sub

    Private Sub lblPassportNum2_Click(sender As Object, e As EventArgs) Handles lblPassportNum2.Click

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        RegisterGuest.Show()
        Hide()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        conn.Open()
        sql = "INSERT INTO GUESTDETAILS(PassportNumber, GuestName, ContactNumber, EmailAddress) VALUES (@PassportNumber, @GuestName, @ContactNumber, @EmailAddress)"
        cmd = New OleDbCommand(sql, conn)

        cmd.Parameters.AddWithValue("@PassportNumber", lblPassportNum2.Text)
        cmd.Parameters.AddWithValue("@GuestName", lblGuestName2.Text)
        cmd.Parameters.AddWithValue("@ContactNumber", lblContactNum2.Text)
        cmd.Parameters.AddWithValue("@EmailAddress", lblEmail2.Text)


        Dim i As Integer = cmd.ExecuteNonQuery()
        conn.Close()
        If i > 0 Then
            MessageBox.Show("Registration successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Registration failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        conn.Close()

        Home.Show()
        Close()
    End Sub

    Private Sub RegisterGuestConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblContactNum2.Text = RegisterGuest.txtContactNum.Text
    End Sub
End Class