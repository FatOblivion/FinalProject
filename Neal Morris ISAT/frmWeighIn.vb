''' <summary>
''' Author: Neal Morris 9510315565084
''' Project: ISAT 
''' Description: Weigh-in specification Form
''' </summary>
Public Class frmWeighIn
    'Defining required variables and instances used accross multiple method stubs
    Private ID As Integer
    Private member As New clsMember
    Private bln As Boolean
    Private weight As Double
    Private age As Integer
    Private hrRest As Double
    Private V02Max As Double
    Private HRmax As Double
    Private Bmi As Double
    Private idealBMI As Double
    Private memberheight As Double
    Private gender As String
    Private bool As Boolean = False
    Private errorCase As Integer = 0
    'Defining required properties
    Public Property memheight As Double
        Get
            Return memberheight
        End Get
        Set(value As Double)
            memberheight = value
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

    Public Property memberID As Integer
        Get
            Return ID
        End Get
        Set(value As Integer)
            ID = value
        End Set
    End Property

    Private Sub WeighInBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.WeighInBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MainDS)

    End Sub
    'Creating method to convert all data safely, and sending properties to class
    Sub collectData()


        If IsNumeric(txtAge.Text) Then
            age = CInt(txtAge.Text)
            member.memberAge = age
        Else
            errorCase = 1
           
        End If

        If IsNumeric(txtWeight.Text) Then

            weight = CDbl(txtWeight.Text)
            member.memberWeight = weight
        Else
            errorCase = 2
          
        End If

        If IsNumeric(txtHr.Text) Then
            hrRest = CDbl(txtHr.Text)
            member.memberHrRest = hrRest

        Else
            errorCase = 3
           
        End If
        

        member.memberHeight = memberheight
        member.memberSex = gender

    End Sub


    Private Sub frmWeighIn_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If ID > 0 Then

            Me.WeighInTableAdapter.FillBy(Me.MainDS.WeighIn, ID)
        Else
            MessageBox.Show("You didn't select a member", "Error")
        End If

    End Sub


    Private Sub btnV02max_Click(sender As Object, e As EventArgs) Handles btnV02max.Click
        Call collectData()
        If errorCase = 0 Then
            'Calling predefined method to collect data and init required properties

            'Calling functions 
            member.heartRmax()
            V02Max = member.vo2max()
            MessageBox.Show(V02Max.ToString())
        Else

            MessageBox.Show("Please ensure that you fill in all the required fields with correct data", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Private Sub btnIdealBMI_Click(sender As Object, e As EventArgs) Handles btnIdealBMI.Click

        'Collecting data 
        Call collectData()
        If errorCase = 0 Then
            'Calling function
            idealBMI = member.idealBMI()
            MessageBox.Show("The ideal BMI is:" & idealBMI.ToString("N2"))
        Else
            errorCase = 0
            MessageBox.Show("Please ensure that you fill in all the required fields with correct data", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If
    End Sub

    Private Sub btnHRmax_Click(sender As Object, e As EventArgs) Handles btnHRmax.Click

        'Refreshing the view
        Me.WeighInDataGridView.Refresh()
        'Collecting data
        Call collectData()
        If errorCase = 0 Then
            'calling function and storing return val
            HRmax = member.heartRmax()
            MessageBox.Show(HRmax.ToString("n2"))

        Else
            errorCase = 0
            MessageBox.Show("Please ensure that you fill in all the required fields with correct data", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Declaring variables and instances
        Dim today As New Date
        today = Date.Today()
        Dim bmiStatus As String

        'Running logical block to determine BMI status
        If Bmi < 18.5 Then
            bmiStatus = "Underweight"
        ElseIf Bmi >= 18.5 Then
            bmiStatus = "Normal"
        ElseIf Bmi >= 25 Then
            bmiStatus = "Overweight"
        ElseIf Bmi > 30 Then
            bmiStatus = "Obese"
        End If

        'Ensuring all data has been defined, converted and stored in order to run try catch block for update query
        Call collectData()
        If errorCase = 0 Then
            Try

                member.calcBmi()
                member.heartRmax()
                member.vo2max()

                'Passing all the predefined params to adapter, to execute query
                Me.WeighInTableAdapter.UpdateQuery(V02Max, HRmax, hrRest, today, Bmi, bmiStatus, idealBMI, ID)
                Me.WeighInTableAdapter.Update(Me.MainDS)
                Me.MainDS.AcceptChanges()
                Me.WeighInDataGridView.Refresh()
                Me.Visible = False
                Me.Visible = True
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            errorCase = 0
            MessageBox.Show("Please ensure that you fill in all the required fields with correct data", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub

    Private Sub btnBMI_Click(sender As Object, e As EventArgs) Handles btnBMI.Click

        Call collectData()
        If errorCase = 0 Then
            Bmi = member.calcBmi()
            MessageBox.Show("Current BMI is:" & Bmi.ToString("N2"))
        Else
            MessageBox.Show("Please ensure that you fill in all the required fields with correct data", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error)
            errorCase = 0
            Exit Sub

        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()



    End Sub

    Private Sub WeighInDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles WeighInDataGridView.CellEnter
        'declaring row position and storing it
        Dim row As Integer = Me.WeighInDataGridView.SelectedRows.Count()
        'placeholder to store data
        Dim x = Me.WeighInDataGridView.Item(0, row)
        'declared as long to handle negative vals
        Dim i As Long = CLng(x.Value)
        'If number is less than 1 it will throw an error
        If i < 1 Then
            'Alert user
            MessageBox.Show("Please ensure the ID is > 1", "Please don't", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'reset val
            Me.WeighInDataGridView.Rows(0).Cells(0).Value = vbNull
            Exit Sub
        End If
    End Sub

    'Creating event handler to handle input errors in the datagrid
    Private Sub WeighInDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles WeighInDataGridView.DataError

        'Creating a select statement to handle the context of each exception with descriptive error messages
        Select Case e.Context

            Case DataGridViewDataErrorContexts.Commit
                MessageBox.Show("We couldn't save that..", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Case DataGridViewDataErrorContexts.CurrentCellChange
                MessageBox.Show("You left invalid data in a cell", "Please fix that beforing moving on", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Case DataGridViewDataErrorContexts.Parsing
                MessageBox.Show("Please ensure all data is correctly formatted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Case DataGridViewDataErrorContexts.LeaveControl
                MessageBox.Show("We couldn't save that cell", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Select
    End Sub
End Class