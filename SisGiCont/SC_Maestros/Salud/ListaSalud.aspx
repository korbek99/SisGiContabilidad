﻿

<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaSalud.aspx.vb" Inherits="SisGiCont.ListaSalud" %>
   
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--Aqui dentro van los objetos de nuestro web forma--%>
     <link href="../../css/style.css" rel="stylesheet" />
    <link href="../../css/stylesM.css" rel="stylesheet" />
     <script src="http://code.jquery.com/jquery-latest.min.js" type="text/javascript"></script>
    <script src="../../Scripts/script.js"></script>

    <div id="divcabecera">
    
               <div style="font-weight:bold;" ><h3>Administrar Tipo Salud</h3></div>	
    
            <br />
            <br />
            <br />    
                <asp:Button ID="Btnnuevo" runat="server" Text="Nuevo Tipo Salud" />
            <br />
            <br />
            <br />
            <asp:GridView ID="GrdTiposalud" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="471px">
                <Columns>
                   <asp:ButtonField Text="Editar"  CommandName="Editar" />
                    <asp:ButtonField Text="Eliminar"  CommandName="Editar" />
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
            </asp:GridView>
            <br />
            <br />
            <br />

</div>



</asp:Content>