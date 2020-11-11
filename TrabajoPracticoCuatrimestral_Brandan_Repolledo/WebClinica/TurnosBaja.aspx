<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="TurnosBaja.aspx.cs" Inherits="WebClinica.Formulario_web113" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
    <asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top: 50px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Alta
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
                <li class="page-item"><a class="page-link" href="TurnosAlta.aspx">Modificacion</a></li>
                <li class="page-item"><a class="page-link" href="TurnosBaja.aspx">Baja</a></li>
            </ul>
        </nav>
    </div>
     <h1 style="margin-top: 20px;">Baja del turno</h1>
    <div style="margin-top: 30px;">
        <div class="form-row">
      
            <div class="form-group col-md-6">
                <label for="inputMedico4">Indique el médico al cual desea cancelar el turno:</label>
                <input type="text" class="form-control" id="inputMedico4">
            </div>
        </div>
        <div class="form-group">
            <label for="inputPaciente">Nombre del paciente:</label>
            <input type="text" class="form-control" id="inputPaciente">
        </div>
        <div class="form-group">
            <label for="inputMotivo">Motivo por que cancela:</label>
            <input type="text" class="form-control" id="inputMotivo">
        </div>
        <div class="form-row">
            <div class="form-group col-md-6">
                <label for="inputEstado">Estado</label>
                <input type="text" class="form-control" id="inputEstado">
            </div>
        </div>
        <button type="submit" class="btn btn-primary">Guardar</button>
</asp:Content>
