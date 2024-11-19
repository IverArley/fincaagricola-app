<%@ Page Title="Gestión de Detalles de Venta" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFDetalle.aspx.cs" Inherits="Presentation.WFDetalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center mb-4">Gestión de Detalles de Venta</h1>
    <div class="container">
        
        <!-- Venta -->
        <div class="mb-3">
            <asp:Label ID="LabelVenta" runat="server" Text="Seleccione la Venta:" AssociatedControlID="DDLVentas" CssClass="form-label"></asp:Label>
            <asp:DropDownList ID="DDLVentas" runat="server" CssClass="form-select">
            </asp:DropDownList>
        </div>
        
        <!-- Producto -->
        <div class="mb-3">
            <asp:Label ID="LabelProducto" runat="server" Text="Seleccione el Producto:" AssociatedControlID="DDLProductos" CssClass="form-label"></asp:Label>
            <asp:DropDownList ID="DDLProductos" runat="server" CssClass="form-select">
            </asp:DropDownList>
        </div>

        <!-- Cantidad -->
        <div class="mb-3">
            <asp:Label ID="LabelCantidad" runat="server" Text="Ingrese la cantidad:" AssociatedControlID="TBCantidad" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBCantidad" runat="server" CssClass="form-control" Placeholder="Ingrese la cantidad del producto"></asp:TextBox>
        </div>
        
        <!-- Botones de acción -->
        <div class="mb-3 text-center">
            <asp:Button ID="BtnSave" runat="server" Text="Guardar" CssClass="btn btn-success mx-2" OnClick="BtnSave_Click" />
            <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" CssClass="btn btn-primary mx-2" OnClick="BtnUpdate_Click" />
            <asp:Label ID="LblMsj" runat="server" Text="" CssClass="text-success"></asp:Label>
        </div>

        <!-- GridView para mostrar los detalles -->
        <div class="mt-4">
            <asp:GridView ID="GVDetalleVentas" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover" OnSelectedIndexChanged="GVDetalleVentas_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="vent_id" HeaderText="Venta" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="prod_id" HeaderText="Producto" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="deta_cantidad" HeaderText="Cantidad" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:CommandField ShowSelectButton="True" ButtonType="Button" ControlStyle-CssClass="btn btn-info btn-sm" SelectText="Seleccionar" />
                    <asp:CommandField ShowDeleteButton="True" ButtonType="Button" ControlStyle-CssClass="btn btn-danger btn-sm" DeleteText="Eliminar" />
                </Columns>
            </asp:GridView>
        </div>
        
    </div>
</asp:Content>

