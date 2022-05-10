Public Class LeaveApplicationForm
    Private leaveAvailmentAdapter As New DataSet1TableAdapters.employee_leave_availmentsTableAdapter
    Private leavesAdapater As New DataSet1TableAdapters.leavesTableAdapter
    Private employeeLeaveAdapter As New DataSet1TableAdapters.view_employee_leavesTableAdapter
    Private startErrorProvider As New ErrorProvider
    Private endErrorProvider As New ErrorProvider
    Private employeeLeaveCredit As Integer
    Private isEditing As Boolean = False
    Private originalId As Integer

    Public Sub getData(ByVal id As Integer)
        Me.originalId = id
        Me.isEditing = True
        Dim data As DataSet1.employee_leave_availmentsRow = leaveAvailmentAdapter.GetDataById(id).Rows(0)
        With data
            If .Item("is_approve") = 1 Then
                Dim dialogError As New DialogError
                With dialogError
                    .setMessage("Unable to edit. already approved")
                    .ShowDialog()
                End With
                Me.ClearForm()
            Else
                cboLeave.SelectedValue = .Item("employee_leave_id")
                dtpStart.Value = .Item("effective_date_from")
                dtpEnd.Value = .Item("effective_date_to")
            End If
        End With
    End Sub

    Public Sub loadData(ByVal employeeId As Integer)
        With cboLeave
            .DataSource = employeeLeaveAdapter.GetDataByEmployeeId(employeeId)
            .DisplayMember = "name"
            .ValueMember = "id"
        End With
    End Sub

    Sub ClearForm()
        dtpStart.Value = Now.ToLongDateString()
        dtpEnd.Value = Now.ToLongDateString()
        startErrorProvider.Clear()
        endErrorProvider.Clear()
        Me.originalId = 0
        Me.isEditing = False
    End Sub

    Private Function InputValidation() As Boolean
        Dim result As Boolean = True
        If CDate(dtpStart.Value) > CDate(dtpEnd.Value) Then
            startErrorProvider.SetError(dtpStart, "Start date must before End date")
            result = False
        End If

        Return result
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If InputValidation() Then
            Dim message As String
            If Me.isEditing Then
                leaveAvailmentAdapter.UpdateQuery(cboLeave.SelectedValue, CDate(dtpStart.Value), CDate(dtpEnd.Value), CInt(CDate(dtpStart.Value).ToString("yyyy")), Me.originalId)
                message = "Leave has been updated"
            Else
                leaveAvailmentAdapter.InsertQuery(cboLeave.SelectedValue, CDate(dtpStart.Value), CDate(dtpEnd.Value), CInt(CDate(dtpStart.Value).ToString("yyyy")), 0, Nothing, Nothing)
                message = "Leave application has been applied, well wait for the approval"

            End If
            Me.ClearForm()
            Dim dialogSuccess As New DialogSuccess
            With dialogSuccess
                .setMessage(message)
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.ClearForm()
    End Sub
End Class
