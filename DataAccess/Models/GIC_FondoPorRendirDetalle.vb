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

Partial Public Class GIC_FondoPorRendirDetalle
    Public Property FPRDetalleID As Integer
    Public Property FPRID As Integer
    Public Property FPRFechaIngresoDetalle As Nullable(Of Date)
    Public Property FPRDescripcionDetalle As String
    Public Property FPRNumeroDocumento As Integer
    Public Property FPRTareasID As Integer
    Public Property Tasa As Decimal
    Public Property Total As Decimal

    Public Overridable Property GIC_FondoPorRendir As GIC_FondoPorRendir
    Public Overridable Property GIC_FondoPorRendirTareas As GIC_FondoPorRendirTareas

End Class
