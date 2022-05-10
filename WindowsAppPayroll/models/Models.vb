Public Class Models

    Protected dbConn As New DBConnection

    Protected dateAndTime As DateAndTime

    Protected primaryKey As String = "id"

    Protected tableName As String

    Public Function deleteQuery(ByVal id As Integer) As Integer
        dbConn.strsql = "DELETE FROM " + Me.tableName + " WHERE " + Me.primaryKey + "='" + id + "'"
        Return dbConn.nonQuery()
    End Function

End Class
