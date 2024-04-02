<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Billing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CalculateBill = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CalculateBill
        '
        Me.CalculateBill.Location = New System.Drawing.Point(118, 41)
        Me.CalculateBill.Name = "CalculateBill"
        Me.CalculateBill.Size = New System.Drawing.Size(198, 59)
        Me.CalculateBill.TabIndex = 0
        Me.CalculateBill.Text = "CalculateBill"
        Me.CalculateBill.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(121, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 66)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ApplyDiscount"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(125, 249)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(197, 65)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "PrintInvoice"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CalculateBill)
        Me.Name = "Billing"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CalculateBill As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
