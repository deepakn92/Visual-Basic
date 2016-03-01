' Program:  State Fair Tickets
' Author:   Deepak Nalla
' Date:     3/26/2014
' Purpose:  This application calculates and displays the total cost of tickets wanted by the user

Option Strict On

Public Class frmStateFairTickets

   
    Const _cdecPricePerTicket As Decimal = 12.99D
    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        Dim strNumberOfTickets As String
        Dim intNumberofTickets As Integer
        Dim decTotalCostOfTickets As Decimal

        strNumberOfTickets = txtNoOfTickets.Text
        intNumberofTickets = Convert.ToInt32(strNumberOfTickets)
        decTotalCostOfTickets = intNumberofTickets * _cdecPricePerTicket
        lblDisplayCost.Text = decTotalCostOfTickets.ToString("C")






    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNoOfTickets.Clear()
        lblDisplayCost.Text = ""
        txtNoOfTickets.Focus()



    End Sub
    Private Sub frmStateFairTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeading.Text = _cdecPricePerTicket.ToString("C") & " Per Ticket"
        lblDisplayCost.Text() = ""
        txtNoOfTickets.Focus()



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
