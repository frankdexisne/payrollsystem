<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUndertime = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmployeeToday = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLate = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserCount = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmployeeCount = New System.Windows.Forms.TextBox()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttendinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttendoutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RenderhoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Viewtodayattendance1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsAppPayroll.DataSet1()
        Me.View_today_attendance1TableAdapter = New WindowsAppPayroll.DataSet1TableAdapters.view_today_attendance1TableAdapter()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.Viewtodayattendance1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.EmployeeidDataGridViewTextBoxColumn, Me.EmployeenameDataGridViewTextBoxColumn, Me.AttendinDataGridViewTextBoxColumn, Me.AttendoutDataGridViewTextBoxColumn, Me.RenderhoursDataGridViewTextBoxColumn})
        Me.MetroGrid1.DataSource = Me.Viewtodayattendance1BindingSource
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
        Me.MetroGrid1.Location = New System.Drawing.Point(8, 116)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(824, 447)
        Me.MetroGrid1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.txtUndertime)
        Me.Panel4.Location = New System.Drawing.Point(506, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(160, 100)
        Me.Panel4.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(11, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Today Undertime"
        '
        'txtUndertime
        '
        Me.txtUndertime.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.txtUndertime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUndertime.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUndertime.ForeColor = System.Drawing.Color.White
        Me.txtUndertime.Location = New System.Drawing.Point(15, 38)
        Me.txtUndertime.Name = "txtUndertime"
        Me.txtUndertime.ReadOnly = True
        Me.txtUndertime.Size = New System.Drawing.Size(128, 43)
        Me.txtUndertime.TabIndex = 3
        Me.txtUndertime.Text = "10"
        Me.txtUndertime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtEmployeeToday)
        Me.Panel1.Location = New System.Drawing.Point(340, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 100)
        Me.Panel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Employee Today"
        '
        'txtEmployeeToday
        '
        Me.txtEmployeeToday.BackColor = System.Drawing.Color.DarkSalmon
        Me.txtEmployeeToday.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmployeeToday.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeToday.ForeColor = System.Drawing.Color.White
        Me.txtEmployeeToday.Location = New System.Drawing.Point(15, 38)
        Me.txtEmployeeToday.Name = "txtEmployeeToday"
        Me.txtEmployeeToday.ReadOnly = True
        Me.txtEmployeeToday.Size = New System.Drawing.Size(128, 43)
        Me.txtEmployeeToday.TabIndex = 3
        Me.txtEmployeeToday.Text = "10"
        Me.txtEmployeeToday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtLate)
        Me.Panel2.Location = New System.Drawing.Point(672, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(160, 100)
        Me.Panel2.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Employee Late(s)"
        '
        'txtLate
        '
        Me.txtLate.BackColor = System.Drawing.Color.ForestGreen
        Me.txtLate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLate.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLate.ForeColor = System.Drawing.Color.White
        Me.txtLate.Location = New System.Drawing.Point(15, 38)
        Me.txtLate.Name = "txtLate"
        Me.txtLate.ReadOnly = True
        Me.txtLate.Size = New System.Drawing.Size(128, 43)
        Me.txtLate.TabIndex = 3
        Me.txtLate.Text = "10"
        Me.txtLate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtUserCount)
        Me.Panel3.Location = New System.Drawing.Point(8, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(160, 100)
        Me.Panel3.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total Users"
        '
        'txtUserCount
        '
        Me.txtUserCount.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtUserCount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserCount.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserCount.ForeColor = System.Drawing.Color.White
        Me.txtUserCount.Location = New System.Drawing.Point(15, 38)
        Me.txtUserCount.Name = "txtUserCount"
        Me.txtUserCount.ReadOnly = True
        Me.txtUserCount.Size = New System.Drawing.Size(128, 43)
        Me.txtUserCount.TabIndex = 3
        Me.txtUserCount.Text = "10"
        Me.txtUserCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Teal
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.txtEmployeeCount)
        Me.Panel5.Location = New System.Drawing.Point(174, 10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(160, 100)
        Me.Panel5.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Total Employee"
        '
        'txtEmployeeCount
        '
        Me.txtEmployeeCount.BackColor = System.Drawing.Color.Teal
        Me.txtEmployeeCount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmployeeCount.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeCount.ForeColor = System.Drawing.Color.White
        Me.txtEmployeeCount.Location = New System.Drawing.Point(15, 38)
        Me.txtEmployeeCount.Name = "txtEmployeeCount"
        Me.txtEmployeeCount.ReadOnly = True
        Me.txtEmployeeCount.Size = New System.Drawing.Size(128, 43)
        Me.txtEmployeeCount.TabIndex = 3
        Me.txtEmployeeCount.Text = "10"
        Me.txtEmployeeCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.EmployeenameDataGridViewTextBoxColumn.Width = 200
        '
        'AttendinDataGridViewTextBoxColumn
        '
        Me.AttendinDataGridViewTextBoxColumn.DataPropertyName = "attend_in"
        Me.AttendinDataGridViewTextBoxColumn.HeaderText = "IN"
        Me.AttendinDataGridViewTextBoxColumn.Name = "AttendinDataGridViewTextBoxColumn"
        Me.AttendinDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AttendoutDataGridViewTextBoxColumn
        '
        Me.AttendoutDataGridViewTextBoxColumn.DataPropertyName = "attend_out"
        Me.AttendoutDataGridViewTextBoxColumn.HeaderText = "OUT"
        Me.AttendoutDataGridViewTextBoxColumn.Name = "AttendoutDataGridViewTextBoxColumn"
        Me.AttendoutDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RenderhoursDataGridViewTextBoxColumn
        '
        Me.RenderhoursDataGridViewTextBoxColumn.DataPropertyName = "render_hours"
        Me.RenderhoursDataGridViewTextBoxColumn.HeaderText = "RENDER HOURS"
        Me.RenderhoursDataGridViewTextBoxColumn.Name = "RenderhoursDataGridViewTextBoxColumn"
        Me.RenderhoursDataGridViewTextBoxColumn.ReadOnly = True
        Me.RenderhoursDataGridViewTextBoxColumn.Width = 150
        '
        'Viewtodayattendance1BindingSource
        '
        Me.Viewtodayattendance1BindingSource.DataMember = "view_today_attendance1"
        Me.Viewtodayattendance1BindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_today_attendance1TableAdapter
        '
        Me.View_today_attendance1TableAdapter.ClearBeforeFill = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Name = "Dashboard"
        Me.Size = New System.Drawing.Size(856, 579)
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.Viewtodayattendance1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUndertime As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmployeeToday As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLate As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUserCount As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmployeeCount As TextBox
    Friend WithEvents Viewtodayattendance1BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents View_today_attendance1TableAdapter As DataSet1TableAdapters.view_today_attendance1TableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttendinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttendoutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RenderhoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
