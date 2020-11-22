<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="UsuariosBaja.aspx.cs" Inherits="WebClinica.UsuariosBaja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="margin-top: 20px;">Usuario</h1>

    <div style="margin-top: 30px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item"><a class="page-link" href="UsuariosAlta.aspx">Alta</a></li>
                <li class="page-item"><a class="page-link" href="UsuariosModifica.aspx">Modificacion</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Baja
                <span class="sr-only">(current)</span>
                    </span>
                </li>
            </ul>
        </nav>
    </div>

    <h4>Ingresar DNI o Codigo del Usuario</h4>
    <div style="margin-top: 30px;">
        <div class="form-row">
            <div class="form-group col-md-3">
                <label>DNI</label>
                <asp:TextBox class="form-control" ID="txtDNI" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Legajo</label>
                <asp:TextBox class="form-control" ID="txtLegajo" runat="server" />
            </div>
        </div>
    </div>
    <div style="margin-top: 20px;">
        <button type="submit" class="btn btn-primary">Aceptar</button>
        <button type="submit" class="btn btn-primary">Cancelar</button>
    </div>
</asp:Content>
