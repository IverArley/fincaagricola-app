<%@ Page Title="Gestión de Insumos" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFInsumos.aspx.cs" Inherits="Presentation.WFInsumos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center mb-4">Gestión de Insumos</h1>
    <div class="container">
        <asp:HiddenField ID="HFInsumoId" runat="server" />
        
        <!-- Nombre del Insumo -->
        <div class="mb-3">
            <asp:Label ID="Label3" runat="server" Text="Ingrese el nombre del insumo:" AssociatedControlID="TBNombre" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBNombre" runat="server" CssClass="form-control" Placeholder="Ingrese el nombre del insumo"></asp:TextBox>
        </div>
        
        <!-- Cantidad -->
        <div class="mb-3">
            <asp:Label ID="Label4" runat="server" Text="Ingrese la cantidad:" AssociatedControlID="TBCantidad" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBCantidad" runat="server" CssClass="form-control" Placeholder="Ingrese la cantidad del insumo"></asp:TextBox>
        </div>
        
        <!-- Fecha de adquisición -->
        <div class="mb-3">
            <asp:Label ID="Label5" runat="server" Text="Ingrese la fecha de adquisición:" AssociatedControlID="TBFechaAdquisicion" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBFechaAdquisicion" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
        </div>
        
        <!-- Proveedor -->
        <div class="mb-3">
            <asp:Label ID="LabelProveedor" runat="server" Text="Seleccione el proveedor:" AssociatedControlID="DDLProveedores" CssClass="form-label"></asp:Label>
            <asp:DropDownList ID="DDLProveedores" runat="server" CssClass="form-select">
                
            </asp:DropDownList>
        </div>
        
        <!-- Parcela -->
        <div class="mb-3">
            <asp:Label ID="LabelParcela" runat="server" Text="Seleccione la parcela:" AssociatedControlID="DDLParcelas" CssClass="form-label"></asp:Label>
            <asp:DropDownList ID="DDLParcelas" runat="server" CssClass="form-select">
                
            </asp:DropDownList>
        </div>

        <!-- Botones de acción -->
        <div class="mb-3 text-center">
            <asp:Button ID="BtnSave" runat="server" Text="Guardar" CssClass="btn btn-success mx-2" OnClick="BtnSave_Click" />
            <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" CssClass="btn btn-primary mx-2" OnClick="BtnUpdate_Click" />
            <asp:Label ID="LblMsj" runat="server" Text="" CssClass="text-success"></asp:Label>
        </div>

        <!-- GridView para mostrar los insumos -->
        <div class="mt-4">
            <asp:GridView ID="GVInsumos" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover" OnSelectedIndexChanged="GVInsumos_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="insu_id" HeaderText="ID" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="insu_nombre" HeaderText="Nombre" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="insu_cantidad" HeaderText="Cantidad" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="insu_fecha_entrada" HeaderText="Fecha de Adquisición" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="prov_id" HeaderText="Proveedor" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="parc_id" HeaderText="Parcela" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:CommandField ShowSelectButton="True" ButtonType="Button" ControlStyle-CssClass="btn btn-info btn-sm" SelectText="Seleccionar" />
                    <asp:CommandField ShowDeleteButton="True" ButtonType="Button" ControlStyle-CssClass="btn btn-danger btn-sm" DeleteText="Eliminar" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>


