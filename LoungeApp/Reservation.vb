
Imports System.Data.OleDb

Public Class Reservation
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\k\Reservation and billing.accdb;")
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim dt As New DataTable

    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = dt
        LoadData()
    End Sub

    Private Sub LoadData()
        dt.Clear()
        con.Open()
        cmd.CommandText = "SELECT * FROM Reservations"
        cmd.Connection = con
        da.SelectCommand = cmd
        da.Fill(dt)
        con.Close()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        con.Open()
        cmd.CommandText = "INSERT INTO Reservations (RoomNumber) VALUES ('" & RoomNoComboBox.Text & "', '" & "')"
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        con.Close()
        LoadData()
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        con.Open()
        cmd.CommandText = "UPDATE Reservations SET RoomNumber='" & RoomNoComboBox.Text & "', GuestName='" & "' WHERE ID=" & DataGridView1.CurrentRow.Cells(0).Value.ToString()
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        con.Close()
        LoadData()
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        con.Open()
        cmd.CommandText = "DELETE FROM Reservations WHERE ID=" & DataGridView1.CurrentRow.Cells(0).Value.ToString()
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        con.Close()
        LoadData()
    End Sub
End Class
