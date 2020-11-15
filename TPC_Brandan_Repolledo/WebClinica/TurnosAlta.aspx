<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="TurnosAlta.aspx.cs" Inherits="WebClinica.TurnosAlta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h1 style="margin-top: 20px;">Gestión de turnos</h1>
    <div style="margin-top: 30px; width: 500px">
        <div class="form-row">
            <div class="form-group col-md-3">
                <label for="inputMedico4">Medico</label>
                <input type="text" class="form-control" id="inputMedico4">
            </div>
            <div class="form-group col-md-3">
                <label for="inputPaciente">Paciente</label>
                <input type="text" class="form-control" id="inputPaciente">
            </div>
        </div>
        
            </div>
        <asp:Calendar ID="Calendar1" Style="background-color: white" runat="server"></asp:Calendar>
        <div class="form-group">
            <label for="inputMotivo">Motivo</label>
            <input type="text" class="form-control" id="inputMotivo">
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

    <button type="submit" class="btn btn-primary">Sign in</button>

</asp:Content>
