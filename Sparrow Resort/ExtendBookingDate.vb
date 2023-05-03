Imports System.Data.OleDb
Public Class ExtendBookingDate
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim sql As String
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ExtendBookingDetail.Show()
        Close()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SparrowResort.accdb;Persist Security Info=False;")

        sql = "UPDATE ReservationDetails SET [CheckOutdate]=@CheckOutdate WHERE BookedBy=@BookedBy"

        conn.Open()
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@CheckOutdate", DateTimePicker2.Text)
        cmd.Parameters.AddWithValue("@BookedBy", lblBookedBy.Text)


        Dim i As Integer = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("Extend sucessfully", "Update Successs", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Unable to update Extend Date. Please select agian your Date", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        conn.Close()
        Home.Show()
        Close()
    End Sub

    Private Sub ExtendBookingDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class