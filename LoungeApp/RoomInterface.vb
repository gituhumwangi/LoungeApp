Imports System.Runtime.CompilerServices

Public Class RoomInterface
    Private room_count As Int32 = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        room_count = room_count + 1
        Dim room As TextBox = New TextBox()
        room.ReadOnly = True
        room.Text = room_count
        room.BackColor = Color.Beige
        room.Height = 100
        room.Width = 100

        FlowLayoutPanel1.Controls.Add(room)

    End Sub
End Class