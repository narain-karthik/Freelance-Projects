<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductDetails
    Inherits System.Windows.Forms.Form

    ' Clean up any resources being used.
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

    ' Form controls
    Private lblTitle As System.Windows.Forms.Label
    Private lblClothName As System.Windows.Forms.Label
    Private lblQuantity As System.Windows.Forms.Label
    Private lblUnit As System.Windows.Forms.Label
    Private lblPrice As System.Windows.Forms.Label
    Private lblSupplier As System.Windows.Forms.Label
    Private lblPurchase As System.Windows.Forms.Label
    Private lblExpiry As System.Windows.Forms.Label
    Friend WithEvents cmbClothName As System.Windows.Forms.ComboBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents txtPricePerUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplier As System.Windows.Forms.TextBox
    Friend WithEvents dtpPurchaseDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpExpiryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvCloths As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblClothName = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.lblPurchase = New System.Windows.Forms.Label()
        Me.lblExpiry = New System.Windows.Forms.Label()
        Me.cmbClothName = New System.Windows.Forms.ComboBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.txtPricePerUnit = New System.Windows.Forms.TextBox()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.dtpPurchaseDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpExpiryDate = New System.Windows.Forms.DateTimePicker()
        Me.dgvCloths = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.dgvCloths, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(180, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(187, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Manage Cloths"
        '
        'lblClothName
        '
        Me.lblClothName.Location = New System.Drawing.Point(30, 60)
        Me.lblClothName.Name = "lblClothName"
        Me.lblClothName.Size = New System.Drawing.Size(100, 23)
        Me.lblClothName.TabIndex = 1
        Me.lblClothName.Text = "Cloth Name:"
        '
        'lblQuantity
        '
        Me.lblQuantity.Location = New System.Drawing.Point(30, 100)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(100, 23)
        Me.lblQuantity.TabIndex = 3
        Me.lblQuantity.Text = "Quantity:"
        '
        'lblUnit
        '
        Me.lblUnit.Location = New System.Drawing.Point(30, 140)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(100, 23)
        Me.lblUnit.TabIndex = 5
        Me.lblUnit.Text = "Unit:"
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(30, 180)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "Price/Unit:"
        '
        'lblSupplier
        '
        Me.lblSupplier.Location = New System.Drawing.Point(30, 220)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(100, 23)
        Me.lblSupplier.TabIndex = 9
        Me.lblSupplier.Text = "Supplier:"
        '
        'lblPurchase
        '
        Me.lblPurchase.Location = New System.Drawing.Point(30, 260)
        Me.lblPurchase.Name = "lblPurchase"
        Me.lblPurchase.Size = New System.Drawing.Size(100, 23)
        Me.lblPurchase.TabIndex = 11
        Me.lblPurchase.Text = "Purchase Date:"
        '
        'lblExpiry
        '
        Me.lblExpiry.Location = New System.Drawing.Point(30, 300)
        Me.lblExpiry.Name = "lblExpiry"
        Me.lblExpiry.Size = New System.Drawing.Size(100, 23)
        Me.lblExpiry.TabIndex = 13
        Me.lblExpiry.Text = "Expiry Date:"
        '
        'cmbClothName
        '
        Me.cmbClothName.Items.AddRange(New Object() {"Shirt", "T-shirt", "Jeans", "Dress", "Jacket", "Skirt", "Sweater"})
        Me.cmbClothName.Location = New System.Drawing.Point(140, 60)
        Me.cmbClothName.Name = "cmbClothName"
        Me.cmbClothName.Size = New System.Drawing.Size(200, 24)
        Me.cmbClothName.TabIndex = 2
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(140, 100)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(200, 22)
        Me.txtQuantity.TabIndex = 4
        '
        'cmbUnit
        '
        Me.cmbUnit.Items.AddRange(New Object() {"piece", "set", "pair"})
        Me.cmbUnit.Location = New System.Drawing.Point(140, 140)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(200, 24)
        Me.cmbUnit.TabIndex = 6
        '
        'txtPricePerUnit
        '
        Me.txtPricePerUnit.Location = New System.Drawing.Point(140, 180)
        Me.txtPricePerUnit.Name = "txtPricePerUnit"
        Me.txtPricePerUnit.Size = New System.Drawing.Size(200, 22)
        Me.txtPricePerUnit.TabIndex = 8
        '
        'txtSupplier
        '
        Me.txtSupplier.Location = New System.Drawing.Point(140, 220)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(200, 22)
        Me.txtSupplier.TabIndex = 10
        '
        'dtpPurchaseDate
        '
        Me.dtpPurchaseDate.Location = New System.Drawing.Point(140, 260)
        Me.dtpPurchaseDate.Name = "dtpPurchaseDate"
        Me.dtpPurchaseDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpPurchaseDate.TabIndex = 12
        '
        'dtpExpiryDate
        '
        Me.dtpExpiryDate.Location = New System.Drawing.Point(140, 300)
        Me.dtpExpiryDate.Name = "dtpExpiryDate"
        Me.dtpExpiryDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpExpiryDate.TabIndex = 14
        '
        'dgvCloths
        '
        Me.dgvCloths.Location = New System.Drawing.Point(30, 340)
        Me.dgvCloths.Name = "dgvCloths"
        Me.dgvCloths.ReadOnly = True
        Me.dgvCloths.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCloths.Size = New System.Drawing.Size(520, 200)
        Me.dgvCloths.TabIndex = 19
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(370, 60)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 30)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(370, 100)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 30)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "Update"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(370, 140)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 30)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(370, 180)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 30)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        '
        'ProductDetails
        '
        Me.ClientSize = New System.Drawing.Size(600, 560)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblClothName)
        Me.Controls.Add(Me.cmbClothName)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.cmbUnit)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtPricePerUnit)
        Me.Controls.Add(Me.lblSupplier)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.lblPurchase)
        Me.Controls.Add(Me.dtpPurchaseDate)
        Me.Controls.Add(Me.lblExpiry)
        Me.Controls.Add(Me.dtpExpiryDate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dgvCloths)
        Me.Name = "ProductDetails"
        Me.Text = "Product Details"
        CType(Me.dgvCloths, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
