' Project:  Mini Cooper Dealerhship
' Name:     Dave Minkowski
' Date:     12/3/2017
' Purpose:  This application allows the user to add cars to the inventory of a Mini Cooper
' car dealership. The program displays the sticker price for each car and allows the user
' to display the entire inventory.

Imports Microsoft.VisualBasic.FileIO

Public Class frmInventory

    Private MiniInventoryParser As TextFieldParser

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstVehicleColor.Items.Clear()
        lstVehicleMileage.Items.Clear()
        lstVehicleModel.Items.Clear()
        lstVehicleNumber.Items.Clear()
        lstVehiclePrice.Items.Clear()
        lstVehicleYear.Items.Clear()


        Dim strFileLocation As String = "VehicleInventory.txt"
        Try
            MiniInventoryParser = New TextFieldParser(strFileLocation)
            MiniInventoryParser.TextFieldType = FieldType.Delimited
            MiniInventoryParser.SetDelimiters(",")

        Catch
            MessageBox.Show("Unable to read the file: " & strFileLocation)
        End Try

        Dim strInventoryField() As String
        If MiniInventoryParser.EndOfData Then
            MessageBox.Show("No records to display.", "End of Data")
        Else
            While Not MiniInventoryParser.EndOfData
                strInventoryField = MiniInventoryParser.ReadFields()
                lstVehicleNumber.Items.Add(strInventoryField(0))
                lstVehicleColor.Items.Add(strInventoryField(1))
                lstVehicleYear.Items.Add(strInventoryField(2))
                lstVehicleModel.Items.Add(strInventoryField(3))
                lstVehicleMileage.Items.Add(strInventoryField(4))
                lstVehiclePrice.Items.Add(strInventoryField(5))
            End While
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        Hide()

    End Sub
End Class