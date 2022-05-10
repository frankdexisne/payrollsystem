<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResignForm
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dtpDateResigned = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnSu = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'dtpDateResigned
        '
        Me.dtpDateResigned.Location = New System.Drawing.Point(149, 76)
        Me.dtpDateResigned.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpDateResigned.Name = "dtpDateResigned"
        Me.dtpDateResigned.Size = New System.Drawing.Size(302, 29)
        Me.dtpDateResigned.TabIndex = 0
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 76)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(120, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Date of resignation"
        '
        'btnSu
        '
        Me.btnSu.Location = New System.Drawing.Point(352, 111)
        Me.btnSu.Name = "btnSu"
        Me.btnSu.Size = New System.Drawing.Size(99, 30)
        Me.btnSu.TabIndex = 2
        Me.btnSu.Text = "Submit"
        Me.btnSu.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 117)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(298, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Note: Clicking submit this employee unsearchable"
        '
        'ResignForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 176)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btnSu)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.dtpDateResigned)
        Me.Name = "ResignForm"
        Me.Text = "Mark As Resign"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpDateResigned As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSu As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
End Class
