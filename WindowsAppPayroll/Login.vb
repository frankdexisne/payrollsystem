Imports System.Net.Mail

Public Class Login
    Dim isAuthenticated As Boolean = False
    Private strConvert As New StringConvert
    Sub ClearForm()
        txtusername.Clear()
        txtPassword.Clear()
        txtusername.Select()
    End Sub

    Private Function InputValidation() As Boolean
        Dim usernameErrorProvider As New ErrorProvider
        Dim passwordErrorProvider As New ErrorProvider

        Dim result As Boolean = True
        If txtusername.Text.ToString() = "" Then
            usernameErrorProvider.SetError(txtusername, "Please provide username")
            result = False
        End If
        If txtPassword.Text.ToString() = "" Then
            passwordErrorProvider.SetError(txtPassword, "Please provide password")
            result = False
        End If
        Return result
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If InputValidation() And Not bgwLogin.IsBusy Then
            bgwLogin.RunWorkerAsync()
        End If
    End Sub

    Private Sub bgwLogin_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwLogin.DoWork
        Dim tableAdapter As New DataSet1TableAdapters.usersTableAdapter
        Dim loginQuery = tableAdapter.loginQuery(txtusername.Text.ToString(), strConvert.encrypt(txtPassword.Text.ToString()))

        If loginQuery Then
            authenticatedUser = tableAdapter.GetData.Rows(0)
            isAuthenticated = True
        Else
            isAuthenticated = False
        End If
    End Sub

    Private Sub bgwLogin_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwLogin.RunWorkerCompleted
        If isAuthenticated Then
            Me.Hide()
            MainForm.Show()
        Else
            MsgBox("Invalid email and password")
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ClearForm()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub
End Class