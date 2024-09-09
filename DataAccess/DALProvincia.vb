Imports Entities
Public Class DALProvincia
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_Provincia

        Try

            Return dc.GIC_Provincia.FirstOrDefault(Function(o) o.ProvinciaID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_Provincia)

        Try
            Return dc.GIC_Provincia.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_Provincia)

        Try
            Dim lists = From o In dc.GIC_Provincia Where o.ProvinciaID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As Provincia) As Boolean

        Try

            Dim VarGic As New GIC_Provincia


            VarGic.RegionID = var.RegionID
            VarGic.ProvinciaNombre = var.ProvinciaNombre
            VarGic.Capital = var.Capital
            VarGic.Activo = var.Activo
            dc.GIC_Provincia.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As Provincia) As Boolean

        Try

            Dim VarGic As GIC_Provincia = dc.GIC_Provincia.Find(var)
            VarGic.RegionID = var.RegionID
            VarGic.ProvinciaNombre = var.ProvinciaNombre
            VarGic.Capital = var.Capital
            VarGic.Activo = var.Activo
            dc.GIC_Provincia.Add(VarGic)

            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As Provincia) As Boolean
        Try

            Dim cl2 As GIC_Provincia = dc.GIC_Provincia.Find(var)
            dc.GIC_Provincia.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
