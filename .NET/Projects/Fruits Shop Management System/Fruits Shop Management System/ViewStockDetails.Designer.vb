<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewStockDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.dgvStockDetails = New System.Windows.Forms.DataGridView()
        Me.btnLoad = New System.Windows.Forms.Button()
        CType(Me.dgvStockDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(180, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(166, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Stock Details"
        '
        'dgvStockDetails
        '
        Me.dgvStockDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStockDetails.Location = New System.Drawing.Point(30, 70)
        Me.dgvStockDetails.Name = "dgvStockDetails"
        Me.dgvStockDetails.ReadOnly = True
        Me.dgvStockDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStockDetails.Size = New System.Drawing.Size(540, 300)
        Me.dgvStockDetails.TabIndex = 1
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(450, 380)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(120, 30)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "Load Stock"
        '
        'ViewStockDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 430)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.dgvStockDetails)
        Me.Controls.Add(Me.btnLoad)
        Me.Name = "ViewStockDetails"
        Me.Text = "View Stock Details"
        CType(Me.dgvStockDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private lblTitle As System.Windows.Forms.Label
    Friend WithEvents dgvStockDetails As System.Windows.Forms.DataGridView
    Friend WithEvents btnLoad As System.Windows.Forms.Button

End Class
