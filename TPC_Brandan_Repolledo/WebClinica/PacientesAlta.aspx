<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="PacientesAlta.aspx.cs" Inherits="WebClinica.PacientesAlta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="margin-top: 50px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Alta
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
                <li class="page-item"><a class="page-link" href="PacientesModifica.aspx">Modificacion</a></li>
                <li class="page-item"><a class="page-link" href="PacientesBaja.aspx">Baja</a></li>
            </ul>
        </nav>
    </div>

    <h1 style="margin-top: 20px;">Alta Paciente</h1>
    <div style="margin-top: 30px;">
        <div class="form-row">
            <div class="form-group col-md-3">
                <label>DNI</label>
                <asp:TextBox class="form-control" ID="TextDNI" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Nombre</label>
                <asp:TextBox class="form-control" ID="TextNombre" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Apellido</label>
                <asp:TextBox class="form-control" ID="TextApellido" runat="server" />
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-3">
                <label>Domicilio</label>
                <asp:TextBox class="form-control" ID="TextDomicilio" runat="server" />
            </div>

            <div class="form-group col-md-3">
                <label>Fecha Nacimiento</label>
                <asp:TextBox class="form-control" ID="TextFechaNac" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Genero</label>
                <asp:DropDownList ID="DDLGenero" runat="server"></asp:DropDownList>
            </div>
            <div class="form-group col-md-4">
                <label>Correo Electronico</label>
                <asp:TextBox class="form-control" ID="TextEmail" runat="server" />
            </div>
        </div>
    </div>
    <div style="margin-top: 20px;">
        <asp:Button Text="Aceptar" class="btn btn-primary" runat="server" OnClick="Click_AceptarAltaPaciente" />
        <asp:Button Text="Cancelar" class="btn btn-primary" runat="server" />
    </div>

</asp:Content>
