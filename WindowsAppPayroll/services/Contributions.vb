Public Class Contributions
    Protected DBConn As New DBConnection
    Public Function computeSSS(ByVal grossIncome As Double) As Double
        If grossIncome >= 24750 Then
            Return 900
        End If
        DBConn.strsql = "SELECT * FROM ssses WHERE start_range >= '" + grossIncome + "' AND end_range<='" + grossIncome + "'"
        Return CDbl(DBConn.Dtable.Rows(0).Item("ee"))
    End Function

    Public Function computePhilHealth(ByVal grossIncome As Double) As Double
        Return grossIncome * 0.03
    End Function

    Public Function computePagibig(ByVal grossIncome As Double) As Double
        Return grossIncome * 0.02
    End Function

    Public Function computeTax(ByVal grossIncome As Double) As Double
        Return grossIncome
    End Function

End Class
