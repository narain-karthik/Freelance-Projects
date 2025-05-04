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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTableDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenuDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewOrderDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewEmployeeDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManagementToolStripMenuItem, Me.ViewDetailsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(711, 36)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ManagementToolStripMenuItem
        '
        Me.ManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TableManagementToolStripMenuItem, Me.MenuManagementToolStripMenuItem, Me.OrderManagementToolStripMenuItem, Me.EmployeeManagementToolStripMenuItem})
        Me.ManagementToolStripMenuItem.Name = "ManagementToolStripMenuItem"
        Me.ManagementToolStripMenuItem.Size = New System.Drawing.Size(140, 32)
        Me.ManagementToolStripMenuItem.Text = "Management"
        '
        'TableManagementToolStripMenuItem
        '
        Me.TableManagementToolStripMenuItem.Name = "TableManagementToolStripMenuItem"
        Me.TableManagementToolStripMenuItem.Size = New System.Drawing.Size(291, 32)
        Me.TableManagementToolStripMenuItem.Text = "Table Management"
        '
        'MenuManagementToolStripMenuItem
        '
        Me.MenuManagementToolStripMenuItem.Name = "MenuManagementToolStripMenuItem"
        Me.MenuManagementToolStripMenuItem.Size = New System.Drawing.Size(291, 32)
        Me.MenuManagementToolStripMenuItem.Text = "Menu Management"
        '
        'OrderManagementToolStripMenuItem
        '
        Me.OrderManagementToolStripMenuItem.Name = "OrderManagementToolStripMenuItem"
        Me.OrderManagementToolStripMenuItem.Size = New System.Drawing.Size(291, 32)
        Me.OrderManagementToolStripMenuItem.Text = "Order Management"
        '
        'EmployeeManagementToolStripMenuItem
        '
        Me.EmployeeManagementToolStripMenuItem.Name = "EmployeeManagementToolStripMenuItem"
        Me.EmployeeManagementToolStripMenuItem.Size = New System.Drawing.Size(291, 32)
        Me.EmployeeManagementToolStripMenuItem.Text = "Employee Management"
        '
        'ViewDetailsToolStripMenuItem
        '
        Me.ViewDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewTableDetailsToolStripMenuItem, Me.ViewMenuDetailsToolStripMenuItem, Me.ViewOrderDetailsToolStripMenuItem, Me.ViewEmployeeDetailsToolStripMenuItem})
        Me.ViewDetailsToolStripMenuItem.Name = "ViewDetailsToolStripMenuItem"
        Me.ViewDetailsToolStripMenuItem.Size = New System.Drawing.Size(129, 32)
        Me.ViewDetailsToolStripMenuItem.Text = "View Details"
        '
        'ViewTableDetailsToolStripMenuItem
        '
        Me.ViewTableDetailsToolStripMenuItem.Name = "ViewTableDetailsToolStripMenuItem"
        Me.ViewTableDetailsToolStripMenuItem.Size = New System.Drawing.Size(280, 32)
        Me.ViewTableDetailsToolStripMenuItem.Text = "View Table Details"
        '
        'ViewMenuDetailsToolStripMenuItem
        '
        Me.ViewMenuDetailsToolStripMenuItem.Name = "ViewMenuDetailsToolStripMenuItem"
        Me.ViewMenuDetailsToolStripMenuItem.Size = New System.Drawing.Size(280, 32)
        Me.ViewMenuDetailsToolStripMenuItem.Text = "View Menu Details"
        '
        'ViewOrderDetailsToolStripMenuItem
        '
        Me.ViewOrderDetailsToolStripMenuItem.Name = "ViewOrderDetailsToolStripMenuItem"
        Me.ViewOrderDetailsToolStripMenuItem.Size = New System.Drawing.Size(280, 32)
        Me.ViewOrderDetailsToolStripMenuItem.Text = "View Order Details"
        '
        'ViewEmployeeDetailsToolStripMenuItem
        '
        Me.ViewEmployeeDetailsToolStripMenuItem.Name = "ViewEmployeeDetailsToolStripMenuItem"
        Me.ViewEmployeeDetailsToolStripMenuItem.Size = New System.Drawing.Size(280, 32)
        Me.ViewEmployeeDetailsToolStripMenuItem.Text = "View Employee Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label1.Location = New System.Drawing.Point(32, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(634, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RESTAURANT MANAGEMENT SYSTEM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdminHomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(711, 360)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AdminHomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Home - Gym Management System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewTableDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMenuDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewOrderDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewEmployeeDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
