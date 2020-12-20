<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MedicosListar.aspx.cs" Inherits="WebClinica.MedicosListar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
        function Validar() {
            var result = confirm("¿Está seguro de recuperar al médico?");
            if (result) {
                return true;
            }
            else {
                return false;
            }
    </script>

    <h1 style="margin-top: 20px; color: cadetblue">Médico</h1>
    <div style="margin-top: 50px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item"><a class="page-link" href="MedicosAlta.aspx">Alta</a></li>
                <li class="page-item"><a class="page-link" href="MedicosModifica.aspx">Modificación</a></li>
                 <li class="page-item"><a class="page-link" href="MedicosBaja.aspx">Baja</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Lista de Médicos
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
            </ul>
        </nav>
    </div>
     <div class="container" style="margin-top: 30px;">

        <div class="row form-group">

            <div class="form-group col-md-3">
                <label>Buscar</label>
                <asp:TextBox class="form-group col-md-10" placeholder="IdMedico" ID="TextBuscarMedico" runat="server" Width="500" />
                <asp:Button Text="Buscar" class="btn btn-primary" runat="server" OnClick="Click_BusquedaBajaMedico" />
                
                <asp:Button Text="Limpiar búsqueda" class="btn btn-primary" runat="server" OnClick="Click_LimpiarBusqueda" />

                
            </div> 
                
            <div class="col">
                <style>
                    .oculto {
                        display: none;
                    }
                </style>
                 <asp:GridView ID="gvBusquedaMedico" AutoGenerateColumns="false" runat="server" OnRowCommand="BusquedaBajaMedico_RowCommand" Style="text-align: center; width: 100%">
                    <Columns>
                        <asp:ButtonField HeaderText="Opcion" ButtonType="Link" Text="Seleccionar" ControlStyle-ForeColor="SlateBlue" CommandName="Select" />
                        <asp:BoundField HeaderText="LegajoMedico" DataField="LegajoMedico"/>
                        <asp:BoundField HeaderText="DNI       " DataField="DNI" />
                        <asp:BoundField HeaderText="Nombre    " DataField="Nombre" />
                        <asp:BoundField HeaderText="Apellido  " DataField="Apellido" />
                        <asp:BoundField HeaderText="Domicilio " DataField="Domicilio" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="FechaNacimiento" DataField="FechaNacimiento" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="Estado" DataField="Estado" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        
                    </Columns>
                </asp:GridView> 
            </div> 
        </div> 
    </div>

    <div>
        <asp:TextBox ID="TextBorrarMedico" runat="server" Width="152px" Enabled="False" />
        <asp:Button Text="Recuperar Usuario" class="btn btn-primary" OnClientClick="return Validar()" runat="server" OnClick="Click_AceptarRecuperarMedico" />
    </div>

</asp:Content>

