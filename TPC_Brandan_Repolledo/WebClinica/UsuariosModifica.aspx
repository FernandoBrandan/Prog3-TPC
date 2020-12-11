<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="UsuariosModifica.aspx.cs" Inherits="WebClinica.UsuariosModifica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <style>
        .oculto {
            display: none;
        }
    </style>

    <h1 style="margin-top: 20px; color: cadetblue">Usuario</h1>

    <div style="margin-top: 30px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item"><a class="page-link" href="UsuariosAlta.aspx">Alta</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Modificación
                <span class="sr-only">(current)</span>
                    </span>
                </li>
                <li class="page-item"><a class="page-link" href="UsuariosBaja.aspx">Baja</a></li>
            </ul>
        </nav>
    </div>

    <div class="container" style="margin-top: 30px;">


        <div class="row">

            <div class="form-group col-md-3">
                <label>Buscar</label>
                <br />
                <asp:TextBox class="form-control col-md-10" placeholder="Busqueda" type="number"  ID="TextBuscar" runat="server" Width="887px" />
           
                <br />
                <br />
                <asp:Button Text="Buscar" class="btn btn-primary" runat="server" OnClick="Click_BuscarUsuario" />
                <asp:Button Text="Borrar" class="btn btn-primary" runat="server" OnClick="Click_BorrarListado" />

            </div>

            <div class="col">
                <asp:GridView ID="gvBusqueda" AutoGenerateColumns="false" runat="server" OnRowCommand="BusquedaUsuario_RowCommand" Style="text-align: center; width: 100%">
                    <Columns>
                        <asp:ButtonField HeaderText="Opcion" ButtonType="Link" Text="Seleccionar" CommandName="Select" />
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


        <div class="form-row">
            <div class="form-group col-md-3">
                <label>DNI</label>
                <asp:TextBox class="form-control" ID="TextModDNI" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Nombre</label>
                <asp:TextBox class="form-control" ID="TextModNombre" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Apellido</label>
                <asp:TextBox class="form-control" ID="TextModApellido" runat="server" />
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-3">
                <label>Domicilio</label>
                <asp:TextBox class="form-control" ID="TextModDomicilio" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Fecha Nacimiento</label>
                <asp:TextBox class="form-control" ID="TextModFechaNacimiento" runat="server" />
            </div>
        </div>

    </div>


    <div style="margin-top: 20px;">
        <asp:Button Text="Aceptar" class="btn btn-primary" OnClick="Click_AceptarModiUsuario" runat="server" />
        <asp:Button Text="Cancelar" class="btn btn-primary" OnClick="Click_CancelarModiUsuario" runat="server" />
    </div>


</asp:Content>
