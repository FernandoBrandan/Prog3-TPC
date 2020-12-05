<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="TurnosGestionMedicos.aspx.cs" Inherits="WebClinica.TurnosGestionMedicos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 style="margin-top: 20px;">Gestion Medico</h1>
    <div style="margin-top: 20px;">
        <nav aria-label="...">
            <ul class="pagination pagination-lg">

                <li class="page-item"><a class="page-link" href="TurnosLista.aspx">Lista</a></li>
                <li class="page-item"><a class="page-link" href="TurnosAlta.aspx">Alta</a></li>
                <li class="page-item active" aria-current="page">
                    <span class="page-link">Gestion Medico
                    <span class="sr-only">(current)</span>
                    </span>
                </li>
            </ul>
        </nav>
    </div>


    <div class="form-row">
        <div class="form-group col-md-3">     
            <asp:Label text="Paciente" runat="server" />        </div>
            <asp:Label id="lblPaciente" runat="server" />        </div>
        <div class="form-group col-md-3">
            <label>Motivo</label> 
            <asp:TextBox runat="server" />
        </div>
        <div class="form-group col-md-3">
            <label>Estado</label> 
            <asp:TextBox runat="server" />
        </div>
    </div> 

</asp:Content>
