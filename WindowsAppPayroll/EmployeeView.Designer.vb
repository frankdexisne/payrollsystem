<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeView
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
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.btnUpdateEmployeeProfile = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.PersonalData1 = New WindowsAppPayroll.PersonalData()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.EducationalBackground1 = New WindowsAppPayroll.EducationalBackground()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.FamilyBackground1 = New WindowsAppPayroll.FamilyBackground()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.AppliedOvertimes1 = New WindowsAppPayroll.AppliedOvertimes()
        Me.OvertimeForm1 = New WindowsAppPayroll.OvertimeForm()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LeaveApplications1 = New WindowsAppPayroll.LeaveApplications()
        Me.LeaveApplicationForm1 = New WindowsAppPayroll.LeaveApplicationForm()
        Me.MetroTabPage4 = New MetroFramework.Controls.MetroTabPage()
        Me.LoanApplications1 = New WindowsAppPayroll.LoanApplications()
        Me.LoanApplicationForm1 = New WindowsAppPayroll.LoanApplicationForm()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TimeSheet1 = New WindowsAppPayroll.TimeSheet()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        Me.MetroPanel3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.MetroTabPage4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Controls.Add(Me.TabPage1)
        Me.MetroTabControl1.Controls.Add(Me.TabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage4)
        Me.MetroTabControl1.Controls.Add(Me.TabPage3)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(20, 60)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 6
        Me.MetroTabControl1.Size = New System.Drawing.Size(1223, 920)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.btnUpdateEmployeeProfile)
        Me.MetroTabPage1.Controls.Add(Me.MetroPanel1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(1215, 878)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Employee Profile"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'btnUpdateEmployeeProfile
        '
        Me.btnUpdateEmployeeProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateEmployeeProfile.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnUpdateEmployeeProfile.Location = New System.Drawing.Point(-1, 843)
        Me.btnUpdateEmployeeProfile.Name = "btnUpdateEmployeeProfile"
        Me.btnUpdateEmployeeProfile.Size = New System.Drawing.Size(181, 30)
        Me.btnUpdateEmployeeProfile.TabIndex = 3
        Me.btnUpdateEmployeeProfile.Text = "Update Profile"
        Me.btnUpdateEmployeeProfile.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel1.Controls.Add(Me.PersonalData1)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(3, 3)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1212, 831)
        Me.MetroPanel1.TabIndex = 2
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'PersonalData1
        '
        Me.PersonalData1.BackColor = System.Drawing.Color.White
        Me.PersonalData1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PersonalData1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonalData1.Location = New System.Drawing.Point(0, 0)
        Me.PersonalData1.Margin = New System.Windows.Forms.Padding(4)
        Me.PersonalData1.Name = "PersonalData1"
        Me.PersonalData1.Size = New System.Drawing.Size(1212, 831)
        Me.PersonalData1.TabIndex = 2
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.MetroPanel2)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(1215, 878)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Educational Background"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel2.Controls.Add(Me.EducationalBackground1)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(3, 3)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(1209, 816)
        Me.MetroPanel2.TabIndex = 2
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'EducationalBackground1
        '
        Me.EducationalBackground1.BackColor = System.Drawing.Color.White
        Me.EducationalBackground1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EducationalBackground1.Location = New System.Drawing.Point(0, 0)
        Me.EducationalBackground1.Name = "EducationalBackground1"
        Me.EducationalBackground1.Size = New System.Drawing.Size(1209, 816)
        Me.EducationalBackground1.TabIndex = 2
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.MetroPanel3)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(1215, 878)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Family Background"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'MetroPanel3
        '
        Me.MetroPanel3.Controls.Add(Me.FamilyBackground1)
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(3, 3)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(1213, 810)
        Me.MetroPanel3.TabIndex = 2
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'FamilyBackground1
        '
        Me.FamilyBackground1.BackColor = System.Drawing.Color.White
        Me.FamilyBackground1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FamilyBackground1.Location = New System.Drawing.Point(0, 0)
        Me.FamilyBackground1.Name = "FamilyBackground1"
        Me.FamilyBackground1.Size = New System.Drawing.Size(1213, 810)
        Me.FamilyBackground1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.AppliedOvertimes1)
        Me.TabPage1.Controls.Add(Me.OvertimeForm1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1215, 878)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Ovetime Application"
        '
        'AppliedOvertimes1
        '
        Me.AppliedOvertimes1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppliedOvertimes1.BackColor = System.Drawing.Color.White
        Me.AppliedOvertimes1.Location = New System.Drawing.Point(10, 170)
        Me.AppliedOvertimes1.Name = "AppliedOvertimes1"
        Me.AppliedOvertimes1.Size = New System.Drawing.Size(1192, 705)
        Me.AppliedOvertimes1.TabIndex = 1
        '
        'OvertimeForm1
        '
        Me.OvertimeForm1.BackColor = System.Drawing.Color.White
        Me.OvertimeForm1.Location = New System.Drawing.Point(10, 10)
        Me.OvertimeForm1.Name = "OvertimeForm1"
        Me.OvertimeForm1.Size = New System.Drawing.Size(412, 147)
        Me.OvertimeForm1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.LeaveApplications1)
        Me.TabPage2.Controls.Add(Me.LeaveApplicationForm1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1215, 878)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Leave Application"
        '
        'LeaveApplications1
        '
        Me.LeaveApplications1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LeaveApplications1.Location = New System.Drawing.Point(10, 150)
        Me.LeaveApplications1.Name = "LeaveApplications1"
        Me.LeaveApplications1.Size = New System.Drawing.Size(1190, 710)
        Me.LeaveApplications1.TabIndex = 1
        '
        'LeaveApplicationForm1
        '
        Me.LeaveApplicationForm1.BackColor = System.Drawing.Color.White
        Me.LeaveApplicationForm1.Location = New System.Drawing.Point(10, 10)
        Me.LeaveApplicationForm1.Name = "LeaveApplicationForm1"
        Me.LeaveApplicationForm1.Size = New System.Drawing.Size(586, 142)
        Me.LeaveApplicationForm1.TabIndex = 0
        '
        'MetroTabPage4
        '
        Me.MetroTabPage4.Controls.Add(Me.LoanApplications1)
        Me.MetroTabPage4.Controls.Add(Me.LoanApplicationForm1)
        Me.MetroTabPage4.HorizontalScrollbarBarColor = True
        Me.MetroTabPage4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.HorizontalScrollbarSize = 10
        Me.MetroTabPage4.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage4.Name = "MetroTabPage4"
        Me.MetroTabPage4.Size = New System.Drawing.Size(1215, 878)
        Me.MetroTabPage4.TabIndex = 6
        Me.MetroTabPage4.Text = "Loan Application"
        Me.MetroTabPage4.VerticalScrollbarBarColor = True
        Me.MetroTabPage4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.VerticalScrollbarSize = 10
        '
        'LoanApplications1
        '
        Me.LoanApplications1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoanApplications1.Location = New System.Drawing.Point(10, 250)
        Me.LoanApplications1.Name = "LoanApplications1"
        Me.LoanApplications1.Size = New System.Drawing.Size(1209, 614)
        Me.LoanApplications1.TabIndex = 3
        '
        'LoanApplicationForm1
        '
        Me.LoanApplicationForm1.BackColor = System.Drawing.Color.White
        Me.LoanApplicationForm1.Location = New System.Drawing.Point(10, 10)
        Me.LoanApplicationForm1.Name = "LoanApplicationForm1"
        Me.LoanApplicationForm1.Size = New System.Drawing.Size(437, 243)
        Me.LoanApplicationForm1.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.TimeSheet1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 38)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1215, 878)
        Me.TabPage3.TabIndex = 5
        Me.TabPage3.Text = "Time Sheet"
        '
        'TimeSheet1
        '
        Me.TimeSheet1.BackColor = System.Drawing.Color.White
        Me.TimeSheet1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TimeSheet1.Location = New System.Drawing.Point(0, 0)
        Me.TimeSheet1.Name = "TimeSheet1"
        Me.TimeSheet1.Size = New System.Drawing.Size(1215, 878)
        Me.TimeSheet1.TabIndex = 0
        '
        'EmployeeView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 1000)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Name = "EmployeeView"
        Me.Text = "EmployeeView"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroPanel3.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.MetroTabPage4.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnUpdateEmployeeProfile As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents PersonalData1 As PersonalData
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents EducationalBackground1 As EducationalBackground
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents FamilyBackground1 As FamilyBackground
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents MetroTabPage4 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents AppliedOvertimes1 As AppliedOvertimes
    Friend WithEvents OvertimeForm1 As OvertimeForm
    Friend WithEvents LeaveApplications1 As LeaveApplications
    Friend WithEvents LeaveApplicationForm1 As LeaveApplicationForm
    Friend WithEvents LoanApplications1 As LoanApplications
    Friend WithEvents LoanApplicationForm1 As LoanApplicationForm
    Friend WithEvents TimeSheet1 As TimeSheet
End Class
