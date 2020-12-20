<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="PacientesListar.aspx.cs" Inherits="WebClinica.PacientesListar" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        function Validar() {

            var result = confirm("¿Está seguro de Recuperar al Paciente?");

            if (result) {
                return true;
            }
            else {
                return false;
            }
        }

    </script>

    <h1 style="margin-top: 20px; color: cadetblue">Lista de Pacientes</h1>

    <div style="margin-top: 50px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item"><a class="page-link" href="PacientesAlta.aspx">Alta</a></li>
                <li class="page-item"><a class="page-link" href="PacientesModifica.aspx">Modificación</a></li>
                <li class="page-item"><a class="page-link" href="PacientesBaja.aspx">Baja</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Lista de Pacientes
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
            </ul>
        </nav>
    </div>
    <div class="container" style="margin-top: 30px;">

        <div class="row form-group">

            <div class="form-group col-md-3">
                <label>Buscar</label>
                <asp:TextBox class="form-group col-md-10" placeholder="IdPaciente" ID="TextBuscarPaciente" runat="server" Width="500" />
                <asp:Button Text="Buscar" class="btn btn-primary" runat="server" OnClick="Click_BusquedaPaciente" Width="78px" />
                <asp:Button Text="Limpiar Búsqueda" class="btn btn-primary" runat="server" OnClick="Click_LimpiarBusqueda" Width="154px" />
            </div>
            <div class="col">
                <style>
                    .oculto {
                        display: none;
                    }
                </style>
                <asp:GridView ID="gvBusquedaPaciente" AutoGenerateColumns="false" runat="server" OnRowCommand="ListaPaciente_RowCommand" Style="text-align: center; width: 100%">
                    <Columns>
                <asp:ButtonField HeaderText="Opcion" ButtonType="Link" Text="Seleccionar" ControlStyle-ForeColor="SlateBlue" CommandName="Select" /> 
                        <asp:BoundField HeaderText="DNI       " DataField="DNI" />
                        <asp:BoundField HeaderText="Legajo" DataField="CodigoPaciente" />
                        <asp:BoundField HeaderText="Nombre    " DataField="Nombre" />
                        <asp:BoundField HeaderText="Apellido  " DataField="Apellido" />
                        <asp:BoundField HeaderText="Domicilio " DataField="Domicilio" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="Estado " DataField="Estado" />
                        <asp:BoundField HeaderText="FechaNacimiento" DataField="FechaNacimiento" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                    </Columns>
                </asp:GridView>

            </div>

        </div>
    </div>
    <div>
        <asp:TextBox ID="TextRecuperarPaciente" runat="server" Width="210px" Enabled="False" />
        <asp:Button Text="Recuperar Paciente" class="btn btn-primary" OnClientClick="return Validar()" OnClick="Click_AceptarRecuperarPaciente" runat="server" />
    </div>


</asp:Content>

