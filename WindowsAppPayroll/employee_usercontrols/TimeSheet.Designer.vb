<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeSheet
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
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttenddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttendinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttendoutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RenderhoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewtimesheetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsAppPayroll.DataSet1()
        Me.cboCutoff = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnShow = New MetroFramework.Controls.MetroButton()
        Me.View_timesheetTableAdapter = New WindowsAppPayroll.DataSet1TableAdapters.view_timesheetTableAdapter()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewtimesheetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid1.AutoGenerateColumns = False
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.EmployeeidDataGridViewTextBoxColumn, Me.EmployeenameDataGridViewTextBoxColumn, Me.AttenddateDataGridViewTextBoxColumn, Me.AttendinDataGridViewTextBoxColumn, Me.AttendoutDataGridViewTextBoxColumn, Me.RenderhoursDataGridViewTextBoxColumn})
        Me.MetroGrid1.DataSource = Me.ViewtimesheetBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(19, 57)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(886, 448)
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
        'EmployeeidDataGridViewTextBoxColumn
        '
        Me.EmployeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.HeaderText = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.Name = "EmployeeidDataGridViewTextBoxColumn"
        Me.EmployeeidDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeeidDataGridViewTextBoxColumn.Visible = False
        '
        'EmployeenameDataGridViewTextBoxColumn
        '
        Me.EmployeenameDataGridViewTextBoxColumn.DataPropertyName = "employee_name"
        Me.EmployeenameDataGridViewTextBoxColumn.HeaderText = "Employee Name"
        Me.EmployeenameDataGridViewTextBoxColumn.Name = "EmployeenameDataGridViewTextBoxColumn"
        Me.EmployeenameDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeenameDataGridViewTextBoxColumn.Visible = False
        '
        'AttenddateDataGridViewTextBoxColumn
        '
        Me.AttenddateDataGridViewTextBoxColumn.DataPropertyName = "attend_date"
        Me.AttenddateDataGridViewTextBoxColumn.HeaderText = "Attend Date"
        Me.AttenddateDataGridViewTextBoxColumn.Name = "AttenddateDataGridViewTextBoxColumn"
        Me.AttenddateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AttendinDataGridViewTextBoxColumn
        '
        Me.AttendinDataGridViewTextBoxColumn.DataPropertyName = "attend_in"
        Me.AttendinDataGridViewTextBoxColumn.HeaderText = "TIME IN"
        Me.AttendinDataGridViewTextBoxColumn.Name = "AttendinDataGridViewTextBoxColumn"
        Me.AttendinDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AttendoutDataGridViewTextBoxColumn
        '
        Me.AttendoutDataGridViewTextBoxColumn.DataPropertyName = "attend_out"
        Me.AttendoutDataGridViewTextBoxColumn.HeaderText = "TIME OUT"
        Me.AttendoutDataGridViewTextBoxColumn.Name = "AttendoutDataGridViewTextBoxColumn"
        Me.AttendoutDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RenderhoursDataGridViewTextBoxColumn
        '
        Me.RenderhoursDataGridViewTextBoxColumn.DataPropertyName = "render_hours"
        Me.RenderhoursDataGridViewTextBoxColumn.HeaderText = "Rendered Hours"
        Me.RenderhoursDataGridViewTextBoxColumn.Name = "RenderhoursDataGridViewTextBoxColumn"
        Me.RenderhoursDataGridViewTextBoxColumn.ReadOnly = True
        Me.RenderhoursDataGridViewTextBoxColumn.Width = 150
        '
        'ViewtimesheetBindingSource
        '
        Me.ViewtimesheetBindingSource.DataMember = "view_timesheet"
        Me.ViewtimesheetBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboCutoff
        '
        Me.cboCutoff.FormattingEnabled = True
        Me.cboCutoff.ItemHeight = 23
        Me.cboCutoff.Location = New System.Drawing.Point(68, 22)
        Me.cboCutoff.Name = "cboCutoff"
        Me.cboCutoff.Size = New System.Drawing.Size(182, 29)
        Me.cboCutoff.TabIndex = 1
        Me.cboCutoff.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(17, 22)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Cutoff"
        '
        'btnShow
        '
        Me.btnShow.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnShow.Location = New System.Drawing.Point(256, 22)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 29)
        Me.btnShow.TabIndex = 3
        Me.btnShow.Text = "Show"
        Me.btnShow.UseSelectable = True
        '
        'View_timesheetTableAdapter
        '
        Me.View_timesheetTableAdapter.ClearBeforeFill = True
        '
        'TimeSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.cboCutoff)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Name = "TimeSheet"
        Me.Size = New System.Drawing.Size(926, 533)
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewtimesheetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents cboCutoff As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnShow As MetroFramework.Controls.MetroButton
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttenddateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttendinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttendoutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RenderhoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ViewtimesheetBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents View_timesheetTableAdapter As DataSet1TableAdapters.view_timesheetTableAdapter
End Class
