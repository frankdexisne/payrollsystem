Public Class FamilyBackground
    Protected requireSpouse As Boolean = False
    Protected familiesAdapter As New DataSet1TableAdapters.familiesTableAdapter
    'Error Providers
    Protected lnameFatherErrorProvider, fnameFatherErrorProvider, mnameFatherErrorProvider, suffixFatherErrorProvider As New ErrorProvider
    Protected lnameMotherErrorProvider, fnameMotherErrorProvider, mnameMotherErrorProvider, suffixMotherErrorProvider As New ErrorProvider

    Protected lnameChildErrorProvider, fnameChildErrorProvider, mnameChildErrorProvider, dobChildErrorProvider As New ErrorProvider
    Protected lnameSpouseErrorProvider, fnameSpouseErrorProvider, mnameSpouseErrorProvider, suffixSpouseErrorProvider As New ErrorProvider
    Protected requiredMessage As String = "This field is required"
    Private isEditingChild As Boolean = False
    Private childId As Integer = 0
    Private isEditing As Boolean = False
    Private employeeId As Integer = 0

    Private dgvRow As DataGridViewRow

    Public Sub isRequiredSpouse(ByVal civilStatus As String)
        If civilStatus <> "Single" Then
            Me.requireSpouse = True
            Me.gbSpouse.Visible = True
        Else
            Me.requireSpouse = False
            Me.gbSpouse.Visible = False
        End If
    End Sub

    Public Sub getData(ByVal employeeId As Integer)
        Me.employeeId = employeeId
        Me.isEditing = True
        Dim motherRow As DataSet1.familiesRow = familiesAdapter.GetDataByMother(employeeId).Rows(0)
        With motherRow
            txtLnameMother.Text = .Item("lname")
            txtFnameMother.Text = .Item("fname")
            txtMnameMother.Text = .Item("mname")
            If Not IsDBNull(.Item("suffix")) Then
                txtSuffixMother.Text = .Item("suffix")
            End If

        End With

        Dim fatherRow As DataSet1.familiesRow = familiesAdapter.GetDataByFather(employeeId).Rows(0)
        With fatherRow
            txtLnameFather.Text = .Item("lname")
            txtFnameFather.Text = .Item("fname")
            txtMnameFather.Text = .Item("mname")
            If Not IsDBNull(.Item("suffix")) Then
                txtSuffixFather.Text = .Item("suffix")
            End If
        End With

        If Me.requireSpouse = True Then
            Dim spouseRow As DataSet1.familiesRow = familiesAdapter.GetDataBySpouse(employeeId).Rows(0)
            With spouseRow
                txtLnameSpouse.Text = .Item("lname")
                txtFnameSpouse.Text = .Item("fname")
                txtMnameSpouse.Text = .Item("mname")
                If Not IsDBNull(.Item("suffix")) Then
                    txtSuffixSpouse.Text = .Item("suffix")
                End If
                txtOccupationSpouse.Text = .Item("occupation")
                txtBusinessAddress.Text = .Item("occupation_address")
                txtBusinessTel.Text = .Item("occupation_telephone_no")
            End With
        End If

        Dim childrensDataTable As DataSet1.familiesDataTable = familiesAdapter.GetDataByChildren(employeeId)
        dgvChildrens.Rows.Clear()
        For i = 0 To childrensDataTable.Rows.Count - 1
            With childrensDataTable.Rows(i)
                Dim row As String() = New String() { .Item("id"), .Item("lname"), .Item("fname"), .Item("mname"), CDate(.Item("dob")).ToLongDateString(), Nothing, Nothing}
                dgvChildrens.Rows.Add(row)
            End With
        Next

    End Sub

    Public Sub ResetInputs()
        txtBusinessAddress.Clear()
        txtBusinessTel.Clear()
        txtfnameChild.Clear()
        txtFnameFather.Clear()
        txtFnameMother.Clear()
        txtFnameSpouse.Clear()
        txtlnameChild.Clear()
        txtLnameFather.Clear()
        txtLnameMother.Clear()
        txtLnameSpouse.Clear()
        txtmnameChild.Clear()
        txtMnameFather.Clear()
        txtMnameMother.Clear()
        txtMnameSpouse.Clear()
        txtOccupationSpouse.Clear()
        txtSuffixFather.Clear()
        txtSuffixMother.Clear()
        txtSuffixSpouse.Clear()
        dgvChildrens.Rows.Clear()
        Me.childId = 0
        Me.isEditing = False
        Me.isEditingChild = False
    End Sub

    Private Sub onRemove(ByVal rowIndex As Integer)
        If Not dgvChildrens.Rows(rowIndex).Cells(0).Value Is Nothing Then
            Dim id As Integer = CInt(dgvChildrens.Rows(rowIndex).Cells(0).Value)
            familiesAdapter.DeleteQuery(id)
        End If
    End Sub

    Public Sub onSave(ByVal employeeId As Integer)
        'SAVE MOTHER INFORMATION
        familiesAdapter.InsertQuery(employeeId, 2, txtLnameMother.Text, txtFnameMother.Text, txtMnameMother.Text, txtSuffixMother.Text, Nothing, Nothing, Nothing, Nothing, Nothing)
        If Not txtLnameFather.Text Is Nothing And Not txtFnameFather.Text Is Nothing And Not txtMnameFather.Text Is Nothing Then
            'SAVE FATHER INFORMATION
            familiesAdapter.InsertQuery(employeeId, 1, txtLnameFather.Text, txtFnameFather.Text, txtMnameFather.Text, txtSuffixFather.Text, Nothing, Nothing, Nothing, Nothing, Nothing)
        End If
        If requireSpouse Then
            'SAVE SPOUSE INFORMATION
            familiesAdapter.InsertQuery(employeeId, 4, txtLnameSpouse.Text, txtFnameSpouse.Text, txtMnameSpouse.Text, txtSuffixSpouse.Text, Nothing, Nothing, txtOccupationSpouse.Text, txtBusinessAddress.Text, txtBusinessTel.Text)
        End If
        For Each row As DataGridViewRow In dgvChildrens.Rows
            With row
                If Not .Cells(0).Value Is Nothing Then
                    familiesAdapter.UpdateQuery(.Cells(1).Value, .Cells(2).Value, .Cells(3).Value, Nothing, CDate(.Cells(4).Value), Nothing, Nothing, Nothing, Nothing, CInt(.Cells(0).Value))
                Else
                    familiesAdapter.InsertQuery(employeeId, 3, .Cells(1).Value, .Cells(2).Value, .Cells(3).Value, Nothing, CDate(.Cells(4).Value), Nothing, Nothing, Nothing, Nothing)
                End If
            End With
        Next
    End Sub

    Private Sub getRow(ByVal rowIndex As Integer)
        Me.isEditingChild = True
        Me.dgvRow = dgvChildrens.Rows(rowIndex)
        With dgvRow
            txtlnameChild.Text = .Cells(1).Value.ToString()
            txtfnameChild.Text = .Cells(2).Value.ToString()
            txtmnameChild.Text = .Cells(3).Value.ToString()
            dtpdobChild.Value = CDate(.Cells(4).Value.ToString()).ToLongDateString()
        End With
    End Sub

    Public Sub showSpouseGroupBox(ByVal status As String)
        If status <> "Single" Then
            Me.gbSpouse.Visible = True
            Me.requireSpouse = True
        Else
            Me.gbSpouse.Visible = False
            Me.requireSpouse = False
        End If
    End Sub

    Public Function isValidInputs() As Boolean
        Dim result As Boolean = True
        If requireSpouse Then
            If txtLnameSpouse.Text = "" Then
                lnameSpouseErrorProvider.SetError(txtLnameSpouse, Me.requiredMessage)
                result = False
            End If
            If txtFnameSpouse.Text = "" Then
                fnameSpouseErrorProvider.SetError(txtFnameSpouse, Me.requiredMessage)
                result = False
            End If
            If txtMnameSpouse.Text = "" Then
                mnameSpouseErrorProvider.SetError(txtMnameSpouse, Me.requiredMessage)
                result = False
            End If
        End If
        If txtLnameMother.Text = "" Then
            lnameMotherErrorProvider.SetError(txtLnameMother, Me.requiredMessage)
            result = False
        End If
        If txtFnameMother.Text = "" Then
            fnameMotherErrorProvider.SetError(txtFnameMother, Me.requiredMessage)
            result = False
        End If
        If txtMnameMother.Text = "" Then
            mnameMotherErrorProvider.SetError(txtMnameMother, Me.requiredMessage)
            result = False
        End If

        If txtLnameFather.Text <> "" Or txtFnameFather.Text <> "" Or txtMnameFather.Text <> "" Then
            If txtLnameFather.Text = "" Then
                lnameFatherErrorProvider.SetError(txtLnameFather, "Please complete name")
                result = False
            End If
            If txtFnameFather.Text = "" Then
                fnameFatherErrorProvider.SetError(txtFnameFather, "Please complete name")
                result = False
            End If
            If txtMnameFather.Text = "" Then
                mnameFatherErrorProvider.SetError(txtMnameFather, "Please complete name")
                result = False
            End If
        End If

        Return result
    End Function

    Private Function validatedChildName() As Boolean
        Dim result As Boolean = True
        If txtlnameChild.Text = "" Then
            lnameChildErrorProvider.SetError(txtlnameChild, Me.requiredMessage)
            result = False
        End If
        If txtfnameChild.Text = "" Then
            fnameChildErrorProvider.SetError(txtfnameChild, Me.requiredMessage)
            result = False
        End If
        If txtmnameChild.Text = "" Then
            mnameChildErrorProvider.SetError(txtmnameChild, Me.requiredMessage)
            result = False
        End If
        If CDate(dtpdobChild.Value) > CDate(Now()) Then
            dobChildErrorProvider.SetError(dtpdobChild, "Invalid value")
            result = False
        End If
        Return result
    End Function

    Public Sub ResetChildInputs()
        txtlnameChild.Clear()
        txtfnameChild.Clear()
        txtmnameChild.Clear()
        dtpdobChild.Value = Now.ToLongDateString()
        Me.isEditingChild = False
        Me.childId = 0
        btnAdd.Text = "Add"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If validatedChildName() Then
            If Me.isEditingChild Then
                With dgvRow
                    .Cells(1).Value = txtlnameChild.Text
                    .Cells(2).Value = txtfnameChild.Text
                    .Cells(3).Value = txtmnameChild.Text
                    .Cells(4).Value = CDate(dtpdobChild.Value).ToLongDateString()
                End With
            Else
                Dim row As String() = New String() {Nothing, txtlnameChild.Text, txtfnameChild.Text, txtmnameChild.Text, CDate(dtpdobChild.Value).ToLongDateString(), Nothing, Nothing}
                dgvChildrens.Rows.Add(row)
            End If
            Me.ResetChildInputs()
        End If
    End Sub

    Private Sub dgvChildrens_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChildrens.CellContentClick
        If e.ColumnIndex = 5 Then
            btnAdd.Text = "Update"
            Me.getRow(e.RowIndex)
        End If
        If e.ColumnIndex = 6 Then
            If confirmDialog().DialogResult = DialogResult.Yes Then
                Me.onRemove(e.RowIndex)
                dgvChildrens.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub
End Class
