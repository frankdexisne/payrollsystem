Public Class JobTitles
    Private originalId As Integer
    Private jobTitlesAdapter As New DataSet1TableAdapters.positionsTableAdapter

    Public Sub LoadData()
        'TODO: This line of code loads data into the 'DataSet1.positions' table. You can move, or remove it, as needed.
        Me.PositionsTableAdapter.Fill(Me.DataSet1.positions)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim dialogJobTitle As New JobTitle
        dialogJobTitle.ShowDialog()
        If dialogJobTitle.DialogResult = DialogResult.OK Then
            Me.LoadData()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Me.PositionsTableAdapter.FillByName(Me.DataSet1.positions, "%" + txtSearch.Text.ToString() + "%")
    End Sub

    Private Sub dgvJobTitles_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvJobTitles.MouseClick
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            MetroContextMenu1.Show(Cursor.Position.X, Cursor.Position.Y)
        End If
    End Sub

    Private Sub dgvJobTitles_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvJobTitles.CellMouseDown
        If e.Button = MouseButtons.Right Then
            Try
                Me.originalId = dgvJobTitles.Rows(e.RowIndex).Cells(0).Value
                dgvJobTitles.CurrentCell = dgvJobTitles.Rows(e.RowIndex).Cells(e.ColumnIndex)
                dgvJobTitles.Rows(e.RowIndex).Selected = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim form As New JobTitle()
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
        If confirmDialog().DialogResult = DialogResult.Yes Then
            jobTitlesAdapter.DeleteQuery(Me.originalId)
            Me.originalId = 0
            Me.LoadData()
        End If
    End Sub
End Class
