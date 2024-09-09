Imports Entities
Imports DataAccess
Public Class BFFichaPersonalDocumentos
    Public Shared Function GetById(id As Integer) As GIC_FichaPersonal_Documentos

        Try
            Dim _dal As New DataAccess.DALFichaPersonalDocumentos
            Return _dal.GetById(id)

        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
    Public Shared Function ListAllActive() As List(Of GIC_FichaPersonal_Documentos)

        Try
            Dim _dal As New DataAccess.DALFichaPersonalDocumentos
            Return _dal.ListAllActive()
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function

    Public Shared Function ListAllById(id As Integer) As List(Of GIC_FichaPersonal_Documentos)

        Try
            Dim _dal As New DataAccess.DALFichaPersonalDocumentos()
            Return _dal.ListAllById(id)
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
    Public Shared Function AddData(var As FichaPersonalDocumentos) As Boolean

        Try
            Dim _dal As New DataAccess.DALFichaPersonalDocumentos()
            _dal.AddData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Shared Function ModData(var As FichaPersonalDocumentos) As Boolean

        Try
            Dim _dal As New DataAccess.DALFichaPersonalDocumentos()
            _dal.ModData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Shared Function DeleteData(var As FichaPersonalDocumentos) As Boolean
        Try
            Dim _dal As New DataAccess.DALFichaPersonalDocumentos()
            _dal.DeleteData(var)
            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
End Class
