Imports Entities
Public Class DALProveedorContactos
    Public dc As New GICont2015Entities2()
    Public Function GetById(id As Integer) As GIC_Proveedor_Contactos

        Try

            Return dc.GIC_Proveedor_Contactos.FirstOrDefault(Function(o) o.ProveContactoID.Equals(id))
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllActive() As List(Of GIC_Proveedor_Contactos)

        Try
            Return dc.GIC_Proveedor_Contactos.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function ListAllById(id As Integer) As List(Of GIC_Proveedor_Contactos)

        Try
            Dim lists = From o In dc.GIC_Proveedor_Contactos Where o.ProveContactoID = id
            Return lists.ToList()
        Catch ex As Exception
            Throw ex
        Finally
            dc.Database.Connection.Close()
            dc = Nothing
        End Try
    End Function
    Public Function AddData(var As ProveedorContactos) As Boolean

        Try

            Dim VarGic As New GIC_Proveedor_Contactos

            VarGic.ProveedorID = var.ProveedorID
            VarGic.ProveedorContacto = var.ProveedorContacto
            VarGic.ProveedorContactoCorreo = var.ProveedorContactoCorreo
            dc.GIC_Proveedor_Contactos.Add(VarGic)
            dc.SaveChanges()

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function ModData(var As ProveedorContactos) As Boolean

        Try

            Dim VarGic As GIC_Proveedor_Contactos = dc.GIC_Proveedor_Contactos.Find(var)

            VarGic.ProveedorID = var.ProveedorID
            VarGic.ProveedorContacto = var.ProveedorContacto
            VarGic.ProveedorContactoCorreo = var.ProveedorContactoCorreo
            dc.GIC_Proveedor_Contactos.Add(VarGic)

            dc.Entry(VarGic).State = System.Data.EntityState.Modified

            Return True
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return False
    End Function
    Public Function DeleteData(var As ProveedorContactos) As Boolean
        Try

            Dim cl2 As GIC_Proveedor_Contactos = dc.GIC_Proveedor_Contactos.Find(var)
            dc.GIC_Proveedor_Contactos.Remove(cl2)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        Finally

        End Try

    End Function
End Class
