<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create
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
        Me.CreateLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.EmailDLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.RoleLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailIDTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.RoleComboBox = New System.Windows.Forms.ComboBox()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.LoginLabel = New System.Windows.Forms.Label()
        Me.LoginLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'CreateLabel
        '
        Me.CreateLabel.AutoSize = True
        Me.CreateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateLabel.Location = New System.Drawing.Point(140, 57)
        Me.CreateLabel.Name = "CreateLabel"
        Me.CreateLabel.Size = New System.Drawing.Size(151, 20)
        Me.CreateLabel.TabIndex = 0
        Me.CreateLabel.Text = "Create Account !"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(26, 111)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(81, 17)
        Me.UsernameLabel.TabIndex = 1
        Me.UsernameLabel.Text = "Username"
        '
        'EmailDLabel
        '
        Me.EmailDLabel.AutoSize = True
        Me.EmailDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailDLabel.Location = New System.Drawing.Point(26, 168)
        Me.EmailDLabel.Name = "EmailDLabel"
        Me.EmailDLabel.Size = New System.Drawing.Size(68, 17)
        Me.EmailDLabel.TabIndex = 2
        Me.EmailDLabel.Text = "Email-ID"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(26, 233)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(77, 17)
        Me.PasswordLabel.TabIndex = 3
        Me.PasswordLabel.Text = "Password"
        '
        'RoleLabel
        '
        Me.RoleLabel.AutoSize = True
        Me.RoleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoleLabel.Location = New System.Drawing.Point(30, 293)
        Me.RoleLabel.Name = "RoleLabel"
        Me.RoleLabel.Size = New System.Drawing.Size(41, 17)
        Me.RoleLabel.TabIndex = 4
        Me.RoleLabel.Text = "Role"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(152, 111)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(172, 22)
        Me.UsernameTextBox.TabIndex = 5
        '
        'EmailIDTextBox
        '
        Me.EmailIDTextBox.Location = New System.Drawing.Point(152, 168)
        Me.EmailIDTextBox.Name = "EmailIDTextBox"
        Me.EmailIDTextBox.Size = New System.Drawing.Size(172, 22)
        Me.EmailIDTextBox.TabIndex = 6
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(152, 233)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(172, 22)
        Me.PasswordTextBox.TabIndex = 7
        '
        'RoleComboBox
        '
        Me.RoleComboBox.FormattingEnabled = True
        Me.RoleComboBox.Items.AddRange(New Object() {"User", "Admin"})
        Me.RoleComboBox.Location = New System.Drawing.Point(152, 293)
        Me.RoleComboBox.Name = "RoleComboBox"
        Me.RoleComboBox.Size = New System.Drawing.Size(172, 24)
        Me.RoleComboBox.TabIndex = 8
        '
        'CreateButton
        '
        Me.CreateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateButton.Location = New System.Drawing.Point(113, 346)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(172, 23)
        Me.CreateButton.TabIndex = 9
        Me.CreateButton.Text = "Create an Account!"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'LoginLabel
        '
        Me.LoginLabel.AutoSize = True
        Me.LoginLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginLabel.Location = New System.Drawing.Point(30, 383)
        Me.LoginLabel.Name = "LoginLabel"
        Me.LoginLabel.Size = New System.Drawing.Size(182, 17)
        Me.LoginLabel.TabIndex = 10
        Me.LoginLabel.Text = "Already having account!"
        '
        'LoginLinkLabel
        '
        Me.LoginLinkLabel.AutoSize = True
        Me.LoginLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginLinkLabel.Location = New System.Drawing.Point(200, 383)
        Me.LoginLinkLabel.Name = "LoginLinkLabel"
        Me.LoginLinkLabel.Size = New System.Drawing.Size(52, 17)
        Me.LoginLinkLabel.TabIndex = 11
        Me.LoginLinkLabel.TabStop = True
        Me.LoginLinkLabel.Text = "Login!"
        '
        'Create
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 409)
        Me.Controls.Add(Me.LoginLinkLabel)
        Me.Controls.Add(Me.LoginLabel)
        Me.Controls.Add(Me.CreateButton)
        Me.Controls.Add(Me.RoleComboBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.EmailIDTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.RoleLabel)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.EmailDLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.CreateLabel)
        Me.Name = "Create"
        Me.Text = "Create"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CreateLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents EmailDLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents RoleLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RoleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CreateButton As System.Windows.Forms.Button
    Friend WithEvents LoginLabel As System.Windows.Forms.Label
    Friend WithEvents LoginLinkLabel As System.Windows.Forms.LinkLabel
End Class
