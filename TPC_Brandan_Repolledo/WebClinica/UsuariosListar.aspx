<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="UsuariosListar.aspx.cs" Inherits="WebClinica.UsuariosListar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        .oculto {
            display: none;
        }
    </style> 
    <script>
        function Validar() {

            var result = confirm("¿Está seguro que desea recuperar al Usuario?");

            if (result) {
                return true;
            }
            else {
                return false;
            }
        }
    </script>

    <h1 style="margin-top: 20px; color: cadetblue">Usuario</h1>

    <div style="margin-top: 30px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item"><a class="page-link" href="UsuariosAlta.aspx">Alta</a></li>
                <li class="page-item"><a class="page-link" href="UsuariosModifica.aspx">Modificación</a></li>
                  <li class="page-item"><a class="page-link" href="UsuariosBaja.aspx">Baja</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Lista de usuarios
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
                <asp:TextBox class="form-group col-md-10" placeholder="IdUsuario" ID="TextBuscarUsuario" runat="server" Width="500" />
                <asp:Button Text="Buscar" class="btn btn-primary" runat="server" OnClick="Click_BusquedaUsuario" Width="78px" />
                <asp:Button Text="Limpiar Búsqueda" class="btn btn-primary" runat="server" OnClick="Click_LimpiarBusqueda" Width="154px" />
            </div>
            <div class="col">
                <style>
                    .oculto {
                        display: none;
                    }
                </style>
                <asp:GridView ID="gvBusquedaUsuario" AutoGenerateColumns="false" runat="server" OnRowCommand="ListaUsuario_RowCommand" Style="text-align: center; width: 100%">
                    <Columns>
                    <asp:ButtonField HeaderText="Opcion" ButtonType="Link" Text="Seleccionar" ControlStyle-ForeColor="SlateBlue" CommandName="Select" /> 
                        <asp:BoundField HeaderText="Legajo" DataField="LegajoUsuario" />
                        <asp:BoundField HeaderText="DNI" DataField="DNI" />
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                        <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                        <asp:BoundField HeaderText="Domicilio" DataField="Domicilio" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="FechaNacimiento" DataField="FechaNacimiento" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="Estado" DataField="Estado"  />

                    </Columns>
                </asp:GridView>

            </div>

        </div>
    </div>
    <div>
        <asp:TextBox ID="TextRecuperarUsuario" runat="server" Width="210px" Enabled="False" />
        <asp:Button Text="Recuperar Usuario" class="btn btn-primary" OnClientClick="return Validar()" OnClick="Click_AceptarRecuperarPaciente" runat="server" />
    </div>


</asp:Content>

