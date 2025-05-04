<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
    Inherits System.Windows.Forms.Form

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

    Friend WithEvents lblProduct As Label
    Friend WithEvents cmbProductName As ComboBox
    Friend WithEvents lblStockIn As Label
    Friend WithEvents txtStockIn As TextBox
    Friend WithEvents lblStockOut As Label
    Friend WithEvents txtStockOut As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblTotalAvailable As Label
    Friend WithEvents txtAvailable As TextBox

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.cmbProductName = New System.Windows.Forms.ComboBox()
        Me.lblStockIn = New System.Windows.Forms.Label()
        Me.txtStockIn = New System.Windows.Forms.TextBox()
        Me.lblStockOut = New System.Windows.Forms.Label()
        Me.txtStockOut = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblTotalAvailable = New System.Windows.Forms.Label()
        Me.txtAvailable = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Location = New System.Drawing.Point(30, 30)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(102, 17)
        Me.lblProduct.TabIndex = 0
        Me.lblProduct.Text = "Product Name:"
        '
        'cmbProductName
        '
        Me.cmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductName.FormattingEnabled = True
        Me.cmbProductName.Location = New System.Drawing.Point(176, 27)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(200, 24)
        Me.cmbProductName.TabIndex = 1
        '
        'lblStockIn
        '
        Me.lblStockIn.AutoSize = True
        Me.lblStockIn.Location = New System.Drawing.Point(30, 70)
        Me.lblStockIn.Name = "lblStockIn"
        Me.lblStockIn.Size = New System.Drawing.Size(62, 17)
        Me.lblStockIn.TabIndex = 2
        Me.lblStockIn.Text = "Stock In:"
        '
        'txtStockIn
        '
        Me.txtStockIn.Location = New System.Drawing.Point(203, 70)
        Me.txtStockIn.Name = "txtStockIn"
        Me.txtStockIn.Size = New System.Drawing.Size(100, 22)
        Me.txtStockIn.TabIndex = 3
        '
        'lblStockOut
        '
        Me.lblStockOut.AutoSize = True
        Me.lblStockOut.Location = New System.Drawing.Point(30, 110)
        Me.lblStockOut.Name = "lblStockOut"
        Me.lblStockOut.Size = New System.Drawing.Size(74, 17)
        Me.lblStockOut.TabIndex = 4
        Me.lblStockOut.Text = "Stock Out:"
        '
        'txtStockOut
        '
        Me.txtStockOut.Location = New System.Drawing.Point(203, 110)
        Me.txtStockOut.Name = "txtStockOut"
        Me.txtStockOut.Size = New System.Drawing.Size(100, 22)
        Me.txtStockOut.TabIndex = 5
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(125, 199)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 30)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblTotalAvailable
        '
        Me.lblTotalAvailable.AutoSize = True
        Me.lblTotalAvailable.Location = New System.Drawing.Point(30, 154)
        Me.lblTotalAvailable.Name = "lblTotalAvailable"
        Me.lblTotalAvailable.Size = New System.Drawing.Size(144, 17)
        Me.lblTotalAvailable.TabIndex = 7
        Me.lblTotalAvailable.Text = "Total Available Stock:"
        '
        'txtAvailable
        '
        Me.txtAvailable.Location = New System.Drawing.Point(203, 151)
        Me.txtAvailable.Name = "txtAvailable"
        Me.txtAvailable.ReadOnly = True
        Me.txtAvailable.Size = New System.Drawing.Size(100, 22)
        Me.txtAvailable.TabIndex = 8
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 250)
        Me.Controls.Add(Me.lblProduct)
        Me.Controls.Add(Me.cmbProductName)
        Me.Controls.Add(Me.lblStockIn)
        Me.Controls.Add(Me.txtStockIn)
        Me.Controls.Add(Me.lblStockOut)
        Me.Controls.Add(Me.txtStockOut)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblTotalAvailable)
        Me.Controls.Add(Me.txtAvailable)
        Me.Name = "Stock"
        Me.Text = "Stock Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
