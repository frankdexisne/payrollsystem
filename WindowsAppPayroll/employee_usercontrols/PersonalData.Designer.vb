<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PersonalData
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ucAddressResidential = New WindowsAppPayroll.userControlAddress()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ucAddressPermanent = New WindowsAppPayroll.userControlAddress()
        Me.txtlname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtfname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtmname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtsuffx = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtEmailAddress = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txtMobileNumber = New MetroFramework.Controls.MetroTextBox()
        Me.cboStatus = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.cboGender = New MetroFramework.Controls.MetroComboBox()
        Me.dtpdob = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.txtpob = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.txtEmployeeNo = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.txttin = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.txtphilhealth = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.txthdmf = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.txtsss = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.cboPosition = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.cboDepartment = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.dtpDateHired = New MetroFramework.Controls.MetroDateTime()
        Me.chkSameWithResidential = New System.Windows.Forms.CheckBox()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.txtHourlyRate = New MetroFramework.Controls.MetroTextBox()
        Me.btnAddDepartment = New System.Windows.Forms.Button()
        Me.btnAddPosition = New System.Windows.Forms.Button()
        Me.chkOldEmployee = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ucAddressResidential)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 369)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 262)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Residential Address"
        '
        'ucAddressResidential
        '
        Me.ucAddressResidential.BackColor = System.Drawing.Color.White
        Me.ucAddressResidential.Location = New System.Drawing.Point(17, 32)
        Me.ucAddressResidential.Name = "ucAddressResidential"
        Me.ucAddressResidential.Size = New System.Drawing.Size(342, 216)
        Me.ucAddressResidential.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ucAddressPermanent)
        Me.GroupBox2.Location = New System.Drawing.Point(384, 369)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(365, 265)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Permanent Address"
        '
        'ucAddressPermanent
        '
        Me.ucAddressPermanent.BackColor = System.Drawing.Color.White
        Me.ucAddressPermanent.Location = New System.Drawing.Point(17, 22)
        Me.ucAddressPermanent.Name = "ucAddressPermanent"
        Me.ucAddressPermanent.Size = New System.Drawing.Size(342, 216)
        Me.ucAddressPermanent.TabIndex = 1
        '
        'txtlname
        '
        '
        '
        '
        Me.txtlname.CustomButton.Image = Nothing
        Me.txtlname.CustomButton.Location = New System.Drawing.Point(620, 1)
        Me.txtlname.CustomButton.Name = ""
        Me.txtlname.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtlname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtlname.CustomButton.TabIndex = 1
        Me.txtlname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtlname.CustomButton.UseSelectable = True
        Me.txtlname.CustomButton.Visible = False
        Me.txtlname.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtlname.Lines = New String(-1) {}
        Me.txtlname.Location = New System.Drawing.Point(103, 74)
        Me.txtlname.MaxLength = 32767
        Me.txtlname.Name = "txtlname"
        Me.txtlname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtlname.SelectedText = ""
        Me.txtlname.SelectionLength = 0
        Me.txtlname.SelectionStart = 0
        Me.txtlname.ShortcutsEnabled = True
        Me.txtlname.Size = New System.Drawing.Size(646, 27)
        Me.txtlname.TabIndex = 2
        Me.txtlname.UseSelectable = True
        Me.txtlname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtlname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(8, 74)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel1.TabIndex = 45
        Me.MetroLabel1.Text = "Surname"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(8, 107)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel2.TabIndex = 47
        Me.MetroLabel2.Text = "Firstname"
        '
        'txtfname
        '
        '
        '
        '
        Me.txtfname.CustomButton.Image = Nothing
        Me.txtfname.CustomButton.Location = New System.Drawing.Point(620, 1)
        Me.txtfname.CustomButton.Name = ""
        Me.txtfname.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtfname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtfname.CustomButton.TabIndex = 1
        Me.txtfname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtfname.CustomButton.UseSelectable = True
        Me.txtfname.CustomButton.Visible = False
        Me.txtfname.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtfname.Lines = New String(-1) {}
        Me.txtfname.Location = New System.Drawing.Point(103, 107)
        Me.txtfname.MaxLength = 32767
        Me.txtfname.Name = "txtfname"
        Me.txtfname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtfname.SelectedText = ""
        Me.txtfname.SelectionLength = 0
        Me.txtfname.SelectionStart = 0
        Me.txtfname.ShortcutsEnabled = True
        Me.txtfname.Size = New System.Drawing.Size(646, 27)
        Me.txtfname.TabIndex = 3
        Me.txtfname.UseSelectable = True
        Me.txtfname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtfname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(8, 140)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel3.TabIndex = 49
        Me.MetroLabel3.Text = "Middlename"
        '
        'txtmname
        '
        '
        '
        '
        Me.txtmname.CustomButton.Image = Nothing
        Me.txtmname.CustomButton.Location = New System.Drawing.Point(620, 1)
        Me.txtmname.CustomButton.Name = ""
        Me.txtmname.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtmname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtmname.CustomButton.TabIndex = 1
        Me.txtmname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtmname.CustomButton.UseSelectable = True
        Me.txtmname.CustomButton.Visible = False
        Me.txtmname.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtmname.Lines = New String(-1) {}
        Me.txtmname.Location = New System.Drawing.Point(103, 140)
        Me.txtmname.MaxLength = 32767
        Me.txtmname.Name = "txtmname"
        Me.txtmname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtmname.SelectedText = ""
        Me.txtmname.SelectionLength = 0
        Me.txtmname.SelectionStart = 0
        Me.txtmname.ShortcutsEnabled = True
        Me.txtmname.Size = New System.Drawing.Size(646, 27)
        Me.txtmname.TabIndex = 4
        Me.txtmname.UseSelectable = True
        Me.txtmname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtmname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(8, 173)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(40, 19)
        Me.MetroLabel4.TabIndex = 51
        Me.MetroLabel4.Text = "Suffix"
        '
        'txtsuffx
        '
        '
        '
        '
        Me.txtsuffx.CustomButton.Image = Nothing
        Me.txtsuffx.CustomButton.Location = New System.Drawing.Point(620, 1)
        Me.txtsuffx.CustomButton.Name = ""
        Me.txtsuffx.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtsuffx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsuffx.CustomButton.TabIndex = 1
        Me.txtsuffx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsuffx.CustomButton.UseSelectable = True
        Me.txtsuffx.CustomButton.Visible = False
        Me.txtsuffx.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtsuffx.Lines = New String(-1) {}
        Me.txtsuffx.Location = New System.Drawing.Point(103, 173)
        Me.txtsuffx.MaxLength = 32767
        Me.txtsuffx.Name = "txtsuffx"
        Me.txtsuffx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsuffx.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsuffx.SelectedText = ""
        Me.txtsuffx.SelectionLength = 0
        Me.txtsuffx.SelectionStart = 0
        Me.txtsuffx.ShortcutsEnabled = True
        Me.txtsuffx.Size = New System.Drawing.Size(646, 27)
        Me.txtsuffx.TabIndex = 5
        Me.txtsuffx.UseSelectable = True
        Me.txtsuffx.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsuffx.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(5, 301)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(92, 19)
        Me.MetroLabel5.TabIndex = 53
        Me.MetroLabel5.Text = "Email Address"
        '
        'txtEmailAddress
        '
        '
        '
        '
        Me.txtEmailAddress.CustomButton.Image = Nothing
        Me.txtEmailAddress.CustomButton.Location = New System.Drawing.Point(242, 1)
        Me.txtEmailAddress.CustomButton.Name = ""
        Me.txtEmailAddress.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtEmailAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmailAddress.CustomButton.TabIndex = 1
        Me.txtEmailAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmailAddress.CustomButton.UseSelectable = True
        Me.txtEmailAddress.CustomButton.Visible = False
        Me.txtEmailAddress.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtEmailAddress.Lines = New String(-1) {}
        Me.txtEmailAddress.Location = New System.Drawing.Point(112, 301)
        Me.txtEmailAddress.MaxLength = 32767
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmailAddress.SelectedText = ""
        Me.txtEmailAddress.SelectionLength = 0
        Me.txtEmailAddress.SelectionStart = 0
        Me.txtEmailAddress.ShortcutsEnabled = True
        Me.txtEmailAddress.Size = New System.Drawing.Size(268, 27)
        Me.txtEmailAddress.TabIndex = 10
        Me.txtEmailAddress.UseSelectable = True
        Me.txtEmailAddress.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmailAddress.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(385, 266)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(103, 19)
        Me.MetroLabel6.TabIndex = 55
        Me.MetroLabel6.Text = "Mobile Number"
        '
        'txtMobileNumber
        '
        '
        '
        '
        Me.txtMobileNumber.CustomButton.Image = Nothing
        Me.txtMobileNumber.CustomButton.Location = New System.Drawing.Point(228, 1)
        Me.txtMobileNumber.CustomButton.Name = ""
        Me.txtMobileNumber.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtMobileNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMobileNumber.CustomButton.TabIndex = 1
        Me.txtMobileNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMobileNumber.CustomButton.UseSelectable = True
        Me.txtMobileNumber.CustomButton.Visible = False
        Me.txtMobileNumber.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtMobileNumber.Lines = New String(-1) {}
        Me.txtMobileNumber.Location = New System.Drawing.Point(493, 266)
        Me.txtMobileNumber.MaxLength = 32767
        Me.txtMobileNumber.Name = "txtMobileNumber"
        Me.txtMobileNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMobileNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMobileNumber.SelectedText = ""
        Me.txtMobileNumber.SelectionLength = 0
        Me.txtMobileNumber.SelectionStart = 0
        Me.txtMobileNumber.ShortcutsEnabled = True
        Me.txtMobileNumber.Size = New System.Drawing.Size(256, 29)
        Me.txtMobileNumber.TabIndex = 9
        Me.txtMobileNumber.UseSelectable = True
        Me.txtMobileNumber.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMobileNumber.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.ItemHeight = 23
        Me.cboStatus.Location = New System.Drawing.Point(493, 231)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(256, 29)
        Me.cboStatus.TabIndex = 7
        Me.cboStatus.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(385, 231)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel7.TabIndex = 57
        Me.MetroLabel7.Text = "Civil Status"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(5, 231)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel8.TabIndex = 59
        Me.MetroLabel8.Text = "Gender"
        '
        'cboGender
        '
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.ItemHeight = 23
        Me.cboGender.Location = New System.Drawing.Point(110, 231)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(268, 29)
        Me.cboGender.TabIndex = 6
        Me.cboGender.UseSelectable = True
        '
        'dtpdob
        '
        Me.dtpdob.Location = New System.Drawing.Point(111, 266)
        Me.dtpdob.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpdob.Name = "dtpdob"
        Me.dtpdob.Size = New System.Drawing.Size(268, 29)
        Me.dtpdob.TabIndex = 8
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(5, 266)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel9.TabIndex = 61
        Me.MetroLabel9.Text = "Date of Birth"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(385, 301)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel10.TabIndex = 63
        Me.MetroLabel10.Text = "Place of Birth"
        '
        'txtpob
        '
        '
        '
        '
        Me.txtpob.CustomButton.Image = Nothing
        Me.txtpob.CustomButton.Location = New System.Drawing.Point(228, 1)
        Me.txtpob.CustomButton.Name = ""
        Me.txtpob.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtpob.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtpob.CustomButton.TabIndex = 1
        Me.txtpob.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtpob.CustomButton.UseSelectable = True
        Me.txtpob.CustomButton.Visible = False
        Me.txtpob.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtpob.Lines = New String(-1) {}
        Me.txtpob.Location = New System.Drawing.Point(493, 301)
        Me.txtpob.MaxLength = 32767
        Me.txtpob.Name = "txtpob"
        Me.txtpob.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpob.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpob.SelectedText = ""
        Me.txtpob.SelectionLength = 0
        Me.txtpob.SelectionStart = 0
        Me.txtpob.ShortcutsEnabled = True
        Me.txtpob.Size = New System.Drawing.Size(256, 29)
        Me.txtpob.TabIndex = 11
        Me.txtpob.UseSelectable = True
        Me.txtpob.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtpob.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(8, 41)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel11.TabIndex = 65
        Me.MetroLabel11.Text = "Employee No"
        '
        'txtEmployeeNo
        '
        '
        '
        '
        Me.txtEmployeeNo.CustomButton.Image = Nothing
        Me.txtEmployeeNo.CustomButton.Location = New System.Drawing.Point(480, 1)
        Me.txtEmployeeNo.CustomButton.Name = ""
        Me.txtEmployeeNo.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtEmployeeNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmployeeNo.CustomButton.TabIndex = 1
        Me.txtEmployeeNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmployeeNo.CustomButton.UseSelectable = True
        Me.txtEmployeeNo.CustomButton.Visible = False
        Me.txtEmployeeNo.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtEmployeeNo.Lines = New String(-1) {}
        Me.txtEmployeeNo.Location = New System.Drawing.Point(103, 41)
        Me.txtEmployeeNo.MaxLength = 32767
        Me.txtEmployeeNo.Name = "txtEmployeeNo"
        Me.txtEmployeeNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmployeeNo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmployeeNo.SelectedText = ""
        Me.txtEmployeeNo.SelectionLength = 0
        Me.txtEmployeeNo.SelectionStart = 0
        Me.txtEmployeeNo.ShortcutsEnabled = True
        Me.txtEmployeeNo.Size = New System.Drawing.Size(506, 27)
        Me.txtEmployeeNo.TabIndex = 1
        Me.txtEmployeeNo.UseSelectable = True
        Me.txtEmployeeNo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmployeeNo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(385, 677)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(29, 19)
        Me.MetroLabel12.TabIndex = 73
        Me.MetroLabel12.Text = "TIN"
        '
        'txttin
        '
        '
        '
        '
        Me.txttin.CustomButton.Image = Nothing
        Me.txttin.CustomButton.Location = New System.Drawing.Point(243, 1)
        Me.txttin.CustomButton.Name = ""
        Me.txttin.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txttin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txttin.CustomButton.TabIndex = 1
        Me.txttin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txttin.CustomButton.UseSelectable = True
        Me.txttin.CustomButton.Visible = False
        Me.txttin.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txttin.Lines = New String(-1) {}
        Me.txttin.Location = New System.Drawing.Point(480, 677)
        Me.txttin.MaxLength = 32767
        Me.txttin.Name = "txttin"
        Me.txttin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttin.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txttin.SelectedText = ""
        Me.txttin.SelectionLength = 0
        Me.txttin.SelectionStart = 0
        Me.txttin.ShortcutsEnabled = True
        Me.txttin.Size = New System.Drawing.Size(269, 27)
        Me.txttin.TabIndex = 15
        Me.txttin.UseSelectable = True
        Me.txttin.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txttin.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(385, 642)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel13.TabIndex = 71
        Me.MetroLabel13.Text = "Philhealth No"
        '
        'txtphilhealth
        '
        '
        '
        '
        Me.txtphilhealth.CustomButton.Image = Nothing
        Me.txtphilhealth.CustomButton.Location = New System.Drawing.Point(243, 1)
        Me.txtphilhealth.CustomButton.Name = ""
        Me.txtphilhealth.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtphilhealth.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtphilhealth.CustomButton.TabIndex = 1
        Me.txtphilhealth.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtphilhealth.CustomButton.UseSelectable = True
        Me.txtphilhealth.CustomButton.Visible = False
        Me.txtphilhealth.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtphilhealth.Lines = New String(-1) {}
        Me.txtphilhealth.Location = New System.Drawing.Point(480, 642)
        Me.txtphilhealth.MaxLength = 32767
        Me.txtphilhealth.Name = "txtphilhealth"
        Me.txtphilhealth.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtphilhealth.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtphilhealth.SelectedText = ""
        Me.txtphilhealth.SelectionLength = 0
        Me.txtphilhealth.SelectionStart = 0
        Me.txtphilhealth.ShortcutsEnabled = True
        Me.txtphilhealth.Size = New System.Drawing.Size(269, 27)
        Me.txtphilhealth.TabIndex = 13
        Me.txtphilhealth.UseSelectable = True
        Me.txtphilhealth.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtphilhealth.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(8, 677)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel14.TabIndex = 69
        Me.MetroLabel14.Text = "HDMF No"
        '
        'txthdmf
        '
        '
        '
        '
        Me.txthdmf.CustomButton.Image = Nothing
        Me.txthdmf.CustomButton.Location = New System.Drawing.Point(241, 1)
        Me.txthdmf.CustomButton.Name = ""
        Me.txthdmf.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txthdmf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txthdmf.CustomButton.TabIndex = 1
        Me.txthdmf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txthdmf.CustomButton.UseSelectable = True
        Me.txthdmf.CustomButton.Visible = False
        Me.txthdmf.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txthdmf.Lines = New String(-1) {}
        Me.txthdmf.Location = New System.Drawing.Point(103, 677)
        Me.txthdmf.MaxLength = 32767
        Me.txthdmf.Name = "txthdmf"
        Me.txthdmf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txthdmf.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txthdmf.SelectedText = ""
        Me.txthdmf.SelectionLength = 0
        Me.txthdmf.SelectionStart = 0
        Me.txthdmf.ShortcutsEnabled = True
        Me.txthdmf.Size = New System.Drawing.Size(267, 27)
        Me.txthdmf.TabIndex = 14
        Me.txthdmf.UseSelectable = True
        Me.txthdmf.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txthdmf.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(8, 642)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel15.TabIndex = 67
        Me.MetroLabel15.Text = "SSS No"
        '
        'txtsss
        '
        '
        '
        '
        Me.txtsss.CustomButton.Image = Nothing
        Me.txtsss.CustomButton.Location = New System.Drawing.Point(241, 1)
        Me.txtsss.CustomButton.Name = ""
        Me.txtsss.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtsss.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsss.CustomButton.TabIndex = 1
        Me.txtsss.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsss.CustomButton.UseSelectable = True
        Me.txtsss.CustomButton.Visible = False
        Me.txtsss.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtsss.Lines = New String(-1) {}
        Me.txtsss.Location = New System.Drawing.Point(103, 642)
        Me.txtsss.MaxLength = 32767
        Me.txtsss.Name = "txtsss"
        Me.txtsss.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsss.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsss.SelectedText = ""
        Me.txtsss.SelectionLength = 0
        Me.txtsss.SelectionStart = 0
        Me.txtsss.ShortcutsEnabled = True
        Me.txtsss.Size = New System.Drawing.Size(267, 27)
        Me.txtsss.TabIndex = 12
        Me.txtsss.UseSelectable = True
        Me.txtsss.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsss.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel16.Location = New System.Drawing.Point(5, 4)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(239, 25)
        Me.MetroLabel16.TabIndex = 74
        Me.MetroLabel16.Text = "PERSONAL INFORMATION"
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.Location = New System.Drawing.Point(6, 710)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel17.TabIndex = 78
        Me.MetroLabel17.Text = "Position"
        '
        'cboPosition
        '
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.ItemHeight = 23
        Me.cboPosition.Location = New System.Drawing.Point(103, 710)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(230, 29)
        Me.cboPosition.TabIndex = 16
        Me.cboPosition.UseSelectable = True
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.Location = New System.Drawing.Point(383, 710)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel18.TabIndex = 80
        Me.MetroLabel18.Text = "Department"
        '
        'cboDepartment
        '
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.ItemHeight = 23
        Me.cboDepartment.Location = New System.Drawing.Point(480, 710)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(234, 29)
        Me.cboDepartment.TabIndex = 17
        Me.cboDepartment.UseSelectable = True
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.Location = New System.Drawing.Point(5, 745)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel19.TabIndex = 82
        Me.MetroLabel19.Text = "Date Hired"
        '
        'dtpDateHired
        '
        Me.dtpDateHired.Location = New System.Drawing.Point(103, 745)
        Me.dtpDateHired.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpDateHired.Name = "dtpDateHired"
        Me.dtpDateHired.Size = New System.Drawing.Size(268, 29)
        Me.dtpDateHired.TabIndex = 18
        '
        'chkSameWithResidential
        '
        Me.chkSameWithResidential.AutoSize = True
        Me.chkSameWithResidential.Location = New System.Drawing.Point(560, 351)
        Me.chkSameWithResidential.Name = "chkSameWithResidential"
        Me.chkSameWithResidential.Size = New System.Drawing.Size(187, 23)
        Me.chkSameWithResidential.TabIndex = 83
        Me.chkSameWithResidential.Text = "Same with Residential"
        Me.chkSameWithResidential.UseVisualStyleBackColor = True
        '
        'MetroLabel20
        '
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.Location = New System.Drawing.Point(387, 747)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(77, 19)
        Me.MetroLabel20.TabIndex = 85
        Me.MetroLabel20.Text = "Hourly Rate"
        '
        'txtHourlyRate
        '
        '
        '
        '
        Me.txtHourlyRate.CustomButton.Image = Nothing
        Me.txtHourlyRate.CustomButton.Location = New System.Drawing.Point(241, 1)
        Me.txtHourlyRate.CustomButton.Name = ""
        Me.txtHourlyRate.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtHourlyRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtHourlyRate.CustomButton.TabIndex = 1
        Me.txtHourlyRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtHourlyRate.CustomButton.UseSelectable = True
        Me.txtHourlyRate.CustomButton.Visible = False
        Me.txtHourlyRate.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtHourlyRate.Lines = New String(-1) {}
        Me.txtHourlyRate.Location = New System.Drawing.Point(481, 747)
        Me.txtHourlyRate.MaxLength = 32767
        Me.txtHourlyRate.Name = "txtHourlyRate"
        Me.txtHourlyRate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHourlyRate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtHourlyRate.SelectedText = ""
        Me.txtHourlyRate.SelectionLength = 0
        Me.txtHourlyRate.SelectionStart = 0
        Me.txtHourlyRate.ShortcutsEnabled = True
        Me.txtHourlyRate.Size = New System.Drawing.Size(267, 27)
        Me.txtHourlyRate.TabIndex = 19
        Me.txtHourlyRate.UseSelectable = True
        Me.txtHourlyRate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtHourlyRate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnAddDepartment
        '
        Me.btnAddDepartment.Location = New System.Drawing.Point(714, 709)
        Me.btnAddDepartment.Name = "btnAddDepartment"
        Me.btnAddDepartment.Size = New System.Drawing.Size(35, 31)
        Me.btnAddDepartment.TabIndex = 86
        Me.btnAddDepartment.Text = "+"
        Me.btnAddDepartment.UseVisualStyleBackColor = True
        '
        'btnAddPosition
        '
        Me.btnAddPosition.Location = New System.Drawing.Point(333, 709)
        Me.btnAddPosition.Name = "btnAddPosition"
        Me.btnAddPosition.Size = New System.Drawing.Size(35, 31)
        Me.btnAddPosition.TabIndex = 87
        Me.btnAddPosition.Text = "+"
        Me.btnAddPosition.UseVisualStyleBackColor = True
        '
        'chkOldEmployee
        '
        Me.chkOldEmployee.AutoSize = True
        Me.chkOldEmployee.Location = New System.Drawing.Point(615, 45)
        Me.chkOldEmployee.Name = "chkOldEmployee"
        Me.chkOldEmployee.Size = New System.Drawing.Size(133, 23)
        Me.chkOldEmployee.TabIndex = 88
        Me.chkOldEmployee.Text = "Old Employee"
        Me.chkOldEmployee.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(63, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 19)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(70, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 19)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(74, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 19)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(157, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 19)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(153, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 19)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(93, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 19)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(471, 300)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 19)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "*"
        '
        'PersonalData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkOldEmployee)
        Me.Controls.Add(Me.btnAddPosition)
        Me.Controls.Add(Me.btnAddDepartment)
        Me.Controls.Add(Me.MetroLabel20)
        Me.Controls.Add(Me.txtHourlyRate)
        Me.Controls.Add(Me.chkSameWithResidential)
        Me.Controls.Add(Me.MetroLabel19)
        Me.Controls.Add(Me.dtpDateHired)
        Me.Controls.Add(Me.MetroLabel18)
        Me.Controls.Add(Me.cboDepartment)
        Me.Controls.Add(Me.MetroLabel17)
        Me.Controls.Add(Me.cboPosition)
        Me.Controls.Add(Me.MetroLabel16)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.txttin)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.txtphilhealth)
        Me.Controls.Add(Me.MetroLabel14)
        Me.Controls.Add(Me.txthdmf)
        Me.Controls.Add(Me.MetroLabel15)
        Me.Controls.Add(Me.txtsss)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.txtEmployeeNo)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.txtpob)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.dtpdob)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.txtMobileNumber)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.txtEmailAddress)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.txtsuffx)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtmname)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PersonalData"
        Me.Size = New System.Drawing.Size(777, 836)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtlname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtfname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtmname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtsuffx As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtEmailAddress As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMobileNumber As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cboStatus As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboGender As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dtpdob As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtpob As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtEmployeeNo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ucAddressResidential As userControlAddress
    Friend WithEvents ucAddressPermanent As userControlAddress
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txttin As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtphilhealth As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txthdmf As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtsss As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboPosition As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboDepartment As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpDateHired As MetroFramework.Controls.MetroDateTime
    Friend WithEvents chkSameWithResidential As CheckBox
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtHourlyRate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnAddDepartment As Button
    Friend WithEvents btnAddPosition As Button
    Friend WithEvents chkOldEmployee As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
