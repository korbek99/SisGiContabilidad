
Imports DataAccess
Imports Entities
Public Class BFCiudad
    Public Shared Function ListAllActive() As List(Of GIC_Ciudad)

        Try
            Dim _dal As New DataAccess.DALCiudad
            Return _dal.ListAllActive()
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
End Class
