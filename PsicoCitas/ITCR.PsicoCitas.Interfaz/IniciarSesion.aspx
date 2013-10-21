<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master"
CodeBehind="IniciarSesion.aspx.cs" Inherits="ITCR.PsicoCitas.Interfaz.IniciarSesion" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <link href="bootstrap/dist/css/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="bootstrap/examples/signin/signin.css" rel="stylesheet">
    <title>Iniciar Sesi&oacute;n</title>

</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="container">
      <div class="form-signin">
        <h2 class="form-signin-heading">Inicio de Sesi&oacute;n</h2>
        <input type="text" class="form-control" placeholder="Email address" autofocus>
        <input type="password" class="form-control" placeholder="Password">
        <label class="checkbox">
          <input type="checkbox" value="remember-me">Recordarme
        </label>
        <button class="btn btn-lg btn-primary btn-block" type="submit">Iniciar Sesi&oacute;n</button>
      </div>
    </div> <!-- /container -->
</asp:Content>