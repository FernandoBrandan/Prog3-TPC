<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="UsuariosModifica.aspx.cs" Inherits="WebClinica.UsuariosModifica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top: 50px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item"><a class="page-link" href="UsuariosAlta.aspx">Alta</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Modificacion
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
                <li class="page-item"><a class="page-link" href="UsuariosBaja.aspx">Baja</a></li>
            </ul>
        </nav>
    </div>

    <h1 style="margin-top: 20px; margin-bottom: 20px">Baja de Usuario</h1>
    <h4>Ingresar DNI o Codigo del Usuario</h4>
    <div style="margin-top: 30px;">
        <div class="form-group col-md-3">
            <label>Buscar</label>
            <asp:TextBox class="form-control" placeholder="IdMedico" ID="TextBuscar" runat="server" Width="887px" />
            <asp:Button Text="Aceptar" class="btn btn-primary" runat="server" OnClick="Click_BuscarUsuario" />
            <asp:Button Text="Borrar" class="btn btn-primary" runat="server" OnClick="Click_BorrarListado" />
            <asp:GridView id="gvBusqueda" runat="server">   </asp:GridView>
        </div>

        <div class="form-row">
            <div class="form-group col-md-3">
                <label>DNI</label>
                <asp:TextBox class="form-control" ID="TextModDNI" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Nombre</label>
                <asp:TextBox class="form-control" ID="TextModNombre" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Apellido</label>
                <asp:TextBox class="form-control" ID="TextModApellido" runat="server" />
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-3">
                <label>Domicilio</label>
                <asp:TextBox class="form-control" ID="TextModDomicilio" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Fecha Nacimiento</label>
                <asp:TextBox class="form-control" ID="TextModFechaNacimiento" runat="server" />
            </div>
        </div>
    </div>

    <div style="margin-top: 20px;">
        <button type="submit" class="btn btn-primary">Aceptar</button>
        <button type="submit" class="btn btn-primary">Cancelar</button>
    </div>

</asp:Content>
