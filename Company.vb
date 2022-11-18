Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports System.Net.Mail
Imports System.Net
Imports System.Data
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

        Dim SetPrice = client.Set("Price/", NewPrice)
        MessageBox.Show("Registration Successful")
        SetPriceTextBox.Text = ""

    End Sub


    Private Sub PaymentButton_Click_1(sender As Object, e As EventArgs) Handles PaymentButton.Click
        Dim dt As New DataTable
        dt.Columns.Add("FarmerId")
        dt.Columns.Add("AnimalSn")
        dt.Columns.Add("Production")
        dt.Columns.Add("Date")
        dt.Columns.Add("Price")
        dt.Columns.Add("Payment")
        dt.Columns.Add("TotalPayment")

        Dim res = client.Get("Counter")
        Dim Counter = Integer.Parse(res.ResultAs(Of String))

        For i = 1 To Counter
            Dim res2 = client.Get("FarmerId/" + Convert.ToString(i) + "/AnimalSn")
            Dim AnimalSerial = res2.ResultAs(Of String)

            Dim res3 = client.Get("Details/" + AnimalSerial)
            Dim DbRes = res3.ResultAs(Of DbDetails)
            Dim Pay = client.Get("Price/")
            Dim dbres2 = Pay.ResultAs(Of Price)
            If (DbRes.AnimalSn <> "") Then
                dt.Rows.Add(DbRes.FarmerId, DbRes.AnimalSn, DbRes.Production, DbRes.DatePicker, dbres2.SetPrice, DbRes.Payment, DbRes.TotalPayment)
            End If
        Next



        For i As Integer = 0 To dt.Rows.Count - 1
            DataGridView1.DataSource = dt
            For j As Integer = 0 To dt.Columns.Count - 1




                If i = 0 Then
                    DataGridView1.Rows(i).Cells("Payment").Value = Val(DataGridView1.Rows(i).Cells("Production").Value) * Val(DataGridView1.Rows(i).Cells("Price").Value)

                Else
                    DataGridView1.Rows(i).Cells("Payment").Value = Val(DataGridView1.Rows(i).Cells("Production").Value) * Val(DataGridView1.Rows(i - 1).Cells("Price").Value)
                End If

            Next
        Next
        DataGridView1.DataSource = dt


        For i As Integer = 0 To dt.Rows.Count - 1
            For j As Integer = 0 To dt.Columns.Count - 1

                If i = 0 Then
                    DataGridView1.Rows(i).Cells("TotalPayment").Value = Val(DataGridView1.Rows(i).Cells("Payment").Value)
                Else
                    DataGridView1.Rows(i).Cells("TotalPayment").Value = Val(DataGridView1.Rows(i - 1).Cells("TotalPayment").Value) + Val(DataGridView1.Rows(i).Cells("Payment").Value)
                End If
            Next
        Next

    End Sub


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private bitmap As Bitmap
    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Dim Height As Integer = DataGridView1.Height
        DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
        bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)

        DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
    End Sub


End Class