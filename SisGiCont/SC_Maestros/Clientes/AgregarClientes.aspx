
<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarClientes.aspx.vb" Inherits="SisGiCont.AgregarClientes" %>
   
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--Aqui dentro van los objetos de nuestro web forma--%>
     <link href="../../css/style.css" rel="stylesheet" />
    <link href="../../css/stylesM.css" rel="stylesheet" />
     <script src="http://code.jquery.com/jquery-latest.min.js" type="text/javascript"></script>
    <script src="../../Scripts/script.js"></script>

    
            <style type="text/css">

            #Background
            {
                position: fixed; 
                top: 0px; 
                bottom: 0px; 
                left: 0px; 
                right: 0px; 
                overflow: hidden; 
                padding: 0; 
                margin: 0; 
                background-color: #F0F0F0; 
                filter: alpha(opacity=80); 
                opacity: 0.8; 
                z-index: 100000;
            }
        
            #Progress
            {
                position: fixed;
                top: 40%; 
                left: 40%; 
                height:20%; 
                width:20%; 
                z-index: 100001;  
                background-color: #FFFFFF; 
                border:1px solid Gray; 
                background-image: url('../../Images/loading.gif'); 
                background-repeat: no-repeat; 
                background-position:center;
            }

                #divDatos {
                    width: 962px;
                }


            </style>
<style type="text/css">
.box {
    width: auto;
    height: auto;
    background: #FFFFFF;
    float: left;
    border: 1px solid #444;
}
.boxcenter{
width:200px;
height:200px;
background:#FFFFFF;
/*float:center;*/
border:1px solid #444;
    }
    .auto-style3 {
        width: 139px;
    }
</style>
<div id="divDatos">
    
               <div style="font-weight:bold;" ><h3>Ingreso Clientes</h3></div>	

     <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
 
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <div class="">
                     <br />
                     <asp:Label ID="LblMensaje" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    <br />

                <table id="TblDatos" border="0">
                    <tr>
                         <td></td>
                         <td><asp:Label ID="Lblnom" runat="server" Text="Nombre"></asp:Label></td>
                         <td>:</td>
                         <td><asp:TextBox ID="Txtnom" runat="server" Width="362px"></asp:TextBox></td>
                         <td></td>
                         <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                         <td>
                             &nbsp;</td>
                    </tr>
                     <tr>
                         <td></td>
                         <td><asp:Label ID="Lblrut" runat="server" Text="Rut"></asp:Label></td>
                         <td>:</td>
                         <td><asp:TextBox ID="Txtrut" runat="server" Width="100px"></asp:TextBox><br /></td>
                         <td></td>
                         <td class="auto-style3">
                             <asp:Label ID="Lbllogo" runat="server" Text="Logo"></asp:Label>
                         </td>
                         <td>:</td>
                         <td>
                             <asp:FileUpload ID="Fileuplogo" runat="server" Width="357px" />
                         </td>
                    </tr>
                    <tr>
                         <td></td>
                         <td><asp:Label ID="Lbldir" runat="server" Text="Dirección"></asp:Label></td>
                         <td>:</td>
                         <td><asp:TextBox ID="Txtdir" runat="server" Width="358px"></asp:TextBox></td>
                         <td></td>
                         <td class="auto-style3">
                             <asp:Label ID="Lbltamano" runat="server" Text="Tamaño Empresa"></asp:Label>
                         </td>
                        <td>:</td>
                         <td>
                             <asp:DropDownList ID="Ddltamano" runat="server" Width="229px">
                             </asp:DropDownList>
                         </td>
                    </tr>
                    <tr>
                         <td></td>
                         <td><asp:Label ID="Lblcomuna" runat="server" Text="Comuna"></asp:Label></td>
                         <td>:</td>
                         <td><asp:DropDownList ID="DdlComuna" runat="server" Width="229px"></asp:DropDownList></td>
                         <td></td>
                         <td class="auto-style3">Tipo Empresa</td>
                        <td>:</td>
                         <td>
                             <asp:DropDownList ID="DdlTipoEmpresa" runat="server" Width="229px">
                             </asp:DropDownList>
                         </td>
                    </tr>
                    <tr>
                         <td></td>
                         <td><asp:Label ID="Lblciudad" runat="server" Text="Ciudad"></asp:Label></td>
                         <td>:</td>
                         <td><asp:DropDownList ID="DdlCiudad" runat="server" Width="229px"></asp:DropDownList></td>
                         <td></td>
                         <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                         <td><asp:CheckBox ID="Checkactivo" runat="server" Text ="Activo" /></td>
                    </tr>
                     <tr>
                         <td></td>
                         <td><asp:Label ID="Lblgiro" runat="server" Text="Giro"></asp:Label></td>
                         <td>:</td>
                         <td><asp:DropDownList ID="DdlGiro" runat="server" Width="229px"></asp:DropDownList></td>
                         <td></td>
                         <td class="auto-style3"></td>
                         <td></td>
                         <td></td>
                    </tr>
                    <tr>
                         <td></td>
                         <td><asp:Label ID="Lbltelefono" runat="server" Text="Telefono"></asp:Label></td>
                         <td>:</td>
                         <td> <asp:TextBox ID="Txtfono" runat="server" Width="151px"></asp:TextBox></td>
                         <td></td>
                         <td class="auto-style3"></td>
                        <td></td>
                         <td></td>
                    </tr>
                    <tr>
                         <td></td>
                         <td><asp:Label ID="Lblfax" runat="server" Text="Fax"></asp:Label></td>
                         <td>:</td>
                         <td><asp:TextBox ID="Txtfax" runat="server" Width="152px"></asp:TextBox></td>
                         <td></td>
                         <td class="auto-style3"></td>
                        <td></td>
                         <td></td>
                    </tr>
                     <tr>
                         <td></td>
                         <td><asp:Label ID="Lblcorreo" runat="server" Text="Correo"></asp:Label></td>
                         <td>:</td>
                         <td><asp:TextBox ID="TxtCorreo" runat="server" Width="252px"></asp:TextBox></td>
                         <td></td>
                         <td class="auto-style3"></td>
                         <td></td>
                         <td></td>
                    </tr>
                     <tr>
                         <td></td>
                         <td><asp:Label ID="Lblsitio" runat="server" Text="Sitio"></asp:Label></td>
                         <td>:</td>
                         <td><asp:TextBox ID="Txtsitio" runat="server" Width="248px"></asp:TextBox></td>
                         <td></td>
                         <td class="auto-style3"></td>
                         <td></td>
                         <td></td>
                    </tr>
                     <tr>
                         <td></td>
                         <td>
                             <asp:Label ID="Lblotro" runat="server" Text="Otros"></asp:Label>
                         </td>
                         <td>:</td>
                         <td>
                             <asp:TextBox ID="Txtotros" runat="server" TextMode="MultiLine" Width="362px"></asp:TextBox>
                         </td>
                         <td></td>
                         <td class="auto-style3"></td>
                         <td></td>
                         <td></td>
                    </tr>
                </table>
                    <br />

            </div>
        <div class="">&nbsp;<br />
        <asp:Button ID="Btnnuevo" runat="server" Text="Nuevo" />
        <asp:Button ID="Btngrabar" runat="server" Text="Grabar" />
        <asp:Button ID="BtnMod" runat="server" Text="Modificar" />
        <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" />
       </div>
        <br />
        <br />
        </ContentTemplate>

    </asp:UpdatePanel>
        <%--<asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
        <ProgressTemplate>
            <div id="Background"></div>
            <div id="Progress">
                <h6> <p style="text-align:center"> <b>Procesando Datos, Espere por favor... <br /></b> </p> </h6>
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>--%>
</div>
</asp:Content>