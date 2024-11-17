<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFProducto.aspx.cs" Inherits="Presentation.WFProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestión de Productos</h1>
    <asp:HiddenField ID="HFProductoID" runat="server" />
    <br />
    <%--Nombre--%>
    <asp:Label ID="LblNombreProductos" runat="server" Text="Ingrese el nombre"></asp:Label>
    <asp:TextBox ID="TBNombre" runat="server" Style="margin-left: 20px"></asp:TextBox>
    <br />
    <%--Descripción--%>
    <asp:Label ID="LblDescripcionProductos" runat="server" Text="Ingrese la descripción"></asp:Label>
    <asp:TextBox ID="TBDescripcion" runat="server" Style="margin-left: 20px"></asp:TextBox>
    <br />
    <%--Precio--%>
    <asp:Label ID="LblPrecioProductos" runat="server" Text="Ingrese el precio"></asp:Label>
    <asp:TextBox ID="TBPrecio" runat="server" Style="margin-left: 20px"></asp:TextBox>
    <br />
    <%--Parcela--%>
    <asp:Label ID="LabelParcelas" runat="server" Text="Seleccione la parcela"></asp:Label>
    <asp:DropDownList ID="DDLParcelas" runat="server"></asp:DropDownList>
    <br />

    <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
    <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
    <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <div>
        <asp:GridView ID="GVProductos" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVProductos_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="prod_id" HeaderText="ID" />
                <asp:BoundField DataField="prod_nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="prod_descripcion" HeaderText="Descripción" />
                <asp:BoundField DataField="prod_precio" HeaderText="Precio" />
                <asp:BoundField DataField="parc_id" HeaderText="Parcela" />
                <asp:CommandField ShowSelectButton="True" ButtonType="Button" />
                <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>