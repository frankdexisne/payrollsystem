Public Class Department
    Private departments As New DataSet1TableAdapters.departmentsTableAdapter
    Private nameErrorProvider As New ErrorProvider
    Private isEditing As Boolean = False
    Private originalId As Integer = 0

    Public Sub getData(ByVal id As Integer)
        Me.isEditing = True
        Me.originalId = id
        'For editing purpose
        Dim data As DataSet1.departmentsRow = departments.GetDataById(id).Rows(0)
        txtName.Text = data.Item("name")
    End Sub

    Sub ClearForm()
        txtName.Clear()
        nameErrorProvider.Clear()
        originalId = 0
        isEditing = False
    End Sub

    Private Function InputValidation() As Boolean
        Dim result As Boolean = True
        Dim errorMessages As String = ""
        If txtName.Text = "" Then
            nameErrorProvider.SetError(txtName, "Name is required")
            result = False
        End If

        If Not isEditing And departments.findByNameQuery(txtName.Text.ToString()) Then
            nameErrorProvider.SetError(txtName, "Name is already exist")
            result = False
        End If

        Return result
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If InputValidation() Then
            If Me.isEditing Then
                'Editing portion
                departments.UpdateQuery(txtName.Text.ToString(), Me.originalId)
                Me.Close()
            Else
                departments.InsertQuery(txtName.Text.ToString())
            End If
            Dim dialogSuccess As New DialogSuccess
            With dialogSuccess
                .setMessage("Department has been save")
            End With
            Me.ClearForm()
            Me.DialogResult = DialogResult.OK
        End If

    End Sub
End Class