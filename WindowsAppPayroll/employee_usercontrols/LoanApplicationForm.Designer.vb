<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoanApplicationForm
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
        Me.txtAmortization = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txtLoanAmount = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.dtpStartAt = New MetroFramework.Controls.MetroDateTime()
        Me.cboLoan = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtReferenceNumber = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSave.Location = New System.Drawing.Point(183, 197)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 30)
        Me.btnSave.TabIndex = 38
        Me.btnSave.Text = "Save"
        Me.btnSave.UseSelectable = True
        '
        'txtAmortization
        '
        '
        '
        '
        Me.txtAmortization.CustomButton.Image = Nothing
        Me.txtAmortization.CustomButton.Location = New System.Drawing.Point(230, 2)
        Me.txtAmortization.CustomButton.Name = ""
        Me.txtAmortization.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtAmortization.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAmortization.CustomButton.TabIndex = 1
        Me.txtAmortization.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAmortization.CustomButton.UseSelectable = True
        Me.txtAmortization.CustomButton.Visible = False
        Me.txtAmortization.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtAmortization.Lines = New String(-1) {}
        Me.txtAmortization.Location = New System.Drawing.Point(153, 161)
        Me.txtAmortization.MaxLength = 32767
        Me.txtAmortization.Name = "txtAmortization"
        Me.txtAmortization.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAmortization.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAmortization.SelectedText = ""
        Me.txtAmortization.SelectionLength = 0
        Me.txtAmortization.SelectionStart = 0
        Me.txtAmortization.ShortcutsEnabled = True
        Me.txtAmortization.Size = New System.Drawing.Size(258, 30)
        Me.txtAmortization.TabIndex = 37
        Me.txtAmortization.UseSelectable = True
        Me.txtAmortization.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAmortization.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(21, 161)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel6.TabIndex = 36
        Me.MetroLabel6.Text = "Amortization"
        '
        'txtLoanAmount
        '
        '
        '
        '
        Me.txtLoanAmount.CustomButton.Image = Nothing
        Me.txtLoanAmount.CustomButton.Location = New System.Drawing.Point(230, 2)
        Me.txtLoanAmount.CustomButton.Name = ""
        Me.txtLoanAmount.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtLoanAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLoanAmount.CustomButton.TabIndex = 1
        Me.txtLoanAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLoanAmount.CustomButton.UseSelectable = True
        Me.txtLoanAmount.CustomButton.Visible = False
        Me.txtLoanAmount.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtLoanAmount.Lines = New String(-1) {}
        Me.txtLoanAmount.Location = New System.Drawing.Point(153, 125)
        Me.txtLoanAmount.MaxLength = 32767
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLoanAmount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLoanAmount.SelectedText = ""
        Me.txtLoanAmount.SelectionLength = 0
        Me.txtLoanAmount.SelectionStart = 0
        Me.txtLoanAmount.ShortcutsEnabled = True
        Me.txtLoanAmount.Size = New System.Drawing.Size(258, 30)
        Me.txtLoanAmount.TabIndex = 35
        Me.txtLoanAmount.UseSelectable = True
        Me.txtLoanAmount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLoanAmount.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(21, 125)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(93, 19)
        Me.MetroLabel5.TabIndex = 34
        Me.MetroLabel5.Text = "Loan Amount"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(21, 90)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel4.TabIndex = 33
        Me.MetroLabel4.Text = "Start At"
        '
        'dtpStartAt
        '
        Me.dtpStartAt.Location = New System.Drawing.Point(153, 90)
        Me.dtpStartAt.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpStartAt.Name = "dtpStartAt"
        Me.dtpStartAt.Size = New System.Drawing.Size(258, 29)
        Me.dtpStartAt.TabIndex = 32
        '
        'cboLoan
        '
        Me.cboLoan.FormattingEnabled = True
        Me.cboLoan.ItemHeight = 23
        Me.cboLoan.Location = New System.Drawing.Point(153, 55)
        Me.cboLoan.Name = "cboLoan"
        Me.cboLoan.Size = New System.Drawing.Size(258, 29)
        Me.cboLoan.TabIndex = 31
        Me.cboLoan.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(21, 55)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel2.TabIndex = 30
        Me.MetroLabel2.Text = "Loan Type"
        '
        'txtReferenceNumber
        '
        '
        '
        '
        Me.txtReferenceNumber.CustomButton.Image = Nothing
        Me.txtReferenceNumber.CustomButton.Location = New System.Drawing.Point(230, 2)
        Me.txtReferenceNumber.CustomButton.Name = ""
        Me.txtReferenceNumber.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtReferenceNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtReferenceNumber.CustomButton.TabIndex = 1
        Me.txtReferenceNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtReferenceNumber.CustomButton.UseSelectable = True
        Me.txtReferenceNumber.CustomButton.Visible = False
        Me.txtReferenceNumber.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtReferenceNumber.Lines = New String(-1) {}
        Me.txtReferenceNumber.Location = New System.Drawing.Point(153, 19)
        Me.txtReferenceNumber.MaxLength = 32767
        Me.txtReferenceNumber.Name = "txtReferenceNumber"
        Me.txtReferenceNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReferenceNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtReferenceNumber.SelectedText = ""
        Me.txtReferenceNumber.SelectionLength = 0
        Me.txtReferenceNumber.SelectionStart = 0
        Me.txtReferenceNumber.ShortcutsEnabled = True
        Me.txtReferenceNumber.Size = New System.Drawing.Size(258, 30)
        Me.txtReferenceNumber.TabIndex = 29
        Me.txtReferenceNumber.UseSelectable = True
        Me.txtReferenceNumber.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtReferenceNumber.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(21, 19)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(122, 19)
        Me.MetroLabel1.TabIndex = 28
        Me.MetroLabel1.Text = "Reference Number"
        '
        'btnCancel
        '
        Me.btnCancel.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnCancel.Location = New System.Drawing.Point(300, 197)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(111, 30)
        Me.btnCancel.TabIndex = 39
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseSelectable = True
        '
        'LoanApplicationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtAmortization)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.txtLoanAmount)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.dtpStartAt)
        Me.Controls.Add(Me.cboLoan)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txtReferenceNumber)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "LoanApplicationForm"
        Me.Size = New System.Drawing.Size(437, 243)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents txtAmortization As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtLoanAmount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpStartAt As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cboLoan As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtReferenceNumber As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
End Class
