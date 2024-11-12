<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFProveedores.aspx.cs" Inherits="Presentation.WFProveedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestion de Productos</h1>
    <div>
        <%--Id--%>
        <asp:HiddenField ID="HFProveedorId" runat="server" />
       
        <%--Nombre--%>
        <asp:Label ID="Label1" runat="server" Text="Ingrese el nombre"></asp:Label>
        <asp:TextBox ID="TBNombre" runat="server"></asp:TextBox>
        <br />
        <%--Producto--%>
        <asp:Label ID="Label2" runat="server" Text="Ingrese el producto"></asp:Label>
        <asp:TextBox ID="TBProducto" runat="server"></asp:TextBox>
        <br />
        <%--Telefono--%>
        <asp:Label ID="Label4" runat="server" Text="Ingrese el Telefono"></asp:Label>
        <asp:TextBox ID="TBTelefono" runat="server"></asp:TextBox>
        
        <br />
        <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click1" />
        <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
        <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
        <br />

     <%--   Lista de productos--%>
        <asp:GridView ID="GVProveedor" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVProveedor_SelectedIndexChanged"> 
            <Columns>
                <asp:BoundField DataField="prov_id" HeaderText="ID" />
                <asp:BoundField DataField="prov_nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="prov_producto" HeaderText="Producto" />
                <asp:BoundField DataField="prov_telefono" HeaderText="Telefono" />
                 

                <asp:CommandField ShowSelectButton="True"></asp:CommandField>
                <asp:CommandField ShowDeleteButton="True"></asp:CommandField>
            </Columns>
        </asp:GridView>
        </div>
</asp:Content>
