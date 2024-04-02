Public Class Form1
    Private room_count As Int32 = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim room As Room = New Room(room_count, ComboBox1.Text, Convert.ToInt32(TextBox2.Text))
            Dim room_widget As UserControl1 = New UserControl1(Convert.ToString(room_count), room, Me)

            FlowLayoutPanel1.Controls.Add(room_widget)

            room_count = room_count + 1
            TextBox1.Text = Convert.ToString(room_count)
            ComboBox1.SelectedIndex = 1
            TextBox2.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Hide()
        room_count = room_count + 1
        TextBox1.Text = Convert.ToString(room_count)
        ComboBox1.SelectedIndex = 1
    End Sub

    Public Sub display_room_details(room As Room)
        Panel1.Controls.Clear()
        Dim room_details As Userdetails = New Userdetails(room, Panel1)
        room_details.TopLevel = False
        room_details.FormBorderStyle = FormBorderStyle.None
        room_details.Dock = DockStyle.Fill
        Panel1.Controls.Add(room_details)
        room_details.Show()
        Panel1.Show()

    End Sub
End Class
