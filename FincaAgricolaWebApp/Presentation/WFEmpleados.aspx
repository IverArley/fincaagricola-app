<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFEmpleados.aspx.cs" Inherits="Presentation.WFEmpleados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestion Empleados</h1>
    <asp:HiddenField ID="HFClienteId" runat="server" />
    <br />
    <%--Nombre--%>
    <asp:Label ID="LblNombreEmpleados" runat="server" Text="Ingrese el nombre del empleado"></asp:Label>
    <asp:TextBox ID="TBNombre" runat="server" style="margin-left: 20px"></asp:TextBox>
    <br />
    <%--Rol--%>
    <asp:Label ID="LblRolEmpleados" runat="server" Text="Ingrese la descripcion"></asp:Label>
    <asp:TextBox ID="TBDescripcion" runat="server" style="margin-left: 20px"></asp:TextBox>
    <br />
    <%--Fecha de contratacion--%>
    <asp:Label ID="LblFechaContratacionEmpleados" runat="server" Text="Ingrese el precio"></asp:Label>
    <asp:TextBox ID="TBTamano" runat="server" style="margin-left: 20px"></asp:TextBox>
    <br />
    <%--Parcela--%>
    <asp:Label ID="LblParcelaEmpleados" runat="server" Text="Ingrese la parcela"></asp:Label>
    <asp:TextBox ID="TBParcela" runat="server" style="margin-left: 20px"></asp:TextBox>
    <br />

    <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click"/>
    <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar"  OnClick="BtnUpdate_Click"/>
    <br />
    <br />
     <div>
     <asp:GridView ID="GVEmpleados" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVEmpleados_SelectedIndexChanged" Width="808px">
         <Columns>
             <asp:BoundField DataField="empl_id" HeaderText="id"/>
             <asp:BoundField DataField="empl_nombre" HeaderText="nombre"/>
             <asp:BoundField DataField="empl_rol" HeaderText="Rol"/>
             <asp:BoundField DataField="empl_fecha_contratacion" HeaderText="Fecha contratacion"/>
             <asp:BoundField DataField="parc_id" HeaderText="parcela"/>

             <asp:CommandField ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
             <asp:CommandField ShowDeleteButton="True" ButtonType="Button"></asp:CommandField>
         </Columns>
     </asp:GridView>
 </div>
</asp:Content>
