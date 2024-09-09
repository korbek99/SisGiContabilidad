
Imports System
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Globalization
Imports Entities

Public Class DALAfp
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_AFP

        Try

            Return dc.GIC_AFP.FirstOrDefault(Function(o) o.AfpID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListarAllDataset()
        Try
            Return dc.GIC_AFP.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_AFP)
        'Dim dc As New GICont2015Entities2()
        Try
            Return dc.GIC_AFP.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_AFP)
        'Dim dc As New GICont2015Entities2()
        Try
            Dim lists = From o In dc.GIC_AFP Where o.AfpID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function

    Public Function AddData(var As AFP) As Boolean

        Try
            ' Dim dc As New GICont2015Entities2()
            Dim Afps As New GIC_AFP

            Afps.AfpNombre = var.AfpNombre
            Afps.Activo = var.Activo
            dc.GIC_AFP.Add(Afps)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As AFP) As Boolean

        Try
            'Dim dc As New GICont2015Entities2()
            Dim Afps As GIC_AFP = dc.GIC_AFP.Find(var.AfpID)

            Afps.AfpNombre = var.AfpNombre
            Afps.Activo = var.Activo
            dc.Entry(Afps).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As AFP) As Boolean
        Try
            'Dim dc As New GICont2015Entities2()
            Dim cl2 As GIC_AFP = dc.GIC_AFP.Find(var)
            dc.GIC_AFP.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
