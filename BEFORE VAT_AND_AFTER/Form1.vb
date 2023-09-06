Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        Dim Price As Decimal
        Dim Quantity As Decimal
        Dim Total As Decimal
        Dim Calculate As String

        'Get Prices 
        Price = txtPrice.Text
        Quantity = txtQuantity.Text
        Calculate = BtnCalculate.Text

        'Total cost
        Total = Price * Quantity


        'Message
        MsgBox("Your Total is " & " R" & Total)


    End Sub
End Class