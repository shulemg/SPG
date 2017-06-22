Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text

<System.ComponentModel.DataObject()> _
Public Class CarriersBLL

    Private m_CarriersTableAdapter As CarriersTableAdapter = Nothing
    Public ReadOnly Property Adapter() As CarriersTableAdapter

        Get
            If m_CarriersTableAdapter Is Nothing Then
                m_CarriersTableAdapter = New CarriersTableAdapter()
                m_CarriersTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return m_CarriersTableAdapter
        End Get

    End Property


    Private Sub UpdateAuditTrail(ByVal ModifiedRecord As SPG.CarriersRow, ByVal originalRecord As Object())

        Dim builder As New StringBuilder(String.Empty)
        Dim recordFields As Integer = (ModifiedRecord.ItemArray.Length - 1)
        Dim i As Integer = 0
        Do While (i <= recordFields)
            Try
                If IsDBNull(originalRecord(i)) Then
                    If Not IsDBNull(ModifiedRecord.Item(i)) Then
                        builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, "NULL", ModifiedRecord.Item(i)))
                    End If
                ElseIf Information.IsDBNull(ModifiedRecord.Item(i)) Then
                    If Not Information.IsDBNull(originalRecord(i)) Then
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
            AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "Carriers", builder.ToString)
        End If

    End Sub

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function GetCarriers() As SPG.CarriersDataTable

        Return Adapter.GetCarriers()

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetCarrierIDAndNames() As SPG.CarriersDataTable

        Return Adapter.GetCarrierIDAndNames()

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetCarrierByID(ByVal carrierID As Integer) As SPG.CarriersDataTable

        Return Adapter.GetCarrierByID(carrierID)

    End Function

    Private Shared Sub SetCarrierFields(ByVal name As String, ByVal contactFirstName As String, ByVal contactLastName As String, ByVal address As String, ByVal city As String, ByVal state As String, ByVal postal As String, _
                                        ByVal phone As String, ByVal email As String, ByVal fax As String, ByVal note As String, ByVal carrier As SPG.CarriersRow)

        carrier.CarrierName = name
        If String.IsNullOrEmpty(contactFirstName) Then
            carrier.SetContactFirstNameNull()
        Else
            carrier.ContactFirstName = contactFirstName
        End If
        If String.IsNullOrEmpty(contactLastName) Then
            carrier.SetContactLastNameNull()
        Else
            carrier.ContactLastName = contactLastName
        End If
        If String.IsNullOrEmpty(address) Then
            carrier.SetAddressNull()
        Else
            carrier.Address = address
        End If
        If String.IsNullOrEmpty(city) Then
            carrier.SetCityNull()
        Else
            carrier.City = city
        End If
        If String.IsNullOrEmpty(state) Then
            carrier.SetStateNull()
        Else
            carrier.State = state
        End If
        If String.IsNullOrEmpty(postal) Then
            carrier.SetPostalNull()
        Else
            carrier.Postal = postal
        End If
        If String.IsNullOrEmpty(phone) Then
            carrier.SetPhoneNull()
        Else
            carrier.Phone = phone
        End If
        If String.IsNullOrEmpty(email) Then
            carrier.SetEmailNull()
        Else
            carrier.Email = email
        End If
        If String.IsNullOrEmpty(fax) Then
            carrier.SetFaxNull()
        Else
            carrier.Fax = fax
        End If
        If String.IsNullOrEmpty(note) Then
            carrier.SetNoteNull()
        Else
            carrier.Note = note
        End If

    End Sub

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateCarrier(ByVal id As Integer, ByVal name As String, ByVal contactFirstName As String, ByVal contactLastName As String, _
        ByVal address As String, ByVal city As String, ByVal state As String, ByVal postal As String, ByVal phone As String, ByVal email As String, _
        ByVal fax As String, ByVal note As String) As Boolean

        If String.IsNullOrEmpty(name) Then
            Throw New ApplicationException("You must provide a Carrier Name.")
        End If

        Dim carriers As SPG.CarriersDataTable = Adapter.GetCarrierByID(id)

        If carriers.Count = 0 Then
            'It is a new carriers
            Return Me.InsertCarrier(id, name, contactFirstName, contactLastName, address, city, state, postal, phone, email, fax, note)
        End If

        Dim carrier As SPG.CarriersRow = carriers(0)

        Dim originalRecord As Object() = Nothing
        originalRecord = carrier.ItemArray

        SetCarrierFields(name, contactFirstName, contactLastName, address, city, state, postal, phone, email, fax, note, carrier)

        If Not IsNothing(originalRecord) Then
            Me.UpdateAuditTrail(carrier, originalRecord)
        End If

        Dim rowsAffected As Integer = Adapter.Update(carrier)

        Return rowsAffected = 1

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function InsertCarrier(ByVal id As Integer, ByVal name As String, ByVal contactFirstName As String, ByVal contactLastName As String, ByVal address As String, _
            ByVal city As String, ByVal state As String, ByVal postal As String, ByVal phone As String, ByVal email As String, ByVal fax As String, _
            ByVal note As String) As Boolean

        Dim carriers As SPG.CarriersDataTable = New SPG.CarriersDataTable
        Dim carrier As SPG.CarriersRow = carriers.NewCarriersRow

        carrier.CarrierID = id
        SetCarrierFields(name, contactFirstName, contactLastName, address, city, state, postal, phone, email, fax, note, carrier)
        carrier.EnteredBy = My.Settings.UserName
        carrier.EnteredOn = Now

        carriers.AddCarriersRow(carrier)
        Dim rowsAffected As Integer = Adapter.Update(carriers)

        Return rowsAffected = 1

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, True)> _
    Public Function DeleteCarrier(ByVal id As Integer) As Boolean

        Dim carriers As SPG.CarriersDataTable = Adapter.GetCarrierByID(id)
        Dim rowsAffected As Integer = 0

        If carriers.Count = 1 Then
            Dim carrier As SPG.CarriersRow = CType(carriers.Rows(0), SPG.CarriersRow)
            rowsAffected = Adapter.Delete(id, carrier.ts)
        End If

        'Return true if precisely one row was deleted, otherwise return false.
        Return rowsAffected = 1

    End Function

    Public Function GetNewCarrierID() As Integer

        Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.UserConnectionString)
        Dim myCommand As New SqlClient.SqlCommand("dbo.spNewIDSafe", conn)
        Dim myNewID As New SqlClient.SqlParameter("@nRetVal", SqlDbType.Int)
        myCommand.CommandType = CommandType.StoredProcedure
        myNewID.Direction = ParameterDirection.Output
        myCommand.Parameters.AddWithValue("@cName", "tblCarriers")
        myCommand.Parameters.AddWithValue("@cPkField", "CarrierID")
        myCommand.Parameters.Add(myNewID)

        conn.Open()
        myCommand.ExecuteNonQuery()

        Return CType(myNewID.Value, Integer)

    End Function

End Class
