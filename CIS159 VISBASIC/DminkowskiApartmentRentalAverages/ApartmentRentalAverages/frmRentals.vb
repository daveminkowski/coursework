' Program Name: Apartment Rental Costs by City
' Author: Dave Minkowski
' Date: 10/23/2017
' Purpose: To calculate the median cost of the top 10 most expensive cities in the US

Option Strict On

Public Class frmRentals

    ' class level variables

    Public Shared _intSizeOfArray As Integer = 9
    Public Shared _strCityName(_intSizeOfArray) As String
    Public Shared _intCityCost(_intSizeOfArray) As Integer

    Private Sub frmRentals_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' populate the listbox object with the inventory items. 

        ' Initialize an instance of the StreamReader object and declare variables. 

        Dim objReader As IO.StreamReader
        Dim strLocationAndNameOfFile As String = "rentals.txt"
        Dim intCount As Integer = 0
        Dim intFill As Integer
        Dim strFileError As String = "The file is not available. Restart when the file is available."

        ' Verify the file exists
        If IO.File.Exists(strLocationAndNameOfFile) Then
            objReader = IO.File.OpenText(strLocationAndNameOfFile)

            ' Read the file line by line until the file is completed
            Do While objReader.Peek <> -1
                _strCityName(intCount) = objReader.ReadLine()
                _intCityCost(intCount) = Convert.ToInt32(objReader.ReadLine())
                intCount += 1
            Loop

            objReader.Close()

            ' the listbox object is filled with the city names
            For intFill = 0 To (_strCityName.Length - 1)
                lstCities.Items.Add(_strCityName(intFill))
            Next
        Else
            MsgBox(strFileError, , "Error")
            Close()
        End If

        lstCities.Items.ToString()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        ' the click event calls the cost averaging sub procedure
        ' for this exercise I feel like it's just easier to leave it in this calculate method instead of making a whole sub procedure for it?
        ' I just didn't feel that there was enough math to be done to warrant two separate methods, unless I completely misunderstood which averages I was to make 
        ' in these methods. I've included two methods anyeay, but only oen of them is an arithmetic operation.
        CalcAverage()
        ShowResults()

        lblCitiesMedianCost.Visible = True
        lblCitiesMedian.Visible = True



    End Sub

    Private Sub CalcAverage()
        ' sets an integer to the sum of the values of the city cost array
        Dim intCityTotals As Integer = _intCityCost.Sum
        ' sets an integer to the value of the tlength of the array (10)
        Dim intNumEntries As Integer = _intCityCost.Length


        Dim decFinalMedianPrice = intCityTotals / intNumEntries
        lblCitiesMedianCost.Text = decFinalMedianPrice.ToString("C")

    End Sub

    Private Sub ShowResults()

        lblCitiesMedian.Visible = True
        lblCitiesMedianCost.Visible = True

    End Sub
    Private Sub Display_Click(sender As Object, e As EventArgs) Handles mnuDisplay.Click

        'the mnuDisplay click event creates an instance of the frmPriceData

        Dim frmSecond As New frmPriceData

        ' hide this form and show the price data form
        Hide()
        frmSecond.ShowDialog()

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click

        lstCities.SelectedIndex = 0
        lblCitiesMedianCost.Visible = False
        lblSummary.Visible = False
        lblCitiesMedian.Visible = False




    End Sub

    Private Sub Exit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    Private Sub lstCities_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCities.SelectedIndexChanged


        lblSummary.Visible = True

        Dim intSelectedIndex As Integer
        Dim intCityCost As Integer
        Dim strSelectedCity As String = ""

        intSelectedIndex = lstCities.SelectedIndex
        If (lstCities.SelectedIndex >= -1) Then
            strSelectedCity = lstCities.SelectedItem.ToString
        Else
            MsgBox(MsgBox("Please Select a City", , "Error"))
        End If


        intCityCost = _intCityCost(intSelectedIndex)

        lblSummary.Text = String.Format("Average cost of a 2 bedroom apartment in {0} ", strSelectedCity & " : " & intCityCost.ToString("C"))

        ' This is what I had originally, what a mess.

        'If lstCities.SelectedIndex = 0 Then
        '    lblCityCost.Text = _intCityCost(0).ToString("C")
        'ElseIf lstCities.SelectedIndex = 1 Then
        '    lblCityCost.Text = _intCityCost(1).ToString("C")
        'ElseIf lstCities.SelectedIndex = 2 Then
        '    lblCityCost.Text = _intCityCost(2).ToString("C")
        'ElseIf lstCities.SelectedIndex = 3 Then
        '    lblCityCost.Text = _intCityCost(3).ToString("C")
        'ElseIf lstCities.SelectedIndex = 4 Then
        '    lblCityCost.Text = _intCityCost(4).ToString("C")
        'ElseIf lstCities.SelectedIndex = 5 Then
        '    lblCityCost.Text = _intCityCost(5).ToString("C")
        'ElseIf lstCities.SelectedIndex = 6 Then
        '    lblCityCost.Text = _intCityCost(6).ToString("C")
        'ElseIf lstCities.SelectedIndex = 7 Then
        '    lblCityCost.Text = _intCityCost(7).ToString("C")
        'ElseIf lstCities.SelectedIndex = 8 Then
        '    lblCityCost.Text = _intCityCost(8).ToString("C")
        'ElseIf lstCities.SelectedIndex = 9 Then
        '    lblCityCost.Text = _intCityCost(9).ToString("C")
        'ElseIf lstCities.SelectedIndex = 10 Then
        '    lblCityCost.Text = _intCityCost({}).ToString("C")
        'Else
        '    lblCityCost.Text = ""
        'End If
    End Sub

End Class
