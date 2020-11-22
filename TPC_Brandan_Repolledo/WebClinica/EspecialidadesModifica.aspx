<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="EspecialidadesModifica.aspx.cs" Inherits="WebClinica.EspecialidadesModifica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h1 style="margin-top: 20px;">Especialidades</h1>
    <div style="margin-top: 30px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item"><a class="page-link" href="EspecialidadesAlta.aspx">Alta</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Modificacion
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
                <li class="page-item"><a class="page-link" href="EspecialidadesBaja.aspx">Baja</a></li>
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
    <div class="form-row">
        <div class="form-group col-md-4">
            <label>Nombre</label>
            <asp:TextBox class="form-control" ID="TextEspecNombre" runat="server" />
        </div>
        <div class="form-group col-md-6">
            <label>Descripcion</label>
            <asp:TextBox class="form-control" ID="TextEspecDescripcion" runat="server" />
        </div>
    </div>
    </div>
    <div style="margin-top: 20px;">
        <asp:Button Text="Aceptar" class="btn btn-primary" runat="server" />
        <asp:Button Text="Cancelar" class="btn btn-primary" runat="server" />
    </div>
</asp:Content>
