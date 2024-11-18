<%@ Page Title="Gestión de Control de Riego" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFArduino.aspx.cs" Inherits="Presentation.WFArduino" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center">Gestión de Control de Riego</h1>
    <div class="container-fluid">
        <div class="row mb-3">
            <div class="col-md-4">
                <%-- Campo oculto para el ID --%>
                <asp:HiddenField ID="HFControlRiegoId" runat="server" />
                <asp:Label ID="LblHumedad" runat="server" Text="Humedad (%):" AssociatedControlID="TBHumedad"></asp:Label>
                <asp:TextBox ID="TBHumedad" CssClass="form-control" runat="server" Placeholder="Ingrese la humedad"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <asp:Label ID="LblClima" runat="server" Text="Clima:" AssociatedControlID="TBClima"></asp:Label>
                <asp:TextBox ID="TBClima" CssClass="form-control" runat="server" Placeholder="Ingrese el clima"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <asp:Label ID="LblCantidadAgua" runat="server" Text="Cantidad de Agua (L):" AssociatedControlID="TBCantidadAgua"></asp:Label>
                <asp:TextBox ID="TBCantidadAgua" CssClass="form-control" runat="server" Placeholder="Ingrese la cantidad de agua"></asp:TextBox>
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
                <%-- Tabla de datos --%>
                <asp:GridView ID="GVControlRiego" CssClass="table table-striped table-hover" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVControlRiego_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="ID" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:BoundField DataField="humedad" HeaderText="Humedad (%)" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:BoundField DataField="clima" HeaderText="Clima" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:BoundField DataField="cantidad_agua" HeaderText="Cantidad de Agua (L)" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:BoundField DataField="fecha_registro" HeaderText="Fecha" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:CommandField ShowSelectButton="True" ButtonType="Button" 
                                          SelectText="Seleccionar" 
                                          ControlStyle-CssClass="btn btn-info btn-sm" />
                        <asp:CommandField ShowDeleteButton="True" ButtonType="Button" 
                                          DeleteText="Eliminar" 
                                          ControlStyle-CssClass="btn btn-danger btn-sm" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
