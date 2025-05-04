Public Class AdminHome

    Private Sub AddstaffLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AddstaffLinkLabel.LinkClicked
        Dim Staff As New Staff()
        Staff.Show()

    End Sub

    Private Sub ViewCustomerLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ViewCustomerLinkLabel.LinkClicked
        Dim View As New ViewCus()
        View.Show()
    End Sub

    Private Sub AddproductLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AddproductLinkLabel.LinkClicked
        Dim Add As New AddProduct()
        Add.Show()
    End Sub
End Class