
<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarFicha.aspx.vb" Inherits="SisGiCont.AgregarFicha" %>
   
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

                .auto-style1 {
                    width: 28px;
                }
                .auto-style2 {
                    width: 164px;
                }
                #TblDatos {
                    width: 832px;
                }

                .auto-style3 {
                    width: 1px;
                }
                .auto-style4 {
                    width: 8px;
                }

                .auto-style5 {
                    width: 135px;
                }

                .auto-style6 {
                    height: 26px;
                }
                .auto-style7 {
                    width: 135px;
                    height: 26px;
                }
                .auto-style8 {
                    width: 28px;
                    height: 26px;
                }
                .auto-style9 {
                    width: 1px;
                    height: 26px;
                }
                .auto-style10 {
                    width: 8px;
                    height: 26px;
                }
                .auto-style11 {
                    width: 164px;
                    height: 26px;
                }

            </style>

    <div id="divDatos">
    
               <div style="font-weight:bold;" ><h3>Ingreso Ficha Trabajador</h3></div>	

     <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
 
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
             <br />
            <br />



                <table id="TblDatos" border="0">
                    <tr>
                        <td></td>
                        <td class="auto-style5">Fecha Ingreso</td>
                        <td>:</td>
                        <td><asp:TextBox ID="Txtfechaing" runat="server"></asp:TextBox></td>
                        <td class="auto-style1"></td>
                        <td class="auto-style3"></td>
                        <td class="auto-style4"></td>
                        <td class="auto-style2"></td>
                         <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="auto-style5">Rut</td>
                        <td>:</td>
                        <td><asp:TextBox ID="Txtrut" runat="server"></asp:TextBox></td>
                        <td class="auto-style1"></td>
                        <td class="auto-style3"></td>
                        <td class="auto-style4"></td>
                        <td class="auto-style2"></td>
                         <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td class="auto-style6"></td>
                        <td class="auto-style7">Nombre</td>
                        <td class="auto-style6">:</td>
                        <td class="auto-style6"><asp:TextBox ID="Txtnom" runat="server" Width="243px"></asp:TextBox></td>
                        <td class="auto-style8"></td>
                        <td class="auto-style9"></td>
                        <td class="auto-style10">&nbsp;</td>
                        <td class="auto-style11"></td>
                         <td class="auto-style6"></td>
                        <td class="auto-style6"></td>
                        <td class="auto-style6"></td>
                    </tr>
                     <tr>
                        <td></td>
                        <td class="auto-style5">Fecha Nac</td>
                        <td>:</td>
                        <td><asp:TextBox ID="Txtfechanac" runat="server"></asp:TextBox></td>
                        <td class="auto-style1"></td>
                        <td class="auto-style3"></td>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style2"></td>
                         <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="auto-style5">Edad</td>
                        <td>:</td>
                        <td><asp:TextBox ID="Txtedad" runat="server"></asp:TextBox></td>
                        <td class="auto-style1"></td>
                        <td class="auto-style3"></td>
                        <td class="auto-style4"> &nbsp;</td>
                        <td class="auto-style2">
                            
                        </td>
                         <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                     <tr>
                        <td></td>
                        <td class="auto-style5">Estado Civil</td>
                        <td>:</td>
                        <td><asp:DropDownList ID="DdlEcivil" runat="server" Width="185px">
                            </asp:DropDownList></td>
                        <td class="auto-style1"></td>
                        <td class="auto-style3"></td>
                        <td class="auto-style4"> </td>
                        <td class="auto-style2">
                           
                        </td>
                         <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                     <tr>
                        <td></td>
                        <td class="auto-style5">Nacionalidad</td>
                        <td>:</td>
                        <td><asp:TextBox ID="Txtnacional" runat="server"></asp:TextBox></td>
                        <td class="auto-style1"></td>
                        <td class="auto-style3"></td>
                        <td class="auto-style4"></td>
                        <td class="auto-style2"></td>
                          <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                     <tr>
                        <td></td>
                        <td class="auto-style5">Dirección</td>
                        <td>:</td>
                        <td colspan="3"><asp:TextBox ID="TxtDir" runat="server" Width="344px"></asp:TextBox></td>
                        <td class="auto-style4"></td>
                        <td class=""></td>
                          <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="auto-style5">Comuna</td>
                        <td>:</td>
                        <td><asp:DropDownList ID="DdlComuna" runat="server" Width="186px"></asp:DropDownList></td>
                        <td></td>
                        <td class="auto-style3">Ciudad</td>
                        <td class="auto-style4">:</td>
                        <td><asp:DropDownList ID="DdlCiudad" runat="server" Width="151px"></asp:DropDownList></td>
                         <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="auto-style5">Estudios</td>
                        <td>:</td>
                        <td colspan="4"><asp:TextBox ID="Txtestudios" runat="server" Width="363px"></asp:TextBox></td>
                        <td class="auto-style2"></td>
                         <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="auto-style5">Fono</td>
                        <td>:</td>
                        <td><asp:TextBox ID="Txtfono" runat="server"></asp:TextBox></td>
                        <td></td>
                        <td class="auto-style3"></td>
                        <td class="auto-style4"></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="auto-style5">Celular</td>
                        <td>:</td>
                        <td><asp:TextBox ID="Txtfonoaux" runat="server"></asp:TextBox></td>
                        <td></td>
                        <td class="auto-style3"></td>
                        <td class="auto-style4"></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                     <tr>
                        <td></td>
                        <td class="auto-style5">Fono Casa</td>
                        <td>:</td>
                        <td><asp:TextBox ID="Txtfonocasa" runat="server"></asp:TextBox></td>
                        <td></td>
                        <td class="auto-style3"></td>
                        <td class="auto-style4"></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="auto-style5">AFP</td>
                        <td>:</td>
                        <td><asp:DropDownList ID="DdlAFP" runat="server" Width="151px"></asp:DropDownList></td>
                        <td></td>
                        <td class="auto-style3">Salud</td>
                        <td class="auto-style4">:</td>
                        <td><asp:DropDownList ID="Ddlsalud" runat="server" Width="151px"></asp:DropDownList></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="auto-style5">Banco</td>
                        <td>:</td>
                        <td><asp:DropDownList ID="Ddlbancos" runat="server" Width="151px"></asp:DropDownList></td>
                        <td></td>
                        <td class="auto-style3">Numero CC</td>
                        <td class="auto-style4">:</td>
                        <td><asp:DropDownList ID="Ddlcuentasbanco" runat="server" Width="151px"></asp:DropDownList></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="auto-style5">Recomendado</td>
                        <td>:</td>
                        <td colspan="4"><asp:TextBox ID="Txtrecomen" runat="server" Width="355px"></asp:TextBox></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="auto-style5">Otros</td>
                        <td>:</td>
                        <td colspan="4"><asp:TextBox ID="Txtotros" runat="server" Width="355px"></asp:TextBox></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="auto-style5">Fecha Inicio Contrato</td>
                        <td>:</td>
                        <td><asp:TextBox ID="Txtfechainicon" runat="server" Width="142px"></asp:TextBox></td>
                        <td></td>
                        <td class="auto-style3"></td>
                        <td class="auto-style4">&nbsp;</td>
                        <td></td>
                         <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                     <tr>
                        <td></td>
                        <td class="auto-style5">Fecha Fin Contrato</td>
                        <td>:</td>
                        <td><asp:TextBox ID="Txtfechafincon" runat="server" Width="142px"></asp:TextBox></td>
                        <td></td>
                        <td class="auto-style3"></td>
                        <td class="auto-style4">&nbsp;</td>
                        <td></td>
                         <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="auto-style5">Area Trabajador</td>
                        <td>:</td>
                        <td colspan="3" ><asp:DropDownList ID="DdlAreatrabajo" runat="server" Width="323px"></asp:DropDownList></td>
                        <td class="auto-style4"></td>
                        <td></td>
                         <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                     <tr>
                        <td></td>
                        <td class="auto-style5">Estado Trabajador</td>
                        <td>:</td>
                        <td ><asp:DropDownList ID="ddlestadotrab" runat="server" Width="151px"></asp:DropDownList></td>
                        <td></td>
                        <td class="auto-style3"></td>
                        <td class="auto-style4"></td>
                        <td></td>
                          <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="auto-style5">Foto Trabajador</td>
                        <td>:</td>
                        <td><asp:FileUpload ID="FileUpFototrab" runat="server" /></td>
                        <td></td>
                        <td>Foto Rut</td>
                        <td>:</td>
                        <td><asp:FileUpload ID="FileUpRut" runat="server" /></td>
                         <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="auto-style5">Firma Trabajador</td>
                        <td>:</td>
                        <td colspan="4"><asp:FileUpload ID="FileUpfirma" runat="server" /></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                      
                    </tr>
                     <tr>
                        <td></td>
                        <td class="auto-style5"></td>
                        <td></td>
                        <td ></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                          <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="auto-style5">Registro de Documentos y Formularios Personales</td>
                        <td></td>
                        <td colspan="5">

                            <table  id="tblregistrodoc">
                                  <tr>
                                        <td>Descripción</td>
                                        <td>:</td>
                                        <td colspan="4"><asp:TextBox ID="Txtdescrip" runat="server" Width="375px"></asp:TextBox></td>
                                        <td >&nbsp;</td>
                                        <td></td>
                                        <td >
                                            &nbsp;</td>
                                 </tr>
                                   <tr>
                                        <td>Adjuntar</td>
                                        <td>:</td>
                                        <td>
                                            <asp:FileUpload ID="FileUpadjuntar" runat="server" />
                                        </td>
                                        <td ></td>
                                        <td>
                                            <asp:Button ID="BtnAgregar" runat="server" Text="Adjuntar a Lista" />
                                        </td>
                                        <td></td>
                                        <td ></td>
                                        <td></td>
                                        <td ></td>
                                 </tr>
                                 <tr>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                 </tr>
                            </table>
                            <asp:GridView ID="GridView1" runat="server" Width="446px">
                                <Columns>
                                    <asp:ButtonField Text="Eliminar" />
                                    <asp:ButtonField Text="Ver" />
                                </Columns>
                            </asp:GridView>
                        </td>
                         <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                </table>




          

            <br />
        <br />
        <asp:Button ID="Btnnuevo" runat="server" Text="Nuevo" />
        <asp:Button ID="Btngrabar" runat="server" Text="Grabar" />
        <asp:Button ID="BtnMod" runat="server" Text="Modificar" />
        <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" />
        <br />
        <br />
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
    <ProgressTemplate>
        <div id="Background"></div>
        <div id="Progress">
            <h6> <p style="text-align:center"> <b>Procesando Datos, Espere por favor... <br /></b> </p> </h6>
        </div>
    </ProgressTemplate>
    </asp:UpdateProgress>
</div>

</asp:Content>