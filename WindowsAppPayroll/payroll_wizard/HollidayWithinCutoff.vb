Public Class HollidayWithinCutoff

    Protected cutoffId As Integer

    Public Sub loadData(ByVal cutoffId As Integer)
        Me.cutoffId = cutoffId
        'set dataset here
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim dialogHoliday As New Holiday
        With dialogHoliday
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                Me.loadData(Me.cutoffId)
            End If
        End With
    End Sub
End Class
