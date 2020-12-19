<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="PacientesListar.aspx.cs" Inherits="WebClinica.EspecialidadesAlta" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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

    <h1 style="margin-top: 20px; color: cadetblue">Lista de Pacientes</h1>

        <div style="margin-top: 50px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item"><a class="page-link" href="PacientesAlta.aspx">Alta</a></li>
                <li class="page-item"><a class="page-link" href="PacientesModifica.aspx">Modifica</a></li>
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
                <asp:Button Text="Buscar" class="btn btn-primary" runat="server" OnClick="Click_BuscarBajaPaciente" />
                <asp:Button Text="Limpiar Búsqueda" class="btn btn-primary" runat="server" OnClick="Click_BorrarPacienteBaja"   />
            </div>
                

            </div>             
            </div>

           
</asp:Content>

