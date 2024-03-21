Imports MySql.Data.MySqlClient
Public Class Cancel
    Dim MySqlConnection As New MySqlConnection("host=127.001;user=root;database=airlinebookingsystem;")
    Dim cm As MySqlCommand

    Dim adp As MySqlDataAdapter
    Private Sub Cancel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        adp = New MySqlDataAdapter("Select * from passenger", MySqlConnection)
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
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get the ID from the textbox
        Dim idToDelete As String = TextBox1.Text.Trim()

        ' Check if the ID is not empty
        If Not String.IsNullOrEmpty(idToDelete) Then
            Try
                ' Perform deletion using the ID
                ' Example: DeleteRecord(idToDelete)
                ' Assume MySqlConnection is already initialized
                Dim query As String = "DELETE FROM passenger WHERE ID = @Id"
                Using cmd As New MySqlCommand(query, MySqlConnection)
                    cmd.Parameters.AddWithValue("@Id", idToDelete)
                    MySqlConnection.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Record with Id  " & idToDelete & " deleted successfully.")
                    Else
                        MessageBox.Show("No record found with Id " & idToDelete & ".")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error deleting record: " & ex.Message)
            Finally
                ' Close the connection
                If MySqlConnection.State = ConnectionState.Open Then
                    MySqlConnection.Close()
                End If
            End Try
        Else
            ' Show a message if the ID is empty
            MessageBox.Show("Please enter an ID to delete.")
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub
End Class