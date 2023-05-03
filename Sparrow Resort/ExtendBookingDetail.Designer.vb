<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExtendBookingDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExtendBookingDetail))
        Me.txtPassportIC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPassportIC
        '
        Me.txtPassportIC.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassportIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassportIC.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassportIC.Location = New System.Drawing.Point(49, 109)
        Me.txtPassportIC.MaxLength = 12
        Me.txtPassportIC.Name = "txtPassportIC"
        Me.txtPassportIC.Size = New System.Drawing.Size(246, 29)
        Me.txtPassportIC.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Passport/IC"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(152, 270)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 30)
        Me.btnClose.TabIndex = 74
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(45, 270)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 30)
        Me.btnClear.TabIndex = 73
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(408, 270)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 30)
        Me.btnSearch.TabIndex = 72
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.txtPassportIC)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 188)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Extend Booking"
        '
        'ExtendBookingDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(562, 343)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ExtendBookingDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExtendBookingDetail"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPassportIC As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
