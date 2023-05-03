<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReservationInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReservationInformation))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtxtMobile = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassportIC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(439, 572)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 30)
        Me.btnClose.TabIndex = 51
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.mtxtMobile)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtPassportIC)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtFullName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(41, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(596, 414)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guest Information"
        '
        'mtxtMobile
        '
        Me.mtxtMobile.Culture = New System.Globalization.CultureInfo("en-MY")
        Me.mtxtMobile.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtMobile.Location = New System.Drawing.Point(62, 369)
        Me.mtxtMobile.Mask = "(999) 000-0000"
        Me.mtxtMobile.Name = "mtxtMobile"
        Me.mtxtMobile.Size = New System.Drawing.Size(138, 29)
        Me.mtxtMobile.TabIndex = 68
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(57, 278)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(246, 29)
        Me.txtEmail.TabIndex = 67
        '
        'txtPassportIC
        '
        Me.txtPassportIC.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassportIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassportIC.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassportIC.Location = New System.Drawing.Point(57, 180)
        Me.txtPassportIC.MaxLength = 12
        Me.txtPassportIC.Name = "txtPassportIC"
        Me.txtPassportIC.Size = New System.Drawing.Size(246, 29)
        Me.txtPassportIC.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 21)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Passport/IC "
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.SystemColors.Window
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(57, 77)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(246, 29)
        Me.txtFullName.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 21)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Email Address "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 21)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Full Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 21)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Mobile"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(41, 572)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 30)
        Me.btnClear.TabIndex = 49
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(547, 572)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(90, 30)
        Me.btnNext.TabIndex = 48
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'txtFind
        '
        Me.txtFind.BackColor = System.Drawing.SystemColors.Window
        Me.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFind.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFind.Location = New System.Drawing.Point(193, 56)
        Me.txtFind.MaxLength = 12
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(246, 29)
        Me.txtFind.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 21)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Passport/IC "
        '
        'btnFind
        '
        Me.btnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Location = New System.Drawing.Point(514, 59)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 29)
        Me.btnFind.TabIndex = 68
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(445, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 40)
        Me.Button1.TabIndex = 69
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReservationInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(679, 628)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReservationInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReservationInformation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mtxtMobile As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassportIC As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtFind As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnFind As Button
    Friend WithEvents Button1 As Button
End Class
