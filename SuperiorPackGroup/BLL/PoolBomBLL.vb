Imports DevExpress.Data.Filtering
Imports DXDAL.SPGData
Imports DevExpress.Xpo
Imports System.Text

Public Class PoolBomBLL

    Public Shared Function PoolUsedAsBom(ByVal poolID As Integer) As Boolean

        Using lXPCollection As XPCollection(Of PoolBom) = New XPCollection(Of PoolBom)(Session.DefaultSession, New BinaryOperator(PoolBom.Fields.ItemPoolID.PropertyName, poolID, BinaryOperatorType.Equal))
            Return lXPCollection.Count > 0
        End Using

    End Function

End Class
