<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerDetailsForm
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
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

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAddStock = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.LabelHeader = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerAddressTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerPhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.PanelForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddStock
        '
        Me.btnAddStock.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddStock.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddStock.ForeColor = System.Drawing.Color.White
        Me.btnAddStock.Location = New System.Drawing.Point(30, 310)
        Me.btnAddStock.Name = "btnAddStock"
        Me.btnAddStock.Size = New System.Drawing.Size(130, 45)
        Me.btnAddStock.TabIndex = 10
        Me.btnAddStock.Text = "Add Customer"
        Me.btnAddStock.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(190, 310)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(130, 45)
        Me.btnRefresh.TabIndex = 11
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.IndianRed
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(340, 310)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(130, 45)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'LabelHeader
        '
        Me.LabelHeader.AutoSize = True
        Me.LabelHeader.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelHeader.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.LabelHeader.Location = New System.Drawing.Point(87, 26)
        Me.LabelHeader.Name = "LabelHeader"
        Me.LabelHeader.Size = New System.Drawing.Size(331, 41)
        Me.LabelHeader.TabIndex = 1
        Me.LabelHeader.Text = "Customer Information"
        Me.LabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customer ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Customer Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Customer Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(3, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Customer Phone No.:"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(180, 20)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(220, 30)
        Me.CustomerIDTextBox.TabIndex = 3
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(180, 65)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(220, 30)
        Me.CustomerNameTextBox.TabIndex = 5
        '
        'CustomerAddressTextBox
        '
        Me.CustomerAddressTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CustomerAddressTextBox.Location = New System.Drawing.Point(180, 110)
        Me.CustomerAddressTextBox.Name = "CustomerAddressTextBox"
        Me.CustomerAddressTextBox.Size = New System.Drawing.Size(220, 30)
        Me.CustomerAddressTextBox.TabIndex = 7
        '
        'CustomerPhoneNumberTextBox
        '
        Me.CustomerPhoneNumberTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CustomerPhoneNumberTextBox.Location = New System.Drawing.Point(180, 155)
        Me.CustomerPhoneNumberTextBox.Name = "CustomerPhoneNumberTextBox"
        Me.CustomerPhoneNumberTextBox.Size = New System.Drawing.Size(220, 30)
        Me.CustomerPhoneNumberTextBox.TabIndex = 9
        '
        'PanelForm
        '
        Me.PanelForm.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelForm.Controls.Add(Me.Label1)
        Me.PanelForm.Controls.Add(Me.Label2)
        Me.PanelForm.Controls.Add(Me.Label3)
        Me.PanelForm.Controls.Add(Me.Label4)
        Me.PanelForm.Controls.Add(Me.CustomerIDTextBox)
        Me.PanelForm.Controls.Add(Me.CustomerNameTextBox)
        Me.PanelForm.Controls.Add(Me.CustomerAddressTextBox)
        Me.PanelForm.Controls.Add(Me.CustomerPhoneNumberTextBox)
        Me.PanelForm.Location = New System.Drawing.Point(30, 70)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(440, 220)
        Me.PanelForm.TabIndex = 0
        '
        'CustomerDetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(500, 380)
        Me.Controls.Add(Me.PanelForm)
        Me.Controls.Add(Me.LabelHeader)
        Me.Controls.Add(Me.btnAddStock)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "CustomerDetailsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Details"
        Me.PanelForm.ResumeLayout(False)
        Me.PanelForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddStock As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents LabelHeader As System.Windows.Forms.Label
    Friend WithEvents PanelForm As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CustomerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerPhoneNumberTextBox As System.Windows.Forms.TextBox
End Class
