<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="TurnosGestionMedicos.aspx.cs" Inherits="WebClinica.TurnosGestionMedicos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 style="margin-top: 20px; color: cadetblue">Gestión Medico</h1>
    <div style="margin-top: 20px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">

                <li class="page-item"><a class="page-link" href="TurnosLista.aspx">Lista</a></li>
                <li class="page-item"><a class="page-link" href="TurnosAlta.aspx">Alta</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Gestión Médico
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
            </ul>
        </nav>
    </div>

    <style>
        .tam {
            font-size: x-large;
        }
    </style>
            <div class="col">
                <h6>ID Turno: <asp:Label class="tam" ID="idTextTurno" runat="server"/></h6>
                <h6>Apellido: <asp:Label class="tam" ID="idTextApellido" runat="server"/></h6>
                <h6>Nombre: <asp:Label class="tam" ID="idTextNombre" runat="server"/> </h6>
                <h6>Motivo: <asp:Label class="tam" ID="idTextMotivo" runat="server"/> </h6>
            </div>

            <div class="col">
                <asp:Label Text="Estado" runat="server" />
                <br />
                <asp:DropDownList runat="server" class="form-control form-group col-md-3" ID="ddlEstadoTurno">
                    <asp:ListItem Value="0">Seleccione</asp:ListItem>
                    <asp:ListItem Value="1">Atendido</asp:ListItem>
                    <asp:ListItem Value="2">Sin Atender</asp:ListItem>
                    <asp:ListItem Value="3">Cancelado</asp:ListItem>
                    <asp:ListItem Value="4">Pendiente</asp:ListItem>
                    <asp:ListItem Value="5">Reprogramado</asp:ListItem>
                </asp:DropDownList>
                <div>
                    <label>Motivo</label>
                    <br />
                    <asp:TextBox ID ="TxtMotivoTurno" TextMode="MultiLine" class="form-control" Columns="70" Rows="3" runat="server" />
                </div>
            </div>  

        <div style="margin-top: 20px;">
            <asp:Button Text="Aceptar" class="btn btn-primary" runat="server" OnClick="Click_AceptarGestionMedico" />
            <asp:Button Text="Cancelar" class="btn btn-primary"  OnClick="Click_CancelarGestionMedico" runat="server" />
        </div> 

</asp:Content>
