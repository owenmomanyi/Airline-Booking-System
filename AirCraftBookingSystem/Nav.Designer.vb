<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nav
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nav))
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label4 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Location = New Point(51, 327)
        Button1.Name = "Button1"
        Button1.Size = New Size(91, 38)
        Button1.TabIndex = 0
        Button1.Text = "Flights"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Location = New Point(189, 328)
        Button2.Name = "Button2"
        Button2.Size = New Size(89, 37)
        Button2.TabIndex = 1
        Button2.Text = "Passengers"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.Location = New Point(320, 327)
        Button3.Name = "Button3"
        Button3.Size = New Size(88, 40)
        Button3.TabIndex = 2
        Button3.Text = "Tickets"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(671, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(23, 23)
        Label4.TabIndex = 37
        Label4.Text = "X"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(239, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 23)
        Label1.TabIndex = 38
        Label1.Text = "ETIHAD Airline"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(227, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(148, 23)
        Label2.TabIndex = 39
        Label2.Text = "Navigation Bar"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Red
        Button4.Location = New Point(465, 325)
        Button4.Name = "Button4"
        Button4.Size = New Size(88, 40)
        Button4.TabIndex = 40
        Button4.Text = "Cancel Ticket"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Nav
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(730, 395)
        Controls.Add(Button4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "Nav"
        Text = "Nav"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
End Class
