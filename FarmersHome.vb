Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Public Class FarmersHome
    Private fcon As New FirebaseConfig With
        {
        .AuthSecret = "m5KIfvB60pJPjJx8Ti15R08LqREXCaZhlRcfddL8",
        .BasePath = "https://dairyfarming-e999c-default-rtdb.firebaseio.com/"
    }
    Private client As IFirebaseClient
    Public Shared Fname
   

    Private Sub FarmersHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text += Fname + "!"
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub AddDetailsButton_Click(sender As Object, e As EventArgs) Handles AddDetailsButton.Click
#Region "First Execution"
#Region "Condition"
        If (String.IsNullOrWhiteSpace(AnimalSNTextBox.Text) AndAlso
            String.IsNullOrWhiteSpace(ProductionTextBox.Text) AndAlso
            String.IsNullOrWhiteSpace(ConsumptionTextBox.Text)) Then

            MessageBox.Show("please fill all the fields")
            Return
        End If

#End Region


        Dim NewUser As New DbDetails() With
            {
            .AnimalSn = AnimalSNTextBox.Text,
            .Consumption = ConsumptionTextBox.Text,
            .Production = ProductionTextBox.Text,
            .FarmerId = FarmerIdTextBox.Text,
            .DatePicker = DateTimePicker.Text
            }

        Dim setter = client.Set("Details/" + AnimalSNTextBox.Text, NewUser)
#End Region

        Dim res = client.Get("Counter")
        Dim Counter = Integer.Parse(res.ResultAs(Of String)) + 1

        Dim roll As New MyRol()
        With roll
            .AnimalSn = AnimalSNTextBox.Text
        End With

        Dim set2 = client.Set("Counter", Counter)
        Dim set3 = client.Set("FarmerId/" + Convert.ToString(Counter), roll)

        MessageBox.Show("Details Added Succesfully")
        AnimalSNTextBox.Text = ""
        ConsumptionTextBox.Text = ""
        ProductionTextBox.Text = ""
        DateTimePicker.Text = ""
        FarmerIdTextBox.Text = ""

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click

#Region "Condition"
        If (String.IsNullOrWhiteSpace(AnimalSNTextBox.Text) AndAlso
            String.IsNullOrWhiteSpace(ProductionTextBox.Text) AndAlso
            String.IsNullOrWhiteSpace(ConsumptionTextBox.Text) AndAlso
            String.IsNullOrWhiteSpace(DateTimePicker.Text)) Then

            MessageBox.Show("please fill all the fields")
            Return
        End If

#End Region
        Dim NewUser As New DbDetails() With
          {
          .AnimalSn = AnimalSNTextBox.Text,
          .Consumption = ConsumptionTextBox.Text,
          .Production = ProductionTextBox.Text,
          .DatePicker = DateTimePicker.Text
          }

        Dim updater = client.Update("Details/" + AnimalSNTextBox.Text, NewUser)
        MessageBox.Show("Details Edited  Succesfully")

    End Sub

    Private Sub ViewButton_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        Dim dt As New DataTable
        dt.Columns.Add("Animal Sn")
        dt.Columns.Add("FarmerId")
        dt.Columns.Add("Consumption")
        dt.Columns.Add("Production")
        dt.Columns.Add("Date")
        dt.Columns.Add("TotalProduction")

        dt.Rows.Clear()


        Dim res = client.Get("Counter")
        Dim Counter = Integer.Parse(res.ResultAs(Of String))

        For i = 1 To Counter
            Dim res2 = client.Get("FarmerId/" + Convert.ToString(i) + "/AnimalSn")
            Dim AnimalSerial = res2.ResultAs(Of String)

            Dim res3 = client.Get("Details/" + AnimalSerial)
            Dim DbRes = res3.ResultAs(Of DbDetails)

            If (DbRes.AnimalSn <> "") Then
                dt.Rows.Add(DbRes.AnimalSn, DbRes.FarmerId, DbRes.Consumption, DbRes.Production, DbRes.DatePicker, DbRes.TotalProduction)
            End If
        Next

        AnimalDataGridView.DataSource = dt
        For i As Integer = 0 To dt.Rows.Count - 1
            For j As Integer = 0 To dt.Columns.Count - 1
                If i = 0 Then
                    AnimalDataGridView.Rows(i).Cells("TotalProduction").Value = Val(AnimalDataGridView.Rows(i).Cells("Production").Value)
                Else
                    AnimalDataGridView.Rows(i).Cells("TotalProduction").Value = Val(AnimalDataGridView.Rows(i - 1).Cells("TotalProduction").Value) + Val(AnimalDataGridView.Rows(i).Cells("Production").Value)
                End If
            Next
        Next





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click

    End Sub
End Class