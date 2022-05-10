Module FormNavigation

    Public Sub onKeyDownTab(ByVal e As KeyEventArgs, ByVal control As Control)
        If e.KeyCode = Keys.Tab Then
            control.Select()
        End If
    End Sub

End Module
