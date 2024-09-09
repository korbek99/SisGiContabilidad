Imports Entities
Public Class DALAreaTrabajo
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_AreaTrabajo

        Try

            Return dc.GIC_AreaTrabajo.FirstOrDefault(Function(o) o.AreaTrabID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_AreaTrabajo)

        Try
            Return dc.GIC_AreaTrabajo.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_AreaTrabajo)

        Try
            Dim lists = From o In dc.GIC_AreaTrabajo Where o.AreaTrabID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
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

    Public Function AddData(var As AreaTrabajo) As Boolean

        Try

            Dim AreaTrab As New GIC_AreaTrabajo

            AreaTrab.AreaTrabNombre = var.AreaTrabNombre
            AreaTrab.Activo = var.Activo
            dc.GIC_AreaTrabajo.Add(AreaTrab)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As AreaTrabajo) As Boolean

        Try

            Dim AreaTrab As GIC_AreaTrabajo = dc.GIC_AreaTrabajo.Find(var)

            AreaTrab.AreaTrabNombre = var.AreaTrabNombre
            AreaTrab.Activo = var.Activo
            dc.Entry(AreaTrab).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As AreaTrabajo) As Boolean
        Try

            Dim cl2 As GIC_AreaTrabajo = dc.GIC_AreaTrabajo.Find(var)
            dc.GIC_AreaTrabajo.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
