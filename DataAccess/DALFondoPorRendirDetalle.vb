Imports Entities
Public Class DALFondoPorRendirDetalle
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_FondoPorRendirDetalle

        Try

            Return dc.GIC_FondoPorRendirDetalle.FirstOrDefault(Function(o) o.FPRDetalleID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_FondoPorRendirDetalle)

        Try
            Return dc.GIC_FondoPorRendirDetalle.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_FondoPorRendirDetalle)

        Try
            Dim lists = From o In dc.GIC_FondoPorRendirDetalle Where o.FPRDetalleID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As FondoPorRendirDetalle) As Boolean

        Try

            Dim VarGic As New GIC_FondoPorRendirDetalle

            VarGic.FPRID = var.FPRID
            VarGic.FPRFechaIngresoDetalle = var.FPRFechaIngresoDetalle
            VarGic.FPRDescripcionDetalle = var.FPRDescripcionDetalle
            VarGic.FPRNumeroDocumento = var.FPRNumeroDocumento
            VarGic.FPRTareasID = var.FPRTareasID
            VarGic.Tasa = var.Tasa
            VarGic.Total = var.Total
            dc.GIC_FondoPorRendirDetalle.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As FondoPorRendirDetalle) As Boolean

        Try

            Dim VarGic As GIC_FondoPorRendirDetalle = dc.GIC_FondoPorRendirDetalle.Find(var)

            VarGic.FPRID = var.FPRID
            VarGic.FPRFechaIngresoDetalle = var.FPRFechaIngresoDetalle
            VarGic.FPRDescripcionDetalle = var.FPRDescripcionDetalle
            VarGic.FPRNumeroDocumento = var.FPRNumeroDocumento
            VarGic.FPRTareasID = var.FPRTareasID
            VarGic.Tasa = var.Tasa
            VarGic.Total = var.Total

            dc.GIC_FondoPorRendirDetalle.Add(VarGic)

            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As FondoPorRendirDetalle) As Boolean
        Try

            Dim cl2 As GIC_FondoPorRendirDetalle = dc.GIC_FondoPorRendirDetalle.Find(var)
            dc.GIC_FondoPorRendirDetalle.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
