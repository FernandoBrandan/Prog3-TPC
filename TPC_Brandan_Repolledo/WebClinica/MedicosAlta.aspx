<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MedicosAlta.aspx.cs" Inherits="WebClinica.MedicosAlta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div style="margin-top: 50px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Alta
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
                <li class="page-item"><a class="page-link" href="MedicosModifica.aspx">Modificacion</a></li>
                <li class="page-item"><a class="page-link" href="MedicosBaja.aspx">Baja</a></li>
            </ul>
        </nav>
    </div>

    <h1 style="margin-top: 20px;">Alta Medico</h1>
    <div style="margin-top: 30px;">
        <div class="form-row">
            <div class="form-group col-md-3">
                <label>DNI</label>
                <asp:TextBox class="form-control" ID="TextMedicoDNI" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Nombre</label>
                <asp:TextBox class="form-control" ID="TextMedicoNombre" runat="server" />
            </div>
            <div class="form-group col-md-3">
                <label>Apellido</label>
                <asp:TextBox class="form-control" ID="TextMedicoApellido" runat="server" />
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-3">
                <label>Domicilio</label>
                <asp:TextBox class="form-control" ID="TextMedicoDomicilio" runat="server" />
            </div>

            <div class="form-group col-md-3">
                <label>Fecha Nacimiento</label>
                <asp:TextBox class="form-control" placeholder="yyyy-mm-dd" ID="TextMedicoFechaNac" runat="server" />
            </div>

            <div class="form-group col-md-3">
                <asp:Label Text="Especialidad" runat="server" />
                <asp:DropDownList ID="ddlAltaEspecialidad" class="form-control" Style="margin-top: 7px" runat="server">
                </asp:DropDownList>
            </div>
            
        </div>
        <h5>Genero</h5>
        <div class="form-row">
            <asp:RadioButtonList ID="RbGenero" RepeatDirection="Horizontal" runat="server" Width="226px">
                <asp:ListItem Text="Masculino" Value="Male"></asp:ListItem>
                <asp:ListItem Text="Femenino" Value="Female"></asp:ListItem>
            </asp:RadioButtonList>
        </div>


    </div>
    <div style="margin-top: 20px;">
        <asp:Button Text="Aceptar" class="btn btn-primary" OnClick="Click_AceptarAltaPaciente" runat="server" />
        <asp:Button Text="Cancelar" class="btn btn-primary" runat="server" />
    </div>

</asp:Content>
