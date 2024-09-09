Imports Entities
Imports DataAccess
Public Class BFFormaPagoProveedor
    Public Shared Function GetById(id As Integer) As GIC_FormaDePagoProveedor

        Try
            Dim _dal As New DataAccess.DALFormaPagoProveedor
            Return _dal.GetById(id)

        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
    Public Shared Function ListAllActive() As List(Of GIC_FormaDePagoProveedor)

        Try
            Dim _dal As New DataAccess.DALFormaPagoProveedor
            Return _dal.ListAllActive()
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function

    Public Shared Function ListAllById(id As Integer) As List(Of GIC_FormaDePagoProveedor)

        Try
            Dim _dal As New DataAccess.DALFormaPagoProveedor()
            Return _dal.ListAllById(id)
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
    Public Shared Function AddData(var As FormaDePagoProveedor) As Boolean

        Try
            Dim _dal As New DataAccess.DALFormaPagoProveedor()
            _dal.AddData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Shared Function ModData(var As FormaDePagoProveedor) As Boolean

        Try
            Dim _dal As New DataAccess.DALFormaPagoProveedor()
            _dal.ModData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Shared Function DeleteData(var As FormaDePagoProveedor) As Boolean
        Try
            Dim _dal As New DataAccess.DALFormaPagoProveedor()
            _dal.DeleteData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
End Class
