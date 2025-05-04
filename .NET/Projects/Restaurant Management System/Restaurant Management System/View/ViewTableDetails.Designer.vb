<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTableDetails
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
        Me.TableIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestaurantDataSet3 = New Restaurant_Management_System.RestaurantDataSet3()
        Me.TableDetailsTableAdapter = New Restaurant_Management_System.RestaurantDataSet3TableAdapters.TableDetailsTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TableIDDataGridViewTextBoxColumn, Me.TableNumberDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.SeatsDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TableDetailsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(641, 319)
        Me.DataGridView1.TabIndex = 0
        '
        'TableIDDataGridViewTextBoxColumn
        '
        Me.TableIDDataGridViewTextBoxColumn.DataPropertyName = "TableID"
        Me.TableIDDataGridViewTextBoxColumn.HeaderText = "TableID"
        Me.TableIDDataGridViewTextBoxColumn.Name = "TableIDDataGridViewTextBoxColumn"
        '
        'TableNumberDataGridViewTextBoxColumn
        '
        Me.TableNumberDataGridViewTextBoxColumn.DataPropertyName = "TableNumber"
        Me.TableNumberDataGridViewTextBoxColumn.HeaderText = "TableNumber"
        Me.TableNumberDataGridViewTextBoxColumn.Name = "TableNumberDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'SeatsDataGridViewTextBoxColumn
        '
        Me.SeatsDataGridViewTextBoxColumn.DataPropertyName = "Seats"
        Me.SeatsDataGridViewTextBoxColumn.HeaderText = "Seats"
        Me.SeatsDataGridViewTextBoxColumn.Name = "SeatsDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        '
        'TableDetailsBindingSource
        '
        Me.TableDetailsBindingSource.DataMember = "TableDetails"
        Me.TableDetailsBindingSource.DataSource = Me.RestaurantDataSet3
        '
        'RestaurantDataSet3
        '
        Me.RestaurantDataSet3.DataSetName = "RestaurantDataSet3"
        Me.RestaurantDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableDetailsTableAdapter
        '
        Me.TableDetailsTableAdapter.ClearBeforeFill = True
        '
        'ViewTableDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 319)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewTableDetails"
        Me.Text = "ViewTableDetails"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RestaurantDataSet3 As Restaurant_Management_System.RestaurantDataSet3
    Friend WithEvents TableDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableDetailsTableAdapter As Restaurant_Management_System.RestaurantDataSet3TableAdapters.TableDetailsTableAdapter
    Friend WithEvents TableIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeatsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
