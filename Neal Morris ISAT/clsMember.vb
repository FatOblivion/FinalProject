''' <summary>
''' Author: Neal Morris 9510315565084
''' Project: ISAT 
''' Description: Member class
''' </summary>
Public Class clsMember
    'Declaring variables used in various methods
    Private gender As String
    Private weight As Double
    Private height As Double
    Private age As Integer
    Private hrRest As Double

    'Defining required properties
    Public Property memberHrRest As Double
        Get
            Return hrRest
        End Get
        Set(value As Double)
            hrRest = value
        End Set
    End Property
    Public Property memberAge As Integer
        Get
            Return age
        End Get
        Set(value As Integer)
            age = value
        End Set
    End Property

    Public Property memberHeight As Double
        Get
            Return height
        End Get
        Set(value As Double)
            height = value
        End Set
    End Property

    Public Property memberSex As String
        Get
            Return gender
        End Get
        Set(value As String)
            gender = value
        End Set
    End Property
    Public Property memberWeight As Double
        Get
            Return weight
        End Get
        Set(value As Double)
            weight = value
        End Set
    End Property
    'Function to calculate current BMI
    Public Function calcBmi()
        Dim final As Double
        Dim x As Double = height / 100
        final = (weight / x ^ 2)
        Return final
    End Function

    'Function to calculate Ideal BMI
    Public Function idealBMI() As Double
        'Declaring placeholders
        Dim final As Double
        Dim x As Double = 0.5 * weight
        Dim i As Double = height / 100

        'Checking gender
        If gender = "Male" Then
            final = x / i ^ 2 + 11.5
        ElseIf gender = "Female" Then
            final = 0.5 * weight / ((height / 100) ^ 2) + 0.03 * age + 11
        End If

        Return final
    End Function
    'Function to calculate v02max
    Public Function vo2max()
        Return 15 * heartRmax() / hrRest
    End Function
    'Function to calculate Heart rate max
    Public Function heartRmax()
        Return 205.8 - (0.685 * age)
    End Function

End Class
