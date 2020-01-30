' Project:  Mini Cooper Dealerhship
' Name:     Dave Minkowski
' Date:     12/3/2017
' Purpose:  This application allows the user to add cars to the inventory of a Mini Cooper
' car dealership. The program displays the sticker price for each car and allows the user
' to display the entire inventory.

Option Strict On

Public Class frmMain

    Dim vehiclePrice As Decimal
    Dim vehicleMileage As Decimal

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboVehicleColor.SelectedIndex = -1
        cboVehicleColor.Text = "Select a color"
        cboVehicleModel.SelectedIndex = -1
        cboVehicleModel.Text = "Select a model"
        lblStickerPrice.Visible = False
        lblStickerPriceValue.Visible = False
        chkConvertible.Checked = False

    End Sub

    Private Sub btnStickerPrice_Click(sender As Object, e As EventArgs) Handles btnStickerPrice.Click

        Dim objConvertibleMini As ConvertibleMini
        Dim objHardTopMini As HardTopMini
        Dim InputError As Boolean = False

        ' ensure a full length vin number is entered
        If txtVehicleNumber.TextLength < 1 Then
            MsgBox("Enter the Vehicle Identification Number", , "Error")
            txtVehicleNumber.Clear()
            txtVehicleNumber.Focus()
            InputError = True

            ' ensure a model is selected
        ElseIf cboVehicleModel.SelectedIndex < 0 Then
            MsgBox("Please select a vehicle model", , "Error")
            cboVehicleModel.Focus()
            InputError = True

            ' ensure a valid model year is entered 
        ElseIf Not IsNumeric(txtVehicleYear.Text) Then
            MsgBox("Enter a valid model year in the Vehicle Year Box", , "Error")
            txtVehicleYear.Clear()
            txtVehicleYear.Focus()
            InputError = True

            ' ensure only bmw mini model years are included in the search (year 2000-present)
        ElseIf Convert.ToInt32(txtVehicleYear.Text) < 2000 Or Convert.ToInt32(txtVehicleYear.Text) > 2020 Then
            MsgBox("Enter a valid model year in the Vehicle Year box", , "Error")
            txtVehicleYear.Clear()
            txtVehicleYear.Focus()
            InputError = True

            ' ensure only numeric entries are accepter for mileage
        ElseIf Not IsNumeric(txtVehicleMileage.Text) Then
            MsgBox("Enter the vehicle's mileage", , "Error")
            txtVehicleMileage.Clear()
            txtVehicleMileage.Focus()
            InputError = True
            ' parse entry as acceptable format for mileage (comma will cause an exception with above only validation)
        ElseIf Decimal.TryParse(txtVehicleMileage.Text, vehicleMileage) = False Then
            MsgBox("Enter the vehicle's mileage", , "Error")
            txtVehicleMileage.Clear()
            txtVehicleMileage.Focus()
            InputError = True

            ' ensure only numeric entries are accepter for price
        ElseIf Not IsNumeric(txtVehiclePrice.Text) Then
            MsgBox("Enter the vehicle's price", , "Error")
            txtVehiclePrice.Clear()
            txtVehiclePrice.Focus()
            InputError = True

            ' parse entry as acceptable format for price (comma will cause an exception with above only validation)
        ElseIf Decimal.TryParse(txtVehiclePrice.Text, vehiclePrice) = False Then
            MsgBox("Enter the vehicle's price", , "Error")
            txtVehiclePrice.Clear()
            txtVehiclePrice.Focus()
            InputError = True

            ' ensure a vehicle color is selected
        ElseIf cboVehicleColor.SelectedIndex < 0 Then
            MsgBox("Please select a color", , "Error")
            cboVehicleColor.Focus()
            InputError = True

        End If

        If Not InputError Then

            If chkConvertible.Checked Then
                objConvertibleMini = New ConvertibleMini(txtVehicleNumber.Text, Convert.ToString(cboVehicleColor.SelectedItem), Convert.ToInt32(txtVehicleYear.Text),
                                               Convert.ToString(cboVehicleModel.SelectedItem), Convert.ToDecimal(txtVehicleMileage.Text),
                                               Convert.ToDecimal(txtVehiclePrice.Text))

                lblStickerPrice.Visible = True
                lblStickerPriceValue.Visible = True
                lblStickerPriceValue.Text = objConvertibleMini.ComputeCosts().ToString("C")
            Else
                objHardTopMini = New HardTopMini(txtVehicleNumber.Text, Convert.ToString(cboVehicleColor.SelectedItem), Convert.ToInt32(txtVehicleYear.Text),
                                               Convert.ToString(cboVehicleModel.SelectedItem), Convert.ToDecimal(txtVehicleMileage.Text),
                                               Convert.ToDecimal(txtVehiclePrice.Text))

                lblStickerPrice.Visible = True
                lblStickerPriceValue.Visible = True
                lblStickerPriceValue.Text = objHardTopMini.ComputeCosts().ToString("C")

            End If

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtVehicleMileage.Clear()
        txtVehicleNumber.Clear()
        txtVehiclePrice.Clear()
        txtVehicleYear.Clear()
        cboVehicleColor.SelectedIndex = -1
        cboVehicleColor.Text = "Select a color"
        cboVehicleModel.SelectedIndex = -1
        cboVehicleModel.Text = "Select a model"
        chkConvertible.Checked = False
        lblStickerPrice.Text = ""
        lblStickerPrice.Visible = False
        lblStickerPriceValue.Text = ""
        lblStickerPriceValue.Visible = False

    End Sub

    Private Sub mnuDisplayInventory_Click(sender As Object, e As EventArgs) Handles mnuDisplayInventory.Click

        frmInventory.ShowDialog()

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        Application.Exit()

    End Sub

    Private Sub chkConvertible_CheckedChanged(sender As Object, e As EventArgs) Handles chkConvertible.CheckedChanged

        If chkConvertible.Checked = True Then
            picMiniConvert.Visible = True
            picMiniHardtop.Visible = False
        ElseIf chkConvertible.Checked = False Then
            picMiniHardtop.Visible = True
            picMiniConvert.Visible = False
        End If

    End Sub

End Class
