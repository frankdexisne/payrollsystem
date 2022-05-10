Public Class Departments
    Private originalId As Integer
    Public Sub LoadData()
        'TODO: This line of code loads data into the 'DataSet1.departments' table. You can move, or remove it, as needed.
        Me.DepartmentsTableAdapter.Fill(Me.DataSet1.departments)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim departmentForm As New Department
        departmentForm.ShowDialog()
        If departmentForm.DialogResult = DialogResult.OK Then
            Me.LoadData()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Me.DepartmentsTableAdapter.FillByName(Me.DataSet1.departments, "%" + txtSearch.Text.ToString() + "%")
    End Sub

    Private Sub dgvDepartments_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDepartments.CellMouseDown
        If e.Button = MouseButtons.Right Then
            Try
                Me.originalId = dgvDepartments.Rows(e.RowIndex).Cells(0).Value
                dgvDepartments.CurrentCell = dgvDepartments.Rows(e.RowIndex).Cells(e.ColumnIndex)
                dgvDepartments.Rows(e.RowIndex).Selected = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub dgvDepartments_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvDepartments.MouseClick
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            MetroContextMenu1.Show(Cursor.Position.X, Cursor.Position.Y)
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim form As New Department()
        With form
            .getData(Me.originalId)
            .ShowDialog()

            If .DialogResult = DialogResult.OK Then
                Me.LoadData()
                Me.originalId = 0
            End If
        End With
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If confirmDialog().DialogResult = DialogResult.OK Then
            Me.DepartmentsTableAdapter.DeleteQuery(Me.originalId)
            Me.originalId = 0
            Me.LoadData()
        End If
    End Sub
End Class
