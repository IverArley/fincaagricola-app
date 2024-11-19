<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFClima.aspx.cs" Inherits="Presentation.WFClima" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center mb-4">Gestión de Clima</h1>
    <div class="container">
        <asp:HiddenField ID="HFClimaId" runat="server" />
        
        <!-- Parcela -->
        <div class="mb-3">
            <asp:Label ID="Label2" runat="server" Text="Seleccione la parcela" CssClass="form-label"></asp:Label>
            <asp:DropDownList ID="DDLParcelas" runat="server" CssClass="form-select">
            </asp:DropDownList>
        </div>
        
        <!-- Fecha -->
        <div class="mb-3">
            <asp:Label ID="Label3" runat="server" Text="Ingrese la fecha" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBFecha" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
        </div>
        
        <!-- Humedad -->
        <div class="mb-3">
            <asp:Label ID="Label4" runat="server" Text="Ingrese la humedad" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBHumedad" runat="server" CssClass="form-control" Placeholder="Ingrese la humedad"></asp:TextBox>
        </div>
        
        <!-- Temperatura -->
        <div class="mb-3">
            <asp:Label ID="Label5" runat="server" Text="Ingrese la temperatura" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBTemperatura" runat="server" CssClass="form-control" Placeholder="Ingrese la temperatura"></asp:TextBox>
        </div>

        <!-- Botones de acción -->
        <div class="mb-3 text-center">
            <asp:Button ID="BtnSave" runat="server" Text="Guardar" CssClass="btn btn-success mx-2" OnClick="BtnSave_Click" />
            <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" CssClass="btn btn-primary mx-2" OnClick="BtnUpdate_Click" />
            <asp:Label ID="LblMsj" runat="server" Text="" CssClass="text-success"></asp:Label>
        </div>

        <!-- GridView para mostrar los registros del clima -->
        <div class="mt-4">
            <asp:GridView ID="GVClima" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover" OnSelectedIndexChanged="GVClima_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="clim_id" HeaderText="ID" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="parc_id" HeaderText="Parcela" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="clim_fecha" HeaderText="Fecha" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="clim_humedad" HeaderText="Humedad" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="clim_temperatura" HeaderText="Temperatura" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:CommandField ShowSelectButton="True" ButtonType="Button" ControlStyle-CssClass="btn btn-info btn-sm" SelectText="Seleccionar" />
                    <asp:CommandField ShowDeleteButton="True" ButtonType="Button" ControlStyle-CssClass="btn btn-danger btn-sm" DeleteText="Eliminar" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>

