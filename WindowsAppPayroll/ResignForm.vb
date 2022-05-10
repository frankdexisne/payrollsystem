Public Class ResignForm
    Protected employeeId As Integer

    Public Sub setId(ByVal id As Integer)
        Me.employeeId = id
    End Sub
    Private Sub btnSu_Click(sender As Object, e As EventArgs) Handles btnSu.Click
        Dim employeeAdapter As New DataSet1TableAdapters.employees1TableAdapter
        employeeAdapter.markAsResigned(dtpDateResigned.Value, Me.employeeId)
        Me.DialogResult = DialogResult.OK
    End Sub
End Class