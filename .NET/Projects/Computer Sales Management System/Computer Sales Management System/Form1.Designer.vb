<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.AdminLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.StaffLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(241, 30)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(298, 25)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Computer Sales Management"
        '
        'AdminLinkLabel
        '
        Me.AdminLinkLabel.AutoSize = True
        Me.AdminLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminLinkLabel.Location = New System.Drawing.Point(217, 93)
        Me.AdminLinkLabel.Name = "AdminLinkLabel"
        Me.AdminLinkLabel.Size = New System.Drawing.Size(61, 20)
        Me.AdminLinkLabel.TabIndex = 1
        Me.AdminLinkLabel.TabStop = True
        Me.AdminLinkLabel.Text = "Admin"
        '
        'StaffLinkLabel
        '
        Me.StaffLinkLabel.AutoSize = True
        Me.StaffLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffLinkLabel.Location = New System.Drawing.Point(522, 93)
        Me.StaffLinkLabel.Name = "StaffLinkLabel"
        Me.StaffLinkLabel.Size = New System.Drawing.Size(49, 20)
        Me.StaffLinkLabel.TabIndex = 2
        Me.StaffLinkLabel.TabStop = True
        Me.StaffLinkLabel.Text = "Staff"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(140, 139)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(383, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 433)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StaffLinkLabel)
        Me.Controls.Add(Me.AdminLinkLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents AdminLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents StaffLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
