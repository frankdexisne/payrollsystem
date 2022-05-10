Imports System.ComponentModel

Public Class EmployeeList
    Protected employeeId As Integer
    Protected employeeName As String
    Protected rowIndex As Integer
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'TODO: This line of code loads data into the 'DataSet1.view_employee_list' table. You can move, or remove it, as needed.
        Me.View_employee_search_resultTableAdapter.FillBySearch(Me.DataSet1.view_employee_search_result, "%" + txtSearch.Text + "%", "%" + txtSearch.Text + "%", "%" + txtSearch.Text + "%")
    End Sub

    Private Sub dgvEmployees_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvEmployees.MouseClick
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            MetroContextMenu1.Show(Cursor.Position.X, Cursor.Position.Y)
        End If
    End Sub

    Private Sub dgvEmployees_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvEmployees.CellMouseDown
        If e.Button = MouseButtons.Right Then
            Try
                Me.rowIndex = e.RowIndex
                Me.employeeId = dgvEmployees.Rows(e.RowIndex).Cells(0).Value
                Me.employeeName = dgvEmployees.Rows(e.RowIndex).Cells(1).Value
                dgvEmployees.CurrentCell = dgvEmployees.Rows(e.RowIndex).Cells(e.ColumnIndex)
                dgvEmployees.Rows(e.RowIndex).Selected = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub ViewProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProfileToolStripMenuItem.Click

        With EmployeeView
            .Text = Me.employeeName
            .getData(Me.employeeId, sender, e)
            .MetroTabControl1.SelectedIndex = 0
            .Show()

        End With
    End Sub

    Private Sub OvertimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OvertimeToolStripMenuItem.Click

        With EmployeeView
            .Text = Me.employeeName
            .getData(Me.employeeId, sender, e)
            .MetroTabControl1.SelectedIndex = 3
            .Show()

        End With
    End Sub

    Private Sub LeaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeaveToolStripMenuItem.Click

        With EmployeeView
            .Text = Me.employeeName
            .getData(Me.employeeId, sender, e)
            .MetroTabControl1.SelectedIndex = 4
            .Show()

        End With
    End Sub

    Private Sub LoanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoanToolStripMenuItem.Click

        With EmployeeView
            .Text = Me.employeeName
            .getData(Me.employeeId, sender, e)
            .MetroTabControl1.SelectedIndex = 5
            .Show()

        End With
    End Sub

    Private Sub MarkAsResignedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAsResignedToolStripMenuItem.Click
        Dim resignedForm As New ResignForm
        With resignedForm
            .setId(Me.employeeId)
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                dgvEmployees.Rows.RemoveAt(rowIndex)
            End If
        End With
    End Sub
End Class