<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DatabaseGuestDetails
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.DataSet1 = New Sparrow_Resort.DataSet1()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuestDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuestDetailsTableAdapter = New Sparrow_Resort.DataSet1TableAdapters.GuestDetailsTableAdapter()
        Me.TableAdapterManager = New Sparrow_Resort.DataSet1TableAdapters.TableAdapterManager()
        Me.PassportNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuestNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuestDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PassportNumberDataGridViewTextBoxColumn, Me.GuestNameDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.EmailAddressDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GuestDetailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(23, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(553, 450)
        Me.DataGridView1.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(41, 489)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 33)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(501, 478)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 33)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'GuestDetailsBindingSource
        '
        Me.GuestDetailsBindingSource.DataMember = "GuestDetails"
        Me.GuestDetailsBindingSource.DataSource = Me.DataSet1
        '
        'GuestDetailsTableAdapter
        '
        Me.GuestDetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChaletTableAdapter = Nothing
        Me.TableAdapterManager.GuestDetailsTableAdapter = Me.GuestDetailsTableAdapter
        Me.TableAdapterManager.ReservationDetailsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sparrow_Resort.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PassportNumberDataGridViewTextBoxColumn
        '
        Me.PassportNumberDataGridViewTextBoxColumn.DataPropertyName = "PassportNumber"
        Me.PassportNumberDataGridViewTextBoxColumn.HeaderText = "PassportNumber"
        Me.PassportNumberDataGridViewTextBoxColumn.Name = "PassportNumberDataGridViewTextBoxColumn"
        '
        'GuestNameDataGridViewTextBoxColumn
        '
        Me.GuestNameDataGridViewTextBoxColumn.DataPropertyName = "GuestName"
        Me.GuestNameDataGridViewTextBoxColumn.HeaderText = "GuestName"
        Me.GuestNameDataGridViewTextBoxColumn.Name = "GuestNameDataGridViewTextBoxColumn"
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        '
        'EmailAddressDataGridViewTextBoxColumn
        '
        Me.EmailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress"
        Me.EmailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress"
        Me.EmailAddressDataGridViewTextBoxColumn.Name = "EmailAddressDataGridViewTextBoxColumn"
        '
        'DatabaseGuestDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 534)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DatabaseGuestDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DatabaseGuestDetails"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuestDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents GuestDetailsBindingSource As BindingSource
    Friend WithEvents GuestDetailsTableAdapter As DataSet1TableAdapters.GuestDetailsTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents PassportNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GuestNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
