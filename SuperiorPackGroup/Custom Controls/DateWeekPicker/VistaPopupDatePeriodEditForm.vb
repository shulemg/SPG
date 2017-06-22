Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class VistaPopupDatePeriodEditForm
    Inherits VistaPopupDateEditForm

    Public Sub New(ByVal ownerEdit As DateEdit)
        MyBase.New(ownerEdit)

    End Sub

    Protected Overrides Function CreateCalendar() As Controls.DateEditCalendar

        Dim c As VistaDateEditCalendar = New VistaDatePeriodEditCalendar(OwnerEdit.Properties, OwnerEdit.EditValue)

        AddHandler c.OkClick, AddressOf OnOkClick

        Return c

    End Function

    Public Overridable Shadows ReadOnly Property Calendar() As VistaDatePeriodEditCalendar
        Get
            Return TryCast(MyBase.Calendar, VistaDatePeriodEditCalendar)
        End Get
    End Property

    Public Overrides ReadOnly Property ResultValue As Object
        Get
            Return Calendar.TotalPeriods.GetCopy()
        End Get
    End Property

End Class
