<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchGuest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchGuest))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPassportIC = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContactNum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(35, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Passport Number/IC Number :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.txtPassportIC)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 71)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search by IC/Passport Number"
        '
        'txtPassportIC
        '
        Me.txtPassportIC.Location = New System.Drawing.Point(237, 30)
        Me.txtPassportIC.Name = "txtPassportIC"
        Me.txtPassportIC.Size = New System.Drawing.Size(204, 23)
        Me.txtPassportIC.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.txtEmail)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtContactNum)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 147)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(398, 136)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Guest Details"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(155, 91)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(204, 23)
        Me.txtEmail.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Email Address :"
        '
        'txtContactNum
        '
        Me.txtContactNum.Location = New System.Drawing.Point(155, 62)
        Me.txtContactNum.Name = "txtContactNum"
        Me.txtContactNum.Size = New System.Drawing.Size(204, 23)
        Me.txtContactNum.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contact Number :"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(155, 33)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(204, 23)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(96, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name :"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnSearch.Location = New System.Drawing.Point(488, 60)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(93, 33)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnModify.Location = New System.Drawing.Point(425, 180)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(137, 33)
        Me.btnModify.TabIndex = 4
        Me.btnModify.Text = "Modify Details"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnBack.Location = New System.Drawing.Point(534, 343)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(93, 33)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnClear.Location = New System.Drawing.Point(425, 233)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(137, 33)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(580, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 40)
        Me.Button1.TabIndex = 70
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SearchGuest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(639, 388)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SearchGuest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SearchGuest"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPassportIC As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtContactNum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Button1 As Button
End Class
