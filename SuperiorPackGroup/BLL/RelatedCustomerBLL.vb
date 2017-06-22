Imports DXDAL.SPGData
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class RelatedCustomerBLL

    Public Shared Function AddRelatedCustomer(ByVal maincustomer As Customers, ByVal relatedCustomer As Customers, ByVal bidirectional As Boolean) As Boolean

        Try
            Dim newRelatedCustomer As RelatedCustomer = New RelatedCustomer With {.MainCustomer = maincustomer, .RelatedCustomer = relatedCustomer, .Bidirectional = bidirectional}
            newRelatedCustomer.Save()

            If bidirectional Then
                newRelatedCustomer = New RelatedCustomer With {.MainCustomer = relatedCustomer, .RelatedCustomer = maincustomer, .Bidirectional = bidirectional}
                newRelatedCustomer.Save()
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Shared Function DeleteRelatedCustomers(ByVal deletingCustomer As Customers) As Boolean

        Dim lRelatedCustomer As RelatedCustomer

        Dim theCriteria As GroupOperator = New GroupOperator With {.OperatorType = GroupOperatorType.Or}
        theCriteria.Operands.Add(New BinaryOperator(RelatedCustomer.Fields.MainCustomer.PropertyName, deletingCustomer, BinaryOperatorType.Equal))
        theCriteria.Operands.Add(New BinaryOperator(RelatedCustomer.Fields.RelatedCustomer.PropertyName, deletingCustomer, BinaryOperatorType.Equal))

        Using myRelatedCustomers As XPCollection(Of RelatedCustomer) = New XPCollection(Of RelatedCustomer)(Session.DefaultSession, theCriteria)
            Try
                For i As Integer = myRelatedCustomers.Count - 1 To 0 Step -1
                    lRelatedCustomer = myRelatedCustomers(i)
                    lRelatedCustomer.Delete()
                Next
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using

    End Function

    Public Shared Function DeleteRelatedCustomer(ByVal deletingCustomer As RelatedCustomer) As Boolean

        Try
            deletingCustomer.Delete()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
