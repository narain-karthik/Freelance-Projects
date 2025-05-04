<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewCancellation
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
        Me.RailwayDataSet4 = New Railway_Reservation.RailwayDataSet4()
        Me.TicketsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TicketsTableAdapter = New Railway_Reservation.RailwayDataSet4TableAdapters.TicketsTableAdapter()
        Me.PNRNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RailwayDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNRNODataGridViewTextBoxColumn, Me.TrainNoDataGridViewTextBoxColumn, Me.TrainNameDataGridViewTextBoxColumn, Me.FromDataGridViewTextBoxColumn, Me.ToDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TicketsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(788, 426)
        Me.DataGridView1.TabIndex = 0
        '
        'RailwayDataSet4
        '
        Me.RailwayDataSet4.DataSetName = "RailwayDataSet4"
        Me.RailwayDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TicketsBindingSource
        '
        Me.TicketsBindingSource.DataMember = "Tickets"
        Me.TicketsBindingSource.DataSource = Me.RailwayDataSet4
        '
        'TicketsTableAdapter
        '
        Me.TicketsTableAdapter.ClearBeforeFill = True
        '
        'PNRNODataGridViewTextBoxColumn
        '
        Me.PNRNODataGridViewTextBoxColumn.DataPropertyName = "PNR_NO"
        Me.PNRNODataGridViewTextBoxColumn.HeaderText = "PNR_NO"
        Me.PNRNODataGridViewTextBoxColumn.Name = "PNRNODataGridViewTextBoxColumn"
        '
        'TrainNoDataGridViewTextBoxColumn
        '
        Me.TrainNoDataGridViewTextBoxColumn.DataPropertyName = "Train_No"
        Me.TrainNoDataGridViewTextBoxColumn.HeaderText = "Train_No"
        Me.TrainNoDataGridViewTextBoxColumn.Name = "TrainNoDataGridViewTextBoxColumn"
        '
        'TrainNameDataGridViewTextBoxColumn
        '
        Me.TrainNameDataGridViewTextBoxColumn.DataPropertyName = "Train_Name"
        Me.TrainNameDataGridViewTextBoxColumn.HeaderText = "Train_Name"
        Me.TrainNameDataGridViewTextBoxColumn.Name = "TrainNameDataGridViewTextBoxColumn"
        '
        'FromDataGridViewTextBoxColumn
        '
        Me.FromDataGridViewTextBoxColumn.DataPropertyName = "From"
        Me.FromDataGridViewTextBoxColumn.HeaderText = "From"
        Me.FromDataGridViewTextBoxColumn.Name = "FromDataGridViewTextBoxColumn"
        '
        'ToDataGridViewTextBoxColumn
        '
        Me.ToDataGridViewTextBoxColumn.DataPropertyName = "To"
        Me.ToDataGridViewTextBoxColumn.HeaderText = "To"
        Me.ToDataGridViewTextBoxColumn.Name = "ToDataGridViewTextBoxColumn"
        '
        'ViewCancellation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 426)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewCancellation"
        Me.Text = "ViewCancellation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RailwayDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RailwayDataSet4 As Railway_Reservation.RailwayDataSet4
    Friend WithEvents TicketsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TicketsTableAdapter As Railway_Reservation.RailwayDataSet4TableAdapters.TicketsTableAdapter
    Friend WithEvents PNRNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrainNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrainNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FromDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
