<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFEmpleados.aspx.cs" Inherits="Presentation.WFEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center">Gestión Empleados</h1>
    <div class="container-fluid">
        <div class="row mb-3">
            <div class="col-md-4">
                <asp:HiddenField ID="HFEmpleadoId" runat="server" />
                <%-- Nombre --%>
                <asp:Label ID="LblNombreEmpleados" runat="server" Text="Ingrese el nombre del empleado"></asp:Label>
                <asp:TextBox ID="TBNombre" runat="server" CssClass="form-control""></asp:TextBox>
            </div>
            <div class="col-md-4">
                <%-- Rol --%>
                <asp:Label ID="LblRolEmpleados" runat="server" Text="Ingrese el cargo"></asp:Label>
                <asp:TextBox ID="TBDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <%-- Fecha de contratación --%>
                <asp:Label ID="LblFechaContratacionEmpleados" runat="server" Text="Ingrese la fecha"></asp:Label>
                <asp:TextBox ID="TBFecha" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <%-- Parcela --%>
                <asp:Label ID="LblParcelaEmpleados" runat="server" Text="Seleccione la parcela"></asp:Label>
                <asp:DropDownList ID="DDLParcelas" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
        </div>
        <div class="row mb-3">
            <div class="col text-center">
                <%-- Botones de acción --%>
                <asp:Button ID="BtnSave" runat="server" CssClass="btn btn-success mx-2" Text="Guardar" OnClick="BtnSave_Click" />
                <asp:Button ID="BtnUpdate" runat="server" CssClass="btn btn-primary mx-2" Text="Actualizar" OnClick="BtnUpdate_Click" />
                <asp:Label ID="LblMsj" runat="server" CssClass="text-success" />
            </div>
        </div>
        <%-- GridView para mostrar los empleados --%>
        <div class="row">
            <div class="col">
                <asp:GridView ID="GVEmpleados" CssClass="table table-striped table-hover" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVEmpleados_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="empl_id" HeaderText="id" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center"/>
                        <asp:BoundField DataField="empl_nombre" HeaderText="nombre" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center"/>
                        <asp:BoundField DataField="empl_rol" HeaderText="Rol" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center"/>
                        <asp:BoundField DataField="empl_fecha_contratacion" HeaderText="Fecha de Contratación" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center"/>
                        <asp:BoundField DataField="parc_id" HeaderText="Parcela" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center"/>
                        <asp:CommandField ShowSelectButton="True" ButtonType="Button"  SelectText="Seleccionar" ControlStyle-CssClass="btn btn-info btn-sm" />
                        <asp:CommandField ShowDeleteButton="True" ButtonType="Button"  DeleteText="Eliminar" ControlStyle-CssClass="btn btn-danger btn-sm"/>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
