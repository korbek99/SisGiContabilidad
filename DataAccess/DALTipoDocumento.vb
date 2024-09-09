Imports Entities
Public Class DALTipoDocumento
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_TipoDocumento

        Try

            Return dc.GIC_TipoDocumento.FirstOrDefault(Function(o) o.TipoDocID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_TipoDocumento)

        Try
            Return dc.GIC_TipoDocumento.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_TipoDocumento)

        Try
            Dim lists = From o In dc.GIC_TipoDocumento Where o.TipoDocID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As TipoDocumento) As Boolean

        Try

            Dim VarGic As New GIC_TipoDocumento

            VarGic.TipoDocumentoNombre = var.TipoDocumentoNombre
            VarGic.Activo = var.Activo
            dc.GIC_TipoDocumento.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As TipoDocumento) As Boolean

        Try

            Dim VarGic As GIC_TipoDocumento = dc.GIC_TipoDocumento.Find(var)
            VarGic.TipoDocumentoNombre = var.TipoDocumentoNombre
            VarGic.Activo = var.Activo
            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As TipoDocumento) As Boolean
        Try

            Dim cl2 As GIC_TipoDocumento = dc.GIC_TipoDocumento.Find(var)
            dc.GIC_TipoDocumento.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
