<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFDetalle.aspx.cs" Inherits="Presentation.WFDetalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestión de Detalles de Venta</h1>
    

    <%-- Venta --%>
    <asp:Label ID="LabelVenta" runat="server" Text="Seleccione la Venta"></asp:Label>
    <asp:DropDownList ID="DDLVentas" runat="server"></asp:DropDownList>
    <br />

    <br />
    <%-- Producto --%>
    <asp:Label ID="LabelProducto" runat="server" Text="Seleccione el Producto"></asp:Label>
    <asp:DropDownList ID="DDLProductos" runat="server"></asp:DropDownList>
    <br />
    
    
    <%-- Cantidad --%>
    <asp:Label ID="LabelCantidad" runat="server" Text="Ingrese la cantidad"></asp:Label>
    <asp:TextBox ID="TBCantidad" runat="server"></asp:TextBox>
    <br />
    
    
    <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
    <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
    
    <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
    <br />
    
    <!-- GridView para mostrar los detalles -->
    <div>
        <asp:GridView ID="GVDetalleVentas" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVDetalleVentas_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="vent_id" HeaderText="Venta" />
                <asp:BoundField DataField="prod_id" HeaderText="Producto" />
                <asp:BoundField DataField="deta_cantidad" HeaderText="Cantidad" />
                <asp:CommandField ShowSelectButton="True" ButtonType="Button" />
                <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
