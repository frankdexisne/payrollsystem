Public Class Holidays
    Private originalId As Integer
    Public Sub LoadData()
        'TODO: This line of code loads data into the 'DataSet1.holidays' table. You can move, or remove it, as needed.
        Me.HolidaysTableAdapter.FillByYear(Me.DataSet1.holidays, CDate(Now).ToString("yyyy"))
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim holidayDialog As New Holiday
        holidayDialog.ShowDialog()
        If holidayDialog.DialogResult = DialogResult.OK Then
            Me.LoadData()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            Me.HolidaysTableAdapter.FillByYear(Me.DataSet1.holidays, CDate(Now).ToString("yyyy"))
        Else
            Me.HolidaysTableAdapter.FillByYear(Me.DataSet1.holidays, txtSearch.Text.ToString())
        End If

    End Sub

    Private Sub dgvHolidays_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvHolidays.CellMouseDown
        If e.Button = MouseButtons.Right Then
            Try
                Me.originalId = dgvHolidays.Rows(e.RowIndex).Cells(0).Value
                dgvHolidays.CurrentCell = dgvHolidays.Rows(e.RowIndex).Cells(e.ColumnIndex)
                dgvHolidays.Rows(e.RowIndex).Selected = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub dgvHolidays_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvHolidays.MouseClick
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            MetroContextMenu1.Show(Cursor.Position.X, Cursor.Position.Y)
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim form As New Holiday()
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
            Me.HolidaysTableAdapter.DeleteQuery(Me.originalId)
            Me.originalId = 0
            Dim dialogSuccess As New DialogSuccess
            If dialogSuccess.DialogResult = DialogResult.OK Then
                Me.LoadData()
            End If
        End If
    End Sub
End Class
