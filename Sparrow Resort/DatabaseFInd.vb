Public Class DatabaseFInd
    Private Sub DatabaseReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.GuestDetails' table. You can move, or remove it, as needed.
        Me.GuestDetailsTableAdapter.Fill(Me.DataSet1.GuestDetails)
        'TODO: This line of code loads data into the 'DataSet1.ReservationDetails' table. You can move, or remove it, as needed.
        Me.ReservationDetailsTableAdapter.Fill(Me.DataSet1.ReservationDetails)
        'TODO: This line of code loads data into the 'DataSet1.GuestDetails' table. You can move, or remove it, as needed.
        Me.GuestDetailsTableAdapter.Fill(Me.DataSet1.GuestDetails)

        'TODO: This line of code loads data into the 'DataSet1.ReservationDetails' table. You can move, or remove it, as needed.
        Me.ReservationDetailsTableAdapter.Fill(Me.DataSet1.ReservationDetails)
        'TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        SearchGuest.Show()
        Close()
    End Sub
End Class