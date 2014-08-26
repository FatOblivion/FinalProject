''' <summary>
''' Author: Neal Morris 9510315565084
''' Project: ISAT 
''' Description: Personal trainer class
''' </summary>
Public Class clsPersonalTrainer
    'Declaring variables and constants
    Private trainerClass As Char
    Private baseSalary As Double
    Private memberFee As Double
    Private Const discount As Double = 0.05D
    'Creating required properties
    Public Property classType As Char
        Get
            Return trainerClass
        End Get
        Set(value As Char)
            trainerClass = value
        End Set
    End Property
    'Method to initialise Enumerator
    Sub initEnum()
        'Logical block checking personal trainer class, and assigning the correct base salary
        If trainerClass = "A" Then
            baseSalary = CDbl(BaseSal.classA)
            memberFee = 500
        ElseIf trainerClass = "B" Then
            baseSalary = CDbl(BaseSal.classB)
            memberFee = 375
        ElseIf trainerClass = "C" Then
            memberFee = 250
            baseSalary = CDbl(BaseSal.classC)
        End If

    End Sub
    'Declaring collection of salaries in enumerator
    Enum BaseSal
        classA = 10000
        classB = 7500
        classC = 5000
    End Enum

    'Function calculating final salary, using the param of user count
    Public Function calcFinalSal(ByVal memberCount As Integer) As Double
        Dim final As Double
        final = baseSalary + (discount * (memberCount * memberFee))
        Return final
    End Function

End Class
