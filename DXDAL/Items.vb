Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering

Namespace SPGData
    <Persistent("tblItems")> _
    Public Class Items
        Inherits XPLiteObject
        Dim fItemID As Integer
        <Key()> _
        Public Property ItemID() As Integer
            Get
                Return fItemID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ItemID", fItemID, value)
            End Set
        End Property
        Dim fItemCode As String
        <Size(50)> _
        Public Property ItemCode() As String
            Get
                Return fItemCode
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ItemCode", fItemCode, value)
            End Set
        End Property
        Dim fItemDescription As String
        <Size(1073741823)> _
        Public Property ItemDescription() As String
            Get
                Return fItemDescription
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ItemDescription", fItemDescription, value)
            End Set
        End Property
        Dim fItemType As String
        <Size(50)> _
        Public Property ItemType() As String
            Get
                Return fItemType
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ItemType", fItemType, value)
            End Set
        End Property
        Dim fItemCustomerID As Customers
        Public Property ItemCustomerID() As Customers
            Get
                Return fItemCustomerID
            End Get
            Set(ByVal value As Customers)
                SetPropertyValue(Of Customers)("ItemCustomerID", fItemCustomerID, value)
            End Set
        End Property
        Dim fItemDefaultMachine As MachineLine
        Public Property ItemDefaultMachine() As MachineLine
            Get
                Return fItemDefaultMachine
            End Get
            Set(ByVal value As MachineLine)
                SetPropertyValue(Of MachineLine)("ItemDefaultMachine", fItemDefaultMachine, value)
            End Set
        End Property
        Dim fItemProdStandard As Double?
        Public Property ItemProdStandard() As Double?
            Get
                Return fItemProdStandard
            End Get
            Set(ByVal value As Double?)
                SetPropertyValue(Of Double?)("ItemProdStandard", fItemProdStandard, value)
            End Set
        End Property
        Dim fItemPicture() As Byte
        Public Property ItemPicture() As Byte()
            Get
                Return fItemPicture
            End Get
            Set(ByVal value As Byte())
                SetPropertyValue(Of Byte())("ItemPicture", fItemPicture, value)
            End Set
        End Property
        Dim fdblPrice As Double
        Public Property dblPrice() As Double
            Get
                Return fdblPrice
            End Get
            Set(ByVal value As Double)
                SetPropertyValue(Of Double)("dblPrice", fdblPrice, value)
            End Set
        End Property
        Dim fsngRebate As Single
        Public Property sngRebate() As Single
            Get
                Return fsngRebate
            End Get
            Set(ByVal value As Single)
                SetPropertyValue(Of Single)("sngRebate", fsngRebate, value)
            End Set
        End Property
        Dim fstrUnitOfMeasure As String
        <Size(50)> _
        Public Property strUnitOfMeasure() As String
            Get
                Return fstrUnitOfMeasure
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("strUnitOfMeasure", fstrUnitOfMeasure, value)
            End Set
        End Property
        Dim fintQtyPerUnit As Double
        Public Property intQtyPerUnit() As Double
            Get
                Return fintQtyPerUnit
            End Get
            Set(ByVal value As Double)
                SetPropertyValue(Of Double)("intQtyPerUnit", fintQtyPerUnit, value)
            End Set
        End Property
        Dim fstrEnteredBy As String
        <Size(50)> _
        Public Property strEnteredBy() As String
            Get
                Return fstrEnteredBy
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("strEnteredBy", fstrEnteredBy, value)
            End Set
        End Property
        Dim fdtmEnteredOn As DateTime
        Public Property dtmEnteredOn() As DateTime
            Get
                Return fdtmEnteredOn
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("dtmEnteredOn", fdtmEnteredOn, value)
            End Set
        End Property
        Dim fdblFreight As Double
        Public Property dblFreight() As Double
            Get
                Return fdblFreight
            End Get
            Set(ByVal value As Double)
                SetPropertyValue(Of Double)("dblFreight", fdblFreight, value)
            End Set
        End Property
        Dim fdblFilm As Double
        Public Property dblFilm() As Double
            Get
                Return fdblFilm
            End Get
            Set(ByVal value As Double)
                SetPropertyValue(Of Double)("dblFilm", fdblFilm, value)
            End Set
        End Property
        Dim fdblBoxes As Double
        Public Property dblBoxes() As Double
            Get
                Return fdblBoxes
            End Get
            Set(ByVal value As Double)
                SetPropertyValue(Of Double)("dblBoxes", fdblBoxes, value)
            End Set
        End Property
        Dim fdblStretchWrap As Double
        Public Property dblStretchWrap() As Double
            Get
                Return fdblStretchWrap
            End Get
            Set(ByVal value As Double)
                SetPropertyValue(Of Double)("dblStretchWrap", fdblStretchWrap, value)
            End Set
        End Property
        Dim fdblPallets As Double
        Public Property dblPallets() As Double
            Get
                Return fdblPallets
            End Get
            Set(ByVal value As Double)
                SetPropertyValue(Of Double)("dblPallets", fdblPallets, value)
            End Set
        End Property
        Dim fdblOther1 As Double
        Public Property dblOther1() As Double
            Get
                Return fdblOther1
            End Get
            Set(ByVal value As Double)
                SetPropertyValue(Of Double)("dblOther1", fdblOther1, value)
            End Set
        End Property
        Dim fdblOther2 As Double
        Public Property dblOther2() As Double
            Get
                Return fdblOther2
            End Get
            Set(ByVal value As Double)
                SetPropertyValue(Of Double)("dblOther2", fdblOther2, value)
            End Set
        End Property
        Dim fdblOther3 As Double
        Public Property dblOther3() As Double
            Get
                Return fdblOther3
            End Get
            Set(ByVal value As Double)
                SetPropertyValue(Of Double)("dblOther3", fdblOther3, value)
            End Set
        End Property
        Dim fdblOther4 As Double
        Public Property dblOther4() As Double
            Get
                Return fdblOther4
            End Get
            Set(ByVal value As Double)
                SetPropertyValue(Of Double)("dblOther4", fdblOther4, value)
            End Set
        End Property
        Dim fdblOther5 As Double
        Public Property dblOther5() As Double
            Get
                Return fdblOther5
            End Get
            Set(ByVal value As Double)
                SetPropertyValue(Of Double)("dblOther5", fdblOther5, value)
            End Set
        End Property
        Dim fintUnitsPerCase As Double
        Public Property intUnitsPerCase() As Double
            Get
                Return fintUnitsPerCase
            End Get
            Set(ByVal value As Double)
                SetPropertyValue(Of Double)("intUnitsPerCase", fintUnitsPerCase, value)
            End Set
        End Property
        Dim fintUnitsPerPallet As Integer
        Public Property intUnitsPerPallet() As Integer
            Get
                Return fintUnitsPerPallet
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("intUnitsPerPallet", fintUnitsPerPallet, value)
            End Set
        End Property
        Dim fintCasesPerPallet As Integer
        Public Property intCasesPerPallet() As Integer
            Get
                Return fintCasesPerPallet
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("intCasesPerPallet", fintCasesPerPallet, value)
            End Set
        End Property
        Dim fsngQuantityOnHand As Single
        Public Property sngQuantityOnHand() As Single
            Get
                Return fsngQuantityOnHand
            End Get
            Set(ByVal value As Single)
                SetPropertyValue(Of Single)("sngQuantityOnHand", fsngQuantityOnHand, value)
            End Set
        End Property
        Dim fCaseGrossWeight As Double
        Public Property CaseGrossWeight() As Double
            Get
                Return fCaseGrossWeight
            End Get
            Set(ByVal value As Double)
                SetPropertyValue(Of Double)("CaseGrossWeight", fCaseGrossWeight, value)
            End Set
        End Property
        Dim fPackageCode As String
        <Size(400)> _
        Public Property PackageCode() As String
            Get
                Return fPackageCode
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("PackageCode", fPackageCode, value)
            End Set
        End Property
        Dim fCaseCode As String
        <Size(400)> _
        Public Property CaseCode() As String
            Get
                Return fCaseCode
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("CaseCode", fCaseCode, value)
            End Set
        End Property
        Dim fRequiredWeight As String
        <Size(50)> _
        Public Property RequiredWeight() As String
            Get
                Return fRequiredWeight
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("RequiredWeight", fRequiredWeight, value)
            End Set
        End Property
        Dim fMAV As String
        <Size(50)> _
        Public Property MAV() As String
            Get
                Return fMAV
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("MAV", fMAV, value)
            End Set
        End Property
        Dim fCasesPerLayer As String
        <Size(50)> _
        Public Property CasesPerLayer() As String
            Get
                Return fCasesPerLayer
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("CasesPerLayer", fCasesPerLayer, value)
            End Set
        End Property
        Dim fLayersPerPallet As String
        <Size(50)> _
        Public Property LayersPerPallet() As String
            Get
                Return fLayersPerPallet
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("LayersPerPallet", fLayersPerPallet, value)
            End Set
        End Property
        Dim fShelfLife As String
        <Size(50)> _
        Public Property ShelfLife() As String
            Get
                Return fShelfLife
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ShelfLife", fShelfLife, value)
            End Set
        End Property
        Dim fInstructions As String
        <Size(400)> _
        Public Property Instructions() As String
            Get
                Return fInstructions
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Instructions", fInstructions, value)
            End Set
        End Property
        Dim fPalletPattern As String
        <Size(150)> _
        Public Property PalletPattern() As String
            Get
                Return fPalletPattern
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("PalletPattern", fPalletPattern, value)
            End Set
        End Property
        Dim fInactive As Boolean
        Public Property Inactive() As Boolean
            Get
                Return fInactive
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("Inactive", fInactive, value)
            End Set
        End Property
        Dim fEditing As Boolean
        Public Property Editing() As Boolean
            Get
                Return fEditing
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("Editing", fEditing, value)
            End Set
        End Property
        Private m_Packers As Double?
        Public Property Packers() As Double?
            Get
                Return m_Packers
            End Get
            Set(ByVal value As Double?)
                SetPropertyValue(Of Double?)("Packers", m_Packers, value)
            End Set
        End Property

        Dim fUpc As String
        <Size(50)> _
        Public Property UPC() As String
            Get
                Return fUpc
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("UPC", fUpc, value)
            End Set
        End Property

        Dim fBagsPerCase As Integer?
        Public Property BagsPerCase() As Integer?
            Get
                Return fBagsPerCase
            End Get
            Set(value As Integer?)
                SetPropertyValue(Of Integer?)("BagsPerCase", fBagsPerCase, value)
            End Set
        End Property

        Dim fGenerateLotCodes As Boolean?
        Public Property GenerateLotCodes() As Boolean?
            Get
                Return fGenerateLotCodes
            End Get
            Set(value As Boolean?)
                SetPropertyValue(Of Boolean?)("GenerateLotCodes", fGenerateLotCodes, value)
            End Set
        End Property

        Dim fRequiresLotCodes As Boolean?
        Public Property RequiresLotCodes() As Boolean?
            Get
                Return fRequiresLotCodes
            End Get
            Set(value As Boolean?)
                SetPropertyValue(Of Boolean?)("RequiresLotCodes", fRequiresLotCodes, value)
            End Set
        End Property

        Dim fRequiresExpirationDates As Boolean?
        Public Property RequiresExpirationDates() As Boolean?
            Get
                Return fRequiresExpirationDates
            End Get
            Set(value As Boolean?)
                SetPropertyValue(Of Boolean?)("RequiresExpirationDates", fRequiresExpirationDates, value)
            End Set
        End Property

        Dim fDefaultLotCodeFormat As LotCodeFormats
        Public Property DefaultLotCodeFormat As LotCodeFormats
            Get
                Return fDefaultLotCodeFormat
            End Get
            Set(value As LotCodeFormats)
                SetPropertyValue("DefaultLotCodeFormat", fDefaultLotCodeFormat, value)
            End Set
        End Property

        Dim fMinutesPerShift As Double
        Public Property MinutesPerShift() As Double
            Get
                Return fMinutesPerShift
            End Get
            Set(value As Double)
                SetPropertyValue("MinutesPerShift", fMinutesPerShift, value)
            End Set
        End Property

        Dim fAllergens As String
        Public Property Allergens() As String
            Get
                Return fAllergens
            End Get
            Set(value As String)
                SetPropertyValue("Allergens", fAllergens, value)
            End Set
        End Property

#Region "Non persistent Properties"

        <Association("Item-BOM", GetType(BOMs)), Aggregated()>
        Public ReadOnly Property ItemBOM As XPCollection(Of BOMs)
            Get
                Return GetCollection(Of BOMs)("ItemBOM")
            End Get
        End Property

        <Association("Item-PoolBom", GetType(PoolBom)), Aggregated()>
        Public ReadOnly Property ItemPoolBom As XPCollection(Of PoolBom)
            Get
                Return GetCollection(Of PoolBom)("ItemPoolBom")
            End Get
        End Property

        <Association("LocationInventory-Item", GetType(LocationInventory)), Aggregated()>
        Public ReadOnly Property LocationsInventory As XPCollection(Of LocationInventory)
            Get
                Return GetCollection(Of LocationInventory)("LocationsInventory")
            End Get
        End Property
        <Association("LocationInventoryByLot-Item", GetType(LocationInventoryByLot)), Aggregated()>
        Public ReadOnly Property LocationsInventoryByLot As XPCollection(Of LocationInventoryByLot)
            Get
                Return GetCollection(Of LocationInventoryByLot)("LocationsInventoryByLot")
            End Get
        End Property

        <Association("Transfer-Item", GetType(LocationTransferDetails)), Aggregated()>
        Public ReadOnly Property LocationTransfers As XPCollection(Of LocationTransferDetails)
            Get
                Return GetCollection(Of LocationTransferDetails)("LocationTransfers")
            End Get
        End Property

        <PersistentAlias("LocationsInventory.Sum(QuantityOnHand)")>
        Public ReadOnly Property TotalQuantityOnHand As Double
            Get
                Return Convert.ToDouble(EvaluateAlias("TotalQuantityOnHand"))
            End Get
        End Property

        <Association("Item-Machines", GetType(ItemMachineStandards)), Aggregated()>
        Public ReadOnly Property MachineStandards As XPCollection(Of ItemMachineStandards)
            Get
                Return GetCollection(Of ItemMachineStandards)("MachineStandards")
            End Get
        End Property
#End Region

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New()
            MyBase.New(Session.DefaultSession)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub

        Public Overrides Function ToString() As String

            Return String.Format("{0} - {1}", ItemID, ItemCode)

        End Function



#Region "XPO nested fields class - don't edit manually"
        Public Shadows Class FieldsClass
            Inherits DevExpress.Xpo.PersistentBase.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property ItemID() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ItemID"))
                End Get
            End Property
            Public ReadOnly Property ItemCode() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ItemCode"))
                End Get
            End Property
            Public ReadOnly Property ItemDescription() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ItemDescription"))
                End Get
            End Property
            Public ReadOnly Property ItemType() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ItemType"))
                End Get
            End Property
            Public ReadOnly Property ItemCustomerID() As Customers.FieldsClass
                Get
                    Return New Customers.FieldsClass(GetNestedName("ItemCustomerID"))
                End Get
            End Property
            Public ReadOnly Property ItemDefaultMachine() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ItemDefaultMachine"))
                End Get
            End Property
            Public ReadOnly Property ItemProdStandard() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ItemProdStandard"))
                End Get
            End Property
            Public ReadOnly Property ItemPicture() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ItemPicture"))
                End Get
            End Property
            Public ReadOnly Property dblPrice() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("dblPrice"))
                End Get
            End Property
            Public ReadOnly Property sngRebate() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("sngRebate"))
                End Get
            End Property
            Public ReadOnly Property strUnitOfMeasure() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("strUnitOfMeasure"))
                End Get
            End Property
            Public ReadOnly Property intQtyPerUnit() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("intQtyPerUnit"))
                End Get
            End Property
            Public ReadOnly Property strEnteredBy() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("strEnteredBy"))
                End Get
            End Property
            Public ReadOnly Property dtmEnteredOn() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("dtmEnteredOn"))
                End Get
            End Property
            Public ReadOnly Property dblFreight() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("dblFreight"))
                End Get
            End Property
            Public ReadOnly Property dblFilm() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("dblFilm"))
                End Get
            End Property
            Public ReadOnly Property dblBoxes() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("dblBoxes"))
                End Get
            End Property
            Public ReadOnly Property dblStretchWrap() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("dblStretchWrap"))
                End Get
            End Property
            Public ReadOnly Property dblPallets() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("dblPallets"))
                End Get
            End Property
            Public ReadOnly Property dblOther1() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("dblOther1"))
                End Get
            End Property
            Public ReadOnly Property dblOther2() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("dblOther2"))
                End Get
            End Property
            Public ReadOnly Property dblOther3() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("dblOther3"))
                End Get
            End Property
            Public ReadOnly Property dblOther4() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("dblOther4"))
                End Get
            End Property
            Public ReadOnly Property dblOther5() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("dblOther5"))
                End Get
            End Property
            Public ReadOnly Property intUnitsPerCase() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("intUnitsPerCase"))
                End Get
            End Property
            Public ReadOnly Property intUnitsPerPallet() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("intUnitsPerPallet"))
                End Get
            End Property
            Public ReadOnly Property intCasesPerPallet() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("intCasesPerPallet"))
                End Get
            End Property
            Public ReadOnly Property sngQuantityOnHand() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("sngQuantityOnHand"))
                End Get
            End Property
            Public ReadOnly Property CaseGrossWeight() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("CaseGrossWeight"))
                End Get
            End Property
            Public ReadOnly Property PackageCode() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("PackageCode"))
                End Get
            End Property
            Public ReadOnly Property CaseCode() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("CaseCode"))
                End Get
            End Property
            Public ReadOnly Property RequiredWeight() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("RequiredWeight"))
                End Get
            End Property
            Public ReadOnly Property MAV() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("MAV"))
                End Get
            End Property
            Public ReadOnly Property CasesPerLayer() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("CasesPerLayer"))
                End Get
            End Property
            Public ReadOnly Property LayersPerPallet() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("LayersPerPallet"))
                End Get
            End Property
            Public ReadOnly Property ShelfLife() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ShelfLife"))
                End Get
            End Property
            Public ReadOnly Property Instructions() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Instructions"))
                End Get
            End Property
            Public ReadOnly Property PalletPattern() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("PalletPattern"))
                End Get
            End Property
            Public ReadOnly Property Inactive() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Inactive"))
                End Get
            End Property
            Public ReadOnly Property Editing() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Editing"))
                End Get
            End Property
            Public ReadOnly Property Packers() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Packers"))
                End Get
            End Property
            Public ReadOnly Property UPC() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("UPC"))
                End Get
            End Property
            Public ReadOnly Property TotalQuantityOnHand() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("TotalQuantityOnHand"))
                End Get
            End Property
            Public ReadOnly Property BagsPerCase() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("BagsPerCase"))
                End Get
            End Property
            Public ReadOnly Property GenerateLotCodes() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("GenerateLotCodes"))
                End Get
            End Property
            Public ReadOnly Property RequiresLotCodes() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("RequiresLotCodes"))
                End Get
            End Property
            Public ReadOnly Property RequiresExpirationDates() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("RequiresExpirationDates"))
                End Get
            End Property
            Public ReadOnly Property DefaultLotCodeFormat() As LotCodeFormats.FieldsClass
                Get
                    Return New LotCodeFormats.FieldsClass(GetNestedName("DefaultLotCodeFormat"))
                End Get
            End Property
            Public ReadOnly Property MinutesPerShift() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("MinutesPerShift"))
                End Get
            End Property
            Public ReadOnly Property Allergens() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Allergens"))
                End Get
            End Property
        End Class
        Private Shared _fields As FieldsClass
        Public Shared Shadows ReadOnly Property Fields() As FieldsClass
            Get
                If ReferenceEquals(_fields, Nothing) Then
                    _fields = New FieldsClass()
                End If
                Return _fields
            End Get
        End Property
#End Region
    End Class
End Namespace
