Public Class Period
    Implements IComparable

#Region "Fields"
    Private _beginDate As DateTime
    Private _endDate As DateTime
#End Region
#Region "Constructors"
    ''' <summary>
    ''' Initializes a new instance of the Period class.
    ''' </summary>
    ''' <param name="beginDate"></param>
    ''' <param name="endDate"></param>
    Public Sub New(ByVal beginDate As DateTime, ByVal endDate As DateTime)
        _beginDate = beginDate.Date
        _endDate = EndOfDay(endDate)
    End Sub

    ''' <summary>
    ''' Initializes a new instance of the Period class.
    ''' </summary>
    ''' <param name="beginAndEndDate"></param>
    Public Sub New(ByVal beginAndEndDate As DateTime)

        Me.New(beginAndEndDate, beginAndEndDate)

    End Sub
    Private Sub New()

    End Sub
#End Region
#Region "Public Methods"
    Public Shared Function BeginOfDay(ByVal beginDate As DateTime) As DateTime

        Return beginDate.Date

    End Function

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo

        Dim dp As Period = TryCast(obj, Period)

        If dp Is Nothing Then
            Throw New ArgumentException("Object is not a Date Period.")
        Else
            Return BeginDate.CompareTo(dp.BeginDate)
        End If

    End Function

    Public Shared Function EndOfDay(ByVal endDate As DateTime) As DateTime

        Return endDate.Date.AddDays(1).AddSeconds(-1)

    End Function

    Public Shared Function Parse(ByVal str As String, ByVal format As IFormatProvider) As Period

        str = str.Trim

        If str.Contains(" - ") Then
            Dim success As Boolean
            Dim sides() As String = str.Split(New String() {" - "}, StringSplitOptions.RemoveEmptyEntries)
            Dim firstDate, secondDate As DateTime

            If sides.Length > 0 Then
                success = True AndAlso DateTime.TryParse(sides(0).Trim, format, Globalization.DateTimeStyles.None, firstDate)
            Else
                success = True
            End If

            If sides.Length > 1 Then
                success = success AndAlso DateTime.TryParse(sides(1).Trim, format, Globalization.DateTimeStyles.None, secondDate)
            End If

            If success Then
                If firstDate <= secondDate Then
                    Return New Period(firstDate, secondDate)
                End If
            End If
        Else
            Dim onlyDate As DateTime
            If DateTime.TryParse(str, format, Globalization.DateTimeStyles.None, onlyDate) Then
                Return New Period(onlyDate)
            End If
        End If

        Return Nothing

    End Function

    Public Overridable Overloads Function ToString(ByVal format As IFormatProvider) As String

        If format Is Nothing Then
            Return ToString()
        End If

        If BeginDate.Date = EndDate.Date Then
            Return BeginDate.ToString(format)
        End If

        Return String.Format("{0} - {1}", BeginDate.ToString(format), EndDate.ToString(format))

    End Function

    Public Overridable Overloads Function ToString(ByVal formatString As String) As String

        If String.IsNullOrEmpty(formatString) Then
            Return ToString()
        End If

        If BeginDate.Date = EndDate.Date Then
            Return BeginDate.ToString(formatString)
        End If

        Return String.Format("{0} - {1}", BeginDate.ToString(formatString), EndDate.ToString(formatString))

    End Function

    Public Overrides Function ToString() As String

        If BeginDate.Date = EndDate.Date Then
            Return BeginDate.ToString("d")
        End If

        Return String.Format("{0:d} - {1:d}", BeginDate, EndDate)

    End Function
#End Region
#Region "Public Properties"
    Public Property BeginDate As DateTime
        Get
            Return _beginDate
        End Get
        Set(value As DateTime)
            If BeginDate <> value Then
                _beginDate = value.Date
            End If
        End Set
    End Property

    Public Property EndDate As DateTime
        Get
            Return _endDate
        End Get
        Set(value As DateTime)
            If EndDate <> value Then
                _endDate = EndOfDay(value)
            End If
        End Set
    End Property
#End Region

End Class
