Public Class Cutoffs
    Inherits Models
    Public Sub New()
        Me.tableName = "cutoffs"
    End Sub
    Public Function insertQuery(ByVal year As Integer, ByVal month As String, ByVal payrollPeriod As String, ByVal dateFrom As Date, ByVal dateTo As Date, ByVal period As Integer, ByVal status As Integer) As Integer
        dbConn.strsql = "INSERT INTO " + Me.tableName + " (`year`, `month`, `payroll_period`, `from`, `to`, `period`, `status`, `created_at`, `updated_at`) VALUES('" + CStr(year) + "','" + month + "','" + payrollPeriod + "','" + dateFrom + "','" + dateTo + "','" + CStr(period) + "','" + CStr(status) + "', NOW(), NOW());SELECT last_insert_id() AS cutoff_id"
        Dim id As Integer = dbConn.getLastInsertedId()
        Return id
    End Function

    Public Function updateQuery(ByVal year As Integer, ByVal month As String, ByVal payrollPeriod As String, ByVal dateFrom As Date, ByVal dateTo As Date, ByVal period As Integer, ByVal originalId As Integer) As Integer
        dbConn.strsql = "UPDATE " + Me.tableName + " SET year = '" + CStr(year) + "', month ='" + month + "', payroll_period = '" + payrollPeriod + "', from = '" + dateFrom.ToString("yyyy-MM-dd") + "' , to = '" + dateTo.ToString("yyyy-MM-dd") + "' , period = '" + period + "', updated_at=NOW() WHERE id = '" + originalId + "'"
        Return dbConn.nonQuery()
    End Function

    Public Function exists(ByVal dateFrom As Date, ByVal dateTo As Date) As Integer
        dbConn.strsql = "SELECT id FROM `cutoffs` WHERE `from`='" + dateFrom.ToString("yyyy-MM-dd") + "' AND `to`='" + dateTo.ToString("yyyy-MM-dd") + "'"
        Return dbConn.Dtable.Rows.Count()
    End Function
End Class
