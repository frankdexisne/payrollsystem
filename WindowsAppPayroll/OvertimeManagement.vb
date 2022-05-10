Public Class OvertimeManagement
    Private Sub OvertimeManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.view_employee_overtimes1' table. You can move, or remove it, as needed.
        Me.View_employee_overtimes1TableAdapter.Fill(Me.DataSet1.view_employee_overtimes1)
    End Sub
End Class