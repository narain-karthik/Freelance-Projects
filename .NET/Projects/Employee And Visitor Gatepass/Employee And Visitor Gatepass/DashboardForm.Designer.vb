<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitorDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PassRequestEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PassRequestVistorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewEmployeeDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewVisitorDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPassRequestEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PassRequestVistorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.ForeColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetailsToolStripMenuItem, Me.PassToolStripMenuItem, Me.ViewDetailsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(548, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeDetailsToolStripMenuItem, Me.VisitorDetailsToolStripMenuItem})
        Me.DetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(83, 29)
        Me.DetailsToolStripMenuItem.Text = "Details"
        '
        'EmployeeDetailsToolStripMenuItem
        '
        Me.EmployeeDetailsToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.EmployeeDetailsToolStripMenuItem.Name = "EmployeeDetailsToolStripMenuItem"
        Me.EmployeeDetailsToolStripMenuItem.Size = New System.Drawing.Size(234, 30)
        Me.EmployeeDetailsToolStripMenuItem.Text = "Employee Details"
        '
        'VisitorDetailsToolStripMenuItem
        '
        Me.VisitorDetailsToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.VisitorDetailsToolStripMenuItem.Name = "VisitorDetailsToolStripMenuItem"
        Me.VisitorDetailsToolStripMenuItem.Size = New System.Drawing.Size(234, 30)
        Me.VisitorDetailsToolStripMenuItem.Text = "Visitor Details"
        '
        'PassToolStripMenuItem
        '
        Me.PassToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PassRequestEmployeeToolStripMenuItem, Me.PassRequestVistorToolStripMenuItem})
        Me.PassToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PassToolStripMenuItem.Name = "PassToolStripMenuItem"
        Me.PassToolStripMenuItem.Size = New System.Drawing.Size(62, 29)
        Me.PassToolStripMenuItem.Text = "Pass"
        '
        'PassRequestEmployeeToolStripMenuItem
        '
        Me.PassRequestEmployeeToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PassRequestEmployeeToolStripMenuItem.Name = "PassRequestEmployeeToolStripMenuItem"
        Me.PassRequestEmployeeToolStripMenuItem.Size = New System.Drawing.Size(302, 30)
        Me.PassRequestEmployeeToolStripMenuItem.Text = "Pass Request - Employee"
        '
        'PassRequestVistorToolStripMenuItem
        '
        Me.PassRequestVistorToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PassRequestVistorToolStripMenuItem.Name = "PassRequestVistorToolStripMenuItem"
        Me.PassRequestVistorToolStripMenuItem.Size = New System.Drawing.Size(302, 30)
        Me.PassRequestVistorToolStripMenuItem.Text = "Pass Request - Visitor"
        '
        'ViewDetailsToolStripMenuItem
        '
        Me.ViewDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewEmployeeDetailsToolStripMenuItem, Me.ViewVisitorDetailsToolStripMenuItem, Me.ViewPassRequestEmployeeToolStripMenuItem, Me.PassRequestVistorToolStripMenuItem1})
        Me.ViewDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewDetailsToolStripMenuItem.Name = "ViewDetailsToolStripMenuItem"
        Me.ViewDetailsToolStripMenuItem.Size = New System.Drawing.Size(131, 29)
        Me.ViewDetailsToolStripMenuItem.Text = "View Details"
        '
        'ViewEmployeeDetailsToolStripMenuItem
        '
        Me.ViewEmployeeDetailsToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ViewEmployeeDetailsToolStripMenuItem.Name = "ViewEmployeeDetailsToolStripMenuItem"
        Me.ViewEmployeeDetailsToolStripMenuItem.Size = New System.Drawing.Size(350, 30)
        Me.ViewEmployeeDetailsToolStripMenuItem.Text = "View Employee Details"
        '
        'ViewVisitorDetailsToolStripMenuItem
        '
        Me.ViewVisitorDetailsToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ViewVisitorDetailsToolStripMenuItem.Name = "ViewVisitorDetailsToolStripMenuItem"
        Me.ViewVisitorDetailsToolStripMenuItem.Size = New System.Drawing.Size(350, 30)
        Me.ViewVisitorDetailsToolStripMenuItem.Text = "View Visitor Details"
        '
        'ViewPassRequestEmployeeToolStripMenuItem
        '
        Me.ViewPassRequestEmployeeToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ViewPassRequestEmployeeToolStripMenuItem.Name = "ViewPassRequestEmployeeToolStripMenuItem"
        Me.ViewPassRequestEmployeeToolStripMenuItem.Size = New System.Drawing.Size(350, 30)
        Me.ViewPassRequestEmployeeToolStripMenuItem.Text = "View Pass Request - Employee"
        '
        'PassRequestVistorToolStripMenuItem1
        '
        Me.PassRequestVistorToolStripMenuItem1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PassRequestVistorToolStripMenuItem1.Name = "PassRequestVistorToolStripMenuItem1"
        Me.PassRequestVistorToolStripMenuItem1.Size = New System.Drawing.Size(350, 30)
        Me.PassRequestVistorToolStripMenuItem1.Text = "View Pass Request - Visitor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee and Visitor Gatepass login System"
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(548, 276)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard - Pass Management System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisitorDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PassRequestEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PassRequestVistorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewEmployeeDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewVisitorDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPassRequestEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PassRequestVistorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
