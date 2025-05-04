<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewReservation
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
        Me.RailwayDataSet1 = New Railway_Reservation.RailwayDataSet1()
        Me.ReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationTableAdapter = New Railway_Reservation.RailwayDataSet1TableAdapters.ReservationTableAdapter()
        Me.ReservationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TravelClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassengerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeniorCitizenDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BookedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RailwayDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReservationIDDataGridViewTextBoxColumn, Me.TrainNumberDataGridViewTextBoxColumn, Me.TrainNameDataGridViewTextBoxColumn, Me.SourceDataGridViewTextBoxColumn, Me.DestinationDataGridViewTextBoxColumn, Me.TravelClassDataGridViewTextBoxColumn, Me.ReservationDateDataGridViewTextBoxColumn, Me.SeatNoDataGridViewTextBoxColumn, Me.PassengerNameDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.SeniorCitizenDataGridViewCheckBoxColumn, Me.BookedByDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReservationBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(834, 453)
        Me.DataGridView1.TabIndex = 0
        '
        'RailwayDataSet1
        '
        Me.RailwayDataSet1.DataSetName = "RailwayDataSet1"
        Me.RailwayDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationBindingSource
        '
        Me.ReservationBindingSource.DataMember = "Reservation"
        Me.ReservationBindingSource.DataSource = Me.RailwayDataSet1
        '
        'ReservationTableAdapter
        '
        Me.ReservationTableAdapter.ClearBeforeFill = True
        '
        'ReservationIDDataGridViewTextBoxColumn
        '
        Me.ReservationIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationID"
        Me.ReservationIDDataGridViewTextBoxColumn.HeaderText = "ReservationID"
        Me.ReservationIDDataGridViewTextBoxColumn.Name = "ReservationIDDataGridViewTextBoxColumn"
        Me.ReservationIDDataGridViewTextBoxColumn.ReadOnly = True
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
        'SourceDataGridViewTextBoxColumn
        '
        Me.SourceDataGridViewTextBoxColumn.DataPropertyName = "Source"
        Me.SourceDataGridViewTextBoxColumn.HeaderText = "Source"
        Me.SourceDataGridViewTextBoxColumn.Name = "SourceDataGridViewTextBoxColumn"
        '
        'DestinationDataGridViewTextBoxColumn
        '
        Me.DestinationDataGridViewTextBoxColumn.DataPropertyName = "Destination"
        Me.DestinationDataGridViewTextBoxColumn.HeaderText = "Destination"
        Me.DestinationDataGridViewTextBoxColumn.Name = "DestinationDataGridViewTextBoxColumn"
        '
        'TravelClassDataGridViewTextBoxColumn
        '
        Me.TravelClassDataGridViewTextBoxColumn.DataPropertyName = "TravelClass"
        Me.TravelClassDataGridViewTextBoxColumn.HeaderText = "TravelClass"
        Me.TravelClassDataGridViewTextBoxColumn.Name = "TravelClassDataGridViewTextBoxColumn"
        '
        'ReservationDateDataGridViewTextBoxColumn
        '
        Me.ReservationDateDataGridViewTextBoxColumn.DataPropertyName = "ReservationDate"
        Me.ReservationDateDataGridViewTextBoxColumn.HeaderText = "ReservationDate"
        Me.ReservationDateDataGridViewTextBoxColumn.Name = "ReservationDateDataGridViewTextBoxColumn"
        '
        'SeatNoDataGridViewTextBoxColumn
        '
        Me.SeatNoDataGridViewTextBoxColumn.DataPropertyName = "SeatNo"
        Me.SeatNoDataGridViewTextBoxColumn.HeaderText = "SeatNo"
        Me.SeatNoDataGridViewTextBoxColumn.Name = "SeatNoDataGridViewTextBoxColumn"
        '
        'PassengerNameDataGridViewTextBoxColumn
        '
        Me.PassengerNameDataGridViewTextBoxColumn.DataPropertyName = "PassengerName"
        Me.PassengerNameDataGridViewTextBoxColumn.HeaderText = "PassengerName"
        Me.PassengerNameDataGridViewTextBoxColumn.Name = "PassengerNameDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        '
        'SeniorCitizenDataGridViewCheckBoxColumn
        '
        Me.SeniorCitizenDataGridViewCheckBoxColumn.DataPropertyName = "SeniorCitizen"
        Me.SeniorCitizenDataGridViewCheckBoxColumn.HeaderText = "SeniorCitizen"
        Me.SeniorCitizenDataGridViewCheckBoxColumn.Name = "SeniorCitizenDataGridViewCheckBoxColumn"
        '
        'BookedByDataGridViewTextBoxColumn
        '
        Me.BookedByDataGridViewTextBoxColumn.DataPropertyName = "BookedBy"
        Me.BookedByDataGridViewTextBoxColumn.HeaderText = "BookedBy"
        Me.BookedByDataGridViewTextBoxColumn.Name = "BookedByDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'ViewReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 453)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewReservation"
        Me.Text = "ViewReservation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RailwayDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RailwayDataSet1 As Railway_Reservation.RailwayDataSet1
    Friend WithEvents ReservationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReservationTableAdapter As Railway_Reservation.RailwayDataSet1TableAdapters.ReservationTableAdapter
    Friend WithEvents ReservationIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrainNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrainNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SourceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DestinationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TravelClassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReservationDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeatNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PassengerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeniorCitizenDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BookedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
