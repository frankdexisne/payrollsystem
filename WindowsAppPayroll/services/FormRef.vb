Public Class FormRef
    Public Sub displayModal(ByVal form As Form)
        form.StartPosition = FormStartPosition.CenterScreen
        form.ControlBox = True
        form.MinimizeBox = False
        form.MaximizeBox = False
        form.ShowDialog()
    End Sub

End Class
