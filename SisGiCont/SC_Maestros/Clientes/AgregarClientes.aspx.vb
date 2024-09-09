Imports Entities
Imports Business
Imports SC.Exceptions

Public Class AgregarClientes
    Inherits System.Web.UI.Page
    Public ActionRecord As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ActionRecord = 0
        ActionRecord = Request.QueryString("id")

        LblMensaje.Text = ""

        If Not IsPostBack Then

            If ActionRecord > 0 Then
                'EnableRecord()
                DisableRecordMod()
                loadData()
            Else


                loadComuna()
                loadCiudad()
                loadGiro()
                loadTipoEmpresa()
                loadTamanoEmpresa()
            End If

        End If

        


    End Sub
    Protected Sub loadTipoEmpresa()
        DdlTipoEmpresa.DataTextField = "TipoEmpresaNombre"
        DdlTipoEmpresa.DataValueField = "TipoEmpID"
        DdlTipoEmpresa.DataSource = Business.BFTipoEmpresa.ListAllActive()
        DdlTipoEmpresa.DataBind()
        DdlTipoEmpresa.Items.Insert(0, New ListItem("SELECCIONAR", "0"))
    End Sub
    Protected Sub loadTamanoEmpresa()
        Ddltamano.Items.Insert(0, New ListItem("SELECCIONAR", "0"))
        Ddltamano.Items.Insert(1, New ListItem("GRANDE", "1"))
        Ddltamano.Items.Insert(2, New ListItem("MEDIANA", "2"))
        Ddltamano.Items.Insert(3, New ListItem("PEQUEÑA", "3"))
        Ddltamano.Items.Insert(4, New ListItem("MICRO EMPRESA", "4"))
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
    Protected Sub loadData()
        Dim var As New GIC_Cliente
        var = Business.BFClientes.GetById(ActionRecord)
        Txtnom.Text = var.ClienteDesc
        Txtnom.Text = var.ClienteDesc
        Txtrut.Text = var.ClienteRUT
        Txtdir.Text = var.ClienteDireccion
        DdlComuna.SelectedValue = var.ComunaID
        DdlCiudad.SelectedValue = var.CiudadID
        DdlGiro.SelectedValue = var.GiroID
        Txtfono.Text = var.ClienteTelefono
        Txtfax.Text = var.ClienteFax
        TxtCorreo.Text = var.ClienteCorreoElectronico
        Txtsitio.Text = var.ClienteSitioWeb
        Txtotros.Text = var.Otros
        'Fileuplogo.FileBytes = var.Logo
        Ddltamano.SelectedValue = var.TamanoEmpresa
        DdlTipoEmpresa.SelectedValue = var.TipoEmpID
        If var.Activo = 0 Then
            Checkactivo.Checked = False
        Else
            Checkactivo.Checked = True
        End If

    End Sub

    Protected Sub Redireccionar()
        Dim directionURL As String
        directionURL = "ListClientes.aspx"
        Response.Redirect(directionURL)
    End Sub

    Protected Sub Limpiar()
        Txtnom.Text = ""
        Checkactivo.Checked = False
        Txtrut.Text = ""
        Txtdir.Text = ""
        Txtfono.Text = ""
        Txtfax.Text = ""
        TxtCorreo.Text = ""
        Txtsitio.Text = ""
        Txtotros.Text = ""
    End Sub

    Protected Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles Btnnuevo.Click
        Limpiar()
    End Sub
    Function Validarcampos() As Boolean
        Validarcampos = False
        
       
       
        If String.IsNullOrEmpty(Txtnom.Text) Then
            LblMensaje.Text = TipoErrorValidacion.NOM_VACIO
            Validarcampos = True
            Exit Function
        Else
            Validarcampos = False
        End If
        If String.IsNullOrEmpty(Txtrut.Text) Then
            LblMensaje.Text = TipoErrorValidacion.RUT_VACIO
            Validarcampos = True
            Exit Function
        Else
            Validarcampos = False
        End If
        If String.IsNullOrEmpty(Txtdir.Text) Then
            LblMensaje.Text = TipoErrorValidacion.DIRECCION_VACIO
            Validarcampos = True
            Exit Function
        Else
            Validarcampos = False
        End If

        If DdlComuna.SelectedValue = 0 Then
            LblMensaje.Text = TipoErrorValidacion.COMUNA_VACIO
            Validarcampos = True
            Exit Function
        Else
            Validarcampos = False
        End If
        If DdlCiudad.SelectedValue = 0 Then
            LblMensaje.Text = TipoErrorValidacion.CIUDAD_VACIO
            Validarcampos = True
            Exit Function
        Else
            Validarcampos = False
        End If
        If DdlTipoEmpresa.SelectedValue = 0 Then
            LblMensaje.Text = TipoErrorValidacion.GIRO_VACIO
            Validarcampos = True
            Exit Function
        Else
            Validarcampos = False
        End If
        If String.IsNullOrEmpty(Txtfono.Text) Then
            LblMensaje.Text = TipoErrorValidacion.FONO_VACIO
            Validarcampos = True
            Exit Function
        Else
            Validarcampos = False
        End If
        If String.IsNullOrEmpty(TxtCorreo.Text) Then
            LblMensaje.Text = TipoErrorValidacion.CORREO_VACIO
            Validarcampos = True
            Exit Function
        Else
            Validarcampos = False
        End If
        If String.IsNullOrEmpty(Txtfax.Text) Then
            LblMensaje.Text = TipoErrorValidacion.FAX_VACIO
            Validarcampos = True
            Exit Function
        Else
            Validarcampos = False
        End If
        If String.IsNullOrEmpty(TxtCorreo.Text) Then
            LblMensaje.Text = TipoErrorValidacion.CORREO_VACIO
            Validarcampos = True
            Exit Function
        Else
            Validarcampos = False
        End If
        If DdlGiro.SelectedValue = 0 Then
            LblMensaje.Text = TipoErrorValidacion.TIPOEMPRESA_VACIO
            Validarcampos = True
            Exit Function
        Else
            Validarcampos = False
        End If
        If Ddltamano.SelectedValue = 0 Then
            LblMensaje.Text = TipoErrorValidacion.TAMANO_VACIO
            Validarcampos = True
            Exit Function
        Else
            Validarcampos = False
        End If
    End Function
    Protected Sub Deshabilitar()

    End Sub
    Protected Sub SaveRecord()
        If Validarcampos() = False Then
            Dim var As New Cliente

            var.ClienteDesc = Txtnom.Text
            var.ClienteRUT = Txtrut.Text
            var.ClienteDireccion = Txtdir.Text
            var.ComunaID = DdlComuna.SelectedValue
            var.CiudadID = DdlCiudad.SelectedValue
            var.GiroID = DdlGiro.SelectedValue
            var.ClienteTelefono = Txtfono.Text
            var.ClienteFax = Txtfax.Text
            var.ClienteCorreoElectronico = TxtCorreo.Text
            var.ClienteSitioWeb = Txtsitio.Text
            var.Otros = Txtotros.Text
            var.Logo = Fileuplogo.FileBytes
            var.TamanoEmpresa = Ddltamano.SelectedValue
            var.TipoEmpID = DdlTipoEmpresa.SelectedValue

            var.Activo = True
            If Business.BFClientes.AddData(var) = True Then
                Limpiar()
                Redireccionar()
            Else

            End If
        Else

        End If
       
    End Sub
    Protected Sub UpdateRecord()
        Dim IdRecord As Integer
        IdRecord = ActionRecord

        If Validarcampos() = False Then
            If IdRecord > 0 Then
                Dim var As New Cliente
                var.ClienteID = IdRecord
                var.ClienteDesc = Txtnom.Text
                var.ClienteRUT = Txtrut.Text
                var.ClienteDireccion = Txtdir.Text
                var.ComunaID = DdlComuna.SelectedValue
                var.CiudadID = DdlCiudad.SelectedValue
                var.GiroID = DdlGiro.SelectedValue
                var.ClienteTelefono = Txtfono.Text
                var.ClienteFax = Txtfax.Text
                var.ClienteCorreoElectronico = TxtCorreo.Text
                var.ClienteSitioWeb = Txtsitio.Text
                var.Otros = Txtotros.Text
                var.Logo = Fileuplogo.FileBytes
                var.TamanoEmpresa = Ddltamano.SelectedValue
                var.TipoEmpID = DdlTipoEmpresa.SelectedValue
                var.Activo = Checkactivo.Checked
                If Business.BFClientes.ModData(var) = True Then
                    Limpiar()
                    Redireccionar()
                Else
                    DisableRecordMod()
                End If
            Else

            End If
        Else



        End If
        Limpiar()
        Redireccionar()
    End Sub
    Protected Sub DeleteRecord()
        Dim IdRecord As Integer
        IdRecord = 0
        If IdRecord > 0 Then
            Dim var As New Salud
            var.SaludID = IdRecord
            If Business.BFSalud.DeleteData(var) = True Then
                Redireccionar()
            Else

            End If
        Else

        End If

        Redireccionar()
    End Sub
    Protected Sub EnableRecord()
        Txtnom.Enabled = True
        Btnnuevo.Enabled = True
        Btngrabar.Enabled = True
        BtnMod.Enabled = False
        Btnnuevo.Visible = True
        Btngrabar.Visible = True
        BtnMod.Visible = False
        BtnEliminar.Visible = False
        BtnEliminar.Enabled = False
    End Sub
    Protected Sub DisableRecordMod()
        Txtnom.Enabled = True
        Btnnuevo.Enabled = False
        Btngrabar.Enabled = False
        BtnMod.Enabled = True
        Btnnuevo.Visible = False
        Btngrabar.Visible = False
        BtnMod.Visible = True
        BtnEliminar.Visible = False
        BtnEliminar.Enabled = False
    End Sub
    Protected Sub DisableRecordDelete()
        Txtnom.Enabled = False
        Btnnuevo.Enabled = False
        Btngrabar.Enabled = False
        BtnMod.Enabled = True
        Btnnuevo.Visible = False
        Btngrabar.Visible = False
        BtnMod.Visible = False
        BtnEliminar.Visible = True
        BtnEliminar.Enabled = True
    End Sub

    Protected Sub Btngrabar_Click(sender As Object, e As EventArgs) Handles Btngrabar.Click
        SaveRecord()
        'System.Threading.Thread.Sleep(Convert.ToInt32(5000))
    End Sub

    Protected Sub BtnMod_Click(sender As Object, e As EventArgs) Handles BtnMod.Click
        UpdateRecord()
    End Sub

    Protected Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        DeleteRecord()
    End Sub



End Class