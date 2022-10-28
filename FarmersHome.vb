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
        Dim set3 = client.Set("AnimalSn/" + Convert.ToString(Counter), roll)

        MessageBox.Show("Details Added Succesfully")
        AnimalSNTextBox.Text = ""
        ConsumptionTextBox.Text = ""
        ProductionTextBox.Text = ""
        DateTimePicker.Text = ""

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

        AnimalDataGridView.Rows.Clear()



        Dim res = client.Get("Counter")
        Dim Counter = Integer.Parse(res.ResultAs(Of String))

        For i = 1 To Counter
            Dim res2 = client.Get("AnimalSn/" + Convert.ToString(i) + "/AnimalSn")
            Dim AnimalSn = res2.ResultAs(Of String)

            Dim res3 = client.Get("Details/" + AnimalSn)
            Dim DbRes = res3.ResultAs(Of DbDetails)

            If (DbRes.AnimalSn <> "") Then
                dt.Rows.Add(DbRes.AnimalSn, DbRes.FarmerId, DbRes.Consumption, DbRes.Production, DbRes.DatePicker, DbRes.TotalProduction)
            End If
        Next
        For Each item As DataRow In dt.Rows
                AnimalDataGridView.Rows.Add(item.ItemArray)

            Next

            For Each item As DataRow In dt.Rows
            Dim totalProduction As Double = 0
            For Each row As DataGridViewRow In AnimalDataGridView.Rows
                totalProduction += row.Cells("Production").Value
            Next
            item("TotalProduction") = totalProduction
        Next
        AnimalDataGridView.DataSource = dt





    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Dim NewUser As New DbDetails() With
          {
          .AnimalSn = AnimalSNTextBox.Text,
          .Consumption = ConsumptionTextBox.Text,
          .Production = ProductionTextBox.Text,
          .DatePicker = DateTimePicker.Text
          }

        Dim updater = client.Delete("Details/" + AnimalViewRemove.Text)
        MessageBox.Show("Details deleted  Succesfully")
    End Sub

    Public Sub AnimalDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AnimalDataGridView.CellContentClick

    End Sub
End Class