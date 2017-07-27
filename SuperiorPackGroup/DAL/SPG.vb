Partial Class SPG
    Partial Public Class ShippingsDataTable
        Private Sub ShippingsDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.strDeliveryNoteColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

Namespace SPGTableAdapters
    
    Partial Class ShippingsTableAdapter

    End Class

    Partial Public Class ProductionTableAdapter
    End Class
End Namespace

Namespace SPGTableAdapters
    
    Partial Public Class ItemsTableAdapter
    End Class
End Namespace

Namespace SPGTableAdapters

    Partial Public Class ItemsTableAdapter
    End Class
End Namespace
