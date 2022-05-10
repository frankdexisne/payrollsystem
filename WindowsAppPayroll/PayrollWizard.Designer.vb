<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayrollWizard
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HolidaydateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsregularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.HolidaysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsAppPayroll.DataSet1()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MetroGrid2 = New MetroFramework.Controls.MetroGrid()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeavenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EffectivedatefromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EffectivedatetoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsavailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsapproveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewemployeeleaveavailmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.cboPayrollPeriod = New MetroFramework.Controls.MetroComboBox()
        Me.ViewpayrollperiodsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.HolidaysTableAdapter = New WindowsAppPayroll.DataSet1TableAdapters.holidaysTableAdapter()
        Me.ViewemployeeleavesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_employee_leavesTableAdapter = New WindowsAppPayroll.DataSet1TableAdapters.view_employee_leavesTableAdapter()
        Me.View_employee_leave_availmentsTableAdapter = New WindowsAppPayroll.DataSet1TableAdapters.view_employee_leave_availmentsTableAdapter()
        Me.View_payroll_periodsTableAdapter = New WindowsAppPayroll.DataSet1TableAdapters.view_payroll_periodsTableAdapter()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnCompute = New MetroFramework.Controls.MetroButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.btnAddHoliday = New MetroFramework.Controls.MetroButton()
        Me.btnAddLeave = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HolidaysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.MetroGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewemployeeleaveavailmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewpayrollperiodsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewemployeeleavesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.TabPage1)
        Me.MetroTabControl1.Controls.Add(Me.TabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 143)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 1
        Me.MetroTabControl1.Size = New System.Drawing.Size(699, 322)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MetroGrid1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(691, 294)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Holidays"
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.AutoGenerateColumns = False
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.HolidaydateDataGridViewTextBoxColumn, Me.IsregularDataGridViewTextBoxColumn})
        Me.MetroGrid1.DataSource = Me.HolidaysBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(0, 0)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.ReadOnly = True
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(691, 294)
        Me.MetroGrid1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 150
        '
        'HolidaydateDataGridViewTextBoxColumn
        '
        Me.HolidaydateDataGridViewTextBoxColumn.DataPropertyName = "holiday_date"
        Me.HolidaydateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.HolidaydateDataGridViewTextBoxColumn.Name = "HolidaydateDataGridViewTextBoxColumn"
        Me.HolidaydateDataGridViewTextBoxColumn.ReadOnly = True
        Me.HolidaydateDataGridViewTextBoxColumn.Width = 150
        '
        'IsregularDataGridViewTextBoxColumn
        '
        Me.IsregularDataGridViewTextBoxColumn.DataPropertyName = "is_regular"
        Me.IsregularDataGridViewTextBoxColumn.FalseValue = "0"
        Me.IsregularDataGridViewTextBoxColumn.HeaderText = "Is Regular"
        Me.IsregularDataGridViewTextBoxColumn.Name = "IsregularDataGridViewTextBoxColumn"
        Me.IsregularDataGridViewTextBoxColumn.ReadOnly = True
        Me.IsregularDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IsregularDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IsregularDataGridViewTextBoxColumn.TrueValue = "1"
        '
        'HolidaysBindingSource
        '
        Me.HolidaysBindingSource.DataMember = "holidays"
        Me.HolidaysBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.MetroGrid2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(691, 280)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Leave Applications"
        '
        'MetroGrid2
        '
        Me.MetroGrid2.AllowUserToAddRows = False
        Me.MetroGrid2.AllowUserToDeleteRows = False
        Me.MetroGrid2.AllowUserToResizeRows = False
        Me.MetroGrid2.AutoGenerateColumns = False
        Me.MetroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MetroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.EmployeeidDataGridViewTextBoxColumn, Me.LeavenameDataGridViewTextBoxColumn, Me.EmployeenameDataGridViewTextBoxColumn, Me.EffectivedatefromDataGridViewTextBoxColumn, Me.EffectivedatetoDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.IsavailDataGridViewTextBoxColumn, Me.IsapproveDataGridViewTextBoxColumn})
        Me.MetroGrid2.DataSource = Me.ViewemployeeleaveavailmentsBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid2.DefaultCellStyle = DataGridViewCellStyle5
        Me.MetroGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroGrid2.EnableHeadersVisualStyles = False
        Me.MetroGrid2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid2.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid2.Location = New System.Drawing.Point(0, 0)
        Me.MetroGrid2.Name = "MetroGrid2"
        Me.MetroGrid2.ReadOnly = True
        Me.MetroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid2.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.MetroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid2.Size = New System.Drawing.Size(691, 280)
        Me.MetroGrid2.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn1.Visible = False
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
        Me.LeavenameDataGridViewTextBoxColumn.HeaderText = "Avail Leave"
        Me.LeavenameDataGridViewTextBoxColumn.Name = "LeavenameDataGridViewTextBoxColumn"
        Me.LeavenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeenameDataGridViewTextBoxColumn
        '
        Me.EmployeenameDataGridViewTextBoxColumn.DataPropertyName = "employee_name"
        Me.EmployeenameDataGridViewTextBoxColumn.HeaderText = "Employee"
        Me.EmployeenameDataGridViewTextBoxColumn.Name = "EmployeenameDataGridViewTextBoxColumn"
        Me.EmployeenameDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeenameDataGridViewTextBoxColumn.Width = 200
        '
        'EffectivedatefromDataGridViewTextBoxColumn
        '
        Me.EffectivedatefromDataGridViewTextBoxColumn.DataPropertyName = "effective_date_from"
        Me.EffectivedatefromDataGridViewTextBoxColumn.HeaderText = "Effective From"
        Me.EffectivedatefromDataGridViewTextBoxColumn.Name = "EffectivedatefromDataGridViewTextBoxColumn"
        Me.EffectivedatefromDataGridViewTextBoxColumn.ReadOnly = True
        Me.EffectivedatefromDataGridViewTextBoxColumn.Width = 150
        '
        'EffectivedatetoDataGridViewTextBoxColumn
        '
        Me.EffectivedatetoDataGridViewTextBoxColumn.DataPropertyName = "effective_date_to"
        Me.EffectivedatetoDataGridViewTextBoxColumn.HeaderText = "Effective To"
        Me.EffectivedatetoDataGridViewTextBoxColumn.Name = "EffectivedatetoDataGridViewTextBoxColumn"
        Me.EffectivedatetoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EffectivedatetoDataGridViewTextBoxColumn.Width = 150
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
        Me.IsavailDataGridViewTextBoxColumn.HeaderText = "Is Avail"
        Me.IsavailDataGridViewTextBoxColumn.Name = "IsavailDataGridViewTextBoxColumn"
        Me.IsavailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IsapproveDataGridViewTextBoxColumn
        '
        Me.IsapproveDataGridViewTextBoxColumn.DataPropertyName = "is_approve"
        Me.IsapproveDataGridViewTextBoxColumn.HeaderText = "Is Approve"
        Me.IsapproveDataGridViewTextBoxColumn.Name = "IsapproveDataGridViewTextBoxColumn"
        Me.IsapproveDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ViewemployeeleaveavailmentsBindingSource
        '
        Me.ViewemployeeleaveavailmentsBindingSource.DataMember = "view_employee_leave_availments"
        Me.ViewemployeeleaveavailmentsBindingSource.DataSource = Me.DataSet1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(685, 63)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(37, 25)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseSelectable = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(599, 20)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(123, 25)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseSelectable = True
        '
        'cboPayrollPeriod
        '
        Me.cboPayrollPeriod.DataSource = Me.ViewpayrollperiodsBindingSource
        Me.cboPayrollPeriod.DisplayMember = "payroll_range"
        Me.cboPayrollPeriod.FormattingEnabled = True
        Me.cboPayrollPeriod.ItemHeight = 23
        Me.cboPayrollPeriod.Location = New System.Drawing.Point(123, 63)
        Me.cboPayrollPeriod.Name = "cboPayrollPeriod"
        Me.cboPayrollPeriod.Size = New System.Drawing.Size(556, 29)
        Me.cboPayrollPeriod.TabIndex = 3
        Me.cboPayrollPeriod.UseSelectable = True
        Me.cboPayrollPeriod.ValueMember = "id"
        '
        'ViewpayrollperiodsBindingSource
        '
        Me.ViewpayrollperiodsBindingSource.DataMember = "view_payroll_periods"
        Me.ViewpayrollperiodsBindingSource.DataSource = Me.DataSet1
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(27, 63)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(90, 19)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "Payroll Period"
        '
        'HolidaysTableAdapter
        '
        Me.HolidaysTableAdapter.ClearBeforeFill = True
        '
        'ViewemployeeleavesBindingSource
        '
        Me.ViewemployeeleavesBindingSource.DataMember = "view_employee_leaves"
        Me.ViewemployeeleavesBindingSource.DataSource = Me.DataSet1
        '
        'View_employee_leavesTableAdapter
        '
        Me.View_employee_leavesTableAdapter.ClearBeforeFill = True
        '
        'View_employee_leave_availmentsTableAdapter
        '
        Me.View_employee_leave_availmentsTableAdapter.ClearBeforeFill = True
        '
        'View_payroll_periodsTableAdapter
        '
        Me.View_payroll_periodsTableAdapter.ClearBeforeFill = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(260, 98)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(182, 25)
        Me.MetroButton1.TabIndex = 5
        Me.MetroButton1.Text = "Show Holidays/Leaves"
        Me.MetroButton1.UseSelectable = True
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(448, 98)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(123, 25)
        Me.btnCompute.TabIndex = 6
        Me.btnCompute.Text = "Start Compute"
        Me.btnCompute.UseSelectable = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(577, 98)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(102, 25)
        Me.MetroButton2.TabIndex = 7
        Me.MetroButton2.Text = "Payroll Summary"
        Me.MetroButton2.UseSelectable = True
        '
        'btnAddHoliday
        '
        Me.btnAddHoliday.Location = New System.Drawing.Point(210, 20)
        Me.btnAddHoliday.Name = "btnAddHoliday"
        Me.btnAddHoliday.Size = New System.Drawing.Size(123, 25)
        Me.btnAddHoliday.TabIndex = 8
        Me.btnAddHoliday.Text = "Add Holiday"
        Me.btnAddHoliday.UseSelectable = True
        '
        'btnAddLeave
        '
        Me.btnAddLeave.Location = New System.Drawing.Point(339, 20)
        Me.btnAddLeave.Name = "btnAddLeave"
        Me.btnAddLeave.Size = New System.Drawing.Size(123, 25)
        Me.btnAddLeave.TabIndex = 9
        Me.btnAddLeave.Text = "Leave Entry"
        Me.btnAddLeave.UseSelectable = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(469, 20)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(123, 25)
        Me.MetroButton3.TabIndex = 10
        Me.MetroButton3.Text = "For Approval Leave"
        Me.MetroButton3.UseSelectable = True
        '
        'PayrollWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 488)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.btnAddLeave)
        Me.Controls.Add(Me.btnAddHoliday)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.cboPayrollPeriod)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Name = "PayrollWizard"
        Me.Text = "Payroll Wizard"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HolidaysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.MetroGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewemployeeleaveavailmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewpayrollperiodsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewemployeeleavesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents HolidaysBindingSource As BindingSource
    Friend WithEvents HolidaysTableAdapter As DataSet1TableAdapters.holidaysTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HolidaydateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsregularDataGridViewTextBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents MetroGrid2 As MetroFramework.Controls.MetroGrid
    Friend WithEvents ViewemployeeleavesBindingSource As BindingSource
    Friend WithEvents View_employee_leavesTableAdapter As DataSet1TableAdapters.view_employee_leavesTableAdapter
    Friend WithEvents ViewemployeeleaveavailmentsBindingSource As BindingSource
    Friend WithEvents View_employee_leave_availmentsTableAdapter As DataSet1TableAdapters.view_employee_leave_availmentsTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LeavenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EffectivedatefromDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EffectivedatetoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsavailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsapproveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents cboPayrollPeriod As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ViewpayrollperiodsBindingSource As BindingSource
    Friend WithEvents View_payroll_periodsTableAdapter As DataSet1TableAdapters.view_payroll_periodsTableAdapter
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCompute As MetroFramework.Controls.MetroButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAddHoliday As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAddLeave As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
End Class
