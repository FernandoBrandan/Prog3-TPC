<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="TurnosLista.aspx.cs" Inherits="WebClinica.TurnosLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div style="margin-top: 50px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Listado
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
                <li class="page-item"><a class="page-link" href="TurnosAlta.aspx">Alta</a></li>
            </ul>
        </nav>
    </div>

        <h1 style="margin-top: 20px;">Listado de Turnos</h1>
    <asp:GridView runat="server"> </asp:GridView>
</asp:Content>
