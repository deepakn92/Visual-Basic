

'Program Name:  Windows Online Shipping Application
' Author:       Deepak Nalla
' Date :        3/26/2014
' Purpose:     This Windows application allows the user to compute the shipping cost and select the location that they want the item
'               to ship too.  ie. Choosing the United States will have a particular price as opposed to 
'               choosing Latin America.

Public Class frmWindowsOnlineShop

    Dim decPounds As Decimal
    Dim decCostPerPd As Decimal
    Dim decCostEstim As Decimal
    Dim decShipUsa As Decimal = 6.0
    Dim decShipLa As Decimal = 8.0
    Dim decShipCan As Decimal = 8.0


    Private Sub btnShpFee_Click(sender As Object, e As EventArgs) Handles btnShpFee.Click
        If IsNumeric(txtWeight.Text) Then
            decPounds = Convert.ToDecimal(txtWeight.Text)
            If (decPounds > 0) And (decPounds < 5.0) Then
                If radUSA.Checked Then
                    decCostPerPd = decShipUsa
                ElseIf radLatAm.Checked Then
                    decCostPerPd = decShipLa
                ElseIf radCan.Checked Then
                    decCostPerPd = decShipCan
                End If
                If radShipOverngt.Checked Then
                    decCostPerPd = decCostPerPd * 2
                End If
                decCostEstim = decPounds * decCostPerPd
                lblCostEstimate.Text = decCostEstim.ToString("C")


            ElseIf (decPounds > 5.0) And (decPounds <= 20) Then

                If radUSA.Checked Then
                    decCostPerPd = decShipUsa + (decShipUsa * 0.25)
                ElseIf radLatAm.Checked Then
                    decCostPerPd = decShipLa + (decShipLa * 0.25)
                ElseIf radCan.Checked Then
                    decCostPerPd = decShipCan + (decShipCan * 0.25)
                End If
                If radShipOverngt.Checked Then
                    decCostPerPd = decCostPerPd * 2
                End If
                decCostEstim = decPounds * decCostPerPd
                lblCostEstimate.Text = decCostEstim.ToString("C")
            Else
                MsgBox("You entered " & decPounds.ToString() & " . Enter a Positive Number, and a Number less than 20 pounds", , "Input Error")
                txtWeight.Text = ""
                txtWeight.Focus()
            End If


        Else
            MsgBox("Enter the Item Weight in Pounds", , "Input Error")
            txtWeight.Text = ""
            txtWeight.Focus()
        End If
    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        txtWeight.Clear()
        lblCostEstimate.Text = ""
        radUSA.Checked = True
        radCan.Checked = False
        radLatAm.Checked = False
        txtWeight.Focus()
    End Sub

    Private Sub frmWindowsOnlineShop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtWeight.Focus()
        lblCostEstimate.Text = ""
        radShipOverngt.Checked = False

    End Sub
End Class

