Public Class StaffHome

    Private Sub StaffdetailsLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles StaffdetailsLinkLabel.LinkClicked
        Dim View As New ViewStaff()
        View.Show()
    End Sub

    Private Sub AddcustomerLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AddcustomerLinkLabel.LinkClicked
        Dim Add As New AddCustomer()
        Add.Show()
    End Sub

    Private Sub ViewProductLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ViewProductLinkLabel.LinkClicked
        Dim Pro As New ViewPro()
        Pro.Show()
    End Sub
End Class