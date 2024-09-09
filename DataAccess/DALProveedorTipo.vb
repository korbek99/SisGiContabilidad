Imports Entities
Public Class DALProveedorTipo
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_TipoProveedor

        Try

            Return dc.GIC_TipoProveedor.FirstOrDefault(Function(o) o.TipoProveID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_TipoProveedor)

        Try
            Return dc.GIC_TipoProveedor.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_TipoProveedor)

        Try
            Dim lists = From o In dc.GIC_TipoProveedor Where o.TipoProveID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As ProveedorTipo) As Boolean

        Try

            Dim VarGic As New GIC_TipoProveedor
            VarGic.TipoProveedorNombre = var.TipoProveedorNombre
            VarGic.Activo = var.Activo
            dc.GIC_TipoProveedor.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As ProveedorTipo) As Boolean

        Try

            Dim VarGic As GIC_TipoProveedor = dc.GIC_TipoProveedor.Find(var)
            VarGic.TipoProveedorNombre = var.TipoProveedorNombre
            VarGic.Activo = var.Activo
            dc.GIC_TipoProveedor.Add(VarGic)

            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As ProveedorTipo) As Boolean
        Try

            Dim cl2 As GIC_TipoProveedor = dc.GIC_TipoProveedor.Find(var)
            dc.GIC_TipoProveedor.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
