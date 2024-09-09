Imports Entities
Public Class DALGiro
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_Giro

        Try

            Return dc.GIC_Giro.FirstOrDefault(Function(o) o.GiroID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_Giro)

        Try
            Return dc.GIC_Giro.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_Giro)

        Try
            Dim lists = From o In dc.GIC_Giro Where o.GiroID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As Giro) As Boolean

        Try

            Dim VarGic As New GIC_Giro

            VarGic.GiroNombre = var.GiroNombre
            VarGic.Activo = var.Activo
            dc.GIC_Giro.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As Giro) As Boolean

        Try

            Dim VarGic As GIC_Giro = dc.GIC_Giro.Find(var)
            VarGic.GiroNombre = var.GiroNombre
            VarGic.Activo = var.Activo
            dc.GIC_Giro.Add(VarGic)

            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As Giro) As Boolean
        Try

            Dim cl2 As GIC_Giro = dc.GIC_Giro.Find(var)
            dc.GIC_Giro.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
