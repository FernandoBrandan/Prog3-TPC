<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="UsuariosAlta.aspx.cs" Inherits="WebClinica.UsuariosAlta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="margin-top: 20px;">Usuario</h1>
    <div style="margin-top: 30px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Alta
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
                <li class="page-item"><a class="page-link" href="UsuariosModifica.aspx">Modificacion</a></li>
                <li class="page-item"><a class="page-link" href="UsuariosBaja.aspx">Baja</a></li>
            </ul>
        </nav>
    </div>

    <div style="margin-top: 30px;">
        <div class="form-row">
            <div class="form-group col-md-3">
                <label>DNI</label>
                <asp:TextBox class="form-control" ID="TextUsuarioDNI" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Nombre</label>
                <asp:TextBox class="form-control" ID="TextUsuarioNombre" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Apellido</label>
                <asp:TextBox class="form-control" ID="TextUsuarioApellido" runat="server" />
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-3">
                <label>Domicilio</label>
                <asp:TextBox class="form-control" ID="TextUsuarioDomicilio" runat="server" />
            </div>

            <div class="form-group col-md-3">
                <label>Fecha Nacimiento</label>
                <asp:TextBox class="form-control" placeholder="yyyy-mm-dd" ID="TextUsuarioFechaNac" runat="server" />
            </div>

        </div>
        <h5>Genero</h5>
        <div class="form-row">
            <asp:RadioButtonList ID="RbGenero" RepeatDirection="Horizontal" runat="server" Width="226px">
                <asp:ListItem Text="Masculino" Value="Male"></asp:ListItem>
                <asp:ListItem Text="Femenino" Value="Female"></asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </div>
    <div style="margin-top: 20px;">
        <asp:Button Text="Aceptar" class="btn btn-primary" OnClick="Click_AceptarAltaUsuario" runat="server" />
        <asp:Button Text="Cancelar" class="btn btn-primary" runat="server" />
    </div>
</asp:Content>
