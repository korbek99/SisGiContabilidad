Imports Entities
Public Class DALSubCuentasGradoSatisfaccion
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_SubCuentasGradoSatisfaccion

        Try

            Return dc.GIC_SubCuentasGradoSatisfaccion.FirstOrDefault(Function(o) o.SubCuentasGradoID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_SubCuentasGradoSatisfaccion)

        Try
            Return dc.GIC_SubCuentasGradoSatisfaccion.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_SubCuentasGradoSatisfaccion)

        Try
            Dim lists = From o In dc.GIC_SubCuentasGradoSatisfaccion Where o.SubCuentasGradoID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As SubCuentasGradoSatisfaccion) As Boolean

        Try

            Dim VarGic As New GIC_SubCuentasGradoSatisfaccion

            VarGic.SubCuentasGradoSatisfDescrip = var.SubCuentasGradoSatisfDescrip

            dc.GIC_SubCuentasGradoSatisfaccion.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As SubCuentasGradoSatisfaccion) As Boolean

        Try

            Dim VarGic As GIC_SubCuentasGradoSatisfaccion = dc.GIC_SubCuentasGradoSatisfaccion.Find(var)
            VarGic.SubCuentasGradoSatisfDescrip = var.SubCuentasGradoSatisfDescrip
            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As SubCuentasGradoSatisfaccion) As Boolean
        Try

            Dim cl2 As GIC_SubCuentasGradoSatisfaccion = dc.GIC_SubCuentasGradoSatisfaccion.Find(var)
            dc.GIC_SubCuentasGradoSatisfaccion.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
