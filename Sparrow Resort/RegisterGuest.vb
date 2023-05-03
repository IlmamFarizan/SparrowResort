Public Class RegisterGuest

    Private Sub txtContactNum_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
        'If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then
        'e.Handled = True
        'End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPassport.Text = ""
        txtGuestName.Text = ""
        txtContactNum.Text = ""
        txtEmail.Text = ""
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Home.Show()
        Hide()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        RegisterGuestConfirm.Show()
        Close()
    End Sub

    Private Sub txtPassport_TextChanged(sender As Object, e As EventArgs) Handles txtPassport.TextChanged
        RegisterGuestConfirm.lblPassportNum2.Text = txtPassport.Text


    End Sub

    Private Sub txtGuestName_TextChanged(sender As Object, e As EventArgs) Handles txtGuestName.TextChanged
        RegisterGuestConfirm.lblGuestName2.Text = txtGuestName.Text
    End Sub

    Private Sub txtContactNum_TextChanged(sender As Object, e As EventArgs)
        RegisterGuestConfirm.lblContactNum2.Text = txtContactNum.Text
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        RegisterGuestConfirm.lblEmail2.Text = txtEmail.Text
    End Sub

    Private Sub RegisterGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class