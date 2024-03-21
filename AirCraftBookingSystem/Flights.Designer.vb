<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Flights
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Flights))
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        ComboBox2 = New ComboBox()
        Label8 = New Label()
        Label4 = New Label()
        DateTimePicker1 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        Label5 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        ComboBox3 = New ComboBox()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        Button3 = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(208, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(176, 23)
        Label2.TabIndex = 15
        Label2.Text = "Record New Flight"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(237, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 23)
        Label1.TabIndex = 14
        Label1.Text = "ETIHAD AIRLINE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkBlue
        Label3.Location = New Point(31, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 19)
        Label3.TabIndex = 16
        Label3.Text = "Flight Code"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Dubai", "", "London", "", "Cape Town", "", "New York", "", "Dubai"})
        ComboBox2.Location = New Point(121, 126)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(115, 23)
        ComboBox2.TabIndex = 25
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.DarkBlue
        Label8.Location = New Point(31, 126)
        Label8.Name = "Label8"
        Label8.Size = New Size(62, 19)
        Label8.TabIndex = 24
        Label8.Text = "Source"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkBlue
        Label4.Location = New Point(31, 173)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 19)
        Label4.TabIndex = 26
        Label4.Text = "TakeOfDate"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(136, 169)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(128, 23)
        DateTimePicker1.TabIndex = 27
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Dubai", "", "London", "", "Cape Town", "", "New York", "", "Dubai"})
        ComboBox1.Location = New Point(136, 90)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(115, 23)
        ComboBox1.TabIndex = 29
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DarkBlue
        Label5.Location = New Point(31, 213)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 19)
        Label5.TabIndex = 28
        Label5.Text = "Destination"
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Highlight
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Red
        Button2.Location = New Point(242, 279)
        Button2.Name = "Button2"
        Button2.Size = New Size(76, 28)
        Button2.TabIndex = 31
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Highlight
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Red
        Button1.Location = New Point(121, 279)
        Button1.Name = "Button1"
        Button1.Size = New Size(76, 28)
        Button1.TabIndex = 30
        Button1.Text = "Record"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"F01", "F02", "F03", "F04", "F05", "F06"})
        ComboBox3.Location = New Point(136, 214)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(115, 23)
        ComboBox3.TabIndex = 32
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4})
        ListView1.GridLines = True
        ListView1.Location = New Point(349, 126)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(304, 125)
        ListView1.TabIndex = 33
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "FlightCode"
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Source"
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "TakeOfDate"
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Destination"
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Highlight
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Red
        Button3.Location = New Point(505, 279)
        Button3.Name = "Button3"
        Button3.Size = New Size(76, 28)
        Button3.TabIndex = 34
        Button3.Text = "Show"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(658, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(23, 23)
        Label6.TabIndex = 39
        Label6.Text = "X"
        ' 
        ' Flights
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(717, 322)
        Controls.Add(Label6)
        Controls.Add(Button3)
        Controls.Add(ListView1)
        Controls.Add(ComboBox3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label5)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label4)
        Controls.Add(ComboBox2)
        Controls.Add(Label8)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Flights"
        Text = "Flights"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button3 As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label6 As Label
End Class
