<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="PacientesBaja.aspx.cs" Inherits="WebClinica.PacientesBaja" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style="margin-top: 50px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item"><a class="page-link" href="PacientesAlta.aspx">Alta</a></li>
                <li class="page-item"><a class="page-link" href="PacientesModifica.aspx">Modificacion</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Baja
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
            </ul>
        </nav>
    </div>

    <h1 style="margin-top: 20px; margin-bottom: 20px">Baja Paciente</h1>
    <h4> Ingresar DNI o Codigo de Paciente</h4>
    <div style="margin-top: 40px;">
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
