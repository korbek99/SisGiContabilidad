Imports Entities
Public Class DALClientes
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_Cliente

        Try

            Return dc.GIC_Cliente.FirstOrDefault(Function(o) o.ClienteID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_Cliente)

        Dim query As IQueryable(Of GIC_Cliente)
        Try


            Dim Strquery = (From C In dc.GIC_Cliente
                                Join Co In dc.GIC_Comuna On C.ComunaID Equals Co.ComunaID
                                Join Fo In dc.GIC_FormaDePago On C.FormaDePagoID Equals Fo.FormaDePagoID
                                Join Ti In dc.GIC_TipoEmpresa On C.TipoEmpID Equals Ti.TipoEmpID
                                Join Gi In dc.GIC_Giro On C.GiroID Equals Gi.GiroID
                                 Select New With _
                                    {
                                    C.ClienteID,
                                    C.ClienteDesc,
                                    C.ClienteRUT,
                                    C.ClienteDireccion,
                                    C.ComunaID,
                                    Co.ComunaNombre,
                                    C.CiudadID,
                                    C.ClienteContacto,
                                    C.GiroID,
                                    Gi.GiroNombre,
                                    C.ClienteTelefono,
                                    C.ClienteFax,
                                    C.ClienteCelular,
                                    C.ClienteCorreoElectronico,
                                    C.ClienteSitioWeb,
                                    C.ClienteApartadoPostal,
                                    C.Activo,
                                    C.ExcluirDeOportunidades,
                                    C.RegionID,
                                    C.FormaDePagoID,
                                    Fo.FormaDePagoDesc,
                                    C.Otros,
                                    C.Logo,
                                    C.TamanoEmpresa,
                                    C.TipoEmpID,
                                    Ti.TipoEmpresaNombre
                                    }).ToList()
            '.AsQueryable()
            ' query = Strquery
            ' Return query.ToList()

            'Return dc.GIC_Cliente.ToList()

        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_Cliente)
        Dim dc As New GICont2015Entities2()
        Try
            Dim lists = From o In dc.GIC_Cliente Where o.ClienteID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As Cliente) As Boolean

        Try
            Dim dc As New GICont2015Entities2()
            Dim varGic As New GIC_Cliente

            varGic.ClienteDesc = var.ClienteDesc
            varGic.ClienteRUT = var.ClienteRUT
            varGic.ClienteDireccion = var.ClienteDireccion
            varGic.ComunaID = var.ComunaID
            varGic.CiudadID = var.CiudadID
            varGic.ClienteContacto = var.ClienteContacto
            varGic.GiroID = var.GiroID
            varGic.ClienteTelefono =
            varGic.ClienteFax = var.ClienteFax
            varGic.ClienteCelular = var.ClienteCelular
            varGic.ClienteCorreoElectronico = var.ClienteCorreoElectronico
            varGic.ClienteSitioWeb = var.ClienteSitioWeb
            varGic.ClienteApartadoPostal = var.ClienteApartadoPostal
            varGic.Activo = var.Activo
            varGic.ExcluirDeOportunidades = var.ExcluirDeOportunidades
            varGic.RegionID = var.RegionID
            varGic.FormaDePagoID = var.FormaDePagoID
            varGic.Otros = var.Otros
            varGic.Logo = var.Logo
            varGic.TamanoEmpresa = var.TamanoEmpresa
            varGic.TipoEmpID = var.TipoEmpID
            dc.GIC_Cliente.Add(varGic)

            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As Cliente) As Boolean

        Try
            Dim dc As New GICont2015Entities2()
            Dim varGic As GIC_Cliente = dc.GIC_Cliente.Find(var)
            varGic.ClienteDesc = var.ClienteDesc
            varGic.ClienteRUT = var.ClienteRUT
            varGic.ClienteDireccion = var.ClienteDireccion
            varGic.ComunaID = var.ComunaID
            varGic.CiudadID = var.CiudadID
            varGic.ClienteContacto = var.ClienteContacto
            varGic.GiroID = var.GiroID
            varGic.ClienteTelefono =
            varGic.ClienteFax = var.ClienteFax
            varGic.ClienteCelular = var.ClienteCelular
            varGic.ClienteCorreoElectronico = var.ClienteCorreoElectronico
            varGic.ClienteSitioWeb = var.ClienteSitioWeb
            varGic.ClienteApartadoPostal = var.ClienteApartadoPostal
            varGic.Activo = var.Activo
            varGic.ExcluirDeOportunidades = var.ExcluirDeOportunidades
            varGic.RegionID = var.RegionID
            varGic.FormaDePagoID = var.FormaDePagoID
            varGic.Otros = var.Otros
            varGic.Logo = var.Logo
            varGic.TamanoEmpresa = var.TamanoEmpresa
            varGic.TipoEmpID = var.TipoEmpID
            dc.GIC_Cliente.Add(varGic)
            dc.Entry(varGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As Cliente) As Boolean
        Try
            Dim dc As New GICont2015Entities2()
            Dim cl2 As GIC_Cliente = dc.GIC_Cliente.Find(var)
            dc.GIC_Cliente.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
    Public Function ListData() As DataSet
        Dim Dst As DataSet

        Try

        Catch ex As Exception
            Throw ex
        Finally

        End Try


        Return Dst
    End Function

    Public Function ListDataById() As DataSet
        Dim Dst As DataSet
        Try

        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return Dst
    End Function


End Class
