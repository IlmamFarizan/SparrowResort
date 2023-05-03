Imports System.Data.OleDb
Public Class ExtendBookingDetail
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim sql As String
    Dim searchkey As String
    Private Sub txtFullName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPassportIC.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Home.Show()
        Hide()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SparrowResort.accdb;Persist Security Info=False")
        conn.Open()
        sql = "SELECT * FROM RESERVATIONDETAILS WHERE [GuestID] ='" & txtPassportIC.Text & "'"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            ExtendBookingDate.lblBookedBy.Text = dr.Item("BookedBy").ToString
            ExtendBookingDate.lblCheckOutDate.Text = dr.Item("CheckOutdate").ToString
            dr.Close()
            conn.Close()
        Else
            MessageBox.Show("No records of the Passport/IC Number found in the database", "Guest Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassportIC.Clear()
            txtPassportIC.Focus()
            Return
        End If
        txtPassportIC.Focus()
        dr.Close()
        conn.Close()



        ExtendBookingDate.Show()
        Hide()
    End Sub

    Private Sub ExtendBookingDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub RegisterGuestForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
End Class