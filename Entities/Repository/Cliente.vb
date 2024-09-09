
Imports System
Imports System.Collections.Generic

Public Class Cliente
    Private m_ClienteID As Integer
    Private m_ClienteDireccion As [String]
    Private m_ClienteRUT As [String]
    Private m_ClienteDesc As [String]
    Private m_ComunaID As Integer
    Private m_CiudadID As Integer
    Private m_ClienteContacto As [String]
    Private m_GiroID As Integer
    Private m_ClienteTelefono As [String]
    Private m_ClienteFax As [String]
    Private m_ClienteCelular As [String]
    Private m_ClienteCorreoElectronico As [String]
    Private m_ClienteSitioWeb As [String]
    Private m_ClienteApartadoPostal As [String]
    Private m_Activo As Integer
    Private m_ExcluirDeOportunidades As Integer
    Private m_RegionID As Integer
    Private m_FormaDePagoID As Integer
    Private m_Otros As [String]
    Private m_Logo As Byte()
    Private m_TamanoEmpresa As Integer
    Private m_TipoEmpID As Integer


    Public Property ClienteID() As Integer
        Get
            Return m_ClienteID
        End Get
        Set(value As Integer)
            m_ClienteID = Value
        End Set
    End Property

    Public Property ClienteDesc() As [String]
        Get
            Return m_ClienteDesc
        End Get
        Set(value As [String])
            m_ClienteDesc = Value
        End Set
    End Property

    Public Property ClienteRUT() As [String]
        Get
            Return m_ClienteRUT
        End Get
        Set(value As [String])
            m_ClienteRUT = Value
        End Set
    End Property

    Public Property ClienteDireccion() As [String]
        Get
            Return m_ClienteDireccion
        End Get
        Set(value As [String])
            m_ClienteDireccion = Value
        End Set
    End Property

    Public Property ComunaID() As Integer
        Get
            Return m_ComunaID
        End Get
        Set(value As Integer)
            m_ComunaID = Value
        End Set
    End Property
   

    Public Property CiudadID() As Integer
        Get
            Return m_CiudadID
        End Get
        Set(value As Integer)
            m_CiudadID = Value
        End Set
    End Property

    Public Property ClienteContacto() As [String]
        Get
            Return m_ClienteContacto
        End Get
        Set(value As [String])
            m_ClienteContacto = Value
        End Set
    End Property

    Public Property GiroID() As Integer
        Get
            Return m_GiroID
        End Get
        Set(value As Integer)
            m_GiroID = Value
        End Set
    End Property

    Public Property ClienteTelefono() As [String]
        Get
            Return m_ClienteTelefono
        End Get
        Set(value As [String])
            m_ClienteTelefono = Value
        End Set
    End Property

    Public Property ClienteFax() As [String]
        Get
            Return m_ClienteFax
        End Get
        Set(value As [String])
            m_ClienteFax = Value
        End Set
    End Property
    



    Public Property ClienteCelular() As [String]
        Get
            Return m_ClienteCelular
        End Get
        Set(value As [String])
            m_ClienteCelular = Value
        End Set
    End Property

    Public Property ClienteCorreoElectronico() As [String]
        Get
            Return m_ClienteCorreoElectronico
        End Get
        Set(value As [String])
            m_ClienteCorreoElectronico = Value
        End Set
    End Property

    Public Property ClienteSitioWeb() As [String]
        Get
            Return m_ClienteSitioWeb
        End Get
        Set(value As [String])
            m_ClienteSitioWeb = Value
        End Set
    End Property

    Public Property ClienteApartadoPostal() As [String]
        Get
            Return m_ClienteApartadoPostal
        End Get
        Set(value As [String])
            m_ClienteApartadoPostal = Value
        End Set
    End Property

    Public Property Activo() As Integer
        Get
            Return m_Activo
        End Get
        Set(value As Integer)
            m_Activo = Value
        End Set
    End Property
  

    Public Property ExcluirDeOportunidades() As Integer
        Get
            Return m_ExcluirDeOportunidades
        End Get
        Set(value As Integer)
            m_ExcluirDeOportunidades = Value
        End Set
    End Property

    Public Property RegionID() As Integer
        Get
            Return m_RegionID
        End Get
        Set(value As Integer)
            m_RegionID = Value
        End Set
    End Property

    Public Property FormaDePagoID() As Integer
        Get
            Return m_FormaDePagoID
        End Get
        Set(value As Integer)
            m_FormaDePagoID = Value
        End Set
    End Property

    Public Property Otros() As [String]
        Get
            Return m_Otros
        End Get
        Set(value As [String])
            m_Otros = Value
        End Set
    End Property

    Public Property Logo() As Byte()
        Get
            Return m_Logo
        End Get
        Set(value As Byte())
            m_Logo = Value
        End Set
    End Property

    Public Property TamanoEmpresa() As Integer
        Get
            Return m_TamanoEmpresa
        End Get
        Set(value As Integer)
            m_TamanoEmpresa = Value
        End Set
    End Property

    Public Property TipoEmpID() As Integer
        Get
            Return m_TipoEmpID
        End Get
        Set(value As Integer)
            m_TipoEmpID = Value
        End Set
    End Property

    


End Class
