Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces

Public Class Login

    Private fcon As New FirebaseConfig With
        {
        .AuthSecret = "m5KIfvB60pJPjJx8Ti15R08LqREXCaZhlRcfddL8",
        .BasePath = "https://dairyfarming-e999c-default-rtdb.firebaseio.com/"
    }
    Private client As IFirebaseClient

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Dim reg As New Registration
        reg.ShowDialog()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
#Region "Condition"
        If (String.IsNullOrWhiteSpace(UserIdTextBox.Text) AndAlso String.IsNullOrWhiteSpace(PasswordTextBox.Text)) Then
            MessageBox.Show("please fill all the fields")
            Return
        End If

#End Region

        Dim res = client.Get("Users/" + UserComboBox.Text)
        Dim resUser = res.ResultAs(Of MyUser)

        Dim CurUser As New MyUser With
            {
            .UserId = UserIdTextBox.Text,
            .Password = PasswordTextBox.Text,
            .UserRole = UserComboBox.Text
            }

        If (MyUser.IsEqual(resUser, CurUser) AndAlso UserComboBox.SelectedItem Is ("Farmer")) Then
            FarmersHome.Fname = resUser.FullNames
            Me.Hide()
            FarmersHome.ShowDialog()
            Me.Close()
            MessageBox.Show("Login Successful")
        ElseIf (MyUser.IsEqual(resUser, CurUser) AndAlso UserComboBox.SelectedItem Is ("Admin")) Then
            Dim real As New Admin
            Admin.Fname = resUser.FullNames
            Me.Hide()
            real.ShowDialog()
            Me.Close()
            MessageBox.Show("Login Successful")
        ElseIf (MyUser.IsEqual(resUser, CurUser) AndAlso UserComboBox.SelectedItem Is ("Company")) Then
            Dim real As New Company
            Company.Fname = resUser.FullNames
            Me.Hide()
            real.ShowDialog()
            Me.Close()
            MessageBox.Show("Login Successful")

        Else
            MyUser.ShowError()
        End If
    End Sub
End Class
