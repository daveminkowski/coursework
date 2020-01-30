' Project:  Tiny House Builders
' Name:     Dave Minkowski
' Date:     11/20/2017
' Purpose:  To use windows forms to access and display records in a microsoft access database

Public Class frmTinyHouse
    Private Sub BuildersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BuildersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BuildersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TinyHousesDataSet)

    End Sub

    Private Sub frmTinyHouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TinyHousesDataSet.Builders' table. You can move, or remove it, as needed.
        Me.BuildersTableAdapter.Fill(Me.TinyHousesDataSet.Builders)

    End Sub

End Class
