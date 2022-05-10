Module DialogForm
    Public Function confirmDialog() As Form
        Dim dialog As New DialogConfirm()
        dialog.ShowDialog()
        Return dialog
    End Function



End Module
