<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attends
    Inherits System.Windows.Forms.Form

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
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnInOrOut = New System.Windows.Forms.Button()
        Me.btnLoginAsAdmin = New System.Windows.Forms.Button()
        Me.dgvAttendance = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttendinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttendoutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RenderhoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TodayattendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsAppPayroll.DataSet1()
        Me.Today_attendanceTableAdapter = New WindowsAppPayroll.DataSet1TableAdapters.today_attendanceTableAdapter()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.dgvAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TodayattendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(21, 26)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(191, 21)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Please enter your ID"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(218, 23)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(269, 30)
        Me.txtID.TabIndex = 1
        '
        'btnInOrOut
        '
        Me.btnInOrOut.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInOrOut.Location = New System.Drawing.Point(493, 22)
        Me.btnInOrOut.Name = "btnInOrOut"
        Me.btnInOrOut.Size = New System.Drawing.Size(193, 30)
        Me.btnInOrOut.TabIndex = 2
        Me.btnInOrOut.Text = "Time In / Time Out"
        Me.btnInOrOut.UseVisualStyleBackColor = True
        '
        'btnLoginAsAdmin
        '
        Me.btnLoginAsAdmin.Location = New System.Drawing.Point(943, 23)
        Me.btnLoginAsAdmin.Name = "btnLoginAsAdmin"
        Me.btnLoginAsAdmin.Size = New System.Drawing.Size(245, 29)
        Me.btnLoginAsAdmin.TabIndex = 3
        Me.btnLoginAsAdmin.Text = "Login As Administator"
        Me.btnLoginAsAdmin.UseVisualStyleBackColor = True
        '
        'dgvAttendance
        '
        Me.dgvAttendance.AllowUserToAddRows = False
        Me.dgvAttendance.AllowUserToDeleteRows = False
        Me.dgvAttendance.AutoGenerateColumns = False
        Me.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAttendance.BackgroundColor = System.Drawing.Color.White
        Me.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAttendance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.EmployeenameDataGridViewTextBoxColumn, Me.AttendinDataGridViewTextBoxColumn, Me.AttendoutDataGridViewTextBoxColumn, Me.RenderhoursDataGridViewTextBoxColumn})
        Me.dgvAttendance.DataSource = Me.TodayattendanceBindingSource
        Me.dgvAttendance.Location = New System.Drawing.Point(25, 120)
        Me.dgvAttendance.Name = "dgvAttendance"
        Me.dgvAttendance.ReadOnly = True
        Me.dgvAttendance.Size = New System.Drawing.Size(1163, 526)
        Me.dgvAttendance.TabIndex = 4
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
        'AttendinDataGridViewTextBoxColumn
        '
        Me.AttendinDataGridViewTextBoxColumn.DataPropertyName = "attend_in"
        Me.AttendinDataGridViewTextBoxColumn.HeaderText = "Time In"
        Me.AttendinDataGridViewTextBoxColumn.Name = "AttendinDataGridViewTextBoxColumn"
        Me.AttendinDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AttendoutDataGridViewTextBoxColumn
        '
        Me.AttendoutDataGridViewTextBoxColumn.DataPropertyName = "attend_out"
        Me.AttendoutDataGridViewTextBoxColumn.HeaderText = "Time Out"
        Me.AttendoutDataGridViewTextBoxColumn.Name = "AttendoutDataGridViewTextBoxColumn"
        Me.AttendoutDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RenderhoursDataGridViewTextBoxColumn
        '
        Me.RenderhoursDataGridViewTextBoxColumn.DataPropertyName = "render_hours"
        Me.RenderhoursDataGridViewTextBoxColumn.HeaderText = "Rendered Hours"
        Me.RenderhoursDataGridViewTextBoxColumn.Name = "RenderhoursDataGridViewTextBoxColumn"
        Me.RenderhoursDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TodayattendanceBindingSource
        '
        Me.TodayattendanceBindingSource.DataMember = "today_attendance"
        Me.TodayattendanceBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Today_attendanceTableAdapter
        '
        Me.Today_attendanceTableAdapter.ClearBeforeFill = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(25, 79)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(278, 31)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Attendance for Today"
        '
        'Attends
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 658)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.dgvAttendance)
        Me.Controls.Add(Me.btnLoginAsAdmin)
        Me.Controls.Add(Me.btnInOrOut)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Attends"
        Me.Text = "Attends"
        CType(Me.dgvAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TodayattendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnInOrOut As Button
    Friend WithEvents btnLoginAsAdmin As Button
    Friend WithEvents dgvAttendance As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents TodayattendanceBindingSource As BindingSource
    Friend WithEvents Today_attendanceTableAdapter As DataSet1TableAdapters.today_attendanceTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttendinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttendoutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RenderhoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblTitle As Label
End Class
