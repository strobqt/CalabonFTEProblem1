Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBeverage.Items.AddRange(New String() {"Espresso", "Latte", "Cappuccino", "Americano", "Mocha"})
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim customerName As String
        Dim beveragePrice As Decimal
        Dim quantity As Integer
        Dim subtotal As Decimal
        Dim discount As Decimal
        Dim finalTotal As Decimal

        customerName = txtName.Text.Trim()
        If String.IsNullOrEmpty(customerName) Then
            MessageBox.Show("Please enter the customer's name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If ComboBeverage.SelectedIndex = -1 Then
            MessageBox.Show("Please select a beverage.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            quantity = CInt(NumberQuantity.Value)
            If quantity <= 0 Then
                MessageBox.Show("Quantity must be a positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid quantity input.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End Try

        Select Case ComboBeverage.SelectedItem.ToString()
            Case "Espresso"
                beveragePrice = 120
            Case "Latte"
                beveragePrice = 150
            Case "Cappuccino"
                beveragePrice = 160
            Case "Americano"
                beveragePrice = 130
            Case "Mocha"
                beveragePrice = 170
        End Select


        subtotal = beveragePrice * quantity
        lblSubtotal.Text = "Total: " + subtotal.ToString()
        If checkDiscount.Checked Then
            discount = subtotal * 0.1
            lblDiscount.Text = "Discount: " + discount.ToString()
        Else
            lblDiscount.Text = "No Discount: ₱0.00"
        End If

        finalTotal = subtotal - discount
        lblFinalTotal.Text = "Final Total: " + finalTotal.ToString()

        Dim summary As String = $"Order for {customerName} submitted. Final Total: {finalTotal.ToString("")}"
        MessageBox.Show(summary, "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class

