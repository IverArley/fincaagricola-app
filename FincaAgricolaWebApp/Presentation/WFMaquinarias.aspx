<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFMaquinarias.aspx.cs" Inherits="Presentation.WFMaquinarias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center">Gestión de Maquinarias</h1>
    <div class="container-fluid">
        <div class="row mb-3">
            <div class="col-md-4">
                <asp:HiddenField ID="HFMaquinariaId" runat="server" />
                <%--Tipo--%>
                <asp:Label ID="LabelTipo" runat="server" Text="Ingrese el tipo de maquinaria"></asp:Label>
                <asp:TextBox ID="TBTipo" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <%--Fecha de Adquisición--%>
                <asp:Label ID="LabelFechaAdquisicion" runat="server" Text="Ingrese la fecha de adquisición"></asp:Label>
                <asp:TextBox ID="TBFechaAdquisicion" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>
            </div>
            <%--Estado--%>
            <div class="col-md-4">
                <asp:Label ID="LabelEstado" runat="server" Text="Ingrese el estado de la maquinaria"></asp:Label>
                <asp:TextBox ID="TBEstado" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <%--Parcela--%>
            <div class="col-md-4">
                <asp:Label ID="LabelParcela" runat="server" Text="Seleccione la parcela"></asp:Label>
                <asp:DropDownList ID="DDLParcelas" CssClass="form-control" runat="server"></asp:DropDownList>
            </div>
            <div class="row mb-3">
                <div class="col text-center">
                    <asp:Button ID="BtnSave" runat="server" CssClass="btn btn-success mx-2" Text="Guardar" OnClick="BtnSave_Click" />
                    <asp:Button ID="BtnUpdate" runat="server" CssClass="btn btn-primary mx-2" Text="Actualizar" OnClick="BtnUpdate_Click" />
                    <asp:Label ID="LblMsj" runat="server" CssClass="table table-striped table-hover"></asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <asp:GridView ID="GVMaquinaria" CssClass="table table-striped table-hover" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVMaquinaria_SelectedIndexChanged">
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
            </div>
        </div>
    </div>
</asp:Content>
