Imports System.Net.Mail
Public Class Validation
    Public Function isEmail(ByVal strEmail As String) As Boolean
        Try
            Dim isValidEmailAddress As New MailAddress(strEmail)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    'ERROR FUNCTIONS
    Public Function isEmpty(ByVal inputValue As String) As Boolean
        Return inputValue = String.Empty Or inputValue Is Nothing
    End Function

    Public Function acceptNumericOnly(ByVal e As KeyPressEventArgs) As Boolean
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                Return True
            End If
        End If
        Return False
    End Function

End Class
