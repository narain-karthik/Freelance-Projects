Imports System.Data.SqlClient

Public Class AdminHomePage
    Inherits Form



    Public Sub New()
        InitializeComponent()
        sample()

    End Sub

    Private Sub sample()
        Me.Text = "Admin Home"
        Me.Size = New Size(400, 300)
        Me.BackColor = Color.LightGreen


    End Sub

    ' Logout Button Click Event
    Private Sub BtnLogout_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim loginForm As New Form1()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddStaffDetails_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStaffDetails.Click
        ' Create a new instance of the AddStaffDetails form and show it
        Dim addStaffForm As New AddStaffDetails()
        addStaffForm.Show()
    End Sub

    Private Sub ViewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewButton.Click
        ' Create a new instance of the AddStaffDetails form and show it
        Dim addStaffForm As New ViewStaffDetails()
        addStaffForm.Show()
    End Sub

    
    Private Sub btnMarkAttendance_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkAttendance.Click
        ' Create a new instance of the AddStaffDetails form and show it
        Dim addStaffForm As New MarkAttendance()
        addStaffForm.Show()
    End Sub

    Private Sub btnAttendanceDetails_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAttendanceDetails.Click
        ' Create a new instance of the AddStaffDetails form and show it
        Dim addStaffForm As New AttendanceDetails()
        addStaffForm.Show()
    End Sub
End Class
