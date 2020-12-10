<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="TurnosAlta.aspx.cs" Inherits="WebClinica.TurnosAlta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        .oculto {
            display: none;
        }
    </style>

    <h1 style="margin-top: 20px; color: cadetblue">Turno</h1>
    <div style="margin-top: 20px;">
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

    <div class="form-group container">

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <div class="row" style="margin-top: 30px;">
            <div class="form-group col">
                <asp:Label Text="Paciente" runat="server" />
                <asp:TextBox ID="TextBusquedaPacienteTurno" class="col-md-10" runat="server" />
                <br />
                <br />
                <div style="margin-left: 100px;">
                    <asp:Button Text="Buscar" class="btn btn-primary" runat="server" OnClick="Click_AceptarBuscaPacienteTurno" Width="150px" />
                    <asp:Button Text="Borrar" class="btn btn-primary" runat="server" OnClick="Click_BorrarBuscaPacienteTurno" Width="150px" />
                </div>
            </div>

            <div class="col">
                <asp:GridView ID="gvBusquedaPaciente" AutoGenerateColumns="false" runat="server" Style="text-align: center; width: 100%" OnRowCommand="BusquedaPaciente_RowCommand">
                    <Columns>
                        <asp:ButtonField HeaderText="Opcion" ButtonType="Link" Text="Seleccionar" ControlStyle-ForeColor="SlateBlue" CommandName="Select" />
                        <asp:BoundField HeaderText="CodigoPaciente" DataField="CodigoPaciente" />
                        <asp:BoundField HeaderText="DNI       " DataField="DNI" />
                        <asp:BoundField HeaderText="Nombre    " DataField="Nombre" />
                        <asp:BoundField HeaderText="Apellido  " DataField="Apellido" />
                        <asp:BoundField HeaderText="Domicilio " DataField="Domicilio" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="FechaNacimiento" DataField="FechaNacimiento" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>

        <div class="row" style="margin-left: 100px; margin-top: 10px; margin-bottom: 20px">
            <h4>Paciente seleccionado:
                <asp:Label ID="LabelPacienteElegido" runat="server" /></h4>
        </div>

        <div class="row" style="margin-bottom: 20px;">
            <div class="col-md-auto">
                <asp:Label Text="Espacialidad" runat="server" />
                <asp:DropDownList AutoPostBack="true" class="form-control" ID="ddlAltaTurnoEspecilidad" runat="server" OnSelectedIndexChanged="Click_SeleccionaEspecialidad">
                </asp:DropDownList>
            </div>
            <div class="col-md-auto">
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <asp:Label Text="Medico"  runat="server" />
                        <asp:DropDownList AutoPostBack="true" class="form-control" ID="ddlAltaTurnoMedico" runat="server">
                        </asp:DropDownList>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>

        <div class="form-row">
            <div class="col">
                <asp:Calendar ID="Calendar1" Style="width: 100%; margin-left: 5px;" runat="server" OnSelectionChanged="Click_SeleccionaFecha"></asp:Calendar>
            </div>
            <div class="col">
                <asp:TextBox AutoPostBack="true" ID="TextFechaElegida" runat="server" />
                <asp:Button Text=">>" ID="selecionFecha" runat="server" OnClick="Click_ValidadFechas" />
                <br />
                <br />
                <asp:Label Text="Horarios Disponibles" runat="server" />
                <asp:DropDownList ID="ddlAltaTurnoHorario" class="form-control" ValidationGroup="g1" Style="margin-top: 7px;" runat="server">
                </asp:DropDownList>
                <br />
                <asp:Label Text="Motivo" runat="server" />
                <br />
                <asp:TextBox ID="TextMotivoTurno" ClientIDMode="Static" TextMode="MultiLine" Columns="70" Rows="2" runat="server" />
            </div>
        </div>

        <div class="row" style="margin-top: 20px;">
            <asp:Button Text="Aceptar" class="btn btn-primary" OnClick="Click_AceptarAltaTurno" runat="server"/>
            <asp:Button Text="Cancelar" style="margin-left: 5px;" class="btn btn-primary" runat="server" />
        </div>

    </div>

</asp:Content>
