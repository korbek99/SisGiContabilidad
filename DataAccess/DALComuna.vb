Imports Entities
Public Class DALComuna
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_Comuna

        Try

            Return dc.GIC_Comuna.FirstOrDefault(Function(o) o.ComunaID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_Comuna)
        Dim dc As New GICont2015Entities2()
        Try
            Return dc.GIC_Comuna.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_Comuna)
        Dim dc As New GICont2015Entities2()
        Try
            Dim lists = From o In dc.GIC_Comuna Where o.ComunaID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As Comuna) As Boolean

        Try
            Dim dc As New GICont2015Entities2()
            Dim VarGic As New GIC_Comuna

            VarGic.ComunaNombre = var.ComunaNombre
            VarGic.ProvinciaID = var.ProvinciaID
            VarGic.ComunaNombre = var.ComunaNombre
            VarGic.Activo = var.Activo
            dc.GIC_Comuna.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As Comuna) As Boolean

        Try
            Dim dc As New GICont2015Entities2()
            Dim VarGic As GIC_Comuna = dc.GIC_Comuna.Find(var)

            VarGic.ComunaNombre = var.ComunaNombre
            VarGic.ProvinciaID = var.ProvinciaID
            VarGic.ComunaNombre = var.ComunaNombre
            VarGic.Activo = var.Activo
            dc.GIC_Comuna.Add(VarGic)

            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As Comuna) As Boolean
        Try
            Dim dc As New GICont2015Entities2()
            Dim cl2 As GIC_Comuna = dc.GIC_Comuna.Find(var)
            dc.GIC_Comuna.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

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


End Class
