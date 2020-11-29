<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="PacientesBaja.aspx.cs" Inherits="WebClinica.PacientesBaja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top: 50px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item"><a class="page-link" href="PacientesAlta.aspx">Alta</a></li>
                <li class="page-item"><a class="page-link" href="PacientesModifica.aspx">Modificacion</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Baja
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
            </ul>
        </nav>
    </div>

    <h1 style="margin-top: 20px; margin-bottom: 20px">Baja Paciente</h1>
    <h4>Ingresar DNI o Codigo de Paciente</h4>
   <div style="margin-top: 30px;">
        <div class="form-group">
            <div class="form-group col-md-3"> 
                <label>Buscar</label>   
                <asp:TextBox class="form-control" placeholder="IdPaciente" ID="TextBuscarPaciente" runat="server" Width="887px" />
                <asp:Button Text="Buscar" class="btn btn-primary" runat="server" OnClick="Click_BuscarPacienteB" />
                <asp:Button Text="Borrar" class="btn btn-primary" runat="server" OnClick="Click_BorrarListadoPacienteB" />


                <style>
                    .oculto {
                        display: none;
                    }
                </style> 
                <asp:GridView ID="gvBusquedaPaciente"  AutoGenerateColumns="false" runat="server" cellpadding="15" >
                    <Columns>
                        <asp:ButtonField HeaderText="Opcion" ButtonType="Link" Text="Borrar" ControlStyle-ForeColor="SlateBlue"  CommandName ="Select" />
                        <asp:BoundField HeaderText="Legajo" DataField="CodigoPaciente" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="DNI       "  DataField  = "DNI" />
                        <asp:BoundField HeaderText="Nombre    " DataField = "Nombre" />
                        <asp:BoundField HeaderText="Apellido  " DataField ="Apellido" />       
                        <asp:BoundField HeaderText="Domicilio " DataField = "Domicilio" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="FechaNacimiento" DataField = "FechaNacimiento" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                    </Columns>
                </asp:GridView>

                
            <div class="form-group col-md-3">
                <label>DNI</label>
                <asp:TextBox class="form-control" ID="txtDNI" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Legajo</label>
                <asp:TextBox class="form-control" ID="txtLegajo" runat="server" />
            </div>
        </div>
    </div>
  
    <div style="margin-top: 20px;">
        <button type="submit" class="btn btn-primary">Aceptar</button>
        <button type="submit" class="btn btn-primary">Cancelar</button>
    </div>
</asp:Content>
