<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.bgwLogin = New System.ComponentModel.BackgroundWorker()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.chkShowPassword = New MetroFramework.Controls.MetroCheckBox()
        Me.btnLogin = New MetroFramework.Controls.MetroButton()
        Me.txtPassword = New MetroFramework.Controls.MetroTextBox()
        Me.txtusername = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bgwLogin
        '
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel1.Controls.Add(Me.PictureBox3)
        Me.MetroPanel1.Controls.Add(Me.PictureBox2)
        Me.MetroPanel1.Controls.Add(Me.chkShowPassword)
        Me.MetroPanel1.Controls.Add(Me.btnLogin)
        Me.MetroPanel1.Controls.Add(Me.txtPassword)
        Me.MetroPanel1.Controls.Add(Me.txtusername)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(218, 64)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(379, 197)
        Me.MetroPanel1.TabIndex = 9
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Location = New System.Drawing.Point(56, 124)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(105, 15)
        Me.chkShowPassword.TabIndex = 3
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseSelectable = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(184, 151)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(176, 30)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseSelectable = True
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.CustomButton.Image = Nothing
        Me.txtPassword.CustomButton.Location = New System.Drawing.Point(276, 2)
        Me.txtPassword.CustomButton.Name = ""
        Me.txtPassword.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPassword.CustomButton.TabIndex = 1
        Me.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPassword.CustomButton.UseSelectable = True
        Me.txtPassword.CustomButton.Visible = False
        Me.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPassword.Lines = New String(-1) {}
        Me.txtPassword.Location = New System.Drawing.Point(56, 88)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.WaterMark = "Password"
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.ShortcutsEnabled = True
        Me.txtPassword.Size = New System.Drawing.Size(304, 30)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSelectable = True
        Me.txtPassword.WaterMark = "Password"
        Me.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtusername
        '
        Me.txtusername.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        '
        '
        '
        Me.txtusername.CustomButton.Image = Nothing
        Me.txtusername.CustomButton.Location = New System.Drawing.Point(276, 2)
        Me.txtusername.CustomButton.Name = ""
        Me.txtusername.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtusername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtusername.CustomButton.TabIndex = 1
        Me.txtusername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtusername.CustomButton.UseSelectable = True
        Me.txtusername.CustomButton.Visible = False
        Me.txtusername.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtusername.Lines = New String(-1) {}
        Me.txtusername.Location = New System.Drawing.Point(56, 32)
        Me.txtusername.MaxLength = 32767
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.WaterMark = "Username"
        Me.txtusername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtusername.SelectedText = ""
        Me.txtusername.SelectionLength = 0
        Me.txtusername.SelectionStart = 0
        Me.txtusername.ShortcutsEnabled = True
        Me.txtusername.Size = New System.Drawing.Size(304, 30)
        Me.txtusername.TabIndex = 1
        Me.txtusername.UseSelectable = True
        Me.txtusername.UseStyleColors = True
        Me.txtusername.WaterMark = "Username"
        Me.txtusername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtusername.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.PictureBox1)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(14, 64)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(198, 197)
        Me.MetroPanel2.TabIndex = 10
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 197)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(15, 32)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(15, 89)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 29)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(618, 284)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.Text = "Login "
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bgwLogin As System.ComponentModel.BackgroundWorker
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnLogin As MetroFramework.Controls.MetroButton
    Friend WithEvents txtPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtusername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents chkShowPassword As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
