Imports System.Data.DataTable
Public Class DatabaseGuestDetails
    Dim table As New DataTable("GUESTDETAILS")
    Private Sub Database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.GuestDetails' table. You can move, or remove it, as needed.
        Me.GuestDetailsTableAdapter.Fill(Me.DataSet1.GuestDetails)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Dim index As Integer
        'index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = DataGridView1.Rows(index)
        'ReservationInformation.txtPassportIC.Text = selectedRow.Cells(0).Value.ToString()
        'ReservationInformation.txtFullName.Text = selectedRow.Cells(1).Value.ToString()
        'ReservationInformation.txtEmail.Text = selectedRow.Cells(3).Value.ToString()
        'ReservationInformation.mtxtMobile.Text = selectedRow.Cells(2).Value.ToString()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ReservationInformation.Show()
        Close()

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        ReservationInformation.Show()
        Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        ReservationInformation.txtPassportIC.Text = selectedRow.Cells(0).Value.ToString()
        ReservationInformation.txtFullName.Text = selectedRow.Cells(1).Value.ToString()
        ReservationInformation.txtEmail.Text = selectedRow.Cells(3).Value.ToString()
        ReservationInformation.mtxtMobile.Text = selectedRow.Cells(2).Value.ToString()
    End Sub
End Class