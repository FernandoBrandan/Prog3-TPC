<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="TurnosAlta.aspx.cs" Inherits="WebClinica.Formulario_web13" %>
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
                <li class="page-item"><a class="page-link" href="TurnosModificacion.aspx">Modificacion</a></li>
                <li class="page-item"><a class="page-link" href="TurnosBaja.aspx">Baja</a></li>
            </ul>
        </nav>
    </div>

    <h1 style="margin-top: 20px;">Alta del turno</h1>
    <div style="margin-top: 30px;">
        <div class="form-row">
            <div class="form-group col-md-6">
                <label for="inputDisponibilidadl4">Disponibilidad</label>
                <input type="text" class="form-control" id="inputDisponibilidadl4">
 
            </div>
            <div class="form-group col-md-6">
                <label for="inputMedico4">Medico</label>
                <input type="text" class="form-control" id="inputMedico4">
            </div>
        </div>
        <div class="form-group">
            <label for="inputPaciente">Paciente</label>
            <input type="text" class="form-control" id="inputPaciente">
        </div>
        <div class="form-group">
            <label for="inputMotivo">Motivo</label>
            <input type="text" class="form-control" id="inputMotivo">
        </div>
        <div class="form-row">
            <div class="form-group col-md-6">
                <label for="inputEstado">Estado</label>
                <input type="text" class="form-control" id="inputEstado">
            </div>
        </div>
        <button type="submit" class="btn btn-primary">Sign in</button>

</asp:Content>
