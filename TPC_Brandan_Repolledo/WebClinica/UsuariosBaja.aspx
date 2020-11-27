<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="UsuariosBaja.aspx.cs" Inherits="WebClinica.UsuariosBaja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="margin-top: 20px;">Usuario</h1>

    <div style="margin-top: 30px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item"><a class="page-link" href="UsuariosAlta.aspx">Alta</a></li>
                <li class="page-item"><a class="page-link" href="UsuariosModifica.aspx">Modificacion</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Baja
                <span class="sr-only">(current)</span>
                    </span>
                </li>
            </ul>
        </nav>
    </div>

    <h4>Ingresar DNI o Codigo del Usuario</h4>
    <div style="margin-top: 30px;">


        <div class="form-group col-md-3">
            <label>Buscar</label>
            <asp:TextBox class="form-control" placeholder="IdUsuario" ID="TextBuscar" runat="server" Width="887px" OnTextChanged="Click_BuscarBajaUsuario" />
            <asp:Button Text="Buscar" class="btn btn-primary" runat="server"/>
            <asp:Button Text="Borrar" class="btn btn-primary" runat="server"/>

            <style>
                .oculto {
                    display: none;
                }
            </style>

            <asp:GridView ID="gvBusqueda" AutoGenerateColumns="false" runat="server" OnRowCommand="BusquedaBajaUsuario_RowCommand">
                <Columns>
                    <asp:ButtonField HeaderText="Opcion" ButtonType="Link" Text="Baja" CommandName="Select"/>
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
    <div style="margin-top: 20px;">
        <button type="submit" class="btn btn-primary">Aceptar</button>
        <button type="submit" class="btn btn-primary">Cancelar</button>
    </div>
</asp:Content>
