<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FamilyBackground
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtLnameFather = New MetroFramework.Controls.MetroTextBox()
        Me.txtFnameFather = New MetroFramework.Controls.MetroTextBox()
        Me.txtMnameFather = New MetroFramework.Controls.MetroTextBox()
        Me.txtSuffixFather = New MetroFramework.Controls.MetroTextBox()
        Me.txtSuffixMother = New MetroFramework.Controls.MetroTextBox()
        Me.txtMnameMother = New MetroFramework.Controls.MetroTextBox()
        Me.txtFnameMother = New MetroFramework.Controls.MetroTextBox()
        Me.txtLnameMother = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.dtpdobChild = New MetroFramework.Controls.MetroDateTime()
        Me.txtmnameChild = New MetroFramework.Controls.MetroTextBox()
        Me.txtfnameChild = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtlnameChild = New MetroFramework.Controls.MetroTextBox()
        Me.dgvChildrens = New MetroFramework.Controls.MetroGrid()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_of_birth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.gbSpouse = New System.Windows.Forms.GroupBox()
        Me.txtBusinessTel = New MetroFramework.Controls.MetroTextBox()
        Me.txtBusinessAddress = New MetroFramework.Controls.MetroTextBox()
        Me.txtOccupationSpouse = New MetroFramework.Controls.MetroTextBox()
        Me.txtSuffixSpouse = New MetroFramework.Controls.MetroTextBox()
        Me.txtMnameSpouse = New MetroFramework.Controls.MetroTextBox()
        Me.txtFnameSpouse = New MetroFramework.Controls.MetroTextBox()
        Me.txtLnameSpouse = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvChildrens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSpouse.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(26, 36)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(206, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "FAMILY BACKGROUND"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(30, 78)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(116, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "FATHER'S NAME"
        '
        'txtLnameFather
        '
        '
        '
        '
        Me.txtLnameFather.CustomButton.Image = Nothing
        Me.txtLnameFather.CustomButton.Location = New System.Drawing.Point(162, 1)
        Me.txtLnameFather.CustomButton.Name = ""
        Me.txtLnameFather.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLnameFather.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLnameFather.CustomButton.TabIndex = 1
        Me.txtLnameFather.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLnameFather.CustomButton.UseSelectable = True
        Me.txtLnameFather.CustomButton.Visible = False
        Me.txtLnameFather.Lines = New String(-1) {}
        Me.txtLnameFather.Location = New System.Drawing.Point(33, 101)
        Me.txtLnameFather.MaxLength = 32767
        Me.txtLnameFather.Name = "txtLnameFather"
        Me.txtLnameFather.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLnameFather.WaterMark = "Surname"
        Me.txtLnameFather.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLnameFather.SelectedText = ""
        Me.txtLnameFather.SelectionLength = 0
        Me.txtLnameFather.SelectionStart = 0
        Me.txtLnameFather.ShortcutsEnabled = True
        Me.txtLnameFather.Size = New System.Drawing.Size(184, 23)
        Me.txtLnameFather.TabIndex = 2
        Me.txtLnameFather.UseSelectable = True
        Me.txtLnameFather.WaterMark = "Surname"
        Me.txtLnameFather.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLnameFather.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtFnameFather
        '
        '
        '
        '
        Me.txtFnameFather.CustomButton.Image = Nothing
        Me.txtFnameFather.CustomButton.Location = New System.Drawing.Point(159, 1)
        Me.txtFnameFather.CustomButton.Name = ""
        Me.txtFnameFather.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFnameFather.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFnameFather.CustomButton.TabIndex = 1
        Me.txtFnameFather.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFnameFather.CustomButton.UseSelectable = True
        Me.txtFnameFather.CustomButton.Visible = False
        Me.txtFnameFather.Lines = New String(-1) {}
        Me.txtFnameFather.Location = New System.Drawing.Point(238, 101)
        Me.txtFnameFather.MaxLength = 32767
        Me.txtFnameFather.Name = "txtFnameFather"
        Me.txtFnameFather.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFnameFather.WaterMark = "Firstname"
        Me.txtFnameFather.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFnameFather.SelectedText = ""
        Me.txtFnameFather.SelectionLength = 0
        Me.txtFnameFather.SelectionStart = 0
        Me.txtFnameFather.ShortcutsEnabled = True
        Me.txtFnameFather.Size = New System.Drawing.Size(181, 23)
        Me.txtFnameFather.TabIndex = 3
        Me.txtFnameFather.UseSelectable = True
        Me.txtFnameFather.WaterMark = "Firstname"
        Me.txtFnameFather.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFnameFather.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMnameFather
        '
        '
        '
        '
        Me.txtMnameFather.CustomButton.Image = Nothing
        Me.txtMnameFather.CustomButton.Location = New System.Drawing.Point(159, 1)
        Me.txtMnameFather.CustomButton.Name = ""
        Me.txtMnameFather.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMnameFather.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMnameFather.CustomButton.TabIndex = 1
        Me.txtMnameFather.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMnameFather.CustomButton.UseSelectable = True
        Me.txtMnameFather.CustomButton.Visible = False
        Me.txtMnameFather.Lines = New String(-1) {}
        Me.txtMnameFather.Location = New System.Drawing.Point(438, 101)
        Me.txtMnameFather.MaxLength = 32767
        Me.txtMnameFather.Name = "txtMnameFather"
        Me.txtMnameFather.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMnameFather.WaterMark = "Middlename"
        Me.txtMnameFather.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMnameFather.SelectedText = ""
        Me.txtMnameFather.SelectionLength = 0
        Me.txtMnameFather.SelectionStart = 0
        Me.txtMnameFather.ShortcutsEnabled = True
        Me.txtMnameFather.Size = New System.Drawing.Size(181, 23)
        Me.txtMnameFather.TabIndex = 4
        Me.txtMnameFather.UseSelectable = True
        Me.txtMnameFather.WaterMark = "Middlename"
        Me.txtMnameFather.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMnameFather.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSuffixFather
        '
        '
        '
        '
        Me.txtSuffixFather.CustomButton.Image = Nothing
        Me.txtSuffixFather.CustomButton.Location = New System.Drawing.Point(89, 1)
        Me.txtSuffixFather.CustomButton.Name = ""
        Me.txtSuffixFather.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSuffixFather.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSuffixFather.CustomButton.TabIndex = 1
        Me.txtSuffixFather.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSuffixFather.CustomButton.UseSelectable = True
        Me.txtSuffixFather.CustomButton.Visible = False
        Me.txtSuffixFather.Lines = New String(-1) {}
        Me.txtSuffixFather.Location = New System.Drawing.Point(642, 101)
        Me.txtSuffixFather.MaxLength = 32767
        Me.txtSuffixFather.Name = "txtSuffixFather"
        Me.txtSuffixFather.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSuffixFather.WaterMark = "Suffix"
        Me.txtSuffixFather.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSuffixFather.SelectedText = ""
        Me.txtSuffixFather.SelectionLength = 0
        Me.txtSuffixFather.SelectionStart = 0
        Me.txtSuffixFather.ShortcutsEnabled = True
        Me.txtSuffixFather.Size = New System.Drawing.Size(111, 23)
        Me.txtSuffixFather.TabIndex = 5
        Me.txtSuffixFather.UseSelectable = True
        Me.txtSuffixFather.WaterMark = "Suffix"
        Me.txtSuffixFather.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSuffixFather.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSuffixMother
        '
        '
        '
        '
        Me.txtSuffixMother.CustomButton.Image = Nothing
        Me.txtSuffixMother.CustomButton.Location = New System.Drawing.Point(89, 1)
        Me.txtSuffixMother.CustomButton.Name = ""
        Me.txtSuffixMother.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSuffixMother.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSuffixMother.CustomButton.TabIndex = 1
        Me.txtSuffixMother.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSuffixMother.CustomButton.UseSelectable = True
        Me.txtSuffixMother.CustomButton.Visible = False
        Me.txtSuffixMother.Lines = New String(-1) {}
        Me.txtSuffixMother.Location = New System.Drawing.Point(642, 158)
        Me.txtSuffixMother.MaxLength = 32767
        Me.txtSuffixMother.Name = "txtSuffixMother"
        Me.txtSuffixMother.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSuffixMother.WaterMark = "Suffix"
        Me.txtSuffixMother.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSuffixMother.SelectedText = ""
        Me.txtSuffixMother.SelectionLength = 0
        Me.txtSuffixMother.SelectionStart = 0
        Me.txtSuffixMother.ShortcutsEnabled = True
        Me.txtSuffixMother.Size = New System.Drawing.Size(111, 23)
        Me.txtSuffixMother.TabIndex = 10
        Me.txtSuffixMother.UseSelectable = True
        Me.txtSuffixMother.WaterMark = "Suffix"
        Me.txtSuffixMother.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSuffixMother.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMnameMother
        '
        '
        '
        '
        Me.txtMnameMother.CustomButton.Image = Nothing
        Me.txtMnameMother.CustomButton.Location = New System.Drawing.Point(159, 1)
        Me.txtMnameMother.CustomButton.Name = ""
        Me.txtMnameMother.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMnameMother.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMnameMother.CustomButton.TabIndex = 1
        Me.txtMnameMother.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMnameMother.CustomButton.UseSelectable = True
        Me.txtMnameMother.CustomButton.Visible = False
        Me.txtMnameMother.Lines = New String(-1) {}
        Me.txtMnameMother.Location = New System.Drawing.Point(438, 158)
        Me.txtMnameMother.MaxLength = 32767
        Me.txtMnameMother.Name = "txtMnameMother"
        Me.txtMnameMother.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMnameMother.WaterMark = "Middlename"
        Me.txtMnameMother.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMnameMother.SelectedText = ""
        Me.txtMnameMother.SelectionLength = 0
        Me.txtMnameMother.SelectionStart = 0
        Me.txtMnameMother.ShortcutsEnabled = True
        Me.txtMnameMother.Size = New System.Drawing.Size(181, 23)
        Me.txtMnameMother.TabIndex = 9
        Me.txtMnameMother.UseSelectable = True
        Me.txtMnameMother.WaterMark = "Middlename"
        Me.txtMnameMother.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMnameMother.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtFnameMother
        '
        '
        '
        '
        Me.txtFnameMother.CustomButton.Image = Nothing
        Me.txtFnameMother.CustomButton.Location = New System.Drawing.Point(159, 1)
        Me.txtFnameMother.CustomButton.Name = ""
        Me.txtFnameMother.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFnameMother.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFnameMother.CustomButton.TabIndex = 1
        Me.txtFnameMother.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFnameMother.CustomButton.UseSelectable = True
        Me.txtFnameMother.CustomButton.Visible = False
        Me.txtFnameMother.Lines = New String(-1) {}
        Me.txtFnameMother.Location = New System.Drawing.Point(238, 158)
        Me.txtFnameMother.MaxLength = 32767
        Me.txtFnameMother.Name = "txtFnameMother"
        Me.txtFnameMother.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFnameMother.WaterMark = "Firstname"
        Me.txtFnameMother.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFnameMother.SelectedText = ""
        Me.txtFnameMother.SelectionLength = 0
        Me.txtFnameMother.SelectionStart = 0
        Me.txtFnameMother.ShortcutsEnabled = True
        Me.txtFnameMother.Size = New System.Drawing.Size(181, 23)
        Me.txtFnameMother.TabIndex = 8
        Me.txtFnameMother.UseSelectable = True
        Me.txtFnameMother.WaterMark = "Firstname"
        Me.txtFnameMother.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFnameMother.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtLnameMother
        '
        '
        '
        '
        Me.txtLnameMother.CustomButton.Image = Nothing
        Me.txtLnameMother.CustomButton.Location = New System.Drawing.Point(162, 1)
        Me.txtLnameMother.CustomButton.Name = ""
        Me.txtLnameMother.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLnameMother.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLnameMother.CustomButton.TabIndex = 1
        Me.txtLnameMother.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLnameMother.CustomButton.UseSelectable = True
        Me.txtLnameMother.CustomButton.Visible = False
        Me.txtLnameMother.Lines = New String(-1) {}
        Me.txtLnameMother.Location = New System.Drawing.Point(33, 158)
        Me.txtLnameMother.MaxLength = 32767
        Me.txtLnameMother.Name = "txtLnameMother"
        Me.txtLnameMother.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLnameMother.WaterMark = "Surname"
        Me.txtLnameMother.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLnameMother.SelectedText = ""
        Me.txtLnameMother.SelectionLength = 0
        Me.txtLnameMother.SelectionStart = 0
        Me.txtLnameMother.ShortcutsEnabled = True
        Me.txtLnameMother.Size = New System.Drawing.Size(184, 23)
        Me.txtLnameMother.TabIndex = 7
        Me.txtLnameMother.UseSelectable = True
        Me.txtLnameMother.WaterMark = "Surname"
        Me.txtLnameMother.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLnameMother.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.Location = New System.Drawing.Point(30, 135)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(124, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "MOTHER'S NAME"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.dtpdobChild)
        Me.GroupBox1.Controls.Add(Me.txtmnameChild)
        Me.GroupBox1.Controls.Add(Me.txtfnameChild)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.txtlnameChild)
        Me.GroupBox1.Controls.Add(Me.dgvChildrens)
        Me.GroupBox1.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 207)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 226)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NAME OF CHILDREN"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(646, 193)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 23)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseSelectable = True
        '
        'dtpdobChild
        '
        Me.dtpdobChild.Location = New System.Drawing.Point(473, 158)
        Me.dtpdobChild.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpdobChild.Name = "dtpdobChild"
        Me.dtpdobChild.Size = New System.Drawing.Size(261, 29)
        Me.dtpdobChild.TabIndex = 17
        '
        'txtmnameChild
        '
        '
        '
        '
        Me.txtmnameChild.CustomButton.Image = Nothing
        Me.txtmnameChild.CustomButton.Location = New System.Drawing.Point(233, 2)
        Me.txtmnameChild.CustomButton.Name = ""
        Me.txtmnameChild.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtmnameChild.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtmnameChild.CustomButton.TabIndex = 1
        Me.txtmnameChild.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtmnameChild.CustomButton.UseSelectable = True
        Me.txtmnameChild.CustomButton.Visible = False
        Me.txtmnameChild.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtmnameChild.Lines = New String(-1) {}
        Me.txtmnameChild.Location = New System.Drawing.Point(473, 122)
        Me.txtmnameChild.MaxLength = 32767
        Me.txtmnameChild.Name = "txtmnameChild"
        Me.txtmnameChild.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmnameChild.WaterMark = "Middle name"
        Me.txtmnameChild.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtmnameChild.SelectedText = ""
        Me.txtmnameChild.SelectionLength = 0
        Me.txtmnameChild.SelectionStart = 0
        Me.txtmnameChild.ShortcutsEnabled = True
        Me.txtmnameChild.Size = New System.Drawing.Size(261, 30)
        Me.txtmnameChild.TabIndex = 16
        Me.txtmnameChild.UseSelectable = True
        Me.txtmnameChild.WaterMark = "Middle name"
        Me.txtmnameChild.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtmnameChild.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtfnameChild
        '
        '
        '
        '
        Me.txtfnameChild.CustomButton.Image = Nothing
        Me.txtfnameChild.CustomButton.Location = New System.Drawing.Point(233, 2)
        Me.txtfnameChild.CustomButton.Name = ""
        Me.txtfnameChild.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtfnameChild.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtfnameChild.CustomButton.TabIndex = 1
        Me.txtfnameChild.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtfnameChild.CustomButton.UseSelectable = True
        Me.txtfnameChild.CustomButton.Visible = False
        Me.txtfnameChild.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtfnameChild.Lines = New String(-1) {}
        Me.txtfnameChild.Location = New System.Drawing.Point(473, 87)
        Me.txtfnameChild.MaxLength = 32767
        Me.txtfnameChild.Name = "txtfnameChild"
        Me.txtfnameChild.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfnameChild.WaterMark = "Firstname"
        Me.txtfnameChild.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtfnameChild.SelectedText = ""
        Me.txtfnameChild.SelectionLength = 0
        Me.txtfnameChild.SelectionStart = 0
        Me.txtfnameChild.ShortcutsEnabled = True
        Me.txtfnameChild.Size = New System.Drawing.Size(261, 30)
        Me.txtfnameChild.TabIndex = 15
        Me.txtfnameChild.UseSelectable = True
        Me.txtfnameChild.WaterMark = "Firstname"
        Me.txtfnameChild.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtfnameChild.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.Location = New System.Drawing.Point(473, 25)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel4.TabIndex = 14
        Me.MetroLabel4.Text = "Name of Child"
        '
        'txtlnameChild
        '
        '
        '
        '
        Me.txtlnameChild.CustomButton.Image = Nothing
        Me.txtlnameChild.CustomButton.Location = New System.Drawing.Point(233, 2)
        Me.txtlnameChild.CustomButton.Name = ""
        Me.txtlnameChild.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtlnameChild.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtlnameChild.CustomButton.TabIndex = 1
        Me.txtlnameChild.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtlnameChild.CustomButton.UseSelectable = True
        Me.txtlnameChild.CustomButton.Visible = False
        Me.txtlnameChild.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtlnameChild.Lines = New String(-1) {}
        Me.txtlnameChild.Location = New System.Drawing.Point(473, 52)
        Me.txtlnameChild.MaxLength = 32767
        Me.txtlnameChild.Name = "txtlnameChild"
        Me.txtlnameChild.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlnameChild.WaterMark = "Lastname"
        Me.txtlnameChild.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtlnameChild.SelectedText = ""
        Me.txtlnameChild.SelectionLength = 0
        Me.txtlnameChild.SelectionStart = 0
        Me.txtlnameChild.ShortcutsEnabled = True
        Me.txtlnameChild.Size = New System.Drawing.Size(261, 30)
        Me.txtlnameChild.TabIndex = 13
        Me.txtlnameChild.UseSelectable = True
        Me.txtlnameChild.WaterMark = "Lastname"
        Me.txtlnameChild.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtlnameChild.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dgvChildrens
        '
        Me.dgvChildrens.AllowUserToAddRows = False
        Me.dgvChildrens.AllowUserToDeleteRows = False
        Me.dgvChildrens.AllowUserToResizeRows = False
        Me.dgvChildrens.BackgroundColor = System.Drawing.Color.White
        Me.dgvChildrens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvChildrens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvChildrens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvChildrens.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvChildrens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChildrens.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.lname, Me.fname, Me.mname, Me.date_of_birth, Me.edit, Me.delete})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvChildrens.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvChildrens.EnableHeadersVisualStyles = False
        Me.dgvChildrens.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvChildrens.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvChildrens.Location = New System.Drawing.Point(7, 23)
        Me.dgvChildrens.Name = "dgvChildrens"
        Me.dgvChildrens.ReadOnly = True
        Me.dgvChildrens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvChildrens.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvChildrens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvChildrens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvChildrens.Size = New System.Drawing.Size(458, 187)
        Me.dgvChildrens.TabIndex = 12
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'lname
        '
        Me.lname.HeaderText = "Lastname"
        Me.lname.Name = "lname"
        Me.lname.ReadOnly = True
        '
        'fname
        '
        Me.fname.HeaderText = "Firstname"
        Me.fname.Name = "fname"
        Me.fname.ReadOnly = True
        '
        'mname
        '
        Me.mname.HeaderText = "Middle Name"
        Me.mname.Name = "mname"
        Me.mname.ReadOnly = True
        '
        'date_of_birth
        '
        Me.date_of_birth.HeaderText = "Date of Birth"
        Me.date_of_birth.Name = "date_of_birth"
        Me.date_of_birth.ReadOnly = True
        '
        'edit
        '
        Me.edit.HeaderText = "Edit"
        Me.edit.Name = "edit"
        Me.edit.ReadOnly = True
        '
        'delete
        '
        Me.delete.HeaderText = "Delete"
        Me.delete.Name = "delete"
        Me.delete.ReadOnly = True
        '
        'gbSpouse
        '
        Me.gbSpouse.Controls.Add(Me.txtBusinessTel)
        Me.gbSpouse.Controls.Add(Me.txtBusinessAddress)
        Me.gbSpouse.Controls.Add(Me.txtOccupationSpouse)
        Me.gbSpouse.Controls.Add(Me.txtSuffixSpouse)
        Me.gbSpouse.Controls.Add(Me.txtMnameSpouse)
        Me.gbSpouse.Controls.Add(Me.txtFnameSpouse)
        Me.gbSpouse.Controls.Add(Me.txtLnameSpouse)
        Me.gbSpouse.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSpouse.Location = New System.Drawing.Point(26, 439)
        Me.gbSpouse.Name = "gbSpouse"
        Me.gbSpouse.Size = New System.Drawing.Size(761, 109)
        Me.gbSpouse.TabIndex = 13
        Me.gbSpouse.TabStop = False
        Me.gbSpouse.Text = "SPOUSE"
        '
        'txtBusinessTel
        '
        '
        '
        '
        Me.txtBusinessTel.CustomButton.Image = Nothing
        Me.txtBusinessTel.CustomButton.Location = New System.Drawing.Point(89, 1)
        Me.txtBusinessTel.CustomButton.Name = ""
        Me.txtBusinessTel.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBusinessTel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBusinessTel.CustomButton.TabIndex = 1
        Me.txtBusinessTel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBusinessTel.CustomButton.UseSelectable = True
        Me.txtBusinessTel.CustomButton.Visible = False
        Me.txtBusinessTel.Lines = New String(-1) {}
        Me.txtBusinessTel.Location = New System.Drawing.Point(616, 62)
        Me.txtBusinessTel.MaxLength = 32767
        Me.txtBusinessTel.Name = "txtBusinessTel"
        Me.txtBusinessTel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBusinessTel.WaterMark = "Telephone"
        Me.txtBusinessTel.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBusinessTel.SelectedText = ""
        Me.txtBusinessTel.SelectionLength = 0
        Me.txtBusinessTel.SelectionStart = 0
        Me.txtBusinessTel.ShortcutsEnabled = True
        Me.txtBusinessTel.Size = New System.Drawing.Size(111, 23)
        Me.txtBusinessTel.TabIndex = 12
        Me.txtBusinessTel.UseSelectable = True
        Me.txtBusinessTel.WaterMark = "Telephone"
        Me.txtBusinessTel.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBusinessTel.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBusinessAddress
        '
        '
        '
        '
        Me.txtBusinessAddress.CustomButton.Image = Nothing
        Me.txtBusinessAddress.CustomButton.Location = New System.Drawing.Point(359, 1)
        Me.txtBusinessAddress.CustomButton.Name = ""
        Me.txtBusinessAddress.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBusinessAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBusinessAddress.CustomButton.TabIndex = 1
        Me.txtBusinessAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBusinessAddress.CustomButton.UseSelectable = True
        Me.txtBusinessAddress.CustomButton.Visible = False
        Me.txtBusinessAddress.Lines = New String(-1) {}
        Me.txtBusinessAddress.Location = New System.Drawing.Point(212, 62)
        Me.txtBusinessAddress.MaxLength = 32767
        Me.txtBusinessAddress.Name = "txtBusinessAddress"
        Me.txtBusinessAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBusinessAddress.WaterMark = "Business Address"
        Me.txtBusinessAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBusinessAddress.SelectedText = ""
        Me.txtBusinessAddress.SelectionLength = 0
        Me.txtBusinessAddress.SelectionStart = 0
        Me.txtBusinessAddress.ShortcutsEnabled = True
        Me.txtBusinessAddress.Size = New System.Drawing.Size(381, 23)
        Me.txtBusinessAddress.TabIndex = 11
        Me.txtBusinessAddress.UseSelectable = True
        Me.txtBusinessAddress.WaterMark = "Business Address"
        Me.txtBusinessAddress.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBusinessAddress.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtOccupationSpouse
        '
        '
        '
        '
        Me.txtOccupationSpouse.CustomButton.Image = Nothing
        Me.txtOccupationSpouse.CustomButton.Location = New System.Drawing.Point(162, 1)
        Me.txtOccupationSpouse.CustomButton.Name = ""
        Me.txtOccupationSpouse.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtOccupationSpouse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtOccupationSpouse.CustomButton.TabIndex = 1
        Me.txtOccupationSpouse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtOccupationSpouse.CustomButton.UseSelectable = True
        Me.txtOccupationSpouse.CustomButton.Visible = False
        Me.txtOccupationSpouse.Lines = New String(-1) {}
        Me.txtOccupationSpouse.Location = New System.Drawing.Point(7, 62)
        Me.txtOccupationSpouse.MaxLength = 32767
        Me.txtOccupationSpouse.Name = "txtOccupationSpouse"
        Me.txtOccupationSpouse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOccupationSpouse.WaterMark = "Occupation"
        Me.txtOccupationSpouse.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtOccupationSpouse.SelectedText = ""
        Me.txtOccupationSpouse.SelectionLength = 0
        Me.txtOccupationSpouse.SelectionStart = 0
        Me.txtOccupationSpouse.ShortcutsEnabled = True
        Me.txtOccupationSpouse.Size = New System.Drawing.Size(184, 23)
        Me.txtOccupationSpouse.TabIndex = 10
        Me.txtOccupationSpouse.UseSelectable = True
        Me.txtOccupationSpouse.WaterMark = "Occupation"
        Me.txtOccupationSpouse.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtOccupationSpouse.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSuffixSpouse
        '
        '
        '
        '
        Me.txtSuffixSpouse.CustomButton.Image = Nothing
        Me.txtSuffixSpouse.CustomButton.Location = New System.Drawing.Point(89, 1)
        Me.txtSuffixSpouse.CustomButton.Name = ""
        Me.txtSuffixSpouse.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSuffixSpouse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSuffixSpouse.CustomButton.TabIndex = 1
        Me.txtSuffixSpouse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSuffixSpouse.CustomButton.UseSelectable = True
        Me.txtSuffixSpouse.CustomButton.Visible = False
        Me.txtSuffixSpouse.Lines = New String(-1) {}
        Me.txtSuffixSpouse.Location = New System.Drawing.Point(616, 33)
        Me.txtSuffixSpouse.MaxLength = 32767
        Me.txtSuffixSpouse.Name = "txtSuffixSpouse"
        Me.txtSuffixSpouse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSuffixSpouse.WaterMark = "Suffix"
        Me.txtSuffixSpouse.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSuffixSpouse.SelectedText = ""
        Me.txtSuffixSpouse.SelectionLength = 0
        Me.txtSuffixSpouse.SelectionStart = 0
        Me.txtSuffixSpouse.ShortcutsEnabled = True
        Me.txtSuffixSpouse.Size = New System.Drawing.Size(111, 23)
        Me.txtSuffixSpouse.TabIndex = 9
        Me.txtSuffixSpouse.UseSelectable = True
        Me.txtSuffixSpouse.WaterMark = "Suffix"
        Me.txtSuffixSpouse.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSuffixSpouse.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMnameSpouse
        '
        '
        '
        '
        Me.txtMnameSpouse.CustomButton.Image = Nothing
        Me.txtMnameSpouse.CustomButton.Location = New System.Drawing.Point(159, 1)
        Me.txtMnameSpouse.CustomButton.Name = ""
        Me.txtMnameSpouse.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMnameSpouse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMnameSpouse.CustomButton.TabIndex = 1
        Me.txtMnameSpouse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMnameSpouse.CustomButton.UseSelectable = True
        Me.txtMnameSpouse.CustomButton.Visible = False
        Me.txtMnameSpouse.Lines = New String(-1) {}
        Me.txtMnameSpouse.Location = New System.Drawing.Point(412, 33)
        Me.txtMnameSpouse.MaxLength = 32767
        Me.txtMnameSpouse.Name = "txtMnameSpouse"
        Me.txtMnameSpouse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMnameSpouse.WaterMark = "Middlename"
        Me.txtMnameSpouse.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMnameSpouse.SelectedText = ""
        Me.txtMnameSpouse.SelectionLength = 0
        Me.txtMnameSpouse.SelectionStart = 0
        Me.txtMnameSpouse.ShortcutsEnabled = True
        Me.txtMnameSpouse.Size = New System.Drawing.Size(181, 23)
        Me.txtMnameSpouse.TabIndex = 8
        Me.txtMnameSpouse.UseSelectable = True
        Me.txtMnameSpouse.WaterMark = "Middlename"
        Me.txtMnameSpouse.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMnameSpouse.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtFnameSpouse
        '
        '
        '
        '
        Me.txtFnameSpouse.CustomButton.Image = Nothing
        Me.txtFnameSpouse.CustomButton.Location = New System.Drawing.Point(159, 1)
        Me.txtFnameSpouse.CustomButton.Name = ""
        Me.txtFnameSpouse.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFnameSpouse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFnameSpouse.CustomButton.TabIndex = 1
        Me.txtFnameSpouse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFnameSpouse.CustomButton.UseSelectable = True
        Me.txtFnameSpouse.CustomButton.Visible = False
        Me.txtFnameSpouse.Lines = New String(-1) {}
        Me.txtFnameSpouse.Location = New System.Drawing.Point(212, 33)
        Me.txtFnameSpouse.MaxLength = 32767
        Me.txtFnameSpouse.Name = "txtFnameSpouse"
        Me.txtFnameSpouse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFnameSpouse.WaterMark = "Firstname"
        Me.txtFnameSpouse.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFnameSpouse.SelectedText = ""
        Me.txtFnameSpouse.SelectionLength = 0
        Me.txtFnameSpouse.SelectionStart = 0
        Me.txtFnameSpouse.ShortcutsEnabled = True
        Me.txtFnameSpouse.Size = New System.Drawing.Size(181, 23)
        Me.txtFnameSpouse.TabIndex = 7
        Me.txtFnameSpouse.UseSelectable = True
        Me.txtFnameSpouse.WaterMark = "Firstname"
        Me.txtFnameSpouse.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFnameSpouse.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtLnameSpouse
        '
        '
        '
        '
        Me.txtLnameSpouse.CustomButton.Image = Nothing
        Me.txtLnameSpouse.CustomButton.Location = New System.Drawing.Point(162, 1)
        Me.txtLnameSpouse.CustomButton.Name = ""
        Me.txtLnameSpouse.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLnameSpouse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLnameSpouse.CustomButton.TabIndex = 1
        Me.txtLnameSpouse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLnameSpouse.CustomButton.UseSelectable = True
        Me.txtLnameSpouse.CustomButton.Visible = False
        Me.txtLnameSpouse.Lines = New String(-1) {}
        Me.txtLnameSpouse.Location = New System.Drawing.Point(7, 33)
        Me.txtLnameSpouse.MaxLength = 32767
        Me.txtLnameSpouse.Name = "txtLnameSpouse"
        Me.txtLnameSpouse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLnameSpouse.WaterMark = "Surname"
        Me.txtLnameSpouse.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLnameSpouse.SelectedText = ""
        Me.txtLnameSpouse.SelectionLength = 0
        Me.txtLnameSpouse.SelectionStart = 0
        Me.txtLnameSpouse.ShortcutsEnabled = True
        Me.txtLnameSpouse.Size = New System.Drawing.Size(184, 23)
        Me.txtLnameSpouse.TabIndex = 6
        Me.txtLnameSpouse.UseSelectable = True
        Me.txtLnameSpouse.WaterMark = "Surname"
        Me.txtLnameSpouse.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLnameSpouse.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'FamilyBackground
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.gbSpouse)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSuffixMother)
        Me.Controls.Add(Me.txtMnameMother)
        Me.Controls.Add(Me.txtFnameMother)
        Me.Controls.Add(Me.txtLnameMother)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtSuffixFather)
        Me.Controls.Add(Me.txtMnameFather)
        Me.Controls.Add(Me.txtFnameFather)
        Me.Controls.Add(Me.txtLnameFather)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "FamilyBackground"
        Me.Size = New System.Drawing.Size(805, 571)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvChildrens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSpouse.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtLnameFather As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFnameFather As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMnameFather As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSuffixFather As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSuffixMother As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMnameMother As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFnameMother As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtLnameMother As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents dtpdobChild As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtmnameChild As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtfnameChild As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtlnameChild As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dgvChildrens As MetroFramework.Controls.MetroGrid
    Friend WithEvents gbSpouse As GroupBox
    Friend WithEvents txtBusinessTel As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBusinessAddress As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtOccupationSpouse As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSuffixSpouse As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMnameSpouse As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFnameSpouse As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtLnameSpouse As MetroFramework.Controls.MetroTextBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents lname As DataGridViewTextBoxColumn
    Friend WithEvents fname As DataGridViewTextBoxColumn
    Friend WithEvents mname As DataGridViewTextBoxColumn
    Friend WithEvents date_of_birth As DataGridViewTextBoxColumn
    Friend WithEvents edit As DataGridViewButtonColumn
    Friend WithEvents delete As DataGridViewButtonColumn
End Class
