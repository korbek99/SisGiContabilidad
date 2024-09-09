Imports Entities
Public Class DALPais
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_Pais

        Try

            Return dc.GIC_Pais.FirstOrDefault(Function(o) o.PaisID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_Pais)

        Try
            Return dc.GIC_Pais.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_Pais)

        Try
            Dim lists = From o In dc.GIC_Pais Where o.PaisID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As Pais) As Boolean

        Try

            Dim VarGic As New GIC_Pais

            VarGic.PaisNombre = var.PaisNombre

            dc.GIC_Pais.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As Pais) As Boolean

        Try

            Dim VarGic As GIC_Pais = dc.GIC_Pais.Find(var)
            VarGic.PaisNombre = var.PaisNombre
            dc.GIC_Pais.Add(VarGic)

            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As Pais) As Boolean
        Try

            Dim cl2 As GIC_Pais = dc.GIC_Pais.Find(var)
            dc.GIC_Pais.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
