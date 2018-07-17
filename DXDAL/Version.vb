Imports DevExpress.Xpo

Namespace SPGData
    <Persistent("tblVersion")>
    Partial Public Class LatestVersion
        Inherits XPObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub
        'Dim fID As Integer
        '<Key(True)>
        'Public Property ID() As Integer
        '    Get
        '        Return fID
        '    End Get
        '    Set(ByVal value As Integer)
        '        SetPropertyValue(Of Integer)("ID", fID, value)
        '    End Set
        'End Property
        Private fLatestRevision As Integer
        Public Property LatestRevision() As Integer
            Get
                Return fLatestRevision
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("LatestRevision", fLatestRevision, value)
            End Set
        End Property
    End Class
End Namespace