Imports Entities
Imports Business
Public Class AgregarFicha
    Inherits System.Web.UI.Page
    Public ActionRecord As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ActionRecord = 0
        ActionRecord = Request.QueryString("id")
        If ActionRecord > 0 Then
            'EnableRecord()
            'DisableRecordMod()
            'loadData()
        Else
            loadEstadoCivil()
            loadCiudad()
            loadComuna()
            loadCiudad()
            loadBanco()
            loadafp()
            loadsalud()
            loadarea()
            loadEstadoTrabajador()

        End If
    End Sub
    Protected Sub loadEstadoTrabajador()

        'ddlestadotrab.Items.Insert(1, New ListItem("ACTIVO", "1"))
        'ddlestadotrab.Items.Insert(2, New ListItem("NO ACTIVO", "0"))
    End Sub
    Protected Sub loadarea()
        DdlAreatrabajo.DataTextField = "AreaTrabNombre"
        DdlAreatrabajo.DataValueField = "AreaTrabID"
        DdlAreatrabajo.DataSource = Business.BFAreaTrabajo.ListAllActive()
        DdlAreatrabajo.DataBind()
        DdlAreatrabajo.Items.Insert(0, New ListItem("SELECCIONAR", "0"))
    End Sub
    Protected Sub loadafp()
        Ddlsalud.DataTextField = "AfpNombre"
        Ddlsalud.DataValueField = "AfpID"
        Ddlsalud.DataSource = Business.BFAfp.ListAllActive()
        Ddlsalud.DataBind()
        Ddlsalud.Items.Insert(0, New ListItem("SELECCIONAR", "0"))
    End Sub
    Protected Sub loadsalud()
        Ddlsalud.DataTextField = "SaludNombre"
        Ddlsalud.DataValueField = "SaludID"
        Ddlsalud.DataSource = Business.BFSalud.ListAllActive()
        Ddlsalud.DataBind()
        Ddlsalud.Items.Insert(0, New ListItem("SELECCIONAR", "0"))
    End Sub

    Protected Sub loadEstadoCivil()
        DdlEcivil.Items.Insert(0, New ListItem("SELECCIONAR", "0"))
        DdlEcivil.Items.Insert(1, New ListItem("SOLTERO", "1"))
        DdlEcivil.Items.Insert(2, New ListItem("CASADO", "2"))
        DdlEcivil.Items.Insert(3, New ListItem("SEPARADO", "3"))
        DdlEcivil.Items.Insert(4, New ListItem("DIVORCIADO", "4"))
        DdlEcivil.Items.Insert(5, New ListItem("VIUDO", "5"))
    End Sub
    Protected Sub loadBanco()
        Ddlbancos.DataTextField = "BancoNombre"
        Ddlbancos.DataValueField = "BancoID"
        Ddlbancos.DataSource = Business.BFBanco.ListAllActive()
        Ddlbancos.DataBind()
        Ddlbancos.Items.Insert(0, New ListItem("SELECCIONAR", "0"))
    End Sub

    Protected Sub loadComuna()
        DdlComuna.DataTextField = "ComunaNombre"
        DdlComuna.DataValueField = "ComunaID"
        DdlComuna.DataSource = Business.BFComuna.ListAllActive()
        DdlComuna.DataBind()
        DdlComuna.Items.Insert(0, New ListItem("SELECCIONAR", "0"))
    End Sub
    Protected Sub loadCiudad()
        DdlCiudad.DataTextField = "CiudadNombre"
        DdlCiudad.DataValueField = "CiudadID"
        DdlCiudad.DataSource = Business.BFCiudad.ListAllActive()
        DdlCiudad.DataBind()
        DdlCiudad.Items.Insert(0, New ListItem("SELECCIONAR", "0"))
    End Sub
    'Protected Sub loadGiro()
    '    DdlGiro.DataTextField = "GiroNombre"
    '    DdlGiro.DataValueField = "GiroID"
    '    DdlGiro.DataSource = Business.BFGiro.ListAllActive()
    '    DdlGiro.DataBind()
    '    DdlGiro.Items.Insert(0, New ListItem("SELECCIONAR", "0"))
    'End Sub
End Class