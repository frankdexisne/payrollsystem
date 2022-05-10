Public Class LeaveApplications

    Protected employeeId As Integer
    Protected originalId As Integer

    Public Event onEditLeave(ByVal leaveId As Integer)

    Public Sub setEmployeeId(ByVal employeeId As Integer)
        Me.employeeId = employeeId
    End Sub

    Public Sub loadData()
        Me.View_employee_leave_availmentsTableAdapter.FillByEmployeeId(Me.DataSet1.view_employee_leave_availments, Me.employeeId)
    End Sub

    Public Sub getData(ByVal employeeId As Integer)
        Me.View_employee_leave_availmentsTableAdapter.FillByEmployeeId(Me.DataSet1.view_employee_leave_availments, employeeId)
    End Sub

    Private Sub dgvEmployeeLeaves_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvEmployeeLeaves.MouseClick
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            MetroContextMenu1.Show(Cursor.Position.X, Cursor.Position.Y)
        End If
    End Sub

    Private Sub dgvEmployeeLeaves_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvEmployeeLeaves.CellMouseDown
        If e.Button = MouseButtons.Right Then
            Try
                Me.originalId = dgvEmployeeLeaves.Rows(e.RowIndex).Cells(0).Value
                dgvEmployeeLeaves.CurrentCell = dgvEmployeeLeaves.Rows(e.RowIndex).Cells(e.ColumnIndex)
                dgvEmployeeLeaves.Rows(e.RowIndex).Selected = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        RaiseEvent onEditLeave(originalId)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If confirmDialog().DialogResult = DialogResult.Yes Then
            Dim employeeLeaveAvailmentAdapter As New DataSet1TableAdapters.employee_leave_availmentsTableAdapter
            employeeLeaveAvailmentAdapter.DeleteQuery(Me.originalId)
            Me.originalId = 0
            Me.loadData()
        End If
    End Sub

End Class
