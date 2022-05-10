<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeList
    Inherits MetroFramework.Forms.MetroForm

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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvEmployees = New MetroFramework.Controls.MetroGrid()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewemployeesearchresultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsAppPayroll.DataSet1()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.btnSearch = New MetroFramework.Controls.MetroButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.View_employee_search_resultTableAdapter = New WindowsAppPayroll.DataSet1TableAdapters.view_employee_search_resultTableAdapter()
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.ViewProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkAsResignedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyForToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OvertimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewemployeesearchresultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroContextMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvEmployees
        '
        Me.dgvEmployees.AllowUserToAddRows = False
        Me.dgvEmployees.AllowUserToDeleteRows = False
        Me.dgvEmployees.AllowUserToResizeRows = False
        Me.dgvEmployees.AutoGenerateColumns = False
        Me.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmployees.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmployees.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.EmployeenameDataGridViewTextBoxColumn, Me.DepartmentnameDataGridViewTextBoxColumn, Me.PositionnameDataGridViewTextBoxColumn})
        Me.dgvEmployees.DataSource = Me.ViewemployeesearchresultBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmployees.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEmployees.EnableHeadersVisualStyles = False
        Me.dgvEmployees.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvEmployees.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEmployees.Location = New System.Drawing.Point(20, 60)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.ReadOnly = True
        Me.dgvEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmployees.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvEmployees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployees.Size = New System.Drawing.Size(622, 248)
        Me.dgvEmployees.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'EmployeenameDataGridViewTextBoxColumn
        '
        Me.EmployeenameDataGridViewTextBoxColumn.DataPropertyName = "employee_name"
        Me.EmployeenameDataGridViewTextBoxColumn.HeaderText = "Employee Name"
        Me.EmployeenameDataGridViewTextBoxColumn.Name = "EmployeenameDataGridViewTextBoxColumn"
        Me.EmployeenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DepartmentnameDataGridViewTextBoxColumn
        '
        Me.DepartmentnameDataGridViewTextBoxColumn.DataPropertyName = "department_name"
        Me.DepartmentnameDataGridViewTextBoxColumn.HeaderText = "Department Assigned"
        Me.DepartmentnameDataGridViewTextBoxColumn.Name = "DepartmentnameDataGridViewTextBoxColumn"
        Me.DepartmentnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PositionnameDataGridViewTextBoxColumn
        '
        Me.PositionnameDataGridViewTextBoxColumn.DataPropertyName = "position_name"
        Me.PositionnameDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionnameDataGridViewTextBoxColumn.Name = "PositionnameDataGridViewTextBoxColumn"
        Me.PositionnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ViewemployeesearchresultBindingSource
        '
        Me.ViewemployeesearchresultBindingSource.DataMember = "view_employee_search_result"
        Me.ViewemployeesearchresultBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtSearch.CustomButton.Image = Nothing
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(215, 2)
        Me.txtSearch.CustomButton.Name = ""
        Me.txtSearch.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearch.CustomButton.TabIndex = 1
        Me.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearch.CustomButton.UseSelectable = True
        Me.txtSearch.CustomButton.Visible = False
        Me.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(313, 28)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.Size = New System.Drawing.Size(243, 30)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnSearch.Location = New System.Drawing.Point(558, 27)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(84, 30)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseSelectable = True
        '
        'View_employee_search_resultTableAdapter
        '
        Me.View_employee_search_resultTableAdapter.ClearBeforeFill = True
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewProfileToolStripMenuItem, Me.MarkAsResignedToolStripMenuItem, Me.ApplyForToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(181, 92)
        '
        'ViewProfileToolStripMenuItem
        '
        Me.ViewProfileToolStripMenuItem.Name = "ViewProfileToolStripMenuItem"
        Me.ViewProfileToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewProfileToolStripMenuItem.Text = "View Profile"
        '
        'MarkAsResignedToolStripMenuItem
        '
        Me.MarkAsResignedToolStripMenuItem.Name = "MarkAsResignedToolStripMenuItem"
        Me.MarkAsResignedToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MarkAsResignedToolStripMenuItem.Text = "Mark As Resigned"
        '
        'ApplyForToolStripMenuItem
        '
        Me.ApplyForToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OvertimeToolStripMenuItem, Me.LeaveToolStripMenuItem, Me.LoanToolStripMenuItem})
        Me.ApplyForToolStripMenuItem.Name = "ApplyForToolStripMenuItem"
        Me.ApplyForToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ApplyForToolStripMenuItem.Text = "Apply for"
        '
        'OvertimeToolStripMenuItem
        '
        Me.OvertimeToolStripMenuItem.Name = "OvertimeToolStripMenuItem"
        Me.OvertimeToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.OvertimeToolStripMenuItem.Text = "Overtime"
        '
        'LeaveToolStripMenuItem
        '
        Me.LeaveToolStripMenuItem.Name = "LeaveToolStripMenuItem"
        Me.LeaveToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.LeaveToolStripMenuItem.Text = "Leave"
        '
        'LoanToolStripMenuItem
        '
        Me.LoanToolStripMenuItem.Name = "LoanToolStripMenuItem"
        Me.LoanToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.LoanToolStripMenuItem.Text = "Loan"
        '
        'EmployeeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 328)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvEmployees)
        Me.Name = "EmployeeList"
        Me.Text = "Search Employee"
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewemployeesearchresultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvEmployees As MetroFramework.Controls.MetroGrid
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ViewemployeesearchresultBindingSource As BindingSource
    Friend WithEvents View_employee_search_resultTableAdapter As DataSet1TableAdapters.view_employee_search_resultTableAdapter
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents ViewProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarkAsResignedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApplyForToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OvertimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
