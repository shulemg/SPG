Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class Utilities

    Public Shared Function FilterQuote(ByVal value As String) As String

        Return value.Replace("'", "''")

    End Function

    Public Shared Sub MakeFormReadOnly(ByVal container As Control, ByVal setReadOnly As Boolean)

        Try
            Dim control As Control
            For Each control In container.Controls
                If control.ToString = "DevExpress.XtraEditors.GroupControl" Then
                    MakeFormReadOnly(control, setReadOnly)
                End If
                Try
                    CType(control, BaseEdit).Properties.ReadOnly = setReadOnly
                    Continue For
                Catch
                    Continue For
                End Try
            Next
        Finally

        End Try

    End Sub

    Public Shared Sub MakeGridReadOnly(ByVal container As GridView, ByVal setReadOnly As Boolean)

        Try
            Dim column As DevExpress.XtraGrid.Columns.GridColumn
            For Each column In container.Columns
                Try
                    column.OptionsColumn.ReadOnly = setReadOnly
                    Continue For
                Catch exception1 As Exception
                    Continue For
                End Try
            Next
        Finally

        End Try

    End Sub

    Public Shared Function ChangeType(ByVal value As Object, ByVal conversionType As Type) As Object

        If (conversionType Is Nothing) Then
            Throw New ArgumentNullException("conversionType")
        End If

        'If it's not a nullable type, just pass through the parameters to Convert.ChangeType
        If (conversionType.IsGenericType) AndAlso conversionType.GetGenericTypeDefinition().Equals(GetType(Nullable(Of ))) Then
            ' It's a nullable type, so instead of calling Convert.ChangeType directly which would throw a
            ' InvalidCastException (per http://weblogs.asp.net/pjohnson/archive/2006/02/07/437631.aspx),
            ' determine what the underlying type is
            ' If it's null, it won't convert to the underlying type, but that's fine since nulls don't really
            ' have a type--so just return null
            ' Note: We only do this check if we're converting to a nullable type, since doing it outside
            ' would diverge from Convert.ChangeType's behavior, which throws an InvalidCastException if
            ' value is null and conversionType is a value type.
            If (value Is Nothing) Then
                Return Nothing
            End If

            ' It's a nullable type, and not null, so that means it can be converted to its underlying type,
            ' so overwrite the passed-in conversion type with this underlying type
            conversionType = Nullable.GetUnderlyingType(conversionType)
        End If


        'theType.GetGenericTypeDefinition().Equals(GetType(Nullable(Of )))
        'andalso conversionType.GetGenericTypeDefinition().Equals(typeof(Nullable<>))
        'Now that we've guaranteed conversionType is something Convert.ChangeType can handle (i.e. not a
        ' nullable type), pass the call on to Convert.ChangeType
        Return Convert.ChangeType(value, conversionType)

    End Function

    Public Shared Function ChangeType(Of T)(ByVal value As Object) As T

        Dim conversionType As Type = GetType(T)
        If conversionType.IsGenericType AndAlso conversionType.GetGenericTypeDefinition().Equals(GetType(Nullable(Of ))) Then
            If value Is Nothing OrElse IsDBNull(value) OrElse CStr(value) = String.Empty Then
                Return (Nothing)
            End If
            conversionType = Nullable.GetUnderlyingType(conversionType)
        End If
        Return (DirectCast(Convert.ChangeType(value, conversionType), T))

    End Function



End Class
