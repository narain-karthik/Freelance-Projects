<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrainDetails
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
        Me.RailwayDataSet3 = New Railway_Reservation.RailwayDataSet3()
        Me.TrainDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrainDetailTableAdapter = New Railway_Reservation.RailwayDataSet3TableAdapters.TrainDetailTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainTimingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RailwayDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrainDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.TrainNumberDataGridViewTextBoxColumn, Me.TrainNameDataGridViewTextBoxColumn, Me.TrainTimingDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TrainDetailBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(847, 434)
        Me.DataGridView1.TabIndex = 0
        '
        'RailwayDataSet3
        '
        Me.RailwayDataSet3.DataSetName = "RailwayDataSet3"
        Me.RailwayDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TrainDetailBindingSource
        '
        Me.TrainDetailBindingSource.DataMember = "TrainDetail"
        Me.TrainDetailBindingSource.DataSource = Me.RailwayDataSet3
        '
        'TrainDetailTableAdapter
        '
        Me.TrainDetailTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TrainNumberDataGridViewTextBoxColumn
        '
        Me.TrainNumberDataGridViewTextBoxColumn.DataPropertyName = "TrainNumber"
        Me.TrainNumberDataGridViewTextBoxColumn.HeaderText = "TrainNumber"
        Me.TrainNumberDataGridViewTextBoxColumn.Name = "TrainNumberDataGridViewTextBoxColumn"
        '
        'TrainNameDataGridViewTextBoxColumn
        '
        Me.TrainNameDataGridViewTextBoxColumn.DataPropertyName = "TrainName"
        Me.TrainNameDataGridViewTextBoxColumn.HeaderText = "TrainName"
        Me.TrainNameDataGridViewTextBoxColumn.Name = "TrainNameDataGridViewTextBoxColumn"
        '
        'TrainTimingDataGridViewTextBoxColumn
        '
        Me.TrainTimingDataGridViewTextBoxColumn.DataPropertyName = "TrainTiming"
        Me.TrainTimingDataGridViewTextBoxColumn.HeaderText = "TrainTiming"
        Me.TrainTimingDataGridViewTextBoxColumn.Name = "TrainTimingDataGridViewTextBoxColumn"
        '
        'TrainDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 434)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "TrainDetails"
        Me.Text = "TrainDetails"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RailwayDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrainDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RailwayDataSet3 As Railway_Reservation.RailwayDataSet3
    Friend WithEvents TrainDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TrainDetailTableAdapter As Railway_Reservation.RailwayDataSet3TableAdapters.TrainDetailTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrainNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrainNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrainTimingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
