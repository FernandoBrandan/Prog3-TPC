<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="TurnosAlta.aspx.cs" Inherits="WebClinica.TurnosAlta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="margin-top: 50px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item"><a class="page-link" href="TurnosLista.aspx">Listado</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Alta
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
            </ul>
        </nav>
    </div>

    <h1 style="margin-top: 20px;">Gestión de turnos</h1>

    <div style="margin-top: 30px; width: 100%">
        <div class="form-row">
            <div class="form-group col-md-4">
                <label for="inputMedico4">Medico</label>
                <input type="text" class="form-control" id="inputMedico4">
                <asp:DropDownList runat="server">
                    <asp:ListItem Text="text1" />
                    <asp:ListItem Text="text2" />
                </asp:DropDownList>

            </div>
            <div class="form-group col-md-4">
                <label for="inputPaciente">Paciente</label>
                <input type="text" class="form-control" id="inputPaciente">
            </div>
            <button type="submit" class="btn btn-primary" style="height: 40px; margin-top: 30px; margin-left: 30px;">Agregar Paciente</button>
        </div>
    </div>

    <div>
        <div style="position: absolute; right: 500px;">
            <asp:Calendar ID="Calendar1" Style="background-color: white" runat="server"></asp:Calendar>
        </div>
        <div class="form-group" style="position: absolute;">
            <label for="inputMotivo">Horario</label>
            <input type="text" class="form-control" id="inputHorario">
            <label for="inputMotivo">Motivo</label>
            <input type="text" class="form-control" id="inputMotivo">
        </div>
    </div>
    

    <div class="form-row">
        <div class="form-group col-md-6">
            <label for="inputEstado">Estado</label>
            <input type="text" class="form-control" id="inputEstado">
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            <br />
            <asp:DataList ID="DataList1" runat="server"></asp:DataList>
            <br />
            <asp:ListView ID="ListView1" runat="server"></asp:ListView> 
        </div> 
    </div>  
    
    <div style="margin-top: 20px;">
        <button type="submit" class="btn btn-primary">Aceptar</button>
        <button type="submit" class="btn btn-primary">Cancelar</button>
    </div>

</asp:Content>
