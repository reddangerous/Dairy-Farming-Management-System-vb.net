Public Class Company
    Public Shared Fname
    Private Sub Comany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text += Fname + "!"
    End Sub
End Class