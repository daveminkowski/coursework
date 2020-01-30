Public Class frmPriceData

    Private Sub frmPriceData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' this is a second form that displays the sorted inventory items

        Dim strCities As String

        ' displays the _strCityName array
        For Each strCities In frmRentals._strCityName
            lstCities.Items.Add(strCities)
        Next

        Dim intCityPrice As Integer

        ' displays the _intCityCost array
        For Each intCityPrice In frmRentals._intCityCost
            lstPrices.Items.Add(intCityPrice.ToString("C"))
        Next

    End Sub


    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        ' this sub opens the first form

        Dim frmFirst As New frmRentals

        Hide()
        frmFirst.ShowDialog()
    End Sub
End Class