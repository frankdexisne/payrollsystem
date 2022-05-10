<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Holiday
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.txtName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.dtpHolidayDate = New MetroFramework.Controls.MetroDateTime()
        Me.chkRegularHoliday = New MetroFramework.Controls.MetroCheckBox()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(232, 256)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(138, 31)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseSelectable = True
        '
        'txtName
        '
        '
        '
        '
        Me.txtName.CustomButton.Image = Nothing
        Me.txtName.CustomButton.Location = New System.Drawing.Point(319, 2)
        Me.txtName.CustomButton.Name = ""
        Me.txtName.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtName.CustomButton.TabIndex = 1
        Me.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtName.CustomButton.UseSelectable = True
        Me.txtName.CustomButton.Visible = False
        Me.txtName.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtName.Lines = New String(-1) {}
        Me.txtName.Location = New System.Drawing.Point(23, 98)
        Me.txtName.MaxLength = 32767
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtName.SelectedText = ""
        Me.txtName.SelectionLength = 0
        Me.txtName.SelectionStart = 0
        Me.txtName.ShortcutsEnabled = True
        Me.txtName.Size = New System.Drawing.Size(347, 30)
        Me.txtName.TabIndex = 10
        Me.txtName.UseSelectable = True
        Me.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 70)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(140, 25)
        Me.MetroLabel1.TabIndex = 12
        Me.MetroLabel1.Text = "Name of Holiday"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 131)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(47, 25)
        Me.MetroLabel2.TabIndex = 13
        Me.MetroLabel2.Text = "Date"
        '
        'dtpHolidayDate
        '
        Me.dtpHolidayDate.FontSize = MetroFramework.MetroDateTimeSize.Tall
        Me.dtpHolidayDate.Location = New System.Drawing.Point(23, 159)
        Me.dtpHolidayDate.MinimumSize = New System.Drawing.Size(0, 35)
        Me.dtpHolidayDate.Name = "dtpHolidayDate"
        Me.dtpHolidayDate.Size = New System.Drawing.Size(347, 35)
        Me.dtpHolidayDate.TabIndex = 14
        '
        'chkRegularHoliday
        '
        Me.chkRegularHoliday.AutoSize = True
        Me.chkRegularHoliday.Location = New System.Drawing.Point(23, 211)
        Me.chkRegularHoliday.Name = "chkRegularHoliday"
        Me.chkRegularHoliday.Size = New System.Drawing.Size(107, 15)
        Me.chkRegularHoliday.TabIndex = 15
        Me.chkRegularHoliday.Text = "Regular Holiday"
        Me.chkRegularHoliday.UseSelectable = True
        '
        'Holiday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 310)
        Me.Controls.Add(Me.chkRegularHoliday)
        Me.Controls.Add(Me.dtpHolidayDate)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtName)
        Me.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Holiday"
        Me.Text = "Holiday"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents txtName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpHolidayDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents chkRegularHoliday As MetroFramework.Controls.MetroCheckBox
End Class
