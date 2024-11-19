<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFCultivos.aspx.cs" Inherits="Presentation.WFCultivos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center">Gestion de Cultivos</h1>
    <div class="container-fluid">
        <div class="row mb-3">
            <div class="col-md-4">
                <asp:HiddenField ID="HFCultivoId" runat="server" />
                <%--Nombre--%>
                <asp:Label ID="Label3" runat="server" Text="Ingrese el nombre"></asp:Label>
                <asp:TextBox ID="TBNombre" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <%--Fecha--%>
                <asp:Label ID="Label4" runat="server" Text="Ingrese la fecha "></asp:Label>
                <asp:TextBox ID="TBFecha" runat="server" TextMode="Date"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <%--Estado--%>
                <asp:Label ID="Label5" runat="server" Text="Ingrese el estado"></asp:Label>
                <asp:TextBox ID="TBEstado" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <%--Parcela--%>
                <asp:Label ID="Label2" runat="server" Text="Seleccione la parcela"></asp:Label>
                <asp:DropDownList ID="DDLParcelas" runat="server"></asp:DropDownList>
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
                <asp:GridView ID="GVCultivo" CssClass="table table-striped table-hover" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVCultivo_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="cult_id" HeaderText="id" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:BoundField DataField="cult_nombre" HeaderText="Nombre" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:BoundField DataField="cult_fecha_siembra" HeaderText="Fecha" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:BoundField DataField="cult_estado" HeaderText="Estado" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:BoundField DataField="parc_id" HeaderText="Parcela" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="Seleccionar" ControlStyle-CssClass="btn btn-info btn-sm" />
                        <asp:CommandField ShowDeleteButton="True" ButtonType="Button" DeleteText="Eliminar" ControlStyle-CssClass="btn btn-danger btn-sm" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
