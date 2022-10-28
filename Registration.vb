Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Public Class Registration
    Private fcon As New FirebaseConfig With
        {
        .AuthSecret = "m5KIfvB60pJPjJx8Ti15R08LqREXCaZhlRcfddL8",
        .BasePath = "https://dairyfarming-e999c-default-rtdb.firebaseio.com/"
    }
    Private client As IFirebaseClient
    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
#Region "Condition"
        If (String.IsNullOrWhiteSpace(UserIdTextBox.Text) AndAlso
            String.IsNullOrWhiteSpace(PasswordTextBox.Text) AndAlso
            String.IsNullOrWhiteSpace(NameTextBox.Text) AndAlso
            String.IsNullOrWhiteSpace(UserComboBox.Text)) Then

            MessageBox.Show("please fill all the fields")
            Return
        End If

#End Region


        Dim NewUser As New MyUser() With
            {
            .UserId = UserIdTextBox.Text,
            .Password = PasswordTextBox.Text,
            .UserRole = UserComboBox.Text,
            .FullNames = NameTextBox.Text
            }
        Dim res = client.Get("Counter2")

        Dim Counter2 = Integer.Parse(res.ResultAs(Of String))
        Dim roll As New MyUser()
        With roll
            .UserId = UserIdTextBox.Text
        End With

        Dim set3 = client.Set("UserId/" + Convert.ToString(Counter2), roll)
        Dim set2 = client.Set("Counter2", Counter2)
        Dim setter = client.Set("Users/" + UserComboBox.Text, NewUser)
        MessageBox.Show("Registration Successful")
        UserComboBox.Text = ""
        UserIdTextBox.Text = ""
        PasswordTextBox.Text = ""
        NameTextBox.Text = ""

    End Sub


End Class