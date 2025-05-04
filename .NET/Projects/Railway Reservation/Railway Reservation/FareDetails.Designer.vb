<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FareDetails
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RailwayDataSet2 = New Railway_Reservation.RailwayDataSet2()
        Me.FareDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FareDetailsTableAdapter = New Railway_Reservation.RailwayDataSet2TableAdapters.FareDetailsTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RailwayDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FareDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.TrainNameDataGridViewTextBoxColumn, Me.TrainNumberDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.FareDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FareDetailsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(726, 376)
        Me.DataGridView1.TabIndex = 0
        '
        'RailwayDataSet2
        '
        Me.RailwayDataSet2.DataSetName = "RailwayDataSet2"
        Me.RailwayDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FareDetailsBindingSource
        '
        Me.FareDetailsBindingSource.DataMember = "FareDetails"
        Me.FareDetailsBindingSource.DataSource = Me.RailwayDataSet2
        '
        'FareDetailsTableAdapter
        '
        Me.FareDetailsTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TrainNameDataGridViewTextBoxColumn
        '
        Me.TrainNameDataGridViewTextBoxColumn.DataPropertyName = "TrainName"
        Me.TrainNameDataGridViewTextBoxColumn.HeaderText = "TrainName"
        Me.TrainNameDataGridViewTextBoxColumn.Name = "TrainNameDataGridViewTextBoxColumn"
        '
        'TrainNumberDataGridViewTextBoxColumn
        '
        Me.TrainNumberDataGridViewTextBoxColumn.DataPropertyName = "TrainNumber"
        Me.TrainNumberDataGridViewTextBoxColumn.HeaderText = "TrainNumber"
        Me.TrainNumberDataGridViewTextBoxColumn.Name = "TrainNumberDataGridViewTextBoxColumn"
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "Class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        '
        'FareDataGridViewTextBoxColumn
        '
        Me.FareDataGridViewTextBoxColumn.DataPropertyName = "Fare"
        Me.FareDataGridViewTextBoxColumn.HeaderText = "Fare"
        Me.FareDataGridViewTextBoxColumn.Name = "FareDataGridViewTextBoxColumn"
        '
        'FareDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 376)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FareDetails"
        Me.Text = "FareDetails"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RailwayDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FareDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RailwayDataSet2 As Railway_Reservation.RailwayDataSet2
    Friend WithEvents FareDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FareDetailsTableAdapter As Railway_Reservation.RailwayDataSet2TableAdapters.FareDetailsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrainNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrainNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FareDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
