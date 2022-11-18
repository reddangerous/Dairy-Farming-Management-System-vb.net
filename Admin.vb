Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Public Class Admin
    Private fcon As New FirebaseConfig With
        {
        .AuthSecret = "m5KIfvB60pJPjJx8Ti15R08LqREXCaZhlRcfddL8",
        .BasePath = "https://dairyfarming-e999c-default-rtdb.firebaseio.com/"
    }
    Private client As IFirebaseClient
    Public Shared Fname
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text += Fname + "!"
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddButton.Click
#Region "Condition"
        If (String.IsNullOrWhiteSpace(UserIdTextBox.Text)) Then

            MessageBox.Show("please Enter The UserId")
        End If
#End Region
        Dim NewUser As New MyUser() With
          {
         .UserId = UserIdTextBox.Text,
         .FullNames = NameTextBox.Text,
         .Password = PasswordTextBox.Text,
         .UserRole = UserComboBox.Text
          }



        Dim updater = client.Set("Users/" + UserComboBox.Text, NewUser)

        Dim res = client.Get("CounterTwo")
        Dim Counter = Integer.Parse(res.ResultAs(Of String)) + 1

        Dim roll As New MyUser()
        With roll

            .UserRole = UserComboBox.Text

        End With
        Dim set2 = client.Set("CounterTwo", Counter)
        Dim set3 = client.Set("User/" + Convert.ToString(Counter), roll)

        MessageBox.Show("User Added  Succesfully")
        UserIdTextBox.Text = ""
        NameTextBox.Text = ""
        PasswordTextBox.Text = ""
        UserComboBox.Text = ""


    End Sub

    Private Sub ViewButton_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        Dim dt As New DataTable
        dt.Columns.Add("FullNames")
        dt.Columns.Add("UserId")
        dt.Columns.Add("UserPassword")
        dt.Columns.Add("UserRole")
        dt.Rows.Clear()

        Dim res = client.Get("CounterTwo")
        Dim Counter = Integer.Parse(res.ResultAs(Of String))

        For i = 1 To Counter
            Dim res2 = client.Get("User/" + Convert.ToString(i) + "/UserRole")
            Dim User = res2.ResultAs(Of String)

            Dim res3 = client.Get("Users/" + User)
            Dim DbRes = res3.ResultAs(Of MyUser)

            If (DbRes.UserRole <> "") Then
                dt.Rows.Add(DbRes.FullNames, DbRes.UserId, DbRes.Password, DbRes.UserRole)
            End If
        Next
        DataGridView1.DataSource = dt
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
#Region "Condition"
        If (String.IsNullOrWhiteSpace(UserIdTextBox.Text)) Then

            MessageBox.Show("please Enter The UserId")
        End If
#End Region
        Dim NewUser As New MyUser() With
          {
         .UserId = UserIdTextBox.Text,
         .FullNames = NameTextBox.Text,
         .Password = PasswordTextBox.Text,
         .UserRole = UserComboBox.Text
          }



        Dim updater = client.Delete("Users/" + UserComboBox.Text)


        MessageBox.Show("User Deleted  Succesfully")
        UserIdTextBox.Text = ""
        NameTextBox.Text = ""
        PasswordTextBox.Text = ""
        UserComboBox.Text = ""
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class