' Project:  Street Taco Web Order Form
' Name:     Dave Minkowski
' Date:     11/13/2017
' Purpose:  The web application will request order information for the street taco order form. The web site
'           will compute the cost of the order and diplay an order confirmation message. 


Partial Class About
    Inherits Page

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Const cdecSalesTax As Decimal = 0.0805D
        Dim decCarneCost As Decimal = 13.99D
        Dim decChickenCost As Decimal = 8.99D
        Dim decPorkCost As Decimal = 9.99D
        Dim decFishCost As Decimal = 12.99D
        Dim decXtraTopping As Decimal = 0.99D
        Dim decToppingCost As Decimal = 0D

        Dim decFillingCost As Decimal = 0D
        Dim decFinalCost As Decimal = 0D

        ' declaring these string variables and trimming the extra spaces during declaration

        Dim strName As String = txtName.Text.Trim
        Dim strAddress As String = txtAddress.Text.Trim
        Dim strPhone As String = txtPhone.Text.Trim

        ' confirmation message string" 

        Dim strConfirmation As String

        ' clear confirmation label to be blank
        lblConfirmation.Text = ""

        ' calculate cost of toppings

        If chkJalapeno.Checked Then
            decToppingCost += decXtraTopping
        End If
        If chkCilantro.Checked Then
            decToppingCost += decXtraTopping
        End If
        If chkPico.Checked Then
            decToppingCost += decXtraTopping
        End If
        If chkSour.Checked Then
            decToppingCost += decXtraTopping
        End If
        If chkGuac.Checked Then
            decToppingCost += decXtraTopping
        End If

        decFillingCost = Convert.ToDecimal(ddlFilling.SelectedItem.Value)
        decFinalCost = (decFillingCost + decToppingCost) * (1 + cdecSalesTax)

        strConfirmation = "Thank you! An order has been placed for: " & "<br>" & strName & "<br>" & "At : " & strAddress & "." & "<br>" & "By phone number: " & strPhone & "." & "<br>" & "<br>" & "Your order total is " & decFinalCost.ToString("C") & " and will be ready to pick up in 10 minutes or less."
        lblConfirmation.Text = strConfirmation

    End Sub
End Class