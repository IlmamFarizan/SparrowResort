<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExtendBookingDate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExtendBookingDate))
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCheckOutDate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBookedBy = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(65, 93)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(321, 29)
        Me.DateTimePicker2.TabIndex = 112
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(142, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 21)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Check-out-Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 197)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 150)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Please Select the Date"
        '
        'lblCheckOutDate
        '
        Me.lblCheckOutDate.AutoSize = True
        Me.lblCheckOutDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckOutDate.Location = New System.Drawing.Point(224, 51)
        Me.lblCheckOutDate.Name = "lblCheckOutDate"
        Me.lblCheckOutDate.Size = New System.Drawing.Size(20, 24)
        Me.lblCheckOutDate.TabIndex = 117
        Me.lblCheckOutDate.Text = ": "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 24)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Check-out-Date"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblCheckOutDate)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(49, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(526, 99)
        Me.GroupBox2.TabIndex = 118
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Original Date"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(62, 388)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 30)
        Me.btnBack.TabIndex = 120
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(534, 388)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(90, 30)
        Me.btnSubmit.TabIndex = 119
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 24)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Booked By"
        '
        'lblBookedBy
        '
        Me.lblBookedBy.AutoSize = True
        Me.lblBookedBy.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBookedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookedBy.Location = New System.Drawing.Point(273, 32)
        Me.lblBookedBy.Name = "lblBookedBy"
        Me.lblBookedBy.Size = New System.Drawing.Size(20, 24)
        Me.lblBookedBy.TabIndex = 122
        Me.lblBookedBy.Text = ": "
        '
        'ExtendBookingDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(667, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblBookedBy)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ExtendBookingDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExtendBookingDate"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblCheckOutDate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBookedBy As Label
End Class
