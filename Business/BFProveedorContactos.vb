Imports Entities
Imports DataAccess
Public Class BFProveedorContactos
    Public Shared Function GetById(id As Integer) As GIC_Proveedor_Contactos

        Try
            Dim _dal As New DataAccess.DALProveedorContactos
            Return _dal.GetById(id)

        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
    Public Shared Function ListAllActive() As List(Of GIC_Proveedor_Contactos)

        Try
            Dim _dal As New DataAccess.DALProveedorContactos
            Return _dal.ListAllActive()
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function

    Public Shared Function ListAllById(id As Integer) As List(Of GIC_Proveedor_Contactos)

        Try
            Dim _dal As New DataAccess.DALProveedorContactos()
            Return _dal.ListAllById(id)
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
    Public Shared Function AddData(var As ProveedorContactos) As Boolean

        Try
            Dim _dal As New DataAccess.DALProveedorContactos()
            _dal.AddData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Shared Function ModData(var As ProveedorContactos) As Boolean

        Try
            Dim _dal As New DataAccess.DALProveedorContactos()
            _dal.ModData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Shared Function DeleteData(var As ProveedorContactos) As Boolean
        Try
            Dim _dal As New DataAccess.DALProveedorContactos()
            _dal.DeleteData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
End Class
