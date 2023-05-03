Imports System.Globalization
Imports System.Data.OleDb
Public Class ReservationRoom
    Dim chaletprice As Single
    Dim numGuest As Integer
    Dim chalettype As String
    Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SparrowResort.accdb;Persist Security Info=False")
    Dim ds As New DataSet
    Dim da As OleDbDataAdapter
    Dim sql As String
    Dim cmd As OleDbCommand
    Private Sub radStandard_CheckedChanged(sender As Object, e As EventArgs) Handles radStandard.CheckedChanged
        sender.text = "Standard"
        chaletprice = 150.0
        chalettype = sender.text
        lblChaletPrice.Text = chaletprice.ToString("c")

        If radStandard.Checked Then
            Button11.Hide()
            Button12.Hide()
            Button13.Hide()
            Button14.Hide()
            Button15.Hide()
            Button16.Hide()
            Button17.Hide()
            Button18.Hide()
            Button19.Hide()
            Button20.Hide()
            Button1.Show()
            Button2.Show()
            Button3.Show()
            Button4.Show()
            Button5.Show()
            Button6.Show()
            Button7.Show()
            Button8.Show()
            Button9.Show()
            Button10.Show()
        End If

    End Sub

    Private Sub radSupreme_CheckedChanged(sender As Object, e As EventArgs) Handles radSupreme.CheckedChanged
        sender.text = "Supreme"
        chaletprice = 250.0
        chalettype = sender.text
        lblChaletPrice.Text = chaletprice.ToString("c")

        If radSupreme.Checked Then
            Button1.Hide()
            Button2.Hide()
            Button3.Hide()
            Button4.Hide()
            Button5.Hide()
            Button6.Hide()
            Button7.Hide()
            Button8.Hide()
            Button9.Hide()
            Button10.Hide()
            Button11.Show()
            Button12.Show()
            Button13.Show()
            Button14.Show()
            Button15.Show()
            Button16.Show()
            Button17.Show()
            Button18.Show()
            Button19.Show()
            Button20.Show()
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim d1 As DateTime = DateTimePicker1.Value
        Dim d2 As DateTime = DateTimePicker2.Value
        Dim result As TimeSpan = d2.Subtract(d1)
        Dim days As Integer = result.TotalDays
        lblNights.Text = days

        Dim numNights As Integer
        Dim total As Single
        Dim deposit As Double

        numNights = Integer.Parse(lblNights.Text)
        deposit = numNights * chaletprice * 0.15
        lblDeposit.Text = deposit.ToString("c")

        numNights = Integer.Parse(lblNights.Text)
        total = numNights * chaletprice + deposit
        lblTotalAmount.Text = total.ToString("c")
    End Sub

    Private Sub ReservationRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim culture As CultureInfo = New CultureInfo("ms-my")
        Threading.Thread.CurrentThread.CurrentCulture = culture
        DateTimePicker1.MinDate = Date.Today
        DateTimePicker2.MinDate = Date.Today
        Try
            conn.Open()
            da = New OleDb.OleDbDataAdapter("SELECT * FROM Chalet", conn)
            da.Fill(ds, "Chalet")

            refreshall()
            conn.Close()
        Catch ex As Exception
            MsgBox("ERROR:" & vbCrLf & ex.Message)
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub refreshall()
        Dim ctl As Control
        For i As Integer = -1 To Panel1.Controls.Count - 1
            ctl = Me.FindControl("Button" & i + 1)

            If Not ctl Is Nothing Then
                If ds.Tables("Chalet").Rows(i).Item(2) = "Available" Then
                    ctl.BackColor = Color.LightGreen
                    AddHandler ctl.Click, AddressOf Button1_Click
                ElseIf ds.Tables("Chalet").Rows(i).Item(2) = "Booked" Then
                    ctl.BackColor = Color.LightPink
                    ctl.Enabled = False

                End If
                ctl.Text = ds.Tables("Chalet").Rows(i).Item(0)
            End If
        Next
    End Sub


    Private Function FindControl(ByVal name As String) As Control
        For Each ctl As Control In Panel1.Controls
            If ctl.Name.ToUpper = name.ToUpper Then
                Return ctl

            End If
        Next
        Return Nothing
    End Function
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumGuest.Clear()
        txtRequestBox.Clear()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ReservationInformation.Show()
        Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If txtNumGuest.Text = "" Then
            MessageBox.Show("Please fill the number")
            Return
        End If

        If DateTimePicker2.Text = Today Then
            MessageBox.Show("Please Select the Correct Day")
            Return
        End If

        If lblTotalAmount.Text = "" Or lblDeposit.Text = "" Or lblChaletPrice.Text = "" Then
            MessageBox.Show("Please click the calculate button")
            Return
        End If
        If txtNumGuest.Text < 5 = False Then
            MessageBox.Show("Maximun is 4 person")
            Return
        End If
        Dim c As Control
        For x As Integer = -1 To Panel1.Controls.Count - 1
            c = Me.FindControl("Button" & x + 1)

            If Not c Is Nothing Then
                If ds.Tables("Chalet").Rows(x).Item(2) = "Available" Then
                    c.BackColor = Color.LightGreen
                    AddHandler c.Click, AddressOf Button1_Click
                ElseIf ds.Tables("Chalet").Rows(x).Item(2) = "Booked" Then
                    c.BackColor = Color.LightPink
                    c.Enabled = False

                End If
            End If
        Next

        SummaryReservation.Show()
            Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button17.Click, Button18.Click, Button19.Click, Button20.Click
        Try
            If sender.BackColor = Color.LightGreen Then
                SummaryReservation.lblChaletID.Text = sender.text 'ds.Tables("Chalet").Rows(1).Item(0)

                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("ERROR:" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class