<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="PacientesModifica.aspx.cs" Inherits="WebClinica.PacientesModifica" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="margin-top: 20px;">Paciente</h1>

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
    <h4>Ingresar DNI o Codigo del Usuario</h4>
       <div style="margin-top: 30px;">
        <div class="form-group">
            <div class="form-group col-md-3">
<<<<<<< HEAD
                <label>Buscar</label> 
=======
                <label>Buscar</label>
>>>>>>> 3a50e28231aca0f8761680aaa712503ec2e26649
                <asp:TextBox class="form-control" placeholder="IdPaciente" ID="TextBuscarPaciente" runat="server" Width="887px" />
                <asp:Button Text="Buscar" class="btn btn-primary" runat="server" OnClick="Click_BuscarPaciente" />
                <asp:Button Text="Borrar" class="btn btn-primary" runat="server" OnClick="Click_BorrarListadoPaciente" />

                <style>
                    .oculto {
                        display: none;
                    }
                </style>
                <asp:GridView ID="gvBusquedaPaciente" runat="server"></asp:GridView>
  
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

          
          <asp:Button Text="Cancelar" class="btn btn-primary" runat="server" />
    </div>
</asp:Content>
