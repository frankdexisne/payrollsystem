Public Class TimeSheet
    Protected cutoffAdapter As New DataSet1TableAdapters.cutoffsTableAdapter
    Protected payrollPeriodAdapter As New DataSet1TableAdapters.view_payroll_periodsTableAdapter
    Protected cutoffRow As DataSet1.cutoffsRow
    Public Sub loadData()
        With cboCutoff
            .DataSource = payrollPeriodAdapter.GetData()
            .DisplayMember = "payroll_range"
            .ValueMember = "id"
        End With
    End Sub

    Public Sub getData(ByVal employeeId As Integer)
        Me.View_timesheetTableAdapter.FillByBetweenCutoff(Me.DataSet1.view_timesheet, employeeId, CDate(cutoffRow.Item("from")), CDate(cutoffRow.Item("to")))
    End Sub

    Private Sub cboCutoff_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboCutoff.SelectedValueChanged
        'Me.cutoffRow = cutoffAdapter.GetDataById(cboCutoff.SelectedValue).Rows(0)
    End Sub
End Class
