Imports System.Data.OleDb
Public Class SearchGuest
    Dim searchkey As String
    Dim con As New OleDbConnection
    Dim dr As OleDbDataReader
    Dim sql As String
    Dim cmd As OleDbCommand
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Home.Show()
        Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtContactNum.Text = ""
        txtEmail.Text = ""
        txtPassportIC.Text = ""
    End Sub

    Private Sub RegisterGuestForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AcceptButton = btnSearch
        txtPassportIC.Focus()
        btnModify.Enabled = False
        Enable_Disable(True)
    End Sub
    Sub Enable_Disable(ByVal flag As Boolean)
        txtName.ReadOnly = flag
        txtContactNum.ReadOnly = flag
        txtEmail.ReadOnly = flag
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SparrowResort.accdb;Persist Security Info=False")
        con.Open()
        sql = "SELECT * FROM GUESTDETAILS WHERE [PassportNumber] ='" & searchkey & "'"
        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            txtName.Text = dr.Item("GuestName")
            txtContactNum.Text = dr.Item("ContactNumber")
            txtEmail.Text = dr.Item("EmailAddress")
            Dim reply As MsgBoxResult

            reply = MessageBox.Show("Do you want to update the data?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If reply = MsgBoxResult.Yes Then
                txtName.ReadOnly = False
                txtContactNum.ReadOnly = False
                txtEmail.ReadOnly = False
                btnModify.Enabled = True
                btnSearch.Enabled = False
            End If
        Else
            MessageBox.Show("No records of the Passport/IC Number found in the database", "Guest Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassportIC.Clear()
            txtPassportIC.Focus()
            txtName.Clear()
            txtContactNum.Clear()
            txtEmail.Clear()
        End If
        txtPassportIC.Focus()
        dr.Close()
        con.Close()
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Dim sqlUpdate As String

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SparrowResort.accdb"
        con.Open()
        sqlUpdate = "UPDATE GuestDetails SET Phone='" & txtContactNum.Text & "', email='" & txtEmail.Text & "' WHERE [GuestName]='" & txtName.Text & "'"
        cmd = New OleDbCommand(sqlUpdate, con)
        cmd.CommandType = CommandType.Text
        Dim iCount As Integer = cmd.ExecuteNonQuery()
        If iCount = 0 Then
            MessageBox.Show("Unable to update record")
        Else
            MessageBox.Show("Record has been updated")
        End If
        btnSearch.Enabled = True
        btnModify.Enabled = False
        con.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassportIC.TextChanged
        searchkey = txtPassportIC.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DatabaseFInd.Show()
    End Sub
End Class