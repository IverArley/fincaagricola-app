<%@ Page Title="Gestión de Clientes" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFClientes.aspx.cs" Inherits="Presentation.WFClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center">Gestión de Clientes</h1>
    <div class="container-fluid">
        <div class="row mb-3">
            <div class="col-md-4">
                <asp:HiddenField ID="HFClienteId" runat="server" />
                <asp:Label ID="Label2" runat="server" Text="Nombre:" AssociatedControlID="TBNombre"></asp:Label>
                <asp:TextBox ID="TBNombre" CssClass="form-control" runat="server" Placeholder="Ingrese el nombre"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <asp:Label ID="Label3" runat="server" Text="Teléfono:" AssociatedControlID="TBTelefono"></asp:Label>
                <asp:TextBox ID="TBTelefono" CssClass="form-control" runat="server" Placeholder="Ingrese el teléfono"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <asp:Label ID="Label4" runat="server" Text="Dirección:" AssociatedControlID="TBDireccion"></asp:Label>
                <asp:TextBox ID="TBDireccion" CssClass="form-control" runat="server" Placeholder="Ingrese la dirección"></asp:TextBox>
            </div>
        </div>
        <div class="row mb-3">
            <div class="col text-center">
                <asp:Button ID="BtnSave" runat="server" CssClass="btn btn-success mx-2" Text="Guardar" OnClick="BtnSave_Click" />
                <asp:Button ID="BtnUpdate" runat="server" CssClass="btn btn-primary mx-2" Text="Actualizar" OnClick="BtnUpdate_Click" />
                <asp:Label ID="LblMsj" runat="server" CssClass="text-success"></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <asp:GridView ID="GVClientes" CssClass="table table-striped table-hover" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVClientes_SelectedIndexChanged"
                           OnRowDeleting="GVClientes_RowDeleting" DataKeyNames="clie_id">
                    <Columns>
                        <asp:BoundField DataField="clie_id" HeaderText="Id" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:BoundField DataField="clie_nombre" HeaderText="Nombre" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:BoundField DataField="clie_telefono" HeaderText="Teléfono" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:BoundField DataField="clie_direccion" HeaderText="Dirección" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:CommandField ShowSelectButton="True" ButtonType="Button" 
                                          SelectText="Seleccionar" 
                                          ControlStyle-CssClass="btn btn-info btn-sm" />
                        <asp:CommandField ShowDeleteButton="True" ButtonType="Button" 
                                          DeleteText="Eliminar" 
                                          ControlStyle-CssClass="btn btn-danger btn-sm" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
