Imports Entities
Public Class DALProveedor
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_Proveedor

        Try

            Return dc.GIC_Proveedor.FirstOrDefault(Function(o) o.ProveedorID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_Proveedor)

        Try
            Return dc.GIC_Proveedor.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_Proveedor)

        Try
            Dim lists = From o In dc.GIC_Proveedor Where o.BancoID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As Proveedor) As Boolean

        Try

            Dim VarGic As New GIC_Proveedor

            VarGic.ProveedorDesc = var.ProveedorDesc
            VarGic.ProveedorRUT = var.ProveedorRUT
            VarGic.ProveedorDireccion = var.ProveedorDireccion
            VarGic.ComunaID = var.ComunaID
            VarGic.CiudadID = var.CiudadID
            VarGic.ProveedorContacto = var.ProveedorContacto
            VarGic.GiroID = var.GiroID
            VarGic.ProveedorTelefono = var.ProveedorTelefono
            VarGic.ProveedorFax = var.ProveedorFax
            VarGic.ProveedorCelular = var.ProveedorCelular
            VarGic.ProveedorCorreoElectronico = var.ProveedorCorreoElectronico
            VarGic.ProveedorSitioWeb = var.ProveedorSitioWeb
            VarGic.ProveedorApartadoPostal = var.ProveedorApartadoPostal
            VarGic.Otros = var.Otros
            VarGic.TipoProveID = var.TipoProveID
            VarGic.Logo = var.Logo
            VarGic.BancoID = var.BancoID
            VarGic.ProveedorCuenCorriente = var.ProveedorCuenCorriente
            VarGic.ProveedorContactos = var.ProveedorContactos
            VarGic.Activo = var.Activo
            VarGic.RegionID = var.RegionID
            VarGic.FormaDePagoProvID = var.FormaDePagoProvID
            dc.GIC_Proveedor.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As Proveedor) As Boolean

        Try

            Dim VarGic As GIC_Proveedor = dc.GIC_Proveedor.Find(var)
            VarGic.ProveedorDesc = var.ProveedorDesc
            VarGic.ProveedorRUT = var.ProveedorRUT
            VarGic.ProveedorDireccion = var.ProveedorDireccion
            VarGic.ComunaID = var.ComunaID
            VarGic.CiudadID = var.CiudadID
            VarGic.ProveedorContacto = var.ProveedorContacto
            VarGic.GiroID = var.GiroID
            VarGic.ProveedorTelefono = var.ProveedorTelefono
            VarGic.ProveedorFax = var.ProveedorFax
            VarGic.ProveedorCelular = var.ProveedorCelular
            VarGic.ProveedorCorreoElectronico = var.ProveedorCorreoElectronico
            VarGic.ProveedorSitioWeb = var.ProveedorSitioWeb
            VarGic.ProveedorApartadoPostal = var.ProveedorApartadoPostal
            VarGic.Otros = var.Otros
            VarGic.TipoProveID = var.TipoProveID
            VarGic.Logo = var.Logo
            VarGic.BancoID = var.BancoID
            VarGic.ProveedorCuenCorriente = var.ProveedorCuenCorriente
            VarGic.ProveedorContactos = var.ProveedorContactos
            VarGic.Activo = var.Activo
            VarGic.RegionID = var.RegionID
            VarGic.FormaDePagoProvID = var.FormaDePagoProvID

            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As Proveedor) As Boolean
        Try

            Dim cl2 As GIC_Proveedor = dc.GIC_Proveedor.Find(var)
            dc.GIC_Proveedor.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
