Imports Entities
Public Class DALEstadosFondosPorRendir
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_EstadosFondoPorRendir

        Try

            Return dc.GIC_EstadosFondoPorRendir.FirstOrDefault(Function(o) o.EstadoFPRID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_EstadosFondoPorRendir)

        Try
            Return dc.GIC_EstadosFondoPorRendir.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_EstadosFondoPorRendir)

        Try
            Dim lists = From o In dc.GIC_EstadosFondoPorRendir Where o.EstadoFPRID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As FondosPorRendirEstados) As Boolean

        Try

            Dim VarGic As New GIC_EstadosFondoPorRendir

            VarGic.EstadosFondoPorRendir = var.EstadosFondoObservacion
            VarGic.EstadosFondoObservacion = var.EstadosFondoObservacion

            dc.GIC_EstadosFondoPorRendir.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As FondosPorRendirEstados) As Boolean

        Try

            Dim VarGic As GIC_EstadosFondoPorRendir = dc.GIC_EstadosFondoPorRendir.Find(var)
            VarGic.EstadosFondoPorRendir = var.EstadosFondoObservacion
            VarGic.EstadosFondoObservacion = var.EstadosFondoObservacion
            dc.GIC_EstadosFondoPorRendir.Add(VarGic)

            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As FondosPorRendirEstados) As Boolean
        Try

            Dim cl2 As GIC_EstadosFondoPorRendir = dc.GIC_EstadosFondoPorRendir.Find(var)
            dc.GIC_EstadosFondoPorRendir.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
