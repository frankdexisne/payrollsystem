<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HollidayWithinCutoff
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvHolidays = New MetroFramework.Controls.MetroGrid()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.DataSet1 = New WindowsAppPayroll.DataSet1()
        Me.HolidaysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HolidaysTableAdapter = New WindowsAppPayroll.DataSet1TableAdapters.holidaysTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HolidaydateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsregularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dgvHolidays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HolidaysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHolidays
        '
        Me.dgvHolidays.AllowUserToAddRows = False
        Me.dgvHolidays.AllowUserToDeleteRows = False
        Me.dgvHolidays.AllowUserToResizeRows = False
        Me.dgvHolidays.AutoGenerateColumns = False
        Me.dgvHolidays.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvHolidays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvHolidays.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvHolidays.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHolidays.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHolidays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHolidays.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.HolidaydateDataGridViewTextBoxColumn, Me.IsregularDataGridViewTextBoxColumn})
        Me.dgvHolidays.DataSource = Me.HolidaysBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHolidays.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvHolidays.EnableHeadersVisualStyles = False
        Me.dgvHolidays.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvHolidays.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvHolidays.Location = New System.Drawing.Point(15, 53)
        Me.dgvHolidays.Name = "dgvHolidays"
        Me.dgvHolidays.ReadOnly = True
        Me.dgvHolidays.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHolidays.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvHolidays.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvHolidays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHolidays.Size = New System.Drawing.Size(745, 288)
        Me.dgvHolidays.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnAdd.Location = New System.Drawing.Point(667, 18)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 29)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(16, 22)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(112, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "List of Holidays"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HolidaysBindingSource
        '
        Me.HolidaysBindingSource.DataMember = "holidays"
        Me.HolidaysBindingSource.DataSource = Me.DataSet1
        '
        'HolidaysTableAdapter
        '
        Me.HolidaysTableAdapter.ClearBeforeFill = True
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
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name of Holiday"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 200
        '
        'HolidaydateDataGridViewTextBoxColumn
        '
        Me.HolidaydateDataGridViewTextBoxColumn.DataPropertyName = "holiday_date"
        Me.HolidaydateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.HolidaydateDataGridViewTextBoxColumn.Name = "HolidaydateDataGridViewTextBoxColumn"
        Me.HolidaydateDataGridViewTextBoxColumn.ReadOnly = True
        Me.HolidaydateDataGridViewTextBoxColumn.Width = 150
        '
        'IsregularDataGridViewTextBoxColumn
        '
        Me.IsregularDataGridViewTextBoxColumn.DataPropertyName = "is_regular"
        Me.IsregularDataGridViewTextBoxColumn.FalseValue = "0"
        Me.IsregularDataGridViewTextBoxColumn.HeaderText = "Regular Holiday"
        Me.IsregularDataGridViewTextBoxColumn.Name = "IsregularDataGridViewTextBoxColumn"
        Me.IsregularDataGridViewTextBoxColumn.ReadOnly = True
        Me.IsregularDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IsregularDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IsregularDataGridViewTextBoxColumn.TrueValue = "1"
        Me.IsregularDataGridViewTextBoxColumn.Width = 200
        '
        'HollidayWithinCutoff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvHolidays)
        Me.Name = "HollidayWithinCutoff"
        Me.Size = New System.Drawing.Size(775, 364)
        CType(Me.dgvHolidays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HolidaysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvHolidays As MetroFramework.Controls.MetroGrid
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HolidaydateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsregularDataGridViewTextBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents HolidaysBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents HolidaysTableAdapter As DataSet1TableAdapters.holidaysTableAdapter
End Class
