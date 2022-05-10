Public Class Attends
    Private Sub Attends_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.today_attendance' table. You can move, or remove it, as needed.
        Me.Today_attendanceTableAdapter.Fill(Me.DataSet1.today_attendance)

    End Sub
End Class