<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="UsuariosModificacion.aspx.cs" Inherits="WebClinica.Formulario_web19" %>
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
   <h1 style="margin-top: 20px;">Modificar Usuario</h1>
    <div style="margin-top: 30px;">
          <div class="form-group col-md-3">
                <label>Buscar</label>
                <asp:TextBox class="form-control" placeholder="IdMedico" ID="TextBox2" runat="server" />
            </div>
        <div class="form-row">
            <div class="form-group col-md-3">
                <label>DNI</label>
                <asp:TextBox class="form-control" ID="txtDNI" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Nombre</label>
                <asp:TextBox class="form-control" ID="TextBox1" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Apellido</label>
                <asp:TextBox class="form-control" ID="TextApellido" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <asp:Label Text="Legajo" ID="IdLegajo" placeholder="Legajo" runat="server" />></asp:label>
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-3">
                <label>Domicilio</label>
                <asp:TextBox class="form-control" ID="TextDomicilio" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Genero</label>
                <asp:TextBox class="form-control" ID="TextGenero" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Fecha Nacimiento</label>
                <asp:TextBox class="form-control" ID="TextFechaNac" runat="server" />
            </div>
            <div class="form-group col-md-4">
                <label>Correo Electronico</label>
                <asp:TextBox class="form-control" ID="TextEmail" runat="server" />
            </div>
        </div>
    </div>
    <div style="margin-top: 20px;">
        <asp:Button type="submit" class="btn btn-primary" Text="Aceptar" runat="server" />
        <asp:Button type="submit" class="btn btn-primary" Text="Cancelar" runat="server" />
    </div>
</asp:Content>
