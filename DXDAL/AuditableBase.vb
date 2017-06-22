Imports DevExpress.Xpo
Imports DXDAL.SPGData

<NonPersistent()>
Public Class AuditableBase
    Inherits XPObject

    Protected Sub New()

    End Sub

    Protected Sub New(ByVal session As Session)
        MyBase.New(session)

    End Sub

    Protected Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
        MyBase.New(session, classInfo)

    End Sub

    Private changes As List(Of Change) = New List(Of Change)

    Private Structure Change

        Public PropertyName As String
        Public PrevValue As String
        Public Value As String

    End Structure

    Public ReadOnly Property HasChanges() As Boolean
        Get
            Return changes.Count > 0
        End Get

    End Property

    Private Sub UpdateAudit(ByVal recordID As Integer)

        If changes.Count > 0 Then
            Dim audit = New AuditTrail(Session) With {.ChangeDate = Now, .RecordType = ClassInfo.ClassType.Name, .UserID = Environment.UserName, .RecordID = recordID}

            For Each change In changes
                audit.RecordChanges &= String.Format("{0}:{1}({2});", change.PropertyName, change.PrevValue, change.Value)
            Next
            audit.Save()
        End If

    End Sub

    Protected Overrides Sub OnSaved()
        MyBase.OnSaved()

        UpdateAudit(CInt(GetMemberValue("Oid")))
    End Sub

    Protected Overrides Sub OnChanged(ByVal propertyName As String, ByVal oldValue As Object, ByVal newValue As Object)
        MyBase.OnChanged(propertyName, oldValue, newValue)

        Dim change = New Change() With {.PropertyName = propertyName}
        If oldValue Is Nothing Then
            change.PrevValue = "NULL"
        Else
            change.PrevValue = oldValue.ToString
        End If
        If newValue Is Nothing Then
            change.Value = "NULL"
        Else
            change.Value = newValue.ToString
        End If
        If Not (change.PropertyName = "Oid" AndAlso change.PrevValue = "-1") AndAlso change.PropertyName <> "OptimisticLockField" AndAlso change.PropertyName <> "OptimisticLockFieldInDataLayer" AndAlso change.PropertyName <> "GCRecord" Then
            changes.Add(change)
        End If


    End Sub

    Protected Overrides Sub OnDeleted()
        MyBase.OnDeleted()

        Dim recordID As Integer = CInt(GetPropertyValue("Oid"))

        Dim audit = New AuditTrail(Session) With {.ChangeDate = Now, .RecordType = ClassInfo.ClassType.Name, .UserID = Environment.UserName, .RecordID = recordID, .RecordChanges = recordID.ToString & " was deleted"}

        audit.Save()

    End Sub

End Class
