Imports Entities
Imports DataAccess
Public Class BFProveedorTipo
    Public Shared Function GetById(id As Integer) As GIC_TipoProveedor

        Try
            Dim _dal As New DataAccess.DALProveedorTipo
            Return _dal.GetById(id)

        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
    Public Shared Function ListAllActive() As List(Of GIC_TipoProveedor)

        Try
            Dim _dal As New DataAccess.DALProveedorTipo
            Return _dal.ListAllActive()
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function

    Public Shared Function ListAllById(id As Integer) As List(Of GIC_TipoProveedor)

        Try
            Dim _dal As New DataAccess.DALProveedorTipo()
            Return _dal.ListAllById(id)
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
    Public Shared Function AddData(var As ProveedorTipo) As Boolean

        Try
            Dim _dal As New DataAccess.DALProveedorTipo()
            _dal.AddData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Shared Function ModData(var As ProveedorTipo) As Boolean

        Try
            Dim _dal As New DataAccess.DALProveedorTipo()
            _dal.ModData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Shared Function DeleteData(var As ProveedorTipo) As Boolean
        Try
            Dim _dal As New DataAccess.DALProveedorTipo()
            _dal.DeleteData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
End Class
