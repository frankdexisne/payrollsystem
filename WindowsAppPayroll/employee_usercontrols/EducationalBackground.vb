Public Class EducationalBackground

    Protected validation As New Validation

    Protected educationalBackgroundAdapter As New DataSet1TableAdapters.educational_backgroundsTableAdapter

    Protected nameOfSchoolErrorProvider, basicEducationErrorProvider, periodFromErrorProvider, periodToErrorProvider, yearGraduatedErrorProvider As New ErrorProvider
    Protected requiredMessage As String = "This field is required"
    Protected isEditing As Boolean = False
    Public employeeId As Integer
    Private dgvRow As DataGridViewRow

    Public Sub getData(ByVal employeeId As Integer)
        Me.employeeId = employeeId
        'POPULATE DATAGRID BY EMPLOYEE ID
        dgvEducationalBackground.Rows.Clear()
        Dim educationBackgroundTable As DataTable = educationalBackgroundAdapter.GetDataByEmployeeId(employeeId)
        For i = 0 To educationBackgroundTable.Rows.Count - 1
            With educationBackgroundTable.Rows(i)
                Dim row As String() = New String() { .Item("id"), .Item("level"), .Item("name_of_school"), .Item("basic_educ_degree_course"), .Item("period_start"), .Item("period_end"), .Item("year_graduated"), .Item("highiest_level_unit_earned"), .Item("is_scholarship"), Nothing, Nothing}
                dgvEducationalBackground.Rows.Add(row)
            End With
        Next
    End Sub

    Public Sub onRemove(ByVal rowIndex As Integer)
        If Not dgvEducationalBackground.Rows(rowIndex).Cells(0).Value Is Nothing Then
            Dim id As Integer = CInt(dgvEducationalBackground.Rows(rowIndex).Cells(0).Value)
            educationalBackgroundAdapter.DeleteQuery(id)
        End If
    End Sub

    Public Sub getRow(ByVal rowIndex As Integer)
        Me.isEditing = True
        Me.dgvRow = dgvEducationalBackground.Rows(rowIndex)
        With dgvRow
            cboLevel.SelectedText = .Cells(1).Value
            txtNameOfSchool.Text = .Cells(2).Value
            txtBasicEducation.Text = .Cells(3).Value
            txtPeriodFrom.Text = .Cells(4).Value
            txtPeriodTo.Text = .Cells(5).Value
            txtHighiesLevelUnitsEarned.Text = .Cells(6).Value
            txtYearGraduated.Text = .Cells(7).Value
            chkScholarship.Checked = .Cells(8).Value
        End With
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isValidInput() Then
            If Me.isEditing Then
                With dgvRow
                    .Cells(1).Value = cboLevel.Text
                    .Cells(2).Value = txtNameOfSchool.Text
                    .Cells(3).Value = txtBasicEducation.Text
                    .Cells(4).Value = txtPeriodFrom.Text
                    .Cells(5).Value = txtPeriodTo.Text
                    .Cells(6).Value = txtYearGraduated.Text
                    .Cells(7).Value = txtHighiesLevelUnitsEarned.Text
                    .Cells(8).Value = chkScholarship.Checked
                End With
            Else
                Dim row As String() = New String() {Nothing, cboLevel.Text, txtNameOfSchool.Text, txtBasicEducation.Text, txtPeriodFrom.Text, txtPeriodTo.Text, txtYearGraduated.Text, txtHighiesLevelUnitsEarned.Text, chkScholarship.Checked, Nothing, Nothing}
                dgvEducationalBackground.Rows.Add(row)
            End If
            Me.ResetInputs()
        End If
    End Sub

    Private Sub dgvEducationalBackground_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEducationalBackground.CellContentClick
        If e.ColumnIndex = 9 Then
            Me.getRow(e.RowIndex)
        End If
        If e.ColumnIndex = 10 Then
            If confirmDialog().DialogResult = DialogResult.Yes Then
                Me.onRemove(e.RowIndex)
                dgvEducationalBackground.Rows.RemoveAt(e.RowIndex)
            End If

        End If
    End Sub

    Protected Function isValidInput() As Boolean
        Dim result As Boolean = True
        If txtNameOfSchool.Text = String.Empty Then
            nameOfSchoolErrorProvider.SetError(txtNameOfSchool, Me.requiredMessage)
            result = False
        End If
        If txtBasicEducation.Text = String.Empty Then
            basicEducationErrorProvider.SetError(txtBasicEducation, Me.requiredMessage)
            result = False
        End If
        If txtPeriodFrom.Text = String.Empty Then
            periodFromErrorProvider.SetError(txtPeriodFrom, Me.requiredMessage)
            result = False
        End If
        If txtPeriodTo.Text = String.Empty Then
            periodToErrorProvider.SetError(txtPeriodTo, Me.requiredMessage)
            result = False
        End If
        If Val(txtPeriodFrom.Text) > Val(txtPeriodTo.Text) Then
            periodFromErrorProvider.SetError(txtPeriodFrom, "Period from must before Period To")
            result = False
        End If
        Return result
    End Function

    Public Sub ResetInputs()
        cboLevel.SelectedIndex = 0
        txtNameOfSchool.Clear()
        txtBasicEducation.Clear()
        txtHighiesLevelUnitsEarned.Clear()
        txtPeriodFrom.Clear()
        txtPeriodTo.Clear()
        txtYearGraduated.Clear()
        chkScholarship.Checked = False
        Me.isEditing = False
        Me.dgvRow = Nothing
    End Sub

    Public Sub onSaveEducationalBackground(ByVal employeeId As Integer)
        For Each row As DataGridViewRow In dgvEducationalBackground.Rows
            With row
                Dim _level As String = .Cells(1).Value
                Dim _name As String = .Cells(2).Value
                Dim _basic As String = .Cells(3).Value
                Dim _periodFrom As String = .Cells(4).Value
                Dim _periodTo As String = .Cells(5).Value
                Dim _yearGraduated As String = .Cells(6).Value
                Dim _highiesLevel As String = .Cells(7).Value
                Dim _isScholarship As Boolean = CBool(.Cells(8).Value)

                If Not .Cells(0).Value Is Nothing Then
                    educationalBackgroundAdapter.UpdateQuery(_level, _name, _basic, _periodFrom, _periodTo, _highiesLevel, _yearGraduated, _isScholarship, employeeId)
                Else
                    educationalBackgroundAdapter.InsertQuery(employeeId, _level, _name, _basic, _periodFrom, _periodTo, _highiesLevel, _yearGraduated, _isScholarship)
                End If
            End With
        Next
    End Sub

    Private Sub txtPeriodFrom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPeriodFrom.KeyPress
        If validation.acceptNumericOnly(e) Then
            periodFromErrorProvider.SetError(txtPeriodFrom, "Please enter numeric")
        Else
            periodFromErrorProvider.Clear()
        End If
    End Sub

    Private Sub txtPeriodTo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPeriodTo.KeyPress
        If validation.acceptNumericOnly(e) Then
            periodToErrorProvider.SetError(txtPeriodTo, "Please enter numeric")
        Else
            periodToErrorProvider.Clear()
        End If
    End Sub

    Private Sub txtYearGraduated_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYearGraduated.KeyPress
        If validation.acceptNumericOnly(e) And txtYearGraduated.Text <> Nothing Then
            yearGraduatedErrorProvider.SetError(txtYearGraduated, "Please enter numeric")
        Else
            yearGraduatedErrorProvider.Clear()
        End If
    End Sub
End Class
