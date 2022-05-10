Imports System.Net.Http
Public Class PayrollWizard

    Protected cutoffId As Integer
    Protected cutoffAdapter As New DataSet1TableAdapters.cutoffs1TableAdapter
    Protected cutoffRow As DataSet1.cutoffs1Row
    Private Sub PayrollWizard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.loadComboBox()
    End Sub

    Public Sub loadHolidays(ByVal cutoffRow As DataSet1.cutoffs1Row)
        'TODO: This line of code loads data into the 'DataSet1.holidays' table. You can move, or remove it, as needed.
        Me.HolidaysTableAdapter.FillByCutoffRange(Me.DataSet1.holidays, cutoffRow.Item("from"), cutoffRow.Item("to"))
    End Sub

    Public Sub loadEmployeeLeaves(ByVal cutoffRow As DataSet1.cutoffs1Row)
        'TODO: This line of code loads data into the 'DataSet1.view_employee_leave_availments' table. You can move, or remove it, as needed.
        Me.View_employee_leave_availmentsTableAdapter.FillByCutoffRange(Me.DataSet1.view_employee_leave_availments, cutoffRow.Item("from"), cutoffRow.Item("to"))
    End Sub

    Public Sub loadComboBox()
        'TODO: This line of code loads data into the 'DataSet1.view_payroll_periods' table. You can move, or remove it, as needed.
        Me.View_payroll_periodsTableAdapter.Fill(Me.DataSet1.view_payroll_periods)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim dialogCutoff As New Cutoff
        With dialogCutoff
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                Me.cutoffId = dialogCutoff.cutoffId
                Me.cutoffRow = cutoffAdapter.GetDataById(Me.cutoffId).Rows(0)
                Me.loadComboBox()
                Me.loadEmployeeLeaves(Me.cutoffRow)
                Me.loadHolidays(Me.cutoffRow)
            End If
        End With
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.cutoffRow = cutoffAdapter.GetDataById(CInt(cboPayrollPeriod.SelectedValue)).Rows(0)
        Me.loadEmployeeLeaves(Me.cutoffRow)
        Me.loadHolidays(Me.cutoffRow)
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Me.Timer1.Enabled = True
        Process.Start("http://payroll-api.test:8080/api/process-payroll/" + CStr(cboPayrollPeriod.SelectedValue))
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Process.Start("http://payroll-api.test:8080/api/payroll-summary/" + CStr(cboPayrollPeriod.SelectedValue))
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAddHoliday_Click(sender As Object, e As EventArgs) Handles btnAddHoliday.Click
        Dim holidayForm As New Holiday
        With holidayForm
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                Me.loadHolidays(Me.cutoffRow)
            End If
        End With
    End Sub

    Private Sub cboPayrollPeriod_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPayrollPeriod.SelectedValueChanged
        If Not cboPayrollPeriod.SelectedValue Is Nothing Then
            cutoffRow = cutoffAdapter.GetDataById(CInt(cboPayrollPeriod.SelectedValue)).Rows(0)
        End If
    End Sub

    Private Sub btnAddLeave_Click(sender As Object, e As EventArgs) Handles btnAddLeave.Click
        Dim employeeList As New EmployeeList
        With employeeList
            .Show()
        End With
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Dim dialogForApprovalLeave As New ForApprovalLeaves
        With dialogForApprovalLeave
            .loadData(cboPayrollPeriod.SelectedValue)
            .ShowDialog()
        End With
    End Sub
End Class