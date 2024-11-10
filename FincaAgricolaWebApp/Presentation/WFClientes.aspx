<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFClientes.aspx.cs" Inherits="Presentation.WFClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestion de clientes</h1>
    <asp:HiddenField ID="HFClienteId" runat="server" />
    <br />
    <%--Nombre--%>
    <asp:Label ID="Label2" runat="server" Text="Ingrese el nombre"></asp:Label>
    <asp:TextBox ID="TBNombre" runat="server"></asp:TextBox>
    <br />
    <%--Telefono--%>
    <asp:Label ID="Label3" runat="server" Text="Ingrese el telefono"></asp:Label>
    <asp:TextBox ID="TBTelefono" runat="server"></asp:TextBox>
    <br />
    <%--Direccion--%>
    <asp:Label ID="Label4" runat="server" Text="Ingrese la direccion"></asp:Label>
    <asp:TextBox ID="TBDireccion" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click"/>
    <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar"  OnClick="BtnUpdate_Click"/>
    <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
    <br />
     <div>
     <asp:GridView ID="GVClientes" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVClientes_SelectedIndexChanged">
         <Columns>
             <asp:BoundField DataField="clie_id" HeaderText="id"/>
             <asp:BoundField DataField="clie_nombre" HeaderText="nombre"/>
             <asp:BoundField DataField="clie_telefono" HeaderText="telefono"/>
             <asp:BoundField DataField="clie_direccion" HeaderText="direccion"/>
             <asp:CommandField ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
             <asp:CommandField ShowDeleteButton="True" ButtonType="Button"></asp:CommandField>
         </Columns>
     </asp:GridView>
 </div>
</asp:Content>
