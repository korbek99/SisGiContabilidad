Imports Entities
Public Class DALSalud
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_Salud

        Try

            Return dc.GIC_Salud.FirstOrDefault(Function(o) o.SaludID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_Salud)

        Try
            Return dc.GIC_Salud.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_Salud)

        Try
            Dim lists = From o In dc.GIC_Salud Where o.SaludID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As Salud) As Boolean

        Try

            Dim VarGic As New GIC_Salud

            VarGic.SaludNombre = var.SaludNombre
            VarGic.Activo = var.Activo
            dc.GIC_Salud.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As Salud) As Boolean

        Try

            Dim VarGic As GIC_Salud = dc.GIC_Salud.Find(var)
            VarGic.SaludNombre = var.SaludNombre
            VarGic.Activo = var.Activo
            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As Salud) As Boolean
        Try

            Dim cl2 As GIC_Salud = dc.GIC_Salud.Find(var)
            dc.GIC_Salud.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
