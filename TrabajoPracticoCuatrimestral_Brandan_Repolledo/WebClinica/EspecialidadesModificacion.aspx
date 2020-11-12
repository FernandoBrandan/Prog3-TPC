﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="EspecialidadesModificacion.aspx.cs" Inherits="WebClinica.Formulario_web17" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style="margin-top: 50px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item"><a class="page-link" href="EspecialidadesAlta.aspx">Alta</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Modificacion
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
                <li class="page-item"><a class="page-link" href="EspecialidadesBaja.aspx">Baja</a></li>
            </ul>
        </nav>
    </div>

    <h1 style="margin-top: 20px;">Modificar Especialidad</h1>
    <div style="margin-top: 30px;">
          <div class="form-group col-md-3">
              <div class="form-group"> <!-- State Button -->
        <label for="especialidad_nombre" class="control-label">Nombre de la especialidad</label>
        <select class="form-control" id="especialidad_N">
            <option value="VA">Virginia</option>
            <option value="WA">Washington</option>
            <option value="WV">West Virginia</option>
            <option value="WI">Wisconsin</option>
            <option value="WY">Wyoming</option>
        </select>                    
    </div>
            </div>
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
        <div class="form-group">
            <label for="inputDescripcion">Descripción</label>
            <input type="text" class="form-control" id="inputDescripcion" placeholder="Indique alguna característica">
        </div>
    </div>
    <button type="submit" class="btn btn-primary">Save</button>
</asp:Content>
