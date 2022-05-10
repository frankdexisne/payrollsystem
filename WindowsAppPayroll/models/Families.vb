Public Class Families
    Inherits Models
    Public Sub New()
        Me.tableName = "families"
    End Sub
    Public Function insertQuery(ByVal employeeId As Integer, ByVal relationshipId As Integer, ByVal lname As String, ByVal fname As String, ByVal mname As String, ByVal occupation As String, ByVal contact_no As String) As Integer
        dbConn.strsql = "INSERT INTO " + Me.tableName + " (employee_id, relationship_id, lname, fname, mname, occupation, contact_no, created_at, updated_at) VALUES('" + CStr(employeeId) + "','" + CStr(relationshipId) + "','" + lname + "','" + fname + "','" + mname + "','" + occupation + "','" + contact_no + "', NOW(), NOW());SELECT last_insert_id() AS family_id"
        Dim id As Integer = dbConn.getLastInsertedId()
        Return id
    End Function

    Public Function updateQuery(ByVal id As Integer, ByVal relationshipId As Integer, ByVal lname As String, ByVal fname As String, ByVal mname As String, ByVal occupation As String, ByVal contact_no As String) As Integer
        dbConn.strsql = "UPDATE " + Me.tableName + " SET relationship_id='" + relationshipId + "', lname='" + lname + "',fname='" + fname + "',mname='" + mname + "',occupation='" + occupation + "',contact_no='" + contact_no + "' updated_at=NOW() WHERE " + Me.primaryKey + "='" + id + "'"
        Return dbConn.nonQuery()
    End Function
End Class
