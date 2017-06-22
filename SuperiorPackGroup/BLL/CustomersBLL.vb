Imports System
Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text
Imports DXDAL.SPGData
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Metadata
Imports System.Collections.ObjectModel

<System.ComponentModel.DataObject()> _
Public Class CustomersBLL

    Private m_CustomersTableAdapter As CustomersTableAdapter = Nothing
    Public ReadOnly Property Adapter() As CustomersTableAdapter

        Get
            If m_CustomersTableAdapter IsNot Nothing Then
                Return m_CustomersTableAdapter
            End If

            m_CustomersTableAdapter = New CustomersTableAdapter()
            m_CustomersTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            Return m_CustomersTableAdapter
        End Get

    End Property

    Private changes As New List(Of Change)()

    Private Sub UpdateAuditTrail()

        Dim builder As New StringBuilder(String.Empty)

        For Each update As Change In changes
            builder.Append(String.Format("{0}:{1}({2}); ", update.PropertyName, update.PrevValue, update.NewValue))
        Next
        
        If (builder.Length > 2) Then
            builder.Length = (builder.Length - 2)
            AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(changes(0).NewValue, Integer), "Customers", builder.ToString)
        End If

        changes.Clear()

    End Sub

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetCustomerNameAndIDS(ByVal inactive As Boolean) As SPG.CustomersDataTable

        If inactive Then
            Return Adapter.GetCustomerNameAndIDS(Nothing)
        End If
        'will return only those that are active
        Return Adapter.GetCustomerNameAndIDS(inactive)

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetCustomerByID(ByVal customerID As Integer) As SPG.CustomersDataTable

        Return Adapter.GetCustomerByID(customerID)

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function GetCustomers() As SPG.CustomersDataTable

        Return Adapter.GetCustomers()

    End Function

    Public Shared Function GetRelatedCustomerIDs(ByVal mainCustomer As Customers) As Collection(Of Integer)

        Dim customerIDS As Collection(Of Integer) = New Collection(Of Integer)

        For Each relatedCustomer As RelatedCustomer In mainCustomer.RelatedCustomers
            customerIDS.Add(relatedCustomer.RelatedCustomer.CustomerID)
        Next

        Return customerIDS

    End Function

    Public Shared Function GetCustomer(ByVal customerID As Integer, ByVal DXSession As Session) As Customers

        Try
            If DXSession Is Nothing Then
                DXSession = Session.DefaultSession
            End If
            Return DXSession.GetObjectByKey(Of Customers)(customerID)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Sub SetField(propertyName As String, oldValue As Object, newValue As Object, ByVal customer As Customers)

        If (oldValue IsNot Nothing Or newValue IsNot Nothing) AndAlso
            ((oldValue IsNot Nothing And newValue Is Nothing) OrElse (newValue IsNot Nothing And oldValue Is Nothing) OrElse oldValue.ToString <> newValue.ToString) Then
            customer.SetMemberValue(propertyName, newValue)
            Dim change As New Change() With {.PropertyName = propertyName, .PrevValue = If(oldValue Is Nothing, "<NULL>", oldValue.ToString()), .NewValue = If(newValue Is Nothing, "<NULL>", newValue.ToString())}
            changes.Add(change)
        End If

    End Sub

    Private Sub SetCustomerFields(ByVal customerName As String, ByVal customerContact As String, ByVal customerPhone As String, ByVal customerEmail As String, ByVal customerFax As String,
                                         ByVal customerNote As String, ByVal address As String, ByVal city As String, ByVal state As String, ByVal postal As String, ByVal inactive As Nullable(Of Boolean),
                                         ByVal lpnPrefix As String, ByVal firstLPNNumber As Integer?, ByVal lastLPNNumber As Integer?, ByVal plantCode As String, ByVal expirationDateFormat As String, ByVal lotCodeFormat As Integer?,
                                         ByVal customer As Customers, ByVal dxSession As Session)

        SetField(Customers.Fields.CustomerName.PropertyName, customer.CustomerName, customerName, customer)
        SetField(Customers.Fields.CustomerContact.PropertyName, customer.CustomerContact, If(String.IsNullOrEmpty(customerContact), Nothing, customerContact), customer)
        SetField(Customers.Fields.CustomerPhone.PropertyName, customer.CustomerPhone, If(String.IsNullOrEmpty(customerPhone), Nothing, customerPhone), customer)
        SetField(Customers.Fields.CustomerEmail.PropertyName, customer.CustomerEmail, If(String.IsNullOrEmpty(customerEmail), Nothing, customerEmail), customer)
        SetField(Customers.Fields.CustomerFax.PropertyName, customer.CustomerFax, If(String.IsNullOrEmpty(customerFax), Nothing, customerFax), customer)
        SetField(Customers.Fields.CustomerNote.PropertyName, customer.CustomerNote, If(String.IsNullOrEmpty(customerNote), Nothing, customerNote), customer)
        SetField(Customers.Fields.Address.PropertyName, customer.Address, If(String.IsNullOrEmpty(address), Nothing, address), customer)
        SetField(Customers.Fields.City.PropertyName, customer.City, If(String.IsNullOrEmpty(city), Nothing, city), customer)
        SetField(Customers.Fields.State.PropertyName, customer.State, If(String.IsNullOrEmpty(state), Nothing, state), customer)
        SetField(Customers.Fields.ZipCode.PropertyName, customer.ZipCode, If(String.IsNullOrEmpty(postal), Nothing, postal), customer)
        SetField(Customers.Fields.Inactive.PropertyName, customer.Inactive, If(inactive, False), customer)
        SetField(Customers.Fields.LPNPrefix.PropertyName, customer.LPNPrefix, If(String.IsNullOrEmpty(lpnPrefix), Nothing, lpnPrefix), customer)
        SetField(Customers.Fields.FirstLPNNumber.PropertyName, customer.FirstLPNNumber, If(firstLPNNumber, Nothing), customer)
        SetField(Customers.Fields.LastLPNNumber.PropertyName, customer.LastLPNNumber, If(lastLPNNumber, Nothing), customer)
        SetField(Customers.Fields.PlantCode.PropertyName, customer.PlantCode, If(String.IsNullOrEmpty(plantCode), Nothing, plantCode), customer)
        SetField(Customers.Fields.ExpirationDateFormat.PropertyName, customer.ExpirationDateFormat, If(String.IsNullOrEmpty(expirationDateFormat), Nothing, expirationDateFormat), customer)
        SetField(Customers.Fields.DefaultLotCodeFormat.PropertyName, customer.DefaultLotCodeFormat, If(lotCodeFormat.HasValue, dxSession.GetObjectByKey(Of LotCodeFormats)(lotCodeFormat.Value), Nothing), customer)

    End Sub

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, True)>
    Public Function UpdateCustomer(ByVal customerID As Integer, ByVal customerName As String, ByVal customerContact As String, ByVal customerPhone As String, ByVal customerEmail As String, ByVal customerFax As String,
                                   ByVal customerNote As String, ByVal address As String, ByVal city As String, ByVal state As String, ByVal postal As String, ByVal inactive As Nullable(Of Boolean),
                                   ByVal lpnPrefix As String, ByVal firstLPNNumber As Integer?, ByVal lastLPNNumber As Integer?, ByVal plantCode As String, ByVal expirationDateFormat As String, ByVal lotCodeFormat As Integer?,
                                   ByVal DXSsession As Session) As Boolean

        If String.IsNullOrEmpty(customerName) Then
            Throw New ApplicationException("You must provide a Customer Name.")
        End If

        If firstLPNNumber.HasValue Then
            If lastLPNNumber.HasValue = False Then
                Throw New ApplicationException("You must provide a last LPN number.")
            ElseIf lastLPNNumber.Value <= firstLPNNumber.Value Then
                Throw New ApplicationException("The last LPN number must be higher than the first LPN number.")
            End If
        End If

        If String.IsNullOrEmpty(plantCode) = False AndAlso plantCode.Length > 4 Then
            Throw New ApplicationException("Plant code should be 4 characters long.")
        End If

        Dim change As Change
        Dim customer As Customers = GetCustomer(customerID, DXSsession)

        If customer Is Nothing Then
            'It is a new Customer
            change = New Change() With {.PropertyName = Customers.Fields.CustomerID.PropertyName, .PrevValue = "<NULL>", .NewValue = customerID.ToString}
            changes.Add(change)
            Return InsertCustomer(customerID, customerName, customerContact, customerPhone, customerEmail, customerFax, customerNote, address, city, state, postal, inactive, lpnPrefix, firstLPNNumber, lastLPNNumber,
                                  plantCode, expirationDateFormat, lotCodeFormat, DXSsession)
        End If

        change = New Change() With {.PropertyName = Customers.Fields.CustomerID.PropertyName, .PrevValue = customer.CustomerID.ToString, .NewValue = customer.CustomerID.ToString}
        changes.Add(change)
        SetCustomerFields(customerName, customerContact, customerPhone, customerEmail, customerFax, customerNote, address, city, state, postal, inactive, lpnPrefix, firstLPNNumber, lastLPNNumber, plantCode,
                          expirationDateFormat, lotCodeFormat, customer, DXSsession)

        Try
            customer.Save()
        Catch ex As Exception
            Return False
        End Try

        UpdateAuditTrail()
        EndedEdit(customer.CustomerID)

        Return True

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, True)>
    Public Function InsertCustomer(ByVal customerID As Integer, ByVal customerName As String, ByVal customerContact As String, ByVal customerPhone As String, ByVal customerEmail As String, ByVal customerFax As String, ByVal customerNote As String,
                                   ByVal address As String, ByVal city As String, ByVal state As String, ByVal postal As String, ByVal inactive As Nullable(Of Boolean), ByVal lpnPrefix As String, ByVal firstLPNNumber As Integer?,
                                   ByVal lastLPNNumber As Integer?, ByVal plantCode As String, ByVal expirationDateFormat As String, ByVal lotCodeFormat As Integer?, ByVal dxSession As Session) As Boolean

        Dim customer As Customers = New Customers(dxSession) With {.CustomerID = customerID}
        SetCustomerFields(customerName, customerContact, customerPhone, customerEmail, customerFax, customerNote, address, city, state, postal, inactive, lpnPrefix, firstLPNNumber, lastLPNNumber, plantCode,
                          expirationDateFormat, lotCodeFormat, customer, dxSession)
        customer.strEnteredBy = My.Settings.UserName
        customer.dtmEnteredOn = Now

        Try
            customer.Save()
        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

    Public Function GetNewCustomerID() As Integer

        Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.UserConnectionString)
        Dim myCommand As New SqlClient.SqlCommand("dbo.spNewIDSafe", conn)
        Dim myNewID As New SqlClient.SqlParameter("@nRetVal", SqlDbType.Int)
        myCommand.CommandType = CommandType.StoredProcedure
        myNewID.Direction = ParameterDirection.Output
        myCommand.Parameters.AddWithValue("@cName", "tblCustomers")
        myCommand.Parameters.AddWithValue("@cPkField", "CustomerID")
        myCommand.Parameters.Add(myNewID)

        conn.Open()
        myCommand.ExecuteNonQuery()

        Return CType(myNewID.Value, Integer)

    End Function

    Public Function DeleteCustomer(ByVal customerid As Integer, ByVal DXSession As Session) As Boolean

        Dim customers As SPG.CustomersDataTable = Adapter.GetCustomerByID(customerid)
        Dim rowsAffected As Integer = 0

        If customers.Count = 1 Then

            If New ItemsBLL().GetItemsByCustomerID(customerid).Count <> 0 OrElse New ProductionBLL().GetProductionByCustomerID(customerid).Count <> 0 _
                    OrElse New InventoryBLL().GetInventoryView(Nothing, Nothing, customerid, Nothing, Nothing).Count <> 0 Then
                If MessageBox.Show("You can't delete this customer because there are items or production/inventory assigned to him. Do you want ot mark him as inactive?", "Delete Customer", MessageBoxButtons.YesNo, _
                                MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Adapter.InactivateCustomer(customerid)
                    Return True
                Else
                    Return True
                End If
            End If
            RelatedCustomerBLL.DeleteRelatedCustomers(GetCustomer(customerid, DXSession))
            rowsAffected = Adapter.Delete(customerid, customers(0).ts)
        End If

        Return Convert.ToBoolean(rowsAffected)

    End Function

    Public Sub EndedEdit(ByVal customerID As Integer)

        Dim customer As Customers = Session.DefaultSession.GetObjectByKey(Of Customers)(customerID, True)
        customer.Editing = False
        customer.Save()

    End Sub

    Public Function AllowEdit(ByVal customerID As Integer) As Boolean

        Dim customer As Customers = Session.DefaultSession.GetObjectByKey(Of Customers)(customerID, True)
        If customer.Editing Then
            Return False
        Else
            customer.Editing = True
            customer.Save()
            Return True
        End If
    End Function

    Public Shared Function GetExpirationDateFormat(ByVal customerID As Integer) As String

        Dim customer As Customers = Session.DefaultSession.GetObjectByKey(Of Customers)(customerID)
        Return customer.ExpirationDateFormat

    End Function

    Public Shared Function GetLPNPrefix(ByVal customerID As Integer) As String

        Dim customer As Customers = Session.DefaultSession.GetObjectByKey(Of Customers)(customerID)
        Return customer.LPNPrefix

    End Function

End Class
