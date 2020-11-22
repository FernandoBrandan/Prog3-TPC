<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="EspecialidadesBaja.aspx.cs" Inherits="WebClinica.EspecialidadesBaja" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h1 style="margin-top: 20px;">Especialidades</h1>
     <div style="margin-top: 30px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item"><a class="page-link" href="EspecialidadesAlta.aspx">Alta</a></li>
                <li class="page-item"><a class="page-link" href="EspecialidadesModifica.aspx">Modificacion</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Baja
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
            </ul>
        </nav>
    </div>

    <div style="margin-top: 30px;">
         <h3>Desplegable desde DB</h3>
                <div class="form-group">
                    <asp:Label Text="Pokemons" runat="server" />
                    <asp:DropDownList runat="server" ID="ddlPokemons" CssClass="form-control">
                    </asp:DropDownList>
                </div>
        </div>
        <div style="margin-top: 20px;">
        <asp:Button Text="Aceptar" class="btn btn-primary"  runat="server" />
        <asp:Button Text="Cancelar" class="btn btn-primary" runat="server" />
    </div>
</asp:Content>
