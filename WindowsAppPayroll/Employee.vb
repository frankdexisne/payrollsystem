Public Class Employee
    Protected currentIndex As Integer = 0
    Protected newIndex As Integer = 0
    Protected employeeNo As String
    Protected validateTabs As Boolean = False
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call
        Me.defaultSetup()
    End Sub

    Private Sub defaultSetup()
        Me.btnPrevious.Enabled = False
        Me.btnNext.Text = "Next"
        With PersonalData1
            .Visible = True
            .loadData()
        End With
        With EducationalBackground1
            .Visible = False
            .ResetInputs()
            .dgvEducationalBackground.Rows.Clear()
        End With

        With FamilyBackground1
            .Visible = False
            .ResetInputs()
            .dgvChildrens.Rows.Clear()
        End With
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If FamilyBackground1.Visible = True Then
            btnNext.Text = "Next"
            FamilyBackground1.Visible = False
            EducationalBackground1.Visible = True
        ElseIf EducationalBackground1.Visible = True Then
            EducationalBackground1.Visible = False
            PersonalData1.Visible = True
            btnPrevious.Enabled = False
        Else

        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If PersonalData1.Visible = True And PersonalData1.isValidInputs() Then
            PersonalData1.Visible = False
            EducationalBackground1.Visible = True
            btnPrevious.Enabled = True
            FamilyBackground1.isRequiredSpouse(PersonalData1.cboStatus.Text)
        ElseIf EducationalBackground1.Visible = True Then
            If EducationalBackground1.dgvEducationalBackground.Rows.Count > 0 Then
                EducationalBackground1.Visible = False
                FamilyBackground1.Visible = True
                btnNext.Text = "Submit"
            Else
                Dim dialogError As New DialogError
                With dialogError
                    .setMessage("Please provide educational background")
                    .ShowDialog()
                End With
            End If
        Else
            If FamilyBackground1.Visible = True And FamilyBackground1.isValidInputs() Then
                Dim employeeId As Integer = PersonalData1.getEmployeeIdOnSave()
                EducationalBackground1.onSaveEducationalBackground(employeeId)
                If FamilyBackground1.isValidInputs() Then
                    FamilyBackground1.onSave(employeeId)
                End If
                'Dim dialogSuccess As New DialogSuccess
                'dialogSuccess.ShowDialog()
                'If dialogSuccess.DialogResult = DialogResult.OK Then

                'End If

                Dim dialogConfirm As New DialogEmployee
                With dialogConfirm
                    .ShowDialog()
                    If .DialogResult = DialogResult.Yes Then
                        Me.defaultSetup()
                    Else
                        Me.Close()
                    End If
                End With
            End If
        End If
    End Sub


End Class