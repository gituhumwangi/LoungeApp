Public Class Billing
    Private Sub btnCalculateBill_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Calculate total bill based on stay duration and services used
        Dim stayDuration As Integer = Convert.ToInt32(txtStayDuration.Text)
        Dim additionalServicesCost As Double = 0 ' Calculate cost of additional services here

        Dim totalBill As Double = (stayDuration * nightlyRate) + additionalServicesCost
        Dim discount As Double = 0

        ' Apply discount if any
        totalBill -= discount

        ' Display total bill in a label or textbox
        lblTotalBill.Text = "Total Bill: $" & totalBill.ToString()
    End Sub

    Private Sub btnPrintInvoice_Click(sender As Object, e As EventArgs) Handles btnPrintInvoice.Click
        ' Code to print the invoice goes here
    End Sub
End Class
