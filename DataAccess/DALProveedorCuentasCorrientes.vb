Imports Entities
Public Class DALProveedorCuentasCorrientes
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_Proveedor_CuentasCorrientes

        Try

            Return dc.GIC_Proveedor_CuentasCorrientes.FirstOrDefault(Function(o) o.ProveCuCoID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_Proveedor_CuentasCorrientes)

        Try
            Return dc.GIC_Proveedor_CuentasCorrientes.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_Proveedor_CuentasCorrientes)

        Try
            Dim lists = From o In dc.GIC_Proveedor_CuentasCorrientes Where o.ProveCuCoID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As ProveedorCuentasCorrientes) As Boolean

        Try

            Dim VarGic As New GIC_Proveedor_CuentasCorrientes


            VarGic.ProveCuCoID = var.ProveCuCoID
            VarGic.ProveedorID = var.ProveedorID
            VarGic.BancoID = var.BancoID
            VarGic.ProveedorCuentasCorrientes = var.ProveedorCuentasCorrientes
            dc.GIC_Proveedor_CuentasCorrientes.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As ProveedorCuentasCorrientes) As Boolean

        Try

            Dim VarGic As GIC_Proveedor_CuentasCorrientes = dc.GIC_Proveedor_CuentasCorrientes.Find(var)

            VarGic.ProveCuCoID = var.ProveCuCoID
            VarGic.ProveedorID = var.ProveedorID
            VarGic.BancoID = var.BancoID
            VarGic.ProveedorCuentasCorrientes = var.ProveedorCuentasCorrientes
            dc.GIC_Proveedor_CuentasCorrientes.Add(VarGic)

            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As ProveedorCuentasCorrientes) As Boolean
        Try

            Dim cl2 As GIC_Proveedor_CuentasCorrientes = dc.GIC_Proveedor_CuentasCorrientes.Find(var)
            dc.GIC_Proveedor_CuentasCorrientes.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
