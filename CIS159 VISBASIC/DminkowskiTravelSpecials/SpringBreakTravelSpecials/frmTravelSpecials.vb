' Project:  Travel Specials
' Name:     Dave Minkowski
' Date:     9/12/17

Public Class frmTravelSpecials
    Private Sub btnMyrtle_Click(sender As Object, e As EventArgs) Handles btnMyrtle.Click

        picMyrtle.Visible = True
        lblMyrtle.Visible = True
        lblMyrtleDescription.Visible = True
        picKeyWest.Visible = False
        lblKeyWest.Visible = False
        lblKeyWestDescription.Visible = False
        picVenice.Visible = False
        lblVenice.Visible = False
        lblVeniceDescription.Visible = False
        btnSelect.Enabled = True

    End Sub

    Private Sub btnKeyWest_Click(sender As Object, e As EventArgs) Handles btnKeyWest.Click

        picMyrtle.Visible = False
        lblMyrtle.Visible = False
        lblMyrtleDescription.Visible = False
        picKeyWest.Visible = True
        lblKeyWest.Visible = True
        lblKeyWestDescription.Visible = True
        picVenice.Visible = False
        lblVenice.Visible = False
        lblVeniceDescription.Visible = False
        btnSelect.Enabled = True


    End Sub

    Private Sub btnVenice_Click(sender As Object, e As EventArgs) Handles btnVenice.Click

        picMyrtle.Visible = False
        lblMyrtle.Visible = False
        lblMyrtleDescription.Visible = False
        picKeyWest.Visible = False
        lblKeyWest.Visible = False
        lblKeyWestDescription.Visible = False
        picVenice.Visible = True
        lblVenice.Visible = True
        lblVeniceDescription.Visible = True
        btnSelect.Enabled = True

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        btnMyrtle.Enabled = False
        btnVenice.Enabled = False
        btnKeyWest.Enabled = False
        btnExit.Enabled = True
        btnSelect.Enabled = False
        lblMyrtleDescription.Visible = False
        lblKeyWestDescription.Visible = False
        lblVeniceDescription.Visible = False
        lblConfirmation.Visible = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub

End Class
