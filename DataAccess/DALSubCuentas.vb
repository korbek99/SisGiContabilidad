Imports Entities
Public Class DALSubCuentas
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_SubCuentas

        Try

            Return dc.GIC_SubCuentas.FirstOrDefault(Function(o) o.SubCuentaID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_SubCuentas)

        Try
            Return dc.GIC_SubCuentas.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_SubCuentas)

        Try
            Dim lists = From o In dc.GIC_SubCuentas Where o.SubCuentaID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As SubCuentas) As Boolean

        Try

            Dim VarGic As New GIC_SubCuentas

            VarGic.CuentaContaID = var.CuentaContaID
            VarGic.SubCuentaNumero = var.SubCuentaNumero
            VarGic.SubCuentaNombre = var.SubCuentaNombre
            VarGic.SubCuentaDescripcion = var.SubCuentaDescripcion
            VarGic.SubCuentaFechaIng = var.SubCuentaFechaIng
            VarGic.ClienteID = var.ClienteID
            VarGic.SubCuentaOfertaRefID = var.SubCuentaOfertaRefID
            VarGic.SubCuentaEstado = var.SubCuentaEstado
            VarGic.SubCuentasGradoID = var.SubCuentasGradoID
            VarGic.UsuarioID = var.UsuarioID
            'VarGic.Activo = var.Activo
            dc.GIC_SubCuentas.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As SubCuentas) As Boolean

        Try

            Dim VarGic As GIC_SubCuentas = dc.GIC_SubCuentas.Find(var)
            VarGic.CuentaContaID = var.CuentaContaID
            VarGic.SubCuentaNumero = var.SubCuentaNumero
            VarGic.SubCuentaNombre = var.SubCuentaNombre
            VarGic.SubCuentaDescripcion = var.SubCuentaDescripcion
            VarGic.SubCuentaFechaIng = var.SubCuentaFechaIng
            VarGic.ClienteID = var.ClienteID
            VarGic.SubCuentaOfertaRefID = var.SubCuentaOfertaRefID
            VarGic.SubCuentaEstado = var.SubCuentaEstado
            VarGic.SubCuentasGradoID = var.SubCuentasGradoID
            VarGic.UsuarioID = var.UsuarioID
            'VarGic.Activo = var.Activo
            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As SubCuentas) As Boolean
        Try

            Dim cl2 As GIC_SubCuentas = dc.GIC_SubCuentas.Find(var)
            dc.GIC_SubCuentas.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
