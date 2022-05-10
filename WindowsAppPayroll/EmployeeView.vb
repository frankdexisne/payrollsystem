Public Class EmployeeView
    Protected employeeId As Integer
    Public Sub getData(ByVal employeeId As Integer, ByVal sender As Object, ByVal e As EventArgs)
        Me.employeeId = employeeId
        With PersonalData1
            .loadData()
            .getData(employeeId, sender, e)
        End With
        EducationalBackground1.getData(employeeId)
        With FamilyBackground1
            .isRequiredSpouse(PersonalData1.civilStatus)
            .getData(employeeId)
        End With
        OvertimeForm1.employeeId = employeeId
        AppliedOvertimes1.getData(employeeId)

        LeaveApplicationForm1.loadData(employeeId)
        With LoanApplicationForm1
            .setEmployeeId(employeeId)
            .loadData()
        End With
        LeaveApplications1.getData(employeeId)
        With LoanApplications1
            .setEmployeeId(employeeId)
            .loadData()
        End With
        TimeSheet1.loadData()
    End Sub

    Private Sub LoanApplicationForm1_onSaveData() Handles LoanApplicationForm1.onSaveData
        With LoanApplications1
            .setEmployeeId(employeeId)
            .loadData()
        End With
    End Sub

    Private Sub LoanApplications1_onEditLoan(id As Integer) Handles LoanApplications1.onEditLoan
        With LoanApplicationForm1
            .getData(id)
        End With
    End Sub

    Private Sub LeaveApplications1_onEditLeave(leaveId As Integer) Handles LeaveApplications1.onEditLeave
        With LeaveApplicationForm1
            .getData(leaveId)
        End With
    End Sub

    Private Sub AppliedOvertimes1_onEdit(overtimeId As Integer) Handles AppliedOvertimes1.onEdit
        With OvertimeForm1
            .getData(overtimeId)
        End With
    End Sub

    Private Sub OvertimeForm1_onSave(employeeId As Integer) Handles OvertimeForm1.onSave
        With AppliedOvertimes1
            .getData(employeeId)
        End With
    End Sub
End Class