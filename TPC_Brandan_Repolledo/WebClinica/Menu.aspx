<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="WebClinica.Menu" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.min.js" integrity="sha384-w1Q4orYjBQndcko6MimVbzY0tgp4pWB4lZ7lr30WKz0vr/aWKhXdBNmNb5D92v7s" crossorigin="anonymous"></script>

    <link href="css/Menu.css" rel="stylesheet" />
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <asp:Button Text="Turnos" class="btnMenu btnMenu-Turnos" OnClick="Click_btnTurnosAlta" runat="server"/>
        <asp:Button Text="Pacientes" class="btnMenu btnMenu-Pacientes" OnClick="Click_btnPacientesAlta" runat="server"/>
        <asp:Button Text="Medicos" class="btnMenu btnMenu-Medicos" OnClick="Click_btnMedicosAlta" runat="server"/>
        <asp:Button Text="Especialidades" class="btnMenu btnMenu-Especialidades" OnClick="Click_btnEspecialidadesAlta" runat="server"/>
        <asp:Button Text="Pacientes" class="btnMenu btnMenu-Pacientes" OnClick="Click_btnPacientesAlta" runat="server"/>
        <asp:Button Text="Usuarios" class="btnMenu btnMenu-Usuarios" OnClick="Click_btnUsuariosAlta" runat="server"/>
        <asp:Button Text="Contactos" class="btnMenu btnMenu-Contactos" OnClick="btnContactos" runat="server"/>
        <asp:Button Text="Info" class="btnMenu btnMenu-Info" OnClick="Click_btnInformacion" runat="server"/>    
        <img class="btnMenu-Blanco1" runat="server"/> 
        <img class="btnMenu-Blanco2" runat="server"/> 
        <img class="btnMenu-Blanco3" runat="server"/> 
    </form>
</body>
</html>
