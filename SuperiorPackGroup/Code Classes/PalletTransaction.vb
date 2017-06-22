Public Class PalletTransaction

    ''' <summary>
    ''' Initializes a new instance of the PalletTransaction class.
    ''' </summary>
    ''' <param name="transactionDate"></param>
    ''' <param name="customerID"></param>
    ''' <param name="customerName"></param>
    ''' <param name="vendorName"></param>
    ''' <param name="shippingDestinationName"></param>
    ''' <param name="transactionBOL"></param>
    ''' <param name="received"></param>
    ''' <param name="shipped"></param>
    Public Sub New(ByVal transactionDate As Date, ByVal customerID As Integer, ByVal customerName As String, ByVal vendorName As String, ByVal shippingDestinationName As String, ByVal transactionBOL As String, _
                   ByVal received As Double, ByVal shipped As Double)

        m_TransactionDate = transactionDate
        m_CustomerID = customerID
        m_CustomerName = customerName
        m_VendorName = vendorName
        m_ShippingDestinationName = shippingDestinationName
        m_TransactionBOL = transactionBOL
        m_Received = received
        m_Shipped = shipped

    End Sub

    Public Sub New()

    End Sub

    Private m_TransactionDate As Date
    Public Property TransactionDate() As Date
        Get
            Return m_TransactionDate
        End Get
        Set(ByVal Value As Date)
            m_TransactionDate = Value
        End Set
    End Property

    Private m_CustomerID As Integer
    Public Property CustomerID() As Integer
        Get
            Return m_CustomerID
        End Get
        Set(ByVal Value As Integer)
            m_CustomerID = Value
        End Set
    End Property

    Private m_CustomerName As String
    Public Property CustomerName() As String
        Get
            Return m_CustomerName
        End Get
        Set(ByVal Value As String)
            m_CustomerName = Value
        End Set
    End Property

    Private m_VendorName As String
    Public Property VendorName() As String
        Get
            Return m_VendorName
        End Get
        Set(ByVal Value As String)
            m_VendorName = Value
        End Set
    End Property

    Private m_ShippingDestinationName As String
    Public Property ShippingDestinationName() As String
        Get
            Return m_ShippingDestinationName
        End Get
        Set(ByVal Value As String)
            m_ShippingDestinationName = Value
        End Set
    End Property

    Private m_TransactionBOL As String
    Public Property TransactionBOL() As String
        Get
            Return m_TransactionBOL
        End Get
        Set(ByVal Value As String)
            m_TransactionBOL = Value
        End Set
    End Property

    Private m_Received As Double?
    Public Property Received() As Double?
        Get
            Return m_Received
        End Get
        Set(ByVal Value As Double?)
            m_Received = Value
        End Set
    End Property

    Private m_Shipped As Double?
    Public Property Shipped() As Double?
        Get
            Return m_Shipped
        End Get
        Set(ByVal Value As Double?)
            m_Shipped = Value
        End Set
    End Property

End Class
