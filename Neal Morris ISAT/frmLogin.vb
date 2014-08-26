Public Class frmLogin


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'Declaring required variables, and storing user input into them
        Dim username As String = txtUsername.Text
        Dim password As String = txtPw.Text
        'Defining instances 
        Dim inst As New mainDSTableAdapters.LoginAuthTableAdapter
        Dim mainForm As New frmMain

        'Running the query predefined in the DS
        If inst.Authenticate(username, password) = 0 Then
            'If 0 is returned no rows have been found
            MessageBox.Show("Sorry, wrong login details.", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf inst.Authenticate(username, password) = 1 Then
            'Clearing textboxes and changing forms
            txtPw.Clear()
            txtUsername.Clear()
            MessageBox.Show("Welcome", "Login sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            frmMain.Show()
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
