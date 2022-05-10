Public Class DialogConfirm
    Public Sub setQuestion(ByVal question As String)
        txtMessage.Text = question
    End Sub
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.DialogResult = DialogResult.No
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Me.DialogResult = DialogResult.Yes
    End Sub
End Class