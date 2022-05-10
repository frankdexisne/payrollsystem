Public Class Cutoff
    Private startErrorProvider As New ErrorProvider
    Private endErrorProvider As New ErrorProvider
    Private isEditing As Boolean = False
    Private originalId As Integer = 0
    Protected cutoffAdapter As New DataSet1TableAdapters.cutoffs1TableAdapter
    Public cutoffId As Integer
    Public Sub getData(ByVal id As Integer)
        Me.isEditing = True
        Me.originalId = id
        'For editing purpose
    End Sub

    Sub ClearForm()
        dtpStart.Value = Now.ToLongDateString()
        dtpEnd.Value = Now.ToLongDateString()
        startErrorProvider.Clear()
        endErrorProvider.Clear()
    End Sub

    Private Function InputValidation() As Boolean
        Dim result As Boolean = True
        If CDate(dtpStart.Value) > CDate(dtpEnd.Value) Then
            startErrorProvider.SetError(dtpStart, "Start date must before End date")
            result = False
        End If

        If Me.cutoffAdapter.ScalarExist(dtpStart.Value, dtpEnd.Value) Then
            startErrorProvider.SetError(dtpStart, "This cutoff is already exist")
            endErrorProvider.SetError(dtpEnd, "This cutoff is already exist")
            result = False
        End If

        Return result
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If InputValidation() Then

            Dim name As String = dtpYearMonth.Value.ToString("MMMM") + " " + cboPeriod.Text + dtpYearMonth.Value.ToString("yyyy")
            If Me.isEditing Then
                'Editing portio
                cutoffAdapter.UpdateQuery(CInt(dtpYearMonth.Value.ToString("yyyy")), dtpYearMonth.Value.ToString("MM"), cboPeriod.Text, dtpStart.Value, dtpEnd.Value, cboPeriod.SelectedIndex, 0, Me.originalId)
            Else
                cutoffAdapter.InsertQuery(dtpYearMonth.Value.ToString("yyyy"), dtpYearMonth.Value.ToString("MM"), cboPeriod.Text, dtpStart.Value.ToString("yyyy-MM-dd"), dtpEnd.Value.ToString("yyyy-MM-dd"), cboPeriod.SelectedIndex, 0)
                Me.cutoffId = cutoffAdapter.ScalarQuery()
            End If
            Me.ClearForm()
            Me.DialogResult = DialogResult.OK
            Me.originalId = 0
        End If

    End Sub

End Class