' Author:       Deepak Nalla
' Date:         April 30, 2014
' Purpose:      The 'Where Our Students Live' Program enters the mileage
'               from students to see how far away are students' homes. It displays
'               each mileage value, and then after all the mileage values have 
'               been entered, it displays the average number of miles from school.

Option Strict On

Public Class frmWhereStudentsLive

    Private Sub btnMileage_Click(sender As Object, e As EventArgs) Handles btnMileage.Click
        ' The btnMileage_Click event accepts and displays up to 10 mileage values
        ' and then calculates and displays the average mileage from the school.

        'Declare and initialize variables

        Dim strMileage As String
        Dim decMileage As Decimal
        Dim decAverageMileage As Decimal
        Dim decTotalMileage As Decimal
        Dim strInputMessage As String = "Enter the mileage for student #"
        Dim strInputHeading As String = "Mileage"
        Dim strNormalMessage As String = "Enter the mileage for student #"
        Dim strNonNumericError As String = "Error - Enter a number for the mileage of student #"
        Dim strNegativeError As String = "Error - Enter a positive number for the mileage of student #"

        ' Declare and Initialize Loop variables

        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 10
        Dim intNumberOfEntries As Integer = 1

        ' This loop allows the user to enter the mileage of up to 10 students.
        ' The loop terminates when the user has entered a mileage value or the 
        ' user taps or clicks the Exit buttor or Clear button in the InputBox

        strMileage = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strMileage = strCancelClicked

            If IsNumeric(strMileage) Then
                decMileage = Convert.ToDecimal(strMileage)
                If decMileage > 0 Then
                    lstMileage.Items.Add(decMileage)
                    decTotalMileage += decMileage
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else : strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strMileage = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop

        'Calculates and displays average Mileage value
        If intNumberOfEntries > 1 Then
            lblAverageMileage.Visible = True
            decAverageMileage = decTotalMileage / (intNumberOfEntries - 1)
            lblAverageMileage.Text = "Our students live an average of " & _
                decAverageMileage.ToString("F2") & " miles from the school"
        Else
            MsgBox("No mileage value entered")
        End If

        'Disables the enter Mileage button
        btnMileage.Enabled = False

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        lstMileage.Items.Clear()
        lblAverageMileage.Visible = False
        btnMileage.Enabled = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
