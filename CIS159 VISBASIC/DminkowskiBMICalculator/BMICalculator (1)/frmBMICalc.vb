' Project:  BMI Calculator
' Name:     Dave Minkowski
' Date:     10/16/2017
' This project will allow a user to input their height and weight, choose either imperial or metric measurements, and calculate their bmi based on their input.
' The main function will display the results calculated by to sub functions. The inputs will be validated, and the calculate button will nto be usable until the user inputs
' a height/weight and selects a unit of measurement. 

Option Strict On

Public Class frmBMICalc

    ' class-level constants
    Const decUnderweight As Decimal = 18.5D
    Const decNormalweight As Decimal = 25D
    Const decOverweight As Decimal = 29.9D

    Dim blnValidatedInputs As Boolean
    Dim strHeightInput As String
    Dim strWeightInput As String


    Private Sub Calc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim decWeight As Decimal
        Dim decHeight As Decimal
        Dim decBMI As Decimal
        Dim blnHeightAndWeightAreValid As Boolean = False
        Dim blnMeasurementTypeHasBeenSelected As Boolean = False
        Dim strUnitType As String = ""
        Dim intUnitChoice As Integer

        lblCategory.Visible = True
        lblWeightType.Visible = True
        lblHeightType.Visible = True


        ' calls function to validate if height and weight were entered properly.
        blnHeightAndWeightAreValid = ValidateHeightWeightInput()

        '   call a function to ensure either imperial or metric measurements was selected

        intUnitChoice = ValidateMeasurementSelection(blnMeasurementTypeHasBeenSelected, strUnitType)

        ' If a measurement type has been chosen and the height/weight are valid inputs, calculate the BMI

        If (blnHeightAndWeightAreValid And blnMeasurementTypeHasBeenSelected) Then

            intUnitChoice = (lstUnitType.SelectedIndex)
            Select Case intUnitChoice
                Case 0
                    decBMI = ImperialBMICalc(decWeight, decHeight)
                Case 1
                    decBMI = MetricBMICalc(decWeight, decHeight)
            End Select

            ' display the particulars of the BMI

            ' display the pertinent health category based on the resulting BMI
            If (decBMI < decUnderweight) Then
                lblCategory.Text = "Your BMI is " & decBMI.ToString("F2") & ". According to the CDC, this classifies you as underweight for your height."
            ElseIf (decBMI > decUnderweight And decBMI < decNormalweight) Then
                lblCategory.Text = "Your BMI is " & decBMI.ToString("F2") & ". According to the CDC, this classifies you as being of normal weight for your height."
            ElseIf (decBMI > decNormalweight And decBMI < decOverweight) Then
                lblCategory.Text = "Your BMI is " & decBMI.ToString("F2") & ". According to the CDC, this classifies you as overweight for your height."
            Else
                lblCategory.Text = "Your BMI is " & decBMI.ToString("F2") & ". According to the CDC, this classifies you as obese for your height."
            End If

        Else
            MsgBox("Ensure you have selected a measurement type and entered a valid height and weight.", , "Error")
        End If

    End Sub

    Private Function ImperialBMICalc(ByVal decWeight As Decimal, ByVal decHeight As Decimal) As Decimal
        ' This function calculates the BMI cost using imperial measurements

        ' function-level variable
        Dim decImperialBMI As Decimal

        decWeight = Convert.ToDecimal(txtWeight.Text)
        decHeight = Convert.ToDecimal(txtHeight.Text)

        decImperialBMI = (decWeight * 703) / (decHeight * decHeight) ' BMI calculations for Imperial measurements

        Return decImperialBMI

    End Function

    Private Function MetricBMICalc(ByVal decWeight As Decimal, ByVal decHeight As Decimal) As Decimal
        ' This function calculates the BMI cost using metric measurements

        ' function-level variable
        Dim decMetricBMI As Decimal

        decWeight = Convert.ToDecimal(txtWeight.Text)
        decHeight = Convert.ToDecimal(txtHeight.Text)

        decMetricBMI = (decWeight) / (decHeight * decHeight) ' BMI calculations for Metric measurements

        Return decMetricBMI

    End Function

    Private Function ValidateHeightWeightInput() As Boolean
        ' this procedure validates whether a value entered for height and weight

        'procedure-level variables
        Dim decHeightInput As Decimal
        Dim decWeightInput As Decimal
        Dim blnHeightWeightValidated As Boolean = False
        Dim strInputsInvalid As String = "Please enter a valid, non-negative value for height and weight."
        Dim strMessageBoxTitle As String = "Error"

        Try
            decHeightInput = Convert.ToDecimal(txtHeight.Text)
            decWeightInput = Convert.ToDecimal(txtWeight.Text)
            If decHeightInput >= 1 And decWeightInput >= 1 Then
                blnHeightWeightValidated = True
            Else
                MsgBox(strInputsInvalid, , strMessageBoxTitle)
            End If

        Catch Exception As FormatException
            MsgBox(strInputsInvalid, , strMessageBoxTitle)
            txtHeight.Focus()
            txtHeight.Clear()
            txtWeight.Clear()
        Catch Exception As OverflowException
            MsgBox(strInputsInvalid, , strMessageBoxTitle)
            txtHeight.Focus()
            txtHeight.Clear()
            txtWeight.Clear()
        Catch Exception As SystemException
            MsgBox(strInputsInvalid, , strMessageBoxTitle)
            txtHeight.Focus()
            txtHeight.Clear()
            txtWeight.Clear()
        End Try

        Return blnHeightWeightValidated

    End Function

    Private Function ValidateMeasurementSelection(ByRef blnMeasurementTypeHasBeenSelected As Boolean, ByRef strUnitType As String) As Integer
        ' this function ensure the user selected imperial or metric measurements

        ' function-level variables:

        Dim intUnitType As Integer
        Try
            intUnitType = Convert.ToInt32(lstUnitType.SelectedIndex)
            strUnitType = lstUnitType.SelectedItem.ToString()
            blnMeasurementTypeHasBeenSelected = True

        Catch ex As SystemException
            'detects if one of the two types was not selected
            MsgBox("Select Imperial or Metric.", , "Error") ' this doesnt seem to be necessary now as the calculate button will not show without selecting imperial or metric.
            blnMeasurementTypeHasBeenSelected = False
        End Try

        Return intUnitType

    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' This event handler clears the form and resets the form for reuse when the user clicks the clear button

        txtHeight.Clear()
        txtWeight.Clear()
        txtHeight.Focus()

        lblCategory.Text = ""
        lblCategory.Visible = False
        btnCalc.Enabled = False

    End Sub

    Private Sub lstUnitType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUnitType.SelectedIndexChanged

        If (lstUnitType.SelectedItem Is "Imperial") Then
            lblHeightType.Text = "inches:"
            lblWeightType.Text = "pounds:"
            lblHeightType.Visible = True
            lblWeightType.Visible = True
            lblHeightInput.Visible = True
            lblWeightInput.Visible = True
            txtHeight.Visible = True
            txtWeight.Visible = True


        ElseIf (lstUnitType.SelectedItem Is "Metric") Then
            lblHeightType.Text = "meters:"
            lblWeightType.Text = "kilograms:"
            lblHeightType.Visible = True
            lblWeightType.Visible = True
            lblHeightInput.Visible = True
            lblWeightInput.Visible = True
            txtHeight.Visible = True
            txtWeight.Visible = True
        End If

        If (txtHeight.Text IsNot "" And txtWeight.Text IsNot "") Then
            btnCalc.Enabled = True
        End If

        lblHeightType.Visible = True
        lblWeightType.Visible = True

    End Sub

    Private Sub txtWeight_TextChanged(sender As Object, e As EventArgs) Handles txtWeight.TextChanged
        If (txtHeight.Text IsNot "" And txtWeight.Text IsNot "" And lstUnitType.SelectedItem Is "Metric" Or lstUnitType.SelectedItem Is "Imperial") Then
            btnCalc.Enabled = True
        End If
    End Sub

    Private Sub txtHeight_TextChanged(sender As Object, e As EventArgs) Handles txtHeight.TextChanged
        If (txtWeight.Text IsNot "" And txtHeight.Text IsNot "" And lstUnitType.SelectedItem Is "Imperial" Or lstUnitType.SelectedItem Is "Metric") Then
            btnCalc.Enabled = True
        End If
    End Sub

    Private Sub frmBMICalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeightType.Visible = False
        lblHeightInput.Visible = False
        txtHeight.Visible = False
        lblWeightInput.Visible = False
        lblWeightType.Visible = False
        txtWeight.Visible = False
        lblCategory.Visible = False

        ' Hosplash for 5 seconds
        Threading.Thread.Sleep(5000)
    End Sub

End Class



