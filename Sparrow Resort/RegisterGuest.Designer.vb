<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterGuest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterGuest))
        Me.lblPassportnum = New System.Windows.Forms.Label()
        Me.lblGuestname = New System.Windows.Forms.Label()
        Me.lblContactnum = New System.Windows.Forms.Label()
        Me.lblEmailaddress = New System.Windows.Forms.Label()
        Me.txtGuestName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtPassport = New System.Windows.Forms.TextBox()
        Me.txtContactNum = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'lblPassportnum
        '
        Me.lblPassportnum.AutoSize = True
        Me.lblPassportnum.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPassportnum.Location = New System.Drawing.Point(55, 63)
        Me.lblPassportnum.Name = "lblPassportnum"
        Me.lblPassportnum.Size = New System.Drawing.Size(142, 17)
        Me.lblPassportnum.TabIndex = 0
        Me.lblPassportnum.Text = "Passport/IC Number :"
        '
        'lblGuestname
        '
        Me.lblGuestname.AutoSize = True
        Me.lblGuestname.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblGuestname.Location = New System.Drawing.Point(102, 101)
        Me.lblGuestname.Name = "lblGuestname"
        Me.lblGuestname.Size = New System.Drawing.Size(95, 17)
        Me.lblGuestname.TabIndex = 1
        Me.lblGuestname.Text = "Guest Name :"
        '
        'lblContactnum
        '
        Me.lblContactnum.AutoSize = True
        Me.lblContactnum.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblContactnum.Location = New System.Drawing.Point(75, 165)
        Me.lblContactnum.Name = "lblContactnum"
        Me.lblContactnum.Size = New System.Drawing.Size(118, 17)
        Me.lblContactnum.TabIndex = 2
        Me.lblContactnum.Text = "Contact Number :"
        '
        'lblEmailaddress
        '
        Me.lblEmailaddress.AutoSize = True
        Me.lblEmailaddress.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEmailaddress.Location = New System.Drawing.Point(91, 136)
        Me.lblEmailaddress.Name = "lblEmailaddress"
        Me.lblEmailaddress.Size = New System.Drawing.Size(106, 17)
        Me.lblEmailaddress.TabIndex = 3
        Me.lblEmailaddress.Text = "Email Address :"
        '
        'txtGuestName
        '
        Me.txtGuestName.Location = New System.Drawing.Point(203, 98)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.Size = New System.Drawing.Size(204, 23)
        Me.txtGuestName.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(203, 136)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(204, 23)
        Me.txtEmail.TabIndex = 7
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(105, 236)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(98, 34)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(209, 236)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(98, 34)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(313, 236)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(98, 34)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtPassport
        '
        Me.txtPassport.Location = New System.Drawing.Point(203, 60)
        Me.txtPassport.MaxLength = 12
        Me.txtPassport.Name = "txtPassport"
        Me.txtPassport.Size = New System.Drawing.Size(204, 23)
        Me.txtPassport.TabIndex = 4
        '
        'txtContactNum
        '
        Me.txtContactNum.Location = New System.Drawing.Point(203, 165)
        Me.txtContactNum.Mask = "(999) 000-0000"
        Me.txtContactNum.Name = "txtContactNum"
        Me.txtContactNum.Size = New System.Drawing.Size(109, 23)
        Me.txtContactNum.TabIndex = 11
        '
        'RegisterGuest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(509, 353)
        Me.Controls.Add(Me.txtContactNum)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtGuestName)
        Me.Controls.Add(Me.txtPassport)
        Me.Controls.Add(Me.lblEmailaddress)
        Me.Controls.Add(Me.lblContactnum)
        Me.Controls.Add(Me.lblGuestname)
        Me.Controls.Add(Me.lblPassportnum)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RegisterGuest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register Guest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPassportnum As Label
    Friend WithEvents lblGuestname As Label
    Friend WithEvents lblContactnum As Label
    Friend WithEvents lblEmailaddress As Label
    Friend WithEvents txtGuestName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtPassport As TextBox
    Friend WithEvents txtContactNum As MaskedTextBox
End Class
