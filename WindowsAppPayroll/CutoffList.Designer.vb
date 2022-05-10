<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CutoffList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvCutoffs = New MetroFramework.Controls.MetroGrid()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CutoffsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsAppPayroll.DataSet1()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.CutoffsTableAdapter = New WindowsAppPayroll.DataSet1TableAdapters.cutoffsTableAdapter()
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.ProceedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvCutoffs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CutoffsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroContextMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCutoffs
        '
        Me.dgvCutoffs.AllowUserToAddRows = False
        Me.dgvCutoffs.AllowUserToDeleteRows = False
        Me.dgvCutoffs.AllowUserToResizeRows = False
        Me.dgvCutoffs.AutoGenerateColumns = False
        Me.dgvCutoffs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCutoffs.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCutoffs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCutoffs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvCutoffs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCutoffs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCutoffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCutoffs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.FromDataGridViewTextBoxColumn, Me.ToDataGridViewTextBoxColumn})
        Me.dgvCutoffs.DataSource = Me.CutoffsBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCutoffs.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCutoffs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCutoffs.EnableHeadersVisualStyles = False
        Me.dgvCutoffs.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvCutoffs.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCutoffs.Location = New System.Drawing.Point(20, 60)
        Me.dgvCutoffs.Name = "dgvCutoffs"
        Me.dgvCutoffs.ReadOnly = True
        Me.dgvCutoffs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCutoffs.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCutoffs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCutoffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCutoffs.Size = New System.Drawing.Size(599, 275)
        Me.dgvCutoffs.TabIndex = 3
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Payroll Period"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FromDataGridViewTextBoxColumn
        '
        Me.FromDataGridViewTextBoxColumn.DataPropertyName = "from"
        Me.FromDataGridViewTextBoxColumn.HeaderText = "Start Cutoff"
        Me.FromDataGridViewTextBoxColumn.Name = "FromDataGridViewTextBoxColumn"
        Me.FromDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ToDataGridViewTextBoxColumn
        '
        Me.ToDataGridViewTextBoxColumn.DataPropertyName = "to"
        Me.ToDataGridViewTextBoxColumn.HeaderText = "End Cutoff"
        Me.ToDataGridViewTextBoxColumn.Name = "ToDataGridViewTextBoxColumn"
        Me.ToDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CutoffsBindingSource
        '
        Me.CutoffsBindingSource.DataMember = "cutoffs"
        Me.CutoffsBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnAdd.Location = New System.Drawing.Point(536, 24)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(83, 30)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseSelectable = True
        '
        'CutoffsTableAdapter
        '
        Me.CutoffsTableAdapter.ClearBeforeFill = True
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProceedToolStripMenuItem, Me.ViewSummaryToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(154, 48)
        '
        'ProceedToolStripMenuItem
        '
        Me.ProceedToolStripMenuItem.Name = "ProceedToolStripMenuItem"
        Me.ProceedToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ProceedToolStripMenuItem.Text = "Proceed"
        '
        'ViewSummaryToolStripMenuItem
        '
        Me.ViewSummaryToolStripMenuItem.Name = "ViewSummaryToolStripMenuItem"
        Me.ViewSummaryToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ViewSummaryToolStripMenuItem.Text = "View Summary"
        '
        'CutoffList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(639, 355)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvCutoffs)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CutoffList"
        Me.Text = "Payroll Periods"
        CType(Me.dgvCutoffs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CutoffsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvCutoffs As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents CutoffsBindingSource As BindingSource
    Friend WithEvents CutoffsTableAdapter As DataSet1TableAdapters.cutoffsTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FromDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents ProceedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewSummaryToolStripMenuItem As ToolStripMenuItem
End Class
