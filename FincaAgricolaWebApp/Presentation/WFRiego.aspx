<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFRiego.aspx.cs" Inherits="Presentation.WFRiego" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center">Gestion de riego</h1>
    <div class="container-fluid">
        <div class="row mb-3">
            <div class="col-md-4">
                <asp:HiddenField ID="HFRiegoId" runat="server" />
                <%--Parcela--%>
                <asp:Label ID="Label2" runat="server" Text="Seleccione la parcela"></asp:Label>
                <asp:DropDownList ID="DDLParcelas" runat="server"></asp:DropDownList>
            </div>
            <div class="col-md-4">
                <%--Fecha--%>
                <asp:Label ID="Label3" runat="server" Text="Ingrese la fecha"></asp:Label>
                <asp:TextBox ID="TBFecha" runat="server" TextMode="Date"></asp:TextBox>
            </div>
        </div>
        <div class="row mb-3">
            <div class="col text-center">
                <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
                <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
                <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <asp:GridView ID="GVRiego" CssClass="table table-striped table-hover" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVRiego_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="rieg_id" HeaderText="id" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:BoundField DataField="parc_id" HeaderText="parcela" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:BoundField DataField="rieg_fecha" HeaderText="fecha" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="Seleccionar" ControlStyle-CssClass="btn btn-info btn-sm" />
                        <asp:CommandField ShowDeleteButton="True" ButtonType="Button" DeleteText="Eliminar" ControlStyle-CssClass="btn btn-danger btn-sm" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
