<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFFinca.aspx.cs" Inherits="Presentation.WFFinca" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center mb-4">Gestión de Finca</h1>
    <div class="container">
        <asp:HiddenField ID="HFClienteId" runat="server" />
        
        <!-- Nombre -->
        <div class="mb-3">
            <asp:Label ID="LblNombreFinca" runat="server" Text="Ingrese el nombre" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBNombre" runat="server" CssClass="form-control" Placeholder="Nombre de la finca"></asp:TextBox>
        </div>
        
        <!-- Ubicación -->
        <div class="mb-3">
            <asp:Label ID="LblUbicacionFinca" runat="server" Text="Ingrese la ubicación" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBUbicacion" runat="server" CssClass="form-control" Placeholder="Ubicación de la finca"></asp:TextBox>
        </div>
        
        <!-- Tamaño -->
        <div class="mb-3">
            <asp:Label ID="LblTamanoFinca" runat="server" Text="Ingrese el tamaño" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBTamano" runat="server" CssClass="form-control" Placeholder="Tamaño de la finca"></asp:TextBox>
        </div>
        
        <!-- Botones de acción -->
        <div class="mb-3 text-center">
            <asp:Button ID="BtnSave" runat="server" Text="Guardar" CssClass="btn btn-success mx-2" OnClick="BtnSave_Click" />
            <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" CssClass="btn btn-primary mx-2" OnClick="BtnUpdate_Click" />
            <asp:Label ID="LblMsj" runat="server" Text="" CssClass="text-success"></asp:Label>
        </div>
        
        <!-- GridView -->
        <div class="table-responsive mt-4">
            <asp:GridView ID="GVFinca" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover" OnSelectedIndexChanged="GVFinca_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="finc_id" HeaderText="ID" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="finc_nombre" HeaderText="Nombre" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="finc_ubicacion" HeaderText="Ubicación" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="finc_tamano" HeaderText="Tamaño" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:CommandField ShowSelectButton="True" ButtonType="Button" ControlStyle-CssClass="btn btn-info btn-sm" SelectText="Seleccionar" />
                    <asp:CommandField ShowDeleteButton="True" ButtonType="Button" ControlStyle-CssClass="btn btn-danger btn-sm" DeleteText="Eliminar" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>

