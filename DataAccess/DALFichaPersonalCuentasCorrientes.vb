Imports Entities
Public Class DALFichaPersonalCuentasCorrientes
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_FichaPersonal_CuentasCorrientes

        Try

            Return dc.GIC_FichaPersonal_CuentasCorrientes.FirstOrDefault(Function(o) o.PersonalCuCoID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_FichaPersonal_CuentasCorrientes)

        Try
            Return dc.GIC_FichaPersonal_CuentasCorrientes.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_FichaPersonal_CuentasCorrientes)

        Try
            Dim lists = From o In dc.GIC_FichaPersonal_CuentasCorrientes Where o.PersonalCuCoID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As FichaPersonalCuentasCorrientes) As Boolean

        Try

            Dim VarGic As New GIC_FichaPersonal_CuentasCorrientes

            VarGic.FichaPersonalID = var.FichaPersonalID
            VarGic.BancoID = var.BancoID
            VarGic.PersonalCuentasCorrientes = var.PersonalCuentasCorrientes
            dc.GIC_FichaPersonal_CuentasCorrientes.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As FichaPersonalCuentasCorrientes) As Boolean

        Try

            Dim VarGic As GIC_FichaPersonal_CuentasCorrientes = dc.GIC_FichaPersonal_CuentasCorrientes.Find(var)
            VarGic.FichaPersonalID = var.FichaPersonalID
            VarGic.BancoID = var.BancoID
            VarGic.PersonalCuentasCorrientes = var.PersonalCuentasCorrientes
            dc.GIC_FichaPersonal_CuentasCorrientes.Add(VarGic)

            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As FichaPersonalCuentasCorrientes) As Boolean
        Try

            Dim cl2 As GIC_FichaPersonal_CuentasCorrientes = dc.GIC_FichaPersonal_CuentasCorrientes.Find(var)
            dc.GIC_FichaPersonal_CuentasCorrientes.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function



End Class
