<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFVentas.aspx.cs" Inherits="Presentation.WFVentas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestion Ventas</h1>
    <asp:HiddenField ID="HFClienteId" runat="server" />
    <br />
    <%--Cliente--%>
    <asp:Label ID="LblClienteVentas" runat="server" Text="Ingrese el cliente"></asp:Label>
    <asp:TextBox ID="TBCliente" runat="server" style="margin-left: 20px"></asp:TextBox>
    <br />
    <%--Fecha--%>
    <asp:Label ID="LblFechaVentas" runat="server" Text="Ingrese la fecha"></asp:Label>
    <asp:TextBox ID="TBUbicacion" runat="server" style="margin-left: 20px"></asp:TextBox>
    <br />
    <%--Monto--%>
    <asp:Label ID="LblMontoVentas" runat="server" Text="Ingrese el monto"></asp:Label>
    <asp:TextBox ID="TBTamano" runat="server" style="margin-left: 20px"></asp:TextBox>
    <br />
    <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click"/>
    <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar"  OnClick="BtnUpdate_Click"/>
    
    <br />
    <br />
     <div>
     <asp:GridView ID="GVVentas" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVVentas_SelectedIndexChanged" Width="660px">
         <Columns>
             <asp:BoundField DataField="vent_id" HeaderText="id"/>
             <asp:BoundField DataField="clie_id" HeaderText="cliente"/>
             <asp:BoundField DataField="vent_fecha" HeaderText="fecha"/>
             <asp:BoundField DataField="vent_monto" HeaderText="monto"/>

             <asp:CommandField ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
             <asp:CommandField ShowDeleteButton="True" ButtonType="Button"></asp:CommandField>
         </Columns>
     </asp:GridView>
 </div>
</asp:Content>
