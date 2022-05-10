<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cutoff
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
        Me.dtpStart = New MetroFramework.Controls.MetroDateTime()
        Me.dtpEnd = New MetroFramework.Controls.MetroDateTime()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.cboPeriod = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.dtpYearMonth = New MetroFramework.Controls.MetroDateTime()
        Me.SuspendLayout()
        '
        'dtpStart
        '
        Me.dtpStart.Location = New System.Drawing.Point(21, 122)
        Me.dtpStart.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(200, 29)
        Me.dtpStart.TabIndex = 4
        '
        'dtpEnd
        '
        Me.dtpEnd.Location = New System.Drawing.Point(248, 122)
        Me.dtpEnd.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(200, 29)
        Me.dtpEnd.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(343, 164)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(108, 33)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(223, 127)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(21, 19)
        Me.MetroLabel1.TabIndex = 7
        Me.MetroLabel1.Text = "to"
        '
        'cboPeriod
        '
        Me.cboPeriod.FormattingEnabled = True
        Me.cboPeriod.ItemHeight = 23
        Me.cboPeriod.Items.AddRange(New Object() {"1-15", "16-end of moth"})
        Me.cboPeriod.Location = New System.Drawing.Point(248, 87)
        Me.cboPeriod.Name = "cboPeriod"
        Me.cboPeriod.Size = New System.Drawing.Size(200, 29)
        Me.cboPeriod.TabIndex = 2
        Me.cboPeriod.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(21, 62)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(90, 19)
        Me.MetroLabel2.TabIndex = 11
        Me.MetroLabel2.Text = "Payroll Period"
        '
        'dtpYearMonth
        '
        Me.dtpYearMonth.CustomFormat = "yyyy MM"
        Me.dtpYearMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYearMonth.Location = New System.Drawing.Point(23, 87)
        Me.dtpYearMonth.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpYearMonth.Name = "dtpYearMonth"
        Me.dtpYearMonth.Size = New System.Drawing.Size(198, 29)
        Me.dtpYearMonth.TabIndex = 12
        '
        'Cutoff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 214)
        Me.Controls.Add(Me.dtpYearMonth)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.cboPeriod)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.dtpStart)
        Me.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cutoff"
        Me.Text = "New Cutoff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpStart As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtpEnd As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboPeriod As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpYearMonth As MetroFramework.Controls.MetroDateTime
End Class
