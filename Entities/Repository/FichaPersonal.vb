Public Class FichaPersonal
    Private m_FichaPersonalID As Integer
    Private m_FichaPersonalNombre As [String]
    Private m_FichaPersonalRUT As [String]
    Private m_FichaPersonalFechaNac As Date



    Public Property FichaPersonalID() As Integer
        Get
            Return m_FichaPersonalID
        End Get
        Set(value As Integer)
            m_FichaPersonalID = value
        End Set
    End Property

    Public Property FichaPersonalNombre() As [String]
        Get
            Return m_FichaPersonalNombre
        End Get
        Set(value As [String])
            m_FichaPersonalNombre = value
        End Set
    End Property

    Public Property FichaPersonalRUT() As [String]
        Get
            Return m_FichaPersonalRUT
        End Get
        Set(value As [String])
            m_FichaPersonalRUT = value
        End Set
    End Property

    Public Property FichaPersonalFechaNac() As Date
        Get
            Return m_FichaPersonalFechaNac
        End Get
        Set(value As Date)
            m_FichaPersonalFechaNac = value
        End Set
    End Property

    Public Property FichaPersonalEdad() As Integer
        Get
            Return m_FichaPersonalEdad
        End Get
        Set(value As Integer)
            m_FichaPersonalEdad = value
        End Set
    End Property
    Private m_FichaPersonalEdad As Integer
    Public Property FichaPersonalEstCivil() As Integer
        Get
            Return m_FichaPersonalEstCivil
        End Get
        Set(value As Integer)
            m_FichaPersonalEstCivil = value
        End Set
    End Property
    Private m_FichaPersonalEstCivil As Integer
    Public Property FichaPersonalNacionalidad() As [String]
        Get
            Return m_FichaPersonalNacionalidad
        End Get
        Set(value As [String])
            m_FichaPersonalNacionalidad = value
        End Set
    End Property
    Private m_FichaPersonalNacionalidad As [String]
    Public Property FichaPersonalDireccion() As [String]
        Get
            Return m_FichaPersonalDireccion
        End Get
        Set(value As [String])
            m_FichaPersonalDireccion = value
        End Set
    End Property
    Private m_FichaPersonalDireccion As [String]
    Public Property ComunaID() As Integer
        Get
            Return m_ComunaID
        End Get
        Set(value As Integer)
            m_ComunaID = value
        End Set
    End Property
    Private m_ComunaID As Integer
    Public Property CiudadID() As Integer
        Get
            Return m_CiudadID
        End Get
        Set(value As Integer)
            m_CiudadID = value
        End Set
    End Property
    Private m_CiudadID As Integer
    Public Property FichaPersonalEstudios() As [String]
        Get
            Return m_FichaPersonalEstudios
        End Get
        Set(value As [String])
            m_FichaPersonalEstudios = value
        End Set
    End Property
    Private m_FichaPersonalEstudios As [String]
    Public Property FichaPersonalTelefono() As [String]
        Get
            Return m_FichaPersonalTelefono
        End Get
        Set(value As [String])
            m_FichaPersonalTelefono = value
        End Set
    End Property
    Private m_FichaPersonalTelefono As [String]
    Public Property FichaPersonalCelular() As [String]
        Get
            Return m_FichaPersonalCelular
        End Get
        Set(value As [String])
            m_FichaPersonalCelular = value
        End Set
    End Property
    Private m_FichaPersonalCelular As [String]
    Public Property FichaPersonalTelEmerg() As [String]
        Get
            Return m_FichaPersonalTelEmerg
        End Get
        Set(value As [String])
            m_FichaPersonalTelEmerg = value
        End Set
    End Property
    Private m_FichaPersonalTelEmerg As [String]
    Public Property FichaPersonalCorreo() As [String]
        Get
            Return m_FichaPersonalCorreo
        End Get
        Set(value As [String])
            m_FichaPersonalCorreo = value
        End Set
    End Property
    Private m_FichaPersonalCorreo As [String]
    Public Property FichaPersonalLicencia() As Integer
        Get
            Return m_FichaPersonalLicencia
        End Get
        Set(value As Integer)
            m_FichaPersonalLicencia = value
        End Set
    End Property
    Private m_FichaPersonalLicencia As Integer
    Public Property AfpID() As Integer
        Get
            Return m_AfpID
        End Get
        Set(value As Integer)
            m_AfpID = value
        End Set
    End Property
    Private m_AfpID As Integer
    Public Property Costizacion() As Integer
        Get
            Return m_Costizacion
        End Get
        Set(value As Integer)
            m_Costizacion = value
        End Set
    End Property
    Private m_Costizacion As Integer
    Public Property SaludID() As Integer
        Get
            Return m_SaludID
        End Get
        Set(value As Integer)
            m_SaludID = value
        End Set
    End Property
    Private m_SaludID As Integer
    Public Property CostoIsapre() As Integer
        Get
            Return m_CostoIsapre
        End Get
        Set(value As Integer)
            m_CostoIsapre = value
        End Set
    End Property
    Private m_CostoIsapre As Integer
    Public Property BancoID() As Integer
        Get
            Return m_BancoID
        End Get
        Set(value As Integer)
            m_BancoID = value
        End Set
    End Property
    Private m_BancoID As Integer
    Public Property FichaPersonalCuentaCorriente() As [String]
        Get
            Return m_FichaPersonalCuentaCorriente
        End Get
        Set(value As [String])
            m_FichaPersonalCuentaCorriente = value
        End Set
    End Property
    Private m_FichaPersonalCuentaCorriente As [String]
    Public Property FichaPersonalRecomendado() As [String]
        Get
            Return m_FichaPersonalRecomendado
        End Get
        Set(value As [String])
            m_FichaPersonalRecomendado = value
        End Set
    End Property
    Private m_FichaPersonalRecomendado As [String]
    Public Property Otros() As [String]
        Get
            Return m_Otros
        End Get
        Set(value As [String])
            m_Otros = value
        End Set
    End Property
    Private m_Otros As [String]
    Public Property FechaInicioContrato() As Date
        Get
            Return m_FechaInicioContrato
        End Get
        Set(value As Date)
            m_FechaInicioContrato = value
        End Set
    End Property
    Private m_FechaInicioContrato As Date
    Public Property FechaFinContrato() As Date
        Get
            Return m_FechaFinContrato
        End Get
        Set(value As Date)
            m_FechaFinContrato = value
        End Set
    End Property
    Private m_FechaFinContrato As Date
    Public Property AreaTrabID() As Integer
        Get
            Return m_AreaTrabID
        End Get
        Set(value As Integer)
            m_AreaTrabID = value
        End Set
    End Property
    Private m_AreaTrabID As Integer
    Public Property Activo() As Integer
        Get
            Return m_Activo
        End Get
        Set(value As Integer)
            m_Activo = value
        End Set
    End Property
    Private m_Activo As Integer
    Public Property FechaIngreso() As Date
        Get
            Return m_FechaIngreso
        End Get
        Set(value As Date)
            m_FechaIngreso = value
        End Set
    End Property
    Private m_FechaIngreso As Date
    Public Property SueldoBase() As Integer
        Get
            Return m_SueldoBase
        End Get
        Set(value As Integer)
            m_SueldoBase = value
        End Set
    End Property
    Private m_SueldoBase As Integer
    Public Property Colacion() As Integer
        Get
            Return m_Colacion
        End Get
        Set(value As Integer)
            m_Colacion = value
        End Set
    End Property
    Private m_Colacion As Integer
    Public Property Prestamos() As Integer
        Get
            Return m_Prestamos
        End Get
        Set(value As Integer)
            m_Prestamos = value
        End Set
    End Property
    Private m_Prestamos As Integer
    Public Property Anticipos() As Integer
        Get
            Return m_Anticipos
        End Get
        Set(value As Integer)
            m_Anticipos = value
        End Set
    End Property
    Private m_Anticipos As Integer
    Public Property APV() As Integer
        Get
            Return m_APV
        End Get
        Set(value As Integer)
            m_APV = value
        End Set
    End Property
    Private m_APV As Integer
    Public Property AhorroVoluntario() As Integer
        Get
            Return m_AhorroVoluntario
        End Get
        Set(value As Integer)
            m_AhorroVoluntario = value
        End Set
    End Property
    Private m_AhorroVoluntario As Integer
    Public Property Beneficios() As Integer
        Get
            Return m_Beneficios
        End Get
        Set(value As Integer)
            m_Beneficios = value
        End Set
    End Property
    Private m_Beneficios As Integer
    Public Property FotoPersonal() As Byte()
        Get
            Return m_FotoPersonal
        End Get
        Set(value As Byte())
            m_FotoPersonal = value
        End Set
    End Property
    Private m_FotoPersonal As Byte()
    Public Property RutPersonal() As Byte()
        Get
            Return m_RutPersonal
        End Get
        Set(value As Byte())
            m_RutPersonal = value
        End Set
    End Property
    Private m_RutPersonal As Byte()
    Public Property FirmaPersonal() As Byte()
        Get
            Return m_FirmaPersonal
        End Get
        Set(value As Byte())
            m_FirmaPersonal = value
        End Set
    End Property
    Private m_FirmaPersonal As Byte()


End Class
