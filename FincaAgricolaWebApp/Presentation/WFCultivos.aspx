<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFCultivos.aspx.cs" Inherits="Presentation.WFCultivos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestion de Cultivos</h1>
    <asp:HiddenField ID="HFCultivoId" runat="server" />
    <br />
    <%--Nombre--%>
    <asp:Label ID="Label3" runat="server" Text="Ingrese el nombre"></asp:Label>
   <asp:TextBox ID="TBNombre" runat="server"></asp:TextBox>
    <br />
    <%--Fecha--%>
    <asp:Label ID="Label4" runat="server" Text="Ingrese la fecha "></asp:Label>
     <asp:TextBox ID="TBFecha" runat="server" TextMode="Date"></asp:TextBox>
    <br />
    <%--Estado--%>
    <asp:Label ID="Label5" runat="server" Text="Ingrese el estado"></asp:Label>
    <asp:TextBox ID="TBEstado" runat="server"></asp:TextBox>
    <br />
    <%--Parcela--%>
    <asp:Label ID="Label2" runat="server" Text="Seleccione la parcela"></asp:Label>
    <asp:DropDownList ID="DDLParcelas" runat="server"></asp:DropDownList>
    <br />
    <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
    <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
    <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
    <br />
    <div>
        <asp:GridView ID="GVCultivo" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVCultivo_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="cult_id" HeaderText="id" />
                <asp:BoundField DataField="cult_nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="cult_fecha_siembra" HeaderText="Fecha" />
                <asp:BoundField DataField="cult_estado" HeaderText="Estado" />
                <asp:BoundField DataField="parc_id" HeaderText="Parcela" />
                <asp:CommandField ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
                <asp:CommandField ShowDeleteButton="True" ButtonType="Button"></asp:CommandField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
