<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="PacientesModifica.aspx.cs" Inherits="WebClinica.PacientesModifica" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="margin-top: 20px;color: cadetblue">Paciente</h1>

    <div style="margin-top: 50px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item"><a class="page-link" href="PacientesAlta.aspx">Alta</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Modificacion
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
                <li class="page-item"><a class="page-link" href="PacientesBaja.aspx">Baja</a></li>
            </ul>
        </nav>
    </div>
       <div style="margin-top: 30px;">
        <div class="form-group">
            <div class="form-group col-md-3"> 
                <label>Buscar</label>   
                <asp:TextBox class="form-control" placeholder="IdPaciente" ID="TextBuscarPaciente" runat="server" Width="887px" />
                <asp:Button Text="Buscar" class="btn btn-primary" runat="server" OnClick="Click_BuscarPaciente" />
                <asp:Button Text="Borrar" class="btn btn-primary" runat="server" OnClick="Click_BorrarListadoPaciente" />

                <style>
                    .oculto {
                        display: none;
                    }
                </style> 
                <asp:GridView ID="gvBusquedaPaciente"  AutoGenerateColumns="false" runat="server" cellpadding="15" OnRowCommand="BusquedaPaciente_RowCommand">
                    <Columns>
                        <asp:ButtonField HeaderText="Opcion" ButtonType="Link" Text="Seleccionar" ControlStyle-ForeColor="SlateBlue"  CommandName ="Select" />
                        <asp:BoundField HeaderText="Legajo" DataField="CodigoPaciente" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="DNI       "  DataField  = "DNI" />
                        <asp:BoundField HeaderText="Nombre    " DataField = "Nombre" />
                        <asp:BoundField HeaderText="Apellido  " DataField ="Apellido" />       
                        <asp:BoundField HeaderText="Domicilio " DataField = "Domicilio" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="FechaNacimiento" DataField = "FechaNacimiento" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
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
          <asp:Button Text="Aceptar" class="btn btn-primary" OnClick="Click_AceptarModiPaciente" runat="server" />

          <asp:Button Text="Cancelar" class="btn btn-primary" runat="server" />
        <asp:Button Text="Cancelar" class="btn btn-primary" runat="server" />
    </div>
</asp:Content>
