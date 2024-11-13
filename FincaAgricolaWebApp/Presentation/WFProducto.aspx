<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFProducto.aspx.cs" Inherits="Presentation.WFProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestion Productos</h1>
    <asp:HiddenField ID="HFClienteId" runat="server" />
    <br />
    <%--Nombre--%>
    <asp:Label ID="LblNombreProductos" runat="server" Text="Ingrese el nombre"></asp:Label>
    <asp:TextBox ID="TBNombre" runat="server" style="margin-left: 20px"></asp:TextBox>
    <br />
    <%--Descripcion--%>
    <asp:Label ID="LblDescripcionProductos" runat="server" Text="Ingrese la descripcion"></asp:Label>
    <asp:TextBox ID="TBDescripcion" runat="server" style="margin-left: 20px"></asp:TextBox>
    <br />
    <%--Precio--%>
    <asp:Label ID="LblPrecioProductos" runat="server" Text="Ingrese el precio"></asp:Label>
    <asp:TextBox ID="TBTamano" runat="server" style="margin-left: 20px"></asp:TextBox>
    <br />
    <%--Parcela--%>
    <asp:Label ID="LblParcelaProductos" runat="server" Text="Ingrese la parcela"></asp:Label>
    <asp:TextBox ID="TBParcela" runat="server" style="margin-left: 20px"></asp:TextBox>
    <br />

    <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click"/>
    <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar"  OnClick="BtnUpdate_Click"/>
    <br />
    <br />
     <div>
     <asp:GridView ID="GVProductos" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVProductos_SelectedIndexChanged" Width="740px">
         <Columns>
             <asp:BoundField DataField="prod_id" HeaderText="id"/>
             <asp:BoundField DataField="prod_nombre" HeaderText="nombre"/>
             <asp:BoundField DataField="prod_descripcion" HeaderText="telefono"/>
             <asp:BoundField DataField="prod_precio" HeaderText="direccion"/>
             <asp:BoundField DataField="parc_id" HeaderText="parcela"/>

             <asp:CommandField ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
             <asp:CommandField ShowDeleteButton="True" ButtonType="Button"></asp:CommandField>
         </Columns>
     </asp:GridView>
 </div>
</asp:Content>

