<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="UsuariosBaja.aspx.cs" Inherits="WebClinica.UsuariosBaja" %>

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

            var result = confirm("¿Está seguro de Eliminar al Usuario?");

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
                <asp:TextBox class="form-group col-md-10" placeholder="Busqueda" ID="TextBuscar" runat="server" Width="882px" OnTextChanged="Click_BuscarBajaUsuario" />
                <br />
                <br />
                <asp:Button Text="Buscar" class="btn btn-primary" runat="server" OnClick="Click_BuscarBajaUsuario" />
                <asp:Button Text="Borrar" class="btn btn-primary" runat="server" OnClick="Click_BorrarBusquedaUsuario" />

            </div>

            <div class="col">
                <asp:GridView ID="gvBusqueda" AutoGenerateColumns="false" runat="server" OnRowCommand="BusquedaBajaUsuario_RowCommand" Style="text-align: center; width: 100%">
                    <Columns>
                        <asp:ButtonField HeaderText="Opcion" ButtonType="Link" Text="Baja" CommandName="Select" />
                        <asp:BoundField HeaderText="Legajo" DataField="LegajoUsuario" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="DNI" DataField="DNI" />
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                        <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                        <asp:BoundField HeaderText="Domicilio" DataField="Domicilio" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="FechaNacimiento" DataField="FechaNacimiento" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>


    <div>
        <asp:TextBox ID="TextBorrarUsuario" runat="server" Width="210px" Enabled="False" />
        <asp:Button Text="Borrar Usuario" class="btn btn-primary" OnClientClick="return Validar()" OnClick="Click_AceptarBorrarUsusario" runat="server" />
    </div>


</asp:Content>
