﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MedicosBaja.aspx.cs" Inherits="WebClinica.MedicosBaja" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top: 50px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item"><a class="page-link" href="MedicosAlta.aspx">Alta</a></li>
                <li class="page-item"><a class="page-link" href="MedicosModifica.aspx">Modificacion</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Baja
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
            </ul>
        </nav>
    </div>

    <h1 style="margin-top: 20px; margin-bottom: 20px">Baja de Médico</h1>
    <h4> Ingresar DNI o Codigo del Médico</h4>
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
