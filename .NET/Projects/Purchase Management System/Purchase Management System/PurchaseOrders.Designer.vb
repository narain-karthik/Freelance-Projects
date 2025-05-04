<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrders
    Inherits System.Windows.Forms.Form

    ' Dispose to clean up components.
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
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents cmbProductName As ComboBox
    Friend WithEvents txtPurchasePrice As TextBox  ' Updated Name
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents dtpOrderDate As DateTimePicker
    Friend WithEvents lblSupplier As Label
    Friend WithEvents lblProduct As Label
    Friend WithEvents lblPurchasePrice As Label  ' Updated Name
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblOrderDate As Label

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.cmbProductName = New System.Windows.Forms.ComboBox()
        Me.txtPurchasePrice = New System.Windows.Forms.TextBox()  ' Updated Name
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.dtpOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.lblPurchasePrice = New System.Windows.Forms.Label()  ' Updated Name
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblOrderDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()

        ' Supplier ComboBox
        Me.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(150, 30)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(200, 24)
        Me.cmbSupplier.TabIndex = 0

        ' Product ComboBox
        Me.cmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductName.FormattingEnabled = True
        Me.cmbProductName.Location = New System.Drawing.Point(150, 70)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(200, 24)
        Me.cmbProductName.TabIndex = 1

        ' Purchase Price TextBox
        Me.txtPurchasePrice.Location = New System.Drawing.Point(150, 110)
        Me.txtPurchasePrice.Name = "txtPurchasePrice"
        Me.txtPurchasePrice.ReadOnly = True
        Me.txtPurchasePrice.Size = New System.Drawing.Size(120, 22)
        Me.txtPurchasePrice.TabIndex = 2

        ' Quantity TextBox
        Me.txtQuantity.Location = New System.Drawing.Point(150, 150)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(120, 22)
        Me.txtQuantity.TabIndex = 3

        ' Total Amount TextBox
        Me.txtTotalAmount.Location = New System.Drawing.Point(150, 190)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(120, 22)
        Me.txtTotalAmount.TabIndex = 4

        ' Submit Button
        Me.btnSubmit.Location = New System.Drawing.Point(150, 270)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(120, 30)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True

        ' Order Date Picker
        Me.dtpOrderDate.Location = New System.Drawing.Point(150, 230)
        Me.dtpOrderDate.Name = "dtpOrderDate"
        Me.dtpOrderDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpOrderDate.TabIndex = 5

        ' Supplier Label
        Me.lblSupplier.Location = New System.Drawing.Point(0, 31)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(100, 23)
        Me.lblSupplier.TabIndex = 7
        Me.lblSupplier.Text = "Supplier"

        ' Product Label
        Me.lblProduct.Location = New System.Drawing.Point(0, 70)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(100, 23)
        Me.lblProduct.TabIndex = 8
        Me.lblProduct.Text = "Product"

        ' Purchase Price Label
        Me.lblPurchasePrice.Location = New System.Drawing.Point(0, 110)
        Me.lblPurchasePrice.Name = "lblPurchasePrice"
        Me.lblPurchasePrice.Size = New System.Drawing.Size(100, 23)
        Me.lblPurchasePrice.TabIndex = 9
        Me.lblPurchasePrice.Text = "Purchase Price"

        ' Quantity Label
        Me.lblQuantity.Location = New System.Drawing.Point(0, 153)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(100, 23)
        Me.lblQuantity.TabIndex = 10
        Me.lblQuantity.Text = "Quantity"

        ' Total Amount Label
        Me.lblTotal.Location = New System.Drawing.Point(0, 189)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "Total Amount"

        ' Order Date Label
        Me.lblOrderDate.Location = New System.Drawing.Point(0, 235)
        Me.lblOrderDate.Name = "lblOrderDate"
        Me.lblOrderDate.Size = New System.Drawing.Size(100, 23)
        Me.lblOrderDate.TabIndex = 12
        Me.lblOrderDate.Text = "Order Date"

        ' Form Settings
        Me.ClientSize = New System.Drawing.Size(400, 330)
        Me.Controls.Add(Me.cmbSupplier)
        Me.Controls.Add(Me.cmbProductName)
        Me.Controls.Add(Me.txtPurchasePrice) ' Updated
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.dtpOrderDate)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblSupplier)
        Me.Controls.Add(Me.lblProduct)
        Me.Controls.Add(Me.lblPurchasePrice) ' Updated
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblOrderDate)
        Me.Name = "PurchaseOrders"
        Me.Text = "Purchase Orders"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
