Public Class DialogSuccess
    Public Sub setMessage(ByVal strMessage As String)
        txtMessage.Text = strMessage
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class