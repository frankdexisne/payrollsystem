Public Class CutoffList
    Private Sub CutoffList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.cutoffs' table. You can move, or remove it, as needed.
        Me.CutoffsTableAdapter.Fill(Me.DataSet1.cutoffs)
    End Sub

    Private Sub ViewSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSummaryToolStripMenuItem.Click
        Process.Start("https://www.google.com/")
    End Sub

    Private Sub dgvDepartments_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCutoffs.CellMouseDown
        If e.Button = MouseButtons.Right Then
            Try
                dgvCutoffs.CurrentCell = dgvCutoffs.Rows(e.RowIndex).Cells(e.ColumnIndex)
                dgvCutoffs.Rows(e.RowIndex).Selected = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub dgvDepartments_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvCutoffs.MouseClick
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            MetroContextMenu1.Show(Cursor.Position.X, Cursor.Position.Y)
        End If
    End Sub
End Class