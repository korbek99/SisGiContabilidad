Imports Entities
Public Class DALFormaPagoProveedor
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_FormaDePagoProveedor

        Try

            Return dc.GIC_FormaDePagoProveedor.FirstOrDefault(Function(o) o.FormaDePagoProvID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_FormaDePagoProveedor)

        Try
            Return dc.GIC_FormaDePagoProveedor.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_FormaDePagoProveedor)

        Try
            Dim lists = From o In dc.GIC_FormaDePagoProveedor Where o.FormaDePagoProvID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As FormaDePagoProveedor) As Boolean

        Try

            Dim VarGic As New GIC_FormaDePagoProveedor

            VarGic.FormaDePagoDesc = var.FormaDePagoDesc
            VarGic.Activo = var.Activo
            dc.GIC_FormaDePagoProveedor.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As FormaDePagoProveedor) As Boolean

        Try

            Dim VarGic As GIC_FormaDePagoProveedor = dc.GIC_FormaDePagoProveedor.Find(var)
            VarGic.FormaDePagoDesc = var.FormaDePagoDesc
            VarGic.Activo = var.Activo
            dc.GIC_FormaDePagoProveedor.Add(VarGic)

            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As FormaDePagoProveedor) As Boolean
        Try

            Dim cl2 As GIC_FormaDePagoProveedor = dc.GIC_FormaDePagoProveedor.Find(var)
            dc.GIC_FormaDePagoProveedor.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
