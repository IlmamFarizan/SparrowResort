<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterGuestConfirm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterGuestConfirm))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblEmailaddress = New System.Windows.Forms.Label()
        Me.lblContactnum = New System.Windows.Forms.Label()
        Me.lblGuestname = New System.Windows.Forms.Label()
        Me.lblPassportnum = New System.Windows.Forms.Label()
        Me.lblPassportNum2 = New System.Windows.Forms.Label()
        Me.lblGuestName2 = New System.Windows.Forms.Label()
        Me.lblContactNum2 = New System.Windows.Forms.Label()
        Me.lblEmail2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(337, 241)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(98, 34)
        Me.btnBack.TabIndex = 21
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(129, 241)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(98, 34)
        Me.btnConfirm.TabIndex = 19
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblEmailaddress
        '
        Me.lblEmailaddress.AutoSize = True
        Me.lblEmailaddress.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEmailaddress.Location = New System.Drawing.Point(115, 175)
        Me.lblEmailaddress.Name = "lblEmailaddress"
        Me.lblEmailaddress.Size = New System.Drawing.Size(106, 17)
        Me.lblEmailaddress.TabIndex = 14
        Me.lblEmailaddress.Text = "Email Address :"
        '
        'lblContactnum
        '
        Me.lblContactnum.AutoSize = True
        Me.lblContactnum.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblContactnum.Location = New System.Drawing.Point(103, 140)
        Me.lblContactnum.Name = "lblContactnum"
        Me.lblContactnum.Size = New System.Drawing.Size(118, 17)
        Me.lblContactnum.TabIndex = 13
        Me.lblContactnum.Text = "Contact Number :"
        '
        'lblGuestname
        '
        Me.lblGuestname.AutoSize = True
        Me.lblGuestname.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblGuestname.Location = New System.Drawing.Point(126, 106)
        Me.lblGuestname.Name = "lblGuestname"
        Me.lblGuestname.Size = New System.Drawing.Size(95, 17)
        Me.lblGuestname.TabIndex = 12
        Me.lblGuestname.Text = "Guest Name :"
        '
        'lblPassportnum
        '
        Me.lblPassportnum.AutoSize = True
        Me.lblPassportnum.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPassportnum.Location = New System.Drawing.Point(79, 70)
        Me.lblPassportnum.Name = "lblPassportnum"
        Me.lblPassportnum.Size = New System.Drawing.Size(142, 17)
        Me.lblPassportnum.TabIndex = 11
        Me.lblPassportnum.Text = "Passport/IC Number :"
        '
        'lblPassportNum2
        '
        Me.lblPassportNum2.AutoSize = True
        Me.lblPassportNum2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPassportNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassportNum2.Location = New System.Drawing.Point(228, 68)
        Me.lblPassportNum2.Name = "lblPassportNum2"
        Me.lblPassportNum2.Size = New System.Drawing.Size(15, 20)
        Me.lblPassportNum2.TabIndex = 22
        Me.lblPassportNum2.Text = "-"
        '
        'lblGuestName2
        '
        Me.lblGuestName2.AutoSize = True
        Me.lblGuestName2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblGuestName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestName2.Location = New System.Drawing.Point(227, 106)
        Me.lblGuestName2.Name = "lblGuestName2"
        Me.lblGuestName2.Size = New System.Drawing.Size(15, 20)
        Me.lblGuestName2.TabIndex = 23
        Me.lblGuestName2.Text = "-"
        '
        'lblContactNum2
        '
        Me.lblContactNum2.AutoSize = True
        Me.lblContactNum2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblContactNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNum2.Location = New System.Drawing.Point(228, 140)
        Me.lblContactNum2.Name = "lblContactNum2"
        Me.lblContactNum2.Size = New System.Drawing.Size(15, 20)
        Me.lblContactNum2.TabIndex = 24
        Me.lblContactNum2.Text = "-"
        '
        'lblEmail2
        '
        Me.lblEmail2.AutoSize = True
        Me.lblEmail2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEmail2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail2.Location = New System.Drawing.Point(227, 175)
        Me.lblEmail2.Name = "lblEmail2"
        Me.lblEmail2.Size = New System.Drawing.Size(15, 20)
        Me.lblEmail2.TabIndex = 25
        Me.lblEmail2.Text = "-"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.label1.Location = New System.Drawing.Point(148, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(265, 25)
        Me.label1.TabIndex = 26
        Me.label1.Text = "Would you like to confirm?"
        '
        'RegisterGuestConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(571, 369)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lblEmail2)
        Me.Controls.Add(Me.lblContactNum2)
        Me.Controls.Add(Me.lblGuestName2)
        Me.Controls.Add(Me.lblPassportNum2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblEmailaddress)
        Me.Controls.Add(Me.lblContactnum)
        Me.Controls.Add(Me.lblGuestname)
        Me.Controls.Add(Me.lblPassportnum)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RegisterGuestConfirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterGuestConfirm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblEmailaddress As Label
    Friend WithEvents lblContactnum As Label
    Friend WithEvents lblGuestname As Label
    Friend WithEvents lblPassportnum As Label
    Friend WithEvents lblPassportNum2 As Label
    Friend WithEvents lblGuestName2 As Label
    Friend WithEvents lblContactNum2 As Label
    Friend WithEvents lblEmail2 As Label
    Friend WithEvents label1 As Label
End Class
