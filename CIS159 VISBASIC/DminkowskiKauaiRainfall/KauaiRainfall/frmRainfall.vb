' Project:  Most Rainfall in USA
' Name:     Dave Minkowski
' Date:     10/7/2017

Public Class frmRainfall

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        '    declaring variables

        Dim strRainfall As String
        Dim decRainfall As Decimal
        Dim decAverageRainfall As Decimal
        Dim decTotalRainfall As Decimal = 0D

        Dim strInputMessage As String = "Enter the amount of rainfall (in inches) for month #"
        Dim strInputHeading As String = "Monthly Rainfall"
        Dim strNormalMessage As String = "Enter the amount of rainfall (in inches) for month #"
        Dim strNonNumericError As String = "Error - Enter a numeric value for inches of rainfall for month #"
        Dim strNegativeError As String = "Error - Enter a positive number for inches of rainfall for month #"

        '   Declare and initialize loop variables

        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 12
        Dim intNumberOfEntries As Integer = 1

        '   This loop allows the user to enter the rainfall for each of the past 12 months
        '   The loop terminates when the user has entered 12 rainfall values or the user
        '   clicks the Cancel or Close button in the inputbox.

        strRainfall = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        '   Do Loop
        '   will continue until the number of entries is greater than the max allowed (12) or until 
        '   the user clicks the cancel button. 
        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strRainfall = strCancelClicked
            If IsNumeric(strRainfall) Then
                decRainfall = Convert.ToDecimal(strRainfall)
                If decRainfall > 0 Then
                    '   The two above "if" statements check if the value is both numeric and greater than 0
                    '   The program then continues to ask for input and increments the number of entries by 1
                    lstMonthlyRainfall.Items.Add(decRainfall)
                    decTotalRainfall += decRainfall
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage

                Else
                    strInputMessage = strNegativeError

                End If
            Else
                strInputMessage = strNonNumericError
                '   The two ebove "else" statements display a message if either the two "if" conditions are not met
            End If

            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strRainfall = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop

        ' Calculates and displays average rainfall
        If intNumberOfEntries > 1 Then
            lblAverageRainfall.Visible = True
            '   calculates average. number of entries is subtracted by 1 since the variable is initialized
            '   at a value of 1 before it is given its first value by the user
            decAverageRainfall = decTotalRainfall / (intNumberOfEntries - 1)
            lblAverageRainfall.Text = "Average Rainfall per Month is " &
                decAverageRainfall.ToString("F1") & " inches"
        Else
            MsgBox("No rainfall value entered")
        End If

        '   disables rainfall calculation button
        btnCalc.Enabled = False
    End Sub

    Private Sub mnuFile_Click(sender As Object, e As EventArgs) Handles mnuFile.Click

    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click

        lstMonthlyRainfall.Items.Clear()
        lblAverageRainfall.Visible = False
        btnCalc.Enabled = True

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        Close()

    End Sub
End Class
