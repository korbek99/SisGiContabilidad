Imports Entities
Public Class DALTipoEmpresa
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_TipoEmpresa

        Try

            Return dc.GIC_TipoEmpresa.FirstOrDefault(Function(o) o.TipoEmpID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_TipoEmpresa)

        Try
            Return dc.GIC_TipoEmpresa.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_TipoEmpresa)

        Try
            Dim lists = From o In dc.GIC_TipoEmpresa Where o.TipoEmpID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As TipoEmpresa) As Boolean

        Try
            Dim VarGic As New GIC_TipoEmpresa

            VarGic.TipoEmpresaNombre = var.TipoEmpresaNombre
            VarGic.Activo = var.Activo
            dc.GIC_TipoEmpresa.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As TipoEmpresa) As Boolean

        Try

            Dim VarGic As GIC_TipoEmpresa = dc.GIC_TipoEmpresa.Find(var)
            VarGic.TipoEmpresaNombre = var.TipoEmpresaNombre
            VarGic.Activo = var.Activo
            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As TipoEmpresa) As Boolean
        Try

            Dim cl2 As GIC_TipoEmpresa = dc.GIC_TipoEmpresa.Find(var)
            dc.GIC_TipoEmpresa.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
