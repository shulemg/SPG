Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering

Namespace SPGData
    Public Class tblid
        Inherits XPLiteObject
        Dim ftablename As String
        <Key()> _
        <Size(40)> _
        Public Property tablename() As String
            Get
                Return ftablename
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("tablename", ftablename, value)
            End Set
        End Property
        Dim fid As Integer
        Public Property id() As Integer
            Get
                Return fid
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("id", fid, value)
            End Set
        End Property
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New()
            MyBase.New(Session.DefaultSession)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub
    End Class

End Namespace
