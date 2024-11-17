<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFProducto.aspx.cs" Inherits="Presentation.WFProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center mb-4">Gestión de Productos</h1>
    <asp:HiddenField ID="HFProductoID" runat="server" />

    <div class="container">
        <!-- Nombre -->
        <div class="mb-3">
            <asp:Label ID="LblNombreProductos" runat="server" Text="Ingrese el nombre" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBNombre" runat="server" CssClass="form-control" placeholder="Nombre del producto"></asp:TextBox>
        </div>

        <!-- Descripción -->
        <div class="mb-3">
            <asp:Label ID="LblDescripcionProductos" runat="server" Text="Ingrese la descripción" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBDescripcion" runat="server" CssClass="form-control" placeholder="Descripción del producto"></asp:TextBox>
        </div>

        <!-- Precio -->
        <div class="mb-3">
            <asp:Label ID="LblPrecioProductos" runat="server" Text="Ingrese el precio" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBPrecio" runat="server" CssClass="form-control" placeholder="Precio del producto"></asp:TextBox>
        </div>

        <!-- Parcela -->
        <div class="mb-3">
            <asp:Label ID="LabelParcelas" runat="server" Text="Seleccione la parcela" CssClass="form-label"></asp:Label>
            <asp:DropDownList ID="DDLParcelas" runat="server" CssClass="form-select">
            </asp:DropDownList>
        </div>

        <!-- Botones de acción -->
        <div class="mb-3 text-center">
            <asp:Button ID="BtnSave" runat="server" Text="Guardar" CssClass="btn btn-success mx-2" OnClick="BtnSave_Click" />
            <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" CssClass="btn btn-primary mx-2" OnClick="BtnUpdate_Click" />
            <asp:Label ID="LblMsj" runat="server" Text="" CssClass="text-success"></asp:Label>
        </div>

        <!-- GridView para mostrar los productos -->
        <div class="mt-4">
            <asp:GridView ID="GVProductos" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover" OnSelectedIndexChanged="GVProductos_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="prod_id" HeaderText="ID" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="prod_nombre" HeaderText="Nombre" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="prod_descripcion" HeaderText="Descripción" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="prod_precio" HeaderText="Precio" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="parc_id" HeaderText="Parcela" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:CommandField ShowSelectButton="True" ButtonType="Button" ControlStyle-CssClass="btn btn-info btn-sm" SelectText="Seleccionar" />
                    <asp:CommandField ShowDeleteButton="True" ButtonType="Button" ControlStyle-CssClass="btn btn-danger btn-sm" DeleteText="Eliminar" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
