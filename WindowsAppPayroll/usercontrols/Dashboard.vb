Public Class Dashboard
    Protected users As New DataSet1TableAdapters.users1TableAdapter
    Protected employees As New DataSet1TableAdapters.employees1TableAdapter
    Protected employeeModel As New Employees
    Public Sub loadData()
        txtLate.Text = employeeModel.todayLate()
        txtUndertime.Text = employeeModel.todayUndertime()
        txtEmployeeToday.Text = employeeModel.todayAttend()
        txtEmployeeCount.Text = employees.activeEmployee()
        txtUserCount.Text = users.totalCount()
        Me.View_today_attendance1TableAdapter.Fill(Me.DataSet1.view_today_attendance1)
    End Sub

End Class
