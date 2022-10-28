Public Class MyUser
    Public Property UserId() As String = ""
    Public Property Password() As String
    Public Property FullNames() As String
    Public Property UserRole() As String

    Private Shared TheError As String = "UserId not found "

    Public Shared Sub ShowError()
        MessageBox.Show(TheError)
    End Sub

    Public Shared Function IsEqual(user1 As MyUser, user2 As MyUser)
        If (user1 Is Nothing Or user2 Is Nothing) Then
            TheError = "UserId not found "
            Return False
        End If
        If (user1.UserId <> user2.UserId) Then
            TheError = "UserId not found "
            Return False
        ElseIf (user1.Password <> user2.Password) Then
            TheError = "UserId and password does  not match "
            Return False
        End If
        Return True
    End Function

End Class
