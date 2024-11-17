<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFVentas.aspx.cs" Inherits="Presentation.WFVentas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center">Gestión de Ventas</h1>
    <div class="container-fluid">
        <div class="row mb-3">
            <div class="col-md-4">
                <asp:HiddenField ID="HFVentaID" runat="server" />
                <asp:Label ID="LblClienteVenta" runat="server" Text="Seleccione el cliente" AssociatedControlID="DDLCliente"></asp:Label>
                <asp:DropDownList ID="DDLCliente" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
            <div class="col-md-4">
                <asp:Label ID="LblFechaVenta" runat="server" Text="Ingrese la fecha" AssociatedControlID="TBFecha"></asp:Label>
                <asp:TextBox ID="TBFecha" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <asp:Label ID="LblMontoVenta" runat="server" Text="Ingrese el monto" AssociatedControlID="TBMonto"></asp:Label>
                <asp:TextBox ID="TBMonto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="row mb-3">
            <div class="col text-center">
                <asp:Button ID="BtnSave" runat="server" CssClass="btn btn-success mx-2" Text="Guardar" OnClick="BtnSave_Click" />
                <asp:Button ID="BtnUpdate" runat="server" CssClass="btn btn-primary mx-2" Text="Actualizar" OnClick="BtnUpdate_Click" />
                <asp:Label ID="LblMsj" runat="server" Text="" CssClass="text-success"></asp:Label>
            </div>
        </div>

        <!-- Ajuste del GridView -->
        <div class="row">
            <div class="col">
                <div class="table-responsive"> <!-- Hace la tabla ajustable al tamaño del contenedor -->
                    <asp:GridView ID="GVVentas" CssClass="table table-striped table-hover" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVVentas_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="vent_id" HeaderText="ID" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                            <asp:BoundField DataField="clie_id" HeaderText="Cliente" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                            <asp:BoundField DataField="vent_fecha" HeaderText="Fecha" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                            <asp:BoundField DataField="vent_monto" HeaderText="Monto" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                            <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="Seleccionar" ControlStyle-CssClass="btn btn-info btn-sm" />
                            <asp:CommandField ShowDeleteButton="True" ButtonType="Button" DeleteText="Eliminar" ControlStyle-CssClass="btn btn-danger btn-sm" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>


