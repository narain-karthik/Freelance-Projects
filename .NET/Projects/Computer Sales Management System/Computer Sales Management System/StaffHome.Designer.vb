<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffHome
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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.AdminLabel = New System.Windows.Forms.Label()
        Me.StaffdetailsLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.AddcustomerLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ViewProductLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(189, 46)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(298, 25)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Computer Sales Management"
        '
        'AdminLabel
        '
        Me.AdminLabel.AutoSize = True
        Me.AdminLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminLabel.Location = New System.Drawing.Point(269, 86)
        Me.AdminLabel.Name = "AdminLabel"
        Me.AdminLabel.Size = New System.Drawing.Size(130, 17)
        Me.AdminLabel.TabIndex = 3
        Me.AdminLabel.Text = "Staff Home Page"
        '
        'StaffdetailsLinkLabel
        '
        Me.StaffdetailsLinkLabel.AutoSize = True
        Me.StaffdetailsLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffdetailsLinkLabel.Location = New System.Drawing.Point(34, 159)
        Me.StaffdetailsLinkLabel.Name = "StaffdetailsLinkLabel"
        Me.StaffdetailsLinkLabel.Size = New System.Drawing.Size(135, 17)
        Me.StaffdetailsLinkLabel.TabIndex = 4
        Me.StaffdetailsLinkLabel.TabStop = True
        Me.StaffdetailsLinkLabel.Text = "View Staff Details"
        '
        'AddcustomerLinkLabel
        '
        Me.AddcustomerLinkLabel.AutoSize = True
        Me.AddcustomerLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddcustomerLinkLabel.Location = New System.Drawing.Point(254, 159)
        Me.AddcustomerLinkLabel.Name = "AddcustomerLinkLabel"
        Me.AddcustomerLinkLabel.Size = New System.Drawing.Size(164, 17)
        Me.AddcustomerLinkLabel.TabIndex = 5
        Me.AddcustomerLinkLabel.TabStop = True
        Me.AddcustomerLinkLabel.Text = "Add Customer Details"
        '
        'ViewProductLinkLabel
        '
        Me.ViewProductLinkLabel.AutoSize = True
        Me.ViewProductLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewProductLinkLabel.Location = New System.Drawing.Point(484, 159)
        Me.ViewProductLinkLabel.Name = "ViewProductLinkLabel"
        Me.ViewProductLinkLabel.Size = New System.Drawing.Size(157, 17)
        Me.ViewProductLinkLabel.TabIndex = 6
        Me.ViewProductLinkLabel.TabStop = True
        Me.ViewProductLinkLabel.Text = "View Product Details"
        '
        'StaffHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 403)
        Me.Controls.Add(Me.ViewProductLinkLabel)
        Me.Controls.Add(Me.AddcustomerLinkLabel)
        Me.Controls.Add(Me.StaffdetailsLinkLabel)
        Me.Controls.Add(Me.AdminLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Name = "StaffHome"
        Me.Text = "StaffHome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents AdminLabel As System.Windows.Forms.Label
    Friend WithEvents StaffdetailsLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents AddcustomerLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents ViewProductLinkLabel As System.Windows.Forms.LinkLabel
End Class
