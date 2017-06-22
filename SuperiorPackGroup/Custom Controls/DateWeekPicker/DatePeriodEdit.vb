Imports DevExpress.XtraEditors
Imports System.ComponentModel

Public Class DatePeriodEdit
    Inherits DateEdit

    Shared Sub New()

        RepositoryItemDatePeriodEdit.RegisterDatePeriodEdit()

    End Sub

    Public Sub New()
        MyBase.New()

        EditValue = New PeriodSet

    End Sub

    Protected Overrides Function CreatePopupForm() As Popup.PopupBaseForm

        Return New VistaPopupDatePeriodEditForm(Me)

    End Function

    Protected Overrides Function ExtractParsedValue(e As Controls.ConvertEditValueEventArgs) As Object

        Return e.Value

    End Function

    Public Overrides ReadOnly Property EditorTypeName As String
        Get
            Return RepositoryItemDatePeriodEdit.DatePeriodEditName
        End Get
    End Property

    Public Overrides Property EditValue As Object
        Get
            Dim value As PeriodSet = TryCast(MyBase.EditValue, PeriodSet)

            If Properties.PeriodStoreMode = StoreMode.StringMode Then
                If value IsNot Nothing Then
                    Return value.ToString
                Else
                    Return String.Empty
                End If
            Else
                If value IsNot Nothing Then
                    Return value
                Else
                    Return New PeriodSet()
                End If
            End If
        End Get
        Set(value As Object)
            If TypeOf value Is PeriodSet Then
                MyBase.EditValue = value
                Return
            End If

            If TypeOf value Is String Then
                MyBase.EditValue = PeriodSet.Parse(CStr(value))
                Return
            End If

            MyBase.EditValue = value
        End Set
    End Property



    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    Public Shadows ReadOnly Property Properties() As RepositoryItemDatePeriodEdit
        Get
            Return TryCast(MyBase.Properties, RepositoryItemDatePeriodEdit)
        End Get
    End Property
End Class
