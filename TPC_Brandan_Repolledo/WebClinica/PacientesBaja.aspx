<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="PacientesBaja.aspx.cs" Inherits="WebClinica.PacientesBaja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
        function Validar() {

            var result = confirm("¿Está seguro de Eliminar al Usuario?");

            if (result) {
                return true;
            }
            else {
                return false;
            }
        }

    </script>

    <h1 style="margin-top: 20px; color: cadetblue">Paciente</h1>
    <div style="margin-top: 50px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item"><a class="page-link" href="PacientesAlta.aspx">Alta</a></li>
                <li class="page-item"><a class="page-link" href="PacientesModifica.aspx">Modificación</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Baja
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
                
                <asp:Button Text="Buscar" class="btn btn-primary" runat="server" OnClick="Click_BuscarBajaPaciente" />
                <asp:Button Text="Borrar" class="btn btn-primary" runat="server" OnClick="Click_BorrarPacienteBaja"   />
            </div>
            <div class="col">
                <style>
                    .oculto {
                        display: none;
                    }
                </style>
                <asp:GridView ID="gvBusquedaPaciente" AutoGenerateColumns="false" runat="server" OnRowCommand="BusquedaBajaPaciente_RowCommand" Style="text-align: center; width: 100%">
                    <Columns>
                        <asp:ButtonField HeaderText="Opcion" ButtonType="Link" Text="Borrar" ControlStyle-ForeColor="SlateBlue" CommandName="Select" />
                        <asp:BoundField HeaderText="Legajo" DataField="CodigoPaciente" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="DNI       " DataField="DNI" />
                        <asp:BoundField HeaderText="Nombre    " DataField="Nombre" />
                        <asp:BoundField HeaderText="Apellido  " DataField="Apellido" />
                        <asp:BoundField HeaderText="Domicilio " DataField="Domicilio" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="FechaNacimiento" DataField="FechaNacimiento" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                    </Columns>
                </asp:GridView>

            </div>

        </div>
    </div>
       <div>
            <asp:TextBox id="TextBorrarPaciente" runat="server"  Width="210px" Enabled="False"  />
            <asp:Button Text="Borrar Usuario" class="btn btn-primary"  OnClientClick="return Validar()"  OnClick="Click_AceptarBorrarPaciente" runat="server" />  
        </div>

</asp:Content>
