Imports Entities
Imports Business
Public Class AgregarProvee
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
            loadComuna()
            loadCiudad()
            loadGiro()
            loadBanco()
            loadTipoProveedor()
        End If
    End Sub
    Protected Sub loadTipoProveedor()
        Ddltipoprovee.DataTextField = "TipoProveedorNombre"
        Ddltipoprovee.DataValueField = "TipoProveID"
        Ddltipoprovee.DataSource = Business.BFProveedorTipo.ListAllActive()
        Ddltipoprovee.DataBind()
        Ddltipoprovee.Items.Insert(0, New ListItem("SELECCIONAR", "0"))
    End Sub
    Protected Sub loadBanco()
        Ddlbanco.DataTextField = "BancoNombre"
        Ddlbanco.DataValueField = "BancoID"
        Ddlbanco.DataSource = Business.BFBanco.ListAllActive()
        Ddlbanco.DataBind()
        Ddlbanco.Items.Insert(0, New ListItem("SELECCIONAR", "0"))
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
    Protected Sub loadGiro()
        DdlGiro.DataTextField = "GiroNombre"
        DdlGiro.DataValueField = "GiroID"
        DdlGiro.DataSource = Business.BFGiro.ListAllActive()
        DdlGiro.DataBind()
        DdlGiro.Items.Insert(0, New ListItem("SELECCIONAR", "0"))
    End Sub
End Class