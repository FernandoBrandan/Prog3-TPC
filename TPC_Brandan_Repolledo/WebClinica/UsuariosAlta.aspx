<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="UsuariosAlta.aspx.cs" Inherits="WebClinica.UsuariosAlta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
        function Validar() {
            var DNI = document.getElementById("TextUsuarioDNI").value;
            var nombre = document.getElementById("TextUsuarioNombre").value;
            var apellido = document.getElementById("TextUsuarioApellido").value;
            var domicilio = document.getElementById("TextUsuarioDomicilio").value;
            var fechaNac = document.getElementById("TextUsuarioFechaNac").value;
            var pass = document.getElementById("TxtPassUsuario").value;

            if (pass == "" || DNI == "" || nombre == "" || apellido == "" || domicilio == "" || fechaNac == "") {
                alert("Debe completar todos los campos");
                return false;
            }
            return true;
        }
    </script>
    <h1 style="margin-top: 20px; color: cadetblue">Usuario</h1>
    <div style="margin-top: 30px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Alta
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
                <li class="page-item"><a class="page-link" href="UsuariosModifica.aspx">Modificación</a></li>
                <li class="page-item"><a class="page-link" href="UsuariosBaja.aspx">Baja</a></li>
                <li class="page-item"><a class="page-link" href="UsuariosListar.aspx">Lista de Usuarios</a></li>
            </ul>
        </nav>
    </div>
    
    <div style="margin-top: 30px;">
        <div class="form-row">
            <div class="form-group col-md-3">
                <label>DNI</label>
                <asp:TextBox class="form-control" placeholder="DNI" type="number" ID="TextUsuarioDNI" ClientIDMode="Static" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Nombre</label>
                <asp:TextBox class="form-control" placeholder="Nombre" ID="TextUsuarioNombre" ClientIDMode="Static" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Apellido</label>
                <asp:TextBox class="form-control" placeholder="Apellido" ID="TextUsuarioApellido" ClientIDMode="Static" runat="server" />
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-3">
                <label>Domicilio</label>
                <asp:TextBox class="form-control" placeholder="Domicilio" ID="TextUsuarioDomicilio" ClientIDMode="Static" runat="server" />
            </div>

            <div class="form-group col-md-3">
                <label>Fecha Nacimiento</label>
                <asp:TextBox class="form-control" placeholder="yyyy-mm-dd" ID="TextUsuarioFechaNac" ClientIDMode="Static" runat="server" />
            </div>

        </div>
        <h5>Genero</h5>
        <div class="form-row">
            <asp:RadioButtonList ID="RbGenero" RepeatDirection="Horizontal" runat="server" Width="226px">
                <asp:ListItem Text="Masculino" Value="Male"></asp:ListItem>
                <asp:ListItem Text="Femenino" Value="Female"></asp:ListItem>
            </asp:RadioButtonList>
        </div>

        <div class="form-row">

            <div class="form-group col-md-2">
                <asp:Label Text="Rol" runat="server" />
                <asp:DropDownList ID="ddlUsuarioRol" class="form-control" Style="margin-top: 7px" runat="server">
                </asp:DropDownList>
            </div>

            <div class="form-group col-md-3">
                <label>Password</label>
                <asp:TextBox class="form-control" type="password" placeholder="Contraseña" ID="TxtPassUsuario" ClientIDMode="Static" runat="server" />
            </div>

        </div>
    </div>
    <div style="margin-top: 20px;">
        <asp:Button Text="Aceptar" OnClientClick="return Validar()" OnClick="Click_AceptarAltaUsuario" class="btn btn-primary" runat="server" />
        <asp:Button Text="Cancelar" class="btn btn-primary" OnClick="Click_CancelarAltaUsuario" runat="server" />
    </div>
</asp:Content>
