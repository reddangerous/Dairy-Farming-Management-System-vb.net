Public Class DbDetails
    Public Property AnimalSn() As String = ""
    Public Property Production() As String = ""
    Public Property Consumption() As String = ""
    Public Property DatePicker() As String = ""
    Public Property TotalProduction() As String = ""
    Public Property FarmerId() As String = ""




    Private Shared TheError As String = "Animal SN not found "

    Public Shared Sub ShowError()
        MessageBox.Show(TheError)
    End Sub

    Public Shared Function IsEqual(user1 As DbDetails, user2 As DbDetails)
        If (user1 Is Nothing Or user2 Is Nothing) Then
            TheError = "Animal SN not found "
            Return False
        End If
        If (user1.AnimalSn <> user2.AnimalSn) Then
            TheError = "Animal SN not found "
            Return False
        End If
        Return True
    End Function


End Class
