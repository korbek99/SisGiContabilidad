Imports Entities


Public Class DALBanco
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_Banco

        Try

            Return dc.GIC_Banco.FirstOrDefault(Function(o) o.BancoID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_Banco)

        Try
            Return dc.GIC_Banco.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_Banco)

        Try
            Dim lists = From o In dc.GIC_Banco Where o.BancoID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As Banco) As Boolean

        Try

            Dim VarGic As New GIC_Banco

            VarGic.BancoNombre = var.BancoNombre
            VarGic.Activo = var.Activo
            dc.GIC_Banco.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As Banco) As Boolean

        Try

            Dim VarGic As GIC_Banco = dc.GIC_Banco.Find(var)
            VarGic.BancoNombre = var.BancoNombre
            VarGic.Activo = var.Activo
            dc.GIC_Banco.Add(VarGic)

            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As Banco) As Boolean
        Try

            Dim cl2 As GIC_Banco = dc.GIC_Banco.Find(var)
            dc.GIC_Banco.Remove(cl2)

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

    Public Function ListDataById(Var As Banco) As DataSet
        Dim Dst As DataSet

        Try

        Catch ex As Exception
            Throw ex
        Finally

        End Try
        Return Dst
    End Function

   
End Class
