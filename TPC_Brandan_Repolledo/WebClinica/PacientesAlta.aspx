<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="PacientesAlta.aspx.cs" Inherits="WebClinica.PacientesAlta" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
        function Validar()
        {
            var DNI = document.getElementById("TextAltaPacienteDNI").value;           
            var nombre = document.getElementById("TextAltaPacienteNombre").value;        
            var apellido = document.getElementById("TextAltaPacienteApellido").value;          
            var domicilio = document.getElementById("TextAltaPacienteDomicilio").value;      
            var fechaNac = document.getElementById("TextAltaPacienteFechaNac").value;   
            var email = document.getElementById("TextAltaPacienteEmail").value;
        
            if (DNI == "" || nombre == "" || apellido == "" || domicilio == "" || fechaNac == "" || email == "")
            {
                alert("Debe completar todos los campos");
                return false;
            }
            return true;
        }

    </script>
    <h1 style="margin-top: 20px;color: cadetblue">Paciente </h1>


  
    <div style="margin-top: 50px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Alta
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
                <li class="page-item"><a class="page-link" href="PacientesModifica.aspx">Modificacion</a></li>
                <li class="page-item"><a class="page-link" href="PacientesBaja.aspx">Baja</a></li>
            </ul>
        </nav>
    </div>
    <div style="margin-top: 30px;">
        <div class="form-row">
            <div class="form-group col-md-3">
                <label>DNI</label>
                <asp:TextBox class="form-control" placeholder="DNI"  ID="TextAltaPacienteDNI"  ClientIDMode ="Static" runat="server" /> 
            </div>
            <div class="form-group col-md-3">
                <label>Nombre</label>
                <asp:TextBox class="form-control" placeholder="Nombre"  ID="TextAltaPacienteNombre" ClientIDMode ="Static"  runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Apellido</label>
                <asp:TextBox class="form-control" placeholder="Apellido" ID="TextAltaPacienteApellido" ClientIDMode ="Static" runat="server" />
            </div>

        </div>
        <div class="form-row">
            <div class="form-group col-md-3">
                <label>Domicilio</label>
                <asp:TextBox class="form-control" placeholder="Apellido" ID="TextAltaPacienteDomicilio" ClientIDMode ="Static" runat="server" />
            </div>

            <div class="form-group col-md-3">
                <label>Fecha Nacimiento</label>
                <asp:TextBox class="form-control"  placeholder="yyyy-mm-dd" ID="TextAltaPacienteFechaNac" ClientIDMode ="Static" runat="server" />
            </div>
            <div class="form-group col-md-4">
                <label>Correo Electrónico</label>
                <asp:TextBox class="form-control"  placeholder="Correo electrónico" ID="TextAltaPacienteEmail" ClientIDMode ="Static"  runat="server" />
            </div>
        </div>
            <h5>Género</h5>
        <div class="form-row">
            <asp:RadioButtonList ID="RbGenero" RepeatDirection="Horizontal" runat="server" Width="226px">
                <asp:ListItem Text="Masculino" Value="Male"></asp:ListItem>
                <asp:ListItem Text="Femenino" Value="Female"></asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </div>
    <div style="margin-top: 20px;">
        <asp:Button Text="Aceptar"  OnClientClick="return Validar()" OnClick="Click_AceptarAltaPaciente" class="btn btn-primary" runat="server"/>
        <asp:Button Text="Cancelar" class="btn btn-primary" runat="server" />
    </div>

</asp:Content>
