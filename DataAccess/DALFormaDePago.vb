Imports Entities
Public Class DALFormaDePago
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_FormaDePago

        Try

            Return dc.GIC_FormaDePago.FirstOrDefault(Function(o) o.FormaDePagoID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_FormaDePago)

        Try
            Return dc.GIC_FormaDePago.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_FormaDePago)

        Try
            Dim lists = From o In dc.GIC_FormaDePago Where o.FormaDePagoID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As FormaDePago) As Boolean

        Try

            Dim VarGic As New GIC_FormaDePago

            VarGic.FormaDePagoDesc = var.FormaDePagoDesc
            VarGic.Activo = var.Activo
            dc.GIC_FormaDePago.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As FormaDePago) As Boolean

        Try

            Dim VarGic As GIC_FormaDePago = dc.GIC_FormaDePago.Find(var)
            VarGic.FormaDePagoDesc = var.FormaDePagoDesc
            VarGic.Activo = var.Activo
            dc.GIC_FormaDePago.Add(VarGic)

            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As FormaDePago) As Boolean
        Try

            Dim cl2 As GIC_FormaDePago = dc.GIC_FormaDePago.Find(var)
            dc.GIC_FormaDePago.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
