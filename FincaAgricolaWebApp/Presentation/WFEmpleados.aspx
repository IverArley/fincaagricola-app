<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFEmpleados.aspx.cs" Inherits="Presentation.WFEmpleados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestión Empleados</h1>
    <asp:HiddenField ID="HFEmpleadoId" runat="server" />
    <br />

    <%-- Nombre --%>
    <asp:Label ID="LblNombreEmpleados" runat="server" Text="Ingrese el nombre del empleado"></asp:Label>
    <asp:TextBox ID="TBNombre" runat="server" style="margin-left: 20px"></asp:TextBox>
    <br />

    <%-- Rol --%>
    <asp:Label ID="LblRolEmpleados" runat="server" Text="Ingrese el cargo"></asp:Label>
    <asp:TextBox ID="TBDescripcion" runat="server" style="margin-left: 20px"></asp:TextBox>
    <br />

    <%-- Fecha de contratación --%>
    <asp:Label ID="LblFechaContratacionEmpleados" runat="server" Text="Ingrese la fecha"></asp:Label>
    <asp:TextBox ID="TBFecha" runat="server" TextMode="Date" style="margin-left: 20px"></asp:TextBox>
    <br />

    <%-- Parcela --%>
    <asp:Label ID="LblParcelaEmpleados" runat="server" Text="Seleccione la parcela"></asp:Label>
    <asp:DropDownList ID="DDLParcelas" runat="server" style="margin-left: 20px"></asp:DropDownList>
    <br />

    <asp:Label ID="LblMsj" runat="server" Text="" ForeColor="Red" />
    <br />

    <%-- Botones de acción --%>
    <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
    <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
    <br />
    <br />

    <%-- GridView para mostrar los empleados --%>
    <div>
        <asp:GridView ID="GVEmpleados" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVEmpleados_SelectedIndexChanged" Width="808px">
            <Columns>
                <asp:BoundField DataField="empl_id" HeaderText="id" />
                <asp:BoundField DataField="empl_nombre" HeaderText="nombre" />
                <asp:BoundField DataField="empl_rol" HeaderText="Rol" />
                <asp:BoundField DataField="empl_fecha_contratacion" HeaderText="Fecha de Contratación" />
                <asp:BoundField DataField="parc_id" HeaderText="Parcela" />
                
                <asp:CommandField ShowSelectButton="True" ButtonType="Button" />
                <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
