Imports Entities
Public Class DALRegion
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_Region

        Try

            Return dc.GIC_Region.FirstOrDefault(Function(o) o.RegionID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_Region)

        Try
            Return dc.GIC_Region.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_Region)

        Try
            Dim lists = From o In dc.GIC_Region Where o.RegionID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As Region) As Boolean

        Try

            Dim VarGic As New GIC_Region

            VarGic.Region_numero_romano = var.Region_numero_romano
            VarGic.RegionNombre = var.RegionNombre
            VarGic.Capital = var.Capital
            VarGic.Activo = var.Activo
            VarGic.PaisID = var.PaisID
            dc.GIC_Region.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As Region) As Boolean

        Try

            Dim VarGic As GIC_Region = dc.GIC_Region.Find(var)
            VarGic.Region_numero_romano = var.Region_numero_romano
            VarGic.RegionNombre = var.RegionNombre
            VarGic.Capital = var.Capital
            VarGic.Activo = var.Activo
            VarGic.PaisID = var.PaisID
            dc.GIC_Region.Add(VarGic)

            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As Region) As Boolean
        Try

            Dim cl2 As GIC_Region = dc.GIC_Region.Find(var)
            dc.GIC_Region.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
