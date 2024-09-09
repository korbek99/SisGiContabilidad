Imports Entities
Public Class DALSubCuentasDetalle
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_SubCuentasDetalle

        Try

            Return dc.GIC_SubCuentasDetalle.FirstOrDefault(Function(o) o.SubCuentaDetalleID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_SubCuentasDetalle)

        Try
            Return dc.GIC_SubCuentasDetalle.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_SubCuentasDetalle)

        Try
            Dim lists = From o In dc.GIC_SubCuentasDetalle Where o.SubCuentaDetalleID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As SubCuentasDetalle) As Boolean

        Try

            Dim VarGic As New GIC_SubCuentasDetalle

            VarGic.SubCuentaID = var.SubCuentaID
            VarGic.NumeroEEPP = var.NumeroEEPP
            VarGic.DescripcionEstadoPago = var.DescripcionEstadoPago
            VarGic.FechaEEPP = var.FechaEEPP
            VarGic.MonedaEEPP = var.MonedaEEPP
            VarGic.MontoEEPP = var.MontoEEPP
            VarGic.ImpuestoEEPP = var.ImpuestoEEPP
            VarGic.TotalEEPP = var.TotalEEPP

            dc.GIC_SubCuentasDetalle.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As SubCuentasDetalle) As Boolean

        Try

            Dim VarGic As GIC_SubCuentasDetalle = dc.GIC_SubCuentasDetalle.Find(var)
            VarGic.SubCuentaID = var.SubCuentaID
            VarGic.NumeroEEPP = var.NumeroEEPP
            VarGic.DescripcionEstadoPago = var.DescripcionEstadoPago
            VarGic.FechaEEPP = var.FechaEEPP
            VarGic.MonedaEEPP = var.MonedaEEPP
            VarGic.MontoEEPP = var.MontoEEPP
            VarGic.ImpuestoEEPP = var.ImpuestoEEPP
            VarGic.TotalEEPP = var.TotalEEPP
            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As SubCuentasDetalle) As Boolean
        Try

            Dim cl2 As GIC_SubCuentasDetalle = dc.GIC_SubCuentasDetalle.Find(var)
            dc.GIC_SubCuentasDetalle.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
