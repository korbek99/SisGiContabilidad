Imports Entities
Imports Business
Public Class AgregarFPR
    Inherits System.Web.UI.Page
    Public ActionRecord As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ActionRecord = 0
        ActionRecord = Request.QueryString("id")
        If ActionRecord > 0 Then
            'EnableRecord()
            DisableRecordMod()
            loadData()
        Else
            loadDestinatario()
            loadEstadoFondo()
            loadCuentaContable()
        End If


    End Sub
    Protected Sub loadCuentaContable()
        DdlDestinatario.DataTextField = "CuentaContaDescripcion"
        DdlDestinatario.DataValueField = "CuentaContaID"
        DdlDestinatario.DataSource = Business.BFCuentaContable.ListAllActive()
        DdlDestinatario.DataBind()
        DdlDestinatario.Items.Insert(0, New ListItem("SELECCIONAR", "0"))
    End Sub
    Protected Sub loadEstadoFondo()
        DdlEstadoFondo.Items.Insert(0, New ListItem("SELECCIONAR", "0"))
        DdlEstadoFondo.Items.Insert(1, New ListItem("Activo", "1"))
        DdlEstadoFondo.Items.Insert(2, New ListItem("En Proceso", "2"))
        DdlEstadoFondo.Items.Insert(3, New ListItem("En Rendicion", "3"))
        DdlEstadoFondo.Items.Insert(4, New ListItem("NO Activo", "4"))
    End Sub
    Protected Sub loadDestinatario()
        DdlDestinatario.DataTextField = "FichaPersonalNombre"
        DdlDestinatario.DataValueField = "FichaPersonalID"
        DdlDestinatario.DataSource = Business.BFFichaPersonal.ListAllActive()
        DdlDestinatario.DataBind()
        DdlDestinatario.Items.Insert(0, New ListItem("SELECCIONAR", "0"))
    End Sub
    Protected Sub loadData()
        Dim FondoPorRendir As New GIC_FondoPorRendir
        FondoPorRendir = Business.BFFondoPorRendir.GetById(ActionRecord)
        Txtdescrip.Text = FondoPorRendir.FPRDescripcion
        ' Checkactivo.Checked = FondoPorRendir.Activo
    End Sub

    Protected Sub Redireccionar()
        Dim directionURL As String
        directionURL = "ListFondoPorRendirR.aspx"
        Response.Redirect(directionURL)
    End Sub

    Protected Sub Limpiar()
        Txtdescrip.Text = ""
        'Checkactivo.Checked = False
    End Sub

    Protected Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles Btnnuevo.Click
        Limpiar()
    End Sub
    Function Validarcampos() As Boolean
        Validarcampos = False

        If String.IsNullOrEmpty(Txtdescrip.Text) Then
            Validarcampos = True
        Else
            Validarcampos = False
        End If
    End Function
    Protected Sub Deshabilitar()

    End Sub
    Protected Sub SaveRecord()
        If Validarcampos() = False Then
            Dim var As New FondoPorRendir
            var.FPRDescripcion = Txtdescrip.Text
            'var.Activo = True
            If Business.BFFondoPorRendir.AddData(var) = True Then
                Redireccionar()
            Else

            End If
        Else

        End If
        Limpiar()
        Redireccionar()
    End Sub
    Protected Sub UpdateRecord()
        Dim IdRecord As Integer
        IdRecord = ActionRecord

        If Validarcampos() = False Then
            If IdRecord > 0 Then
                Dim var As New FondoPorRendir
                var.FPRID = IdRecord
                var.FPRDescripcion = Txtdescrip.Text
                'var.Activo = True
                If Business.BFFondoPorRendir.ModData(var) = True Then
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
            Dim var As New FondoPorRendir
            var.FPRID = IdRecord
            If Business.BFFondoPorRendir.DeleteData(var) = True Then

            Else

            End If
        Else

        End If

        Redireccionar()
    End Sub
    Protected Sub EnableRecord()
        Txtdescrip.Enabled = True
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
        Txtdescrip.Enabled = True
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
        Txtdescrip.Enabled = False
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