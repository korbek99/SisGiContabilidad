Imports Entities
Public Class DALFondoPorRendir
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_FondoPorRendir

        Try

            Return dc.GIC_FondoPorRendir.FirstOrDefault(Function(o) o.FPRID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_FondoPorRendir)

        Try
            Return dc.GIC_FondoPorRendir.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_FondoPorRendir)

        Try
            Dim lists = From o In dc.GIC_FondoPorRendir Where o.FPRID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As FondoPorRendir) As Boolean

        Try

            Dim VarGic As New GIC_FondoPorRendir

            VarGic.FichaPersonalID = var.FichaPersonalID
            VarGic.SubCuentaID = var.SubCuentaID
            VarGic.CuentaContaID = var.CuentaContaID
            VarGic.FPRMontoAsignado = var.FPRMontoAsignado
            VarGic.FPRDescripcion = var.FPRDescripcion
            VarGic.FPRMontoGastado = var.FPRMontoGastado
            VarGic.FPRSaldoActual = var.FPRSaldoActual
            VarGic.FPRFechaIngreso = var.FPRFechaIngreso
            VarGic.FPRImagenSolicitud = var.FPRImagenSolicitud
            VarGic.FPRImagenTransDestinatario = var.FPRImagenTransDestinatario
            VarGic.FPRImagenRendicion = var.FPRImagenRendicion
            VarGic.FPRImagenTransSaldo = var.FPRImagenTransSaldo
            VarGic.EstadoFPRID = var.EstadoFPRID
            VarGic.FPRSubTotal = var.FPRSubTotal
            VarGic.FPRTotal = var.FPRTotal
            VarGic.UsuarioID = var.UsuarioID
            dc.GIC_FondoPorRendir.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As FondoPorRendir) As Boolean

        Try

            Dim VarGic As GIC_FondoPorRendir = dc.GIC_FondoPorRendir.Find(var)
            VarGic.FichaPersonalID = var.FichaPersonalID
            VarGic.SubCuentaID = var.SubCuentaID
            VarGic.CuentaContaID = var.CuentaContaID
            VarGic.FPRMontoAsignado = var.FPRMontoAsignado
            VarGic.FPRDescripcion = var.FPRDescripcion
            VarGic.FPRMontoGastado = var.FPRMontoGastado
            VarGic.FPRSaldoActual = var.FPRSaldoActual
            VarGic.FPRFechaIngreso = var.FPRFechaIngreso
            VarGic.FPRImagenSolicitud = var.FPRImagenSolicitud
            VarGic.FPRImagenTransDestinatario = var.FPRImagenTransDestinatario
            VarGic.FPRImagenRendicion = var.FPRImagenRendicion
            VarGic.FPRImagenTransSaldo = var.FPRImagenTransSaldo
            VarGic.EstadoFPRID = var.EstadoFPRID
            VarGic.FPRSubTotal = var.FPRSubTotal
            VarGic.FPRTotal = var.FPRTotal
            VarGic.UsuarioID = var.UsuarioID
            dc.GIC_FondoPorRendir.Add(VarGic)

            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As FondoPorRendir) As Boolean
        Try

            Dim cl2 As GIC_FondoPorRendir = dc.GIC_FondoPorRendir.Find(var)
            dc.GIC_FondoPorRendir.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
