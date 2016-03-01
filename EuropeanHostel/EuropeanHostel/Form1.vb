' Program Name: European Hostel 
' Developer:    Deepak Nalla   
' Date:         2/19/2014
' Purpose:      This program shall let the user choose his/her selection of European Hostel by observing 2 images.

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles lnHostel.Click
        picLondonHostel.Visible = True
        picDublinHostel.Visible = False
        btnSelection.Enabled = True





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        picLondonHostel.Visible = False
        picDublinHostel.Visible = True
        btnSelection.Enabled = True
    End Sub

    Private Sub btnSelection_Click(sender As Object, e As EventArgs) Handles btnSelection.Click
        ' picLondonHostel.Visible = False
        'picDublinHostel.Visible = False
        btnSelection.Enabled = False
        btnExit.Enabled = True
        Confirmlbl.Visible = True
        Instructlbl.Visible = False
        Headerlbl.Visible = False






    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
