<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFParcelas.aspx.cs" Inherits="Presentation.WFParcelas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center mb-4">Gestión de Parcelas</h1>
    <div class="container">
        <asp:HiddenField ID="HFParcelasID" runat="server" />
        
        <!-- Tamaño -->
        <div class="mb-3">
            <asp:Label ID="LblTamanoParcelas" runat="server" Text="Ingrese el tamaño" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBTamano" runat="server" CssClass="form-control" Placeholder="Tamaño de la parcela"></asp:TextBox>
        </div>
        
        <!-- Ubicación -->
        <div class="mb-3">
            <asp:Label ID="LblUbicacionParcela" runat="server" Text="Ingrese la ubicación" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBUbicacion" runat="server" CssClass="form-control" Placeholder="Ubicación de la parcela"></asp:TextBox>
        </div>
        
        <!-- Finca -->
        <div class="mb-3">
            <asp:Label ID="LblFincaParcelas" runat="server" Text="Seleccione la finca" CssClass="form-label"></asp:Label>
            <asp:DropDownList ID="DDLFinca" runat="server" CssClass="form-select"></asp:DropDownList>
        </div>

        <!-- Botones de acción -->
        <div class="mb-3 text-center">
            <asp:Button ID="BtnSave" runat="server" Text="Guardar" CssClass="btn btn-success mx-2" OnClick="BtnSave_Click" />
            <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" CssClass="btn btn-primary mx-2" OnClick="BtnUpdate_Click" />
            <asp:Label ID="LblMsj" runat="server" Text="" CssClass="text-success"></asp:Label>
        </div>
        
        <!-- GridView -->
        <div class="table-responsive mt-4">
            <asp:GridView ID="GVParcelas" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover" OnSelectedIndexChanged="GVParcelas_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="parc_id" HeaderText="ID" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="parc_tamano" HeaderText="Tamaño" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="parc_ubicacion" HeaderText="Ubicación" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="finc_id" HeaderText="Finca" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:CommandField ShowSelectButton="True" ButtonType="Button" ControlStyle-CssClass="btn btn-info btn-sm" SelectText="Seleccionar" />
                    <asp:CommandField ShowDeleteButton="True" ButtonType="Button" ControlStyle-CssClass="btn btn-danger btn-sm" DeleteText="Eliminar" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
