﻿' Project:  Mini Cooper Dealerhship
' Name:     Dave Minkowski
' Date:     12/3/2017
' Purpose:  This application allows the user to add cars to the inventory of a Mini Cooper
' car dealership. The program displays the sticker price for each car and allows the user
' to display the entire inventory.

Option Strict On

Public Class HardTopMini

    'class variables
    Protected _strVehicleNumber As String
    Protected _strVehicleModel As String
    Protected _intVehicleYear As Integer
    Protected _strVehicleColor As String
    Protected _decVehicleMileage As Decimal
    Protected _decVehiclePrice As Decimal

    Dim objVehicleInventoryFile As VehicleInventoryFile

    Sub New(ByVal strVehicleNumber As String, ByVal strVehicleColor As String, ByVal intVehicleYear As Integer,
            ByVal strVehicleModel As String, ByVal decVehicleMileage As Decimal, ByVal decVehiclePrice As Decimal)
        _strVehicleNumber = strVehicleNumber
        _strVehicleModel = strVehicleModel
        _strVehicleColor = strVehicleColor
        _intVehicleYear = intVehicleYear
        _decVehicleMileage = decVehicleMileage
        _decVehiclePrice = decVehiclePrice

    End Sub

    Overridable Function ComputeCosts() As Decimal
        ' this function returns the cost of the vehicle and writes to the text file

        objVehicleInventoryFile = New VehicleInventoryFile(_strVehicleNumber, _strVehicleModel, _intVehicleYear,
                                                           _decVehicleMileage, _decVehiclePrice, _strVehicleColor)

        objVehicleInventoryFile.WriteRecord()

        Return _decVehiclePrice

    End Function


End Class