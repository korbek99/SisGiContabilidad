Imports Entities

Public Class DALCuentaContable

    Public dc As New GICont2015Entities2()

    Public Function GetById(id As Integer) As GIC_CuentasContable

        Try

            Return dc.GIC_CuentasContable.FirstOrDefault(Function(o) o.CuentaContaID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_CuentasContable)

        Try
            Return dc.GIC_CuentasContable.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_CuentasContable)

        Try
            Dim lists = From o In dc.GIC_CuentasContable Where o.CuentaContaID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As CuentaContable) As Boolean

        Try

            Dim VarGic As New GIC_CuentasContable

            VarGic.CuentaContaDescripcion = var.CuentaContaDescripcion
            VarGic.Activo = var.Activo
            dc.GIC_CuentasContable.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As CuentaContable) As Boolean

        Try

            Dim VarGic As GIC_CuentasContable = dc.GIC_CuentasContable.Find(var)
            VarGic.CuentaContaDescripcion = var.CuentaContaDescripcion
            VarGic.Activo = var.Activo
            dc.GIC_CuentasContable.Add(VarGic)

            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As CuentaContable) As Boolean
        Try

            Dim cl2 As GIC_CuentasContable = dc.GIC_CuentasContable.Find(var)
            dc.GIC_CuentasContable.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
