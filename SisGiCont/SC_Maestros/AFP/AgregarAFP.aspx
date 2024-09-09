
<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarAFP.aspx.vb" Inherits="SisGiCont.AgregarAFP" %>
   
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

            </style>


 <div id="divDatos">
    
               <div style="font-weight:bold;" ><h3>Ingreso AFP</h3></div>	

     <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
 
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
             <br />
            <br />
           <asp:Label ID="Lblafp" runat="server" Text="Nombre AFP"></asp:Label> <br />
        <asp:TextBox ID="Txtafp" runat="server" Width="362px"></asp:TextBox>

            <br />
            <asp:CheckBox ID="Checkactivo" runat="server" Text ="Activo" />
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

