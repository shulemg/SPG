Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.Utils


<UserRepositoryItem("RegisterDatePeriodEdit")>
Public Class RepositoryItemDatePeriodEdit
    Inherits RepositoryItemDateEdit

#Region "Fields"
    Private optionsSelections As OptionsSelection
    Private _periodStoreMode As StoreMode
    Private _separatorChar As Char = ","c
#End Region
#Region "Constants"
    Public Const DatePeriodEditName As String = "DatePeriodEdit"
#End Region
#Region "Constructors"
    Shared Sub New()

        RegisterDatePeriodEdit()

    End Sub

    Public Sub New()

        optionsSelections = New OptionsSelection()
        TextEditStyle = TextEditStyles.DisableTextEditor

    End Sub
#End Region
#Region "Protected Methods"
    Protected Overrides Function IsNullValue(editValue As Object) As Boolean

        If TypeOf editValue Is PeriodSet Then
            Return (CType(editValue, PeriodSet)).Periods.Count = 0
        End If

        If TypeOf editValue Is String Then
            Dim dates As PeriodSet = PeriodSet.Parse(CStr(editValue))

            If dates IsNot Nothing Then
                Return dates.Periods.Count = 0
            End If
        End If

    End Function
#End Region
#Region "Public Methods"
    Public Overrides Sub Assign(item As RepositoryItem)
        MyBase.Assign(item)

        Dim source As RepositoryItemDatePeriodEdit = TryCast(item, RepositoryItemDatePeriodEdit)

        optionsSelections = source.OptionsSelection
        _separatorChar = source.SeparatorChar
        _periodStoreMode = source.PeriodStoreMode

    End Sub

    Public Overrides Function GetDisplayText(format As FormatInfo, editValue As Object) As String

        Dim displayText As String = String.Empty
        Dim dates As PeriodSet = TryCast(editValue, PeriodSet)

        If dates IsNot Nothing Then
            displayText = dates.ToString(format.FormatString, SeparatorChar)
        Else
            If TypeOf editValue Is String Then
                displayText = PeriodSet.Parse(CStr(editValue)).ToString(format.FormatString, SeparatorChar)
            End If
        End If

        Dim e As New CustomDisplayTextEventArgs(editValue, displayText)

        If format IsNot EditFormat Then
            RaiseCustomDisplayText(e)
        End If

        Return e.DisplayText

    End Function

    Public Shared Sub RegisterDatePeriodEdit()

        EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(DatePeriodEditName, GetType(DatePeriodEdit), GetType(RepositoryItemDatePeriodEdit), GetType(DateEditViewInfo), New ButtonEditPainter(), True))

    End Sub
#End Region
#Region "Public Properties"
    <Browsable(False)>
    Public Overrides ReadOnly Property EditFormat As FormatInfo
        Get
            Return MyBase.DisplayFormat
        End Get
    End Property

    <Browsable(False)>
    Public Shadows ReadOnly Property EditMask As String
        Get
            Return MyBase.EditMask
        End Get
    End Property

    Public Overrides ReadOnly Property EditorTypeName As String
        Get
            Return DatePeriodEditName
        End Get
    End Property

    <Browsable(False)>
    Public Overrides ReadOnly Property Mask As Mask.MaskProperties
        Get
            Return MyBase.Mask
        End Get
    End Property

    <Description("Provides access to the settings used for selection."), Category(CategoryName.Properties), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    Public ReadOnly Property OptionsSelection() As OptionsSelection
        Get
            Return optionsSelections
        End Get
    End Property

    <Description("Gets or sets how the editor stores periods selected via the calendar."), Category(CategoryName.Format), DefaultValue(StoreMode.DefaultMode)>
    Public Overridable Property PeriodStoreMode() As StoreMode
        Get
            Return _periodStoreMode
        End Get
        Set(value As StoreMode)
            If PeriodStoreMode = value Then
                Return
            End If
            _periodStoreMode = value
        End Set
    End Property

    <Description("Gets or sets the character that will separate periods."), Category(CategoryName.Format), DefaultValue(","c)>
    Public Overridable Property SeparatorChar() As Char
        Get
            Return _separatorChar
        End Get
        Set(value As Char)
            If SeparatorChar = value Then
                Return
            End If
            _separatorChar = value
            OnPropertiesChanged()
        End Set
    End Property

    <Browsable(False)>
    Public Shadows ReadOnly Property VistaDisplayMode As DefaultBoolean
        Get
            Return MyBase.VistaDisplayMode
        End Get
    End Property

    <Browsable(False)>
    Public Shadows ReadOnly Property VistaEditTime As DefaultBoolean
        Get
            Return MyBase.VistaEditTime
        End Get
    End Property
#End Region
End Class
