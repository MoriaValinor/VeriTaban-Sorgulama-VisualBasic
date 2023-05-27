<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ADIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOYADIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEMLEKETDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MESLEKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CINSIYETDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GELİRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GİDERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tablo1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BilgilerDataSet = New veritabanı_sorgu.bilgilerDataSet()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Tablo1TableAdapter = New veritabanı_sorgu.bilgilerDataSetTableAdapters.Tablo1TableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tablo1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BilgilerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ADIDataGridViewTextBoxColumn, Me.SOYADIDataGridViewTextBoxColumn, Me.MEMLEKETDataGridViewTextBoxColumn, Me.MESLEKDataGridViewTextBoxColumn, Me.CINSIYETDataGridViewTextBoxColumn, Me.GELİRDataGridViewTextBoxColumn, Me.GİDERDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Tablo1BindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.GridColor = System.Drawing.Color.Lime
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1065, 191)
        Me.DataGridView1.TabIndex = 0
        '
        'ADIDataGridViewTextBoxColumn
        '
        Me.ADIDataGridViewTextBoxColumn.DataPropertyName = "ADI"
        Me.ADIDataGridViewTextBoxColumn.HeaderText = "ADI"
        Me.ADIDataGridViewTextBoxColumn.Name = "ADIDataGridViewTextBoxColumn"
        Me.ADIDataGridViewTextBoxColumn.ReadOnly = True
        Me.ADIDataGridViewTextBoxColumn.Width = 150
        '
        'SOYADIDataGridViewTextBoxColumn
        '
        Me.SOYADIDataGridViewTextBoxColumn.DataPropertyName = "SOYADI"
        Me.SOYADIDataGridViewTextBoxColumn.HeaderText = "SOYADI"
        Me.SOYADIDataGridViewTextBoxColumn.Name = "SOYADIDataGridViewTextBoxColumn"
        Me.SOYADIDataGridViewTextBoxColumn.ReadOnly = True
        Me.SOYADIDataGridViewTextBoxColumn.Width = 150
        '
        'MEMLEKETDataGridViewTextBoxColumn
        '
        Me.MEMLEKETDataGridViewTextBoxColumn.DataPropertyName = "MEMLEKET"
        Me.MEMLEKETDataGridViewTextBoxColumn.HeaderText = "MEMLEKET"
        Me.MEMLEKETDataGridViewTextBoxColumn.Name = "MEMLEKETDataGridViewTextBoxColumn"
        Me.MEMLEKETDataGridViewTextBoxColumn.ReadOnly = True
        Me.MEMLEKETDataGridViewTextBoxColumn.Width = 150
        '
        'MESLEKDataGridViewTextBoxColumn
        '
        Me.MESLEKDataGridViewTextBoxColumn.DataPropertyName = "MESLEK"
        Me.MESLEKDataGridViewTextBoxColumn.HeaderText = "MESLEK"
        Me.MESLEKDataGridViewTextBoxColumn.Name = "MESLEKDataGridViewTextBoxColumn"
        Me.MESLEKDataGridViewTextBoxColumn.ReadOnly = True
        Me.MESLEKDataGridViewTextBoxColumn.Width = 150
        '
        'CINSIYETDataGridViewTextBoxColumn
        '
        Me.CINSIYETDataGridViewTextBoxColumn.DataPropertyName = "CINSIYET"
        Me.CINSIYETDataGridViewTextBoxColumn.HeaderText = "CINSIYET"
        Me.CINSIYETDataGridViewTextBoxColumn.Name = "CINSIYETDataGridViewTextBoxColumn"
        Me.CINSIYETDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GELİRDataGridViewTextBoxColumn
        '
        Me.GELİRDataGridViewTextBoxColumn.DataPropertyName = "GELİR"
        DataGridViewCellStyle3.Format = "C"
        Me.GELİRDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.GELİRDataGridViewTextBoxColumn.HeaderText = "GELİR"
        Me.GELİRDataGridViewTextBoxColumn.Name = "GELİRDataGridViewTextBoxColumn"
        Me.GELİRDataGridViewTextBoxColumn.ReadOnly = True
        Me.GELİRDataGridViewTextBoxColumn.Width = 150
        '
        'GİDERDataGridViewTextBoxColumn
        '
        Me.GİDERDataGridViewTextBoxColumn.DataPropertyName = "GİDER"
        DataGridViewCellStyle4.Format = "C"
        Me.GİDERDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.GİDERDataGridViewTextBoxColumn.HeaderText = "GİDER"
        Me.GİDERDataGridViewTextBoxColumn.Name = "GİDERDataGridViewTextBoxColumn"
        Me.GİDERDataGridViewTextBoxColumn.ReadOnly = True
        Me.GİDERDataGridViewTextBoxColumn.Width = 150
        '
        'Tablo1BindingSource
        '
        Me.Tablo1BindingSource.DataMember = "Tablo1"
        Me.Tablo1BindingSource.DataSource = Me.BilgilerDataSet
        '
        'BilgilerDataSet
        '
        Me.BilgilerDataSet.DataSetName = "bilgilerDataSet"
        Me.BilgilerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView2.GridColor = System.Drawing.Color.Lime
        Me.DataGridView2.Location = New System.Drawing.Point(0, 322)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowTemplate.Height = 30
        Me.DataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(1065, 191)
        Me.DataGridView2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.Location = New System.Drawing.Point(698, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(318, 69)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "SORGULAMA YAP"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(33, 228)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(327, 20)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "AD,SOYAD VE GELİR-GİDERLERİNİ GÖSTERME"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(33, 249)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(303, 20)
        Me.CheckBox2.TabIndex = 4
        Me.CheckBox2.Text = "AD,SOYAD VE CİNSİYETLERİNİ GÖSTERME"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(33, 272)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(201, 20)
        Me.CheckBox3.TabIndex = 5
        Me.CheckBox3.Text = "TÜM BİLGİLERİ GÖSTERME"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Tablo1TableAdapter
        '
        Me.Tablo1TableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1065, 513)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tablo1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BilgilerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents BilgilerDataSet As veritabanı_sorgu.bilgilerDataSet
    Friend WithEvents Tablo1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tablo1TableAdapter As veritabanı_sorgu.bilgilerDataSetTableAdapters.Tablo1TableAdapter
    Friend WithEvents ADIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SOYADIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MEMLEKETDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MESLEKDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CINSIYETDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GELİRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GİDERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
