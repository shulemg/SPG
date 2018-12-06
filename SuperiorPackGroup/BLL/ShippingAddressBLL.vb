Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text

<ComponentModel.DataObject()> _
Public Class ShippingAddressBLL

    Private m_ShippingAddressesTableAdapter As ShippingAddressesTableAdapter = Nothing
    Public ReadOnly Property Adapter() As ShippingAddressesTableAdapter

        Get
            If m_ShippingAddressesTableAdapter Is Nothing Then
                m_ShippingAddressesTableAdapter = New ShippingAddressesTableAdapter()
                m_ShippingAddressesTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return m_ShippingAddressesTableAdapter
        End Get

    End Property

    Private Sub UpdateAuditTrail(ByVal ModifiedRecord As SPG.ShippingAddressesRow, ByVal originalRecord As Object())

        Dim builder As New StringBuilder(String.Empty)
        Dim recordFields As Integer = (ModifiedRecord.ItemArray.Length - 1)
        Dim i As Integer = 0
        Do While (i <= recordFields)
            Try
                If IsDBNull(originalRecord(i)) Then
                    If Not IsDBNull(ModifiedRecord.Item(i)) Then
                        builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, "NULL", ModifiedRecord.Item(i)))
                    End If
                ElseIf IsDBNull(ModifiedRecord.Item(i)) Then
                    If Not IsDBNull(originalRecord(i)) Then
                        builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), "NULL"))
                    End If
                ElseIf ModifiedRecord.Item(i) IsNot originalRecord(i) Then
                    builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), ModifiedRecord.Item(i)))
                End If
            Catch
            End Try
            i += 1
        Loop
        If (builder.Length > 2) Then
            builder.Length = (builder.Length - 2)
            AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "ShippingAddress", builder.ToString)
        End If

    End Sub

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetAddressNameAndIDS() As SPG.ShippingAddressesDataTable

        Return Adapter.GetAddressNameAndIDs()

    End Function

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetAddressInfoByID(ByVal addressID As Integer) As SPG.ShippingAddressesDataTable

        Return Adapter.GetAddressInfoByID(addressID)

    End Function

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetAddressByID(ByVal addressID As Integer) As SPG.ShippingAddressesDataTable

        Return Adapter.GetAddressByID(addressID)

    End Function

    Private Shared Sub SetAddressFields(ByVal shippingName As String, ByVal contactFirstName As String, ByVal contactLastName As String, ByVal shippingAddress As String, ByVal shippingCity As String, _
                                        ByVal shippingState As String, ByVal shippingPostal As String, ByVal shippingPhone As String, ByVal shippingEmail As String, ByVal shippingFax As String, ByVal shippingNote As String, _
                                        ByVal address As SPG.ShippingAddressesRow)

        address.ShippingName = shippingName
        If String.IsNullOrEmpty(contactFirstName) Then
            address.SetContactFirstNameNull()
        Else
            address.ContactFirstName = contactFirstName
        End If
        If String.IsNullOrEmpty(contactLastName) Then
            address.SetContactLastNameNull()
        Else
            address.ContactLastName = contactLastName
        End If
        address.ShippingAddress = shippingAddress
        address.ShippingCity = shippingCity
        address.ShippingState = shippingState
        If String.IsNullOrEmpty(shippingPostal) Then
            address.SetShippingPostalNull()
        Else
            address.ShippingPostal = shippingPostal
        End If
        If String.IsNullOrEmpty(shippingPhone) Then
            address.SetShippingPhoneNull()
        Else
            address.ShippingPhone = shippingPhone
        End If
        If String.IsNullOrEmpty(shippingEmail) Then
            address.SetShippingEmailNull()
        Else
            address.ShippingEmail = shippingEmail
        End If
        If String.IsNullOrEmpty(shippingFax) Then
            address.SetShippingFaxNull()
        Else
            address.ShippingFax = shippingFax
        End If
        If String.IsNullOrEmpty(shippingNote) Then
            address.SetShippingNoteNull()
        Else
            address.ShippingNote = shippingNote
        End If

    End Sub

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateAddress(ByVal addressID As Integer, ByVal shippingName As String, ByVal contactFirstName As String, ByVal contactLastName As String, _
        ByVal shippingAddress As String, ByVal shippingCity As String, ByVal shippingState As String, ByVal shippingPostal As String, _
        ByVal shippingPhone As String, ByVal shippingEmail As String, ByVal shippingFax As String, ByVal shippingNote As String) As Boolean

        Dim str As StringBuilder = New StringBuilder(String.Empty)
        If String.IsNullOrEmpty(shippingName) Then
            str.Append("Shipping Name, ")
        End If

        If String.IsNullOrEmpty(shippingAddress) Then
            str.Append("Shipping Address, ")
        End If

        If String.IsNullOrEmpty(shippingCity) Then
            str.Append("Shipping City, ")
        End If

        If String.IsNullOrEmpty(shippingState) Then
            str.Append("Shipping State, ")
        End If

        If str.Length > 0 Then
            Throw New ApplicationException(String.Format("You must provide a {0}.", str.ToString.Substring(0, (str.Length - 2))))
        End If

        Dim addresses As SPG.ShippingAddressesDataTable = Adapter.GetAddressByID(addressID)

        If addresses.Count = 0 Then
            'It is a new Shipping Address 
            Return Me.InsertAddress(addressID, shippingName, contactFirstName, contactLastName, shippingAddress, shippingCity, shippingState, shippingPostal, _
                    shippingPhone, shippingEmail, shippingFax, shippingNote)
        End If

        Dim address As SPG.ShippingAddressesRow = addresses(0)

        Dim originalRecord As Object() = Nothing
        originalRecord = address.ItemArray

        SetAddressFields(shippingName, contactFirstName, contactLastName, shippingAddress, shippingCity, shippingState, shippingPostal, shippingPhone, shippingEmail, shippingFax, shippingNote, address)

        If Not IsNothing(originalRecord) Then
            Me.UpdateAuditTrail(address, originalRecord)
        End If

        Dim rowsAffected As Integer = Adapter.Update(address)

        Return rowsAffected = 1

    End Function

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function InsertAddress(ByVal addressID As Integer, ByVal shippingName As String, ByVal contactFirstName As String, ByVal contactLastName As String, _
            ByVal shippingAddress As String, ByVal shippingCity As String, ByVal shippingState As String, ByVal shippingPostal As String, _
            ByVal shippingPhone As String, ByVal shippingEmail As String, ByVal shippingFax As String, ByVal shippingNote As String) As Boolean

        Dim addresses As SPG.ShippingAddressesDataTable = New SPG.ShippingAddressesDataTable
        Dim address As SPG.ShippingAddressesRow = addresses.NewShippingAddressesRow()

        address.AddressID = addressID
        SetAddressFields(shippingName, contactFirstName, contactLastName, shippingAddress, shippingCity, shippingState, shippingPostal, shippingPhone, shippingEmail, shippingFax, shippingNote, address)
        address.strEnteredBy = My.Settings.UserName
        address.dtmEnteredOn = Now

        addresses.AddShippingAddressesRow(address)
        Dim rowsAffected As Integer = Adapter.Update(addresses)

        Return rowsAffected = 1

    End Function

    Public Function GetNewAddressID() As Integer

        Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.UserConnectionString)
        Dim myCommand As New SqlClient.SqlCommand("dbo.spNewIDSafe", conn)
        Dim myNewID As New SqlClient.SqlParameter("@nRetVal", SqlDbType.Int)
        myCommand.CommandType = CommandType.StoredProcedure
        myNewID.Direction = ParameterDirection.Output
        myCommand.Parameters.AddWithValue("@cName", "tblShippingAddresses")
        myCommand.Parameters.AddWithValue("@cPkField", "AddressID")
        myCommand.Parameters.Add(myNewID)

        conn.Open()
        myCommand.ExecuteNonQuery()

        Return CType(myNewID.Value, Integer)

    End Function

End Class
