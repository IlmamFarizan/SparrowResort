Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class ReservationInformation
    Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SparrowResort.accdb;Persist Security Info=False")
    Dim cmd As OleDbCommand
    Dim sql As String
    Dim dr As OleDbDataReader
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFullName.Clear()
        txtPassportIC.Clear()
        txtEmail.Clear()
        mtxtMobile.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Home.Show()
        Hide()
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If txtFullName.Text = "" Or txtPassportIC.Text = "" Or txtEmail.Text = "" Or mtxtMobile.Text.Contains("_") Then
            MsgBox("Please fill the all the text box")
            Return
        End If

        Dim par As String
        par = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If Not Regex.IsMatch(txtEmail.Text, par) Then
            MsgBox("invaild email")
            Return
        End If

        sql = "Select * FROM GUESTDETAILS WHERE PassportNumber='" & txtPassportIC.Text & "' AND GuestName='" & txtFullName.Text & "'AND ContactNumber='" & mtxtMobile.Text & "'AND EmailAddress='" & txtEmail.Text & "'"

        cmd = New OleDbCommand(sql, conn)
        conn.Open()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            ReservationRoom.Show()
            Hide()
        Else
            MessageBox.Show("No Record Found in database. Please register first", "Reservation Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFullName.Clear()
            txtEmail.Clear()
            txtPassportIC.Clear()
            txtFind.Clear()
            mtxtMobile.Clear()
            txtFind.Clear()
        End If
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        conn.Open()
        sql = "SELECT * FROM GUESTDETAILS WHERE [PassportNumber] ='" & txtFind.Text & "'"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            txtFullName.Text = dr.Item("GuestName")
            mtxtMobile.Text = dr.Item("ContactNumber")
            txtEmail.Text = dr.Item("EmailAddress")
            txtPassportIC.Text = dr.Item("PassportNumber")

        Else
            MessageBox.Show("No records of the Passport/IC Number found in the database", "Guest Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFind.Clear()
            txtPassportIC.Focus()
            txtPassportIC.Clear()
            txtFullName.Clear()
            mtxtMobile.Clear()
            txtEmail.Clear()
        End If
        dr.Close()
        conn.Close()
    End Sub
    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        DatabaseGuestDetails.Show()
    End Sub
End Class