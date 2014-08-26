''' <summary>
''' Author: Neal Morris 9510315565084
''' Project: ISAT 
''' Description: Personal trainer form
''' </summary>

Public Class frmTrainer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Defining variables and storing input from dialogue
        Dim x As String = InputBox("Please enter trainer ID", "Who are you looking for?")
        Dim inputID As Integer

        'Safe data conversion
        If IsNumeric(x) Then
            inputID = CInt(x)
        ElseIf Not IsNumeric(x) Then
            MessageBox.Show("That can't be right.", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Running try catch block to fill DS where the ID corresponds with the parameter
        Try
            Me.TrainerTableAdapter.FillBy(Me.MainDS.Trainer, inputID)
            TrainerDataGridView.Update()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Defining required variables and instances
        Dim trainerClass As Char
        Dim ID As Integer
        Dim memberCount As Integer
        Dim personalTrainer As New clsPersonalTrainer
        Dim finalSal As Double


        'If there's data in the dataset, it will extract the required information after converting it
        If Me.MainDS.Trainer.Rows.Count > 0 Then
            trainerClass = CChar(Me.MainDS.Trainer.Rows(0).Item("Class"))

            ID = CInt(Me.MainDS.Trainer.Rows(0).Item("ID"))
            memberCount = TrainerTableAdapter.MemberCount(ID)

        Else
            MessageBox.Show("It appears you haven't selected a trainer.", "Please try again")
            Exit Sub
        End If

        'Passing properties to the associated class
        personalTrainer.classType = trainerClass
        'Calling required methods
        personalTrainer.initEnum()
        finalSal = personalTrainer.calcFinalSal(memberCount)
        'Displaying final salary
        MessageBox.Show("The final salary is: " & finalSal.ToString("C2"))
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'close
        Me.Close()
    End Sub

    Private Sub btnMemberCnt_Click(sender As Object, e As EventArgs) Handles btnMemberCnt.Click
        'Defining required variables
        Dim memberCnt As Integer
        Dim ID As Integer

        'If there is data in ds it will extract and convert
        If Me.MainDS.Trainer.Rows.Count > 0 Then
            ID = CInt(Me.MainDS.Trainer.Rows(0).Item("ID"))
            'Checking how many members associated with the param of ID
            memberCnt = TrainerTableAdapter.MemberCount(ID)
            MessageBox.Show("The trainer, trains : " & memberCnt.ToString + " members")
        Else
            MessageBox.Show("It appears you haven't selected a trainer.", "Please try again")
            Exit Sub
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'try catch block to save changes
        Try
            Me.Validate()
            Me.TrainerBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MainDS)
            Me.MainDS.AcceptChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmTrainer_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

    End Sub



    'Event handler for datagrid errors
    Private Sub TrainerDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles TrainerDataGridView.DataError
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