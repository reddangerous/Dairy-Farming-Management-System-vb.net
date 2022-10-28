Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Public Class Company
    Private fcon As New FirebaseConfig With
        {
        .AuthSecret = "m5KIfvB60pJPjJx8Ti15R08LqREXCaZhlRcfddL8",
        .BasePath = "https://dairyfarming-e999c-default-rtdb.firebaseio.com/"
    }
    Private client As IFirebaseClient
    Public Shared Fname
    Public Shared AnimalDataGridView As Object

    Private Sub Comany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text += Fname + " "
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub SetPriceButton_Click(sender As Object, e As EventArgs) Handles SetPriceButton.Click
#Region "Condition"
        If (String.IsNullOrWhiteSpace(SetPriceTextBox.Text)) Then
            MessageBox.Show("please fill all the fields")
            Return
        End If

#End Region
        Dim NewPrice As New Price() With
            {
            .SetPrice = SetPriceTextBox.Text
            }

        Dim SetPrice = client.Set("Price/" + SetPriceTextBox.Text, NewPrice)
        MessageBox.Show("Registration Successful")
        SetPriceTextBox.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        Dim dt As New DataTable
        dt.Columns.Add("FarmerId")
        dt.Columns.Add("AnimalSn")
        dt.Columns.Add("Production")
        dt.Columns.Add("Date")
        dt.Columns.Add("Payment")




        Dim res = client.Get("Counter")
        Dim Counter2 = Integer.Parse(res.ResultAs(Of String))
        For i = 1 To Counter2
            Dim res2 = client.Get("AnimalSn/" + Convert.ToString(i) + "/AnimalSn")
            Dim res5 = client.Get("UserId/" + FarmerIdTextBox.Text)
            Dim AnimalSn = res2.ResultAs(Of String)
            Dim FarmerId = res.ResultAs(Of String)


            Dim res3 = client.Get("Details/" + AnimalSn)
            Dim DbRes = res3.ResultAs(Of DbDetails)


            If (DbRes.AnimalSn <> "") Then
                dt.Rows.Add(DbRes.FarmerId, DbRes.AnimalSn, DbRes.Production, DbRes.DatePicker)

            End If
        Next
        For Each item As DataRow In dt.Rows
            DataGridView1.Rows.Add(item.ItemArray)
        Next

        For Each item As DataRow In dt.Rows
            Dim totalProduction As Double = 0
            Dim res7 = client.Get("SetPrice")
            Dim Price = Double.Parse(res7.ResultAs(Of String))
            For Each row As DataGridViewRow In DataGridView1.Rows
                totalProduction += row.Cells("Production").Value
                Dim payment As Double
                payment = (totalProduction * Price)
                item("Payment") = payment
            Next
        Next
        DataGridView1.DataSource = dt
    End Sub
End Class