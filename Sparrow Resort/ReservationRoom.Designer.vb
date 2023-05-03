<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReservationRoom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReservationRoom))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRequestBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.lblNights = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtNumGuest = New System.Windows.Forms.TextBox()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblChaletPrice = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radSupreme = New System.Windows.Forms.RadioButton()
        Me.radStandard = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(574, 611)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 30)
        Me.btnBack.TabIndex = 104
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(680, 611)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(90, 30)
        Me.btnCalculate.TabIndex = 103
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(78, 611)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 30)
        Me.btnClear.TabIndex = 102
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(786, 611)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(90, 30)
        Me.btnNext.TabIndex = 101
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.txtRequestBox)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.lblNights)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txtNumGuest)
        Me.GroupBox1.Controls.Add(Me.lblDeposit)
        Me.GroupBox1.Controls.Add(Me.lblTotalAmount)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblChaletPrice)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(39, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 578)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reservation Room"
        '
        'txtRequestBox
        '
        Me.txtRequestBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtRequestBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRequestBox.Location = New System.Drawing.Point(314, 151)
        Me.txtRequestBox.Multiline = True
        Me.txtRequestBox.Name = "txtRequestBox"
        Me.txtRequestBox.Size = New System.Drawing.Size(518, 197)
        Me.txtRequestBox.TabIndex = 99
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.Button15)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button11)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button20)
        Me.Panel1.Controls.Add(Me.Button12)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button19)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button13)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button18)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button14)
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.Button17)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button16)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Location = New System.Drawing.Point(45, 376)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 182)
        Me.Panel1.TabIndex = 110
        '
        'Button15
        '
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(329, 5)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(81, 31)
        Me.Button15.TabIndex = 6
        Me.Button15.Text = "SP006"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(18, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "SD001"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(329, 148)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(81, 31)
        Me.Button11.TabIndex = 10
        Me.Button11.Text = "SP010"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(18, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 31)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "SD002"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.Location = New System.Drawing.Point(237, 5)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(81, 31)
        Me.Button20.TabIndex = 1
        Me.Button20.Text = " SP001"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(329, 111)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(81, 31)
        Me.Button12.TabIndex = 9
        Me.Button12.Text = "SP009"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(18, 74)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(81, 31)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "SD003"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.Location = New System.Drawing.Point(237, 37)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(81, 31)
        Me.Button19.TabIndex = 2
        Me.Button19.Text = "SP002"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(110, 148)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(81, 31)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "SD010"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(329, 74)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(81, 31)
        Me.Button13.TabIndex = 8
        Me.Button13.Text = "SP008"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(18, 111)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(81, 31)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "SD004"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.Location = New System.Drawing.Point(237, 74)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(81, 31)
        Me.Button18.TabIndex = 3
        Me.Button18.Text = "SP003"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(18, 148)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(81, 31)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "SD005"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(329, 37)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(81, 31)
        Me.Button14.TabIndex = 7
        Me.Button14.Text = "SP007"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(111, 5)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(81, 31)
        Me.Button10.TabIndex = 6
        Me.Button10.Text = "SD006"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.Location = New System.Drawing.Point(237, 111)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(81, 31)
        Me.Button17.TabIndex = 4
        Me.Button17.Text = " SP004"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(111, 37)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(81, 31)
        Me.Button9.TabIndex = 7
        Me.Button9.Text = "SD007"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(237, 148)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(81, 31)
        Me.Button16.TabIndex = 5
        Me.Button16.Text = " SP005"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(110, 111)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(81, 31)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "SD009"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(110, 74)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(81, 31)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "SD008"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'lblNights
        '
        Me.lblNights.BackColor = System.Drawing.SystemColors.Control
        Me.lblNights.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNights.Location = New System.Drawing.Point(156, 126)
        Me.lblNights.Name = "lblNights"
        Me.lblNights.Size = New System.Drawing.Size(85, 31)
        Me.lblNights.TabIndex = 109
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(492, 74)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(286, 29)
        Me.DateTimePicker2.TabIndex = 108
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Location = New System.Drawing.Point(45, 74)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(286, 29)
        Me.DateTimePicker1.TabIndex = 107
        Me.DateTimePicker1.Value = New Date(2018, 10, 7, 1, 28, 8, 0)
        '
        'txtNumGuest
        '
        Me.txtNumGuest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumGuest.Location = New System.Drawing.Point(747, 409)
        Me.txtNumGuest.Multiline = True
        Me.txtNumGuest.Name = "txtNumGuest"
        Me.txtNumGuest.Size = New System.Drawing.Size(85, 31)
        Me.txtNumGuest.TabIndex = 106
        '
        'lblDeposit
        '
        Me.lblDeposit.AutoSize = True
        Me.lblDeposit.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeposit.Location = New System.Drawing.Point(743, 497)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(0, 21)
        Me.lblDeposit.TabIndex = 104
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(743, 537)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(0, 21)
        Me.lblTotalAmount.TabIndex = 103
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(586, 537)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 21)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "Total Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(586, 497)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 21)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Deposit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(310, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 21)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Notes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 21)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Nights"
        '
        'lblChaletPrice
        '
        Me.lblChaletPrice.AutoSize = True
        Me.lblChaletPrice.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChaletPrice.Location = New System.Drawing.Point(743, 460)
        Me.lblChaletPrice.Name = "lblChaletPrice"
        Me.lblChaletPrice.Size = New System.Drawing.Size(0, 21)
        Me.lblChaletPrice.TabIndex = 94
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Controls.Add(Me.radSupreme)
        Me.GroupBox2.Controls.Add(Me.radStandard)
        Me.GroupBox2.Location = New System.Drawing.Point(45, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(196, 156)
        Me.GroupBox2.TabIndex = 91
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type of Chalet"
        '
        'radSupreme
        '
        Me.radSupreme.AutoSize = True
        Me.radSupreme.Location = New System.Drawing.Point(18, 94)
        Me.radSupreme.Name = "radSupreme"
        Me.radSupreme.Size = New System.Drawing.Size(94, 25)
        Me.radSupreme.TabIndex = 1
        Me.radSupreme.TabStop = True
        Me.radSupreme.Text = "Supreme"
        Me.radSupreme.UseVisualStyleBackColor = True
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.Location = New System.Drawing.Point(18, 48)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Size = New System.Drawing.Size(100, 25)
        Me.radStandard.TabIndex = 0
        Me.radStandard.TabStop = True
        Me.radStandard.Text = "Standard "
        Me.radStandard.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(586, 460)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 21)
        Me.Label8.TabIndex = 89
        Me.Label8.Text = "Chalet Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(586, 419)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 21)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Number of Guest"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(531, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 21)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Check-out-Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(136, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 21)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Check-in-Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(192, 620)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "text"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(222, 620)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Booked"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightGreen
        Me.Label11.Location = New System.Drawing.Point(290, 620)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 13)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "text"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(326, 620)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 108
        Me.Label12.Text = "Available"
        '
        'ReservationRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(919, 653)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReservationRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReservationRoom"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNights As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtNumGuest As TextBox
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRequestBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radSupreme As RadioButton
    Friend WithEvents radStandard As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button15 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDeposit As Label
    Friend WithEvents lblChaletPrice As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
