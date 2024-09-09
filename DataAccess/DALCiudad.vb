
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Globalization
Imports Entities

Public Class DALCiudad
    Public dc As New GICont2015Entities2()
    Public Function ListAllActive() As List(Of GIC_Ciudad)
        '
        Try
            Return dc.GIC_Ciudad.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
End Class
