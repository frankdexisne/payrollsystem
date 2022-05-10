Public Class PersonalData


    Protected employeesTableAdapter As New DataSet1TableAdapters.employeesTableAdapter
    Protected gendersAdapter As New DataSet1TableAdapters.gendersTableAdapter
    Protected statusesAdapter As New DataSet1TableAdapters.statusesTableAdapter
    Protected positionsAdapter As New DataSet1TableAdapters.positionsTableAdapter
    Protected departmentsAdapter As New DataSet1TableAdapters.departmentsTableAdapter
    Protected addressesAdapter As New DataSet1TableAdapters.addressesTableAdapter
    Protected ratesAdapater As New DataSet1TableAdapters.ratesTableAdapter


    Protected isEditing As Boolean = False
    Protected originalId As Integer = 0
    Public employeeId As Integer

    Protected requiredMessage As String = "This field is required"

    Protected employeeNoErrorProvider As New ErrorProvider
    Protected lNameErrorProvider As New ErrorProvider
    Protected fNameErrorProvider As New ErrorProvider
    Protected emailAddressErrorProvider As New ErrorProvider
    Protected mobileNumberErrorProvide As New ErrorProvider
    Protected dobErrorProvider As New ErrorProvider
    Protected placeOfBirthErrorProvider As New ErrorProvider

    Public civilStatus As String

    Public Sub getData(ByVal id As Integer, ByVal sender As Object, ByVal e As EventArgs)
        Me.isEditing = True
        Me.originalId = id
        Dim data As DataSet1.employeesRow = employeesTableAdapter.GetDataById(id).Rows(0)
        txtEmployeeNo.Text = data.Item("employee_no")
        txtlname.Text = data.Item("lname")
        txtfname.Text = data.Item("fname")
        txtmname.Text = data.Item("mname")
        txtsuffx.Text = data.Item("suffix")
        dtpdob.Value = CDate(data.Item("dob")).ToLongDateString()
        txtpob.Text = data.Item("pob")
        txtMobileNumber.Text = data.Item("contact_no")
        dtpDateHired.Value = CDate(data.Item("date_hired")).ToLongDateString()
        cboGender.SelectedValue = data.Item("gender_id")
        cboStatus.SelectedValue = data.Item("status_id")
        Me.civilStatus = cboStatus.Text
        cboDepartment.SelectedValue = data.Item("department_id")
        cboPosition.SelectedValue = data.Item("position_id")
        txtsss.Text = data.Item("sss_no")
        txthdmf.Text = data.Item("pagibig_no")
        txtphilhealth.Text = data.Item("philhealth_no")
        txttin.Text = data.Item("tin_no")
        Dim residential As DataSet1.addressesRow = addressesAdapter.GetDataByTypeAndEmployeeId("R", id).Rows(0)
        Me.ucAddressResidential.getData(residential.Item("barangay_id"), sender, e)
        Dim permanent As DataSet1.addressesRow = addressesAdapter.GetDataByTypeAndEmployeeId("P", id).Rows(0)
        Me.ucAddressPermanent.getData(permanent.Item("barangay_id"), sender, e)
        txtHourlyRate.Text = ratesAdapater.GetDataByEmployeeId(id).Rows(0).Item("hourly_rate")
    End Sub

    Public Sub loadData()
        With cboGender
            .DataSource = gendersAdapter.GetData()
            .DisplayMember = "name"
            .ValueMember = "id"
        End With
        With cboStatus
            .DataSource = statusesAdapter.GetData()
            .DisplayMember = "name"
            .ValueMember = "id"
        End With
        With cboDepartment
            .DataSource = departmentsAdapter.GetData()
            .DisplayMember = "name"
            .ValueMember = "id"
        End With
        With cboPosition
            .DataSource = positionsAdapter.GetData()
            .DisplayMember = "name"
            .ValueMember = "id"
        End With
        ucAddressResidential.loadData()
        ucAddressPermanent.loadData()
    End Sub

    Public Sub setEmployeeNo()
        txtEmployeeNo.Text = lastEmployeeNo()
        txtlname.Select()
    End Sub

    Public Function lastEmployeeNo() As String
        Dim employeeModel As New Employees
        With employeeModel
            Return employeeModel.getLastEmployeeNo()
        End With
    End Function

    Public Sub ResetInputs()
        txtEmployeeNo.Clear()
        txtlname.Clear()
        txtfname.Clear()
        txtmname.Clear()
        txtsuffx.Clear()
        cboStatus.SelectedIndex = 0
        cboGender.SelectedIndex = 0
        txtEmailAddress.Clear()
        txtMobileNumber.Clear()
        dtpdob.Value = CDate(Now).ToLongDateString()
        txtpob.Clear()
        ucAddressResidential.ResetInputs()
        ucAddressPermanent.ResetInputs()
    End Sub

    Public Function isValidInputs() As Boolean
        Dim result As Boolean = True
        If txtEmployeeNo.Text = String.Empty Then
            employeeNoErrorProvider.SetError(txtEmployeeNo, requiredMessage)
            result = False
        End If
        If txtfname.Text = String.Empty Then
            fNameErrorProvider.SetError(txtfname, requiredMessage)
            result = False
        End If
        If txtlname.Text = String.Empty Then
            lNameErrorProvider.SetError(txtlname, requiredMessage)
            result = False
        End If
        '
        'If txtmname.Text = String.Empty Then
        'mNameErrorProvider.SetError(txtmname, requiredMessage)
        'result = False
        'End If
        '
        If txtEmailAddress.Text = String.Empty Then
            emailAddressErrorProvider.SetError(txtEmailAddress, requiredMessage)
            result = False
        End If
        If CDate(dtpdob.Value) >= CDate(Now) Then
            dobErrorProvider.SetError(dtpdob, "Invalid value")
            result = False
        End If
        If txtpob.Text = String.Empty Then
            placeOfBirthErrorProvider.SetError(txtpob, requiredMessage)
            result = False
        End If
        If Not ucAddressPermanent.isValidInputs() Then
            result = False
        End If
        If Not ucAddressResidential.isValidInputs() Then
            result = False
        End If
        Return result
    End Function

    Public Function getEmployeeIdOnSave() As Integer
        Dim employeeModel As New Employees
        Dim employeeId As Integer
        With employeeModel
            employeeId = .insertQuery(txtEmployeeNo.Text, txtlname.Text, txtfname.Text, txtmname.Text, txtsuffx.Text, dtpdob.Value, txtpob.Text, txtEmailAddress.Text, txtMobileNumber.Text, dtpDateHired.Value, cboGender.SelectedValue, cboStatus.SelectedValue, cboDepartment.SelectedValue, cboPosition.SelectedValue, txtsss.Text, txthdmf.Text, txtphilhealth.Text, txttin.Text)
        End With
        ucAddressPermanent.onSave(employeeId, "P")
        ucAddressResidential.onSave(employeeId, "R")
        ratesAdapater.InsertQuery(employeeId, dtpDateHired.Value.ToString("yyyy-MM-dd"), txtHourlyRate.Text)
        Return employeeId
    End Function

    Public Sub onUpdate()

    End Sub

    Private Sub chkSameWithResidential_CheckedChanged(sender As Object, e As EventArgs) Handles chkSameWithResidential.CheckedChanged
        If chkSameWithResidential.Checked Then
            If Not ucAddressResidential.cboBarangay.SelectedValue Is Nothing Then
                With ucAddressPermanent
                    .getData(ucAddressResidential.cboBarangay.SelectedValue, sender, e)
                    .txtStreet.Text = ucAddressResidential.txtStreet.Text
                    .txtOthers.Text = ucAddressResidential.txtOthers.Text
                    .Enabled = False
                End With
            End If
        Else
            With ucAddressPermanent
                .ResetInputs()
                .Enabled = True
            End With
        End If
    End Sub

    Private Sub btnAddDepartment_Click(sender As Object, e As EventArgs) Handles btnAddDepartment.Click
        Dim departmentDialog As New Department
        departmentDialog.ShowDialog()
        If departmentDialog.DialogResult = DialogResult.OK Then
            With cboDepartment
                .DataSource = departmentsAdapter.GetData()
                .DisplayMember = "name"
                .ValueMember = "id"
            End With
        End If
    End Sub

    Private Sub btnAddPosition_Click(sender As Object, e As EventArgs) Handles btnAddPosition.Click
        Dim jobTitleDialog As New JobTitle
        jobTitleDialog.ShowDialog()
        If jobTitleDialog.DialogResult = DialogResult.OK Then
            With cboPosition
                .DataSource = positionsAdapter.GetData()
                .DisplayMember = "name"
                .ValueMember = "id"
            End With
        End If
    End Sub

    Private Sub chkOldEmployee_CheckedChanged(sender As Object, e As EventArgs) Handles chkOldEmployee.CheckedChanged
        With txtEmployeeNo
            If chkOldEmployee.Checked Then
                .Text = ""
                .Enabled = True
                .Select()
            Else
                .Text = lastEmployeeNo()
                .Enabled = False
                txtlname.Select()
            End If
        End With
    End Sub

    Private Sub PersonalData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
