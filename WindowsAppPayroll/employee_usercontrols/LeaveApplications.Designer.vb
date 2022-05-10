<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LeaveApplications
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.btnSearch = New MetroFramework.Controls.MetroButton()
        Me.dgvEmployeeLeaves = New MetroFramework.Controls.MetroGrid()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeavenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EffectivedatefromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EffectivedatetoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsavailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IsapproveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ViewemployeeleaveavailmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsAppPayroll.DataSet1()
        Me.View_employee_leave_availmentsTableAdapter = New WindowsAppPayroll.DataSet1TableAdapters.view_employee_leave_availmentsTableAdapter()
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvEmployeeLeaves, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewemployeeleaveavailmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroContextMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtSearch.CustomButton.Image = Nothing
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(176, 1)
        Me.txtSearch.CustomButton.Name = ""
        Me.txtSearch.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearch.CustomButton.TabIndex = 1
        Me.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearch.CustomButton.UseSelectable = True
        Me.txtSearch.CustomButton.Visible = False
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(581, 10)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.Size = New System.Drawing.Size(198, 23)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(778, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseSelectable = True
        '
        'dgvEmployeeLeaves
        '
        Me.dgvEmployeeLeaves.AllowUserToAddRows = False
        Me.dgvEmployeeLeaves.AllowUserToDeleteRows = False
        Me.dgvEmployeeLeaves.AllowUserToResizeRows = False
        Me.dgvEmployeeLeaves.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEmployeeLeaves.AutoGenerateColumns = False
        Me.dgvEmployeeLeaves.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEmployeeLeaves.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvEmployeeLeaves.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvEmployeeLeaves.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmployeeLeaves.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvEmployeeLeaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployeeLeaves.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.EmployeeidDataGridViewTextBoxColumn, Me.LeavenameDataGridViewTextBoxColumn, Me.EmployeenameDataGridViewTextBoxColumn, Me.EffectivedatefromDataGridViewTextBoxColumn, Me.EffectivedatetoDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.IsavailDataGridViewTextBoxColumn, Me.IsapproveDataGridViewTextBoxColumn})
        Me.dgvEmployeeLeaves.DataSource = Me.ViewemployeeleaveavailmentsBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmployeeLeaves.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvEmployeeLeaves.EnableHeadersVisualStyles = False
        Me.dgvEmployeeLeaves.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvEmployeeLeaves.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEmployeeLeaves.Location = New System.Drawing.Point(16, 39)
        Me.dgvEmployeeLeaves.Name = "dgvEmployeeLeaves"
        Me.dgvEmployeeLeaves.ReadOnly = True
        Me.dgvEmployeeLeaves.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmployeeLeaves.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvEmployeeLeaves.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvEmployeeLeaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployeeLeaves.Size = New System.Drawing.Size(837, 305)
        Me.dgvEmployeeLeaves.TabIndex = 4
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
        '
        'EmployeenameDataGridViewTextBoxColumn
        '
        Me.EmployeenameDataGridViewTextBoxColumn.DataPropertyName = "employee_name"
        Me.EmployeenameDataGridViewTextBoxColumn.HeaderText = "Name of Employee"
        Me.EmployeenameDataGridViewTextBoxColumn.Name = "EmployeenameDataGridViewTextBoxColumn"
        Me.EmployeenameDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeenameDataGridViewTextBoxColumn.Width = 200
        '
        'EffectivedatefromDataGridViewTextBoxColumn
        '
        Me.EffectivedatefromDataGridViewTextBoxColumn.DataPropertyName = "effective_date_from"
        Me.EffectivedatefromDataGridViewTextBoxColumn.HeaderText = "Start Date"
        Me.EffectivedatefromDataGridViewTextBoxColumn.Name = "EffectivedatefromDataGridViewTextBoxColumn"
        Me.EffectivedatefromDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EffectivedatetoDataGridViewTextBoxColumn
        '
        Me.EffectivedatetoDataGridViewTextBoxColumn.DataPropertyName = "effective_date_to"
        Me.EffectivedatetoDataGridViewTextBoxColumn.HeaderText = "End Date"
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
        Me.IsavailDataGridViewTextBoxColumn.FalseValue = "0"
        Me.IsavailDataGridViewTextBoxColumn.HeaderText = "Availed?"
        Me.IsavailDataGridViewTextBoxColumn.Name = "IsavailDataGridViewTextBoxColumn"
        Me.IsavailDataGridViewTextBoxColumn.ReadOnly = True
        Me.IsavailDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IsavailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IsavailDataGridViewTextBoxColumn.TrueValue = "1"
        '
        'IsapproveDataGridViewTextBoxColumn
        '
        Me.IsapproveDataGridViewTextBoxColumn.DataPropertyName = "is_approve"
        Me.IsapproveDataGridViewTextBoxColumn.FalseValue = "0"
        Me.IsapproveDataGridViewTextBoxColumn.HeaderText = "Approved?"
        Me.IsapproveDataGridViewTextBoxColumn.Name = "IsapproveDataGridViewTextBoxColumn"
        Me.IsapproveDataGridViewTextBoxColumn.ReadOnly = True
        Me.IsapproveDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IsapproveDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IsapproveDataGridViewTextBoxColumn.TrueValue = "1"
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
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(181, 70)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'LeaveApplications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvEmployeeLeaves)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "LeaveApplications"
        Me.Size = New System.Drawing.Size(868, 367)
        CType(Me.dgvEmployeeLeaves, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewemployeeleaveavailmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents dgvEmployeeLeaves As MetroFramework.Controls.MetroGrid
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LeavenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EffectivedatefromDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EffectivedatetoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsavailDataGridViewTextBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IsapproveDataGridViewTextBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ViewemployeeleaveavailmentsBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents View_employee_leave_availmentsTableAdapter As DataSet1TableAdapters.view_employee_leave_availmentsTableAdapter
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
