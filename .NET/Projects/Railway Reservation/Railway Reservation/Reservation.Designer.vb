<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ClassComboBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ReservationDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BookTicketButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SNo1ComboBox = New System.Windows.Forms.ComboBox()
        Me.SNo2ComboBox = New System.Windows.Forms.ComboBox()
        Me.SNo3ComboBox = New System.Windows.Forms.ComboBox()
        Me.SNo4ComboBox = New System.Windows.Forms.ComboBox()
        Me.SNo5ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Name1TextBox = New System.Windows.Forms.TextBox()
        Me.Name2TextBox = New System.Windows.Forms.TextBox()
        Me.Name3TextBox = New System.Windows.Forms.TextBox()
        Me.Name4TextBox = New System.Windows.Forms.TextBox()
        Me.Name5TextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Age1TextBox = New System.Windows.Forms.TextBox()
        Me.Age2TextBox = New System.Windows.Forms.TextBox()
        Me.Age3TextBox = New System.Windows.Forms.TextBox()
        Me.Age4TextBox = New System.Windows.Forms.TextBox()
        Me.Age5TextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Sex1ComboBox = New System.Windows.Forms.ComboBox()
        Me.Sex2ComboBox = New System.Windows.Forms.ComboBox()
        Me.Sex3ComboBox = New System.Windows.Forms.ComboBox()
        Me.Sex4ComboBox = New System.Windows.Forms.ComboBox()
        Me.Sex5ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SC1CheckBox = New System.Windows.Forms.CheckBox()
        Me.SC2CheckBox = New System.Windows.Forms.CheckBox()
        Me.SC3CheckBox = New System.Windows.Forms.CheckBox()
        Me.SC4CheckBox = New System.Windows.Forms.CheckBox()
        Me.SC5CheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sothern Railways"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(324, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Reservation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Train Number"
        '
        'TrainNumberComboBox
        '
        Me.TrainNumberComboBox.FormattingEnabled = True
        Me.TrainNumberComboBox.Items.AddRange(New Object() {"0101", "0102", "0103", "0104"})
        Me.TrainNumberComboBox.Location = New System.Drawing.Point(133, 114)
        Me.TrainNumberComboBox.Name = "TrainNumberComboBox"
        Me.TrainNumberComboBox.Size = New System.Drawing.Size(121, 24)
        Me.TrainNumberComboBox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Train Name"
        '
        'TrainNameComboBox
        '
        Me.TrainNameComboBox.FormattingEnabled = True
        Me.TrainNameComboBox.Items.AddRange(New Object() {"Chennai Egmore - Kanyakumari Express ( 0101)", "Chennai Central - Coimbatore Shatabdi Express (0102)", "Kanyakumari - Mumbai CSMT Express (0103)", "Mangaluru Central - Chennai Central Mail (0104)"})
        Me.TrainNameComboBox.Location = New System.Drawing.Point(133, 158)
        Me.TrainNameComboBox.Name = "TrainNameComboBox"
        Me.TrainNameComboBox.Size = New System.Drawing.Size(121, 24)
        Me.TrainNameComboBox.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(281, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "From"
        '
        'FromComboBox
        '
        Me.FromComboBox.FormattingEnabled = True
        Me.FromComboBox.Items.AddRange(New Object() {"Chennai Egmore ", "Chennai Central ", "Kanyakumari ", "Mangaluru Central ", "Chidambaram", "Mayiladuthurai", "Kumbakonam ", "Thanjavur ", "Tiruchchirappalli ", "Dindigul ", "Tirunelveli ", "Nagercoil ", "Kanyakumari", "Madurai", "Salem ", " Erode ", "Tiruppur ", "Coimbatore", ""})
        Me.FromComboBox.Location = New System.Drawing.Point(340, 118)
        Me.FromComboBox.Name = "FromComboBox"
        Me.FromComboBox.Size = New System.Drawing.Size(121, 24)
        Me.FromComboBox.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(281, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "To"
        '
        'ToComboBox
        '
        Me.ToComboBox.FormattingEnabled = True
        Me.ToComboBox.Items.AddRange(New Object() {"Chennai Egmore ", "Chennai Central ", "Kanyakumari ", "Mangaluru Central ", "Chidambaram", "Mayiladuthurai", "Kumbakonam ", "Thanjavur ", "Tiruchchirappalli ", "Dindigul ", "Tirunelveli ", "Nagercoil ", "Kanyakumari", "Madurai", "Salem ", " Erode ", "Tiruppur ", "Coimbatore", ""})
        Me.ToComboBox.Location = New System.Drawing.Point(340, 154)
        Me.ToComboBox.Name = "ToComboBox"
        Me.ToComboBox.Size = New System.Drawing.Size(121, 24)
        Me.ToComboBox.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Class"
        '
        'ClassComboBox
        '
        Me.ClassComboBox.FormattingEnabled = True
        Me.ClassComboBox.Items.AddRange(New Object() {"Sleeper", "1A (1st Class)", "2A (2nd Class)", "3A (3rd Class)"})
        Me.ClassComboBox.Location = New System.Drawing.Point(133, 207)
        Me.ClassComboBox.Name = "ClassComboBox"
        Me.ClassComboBox.Size = New System.Drawing.Size(121, 24)
        Me.ClassComboBox.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(284, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Date"
        '
        'ReservationDateTimePicker
        '
        Me.ReservationDateTimePicker.Location = New System.Drawing.Point(340, 213)
        Me.ReservationDateTimePicker.Name = "ReservationDateTimePicker"
        Me.ReservationDateTimePicker.Size = New System.Drawing.Size(121, 22)
        Me.ReservationDateTimePicker.TabIndex = 14
        '
        'BookTicketButton
        '
        Me.BookTicketButton.Location = New System.Drawing.Point(543, 250)
        Me.BookTicketButton.Name = "BookTicketButton"
        Me.BookTicketButton.Size = New System.Drawing.Size(111, 28)
        Me.BookTicketButton.TabIndex = 15
        Me.BookTicketButton.Text = "Book Ticket"
        Me.BookTicketButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(543, 312)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(111, 28)
        Me.ClearButton.TabIndex = 16
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 283)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "S.No"
        '
        'SNo1ComboBox
        '
        Me.SNo1ComboBox.FormattingEnabled = True
        Me.SNo1ComboBox.Items.AddRange(New Object() {"1"})
        Me.SNo1ComboBox.Location = New System.Drawing.Point(19, 316)
        Me.SNo1ComboBox.Name = "SNo1ComboBox"
        Me.SNo1ComboBox.Size = New System.Drawing.Size(39, 24)
        Me.SNo1ComboBox.TabIndex = 18
        '
        'SNo2ComboBox
        '
        Me.SNo2ComboBox.FormattingEnabled = True
        Me.SNo2ComboBox.Items.AddRange(New Object() {"2"})
        Me.SNo2ComboBox.Location = New System.Drawing.Point(19, 359)
        Me.SNo2ComboBox.Name = "SNo2ComboBox"
        Me.SNo2ComboBox.Size = New System.Drawing.Size(39, 24)
        Me.SNo2ComboBox.TabIndex = 19
        '
        'SNo3ComboBox
        '
        Me.SNo3ComboBox.FormattingEnabled = True
        Me.SNo3ComboBox.Items.AddRange(New Object() {"3"})
        Me.SNo3ComboBox.Location = New System.Drawing.Point(19, 398)
        Me.SNo3ComboBox.Name = "SNo3ComboBox"
        Me.SNo3ComboBox.Size = New System.Drawing.Size(39, 24)
        Me.SNo3ComboBox.TabIndex = 20
        '
        'SNo4ComboBox
        '
        Me.SNo4ComboBox.FormattingEnabled = True
        Me.SNo4ComboBox.Items.AddRange(New Object() {"4"})
        Me.SNo4ComboBox.Location = New System.Drawing.Point(19, 442)
        Me.SNo4ComboBox.Name = "SNo4ComboBox"
        Me.SNo4ComboBox.Size = New System.Drawing.Size(39, 24)
        Me.SNo4ComboBox.TabIndex = 21
        '
        'SNo5ComboBox
        '
        Me.SNo5ComboBox.FormattingEnabled = True
        Me.SNo5ComboBox.Items.AddRange(New Object() {"5"})
        Me.SNo5ComboBox.Location = New System.Drawing.Point(19, 481)
        Me.SNo5ComboBox.Name = "SNo5ComboBox"
        Me.SNo5ComboBox.Size = New System.Drawing.Size(39, 24)
        Me.SNo5ComboBox.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(130, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 17)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Name"
        '
        'Name1TextBox
        '
        Me.Name1TextBox.Location = New System.Drawing.Point(107, 317)
        Me.Name1TextBox.Name = "Name1TextBox"
        Me.Name1TextBox.Size = New System.Drawing.Size(113, 22)
        Me.Name1TextBox.TabIndex = 24
        '
        'Name2TextBox
        '
        Me.Name2TextBox.Location = New System.Drawing.Point(107, 359)
        Me.Name2TextBox.Name = "Name2TextBox"
        Me.Name2TextBox.Size = New System.Drawing.Size(113, 22)
        Me.Name2TextBox.TabIndex = 25
        '
        'Name3TextBox
        '
        Me.Name3TextBox.Location = New System.Drawing.Point(107, 398)
        Me.Name3TextBox.Name = "Name3TextBox"
        Me.Name3TextBox.Size = New System.Drawing.Size(113, 22)
        Me.Name3TextBox.TabIndex = 26
        '
        'Name4TextBox
        '
        Me.Name4TextBox.Location = New System.Drawing.Point(107, 444)
        Me.Name4TextBox.Name = "Name4TextBox"
        Me.Name4TextBox.Size = New System.Drawing.Size(113, 22)
        Me.Name4TextBox.TabIndex = 27
        '
        'Name5TextBox
        '
        Me.Name5TextBox.Location = New System.Drawing.Point(107, 483)
        Me.Name5TextBox.Name = "Name5TextBox"
        Me.Name5TextBox.Size = New System.Drawing.Size(113, 22)
        Me.Name5TextBox.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(264, 283)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 17)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Age"
        '
        'Age1TextBox
        '
        Me.Age1TextBox.Location = New System.Drawing.Point(267, 316)
        Me.Age1TextBox.Name = "Age1TextBox"
        Me.Age1TextBox.Size = New System.Drawing.Size(30, 22)
        Me.Age1TextBox.TabIndex = 30
        '
        'Age2TextBox
        '
        Me.Age2TextBox.Location = New System.Drawing.Point(267, 359)
        Me.Age2TextBox.Name = "Age2TextBox"
        Me.Age2TextBox.Size = New System.Drawing.Size(30, 22)
        Me.Age2TextBox.TabIndex = 31
        '
        'Age3TextBox
        '
        Me.Age3TextBox.Location = New System.Drawing.Point(267, 398)
        Me.Age3TextBox.Name = "Age3TextBox"
        Me.Age3TextBox.Size = New System.Drawing.Size(30, 22)
        Me.Age3TextBox.TabIndex = 32
        '
        'Age4TextBox
        '
        Me.Age4TextBox.Location = New System.Drawing.Point(267, 444)
        Me.Age4TextBox.Name = "Age4TextBox"
        Me.Age4TextBox.Size = New System.Drawing.Size(30, 22)
        Me.Age4TextBox.TabIndex = 33
        '
        'Age5TextBox
        '
        Me.Age5TextBox.Location = New System.Drawing.Point(267, 483)
        Me.Age5TextBox.Name = "Age5TextBox"
        Me.Age5TextBox.Size = New System.Drawing.Size(30, 22)
        Me.Age5TextBox.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(337, 283)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 17)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Sex"
        '
        'Sex1ComboBox
        '
        Me.Sex1ComboBox.FormattingEnabled = True
        Me.Sex1ComboBox.Items.AddRange(New Object() {"M", "F", "O"})
        Me.Sex1ComboBox.Location = New System.Drawing.Point(332, 314)
        Me.Sex1ComboBox.Name = "Sex1ComboBox"
        Me.Sex1ComboBox.Size = New System.Drawing.Size(39, 24)
        Me.Sex1ComboBox.TabIndex = 36
        '
        'Sex2ComboBox
        '
        Me.Sex2ComboBox.FormattingEnabled = True
        Me.Sex2ComboBox.Items.AddRange(New Object() {"F", "O", "M"})
        Me.Sex2ComboBox.Location = New System.Drawing.Point(332, 359)
        Me.Sex2ComboBox.Name = "Sex2ComboBox"
        Me.Sex2ComboBox.Size = New System.Drawing.Size(39, 24)
        Me.Sex2ComboBox.TabIndex = 37
        '
        'Sex3ComboBox
        '
        Me.Sex3ComboBox.FormattingEnabled = True
        Me.Sex3ComboBox.Items.AddRange(New Object() {"M", "F", "O"})
        Me.Sex3ComboBox.Location = New System.Drawing.Point(332, 398)
        Me.Sex3ComboBox.Name = "Sex3ComboBox"
        Me.Sex3ComboBox.Size = New System.Drawing.Size(39, 24)
        Me.Sex3ComboBox.TabIndex = 38
        '
        'Sex4ComboBox
        '
        Me.Sex4ComboBox.FormattingEnabled = True
        Me.Sex4ComboBox.Items.AddRange(New Object() {"M", "F", "O"})
        Me.Sex4ComboBox.Location = New System.Drawing.Point(332, 442)
        Me.Sex4ComboBox.Name = "Sex4ComboBox"
        Me.Sex4ComboBox.Size = New System.Drawing.Size(39, 24)
        Me.Sex4ComboBox.TabIndex = 39
        '
        'Sex5ComboBox
        '
        Me.Sex5ComboBox.FormattingEnabled = True
        Me.Sex5ComboBox.Items.AddRange(New Object() {"M", "F", "O"})
        Me.Sex5ComboBox.Location = New System.Drawing.Point(332, 483)
        Me.Sex5ComboBox.Name = "Sex5ComboBox"
        Me.Sex5ComboBox.Size = New System.Drawing.Size(39, 24)
        Me.Sex5ComboBox.TabIndex = 40
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(399, 283)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 17)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Senior Citizen"
        '
        'SC1CheckBox
        '
        Me.SC1CheckBox.AutoSize = True
        Me.SC1CheckBox.Location = New System.Drawing.Point(430, 314)
        Me.SC1CheckBox.Name = "SC1CheckBox"
        Me.SC1CheckBox.Size = New System.Drawing.Size(18, 17)
        Me.SC1CheckBox.TabIndex = 42
        Me.SC1CheckBox.UseVisualStyleBackColor = True
        '
        'SC2CheckBox
        '
        Me.SC2CheckBox.AutoSize = True
        Me.SC2CheckBox.Location = New System.Drawing.Point(430, 359)
        Me.SC2CheckBox.Name = "SC2CheckBox"
        Me.SC2CheckBox.Size = New System.Drawing.Size(18, 17)
        Me.SC2CheckBox.TabIndex = 43
        Me.SC2CheckBox.UseVisualStyleBackColor = True
        '
        'SC3CheckBox
        '
        Me.SC3CheckBox.AutoSize = True
        Me.SC3CheckBox.Location = New System.Drawing.Point(430, 402)
        Me.SC3CheckBox.Name = "SC3CheckBox"
        Me.SC3CheckBox.Size = New System.Drawing.Size(18, 17)
        Me.SC3CheckBox.TabIndex = 44
        Me.SC3CheckBox.UseVisualStyleBackColor = True
        '
        'SC4CheckBox
        '
        Me.SC4CheckBox.AutoSize = True
        Me.SC4CheckBox.Location = New System.Drawing.Point(430, 449)
        Me.SC4CheckBox.Name = "SC4CheckBox"
        Me.SC4CheckBox.Size = New System.Drawing.Size(18, 17)
        Me.SC4CheckBox.TabIndex = 45
        Me.SC4CheckBox.UseVisualStyleBackColor = True
        '
        'SC5CheckBox
        '
        Me.SC5CheckBox.AutoSize = True
        Me.SC5CheckBox.Location = New System.Drawing.Point(430, 490)
        Me.SC5CheckBox.Name = "SC5CheckBox"
        Me.SC5CheckBox.Size = New System.Drawing.Size(18, 17)
        Me.SC5CheckBox.TabIndex = 46
        Me.SC5CheckBox.UseVisualStyleBackColor = True
        '
        'Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 551)
        Me.Controls.Add(Me.SC5CheckBox)
        Me.Controls.Add(Me.SC4CheckBox)
        Me.Controls.Add(Me.SC3CheckBox)
        Me.Controls.Add(Me.SC2CheckBox)
        Me.Controls.Add(Me.SC1CheckBox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Sex5ComboBox)
        Me.Controls.Add(Me.Sex4ComboBox)
        Me.Controls.Add(Me.Sex3ComboBox)
        Me.Controls.Add(Me.Sex2ComboBox)
        Me.Controls.Add(Me.Sex1ComboBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Age5TextBox)
        Me.Controls.Add(Me.Age4TextBox)
        Me.Controls.Add(Me.Age3TextBox)
        Me.Controls.Add(Me.Age2TextBox)
        Me.Controls.Add(Me.Age1TextBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Name5TextBox)
        Me.Controls.Add(Me.Name4TextBox)
        Me.Controls.Add(Me.Name3TextBox)
        Me.Controls.Add(Me.Name2TextBox)
        Me.Controls.Add(Me.Name1TextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.SNo5ComboBox)
        Me.Controls.Add(Me.SNo4ComboBox)
        Me.Controls.Add(Me.SNo3ComboBox)
        Me.Controls.Add(Me.SNo2ComboBox)
        Me.Controls.Add(Me.SNo1ComboBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.BookTicketButton)
        Me.Controls.Add(Me.ReservationDateTimePicker)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ClassComboBox)
        Me.Controls.Add(Me.Label7)
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
        Me.Name = "Reservation"
        Me.Text = "Reservation"
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ClassComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ReservationDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BookTicketButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SNo1ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SNo2ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SNo3ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SNo4ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SNo5ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Name1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name5TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Age1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Age2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Age3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Age4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Age5TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Sex1ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Sex2ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Sex3ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Sex4ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Sex5ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents SC1CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SC2CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SC3CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SC4CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SC5CheckBox As System.Windows.Forms.CheckBox
End Class
