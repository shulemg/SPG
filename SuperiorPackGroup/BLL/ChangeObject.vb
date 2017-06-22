
Public Class ChangeObject
    Public Property PropertyName As String
    Public Property PrevValue As String
    Public Property NewValue As String
    Public Property ChangeID As Integer
    Public Property DateChanged As Date
    Public Property RecordID As Integer
End Class

Public Structure ChangeObjectLookUpKey
    Public ChangeID As Integer
    Public ProperyName As String
End Structure