<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MedicosAlta.aspx.cs" Inherits="WebClinica.MedicosAlta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <script>
        function Validar()
        {
            var DNI = document.getElementById("TextMedicoDNI").value;
            var nombre = document.getElementById("TextMedicoNombre").value;
            var apellido = document.getElementById("TextMedicoApellido").value;
            var domicilio = document.getElementById("TextMedicoDomicilio").value;
            var fechaNac = document.getElementById("TextMedicoFechaNac").value;  
        
            if (DNI == "" || nombre == "" || apellido == "" || domicilio == "" || fechaNac == "")
            {
                alert("Debe completar todos los campos");
                return false;
            }
            return true;
        }

     </script>


       <h1  style="margin-top: 20px;color: cadetblue">Médico</h1>


    <div style="margin-top: 50px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Alta
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
                <li class="page-item"><a class="page-link" href="MedicosModifica.aspx">Modificación</a></li>
                <li class="page-item"><a class="page-link" href="MedicosBaja.aspx">Baja</a></li>
            </ul>
        </nav>
    </div>
    <div style="margin-top: 30px;">
        <div class="form-row">
            <div class="form-group col-md-3">
                <label>DNI</label>
      
                <asp:TextBox class="form-control" placeholder="DNI" ID="TextMedicoDNI" ClientIDMode ="Static" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Nombre</label>
                <asp:TextBox class="form-control" placeholder="Nombre" ID="TextMedicoNombre"  ClientIDMode ="Static" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Apellido</label>
                <asp:TextBox class="form-control" placeholder="Apellido" ID="TextMedicoApellido" ClientIDMode ="Static"  runat="server" />
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-3">
                <label>Domicilio</label>
                <asp:TextBox class="form-control"  placeholder="Domicilio" ID="TextMedicoDomicilio" ClientIDMode ="Static" runat="server" />
            </div>

            <div class="form-group col-md-3">
                <label>Fecha Nacimiento</label>
                <asp:TextBox class="form-control" placeholder="yyyy-mm-dd" ID="TextMedicoFechaNac" ClientIDMode ="Static"  runat="server" />
            </div>

            <div class="form-group col-md-3">
                <asp:Label Text="Especialidad" runat="server" />
                <asp:DropDownList ID="ddlAltaEspecialidad" class="form-control" Style="margin-top: 7px" runat="server">
                </asp:DropDownList>
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
        <asp:Button Text="Aceptar" class="btn btn-primary"   OnClientClick="return Validar()" OnClick="Click_AceptarAltaPaciente"  runat="server" />
        <asp:Button Text="Cancelar" class="btn btn-primary" runat="server" />
    </div>

</asp:Content>
