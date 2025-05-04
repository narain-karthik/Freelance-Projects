<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Unreservation
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TrainNumberComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TrainNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FromComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToComboBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ReservationDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BookTicketButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sothern Railways"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(241, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Unreservation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Train Number"
        '
        'TrainNumberComboBox
        '
        Me.TrainNumberComboBox.FormattingEnabled = True
        Me.TrainNumberComboBox.Items.AddRange(New Object() {"0101", "0102", "0103", "0104"})
        Me.TrainNumberComboBox.Location = New System.Drawing.Point(189, 143)
        Me.TrainNumberComboBox.Name = "TrainNumberComboBox"
        Me.TrainNumberComboBox.Size = New System.Drawing.Size(121, 24)
        Me.TrainNumberComboBox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Train Name"
        '
        'TrainNameComboBox
        '
        Me.TrainNameComboBox.FormattingEnabled = True
        Me.TrainNameComboBox.Items.AddRange(New Object() {"Chennai Egmore - Kanyakumari Express ( 0101)", "Chennai Central - Coimbatore Shatabdi Express (0102)", "Kanyakumari - Mumbai CSMT Express (0103)", "Mangaluru Central - Chennai Central Mail (0104)"})
        Me.TrainNameComboBox.Location = New System.Drawing.Point(189, 197)
        Me.TrainNameComboBox.Name = "TrainNameComboBox"
        Me.TrainNameComboBox.Size = New System.Drawing.Size(121, 24)
        Me.TrainNameComboBox.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(345, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "From"
        '
        'FromComboBox
        '
        Me.FromComboBox.FormattingEnabled = True
        Me.FromComboBox.Items.AddRange(New Object() {"Chennai Egmore ", "Chennai Central ", "Kanyakumari ", "Mangaluru Central ", "Chidambaram", "Mayiladuthurai", "Kumbakonam ", "Thanjavur ", "Tiruchchirappalli ", "Dindigul ", "Tirunelveli ", "Nagercoil ", "Kanyakumari", "Madurai", "Salem ", " Erode ", "Tiruppur ", "Coimbatore", ""})
        Me.FromComboBox.Location = New System.Drawing.Point(424, 143)
        Me.FromComboBox.Name = "FromComboBox"
        Me.FromComboBox.Size = New System.Drawing.Size(121, 24)
        Me.FromComboBox.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(345, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "To"
        '
        'ToComboBox
        '
        Me.ToComboBox.FormattingEnabled = True
        Me.ToComboBox.Items.AddRange(New Object() {"Chennai Egmore ", "Chennai Central ", "Kanyakumari ", "Mangaluru Central ", "Chidambaram", "Mayiladuthurai", "Kumbakonam ", "Thanjavur ", "Tiruchchirappalli ", "Dindigul ", "Tirunelveli ", "Nagercoil ", "Kanyakumari", "Madurai", "Salem ", " Erode ", "Tiruppur ", "Coimbatore", ""})
        Me.ToComboBox.Location = New System.Drawing.Point(424, 190)
        Me.ToComboBox.Name = "ToComboBox"
        Me.ToComboBox.Size = New System.Drawing.Size(121, 24)
        Me.ToComboBox.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(63, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Date"
        '
        'ReservationDateTimePicker
        '
        Me.ReservationDateTimePicker.Location = New System.Drawing.Point(189, 246)
        Me.ReservationDateTimePicker.Name = "ReservationDateTimePicker"
        Me.ReservationDateTimePicker.Size = New System.Drawing.Size(121, 22)
        Me.ReservationDateTimePicker.TabIndex = 15
        '
        'BookTicketButton
        '
        Me.BookTicketButton.Location = New System.Drawing.Point(245, 309)
        Me.BookTicketButton.Name = "BookTicketButton"
        Me.BookTicketButton.Size = New System.Drawing.Size(111, 28)
        Me.BookTicketButton.TabIndex = 16
        Me.BookTicketButton.Text = "Book Ticket"
        Me.BookTicketButton.UseVisualStyleBackColor = True
        '
        'Unreservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 411)
        Me.Controls.Add(Me.BookTicketButton)
        Me.Controls.Add(Me.ReservationDateTimePicker)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ToComboBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.FromComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TrainNameComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TrainNumberComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Unreservation"
        Me.Text = "Unreservation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TrainNumberComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TrainNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FromComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ReservationDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BookTicketButton As System.Windows.Forms.Button
End Class
