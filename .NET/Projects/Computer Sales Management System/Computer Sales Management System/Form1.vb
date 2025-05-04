Public Class Form1

    Private Sub AdminLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AdminLinkLabel.LinkClicked
        Dim adminForm As New Login()
        adminForm.Show()
    End Sub

    Private Sub StaffLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles StaffLinkLabel.LinkClicked
        Dim staffForm As New Login()
        staffForm.Show()
    End Sub

    
End Class
