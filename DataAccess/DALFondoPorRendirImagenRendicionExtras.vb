Imports Entities
Public Class DALFondoPorRendirImagenRendicionExtras
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_FondoPorRendirImagenRendicionExt

        Try

            Return dc.GIC_FondoPorRendirImagenRendicionExt.FirstOrDefault(Function(o) o.FPRImgExtID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_FondoPorRendirImagenRendicionExt)

        Try
            Return dc.GIC_FondoPorRendirImagenRendicionExt.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_FondoPorRendirImagenRendicionExt)

        Try
            Dim lists = From o In dc.GIC_FondoPorRendirImagenRendicionExt Where o.FPRImgExtID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As FondoPorRendirImagenRendicionExt) As Boolean

        Try

            Dim VarGic As New GIC_FondoPorRendirImagenRendicionExt

            VarGic.FPRID = var.FPRID
            VarGic.FPRImagenRendicion = var.FPRImagenRendicion
            VarGic.FPRFechaIngreso = var.FPRFechaIngreso
            dc.GIC_FondoPorRendirImagenRendicionExt.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As FondoPorRendirImagenRendicionExt) As Boolean

        Try

            Dim VarGic As GIC_FondoPorRendirImagenRendicionExt = dc.GIC_FondoPorRendirImagenRendicionExt.Find(var)

            VarGic.FPRID = var.FPRID
            VarGic.FPRImagenRendicion = var.FPRImagenRendicion
            VarGic.FPRFechaIngreso = var.FPRFechaIngreso
            dc.GIC_FondoPorRendirImagenRendicionExt.Add(VarGic)

            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As FondoPorRendirImagenRendicionExt) As Boolean
        Try

            Dim cl2 As GIC_FondoPorRendirImagenRendicionExt = dc.GIC_FondoPorRendirImagenRendicionExt.Find(var)
            dc.GIC_FondoPorRendirImagenRendicionExt.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
