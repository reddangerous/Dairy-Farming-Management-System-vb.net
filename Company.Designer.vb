<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Company
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SetPriceButton = New System.Windows.Forms.Button()
        Me.SetPriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ViewButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PaymentButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.FarmerIdTextBox = New System.Windows.Forms.TextBox()
        Me.FarmerId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnimalSn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Production = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.farmersDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Payment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(58, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome"
        '
        'SetPriceButton
        '
        Me.SetPriceButton.AutoSize = True
        Me.SetPriceButton.BackColor = System.Drawing.Color.Cyan
        Me.SetPriceButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetPriceButton.Location = New System.Drawing.Point(109, 104)
        Me.SetPriceButton.Name = "SetPriceButton"
        Me.SetPriceButton.Size = New System.Drawing.Size(87, 30)
        Me.SetPriceButton.TabIndex = 2
        Me.SetPriceButton.Text = "SetPrice"
        Me.SetPriceButton.UseVisualStyleBackColor = False
        '
        'SetPriceTextBox
        '
        Me.SetPriceTextBox.Location = New System.Drawing.Point(192, 51)
        Me.SetPriceTextBox.Name = "SetPriceTextBox"
        Me.SetPriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SetPriceTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Set Milk Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "View Farmer Production"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Farmer Id"
        '
        'ViewButton
        '
        Me.ViewButton.AutoSize = True
        Me.ViewButton.BackColor = System.Drawing.Color.Cyan
        Me.ViewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewButton.Location = New System.Drawing.Point(48, 272)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(87, 30)
        Me.ViewButton.TabIndex = 8
        Me.ViewButton.Text = "View"
        Me.ViewButton.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FarmerId, Me.AnimalSn, Me.Production, Me.farmersDate, Me.Payment})
        Me.DataGridView1.Location = New System.Drawing.Point(371, 47)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(423, 111)
        Me.DataGridView1.TabIndex = 9
        '
        'PaymentButton
        '
        Me.PaymentButton.AutoSize = True
        Me.PaymentButton.BackColor = System.Drawing.Color.Cyan
        Me.PaymentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentButton.Location = New System.Drawing.Point(177, 272)
        Me.PaymentButton.Name = "PaymentButton"
        Me.PaymentButton.Size = New System.Drawing.Size(88, 30)
        Me.PaymentButton.TabIndex = 10
        Me.PaymentButton.Text = "Payment"
        Me.PaymentButton.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(415, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(293, 24)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Generate and Print Milk Statement" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GenerateButton
        '
        Me.GenerateButton.AutoSize = True
        Me.GenerateButton.BackColor = System.Drawing.Color.Cyan
        Me.GenerateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateButton.Location = New System.Drawing.Point(430, 239)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(114, 30)
        Me.GenerateButton.TabIndex = 12
        Me.GenerateButton.Text = "Generate"
        Me.GenerateButton.UseVisualStyleBackColor = False
        '
        'PrintButton
        '
        Me.PrintButton.AutoSize = True
        Me.PrintButton.BackColor = System.Drawing.Color.Cyan
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(585, 239)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(114, 30)
        Me.PrintButton.TabIndex = 13
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.AutoSize = True
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(289, 339)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(114, 30)
        Me.ExitButton.TabIndex = 14
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'FarmerIdTextBox
        '
        Me.FarmerIdTextBox.Location = New System.Drawing.Point(192, 221)
        Me.FarmerIdTextBox.Name = "FarmerIdTextBox"
        Me.FarmerIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FarmerIdTextBox.TabIndex = 15
        '
        'FarmerId
        '
        Me.FarmerId.HeaderText = "Farmer Id"
        Me.FarmerId.Name = "FarmerId"
        Me.FarmerId.ReadOnly = True
        '
        'AnimalSn
        '
        Me.AnimalSn.HeaderText = "AnimalSn"
        Me.AnimalSn.Name = "AnimalSn"
        Me.AnimalSn.ReadOnly = True
        '
        'Production
        '
        Me.Production.HeaderText = "Production"
        Me.Production.Name = "Production"
        Me.Production.ReadOnly = True
        '
        'farmersDate
        '
        Me.farmersDate.HeaderText = "Date"
        Me.farmersDate.Name = "farmersDate"
        Me.farmersDate.ReadOnly = True
        '
        'Payment
        '
        Me.Payment.HeaderText = "Payment"
        Me.Payment.Name = "Payment"
        Me.Payment.ReadOnly = True
        '
        'Company
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.projectFinal.My.Resources.Resources.company
        Me.ClientSize = New System.Drawing.Size(807, 384)
        Me.Controls.Add(Me.FarmerIdTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.GenerateButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PaymentButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ViewButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SetPriceTextBox)
        Me.Controls.Add(Me.SetPriceButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Company"
        Me.Text = "Comany"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SetPriceButton As Button
    Friend WithEvents SetPriceTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ViewButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PaymentButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents GenerateButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents FarmerIdTextBox As TextBox
    Friend WithEvents FarmerId As DataGridViewTextBoxColumn
    Friend WithEvents AnimalSn As DataGridViewTextBoxColumn
    Friend WithEvents Production As DataGridViewTextBoxColumn
    Friend WithEvents farmersDate As DataGridViewTextBoxColumn
    Friend WithEvents Payment As DataGridViewTextBoxColumn
End Class
