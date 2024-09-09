Imports Entities
Imports DataAccess
Public Class BFPais
    Public Shared Function GetById(id As Integer) As GIC_Pais

        Try
            Dim _dal As New DataAccess.DALPais
            Return _dal.GetById(id)

        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
    Public Shared Function ListAllActive() As List(Of GIC_Pais)

        Try
            Dim _dal As New DataAccess.DALPais
            Return _dal.ListAllActive()
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function

    Public Shared Function ListAllById(id As Integer) As List(Of GIC_Pais)

        Try
            Dim _dal As New DataAccess.DALPais()
            Return _dal.ListAllById(id)
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
    Public Shared Function AddData(var As Pais) As Boolean

        Try
            Dim _dal As New DataAccess.DALPais()
            _dal.AddData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Shared Function ModData(var As Pais) As Boolean

        Try
            Dim _dal As New DataAccess.DALPais()
            _dal.ModData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Shared Function DeleteData(var As Pais) As Boolean
        Try
            Dim _dal As New DataAccess.DALPais()
            _dal.DeleteData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
End Class
