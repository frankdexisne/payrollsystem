Public Class AppliedOvertimes
    Private originalId As Integer
    Protected employeeId As Integer
    Protected overtimesAdapter As New DataSet1TableAdapters.overtimesTableAdapter

    Public Event onEdit(ByVal overtimeId As Integer)

    Public Sub getData(ByVal employeeId As Integer)
        Me.View_employee_overtimes1TableAdapter.FillByApprovedOvertime(Me.DataSet1.view_employee_overtimes1, employeeId)
        Me.employeeId = employeeId
    End Sub

    Private Sub dgvOvertimes_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvOvertimes.CellMouseDown
        If e.Button = MouseButtons.Right Then
            Try
                Me.originalId = dgvOvertimes.Rows(e.RowIndex).Cells(0).Value
                dgvOvertimes.CurrentCell = dgvOvertimes.Rows(e.RowIndex).Cells(e.ColumnIndex)
                dgvOvertimes.Rows(e.RowIndex).Selected = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub dgvOvertimes_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvOvertimes.MouseClick
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            MetroContextMenu1.Show(Cursor.Position.X, Cursor.Position.Y)
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If confirmDialog().DialogResult = DialogResult.Yes Then
            overtimesAdapter.DeleteQuery(Me.originalId)
            Me.getData(Me.employeeId)
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        RaiseEvent onEdit(Me.originalId)
    End Sub
End Class
