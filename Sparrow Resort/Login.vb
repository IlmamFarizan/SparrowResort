Imports System.Data.OleDb

Public Class Login
    Dim Conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim sql As String
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SparrowResort.accdb;Persist Security Info=False")

        sql = "Select * FROM Users WHERE Username='" & txtUsername.Text & "' AND Password='" & txtPassword.Text & "'"

        cmd = New OleDbCommand(sql, Conn)
        Conn.Open()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Home.Show()
            Hide()
        Else
            MessageBox.Show("Incorrect Username and Password. Please retry", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        Conn.Close()
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Register.Show()
        Hide()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = "Today is " & Now.ToLongDateString & ControlChars.NewLine & "The time now is " & Now.ToShortTimeString
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub RegisterGuestForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
End Class
