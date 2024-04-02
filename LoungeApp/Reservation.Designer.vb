<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
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
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        RoomNoComboBox = New ComboBox()
        ExitButton = New Button()
        RemoveButton = New Button()
        EditButton = New Button()
        AddButton = New Button()
        CheckOutMaskedTextBox = New MaskedTextBox()
        CheckInMaskedTextBox = New MaskedTextBox()
        DataGridView1 = New DataGridView()
        Label7 = New Label()
        Label6 = New Label()
        ClientIDTextBox = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        ReservationIDTextBox = New TextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Highlight
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-1, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(801, 47)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(210, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(401, 45)
        Label1.TabIndex = 0
        Label1.Text = "Reservation management"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(RoomNoComboBox)
        Panel2.Controls.Add(ExitButton)
        Panel2.Controls.Add(RemoveButton)
        Panel2.Controls.Add(EditButton)
        Panel2.Controls.Add(AddButton)
        Panel2.Controls.Add(CheckOutMaskedTextBox)
        Panel2.Controls.Add(CheckInMaskedTextBox)
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(ClientIDTextBox)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(ReservationIDTextBox)
        Panel2.Location = New Point(-1, 47)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(801, 306)
        Panel2.TabIndex = 1
        ' 
        ' RoomNoComboBox
        ' 
        RoomNoComboBox.FormattingEnabled = True
        RoomNoComboBox.Location = New Point(128, 102)
        RoomNoComboBox.Name = "RoomNoComboBox"
        RoomNoComboBox.Size = New Size(130, 23)
        RoomNoComboBox.TabIndex = 17
        ' 
        ' ExitButton
        ' 
        ExitButton.BackColor = SystemColors.Highlight
        ExitButton.FlatStyle = FlatStyle.Popup
        ExitButton.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        ExitButton.Location = New Point(301, 269)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(75, 23)
        ExitButton.TabIndex = 16
        ExitButton.Text = "E&xit"
        ExitButton.UseVisualStyleBackColor = False
        ' 
        ' RemoveButton
        ' 
        RemoveButton.BackColor = SystemColors.Highlight
        RemoveButton.FlatStyle = FlatStyle.Popup
        RemoveButton.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        RemoveButton.Location = New Point(210, 269)
        RemoveButton.Name = "RemoveButton"
        RemoveButton.Size = New Size(75, 23)
        RemoveButton.TabIndex = 15
        RemoveButton.Text = "Remove"
        RemoveButton.UseVisualStyleBackColor = False
        ' 
        ' EditButton
        ' 
        EditButton.BackColor = SystemColors.Highlight
        EditButton.FlatStyle = FlatStyle.Popup
        EditButton.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        EditButton.Location = New Point(116, 269)
        EditButton.Name = "EditButton"
        EditButton.Size = New Size(75, 23)
        EditButton.TabIndex = 14
        EditButton.Text = "Edit"
        EditButton.UseVisualStyleBackColor = False
        ' 
        ' AddButton
        ' 
        AddButton.BackColor = SystemColors.Highlight
        AddButton.FlatStyle = FlatStyle.Popup
        AddButton.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        AddButton.Location = New Point(26, 269)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(75, 23)
        AddButton.TabIndex = 13
        AddButton.Text = "Add"
        AddButton.UseVisualStyleBackColor = False
        ' 
        ' CheckOutMaskedTextBox
        ' 
        CheckOutMaskedTextBox.Location = New Point(128, 195)
        CheckOutMaskedTextBox.Mask = "00/00/0000 90:00"
        CheckOutMaskedTextBox.Name = "CheckOutMaskedTextBox"
        CheckOutMaskedTextBox.Size = New Size(130, 23)
        CheckOutMaskedTextBox.TabIndex = 12
        CheckOutMaskedTextBox.ValidatingType = GetType(Date)
        ' 
        ' CheckInMaskedTextBox
        ' 
        CheckInMaskedTextBox.Location = New Point(128, 150)
        CheckInMaskedTextBox.Mask = "00/00/0000 90:00"
        CheckInMaskedTextBox.Name = "CheckInMaskedTextBox"
        CheckInMaskedTextBox.Size = New Size(130, 23)
        CheckInMaskedTextBox.TabIndex = 11
        CheckInMaskedTextBox.ValidatingType = GetType(Date)
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(381, 9)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(408, 253)
        DataGridView1.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(13, 198)
        Label7.Name = "Label7"
        Label7.Size = New Size(93, 15)
        Label7.TabIndex = 9
        Label7.Text = "CheckOut Date: "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(13, 153)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 15)
        Label6.TabIndex = 8
        Label6.Text = "CheckIn Date: "
        ' 
        ' ClientIDTextBox
        ' 
        ClientIDTextBox.Location = New Point(128, 62)
        ClientIDTextBox.Name = "ClientIDTextBox"
        ClientIDTextBox.Size = New Size(130, 23)
        ClientIDTextBox.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 15)
        Label2.TabIndex = 1
        Label2.Text = "Reservation ID: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 65)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 2
        Label3.Text = "Client ID: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 105)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 15)
        Label4.TabIndex = 3
        Label4.Text = "Room No: "
        ' 
        ' ReservationIDTextBox
        ' 
        ReservationIDTextBox.Location = New Point(128, 26)
        ReservationIDTextBox.Name = "ReservationIDTextBox"
        ReservationIDTextBox.Size = New Size(130, 23)
        ReservationIDTextBox.TabIndex = 0
        ' 
        ' Reservation
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Reservation"
        Text = "Reservation"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ReservationIDTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ClientIDTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckOutMaskedTextBox As MaskedTextBox
    Friend WithEvents CheckInMaskedTextBox As MaskedTextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RemoveButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents RoomNoComboBox As ComboBox
End Class
