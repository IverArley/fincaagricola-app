<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Presentation.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Aquí puedes agregar CSS adicional o referencias de JavaScript -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1></h1>

    <!-- Carousel de Bootstrap -->
    <div id="carouselExampleInterval" class="carousel slide" data-bs-ride="carousel">
        <div class="carousel-inner">
            <div class="carousel-item active" data-bs-interval="10000">
                <img src="resources/imagenes/inicio1.jpg" class="d-block w-100" alt="Descripción de la imagen 1">
            </div>
            <div class="carousel-item" data-bs-interval="2000">
                <img src="resources/imagenes/inicio2.jpg" class="d-block w-100" alt="Descripción de la imagen 2">
            </div>
            <div class="carousel-item">
                <img src="resources/imagenes/inicio4.jpg" class="d-block w-100" alt="Descripción de la imagen 3">
            </div>
        </div>
        <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleInterval" data-bs-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Anterior</span>
        </button>
        <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleInterval" data-bs-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Siguiente</span>
        </button>
    </div>
</asp:Content>

