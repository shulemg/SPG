Public Class ItemTransaction

    ''' <summary>
    ''' Initializes a new instance of the ItemTransaction class.
    ''' </summary>
    ''' <param name="transactionDate"></param>
    ''' <param name="transactionItemCode"></param>
    ''' <param name="transactionItemDescription"></param>
    ''' <param name="transactionType"></param>
    ''' <param name="quantity"></param>
    Public Sub New(ByVal transactionDate As Date, ByVal transactionItemCode As String, ByVal transactionItemDescription As String, ByVal transactionType As ItemTransactionType, ByVal quantity As Double)

        _transactionDate = transactionDate
        _transactionItemCode = transactionItemCode
        _transactionItemDescription = transactionItemDescription
        _transactionType = transactionType
        _quantity = quantity

    End Sub

    Public Sub New()

    End Sub


    Private _transactionDate As Date
    Public Property TransactionDate() As date
        Get
            Return _transactionDate
        End Get
        Set(ByVal Value As date)
            _transactionDate = Value
        End Set
    End Property

    Private _transactionItemCode As String
    Public Property TransactionItemCode() As String
        Get
            Return _transactionItemCode
        End Get
        Set(ByVal Value As String)
            _transactionItemCode = Value
        End Set
    End Property

    Private _transactionItemDescription As String
    Public Property TransactionItemDescription() As String
        Get
            Return _transactionItemDescription
        End Get
        Set(ByVal Value As String)
            _transactionItemDescription = Value
        End Set
    End Property

    Private _transactionType As ItemTransactionType
    Public Property TransactionType() As ItemTransactionType
        Get
            Return _transactionType
        End Get
        Set(ByVal Value As ItemTransactionType)
            _transactionType = Value
        End Set
    End Property

    Private _quantity As Double
    Public Property Quantity() As Double
        Get
            Return _quantity
        End Get
        Set(ByVal Value As Double)
            _quantity = Value
        End Set
    End Property

End Class

