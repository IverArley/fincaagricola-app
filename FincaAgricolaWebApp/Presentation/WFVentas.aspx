<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFVentas.aspx.cs" Inherits="Presentation.WFVentas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestión de Ventas</h1>
    <asp:HiddenField ID="HFVentaID" runat="server" />
    <br />

    <%-- Cliente --%>
    <asp:Label ID="LblClienteVenta" runat="server" Text="Seleccione el cliente"></asp:Label>
    <asp:DropDownList ID="DDLCliente" runat="server" style="margin-left: 20px"></asp:DropDownList>
    <br />

    <%-- Fecha --%>
    <asp:Label ID="LblFechaVenta" runat="server" Text="Ingrese la fecha"></asp:Label>
    <asp:TextBox ID="TBFecha" runat="server" style="margin-left: 20px" TextMode="Date"></asp:TextBox>
    <br />

    <%-- Monto --%>
    <asp:Label ID="LblMontoVenta" runat="server" Text="Ingrese el monto"></asp:Label>
    <asp:TextBox ID="TBMonto" runat="server" style="margin-left: 20px"></asp:TextBox>
    <br />

    <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
    <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
    <asp:Label ID="LblMsj" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
    <br />

    <div>
        <asp:GridView ID="GVVentas" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVVentas_SelectedIndexChanged" Width="573px">
            <Columns>
                <asp:BoundField DataField="vent_id" HeaderText="ID" />
                <asp:BoundField DataField="clie_id" HeaderText="Cliente" />
                <asp:BoundField DataField="vent_fecha" HeaderText="Fecha" />
                <asp:BoundField DataField="vent_monto" HeaderText="Monto" />

                <asp:CommandField ShowSelectButton="True" ButtonType="Button" />
                <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

