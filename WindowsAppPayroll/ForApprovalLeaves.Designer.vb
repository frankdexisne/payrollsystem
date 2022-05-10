<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForApprovalLeaves
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
        Me.dgvLeaves = New MetroFramework.Controls.MetroGrid()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeavenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EffectivedatefromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EffectivedatetoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewemployeeleaveavailmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsAppPayroll.DataSet1()
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.ApproveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DenyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.View_employee_leave_availmentsTableAdapter = New WindowsAppPayroll.DataSet1TableAdapters.view_employee_leave_availmentsTableAdapter()
        CType(Me.dgvLeaves, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewemployeeleaveavailmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroContextMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLeaves
        '
        Me.dgvLeaves.AllowUserToAddRows = False
        Me.dgvLeaves.AllowUserToDeleteRows = False
        Me.dgvLeaves.AllowUserToResizeRows = False
        Me.dgvLeaves.AutoGenerateColumns = False
        Me.dgvLeaves.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLeaves.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvLeaves.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvLeaves.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLeaves.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLeaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLeaves.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.EmployeeidDataGridViewTextBoxColumn, Me.LeavenameDataGridViewTextBoxColumn, Me.EmployeenameDataGridViewTextBoxColumn, Me.EffectivedatefromDataGridViewTextBoxColumn, Me.EffectivedatetoDataGridViewTextBoxColumn})
        Me.dgvLeaves.DataSource = Me.ViewemployeeleaveavailmentsBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLeaves.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLeaves.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLeaves.EnableHeadersVisualStyles = False
        Me.dgvLeaves.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvLeaves.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLeaves.Location = New System.Drawing.Point(20, 60)
        Me.dgvLeaves.Name = "dgvLeaves"
        Me.dgvLeaves.ReadOnly = True
        Me.dgvLeaves.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLeaves.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLeaves.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvLeaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLeaves.Size = New System.Drawing.Size(759, 370)
        Me.dgvLeaves.TabIndex = 0
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
        Me.LeavenameDataGridViewTextBoxColumn.HeaderText = "Name of Leave"
        Me.LeavenameDataGridViewTextBoxColumn.Name = "LeavenameDataGridViewTextBoxColumn"
        Me.LeavenameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LeavenameDataGridViewTextBoxColumn.Width = 150
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
        Me.EffectivedatefromDataGridViewTextBoxColumn.HeaderText = "From"
        Me.EffectivedatefromDataGridViewTextBoxColumn.Name = "EffectivedatefromDataGridViewTextBoxColumn"
        Me.EffectivedatefromDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EffectivedatetoDataGridViewTextBoxColumn
        '
        Me.EffectivedatetoDataGridViewTextBoxColumn.DataPropertyName = "effective_date_to"
        Me.EffectivedatetoDataGridViewTextBoxColumn.HeaderText = "To"
        Me.EffectivedatetoDataGridViewTextBoxColumn.Name = "EffectivedatetoDataGridViewTextBoxColumn"
        Me.EffectivedatetoDataGridViewTextBoxColumn.ReadOnly = True
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
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApproveToolStripMenuItem, Me.DenyToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(120, 48)
        '
        'ApproveToolStripMenuItem
        '
        Me.ApproveToolStripMenuItem.Name = "ApproveToolStripMenuItem"
        Me.ApproveToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ApproveToolStripMenuItem.Text = "Approve"
        '
        'DenyToolStripMenuItem
        '
        Me.DenyToolStripMenuItem.Name = "DenyToolStripMenuItem"
        Me.DenyToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.DenyToolStripMenuItem.Text = "Deny"
        '
        'View_employee_leave_availmentsTableAdapter
        '
        Me.View_employee_leave_availmentsTableAdapter.ClearBeforeFill = True
        '
        'ForApprovalLeaves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 450)
        Me.Controls.Add(Me.dgvLeaves)
        Me.Name = "ForApprovalLeaves"
        Me.Text = "For Approval Leaves"
        CType(Me.dgvLeaves, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewemployeeleaveavailmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvLeaves As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents ApproveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DenyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ViewemployeeleaveavailmentsBindingSource As BindingSource
    Friend WithEvents View_employee_leave_availmentsTableAdapter As DataSet1TableAdapters.view_employee_leave_availmentsTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LeavenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EffectivedatefromDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EffectivedatetoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
