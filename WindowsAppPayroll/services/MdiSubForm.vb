Public Class MdiSubForm
    Private parentForm As Form
    Public Sub New(ByVal form As Form)
        Me.parentForm = form
    End Sub

    Public Sub display(ByVal form As Form)
        form.MdiParent = Me.parentForm
        form.FormBorderStyle = FormBorderStyle.None
        form.MinimizeBox = False
        form.MaximizeBox = False
        form.WindowState = FormWindowState.Maximized
        form.ControlBox = True
        form.Show()
    End Sub

    Public Sub displayModal(ByVal form As Form)
        form.MdiParent = Me.parentForm
        form.StartPosition = FormStartPosition.CenterScreen
        form.ControlBox = True
        form.MinimizeBox = False
        form.MaximizeBox = False
        form.Show()
    End Sub

End Class
