<%@ Page Title="Gestión de Proveedores" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFProveedores.aspx.cs" Inherits="Presentation.WFProveedores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center mb-4">Gestión de Proveedores</h1>
    <div class="container">
        <asp:HiddenField ID="HFProveedorId" runat="server" />

        <!-- Nombre del Proveedor -->
        <div class="mb-3">
            <asp:Label ID="Label1" runat="server" Text="Ingrese el nombre del proveedor:" AssociatedControlID="TBNombre" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBNombre" runat="server" CssClass="form-control" Placeholder="Ingrese el nombre del proveedor"></asp:TextBox>
        </div>

        <!-- Producto -->
        <div class="mb-3">
            <asp:Label ID="Label2" runat="server" Text="Ingrese el producto que ofrece:" AssociatedControlID="TBProducto" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBProducto" runat="server" CssClass="form-control" Placeholder="Ingrese el nombre del producto"></asp:TextBox>
        </div>

        <!-- Teléfono -->
        <div class="mb-3">
            <asp:Label ID="Label4" runat="server" Text="Ingrese el teléfono:" AssociatedControlID="TBTelefono" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBTelefono" runat="server" CssClass="form-control" Placeholder="Ingrese el teléfono del proveedor"></asp:TextBox>
        </div>

        <!-- Botones de acción -->
        <div class="mb-3 text-center">
            <asp:Button ID="BtnSave" runat="server" Text="Guardar" CssClass="btn btn-success mx-2" OnClick="BtnSave_Click1" />
            <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" CssClass="btn btn-primary mx-2" OnClick="BtnUpdate_Click" />
            <asp:Label ID="LblMsj" runat="server" Text="" CssClass="text-success"></asp:Label>
        </div>

        <!-- GridView para mostrar proveedores -->
        <div class="mt-4">
            <asp:GridView ID="GVProveedor" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover" OnSelectedIndexChanged="GVProveedor_SelectedIndexChanged"
                 OnRowDeleting="GVProveedor_RowDeleting" DataKeyNames="prov_id">
                <Columns>
                    <asp:BoundField DataField="prov_id" HeaderText="ID" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="prov_nombre" HeaderText="Nombre" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="prov_producto" HeaderText="Producto" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="prov_telefono" HeaderText="Teléfono" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:CommandField ShowSelectButton="True" ButtonType="Button" ControlStyle-CssClass="btn btn-info btn-sm" SelectText="Seleccionar" />
                    <asp:CommandField ShowDeleteButton="True" ButtonType="Button" ControlStyle-CssClass="btn btn-danger btn-sm" DeleteText="Eliminar" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>

