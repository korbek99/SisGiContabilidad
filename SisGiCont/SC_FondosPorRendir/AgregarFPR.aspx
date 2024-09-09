
<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarFPR.aspx.vb" Inherits="SisGiCont.AgregarFPR" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--Aqui dentro van los objetos de nuestro web forma--%>
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
                    width: 114px;
                }
                .auto-style2 {
                    width: 22px;
                }

                .auto-style3 {
                    width: 92px;
                }

            </style>


 <div id="divDatos" class="DivRef">
    
               <div style="font-weight:bold;" ><h3>Fondo por Rendir</h3></div>	

     <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
 
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
             <br />
             <br />
           <div id="DivTituloCabecera">
               <div style="font-weight:bold;" ><h5>Ingreso Datos FRP</h5>
               <br />
               </div>
               
            <table id="tblDatos" border="0">
                <tr>
                    <td></td>
                    <td class="auto-style1">Id</td>
                    <td class="auto-style2">:</td>
                    <td><asp:TextBox ID="Txtid" runat="server" ></asp:TextBox></td>
                    <td></td>
                    <td class="auto-style3"></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                 <tr>
                    <td></td>
                    <td class="auto-style1">Destinatario</td>
                    <td class="auto-style2">:</td>
                    <td><asp:DropDownList ID="DdlDestinatario" runat="server" Width="251px"></asp:DropDownList></td>
                    <td><asp:Button ID="BtnNuevodestina" runat="server" Text="Nuevo" /></td>
                    <td class="auto-style3"></td>
                    <td></td>
                    <td></td>
                     
                     
                    <td></td>
                </tr>
                 <tr>
                    <td></td>
                    <td class="auto-style1">Proyecto Asociado</td>
                    <td class="auto-style2">:</td>
                    <td><asp:DropDownList ID="DdlProyectoAsign" runat="server" Width="251px"></asp:DropDownList></td>
                    <td><asp:Button ID="BtnNuevoProyecto" runat="server" Text="Nuevo" /></td>
                    <td class="auto-style3"></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                 <tr>
                    <td></td>
                    <td class="auto-style1">Cuenta Contable</td>
                    <td class="auto-style2">:</td>
                    <td><asp:DropDownList ID="DdlCuentacontable" runat="server" Width="251px"></asp:DropDownList></td>
                    <td></td>
                    <td class="auto-style3">SubCuenta</td>
                    <td>:</td>
                    <td><asp:DropDownList ID="Ddlsubcuenta" runat="server" Width="156px" Height="16px"></asp:DropDownList></td>
                    <td></td>
                </tr>
                 <tr>
                    <td></td>
                    <td class="auto-style1">Monto Asignado</td>
                    <td class="auto-style2">:</td>
                    <td><asp:TextBox ID="Txtmontoasignado" runat="server"></asp:TextBox></td>
                    <td></td>
                    <td class="auto-style3"></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                 <tr>
                    <td></td>
                    <td class="auto-style1">Descripción</td>
                    <td class="auto-style2">:</td>
                    <td><asp:TextBox ID="Txtdescrip" runat="server" Width="250px"></asp:TextBox></td>
                    <td></td>
                    <td class="auto-style3"></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                 <tr>
                    <td></td>
                    <td class="auto-style1">Monto Gastado</td>
                    <td class="auto-style2">:</td>
                    <td><asp:TextBox ID="Txtmontogastado" runat="server"></asp:TextBox></td>
                    <td><asp:Button ID="BtnCalculo" runat="server" Text="Calculo Monto Gastado" Width="144px" /></td>
                    <td class="auto-style3">Saldo Actual</td>
                    <td>:</td>
                    <td><asp:TextBox ID="Txtsaldoactual" runat="server"></asp:TextBox></td>
                    <td></td>
                </tr>
                 <tr>
                    <td></td>
                    <td class="auto-style1">Fecha Entrega</td>
                    <td class="auto-style2">:</td>
                    <td><asp:TextBox ID="TextFechaEntrega" runat="server" ></asp:TextBox></td>
                    <td></td>
                    <td class="auto-style3"></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                 <tr>
                    <td></td>
                    <td class="auto-style1">Estado Fondo</td>
                    <td class="auto-style2">:</td>
                    <td><asp:DropDownList ID="DdlEstadoFondo" runat="server" Width="173px" Height="16px"></asp:DropDownList></td>
                    <td></td>
                    <td class="auto-style3"></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
            </table>
            </div>
             <br />
            <div id="DivDatosDatosAdjuntos"> 
                <div id="DivTitulodatosadjuntos">
               <div style="font-weight:bold;" ><h5>Ingreso Datos Adjuntos</h5>
               <br />
               </div>
            <table>
                <tr>
                    <td></td>
                    <td>Solicitud FPR</td>
                    <td>:</td>
                    <td><asp:FileUpload ID="FileUpSolFPR" runat="server" /></td>
                    <td></td>
                </tr>
                 <tr>
                    <td></td>
                    <td>Transferencia de Destinatario del FPR</td>
                    <td>:</td>
                    <td><asp:FileUpload ID="FileUpTransDesFPR" runat="server" /></td>
                    <td></td>
                </tr>
                
                <tr>
                    <td></td>
                    <td>Rendición de  FPR</td>
                    <td>:</td>
                    <td><asp:FileUpload ID="FileUpRenFPR" runat="server" /></td>
                    <td></td>
                </tr>
                 <tr>
                    <td></td>
                    <td>Transferencia de  Saldo</td>
                    <td>:</td>
                    <td><asp:FileUpload ID="FileUpTransSaldo" runat="server" /></td>
                    <td></td>
                </tr>
            </table>
           </div>

            <br />
            <div id="DivDetalleFPR"> 
                <div id="DivTituloDetalleFRP">
               <div style="font-weight:bold;" ><h5>Ingreso Datos FRP</h5>
               <br />
               </div>
              <table>
                <tr>
                    <td></td>
                    <td><asp:GridView ID="Grddetallefondos" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="634px">
                        <Columns>
                            <asp:ButtonField Text="Eliminar" />
                        </Columns>
                        <FooterStyle BackColor="White" ForeColor="#000066" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                        <RowStyle ForeColor="#000066" />
                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#007DBB" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#00547E" />
                        </asp:GridView></td>
                    <td></td>
                    <td></td>
                    
                    <td></td>
                </tr>
              </table>
           </div>


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
