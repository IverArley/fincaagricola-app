<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFClima.aspx.cs" Inherits="Presentation.WFClima" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestion de clima</h1>
    <asp:HiddenField ID="HFClimaId" runat="server" />
    <br />
    <%--Parcela--%>
    <asp:Label ID="Label2" runat="server" Text="Seleccione la parcela"></asp:Label>
    <asp:DropDownList ID="DDLParcelas" runat="server"></asp:DropDownList>
    <br />
    <%--Fecha--%>
    <asp:Label ID="Label3" runat="server" Text="Ingrese la fecha"></asp:Label>
    <asp:TextBox ID="TBFecha" runat="server" TextMode="Date"></asp:TextBox>
    <br />
    <%--Humedad--%>
    <asp:Label ID="Label4" runat="server" Text="Ingrese la humedad"></asp:Label>
    <asp:TextBox ID="TBHumedad" runat="server"></asp:TextBox>
    <br />
    <%--Temperatura--%>
    <asp:Label ID="Label5" runat="server" Text="Ingrese la temperatura"></asp:Label>
    <asp:TextBox ID="TBTemperatura" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
    <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
    <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
    <br />
    <div>
        <asp:GridView ID="GVClima" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVClima_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="clim_id" HeaderText="id" />
                <asp:BoundField DataField="parc_id" HeaderText="parcela" />
                <asp:BoundField DataField="clim_fecha" HeaderText="fecha" />
                <asp:BoundField DataField="clim_humedad" HeaderText="humedad" />
                <asp:BoundField DataField="clim_temperatura" HeaderText="temperatura" />
                <asp:CommandField ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
                <asp:CommandField ShowDeleteButton="True" ButtonType="Button"></asp:CommandField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
