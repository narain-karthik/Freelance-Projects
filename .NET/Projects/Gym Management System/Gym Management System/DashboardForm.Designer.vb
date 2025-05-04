<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
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

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MembersDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MembersAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMembersDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStaffDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStaffAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMembersAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetailsToolStripMenuItem, Me.ViewDetailsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(640, 35)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MembersDetailsToolStripMenuItem, Me.StaffDetailsToolStripMenuItem, Me.StaffAttendanceToolStripMenuItem, Me.MembersAttendanceToolStripMenuItem})
        Me.DetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(83, 29)
        Me.DetailsToolStripMenuItem.Text = "Details"
        '
        'MembersDetailsToolStripMenuItem
        '
        Me.MembersDetailsToolStripMenuItem.Name = "MembersDetailsToolStripMenuItem"
        Me.MembersDetailsToolStripMenuItem.Size = New System.Drawing.Size(274, 30)
        Me.MembersDetailsToolStripMenuItem.Text = "Members Details"
        '
        'StaffDetailsToolStripMenuItem
        '
        Me.StaffDetailsToolStripMenuItem.Name = "StaffDetailsToolStripMenuItem"
        Me.StaffDetailsToolStripMenuItem.Size = New System.Drawing.Size(274, 30)
        Me.StaffDetailsToolStripMenuItem.Text = "Staff Details"
        '
        'StaffAttendanceToolStripMenuItem
        '
        Me.StaffAttendanceToolStripMenuItem.Name = "StaffAttendanceToolStripMenuItem"
        Me.StaffAttendanceToolStripMenuItem.Size = New System.Drawing.Size(274, 30)
        Me.StaffAttendanceToolStripMenuItem.Text = "Staff Attendance"
        '
        'MembersAttendanceToolStripMenuItem
        '
        Me.MembersAttendanceToolStripMenuItem.Name = "MembersAttendanceToolStripMenuItem"
        Me.MembersAttendanceToolStripMenuItem.Size = New System.Drawing.Size(274, 30)
        Me.MembersAttendanceToolStripMenuItem.Text = "Members Attendance"
        '
        'ViewDetailsToolStripMenuItem
        '
        Me.ViewDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewMembersDetailsToolStripMenuItem, Me.ViewStaffDetailsToolStripMenuItem, Me.ViewStaffAttendanceToolStripMenuItem, Me.ViewMembersAttendanceToolStripMenuItem})
        Me.ViewDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewDetailsToolStripMenuItem.Name = "ViewDetailsToolStripMenuItem"
        Me.ViewDetailsToolStripMenuItem.Size = New System.Drawing.Size(131, 29)
        Me.ViewDetailsToolStripMenuItem.Text = "View Details"
        '
        'ViewMembersDetailsToolStripMenuItem
        '
        Me.ViewMembersDetailsToolStripMenuItem.Name = "ViewMembersDetailsToolStripMenuItem"
        Me.ViewMembersDetailsToolStripMenuItem.Size = New System.Drawing.Size(322, 30)
        Me.ViewMembersDetailsToolStripMenuItem.Text = "View Members Details"
        '
        'ViewStaffDetailsToolStripMenuItem
        '
        Me.ViewStaffDetailsToolStripMenuItem.Name = "ViewStaffDetailsToolStripMenuItem"
        Me.ViewStaffDetailsToolStripMenuItem.Size = New System.Drawing.Size(322, 30)
        Me.ViewStaffDetailsToolStripMenuItem.Text = "View Staff Details"
        '
        'ViewStaffAttendanceToolStripMenuItem
        '
        Me.ViewStaffAttendanceToolStripMenuItem.Name = "ViewStaffAttendanceToolStripMenuItem"
        Me.ViewStaffAttendanceToolStripMenuItem.Size = New System.Drawing.Size(322, 30)
        Me.ViewStaffAttendanceToolStripMenuItem.Text = "View Staff Attendance"
        '
        'ViewMembersAttendanceToolStripMenuItem
        '
        Me.ViewMembersAttendanceToolStripMenuItem.Name = "ViewMembersAttendanceToolStripMenuItem"
        Me.ViewMembersAttendanceToolStripMenuItem.Size = New System.Drawing.Size(322, 30)
        Me.ViewMembersAttendanceToolStripMenuItem.Text = "View Members Attendance"
        '
        'LabelTitle
        '
        Me.LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitle.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.LabelTitle.Location = New System.Drawing.Point(75, 127)
        Me.LabelTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(494, 46)
        Me.LabelTitle.TabIndex = 1
        Me.LabelTitle.Text = "GYM MANAGEMENT SYSTEM"
        Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(640, 288)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "DashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MembersDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffAttendanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MembersAttendanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewMembersDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewStaffDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewStaffAttendanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewMembersAttendanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelTitle As Label
End Class
