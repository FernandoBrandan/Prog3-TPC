<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MedicosBaja.aspx.cs" Inherits="WebClinica.MedicosBaja" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
        function  Validar() {
            var result = confirm("¿Está seguro de eliminar al médico?");
            if (result){
                return true;
            }
            else{
                return false;
            }
    </script>

    <h1  style="margin-top: 20px;color: cadetblue">Médico</h1>
    <div style="margin-top: 50px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item"><a class="page-link" href="MedicosAlta.aspx">Alta</a></li>
                <li class="page-item"><a class="page-link" href="MedicosModifica.aspx">Modificacion</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Baja
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
            </ul>
        </nav>
    </div>

    <div style="margin-top: 30px;">
        <div class="form-group">
            <div class="form-group col-md-3"> 
                <label>Buscar</label>     
                <asp:TextBox class="form-control" placeholder="IdMedico" ID="TextBuscarMedico" runat="server" Width="500"  />

                <asp:Button Text="Buscar" class="btn btn-primary" runat="server"  OnClick="Click_BuscarBajaPaciente"/>

                <style>
                    .oculto {
                        display: none;
                    }
                </style> 
                <asp:GridView ID="gvBusquedaMedico"  AutoGenerateColumns="false" runat="server" OnRowCommand="BusquedaBajaMedico_RowCommand"  cellpadding="15" >
                    <Columns>
                        <asp:ButtonField HeaderText="Opcion" ButtonType="Link" Text="Borrar" ControlStyle-ForeColor="SlateBlue"  CommandName ="Select" />
                        <asp:BoundField HeaderText="Legajo" DataField="CodigoMedico" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="DNI       "  DataField  = "DNI" />
                        <asp:BoundField HeaderText="Nombre    " DataField = "Nombre" />
                        <asp:BoundField HeaderText="Apellido  " DataField ="Apellido" />       
                        <asp:BoundField HeaderText="Domicilio " DataField = "Domicilio" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="FechaNacimiento" DataField = "FechaNacimiento" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                    </Columns>
                </asp:GridView>
                  <div>
            <asp:TextBox id="TextBorrarMedico" runat="server" Width="152px" Enabled="False" />
            <asp:Button Text="Borrar Usuario" OnClientClick="return Validar()"   runat="server" OnClick="Click_AceptarBorrarMedico" Height="33px" Width="117px" />
        </div>
        </div>

    </div>
   </div>

</asp:Content>
