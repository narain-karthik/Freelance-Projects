<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHome
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
        Me.AddstaffLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.AddproductLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ViewCustomerLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(185, 38)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(298, 25)
        Me.TitleLabel.TabIndex = 1
        Me.TitleLabel.Text = "Computer Sales Management"
        '
        'AdminLabel
        '
        Me.AdminLabel.AutoSize = True
        Me.AdminLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminLabel.Location = New System.Drawing.Point(270, 77)
        Me.AdminLabel.Name = "AdminLabel"
        Me.AdminLabel.Size = New System.Drawing.Size(140, 17)
        Me.AdminLabel.TabIndex = 2
        Me.AdminLabel.Text = "Admin Home Page"
        '
        'AddstaffLinkLabel
        '
        Me.AddstaffLinkLabel.AutoSize = True
        Me.AddstaffLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddstaffLinkLabel.Location = New System.Drawing.Point(45, 169)
        Me.AddstaffLinkLabel.Name = "AddstaffLinkLabel"
        Me.AddstaffLinkLabel.Size = New System.Drawing.Size(130, 17)
        Me.AddstaffLinkLabel.TabIndex = 3
        Me.AddstaffLinkLabel.TabStop = True
        Me.AddstaffLinkLabel.Text = "Add Staff Details"
        '
        'AddproductLinkLabel
        '
        Me.AddproductLinkLabel.AutoSize = True
        Me.AddproductLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddproductLinkLabel.Location = New System.Drawing.Point(234, 169)
        Me.AddproductLinkLabel.Name = "AddproductLinkLabel"
        Me.AddproductLinkLabel.Size = New System.Drawing.Size(152, 17)
        Me.AddproductLinkLabel.TabIndex = 4
        Me.AddproductLinkLabel.TabStop = True
        Me.AddproductLinkLabel.Text = "Add Product Details"
        '
        'ViewCustomerLinkLabel
        '
        Me.ViewCustomerLinkLabel.AutoSize = True
        Me.ViewCustomerLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewCustomerLinkLabel.Location = New System.Drawing.Point(453, 169)
        Me.ViewCustomerLinkLabel.Name = "ViewCustomerLinkLabel"
        Me.ViewCustomerLinkLabel.Size = New System.Drawing.Size(169, 17)
        Me.ViewCustomerLinkLabel.TabIndex = 5
        Me.ViewCustomerLinkLabel.TabStop = True
        Me.ViewCustomerLinkLabel.Text = "View Customer Details"
        '
        'AdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 403)
        Me.Controls.Add(Me.ViewCustomerLinkLabel)
        Me.Controls.Add(Me.AddproductLinkLabel)
        Me.Controls.Add(Me.AddstaffLinkLabel)
        Me.Controls.Add(Me.AdminLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Name = "AdminHome"
        Me.Text = "AdminHome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents AdminLabel As System.Windows.Forms.Label
    Friend WithEvents AddstaffLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents AddproductLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents ViewCustomerLinkLabel As System.Windows.Forms.LinkLabel
End Class
