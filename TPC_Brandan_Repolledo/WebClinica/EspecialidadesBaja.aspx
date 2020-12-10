<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="EspecialidadesBaja.aspx.cs" Inherits="WebClinica.EspecialidadesBaja" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h1 style="margin-top: 20px;;color: cadetblue">Especialidades</h1>
     <div style="margin-top: 30px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">
                <li class="page-item"><a class="page-link" href="EspecialidadesAlta.aspx">Alta</a></li>
                <li class="page-item"><a class="page-link" href="EspecialidadesModifica.aspx">Modificación</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Baja
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
            </ul>
        </nav>
    </div>

    <div style="margin-top: 30px;">  
                <div class="form-group ">
                    <asp:Label Text="Especialidades" runat="server" />
                    <asp:DropDownList runat="server" ID="ddlModEspecialidad" CssClass="form-control col-md-3">
                      
                    </asp:DropDownList>
                    <br />
                    <asp:Button Text="Elegir" class="btn btn-primary" runat="server" OnClick="Click_ElegirEspecialidad" />
                </div>
    </div>
    <div style="margin-top: 20px;">
        <asp:TextBox id="TextBorrarEspecialidad" runat="server" Width="152px" />
            <asp:Button Text="Borrar Especialidad"    OnClick="Click_AceptaBorrarEspecialidad" Height="33px" Width="175px" runat="server" />
    </div>
</asp:Content>
