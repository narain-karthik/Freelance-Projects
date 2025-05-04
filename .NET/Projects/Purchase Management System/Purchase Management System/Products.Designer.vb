<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
    Inherits System.Windows.Forms.Form

    ' Dispose
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

    ' Form Components
    Private components As System.ComponentModel.IContainer
    Friend WithEvents cmbProductName As ComboBox
    Friend WithEvents txtPurchasePrice As TextBox
    Friend WithEvents txtSellingPrice As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblPurchasePrice As Label
    Friend WithEvents lblSellingPrice As Label

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbProductName = New System.Windows.Forms.ComboBox()
        Me.txtPurchasePrice = New System.Windows.Forms.TextBox()
        Me.txtSellingPrice = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblPurchasePrice = New System.Windows.Forms.Label()
        Me.lblSellingPrice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbProductName
        '
        Me.cmbProductName.Location = New System.Drawing.Point(150, 25)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(200, 24)
        Me.cmbProductName.TabIndex = 1
        '
        'txtPurchasePrice
        '
        Me.txtPurchasePrice.Location = New System.Drawing.Point(150, 65)
        Me.txtPurchasePrice.Name = "txtPurchasePrice"
        Me.txtPurchasePrice.Size = New System.Drawing.Size(200, 22)
        Me.txtPurchasePrice.TabIndex = 3
        '
        'txtSellingPrice
        '
        Me.txtSellingPrice.Location = New System.Drawing.Point(150, 105)
        Me.txtSellingPrice.Name = "txtSellingPrice"
        Me.txtSellingPrice.Size = New System.Drawing.Size(200, 22)
        Me.txtSellingPrice.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(150, 150)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(30, 30)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(98, 17)
        Me.lblProductName.TabIndex = 0
        Me.lblProductName.Text = "Product Name"
        '
        'lblPurchasePrice
        '
        Me.lblPurchasePrice.AutoSize = True
        Me.lblPurchasePrice.Location = New System.Drawing.Point(30, 70)
        Me.lblPurchasePrice.Name = "lblPurchasePrice"
        Me.lblPurchasePrice.Size = New System.Drawing.Size(104, 17)
        Me.lblPurchasePrice.TabIndex = 2
        Me.lblPurchasePrice.Text = "Purchase Price"
        '
        'lblSellingPrice
        '
        Me.lblSellingPrice.AutoSize = True
        Me.lblSellingPrice.Location = New System.Drawing.Point(30, 110)
        Me.lblSellingPrice.Name = "lblSellingPrice"
        Me.lblSellingPrice.Size = New System.Drawing.Size(86, 17)
        Me.lblSellingPrice.TabIndex = 4
        Me.lblSellingPrice.Text = "Selling Price"
        '
        'Products
        '
        Me.ClientSize = New System.Drawing.Size(400, 220)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.cmbProductName)
        Me.Controls.Add(Me.lblPurchasePrice)
        Me.Controls.Add(Me.txtPurchasePrice)
        Me.Controls.Add(Me.lblSellingPrice)
        Me.Controls.Add(Me.txtSellingPrice)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "Products"
        Me.Text = "Add Product Price"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
