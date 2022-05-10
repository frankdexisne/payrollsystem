Public Class LoanApplicationForm

    Public Event onSaveData()

    Protected employeeLoans As New DataSet1TableAdapters.employee_loansTableAdapter
    Protected loansAdapter As New DataSet1TableAdapters.loansTableAdapter
    Private validation As New Validation
    Private referenceErrorProvider As New ErrorProvider
    Private startAtErrorProvider As New ErrorProvider
    Private loanAmountErrorProvider As New ErrorProvider
    Private amortizationErrorProvider As New ErrorProvider
    Public employeeId As Integer
    Public isEditing As Boolean = False
    Public originalId As Integer

    Public Sub getData(ByVal id As Integer)
        Me.originalId = id
        Me.isEditing = True
        Dim data As DataSet1.employee_loansRow = employeeLoans.GetDataById(id).Rows(0)
        With data
            txtReferenceNumber.Text = .Item("reference_no")
            txtLoanAmount.Text = .Item("loan_amount")
            txtAmortization.Text = .Item("amortization")
            dtpStartAt.Value = .Item("start_at")
        End With
    End Sub

    Sub ClearForm()
        txtReferenceNumber.Clear()
        cboLoan.SelectedIndex = 0
        dtpStartAt.Value = Now.ToLongDateString()
        txtAmortization.Clear()
        txtLoanAmount.Clear()
        referenceErrorProvider.Clear()
        startAtErrorProvider.Clear()
        loanAmountErrorProvider.Clear()
        amortizationErrorProvider.Clear()
        Me.originalId = 0
        Me.isEditing = True
    End Sub

    Public Sub setEmployeeId(ByVal employeeId As Integer)
        Me.employeeId = employeeId
    End Sub

    Public Sub loadData()
        With cboLoan
            .DataSource = loansAdapter.GetData()
            .DisplayMember = "name"
            .ValueMember = "id"
        End With
    End Sub

    Private Function InputValidation() As Boolean
        Dim result As Boolean = True

        If txtReferenceNumber.Text.ToString() = "" Then
            referenceErrorProvider.SetError(txtReferenceNumber, "Please provide reference number")
            result = False
        End If

        If CDate(dtpStartAt.Value) < CDate(Now) Then
            startAtErrorProvider.SetError(dtpStartAt, "Start at date must be future date")
            result = False
        End If

        If txtLoanAmount.Text = "" Then
            loanAmountErrorProvider.SetError(txtLoanAmount, "Please provide loan amount")
            result = False
        End If

        If txtAmortization.Text = "" Then
            amortizationErrorProvider.SetError(txtAmortization, "Please provide amortization")
            result = False
        End If

        Return result
    End Function

    Private Sub txtLoanAmount_KeyPress(sender As Object, e As KeyPressEventArgs)
        If validation.acceptNumericOnly(e) Then
            loanAmountErrorProvider.SetError(txtLoanAmount, "Please enter numeric")
        Else
            loanAmountErrorProvider.Clear()
        End If
    End Sub

    Private Sub txtAmortization_KeyPress(sender As Object, e As KeyPressEventArgs)
        If validation.acceptNumericOnly(e) Then
            amortizationErrorProvider.SetError(txtAmortization, "Please enter numeric")
        Else
            amortizationErrorProvider.Clear()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If InputValidation() Then
            If Me.isEditing Then
                employeeLoans.UpdateQuery(Me.employeeId, cboLoan.SelectedValue, txtReferenceNumber.Text.ToString(), CDate(dtpStartAt.Value), CDbl(txtLoanAmount.Text), CDbl(txtAmortization.Text), Me.originalId)
            Else
                employeeLoans.InsertQuery(Me.employeeId, cboLoan.SelectedValue, txtReferenceNumber.Text.ToString(), CDate(dtpStartAt.Value), CDbl(txtLoanAmount.Text), CDbl(txtAmortization.Text), 0, txtLoanAmount.Text)
            End If
            Me.ClearForm()
            RaiseEvent onSaveData()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.ClearForm()
    End Sub
End Class
