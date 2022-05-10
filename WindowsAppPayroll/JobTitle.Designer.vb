<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobTitle
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
        Me.txtName = New MetroFramework.Controls.MetroTextBox()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtName
        '
        '
        '
        '
        Me.txtName.CustomButton.Image = Nothing
        Me.txtName.CustomButton.Location = New System.Drawing.Point(323, 2)
        Me.txtName.CustomButton.Name = ""
        Me.txtName.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtName.CustomButton.TabIndex = 1
        Me.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtName.CustomButton.UseSelectable = True
        Me.txtName.CustomButton.Visible = False
        Me.txtName.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtName.Lines = New String(-1) {}
        Me.txtName.Location = New System.Drawing.Point(13, 77)
        Me.txtName.MaxLength = 32767
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtName.SelectedText = ""
        Me.txtName.SelectionLength = 0
        Me.txtName.SelectionStart = 0
        Me.txtName.ShortcutsEnabled = True
        Me.txtName.Size = New System.Drawing.Size(351, 30)
        Me.txtName.TabIndex = 3
        Me.txtName.UseSelectable = True
        Me.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnSave
        '
        Me.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnSave.Location = New System.Drawing.Point(230, 115)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(134, 35)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseSelectable = True
        '
        'JobTitle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 169)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtName)
        Me.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "JobTitle"
        Me.Text = "New Job Title"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
End Class
