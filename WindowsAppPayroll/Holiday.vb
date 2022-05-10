
Public Class Holiday
    Private holidays As New DataSet1TableAdapters.holidaysTableAdapter
    Private nameErrorProvider As New ErrorProvider
    Private holidayDateErrorProvider As New ErrorProvider
    Private isEditing As Boolean = False
    Private originalId As Integer = 0

    Public Sub getData(ByVal id As Integer)
        Me.isEditing = True
        Me.originalId = id
        'For editing purpose
        Dim data As DataSet1.holidaysRow = holidays.GetDataById(id).Rows(0)
        txtName.Text = data.Item("name")
        dtpHolidayDate.Value = CDate(data.Item("holiday_date")).ToLongDateString()

    End Sub

    Sub ClearForm()
        txtName.Clear()
        nameErrorProvider.Clear()
        originalId = 0
        isEditing = False
    End Sub

    Private Function InputValidation() As Boolean
        Dim result As Boolean = True
        If txtName.Text = "" Then
            nameErrorProvider.SetError(txtName, "Name is required")
            result = False
        End If

        If Not isEditing And holidays.findByNameQuery(txtName.Text.ToString()) Then
            nameErrorProvider.SetError(txtName, "Name is already exist")
            result = False
        End If

        Return result
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If InputValidation() Then
            Dim isRegular As Integer = chkRegularHoliday.CheckState
            If Me.isEditing Then
                'Editing portion
                holidays.UpdateQuery(txtName.Text.ToString(), CDate(dtpHolidayDate.Value), isRegular, Me.originalId)
            Else
                holidays.InsertQuery(txtName.Text.ToString(), CDate(dtpHolidayDate.Value), isRegular)
            End If
            Me.ClearForm()
            Dim dialogSuccess As New DialogSuccess
            With dialogSuccess
                .setMessage("Holiday has been saved")
                .ShowDialog()
            End With
            Me.DialogResult = DialogResult.OK
        End If

    End Sub
End Class