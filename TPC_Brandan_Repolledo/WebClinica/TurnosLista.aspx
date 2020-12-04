<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="TurnosLista.aspx.cs" Inherits="WebClinica.TurnosLista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h1 style="margin-top: 20px;">Listado</h1>
    <div style="margin-top: 20px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Listado
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
                <li class="page-item"><a class="page-link" href="TurnosAlta.aspx">Alta</a></li>
                <li class="page-item"><a class="page-link" href="TurnosGestionMedicos.aspx">Gestion Medicos</a></li>
            </ul>
        </nav>
    </div>

    <style>
        .oculto {
            display: none;
        } 
    </style> 

    <asp:GridView ID="gvBusquedaTurnos" AutoGenerateColumns="false" runat="server" OnRowCommand="ListadoTurnos_RowCommand">
        <Columns>
            <asp:ButtonField HeaderText="Opcion" ButtonType="Link" Text="Gestionar" CommandName="Select" />
            <asp:BoundField HeaderText="IdTurno" DataField="IdTurno"/>
            <asp:BoundField HeaderText="Disponibilidad" DataField="Disponibilidad"/>
            <asp:BoundField HeaderText="Medico" DataField="Medico"/>
            <asp:BoundField HeaderText="Paciente" DataField="Paciente"/>
            <asp:BoundField HeaderText="Estado" DataField="Estado"/>
            <asp:BoundField HeaderText="Motivo" DataField="Motivo"/>
        </Columns>
    </asp:GridView>
</asp:Content>
