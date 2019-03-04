Option Strict On

' Author:       Anastasiia Kononirenko
' Student ID:   100717670
' Date:         08/02/2019
' Purpose:      Lab_3_Average_Units_Shipped_By_Employee
' Description:  A windows forms application that calculates the average number of units shipped 
'               within a week per employee, as well as, the company average.

Public Class frmAverageUnitsShippedByEmployee

#Region "Declarations"
    ' CONSTANT DECLARATIONS
    Const NUMBER_OF_DAYS As Integer = 7               ' Number of days
    Const MINIMUM_NUMBER_OF_UNITS As Integer = 0      ' Minimum allowed number of units
    Const MAXIMUM_NUMBER_OF_UNITS As Integer = 1000   ' Maximum allowed number of units
    Const NUMBER_OF_EMPLOYEES As Integer = 3          ' Number of employees
    Const SENTINEL_VALUE As Integer = -1              ' Sentinel value for input validation

    ' VARIABLE DECLARATIONS
    Dim unitsPerEmployee(NUMBER_OF_EMPLOYEES - 1, NUMBER_OF_DAYS - 1) As Integer  ' Holds units entered by the user
    Dim employee As Integer = 0   ' Holds current employee
    Dim day As Integer = 1        ' Holds current day of the week
#End Region

#Region "Functions"
    ''' <summary>
    ''' Validates user input for the number of units
    ''' </summary>
    ''' <param name="userInput"></param>
    ''' <returns></returns>
    Private Function InputValidation(ByVal userInput As String) As Integer
        Dim validNumber As Integer   ' Holds function return value
        If (Integer.TryParse(userInput, validNumber) = False) Then   ' If user input is not a number,
            MessageBox.Show("Input must be numeric, whole numbers only, no decimals. Please try again.")  ' display the error message
            validNumber = SENTINEL_VALUE   ' set the validNumber value to the sentinel value
        ElseIf (validNumber < MINIMUM_NUMBER_OF_UNITS OrElse validNumber > MAXIMUM_NUMBER_OF_UNITS) Then  ' If the number isn't within the required range,
            MessageBox.Show("Please ensure the units shipped are between " & MINIMUM_NUMBER_OF_UNITS.ToString & " and " & MAXIMUM_NUMBER_OF_UNITS.ToString & "!") ' display the error message
            validNumber = SENTINEL_VALUE   ' set the validNumber value to the sentinel value
        End If
        txtUnits.Focus()      ' Set Focus to the txtUnits text box
        txtUnits.SelectAll()  ' Select the text in the txtUnits text box
        Return validNumber    ' Return validNumber
    End Function

    ''' <summary>
    ''' Calculates the average units shipped for an employee
    ''' </summary>
    ''' <param name="inputArray"></param>
    ''' <param name="index"></param>
    ''' <returns></returns>
    Private Function CalculateEmployeeAverage(ByVal inputArray(,) As Integer, ByVal index As Integer) As Double
        Dim sumOfUnits As Double = 0   ' Holds the sum of numbers of units shipped
        For day As Integer = 0 To NUMBER_OF_DAYS - 1   ' Calculate the sum,
            sumOfUnits += inputArray(index, day)       ' using a for loop
        Next
        Return sumOfUnits / NUMBER_OF_DAYS   ' Return the average number of units
    End Function

    ''' <summary>
    ''' Calculates the company average
    ''' </summary>
    ''' <param name="unitsArray"></param>
    ''' <returns></returns>
    Private Function CalculateCompanyAverage(ByVal unitsArray(,) As Integer) As Double
        Dim companySum As Double    ' Holds the sum of employees' averages
        For employee As Integer = 0 To NUMBER_OF_EMPLOYEES - 1            ' Calsulate the sum,
            companySum += CalculateEmployeeAverage(unitsArray, employee)  ' using a for loop
        Next
        Return companySum / NUMBER_OF_EMPLOYEES    ' Return the company average
    End Function

    ''' <summary>
    ''' Resets Form to its initial state
    ''' </summary>
    Private Sub ResetForm()
        Dim textBoxesToReset() As TextBox = {txtDisplayUnits1, txtDisplayUnits2, txtDisplayUnits3}  ' Holds text boxes displaying number of units shipped per day
        Dim labelsToReset() As Label = {lblDisplayAverage1, lblDisplayAverage2, lblDisplayAverage3, lblDisplayCompanyAverage}   ' Holds labels that needs to be reset
        txtUnits.ReadOnly = False   ' Set the ReadOnly property of the txtUnits text box to False
        txtUnits.Focus()            ' Set Focus to the txtUnits text box
        btnEnter.Enabled = True     ' Enable the btnEnter button
        day = 1      ' Set the day value to 1
        lblDays.Text = "Day " & day.ToString    ' Set the text property of lblDay label to "Day 1"
        employee = 0 ' Set the employee value to 0
        For Each textBox As TextBox In textBoxesToReset  ' Reset the Text property of the text boxes that 
            textBox.Text = String.Empty                  ' display number of units shipped
        Next
        For Each label As Label In labelsToReset         ' Reset the Text property of the labels that
            label.Text = String.Empty                    ' display the averages
        Next
    End Sub
#End Region

#Region "btnEnter"
    ''' <summary>
    ''' Click event of the btnEnter button that validates user input, displays number of units shipped,
    ''' calculates employees' averages and the company average
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim displayTextBoxes() As TextBox = {txtDisplayUnits1, txtDisplayUnits2, txtDisplayUnits3}  ' Holds text boxes displaying number of units shipped per day
        Dim employeeLabels() As Label = {lblEmployee1, lblEmployee2, lblEmployee3, lblDisplayAverage1, lblDisplayAverage2, lblDisplayAverage3}  ' Holds labels displaying employees' numbers and averages
        Dim numberOfUnits As Integer    ' Holds number of units shipped
        numberOfUnits = InputValidation(txtUnits.Text)  ' Validate user input using InputValidation function
        If (numberOfUnits <> SENTINEL_VALUE) Then   ' If user input passes validation, then
            txtUnits.Clear()    ' Clear the text in the txtUnits text box
            unitsPerEmployee(employee, day - 1) = numberOfUnits     ' Store number of units shipped in the array
            displayTextBoxes(employee).Text += numberOfUnits.ToString & vbCrLf      ' Display number of units in the current employee text box
            If (day = NUMBER_OF_DAYS) Then      ' If the number of units has been entered for the 7th day, then
                employeeLabels(employee + 3).Text = "Average: " & Math.Round(CalculateEmployeeAverage(unitsPerEmployee, employee), 2).ToString("n2") ' Display current employee's average
                If (employee = NUMBER_OF_EMPLOYEES - 1) Then    ' If the number of units has been entered for the last employee, then
                    lblDisplayCompanyAverage.Text = "Average per day: " & Math.Round(CalculateCompanyAverage(unitsPerEmployee), 2).ToString("n2") ' Display the company average
                    lblDays.Text = "Done"       ' Set the Text property of the lblDays label to "Done"
                    txtUnits.ReadOnly = True    ' Set the ReadOnly property of the txtUnits text box to True
                    btnEnter.Enabled = False    ' Disable the btnEnter button
                    btnReset.Focus()            ' Set Focus to the btnReset button
                    employeeLabels(0).Font = New Font(employeeLabels(0).Font, FontStyle.Bold)   ' Change the font of the label to Bold
                    employeeLabels(employee).Font = New Font(employeeLabels(employee).Font, FontStyle.Regular)  ' Change the font of the label to Regular
                    Exit Sub    ' Exit the subroutine
                Else    ' If the number of units has not been entered for the last employee, then
                    employeeLabels(employee).Font = New Font(employeeLabels(employee).Font, FontStyle.Regular)  ' Change the font of the label to Regular
                    employee += 1   ' Increase the value of employee variable by 1
                    day = 0         ' Set the value of day variable to 0
                    employeeLabels(employee).Font = New Font(employeeLabels(employee).Font, FontStyle.Bold) ' Change the font of the label to Bold
                End If
            End If
            day += 1  ' Increase the value of day variable by 1
            lblDays.Text = "Day " & day.ToString  ' Display the current day
        End If
    End Sub
#End Region

#Region "btnReset"
    ''' <summary>
    ''' Click event of the Reset button that resets the form using the subroutine
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()   ' Use the subroutine to reset the form
    End Sub
#End Region

#Region "btnExit"
    ''' <summary>
    ''' Click event of the Exit button that exits the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()  ' Close the form
    End Sub
#End Region

End Class
