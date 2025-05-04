<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableManagement
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
        Me.LabelHeader = New System.Windows.Forms.Label()
        Me.GroupBoxTableDetails = New System.Windows.Forms.GroupBox()
        Me.LocationComboBox = New System.Windows.Forms.ComboBox()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.SeatsTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.TableNumberTextBox = New System.Windows.Forms.TextBox()
        Me.TableIDTextBox = New System.Windows.Forms.TextBox()
        Me.LabelLocation = New System.Windows.Forms.Label()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.LabelSeats = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelTableNumber = New System.Windows.Forms.Label()
        Me.LabelTableID = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.GroupBoxTableDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelHeader
        '
        Me.LabelHeader.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LabelHeader.Location = New System.Drawing.Point(80, 20)
        Me.LabelHeader.Name = "LabelHeader"
        Me.LabelHeader.Size = New System.Drawing.Size(300, 40)
        Me.LabelHeader.TabIndex = 0
        Me.LabelHeader.Text = "Table Management"
        Me.LabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBoxTableDetails
        '
        Me.GroupBoxTableDetails.Controls.Add(Me.LocationComboBox)
        Me.GroupBoxTableDetails.Controls.Add(Me.StatusComboBox)
        Me.GroupBoxTableDetails.Controls.Add(Me.SeatsTextBox)
        Me.GroupBoxTableDetails.Controls.Add(Me.NameTextBox)
        Me.GroupBoxTableDetails.Controls.Add(Me.TableNumberTextBox)
        Me.GroupBoxTableDetails.Controls.Add(Me.TableIDTextBox)
        Me.GroupBoxTableDetails.Controls.Add(Me.LabelLocation)
        Me.GroupBoxTableDetails.Controls.Add(Me.LabelStatus)
        Me.GroupBoxTableDetails.Controls.Add(Me.LabelSeats)
        Me.GroupBoxTableDetails.Controls.Add(Me.LabelName)
        Me.GroupBoxTableDetails.Controls.Add(Me.LabelTableNumber)
        Me.GroupBoxTableDetails.Controls.Add(Me.LabelTableID)
        Me.GroupBoxTableDetails.Location = New System.Drawing.Point(40, 80)
        Me.GroupBoxTableDetails.Name = "GroupBoxTableDetails"
        Me.GroupBoxTableDetails.Size = New System.Drawing.Size(380, 320)
        Me.GroupBoxTableDetails.TabIndex = 1
        Me.GroupBoxTableDetails.TabStop = False
        Me.GroupBoxTableDetails.Text = "Enter Table Details"
        '
        'LocationComboBox
        '
        Me.LocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LocationComboBox.FormattingEnabled = True
        Me.LocationComboBox.Items.AddRange(New Object() {"Indoor", "Outdoor", "Balcony"})
        Me.LocationComboBox.Location = New System.Drawing.Point(150, 260)
        Me.LocationComboBox.Name = "LocationComboBox"
        Me.LocationComboBox.Size = New System.Drawing.Size(200, 24)
        Me.LocationComboBox.TabIndex = 11
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"Available", "Occupied", "Reserved", "Cleaning"})
        Me.StatusComboBox.Location = New System.Drawing.Point(150, 215)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(200, 24)
        Me.StatusComboBox.TabIndex = 10
        '
        'SeatsTextBox
        '
        Me.SeatsTextBox.Location = New System.Drawing.Point(150, 170)
        Me.SeatsTextBox.Name = "SeatsTextBox"
        Me.SeatsTextBox.Size = New System.Drawing.Size(200, 22)
        Me.SeatsTextBox.TabIndex = 9
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(150, 125)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.NameTextBox.TabIndex = 8
        '
        'TableNumberTextBox
        '
        Me.TableNumberTextBox.Location = New System.Drawing.Point(150, 80)
        Me.TableNumberTextBox.Name = "TableNumberTextBox"
        Me.TableNumberTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TableNumberTextBox.TabIndex = 7
        '
        'TableIDTextBox
        '
        Me.TableIDTextBox.Location = New System.Drawing.Point(150, 35)
        Me.TableIDTextBox.Name = "TableIDTextBox"
        Me.TableIDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TableIDTextBox.TabIndex = 6
        '
        'LabelLocation
        '
        Me.LabelLocation.AutoSize = True
        Me.LabelLocation.Location = New System.Drawing.Point(20, 263)
        Me.LabelLocation.Name = "LabelLocation"
        Me.LabelLocation.Size = New System.Drawing.Size(62, 17)
        Me.LabelLocation.TabIndex = 5
        Me.LabelLocation.Text = "Location"
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(20, 218)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(48, 17)
        Me.LabelStatus.TabIndex = 4
        Me.LabelStatus.Text = "Status"
        '
        'LabelSeats
        '
        Me.LabelSeats.AutoSize = True
        Me.LabelSeats.Location = New System.Drawing.Point(20, 173)
        Me.LabelSeats.Name = "LabelSeats"
        Me.LabelSeats.Size = New System.Drawing.Size(44, 17)
        Me.LabelSeats.TabIndex = 3
        Me.LabelSeats.Text = "Seats"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(20, 128)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(45, 17)
        Me.LabelName.TabIndex = 2
        Me.LabelName.Text = "Name"
        '
        'LabelTableNumber
        '
        Me.LabelTableNumber.AutoSize = True
        Me.LabelTableNumber.Location = New System.Drawing.Point(20, 83)
        Me.LabelTableNumber.Name = "LabelTableNumber"
        Me.LabelTableNumber.Size = New System.Drawing.Size(98, 17)
        Me.LabelTableNumber.TabIndex = 1
        Me.LabelTableNumber.Text = "Table Number"
        '
        'LabelTableID
        '
        Me.LabelTableID.AutoSize = True
        Me.LabelTableID.Location = New System.Drawing.Point(20, 38)
        Me.LabelTableID.Name = "LabelTableID"
        Me.LabelTableID.Size = New System.Drawing.Size(61, 17)
        Me.LabelTableID.TabIndex = 0
        Me.LabelTableID.Text = "Table ID"
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.SaveButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.SaveButton.ForeColor = System.Drawing.Color.White
        Me.SaveButton.Location = New System.Drawing.Point(100, 420)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(100, 35)
        Me.SaveButton.TabIndex = 2
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.IndianRed
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ClearButton.ForeColor = System.Drawing.Color.White
        Me.ClearButton.Location = New System.Drawing.Point(230, 420)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(100, 35)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'TableManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(460, 480)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.GroupBoxTableDetails)
        Me.Controls.Add(Me.LabelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "TableManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Table Management"
        Me.GroupBoxTableDetails.ResumeLayout(False)
        Me.GroupBoxTableDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelHeader As Label
    Friend WithEvents GroupBoxTableDetails As GroupBox
    Friend WithEvents LocationComboBox As ComboBox
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents SeatsTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents TableNumberTextBox As TextBox
    Friend WithEvents TableIDTextBox As TextBox
    Friend WithEvents LabelLocation As Label
    Friend WithEvents LabelStatus As Label
    Friend WithEvents LabelSeats As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelTableNumber As Label
    Friend WithEvents LabelTableID As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents ClearButton As Button

End Class
