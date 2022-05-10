<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LeaveApplicationForm
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.dtpEnd = New MetroFramework.Controls.MetroDateTime()
        Me.dtpStart = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.cboLeave = New MetroFramework.Controls.MetroComboBox()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSave.Location = New System.Drawing.Point(356, 93)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 33)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "Save"
        Me.btnSave.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(30, 61)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(96, 19)
        Me.MetroLabel5.TabIndex = 27
        Me.MetroLabel5.Text = "Leave Duration"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(345, 61)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(21, 19)
        Me.MetroLabel4.TabIndex = 26
        Me.MetroLabel4.Text = "to"
        '
        'dtpEnd
        '
        Me.dtpEnd.Location = New System.Drawing.Point(367, 58)
        Me.dtpEnd.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(195, 29)
        Me.dtpEnd.TabIndex = 25
        '
        'dtpStart
        '
        Me.dtpStart.Location = New System.Drawing.Point(142, 58)
        Me.dtpStart.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(200, 29)
        Me.dtpStart.TabIndex = 24
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(28, 23)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel3.TabIndex = 23
        Me.MetroLabel3.Text = "Type of Leave"
        '
        'cboLeave
        '
        Me.cboLeave.DisplayMember = "name"
        Me.cboLeave.FormattingEnabled = True
        Me.cboLeave.ItemHeight = 23
        Me.cboLeave.Location = New System.Drawing.Point(142, 23)
        Me.cboLeave.Name = "cboLeave"
        Me.cboLeave.Size = New System.Drawing.Size(420, 29)
        Me.cboLeave.TabIndex = 22
        Me.cboLeave.UseSelectable = True
        Me.cboLeave.ValueMember = "id"
        '
        'btnCancel
        '
        Me.btnCancel.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnCancel.Location = New System.Drawing.Point(462, 93)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 33)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseSelectable = True
        '
        'LeaveApplicationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.dtpStart)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.cboLeave)
        Me.Name = "LeaveApplicationForm"
        Me.Size = New System.Drawing.Size(586, 142)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpEnd As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtpStart As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboLeave As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
End Class
