<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFFinca.aspx.cs" Inherits="Presentation.WFFinca" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestion Finca</h1>
    <asp:HiddenField ID="HFClienteId" runat="server" />
    <br />
    <%--Nombre--%>
    <asp:Label ID="LblNombreFinca" runat="server" Text="Ingrese el nombre"></asp:Label>
    <asp:TextBox ID="TBNombre" runat="server" style="margin-left: 20px"></asp:TextBox>
    <br />
    <%--Ubicacion--%>
    <asp:Label ID="LblUbicacionFinca" runat="server" Text="Ingrese la ubicacion"></asp:Label>
    <asp:TextBox ID="TBUbicacion" runat="server" style="margin-left: 20px"></asp:TextBox>
    <br />
    <%--Tamaño--%>
    <asp:Label ID="LblTamanoFinca" runat="server" Text="Ingrese el tamaño"></asp:Label>
    <asp:TextBox ID="TBTamano" runat="server" style="margin-left: 20px"></asp:TextBox>
    <br />
    <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click"/>
    <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar"  OnClick="BtnUpdate_Click"/>
    
    <br />
    
    <br />
     <div>
     <asp:GridView ID="GVFinca" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVFinca_SelectedIndexChanged" Width="652px">
         <Columns>
             <asp:BoundField DataField="finc_id" HeaderText="id"/>
             <asp:BoundField DataField="finc_nombre" HeaderText="nombre"/>
             <asp:BoundField DataField="finc_ubicacion" HeaderText="ubicacion"/>
             <asp:BoundField DataField="finc_tamano" HeaderText="tamaño"/>

             <asp:CommandField ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
             <asp:CommandField ShowDeleteButton="True" ButtonType="Button"></asp:CommandField>
         </Columns>
     </asp:GridView>
 </div>
</asp:Content>

