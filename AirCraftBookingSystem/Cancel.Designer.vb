<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cancel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cancel))
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        Button3 = New Button()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7})
        ListView1.GridLines = True
        ListView1.Location = New Point(297, 90)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(426, 158)
        ListView1.TabIndex = 29
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Id"
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Name"
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "passport"
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Address"
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Nationality"
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Gender"
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Phone"
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Highlight
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Red
        Button3.Location = New Point(545, 254)
        Button3.Name = "Button3"
        Button3.Size = New Size(168, 28)
        Button3.TabIndex = 30
        Button3.Text = "Show Record"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Highlight
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Red
        Button1.Location = New Point(117, 330)
        Button1.Name = "Button1"
        Button1.Size = New Size(168, 28)
        Button1.TabIndex = 31
        Button1.Text = "Delete Record"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(180, 283)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(102, 23)
        TextBox1.TabIndex = 33
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkBlue
        Label3.Location = New Point(59, 283)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 19)
        Label3.TabIndex = 32
        Label3.Text = "Enter Id"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(326, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 23)
        Label1.TabIndex = 39
        Label1.Text = "ETIHAD Airline"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(274, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(240, 23)
        Label2.TabIndex = 40
        Label2.Text = "Delete Passenger Record"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(750, 18)
        Label4.Name = "Label4"
        Label4.Size = New Size(23, 23)
        Label4.TabIndex = 41
        Label4.Text = "X"
        ' 
        ' Cancel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Button3)
        Controls.Add(ListView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Cancel"
        Text = "Cancel"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
