<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="EspecialidadesBaja.aspx.cs" Inherits="WebClinica.EspecialidadesBaja" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style="margin-top: 50px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Baja
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
                <li class="page-item"><a class="page-link" href="EspecialidadesModificacion.aspx">Modificacion</a></li>
                <li class="page-item"><a class="page-link" href="EspecialidadesAlta.aspx">Alta</a></li>
            </ul>
        </nav>
    </div>

    <h1 style="margin-top: 20px;">Baja de Especialidades</h1>
    <div style="margin-top: 30px;">
        <div class="form-row">
            <div class="form-group col-md-6">
                <label for="inputEspecialidad4">Id de la Especialidad:</label>
                <input type="text" class="form-control" id="inputEspecialidad4">
            </div>
            <div class="form-group col-md-6">
                <label for="inputNombre">Nombre:</label>
                <input type="password" class="form-control" id="inputNombre">
            </div>
        </div>
    </div>
    <button type="submit" class="btn btn-primary">Delete</button>
</asp:Content>
