<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FarmersHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AnimalSNTextBox = New System.Windows.Forms.TextBox()
        Me.AddDetailsButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProductionTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ConsumptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AnimalDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ViewButton = New System.Windows.Forms.Button()
        Me.FarmerIdTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        CType(Me.AnimalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome"
        '
        'AnimalSNTextBox
        '
        Me.AnimalSNTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnimalSNTextBox.Location = New System.Drawing.Point(178, 105)
        Me.AnimalSNTextBox.Name = "AnimalSNTextBox"
        Me.AnimalSNTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AnimalSNTextBox.TabIndex = 1
        '
        'AddDetailsButton
        '
        Me.AddDetailsButton.AutoSize = True
        Me.AddDetailsButton.BackColor = System.Drawing.Color.Cyan
        Me.AddDetailsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddDetailsButton.Location = New System.Drawing.Point(10, 346)
        Me.AddDetailsButton.Name = "AddDetailsButton"
        Me.AddDetailsButton.Size = New System.Drawing.Size(112, 30)
        Me.AddDetailsButton.TabIndex = 2
        Me.AddDetailsButton.Text = "Add Details"
        Me.AddDetailsButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(32, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 48)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Add Animals  Daily Production" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " and Consumption" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Animal SN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Production"
        '
        'ProductionTextBox
        '
        Me.ProductionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductionTextBox.Location = New System.Drawing.Point(178, 160)
        Me.ProductionTextBox.Name = "ProductionTextBox"
        Me.ProductionTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ProductionTextBox.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Consumption"
        '
        'ConsumptionTextBox
        '
        Me.ConsumptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsumptionTextBox.Location = New System.Drawing.Point(178, 211)
        Me.ConsumptionTextBox.Name = "ConsumptionTextBox"
        Me.ConsumptionTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ConsumptionTextBox.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 24)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Date"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker.Location = New System.Drawing.Point(178, 293)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(100, 24)
        Me.DateTimePicker.TabIndex = 10
        '
        'EditButton
        '
        Me.EditButton.AutoSize = True
        Me.EditButton.BackColor = System.Drawing.Color.Cyan
        Me.EditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.Location = New System.Drawing.Point(187, 346)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(79, 30)
        Me.EditButton.TabIndex = 11
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(418, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(313, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "View Monthly details and production"
        '
        'AnimalDataGridView
        '
        Me.AnimalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AnimalDataGridView.Location = New System.Drawing.Point(324, 68)
        Me.AnimalDataGridView.Name = "AnimalDataGridView"
        Me.AnimalDataGridView.Size = New System.Drawing.Size(581, 270)
        Me.AnimalDataGridView.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 24)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "FarmerId" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ViewButton
        '
        Me.ViewButton.AutoSize = True
        Me.ViewButton.BackColor = System.Drawing.Color.Cyan
        Me.ViewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewButton.Location = New System.Drawing.Point(593, 346)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(79, 30)
        Me.ViewButton.TabIndex = 16
        Me.ViewButton.Text = "View"
        Me.ViewButton.UseVisualStyleBackColor = False
        '
        'FarmerIdTextBox
        '
        Me.FarmerIdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FarmerIdTextBox.Location = New System.Drawing.Point(178, 251)
        Me.FarmerIdTextBox.Name = "FarmerIdTextBox"
        Me.FarmerIdTextBox.Size = New System.Drawing.Size(100, 22)
        Me.FarmerIdTextBox.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(373, 393)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 30)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Delete
        '
        Me.Delete.AutoSize = True
        Me.Delete.BackColor = System.Drawing.Color.DarkRed
        Me.Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(113, 393)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(79, 30)
        Me.Delete.TabIndex = 21
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'FarmersHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.projectFinal.My.Resources.Resources.farmers
        Me.ClientSize = New System.Drawing.Size(917, 430)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FarmerIdTextBox)
        Me.Controls.Add(Me.ViewButton)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.AnimalDataGridView)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ConsumptionTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ProductionTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AddDetailsButton)
        Me.Controls.Add(Me.AnimalSNTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FarmersHome"
        Me.Text = "Farmers Home"
        CType(Me.AnimalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AnimalSNTextBox As TextBox
    Friend WithEvents AddDetailsButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ProductionTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ConsumptionTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents EditButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents AnimalDataGridView As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents ViewButton As Button
    Friend WithEvents FarmerIdTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Delete As Button
End Class
