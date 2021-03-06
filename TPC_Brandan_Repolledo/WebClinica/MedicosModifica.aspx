﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MedicosModifica.aspx.cs" Inherits="WebClinica.MedicosModifica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="margin-top: 20px; color: cadetblue">Médico</h1>

    <div style="margin-top: 50px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item"><a class="page-link" href="MedicosAlta.aspx">Alta</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Modificación
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
                <li class="page-item"><a class="page-link" href="MedicosBaja.aspx">Baja</a></li>
                 <li class="page-item"><a class="page-link" href="MedicosListar.aspx">Lista de Médicos</a></li>
            </ul>
        </nav>
    </div>
    <div class="container" style="margin-top: 30px;">
        <div class="row"> 
            <div class="form-group col-md-3">
                <label>Buscar</label>
                <asp:TextBox  class="form-control col-md-10" placeholder="IdUsuario" ID="TextMedicoBuscar" runat="server" Width="883px" />
                <br />
                <asp:Button Text="Buscar" class="btn btn-primary" runat="server" OnClick="Click_BuscarMedico" />
                <asp:Button Text="Borrar" class="btn btn-primary" runat="server" OnClick="Click_BorrarListado" />

            </div>
            <div class="col">
                <style>
                    .oculto {
                        display: none;
                    }
                </style>
                <asp:GridView ID="gvBusqueda" AutoGenerateColumns="false" runat="server" OnRowCommand="BusquedaMedico_RowCommand" Style="text-align: center; width: 100%">
                    <Columns>
                        <asp:ButtonField HeaderText="Opcion" ButtonType="Link" Text="Seleccionar" CommandName="Select" />
                        <asp:BoundField HeaderText="Legajo" DataField="LegajoMedico" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="DNI" DataField="DNI" />
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                        <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                        <asp:BoundField HeaderText="Domicilio" DataField="Domicilio" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="FechaNacimiento" DataField="FechaNacimiento" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="Especialidad" DataField="Especialidad" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-3">
                <label>DNI</label>
                <asp:TextBox class="form-control" ID="TextModMedicoDNI" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Nombre</label>
                <asp:TextBox class="form-control" ID="TextModMedicoNombre" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Apellido</label>
                <asp:TextBox class="form-control" ID="TextModMedicoApellido" runat="server" />
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-3">
                <label>Domicilio</label>
                <asp:TextBox class="form-control" ID="TextModMedicoDomicilio" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Fecha Nacimiento</label>
                <asp:TextBox class="form-control" ID="TextModMedicoFechaNacimiento" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <asp:Label Text="Especialidad" runat="server" />
                <asp:DropDownList ID="ddlModMedico" class="form-control" Style="margin-top: 7px" runat="server">
                </asp:DropDownList>
            </div>
        </div>
    </div>
    <div style="margin-top: 20px;">
        <asp:Button Text="Aceptar" class="btn btn-primary" runat="server" OnClick="Click_AceptarModiMedico" />
        <asp:Button Text="Cancelar" class="btn btn-primary" OnClick="Click_CancelarModiMedico" runat="server" />
    </div>

</asp:Content>
