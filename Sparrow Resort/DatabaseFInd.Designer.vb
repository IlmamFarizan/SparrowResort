<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DatabaseFInd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatabaseFInd))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReservationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuestIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckIndateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckOutdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuestNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIghtsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChaletTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChaletIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerRequestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepositDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Sparrow_Resort.DataSet1()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.PassportNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuestNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuestDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationDetailsTableAdapter = New Sparrow_Resort.DataSet1TableAdapters.ReservationDetailsTableAdapter()
        Me.TableAdapterManager = New Sparrow_Resort.DataSet1TableAdapters.TableAdapterManager()
        Me.GuestDetailsTableAdapter = New Sparrow_Resort.DataSet1TableAdapters.GuestDetailsTableAdapter()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuestDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(1143, 519)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 33)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReservationIDDataGridViewTextBoxColumn, Me.BookedByDataGridViewTextBoxColumn, Me.GuestIDDataGridViewTextBoxColumn, Me.CheckIndateDataGridViewTextBoxColumn, Me.CheckOutdateDataGridViewTextBoxColumn, Me.GuestNumberDataGridViewTextBoxColumn, Me.NIghtsDataGridViewTextBoxColumn, Me.ChaletTypeDataGridViewTextBoxColumn, Me.ChaletIDDataGridViewTextBoxColumn, Me.CustomerRequestDataGridViewTextBoxColumn, Me.DepositDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReservationDetailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(53, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1241, 222)
        Me.DataGridView1.TabIndex = 3
        '
        'ReservationIDDataGridViewTextBoxColumn
        '
        Me.ReservationIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationID"
        Me.ReservationIDDataGridViewTextBoxColumn.HeaderText = "ReservationID"
        Me.ReservationIDDataGridViewTextBoxColumn.Name = "ReservationIDDataGridViewTextBoxColumn"
        '
        'BookedByDataGridViewTextBoxColumn
        '
        Me.BookedByDataGridViewTextBoxColumn.DataPropertyName = "BookedBy"
        Me.BookedByDataGridViewTextBoxColumn.HeaderText = "BookedBy"
        Me.BookedByDataGridViewTextBoxColumn.Name = "BookedByDataGridViewTextBoxColumn"
        '
        'GuestIDDataGridViewTextBoxColumn
        '
        Me.GuestIDDataGridViewTextBoxColumn.DataPropertyName = "GuestID"
        Me.GuestIDDataGridViewTextBoxColumn.HeaderText = "GuestID"
        Me.GuestIDDataGridViewTextBoxColumn.Name = "GuestIDDataGridViewTextBoxColumn"
        '
        'CheckIndateDataGridViewTextBoxColumn
        '
        Me.CheckIndateDataGridViewTextBoxColumn.DataPropertyName = "CheckIndate"
        Me.CheckIndateDataGridViewTextBoxColumn.HeaderText = "CheckIndate"
        Me.CheckIndateDataGridViewTextBoxColumn.Name = "CheckIndateDataGridViewTextBoxColumn"
        '
        'CheckOutdateDataGridViewTextBoxColumn
        '
        Me.CheckOutdateDataGridViewTextBoxColumn.DataPropertyName = "CheckOutdate"
        Me.CheckOutdateDataGridViewTextBoxColumn.HeaderText = "CheckOutdate"
        Me.CheckOutdateDataGridViewTextBoxColumn.Name = "CheckOutdateDataGridViewTextBoxColumn"
        '
        'GuestNumberDataGridViewTextBoxColumn
        '
        Me.GuestNumberDataGridViewTextBoxColumn.DataPropertyName = "GuestNumber"
        Me.GuestNumberDataGridViewTextBoxColumn.HeaderText = "GuestNumber"
        Me.GuestNumberDataGridViewTextBoxColumn.Name = "GuestNumberDataGridViewTextBoxColumn"
        '
        'NIghtsDataGridViewTextBoxColumn
        '
        Me.NIghtsDataGridViewTextBoxColumn.DataPropertyName = "NIghts"
        Me.NIghtsDataGridViewTextBoxColumn.HeaderText = "NIghts"
        Me.NIghtsDataGridViewTextBoxColumn.Name = "NIghtsDataGridViewTextBoxColumn"
        '
        'ChaletTypeDataGridViewTextBoxColumn
        '
        Me.ChaletTypeDataGridViewTextBoxColumn.DataPropertyName = "ChaletType"
        Me.ChaletTypeDataGridViewTextBoxColumn.HeaderText = "ChaletType"
        Me.ChaletTypeDataGridViewTextBoxColumn.Name = "ChaletTypeDataGridViewTextBoxColumn"
        '
        'ChaletIDDataGridViewTextBoxColumn
        '
        Me.ChaletIDDataGridViewTextBoxColumn.DataPropertyName = "ChaletID"
        Me.ChaletIDDataGridViewTextBoxColumn.HeaderText = "ChaletID"
        Me.ChaletIDDataGridViewTextBoxColumn.Name = "ChaletIDDataGridViewTextBoxColumn"
        '
        'CustomerRequestDataGridViewTextBoxColumn
        '
        Me.CustomerRequestDataGridViewTextBoxColumn.DataPropertyName = "CustomerRequest"
        Me.CustomerRequestDataGridViewTextBoxColumn.HeaderText = "CustomerRequest"
        Me.CustomerRequestDataGridViewTextBoxColumn.Name = "CustomerRequestDataGridViewTextBoxColumn"
        '
        'DepositDataGridViewTextBoxColumn
        '
        Me.DepositDataGridViewTextBoxColumn.DataPropertyName = "Deposit"
        Me.DepositDataGridViewTextBoxColumn.HeaderText = "Deposit"
        Me.DepositDataGridViewTextBoxColumn.Name = "DepositDataGridViewTextBoxColumn"
        '
        'TotalAmountDataGridViewTextBoxColumn
        '
        Me.TotalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.Name = "TotalAmountDataGridViewTextBoxColumn"
        '
        'ReservationDetailsBindingSource
        '
        Me.ReservationDetailsBindingSource.DataMember = "ReservationDetails"
        Me.ReservationDetailsBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PassportNumberDataGridViewTextBoxColumn, Me.GuestNameDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.EmailAddressDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.GuestDetailsBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(53, 301)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(964, 251)
        Me.DataGridView2.TabIndex = 5
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
        'GuestDetailsBindingSource
        '
        Me.GuestDetailsBindingSource.DataMember = "GuestDetails"
        Me.GuestDetailsBindingSource.DataSource = Me.DataSet1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Reservation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Guest Details"
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'ReservationDetailsTableAdapter
        '
        Me.ReservationDetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChaletTableAdapter = Nothing
        Me.TableAdapterManager.GuestDetailsTableAdapter = Me.GuestDetailsTableAdapter
        Me.TableAdapterManager.ReservationDetailsTableAdapter = Me.ReservationDetailsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sparrow_Resort.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GuestDetailsTableAdapter
        '
        Me.GuestDetailsTableAdapter.ClearBeforeFill = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1306, 25)
        Me.BindingNavigator1.TabIndex = 9
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'DatabaseFInd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1306, 586)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DatabaseFInd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DatabaseFInd"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuestDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ReservationDetailsBindingSource As BindingSource
    Friend WithEvents ReservationDetailsTableAdapter As DataSet1TableAdapters.ReservationDetailsTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ReservationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GuestIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CheckIndateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CheckOutdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GuestNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NIghtsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChaletTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChaletIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerRequestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepositDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GuestDetailsTableAdapter As DataSet1TableAdapters.GuestDetailsTableAdapter
    Friend WithEvents GuestDetailsBindingSource As BindingSource
    Friend WithEvents PassportNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GuestNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
End Class
