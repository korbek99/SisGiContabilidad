﻿Imports Entities
Imports DataAccess
Public Class BFComuna
    Public Shared Function GetById(id As Integer) As GIC_Comuna

        Try
            Dim _dal As New DataAccess.DALComuna
            Return _dal.GetById(id)

        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
    Public Shared Function ListAllActive() As List(Of GIC_Comuna)

        Try
            Dim _dal As New DataAccess.DALComuna
            Return _dal.ListAllActive()
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function

    Public Shared Function ListAllById(id As Integer) As List(Of GIC_Comuna)

        Try
            Dim _dal As New DataAccess.DALComuna()
            Return _dal.ListAllById(id)
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
    Public Shared Function AddData(var As Comuna) As Boolean

        Try
            Dim _dal As New DataAccess.DALComuna()
            _dal.AddData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Shared Function ModData(var As Comuna) As Boolean

        Try
            Dim _dal As New DataAccess.DALComuna()
            _dal.ModData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Shared Function DeleteData(var As Comuna) As Boolean
        Try
            Dim _dal As New DataAccess.DALComuna()
            _dal.DeleteData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
End Class
