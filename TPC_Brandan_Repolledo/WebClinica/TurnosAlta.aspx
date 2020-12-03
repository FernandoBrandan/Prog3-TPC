<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="TurnosAlta.aspx.cs" Inherits="WebClinica.TurnosAlta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 style="margin-top: 20px;">Turno</h1>
    <div style="margin-top: 20px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item"><a class="page-link" href="TurnosLista.aspx">Listado</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Alta
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
                <li class="page-item"><a class="page-link" href="TurnosAlta.aspx">Gestion Medicos</a></li>
            </ul>
        </nav>
    </div>

    <div style="margin-top: 30px;">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <div class="form-row">

            <div class="form-group col-md-3">
                <asp:Label Text="Paciente" runat="server" />
                <asp:TextBox ID="TextBusquedaPacienteTurno" runat="server" />
                <div>
                    <asp:Button Text="Buscar" runat="server" OnClick="Click_AceptarBuscaPacienteTurno" />
                    <asp:Button Text="Borrar" runat="server" />
                </div>


            </div>

            <div class="form-group col-md-3">
                <style>
                    .oculto {
                        display: none;
                    }
                </style>

                <asp:GridView ID="gvBusquedaPaciente" AutoGenerateColumns="false" runat="server" CellPadding="15" OnRowCommand="BusquedaPaciente_RowCommand">
                    <Columns>
                        <asp:ButtonField HeaderText="Opcion" ButtonType="Link" Text="Seleccionar" ControlStyle-ForeColor="SlateBlue" CommandName="Select" />
                        <asp:BoundField HeaderText="CodigoPaciente" DataField="CodigoPaciente" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="DNI       " DataField="DNI" />
                        <asp:BoundField HeaderText="Nombre    " DataField="Nombre" />
                        <asp:BoundField HeaderText="Apellido  " DataField="Apellido" />
                        <asp:BoundField HeaderText="Domicilio " DataField="Domicilio" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="FechaNacimiento" DataField="FechaNacimiento" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                    </Columns>
                </asp:GridView>

            </div>

        </div>
        <div>

            <div>
                <h5>Paciente seleccionado:<asp:Label ID="LabelPacienteElegido" runat="server" /></h5> 
            </div>
        </div>

        <div class="form-row">
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <div class="form-group col-md-auto">
                        <asp:Label Text="Espacialidad" runat="server" />
                        <asp:DropDownList AutoPostBack="true" ID="ddlAltaTurnoEspecilidad" class="form-control" Style="margin-top: 7px" runat="server" OnSelectedIndexChanged="Click_SeleccionaEspecialidad">
                        </asp:DropDownList> 
                    </div>

                    <div class="form-group col-md-auto">
                        <asp:Label Text="Medico" runat="server" />
                        <asp:DropDownList AutoPostBack="true" ID="ddlAltaTurnoMedico" class="form-control" Style="margin-top: 7px" runat="server">
                        </asp:DropDownList>
                    </div> 
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>

        <div class="form-row">
            <div class="form-group">
                <asp:Calendar ID="Calendar1" Style="width: 140%; margin-left: 5px;" runat="server" OnSelectionChanged="Click_SeleccionaFecha"></asp:Calendar>
            </div>
            <div class="form-group col-md-3" style="margin-left: 95px;"> 
                <asp:TextBox AutoPostBack="true" id="TextFechaElegida" runat="server"/>  
                <asp:Button Text=">>" runat="server" OnClick="Click_ValidadFechas" />
                <br />
                <br />
                <asp:Label Text="Horarios Disponibles" runat="server" />
                <asp:DropDownList ID="ddlAltaTurnoHorario" class="form-control" Style="margin-top: 7px" runat="server">
                </asp:DropDownList>
            </div>
        </div>

    </div>

    <div style="margin-top: 20px;">
        <asp:Button Text="Aceptar" class="btn btn-primary" runat="server" />
        <asp:Button Text="Cancelar" class="btn btn-primary" runat="server" />
    </div>

</asp:Content>
