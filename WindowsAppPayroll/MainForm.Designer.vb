<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LeaveManagement1 = New WindowsAppPayroll.LeaveManagement()
        Me.Departments1 = New WindowsAppPayroll.Departments()
        Me.JobTitles1 = New WindowsAppPayroll.JobTitles()
        Me.Holidays1 = New WindowsAppPayroll.Holidays()
        Me.Dashboard1 = New WindowsAppPayroll.Dashboard()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.lblName = New MetroFramework.Controls.MetroLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsDashboard = New System.Windows.Forms.ToolStripSplitButton()
        Me.tsEmployees = New System.Windows.Forms.ToolStripSplitButton()
        Me.smNewEmployee = New System.Windows.Forms.ToolStripMenuItem()
        Me.smSearchEmployee = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsHolidays = New System.Windows.Forms.ToolStripSplitButton()
        Me.smNewHoliday = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsDepartments = New System.Windows.Forms.ToolStripSplitButton()
        Me.smNewDepartment = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsJobTitles = New System.Windows.Forms.ToolStripSplitButton()
        Me.smNewJobTitle = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsLeaveManagement = New System.Windows.Forms.ToolStripSplitButton()
        Me.tsPayroll = New System.Windows.Forms.ToolStripSplitButton()
        Me.tsSetting = New System.Windows.Forms.ToolStripSplitButton()
        Me.smChangePassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.smChangeProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.smLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.LeaveManagement1)
        Me.Panel1.Controls.Add(Me.Departments1)
        Me.Panel1.Controls.Add(Me.JobTitles1)
        Me.Panel1.Controls.Add(Me.Holidays1)
        Me.Panel1.Controls.Add(Me.Dashboard1)
        Me.Panel1.Location = New System.Drawing.Point(30, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1309, 523)
        Me.Panel1.TabIndex = 7
        '
        'LeaveManagement1
        '
        Me.LeaveManagement1.BackColor = System.Drawing.Color.White
        Me.LeaveManagement1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LeaveManagement1.Location = New System.Drawing.Point(0, 0)
        Me.LeaveManagement1.Margin = New System.Windows.Forms.Padding(4)
        Me.LeaveManagement1.Name = "LeaveManagement1"
        Me.LeaveManagement1.Size = New System.Drawing.Size(1309, 523)
        Me.LeaveManagement1.TabIndex = 5
        Me.LeaveManagement1.Visible = False
        '
        'Departments1
        '
        Me.Departments1.BackColor = System.Drawing.Color.White
        Me.Departments1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Departments1.Location = New System.Drawing.Point(0, 0)
        Me.Departments1.Margin = New System.Windows.Forms.Padding(4)
        Me.Departments1.Name = "Departments1"
        Me.Departments1.Size = New System.Drawing.Size(1309, 523)
        Me.Departments1.TabIndex = 4
        Me.Departments1.Visible = False
        '
        'JobTitles1
        '
        Me.JobTitles1.BackColor = System.Drawing.Color.White
        Me.JobTitles1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JobTitles1.Location = New System.Drawing.Point(0, 0)
        Me.JobTitles1.Margin = New System.Windows.Forms.Padding(4)
        Me.JobTitles1.Name = "JobTitles1"
        Me.JobTitles1.Size = New System.Drawing.Size(1309, 523)
        Me.JobTitles1.TabIndex = 3
        Me.JobTitles1.Visible = False
        '
        'Holidays1
        '
        Me.Holidays1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Holidays1.Location = New System.Drawing.Point(0, 0)
        Me.Holidays1.Margin = New System.Windows.Forms.Padding(4)
        Me.Holidays1.Name = "Holidays1"
        Me.Holidays1.Size = New System.Drawing.Size(1309, 523)
        Me.Holidays1.TabIndex = 1
        Me.Holidays1.Visible = False
        '
        'Dashboard1
        '
        Me.Dashboard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dashboard1.Location = New System.Drawing.Point(0, 0)
        Me.Dashboard1.Margin = New System.Windows.Forms.Padding(4)
        Me.Dashboard1.Name = "Dashboard1"
        Me.Dashboard1.Size = New System.Drawing.Size(1309, 523)
        Me.Dashboard1.TabIndex = 0
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(33, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel1.TabIndex = 8
        Me.MetroLabel1.Text = "Welcome!"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblName.Location = New System.Drawing.Point(100, 60)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(43, 19)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "USER"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsDashboard, Me.tsEmployees, Me.tsHolidays, Me.tsDepartments, Me.tsJobTitles, Me.tsLeaveManagement, Me.tsPayroll, Me.tsSetting})
        Me.ToolStrip1.Location = New System.Drawing.Point(30, 88)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1309, 25)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsDashboard
        '
        Me.tsDashboard.Image = CType(resources.GetObject("tsDashboard.Image"), System.Drawing.Image)
        Me.tsDashboard.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDashboard.Name = "tsDashboard"
        Me.tsDashboard.Size = New System.Drawing.Size(96, 22)
        Me.tsDashboard.Text = "Dashboard"
        '
        'tsEmployees
        '
        Me.tsEmployees.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smNewEmployee, Me.smSearchEmployee})
        Me.tsEmployees.Image = CType(resources.GetObject("tsEmployees.Image"), System.Drawing.Image)
        Me.tsEmployees.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEmployees.Name = "tsEmployees"
        Me.tsEmployees.Size = New System.Drawing.Size(96, 22)
        Me.tsEmployees.Text = "Employees"
        '
        'smNewEmployee
        '
        Me.smNewEmployee.Name = "smNewEmployee"
        Me.smNewEmployee.Size = New System.Drawing.Size(164, 22)
        Me.smNewEmployee.Text = "New Employee"
        '
        'smSearchEmployee
        '
        Me.smSearchEmployee.Name = "smSearchEmployee"
        Me.smSearchEmployee.Size = New System.Drawing.Size(164, 22)
        Me.smSearchEmployee.Text = "Search Employee"
        '
        'tsHolidays
        '
        Me.tsHolidays.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smNewHoliday})
        Me.tsHolidays.Image = CType(resources.GetObject("tsHolidays.Image"), System.Drawing.Image)
        Me.tsHolidays.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsHolidays.Name = "tsHolidays"
        Me.tsHolidays.Size = New System.Drawing.Size(85, 22)
        Me.tsHolidays.Text = "Holidays"
        '
        'smNewHoliday
        '
        Me.smNewHoliday.Name = "smNewHoliday"
        Me.smNewHoliday.Size = New System.Drawing.Size(142, 22)
        Me.smNewHoliday.Text = "New Holiday"
        '
        'tsDepartments
        '
        Me.tsDepartments.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smNewDepartment})
        Me.tsDepartments.Image = CType(resources.GetObject("tsDepartments.Image"), System.Drawing.Image)
        Me.tsDepartments.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDepartments.Name = "tsDepartments"
        Me.tsDepartments.Size = New System.Drawing.Size(107, 22)
        Me.tsDepartments.Text = "Departments"
        '
        'smNewDepartment
        '
        Me.smNewDepartment.Name = "smNewDepartment"
        Me.smNewDepartment.Size = New System.Drawing.Size(164, 22)
        Me.smNewDepartment.Text = "New Department"
        '
        'tsJobTitles
        '
        Me.tsJobTitles.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smNewJobTitle})
        Me.tsJobTitles.Image = CType(resources.GetObject("tsJobTitles.Image"), System.Drawing.Image)
        Me.tsJobTitles.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsJobTitles.Name = "tsJobTitles"
        Me.tsJobTitles.Size = New System.Drawing.Size(87, 22)
        Me.tsJobTitles.Text = "Job Titles"
        '
        'smNewJobTitle
        '
        Me.smNewJobTitle.Name = "smNewJobTitle"
        Me.smNewJobTitle.Size = New System.Drawing.Size(144, 22)
        Me.smNewJobTitle.Text = "New Job Title"
        '
        'tsLeaveManagement
        '
        Me.tsLeaveManagement.Image = CType(resources.GetObject("tsLeaveManagement.Image"), System.Drawing.Image)
        Me.tsLeaveManagement.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsLeaveManagement.Name = "tsLeaveManagement"
        Me.tsLeaveManagement.Size = New System.Drawing.Size(143, 22)
        Me.tsLeaveManagement.Text = "Leave Management"
        '
        'tsPayroll
        '
        Me.tsPayroll.Image = CType(resources.GetObject("tsPayroll.Image"), System.Drawing.Image)
        Me.tsPayroll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPayroll.Name = "tsPayroll"
        Me.tsPayroll.Size = New System.Drawing.Size(75, 22)
        Me.tsPayroll.Text = "Payroll"
        '
        'tsSetting
        '
        Me.tsSetting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smChangePassword, Me.smChangeProfile, Me.smLogout})
        Me.tsSetting.Image = CType(resources.GetObject("tsSetting.Image"), System.Drawing.Image)
        Me.tsSetting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSetting.Name = "tsSetting"
        Me.tsSetting.Size = New System.Drawing.Size(76, 22)
        Me.tsSetting.Text = "Setting"
        '
        'smChangePassword
        '
        Me.smChangePassword.Name = "smChangePassword"
        Me.smChangePassword.Size = New System.Drawing.Size(168, 22)
        Me.smChangePassword.Text = "Change Password"
        '
        'smChangeProfile
        '
        Me.smChangeProfile.Name = "smChangeProfile"
        Me.smChangeProfile.Size = New System.Drawing.Size(168, 22)
        Me.smChangeProfile.Text = "Change Profile"
        '
        'smLogout
        '
        Me.smLogout.Name = "smLogout"
        Me.smLogout.Size = New System.Drawing.Size(168, 22)
        Me.smLogout.Text = "Logout"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1369, 664)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.Padding = New System.Windows.Forms.Padding(30, 88, 30, 29)
        Me.Text = "Payroll System"
        Me.TransparencyKey = System.Drawing.Color.Empty
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Dashboard1 As Dashboard
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblName As MetroFramework.Controls.MetroLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsEmployees As ToolStripSplitButton
    Friend WithEvents smNewEmployee As ToolStripMenuItem
    Friend WithEvents smSearchEmployee As ToolStripMenuItem
    Friend WithEvents tsDepartments As ToolStripSplitButton
    Friend WithEvents smNewDepartment As ToolStripMenuItem
    Friend WithEvents tsJobTitles As ToolStripSplitButton
    Friend WithEvents smNewJobTitle As ToolStripMenuItem
    Friend WithEvents tsSetting As ToolStripSplitButton
    Friend WithEvents smChangePassword As ToolStripMenuItem
    Friend WithEvents smChangeProfile As ToolStripMenuItem
    Friend WithEvents smLogout As ToolStripMenuItem
    Friend WithEvents tsDashboard As ToolStripSplitButton
    Friend WithEvents tsHolidays As ToolStripSplitButton
    Friend WithEvents smNewHoliday As ToolStripMenuItem
    Friend WithEvents tsPayroll As ToolStripSplitButton
    Friend WithEvents Holidays1 As Holidays
    Friend WithEvents JobTitles1 As JobTitles
    Friend WithEvents tsLeaveManagement As ToolStripSplitButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Departments1 As Departments
    Friend WithEvents LeaveManagement1 As LeaveManagement
End Class
