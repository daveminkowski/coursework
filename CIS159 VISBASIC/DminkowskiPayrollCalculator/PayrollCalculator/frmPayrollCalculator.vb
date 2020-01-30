' Project:  Payroll Calculator
' Name:     Dave Minkowski
' Date:     9/15/17

Public Class frmPayrollCalculator

    ' Declaring class level variables and constants here:

    ' decNetPay will store the net total after taxes
    Dim decNetPay As Decimal

    ' These three constants are the different tax rates to be deducted from gross pay
    Const _cdecFICATax As Decimal = 0.0765D     ' D = forced literal type (decimal)
    Const _cdecStateTax As Decimal = 0.04D      ' D = forced literal type (decimal)
    Const _cdecFederalTax As Decimal = 0.22D    ' D = forced literal type (decimal)

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        ' Declare a decimal variable in which to store user text input
        Dim decGrossPay As Decimal

        ' Take user input from text box and store it the declared variable above (decGrossPay)
        decGrossPay = txtGrossPay.Text

        ' declare a decimal to store the amount of FICA tax to be deducted from gross pay
        Dim decTotalFICATax As Decimal
        ' Calculate the value of the FICA tax
        decTotalFICATax = decGrossPay * _cdecFICATax
        ' Populate the blank FICA tax label with the value of the above calculation
        lblFICATotal.Text = decTotalFICATax.ToString("C2")

        ' declare a decimal to store the amount of Federal tax to be deducted from gross pay
        Dim decTotalFedTax As Decimal
        ' Calculate the value of the Federal tax
        decTotalFedTax = decGrossPay * _cdecFederalTax
        ' Populate the blank Federal tax label with the value of the above calculation
        lblFederalTotal.Text = decTotalFedTax.ToString("C2")

        ' declare a decimal to store the amount of State tax to be deducted from gross pay
        Dim decTotalStateTax As Decimal
        ' Calculate the value of the State tax
        decTotalStateTax = decGrossPay * _cdecStateTax
        ' Populate the blank State tax label with the value of the above calculation
        lblStateTotal.Text = decTotalStateTax.ToString("C2")

        ' Calculate the net pay (gross pay - taxes) and store it as decNetPay
        decNetPay = decGrossPay - (decTotalFedTax + decTotalStateTax + decTotalFICATax)
        ' Populate the blank Net Pay label with the value of the above calculation
        lblNetTotal.Text = decNetPay.ToString("C2")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' Clear the user input text block
        txtGrossPay.Clear()

        ' Clear the output labels
        lblFICATotal.Text = ""
        lblFederalTotal.Text = ""
        lblStateTotal.Text = ""
        lblNetTotal.Text = ""

        ' Place cursor in the gross pay text block, ready for input
        txtGrossPay.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' Close the program
        Close()

    End Sub
End Class
