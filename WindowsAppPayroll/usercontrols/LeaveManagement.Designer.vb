<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LeaveManagement
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.ViewemployeeleaveavailmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsAppPayroll.DataSet1()
        Me.View_employee_leave_availmentsTableAdapter = New WindowsAppPayroll.DataSet1TableAdapters.view_employee_leave_availmentsTableAdapter()
        Me.dtpYear = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.dgvEmployeeLeaves = New MetroFramework.Controls.MetroGrid()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeavenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EffectivedatefromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EffectivedatetoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsavailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsapproveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        CType(Me.ViewemployeeleaveavailmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmployeeLeaves, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel16.Location = New System.Drawing.Point(5, 7)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(202, 25)
        Me.MetroLabel16.TabIndex = 75
        Me.MetroLabel16.Text = "LEAVE MANAGEMENT"
        '
        'ViewemployeeleaveavailmentsBindingSource
        '
        Me.ViewemployeeleaveavailmentsBindingSource.DataMember = "view_employee_leave_availments"
        Me.ViewemployeeleaveavailmentsBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_employee_leave_availmentsTableAdapter
        '
        Me.View_employee_leave_availmentsTableAdapter.ClearBeforeFill = True
        '
        'dtpYear
        '
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(767, 4)
        Me.dtpYear.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.Size = New System.Drawing.Size(200, 29)
        Me.dtpYear.TabIndex = 78
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(650, 4)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(111, 19)
        Me.MetroLabel1.TabIndex = 79
        Me.MetroLabel1.Text = "Please select year"
        '
        'dgvEmployeeLeaves
        '
        Me.dgvEmployeeLeaves.AllowUserToAddRows = False
        Me.dgvEmployeeLeaves.AllowUserToDeleteRows = False
        Me.dgvEmployeeLeaves.AllowUserToOrderColumns = True
        Me.dgvEmployeeLeaves.AllowUserToResizeRows = False
        Me.dgvEmployeeLeaves.AutoGenerateColumns = False
        Me.dgvEmployeeLeaves.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEmployeeLeaves.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEmployeeLeaves.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvEmployeeLeaves.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmployeeLeaves.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEmployeeLeaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployeeLeaves.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.EmployeeidDataGridViewTextBoxColumn, Me.LeavenameDataGridViewTextBoxColumn, Me.EmployeenameDataGridViewTextBoxColumn, Me.EffectivedatefromDataGridViewTextBoxColumn, Me.EffectivedatetoDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.IsavailDataGridViewTextBoxColumn, Me.IsapproveDataGridViewTextBoxColumn})
        Me.dgvEmployeeLeaves.DataSource = Me.ViewemployeeleaveavailmentsBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmployeeLeaves.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEmployeeLeaves.EnableHeadersVisualStyles = False
        Me.dgvEmployeeLeaves.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvEmployeeLeaves.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEmployeeLeaves.Location = New System.Drawing.Point(5, 67)
        Me.dgvEmployeeLeaves.Name = "dgvEmployeeLeaves"
        Me.dgvEmployeeLeaves.ReadOnly = True
        Me.dgvEmployeeLeaves.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmployeeLeaves.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEmployeeLeaves.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvEmployeeLeaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployeeLeaves.Size = New System.Drawing.Size(962, 524)
        Me.dgvEmployeeLeaves.TabIndex = 80
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'EmployeeidDataGridViewTextBoxColumn
        '
        Me.EmployeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.HeaderText = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.Name = "EmployeeidDataGridViewTextBoxColumn"
        Me.EmployeeidDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeeidDataGridViewTextBoxColumn.Visible = False
        '
        'LeavenameDataGridViewTextBoxColumn
        '
        Me.LeavenameDataGridViewTextBoxColumn.DataPropertyName = "leave_name"
        Me.LeavenameDataGridViewTextBoxColumn.HeaderText = "Type of Leave"
        Me.LeavenameDataGridViewTextBoxColumn.Name = "LeavenameDataGridViewTextBoxColumn"
        Me.LeavenameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LeavenameDataGridViewTextBoxColumn.Width = 150
        '
        'EmployeenameDataGridViewTextBoxColumn
        '
        Me.EmployeenameDataGridViewTextBoxColumn.DataPropertyName = "employee_name"
        Me.EmployeenameDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE NAME"
        Me.EmployeenameDataGridViewTextBoxColumn.Name = "EmployeenameDataGridViewTextBoxColumn"
        Me.EmployeenameDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeenameDataGridViewTextBoxColumn.Width = 200
        '
        'EffectivedatefromDataGridViewTextBoxColumn
        '
        Me.EffectivedatefromDataGridViewTextBoxColumn.DataPropertyName = "effective_date_from"
        Me.EffectivedatefromDataGridViewTextBoxColumn.HeaderText = "FROM"
        Me.EffectivedatefromDataGridViewTextBoxColumn.Name = "EffectivedatefromDataGridViewTextBoxColumn"
        Me.EffectivedatefromDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EffectivedatetoDataGridViewTextBoxColumn
        '
        Me.EffectivedatetoDataGridViewTextBoxColumn.DataPropertyName = "effective_date_to"
        Me.EffectivedatetoDataGridViewTextBoxColumn.HeaderText = "TO"
        Me.EffectivedatetoDataGridViewTextBoxColumn.Name = "EffectivedatetoDataGridViewTextBoxColumn"
        Me.EffectivedatetoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        Me.YearDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IsavailDataGridViewTextBoxColumn
        '
        Me.IsavailDataGridViewTextBoxColumn.DataPropertyName = "is_avail"
        Me.IsavailDataGridViewTextBoxColumn.HeaderText = "Availed"
        Me.IsavailDataGridViewTextBoxColumn.Name = "IsavailDataGridViewTextBoxColumn"
        Me.IsavailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IsapproveDataGridViewTextBoxColumn
        '
        Me.IsapproveDataGridViewTextBoxColumn.DataPropertyName = "is_approve"
        Me.IsapproveDataGridViewTextBoxColumn.FalseValue = "0"
        Me.IsapproveDataGridViewTextBoxColumn.HeaderText = "Approve"
        Me.IsapproveDataGridViewTextBoxColumn.Name = "IsapproveDataGridViewTextBoxColumn"
        Me.IsapproveDataGridViewTextBoxColumn.ReadOnly = True
        Me.IsapproveDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IsapproveDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IsapproveDataGridViewTextBoxColumn.TrueValue = "1"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(8, 36)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(109, 25)
        Me.MetroLabel2.TabIndex = 82
        Me.MetroLabel2.Text = "For Approval"
        '
        'LeaveManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.dgvEmployeeLeaves)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.dtpYear)
        Me.Controls.Add(Me.MetroLabel16)
        Me.Name = "LeaveManagement"
        Me.Size = New System.Drawing.Size(971, 612)
        CType(Me.ViewemployeeleaveavailmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmployeeLeaves, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ViewemployeeleaveavailmentsBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents View_employee_leave_availmentsTableAdapter As DataSet1TableAdapters.view_employee_leave_availmentsTableAdapter
    Friend WithEvents dtpYear As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgvEmployeeLeaves As MetroFramework.Controls.MetroGrid
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LeavenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EffectivedatefromDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EffectivedatetoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsavailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsapproveDataGridViewTextBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
End Class
