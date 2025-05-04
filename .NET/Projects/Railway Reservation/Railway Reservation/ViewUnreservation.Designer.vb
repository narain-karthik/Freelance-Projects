<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewUnreservation
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
        Me.RailwayDataSet = New Railway_Reservation.RailwayDataSet()
        Me.UnreservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnreservationTableAdapter = New Railway_Reservation.RailwayDataSetTableAdapters.UnreservationTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SourceStationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinationStationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnreservationDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RailwayDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnreservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.TrainNumberDataGridViewTextBoxColumn, Me.TrainNameDataGridViewTextBoxColumn, Me.SourceStationDataGridViewTextBoxColumn, Me.DestinationStationDataGridViewTextBoxColumn, Me.UnreservationDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UnreservationBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(862, 406)
        Me.DataGridView1.TabIndex = 0
        '
        'RailwayDataSet
        '
        Me.RailwayDataSet.DataSetName = "RailwayDataSet"
        Me.RailwayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UnreservationBindingSource
        '
        Me.UnreservationBindingSource.DataMember = "Unreservation"
        Me.UnreservationBindingSource.DataSource = Me.RailwayDataSet
        '
        'UnreservationTableAdapter
        '
        Me.UnreservationTableAdapter.ClearBeforeFill = True
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
        'SourceStationDataGridViewTextBoxColumn
        '
        Me.SourceStationDataGridViewTextBoxColumn.DataPropertyName = "SourceStation"
        Me.SourceStationDataGridViewTextBoxColumn.HeaderText = "SourceStation"
        Me.SourceStationDataGridViewTextBoxColumn.Name = "SourceStationDataGridViewTextBoxColumn"
        '
        'DestinationStationDataGridViewTextBoxColumn
        '
        Me.DestinationStationDataGridViewTextBoxColumn.DataPropertyName = "DestinationStation"
        Me.DestinationStationDataGridViewTextBoxColumn.HeaderText = "DestinationStation"
        Me.DestinationStationDataGridViewTextBoxColumn.Name = "DestinationStationDataGridViewTextBoxColumn"
        '
        'UnreservationDateDataGridViewTextBoxColumn
        '
        Me.UnreservationDateDataGridViewTextBoxColumn.DataPropertyName = "UnreservationDate"
        Me.UnreservationDateDataGridViewTextBoxColumn.HeaderText = "UnreservationDate"
        Me.UnreservationDateDataGridViewTextBoxColumn.Name = "UnreservationDateDataGridViewTextBoxColumn"
        '
        'ViewUnreservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 406)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewUnreservation"
        Me.Text = "ViewUnreservation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RailwayDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnreservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RailwayDataSet As Railway_Reservation.RailwayDataSet
    Friend WithEvents UnreservationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnreservationTableAdapter As Railway_Reservation.RailwayDataSetTableAdapters.UnreservationTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrainNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrainNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SourceStationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DestinationStationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnreservationDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
