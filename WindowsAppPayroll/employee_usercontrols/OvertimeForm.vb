Public Class OvertimeForm
    Protected overtimes As New DataSet1TableAdapters.overtimesTableAdapter
    Private startTimeErrorProvider As New ErrorProvider
    Private endTimeErrorProvider As New ErrorProvider
    Public employeeId As Integer
    Public isEditing As Boolean
    Public originalId As Integer

    Public Event onSave(ByVal employeeId As Integer)

    Public Sub getData(ByVal id As Integer)
        Dim overtimeModel As New Overtimes
        Dim overtimeRow As DataRow = overtimeModel.getById(id).Rows(0)
        'Dim overtime As DataSet1.overtimesRow = overtimes.GetDataById(id).Rows(0)
        With overtimeRow
            dtpOvertimeDate.Value = .Item("overtime_date")
            dtpStartFrom.Value = .Item("start_from")
            dtpEndTime.Value = .Item("end_time").ToString()
        End With
        Me.isEditing = True
    End Sub

    Sub ClearForm()
        dtpOvertimeDate.Value = Now.ToLongDateString()
        dtpStartFrom.Value = Now.ToLongTimeString()
        dtpEndTime.Value = Now.ToLongTimeString()
        Me.isEditing = False
        Me.originalId = 0
    End Sub

    Private Function InputValidation() As Boolean
        Dim result As Boolean = True
        If CDate(dtpStartFrom.Value) > CDate(dtpEndTime.Value) Then
            startTimeErrorProvider.SetError(dtpStartFrom, "Start time must before End time")
            result = False
        End If

        Return result
    End Function

    Private Sub dtpOvertimeDate_ValueChanged(sender As Object, e As EventArgs)
        dtpStartFrom.Value = dtpOvertimeDate.Value
        dtpEndTime.Value = dtpOvertimeDate.Value
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If InputValidation() Then
            Dim renderedHours As Double = (dtpEndTime.Value - dtpStartFrom.Value).TotalHours
            'Dim overtimeModel As New Overtimes
            If Me.isEditing Then
                'overtimeModel.updateQuery(Me.employeeId, dtpOvertimeDate.Value.ToString("yyyy-MM-dd"), dtpStartFrom.Value.ToString("yyyy-MM-dd HH:mm:ss"), dtpEndTime.Value.ToString("yyyy-MM-dd HH:mm:ss"), renderedHours, Me.originalId)
                'overtimes.UpdateQuery(CDate(dtpOvertimeDate.Value), dtpStartFrom.Value, dtpEndTime.Value, renderedHours, Me.originalId)
            Else
                overtimes.InsertQuery(Me.employeeId, CDate(dtpOvertimeDate.Value), dtpStartFrom.Value, dtpEndTime.Value, renderedHours)
                'overtimeModel.insertQuery(Me.employeeId.ToString, dtpOvertimeDate.Value.ToString("yyyy-MM-dd"), dtpStartFrom.Value.ToString("yyyy-MM-dd HH:mm:ss"), dtpEndTime.Value.ToString("yyyy-MM-dd HH:mm:ss"), renderedHours)
            End If
            Dim successDialog As New DialogSuccess
            With successDialog
                .setMessage("Overtime has been saved")
                .ShowDialog()
            End With
            RaiseEvent onSave(Me.employeeId)
        End If
    End Sub
End Class
