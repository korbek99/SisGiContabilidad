﻿Imports Entities
Imports DataAccess
Public Class BFFormaDePago
    Public Shared Function GetById(id As Integer) As GIC_FormaDePago

        Try
            Dim _dal As New DataAccess.DALFormaDePago
            Return _dal.GetById(id)

        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
    Public Shared Function ListAllActive() As List(Of GIC_FormaDePago)

        Try
            Dim _dal As New DataAccess.DALFormaDePago
            Return _dal.ListAllActive()
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function

    Public Shared Function ListAllById(id As Integer) As List(Of GIC_FormaDePago)

        Try
            Dim _dal As New DataAccess.DALFormaDePago()
            Return _dal.ListAllById(id)
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
    Public Shared Function AddData(var As FormaDePago) As Boolean

        Try
            Dim _dal As New DataAccess.DALFormaDePago()
            _dal.AddData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Shared Function ModData(var As FormaDePago) As Boolean

        Try
            Dim _dal As New DataAccess.DALFormaDePago()
            _dal.ModData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Shared Function DeleteData(var As FormaDePago) As Boolean
        Try
            Dim _dal As New DataAccess.DALFormaDePago()
            _dal.DeleteData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
End Class
