<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OvertimeForm
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
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.dtpOvertimeDate = New MetroFramework.Controls.MetroDateTime()
        Me.dtpStartFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndTime = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(256, 71)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(22, 19)
        Me.MetroLabel3.TabIndex = 51
        Me.MetroLabel3.Text = "to"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(16, 67)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(124, 19)
        Me.MetroLabel1.TabIndex = 48
        Me.MetroLabel1.Text = "Overtime Duration"
        '
        'btnSave
        '
        Me.btnSave.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSave.Location = New System.Drawing.Point(272, 102)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(117, 30)
        Me.btnSave.TabIndex = 47
        Me.btnSave.Text = "Save"
        Me.btnSave.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(16, 32)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(99, 19)
        Me.MetroLabel4.TabIndex = 46
        Me.MetroLabel4.Text = "Overtime Date"
        '
        'dtpOvertimeDate
        '
        Me.dtpOvertimeDate.Location = New System.Drawing.Point(148, 32)
        Me.dtpOvertimeDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpOvertimeDate.Name = "dtpOvertimeDate"
        Me.dtpOvertimeDate.Size = New System.Drawing.Size(241, 29)
        Me.dtpOvertimeDate.TabIndex = 45
        '
        'dtpStartFrom
        '
        Me.dtpStartFrom.CalendarFont = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartFrom.CustomFormat = "hh:mm:ss"
        Me.dtpStartFrom.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStartFrom.Location = New System.Drawing.Point(146, 71)
        Me.dtpStartFrom.Name = "dtpStartFrom"
        Me.dtpStartFrom.ShowUpDown = True
        Me.dtpStartFrom.Size = New System.Drawing.Size(104, 23)
        Me.dtpStartFrom.TabIndex = 52
        '
        'dtpEndTime
        '
        Me.dtpEndTime.CalendarFont = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndTime.CustomFormat = "hh:mm:ss"
        Me.dtpEndTime.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEndTime.Location = New System.Drawing.Point(285, 71)
        Me.dtpEndTime.Name = "dtpEndTime"
        Me.dtpEndTime.ShowUpDown = True
        Me.dtpEndTime.Size = New System.Drawing.Size(104, 23)
        Me.dtpEndTime.TabIndex = 53
        '
        'OvertimeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.dtpEndTime)
        Me.Controls.Add(Me.dtpStartFrom)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.dtpOvertimeDate)
        Me.Name = "OvertimeForm"
        Me.Size = New System.Drawing.Size(412, 147)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpOvertimeDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtpStartFrom As DateTimePicker
    Friend WithEvents dtpEndTime As DateTimePicker
End Class
