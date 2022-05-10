Public Class DateAndTime

    Public Function getMonthName(ByVal month As Integer) As String
        Dim monthNames() As String = {"January", "February", "March", "Äpril", "May", "June", "July", "August", "September", "October", "November", "December"}
        Return monthNames(month - 1)
    End Function

    Public Function toSQLDate(ByVal dt As Date) As String
        Return dt.ToString("yyyy-MM-dd")
    End Function

    Public Function toSQLDateTime(ByVal dt As Date) As String
        Return CDate(dt).ToString("yyyy-MM-dd HH:mm:ss")
    End Function

End Class
