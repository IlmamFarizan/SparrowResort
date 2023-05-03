Imports System.Data.OleDb
Public Class Register
    Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\VBN\Sparrow Resort\Sparrow Resort\bin\Debug\SparrowResort.accdb;Persist Security Info=False")
    Dim cmd As OleDbCommand
    Dim sql As String
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        conn.Open()
        sql = "INSERT INTO USERS(Username, [Password], Fullname, Role) VALUES (@Username, @Password, @Fullname, @Role)"

        cmd = New OleDbCommand(sql, conn)

        cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
        cmd.Parameters.AddWithValue("@Fullname", txtFname.Text)
        cmd.Parameters.AddWithValue("@Role", ComboBox1.Text)

        Dim i As Integer = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("Registration successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Registration failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        conn.Close()
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Login.Show()
        Hide()
    End Sub

    Private Sub RegisterGuestForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
End Class