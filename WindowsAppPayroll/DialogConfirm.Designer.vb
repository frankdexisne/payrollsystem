<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DialogConfirm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogConfirm))
        Me.btnYes = New MetroFramework.Controls.MetroButton()
        Me.btnNo = New MetroFramework.Controls.MetroButton()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnYes
        '
        Me.btnYes.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnYes.Location = New System.Drawing.Point(286, 130)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(87, 30)
        Me.btnYes.TabIndex = 1
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseSelectable = True
        '
        'btnNo
        '
        Me.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNo.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnNo.Location = New System.Drawing.Point(379, 130)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(88, 30)
        Me.btnNo.TabIndex = 2
        Me.btnNo.Text = "No"
        Me.btnNo.UseSelectable = True
        '
        'txtMessage
        '
        Me.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMessage.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage.Location = New System.Drawing.Point(23, 74)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(444, 50)
        Me.txtMessage.TabIndex = 3
        Me.txtMessage.Text = "Do you want to continue?"
        Me.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(77, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DialogConfirm
        '
        Me.AcceptButton = Me.btnYes
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnNo
        Me.ClientSize = New System.Drawing.Size(490, 183)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Name = "DialogConfirm"
        Me.Resizable = False
        Me.Text = "Confirm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnYes As MetroFramework.Controls.MetroButton
    Friend WithEvents btnNo As MetroFramework.Controls.MetroButton
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
