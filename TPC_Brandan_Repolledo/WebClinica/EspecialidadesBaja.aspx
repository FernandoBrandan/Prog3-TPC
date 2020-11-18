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
                <li class="page-item"><a class="page-link" href="EspecialidadesModifica.aspx">Modificacion</a></li>
                <li class="page-item"><a class="page-link" href="EspecialidadesAlta.aspx">Alta</a></li>
            </ul>
        </nav>
    </div>

    <h1 style="margin-top: 20px;">Baja de Especialidades</h1>
    <div style="margin-top: 30px;">
    <div class="form-group"> <!-- State Button -->
        <label for="state_id" class="control-label">Nombre de la especialidad</label>
        <select class="form-control" id="Ispecialidad_ID">
            <option value="VA">Virginia</option>
            <option value="WA">Washington</option>
            <option value="WV">West Virginia</option>
            <option value="WI">Wisconsin</option>
            <option value="WY">Wyoming</option>
        </select>                    
    </div>
        <div style="margin-top: 30px;">
    <div class="form-group"> <!-- State Button -->
        <label for="state_id" class="control-label">ID de la especialidad</label>
        <select class="form-control" id="Ispecialidad_Nombre">
        </select>                    
    </div>
    <button type="submit" class="btn btn-primary">Delete</button>
</asp:Content>
