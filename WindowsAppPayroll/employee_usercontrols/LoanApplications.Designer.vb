<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoanApplications
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSearch = New MetroFramework.Controls.MetroButton()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.dgvLoans = New MetroFramework.Controls.MetroGrid()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoanidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoannameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReferencenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoanamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmortizationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SettledDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewemployeeloansBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsAppPayroll.DataSet1()
        Me.View_employee_loansTableAdapter = New WindowsAppPayroll.DataSet1TableAdapters.view_employee_loansTableAdapter()
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvLoans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewemployeeloansBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroContextMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(779, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseSelectable = True
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
        Me.txtSearch.Location = New System.Drawing.Point(582, 10)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.Size = New System.Drawing.Size(198, 23)
        Me.txtSearch.TabIndex = 4
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dgvLoans
        '
        Me.dgvLoans.AllowUserToAddRows = False
        Me.dgvLoans.AllowUserToDeleteRows = False
        Me.dgvLoans.AllowUserToResizeRows = False
        Me.dgvLoans.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLoans.AutoGenerateColumns = False
        Me.dgvLoans.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLoans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvLoans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvLoans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLoans.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLoans.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.EmployeeidDataGridViewTextBoxColumn, Me.LoanidDataGridViewTextBoxColumn, Me.LoannameDataGridViewTextBoxColumn, Me.EmployeenameDataGridViewTextBoxColumn, Me.ReferencenoDataGridViewTextBoxColumn, Me.StartatDataGridViewTextBoxColumn, Me.LoanamountDataGridViewTextBoxColumn, Me.AmortizationDataGridViewTextBoxColumn, Me.SettledDataGridViewTextBoxColumn, Me.BalanceDataGridViewTextBoxColumn})
        Me.dgvLoans.DataSource = Me.ViewemployeeloansBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLoans.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLoans.EnableHeadersVisualStyles = False
        Me.dgvLoans.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvLoans.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLoans.Location = New System.Drawing.Point(16, 39)
        Me.dgvLoans.Name = "dgvLoans"
        Me.dgvLoans.ReadOnly = True
        Me.dgvLoans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLoans.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLoans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLoans.Size = New System.Drawing.Size(837, 305)
        Me.dgvLoans.TabIndex = 3
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
        'LoanidDataGridViewTextBoxColumn
        '
        Me.LoanidDataGridViewTextBoxColumn.DataPropertyName = "loan_id"
        Me.LoanidDataGridViewTextBoxColumn.HeaderText = "loan_id"
        Me.LoanidDataGridViewTextBoxColumn.Name = "LoanidDataGridViewTextBoxColumn"
        Me.LoanidDataGridViewTextBoxColumn.ReadOnly = True
        Me.LoanidDataGridViewTextBoxColumn.Visible = False
        '
        'LoannameDataGridViewTextBoxColumn
        '
        Me.LoannameDataGridViewTextBoxColumn.DataPropertyName = "loan_name"
        Me.LoannameDataGridViewTextBoxColumn.HeaderText = "Type of Loan"
        Me.LoannameDataGridViewTextBoxColumn.Name = "LoannameDataGridViewTextBoxColumn"
        Me.LoannameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeenameDataGridViewTextBoxColumn
        '
        Me.EmployeenameDataGridViewTextBoxColumn.DataPropertyName = "employee_name"
        Me.EmployeenameDataGridViewTextBoxColumn.HeaderText = "Employee Name"
        Me.EmployeenameDataGridViewTextBoxColumn.Name = "EmployeenameDataGridViewTextBoxColumn"
        Me.EmployeenameDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeenameDataGridViewTextBoxColumn.Width = 200
        '
        'ReferencenoDataGridViewTextBoxColumn
        '
        Me.ReferencenoDataGridViewTextBoxColumn.DataPropertyName = "reference_no"
        Me.ReferencenoDataGridViewTextBoxColumn.HeaderText = "Reference #"
        Me.ReferencenoDataGridViewTextBoxColumn.Name = "ReferencenoDataGridViewTextBoxColumn"
        Me.ReferencenoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StartatDataGridViewTextBoxColumn
        '
        Me.StartatDataGridViewTextBoxColumn.DataPropertyName = "start_at"
        Me.StartatDataGridViewTextBoxColumn.HeaderText = "Start At"
        Me.StartatDataGridViewTextBoxColumn.Name = "StartatDataGridViewTextBoxColumn"
        Me.StartatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LoanamountDataGridViewTextBoxColumn
        '
        Me.LoanamountDataGridViewTextBoxColumn.DataPropertyName = "loan_amount"
        Me.LoanamountDataGridViewTextBoxColumn.HeaderText = "Loan Amount"
        Me.LoanamountDataGridViewTextBoxColumn.Name = "LoanamountDataGridViewTextBoxColumn"
        Me.LoanamountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmortizationDataGridViewTextBoxColumn
        '
        Me.AmortizationDataGridViewTextBoxColumn.DataPropertyName = "amortization"
        Me.AmortizationDataGridViewTextBoxColumn.HeaderText = "Amortization"
        Me.AmortizationDataGridViewTextBoxColumn.Name = "AmortizationDataGridViewTextBoxColumn"
        Me.AmortizationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SettledDataGridViewTextBoxColumn
        '
        Me.SettledDataGridViewTextBoxColumn.DataPropertyName = "settled"
        Me.SettledDataGridViewTextBoxColumn.HeaderText = "Settled"
        Me.SettledDataGridViewTextBoxColumn.Name = "SettledDataGridViewTextBoxColumn"
        Me.SettledDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "balance"
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        Me.BalanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ViewemployeeloansBindingSource
        '
        Me.ViewemployeeloansBindingSource.DataMember = "view_employee_loans"
        Me.ViewemployeeloansBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_employee_loansTableAdapter
        '
        Me.View_employee_loansTableAdapter.ClearBeforeFill = True
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(108, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'LoanApplications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvLoans)
        Me.Name = "LoanApplications"
        Me.Size = New System.Drawing.Size(871, 362)
        CType(Me.dgvLoans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewemployeeloansBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dgvLoans As MetroFramework.Controls.MetroGrid
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoanidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoannameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReferencenoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoanamountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmortizationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SettledDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ViewemployeeloansBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents View_employee_loansTableAdapter As DataSet1TableAdapters.view_employee_loansTableAdapter
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
