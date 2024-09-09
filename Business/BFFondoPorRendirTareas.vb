Imports Entities
Imports DataAccess
Public Class BFFondoPorRendirTareas
    Public Shared Function GetById(id As Integer) As GIC_FondoPorRendirTareas

        Try
            Dim _dal As New DataAccess.DALFondoPorRendirTareas
            Return _dal.GetById(id)

        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
    Public Shared Function ListAllActive() As List(Of GIC_FondoPorRendirTareas)

        Try
            Dim _dal As New DataAccess.DALFondoPorRendirTareas
            Return _dal.ListAllActive()
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function

    Public Shared Function ListAllById(id As Integer) As List(Of GIC_FondoPorRendirTareas)

        Try
            Dim _dal As New DataAccess.DALFondoPorRendirTareas()
            Return _dal.ListAllById(id)
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
    Public Shared Function AddData(var As FondoPorRendirTareas) As Boolean

        Try
            Dim _dal As New DataAccess.DALFondoPorRendirTareas()
            _dal.AddData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Shared Function ModData(var As FondoPorRendirTareas) As Boolean

        Try
            Dim _dal As New DataAccess.DALFondoPorRendirTareas()
            _dal.ModData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Shared Function DeleteData(var As FondoPorRendirTareas) As Boolean
        Try
            Dim _dal As New DataAccess.DALFondoPorRendirTareas()
            _dal.DeleteData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
End Class
