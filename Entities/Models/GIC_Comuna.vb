'------------------------------------------------------------------------------
' <auto-generated>
'    Este código se generó a partir de una plantilla.
'
'    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class GIC_Comuna
    Public Property ComunaID As Integer
    Public Property ProvinciaID As Integer
    Public Property ComunaNombre As String
    Public Property Activo As Nullable(Of Integer)

    Public Overridable Property GIC_Cliente As ICollection(Of GIC_Cliente) = New HashSet(Of GIC_Cliente)
    Public Overridable Property GIC_Provincia As GIC_Provincia
    Public Overridable Property GIC_FichaPersonal As ICollection(Of GIC_FichaPersonal) = New HashSet(Of GIC_FichaPersonal)
    Public Overridable Property GIC_Proveedor As ICollection(Of GIC_Proveedor) = New HashSet(Of GIC_Proveedor)

End Class
