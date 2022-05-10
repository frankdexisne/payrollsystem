<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Department
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
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.txtName = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(229, 104)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(138, 31)
        Me.btnSave.TabIndex = 9
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
        Me.txtName.Location = New System.Drawing.Point(23, 63)
        Me.txtName.MaxLength = 32767
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtName.SelectedText = ""
        Me.txtName.SelectionLength = 0
        Me.txtName.SelectionStart = 0
        Me.txtName.ShortcutsEnabled = True
        Me.txtName.Size = New System.Drawing.Size(347, 30)
        Me.txtName.TabIndex = 8
        Me.txtName.UseSelectable = True
        Me.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Department
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 163)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Department"
        Me.Text = "Department"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents txtName As MetroFramework.Controls.MetroTextBox
End Class
