<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employee
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
        Me.btnPrevious = New MetroFramework.Controls.MetroButton()
        Me.btnNext = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.PersonalData1 = New WindowsAppPayroll.PersonalData()
        Me.EducationalBackground1 = New WindowsAppPayroll.EducationalBackground()
        Me.FamilyBackground1 = New WindowsAppPayroll.FamilyBackground()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPrevious
        '
        Me.btnPrevious.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrevious.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnPrevious.Location = New System.Drawing.Point(24, 1016)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(105, 30)
        Me.btnPrevious.TabIndex = 1
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseSelectable = True
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNext.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnNext.Location = New System.Drawing.Point(135, 1016)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(105, 30)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Next"
        Me.btnNext.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.PersonalData1)
        Me.MetroPanel1.Controls.Add(Me.EducationalBackground1)
        Me.MetroPanel1.Controls.Add(Me.FamilyBackground1)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(24, 63)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1274, 933)
        Me.MetroPanel1.TabIndex = 3
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'PersonalData1
        '
        Me.PersonalData1.BackColor = System.Drawing.Color.White
        Me.PersonalData1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PersonalData1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonalData1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PersonalData1.Location = New System.Drawing.Point(0, 0)
        Me.PersonalData1.Margin = New System.Windows.Forms.Padding(4)
        Me.PersonalData1.Name = "PersonalData1"
        Me.PersonalData1.Size = New System.Drawing.Size(1274, 933)
        Me.PersonalData1.TabIndex = 4
        '
        'EducationalBackground1
        '
        Me.EducationalBackground1.BackColor = System.Drawing.Color.White
        Me.EducationalBackground1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EducationalBackground1.Location = New System.Drawing.Point(0, 0)
        Me.EducationalBackground1.Name = "EducationalBackground1"
        Me.EducationalBackground1.Size = New System.Drawing.Size(1274, 933)
        Me.EducationalBackground1.TabIndex = 3
        '
        'FamilyBackground1
        '
        Me.FamilyBackground1.BackColor = System.Drawing.Color.White
        Me.FamilyBackground1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FamilyBackground1.Location = New System.Drawing.Point(0, 0)
        Me.FamilyBackground1.Name = "FamilyBackground1"
        Me.FamilyBackground1.Size = New System.Drawing.Size(1274, 933)
        Me.FamilyBackground1.TabIndex = 2
        Me.FamilyBackground1.Visible = False
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 1101)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Name = "Employee"
        Me.Text = "Employee"
        Me.MetroPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPrevious As MetroFramework.Controls.MetroButton
    Friend WithEvents btnNext As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents PersonalData1 As PersonalData
    Friend WithEvents EducationalBackground1 As EducationalBackground
    Friend WithEvents FamilyBackground1 As FamilyBackground
End Class
