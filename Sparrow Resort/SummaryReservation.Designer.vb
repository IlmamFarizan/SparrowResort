<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SummaryReservation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SummaryReservation))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblChaletID = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblPassportIC = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblCusResq = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblNumGuest = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNights = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.lblChaletType = New System.Windows.Forms.Label()
        Me.lblCheckOutDate = New System.Windows.Forms.Label()
        Me.lblCheckinDate = New System.Windows.Forms.Label()
        Me.lblBookedBy = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(49, 552)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 30)
        Me.btnClose.TabIndex = 55
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(569, 552)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 30)
        Me.btnBack.TabIndex = 54
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.lblChaletID)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblPassportIC)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblCusResq)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblNumGuest)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblNights)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblTotalAmount)
        Me.GroupBox1.Controls.Add(Me.lblDeposit)
        Me.GroupBox1.Controls.Add(Me.lblChaletType)
        Me.GroupBox1.Controls.Add(Me.lblCheckOutDate)
        Me.GroupBox1.Controls.Add(Me.lblCheckinDate)
        Me.GroupBox1.Controls.Add(Me.lblBookedBy)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(44, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(643, 495)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Summary of Reservation"
        '
        'lblChaletID
        '
        Me.lblChaletID.AutoSize = True
        Me.lblChaletID.Location = New System.Drawing.Point(187, 302)
        Me.lblChaletID.Name = "lblChaletID"
        Me.lblChaletID.Size = New System.Drawing.Size(19, 21)
        Me.lblChaletID.TabIndex = 66
        Me.lblChaletID.Text = ": "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 302)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 21)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Chalet ID"
        '
        'lblPassportIC
        '
        Me.lblPassportIC.AutoSize = True
        Me.lblPassportIC.Location = New System.Drawing.Point(187, 92)
        Me.lblPassportIC.Name = "lblPassportIC"
        Me.lblPassportIC.Size = New System.Drawing.Size(19, 21)
        Me.lblPassportIC.TabIndex = 64
        Me.lblPassportIC.Text = ": "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 21)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Passport/IC"
        '
        'lblCusResq
        '
        Me.lblCusResq.AutoSize = True
        Me.lblCusResq.Location = New System.Drawing.Point(186, 379)
        Me.lblCusResq.Name = "lblCusResq"
        Me.lblCusResq.Size = New System.Drawing.Size(19, 21)
        Me.lblCusResq.TabIndex = 62
        Me.lblCusResq.Text = ": "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 379)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 21)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Customer Request"
        '
        'lblNumGuest
        '
        Me.lblNumGuest.AutoSize = True
        Me.lblNumGuest.Location = New System.Drawing.Point(187, 222)
        Me.lblNumGuest.Name = "lblNumGuest"
        Me.lblNumGuest.Size = New System.Drawing.Size(19, 21)
        Me.lblNumGuest.TabIndex = 60
        Me.lblNumGuest.Text = ": "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 222)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 21)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Number of Guest"
        '
        'lblNights
        '
        Me.lblNights.AutoSize = True
        Me.lblNights.Location = New System.Drawing.Point(186, 340)
        Me.lblNights.Name = "lblNights"
        Me.lblNights.Size = New System.Drawing.Size(19, 21)
        Me.lblNights.TabIndex = 58
        Me.lblNights.Text = ": "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 340)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 21)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Nights"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Location = New System.Drawing.Point(186, 461)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(19, 21)
        Me.lblTotalAmount.TabIndex = 56
        Me.lblTotalAmount.Text = ": "
        '
        'lblDeposit
        '
        Me.lblDeposit.AutoSize = True
        Me.lblDeposit.Location = New System.Drawing.Point(186, 416)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(19, 21)
        Me.lblDeposit.TabIndex = 55
        Me.lblDeposit.Text = ": "
        '
        'lblChaletType
        '
        Me.lblChaletType.AutoSize = True
        Me.lblChaletType.Location = New System.Drawing.Point(187, 263)
        Me.lblChaletType.Name = "lblChaletType"
        Me.lblChaletType.Size = New System.Drawing.Size(19, 21)
        Me.lblChaletType.TabIndex = 54
        Me.lblChaletType.Text = ": "
        '
        'lblCheckOutDate
        '
        Me.lblCheckOutDate.AutoSize = True
        Me.lblCheckOutDate.Location = New System.Drawing.Point(187, 174)
        Me.lblCheckOutDate.Name = "lblCheckOutDate"
        Me.lblCheckOutDate.Size = New System.Drawing.Size(19, 21)
        Me.lblCheckOutDate.TabIndex = 52
        Me.lblCheckOutDate.Text = ": "
        '
        'lblCheckinDate
        '
        Me.lblCheckinDate.AutoSize = True
        Me.lblCheckinDate.Location = New System.Drawing.Point(187, 131)
        Me.lblCheckinDate.Name = "lblCheckinDate"
        Me.lblCheckinDate.Size = New System.Drawing.Size(19, 21)
        Me.lblCheckinDate.TabIndex = 51
        Me.lblCheckinDate.Text = ": "
        '
        'lblBookedBy
        '
        Me.lblBookedBy.AutoSize = True
        Me.lblBookedBy.Location = New System.Drawing.Point(187, 53)
        Me.lblBookedBy.Name = "lblBookedBy"
        Me.lblBookedBy.Size = New System.Drawing.Size(19, 21)
        Me.lblBookedBy.TabIndex = 50
        Me.lblBookedBy.Text = ": "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 461)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 416)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Deposit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Type of Chalet"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Check-out-Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Check-in-Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Booked By"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(677, 552)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 30)
        Me.btnSave.TabIndex = 53
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'SummaryReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 594)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SummaryReservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SummaryReservation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblCusResq As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblNumGuest As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblNights As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblDeposit As Label
    Friend WithEvents lblChaletType As Label
    Friend WithEvents lblCheckOutDate As Label
    Friend WithEvents lblCheckinDate As Label
    Friend WithEvents lblBookedBy As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lblPassportIC As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblChaletID As Label
    Friend WithEvents Label10 As Label
End Class
