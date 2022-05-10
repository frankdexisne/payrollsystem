Public Class NewPayroll
    Private Sub NewPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub loadData(ByVal cutoffId As Integer)
        Dim cutoffRow As DataSet1.cutoffsRow
        'TODO: This line of code loads data into the 'DataSet1.holidays' table. You can move, or remove it, as needed.
        Me.HolidaysTableAdapter.Fill(Me.DataSet1.holidays)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class