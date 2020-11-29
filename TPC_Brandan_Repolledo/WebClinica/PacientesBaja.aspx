<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="PacientesBaja.aspx.cs" Inherits="WebClinica.PacientesBaja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
        function Validar() {
            var result = confirm("Seguro que desea realizar los cambios?");
            if (result){
                return true;
            }
            else{
                return false;
            }
        }

    </script>

    <h1 style="margin-top: 20px;">Baja del paciente</h1>
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
     
    
    <h4>Ingresar DNI o Codigo de Paciente</h4>
   <div style="margin-top: 30px;">
        <div class="form-group">
            <div class="form-group col-md-3"> 
                <label>Buscar</label>     
                <asp:TextBox class="form-control" placeholder="IdPaciente" ID="TextBuscarPaciente" runat="server" Width="500" OnTextChanged="Click_BuscarBajaPaciente" />
                <asp:Button Text="Buscar" class="btn btn-primary" runat="server" />
                <asp:Button Text="Borrar" class="btn btn-primary" runat="server" />

                <style>
                    .oculto {
                        display: none;
                    }
                </style> 
                <asp:GridView ID="gvBusquedaPaciente"  AutoGenerateColumns="false" runat="server" OnRowCommand="BusquedaBajaPaciente_RowCommand"  cellpadding="15" >
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
                  <div>
            <asp:TextBox id="TextBorrarPaciente" runat="server" />
            <asp:Button Text="Borrar Usuario" runat="server" OnClick="Click_AceptarBorrarPaciente" />
        </div>
        </div>

    </div>
   </div>

</asp:Content>
