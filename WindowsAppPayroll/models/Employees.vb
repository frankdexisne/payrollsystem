Public Class Employees
    Inherits Models
    Public Sub New()
        Me.tableName = "employees"
    End Sub

    Public Function insertQuery(ByVal employeeNo As String, ByVal lname As String, ByVal fname As String, ByVal mname As String, ByVal suffix As String, ByVal dob As Date, ByVal pob As String, ByVal email_address As String, ByVal contact_no As String, ByVal date_hired As Date, ByVal gender_id As Integer, ByVal status_id As Integer, ByVal deparment_id As Integer, ByVal position_id As Integer, ByVal sssNo As String, ByVal pagibigNo As String, ByVal philhealtNo As String, ByVal tinNo As String) As Integer
        dbConn.strsql = "INSERT INTO " + Me.tableName + " (employee_no,lname, fname, mname, suffix, dob, pob, email_address, contact_no, date_hired, gender_id, status_id, department_id, position_id,sss_no,pagibig_no,philhealth_no,tin_no, created_at, updated_at) VALUES('" + employeeNo + "','" + lname + "','" + fname + "','" + mname + "','" + suffix + "','" + dob.ToString("yyyy-MM-dd") + "','" + pob + "','" + email_address + "','" + contact_no + "','" + date_hired.ToString("yyyy-MM-dd") + "'," + CStr(gender_id) + "," + CStr(status_id) + "," + CStr(deparment_id) + "," + CStr(position_id) + ",'" + sssNo + "','" + pagibigNo + "','" + philhealtNo + "','" + tinNo + "', NOW(), NOW());SELECT last_insert_id() AS employee_id"
        Dim id As Integer = dbConn.getLastInsertedId()
        Return id
    End Function

    Public Function insertQuerySQL(ByVal employeeNo As String, ByVal lname As String, ByVal fname As String, ByVal mname As String, ByVal suffix As String, ByVal dob As Date, ByVal pob As String, ByVal email_address As String, ByVal contact_no As String, ByVal date_hired As Date, ByVal gender_id As Integer, ByVal status_id As Integer, ByVal deparment_id As Integer, ByVal position_id As Integer, ByVal sssNo As String, ByVal pagibigNo As String, ByVal philhealtNo As String, ByVal tinNo As String) As Integer
        Return "INSERT INTO " + Me.tableName + " (employee_no,lname, fname, mname, suffix, dob, pob, email_address, contact_no, date_hired, gender_id, status_id, department_id, position_id,sss_no,pagibig_no,philhealth_no,tin_no, created_at, updated_at) VALUES('" + employeeNo + "','" + lname + "','" + fname + "','" + mname + "','" + suffix + "','" + dob.ToString("yyyy-MM-dd") + "','" + pob + "','" + email_address + "','" + contact_no + "','" + date_hired.ToString("yyyy-MM-dd") + "'," + CStr(gender_id) + "," + CStr(status_id) + "," + CStr(deparment_id) + "," + CStr(position_id) + ",'" + sssNo + "','" + pagibigNo + "','" + philhealtNo + "','" + tinNo + "', NOW(), NOW())"
    End Function

    Public Function updateQuery(ByVal id As Integer, ByVal lname As String, ByVal fname As String, ByVal mname As String, ByVal email_address As String, ByVal contact_no As String, ByVal date_hired As Date, ByVal gender_id As Integer, ByVal deparment_id As Integer, ByVal position_id As Integer) As Integer
        dbConn.strsql = "UPDATE " + Me.tableName + " SET lname='" + lname + "',fname='" + fname + "',mname='" + mname + "',emaill_address='" + email_address + "',contact_no='" + contact_no + "',date_hired='" + date_hired.ToString("yyyy-MM-dd") + "',gender_id='" + gender_id + "',department_id='" + deparment_id + "',position_id='" + position_id + "' WHERE " + Me.primaryKey + "='" + id + "'"
        Return dbConn.nonQuery()
    End Function

    Public Function markAsResigned(ByVal id As Integer, ByVal resignDate As String) As Integer
        dbConn.strsql = "UPDATE " + Me.tableName + " SET date_resigned='" + CStr(resignDate) + "' WHERE " + Me.primaryKey + "='" + id + "'"
        Return dbConn.nonQuery()
    End Function


    Public Function getLastEmployeeNo() As String
        dbConn.strsql = "SELECT RIGHT(employee_no, 3) AS last_employee_no FROM employees ORDER BY id DESC LIMIT 1"
        If dbConn.Dtable.Rows.Count() = 0 Then
            Return "AKB-" + CDate(Now).ToString("yyyy") + "-001"
        Else
            Dim lastInsertedEmpNo As String = dbConn.Dtable.Rows(0).Item("last_employee_no").ToString()
            Dim newEmployeeNo As String = (Val(lastInsertedEmpNo) + 1).ToString
            Dim finalEmployeeNo As String = ""
            For i = 0 To newEmployeeNo.Length - 1
                finalEmployeeNo = finalEmployeeNo + "0"
            Next
            finalEmployeeNo = finalEmployeeNo + newEmployeeNo
            Return "AKB-" + CDate(Now).ToString("yyyy") + "-" + finalEmployeeNo
        End If

    End Function

    Public Function todayAttend() As Integer
        dbConn.strsql = "SELECT COUNT(attends.id) AS total FROM attends INNER JOIN employees ON attends.employee_id = employees.id WHERE employees.date_resigned IS NULL AND attend_date = DATE(NOW()) GROUP BY attends.employee_id"
        If dbConn.Dtable.Rows.Count = 0 Then
            Return 0
        End If
        Return dbConn.Dtable.Rows(0).Item("total")
    End Function

    Public Function todayUndertime() As Integer
        dbConn.strsql = "SELECT COUNT(undertimes.id) AS total FROM undertimes INNER JOIN employees ON undertimes.employee_id = employees.id WHERE employees.date_resigned IS NULL AND date_commited = DATE(NOW()) GROUP BY employee_id"
        If dbConn.Dtable.Rows.Count = 0 Then
            Return 0
        End If
        Return dbConn.Dtable.Rows(0).Item("total")
    End Function

    Public Function todayLate() As Integer
        dbConn.strsql = "SELECT COUNT(tardies.id) AS total FROM tardies INNER JOIN employees ON tardies.employee_id = employees.id WHERE employees.date_resigned IS NULL AND date_commited = DATE(NOW()) GROUP BY employee_id"
        If dbConn.Dtable.Rows.Count = 0 Then
            Return 0
        End If
        Return dbConn.Dtable.Rows(0).Item("total")
    End Function



End Class
