Public Class JobTitle
    Private positionAdapter As New DataSet1TableAdapters.positionsTableAdapter
    Private nameErrorProvider As New ErrorProvider
    Private isEditing As Boolean = False
    Private originalId As Integer = 0

    Public Sub getData(ByVal id As Integer)
        Me.isEditing = True
        Me.originalId = id
        'For editing purpose
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

        If Not isEditing And positionAdapter.findByNameQuery(txtName.Text.ToString()) Then
            nameErrorProvider.SetError(txtName, "Name is already exist")
            result = False
        End If

        Return result
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If InputValidation() Then
            If Me.isEditing Then
                'Editing portion
                positionAdapter.UpdateQuery(txtName.Text.ToString(), Me.originalId)
                MsgBox("Job Title has been updated")
            Else
                positionAdapter.InsertQuery(txtName.Text.ToString())
                MsgBox("Job Title name is already added")
            End If
            Me.ClearForm()
            Me.DialogResult = DialogResult.OK
        End If

    End Sub
End Class