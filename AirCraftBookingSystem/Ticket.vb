Imports MySql.Data.MySqlClient
Public Class Ticket
    Dim MySqlConnection As New MySqlConnection("host=127.001;user=root;database=airlinebookingsystem;")
    Dim cm As MySqlCommand

    Dim adp As MySqlDataAdapter
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MySqlConnection.Open()
            MessageBox.Show("successful connected")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try



            cm = New MySqlCommand("insert into ticket values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.GetItemText(ComboBox1.SelectedItem) & "','" & ComboBox2.GetItemText(ComboBox2.SelectedItem) & "','" & TextBox4.Text & "','" & ComboBox3.GetItemText(ComboBox3.SelectedItem) & "','" & TextBox5.Text & "')", MySqlConnection)
            cm.ExecuteNonQuery()
            MsgBox("Data sent Successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        TextBox4.Text = ""
        ComboBox3.SelectedIndex = -1
        TextBox5.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        adp = New MySqlDataAdapter("Select * from ticket", MySqlConnection)
        Dim dt As New DataTable
        adp.Fill(dt)
        ListView1.Items.Clear()

        For Each drow As DataRow In dt.Rows
            ListView1.Items.Add(drow(0).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(1).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(2).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(3).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(4).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(5).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(6).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(7).ToString())
        Next



    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Me.Close()
    End Sub
End Class