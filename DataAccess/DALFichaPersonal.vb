Imports Entities
Public Class DALFichaPersonal
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_FichaPersonal

        Try

            Return dc.GIC_FichaPersonal.FirstOrDefault(Function(o) o.FichaPersonalID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_FichaPersonal)

        Try
            Return dc.GIC_FichaPersonal.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_FichaPersonal)

        Try
            Dim lists = From o In dc.GIC_FichaPersonal Where o.FichaPersonalID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function

    Public Function AddData(var As FichaPersonal) As Boolean

        Try

            Dim VarGic As New GIC_FichaPersonal

            VarGic.FichaPersonalNombre = var.FichaPersonalNombre
            VarGic.FichaPersonalRUT = var.FichaPersonalRUT
            VarGic.FichaPersonalFechaNac = var.FichaPersonalFechaNac
            VarGic.FichaPersonalEdad = var.FichaPersonalEdad
            VarGic.FichaPersonalEstCivil = var.FichaPersonalEstCivil
            VarGic.FichaPersonalNacionalidad = var.FichaPersonalNacionalidad
            VarGic.FichaPersonalDireccion = var.FichaPersonalDireccion
            VarGic.ComunaID = var.ComunaID
            VarGic.CiudadID = var.CiudadID
            VarGic.FichaPersonalEstudios = var.FichaPersonalEstudios
            VarGic.FichaPersonalTelefono = var.FichaPersonalTelefono
            VarGic.FichaPersonalCelular = var.FichaPersonalCelular
            VarGic.FichaPersonalTelEmerg = var.FichaPersonalTelEmerg
            VarGic.FichaPersonalCorreo = var.FichaPersonalCorreo
            VarGic.FichaPersonalLicencia = var.FichaPersonalLicencia
            VarGic.AfpID = var.AfpID
            VarGic.Costizacion = var.Costizacion
            VarGic.SaludID = var.SaludID
            VarGic.CostoIsapre = var.CostoIsapre
            VarGic.BancoID = var.BancoID
            VarGic.FichaPersonalCuentaCorriente = var.FichaPersonalCuentaCorriente
            VarGic.FichaPersonalRecomendado = var.FichaPersonalRecomendado
            VarGic.Otros = var.Otros
            VarGic.FechaInicioContrato = var.FechaInicioContrato
            VarGic.FechaFinContrato = var.FechaFinContrato
            VarGic.AreaTrabID = var.AreaTrabID
            VarGic.Activo = var.Activo
            VarGic.FechaIngreso = var.FechaIngreso
            VarGic.SueldoBase = var.SueldoBase
            VarGic.Colacion = var.Colacion
            VarGic.Prestamos = var.Prestamos
            VarGic.Anticipos = var.Anticipos
            VarGic.APV = var.APV
            VarGic.AhorroVoluntario = var.AhorroVoluntario
            VarGic.Beneficios = var.Beneficios
            VarGic.FotoPersonal = var.FotoPersonal
            VarGic.RutPersonal = var.RutPersonal
            VarGic.FirmaPersonal = var.FirmaPersonal
            dc.GIC_FichaPersonal.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As FichaPersonal) As Boolean

        Try

            Dim VarGic As GIC_FichaPersonal = dc.GIC_FichaPersonal.Find(var)

            VarGic.FichaPersonalNombre = var.FichaPersonalNombre
            VarGic.FichaPersonalRUT = var.FichaPersonalRUT
            VarGic.FichaPersonalFechaNac = var.FichaPersonalFechaNac
            VarGic.FichaPersonalEdad = var.FichaPersonalEdad
            VarGic.FichaPersonalEstCivil = var.FichaPersonalEstCivil
            VarGic.FichaPersonalNacionalidad = var.FichaPersonalNacionalidad
            VarGic.FichaPersonalDireccion = var.FichaPersonalDireccion
            VarGic.ComunaID = var.ComunaID
            VarGic.CiudadID = var.CiudadID
            VarGic.FichaPersonalEstudios = var.FichaPersonalEstudios
            VarGic.FichaPersonalTelefono = var.FichaPersonalTelefono
            VarGic.FichaPersonalCelular = var.FichaPersonalCelular
            VarGic.FichaPersonalTelEmerg = var.FichaPersonalTelEmerg
            VarGic.FichaPersonalCorreo = var.FichaPersonalCorreo
            VarGic.FichaPersonalLicencia = var.FichaPersonalLicencia
            VarGic.AfpID = var.AfpID
            VarGic.Costizacion = var.Costizacion
            VarGic.SaludID = var.SaludID
            VarGic.CostoIsapre = var.CostoIsapre
            VarGic.BancoID = var.BancoID
            VarGic.FichaPersonalCuentaCorriente = var.FichaPersonalCuentaCorriente
            VarGic.FichaPersonalRecomendado = var.FichaPersonalRecomendado
            VarGic.Otros = var.Otros
            VarGic.FechaInicioContrato = var.FechaInicioContrato
            VarGic.FechaFinContrato = var.FechaFinContrato
            VarGic.AreaTrabID = var.AreaTrabID
            VarGic.Activo = var.Activo
            VarGic.FechaIngreso = var.FechaIngreso
            VarGic.SueldoBase = var.SueldoBase
            VarGic.Colacion = var.Colacion
            VarGic.Prestamos = var.Prestamos
            VarGic.Anticipos = var.Anticipos
            VarGic.APV = var.APV
            VarGic.AhorroVoluntario = var.AhorroVoluntario
            VarGic.Beneficios = var.Beneficios
            VarGic.FotoPersonal = var.FotoPersonal
            VarGic.RutPersonal = var.RutPersonal
            VarGic.FirmaPersonal = var.FirmaPersonal
            dc.GIC_FichaPersonal.Add(VarGic)
            dc.GIC_FichaPersonal.Add(VarGic)

            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As FichaPersonal) As Boolean
        Try

            Dim cl2 As GIC_FichaPersonal = dc.GIC_FichaPersonal.Find(var)
            dc.GIC_FichaPersonal.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
