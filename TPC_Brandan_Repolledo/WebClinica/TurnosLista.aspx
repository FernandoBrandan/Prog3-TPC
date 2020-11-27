<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="TurnosLista.aspx.cs" Inherits="WebClinica.TurnosLista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="margin-top: 50px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Listado
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
                <li class="page-item"><a class="page-link" href="TurnosAlta.aspx">Alta</a></li>
                <li class="page-item"><a class="page-link" href="TurnosAlta.aspx">Gestion Medicos</a></li>
            </ul>
        </nav>
    </div>

    <h1 style="margin-top: 20px;">Listado de Turnos</h1>
    <style>
        .oculto {
            display: none;
        }
    </style>

    <asp:GridView ID="gvBusqueda" AutoGenerateColumns="false" runat="server" OnRowCommand="ListadoTurnos_RowCommand">
        <Columns>
            <asp:ButtonField HeaderText="Opcion" ButtonType="Link" Text="Seleccionar" CommandName="Select" />
            <asp:BoundField HeaderText="IdTurno" DataField="IdTurno" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
            <asp:BoundField HeaderText="Disponibilidad" DataField="Disponibilidad" />
            <asp:BoundField HeaderText="Medico" DataField="Medico" />
            <asp:BoundField HeaderText="Paciente" DataField="Paciente" />
            <asp:BoundField HeaderText="Estado" DataField="Estado" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
            <asp:BoundField HeaderText="Motivo" DataField="Motivo" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
        </Columns>
    </asp:GridView>
</asp:Content>
