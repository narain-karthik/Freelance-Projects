Imports System.Data.SqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceDetails
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
    Private Sub RefreshData()
        Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Attendance;Integrated Security=True"
        Dim query As String = "SELECT * FROM [Attendance].[dbo].[AttendanceRecords]"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                ViewAttendanceDetailsDataGridView.DataSource = table
            End Using
        End Using
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ViewAttendanceDetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegisterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsPresentDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AttendanceRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendanceDataSet4 = New Attendance_Application.AttendanceDataSet4()
        Me.AttendanceRecordsTableAdapter = New Attendance_Application.AttendanceDataSet4TableAdapters.AttendanceRecordsTableAdapter()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        CType(Me.ViewAttendanceDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(181, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "View Attendace Details"
        '
        'ViewAttendanceDetailsDataGridView
        '
        Me.ViewAttendanceDetailsDataGridView.AutoGenerateColumns = False
        Me.ViewAttendanceDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewAttendanceDetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.RegisterDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.IsPresentDataGridViewCheckBoxColumn})
        Me.ViewAttendanceDetailsDataGridView.DataSource = Me.AttendanceRecordsBindingSource
        Me.ViewAttendanceDetailsDataGridView.Location = New System.Drawing.Point(39, 118)
        Me.ViewAttendanceDetailsDataGridView.Name = "ViewAttendanceDetailsDataGridView"
        Me.ViewAttendanceDetailsDataGridView.RowTemplate.Height = 24
        Me.ViewAttendanceDetailsDataGridView.Size = New System.Drawing.Size(516, 204)
        Me.ViewAttendanceDetailsDataGridView.TabIndex = 1
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'RegisterDataGridViewTextBoxColumn
        '
        Me.RegisterDataGridViewTextBoxColumn.DataPropertyName = "Register"
        Me.RegisterDataGridViewTextBoxColumn.HeaderText = "Register"
        Me.RegisterDataGridViewTextBoxColumn.Name = "RegisterDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'IsPresentDataGridViewCheckBoxColumn
        '
        Me.IsPresentDataGridViewCheckBoxColumn.DataPropertyName = "IsPresent"
        Me.IsPresentDataGridViewCheckBoxColumn.HeaderText = "IsPresent"
        Me.IsPresentDataGridViewCheckBoxColumn.Name = "IsPresentDataGridViewCheckBoxColumn"
        '
        'AttendanceRecordsBindingSource
        '
        Me.AttendanceRecordsBindingSource.DataMember = "AttendanceRecords"
        Me.AttendanceRecordsBindingSource.DataSource = Me.AttendanceDataSet4
        '
        'AttendanceDataSet4
        '
        Me.AttendanceDataSet4.DataSetName = "AttendanceDataSet4"
        Me.AttendanceDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AttendanceRecordsTableAdapter
        '
        Me.AttendanceRecordsTableAdapter.ClearBeforeFill = True
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.SystemColors.HotTrack
        Me.UpdateButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UpdateButton.Location = New System.Drawing.Point(143, 365)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton.TabIndex = 2
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.DeleteButton.Location = New System.Drawing.Point(405, 365)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 3
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'AttendanceDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(606, 441)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.ViewAttendanceDetailsDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AttendanceDetails"
        Me.Text = "AttendanceDetails"
        CType(Me.ViewAttendanceDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ViewAttendanceDetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AttendanceDataSet4 As Attendance_Application.AttendanceDataSet4
    Friend WithEvents AttendanceRecordsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AttendanceRecordsTableAdapter As Attendance_Application.AttendanceDataSet4TableAdapters.AttendanceRecordsTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegisterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsPresentDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
End Class
