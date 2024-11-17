<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFParcelas.aspx.cs" Inherits="Presentation.WFParcelas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestion Parcelas</h1>
    <asp:HiddenField ID="HFParcelasID" runat="server" />
    <br />
     <%--Tamaño--%>
    <asp:Label ID="LblTamanoParcelas" runat="server" Text="Ingrese el tamaño"></asp:Label>
    <asp:TextBox ID="TBTamano" runat="server" style="margin-left: 20px"></asp:TextBox>
    <br />
    <%--Ubicacion--%>
    <asp:Label ID="LblUbicacionParcela" runat="server" Text="Ingrese la ubicacion"></asp:Label>
    <asp:TextBox ID="TBUbicacion" runat="server" style="margin-left: 20px"></asp:TextBox>
    <br />
    <%--Finca--%>
    <asp:Label ID="LblFincaParcelas" runat="server" Text="Ingrese la finca"></asp:Label>
    <asp:DropDownList ID="DDLFinca" runat="server"></asp:DropDownList>
    <br />

    <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click"/>
    <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar"  OnClick="BtnUpdate_Click"/>
    <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
    <br />
    <br />
     <div>
     <asp:GridView ID="GVParcelas" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVParcelas_SelectedIndexChanged" Width="573px">
         <Columns>
             <asp:BoundField DataField="parc_id" HeaderText="id"/>
             <asp:BoundField DataField="parc_tamano" HeaderText="tamaño"/>
             <asp:BoundField DataField="parc_ubicacion" HeaderText="ubicacion"/>
             <asp:BoundField DataField="finc_id" HeaderText="finca"/>

             <asp:CommandField ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
             <asp:CommandField ShowDeleteButton="True" ButtonType="Button"></asp:CommandField>
         </Columns>
     </asp:GridView>
 </div>
</asp:Content>