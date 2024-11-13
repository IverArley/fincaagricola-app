<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFRiego.aspx.cs" Inherits="Presentation.WFRiego" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestion de riego</h1>
    <asp:HiddenField ID="HFRiegoId" runat="server" />
    <br />
    <%--Parcela--%>
    <asp:Label ID="Label2" runat="server" Text="Seleccione la parcela"></asp:Label>
    <asp:DropDownList ID="DDLParcelas" runat="server"></asp:DropDownList>
    <br />
    <%--Fecha--%>
    <asp:Label ID="Label3" runat="server" Text="Ingrese la fecha"></asp:Label>
    <asp:TextBox ID="TBFecha" runat="server" TextMode="Date"></asp:TextBox>
    <br />
    <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
    <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
    <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
    <br />
    <div>
        <asp:GridView ID="GVRiego" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVRiego_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="rieg_id" HeaderText="id" />
                <asp:BoundField DataField="parc_id" HeaderText="parcela" />
                <asp:BoundField DataField="rieg_fecha" HeaderText="fecha" />
                <asp:CommandField ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
                <asp:CommandField ShowDeleteButton="True" ButtonType="Button"></asp:CommandField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
