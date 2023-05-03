Public Class OccupancyReport2
    Private Sub OccupancyReport2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Chalet' table. You can move, or remove it, as needed.
        Me.ChaletTableAdapter.Fill(Me.DataSet1.Chalet)

        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub RegisterGuestForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            e.Cancel = False
            Home.Show()
        Else
            e.Cancel = True
        End If
    End Sub
End Class