Imports Entities
Public Class DALFichaPersonalDocumentos
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_FichaPersonal_Documentos

        Try

            Return dc.GIC_FichaPersonal_Documentos.FirstOrDefault(Function(o) o.FichaPersonalDoc.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_FichaPersonal_Documentos)

        Try
            Return dc.GIC_FichaPersonal_Documentos.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_FichaPersonal_Documentos)

        Try
            Dim lists = From o In dc.GIC_FichaPersonal_Documentos Where o.FichaPersonalDoc = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As FichaPersonalDocumentos) As Boolean

        Try

            Dim VarGic As New GIC_FichaPersonal_Documentos

            VarGic.FichaPersonalID = var.FichaPersonalID
            VarGic.FichaPersonalDocumento = var.FichaPersonalDocumento
            VarGic.FichaPersonalDescripcion = var.FichaPersonalDescripcion
            dc.GIC_FichaPersonal_Documentos.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As FichaPersonalDocumentos) As Boolean

        Try

            Dim VarGic As GIC_FichaPersonal_Documentos = dc.GIC_FichaPersonal_Documentos.Find(var)
            VarGic.FichaPersonalID = var.FichaPersonalID
            VarGic.FichaPersonalDocumento = var.FichaPersonalDocumento
            VarGic.FichaPersonalDescripcion = var.FichaPersonalDescripcion
            dc.GIC_FichaPersonal_Documentos.Add(VarGic)

            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As FichaPersonalDocumentos) As Boolean
        Try

            Dim cl2 As GIC_FichaPersonal_Documentos = dc.GIC_FichaPersonal_Documentos.Find(var)
            dc.GIC_FichaPersonal_Documentos.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
