<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="WebClinica.Formulario_web3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>REPORTES</h1>
    
    <asp:Button type="submit" class="btn btn-primary" Text="Medicos" runat="server" />
    <asp:Button type="submit" class="btn btn-primary" Text="Pacientes" runat="server" />
    <asp:Button type="submit" class="btn btn-primary" Text="Usuarios" runat="server" />
    <asp:Button type="submit" class="btn btn-primary" Text="Turnos" runat="server" />

    <asp:GridView id="gvReporte" OnRowDataBound="gvReportes_RowDataBound" AutoGenerateColumns="true" runat="server">
    </asp:GridView>

</asp:Content>
