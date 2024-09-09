Imports Entities
Public Class DALFondoPorRendirTareas
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_FondoPorRendirTareas

        Try

            Return dc.GIC_FondoPorRendirTareas.FirstOrDefault(Function(o) o.FPRTareasID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_FondoPorRendirTareas)

        Try
            Return dc.GIC_FondoPorRendirTareas.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_FondoPorRendirTareas)

        Try
            Dim lists = From o In dc.GIC_FondoPorRendirTareas Where o.FPRTareasID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As FondoPorRendirTareas) As Boolean

        Try

            Dim VarGic As New GIC_FondoPorRendirTareas

            VarGic.FPRTareasDescripcion = var.FPRTareasDescripcion

            dc.GIC_FondoPorRendirTareas.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As FondoPorRendirTareas) As Boolean

        Try

            Dim VarGic As GIC_FondoPorRendirTareas = dc.GIC_FondoPorRendirTareas.Find(var)

            VarGic.FPRTareasDescripcion = var.FPRTareasDescripcion
            dc.GIC_FondoPorRendirTareas.Add(VarGic)

            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As FondoPorRendirTareas) As Boolean
        Try

            Dim cl2 As GIC_FondoPorRendirTareas = dc.GIC_FondoPorRendirTareas.Find(var)
            dc.GIC_FondoPorRendirTareas.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
