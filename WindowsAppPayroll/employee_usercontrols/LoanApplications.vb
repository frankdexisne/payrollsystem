Public Class LoanApplications
    Protected originalId As Integer
    Protected employeeId As Integer

    Public Event onEditLoan(ByVal id As Integer)

    Public Sub setEmployeeId(ByVal id As Integer)
        Me.employeeId = id
    End Sub
    Public Sub loadData()
        Me.View_employee_loansTableAdapter.FillByEmployeeId(Me.DataSet1.view_employee_loans, Me.employeeId)
    End Sub

    Private Sub dgvLoans_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvLoans.MouseClick
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            MetroContextMenu1.Show(Cursor.Position.X, Cursor.Position.Y)
        End If
    End Sub

    Private Sub dgvLoans_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvLoans.CellMouseDown
        If e.Button = MouseButtons.Right Then
            Try
                Me.originalId = dgvLoans.Rows(e.RowIndex).Cells(0).Value
                dgvLoans.CurrentCell = dgvLoans.Rows(e.RowIndex).Cells(e.ColumnIndex)
                dgvLoans.Rows(e.RowIndex).Selected = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        RaiseEvent onEditLoan(originalId)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If confirmDialog().DialogResult = DialogResult.Yes Then
            Dim employeeLoansAdapter As New DataSet1TableAdapters.employee_loansTableAdapter
            employeeLoansAdapter.DeleteQuery(Me.originalId)
            Me.originalId = 0
            Me.loadData()
        End If
    End Sub
End Class
