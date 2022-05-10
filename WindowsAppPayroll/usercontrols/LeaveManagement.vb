Public Class LeaveManagement
    Private originalId As Integer
    Private rowIndex As Integer
    Private dgvRow As DataGridViewRow
    Protected employeeLeaveAvailment As New DataSet1TableAdapters.employee_leave_availmentsTableAdapter
    Public Sub loadData()
        Dim year As Integer = CInt(dtpYear.Value.ToString("yyyy"))
        Me.View_employee_leave_availmentsTableAdapter.FillByYear(Me.DataSet1.view_employee_leave_availments, year)
    End Sub

    Private Sub MetroLabel2_Click(sender As Object, e As EventArgs) Handles MetroLabel2.Click
        Dim dialogForApprovalLeaves As New ForApprovalLeaves
        With dialogForApprovalLeaves
            Dim year As Integer = CInt(dtpYear.Value.ToString("yyyy"))
            .loadAll(year)
            .ShowDialog()
        End With
    End Sub

    Private Sub dtpYear_ValueChanged(sender As Object, e As EventArgs) Handles dtpYear.ValueChanged
        Me.loadData()
    End Sub
End Class
