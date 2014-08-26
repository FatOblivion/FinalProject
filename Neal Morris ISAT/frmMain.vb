Public Class frmMain

    Private Sub btnTrainer_Click(sender As Object, e As EventArgs) Handles btnTrainer.Click
        'Declaring instance and opening a dialogue window
        Dim frm As New frmTrainer
        frm.ShowDialog()
    End Sub

    Private Sub btnMember_Click(sender As Object, e As EventArgs) Handles btnMember.Click
        'Declaring instance and opening a dialogue window
        Dim frm As New frmMember
        frm.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        'loggin out
        frmLogin.Show()
        Me.Close()
    End Sub
End Class
