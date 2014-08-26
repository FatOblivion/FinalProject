''' <summary>
''' Author: Neal Morris 9510315565084
''' Project: ISAT 
''' Description: Personal trainer form
''' </summary>
Public Class frmMember
    'Declaring variables and instances used for various methods
    Private member As New clsMember
    Private age As Integer
    Private weight As Double
    Private hrRest As Double
    Private bln As Boolean = False



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnWeighIn.Click
        'Declaring instances and variables
        Dim frm As New frmWeighIn
        Dim ID As Integer

        'Checking if DS contains data
        If Me.MainDS.Member.Rows.Count > 0 Then
            'If there's data, it's safe to convert
            ID = CInt(Me.MainDS.Member.Rows(0).Item("ID"))
        Else
            'No ID specified, so running dialogue to collect the ID
            MessageBox.Show("Seems that you didn't search a member", "Hmm..", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim x As String = InputBox("Please enter member ID", "Member ID")
            'To be safe, running through another logical block to ensure safe data conversion
            If IsNumeric(x) Then
                ID = CInt(x)
                'Refilling DS 
                Try
                    Me.MemberTableAdapter.FillBy1(Me.MainDS.Member, ID)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            Else
                'Escape to avoid crash
                Exit Sub
            End If
        End If

        'Passing required properties to the next form
        frm.memheight = CDbl(Me.MainDS.Member.Rows(0).Item("Height(cm)"))
        frm.memberSex = CStr(Me.MainDS.Member.Rows(0).Item("Gender"))
        frm.memberID = ID
        frm.ShowDialog()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Defining variables, storing input data from dialogue
        Dim x As String = InputBox("Enter ID")
        Dim id As Integer

        'Run through logical block for safe data conversion
        If IsNumeric(x) Then
            id = CInt(x)
            'Try catch block to ensure the program handles errors
            Try
                Me.MemberTableAdapter.FillBy1(Me.MainDS.Member, id)
                'Updating view
                MemberDataGridView.Update()
                'Refreshing components
                Me.Visible = False
                Me.Visible = True
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else
            MessageBox.Show("That can't be right. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Defining dialogue result from message box
        Dim x As DialogResult = MessageBox.Show("Are you sure?", "Save all changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        'If user clicked no, the sub will escape
        If x = Windows.Forms.DialogResult.No Then
            Exit Sub
        ElseIf x = Windows.Forms.DialogResult.Yes Then
            'Running try catch block for error handling
            Try
                Me.MemberBindingSource.EndEdit()
                'updating dataset and accepting changes
                Me.TableAdapterManager.UpdateAll(Me.MainDS)
                Me.MainDS.AcceptChanges()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub



    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If Me.MainDS.Member.Rows.Count > 0 Then
            'Declaring variables and storing count
            Dim oldRegionRow As mainDS.MemberRow


            Dim i As Integer = CInt(Me.MemberDataGridView.SelectedRows.Count)
            Dim y As Integer = Me.MainDS.Member.Rows(i).Item("ID")

            Dim result As DialogResult = MessageBox.Show("are you sure?", "Really?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)
            oldRegionRow = MainDS.Member.FindByID(y)
            'If user clicked OK, try catch block runs to delete current row of data
            If result = Windows.Forms.DialogResult.OK Then

                Try
                    oldRegionRow.Delete()

                    Me.TableAdapterManager.UpdateAll(Me.MainDS)
                    Me.MainDS.AcceptChanges()
                    Me.MemberBindingSource.EndEdit()
                    Me.Visible = False
                    Me.Visible = True
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        Else
            MessageBox.Show("Nothing to delete", "hmm..", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    'Creating error handle, when the user changes cell
    Private Sub MemberDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles MemberDataGridView.CellEndEdit
        'declaring row position and storing it
        Dim row As Integer = Me.MemberDataGridView.SelectedRows.Count()
        'placeholder to store data
        Dim x = Me.MemberDataGridView.Item(0, row)
        'declared as long to handle negative vals
        Dim i As Long = CLng(x.Value)
        'If number is less than 1 it will throw an error
        If i < 1 Then
            'Alert user
            MessageBox.Show("Please ensure the ID is > 1", "Please don't", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'reset val
            Me.MemberDataGridView.Rows(0).Cells(0).Value = vbNull
            Exit Sub
        End If
    End Sub




    'Creating event handler to handle input errors in the datagrid
    Private Sub MemberDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles MemberDataGridView.DataError

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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class