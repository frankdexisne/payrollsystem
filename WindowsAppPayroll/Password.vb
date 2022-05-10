Public Class Password
    Private usersAdapater As New DataSet1TableAdapters.usersTableAdapter
    Private strConvert As New StringConvert
    Private passwordErrorProvider As New ErrorProvider
    Private newPasswordErrorProvider As New ErrorProvider
    Private confirmPasswordErrorProvider As New ErrorProvider
    Private originalId As Integer = 0

    Public Sub SetId(ByVal id As Integer)
        Me.originalId = id
    End Sub

    Sub ClearForm()
        txtPassword.Clear()
        txtNewPassword.Clear()
        txtConfirmPassword.Clear()
        passwordErrorProvider.Clear()
        newPasswordErrorProvider.Clear()
        confirmPasswordErrorProvider.Clear()
    End Sub

    Private Function InputValidation() As Boolean
        Dim result As Boolean = True
        If txtPassword.Text = "" Then
            passwordErrorProvider.SetError(txtPassword, "Password is required")
            result = False
        End If

        If txtNewPassword.Text = "" Then
            newPasswordErrorProvider.SetError(txtNewPassword, "New Password is required")
            result = False
        End If

        If txtConfirmPassword.Text = "" Then
            confirmPasswordErrorProvider.SetError(txtConfirmPassword, "Confirm Password is required")
            result = False
        End If

        If strConvert.encrypt(txtNewPassword.Text) = strConvert.encrypt(txtConfirmPassword.Text) Then
            newPasswordErrorProvider.SetError(txtNewPassword, "Mismatch password")
            confirmPasswordErrorProvider.SetError(txtConfirmPassword, "Mismatch password")
            result = False
        End If

        Return result
    End Function
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If InputValidation() Then
            usersAdapater.UpdatePasswordQuery(strConvert.encrypt(txtNewPassword.Text), Me.originalId)
            Me.ClearForm()
        End If
    End Sub
End Class