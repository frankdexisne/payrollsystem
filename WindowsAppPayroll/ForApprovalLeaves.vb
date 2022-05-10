Public Class ForApprovalLeaves

    Protected cutoffAdapter As New DataSet1TableAdapters.cutoffs1TableAdapter
    Protected employeeLeaveAvailment As New DataSet1TableAdapters.employee_leave_availmentsTableAdapter
    Private dgvRow As DataGridViewRow
    Protected cutoffId As Integer
    Protected originalId As Integer
    Protected rowIndex As Integer

    Public Sub loadData(ByVal cutoffId As Integer)
        Me.cutoffId = cutoffId
        Dim cutoffRow As DataSet1.cutoffs1Row = cutoffAdapter.GetDataById(cutoffId).Rows(0)
        With cutoffRow
            'TODO: This line of code loads data into the 'DataSet1.view_employee_leave_availments' table. You can move, or remove it, as needed.
            Me.View_employee_leave_availmentsTableAdapter.FillByForApproval(Me.DataSet1.view_employee_leave_availments, .Item("from"), .Item("to"))
        End With
    End Sub

    Public Sub loadAll(ByVal year As Integer)
        Me.View_employee_leave_availmentsTableAdapter.FillByYear(Me.DataSet1.view_employee_leave_availments, year)
    End Sub

    Private Sub dgvLeaves_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvLeaves.CellMouseDown
        If e.Button = MouseButtons.Right Then
            Try
                Me.originalId = dgvLeaves.Rows(e.RowIndex).Cells(0).Value
                Me.rowIndex = e.RowIndex
                dgvLeaves.CurrentCell = dgvLeaves.Rows(e.RowIndex).Cells(e.ColumnIndex)
                dgvLeaves.Rows(e.RowIndex).Selected = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub dgvLeaves_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvLeaves.MouseClick
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            If dgvLeaves.Rows(rowIndex).Cells(8).Value = 0 Then
                MetroContextMenu1.Show(Cursor.Position.X, Cursor.Position.Y)
            End If
        End If
    End Sub

    Private Function onRemoveRow(ByVal question As String) As Boolean
        Dim confirmDialog As New DialogConfirm
        With confirmDialog
            .setQuestion(question)
            .ShowDialog()
            If .DialogResult = DialogResult.Yes Then
                Me.dgvRow = dgvLeaves.Rows(rowIndex)
                dgvLeaves.Rows.RemoveAt(Me.rowIndex)
                Return True
            End If
        End With
        Return False
    End Function

    Private Sub ApproveToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Me.onRemoveRow("Approve this leave?") Then
            'change to approved dtgview
            Me.employeeLeaveAvailment.ChangeStatusQuery(1, Me.originalId)
        End If
    End Sub

    Private Sub DisapproveToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Me.onRemoveRow("Disapprove this leave?") Then
            'change to disapproved dtgview
            Me.employeeLeaveAvailment.ChangeStatusQuery(0, Me.originalId)
        End If
    End Sub

End Class