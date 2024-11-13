<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFInsumos.aspx.cs" Inherits="Presentation.WFInsumos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestión de Insumos</h1>
    <asp:HiddenField ID="HFInsumoId" runat="server" />
    <br />
    <%-- Nombre --%>
    <asp:Label ID="Label3" runat="server" Text="Ingrese el nombre"></asp:Label>
    <asp:TextBox ID="TBNombre" runat="server"></asp:TextBox>
    <br />
    <%-- Cantidad --%>
    <asp:Label ID="Label4" runat="server" Text="Ingrese la cantidad "></asp:Label>
    <asp:TextBox ID="TBCantidad" runat="server"></asp:TextBox>
    <br />
    <%-- Fecha de adquisición --%>
    <asp:Label ID="Label5" runat="server" Text="Ingrese la fecha de adquisición"></asp:Label>
    <asp:TextBox ID="TBFechaAdquisicion" runat="server" TextMode="Date"></asp:TextBox>
    <br />
    <%-- Proveedor --%>
    <asp:Label ID="LabelProveedor" runat="server" Text="Seleccione el proveedor"></asp:Label>
    <asp:DropDownList ID="DDLProveedores" runat="server"></asp:DropDownList>
    <br />
    <%-- Parcela --%>
    <asp:Label ID="LabelParcela" runat="server" Text="Seleccione la parcela"></asp:Label>
    <asp:DropDownList ID="DDLParcelas" runat="server"></asp:DropDownList>
    <br />
    <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
    <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
    <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
    <br />
    <div>
        <asp:GridView ID="GVInsumos" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVInsumos_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="insu_id" HeaderText="id" />
                <asp:BoundField DataField="insu_nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="insu_cantidad" HeaderText="Cantidad" />
                <asp:BoundField DataField="insu_fecha_entrada" HeaderText="Fecha de Adquisición" />
                <asp:BoundField DataField="prov_id" HeaderText="Proveedor" />
                <asp:BoundField DataField="parc_id" HeaderText="Parcela" />
                <asp:CommandField ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
                <asp:CommandField ShowDeleteButton="True" ButtonType="Button"></asp:CommandField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
