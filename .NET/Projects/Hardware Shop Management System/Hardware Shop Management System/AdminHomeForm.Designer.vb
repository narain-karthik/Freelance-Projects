<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHomeForm
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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PURCHASEDETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALESDETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STOCKDETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUSTOMERDETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DETAILSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(707, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DETAILSToolStripMenuItem
        '
        Me.DETAILSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PURCHASEDETAILSToolStripMenuItem, Me.SALESDETAILSToolStripMenuItem, Me.STOCKDETAILSToolStripMenuItem, Me.CUSTOMERDETAILSToolStripMenuItem})
        Me.DETAILSToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DETAILSToolStripMenuItem.Name = "DETAILSToolStripMenuItem"
        Me.DETAILSToolStripMenuItem.Size = New System.Drawing.Size(83, 29)
        Me.DETAILSToolStripMenuItem.Text = "Details"
        '
        'PURCHASEDETAILSToolStripMenuItem
        '
        Me.PURCHASEDETAILSToolStripMenuItem.Name = "PURCHASEDETAILSToolStripMenuItem"
        Me.PURCHASEDETAILSToolStripMenuItem.Size = New System.Drawing.Size(234, 30)
        Me.PURCHASEDETAILSToolStripMenuItem.Text = "Purchase Details"
        '
        'SALESDETAILSToolStripMenuItem
        '
        Me.SALESDETAILSToolStripMenuItem.Name = "SALESDETAILSToolStripMenuItem"
        Me.SALESDETAILSToolStripMenuItem.Size = New System.Drawing.Size(234, 30)
        Me.SALESDETAILSToolStripMenuItem.Text = "Sales Details"
        '
        'STOCKDETAILSToolStripMenuItem
        '
        Me.STOCKDETAILSToolStripMenuItem.Name = "STOCKDETAILSToolStripMenuItem"
        Me.STOCKDETAILSToolStripMenuItem.Size = New System.Drawing.Size(234, 30)
        Me.STOCKDETAILSToolStripMenuItem.Text = "Stock Details"
        '
        'CUSTOMERDETAILSToolStripMenuItem
        '
        Me.CUSTOMERDETAILSToolStripMenuItem.Name = "CUSTOMERDETAILSToolStripMenuItem"
        Me.CUSTOMERDETAILSToolStripMenuItem.Size = New System.Drawing.Size(234, 30)
        Me.CUSTOMERDETAILSToolStripMenuItem.Text = "Customer Details"
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.Teal
        Me.PanelHeader.Controls.Add(Me.LabelTitle)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(707, 60)
        Me.PanelHeader.TabIndex = 1
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitle.ForeColor = System.Drawing.Color.White
        Me.LabelTitle.Location = New System.Drawing.Point(20, 10)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(226, 41)
        Me.LabelTitle.TabIndex = 0
        Me.LabelTitle.Text = "Admin Control"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 290)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(707, 25)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(122, 20)
        Me.ToolStripStatusLabel1.Text = "Welcome, Admin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(131, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(419, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "HARDWARE SHOP MANAGEMENT SYSTEM"
        '
        'AdminHomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(707, 315)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AdminHomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DETAILSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PURCHASEDETAILSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALESDETAILSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents STOCKDETAILSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CUSTOMERDETAILSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
