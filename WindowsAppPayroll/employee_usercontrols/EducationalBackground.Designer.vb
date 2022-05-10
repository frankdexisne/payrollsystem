<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EducationalBackground
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.dgvEducationalBackground = New MetroFramework.Controls.MetroGrid()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.level = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_of_school = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.basic_education = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.from = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.period_to = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.year_graduated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.highiest_level = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.is_scholarship = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataSet1 = New WindowsAppPayroll.DataSet1()
        Me.cboLevel = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtNameOfSchool = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtBasicEducation = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtPeriodFrom = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txtPeriodTo = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txtYearGraduated = New MetroFramework.Controls.MetroTextBox()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.chkScholarship = New MetroFramework.Controls.MetroCheckBox()
        Me.txtHighiesLevelUnitsEarned = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        CType(Me.dgvEducationalBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(19, 22)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(269, 25)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "EDUCATIONAL BACKGROUND"
        '
        'dgvEducationalBackground
        '
        Me.dgvEducationalBackground.AllowUserToAddRows = False
        Me.dgvEducationalBackground.AllowUserToDeleteRows = False
        Me.dgvEducationalBackground.AllowUserToResizeRows = False
        Me.dgvEducationalBackground.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEducationalBackground.BackgroundColor = System.Drawing.Color.White
        Me.dgvEducationalBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvEducationalBackground.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvEducationalBackground.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEducationalBackground.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEducationalBackground.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEducationalBackground.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.level, Me.name_of_school, Me.basic_education, Me.from, Me.period_to, Me.year_graduated, Me.highiest_level, Me.is_scholarship, Me.edit, Me.delete})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEducationalBackground.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEducationalBackground.EnableHeadersVisualStyles = False
        Me.dgvEducationalBackground.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvEducationalBackground.GridColor = System.Drawing.Color.White
        Me.dgvEducationalBackground.Location = New System.Drawing.Point(27, 231)
        Me.dgvEducationalBackground.Name = "dgvEducationalBackground"
        Me.dgvEducationalBackground.ReadOnly = True
        Me.dgvEducationalBackground.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEducationalBackground.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEducationalBackground.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvEducationalBackground.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEducationalBackground.Size = New System.Drawing.Size(1013, 226)
        Me.dgvEducationalBackground.TabIndex = 2
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'level
        '
        Me.level.HeaderText = "Level"
        Me.level.Name = "level"
        Me.level.ReadOnly = True
        Me.level.Width = 150
        '
        'name_of_school
        '
        Me.name_of_school.HeaderText = "Name of School"
        Me.name_of_school.Name = "name_of_school"
        Me.name_of_school.ReadOnly = True
        Me.name_of_school.Width = 200
        '
        'basic_education
        '
        Me.basic_education.HeaderText = "Basic Education"
        Me.basic_education.Name = "basic_education"
        Me.basic_education.ReadOnly = True
        Me.basic_education.Width = 150
        '
        'from
        '
        Me.from.HeaderText = "FROM"
        Me.from.Name = "from"
        Me.from.ReadOnly = True
        '
        'period_to
        '
        Me.period_to.HeaderText = "TO"
        Me.period_to.Name = "period_to"
        Me.period_to.ReadOnly = True
        '
        'year_graduated
        '
        Me.year_graduated.HeaderText = "Year Graduated"
        Me.year_graduated.Name = "year_graduated"
        Me.year_graduated.ReadOnly = True
        Me.year_graduated.Width = 150
        '
        'highiest_level
        '
        Me.highiest_level.HeaderText = "Highiest Level/Units Earned"
        Me.highiest_level.Name = "highiest_level"
        Me.highiest_level.ReadOnly = True
        Me.highiest_level.Width = 200
        '
        'is_scholarship
        '
        Me.is_scholarship.FalseValue = "0"
        Me.is_scholarship.HeaderText = "Scholarship"
        Me.is_scholarship.Name = "is_scholarship"
        Me.is_scholarship.ReadOnly = True
        Me.is_scholarship.TrueValue = "1"
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
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboLevel
        '
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.ItemHeight = 23
        Me.cboLevel.Items.AddRange(New Object() {"ELEMENTARY", "SECONDARY", "VOCATIONAL/TRADE COURSE", "COLLEGE", "GRADUATE STUDIES"})
        Me.cboLevel.Location = New System.Drawing.Point(226, 60)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.Size = New System.Drawing.Size(230, 29)
        Me.cboLevel.TabIndex = 3
        Me.cboLevel.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(27, 60)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Level"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(27, 94)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(104, 19)
        Me.MetroLabel3.TabIndex = 5
        Me.MetroLabel3.Text = "Name of School"
        '
        'txtNameOfSchool
        '
        '
        '
        '
        Me.txtNameOfSchool.CustomButton.Image = Nothing
        Me.txtNameOfSchool.CustomButton.Location = New System.Drawing.Point(202, 2)
        Me.txtNameOfSchool.CustomButton.Name = ""
        Me.txtNameOfSchool.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNameOfSchool.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNameOfSchool.CustomButton.TabIndex = 1
        Me.txtNameOfSchool.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNameOfSchool.CustomButton.UseSelectable = True
        Me.txtNameOfSchool.CustomButton.Visible = False
        Me.txtNameOfSchool.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNameOfSchool.Lines = New String(-1) {}
        Me.txtNameOfSchool.Location = New System.Drawing.Point(226, 94)
        Me.txtNameOfSchool.MaxLength = 32767
        Me.txtNameOfSchool.Name = "txtNameOfSchool"
        Me.txtNameOfSchool.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNameOfSchool.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNameOfSchool.SelectedText = ""
        Me.txtNameOfSchool.SelectionLength = 0
        Me.txtNameOfSchool.SelectionStart = 0
        Me.txtNameOfSchool.ShortcutsEnabled = True
        Me.txtNameOfSchool.Size = New System.Drawing.Size(230, 30)
        Me.txtNameOfSchool.TabIndex = 6
        Me.txtNameOfSchool.UseSelectable = True
        Me.txtNameOfSchool.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNameOfSchool.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(27, 130)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(193, 19)
        Me.MetroLabel4.TabIndex = 7
        Me.MetroLabel4.Text = "Basic Education/Degree/Course"
        '
        'txtBasicEducation
        '
        '
        '
        '
        Me.txtBasicEducation.CustomButton.Image = Nothing
        Me.txtBasicEducation.CustomButton.Location = New System.Drawing.Point(202, 2)
        Me.txtBasicEducation.CustomButton.Name = ""
        Me.txtBasicEducation.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtBasicEducation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBasicEducation.CustomButton.TabIndex = 1
        Me.txtBasicEducation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBasicEducation.CustomButton.UseSelectable = True
        Me.txtBasicEducation.CustomButton.Visible = False
        Me.txtBasicEducation.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtBasicEducation.Lines = New String(-1) {}
        Me.txtBasicEducation.Location = New System.Drawing.Point(226, 130)
        Me.txtBasicEducation.MaxLength = 32767
        Me.txtBasicEducation.Name = "txtBasicEducation"
        Me.txtBasicEducation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBasicEducation.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBasicEducation.SelectedText = ""
        Me.txtBasicEducation.SelectionLength = 0
        Me.txtBasicEducation.SelectionStart = 0
        Me.txtBasicEducation.ShortcutsEnabled = True
        Me.txtBasicEducation.Size = New System.Drawing.Size(230, 30)
        Me.txtBasicEducation.TabIndex = 8
        Me.txtBasicEducation.UseSelectable = True
        Me.txtBasicEducation.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBasicEducation.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(532, 60)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(133, 19)
        Me.MetroLabel5.TabIndex = 9
        Me.MetroLabel5.Text = "Period of Attendance"
        '
        'txtPeriodFrom
        '
        '
        '
        '
        Me.txtPeriodFrom.CustomButton.Image = Nothing
        Me.txtPeriodFrom.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtPeriodFrom.CustomButton.Name = ""
        Me.txtPeriodFrom.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPeriodFrom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPeriodFrom.CustomButton.TabIndex = 1
        Me.txtPeriodFrom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPeriodFrom.CustomButton.UseSelectable = True
        Me.txtPeriodFrom.CustomButton.Visible = False
        Me.txtPeriodFrom.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPeriodFrom.Lines = New String(-1) {}
        Me.txtPeriodFrom.Location = New System.Drawing.Point(705, 60)
        Me.txtPeriodFrom.MaxLength = 4
        Me.txtPeriodFrom.Name = "txtPeriodFrom"
        Me.txtPeriodFrom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPeriodFrom.WaterMark = "Year"
        Me.txtPeriodFrom.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPeriodFrom.SelectedText = ""
        Me.txtPeriodFrom.SelectionLength = 0
        Me.txtPeriodFrom.SelectionStart = 0
        Me.txtPeriodFrom.ShortcutsEnabled = True
        Me.txtPeriodFrom.Size = New System.Drawing.Size(66, 30)
        Me.txtPeriodFrom.TabIndex = 10
        Me.txtPeriodFrom.UseSelectable = True
        Me.txtPeriodFrom.WaterMark = "Year"
        Me.txtPeriodFrom.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPeriodFrom.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(777, 60)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(21, 19)
        Me.MetroLabel6.TabIndex = 11
        Me.MetroLabel6.Text = "to"
        '
        'txtPeriodTo
        '
        '
        '
        '
        Me.txtPeriodTo.CustomButton.Image = Nothing
        Me.txtPeriodTo.CustomButton.Location = New System.Drawing.Point(52, 2)
        Me.txtPeriodTo.CustomButton.Name = ""
        Me.txtPeriodTo.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPeriodTo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPeriodTo.CustomButton.TabIndex = 1
        Me.txtPeriodTo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPeriodTo.CustomButton.UseSelectable = True
        Me.txtPeriodTo.CustomButton.Visible = False
        Me.txtPeriodTo.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPeriodTo.Lines = New String(-1) {}
        Me.txtPeriodTo.Location = New System.Drawing.Point(804, 60)
        Me.txtPeriodTo.MaxLength = 4
        Me.txtPeriodTo.Name = "txtPeriodTo"
        Me.txtPeriodTo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPeriodTo.WaterMark = "Year"
        Me.txtPeriodTo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPeriodTo.SelectedText = ""
        Me.txtPeriodTo.SelectionLength = 0
        Me.txtPeriodTo.SelectionStart = 0
        Me.txtPeriodTo.ShortcutsEnabled = True
        Me.txtPeriodTo.Size = New System.Drawing.Size(80, 30)
        Me.txtPeriodTo.TabIndex = 12
        Me.txtPeriodTo.UseSelectable = True
        Me.txtPeriodTo.WaterMark = "Year"
        Me.txtPeriodTo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPeriodTo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(532, 94)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(100, 19)
        Me.MetroLabel7.TabIndex = 13
        Me.MetroLabel7.Text = "Year Graduated"
        '
        'txtYearGraduated
        '
        '
        '
        '
        Me.txtYearGraduated.CustomButton.Image = Nothing
        Me.txtYearGraduated.CustomButton.Location = New System.Drawing.Point(151, 2)
        Me.txtYearGraduated.CustomButton.Name = ""
        Me.txtYearGraduated.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtYearGraduated.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtYearGraduated.CustomButton.TabIndex = 1
        Me.txtYearGraduated.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtYearGraduated.CustomButton.UseSelectable = True
        Me.txtYearGraduated.CustomButton.Visible = False
        Me.txtYearGraduated.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtYearGraduated.Lines = New String(-1) {}
        Me.txtYearGraduated.Location = New System.Drawing.Point(705, 96)
        Me.txtYearGraduated.MaxLength = 4
        Me.txtYearGraduated.Name = "txtYearGraduated"
        Me.txtYearGraduated.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtYearGraduated.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtYearGraduated.SelectedText = ""
        Me.txtYearGraduated.SelectionLength = 0
        Me.txtYearGraduated.SelectionStart = 0
        Me.txtYearGraduated.ShortcutsEnabled = True
        Me.txtYearGraduated.Size = New System.Drawing.Size(179, 30)
        Me.txtYearGraduated.TabIndex = 14
        Me.txtYearGraduated.UseSelectable = True
        Me.txtYearGraduated.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtYearGraduated.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnSave
        '
        Me.btnSave.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSave.Location = New System.Drawing.Point(27, 191)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseSelectable = True
        '
        'chkScholarship
        '
        Me.chkScholarship.AutoSize = True
        Me.chkScholarship.Location = New System.Drawing.Point(27, 170)
        Me.chkScholarship.Name = "chkScholarship"
        Me.chkScholarship.Size = New System.Drawing.Size(84, 15)
        Me.chkScholarship.TabIndex = 17
        Me.chkScholarship.Text = "Scholarship"
        Me.chkScholarship.UseSelectable = True
        '
        'txtHighiesLevelUnitsEarned
        '
        '
        '
        '
        Me.txtHighiesLevelUnitsEarned.CustomButton.Image = Nothing
        Me.txtHighiesLevelUnitsEarned.CustomButton.Location = New System.Drawing.Point(151, 2)
        Me.txtHighiesLevelUnitsEarned.CustomButton.Name = ""
        Me.txtHighiesLevelUnitsEarned.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtHighiesLevelUnitsEarned.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtHighiesLevelUnitsEarned.CustomButton.TabIndex = 1
        Me.txtHighiesLevelUnitsEarned.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtHighiesLevelUnitsEarned.CustomButton.UseSelectable = True
        Me.txtHighiesLevelUnitsEarned.CustomButton.Visible = False
        Me.txtHighiesLevelUnitsEarned.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtHighiesLevelUnitsEarned.Lines = New String(-1) {}
        Me.txtHighiesLevelUnitsEarned.Location = New System.Drawing.Point(705, 130)
        Me.txtHighiesLevelUnitsEarned.MaxLength = 32767
        Me.txtHighiesLevelUnitsEarned.Name = "txtHighiesLevelUnitsEarned"
        Me.txtHighiesLevelUnitsEarned.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHighiesLevelUnitsEarned.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtHighiesLevelUnitsEarned.SelectedText = ""
        Me.txtHighiesLevelUnitsEarned.SelectionLength = 0
        Me.txtHighiesLevelUnitsEarned.SelectionStart = 0
        Me.txtHighiesLevelUnitsEarned.ShortcutsEnabled = True
        Me.txtHighiesLevelUnitsEarned.Size = New System.Drawing.Size(179, 30)
        Me.txtHighiesLevelUnitsEarned.TabIndex = 19
        Me.txtHighiesLevelUnitsEarned.UseSelectable = True
        Me.txtHighiesLevelUnitsEarned.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtHighiesLevelUnitsEarned.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(532, 128)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(166, 19)
        Me.MetroLabel8.TabIndex = 18
        Me.MetroLabel8.Text = "Highiest Level/Units Earned"
        '
        'EducationalBackground
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txtHighiesLevelUnitsEarned)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.chkScholarship)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtYearGraduated)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.txtPeriodTo)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.txtPeriodFrom)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.txtBasicEducation)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.txtNameOfSchool)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.cboLevel)
        Me.Controls.Add(Me.dgvEducationalBackground)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "EducationalBackground"
        Me.Size = New System.Drawing.Size(1058, 494)
        CType(Me.dgvEducationalBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgvEducationalBackground As MetroFramework.Controls.MetroGrid
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents cboLevel As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNameOfSchool As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtBasicEducation As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPeriodFrom As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPeriodTo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtYearGraduated As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents chkScholarship As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents txtHighiesLevelUnitsEarned As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents level As DataGridViewTextBoxColumn
    Friend WithEvents name_of_school As DataGridViewTextBoxColumn
    Friend WithEvents basic_education As DataGridViewTextBoxColumn
    Friend WithEvents from As DataGridViewTextBoxColumn
    Friend WithEvents period_to As DataGridViewTextBoxColumn
    Friend WithEvents year_graduated As DataGridViewTextBoxColumn
    Friend WithEvents highiest_level As DataGridViewTextBoxColumn
    Friend WithEvents is_scholarship As DataGridViewCheckBoxColumn
    Friend WithEvents edit As DataGridViewButtonColumn
    Friend WithEvents delete As DataGridViewButtonColumn
End Class
