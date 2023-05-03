<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Manager", "Staff"})
        Me.ComboBox1.Location = New System.Drawing.Point(292, 191)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(199, 24)
        Me.ComboBox1.TabIndex = 15
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(292, 112)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(199, 22)
        Me.txtUsername.TabIndex = 14
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(293, 150)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(199, 22)
        Me.txtPassword.TabIndex = 13
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(292, 69)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(199, 22)
        Me.txtFname.TabIndex = 12
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.lblRole.Location = New System.Drawing.Point(213, 188)
        Me.lblRole.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(68, 25)
        Me.lblRole.TabIndex = 11
        Me.lblRole.Text = "Role :"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.lblPassword.Location = New System.Drawing.Point(161, 148)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(118, 25)
        Me.lblPassword.TabIndex = 10
        Me.lblPassword.Text = "Password :"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.lblUsername.Location = New System.Drawing.Point(157, 110)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(122, 25)
        Me.lblUsername.TabIndex = 9
        Me.lblUsername.Text = "Username :"
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.lblFname.Location = New System.Drawing.Point(157, 69)
        Me.lblFname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(121, 25)
        Me.lblFname.TabIndex = 8
        Me.lblFname.Text = "Full Name :"
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnSubmit.Location = New System.Drawing.Point(183, 246)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(135, 46)
        Me.btnSubmit.TabIndex = 16
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnBack.Location = New System.Drawing.Point(356, 246)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(137, 46)
        Me.btnBack.TabIndex = 17
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(729, 404)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblFname)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents lblRole As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblFname As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnBack As Button
End Class
