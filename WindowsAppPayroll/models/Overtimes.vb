Public Class Overtimes
    Inherits Models
    Public Sub New()
        Me.tableName = "overtimes"
    End Sub

    Public Function insertQuery(ByVal employeeId As String, ByVal overtimeDate As String, ByVal startTime As String, ByVal endTime As String, ByVal renderedHours As String) As Integer
        dbConn.strsql = "INSERT INTO " + Me.tableName + " (employee_id,overtime_date, start_from, end_time, rendered_hours, is_approve, created_at, updated_at) VALUES('" + employeeId + "','" + overtimeDate + "','" + startTime + "','" + endTime + "','" + renderedHours + "',0, NOW(), NOW())"
        Return dbConn.nonQuery()
    End Function

    Public Function updateQuery(ByVal employeeId As String, ByVal overtimeDate As String, ByVal startTime As String, ByVal endTime As String, ByVal renderedHours As String, ByVal id As Integer) As Integer
        dbConn.strsql = "UPDATE " + Me.tableName + " SET overtime_date='" + overtimeDate + "',start_from='" + startTime + "',end_time='" + endTime + "',rendered_hours='" + renderedHours + "' WHERE " + Me.primaryKey + "='" + id.ToString() + "'"
        Return dbConn.nonQuery()
    End Function

    Public Function getById(ByVal overtimeId As Integer) As DataTable
        dbConn.strsql = "SELECT * FROM overtimes WHERE id='" + overtimeId.ToString() + "'"
        Return dbConn.Dtable
    End Function
End Class
