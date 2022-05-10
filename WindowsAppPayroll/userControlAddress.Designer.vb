<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class userControlAddress
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
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.cboProvince = New MetroFramework.Controls.MetroComboBox()
        Me.cboCity = New MetroFramework.Controls.MetroComboBox()
        Me.lblCity = New MetroFramework.Controls.MetroLabel()
        Me.cboBarangay = New MetroFramework.Controls.MetroComboBox()
        Me.lblBarangay = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtStreet = New MetroFramework.Controls.MetroTextBox()
        Me.cboRegion = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtOthers = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.DataSet1 = New WindowsAppPayroll.DataSet1()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(1, 42)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel2.TabIndex = 0
        Me.MetroLabel2.Text = "Province"
        '
        'cboProvince
        '
        Me.cboProvince.FormattingEnabled = True
        Me.cboProvince.ItemHeight = 23
        Me.cboProvince.Location = New System.Drawing.Point(135, 40)
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(186, 29)
        Me.cboProvince.TabIndex = 1
        Me.cboProvince.UseSelectable = True
        '
        'cboCity
        '
        Me.cboCity.FormattingEnabled = True
        Me.cboCity.ItemHeight = 23
        Me.cboCity.Location = New System.Drawing.Point(135, 74)
        Me.cboCity.Name = "cboCity"
        Me.cboCity.Size = New System.Drawing.Size(186, 29)
        Me.cboCity.TabIndex = 3
        Me.cboCity.UseSelectable = True
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(1, 81)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(105, 19)
        Me.lblCity.TabIndex = 2
        Me.lblCity.Text = "City/Municipality"
        '
        'cboBarangay
        '
        Me.cboBarangay.FormattingEnabled = True
        Me.cboBarangay.ItemHeight = 23
        Me.cboBarangay.Location = New System.Drawing.Point(135, 109)
        Me.cboBarangay.Name = "cboBarangay"
        Me.cboBarangay.Size = New System.Drawing.Size(186, 29)
        Me.cboBarangay.TabIndex = 5
        Me.cboBarangay.UseSelectable = True
        '
        'lblBarangay
        '
        Me.lblBarangay.AutoSize = True
        Me.lblBarangay.Location = New System.Drawing.Point(1, 116)
        Me.lblBarangay.Name = "lblBarangay"
        Me.lblBarangay.Size = New System.Drawing.Size(64, 19)
        Me.lblBarangay.TabIndex = 4
        Me.lblBarangay.Text = "Barangay"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(1, 152)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel5.TabIndex = 6
        Me.MetroLabel5.Text = "Street"
        '
        'txtStreet
        '
        '
        '
        '
        Me.txtStreet.CustomButton.Image = Nothing
        Me.txtStreet.CustomButton.Location = New System.Drawing.Point(158, 2)
        Me.txtStreet.CustomButton.Name = ""
        Me.txtStreet.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtStreet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStreet.CustomButton.TabIndex = 1
        Me.txtStreet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStreet.CustomButton.UseSelectable = True
        Me.txtStreet.CustomButton.Visible = False
        Me.txtStreet.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtStreet.Lines = New String(-1) {}
        Me.txtStreet.Location = New System.Drawing.Point(135, 144)
        Me.txtStreet.MaxLength = 32767
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStreet.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStreet.SelectedText = ""
        Me.txtStreet.SelectionLength = 0
        Me.txtStreet.SelectionStart = 0
        Me.txtStreet.ShortcutsEnabled = True
        Me.txtStreet.Size = New System.Drawing.Size(186, 30)
        Me.txtStreet.TabIndex = 7
        Me.txtStreet.UseSelectable = True
        Me.txtStreet.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStreet.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cboRegion
        '
        Me.cboRegion.DisplayMember = "region_id"
        Me.cboRegion.FormattingEnabled = True
        Me.cboRegion.ItemHeight = 23
        Me.cboRegion.Location = New System.Drawing.Point(135, 7)
        Me.cboRegion.Name = "cboRegion"
        Me.cboRegion.Size = New System.Drawing.Size(186, 29)
        Me.cboRegion.TabIndex = 9
        Me.cboRegion.UseSelectable = True
        Me.cboRegion.ValueMember = "region_id"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(1, 8)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel3.TabIndex = 8
        Me.MetroLabel3.Text = "Region"
        '
        'txtOthers
        '
        '
        '
        '
        Me.txtOthers.CustomButton.Image = Nothing
        Me.txtOthers.CustomButton.Location = New System.Drawing.Point(158, 2)
        Me.txtOthers.CustomButton.Name = ""
        Me.txtOthers.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtOthers.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtOthers.CustomButton.TabIndex = 1
        Me.txtOthers.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtOthers.CustomButton.UseSelectable = True
        Me.txtOthers.CustomButton.Visible = False
        Me.txtOthers.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtOthers.Lines = New String(-1) {}
        Me.txtOthers.Location = New System.Drawing.Point(135, 180)
        Me.txtOthers.MaxLength = 32767
        Me.txtOthers.Name = "txtOthers"
        Me.txtOthers.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOthers.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtOthers.SelectedText = ""
        Me.txtOthers.SelectionLength = 0
        Me.txtOthers.SelectionStart = 0
        Me.txtOthers.ShortcutsEnabled = True
        Me.txtOthers.Size = New System.Drawing.Size(186, 30)
        Me.txtOthers.TabIndex = 11
        Me.txtOthers.UseSelectable = True
        Me.txtOthers.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtOthers.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(1, 185)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(126, 19)
        Me.MetroLabel4.TabIndex = 10
        Me.MetroLabel4.Text = "House/Block/Lot No"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'userControlAddress
        '
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txtOthers)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.cboRegion)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.cboBarangay)
        Me.Controls.Add(Me.lblBarangay)
        Me.Controls.Add(Me.cboCity)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.cboProvince)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Name = "userControlAddress"
        Me.Size = New System.Drawing.Size(353, 216)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboProvince As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cboCity As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblCity As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboBarangay As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblBarangay As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtStreet As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cboRegion As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtOthers As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
End Class
