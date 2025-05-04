<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAttendance
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
        Me.ViewAttendanceLabel = New System.Windows.Forms.Label()
        Me.RegisterLabel = New System.Windows.Forms.Label()
        Me.RegisterTextBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.AttendanceDataSet5 = New Attendance_Application.AttendanceDataSet5()
        Me.AttendanceRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendanceRecordsTableAdapter = New Attendance_Application.AttendanceDataSet5TableAdapters.AttendanceRecordsTableAdapter()
        Me.ViewAttendanceDetailsDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.AttendanceDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewAttendanceDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ViewAttendanceLabel
        '
        Me.ViewAttendanceLabel.AutoSize = True
        Me.ViewAttendanceLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ViewAttendanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewAttendanceLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ViewAttendanceLabel.Location = New System.Drawing.Point(109, 57)
        Me.ViewAttendanceLabel.Name = "ViewAttendanceLabel"
        Me.ViewAttendanceLabel.Size = New System.Drawing.Size(232, 25)
        Me.ViewAttendanceLabel.TabIndex = 0
        Me.ViewAttendanceLabel.Text = "View User Attendance "
        '
        'RegisterLabel
        '
        Me.RegisterLabel.AutoSize = True
        Me.RegisterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterLabel.Location = New System.Drawing.Point(10, 126)
        Me.RegisterLabel.Name = "RegisterLabel"
        Me.RegisterLabel.Size = New System.Drawing.Size(130, 17)
        Me.RegisterLabel.TabIndex = 1
        Me.RegisterLabel.Text = "Register Number"
        '
        'RegisterTextBox
        '
        Me.RegisterTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.RegisterTextBox.Location = New System.Drawing.Point(167, 124)
        Me.RegisterTextBox.Name = "RegisterTextBox"
        Me.RegisterTextBox.Size = New System.Drawing.Size(100, 22)
        Me.RegisterTextBox.TabIndex = 2
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.SystemColors.HotTrack
        Me.SearchButton.Location = New System.Drawing.Point(321, 122)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton.TabIndex = 3
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'AttendanceDataSet5
        '
        Me.AttendanceDataSet5.DataSetName = "AttendanceDataSet5"
        Me.AttendanceDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AttendanceRecordsBindingSource
        '
        Me.AttendanceRecordsBindingSource.DataMember = "AttendanceRecords"
        Me.AttendanceRecordsBindingSource.DataSource = Me.AttendanceDataSet5
        '
        'AttendanceRecordsTableAdapter
        '
        Me.AttendanceRecordsTableAdapter.ClearBeforeFill = True
        '
        'ViewAttendanceDetailsDataGridView
        '
        Me.ViewAttendanceDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewAttendanceDetailsDataGridView.Location = New System.Drawing.Point(27, 222)
        Me.ViewAttendanceDetailsDataGridView.Name = "ViewAttendanceDetailsDataGridView"
        Me.ViewAttendanceDetailsDataGridView.RowTemplate.Height = 24
        Me.ViewAttendanceDetailsDataGridView.Size = New System.Drawing.Size(393, 167)
        Me.ViewAttendanceDetailsDataGridView.TabIndex = 4
        '
        'ViewAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(460, 406)
        Me.Controls.Add(Me.ViewAttendanceDetailsDataGridView)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.RegisterTextBox)
        Me.Controls.Add(Me.RegisterLabel)
        Me.Controls.Add(Me.ViewAttendanceLabel)
        Me.Name = "ViewAttendance"
        Me.Text = "ViewAttendance"
        CType(Me.AttendanceDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewAttendanceDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ViewAttendanceLabel As System.Windows.Forms.Label
    Friend WithEvents RegisterLabel As System.Windows.Forms.Label
    Friend WithEvents RegisterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents AttendanceDataSet5 As Attendance_Application.AttendanceDataSet5
    Friend WithEvents AttendanceRecordsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AttendanceRecordsTableAdapter As Attendance_Application.AttendanceDataSet5TableAdapters.AttendanceRecordsTableAdapter
    Friend WithEvents ViewAttendanceDetailsDataGridView As System.Windows.Forms.DataGridView
End Class
