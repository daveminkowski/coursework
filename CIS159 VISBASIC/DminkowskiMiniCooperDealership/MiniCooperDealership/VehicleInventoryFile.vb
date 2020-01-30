' Project:  Mini Cooper Dealerhship
' Name:     Dave Minkowski
' Date:     12/3/2017
' Purpose:  This application allows the user to add cars to the inventory of a Mini Cooper
' car dealership. The program displays the sticker price for each car and allows the user
' to display the entire inventory.

Option Strict On

Public Class VehicleInventoryFile

    Private _strVehicleNumber As String
    Private _strVehicleModel As String
    Private _strVehicleColor As String
    Private _intVehicleYear As Integer
    Private _decVehicleMileage As Decimal
    Private _decVehiclePrice As Decimal
    Private _decConvertibleMarkup As Decimal

    Sub New(ByVal strVehicleNumber As String, ByVal strVehicleModel As String, ByVal intVehicleYear As Integer,
           ByVal decVehicleMileage As Decimal, ByVal decVehiclePrice As Decimal, ByVal strVehicleColor As String)

        _strVehicleNumber = strVehicleNumber
        _strVehicleModel = strVehicleModel
        _strVehicleColor = strVehicleColor
        _intVehicleYear = intVehicleYear
        _decVehicleMileage = decVehicleMileage
        _decVehiclePrice = decVehiclePrice
        _decConvertibleMarkup = (decVehiclePrice * 1.26D)

    End Sub

    Sub WriteRecord()

        Dim strFileLocation As String = "VehicleInventory.txt"

        Try
            Dim objWriter As IO.StreamWriter = IO.File.AppendText(strFileLocation)

            objWriter.Write(_strVehicleNumber & ",")
            objWriter.Write(_strVehicleColor & ",")
            objWriter.Write(_intVehicleYear & ",")
            objWriter.Write(_strVehicleModel & ",")
            objWriter.Write(_decVehicleMileage & ",")

            If frmMain.chkConvertible.Checked = True Then
                objWriter.WriteLine(_decConvertibleMarkup)
            Else
                objWriter.WriteLine(_decVehiclePrice)
            End If

            objWriter.Close()

        Catch ex As Exception
            MsgBox("Unable to read the file: " & strFileLocation)
            Application.Exit()

        End Try

    End Sub

End Class
