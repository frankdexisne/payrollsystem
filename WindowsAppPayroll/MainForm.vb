
Public Class MainForm

    Private mdiSubForm As New MdiSubForm(Me)
    Protected activeUserControl As New UserControl

    Private Sub showUserControl(ByVal uc As UserControl)
        activeUserControl.Visible = False
        activeUserControl = uc
        activeUserControl.Visible = True
    End Sub

    Private Sub smSearchEmployee_Click(sender As Object, e As EventArgs) Handles smSearchEmployee.Click
        EmployeeList.Show()
    End Sub

    Private Sub smNewEmployee_Click(sender As Object, e As EventArgs) Handles smNewEmployee.Click
        ' Dialog for new or old employee
        Dim dialogEmployee As New Employee
        With dialogEmployee
            With .PersonalData1
                .txtEmployeeNo.Enabled = False
                .setEmployeeNo()
            End With
            .ShowDialog()
        End With
    End Sub

    Private Sub smNewHoliday_Click(sender As Object, e As EventArgs) Handles smNewHoliday.Click
        Dim holidaysDialog As New Holiday
        holidaysDialog.ShowDialog()
        If holidaysDialog.DialogResult = DialogResult.OK Then
            Me.Holidays1.LoadData()
        End If
    End Sub


    Private Sub tsHolidays_ButtonClick(sender As Object, e As EventArgs) Handles tsHolidays.ButtonClick
        Me.Holidays1.LoadData()
        Me.showUserControl(Me.Holidays1)
    End Sub

    Private Sub tsDepartments_Click(sender As Object, e As EventArgs) Handles tsDepartments.Click
        Me.showUserControl(Me.Departments1)
    End Sub

    Private Sub tsJobTitles_ButtonClick(sender As Object, e As EventArgs) Handles tsJobTitles.ButtonClick
        Me.JobTitles1.LoadData()
        Me.showUserControl(Me.JobTitles1)
    End Sub

    Private Sub smNewDepartment_Click(sender As Object, e As EventArgs) Handles smNewDepartment.Click
        Dim dialogDepartment As New Department
        dialogDepartment.ShowDialog()
        If dialogDepartment.DialogResult = DialogResult.OK Then
            Me.Departments1.LoadData()
        End If
    End Sub

    Private Sub smNewJobTitle_Click(sender As Object, e As EventArgs) Handles smNewJobTitle.Click
        Dim dialogJobTitle As New JobTitle
        dialogJobTitle.ShowDialog()
        If dialogJobTitle.DialogResult = DialogResult.OK Then
            Me.JobTitles1.LoadData()
        End If
    End Sub

    Private Sub tsDepartments_ButtonClick(sender As Object, e As EventArgs) Handles tsDepartments.ButtonClick
        Departments1.LoadData()
        Me.showUserControl(Me.Departments1)
    End Sub

    Private Sub tsLeaveManagement_ButtonClick(sender As Object, e As EventArgs) Handles tsLeaveManagement.ButtonClick
        LeaveManagement1.loadData()
        Me.showUserControl(Me.LeaveManagement1)
    End Sub

    Private Sub tsPayroll_ButtonClick(sender As Object, e As EventArgs) Handles tsPayroll.ButtonClick
        Dim payrollWizard As New PayrollWizard
        With payrollWizard
            .loadComboBox()
            .ShowDialog()
        End With
    End Sub

    Private Sub tsDashboard_ButtonClick(sender As Object, e As EventArgs) Handles tsDashboard.ButtonClick
        Me.Dashboard1.loadData()
        Me.showUserControl(Me.Dashboard1)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblName.Text = authenticatedUser.Item("name")
        tsDashboard_ButtonClick(sender, e)
    End Sub
End Class
