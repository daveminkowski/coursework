'   Project:    Comic Convention Registration Calculator
'   Name:       David Minkowski
'   Date:       10/1/17
'   Purpose:    This application will compute the total cost of comic convention tickets based on the group 
'               size and the package price.

Public Class frmComicConvention
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim decGroupSize As Decimal ' The group size to be input by the user
        Dim decPackageCost As Decimal ' The variable to store the cost of the selected package
        Dim decTotalCost As Decimal ' The product of the above two variables
        Dim decBasicPackage As Decimal = 209D ' a constant to hold the price of the basic package
        Dim decAutographPackage As Decimal = 275D ' a constant to hold the price of the autograph package
        Dim decSuperheroPackage As Decimal = 380D ' a constant to hold the price of the superhero package

        ' Begin checking for valid input:
        If IsNumeric(txtGroupSize.Text) Then
            decGroupSize = Convert.ToDecimal(txtGroupSize.Text)

            ' Continue with input validation (group size must be between 0 ad 20)
            If decGroupSize > 0 And decGroupSize < 20 Then

                ' Continue with input validation (set package cost)
                ' (depending on which radio option is selected, set cost (decPackageCost) to one of the above constants
                If radBasic.Checked Then
                    decPackageCost = decBasicPackage
                ElseIf radAutograph.Checked Then
                    decPackageCost = decAutographPackage
                ElseIf radSuperhero.Checked Then
                    decPackageCost = decSuperheroPackage
                End If

                ' Calculate total cost (total cost = # in group x package cost)
                decTotalCost = decGroupSize * decPackageCost
                lblTotalCost.Text = decTotalCost.ToString("C")

                ' Output error(s) if the above if statement is not true:
            Else
                'Display error message if number is less than 0 or greater than 20
                MsgBox("You entered " & decGroupSize.ToString() & ". Please enter a valid number of attendees, between 1-20. (Badge presales are limited to parties of 20 or fewer)", , "Input Error")
                txtGroupSize.Text = ""
                txtGroupSize.Focus()
            End If

        Else
            ' Display error if user entered a nonnumeric value:
            MsgBox("Please enter the number of attendees in your group.", , "Input Error")
            txtGroupSize.Text = ""
            txtGroupSize.Focus()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        '   This button will clear the form, all its fields and label values, and reset the radio options
        '   to the default of "superhero package"

        txtGroupSize.Clear() ' clear text box with the clear method .Clear()
        lblTotalCost.Text = "" ' clear labels by setting their text to be blank
        radBasic.Checked = False ' Set basic convention package to be checked
        radAutograph.Checked = False ' Set autograph package to be unchecked
        radSuperhero.Checked = True ' Set superhero package to be unchecked
        txtGroupSize.Focus()

    End Sub

    Private Sub frmComicConvention_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   This will execute as the form is loaded. For this app, it will clear the total cost 
        '   label while focusing the cursor on the textbox. (The radio menus are set by default 
        '   when we created the form objects

        txtGroupSize.Focus()
        lblTotalCost.Text = ""

    End Sub
End Class
