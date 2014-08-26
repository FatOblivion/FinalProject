Partial Class mainDS
    Partial Class MemberDataTable

        Private Sub MemberDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Join_DateColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace mainDSTableAdapters
    
    Partial Public Class MemberTableAdapter
    End Class
End Namespace
