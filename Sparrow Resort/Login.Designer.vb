<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnSignup = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblUsername.Location = New System.Drawing.Point(95, 94)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(95, 23)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username :"
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblPassword.Location = New System.Drawing.Point(95, 149)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(95, 23)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password :"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(196, 96)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(180, 20)
        Me.txtUsername.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(196, 151)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(180, 20)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.btnLogin.Location = New System.Drawing.Point(121, 229)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(96, 32)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnSignup
        '
        Me.btnSignup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.btnSignup.Location = New System.Drawing.Point(264, 229)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(96, 32)
        Me.btnSignup.TabIndex = 5
        Me.btnSignup.Text = "Sign Up"
        Me.btnSignup.UseVisualStyleBackColor = True
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHeader.Font = New System.Drawing.Font("Perpetua Titling MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(144, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(195, 46)
        Me.lblHeader.TabIndex = 6
        Me.lblHeader.Text = "Welcome"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckBox1.Location = New System.Drawing.Point(382, 153)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(13, 312)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(0, 15)
        Me.lblDate.TabIndex = 8
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(492, 348)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.btnSignup)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sparrow Resort Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnSignup As Button
    Friend WithEvents lblHeader As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lblDate As Label
End Class
