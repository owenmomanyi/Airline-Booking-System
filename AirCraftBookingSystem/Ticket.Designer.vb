<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ticket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ticket))
        Label2 = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        Label7 = New Label()
        TextBox5 = New TextBox()
        Label8 = New Label()
        ComboBox2 = New ComboBox()
        Label9 = New Label()
        Label10 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        ComboBox3 = New ComboBox()
        TextBox4 = New TextBox()
        Button3 = New Button()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        Label11 = New Label()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(232, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 23)
        Label2.TabIndex = 15
        Label2.Text = "Ticket Booking"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(261, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 23)
        Label1.TabIndex = 14
        Label1.Text = "SkyJet Airline"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(152, 97)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(102, 23)
        TextBox1.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkBlue
        Label3.Location = New Point(31, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 19)
        Label3.TabIndex = 16
        Label3.Text = "Ticket Id"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(152, 129)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(102, 23)
        TextBox2.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkBlue
        Label4.Location = New Point(31, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 19)
        Label4.TabIndex = 18
        Label4.Text = "Passenger Id"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(152, 167)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(102, 23)
        TextBox3.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DarkBlue
        Label5.Location = New Point(61, 165)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 19)
        Label5.TabIndex = 20
        Label5.Text = "Age"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DarkBlue
        Label6.Location = New Point(74, 203)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 19)
        Label6.TabIndex = 22
        Label6.Text = "Status"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"First Class", "Bussiness Class", "Economy Class"})
        ComboBox1.Location = New Point(152, 204)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(115, 23)
        ComboBox1.TabIndex = 25
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.DarkBlue
        Label7.Location = New Point(301, 101)
        Label7.Name = "Label7"
        Label7.Size = New Size(97, 19)
        Label7.TabIndex = 24
        Label7.Text = "Flight Code"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(417, 204)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(102, 23)
        TextBox5.TabIndex = 27
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.DarkBlue
        Label8.Location = New Point(324, 129)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 19)
        Label8.TabIndex = 26
        Label8.Text = "Name"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"F01", "F02", "F03", "F04", "F05"})
        ComboBox2.Location = New Point(404, 97)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(115, 23)
        ComboBox2.TabIndex = 29
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.DarkBlue
        Label9.Location = New Point(306, 166)
        Label9.Name = "Label9"
        Label9.Size = New Size(92, 19)
        Label9.TabIndex = 28
        Label9.Text = "Nationality"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.DarkBlue
        Label10.Location = New Point(334, 203)
        Label10.Name = "Label10"
        Label10.Size = New Size(71, 19)
        Label10.TabIndex = 30
        Label10.Text = "Amount"
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Highlight
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Red
        Button2.Location = New Point(326, 249)
        Button2.Name = "Button2"
        Button2.Size = New Size(76, 28)
        Button2.TabIndex = 33
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
        Button1.Location = New Point(220, 249)
        Button1.Name = "Button1"
        Button1.Size = New Size(76, 28)
        Button1.TabIndex = 32
        Button1.Text = "Record"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Kenyan", "American", "British", "Somalian", "Ugandan"})
        ComboBox3.Location = New Point(404, 166)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(115, 23)
        ComboBox3.TabIndex = 35
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(404, 129)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(102, 23)
        TextBox4.TabIndex = 36
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Highlight
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Red
        Button3.Location = New Point(430, 410)
        Button3.Name = "Button3"
        Button3.Size = New Size(118, 28)
        Button3.TabIndex = 37
        Button3.Text = "Show Record"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8})
        ListView1.GridLines = True
        ListView1.Location = New Point(31, 288)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(488, 103)
        ListView1.TabIndex = 38
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Ticket Id"
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Passenger Id"
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Age"
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Status"
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Flight Code"
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Name"
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Nationality"
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Amount"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Red
        Label11.Location = New Point(666, 9)
        Label11.Name = "Label11"
        Label11.Size = New Size(23, 23)
        Label11.TabIndex = 39
        Label11.Text = "X"
        ' 
        ' Ticket
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(701, 450)
        Controls.Add(Label11)
        Controls.Add(ListView1)
        Controls.Add(Button3)
        Controls.Add(TextBox4)
        Controls.Add(ComboBox3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label10)
        Controls.Add(ComboBox2)
        Controls.Add(Label9)
        Controls.Add(TextBox5)
        Controls.Add(Label8)
        Controls.Add(ComboBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Ticket"
        Text = "Ticket"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Label11 As Label
End Class
