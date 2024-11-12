<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFMaquinarias.aspx.cs" Inherits="Presentation.WFMaquinarias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestión de Maquinarias</h1>
    <asp:HiddenField ID="HFMaquinariaId" runat="server" />
    <br />
    <%--Tipo--%>
    <asp:Label ID="LabelTipo" runat="server" Text="Ingrese el tipo de maquinaria"></asp:Label>
    <asp:TextBox ID="TBTipo" runat="server"></asp:TextBox>
    <br />
    <%--Fecha de Adquisición--%>
    <asp:Label ID="LabelFechaAdquisicion" runat="server" Text="Ingrese la fecha de adquisición"></asp:Label>
    <asp:TextBox ID="TBFechaAdquisicion" runat="server" TextMode="Date"></asp:TextBox>
    <br />
    <%--Estado--%>
    <asp:Label ID="LabelEstado" runat="server" Text="Ingrese el estado de la maquinaria"></asp:Label>
    <asp:TextBox ID="TBEstado" runat="server"></asp:TextBox>
    <br />
    <%--Parcela--%>
    <asp:Label ID="LabelParcela" runat="server" Text="Seleccione la parcela"></asp:Label>
    <asp:DropDownList ID="DDLParcelas" runat="server"></asp:DropDownList>
    <br />
    <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
    <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
    <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
    <br />
    <div>
        <asp:GridView ID="GVMaquinaria" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVMaquinaria_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="maqu_id" HeaderText="ID" />
                <asp:BoundField DataField="maqu_tipo" HeaderText="Tipo" />
                <asp:BoundField DataField="maqu_fecha_adquisicion" HeaderText="Fecha de Adquisición" />
                <asp:BoundField DataField="maqu_estado" HeaderText="Estado" />
                <asp:BoundField DataField="parc_id" HeaderText="Parcela" />
                <asp:CommandField ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
                <asp:CommandField ShowDeleteButton="True" ButtonType="Button"></asp:CommandField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
