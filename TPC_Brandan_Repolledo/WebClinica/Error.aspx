<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="WebClinica.EspecialidadesAlta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label Text="Disculpe, la página se encuentra en mantenimiento ... Presione enter para hacer volver al menù principal" ID="lblError"  runat="server" />
     <input type="text" onkeydown="Response.Redirect("Menu.aspx")">

       
</asp:Content>
