Imports System.Globalization

Public Class PeriodSet

#Region "Fields"
    Private ReadOnly _periods As ArrayList
#End Region
#Region "Constructors"
    Public Sub New()

        _periods = New ArrayList

    End Sub
#End Region
#Region "Protected Methods"
    Protected Overridable Function Add(ByVal value As Period) As Integer

        For Each dp As Period In _periods
            If dp.BeginDate.Date = value.EndDate.Date.AddDays(1) Then
                dp.BeginDate = value.BeginDate
                Return _periods.IndexOf(dp)
            End If
            If dp.EndDate.Date = value.BeginDate.Date.AddDays(-1) Then
                dp.EndDate = value.EndDate
                Return _periods.IndexOf(dp)
            End If
        Next dp

        _periods.Add(value)
        _periods.Sort()

        Return _periods.IndexOf(value)

    End Function
#End Region
#Region "Protected Properties"
    Protected Shared ReadOnly Property DefaultSeparator() As Char
        Get
            Return ","c
        End Get
    End Property

    Protected Shared ReadOnly Property InvariantCulture() As CultureInfo
        Get
            Return New CultureInfo(String.Empty)
        End Get
    End Property
#End Region
#Region "Public Methods"
    Public Overridable Function ContainPartOfPeriod(ByVal beginDate As DateTime, ByVal endDate As DateTime) As Boolean

        If ContainPeriod(beginDate, endDate) Then
            Return True
        End If

        For i As Integer = 0 To Periods.Count - 1
            If (beginDate <= Me(i).BeginDate AndAlso endDate >= Me(i).BeginDate) OrElse (beginDate <= Me(i).EndDate AndAlso endDate >= Me(i).EndDate) Then
                Return True
            End If
        Next i

        Return False

    End Function

    Public Function ContainPeriod(ByVal item As Object) As Boolean

        Dim dp As Period = TryCast(item, Period)

        If dp IsNot Nothing Then
            Return ContainPeriod(dp.BeginDate, dp.EndDate)
        End If

        Return False

    End Function

    Public Overridable Function ContainPeriod(ByVal beginDate As DateTime, ByVal endDate As DateTime) As Boolean

        For i As Integer = 0 To Periods.Count - 1
            If beginDate >= Me(i).BeginDate AndAlso endDate <= Me(i).EndDate Then
                Return True
            End If
        Next i

        Return False

    End Function

    Public Overridable Function GetCopy() As PeriodSet

        Dim result As New PeriodSet

        For Each period As Period In _periods
            result.Add(period)
        Next

        Return result

    End Function

    Public Sub IntersectsWith(ByVal beginDate As DateTime, endDate As DateTime)

        If beginDate.Date > endDate Then
            Return
        End If

        beginDate = Period.BeginOfDay(beginDate)
        endDate = Period.EndOfDay(endDate)

        For i As Integer = 0 To Periods.Count - 1
            If beginDate <= Me(i).BeginDate AndAlso endDate >= Me(i).EndDate Then
                Dim oldBegin As DateTime = Me(i).BeginDate
                Dim oldEnd As DateTime = Me(i).EndDate
                _periods.RemoveAt(i)
                IntersectsWith(beginDate, oldBegin.AddSeconds(-1))
                IntersectsWith(oldEnd.AddSeconds(1), endDate)
                Return
            End If
            i += 1
        Next

        For Each dp As Period In _periods
            If beginDate > dp.BeginDate AndAlso endDate < dp.EndDate Then
                Dim periodEnd As DateTime = dp.EndDate
                dp.EndDate = beginDate.AddSeconds(-1)
                IntersectsWith(endDate.AddSeconds(1), periodEnd)
                Return
            End If
        Next

        For i As Integer = 0 To Periods.Count - 1
            If beginDate = Me(i).BeginDate Then
                Me(i).BeginDate = endDate.AddSeconds(1)
                Return
            End If
            If endDate = Me(i).EndDate Then
                Me(i).EndDate = beginDate.AddSeconds(-1)
                Return
            End If
        Next

        For i As Integer = 0 To Periods.Count - 1
            If beginDate >= Me(i).BeginDate AndAlso beginDate <= Me(i).EndDate Then
                Dim oldEnd As DateTime = Me(i).EndDate
                Me(i).EndDate = beginDate.AddSeconds(-1)
                beginDate = oldEnd.AddSeconds(1)
            End If
            If endDate >= Me(i).BeginDate AndAlso endDate <= Me(i).EndDate Then
                Dim oldBegin As DateTime = Me(i).BeginDate
                Me(i).BeginDate = endDate.AddSeconds(1)
                endDate = oldBegin.AddSeconds(-1)
            End If
        Next

        Add(New Period(beginDate, endDate))

    End Sub

    Public Sub MergeWith(ByVal beginDate As DateTime, endDate As DateTime)

        If beginDate.Date > endDate.Date Then
            Return
        End If

        beginDate = Period.BeginOfDay(beginDate)
        endDate = Period.EndOfDay(endDate)

        If ContainPeriod(beginDate, endDate) Then
            Return
        End If

        For i As Integer = 0 To Periods.Count - 1
            If beginDate <= Me(i).BeginDate AndAlso endDate >= Me(i).EndDate Then
                _periods.RemoveAt(i)
                MergeWith(beginDate, endDate)
                Return
            End If
        Next i

        Dim beginPeriod As Period = Nothing
        Dim endPeriod As Period = Nothing

        For i As Integer = 0 To Periods.Count - 1
            If beginDate >= Me(i).BeginDate AndAlso beginDate <= Me(i).EndDate Then
                beginPeriod = Me(i)
            End If
            If endDate >= Me(i).BeginDate AndAlso endDate <= Me(i).EndDate Then
                endPeriod = Me(i)
            End If
        Next i

        If beginPeriod IsNot Nothing AndAlso endPeriod IsNot Nothing Then
            beginPeriod.EndDate = endPeriod.EndDate
            _periods.Remove(endPeriod)
            Return
        End If

        If beginPeriod IsNot Nothing Then
            beginPeriod.EndDate = endDate
            Return
        End If

        If endPeriod IsNot Nothing Then
            endPeriod.BeginDate = beginDate
            Return
        End If

        Add(New Period(beginDate, endDate))

    End Sub

    Public Shared Function Parse(ByVal str As String) As PeriodSet

        Return Parse(str, InvariantCulture, DefaultSeparator)

    End Function

    Public Shared Function Parse(ByVal str As String, ByVal format As IFormatProvider, ByVal separator As Char) As PeriodSet

        Dim result As New PeriodSet
        Dim periodSet() As String = str.Split(separator)

        For Each periodString As String In periodSet
            Dim dp As Period = Period.Parse(str, format)

            If dp IsNot Nothing Then
                result.Add(dp)
            End If
        Next

        Return result

    End Function

    Public Overrides Function ToString() As String

        Return ToString(InvariantCulture, DefaultSeparator)

    End Function

    Public Overridable Overloads Function ToString(ByVal format As IFormatProvider, ByVal separator As Char) As String

        Dim str As String = String.Empty

        For Each dp As Period In _periods
            str = String.Format("{0}{1}{2} ", str, dp.ToString(format), separator)
        Next

        If str.Length > 2 Then
            str = str.Remove(str.Length - 2)
        End If

        Return str

    End Function

    Public Overridable Overloads Function ToString(ByVal formatString As String, ByVal separator As Char) As String

        Dim str As String = String.Empty

        For Each dp As Period In _periods
            str = String.Format("{0}{1}{2}", str, dp.ToString(formatString), separator)
        Next

        If str.Length > 2 Then
            str = str.Remove(str.Length - 2)
        End If

        Return str

    End Function
#End Region
#Region "Public Property"
    Default Public Property Item(ByVal index As Integer) As Period
        Get
            Return TryCast(_periods(index), Period)
        End Get
        Set(value As Period)
            _periods(index) = value
        End Set
    End Property

    Public ReadOnly Property Periods() As ArrayList
        Get
            Return _periods
        End Get
    End Property
#End Region
End Class
